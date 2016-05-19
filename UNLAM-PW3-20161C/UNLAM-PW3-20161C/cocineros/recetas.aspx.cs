using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;

namespace UNLAM_PW3_20161C.cocineros
{
    public partial class recetas : System.Web.UI.Page
    {
        CocineroRepositorio CocRepo = new CocineroRepositorio();

        protected void Page_Load(object sender, EventArgs e)
        {
            sltIngredientes.textoLabel = "Ingredientes: ";
            sltRecetaDescripcion.textoLabel = "Descripcion y pasos de realizacion: ";
            sltTiempoCoccion.textoLabel = "Tiempo de Coccion (min.): ";
            sltRecetaNombre.textoLabel = "Nombre: ";
            sltRecetaDescripcion.TextMode = TextBoxMode.MultiLine;
            sltIngredientes.TextMode = TextBoxMode.MultiLine;

        }

        protected void btnCargarReceta_Click(object sender, EventArgs e)
        {
            Receta nuevaReceta = new Receta();
            nuevaReceta.nombreReceta = sltRecetaNombre.textoTextbox;
            nuevaReceta.tiempoReceta = Convert.ToInt16(sltTiempoCoccion.textoTextbox);
            nuevaReceta.tipoReceta = ingredientes.SelectedValue;
            nuevaReceta.ingredientesReceta = sltIngredientes.textoTextbox;
            nuevaReceta.descripcionPasosReceta = sltRecetaDescripcion.textoTextbox;
            nuevaReceta.autorReceta = HttpContext.Current.Session["usuario"].ToString();
            CocRepo.CrearReceta(nuevaReceta);

        }
    }
}