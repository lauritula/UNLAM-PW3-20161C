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
                ReserRepo.cargaFicticiaReserva();
                CargarGrillaEventosFinalizados();
            }
        }

        private void CargarGrillaEventosFinalizados()
        {
            string usuario = HttpContext.Current.Session["usuario"].ToString();
            gvEventosFinalizados.DataSource = ReserRepo.reservaFinalizados("Finalizado", usuario);
            gvEventosFinalizados.DataBind();
        }

        protected void btnComentario_Click(object sender, EventArgs e)
        {
            Comentario nuevoComentario = new Comentario();
            nuevoComentario.comentarioDescripcion = sltComentario.textoTextbox;
            nuevoComentario.comentarioID = nuevoComentario.comentarioID + 1;
            nuevoComentario.comentarioUsuario = HttpContext.Current.Session["usuario"].ToString();

            ComeRepo.Crear(nuevoComentario);
        }
    }
}