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
            // old resouce
            //string script = "$(document).ready(function () { $('[id*=btnSubmit]').click(); });";
           
            this.GetData();


        }

        void GetData()
        {
            User user = (User)Session["strUsername"];
            // Add Fake Delay to simulate long running process.
            System.Threading.Thread.Sleep(2000);

            var collection = uSOEntities.Sites.Where(x => x.Status == 1).ToList();
            this.SiteRepeater.DataSource = collection.ToList();
            this.SiteRepeater.DataBind();


        }



        protected void SiteRepeater_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            Site dataItem = e.Item.DataItem as Site;


            HyperLink HyperLink1 = e.Item.FindControl("HyperLink1") as HyperLink;
            HyperLink HyperLink2 = e.Item.FindControl("HyperLink2") as HyperLink;
            HyperLink Q1Label = e.Item.FindControl("Q1Label") as HyperLink;
            Q1Label.Text = dataItem.SRs.Where(x => x.Quarter == 1).Count() > 0 ? "กรอกเเล้ว" : "ยังไม่กรอก";
            HyperLink Q2Label = e.Item.FindControl("Q2Label") as HyperLink;
            Q2Label.Text = dataItem.SRs.Where(x => x.Quarter == 2).Count() > 0 ? "กรอกเเล้ว" : "ยังไม่กรอก";
            HyperLink Q3Label = e.Item.FindControl("Q3Label") as HyperLink;
            Q3Label.Text = dataItem.SRs.Where(x => x.Quarter == 3).Count() > 0 ? "กรอกเเล้ว" : "ยังไม่กรอก";
            HyperLink Q4Label = e.Item.FindControl("Q4Label") as HyperLink;
            Q4Label.Text = dataItem.SRs.Where(x => x.Quarter == 4).Count() > 0 ? "กรอกเเล้ว" : "ยังไม่กรอก";


            HyperLink preview1 = e.Item.FindControl("preview1") as HyperLink;
            HyperLink preview2 = e.Item.FindControl("preview2") as HyperLink;
            HyperLink preview3 = e.Item.FindControl("preview3") as HyperLink;
            HyperLink preview4 = e.Item.FindControl("preview4") as HyperLink;

            switch (dataItem.HeadId)
            {
                case 1:

                    Q1Label.NavigateUrl    = "PreventiveMaintenanceReportBB_USOWrap/default.aspx?SiteId=" + dataItem.Id.ToString() + "&qurter=1";
                    Q2Label.NavigateUrl = "PreventiveMaintenanceReportBB_USOWrap/default.aspx?SiteId=" + dataItem.Id.ToString() + "&qurter=2";
                    Q3Label.NavigateUrl = "PreventiveMaintenanceReportBB_USOWrap/default.aspx?SiteId=" + dataItem.Id.ToString() + "&qurter=3";
                    Q4Label.NavigateUrl = "PreventiveMaintenanceReportBB_USOWrap/default.aspx?SiteId=" + dataItem.Id.ToString() + "&qurter=4";
                    //HyperLink1.NavigateUrl = "PreventiveMaintenanceReportBB_USOWrap/default.aspx?SiteId=" + dataItem.Id.ToString();
                    preview1.NavigateUrl = "PreventiveMaintenanceReportBB_USOWrap/preview.aspx?SiteId=" + dataItem.Id.ToString() + "&qurter=1";
                    preview2.NavigateUrl = "PreventiveMaintenanceReportBB_USOWrap/preview.aspx?SiteId=" + dataItem.Id.ToString() + "&qurter=2";
                    preview3.NavigateUrl = "PreventiveMaintenanceReportBB_USOWrap/preview.aspx?SiteId=" + dataItem.Id.ToString() + "&qurter=3";
                    preview4.NavigateUrl = "PreventiveMaintenanceReportBB_USOWrap/preview.aspx?SiteId=" + dataItem.Id.ToString() + "&qurter=4";

                    break;
                case 2:
                    Q1Label.NavigateUrl = "PreventiveMaintenanceReportBB_2_4/default.aspx?SiteId=" + dataItem.Id.ToString() + "&qurter=1";
                    Q2Label.NavigateUrl = "PreventiveMaintenanceReportBB_2_4/default.aspx?SiteId=" + dataItem.Id.ToString() + "&qurter=2";
                    Q3Label.NavigateUrl = "PreventiveMaintenanceReportBB_2_4/default.aspx?SiteId=" + dataItem.Id.ToString() + "&qurter=3";
                    Q4Label.NavigateUrl = "PreventiveMaintenanceReportBB_2_4/default.aspx?SiteId=" + dataItem.Id.ToString() + "&qurter=4";
                    //HyperLink1.NavigateUrl = "PreventiveMaintenanceReportBB_2_4/default.aspx?SiteId=" + dataItem.Id.ToString();
                    preview1.NavigateUrl = "PreventiveMaintenanceReportBB_2_4/preview.aspx?SiteId=" + dataItem.Id.ToString() + "&qurter=1";
                    preview2.NavigateUrl = "PreventiveMaintenanceReportBB_2_4/preview.aspx?SiteId=" + dataItem.Id.ToString() + "&qurter=2";
                    preview3.NavigateUrl = "PreventiveMaintenanceReportBB_2_4/preview.aspx?SiteId=" + dataItem.Id.ToString() + "&qurter=3";
                    preview4.NavigateUrl = "PreventiveMaintenanceReportBB_2_4/preview.aspx?SiteId=" + dataItem.Id.ToString() + "&qurter=4";


                    break;
                case 3:


                    Q1Label.NavigateUrl = "PreventiveMaintenanceReportBB2_3_3_3/default.aspx?SiteId=" + dataItem.Id.ToString() + "&qurter=1";
                    Q2Label.NavigateUrl = "PreventiveMaintenanceReportBB2_3_3_3/default.aspx?SiteId=" + dataItem.Id.ToString() + "&qurter=2";
                    Q3Label.NavigateUrl = "PreventiveMaintenanceReportBB2_3_3_3/default.aspx?SiteId=" + dataItem.Id.ToString() + "&qurter=3";
                    Q4Label.NavigateUrl = "PreventiveMaintenanceReportBB2_3_3_3/default.aspx?SiteId=" + dataItem.Id.ToString() + "&qurter=4";
                    //HyperLink1.NavigateUrl = "PreventiveMaintenanceReportBB2_3_3_3/default.aspx?SiteId=" + dataItem.Id.ToString();
                    preview1.NavigateUrl = "PreventiveMaintenanceReportBB2_3_3_3/preview.aspx?SiteId=" + dataItem.Id.ToString() + "&qurter=1";
                    preview2.NavigateUrl = "PreventiveMaintenanceReportBB2_3_3_3/preview.aspx?SiteId=" + dataItem.Id.ToString() + "&qurter=2";
                    preview3.NavigateUrl = "PreventiveMaintenanceReportBB2_3_3_3/preview.aspx?SiteId=" + dataItem.Id.ToString() + "&qurter=3";
                    preview4.NavigateUrl = "PreventiveMaintenanceReportBB2_3_3_3/preview.aspx?SiteId=" + dataItem.Id.ToString() + "&qurter=4";
                    break;
                case 4:
                    Q1Label.NavigateUrl = "PreventiveMaintenanceReportBB2_2_3_2/default.aspx?SiteId=" + dataItem.Id.ToString() + "&qurter=1";
                    Q2Label.NavigateUrl = "PreventiveMaintenanceReportBB2_2_3_2/default.aspx?SiteId=" + dataItem.Id.ToString() + "&qurter=2";
                    Q3Label.NavigateUrl = "PreventiveMaintenanceReportBB2_2_3_2/default.aspx?SiteId=" + dataItem.Id.ToString() + "&qurter=3";
                    Q4Label.NavigateUrl = "PreventiveMaintenanceReportBB2_2_3_2/default.aspx?SiteId=" + dataItem.Id.ToString() + "&qurter=4";
                    //HyperLink1.NavigateUrl = "PreventiveMaintenanceReportBB2_2_3_2/default.aspx?SiteId=" + dataItem.Id.ToString();
                    preview1.NavigateUrl = "PreventiveMaintenanceReportBB2_2_3_2/preview.aspx?SiteId=" + dataItem.Id.ToString() + "&qurter=1";
                    preview2.NavigateUrl = "PreventiveMaintenanceReportBB2_2_3_2/preview.aspx?SiteId=" + dataItem.Id.ToString() + "&qurter=2";
                    preview3.NavigateUrl = "PreventiveMaintenanceReportBB2_2_3_2/preview.aspx?SiteId=" + dataItem.Id.ToString() + "&qurter=3";
                    preview4.NavigateUrl = "PreventiveMaintenanceReportBB2_2_3_2/preview.aspx?SiteId=" + dataItem.Id.ToString() + "&qurter=4";
                    break;
                case 5:
                    Q1Label.NavigateUrl = "PreventiveMaintenanceReportBB2_1_3_1/default.aspx?SiteId=" + dataItem.Id.ToString() + "&qurter=1";
                    Q2Label.NavigateUrl = "PreventiveMaintenanceReportBB2_1_3_1/default.aspx?SiteId=" + dataItem.Id.ToString() + "&qurter=2";
                    Q3Label.NavigateUrl = "PreventiveMaintenanceReportBB2_1_3_1/default.aspx?SiteId=" + dataItem.Id.ToString() + "&qurter=3";
                    Q4Label.NavigateUrl = "PreventiveMaintenanceReportBB2_1_3_1/default.aspx?SiteId=" + dataItem.Id.ToString() + "&qurter=4";
                    //HyperLink1.NavigateUrl = "PreventiveMaintenanceReportBB2_1_3_1/default.aspx?SiteId=" + dataItem.Id.ToString();
                    preview1.NavigateUrl = "PreventiveMaintenanceReportBB2_1_3_1/preview.aspx?SiteId=" + dataItem.Id.ToString() + "&qurter=1";
                    preview2.NavigateUrl = "PreventiveMaintenanceReportBB2_1_3_1/preview.aspx?SiteId=" + dataItem.Id.ToString() + "&qurter=2";
                    preview3.NavigateUrl = "PreventiveMaintenanceReportBB2_1_3_1/preview.aspx?SiteId=" + dataItem.Id.ToString() + "&qurter=3";
                    preview4.NavigateUrl = "PreventiveMaintenanceReportBB2_1_3_1/preview.aspx?SiteId=" + dataItem.Id.ToString() + "&qurter=4";
                    break;
                case 6:
                    Q1Label.NavigateUrl = "PreventiveMaintenanceReportBB_1/default.aspx?SiteId=" + dataItem.Id.ToString() + "&qurter=1";
                    Q2Label.NavigateUrl = "PreventiveMaintenanceReportBB_1/default.aspx?SiteId=" + dataItem.Id.ToString() + "&qurter=2";
                    Q3Label.NavigateUrl = "PreventiveMaintenanceReportBB_1/default.aspx?SiteId=" + dataItem.Id.ToString() + "&qurter=3";
                    Q4Label.NavigateUrl = "PreventiveMaintenanceReportBB_1/default.aspx?SiteId=" + dataItem.Id.ToString() + "&qurter=4";
                    //HyperLink1.NavigateUrl = "PreventiveMaintenanceReportBB_1/default.aspx?SiteId=" + dataItem.Id.ToString();
                    preview1.NavigateUrl = "PreventiveMaintenanceReportBB_1/preview.aspx?SiteId=" + dataItem.Id.ToString() + "&qurter=1";
                    preview2.NavigateUrl = "PreventiveMaintenanceReportBB_1/preview.aspx?SiteId=" + dataItem.Id.ToString() + "&qurter=2";
                    preview3.NavigateUrl = "PreventiveMaintenanceReportBB_1/preview.aspx?SiteId=" + dataItem.Id.ToString() + "&qurter=3";
                    preview4.NavigateUrl = "PreventiveMaintenanceReportBB_1/preview.aspx?SiteId=" + dataItem.Id.ToString() + "&qurter=4";

                    break;
                case 7:
                    Q1Label.NavigateUrl = "PreventiveMaintenanceReportMobileService_2_1_2_2_3/default.aspx?SiteId=" + dataItem.Id.ToString() + "&qurter=1";
                    Q2Label.NavigateUrl = "PreventiveMaintenanceReportMobileService_2_1_2_2_3/default.aspx?SiteId=" + dataItem.Id.ToString() + "&qurter=2";
                    Q3Label.NavigateUrl = "PreventiveMaintenanceReportMobileService_2_1_2_2_3/default.aspx?SiteId=" + dataItem.Id.ToString() + "&qurter=3";
                    Q4Label.NavigateUrl = "PreventiveMaintenanceReportMobileService_2_1_2_2_3/default.aspx?SiteId=" + dataItem.Id.ToString() + "&qurter=4";
                    //HyperLink1.NavigateUrl = "PreventiveMaintenanceReportMobileService_2_1_2_2_3/default.aspx?SiteId=" + dataItem.Id.ToString();
                    preview1.NavigateUrl = "PreventiveMaintenanceReportMobileService_2_1_2_2_3/preview.aspx?SiteId=" + dataItem.Id.ToString() + "&qurter=1";
                    preview2.NavigateUrl = "PreventiveMaintenanceReportMobileService_2_1_2_2_3/preview.aspx?SiteId=" + dataItem.Id.ToString() + "&qurter=2";
                    preview3.NavigateUrl = "PreventiveMaintenanceReportMobileService_2_1_2_2_3/preview.aspx?SiteId=" + dataItem.Id.ToString() + "&qurter=3";
                    preview4.NavigateUrl = "PreventiveMaintenanceReportMobileService_2_1_2_2_3/preview.aspx?SiteId=" + dataItem.Id.ToString() + "&qurter=4";
                    break;
            }



            //HyperLink Q1Label = e.Item.FindControl("Q1Label") as HyperLink;
            //Q1Label.Text = dataItem.SRs.Where(x => x.Quarter == 1).Count() > 0 ? "กรอกเเล้ว" : "ยังไม่กรอก";
            //HyperLink Q2Label = e.Item.FindControl("Q2Label") as HyperLink;
            //Q2Label.Text = dataItem.SRs.Where(x => x.Quarter == 2).Count() > 0 ? "กรอกเเล้ว" : "ยังไม่กรอก";
            //HyperLink Q3Label = e.Item.FindControl("Q3Label") as HyperLink;
            //Q3Label.Text = dataItem.SRs.Where(x => x.Quarter == 3).Count() > 0 ? "กรอกเเล้ว" : "ยังไม่กรอก";
            //HyperLink Q4Label = e.Item.FindControl("Q4Label") as HyperLink;
            //Q4Label.Text = dataItem.SRs.Where(x => x.Quarter == 4).Count() > 0 ? "กรอกเเล้ว" : "ยังไม่กรอก";









        }
    }


}