//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApplication1
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