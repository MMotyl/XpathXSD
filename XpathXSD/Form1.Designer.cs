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
            this.reload = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.XMLTree = new System.Windows.Forms.TreeView();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.dd = new System.Windows.Forms.CheckBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.verLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.XMLOutput = new System.Windows.Forms.TextBox();
            this.XMLtxt = new System.Windows.Forms.TextBox();
            this.addRoot = new System.Windows.Forms.CheckBox();
            this.doc = new System.Windows.Forms.CheckBox();
            this.occurs_det = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(39, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(763, 22);
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
            this.panel1.Controls.Add(this.reload);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1021, 46);
            this.panel1.TabIndex = 3;
            // 
            // reload
            // 
            this.reload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.reload.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.reload.Location = new System.Drawing.Point(906, 5);
            this.reload.Name = "reload";
            this.reload.Size = new System.Drawing.Size(108, 33);
            this.reload.TabIndex = 4;
            this.reload.Text = "reload";
            this.reload.UseVisualStyleBackColor = true;
            this.reload.Click += new System.EventHandler(this.reload_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(808, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "plik";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // XMLTree
            // 
            this.XMLTree.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.XMLTree.Location = new System.Drawing.Point(12, 127);
            this.XMLTree.Name = "XMLTree";
            this.XMLTree.Size = new System.Drawing.Size(297, 415);
            this.XMLTree.TabIndex = 4;
            this.XMLTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.XMLTree_AfterSelect);
            // 
            // OFD
            // 
            this.OFD.DefaultExt = "xsd";
            this.OFD.InitialDirectory = "C:\\Users\\marci\\Desktop\\Praca\\XSD";
            this.OFD.Title = "Wskaż XSD";
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
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.verLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 545);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1038, 25);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ActiveLinkColor = System.Drawing.Color.YellowGreen;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(68, 20);
            this.toolStripStatusLabel1.Text = "Butter\'16";
            // 
            // verLabel
            // 
            this.verLabel.Name = "verLabel";
            this.verLabel.Size = new System.Drawing.Size(29, 20);
            this.verLabel.Text = "ver";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(315, 64);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.XMLOutput);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.XMLtxt);
            this.splitContainer1.Size = new System.Drawing.Size(718, 478);
            this.splitContainer1.SplitterDistance = 300;
            this.splitContainer1.TabIndex = 9;
            // 
            // XMLOutput
            // 
            this.XMLOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.XMLOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.XMLOutput.Cursor = System.Windows.Forms.Cursors.No;
            this.XMLOutput.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.XMLOutput.Location = new System.Drawing.Point(3, 3);
            this.XMLOutput.Multiline = true;
            this.XMLOutput.Name = "XMLOutput";
            this.XMLOutput.ReadOnly = true;
            this.XMLOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.XMLOutput.Size = new System.Drawing.Size(712, 294);
            this.XMLOutput.TabIndex = 6;
            this.XMLOutput.DoubleClick += new System.EventHandler(this.XMLOutput_DoubleClick);
            // 
            // XMLtxt
            // 
            this.XMLtxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.XMLtxt.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.XMLtxt.Location = new System.Drawing.Point(0, 3);
            this.XMLtxt.Multiline = true;
            this.XMLtxt.Name = "XMLtxt";
            this.XMLtxt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.XMLtxt.Size = new System.Drawing.Size(718, 168);
            this.XMLtxt.TabIndex = 7;
            // 
            // addRoot
            // 
            this.addRoot.AutoSize = true;
            this.addRoot.Checked = true;
            this.addRoot.CheckState = System.Windows.Forms.CheckState.Checked;
            this.addRoot.Location = new System.Drawing.Point(12, 96);
            this.addRoot.Name = "addRoot";
            this.addRoot.Size = new System.Drawing.Size(84, 21);
            this.addRoot.TabIndex = 10;
            this.addRoot.Text = global::XpathXSD.Properties.Settings.Default.AddRoot;
            this.addRoot.UseVisualStyleBackColor = true;
            this.addRoot.CheckedChanged += new System.EventHandler(this.addRoot_CheckedChanged);
            // 
            // doc
            // 
            this.doc.AutoSize = true;
            this.doc.Checked = true;
            this.doc.CheckState = System.Windows.Forms.CheckState.Checked;
            this.doc.Location = new System.Drawing.Point(129, 69);
            this.doc.Name = "doc";
            this.doc.Size = new System.Drawing.Size(55, 21);
            this.doc.TabIndex = 11;
            this.doc.Text = "Doc";
            this.doc.UseVisualStyleBackColor = true;
            this.doc.CheckedChanged += new System.EventHandler(this.doc_CheckedChanged);
            // 
            // occurs_det
            // 
            this.occurs_det.AutoSize = true;
            this.occurs_det.Checked = true;
            this.occurs_det.CheckState = System.Windows.Forms.CheckState.Checked;
            this.occurs_det.Location = new System.Drawing.Point(129, 96);
            this.occurs_det.Name = "occurs_det";
            this.occurs_det.Size = new System.Drawing.Size(87, 21);
            this.occurs_det.TabIndex = 12;
            this.occurs_det.Text = "krotności";
            this.occurs_det.UseVisualStyleBackColor = true;
            this.occurs_det.CheckedChanged += new System.EventHandler(this.occurs_det_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 570);
            this.Controls.Add(this.occurs_det);
            this.Controls.Add(this.doc);
            this.Controls.Add(this.addRoot);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dd);
            this.Controls.Add(this.XMLTree);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "XPath generator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView XMLTree;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog OFD;
        private System.Windows.Forms.CheckBox dd;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel verLabel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox XMLOutput;
        private System.Windows.Forms.TextBox XMLtxt;
        private System.Windows.Forms.CheckBox addRoot;
        private System.Windows.Forms.Button reload;
        private System.Windows.Forms.CheckBox doc;
        private System.Windows.Forms.CheckBox occurs_det;
    }
}

