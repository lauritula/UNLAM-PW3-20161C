using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Repositorio;

namespace UNLAM_PW3_20161C.comensales
{
    public partial class comentarios : System.Web.UI.Page
    {
        ComensalRepositorio ReserRepo = new ComensalRepositorio();
        ComentariosRepositorio ComeRepo = new ComentariosRepositorio();

        protected void Page_Load(object sender, EventArgs e)
        {
            sltComentario.textoLabel = "Comentario: ";
            sltComentario.TextMode = TextBoxMode.MultiLine;

            if (!IsPostBack)
            {

            }
        }


        protected void btnComentario_Click(object sender, EventArgs e)
        {
            Comentarios nuevoComentario = new Comentarios();
            nuevoComentario.Comentarios1 = sltComentario.textoTextbox;
            nuevoComentario.Puntuacion = Convert.ToByte(lbPuntacion.SelectedValue);
            nuevoComentario.IdEvento = Convert.ToInt32(Request.QueryString["evento"]);
            nuevoComentario.IdUsuario = Convert.ToInt32(HttpContext.Current.Session["userID"]);

            ComeRepo.Crear(nuevoComentario);
            Response.Redirect("reservas.aspx");

        }
    }
}