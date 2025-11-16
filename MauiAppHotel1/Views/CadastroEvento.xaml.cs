using MauiAppHotel1.Models;

namespace MauiAppHotel1.Views;

public partial class CadastroEvento : ContentPage
{
    public Evento EventoAtual { get; set; } = new();

    public CadastroEvento()
	{
		InitializeComponent();
        BindingContext = EventoAtual;
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ResultadoEvento(EventoAtual));
    }
}