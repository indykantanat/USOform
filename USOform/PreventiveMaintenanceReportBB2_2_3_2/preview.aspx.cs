using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CommonClassLibrary;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace USOform.PreventiveMaintenanceReportBB2_2_3_2
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
                //string ansMonth = Request["AnsMonth"] != null ? Request["AnsMonth"] : DateTime.Now.ToString("yyyyMM", CultureInfo.GetCultureInfo("en-US"));
                long siteId = long.Parse(Request["SiteId"]);
                int currentQuarter = this.GetQuarter(DateTime.Now);
                SR sR = uSOEntities.SRs.Where(x => x.Quarter == currentQuarter && x.SiteId == siteId && x.Status == 1).FirstOrDefault();
                if (sR != null)
                {
                    answers = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id).ToList();
                    if (answers.Count() > 0)
                    {
                        SetForm();
                    }
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

        void SetForm()
        {
            this.GroupNameLabel.Text = answers.Where(x => x.QuestionId == 736).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 736).FirstOrDefault().AnsDes : "";
            this.AreaLabel.Text = answers.Where(x => x.QuestionId == 737).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 737).FirstOrDefault().AnsDes : "";
            this.CompanyLabel.Text = answers.Where(x => x.QuestionId == 738).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 738).FirstOrDefault().AnsDes : "";
            this.maintenanceCountLabel.Text = answers.Where(x => x.QuestionId == 740).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 740).FirstOrDefault().AnsDes : "";
            this.yearLabel.Text = answers.Where(x => x.QuestionId == 741).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 741).FirstOrDefault().AnsDes : "";
            this.startDatepickerLabel.Text = answers.Where(x => x.QuestionId == 742).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 742).FirstOrDefault().AnsDes : "";
            this.endDatepickerLabel.Text = answers.Where(x => x.QuestionId == 743).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 743).FirstOrDefault().AnsDes : "";
            this.siteCodeLabel.Text = answers.Where(x => x.QuestionId == 744).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 744).FirstOrDefault().AnsDes : "";
            this.cabinetIdLabel.Text = answers.Where(x => x.QuestionId == 746).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 746).FirstOrDefault().AnsDes : "";
            this.sitecodeLabelSection2.Text = answers.Where(x => x.QuestionId == 747).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 747).FirstOrDefault().AnsDes : "";
            this.VillageIdLabel.Text = answers.Where(x => x.QuestionId == 748).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 748).FirstOrDefault().AnsDes : "";
            this.villageLabel.Text = answers.Where(x => x.QuestionId == 749).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 749).FirstOrDefault().AnsDes : "";
            this.schoolnameLabel.Text = answers.Where(x => x.QuestionId == 750).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 750).FirstOrDefault().AnsDes : "";
            this.subdistrictLabel.Text = answers.Where(x => x.QuestionId == 751).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 751).FirstOrDefault().AnsDes : "";
            this.districtLabel.Text = answers.Where(x => x.QuestionId == 752).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 752).FirstOrDefault().AnsDes : "";
            this.provinceLabel.Text = answers.Where(x => x.QuestionId == 753).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 753).FirstOrDefault().AnsDes : "";
            this.typeLabel.Text = answers.Where(x => x.QuestionId == 754).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 754).FirstOrDefault().AnsDes : "";
            this.pmdateLabel.Text = answers.Where(x => x.QuestionId == 755).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 755).FirstOrDefault().AnsDes : "";
            // this.signatureExecutorLabel.Text = answers.Where(x => x.QuestionId == 758).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 758).FirstOrDefault().AnsDes : "";
            //this.signatureSupervisorLabel.Text = answers.Where(x => x.QuestionId == 759).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 759).FirstOrDefault().AnsDes : "";
            this.nameExecutorLabel.Text = answers.Where(x => x.QuestionId == 760).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 760).FirstOrDefault().AnsDes : "";
            this.nameSupervisorLabel.Text = answers.Where(x => x.QuestionId == 761).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 761).FirstOrDefault().AnsDes : "";
            this.DateExecutorLabel.Text = answers.Where(x => x.QuestionId == 762).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 762).FirstOrDefault().AnsDes : "";
            this.DateSupervisorLabel.Text = answers.Where(x => x.QuestionId == 763).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 763).FirstOrDefault().AnsDes : "";
            this.LocationnameLabel.Text = answers.Where(x => x.QuestionId == 764).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 764).FirstOrDefault().AnsDes : "";
            this.sitecodeLabelSection4.Text = answers.Where(x => x.QuestionId == 765).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 765).FirstOrDefault().AnsDes : "";
            this.villageIDLabelSection4.Text = answers.Where(x => x.QuestionId == 766).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 766).FirstOrDefault().AnsDes : "";
            this.latandlongLabel.Text = answers.Where(x => x.QuestionId == 767).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 767).FirstOrDefault().AnsDes : "";
            this.oltidLabel.Text = answers.Where(x => x.QuestionId == 769).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 769).FirstOrDefault().AnsDes : "";
            this.numberuserLabel.Text = answers.Where(x => x.QuestionId == 772).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 772).FirstOrDefault().AnsDes : "";
            this.kwhMeterLabel.Text = answers.Where(x => x.QuestionId == 773).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 773).FirstOrDefault().AnsDes : "";
            this.acLabel.Text = answers.Where(x => x.QuestionId == 774).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 774).FirstOrDefault().AnsDes : "";
            this.lineAcLabel.Text = answers.Where(x => x.QuestionId == 775).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 775).FirstOrDefault().AnsDes : "";
            this.neutronacLabel.Text = answers.Where(x => x.QuestionId == 776).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 776).FirstOrDefault().AnsDes : "";
            this.acfromupsLabel.Text = answers.Where(x => x.QuestionId == 780).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 780).FirstOrDefault().AnsDes : "";
            this.electricloadLabel.Text = answers.Where(x => x.QuestionId == 781).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 781).FirstOrDefault().AnsDes : "";
            this.battFirealarm1Label.Text = answers.Where(x => x.QuestionId == 800).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 800).FirstOrDefault().AnsDes : "";
            this.battFirealarm3Label.Text = answers.Where(x => x.QuestionId == 801).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 801).FirstOrDefault().AnsDes : "";
            this.voltageInverterLabel.Text = answers.Where(x => x.QuestionId == 850).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 850).FirstOrDefault().AnsDes : "";
            this.voltageLoadLabel.Text = answers.Where(x => x.QuestionId == 851).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 851).FirstOrDefault().AnsDes : "";
            this.dowloadforOnuLabel.Text = answers.Where(x => x.QuestionId == 852).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 852).FirstOrDefault().AnsDes : "";
            this.uploadforOnuLabel.Text = answers.Where(x => x.QuestionId == 853).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 853).FirstOrDefault().AnsDes : "";
            this.pingTestLabel.Text = answers.Where(x => x.QuestionId == 854).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 854).FirstOrDefault().AnsDes : "";
            this.dowloadForwifiLabel.Text = answers.Where(x => x.QuestionId == 855).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 855).FirstOrDefault().AnsDes : "";
            this.uploadForwifiLabel.Text = answers.Where(x => x.QuestionId == 856).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 856).FirstOrDefault().AnsDes : "";
            this.pingtestForwifiLabel.Text = answers.Where(x => x.QuestionId == 857).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 857).FirstOrDefault().AnsDes : "";
            this.dowlaodForlanLabel.Text = answers.Where(x => x.QuestionId == 858).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 858).FirstOrDefault().AnsDes : "";
            this.uploadForlandLabel.Text = answers.Where(x => x.QuestionId == 859).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 859).FirstOrDefault().AnsDes : "";
            this.pingtestForlanLabel.Text = answers.Where(x => x.QuestionId == 860).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 860).FirstOrDefault().AnsDes : "";

            this.problemLabel1.Text = answers.Where(x => x.QuestionId == 861).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 861).FirstOrDefault().AnsDes : "";
            this.howtoSolveLabel1.Text = answers.Where(x => x.QuestionId == 862).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 862).FirstOrDefault().AnsDes : "";
            this.problemLabel2.Text = answers.Where(x => x.QuestionId == 863).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 863).FirstOrDefault().AnsDes : "";
            this.howtoSolveLabel2.Text = answers.Where(x => x.QuestionId == 864).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 864).FirstOrDefault().AnsDes : "";
            this.problemLabel3.Text = answers.Where(x => x.QuestionId == 865).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 865).FirstOrDefault().AnsDes : "";
            this.howtoSolveLabel3.Text = answers.Where(x => x.QuestionId == 866).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 866).FirstOrDefault().AnsDes : "";
            this.problemLabel4.Text = answers.Where(x => x.QuestionId == 867).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 867).FirstOrDefault().AnsDes : "";
            this.howtoSolveLabel4.Text = answers.Where(x => x.QuestionId == 868).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 868).FirstOrDefault().AnsDes : "";
            this.problemLabel5.Text = answers.Where(x => x.QuestionId == 869).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 869).FirstOrDefault().AnsDes : "";
            this.howtoSolveLabel5.Text = answers.Where(x => x.QuestionId == 870).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 870).FirstOrDefault().AnsDes : "";
            this.problemLabel6.Text = answers.Where(x => x.QuestionId == 871).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 871).FirstOrDefault().AnsDes : "";
            this.howtoSolveLabel6.Text = answers.Where(x => x.QuestionId == 872).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 872).FirstOrDefault().AnsDes : "";
            this.problemLabel7.Text = answers.Where(x => x.QuestionId == 873).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 873).FirstOrDefault().AnsDes : "";
            this.howtoSolveLabel7.Text = answers.Where(x => x.QuestionId == 874).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 874).FirstOrDefault().AnsDes : "";
            this.problemLabel8.Text = answers.Where(x => x.QuestionId == 875).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 875).FirstOrDefault().AnsDes : "";
            this.howtoSolveLabel8.Text = answers.Where(x => x.QuestionId == 876).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 876).FirstOrDefault().AnsDes : "";
            this.problemLabel9.Text = answers.Where(x => x.QuestionId == 877).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 877).FirstOrDefault().AnsDes : "";
            this.howtoSolveLabel9.Text = answers.Where(x => x.QuestionId == 878).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 878).FirstOrDefault().AnsDes : "";
            this.problemLabel10.Text = answers.Where(x => x.QuestionId == 879).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 879).FirstOrDefault().AnsDes : "";
            this.howtoSolveLabel10.Text = answers.Where(x => x.QuestionId == 880).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 880).FirstOrDefault().AnsDes : "";
            this.problemLabel11.Text = answers.Where(x => x.QuestionId == 881).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 881).FirstOrDefault().AnsDes : "";
            this.howtoSolveLabel11.Text = answers.Where(x => x.QuestionId == 882).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 882).FirstOrDefault().AnsDes : "";
            this.problemLabel12.Text = answers.Where(x => x.QuestionId == 883).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 883).FirstOrDefault().AnsDes : "";
            this.howtoSolveLabel12.Text = answers.Where(x => x.QuestionId == 884).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 884).FirstOrDefault().AnsDes : "";
            this.problemLabel13.Text = answers.Where(x => x.QuestionId == 885).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 885).FirstOrDefault().AnsDes : "";
            this.howtoSolveLabel13.Text = answers.Where(x => x.QuestionId == 886).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 886).FirstOrDefault().AnsDes : "";
            this.problemLabel14.Text = answers.Where(x => x.QuestionId == 887).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 887).FirstOrDefault().AnsDes : "";
            this.howtoSolveLabel14.Text = answers.Where(x => x.QuestionId == 888).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 888).FirstOrDefault().AnsDes : "";
            this.problemLabel15.Text = answers.Where(x => x.QuestionId == 889).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 889).FirstOrDefault().AnsDes : "";
            this.howtoSolveLabel15.Text = answers.Where(x => x.QuestionId == 890).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 890).FirstOrDefault().AnsDes : "";

            this.toolsListLabel1.Text = answers.Where(x => x.QuestionId == 891).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 891).FirstOrDefault().AnsDes : "";
            this.serialNumberLabel1.Text = answers.Where(x => x.QuestionId == 892).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 892).FirstOrDefault().AnsDes : "";
            this.newSerialNumberLabel1.Text = answers.Where(x => x.QuestionId == 893).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 893).FirstOrDefault().AnsDes : "";
            this.noteLabel1.Text = answers.Where(x => x.QuestionId == 894).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 894).FirstOrDefault().AnsDes : "";
            this.toolsListLabel2.Text = answers.Where(x => x.QuestionId == 895).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 895).FirstOrDefault().AnsDes : "";
            this.serialNumberLabel2.Text = answers.Where(x => x.QuestionId == 896).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 896).FirstOrDefault().AnsDes : "";
            this.newSerialNumberLabel2.Text = answers.Where(x => x.QuestionId == 897).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 897).FirstOrDefault().AnsDes : "";
            this.noteLabel2.Text = answers.Where(x => x.QuestionId == 898).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 898).FirstOrDefault().AnsDes : "";
            this.toolsListLabel3.Text = answers.Where(x => x.QuestionId == 899).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 899).FirstOrDefault().AnsDes : "";
            this.serialNumberLabel3.Text = answers.Where(x => x.QuestionId == 900).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 900).FirstOrDefault().AnsDes : "";
            this.newSerialNumberLabel3.Text = answers.Where(x => x.QuestionId == 901).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 901).FirstOrDefault().AnsDes : "";
            this.noteLabel3.Text = answers.Where(x => x.QuestionId == 902).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 902).FirstOrDefault().AnsDes : "";
            this.toolsListLabel4.Text = answers.Where(x => x.QuestionId == 903).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 903).FirstOrDefault().AnsDes : "";
            this.serialNumberLabel4.Text = answers.Where(x => x.QuestionId == 904).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 904).FirstOrDefault().AnsDes : "";
            this.newSerialNumberLabel4.Text = answers.Where(x => x.QuestionId == 905).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 905).FirstOrDefault().AnsDes : "";
            this.noteLabel4.Text = answers.Where(x => x.QuestionId == 906).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 906).FirstOrDefault().AnsDes : "";
            this.toolsListLabel5.Text = answers.Where(x => x.QuestionId == 907).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 907).FirstOrDefault().AnsDes : "";
            this.serialNumberLabel5.Text = answers.Where(x => x.QuestionId == 908).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 908).FirstOrDefault().AnsDes : "";
            this.newSerialNumberLabel5.Text = answers.Where(x => x.QuestionId == 909).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 909).FirstOrDefault().AnsDes : "";
            this.noteLabel5.Text = answers.Where(x => x.QuestionId == 910).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 910).FirstOrDefault().AnsDes : "";
            this.toolsListLabel6.Text = answers.Where(x => x.QuestionId == 911).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 911).FirstOrDefault().AnsDes : "";
            this.serialNumberLabel6.Text = answers.Where(x => x.QuestionId == 912).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 912).FirstOrDefault().AnsDes : "";
            this.newSerialNumberLabel6.Text = answers.Where(x => x.QuestionId == 913).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 913).FirstOrDefault().AnsDes : "";
            this.noteLabel6.Text = answers.Where(x => x.QuestionId == 914).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 914).FirstOrDefault().AnsDes : "";
            this.toolsListLabel7.Text = answers.Where(x => x.QuestionId == 915).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 915).FirstOrDefault().AnsDes : "";
            this.serialNumberLabel7.Text = answers.Where(x => x.QuestionId == 916).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 916).FirstOrDefault().AnsDes : "";
            this.newSerialNumberLabel7.Text = answers.Where(x => x.QuestionId == 917).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 917).FirstOrDefault().AnsDes : "";
            this.noteLabel7.Text = answers.Where(x => x.QuestionId == 918).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 918).FirstOrDefault().AnsDes : "";
            this.toolsListLabel8.Text = answers.Where(x => x.QuestionId == 919).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 919).FirstOrDefault().AnsDes : "";
            this.serialNumberLabel8.Text = answers.Where(x => x.QuestionId == 920).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 920).FirstOrDefault().AnsDes : "";
            this.newSerialNumberLabel8.Text = answers.Where(x => x.QuestionId == 921).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 921).FirstOrDefault().AnsDes : "";
            this.noteLabel8.Text = answers.Where(x => x.QuestionId == 922).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 922).FirstOrDefault().AnsDes : "";
            this.toolsListLabel9.Text = answers.Where(x => x.QuestionId == 923).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 923).FirstOrDefault().AnsDes : "";
            this.serialNumberLabel9.Text = answers.Where(x => x.QuestionId == 924).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 924).FirstOrDefault().AnsDes : "";
            this.newSerialNumberLabel9.Text = answers.Where(x => x.QuestionId == 925).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 925).FirstOrDefault().AnsDes : "";
            this.noteLabel9.Text = answers.Where(x => x.QuestionId == 926).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 926).FirstOrDefault().AnsDes : "";
            this.toolsListLabel10.Text = answers.Where(x => x.QuestionId == 927).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 927).FirstOrDefault().AnsDes : "";
            this.serialNumberLabel10.Text = answers.Where(x => x.QuestionId == 928).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 928).FirstOrDefault().AnsDes : "";
            this.newSerialNumberLabel10.Text = answers.Where(x => x.QuestionId == 929).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 929).FirstOrDefault().AnsDes : "";
            this.noteLabel10.Text = answers.Where(x => x.QuestionId == 930).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 930).FirstOrDefault().AnsDes : "";
            this.toolsListLabel11.Text = answers.Where(x => x.QuestionId == 931).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 931).FirstOrDefault().AnsDes : "";
            this.serialNumberLabel11.Text = answers.Where(x => x.QuestionId == 932).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 932).FirstOrDefault().AnsDes : "";
            this.newSerialNumberLabel11.Text = answers.Where(x => x.QuestionId == 933).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 933).FirstOrDefault().AnsDes : "";
            this.noteLabel11.Text = answers.Where(x => x.QuestionId == 934).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 934).FirstOrDefault().AnsDes : "";
            this.toolsListLabel12.Text = answers.Where(x => x.QuestionId == 935).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 935).FirstOrDefault().AnsDes : "";
            this.serialNumberLabel12.Text = answers.Where(x => x.QuestionId == 936).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 936).FirstOrDefault().AnsDes : "";
            this.newSerialNumberLabel12.Text = answers.Where(x => x.QuestionId == 937).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 937).FirstOrDefault().AnsDes : "";
            this.noteLabel12.Text = answers.Where(x => x.QuestionId == 938).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 938).FirstOrDefault().AnsDes : "";
            this.toolsListLabel13.Text = answers.Where(x => x.QuestionId == 939).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 939).FirstOrDefault().AnsDes : "";
            this.serialNumberLabel13.Text = answers.Where(x => x.QuestionId == 940).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 940).FirstOrDefault().AnsDes : "";
            this.newSerialNumberLabel13.Text = answers.Where(x => x.QuestionId == 941).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 941).FirstOrDefault().AnsDes : "";
            this.noteLabel13.Text = answers.Where(x => x.QuestionId == 942).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 942).FirstOrDefault().AnsDes : "";
            this.toolsListLabel14.Text = answers.Where(x => x.QuestionId == 943).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 943).FirstOrDefault().AnsDes : "";
            this.serialNumberLabel14.Text = answers.Where(x => x.QuestionId == 944).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 944).FirstOrDefault().AnsDes : "";
            this.newSerialNumberLabel14.Text = answers.Where(x => x.QuestionId == 945).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 945).FirstOrDefault().AnsDes : "";
            this.noteLabel14.Text = answers.Where(x => x.QuestionId == 946).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 946).FirstOrDefault().AnsDes : "";
            this.toolsListLabel15.Text = answers.Where(x => x.QuestionId == 947).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 947).FirstOrDefault().AnsDes : "";
            this.serialNumberLabel15.Text = answers.Where(x => x.QuestionId == 948).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 948).FirstOrDefault().AnsDes : "";
            this.newSerialNumberLabel15.Text = answers.Where(x => x.QuestionId == 949).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 949).FirstOrDefault().AnsDes : "";
            this.noteLabel15.Text = answers.Where(x => x.QuestionId == 950).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 950).FirstOrDefault().AnsDes : "";

            this.nameTeampmLabel.Text = answers.Where(x => x.QuestionId == 951).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 951).FirstOrDefault().AnsDes : "";
            this.dayDopmLabel.Text = answers.Where(x => x.QuestionId == 952).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 952).FirstOrDefault().AnsDes : "";
            this.nameAgentareaLabel.Text = answers.Where(x => x.QuestionId == 953).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 953).FirstOrDefault().AnsDes : "";
            this.telephoneAgentLabel.Text = answers.Where(x => x.QuestionId == 954).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 954).FirstOrDefault().AnsDes : "";
        }

        int GetQuarter(DateTime dt)
        {
            return (dt.Month - 1) / 3 + 1;
        }

    }
}