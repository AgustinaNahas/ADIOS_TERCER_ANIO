//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MercadoEnvios
{
    using System;
    using System.Collections.Generic;
    
    public partial class Calificacion
    {
        public int id { get; set; }
        public int idUsuarioCalificador { get; set; }
        public Nullable<int> idPublicacion { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
        public Nullable<int> valor { get; set; }
        public string detalle { get; set; }
        public Nullable<int> pendiente { get; set; }
    
        public virtual Publicacion Publicacion { get; set; }
    }
}
