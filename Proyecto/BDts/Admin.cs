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
    
    public partial class Admin
    {
        public Admin()
        {
            this.Sedes = new HashSet<Sede>();
        }
    
        public int Id { get; set; }
        public string Pri_nom { get; set; }
        public string Seg_nom { get; set; }
        public string Pri_ape { get; set; }
        public string Seg_ape { get; set; }
        public string Cedula { get; set; }
        public string Imagen { get; set; }
        public string Genero { get; set; }
        public string Correo { get; set; }
    
        public virtual ICollection<Sede> Sedes { get; set; }
    }
}
