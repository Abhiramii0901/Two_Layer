using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Two_Layer
{
    public partial class AdminPage : System.Web.UI.Page
    {
        Concncls ob = new Concncls();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string p = "~/ph/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(p));

            string ins = "insert into BookT values('" + TextBox1.Text + "'," + TextBox2.Text + ",'" + p + "')";
            int i = ob.fn_nonqry(ins);
            if(i==1)
            {
                Label4.Text = "Inserted";
            }
        }
    }
}