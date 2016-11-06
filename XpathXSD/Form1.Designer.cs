namespace XpathXSD
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.XMLTree = new System.Windows.Forms.TreeView();
            this.XMLOutput = new System.Windows.Forms.TextBox();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.XMLtxt = new System.Windows.Forms.TextBox();
            this.dd = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(39, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(872, 22);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Plik";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(999, 46);
            this.panel1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(917, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "plik";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // XMLTree
            // 
            this.XMLTree.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.XMLTree.Location = new System.Drawing.Point(12, 102);
            this.XMLTree.Name = "XMLTree";
            this.XMLTree.Size = new System.Drawing.Size(297, 456);
            this.XMLTree.TabIndex = 4;
            this.XMLTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.XMLTree_AfterSelect);
            // 
            // XMLOutput
            // 
            this.XMLOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.XMLOutput.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.XMLOutput.Location = new System.Drawing.Point(315, 64);
            this.XMLOutput.Multiline = true;
            this.XMLOutput.Name = "XMLOutput";
            this.XMLOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.XMLOutput.Size = new System.Drawing.Size(689, 303);
            this.XMLOutput.TabIndex = 5;
            // 
            // OFD
            // 
            this.OFD.DefaultExt = "xsd";
            this.OFD.InitialDirectory = "C:\\Users\\marci\\Desktop\\Praca\\XSD";
            this.OFD.Title = "Wskaż XSD";
            // 
            // XMLtxt
            // 
            this.XMLtxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.XMLtxt.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.XMLtxt.Location = new System.Drawing.Point(315, 373);
            this.XMLtxt.Multiline = true;
            this.XMLtxt.Name = "XMLtxt";
            this.XMLtxt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.XMLtxt.Size = new System.Drawing.Size(689, 185);
            this.XMLtxt.TabIndex = 6;
            // 
            // dd
            // 
            this.dd.AutoSize = true;
            this.dd.Checked = true;
            this.dd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.dd.Location = new System.Drawing.Point(12, 69);
            this.dd.Name = "dd";
            this.dd.Size = new System.Drawing.Size(89, 21);
            this.dd.TabIndex = 7;
            this.dd.Text = "DrillDown";
            this.dd.UseVisualStyleBackColor = true;
            this.dd.CheckedChanged += new System.EventHandler(this.dd_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 570);
            this.Controls.Add(this.dd);
            this.Controls.Add(this.XMLtxt);
            this.Controls.Add(this.XMLOutput);
            this.Controls.Add(this.XMLTree);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "XPath generator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView XMLTree;
        private System.Windows.Forms.TextBox XMLOutput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog OFD;
        private System.Windows.Forms.TextBox XMLtxt;
        private System.Windows.Forms.CheckBox dd;
    }
}

