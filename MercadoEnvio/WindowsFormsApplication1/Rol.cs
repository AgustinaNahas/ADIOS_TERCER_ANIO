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
    
    public partial class Rol
    {
        public Rol()
        {
            this.FuncionalidadRols = new HashSet<FuncionalidadRol>();
            this.RolUsuarios = new HashSet<RolUsuario>();
        }
    
        public int id { get; set; }
        public string nombre { get; set; }
        public Nullable<int> deleted { get; set; }
    
        public virtual ICollection<FuncionalidadRol> FuncionalidadRols { get; set; }
        public virtual ICollection<RolUsuario> RolUsuarios { get; set; }
    }
}
