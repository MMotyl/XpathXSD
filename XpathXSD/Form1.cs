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
                reload_Click(sender, e);
                //sp2 = new SchemaParser( OFD.FileName);
                //s2t = new SchemaParserToTree(XMLTree, sp2);
                //sp2.drillDown = dd.Checked;
                //sp2.AddRoot = addRoot.Checked;
                //sp2.Doc = doc.Checked;
                //s2t.GetElements();
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

        private void reload_Click(object sender, EventArgs e)
        {
            sp2 = new SchemaParser(OFD.FileName);
            s2t = new SchemaParserToTree(XMLTree, sp2);
            sp2.drillDown = dd.Checked;
            sp2.AddRoot = addRoot.Checked;
            sp2.Occures = occurs_det.Checked;
            s2t.GetElements();
        }

        private void addRoot_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox ro = (CheckBox)sender;
            sp2.AddRoot = ro.Checked;
        }

        private void doc_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox docc = (CheckBox)sender;
            sp2.Doc = docc.Checked;
        }

        private void occurs_det_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox occ = (CheckBox)sender;
            sp2.Occures = occ.Checked;
        }

        private void XMLOutput_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                string txt = XMLOutput.Text.ToString();
                Clipboard.SetText(txt);
            }
            catch (Exception ex) { }
        }
    }
}
