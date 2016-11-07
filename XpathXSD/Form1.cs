using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using XpathXSD;

namespace XpathXSD
{
    public partial class Form1 : Form
    {
        SchemaParser sp2;
        SchemaParserToTree s2t;

        public Form1()
        {
            InitializeComponent();
            dd.Checked = true;
            verLabel.Text = typeof(Program).Assembly.GetName().Version.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             OFD.ShowDialog();

            if (File.Exists(OFD.FileName))
            {
                textBox1.Text = OFD.FileName;
                sp2 = new SchemaParser( OFD.FileName);
                s2t = new SchemaParserToTree(XMLTree, sp2);
                s2t.GetElements();
            }
        }

        private void XMLTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            ElementType info = (ElementType)XMLTree.SelectedNode.Tag;
            string txt = sp2.parseElement(info.name);

            XMLOutput.Text = txt;
            XMLtxt.Text = XMLFormat.FormatXml(info.innerXML.OuterXml);

        }

        private void dd_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            sp2.drillDown = cb.Checked;
        }
    }
}
