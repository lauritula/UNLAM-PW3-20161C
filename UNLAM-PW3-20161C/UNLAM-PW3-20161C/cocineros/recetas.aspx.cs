using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Repositorio;

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
            Recetas nuevaReceta = new Recetas();
            nuevaReceta.Nombre = sltRecetaNombre.textoTextbox;
            nuevaReceta.TiempoCoccion = Convert.ToInt32(sltTiempoCoccion.textoTextbox);
            nuevaReceta.Tipo = Convert.ToByte(ingredientes.SelectedValue);
            nuevaReceta.Ingredientes = sltIngredientes.textoTextbox;
            nuevaReceta.Descripcion = sltRecetaDescripcion.textoTextbox;
            nuevaReceta.IdUsuario = Convert.ToInt32(HttpContext.Current.Session["userID"]);
            CocRepo.CrearReceta(nuevaReceta);
            Response.Redirect("perfil.aspx");

        }

    }
}