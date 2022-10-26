namespace StarWar.Views;
using StarWar.Models;
using StarWar.Services;
using System;


public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
        DependencyService.Register<StarWarStoreApi>();
        DependencyService.Register<WebClientService>();
    }

	
}

