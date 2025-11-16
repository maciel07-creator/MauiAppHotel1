using MauiAppHotel1.Models;

namespace MauiAppHotel1.Views;

public partial class ResultadoEvento : ContentPage
{
	public ResultadoEvento(Evento evento)
	{
		InitializeComponent();

        Resumo.Text =
           $"📌 Nome do evento: {evento.Nome}" +
           $"📅 Início: {evento.DataInicio:dd/MM/yyyy}" +
           $"📅 Término: {evento.DataTermino:dd/MM/yyyy}" +
           $"⏳ Duração: {evento.Duracao} dias" +
           $"👥 Participantes: {evento.NumeroParticipantes}" +
           $"📍 Local: {evento.Local}\n" +
           $"💰 Custo por participante: R$ {evento.CustoPorParticipante:F2}" +
           $"💵 Custo total do evento: R$ {evento.CustoTotal:F2}";
    }
}