using System.Text.RegularExpressions;

namespace MyFilkList.Models;

public class SongDetail
{
    public string NavKey => Uri.EscapeDataString(Regex.Replace(Title, @"['""().[\]?]", "-").Replace(' ', '-'));

    public string Title { get; set; } = null!;
    public Uri? GoogleEmbedUrl { get; set; }
    public IReadOnlyList<LinkDescription>? Links { get; set; }
}