using System;
using System.Collections.Generic;
using System.Text;

namespace MauiAppCadastroEventos.Model
{
    public class Evento
    {
        public string NomeEvento { get; set; }

        public DateTime DataInicio { get; set; }

        public DateTime DataTermino { get; set; }

        public int NumeroParticipantes { get; set; }

        public string LocalEvento { get; set; }

        public decimal CustoPorParticipante { get; set; }

        public TimeSpan DuracaoEvento
        {
            get
            {
                return DataTermino - DataInicio;
            }
        }

        public int QuantidadeDias
        {
            get
            {
                return (DataTermino - DataInicio).Days + 1;
            }
        }

        public decimal CustoTotal
        {
            get
            {
                return NumeroParticipantes * CustoPorParticipante;
            }
        }

        public string DataInicioFormatada
        {
            get
            {
                return DataInicio.ToString("dd/MM/yyyy");
            }
        }

        public string DataTerminoFormatada
        {
            get
            {
                return DataTermino.ToString("dd/MM/yyyy");
            }
        }
    }
}