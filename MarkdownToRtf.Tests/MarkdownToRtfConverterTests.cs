using System;
using Xunit;                  // xUnit attributes
using MarkdownToRtf;         // Namespace of your MarkdownToRtfConverter

namespace MarkdownToRtf.Tests
{
    public class MarkdownToRtfConverterTests
    {
        [Fact]
        public void Convert_Heading1_IncludesRtfHeading()
        {
            // Arrange
            string markdown = "# Heading 1";

            // Act
            string rtf = MarkdownToRtfConverter.Convert(markdown);

            // Assert
            // Check the heading font size token (\fs32) and bold (\b ... \b0)
            Assert.Contains(@"\fs30", rtf);
            Assert.Contains(@"\b Heading 1\b0", rtf);
        }

        [Fact]
        public void Convert_Bold_IncludesRtfBold()
        {
            // Arrange
            string markdown = "This is **bold** text.";

            // Act
            string rtf = MarkdownToRtfConverter.Convert(markdown);

            // Assert
            // Should see \b "bold" \b0 somewhere
            Assert.Contains(@"\b bold \b0", rtf);
        }

        [Fact]
        public void Convert_Italic_IncludesRtfItalic()
        {
            // Arrange
            string markdown = "This is *italic* text.";

            // Act
            string rtf = MarkdownToRtfConverter.Convert(markdown);

            // Assert
            // Should see \i "italic" \i0
            Assert.Contains(@"\i italic \i0", rtf);
        }

        [Fact]
        public void Convert_Underline_IncludesRtfUnderline()
        {
            // Arrange
            string markdown = "This is __underline__ text.";

            // Act
            string rtf = MarkdownToRtfConverter.Convert(markdown);

            // Assert
            // Should see \ul "underline" \ulnone
            Assert.Contains(@"\ul underline \ulnone", rtf);
        }

        [Fact]
        public void Convert_OrderedList_ContainsNumbers()
        {
            // Arrange
            // By default, our code inserts "listItemBlock.Order + '. '"
            // So we expect "1. " and "2. "
            string markdown = 
@"1. Item1
2. Item2";

            // Act
            string rtf = MarkdownToRtfConverter.Convert(markdown);

            // Assert
            Assert.Contains("1. Item1", rtf);
            Assert.Contains("2. Item2", rtf);
        }

        [Fact]
        public void Convert_UnorderedList_ContainsBullet()
        {
            // Arrange
            // By default, our code inserts "\bullet " for unordered lists
            string markdown = 
@"- Bullet1
- Bullet2";

            // Act
            string rtf = MarkdownToRtfConverter.Convert(markdown);

            // Assert
            Assert.Contains(@"\bullet Bullet1", rtf);
            Assert.Contains(@"\bullet Bullet2", rtf);
        }

        [Fact]
        public void Convert_MixedStyles_CombinationWorks()
        {
            // Arrange
            // Mix bold and italic in the same line
            string markdown = "Here is **bold** and also *italic* in one line";

            // Act
            string rtf = MarkdownToRtfConverter.Convert(markdown);

            // Assert
            Assert.Contains(@"\b bold \b0", rtf);
            Assert.Contains(@"\i italic \i0", rtf);
        }

        [Fact]
        public void Convert_EscapingSpecialCharacters()
        {
            // Arrange
            // Curly braces and backslashes are special in RTF
            string markdown = @"Special chars: \ { }";

            // Act
            string rtf = MarkdownToRtfConverter.Convert(markdown);

            // Assert
            // The converter should escape them (\\, \{, \})
            Assert.Contains(@"Special chars: \\ \{ \}", rtf);
        }

        [Fact]
        public void Convert_HorizontalRule_IncludesRtfBorder()
        {
            // Arrange
            string markdown = "---";

            // Act
            string rtf = MarkdownToRtfConverter.Convert(markdown);

            // Assert

            Assert.Contains(@"\brdrb", rtf);
        }
  
          [Fact]
        public void Convert_CodeInline_UsesMonospaceFont()
        {
            // Arrange
            string markdown = "Example with `code` inline.";

            // Act
            string rtf = MarkdownToRtfConverter.Convert(markdown);

            // Assert

            Assert.Contains(@"\f1 code\f0", rtf);
        }

        [Fact]
        public void Convert_Link_IncludesUnderline()
        {
            // Arrange
            string markdown = "See [link](https://example.com) here.";

            // Act
            string rtf = MarkdownToRtfConverter.Convert(markdown);

            // Assert
            Assert.Contains(@"\ul https://example.com\ulnone", rtf);
        }

        [Fact]
        public void Convert_LineBreak_AddsRtfLine()
        {
            // Arrange - two spaces before newline forces a line break
            string markdown = "Line1  \nLine2";

            // Act
            string rtf = MarkdownToRtfConverter.Convert(markdown);

            // Assert
            Assert.Contains(@"\line", rtf);
        }

        [Fact]
        public void Convert_Heading2_UsesSmallerFont()
        {
            // Arrange
            string markdown = "## Second Level";

            // Act
            string rtf = MarkdownToRtfConverter.Convert(markdown);

            // Assert - heading level 2 maps to \fs28
            Assert.Contains(@"\fs28", rtf);

        }

        [Fact]
        public void Convert_BlockQuote_AddsIndent()
        {
            // Arrange
            string markdown = "> quoted";

            // Act
            string rtf = MarkdownToRtfConverter.Convert(markdown);

            // Assert
            Assert.Contains(@"\li300", rtf);
            Assert.Contains("quoted", rtf);
        }
    }
}
