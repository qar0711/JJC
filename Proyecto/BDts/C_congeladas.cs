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
    
    public partial class C_congeladas
    {
        public int Id { get; set; }
        public int Id_cliente { get; set; }
        public System.DateTime Congela { get; set; }
        public System.DateTime Regresa { get; set; }
        public short Dias_rest { get; set; }
    
        public virtual Cliente Cliente { get; set; }
    }
}
