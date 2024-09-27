using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Two_Layer
{
    public partial class AdminReg : System.Web.UI.Page
    {
        Concncls obj = new Concncls();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sel = "select max(Reg_Id) from Register";
            string regid = obj.fn_sclar(sel);
            int Reg_id = 0;
            if (regid == "")
            {
                Reg_id = 1;
            }
            else
            {
                int newReg_id = Convert.ToInt32(regid);
                Reg_id = newReg_id + 1;
            }
            string ins = "insert into AdminT values(" + Reg_id + ",'" + TextBox1.Text + "','" + TextBox2.Text + "')";
            int i = obj.fn_nonqry(ins);
            if (i == 1)
            {
                string ins1 = "insert into Register values(" + Reg_id + ",'" + TextBox3.Text + "','" + TextBox4.Text + "','Admin','Active')";
                int j = obj.fn_nonqry(ins1);
                if (j == 1)
                {
                    Label5.Text = "Inserted";
                }
            }
        }
    }
}