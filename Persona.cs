using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArchivosXML
{
    public class Persona
    {
        string nombre;
        string apellido;
        string dirección;
        DateTime fechaNacimiento;
        int edad;


        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Dirección { get => dirección; set => dirección = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public int Edad { get { return calcularEdad(); } }

        private int calcularEdad()
        {

            DateTime hoy = DateTime.Now;

            int años = hoy.Year - fechaNacimiento.Year;

            if (fechaNacimiento.Month < hoy.Month)
                años--;

            return años;
        
        }
    }
}