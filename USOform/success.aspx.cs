using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace USOform
{
    public partial class success : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            pnSuccess.Visible = true;
        }

        protected void btnGoMain_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/dashboard.aspx");
        }
    }
}