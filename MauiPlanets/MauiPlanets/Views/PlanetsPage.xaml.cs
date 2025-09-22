using MauiPlanets.Services;

namespace MauiPlanets.Views;

public partial class PlanetsPage : ContentPage
{

	private const uint AnimationDuration = 800u;
	public PlanetsPage()
	{
		InitializeComponent();
	}

	protected override void OnAppearing()
	{
		base.OnAppearing();

		lstPopularPlanets.ItemSource = PlanetsService.GetFeaturedPlanets();
		lstAllPlanets.ItemSource = PlanetsService.GetAllPlanets();
    }
}
