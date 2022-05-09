
namespace PipelineTextTransformer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.txtPreviewSource = new System.Windows.Forms.TextBox();
            this.txtPreviewResult = new System.Windows.Forms.TextBox();
            this.lstTransformers = new System.Windows.Forms.ListBox();
            this.btnEditWindow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 44);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(564, 174);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Location = new System.Drawing.Point(1387, 44);
            this.propertyGrid1.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(676, 646);
            this.propertyGrid1.TabIndex = 1;
            // 
            // txtPreviewSource
            // 
            this.txtPreviewSource.Location = new System.Drawing.Point(45, 701);
            this.txtPreviewSource.Multiline = true;
            this.txtPreviewSource.Name = "txtPreviewSource";
            this.txtPreviewSource.Size = new System.Drawing.Size(749, 372);
            this.txtPreviewSource.TabIndex = 4;
            this.txtPreviewSource.Text = "Dette er en test text som brukes undr testing.";
            // 
            // txtPreviewResult
            // 
            this.txtPreviewResult.Location = new System.Drawing.Point(1383, 701);
            this.txtPreviewResult.Multiline = true;
            this.txtPreviewResult.Name = "txtPreviewResult";
            this.txtPreviewResult.Size = new System.Drawing.Size(689, 372);
            this.txtPreviewResult.TabIndex = 4;
            // 
            // lstTransformers
            // 
            this.lstTransformers.FormattingEnabled = true;
            this.lstTransformers.ItemHeight = 41;
            this.lstTransformers.Items.AddRange(new object[] {
            "rdthf",
            "udyftre",
            "yutr",
            "hjgfdf",
            "utyr",
            "jhgf"});
            this.lstTransformers.Location = new System.Drawing.Point(800, 44);
            this.lstTransformers.Name = "lstTransformers";
            this.lstTransformers.Size = new System.Drawing.Size(577, 1029);
            this.lstTransformers.TabIndex = 6;
            // 
            // btnEditWindow
            // 
            this.btnEditWindow.Location = new System.Drawing.Point(150, 279);
            this.btnEditWindow.Name = "btnEditWindow";
            this.btnEditWindow.Size = new System.Drawing.Size(386, 58);
            this.btnEditWindow.TabIndex = 7;
            this.btnEditWindow.Text = "Edit Transformers";
            this.btnEditWindow.UseVisualStyleBackColor = true;
            this.btnEditWindow.Click += new System.EventHandler(this.btnEditWindow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2157, 1134);
            this.Controls.Add(this.btnEditWindow);
            this.Controls.Add(this.lstTransformers);
            this.Controls.Add(this.txtPreviewResult);
            this.Controls.Add(this.txtPreviewSource);
            this.Controls.Add(this.propertyGrid1);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.TextBox txtPreviewSource;
        private System.Windows.Forms.TextBox txtPreviewResult;
        private System.Windows.Forms.ListBox lstTransformers;
        private System.Windows.Forms.Button btnEditWindow;
    }
}

