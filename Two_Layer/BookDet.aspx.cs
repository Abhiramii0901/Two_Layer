using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Two_Layer
{
    public partial class BookDet : System.Web.UI.Page
    {
        Concncls ob = new Concncls();
        protected void Page_Load(object sender, EventArgs e)
        {
            string sel = "select * from BookT";

        }
    }
}