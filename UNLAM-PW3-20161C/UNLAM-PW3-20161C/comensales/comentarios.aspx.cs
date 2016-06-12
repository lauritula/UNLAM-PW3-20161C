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
            Comentario nuevoComentario = new Comentario();
            nuevoComentario.comentarioDescripcion = sltComentario.textoTextbox;
            nuevoComentario.comentarioID = nuevoComentario.comentarioID + 1;
            nuevoComentario.comentarioEvento = Request.QueryString["evento"];
            nuevoComentario.comentarioUsuario = HttpContext.Current.Session["usuario"].ToString();

            ComeRepo.Crear(nuevoComentario);
            Response.Redirect("reservas.aspx");

        }
    }
}