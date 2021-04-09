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
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonCargar_Click(object sender, EventArgs e)
        {
            
            List<Universidades> universidades = new List<Universidades>();

            string archivo = Server.MapPath("Universidades.json");
            StreamReader jsonStream = File.OpenText(archivo);

            var json = jsonStream.ReadLine();

            universidades = JsonConvert.DeserializeObject<List<Universidades>>(json);






        }
    }
}