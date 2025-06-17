

# MarkdownToRtf

**MarkdownToRtf** is a basic C# library that converts Markdown to RTF (Rich Text Format). It supports standard Markdown elements such as headings, bold, italic, underline, lists, and more.

## Features

- **Markdown parsing**: Converts Markdown syntax into RTF.
- **Standard elements**:
  - Headings (`# Heading 1`, `## Heading 2`, etc.)
  - Bold (`**bold**`)
  - Italic (`*italic*`)
  - Underline (`__underline__`)
  - Ordered and unordered lists (`1. Item`, `- Bullet`)
- **RTF output**: Generates a valid RTF string that can be saved to a file or rendered in controls like `RichTextBox`.


## Usage

### Basic Example

```csharp
using MarkdownToRtf;

class Program
{
    static void Main()
    {
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
        // Save to file or use in a RichTextBox
    }
}
```

### Output

Input Markdown:

```markdown
# Heading 1
This is **bold**, *italic*, and __underline__ text.

1. First item
2. Second item

- Bullet 1
- Bullet 2
```

Output RTF (simplified for readability):

```rtf
{\rtf1\ansi\deff0
\pard\sa180\fs30 \b Heading 1\b0\par
\pard\ This is \b bold \b0 , \i italic \i0 , and \ul underline \ulnone  text.\par
\pard\ 1. First item\par
\pard\ 2. Second item\par
\pard\ \bullet Bullet 1\par
\pard\ \bullet Bullet 2\par
}
```

## Requirements

- .NET 6 or higher (check the csproj)
- [Markdig](https://github.com/xoofx/markdig) (Markdown parser)

## Planned Features

- Nested lists
- Clickable links
- Images
- Block quotes
- Code blocks
- Horizontal rules
- Tables



## License

This project is licensed under the [MIT License](LICENSE).
