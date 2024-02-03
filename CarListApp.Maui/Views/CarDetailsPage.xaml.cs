using CarListApp.Maui.ViewModels;
namespace CarListApp.Maui.Views;

public partial class CarDetailsPage : ContentPage
{
    private CarDetailsViewModel carDetailsViewModel;

    public CarDetailsPage(CarDetailsViewModel carDetailsViewModel)
	{
        this.carDetailsViewModel = carDetailsViewModel;
        InitializeComponent();
		BindingContext = carDetailsViewModel;
        this.carDetailsViewModel = carDetailsViewModel;
		
	}

    protected override async void OnAppearing()
    {
		base.OnAppearing();
        await carDetailsViewModel.GetCarData();

		
    }
}