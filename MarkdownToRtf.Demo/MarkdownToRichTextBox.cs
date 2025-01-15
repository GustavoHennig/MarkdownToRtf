namespace MarkdownToRtf.Demo
{
    public partial class MarkdownToRichTextBox : Form
    {
        public MarkdownToRichTextBox()
        {
            InitializeComponent();
        }

        private void textBoxMarkdown_TextChanged(object sender, EventArgs e)
        {
            string rtf = MarkdownToRtfConverter.Convert(textBoxMarkdown.Text);

            richTextBoxPreview.Rtf = rtf;
        }

        private void MarkdownToRichTextBox_Load(object sender, EventArgs e)
        {
            try
            {
                textBoxMarkdown.Text = File.ReadAllText("MarkdownSyntax.md");
            }
            catch (Exception)
            {
                // just ignore
            }
        }
    }
}
