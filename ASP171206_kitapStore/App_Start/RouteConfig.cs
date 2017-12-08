using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace ASP171206_kitapStore.App_Start
{
    public static class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapPageRoute("HomeRoute", "Anasayfa", "~/Books.aspx");

            routes.MapPageRoute("KategoriRoute", "Kitap-Kategori/{KategoriAdi}", "~/Books.aspx");
        }
    }
}