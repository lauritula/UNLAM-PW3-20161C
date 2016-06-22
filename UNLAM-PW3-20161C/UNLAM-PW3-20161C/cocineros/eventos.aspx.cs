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
    public partial class eventos : System.Web.UI.Page
    {
        CocineroRepositorio CocRepo = new CocineroRepositorio();

        protected void Page_Load(object sender, EventArgs e)
        {
            sltNombreEvento.textoLabel = "Nombre del Evento: ";
            sltDescripcion.textoLabel = "Descripcion: ";
            sltCantComensales.textoLabel = "Cantidad de Comensales: ";
            sltUbicacion.textoLabel = "Ubicacion del Evento: ";
            sltPrecio.textoLabel = "Precio: ";
   //         txtFotoEvento.Text = Convert.ToString(fuFotoEvento.FileName);

            int usuario = Convert.ToInt32(HttpContext.Current.Session["userID"]);
            cblRecetas.DataSource = CocRepo.recetasPorUsuario(usuario).ToList();
            cblRecetas.DataTextField = "Nombre";
            cblRecetas.DataValueField = "IdReceta";
            cblRecetas.DataBind();
        }

        protected void btnCrearEvento_Click(object sender, EventArgs e)
        {
            string nombreEvento = sltNombreEvento.textoTextbox;
            string descripcion = sltDescripcion.textoTextbox;
            string precio = sltPrecio.textoTextbox;
            string cantComensales = sltCantComensales.textoTextbox;
            string ubicacion = sltUbicacion.textoTextbox;
            string eventoFoto = txtFotoEvento.Text;

            Eventos nuevoEvento = new Eventos();
            nuevoEvento.Nombre = nombreEvento;
            nuevoEvento.Descripcion = descripcion;
            nuevoEvento.CantidadComensales = Convert.ToInt32(cantComensales);
            nuevoEvento.Precio = Convert.ToDecimal(precio);
            nuevoEvento.Ubicacion = ubicacion;
            nuevoEvento.Fecha = Convert.ToDateTime(txtFechaEvento.Text);
            nuevoEvento.IdUsuario = Convert.ToInt32(HttpContext.Current.Session["userID"]);

            Boolean fileOK = false;
            String path = Server.MapPath("~/img/eventos/");
            if (fuFotoEvento.HasFile)
            {
                eventoFoto = fuFotoEvento.FileName;
                String fileExtension =
                    System.IO.Path.GetExtension(fuFotoEvento.FileName).ToLower();
                String[] allowedExtensions = { ".gif", ".png", ".jpeg", ".jpg" };

                for (int i = 0; i < allowedExtensions.Length; i++)
                {
                    if (fileExtension == allowedExtensions[i])
                    {
                        fileOK = true;
                    }
                }
            }

            if (fileOK)
            {
                try
                {
                    fuFotoEvento.PostedFile.SaveAs(path + fuFotoEvento.FileName);
                    lblFileOk.Text = "Subido con Exito.";
                }
                catch (Exception ex)
                {
                    lblFileOk.Text = "La imagen no se pudo subir.";
                }
            }
            else
            {
                lblFileOk.Text = "No se aceptan archivos de ese tipo.";
            }

            nuevoEvento.NombreFoto = eventoFoto;

            foreach (ListItem re in cblRecetas.Items)
                     {
                         if (re.Selected)
                         {
                             int idRece = Int32.Parse(re.Value);
                             Recetas receta = CocRepo.recetasPorId(idRece);
                             nuevoEvento.Recetas.Add(receta);
                         }                            
   
                     }

            CocRepo.CrearEvento(nuevoEvento);
            
            Response.Redirect("perfil.aspx");

        }
    }
}