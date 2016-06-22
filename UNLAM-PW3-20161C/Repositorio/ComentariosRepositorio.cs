using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Entidades;

namespace Repositorio
{
    public class ComentariosRepositorio
    {
        PW3_TP_20161CEntities Contexto;
        
        public ComentariosRepositorio()
        {
            Contexto = new PW3_TP_20161CEntities();
        }
        
        public static List<Comentarios> ListaComentarios = new List<Comentarios>(); //ctrl + . para agregar el  using de "Entidades"

        public void Crear(Comentarios com)
        {
            Contexto.Comentarios.Add(com);
            Contexto.SaveChanges();
        }


        public IQueryable<Comentarios> ObtenerPorEvento(string nombreEvento)
        {
           var comentario = from c in Contexto.Comentarios
                         join e in Contexto.Eventos
                                on c.IdEvento equals e.IdEvento
                         where e.Nombre == nombreEvento
                         select c;
            return comentario;
         }


        public Comentarios Obtener(int com)
        {
          //  Comentario nuevoCom = new Comentario();

            foreach (Comentarios L in ListaComentarios)
            {
                if (L.IdComentario == com)
                {
                    return L;
                }
                else
                {
                    return null;
                }
            }

           throw new Exception("Comentario no encontrado");
                        
        }

    
    }
}