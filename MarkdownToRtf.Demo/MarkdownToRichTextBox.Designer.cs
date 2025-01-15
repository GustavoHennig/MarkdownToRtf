namespace MarkdownToRtf.Demo
{
    partial class MarkdownToRichTextBox
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
            this.splitContainer1 = new SplitContainer();
            this.textBoxMarkdown = new TextBox();
            this.richTextBoxPreview = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)this.splitContainer1).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = DockStyle.Fill;
            this.splitContainer1.Location = new Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.textBoxMarkdown);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.richTextBoxPreview);
            this.splitContainer1.Size = new Size(1306, 770);
            this.splitContainer1.SplitterDistance = 591;
            this.splitContainer1.TabIndex = 0;
            // 
            // textBoxMarkdown
            // 
            this.textBoxMarkdown.Dock = DockStyle.Fill;
            this.textBoxMarkdown.Location = new Point(0, 0);
            this.textBoxMarkdown.MaxLength = 327673;
            this.textBoxMarkdown.Multiline = true;
            this.textBoxMarkdown.Name = "textBoxMarkdown";
            this.textBoxMarkdown.Size = new Size(591, 770);
            this.textBoxMarkdown.TabIndex = 0;
            this.textBoxMarkdown.TextChanged += this.textBoxMarkdown_TextChanged;
            // 
            // richTextBoxPreview
            // 
            this.richTextBoxPreview.BulletIndent = 1;
            this.richTextBoxPreview.Dock = DockStyle.Fill;
            this.richTextBoxPreview.Location = new Point(0, 0);
            this.richTextBoxPreview.Margin = new Padding(15);
            this.richTextBoxPreview.Name = "richTextBoxPreview";
            this.richTextBoxPreview.ReadOnly = true;
            this.richTextBoxPreview.Size = new Size(711, 770);
            this.richTextBoxPreview.TabIndex = 0;
            this.richTextBoxPreview.Text = "";
            // 
            // MarkdownToRichTextBox
            // 
            this.AutoScaleDimensions = new SizeF(144F, 144F);
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.ClientSize = new Size(1306, 770);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MarkdownToRichTextBox";
            this.Text = "Markdown to RichTextBox demo";
            this.Load += this.MarkdownToRichTextBox_Load;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.splitContainer1).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private TextBox textBoxMarkdown;
        private RichTextBox richTextBoxPreview;
    }
}
