//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class City
    {
        public City()
        {
            this.Provider = new HashSet<Provider>();
        }
    
        public int IdCiy { get; set; }
        public string Name { get; set; }
        public Nullable<int> IdCountry { get; set; }
        public Nullable<bool> Estatus { get; set; }
    
        public virtual Country Country { get; set; }
        public virtual ICollection<Provider> Provider { get; set; }
    }
}
