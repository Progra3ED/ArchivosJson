using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ArchivosXML
{
    public partial class Contact : Page
    {
        static List<Universidades> universidades = new List<Universidades>();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                //se usará el archivo de universidades
                string archivo = Server.MapPath("Universidades.json");
                //se abre el archivo
                StreamReader jsonStream = File.OpenText(archivo);
                //se lee todo el contenido del archivo y el contenido se guarda en la variable json
                string json = jsonStream.ReadToEnd();

                jsonStream.Close();

                //Se deserializa (convierte) la cadena json en la estructura que tiene la lista universidades
                universidades = JsonConvert.DeserializeObject<List<Universidades>>(json);

                //se enlaza con el gridview para que muestre las universidades
                //Como cada universidad tiene dentro una lista con alumnos, esta segunda lista no se puede
                //desplegar en el gridview, pues la cantidad de alumnos en cada universidad puede variar,
                //y el gridview siempre debe tener la misma cantidad de columnas para todas sus filas.
                //Por lo que solo se van a mostrar los nombres de las universidades.
                //Al GridviewUniversidades, desde el diseño se le agregó una columna que permita seleccionar
                //la universidad de la que queremos mostrar sus alumnos en un segundo gridview.
                GridViewUniversidades.DataSource = universidades;
                GridViewUniversidades.DataBind();
            }
            LabelNombre.Visible = false;
            TextBoxNombre.Visible = false;
            ButtonGuardar.Visible = false;
        }

        
        protected void GridViewUniversidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            //guarda el indice de la fila seleccionada en el gridview
            int seleccionada = GridViewUniversidades.SelectedIndex;

            //el datasource para el gridView de alumnos, es la lista de alumnos que esta en la posicion seleccionada
            //dentro de la lista de universidades.
            //Recordar que universidades es una lista, que dentro de cada posición tiene otra lista
            //con todos los alumnos de esa universidad.
            GridViewAlumnos.DataSource = universidades[seleccionada].Estudiantes;
            GridViewAlumnos.DataBind();
        }


        private void GuardarJson()
        {
            string json = JsonConvert.SerializeObject(universidades);
            string archivo = Server.MapPath("Universidades.json");
            System.IO.File.WriteAllText(archivo, json);
        }

        protected void ButtonEliminar_Click(object sender, EventArgs e)
        {
            int idUniversidad = GridViewUniversidades.SelectedIndex;
            int idAlumno = GridViewAlumnos.SelectedIndex;


            universidades[idUniversidad].Estudiantes.RemoveAt(idAlumno);
         



            GuardarJson();

            GridViewAlumnos.DataSource = universidades[idUniversidad].Estudiantes;
            GridViewAlumnos.DataBind();

        }

        protected void ButtonEditar_Click(object sender, EventArgs e)
        {
            int idUniversidad = GridViewUniversidades.SelectedIndex;
            int idAlumno = GridViewAlumnos.SelectedIndex;

            LabelNombre.Visible = true;
            TextBoxNombre.Visible = true;
            ButtonGuardar.Visible = true;

            TextBoxNombre.Text = universidades[idUniversidad].Estudiantes[idAlumno].Nombre;


        }

        protected void ButtonGuardar_Click(object sender, EventArgs e)
        {
            int idUniversidad = GridViewUniversidades.SelectedIndex;
            int idAlumno = GridViewAlumnos.SelectedIndex;

            universidades[idUniversidad].Estudiantes[idAlumno].Nombre = TextBoxNombre.Text;
            
            GuardarJson();

            GridViewAlumnos.DataSource = universidades[idUniversidad].Estudiantes;
            GridViewAlumnos.DataBind();
        }
    }
}