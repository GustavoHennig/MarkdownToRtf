namespace MarkdownToRtf.Demo
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            string markdown = @"
# Heading 1
This is **bold**, *italic*, and __underline__ text.

1. First item
2. Second item

- Bullet 1
- Bullet 2
";

            string rtf = MarkdownToRtfConverter.Convert(markdown);

            Console.WriteLine(rtf);

            ApplicationConfiguration.Initialize();
            Application.Run(new MarkdownToRichTextBox());
        }
    }
}