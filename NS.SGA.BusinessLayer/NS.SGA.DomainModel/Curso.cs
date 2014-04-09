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
    
    public partial class Curso
    {
        public Curso()
        {
            this.AlumnosSecciones = new HashSet<AlumnoSeccionCurso>();
            this.CursoSecciones = new HashSet<CursoSeccion>();
        }
    
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int IdPeriodo { get; set; }
        public int IdSeccion { get; set; }
    
        public virtual ICollection<AlumnoSeccionCurso> AlumnosSecciones { get; set; }
        public virtual ICollection<CursoSeccion> CursoSecciones { get; set; }
        public virtual Periodo Periodo { get; set; }
        public virtual Sede Sede { get; set; }
    }
}