//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcApplication1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class kitap_tbl
    {
        public int id { get; set; }
        public string ad { get; set; }
        public string yazar { get; set; }
        public Nullable<int> sayfasayisi { get; set; }
        public string yayinevi { get; set; }
        public Nullable<System.DateTime> basimyili { get; set; }
        public string kategori { get; set; }
        public string isbnno { get; set; }
        public string aciklama { get; set; }
        public string durum { get; set; }
        public string basim_yili { get; set; }
        public string kayit_tarih { get; set; }
    }
}