//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataConnection
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        public int IdProduct { get; set; }
        public string Name { get; set; }
        public Nullable<int> IdProvider { get; set; }
        public Nullable<int> IdCategory { get; set; }
        public string costing { get; set; }
        public string Description { get; set; }
        public Nullable<bool> Estatus { get; set; }
    
        public virtual Category Category { get; set; }
        public virtual Provider Provider { get; set; }
    }
}