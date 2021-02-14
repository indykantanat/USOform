using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using CommonClassLibrary;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Drawing;

namespace USOform.PreventiveMaintenanceReportBB2_3_3_3
{
    public partial class preview : System.Web.UI.Page
    {
        USOEntities uSOEntities;
        public List<Answer> answers;

        public preview()
        {
            uSOEntities = new USOEntities();
            answers = new List<Answer>();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            User user = (User)Session["strUsername"];
            if (user != null)
            {
                long siteId = long.Parse(Request["SiteId"]);
                int currentQuarter = this.GetQuarter(DateTime.Now);
                SR sR = uSOEntities.SRs.Where(x => x.Quarter == currentQuarter && x.SiteId == siteId && x.Status == 1).FirstOrDefault();
                if (sR != null)
                {
                    answers = uSOEntities.Answers.Where(x => x.SRId == sR.Id).ToList();

                }
            }
            else
            {
                Response.Redirect("~/login/login.aspx");
                Response.End();
            }

            if (!IsPostBack)
            {
                if (answers.Count() > 0)
                {
                    SetForm();
                }

            }
        }

        int GetQuarter(DateTime dt)
        {
            return (dt.Month - 1) / 3 + 1;
        }




        void SetForm()
        {
            this.groupLabel.Text = answers.Where(x => x.QuestionId == 484).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 484).FirstOrDefault().AnsDes : "";
            this.AreaLabel.Text = answers.Where(x => x.QuestionId == 485).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 485).FirstOrDefault().AnsDes : "";
            this.CompanyLabel.Text = answers.Where(x => x.QuestionId == 486).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 485).FirstOrDefault().AnsDes : "";
            this.maintenanceCountLabel.Text = answers.Where(x => x.QuestionId == 488).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 488).FirstOrDefault().AnsDes : "";
            this.yearLabel.Text = answers.Where(x => x.QuestionId == 489).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 489).FirstOrDefault().AnsDes : "";
            this.startDatepickerLabel.Text = answers.Where(x => x.QuestionId == 490).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 490).FirstOrDefault().AnsDes : "";
            this.endDatepickerLabel.Text = answers.Where(x => x.QuestionId == 491).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 491).FirstOrDefault().AnsDes : "";
            this.siteCodeLabel.Text = answers.Where(x => x.QuestionId == 1640).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1640).FirstOrDefault().AnsDes : "";
            this.cabinetIdLabel.Text = answers.Where(x => x.QuestionId == 492).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 492).FirstOrDefault().AnsDes : "";
            this.sitecodeLabelSection2.Text = answers.Where(x => x.QuestionId == 493).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 493).FirstOrDefault().AnsDes : "";
            this.VillageIdLabel.Text = answers.Where(x => x.QuestionId == 494).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 494).FirstOrDefault().AnsDes : "";
            this.villageLabel.Text = answers.Where(x => x.QuestionId == 495).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 495).FirstOrDefault().AnsDes : "";
            this.schoolNameLabel.Text = answers.Where(x => x.QuestionId == 496).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 496).FirstOrDefault().AnsDes : "";
            this.subdistrictLabel.Text = answers.Where(x => x.QuestionId == 497).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 497).FirstOrDefault().AnsDes : "";
            this.DistrictLabelEIEI.Text = answers.Where(x => x.QuestionId == 498).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 498).FirstOrDefault().AnsDes : "";
            this.provinceLabel.Text = answers.Where(x => x.QuestionId == 499).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 499).FirstOrDefault().AnsDes : "";
            this.typeLabel.Text = answers.Where(x => x.QuestionId == 500).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 500).FirstOrDefault().AnsDes : "";
            this.pmdateLabel.Text = answers.Where(x => x.QuestionId == 501).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 501).FirstOrDefault().AnsDes : "";
            //this.signatureExecutorLabel.Text = answers.Where(x => x.QuestionId == 504).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 504).FirstOrDefault().AnsDes : "";
            //this.signatureSupervisorLabel.Text = answers.Where(x => x.QuestionId == 505).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 505).FirstOrDefault().AnsDes : "";
            this.nameExecutorLabel.Text = answers.Where(x => x.QuestionId == 506).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 506).FirstOrDefault().AnsDes : "";
            this.nameSupervisorLabel.Text = answers.Where(x => x.QuestionId == 507).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 507).FirstOrDefault().AnsDes : "";
            this.DateExecutorLabel.Text = answers.Where(x => x.QuestionId == 508).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 508).FirstOrDefault().AnsDes : "";
            this.DateSupervisorLabel.Text = answers.Where(x => x.QuestionId == 509).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 509).FirstOrDefault().AnsDes : "";
            this.cabinetId2Label.Text = answers.Where(x => x.QuestionId == 510).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 510).FirstOrDefault().AnsDes : "";
            this.sitecodeLabelSection4.Text = answers.Where(x => x.QuestionId == 511).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 511).FirstOrDefault().AnsDes : "";
            this.villageIDLabelSection4.Text = answers.Where(x => x.QuestionId == 512).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 512).FirstOrDefault().AnsDes : "";
            this.latandlongLabel.Text = answers.Where(x => x.QuestionId == 513).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 513).FirstOrDefault().AnsDes : "";
            this.oltIdLabel.Text = answers.Where(x => x.QuestionId == 515).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 515).FirstOrDefault().AnsDes : "";
            this.numberIdLabel.Text = answers.Where(x => x.QuestionId == 517).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 517).FirstOrDefault().AnsDes : "";
            this.kwhMeterLabel.Text = answers.Where(x => x.QuestionId == 518).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 518).FirstOrDefault().AnsDes : "";
            this.acvoltLabel.Text = answers.Where(x => x.QuestionId == 519).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 519).FirstOrDefault().AnsDes : "";
            this.lineAcLabel.Text = answers.Where(x => x.QuestionId == 520).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 520).FirstOrDefault().AnsDes : "";
            this.neutronAcEIEILabel.Text = answers.Where(x => x.QuestionId == 521).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 521).FirstOrDefault().AnsDes : "";
            this.neutronAcEIEILabel.Text = answers.Where(x => x.QuestionId == 521).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 521).FirstOrDefault().AnsDes : "";
            this.acfromupsLabel.Text = answers.Where(x => x.QuestionId == 525).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 525).FirstOrDefault().AnsDes : "";
            this.voltInverterLabel.Text = answers.Where(x => x.QuestionId == 576).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 576).FirstOrDefault().AnsDes : "";
            this.loadVoltTageLabel.Text = answers.Where(x => x.QuestionId == 577).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 577).FirstOrDefault().AnsDes : "";
            this.batterLabel1.Text = answers.Where(x => x.QuestionId == 578).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 578).FirstOrDefault().AnsDes : "";
            this.batterLabel2.Text = answers.Where(x => x.QuestionId == 579).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 579).FirstOrDefault().AnsDes : "";
            this.batterLabel3.Text = answers.Where(x => x.QuestionId == 580).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 580).FirstOrDefault().AnsDes : "";
            this.batterLabel4.Text = answers.Where(x => x.QuestionId == 581).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 581).FirstOrDefault().AnsDes : "";
            this.dowloadOnuLabel.Text = answers.Where(x => x.QuestionId == 582).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 582).FirstOrDefault().AnsDes : "";
            this.uploadforOnuLabel.Text = answers.Where(x => x.QuestionId == 583).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 583).FirstOrDefault().AnsDes : "";
            this.pinngtestforOnuLabel.Text = answers.Where(x => x.QuestionId == 584).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 584).FirstOrDefault().AnsDes : "";
            this.dowloadforMobileLabel.Text = answers.Where(x => x.QuestionId == 585).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 585).FirstOrDefault().AnsDes : "";
            this.uploadforMobileLabel.Text = answers.Where(x => x.QuestionId == 586).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 586).FirstOrDefault().AnsDes : "";
            this.pingtestFormobileLabel.Text = answers.Where(x => x.QuestionId == 587).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 587).FirstOrDefault().AnsDes : "";

            //  ปัญหาที่พบและวิธีการแก้ปัญหา 
            this.problemLabel1.Text = answers.Where(x => x.QuestionId == 588).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 588).FirstOrDefault().AnsDes : "";
            this.howtoSolveLabel1.Text = answers.Where(x => x.QuestionId == 589).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 589).FirstOrDefault().AnsDes : "";
            this.problemLabel2.Text = answers.Where(x => x.QuestionId == 590).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 590).FirstOrDefault().AnsDes : "";
            this.howtoSolveLabel2.Text = answers.Where(x => x.QuestionId == 591).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 591).FirstOrDefault().AnsDes : "";
            this.problemLabel3.Text = answers.Where(x => x.QuestionId == 592).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 592).FirstOrDefault().AnsDes : "";
            this.howtoSolveLabel3.Text = answers.Where(x => x.QuestionId == 593).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 593).FirstOrDefault().AnsDes : "";
            this.problemLabel4.Text = answers.Where(x => x.QuestionId == 594).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 594).FirstOrDefault().AnsDes : "";
            this.howtoSolveLabel4.Text = answers.Where(x => x.QuestionId == 595).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 595).FirstOrDefault().AnsDes : "";
            this.problemLabel5.Text = answers.Where(x => x.QuestionId == 596).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 596).FirstOrDefault().AnsDes : "";
            this.howtoSolveLabel5.Text = answers.Where(x => x.QuestionId == 597).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 597).FirstOrDefault().AnsDes : "";
            this.problemLabel6.Text = answers.Where(x => x.QuestionId == 598).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 598).FirstOrDefault().AnsDes : "";
            this.howtoSolveLabel6.Text = answers.Where(x => x.QuestionId == 599).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 599).FirstOrDefault().AnsDes : "";
            this.problemLabel7.Text = answers.Where(x => x.QuestionId == 600).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 600).FirstOrDefault().AnsDes : "";
            this.howtoSolveLabel7.Text = answers.Where(x => x.QuestionId == 601).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 601).FirstOrDefault().AnsDes : "";
            this.problemLabel8.Text = answers.Where(x => x.QuestionId == 602).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 602).FirstOrDefault().AnsDes : "";
            this.howtoSolveLabel8.Text = answers.Where(x => x.QuestionId == 603).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 603).FirstOrDefault().AnsDes : "";
            this.problemLabel9.Text = answers.Where(x => x.QuestionId == 604).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 604).FirstOrDefault().AnsDes : "";
            this.howtoSolveLabel9.Text = answers.Where(x => x.QuestionId == 605).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 605).FirstOrDefault().AnsDes : "";
            this.problemLabel10.Text = answers.Where(x => x.QuestionId == 606).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 606).FirstOrDefault().AnsDes : "";
            this.howtoSolveLabel10.Text = answers.Where(x => x.QuestionId == 607).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 607).FirstOrDefault().AnsDes : "";
            this.problemLabel11.Text = answers.Where(x => x.QuestionId == 608).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 608).FirstOrDefault().AnsDes : "";
            this.howtoSolveLabel11.Text = answers.Where(x => x.QuestionId == 609).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 609).FirstOrDefault().AnsDes : "";
            this.problemLabel12.Text = answers.Where(x => x.QuestionId == 610).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 610).FirstOrDefault().AnsDes : "";
            this.howtoSolveLabel12.Text = answers.Where(x => x.QuestionId == 611).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 611).FirstOrDefault().AnsDes : "";
            this.problemLabel13.Text = answers.Where(x => x.QuestionId == 612).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 612).FirstOrDefault().AnsDes : "";
            this.howtoSolveLabel13.Text = answers.Where(x => x.QuestionId == 613).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 613).FirstOrDefault().AnsDes : "";
            this.problemLabel14.Text = answers.Where(x => x.QuestionId == 614).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 614).FirstOrDefault().AnsDes : "";
            this.howtoSolveLabel14.Text = answers.Where(x => x.QuestionId == 615).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 615).FirstOrDefault().AnsDes : "";
            this.problemLabel15.Text = answers.Where(x => x.QuestionId == 616).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 616).FirstOrDefault().AnsDes : "";
            this.howtoSolveLabel15.Text = answers.Where(x => x.QuestionId == 617).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 617).FirstOrDefault().AnsDes : "";

            // รายการอุปกรณ์
            this.toolsListLabel1.Text = answers.Where(x => x.QuestionId == 618).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 618).FirstOrDefault().AnsDes : "";
            this.serialNumberLabel1.Text = answers.Where(x => x.QuestionId == 619).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 619).FirstOrDefault().AnsDes : "";
            this.newSerialNumberLabel1.Text = answers.Where(x => x.QuestionId == 620).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 620).FirstOrDefault().AnsDes : "";
            this.noteLabel1.Text = answers.Where(x => x.QuestionId == 621).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 621).FirstOrDefault().AnsDes : "";
            this.toolsListLabel2.Text = answers.Where(x => x.QuestionId == 622).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 622).FirstOrDefault().AnsDes : "";
            this.serialNumberLabel2.Text = answers.Where(x => x.QuestionId == 623).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 623).FirstOrDefault().AnsDes : "";
            this.newSerialNumberLabel2.Text = answers.Where(x => x.QuestionId == 624).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 624).FirstOrDefault().AnsDes : "";
            this.noteLabel2.Text = answers.Where(x => x.QuestionId == 625).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 625).FirstOrDefault().AnsDes : "";
            this.toolsListLabel3.Text = answers.Where(x => x.QuestionId == 626).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 626).FirstOrDefault().AnsDes : "";
            this.serialNumberLabel3.Text = answers.Where(x => x.QuestionId == 627).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 627).FirstOrDefault().AnsDes : "";
            this.newSerialNumberLabel3.Text = answers.Where(x => x.QuestionId == 628).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 628).FirstOrDefault().AnsDes : "";
            this.noteLabel3.Text = answers.Where(x => x.QuestionId == 629).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 629).FirstOrDefault().AnsDes : "";
            this.toolsListLabel4.Text = answers.Where(x => x.QuestionId == 630).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 630).FirstOrDefault().AnsDes : "";
            this.serialNumberLabel4.Text = answers.Where(x => x.QuestionId == 631).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 631).FirstOrDefault().AnsDes : "";
            this.newSerialNumberLabel4.Text = answers.Where(x => x.QuestionId == 632).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 632).FirstOrDefault().AnsDes : "";
            this.noteLabel4.Text = answers.Where(x => x.QuestionId == 633).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 633).FirstOrDefault().AnsDes : "";
            this.toolsListLabel5.Text = answers.Where(x => x.QuestionId == 634).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 634).FirstOrDefault().AnsDes : "";
            this.serialNumberLabel5.Text = answers.Where(x => x.QuestionId == 635).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 635).FirstOrDefault().AnsDes : "";
            this.newSerialNumberLabel5.Text = answers.Where(x => x.QuestionId == 636).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 636).FirstOrDefault().AnsDes : "";
            this.noteLabel5.Text = answers.Where(x => x.QuestionId == 637).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 637).FirstOrDefault().AnsDes : "";
            this.toolsListLabel6.Text = answers.Where(x => x.QuestionId == 638).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 638).FirstOrDefault().AnsDes : "";
            this.serialNumberLabel6.Text = answers.Where(x => x.QuestionId == 639).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 639).FirstOrDefault().AnsDes : "";
            this.newSerialNumberLabel6.Text = answers.Where(x => x.QuestionId == 640).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 640).FirstOrDefault().AnsDes : "";
            this.noteLabel6.Text = answers.Where(x => x.QuestionId == 641).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 641).FirstOrDefault().AnsDes : "";
            this.toolsListLabel7.Text = answers.Where(x => x.QuestionId == 642).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 642).FirstOrDefault().AnsDes : "";
            this.serialNumberLabel7.Text = answers.Where(x => x.QuestionId == 643).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 643).FirstOrDefault().AnsDes : "";
            this.newSerialNumberLabel7.Text = answers.Where(x => x.QuestionId == 644).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 644).FirstOrDefault().AnsDes : "";
            this.noteLabel7.Text = answers.Where(x => x.QuestionId == 645).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 645).FirstOrDefault().AnsDes : "";
            this.toolsListLabel8.Text = answers.Where(x => x.QuestionId == 646).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 646).FirstOrDefault().AnsDes : "";
            this.serialNumberLabel8.Text = answers.Where(x => x.QuestionId == 647).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 647).FirstOrDefault().AnsDes : "";
            this.newSerialNumberLabel8.Text = answers.Where(x => x.QuestionId == 648).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 648).FirstOrDefault().AnsDes : "";
            this.noteLabel7.Text = answers.Where(x => x.QuestionId == 649).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 649).FirstOrDefault().AnsDes : "";
            this.toolsListLabel9.Text = answers.Where(x => x.QuestionId == 650).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 650).FirstOrDefault().AnsDes : "";
            this.serialNumberLabel9.Text = answers.Where(x => x.QuestionId == 651).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 651).FirstOrDefault().AnsDes : "";
            this.newSerialNumberLabel9.Text = answers.Where(x => x.QuestionId == 652).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 652).FirstOrDefault().AnsDes : "";
            this.noteLabel9.Text = answers.Where(x => x.QuestionId == 653).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 653).FirstOrDefault().AnsDes : "";
            this.toolsListLabel10.Text = answers.Where(x => x.QuestionId == 654).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 654).FirstOrDefault().AnsDes : "";
            this.serialNumberLabel10.Text = answers.Where(x => x.QuestionId == 655).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 655).FirstOrDefault().AnsDes : "";
            this.newSerialNumberLabel10.Text = answers.Where(x => x.QuestionId == 656).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 656).FirstOrDefault().AnsDes : "";
            this.noteLabel10.Text = answers.Where(x => x.QuestionId == 657).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 657).FirstOrDefault().AnsDes : "";
            this.toolsListLabel11.Text = answers.Where(x => x.QuestionId == 658).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 658).FirstOrDefault().AnsDes : "";
            this.serialNumberLabel11.Text = answers.Where(x => x.QuestionId == 659).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 659).FirstOrDefault().AnsDes : "";
            this.newSerialNumberLabel11.Text = answers.Where(x => x.QuestionId == 660).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 660).FirstOrDefault().AnsDes : "";
            this.noteLabel11.Text = answers.Where(x => x.QuestionId == 661).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 661).FirstOrDefault().AnsDes : "";
            this.toolsListLabel12.Text = answers.Where(x => x.QuestionId == 662).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 662).FirstOrDefault().AnsDes : "";
            this.serialNumberLabel12.Text = answers.Where(x => x.QuestionId == 663).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 663).FirstOrDefault().AnsDes : "";
            this.newSerialNumberLabel12.Text = answers.Where(x => x.QuestionId == 664).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 664).FirstOrDefault().AnsDes : "";
            this.noteLabel12.Text = answers.Where(x => x.QuestionId == 665).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 665).FirstOrDefault().AnsDes : "";
            this.toolsListLabel13.Text = answers.Where(x => x.QuestionId == 666).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 666).FirstOrDefault().AnsDes : "";
            this.serialNumberLabel13.Text = answers.Where(x => x.QuestionId == 667).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 667).FirstOrDefault().AnsDes : "";
            this.newSerialNumberLabel13.Text = answers.Where(x => x.QuestionId == 668).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 668).FirstOrDefault().AnsDes : "";
            this.noteLabel13.Text = answers.Where(x => x.QuestionId == 669).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 669).FirstOrDefault().AnsDes : "";
            this.toolsListLabel14.Text = answers.Where(x => x.QuestionId == 670).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 670).FirstOrDefault().AnsDes : "";
            this.serialNumberLabel14.Text = answers.Where(x => x.QuestionId == 671).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 671).FirstOrDefault().AnsDes : "";
            this.newSerialNumberLabel14.Text = answers.Where(x => x.QuestionId == 672).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 672).FirstOrDefault().AnsDes : "";
            this.noteLabel14.Text = answers.Where(x => x.QuestionId == 673).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 673).FirstOrDefault().AnsDes : "";
            this.toolsListLabel15.Text = answers.Where(x => x.QuestionId == 674).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 674).FirstOrDefault().AnsDes : "";
            this.serialNumberLabel15.Text = answers.Where(x => x.QuestionId == 675).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 675).FirstOrDefault().AnsDes : "";
            this.newSerialNumberLabel15.Text = answers.Where(x => x.QuestionId == 676).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 676).FirstOrDefault().AnsDes : "";
            this.noteLabel15.Text = answers.Where(x => x.QuestionId == 677).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 677).FirstOrDefault().AnsDes : "";



            this.nameDopmLabel.Text = answers.Where(x => x.QuestionId == 678).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 678).FirstOrDefault().AnsDes : "";
            this.dayDopmLabel.Text = answers.Where(x => x.QuestionId == 679).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 679).FirstOrDefault().AnsDes : "";
            // this.dayDopmLabel.Text = answers.Where(x => x.QuestionId == 679).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 679).FirstOrDefault().AnsDes : "";















        }



    }
}