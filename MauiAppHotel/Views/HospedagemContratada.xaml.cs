namespace MauiAppHotel.Views;

public partial class HospedagemContratada : ContentPage
{
    public HospedagemContratada()
    {
        InitializeComponent();
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
           await Navigation.PopAsync();
        }
        catch (Exception ex)
        {
           await DisplayAlert("Ops", ex.Message, "OK");
        }

    }
}