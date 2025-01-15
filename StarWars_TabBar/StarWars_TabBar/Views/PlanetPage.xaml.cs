using StarWars_TabBar.Services;

namespace StarWars_TabBar.Views;

public partial class PlanetPage : ContentPage
{
    private readonly IStarWarsService _starWarsService;

    public PlanetPage(IStarWarsService starWarsService)
    {
        _starWarsService = starWarsService;
        InitializeComponent();
    }

    private async void OnDataClicked(object sender, EventArgs e)
    {
        loading.IsVisible = true;

        var data = await _starWarsService.GetPlanetsAsync();
        listViewPlanets.ItemsSource = data;

        loading.IsVisible = false;
    }
}
