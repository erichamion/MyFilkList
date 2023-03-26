using System.Net.Http.Json;
using Microsoft.AspNetCore.Components;
using MyFilkList.Models;

namespace MyFilkList.Pages;

public partial class Song
{
    [Inject] private HttpClient Http { get; init; } = null!;

    [Parameter] public string? NavKey { get; set; }

    private SongDetail? _songDetail;

    protected override async Task OnParametersSetAsync()
    {
        var allSongs = await Http.GetFromJsonAsync<List<SongDetail>>("data/songs.json");
        _songDetail = allSongs!.SingleOrDefault(s => s.NavKey == this.NavKey);
    }
}