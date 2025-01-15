using StarWars_TabBar.Services;

namespace StarWars_TabBar.Views;

public partial class StarShipPage : ContentPage
{
    private readonly IStarWarsService _starWarsService;
    public StarShipPage(IStarWarsService starWarsService)
	{
        _starWarsService = starWarsService;
        InitializeComponent();
	}

    private async void OnDataClicked(object sender, EventArgs e)
    {
        loading.IsVisible = true;

        var data = await _starWarsService.GetStarShipsAsync();
        listViewStarShips.ItemsSource = data;

        loading.IsVisible = false;
    }
}