
namespace PipelineTextTransformer
{
    partial class EditForm
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
            this.txtPreviewSoure = new System.Windows.Forms.TextBox();
            this.txtPreviewResult = new System.Windows.Forms.TextBox();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.lblTransformertype = new System.Windows.Forms.Label();
            this.btnArrowUp = new System.Windows.Forms.Button();
            this.btnArrowDown = new System.Windows.Forms.Button();
            this.btnAddTransformer = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeleteTransformer = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPaste = new System.Windows.Forms.Button();
            this.btnCopySelected = new System.Windows.Forms.Button();
            this.lstNewType = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSourcePath = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPreviewSoure
            // 
            this.txtPreviewSoure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPreviewSoure.Location = new System.Drawing.Point(0, 15);
            this.txtPreviewSoure.Margin = new System.Windows.Forms.Padding(1);
            this.txtPreviewSoure.Multiline = true;
            this.txtPreviewSoure.Name = "txtPreviewSoure";
            this.txtPreviewSoure.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPreviewSoure.Size = new System.Drawing.Size(1090, 144);
            this.txtPreviewSoure.TabIndex = 0;
            this.txtPreviewSoure.TextChanged += new System.EventHandler(this.txtPreviewSoure_TextChanged);
            // 
            // txtPreviewResult
            // 
            this.txtPreviewResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPreviewResult.Location = new System.Drawing.Point(0, 15);
            this.txtPreviewResult.Margin = new System.Windows.Forms.Padding(1);
            this.txtPreviewResult.Multiline = true;
            this.txtPreviewResult.Name = "txtPreviewResult";
            this.txtPreviewResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPreviewResult.Size = new System.Drawing.Size(1090, 142);
            this.txtPreviewResult.TabIndex = 0;
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.HelpVisible = false;
            this.propertyGrid1.Location = new System.Drawing.Point(4, 35);
            this.propertyGrid1.Margin = new System.Windows.Forms.Padding(1);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(270, 176);
            this.propertyGrid1.TabIndex = 2;
            this.propertyGrid1.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.propertyGrid1_PropertyValueChanged);
            // 
            // lblTransformertype
            // 
            this.lblTransformertype.AutoSize = true;
            this.lblTransformertype.Location = new System.Drawing.Point(4, 19);
            this.lblTransformertype.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblTransformertype.Name = "lblTransformertype";
            this.lblTransformertype.Size = new System.Drawing.Size(82, 15);
            this.lblTransformertype.TabIndex = 3;
            this.lblTransformertype.Text = "None selected";
            this.lblTransformertype.Click += new System.EventHandler(this.lblTransformertype_Click);
            // 
            // btnArrowUp
            // 
            this.btnArrowUp.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnArrowUp.Location = new System.Drawing.Point(238, 27);
            this.btnArrowUp.Margin = new System.Windows.Forms.Padding(1);
            this.btnArrowUp.Name = "btnArrowUp";
            this.btnArrowUp.Size = new System.Drawing.Size(22, 35);
            this.btnArrowUp.TabIndex = 4;
            this.btnArrowUp.Text = "up";
            this.btnArrowUp.UseVisualStyleBackColor = true;
            this.btnArrowUp.Click += new System.EventHandler(this.btnArrowUp_Click);
            // 
            // btnArrowDown
            // 
            this.btnArrowDown.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnArrowDown.Location = new System.Drawing.Point(238, 64);
            this.btnArrowDown.Margin = new System.Windows.Forms.Padding(1);
            this.btnArrowDown.Name = "btnArrowDown";
            this.btnArrowDown.Size = new System.Drawing.Size(22, 35);
            this.btnArrowDown.TabIndex = 4;
            this.btnArrowDown.Text = "dn";
            this.btnArrowDown.UseVisualStyleBackColor = true;
            this.btnArrowDown.Click += new System.EventHandler(this.btnArrowDown_Click);
            // 
            // btnAddTransformer
            // 
            this.btnAddTransformer.Location = new System.Drawing.Point(187, 27);
            this.btnAddTransformer.Margin = new System.Windows.Forms.Padding(1);
            this.btnAddTransformer.Name = "btnAddTransformer";
            this.btnAddTransformer.Size = new System.Drawing.Size(107, 21);
            this.btnAddTransformer.TabIndex = 6;
            this.btnAddTransformer.Text = "Add Transformer";
            this.btnAddTransformer.UseVisualStyleBackColor = true;
            this.btnAddTransformer.Click += new System.EventHandler(this.btnAddTransformer_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(238, 94);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(1);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(45, 117);
            this.trackBar1.TabIndex = 7;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(2, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1090, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHelpToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // viewHelpToolStripMenuItem
            // 
            this.viewHelpToolStripMenuItem.Name = "viewHelpToolStripMenuItem";
            this.viewHelpToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.viewHelpToolStripMenuItem.Text = "View Help";
            this.viewHelpToolStripMenuItem.Click += new System.EventHandler(this.viewHelpToolStripMenuItem_Click);
            // 
            // btnDeleteTransformer
            // 
            this.btnDeleteTransformer.Location = new System.Drawing.Point(187, 50);
            this.btnDeleteTransformer.Margin = new System.Windows.Forms.Padding(1);
            this.btnDeleteTransformer.Name = "btnDeleteTransformer";
            this.btnDeleteTransformer.Size = new System.Drawing.Size(107, 21);
            this.btnDeleteTransformer.TabIndex = 10;
            this.btnDeleteTransformer.Text = "Delete selected";
            this.btnDeleteTransformer.UseVisualStyleBackColor = true;
            this.btnDeleteTransformer.Click += new System.EventHandler(this.btnDeleteTransformer_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPaste);
            this.groupBox1.Controls.Add(this.btnCopySelected);
            this.groupBox1.Controls.Add(this.lstNewType);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btnAddTransformer);
            this.groupBox1.Controls.Add(this.btnDeleteTransformer);
            this.groupBox1.Location = new System.Drawing.Point(10, 28);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox1.Size = new System.Drawing.Size(296, 215);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit transformers";
            // 
            // btnPaste
            // 
            this.btnPaste.Location = new System.Drawing.Point(187, 120);
            this.btnPaste.Margin = new System.Windows.Forms.Padding(1);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(107, 21);
            this.btnPaste.TabIndex = 21;
            this.btnPaste.Text = "Paste";
            this.btnPaste.UseVisualStyleBackColor = true;
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // btnCopySelected
            // 
            this.btnCopySelected.Location = new System.Drawing.Point(187, 97);
            this.btnCopySelected.Margin = new System.Windows.Forms.Padding(1);
            this.btnCopySelected.Name = "btnCopySelected";
            this.btnCopySelected.Size = new System.Drawing.Size(107, 21);
            this.btnCopySelected.TabIndex = 21;
            this.btnCopySelected.Text = "Copy";
            this.btnCopySelected.UseVisualStyleBackColor = true;
            this.btnCopySelected.Click += new System.EventHandler(this.btnCopySelected_Click);
            // 
            // lstNewType
            // 
            this.lstNewType.FormattingEnabled = true;
            this.lstNewType.ItemHeight = 15;
            this.lstNewType.Location = new System.Drawing.Point(12, 27);
            this.lstNewType.Margin = new System.Windows.Forms.Padding(1);
            this.lstNewType.Name = "lstNewType";
            this.lstNewType.Size = new System.Drawing.Size(169, 184);
            this.lstNewType.TabIndex = 16;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(187, 74);
            this.button2.Margin = new System.Windows.Forms.Padding(1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 21);
            this.button2.TabIndex = 6;
            this.button2.Text = "Add as child";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnAddAsChild_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(5, 42);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(1);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(77, 19);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Wrap text";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 284);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 15;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.txtSourcePath);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 261);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox2.Size = new System.Drawing.Size(1090, 62);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data source";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Load text from file";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSourcePath
            // 
            this.txtSourcePath.Enabled = false;
            this.txtSourcePath.Location = new System.Drawing.Point(150, 17);
            this.txtSourcePath.Name = "txtSourcePath";
            this.txtSourcePath.Size = new System.Drawing.Size(926, 23);
            this.txtSourcePath.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 643);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1090, 22);
            this.statusStrip1.TabIndex = 18;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel1.Text = "Ready";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1090, 261);
            this.panel1.TabIndex = 19;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(954, 67);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(1);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(77, 21);
            this.btnRefresh.TabIndex = 16;
            this.btnRefresh.Text = "button3";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.treeView1);
            this.groupBox4.Controls.Add(this.btnArrowUp);
            this.groupBox4.Controls.Add(this.btnArrowDown);
            this.groupBox4.Controls.Add(this.trackBar1);
            this.groupBox4.Location = new System.Drawing.Point(310, 28);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(288, 215);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Transformer list";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(310, 0);
            this.button3.Margin = new System.Windows.Forms.Padding(1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(188, 58);
            this.button3.TabIndex = 22;
            this.button3.Text = "TestData";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // treeView1
            // 
            this.treeView1.HideSelection = false;
            this.treeView1.Location = new System.Drawing.Point(5, 27);
            this.treeView1.Margin = new System.Windows.Forms.Padding(1);
            this.treeView1.Name = "treeView1";
            this.treeView1.ShowPlusMinus = false;
            this.treeView1.Size = new System.Drawing.Size(233, 187);
            this.treeView1.TabIndex = 16;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblTransformertype);
            this.groupBox3.Controls.Add(this.propertyGrid1);
            this.groupBox3.Location = new System.Drawing.Point(604, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(278, 215);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Transformer properties";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 323);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtPreviewSoure);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtPreviewResult);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(1090, 320);
            this.splitContainer1.SplitterDistance = 159;
            this.splitContainer1.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Input:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Output:";
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 665);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "EditForm";
            this.Text = "Text transformer";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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

        private System.Windows.Forms.TextBox txtPreviewSoure;
        private System.Windows.Forms.TextBox txtPreviewResult;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.Label lblTransformertype;
        private System.Windows.Forms.Button btnArrowUp;
        private System.Windows.Forms.Button btnArrowDown;
        private System.Windows.Forms.Button btnAddTransformer;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.Button btnDeleteTransformer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewHelpToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSourcePath;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ListBox lstNewType;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnPaste;
        private System.Windows.Forms.Button btnCopySelected;
        private System.Windows.Forms.Button button3;
    }
}