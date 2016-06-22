using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Repositorio;
using Entidades;
using System.Data;

namespace UNLAM_PW3_20161C.cocineros
{
    public partial class perfil : System.Web.UI.Page
    {
        CocineroRepositorio CocRepo = new CocineroRepositorio();
        UsuarioRepositorio UserRepo = new UsuarioRepositorio();

        
        protected void Page_Load(object sender, EventArgs e)
        {
            var objUsuario = UserRepo.ObtenerUsuarioId(Convert.ToInt32(HttpContext.Current.Session["userID"]));
                lblFecha.Text = Convert.ToString(objUsuario.FechaRegistracion) ;
                lblEmail1.Text = objUsuario.Email ;
                lblCantidad.Text = Convert.ToString(CocRepo.cantRecetas(objUsuario.IdUsuario)) ;

           CocRepo.finalizarEvento();

            if (!IsPostBack)
            {
                CargarGrillaEventos();
                CargarGrillaRecetas();
            }
        }

        private void CargarGrillaEventos()
        {
            int usuario = Convert.ToInt32(HttpContext.Current.Session["userID"]);
     /*       gvEventosPerfil.DataSource = CocRepo.eventoPorUsuario(usuario).ToArray();
            gvEventosPerfil.AutoGenerateColumns = false;
            gvEventosPerfil.DataBind();*/

            List<Eventos> eventos = CocRepo.eventoPorUsuario(usuario).ToList();
            if (eventos != null)
            {
                DataTable table = new DataTable("Tabla1");
                table.Columns.Add(new DataColumn("IdEvento", typeof(int)));
                table.Columns.Add(new DataColumn("Nombre", typeof(string)));
                table.Columns.Add(new DataColumn("Fecha", typeof(string)));
                table.Columns.Add(new DataColumn("Descripcion", typeof(string)));
                table.Columns.Add(new DataColumn("CantidadComensales", typeof(int)));
                table.Columns.Add(new DataColumn("Ubicacion", typeof(string)));
                table.Columns.Add(new DataColumn("NombreFoto", typeof(string)));
                table.Columns.Add(new DataColumn("Precio", typeof(int)));
                table.Columns.Add(new DataColumn("Estado", typeof(string)));

                foreach (Eventos ev in eventos)
                {
                    DataRow row = table.NewRow();
                    row["IdEvento"] = ev.IdEvento;
                    row["Nombre"] = ev.Nombre;
                    row["Fecha"] = ev.Fecha;
                    row["Descripcion"] = ev.Descripcion;
                    row["CantidadComensales"] = ev.CantidadComensales;
                    row["Ubicacion"] = ev.Ubicacion;
                    row["NombreFoto"] = ev.NombreFoto;
                    row["Precio"] = ev.Precio;
                    switch (ev.Estado) //estado 1 = Programado, 2 = en curso, 3 = finalizado, 4 = Cancelado
                    {
                        case 1:
                            row["Estado"] = "Programado";
                            break;
                        case 2:
                            row["Estado"] = "En curso";
                            break;
                        case 3:
                            row["Estado"] = "Finalizado";
                            break;
                        case 4:
                            row["Estado"] = "Cancelado";
                            break;
                        default:
                            row["Estado"] = "Quien sabe";
                            break;
                    }
                    
                    table.Rows.Add(row);
                }
                gvEventosPerfil.DataSource = table;
                gvEventosPerfil.AutoGenerateColumns = false;
                gvEventosPerfil.DataBind();
            }
            
        }

        private void CargarGrillaRecetas()
        {
            int usuario = Convert.ToInt32(HttpContext.Current.Session["userID"]);
  /*          gvRecetasPerfil.DataSource = CocRepo.recetasPorUsuario(usuario).ToArray();
            gvRecetasPerfil.AutoGenerateColumns = false;
            gvRecetasPerfil.DataBind();*/

            List<Recetas> recetas = CocRepo.recetasPorUsuario(usuario).ToList();
            if (recetas != null)
            {
                DataTable table1 = new DataTable("Tabla2");
                table1.Columns.Add(new DataColumn("IdReceta", typeof(int)));
                table1.Columns.Add(new DataColumn("Nombre", typeof(string)));
                table1.Columns.Add(new DataColumn("TiempoCoccion", typeof(int)));
                table1.Columns.Add(new DataColumn("Descripcion", typeof(string)));
                table1.Columns.Add(new DataColumn("Ingredientes", typeof(string)));
                table1.Columns.Add(new DataColumn("Tipo", typeof(string)));

                foreach (Recetas re in recetas)
                {
                    DataRow row = table1.NewRow();
                    row["IdReceta"] = re.IdReceta;
                    row["Nombre"] = re.Nombre;
                    row["TiempoCoccion"] = re.TiempoCoccion;
                    row["Descripcion"] = re.Descripcion;
                    row["Ingredientes"] = re.Ingredientes;
                    switch (re.Tipo) //1=Gourmet, 2=Diet, 3=Casera, 4=Oriental, 5=Delicateces
                    {
                        case 1:
                            row["Tipo"] = "Gourmet";
                            break;
                        case 2:
                            row["Tipo"] = "Diet";
                            break;
                        case 3:
                            row["Tipo"] = "Casera";
                            break;
                        case 4:
                            row["Tipo"] = "Oriental";
                            break;
                        case 5:
                            row["Tipo"] = "Delicateces";
                            break;
                        default:
                            row["Tipo"] = "Quien sabe";
                            break;
                    }


                    table1.Rows.Add(row);
                }
                gvRecetasPerfil.DataSource = table1;
                gvRecetasPerfil.AutoGenerateColumns = false;
                gvRecetasPerfil.DataBind();
            }
        }
    }
}