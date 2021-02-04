using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Web.UI.WebControls;
using CommonClassLibrary;

namespace USOform.login
{
    public partial class WebForm1 : System.Web.UI.Page

    {

        USOEntities uSOEntities;

        public WebForm1()
        {
            uSOEntities = new USOEntities();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btnLogins_Click(object sender, EventArgs e)
        {
            var user = uSOEntities.Users.Where(x => x.Username == this.txtUsername.Value && x.Password == this.txtPassword.Value).FirstOrDefault();
            if (user != null)
            {
                Session["strUsername"] = user;
              
                Response.Redirect("/dashboard.aspx");
              

            }
            else
            {
                Response.Write("<script>alert('ชื่อผุ้ใช้งาน หรือ รหัสผ่านไม่ถูกต้อง');</script>");
            }
        }
    }


}