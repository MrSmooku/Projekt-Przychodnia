//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Projekt_BD
{
    using System;
    using System.Collections.Generic;
    
    public partial class SpisChorbs
    {
        public SpisChorbs()
        {
            this.HistoriaChorobies = new HashSet<HistoriaChorobies>();
        }
    
        public string NazwaChoroby { get; set; }
        public string NazwaPolskaChoroby { get; set; }
        public string Opis { get; set; }
        public string Objawy { get; set; }
        public string SposobyLeczenia { get; set; }
    
        public virtual ICollection<HistoriaChorobies> HistoriaChorobies { get; set; }
    }
}
