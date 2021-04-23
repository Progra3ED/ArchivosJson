using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArchivosXML
{
    public class Estudiante: Persona
    {
        string carne;

        public string Carne { get => carne; set => carne = value; }
    }
}