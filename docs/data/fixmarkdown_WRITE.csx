#r "nuget: System.Text.Encoding.CodePages, 7.0.0"

using System.Text;
using System.Text.RegularExpressions;

var root = Directory.GetCurrentDirectory();
var files = Directory.GetFiles(root, "*.md", SearchOption.AllDirectories);

var headingAndTableRegex = new Regex(@"(^#### .*)(\r\n|\n|\r)(?=\|)", RegexOptions.Multiline);

int totalHits = 0;
int filesChanged = 0;

foreach (var file in files)
{
    string original = File.ReadAllText(file);
    string fixedText = headingAndTableRegex.Replace(
        original,
        m =>
        {
            totalHits++;
            return m.Groups[1].Value + m.Groups[2].Value + "\n";
        }
    );

    if (!original.Equals(fixedText))
    {
        File.WriteAllText(file, fixedText);
        filesChanged++;
        Console.WriteLine($"✔ Fixed: {file}");
    }
}

Console.WriteLine("\n🎉 Done!");
Console.WriteLine($"📝 Files changed: {filesChanged}");
Console.WriteLine($"🔍 Total fixes applied: {totalHits}");
