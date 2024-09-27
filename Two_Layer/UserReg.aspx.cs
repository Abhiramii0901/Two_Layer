using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Two_Layer
{
    public partial class UserReg : System.Web.UI.Page
    {
        Concncls ob = new Concncls();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sel = "select max(Reg_Id) from Register";
            string regid = ob.fn_sclar(sel);
            int Reg_id = 0;
            if(regid=="")
            {
                Reg_id = 1;
            }
            else
            {
                int newReg_id = Convert.ToInt32(regid);
                Reg_id = newReg_id + 1;
            }
            string ins = "insert into UserT values(" + Reg_id + ",'" + TextBox1.Text + "'," + TextBox2.Text + ",'" + TextBox3.Text + "')";
            int i = ob.fn_nonqry(ins);
            if(i==1)
            {
                string ins1 = "insert into Register values(" + Reg_id + ",'" + TextBox4.Text + "','" + TextBox5.Text + "','User','Active')";
                int j = ob.fn_nonqry(ins1);
                if(j==1)
                {
                    Label6.Text = "Inserted";
                }
            }
        }
    }
}