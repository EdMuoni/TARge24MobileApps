using MauiPlanets.Services;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml;
using System;
using MauiPlanets.Models;

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

	async void Planets_SelectionChanged(System.Object sender, Microsoft.Maui.Controls.SelectionChangedEventArgs e)
	{
		//await Navigation.PushAsync(new PlanetsDetailsPage(e. CurrentSelection.First() as Planet));
	}

        async void ProfilePic_Clicked(System.Object sender, System.EventArgs e)
	{
		_ = MainContentGrid.TranslateTo(-this.Width * 0.5, this.Height * 0.1, AnimationDuration, Easing.CubicIn);

		await MainContentGrid.ScaleTo(0.8, AnimationDuration);
		_ = MainContentGrid.ScaleTo(0.8, AnimationDuration);
	}

   
}
