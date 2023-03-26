using System.Net;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Components;
using MyFilkList.Models;


namespace MyFilkList.Shared;

public partial class NavMenu
{
    
    private bool collapseNavMenu = true;

    private string? NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }


    [Inject]
    private HttpClient Http { get; init; } = null!;

    private IReadOnlyList<SongDetail>? _songs;
    


    protected override async Task OnInitializedAsync()
    {
        _songs = await Http.GetFromJsonAsync<List<SongDetail>>("data/songs.json");
    }
    
    
}