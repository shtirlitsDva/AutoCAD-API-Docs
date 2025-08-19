#r "nuget: System.Text.Encoding.CodePages, 7.0.0"

using System.Text;
using System.Text.RegularExpressions;

// Setup
var root = Directory.GetCurrentDirectory();
var outputHtml = "fix_preview.html";
var files = Directory.GetFiles(root, "*.md", SearchOption.AllDirectories);

// Add this at the top
int totalMatches = 0;

var results = new List<(string file, string headingLine, string fixedBlock)>();

var headingAndTableRegex = new Regex(@"(^#### .*)(\r\n|\n|\r)(?=\|)", RegexOptions.Multiline);

// HTML output setup
var sb = new StringBuilder();
sb.AppendLine("<!DOCTYPE html><html><head><meta charset='utf-8'><style>");
sb.AppendLine("table { border-collapse: collapse; width: 100%; }");
sb.AppendLine(
    "td, th { border: 1px solid #ccc; padding: 4px; font-family: monospace; white-space: pre-wrap; }"
);
sb.AppendLine("tr:nth-child(even) { background-color: #f9f9f9; }");
sb.AppendLine("</style></head><body>");
sb.AppendLine("<h2>Markdown Table Fix Preview</h2>");
sb.AppendLine("<table>");
sb.AppendLine("<tr><th>File</th><th>Heading</th><th>Suggested Fix</th></tr>");

foreach (var file in files)
{
    var text = File.ReadAllText(file);
    var matches = headingAndTableRegex.Matches(text);

    totalMatches += matches.Count;

    foreach (Match match in matches)
    {
        var heading = match.Groups[1].Value.TrimEnd();
        var newline = match.Groups[2].Value;

        var startIndex = match.Index + match.Length;
        var nextLines = GetNextLines(text, startIndex, 5);

        var fixedBlock = $"{heading}{newline}\n{nextLines}";

        results.Add((file, heading, fixedBlock));

        sb.AppendLine("<tr>");
        sb.AppendLine($"<td>{file.Replace("\\", "/")}</td>");
        sb.AppendLine($"<td>{EscapeHtml(heading)}</td>");
        sb.AppendLine($"<td><pre>{EscapeHtml(fixedBlock)}</pre></td>");
        sb.AppendLine("</tr>");
    }
}

sb.AppendLine("</table></body></html>");
File.WriteAllText(outputHtml, sb.ToString());

Console.WriteLine($"✅ Preview written to: {outputHtml}");
Console.WriteLine($"Total matches found: {totalMatches}");

// --- Helpers ---
string GetNextLines(string text, int startIndex, int maxLines)
{
    var lines = new List<string>();
    using var reader = new StringReader(text.Substring(startIndex));
    for (int i = 0; i < maxLines; i++)
    {
        var line = reader.ReadLine();
        if (line == null || string.IsNullOrWhiteSpace(line))
            break;
        lines.Add(line);
    }
    return string.Join(Environment.NewLine, lines);
}

string EscapeHtml(string input)
{
    return input.Replace("&", "&amp;").Replace("<", "&lt;").Replace(">", "&gt;");
}
