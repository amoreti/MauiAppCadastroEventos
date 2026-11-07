using MauiAppCadastroEventos.Model;
using Microsoft.Maui.Graphics.Text;

namespace MauiAppCadastroEventos.View;

public partial class CadastroEventoPage : ContentPage
{
	public CadastroEventoPage()
	{
		InitializeComponent();

        dtInicio.Date = DateTime.Today;
        dtTermino.Date = DateTime.Today;
    }

    private void dtInicio_DateSelected(object sender, DateChangedEventArgs e)
    {
        dtTermino.MinimumDate = dtInicio.Date;

        if (dtTermino.Date < dtInicio.Date)
        {
            dtTermino.Date = dtInicio.Date;
        }
    }

    private void dtTermino_DateSelected(object sender, DateChangedEventArgs e)
    {
    }

    private async void CadastrarEvento_Clicked(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(txtNomeEvento.Text))
            {
                await DisplayAlertAsync("Atenção","Informe o nome do evento.","OK");

                return;
            }

            if (dtTermino.Date < dtInicio.Date)
            {
                await DisplayAlertAsync("Atenção","A data de término deve ser maior ou igual à data de início.","OK");

                return;
            }

            if (!int.TryParse(txtParticipantes.Text, out int participantes))
            {
                await DisplayAlertAsync("Atenção","Informe uma quantidade válida de participantes.","OK");

                return;
            }

            if (!decimal.TryParse(txtCustoParticipante.Text,out decimal custoParticipante))
            {
                await DisplayAlertAsync("Atenção","Informe um custo válido.","OK");

                return;
            }

            Evento evento = new Evento
            {
                NomeEvento = txtNomeEvento.Text,
                DataInicio = dtInicio.Date.Value,
                DataTermino = dtTermino.Date.Value,
                NumeroParticipantes = participantes,
                LocalEvento = txtLocalEvento.Text,
                CustoPorParticipante = custoParticipante
            };

            await Navigation.PushAsync(new EventoCadastrado(evento));

        }
        catch (Exception ex)
        {
            await DisplayAlertAsync("Erro",ex.Message,"OK");
        }
    }
}