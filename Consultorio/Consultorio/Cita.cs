using System;

namespace Consultorio
{
    public class Cita
    {
        public string ID { get; set; } = string.Empty;
        public string Paciente { get; set; } = string.Empty;
        public DateTime FechaHora { get; set; }
        public int Duracion { get; set; }
        public string Dentista { get; set; } = string.Empty;
        public string Motivo { get; set; } = string.Empty;

        public int DiasRestantes()
        {
            return (FechaHora - DateTime.Now).Days;
        }

        public string Estado()
        {
            DateTime fin = FechaHora.AddMinutes(Duracion);

            if (DateTime.Now < FechaHora)
                return "Vigente";

            if (DateTime.Now >= FechaHora && DateTime.Now <= fin)
                return "En proceso";

            return "Finalizado";
        }
    }
}