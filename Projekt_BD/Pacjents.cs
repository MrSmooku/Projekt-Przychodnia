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
    
    public partial class Pacjents
    {
        public Pacjents()
        {
            this.HistoriaChorobies = new HashSet<HistoriaChorobies>();
        }
    
        public string Imie { get; set; }
        public System.DateTime DataUrodzenie { get; set; }
        public string MiejsceUrodzenia { get; set; }
        public int Plec { get; set; }
        public string NrTelefonu { get; set; }
        public string Mail { get; set; }
        public string Pesel { get; set; }
        public string Nazwisko { get; set; }
    
        public virtual ICollection<HistoriaChorobies> HistoriaChorobies { get; set; }
    }
}
