//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BDts
{
    using System;
    using System.Collections.Generic;
    
    public partial class Plane
    {
        public Plane()
        {
            this.Servs_Plns = new HashSet<Servs_Plns>();
        }
    
        public int Id { get; set; }
        public string Descripcion { get; set; }
    
        public virtual ICollection<Servs_Plns> Servs_Plns { get; set; }
    }
}
