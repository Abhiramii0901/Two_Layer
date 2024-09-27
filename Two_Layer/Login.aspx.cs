using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Two_Layer
{
    public partial class Login : System.Web.UI.Page
    {
        Concncls clsob = new Concncls();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sel = "select count(Reg_Id) from Register where Username='" + TextBox1.Text + "' and Password='" + TextBox2.Text + "'";
            string cid = clsob.fn_sclar(sel);
            int cid1 = Convert.ToInt32(cid);

            if (cid1 == 1)
            {
                string sel1 = "select Reg_Id from Register where Username='" + TextBox1.Text + "' and Password='" + TextBox2.Text + "'";
                string id = clsob.fn_sclar(sel1);
                Session["uid"] = id;
                string sel2= "select Log_Type from Register where Username='" + TextBox1.Text + "' and Password='" + TextBox2.Text + "'";
                string logtyp = clsob.fn_sclar(sel2);
                if(logtyp=="Admin")
                {
                    Response.Redirect("AdminPage.aspx");
                }
                else if(logtyp=="User")
                {
                    Response.Redirect("UserPage.aspx");
                }
            }
            else
            {
                Label3.Text = ("Invalid Username and Password");
            }
        }
    }
}