using MauiAppHotel.Views;

namespace MauiAppHotel.Sobre;

public partial class Desenvolvedor : ContentPage
{
    public Desenvolvedor()
    {
        InitializeComponent();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ContratacaoHospedagem());
    }
}