//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace prjFinanzasPersonales
{
    using System;
    using System.Collections.Generic;
    
    public partial class Egresos
    {
        public int EgresoID { get; set; }
        public Nullable<int> TipoEgresoID { get; set; }
        public Nullable<int> TipoPagoxDefecto { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }
    
        public virtual TipoEgreso TipoEgreso { get; set; }
        public virtual TipoPago TipoPago { get; set; }
    }
}
