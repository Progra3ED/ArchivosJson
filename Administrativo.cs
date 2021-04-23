using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArchivosXML
{
    public class Administrativo
    {
        string igss;
        string profesion;
        DateTime fechaInicio;
        DateTime fechaSalida;

        public string Igss { get => igss; set => igss = value; }
        public string Profesion { get => profesion; set => profesion = value; }
        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public DateTime FechaSalida { get => fechaSalida; set => fechaSalida = value; }
    }
}