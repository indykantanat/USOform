using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CommonClassLibrary;
using System.Web.UI.HtmlControls;
using System.Data.Entity;

namespace USOform
{
    public partial class WebForm2 : System.Web.UI.Page
    {

        USOEntities uSOEntities;

        public WebForm2()
        {
            uSOEntities = new USOEntities();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            User user = (User)Session["strUsername"];
            if (user != null)
            {

              
            }
            else
            {
                Response.Redirect("~/login/login.aspx");
                Response.End();

            }

            this.GetData();


        }

        void GetData()
        {
            User user = (User)Session["strUsername"];

            var collection = uSOEntities.Sites.Where(x => x.Status == 1).ToList();

            this.SiteRepeater.DataSource = collection.ToList();

            this.SiteRepeater.DataBind();


        }

        //protected void ResultRepeater_ItemDataBound(object sender, RepeaterItemEventArgs e)
        //{
        //    Answer dataItem = e.Item.DataItem as Answer;

        //    HtmlInputText GroupNameTextBox = e.Item.FindControl("GroupNameTextBox") as HtmlInputText;
        //    if (dataItem.QuestionId == 1)
        //    {
        //        GroupNameTextBox.Value = dataItem.AnsDes;
        //    }

        //    HtmlInputText AreaTextbox = e.Item.FindControl("AreaTextbox") as HtmlInputText;
        //    if (dataItem.QuestionId == 2)
        //    {
        //        AreaTextbox.Value = dataItem.AnsDes;
        //    }



        //}

        protected void SiteRepeater_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            Site dataItem = e.Item.DataItem as Site;
            HyperLink HyperLink1 = e.Item.FindControl("HyperLink1") as HyperLink;

            switch (dataItem.HeadId)
            {
                case 1:
                    HyperLink1.NavigateUrl = "PreventiveMaintenanceReportBB_USOWrap/default.aspx?SiteId=" + dataItem.Id.ToString();
                    break;
                case 2:

                    HyperLink1.NavigateUrl = "PreventiveMaintenanceReportBB_2_4/default.aspx?SiteId=" + dataItem.Id.ToString();
                    break;
                case 3:

                    HyperLink1.NavigateUrl = "PreventiveMaintenanceReportBB2_3_3_3/default.aspx?SiteId=" + dataItem.Id.ToString();
                    break;
                case 4:

                    HyperLink1.NavigateUrl = "PreventiveMaintenanceReportBB2_2_3_2/default.aspx?SiteId=" + dataItem.Id.ToString();
                    break;
                case 5:

                    HyperLink1.NavigateUrl = "PreventiveMaintenanceReportBB2_1_3_1/default.aspx?SiteId=" + dataItem.Id.ToString();
                    break;
                case 6:

                    HyperLink1.NavigateUrl = "PreventiveMaintenanceReportBB_1/default.aspx?SiteId=" + dataItem.Id.ToString();
                    break;
                case 7:
                    HyperLink1.NavigateUrl = "PreventiveMaintenanceReportMobileService_2_1_2_2_3/default.aspx?SiteId=" + dataItem.Id.ToString();
                    break;
            }



        }
    }
}