using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Two_Layer
{
    public partial class UserPage : System.Web.UI.Page
    {
        Concncls ob = new Concncls();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("BookDet.aspx");
        }
    }
}