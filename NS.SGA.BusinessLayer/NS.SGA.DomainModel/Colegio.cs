//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NS.SGA.DomainModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Colegio
    {
        public Colegio()
        {
            this.Sedes = new HashSet<Sede>();
        }
    
        public int Id { get; set; }
        public string RazonSocial { get; set; }
        public string Ruc { get; set; }
    
        public virtual ICollection<Sede> Sedes { get; set; }
    }
}
