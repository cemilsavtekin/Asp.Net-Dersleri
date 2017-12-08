using ASP171206_kitapStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP171206_kitapStore
{
    public partial class MasterFromMain : System.Web.UI.MasterPage
    {

        

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)//servera istekte bulunduktan sonra gelen sayfada işlem yapılım servara gitme olayı ispostpback dir.
                //burada sayfa ilk yüklendiği anda işlem yapsın diye ispostback olmadan işlem yaptırıyoruz.
            {
                kategoriGetir();
            }
        }

        private void kategoriGetir()
        {
            using (DBEntities db = new DBEntities())
            {
                var kategoriler = db.Kategoriler.ToList();

                kategoriList.DataSource = kategoriler;
                kategoriList.DataBind();

            }
        }
    }
}