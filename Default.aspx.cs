using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;

namespace ArchivosXML
{
    public partial class _Default : Page
    {
        static List<Universidades> universidades = new List<Universidades>();
        static List<Estudiante> estudiantes = new List<Estudiante>();

        protected void Page_Load(object sender, EventArgs e)
        {
            //Cada vez que se corre el programa, se cargan las universidades existentes en el archivo Json

            //se usará el archivo de universidades
            string archivo = Server.MapPath("Universidades.json");
            //se abre el archivo
            StreamReader jsonStream = File.OpenText(archivo);            

            //se lee todo el contenido del archivo y el contenido se guarda en la variable json
            string json = jsonStream.ReadToEnd();

            jsonStream.Close();

            //Se deserializa (convierte) la cadena json en la estructura que tiene la lista universidades
            universidades = JsonConvert.DeserializeObject<List<Universidades>>(json);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Universidades universidad = new Universidades();
            universidad.Universidad = TextBoxUniversidad.Text;
            universidad.Estudiantes = estudiantes.ToList();

            universidades.Add(universidad);

            GuardarJson();

            estudiantes.Clear();
        }

        private void GuardarJson()
        {
            string json = JsonConvert.SerializeObject(universidades);
            string archivo = Server.MapPath("Universidades.json");
            System.IO.File.WriteAllText(archivo, json);
        }

        protected void ButtonAlumno_Click(object sender, EventArgs e)
        {
            Estudiante estudiante = new Estudiante();
            estudiante.Nombre = TextBoxAlumno.Text;

            estudiantes.Add(estudiante);
        }
    }
}