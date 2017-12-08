using ASP171206_kitapStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP171206_kitapStore
{
    public partial class Books : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Request.QueryString["katID"] != null)
            {
                int id = int.Parse(Request.QueryString["katID"]);
                kitapGetir(id);
            }
            else
            {
                kitapGetir();
            }


        }

        private void kitapGetir(int id)
        {
            using (DBEntities db = new DBEntities())
            {
                var kitaplar = (from k in db.Kitaplar
                                where k.KategoriId == id
                                select new
                                {
                                    k.KitapAdi,
                                    k.Resim,
                                    Detay = k.Detay.Length > 100 ? k.Detay.Substring(0, 97) + "..." : k.Detay,
                                    k.Fiyat,
                                    k.Id,
                                    k.KategoriId,
                                    k.Kategoriler,
                                    k.Kategoriler.KategoriAdi,
                                    k.Tarih,
                                    k.YayinEviId,
                                    k.YayinEvleri,
                                    k.YazarId,
                                    yazar = k.Yazarlar.YazarAdi + " " + k.Yazarlar.YazarSoyadi
                                }).ToList();





                bookList.DataSource = kitaplar;
                bookList.DataBind();
            }
        }

        private void kitapGetir()
        {
            using (DBEntities db = new DBEntities())
            {
                var kitaplar = (from k in db.Kitaplar
                                select new
                                {
                                    k.KitapAdi,
                                    k.Resim,
                                    Detay = k.Detay.Length > 100 ? k.Detay.Substring(0, 97) + "..." : k.Detay,
                                    k.Fiyat,
                                    k.Id,
                                    k.KategoriId,
                                    k.Kategoriler,
                                    k.Kategoriler.KategoriAdi,
                                    k.Tarih,
                                    k.YayinEviId,
                                    k.YayinEvleri,
                                    k.YazarId,
                                    yazar = k.Yazarlar.YazarAdi + " " + k.Yazarlar.YazarSoyadi
                                }).ToList();





                bookList.DataSource = kitaplar;
                bookList.DataBind();
            }
        }
    }
}