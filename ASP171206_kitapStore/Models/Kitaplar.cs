//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP171206_kitapStore.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Kitaplar
    {
        public int Id { get; set; }
        public string KitapAdi { get; set; }
        public Nullable<System.DateTime> Tarih { get; set; }
        public Nullable<decimal> Fiyat { get; set; }
        public int YayinEviId { get; set; }
        public int KategoriId { get; set; }
        public int YazarId { get; set; }
        public string Resim { get; set; }
        public string Detay { get; set; }
    
        public virtual Kategoriler Kategoriler { get; set; }
        public virtual YayinEvleri YayinEvleri { get; set; }
        public virtual Yazarlar Yazarlar { get; set; }
    }
}