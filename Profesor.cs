using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArchivosXML
{
    public class Profesor
    {
        string id;
        string titulo;

        public string Id { get => id; set => id = value; }
        public string Titulo { get => titulo; set => titulo = value; }
    }
}