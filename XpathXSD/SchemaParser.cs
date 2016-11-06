using System;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Collections;

namespace XpathXSD
{
    class ElementType
    {
        public string name = "";
        public string XPath = "";
        public string TreePath = "";
        public bool IsArray = false;
        public XmlNode innerXML;
        public elementTypes Type ;
        public TreeNode treeNode = null;
    }

    class SchemaParserToTree
    {
        TreeView tree;
        public SchemaParser parser;

        public SchemaParserToTree(TreeView tree, SchemaParser parser)
        {
            this.parser = parser;
            this.tree = tree;

            this.tree.Nodes.Clear();
        }

        public void GetElements()
        {
            tree.Nodes.Clear();
            if (parser == null) return;
            foreach (ElementType ct in parser.elementList)
            {
                TreeNode tn = new TreeNode(ct.name);
                tree.Nodes.Add(tn);
                tn.Tag = ct; // ElementType info = (ElementType)node.Tag;
                ct.treeNode = tn;
            }
        }
    }

    public enum elementTypes {ComplexType, SimpleType};

    static class XMLFormat
    {
        public static string FormatXml(string xml)
        {
            try
            {
                var doc = XDocument.Parse(xml);
                return doc.ToString();
            }
            catch (Exception)
            {
                return xml;
            }
        }
    }


    class SchemaParser
    {
        private struct ReqRec
          {
            public string name;
            public int level;
            public ReqRec(string name, int level)
            {
                this.name = name;
                this.level = level;
            }
          }

        private bool isReq(ArrayList lista, string nazwa, int level)
        {
            bool res=false;
            foreach (ReqRec element in lista)
            {
                if (element.name == nazwa && element.level < level)
                {
                    res = true;
                    break;
                }

            }

            return res;
        }

        string file;
        XmlDocument XmlDoc = new XmlDocument();

        NameTable nt = new NameTable();
        XmlNamespaceManager NameSpace;
        XmlNode root;
        bool _drillDown;

 
        public List<ElementType> elementList = new List<ElementType>();

        public SchemaParser(string FileName)
        {

            NameSpace =  new XmlNamespaceManager(nt);
            NameSpace.AddNamespace("xs", "http://www.w3.org/2001/XMLSchema");

            file = FileName;
            try
            {
                XmlDoc.Load(file);
                root = XmlDoc.DocumentElement;
                drillDown = true;

                GetComplexTypes(@"/xs:schema/xs:complexType", elementTypes.ComplexType);
                //GetComplexTypes(@"/xs:schema/xs:simpleType", elementTypes.SimpleType);
            }

            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public bool drillDown
        {
            get
            { return _drillDown;  }
            set
            { _drillDown = value; }
        }


        public string parseElement(string Name)
        {
            ElementType element = null;
            element = elementList.Find(x => x.name == Name);

            if (element == null)
            {
                string error = String.Format("Nie znaleziono elementu {0}", Name);
                throw new Exception(error);
            }
            return parseElement(element);

        }

        public string parseElement(ElementType element)
        {
            ArrayList rek = new ArrayList();

            string res = Parse(element.innerXML, 0, rek);
            return res;
        }

        /// <summary>
        /// Główna funkcja parsująca
        /// </summary>
        /// <param name="node">XML zawierający kod elementu</param>
        /// <param name="startPath">do wiązania z inymi typami złożonymi</param>
        /// <returns></returns>
        private string Parse(XmlNode node, int level, ArrayList rekurencja)
        {
            string result = "";

            string name;
            string sub;
            string multi;
            string prefix;
            ElementType typZlozony;

            if (level == 0)
            {
                rekurencja.Clear();
                rekurencja.Add( new ReqRec( getType(node, "name"), level));
            }

            foreach (XmlNode element in node.ChildNodes)
            {
                typZlozony = null;
                name = getType(element, "name");
                Console.WriteLine(name);
                if (name != "")
                {
                    multi = getType(element, "maxOccurs");
                    if (multi == "unbounded")
                    {
                        name += "[]";
                    }

                    result += "/" + name;
                    typZlozony = IsComplexType(element);
                    // if ((typZlozony != null) && (rekurencja.IndexOf(typZlozony.name) == -1))
                    if ((typZlozony != null) && !isReq(rekurencja, typZlozony.name, level))
                    {

                        if (typZlozony.name != "") //czasami się zdarzają. a nie powinny...
                        {
                            rekurencja.Add(new ReqRec(typZlozony.name, level));
                            Console.WriteLine("add req name:{0} leve{1}", typZlozony.name, level);
                        }
                        if (drillDown)
                        {

                            sub = Parse(typZlozony.innerXML, ++level, rekurencja);
                            Console.WriteLine("SUBName " + name);
                            Console.WriteLine("Sub contet " + sub);
                            if (name != "" && !name.StartsWith("/"))
                            {
                                name = "/" + name;
                            }

                            prefix = addPrefix(sub, name);
                            result += Environment.NewLine + prefix;
                        }
                        else
                        {
                            result += "[type: " + typZlozony.name + " ]";
                        }


                    }
                    else
                    {
                        //if ((typZlozony != null) && (rekurencja.IndexOf(typZlozony.name) != -1))
                        if ((typZlozony != null) && isReq(rekurencja, typZlozony.name, level))
                        {
                            result += "[rekurencja! type: " + typZlozony.name + " ]";
                        }
                    }


                    result += Environment.NewLine;
                }
                    if (element.HasChildNodes)
                    {
                        if (getType(node, "xs:annotation") == "")
                        {
                            sub = Parse(element, level, rekurencja); 
                            if (sub != "") 
                            {
                            if (name != "" && !name.StartsWith("/"))
                            {
                                name = "/"+name;
                            }

                                prefix = addPrefix(sub, name);
                                if (!prefix.StartsWith("/"))
                                {
                                    prefix += "/";
                                }
                                result += prefix; 
                            }
                        }
                    }
                }
            

            return result;
        }

        private string addPrefix(string input, string prefix)
        {
            // StringBuilder sb = new StringBuilder(input);
            string[] sep = { "\r\n",  };
            string result = "";
            Console.WriteLine(prefix);
            if (prefix != "")
            {
                foreach (string line in input.Split(sep, StringSplitOptions.RemoveEmptyEntries))
                {
                    if (line != "")
                    {
                        result = result + prefix + line + Environment.NewLine;
                    }
                }
            }
            else
                result = input;

            return result;
        }

        private ElementType IsComplexType(XmlNode node)
        {
            ElementType element = null;
            string Name = getType(node, "type");
            element = elementList.Find(x => ((x.name == Name) &&(x.Type ==elementTypes.ComplexType )));

            return element; //jeśli uda się znaleźć - należy użyć elementu do kolejnego wyszukania.
        }

        private string getType(XmlNode node, string type)
        {
            string res = "";
            try
            {
                res = node.Attributes.GetNamedItem(type).Value;
            }
            catch(NullReferenceException e)
            {
                Console.WriteLine("no element @" + type);
            }
            return res;
        }

        private void GetComplexTypes(string XPath, elementTypes Type)
        {
         
            XmlNodeList nl = root.SelectNodes(XPath, NameSpace);
            foreach (XmlNode element in nl)
            {
                ElementType ct = new ElementType();
                ct.name = element.Attributes.GetNamedItem("name").Value;
                ct.innerXML = element; //new XmlElement("element", element.InnerXml);
                ct.Type = Type;
                ct.XPath = XPath;

                elementList.Add(ct);

            }
        }

    }
}
