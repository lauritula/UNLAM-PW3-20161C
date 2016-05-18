using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UNLAM_PW3_20161C.cocineros
{
    public partial class eventos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            sltNombreEvento.textoLabel = "Nombre del Evento: ";
            sltDescripcion.textoLabel = "Descripcion: ";
            sltCantComensales.textoLabel = "Cantidad de Comensales: ";
            sltUbicacion.textoLabel = "Ubicacion del Evento: ";
    //        txtFotoEvento.Text = fuFotoEvento.FileContent.ToString();

           

        }

        protected void btnCrearEvento_Click(object sender, EventArgs e)
        {
            string nombreEvento = sltNombreEvento.textoTextbox;
            string descripcion = sltDescripcion.textoTextbox;
            string cantComensales = sltCantComensales.textoTextbox;
            string ubicacion = sltUbicacion.textoTextbox;

        }
    }
}