

namespace MauiAppHotel1.Models
{
    public class Evento
    {
        public string Nome { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
        public int NumeroParticipantes { get; set; }
        public string Local { get; set; }
        public double CustoPorParticipante { get; set; }

        // Cálculo da duração
        public int Duracao => (DataTermino - DataInicio).Days;

        // Cálculo do custo total
        public double CustoTotal => NumeroParticipantes * CustoPorParticipante;
    }
}