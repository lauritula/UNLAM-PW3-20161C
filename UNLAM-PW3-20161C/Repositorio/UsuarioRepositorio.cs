using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;

namespace Repositorio
{
    public class UsuarioRepositorio
    {
        PW3_TP_20161CEntities Contexto; 

        public static List<Usuarios> ListaEmpleados = new List<Usuarios>();

        public UsuarioRepositorio()
        {
            Contexto = new PW3_TP_20161CEntities();
        }

        public void Crear(Usuarios usu)
        {
            Contexto.Usuarios.Add(usu);
            Contexto.SaveChanges();
        }

        public Usuarios ObtenerUsuario(string email, string pass)
        {
            var user = (from u in Contexto.Usuarios
                            where u.Email == email
                            && u.Password == pass
                            select u).FirstOrDefault();
            return user;
        }
    }
}
