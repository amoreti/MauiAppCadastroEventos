using MauiAppCadastroEventos.Model;

namespace MauiAppCadastroEventos.View;

public partial class EventoCadastrado : ContentPage
{
    public EventoCadastrado(Evento evento)
    {
        InitializeComponent();

        BindingContext = evento;
    }
    private async void Voltar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}