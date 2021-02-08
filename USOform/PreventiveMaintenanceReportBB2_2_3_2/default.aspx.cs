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

namespace USOform.PreventiveMaintenanceReportBB2._2_3._2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        USOEntities uSOEntities;

        public List<Answer> answers;

        public WebForm1()
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






            //this.GetData();
            if (!IsPostBack)
            {

                if (answers.Count() > 0)
                {
                    SetForm();
                }
            }
            //*** Check login Status ***//
            //if (Convert.ToString(Session["strUsername"]) == "")
            //{
            //    Response.Redirect("/UsoLogin.aspx");
            //    Response.End();
            //}


        }

        void SetForm()
        {
            this.GroupNameTextBox.Value = answers.Where(x => x.QuestionId == 736).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 736).FirstOrDefault().AnsDes : "";
            this.AreaTextbox.Value = answers.Where(x => x.QuestionId == 737).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 737).FirstOrDefault().AnsDes : "";
            this.CompanyTextbox.Value = answers.Where(x => x.QuestionId == 738).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 738).FirstOrDefault().AnsDes : "";

            this.maintenanceCountTextbox.Value = answers.Where(x => x.QuestionId == 740).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 740).FirstOrDefault().AnsDes : "";
            this.yearTextbox.Value = answers.Where(x => x.QuestionId == 741).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 741).FirstOrDefault().AnsDes : "";
            this.startDatepicker.Value = answers.Where(x => x.QuestionId == 742).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 742).FirstOrDefault().AnsDes : "";
            this.endDatepicker.Value = answers.Where(x => x.QuestionId == 743).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 743).FirstOrDefault().AnsDes : "";
            this.siteCodeTextbox.Value = answers.Where(x => x.QuestionId == 744).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 744).FirstOrDefault().AnsDes : "";
            this.cabinetIdTextbox.Value = answers.Where(x => x.QuestionId == 746).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 746).FirstOrDefault().AnsDes : "";
            this.sitecodeTextboxSection2.Value = answers.Where(x => x.QuestionId == 747).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 747).FirstOrDefault().AnsDes : "";
            this.VillageIdTextbox.Value = answers.Where(x => x.QuestionId == 748).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 748).FirstOrDefault().AnsDes : "";
            this.villageTextbox.Value = answers.Where(x => x.QuestionId == 749).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 749).FirstOrDefault().AnsDes : "";
            this.schoolnameTextbox.Value = answers.Where(x => x.QuestionId == 750).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 750).FirstOrDefault().AnsDes : "";
            this.subdistrictTextbox.Value = answers.Where(x => x.QuestionId == 751).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 751).FirstOrDefault().AnsDes : "";
            this.districtTextbox.Value = answers.Where(x => x.QuestionId == 752).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 752).FirstOrDefault().AnsDes : "";
            this.provinceTextbox.Value = answers.Where(x => x.QuestionId == 753).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 753).FirstOrDefault().AnsDes : "";
            this.typeTextbox.Value = answers.Where(x => x.QuestionId == 754).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 754).FirstOrDefault().AnsDes : "";
            this.pmdateTextbox.Value = answers.Where(x => x.QuestionId == 755).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 755).FirstOrDefault().AnsDes : "";
           // this.signatureExecutorTextbox.Value = answers.Where(x => x.QuestionId == 758).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 758).FirstOrDefault().AnsDes : "";
            //this.signatureSupervisorTextbox.Value = answers.Where(x => x.QuestionId == 759).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 759).FirstOrDefault().AnsDes : "";
            this.nameExecutorTextbox.Value = answers.Where(x => x.QuestionId == 760).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 760).FirstOrDefault().AnsDes : "";
            this.nameSupervisorTextbox.Value = answers.Where(x => x.QuestionId == 761).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 761).FirstOrDefault().AnsDes : "";
            this.DateExecutorTextbox.Value = answers.Where(x => x.QuestionId == 762).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 762).FirstOrDefault().AnsDes : "";
            this.DateSupervisorTextbox.Value = answers.Where(x => x.QuestionId == 763).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 763).FirstOrDefault().AnsDes : "";
            this.LocationnameTextbox.Value = answers.Where(x => x.QuestionId == 764).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 764).FirstOrDefault().AnsDes : "";
            this.sitecodeTextboxSection4.Value = answers.Where(x => x.QuestionId == 765).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 765).FirstOrDefault().AnsDes : "";
            this.villageIDTextboxSection4.Value = answers.Where(x => x.QuestionId == 766).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 766).FirstOrDefault().AnsDes : "";
            this.latandlongTextbox.Value = answers.Where(x => x.QuestionId == 767).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 767).FirstOrDefault().AnsDes : "";
            this.oltidTextbox.Value = answers.Where(x => x.QuestionId == 769).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 769).FirstOrDefault().AnsDes : "";
            this.numberuserTextbox.Value = answers.Where(x => x.QuestionId == 772).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 772).FirstOrDefault().AnsDes : "";
            this.kwhMeterTextbox.Value = answers.Where(x => x.QuestionId == 773).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 773).FirstOrDefault().AnsDes : "";
            this.acTextbox.Value = answers.Where(x => x.QuestionId == 774).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 774).FirstOrDefault().AnsDes : "";
            this.lineAcTextbox.Value = answers.Where(x => x.QuestionId == 775).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 775).FirstOrDefault().AnsDes : "";
            this.neutronacTextbox.Value = answers.Where(x => x.QuestionId == 776).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 776).FirstOrDefault().AnsDes : "";
            this.acfromupsTextbox.Value = answers.Where(x => x.QuestionId == 780).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 780).FirstOrDefault().AnsDes : "";
            this.electricloadTextbox.Value = answers.Where(x => x.QuestionId == 781).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 781).FirstOrDefault().AnsDes : "";
            this.battFirealarm1Textbox.Value = answers.Where(x => x.QuestionId == 800).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 800).FirstOrDefault().AnsDes : "";
            this.battFirealarm3Textbox.Value = answers.Where(x => x.QuestionId == 801).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 801).FirstOrDefault().AnsDes : "";
            this.voltageInverterTextbox.Value = answers.Where(x => x.QuestionId == 850).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 850).FirstOrDefault().AnsDes : "";
            this.voltageLoadTextbox.Value = answers.Where(x => x.QuestionId == 851).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 851).FirstOrDefault().AnsDes : "";
            this.dowloadforOnuTextbox.Value = answers.Where(x => x.QuestionId == 852).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 852).FirstOrDefault().AnsDes : "";
            this.uploadforOnuTextbox.Value = answers.Where(x => x.QuestionId == 853).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 853).FirstOrDefault().AnsDes : "";
            this.pingTestTextbox.Value = answers.Where(x => x.QuestionId == 854).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 854).FirstOrDefault().AnsDes : "";
            this.dowloadForwifiTextbox.Value = answers.Where(x => x.QuestionId == 855).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 855).FirstOrDefault().AnsDes : "";
            this.uploadForwifiTextbox.Value = answers.Where(x => x.QuestionId == 856).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 856).FirstOrDefault().AnsDes : "";
            this.pingtestForwifiTextbox.Value = answers.Where(x => x.QuestionId == 857).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 857).FirstOrDefault().AnsDes : "";
            this.dowlaodForlanTextbox.Value = answers.Where(x => x.QuestionId == 858).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 858).FirstOrDefault().AnsDes : "";
            this.uploadForlandTextbox.Value = answers.Where(x => x.QuestionId == 859).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 859).FirstOrDefault().AnsDes : "";
            this.pingtestForlanTextbox.Value = answers.Where(x => x.QuestionId == 860).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 860).FirstOrDefault().AnsDes : "";

            this.problemTextbox1.Value = answers.Where(x => x.QuestionId == 861).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 861).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox1.Value = answers.Where(x => x.QuestionId == 862).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 862).FirstOrDefault().AnsDes : "";
            this.problemTextbox2.Value = answers.Where(x => x.QuestionId == 863).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 863).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox2.Value = answers.Where(x => x.QuestionId == 864).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 864).FirstOrDefault().AnsDes : "";
            this.problemTextbox3.Value = answers.Where(x => x.QuestionId == 865).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 865).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox3.Value = answers.Where(x => x.QuestionId == 866).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 866).FirstOrDefault().AnsDes : "";
            this.problemTextbox4.Value = answers.Where(x => x.QuestionId == 867).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 867).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox4.Value = answers.Where(x => x.QuestionId == 868).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 868).FirstOrDefault().AnsDes : "";
            this.problemTextbox5.Value = answers.Where(x => x.QuestionId == 869).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 869).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox5.Value = answers.Where(x => x.QuestionId == 870).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 870).FirstOrDefault().AnsDes : "";
            this.problemTextbox6.Value = answers.Where(x => x.QuestionId == 871).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 871).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox6.Value = answers.Where(x => x.QuestionId == 872).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 872).FirstOrDefault().AnsDes : "";
            this.problemTextbox7.Value = answers.Where(x => x.QuestionId == 873).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 873).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox7.Value = answers.Where(x => x.QuestionId == 874).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 874).FirstOrDefault().AnsDes : "";
            this.problemTextbox8.Value = answers.Where(x => x.QuestionId == 875).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 875).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox8.Value = answers.Where(x => x.QuestionId == 876).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 876).FirstOrDefault().AnsDes : "";
            this.problemTextbox9.Value = answers.Where(x => x.QuestionId == 877).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 877).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox9.Value = answers.Where(x => x.QuestionId == 878).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 878).FirstOrDefault().AnsDes : "";
            this.problemTextbox10.Value = answers.Where(x => x.QuestionId == 879).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 879).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox10.Value = answers.Where(x => x.QuestionId == 880).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 880).FirstOrDefault().AnsDes : "";
            this.problemTextbox11.Value = answers.Where(x => x.QuestionId == 881).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 881).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox11.Value = answers.Where(x => x.QuestionId == 882).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 882).FirstOrDefault().AnsDes : "";
            this.problemTextbox12.Value = answers.Where(x => x.QuestionId == 883).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 883).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox12.Value = answers.Where(x => x.QuestionId == 884).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 884).FirstOrDefault().AnsDes : "";
            this.problemTextbox13.Value = answers.Where(x => x.QuestionId == 885).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 885).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox13.Value = answers.Where(x => x.QuestionId == 886).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 886).FirstOrDefault().AnsDes : "";
            this.problemTextbox14.Value = answers.Where(x => x.QuestionId == 887).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 887).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox14.Value = answers.Where(x => x.QuestionId == 888).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 888).FirstOrDefault().AnsDes : "";
            this.problemTextbox15.Value = answers.Where(x => x.QuestionId == 889).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 889).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox15.Value = answers.Where(x => x.QuestionId == 890).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 890).FirstOrDefault().AnsDes : "";

            this.toolsListTextbox1.Value = answers.Where(x => x.QuestionId == 891).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 891).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox1.Value = answers.Where(x => x.QuestionId == 892).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 892).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox1.Value = answers.Where(x => x.QuestionId == 893).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 893).FirstOrDefault().AnsDes : "";
            this.noteTextbox1.Value = answers.Where(x => x.QuestionId == 894).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 894).FirstOrDefault().AnsDes : "";
            this.toolsListTextbox2.Value = answers.Where(x => x.QuestionId == 895).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 895).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox2.Value = answers.Where(x => x.QuestionId == 896).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 896).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox2.Value = answers.Where(x => x.QuestionId == 897).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 897).FirstOrDefault().AnsDes : "";
            this.noteTextbox2.Value = answers.Where(x => x.QuestionId == 898).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 898).FirstOrDefault().AnsDes : "";
            this.toolsListTextbox3.Value = answers.Where(x => x.QuestionId == 899).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 899).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox3.Value = answers.Where(x => x.QuestionId == 900).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 900).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox3.Value = answers.Where(x => x.QuestionId == 901).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 901).FirstOrDefault().AnsDes : "";
            this.noteTextbox3.Value = answers.Where(x => x.QuestionId == 902).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 902).FirstOrDefault().AnsDes : "";
            this.toolsListTextbox4.Value = answers.Where(x => x.QuestionId == 903).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 903).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox4.Value = answers.Where(x => x.QuestionId == 904).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 904).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox4.Value = answers.Where(x => x.QuestionId == 905).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 905).FirstOrDefault().AnsDes : "";
            this.noteTextbox4.Value = answers.Where(x => x.QuestionId == 906).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 906).FirstOrDefault().AnsDes : "";
            this.toolsListTextbox5.Value = answers.Where(x => x.QuestionId == 907).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 907).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox5.Value = answers.Where(x => x.QuestionId == 908).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 908).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox5.Value = answers.Where(x => x.QuestionId == 909).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 909).FirstOrDefault().AnsDes : "";
            this.noteTextbox5.Value = answers.Where(x => x.QuestionId == 910).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 910).FirstOrDefault().AnsDes : "";
            this.toolsListTextbox6.Value = answers.Where(x => x.QuestionId == 911).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 911).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox6.Value = answers.Where(x => x.QuestionId == 912).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 912).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox6.Value = answers.Where(x => x.QuestionId == 913).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 913).FirstOrDefault().AnsDes : "";
            this.noteTextbox6.Value = answers.Where(x => x.QuestionId == 914).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 914).FirstOrDefault().AnsDes : "";
            this.toolsListTextbox7.Value = answers.Where(x => x.QuestionId == 915).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 915).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox7.Value = answers.Where(x => x.QuestionId == 916).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 916).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox7.Value = answers.Where(x => x.QuestionId == 917).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 917).FirstOrDefault().AnsDes : "";
            this.noteTextbox7.Value = answers.Where(x => x.QuestionId == 918).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 918).FirstOrDefault().AnsDes : "";
            this.toolsListTextbox8.Value = answers.Where(x => x.QuestionId == 919).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 919).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox8.Value = answers.Where(x => x.QuestionId == 920).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 920).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox8.Value = answers.Where(x => x.QuestionId == 921).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 921).FirstOrDefault().AnsDes : "";
            this.noteTextbox8.Value = answers.Where(x => x.QuestionId == 922).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 922).FirstOrDefault().AnsDes : "";
            this.toolsListTextbox9.Value = answers.Where(x => x.QuestionId == 923).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 923).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox9.Value = answers.Where(x => x.QuestionId == 924).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 924).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox9.Value = answers.Where(x => x.QuestionId == 925).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 925).FirstOrDefault().AnsDes : "";
            this.noteTextbox9.Value = answers.Where(x => x.QuestionId == 926).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 926).FirstOrDefault().AnsDes : "";
            this.toolsListTextbox10.Value = answers.Where(x => x.QuestionId == 927).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 927).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox10.Value = answers.Where(x => x.QuestionId == 928).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 928).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox10.Value = answers.Where(x => x.QuestionId == 929).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 929).FirstOrDefault().AnsDes : "";
            this.noteTextbox10.Value = answers.Where(x => x.QuestionId == 930).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 930).FirstOrDefault().AnsDes : "";
            this.toolsListTextbox11.Value = answers.Where(x => x.QuestionId == 931).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 931).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox11.Value = answers.Where(x => x.QuestionId == 932).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 932).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox11.Value = answers.Where(x => x.QuestionId == 933).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 933).FirstOrDefault().AnsDes : "";
            this.noteTextbox11.Value = answers.Where(x => x.QuestionId == 934).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 934).FirstOrDefault().AnsDes : "";
            this.toolsListTextbox12.Value = answers.Where(x => x.QuestionId == 935).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 935).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox12.Value = answers.Where(x => x.QuestionId == 936).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 936).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox12.Value = answers.Where(x => x.QuestionId == 937).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 937).FirstOrDefault().AnsDes : "";
            this.noteTextbox12.Value = answers.Where(x => x.QuestionId == 938).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 938).FirstOrDefault().AnsDes : "";
            this.toolsListTextbox13.Value = answers.Where(x => x.QuestionId == 939).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 939).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox13.Value = answers.Where(x => x.QuestionId == 940).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 940).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox13.Value = answers.Where(x => x.QuestionId == 941).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 941).FirstOrDefault().AnsDes : "";
            this.noteTextbox13.Value = answers.Where(x => x.QuestionId == 942).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 942).FirstOrDefault().AnsDes : "";
            this.toolsListTextbox14.Value = answers.Where(x => x.QuestionId == 943).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 943).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox14.Value = answers.Where(x => x.QuestionId == 944).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 944).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox14.Value = answers.Where(x => x.QuestionId == 945).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 945).FirstOrDefault().AnsDes : "";
            this.noteTextbox14.Value = answers.Where(x => x.QuestionId == 946).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 946).FirstOrDefault().AnsDes : "";
            this.toolsListTextbox15.Value = answers.Where(x => x.QuestionId == 947).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 947).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox15.Value = answers.Where(x => x.QuestionId == 948).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 948).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox15.Value = answers.Where(x => x.QuestionId == 949).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 949).FirstOrDefault().AnsDes : "";
            this.noteTextbox15.Value = answers.Where(x => x.QuestionId == 950).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 950).FirstOrDefault().AnsDes : "";

            this.nameTeampmTextbox.Value = answers.Where(x => x.QuestionId == 951).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 951).FirstOrDefault().AnsDes : "";
            this.dayDopmTextbox.Value = answers.Where(x => x.QuestionId == 952).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 952).FirstOrDefault().AnsDes : "";
            this.nameAgentareaTextbox.Value = answers.Where(x => x.QuestionId == 953).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 953).FirstOrDefault().AnsDes : "";
            this.telephoneAgentTextbox.Value = answers.Where(x => x.QuestionId == 954).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 954).FirstOrDefault().AnsDes : "";
        }

        int GetQuarter(DateTime dt)
        {
            return (dt.Month - 1) / 3 + 1;
        }
        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            User user = (User)Session["strUsername"];
            if (user != null)
            {

            }
            else
            {
                Response.Redirect("/login.aspx");
                Response.End();

            }

            string ansMonth = DateTime.Now.ToString("yyyyMM", CultureInfo.GetCultureInfo("en-US"));

            long siteId = long.Parse(Request["SiteId"]);
            int currentQuarter = this.GetQuarter(DateTime.Now);
            SR sR = uSOEntities.SRs.Where(x => x.Quarter == currentQuarter && x.SiteId == siteId && x.Status == 1).FirstOrDefault();
            if (sR == null)
            {
                string srCode = "Q" + currentQuarter.ToString() + "/" + DateTime.Now.ToString("yyyy", CultureInfo.GetCultureInfo("th-US"));
                sR = new SR
                {
                    Code = srCode,
                    CreatedDate = DateTime.Now,
                    Detail = "",
                    LastUpdated = DateTime.Now,
                    LastUser = user.Id,
                    SiteId = siteId,
                    Quarter = currentQuarter,
                    Status = 1
                };
                uSOEntities.SRs.Add(sR);
            }
            else
            {
                sR.LastUser = user.Id;
                sR.LastUpdated = DateTime.Now;
            }

            var ans1 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 736).FirstOrDefault();
            if (ans1 == null)
            {
                Answer answer1 = new Answer()
                {
                    AnsDes = this.GroupNameTextBox.Value,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    QuestionId = 736,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer1);
            }
            else
            {
                ans1.AnsDes = this.GroupNameTextBox.Value;
                ans1.AnserTypeId = 1;
                ans1.CreateDate = DateTime.Now;
                ans1.QuestionId = 736;
                ans1.UserId = user.Id;
                ans1.AnsMonth = ansMonth; ans1.SRId = sR.Id;
            }

            // ภูมิภาค
            var ans2 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 737).FirstOrDefault();
            if (ans2 == null)
            {
                Answer answer2 = new Answer()
                {
                    AnsDes = this.AreaTextbox.Value,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    QuestionId = 737,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer2);
            }
            else
            {
                ans2.AnsDes = this.AreaTextbox.Value;
                ans2.AnserTypeId = 1;
                ans2.CreateDate = DateTime.Now;
                ans2.QuestionId = 737;
                ans2.UserId = user.Id;
                ans2.AnsMonth = ansMonth; ans2.SRId = sR.Id;
            }



            // บริษัท

            var ans3 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 738).FirstOrDefault();
            if (ans3 == null)
            {
                Answer answer3 = new Answer()
                {
                    AnsDes = this.CompanyTextbox.Value,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    QuestionId = 738,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer3);
            }
            else
            {
                ans3.AnsDes = this.CompanyTextbox.Value;
                ans3.AnserTypeId = 1;
                ans3.CreateDate = DateTime.Now;
                ans3.QuestionId = 738;
                ans3.UserId = user.Id;
                ans3.AnsMonth = ansMonth; ans3.SRId = sR.Id;

            }




            var ans3_1 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 739).FirstOrDefault();
            if (ans3_1 == null)
            {
                string category = Request.Form["category"];
                Answer answer4 = new Answer()
                {
                    AnsDes = category,
                    QuestionId = 739,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer4);
            }
            else
            {
                string category = Request.Form["category"];
                ans3_1.AnsDes = category;
                ans3_1.AnserTypeId = 4;
                ans3_1.CreateDate = DateTime.Now;
                ans3_1.QuestionId = 739;
                ans3_1.UserId = user.Id;
                ans3_1.AnsMonth = ansMonth; ans3_1.SRId = sR.Id;


            }


            //รอบการบำรุงรักษาครั้งที่
            var ans4 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 740).FirstOrDefault();
            if (ans4 == null)
            {
                Answer answer4 = new Answer()
                {
                    AnsDes = this.maintenanceCountTextbox.Value,
                    QuestionId = 740,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer4);
            }
            else
            {
                ans4.AnsDes = this.maintenanceCountTextbox.Value;
                ans4.AnserTypeId = 1;
                ans4.CreateDate = DateTime.Now;
                ans4.QuestionId = 740;
                ans4.UserId = user.Id;
                ans4.AnsMonth = ansMonth; ans4.SRId = sR.Id;


            }


            //ปีพุทธศักราช

            var ans5 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 741).FirstOrDefault();
            if (ans5 == null)
            {
                Answer answer5 = new Answer()
                {
                    AnsDes = this.yearTextbox.Value,
                    QuestionId = 741,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer5);
            }
            else
            {
                ans5.AnsDes = this.yearTextbox.Value;
                ans5.AnserTypeId = 1;
                ans5.CreateDate = DateTime.Now;
                ans5.QuestionId = 741;
                ans5.UserId = user.Id;
                ans5.AnsMonth = ansMonth; ans5.SRId = sR.Id;

            }

            //วัน เดือน ปี ที่เริ่มต้น
            var ans6 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 742).FirstOrDefault();
            if (ans6 == null)
            {
                Answer answer6 = new Answer()
                {
                    AnsDes = this.startDatepicker.Value,
                    //  StartDate = DateTime.ParseExact(this.startDatepicker.Value, "MM/dd/yyyy", CultureInfo.GetCultureInfo("en-GB")),
                    QuestionId = 742,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                    //StartDate = DateTime.ParseExact(this.startDateTextbox2.Value, "MM/dd/yyyy", CultureInfo.GetCultureInfo("en-US")),
                };
                uSOEntities.Answers.Add(answer6);
            }
            else
            {
                ans6.AnsDes = this.startDatepicker.Value;
                ans6.AnserTypeId = 1;
                ans6.CreateDate = DateTime.Now;
                ans6.QuestionId = 742;
                ans6.UserId = user.Id;
                ans6.AnsMonth = ansMonth; ans6.SRId = sR.Id;

            }

            //ถึง 
            var ans7 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 743).FirstOrDefault();
            if (ans7 == null)
            {
                Answer answer7 = new Answer()
                {
                    AnsDes = this.endDatepicker.Value,
                    // EndDate = DateTime.ParseExact(this.endDatepicker.Value, "MM/dd/yyyy", CultureInfo.GetCultureInfo("en-GB")),
                    QuestionId = 743,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    //StartDate = DateTime.ParseExact(this.startDateTextbox2.Value, "MM/dd/yyyy", CultureInfo.GetCultureInfo("en-US")),
                };
                uSOEntities.Answers.Add(answer7);
            }
            else
            {
                ans7.AnsDes = this.endDatepicker.Value;
                ans7.AnserTypeId = 1;
                ans7.CreateDate = DateTime.Now;
                ans7.QuestionId = 743;
                ans7.UserId = user.Id;
                ans7.AnsMonth = ansMonth; ans7.SRId = sR.Id;
            }

            var ans8 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 744).FirstOrDefault();
            if (ans8 == null)
            {
                //สถานที่ SITE CODE
                Answer answer8 = new Answer()
                {
                    AnsDes = this.siteCodeTextbox.Value,
                    QuestionId = 744,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer8);
            }
            else
            {
                ans8.AnsDes = this.siteCodeTextbox.Value;
                ans8.AnserTypeId = 1;
                ans8.CreateDate = DateTime.Now;
                ans8.QuestionId = 744;
                ans8.UserId = user.Id;
                ans8.AnsMonth = ansMonth; ans8.SRId = sR.Id;

            }

            var ans9 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 1239).FirstOrDefault();
            //ใส่รูป Logo 
            if (ans9 == null)
            {
                if (this.pictureOrganize_.HasFile)
                {
                    string extension = this.pictureOrganize_.PostedFile.FileName.Split('.')[1];
                    string newFileName = "images/PictureOrganize_BB2_2_3_2_" + DateTime.Now.ToString("yyyyMMddHHmmss") + "." + extension;
                    this.pictureOrganize_.PostedFile.SaveAs(Server.MapPath(newFileName));

                    Answer answer9 = new Answer()
                    {
                        AnsDes = newFileName,
                        QuestionId = 745,
                        AnserTypeId = 3,
                        CreateDate = DateTime.Now,
                        SRId = sR.Id,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer9);
                }
            }
            else
            {
                if (this.pictureOrganize_.HasFile)
                {
                    string extension = this.pictureOrganize_.PostedFile.FileName.Split('.')[1];
                    string newFileName = "images/PictureOrganize_BB2_2_3_2_" + DateTime.Now.ToString("yyyyMMddHHmmss") + "." + extension;
                    this.pictureOrganize_.PostedFile.SaveAs(Server.MapPath(newFileName));

                    ans9.AnsDes = newFileName;
                    ans9.QuestionId = 745;
                    ans9.AnserTypeId = 3;
                    ans9.CreateDate = DateTime.Now;
                    ans9.UserId = user.Id;
                    ans9.AnsMonth = ansMonth;
                    ans9.SRId = sR.Id;
                }

            }

            //Cabinet ID:
            var ans10 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 746).FirstOrDefault();
            if (ans10 == null)
            {
                Answer answer10 = new Answer()
                {
                    AnsDes = this.cabinetIdTextbox.Value,
                    QuestionId = 746,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer10);
            }
            else
            {
                ans10.AnsDes = this.cabinetIdTextbox.Value;
                ans10.AnserTypeId = 1;
                ans10.CreateDate = DateTime.Now;
                ans10.QuestionId = 746;
                ans10.UserId = user.Id;
                ans10.AnsMonth = ansMonth; ans10.SRId = sR.Id;
            }

            //Site Code :
            var ans11 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 747).FirstOrDefault();
            if (ans11 == null)
            {
                Answer answer11 = new Answer()
                {
                    AnsDes = this.sitecodeTextboxSection2.Value,
                    QuestionId = 747,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer11);
            }
            else
            {
                ans11.AnsDes = this.sitecodeTextboxSection2.Value;
                ans11.AnserTypeId = 1;
                ans11.CreateDate = DateTime.Now;
                ans11.QuestionId = 747;
                ans11.UserId = user.Id;
                ans11.AnsMonth = ansMonth; ans11.SRId = sR.Id;
            }

            //Village ID :
            var ans12 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 748).FirstOrDefault();
            if (ans12 == null)
            {
                Answer answer12 = new Answer()
                {
                    AnsDes = this.VillageIdTextbox.Value,
                    QuestionId = 748,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer12);
            }
            else
            {
                ans12.AnsDes = this.VillageIdTextbox.Value;
                ans12.AnserTypeId = 1;
                ans12.CreateDate = DateTime.Now;
                ans12.QuestionId = 748;
                ans12.UserId = user.Id;
                ans12.AnsMonth = ansMonth; ans12.SRId = sR.Id;
            }

            //Village  :
            var ans13 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 749).FirstOrDefault();
            if (ans13 == null)
            {
                Answer answer13 = new Answer()
                {
                    AnsDes = this.villageTextbox.Value,
                    QuestionId = 749,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer13);
            }
            else
            {
                ans13.AnsDes = this.VillageIdTextbox.Value;
                ans13.AnserTypeId = 1;
                ans13.CreateDate = DateTime.Now;
                ans13.QuestionId = 749;
                ans13.UserId = user.Id;
                ans13.AnsMonth = ansMonth; ans13.SRId = sR.Id;
            }

            ///School 's name
            var ans13__ = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 750).FirstOrDefault();
            if (ans13__ == null)
            {
                Answer answer13__ = new Answer()
                {
                    AnsDes = this.schoolnameTextbox.Value,
                    QuestionId = 750,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer13__);
            }
            else
            {
                ans13__.AnsDes = this.schoolnameTextbox.Value;
                ans13__.AnserTypeId = 1;
                ans13__.CreateDate = DateTime.Now;
                ans13__.QuestionId = 750;
                ans13__.UserId = user.Id;
                ans13__.AnsMonth = ansMonth; ans13__.SRId = sR.Id;
            }



            //Sub-District :
            var ans14 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 751).FirstOrDefault();
            if (ans14 == null)
            {
                Answer answer14 = new Answer()
                {
                    AnsDes = this.subdistrictTextbox.Value,
                    QuestionId = 751,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer14);
            }
            else
            {
                ans14.AnsDes = this.subdistrictTextbox.Value;
                ans14.AnserTypeId = 1;
                ans14.CreateDate = DateTime.Now;
                ans14.QuestionId = 751;
                ans14.UserId = user.Id;
                ans14.AnsMonth = ansMonth; ans14.SRId = sR.Id;

            }


            //District :
            var ans15 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 752).FirstOrDefault();
            if (ans15 == null)
            {

                Answer answer15 = new Answer()
                {
                    AnsDes = this.districtTextbox.Value,
                    QuestionId = 752,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer15);
            }
            else
            {
                ans15.AnsDes = this.districtTextbox.Value;
                ans15.AnserTypeId = 1;
                ans15.CreateDate = DateTime.Now;
                ans15.QuestionId = 752;
                ans15.UserId = user.Id;
                ans15.AnsMonth = ansMonth; ans15.SRId = sR.Id;
            }
            //Province :
            var ans16 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 753).FirstOrDefault();
            if (ans16 == null)
            {
                Answer answer16 = new Answer()
                {
                    AnsDes = this.provinceTextbox.Value,
                    QuestionId = 753,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer16);
            }
            else
            {
                ans16.AnsDes = this.provinceTextbox.Value;
                ans16.AnserTypeId = 1;
                ans16.CreateDate = DateTime.Now;
                ans16.QuestionId = 753;
                ans16.UserId = user.Id;
                ans16.AnsMonth = ansMonth; ans16.SRId = sR.Id;
            }

            //Type :
            var ans17 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 754).FirstOrDefault();
            if (ans17 == null)
            {
                Answer answer17 = new Answer()
                {
                    AnsDes = this.typeTextbox.Value,
                    QuestionId = 754,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer17);
            }
            else
            {
                ans17.AnsDes = this.typeTextbox.Value;
                ans17.AnserTypeId = 1;
                ans17.CreateDate = DateTime.Now;
                ans17.QuestionId = 754;
                ans17.UserId = user.Id;
                ans17.AnsMonth = ansMonth; ans17.SRId = sR.Id;
            }
            //PM Date :
            var ans18 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 755).FirstOrDefault();
            if (ans18 == null)
            {
                Answer answer18 = new Answer()
                {
                    AnsDes = this.pmdateTextbox.Value,
                    QuestionId = 755,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer18);
            }
            else
            {
                ans18.AnsDes = this.pmdateTextbox.Value;
                ans18.AnserTypeId = 1;
                ans18.CreateDate = DateTime.Now;
                ans18.QuestionId = 755;
                ans18.UserId = user.Id;
                ans18.AnsMonth = ansMonth; ans18.SRId = sR.Id;

            }


            //ใส่รูปหน้าอาคารศูนย์ USO Net :

            var ans789 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 756).FirstOrDefault();
            if (ans789 == null)
            {
                if (this.usonetsignboardImage.HasFile)
                {
                    string extension = this.usonetsignboardImage.PostedFile.FileName.Split('.')[1];
                    string newFileName = "images/UsonetPictureBB2_2_3_2_" + DateTime.Now.ToString("yyyyMMddHHmmss") + "." + extension;
                    this.usonetsignboardImage.PostedFile.SaveAs(Server.MapPath(newFileName));

                    Answer answer20__ = new Answer()
                    {
                        AnsDes = newFileName,
                        QuestionId = 756,
                        AnserTypeId = 3,
                        CreateDate = DateTime.Now,
                        SRId = sR.Id,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer20__);
                }
            }
            else
            {
                if (this.usonetsignboardImage.HasFile)
                {
                    string extension = this.usonetsignboardImage.PostedFile.FileName.Split('.')[1];
                    string newFileName = "images/UsonetPictureBB2_2_3_2_" + DateTime.Now.ToString("yyyyMMddHHmmss") + "." + extension;
                    this.usonetsignboardImage.PostedFile.SaveAs(Server.MapPath(newFileName));

                    ans789.AnsDes = newFileName;
                    ans789.QuestionId = 756;
                    ans789.AnserTypeId = 3;
                    ans789.CreateDate = DateTime.Now;
                    ans789.UserId = user.Id;
                    ans789.AnsMonth = ansMonth;
                    ans789.SRId = sR.Id;

                }




            }


            //ใส่ป้ายหน้าโรงเรียน :
            var ans7899 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 757).FirstOrDefault();
            if (ans7899 == null)
            {
                if (this.signboardschoolImage.HasFile)
                {
                    string extension = this.signboardschoolImage.PostedFile.FileName.Split('.')[1];
                    string newFileName = "images/SignboardSchoolBB2_2_3_2_" + DateTime.Now.ToString("yyyyMMddHHmmss") + "." + extension;
                    this.signboardschoolImage.PostedFile.SaveAs(Server.MapPath(newFileName));

                    Answer answer21__ = new Answer()
                    {
                        AnsDes = newFileName,
                        QuestionId = 757,
                        AnserTypeId = 3,
                        CreateDate = DateTime.Now,
                        SRId = sR.Id,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer21__);
                }
            }
            else
            {
                if (this.signboardschoolImage.HasFile) {
                    string extension = this.signboardschoolImage.PostedFile.FileName.Split('.')[1];
                    string newFileName = "images/SignboardSchoolBB2_2_3_2_" + DateTime.Now.ToString("yyyyMMddHHmmss") + "." + extension;
                    this.signboardschoolImage.PostedFile.SaveAs(Server.MapPath(newFileName));



                    ans7899.AnsDes = newFileName;
                    ans7899.QuestionId = 757;
                    ans7899.AnserTypeId = 3;
                    ans7899.CreateDate = DateTime.Now;
                    ans7899.UserId = user.Id;
                    ans7899.AnsMonth = ansMonth;
                    ans7899.SRId = sR.Id;
                }
                  



            }

















            //signature Executor :
            var ans758 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 758).FirstOrDefault();
            string sx = "";
            sx = this.signatureExecutorJSON.Value.Replace(' ', '+');
            sx = sx.Replace("data:image/jpeg;base64,", String.Empty);
            byte[] imageBytes = Convert.FromBase64String(sx);
            string filename = "";
            using (var ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
            {
                filename = $"signatureExecutor{DateTime.Now.ToString("yyyyMMddHHmmss")}.jpg";
                System.Drawing.Image image = System.Drawing.Image.FromStream(ms, true);
                image.Save(Server.MapPath($"images/{filename}"));
            }

            string ans758ImagesSignature = string.Format("images/{0}", filename);


            int mod1428 = sx.Length % 4;
            if (mod1428 > 0)
            {
                sx += new string('=', 4 - mod1428);
            }
            if (ans758 == null)
            {
                //signature Executor :
                Answer answer21 = new Answer()
                {
                    AnsDes = ans758ImagesSignature,
                    QuestionId = 758,
                    AnserTypeId = 3,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer21);
            }
            else
            {
                ans758.QuestionId = 758;
                ans758.AnsDes = ans758ImagesSignature;
                ans758.AnserTypeId = 3;
                ans758.CreateDate = DateTime.Now;
                ans758.UserId = user.Id;
                ans758.AnsMonth = ansMonth; 
                ans758.SRId = sR.Id;

            }




            //signature Supervisor :
            var ans759 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 759).FirstOrDefault();
            string s = "";
            s = this.signatureSupervisorJSON.Value.Replace(' ', '+');
            s = s.Replace("data:image/jpeg;base64,", String.Empty);
            string filename2 = "";
            byte[] imageBytes2 = Convert.FromBase64String(s);
            using (var ms2 = new MemoryStream(imageBytes2, 0, imageBytes2.Length))
            {
                filename2 = $"signatureSupervisor{DateTime.Now.ToString("yyyyMMddHHmmss")}.jpg";
                System.Drawing.Image image2 = System.Drawing.Image.FromStream(ms2, true);
                image2.Save(Server.MapPath($"images/{filename2}"));
            }
            string ans759SignatureImages = string.Format("images/{0}", filename2);

            int mod4 = s.Length % 4;
            if (mod4 > 0)
            {
                s += new string('=', 4 - mod4);
            }
            if (ans759 == null)
            {
                //signature Supervisor :
                Answer answer22 = new Answer()
                {
                    AnsDes = ans759SignatureImages,
                    QuestionId = 759,
                    AnserTypeId = 3,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer22);
            }
            else
            {
                ans759.QuestionId = 759;
                ans759.AnsDes = ans759SignatureImages;
                ans759.AnserTypeId = 3;
                ans759.CreateDate = DateTime.Now;
                ans759.UserId = user.Id;
                ans759.AnsMonth = ansMonth;
                ans759.SRId = sR.Id;

            }


            //name Executor  :
            var ans22 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 760).FirstOrDefault();
            if (ans22 == null)
            {
                Answer answer22 = new Answer()
                {
                    AnsDes = this.nameExecutorTextbox.Value,
                    QuestionId = 760,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer22);
            }
            else
            {
                ans22.AnsDes = this.nameExecutorTextbox.Value;
                ans22.AnserTypeId = 1;
                ans22.CreateDate = DateTime.Now;
                ans22.QuestionId = 760;
                ans22.UserId = user.Id;
                ans22.AnsMonth = ansMonth; ans22.SRId = sR.Id;
            }
            //name Supervisor :
            var ans23 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 761).FirstOrDefault();
            if (ans23 == null)
            {
                Answer answer23 = new Answer()
                {
                    AnsDes = this.nameSupervisorTextbox.Value,
                    QuestionId = 761,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer23);
            }
            else
            {
                ans23.AnsDes = this.nameSupervisorTextbox.Value;
                ans23.AnserTypeId = 1;
                ans23.CreateDate = DateTime.Now;
                ans23.QuestionId = 761;
                ans23.UserId = user.Id;
                ans23.AnsMonth = ansMonth; ans23.SRId = sR.Id;
            }
            //Date Executor :
            var ans24 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 762).FirstOrDefault();
            if (ans24 == null)
            {
                Answer answer24 = new Answer()
                {
                    AnsDes = this.DateExecutorTextbox.Value,
                    QuestionId = 762,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer24);
            }
            else
            {
                ans24.AnsDes = this.DateExecutorTextbox.Value;
                ans24.AnserTypeId = 1;
                ans24.CreateDate = DateTime.Now;
                ans24.QuestionId = 762;
                ans24.UserId = user.Id;
                ans24.AnsMonth = ansMonth; ans24.SRId = sR.Id;
            }
            //Date Supervisor :
            var ans25 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 763).FirstOrDefault();
            if (ans25 == null)
            {
                Answer answer25 = new Answer()
                {
                    AnsDes = this.DateSupervisorTextbox.Value,
                    QuestionId = 763,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer25);
            }
            else
            {
                ans25.AnsDes = this.DateSupervisorTextbox.Value;
                ans25.AnserTypeId = 1;
                ans25.CreateDate = DateTime.Now;
                ans25.QuestionId = 763;
                ans25.UserId = user.Id;
                ans25.AnsMonth = ansMonth; ans25.SRId = sR.Id;
            }



            //--------------------------------------------------------
            //Location name :
            var ans26 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 764).FirstOrDefault();
            if (ans26 == null)
            {
                Answer answer26 = new Answer()
                {
                    AnsDes = this.LocationnameTextbox.Value,
                    QuestionId = 764,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer26);
            }
            else
            {
                ans26.AnsDes = this.LocationnameTextbox.Value;
                ans26.AnserTypeId = 1;
                ans26.CreateDate = DateTime.Now;
                ans26.QuestionId = 764;
                ans26.UserId = user.Id;
                ans26.AnsMonth = ansMonth; ans26.SRId = sR.Id;
            }

            //Site code section 4 :
            var ans27 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 765).FirstOrDefault();
            if (ans27 == null)
            {
                Answer answer27 = new Answer()
                {
                    AnsDes = this.sitecodeTextboxSection4.Value,
                    QuestionId = 765,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer27);
            }
            else
            {
                ans27.AnsDes = this.sitecodeTextboxSection4.Value;
                ans27.AnserTypeId = 1;
                ans27.CreateDate = DateTime.Now;
                ans27.QuestionId = 765;
                ans27.UserId = user.Id;
                ans27.AnsMonth = ansMonth; ans27.SRId = sR.Id;
            }

            //villageIDsection 4 :
            var ans28 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 766).FirstOrDefault();
            if (ans28 == null)
            {
                Answer answer28 = new Answer()
                {
                    AnsDes = this.villageIDTextboxSection4.Value,
                    QuestionId = 766,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer28);
            }
            else
            {
                ans28.AnsDes = this.villageIDTextboxSection4.Value;
                ans28.AnserTypeId = 1;
                ans28.CreateDate = DateTime.Now;
                ans28.QuestionId = 766;
                ans28.UserId = user.Id;
                ans28.AnsMonth = ansMonth; ans28.SRId = sR.Id;
            }


            //lat and long  :
            var ans29 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 767).FirstOrDefault();
            if (ans29 == null)
            {
                Answer answer29 = new Answer()
                {
                    AnsDes = this.latandlongTextbox.Value,
                    QuestionId = 767,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer29);
            }
            else
            {
                ans29.AnsDes = this.latandlongTextbox.Value;
                ans29.AnserTypeId = 1;
                ans29.CreateDate = DateTime.Now;
                ans29.QuestionId = 767;
                ans29.UserId = user.Id;
                ans29.AnsMonth = ansMonth; ans29.SRId = sR.Id;
            }

            //type of signal Radio  :
            var ans29_1 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 768).FirstOrDefault();
            if (ans29_1 == null)
            {
                string typeOf = Request.Form["typeofsignalRadio"];
                Answer answer32 = new Answer()
                {
                    AnsDes = typeOf,
                    QuestionId = 768,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer32);
            }
            else
            {
                string typeOf = Request.Form["typeofsignalRadio"];
                ans29_1.AnsDes = typeOf;
                ans29_1.AnserTypeId = 4;
                ans29_1.CreateDate = DateTime.Now;
                ans29_1.QuestionId = 768;
                ans29_1.UserId = user.Id;
                ans29_1.AnsMonth = ansMonth; ans29_1.SRId = sR.Id;
            }


            //oltid  :
            var ans29_2 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 769).FirstOrDefault();
            if (ans29_2 == null)
            {
                Answer answer33 = new Answer()
                {
                    AnsDes = this.oltidTextbox.Value,
                    QuestionId = 769,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer33);
            }
            else
            {
                ans29_2.AnsDes = this.oltidTextbox.Value;
                ans29_2.AnserTypeId = 1;
                ans29_2.CreateDate = DateTime.Now;
                ans29_2.QuestionId = 769;
                ans29_2.UserId = user.Id;
                ans29_2.AnsMonth = ansMonth; ans29_2.SRId = sR.Id;
            }

            //elecSystem Radio  :
            var ans29_3 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 770).FirstOrDefault();
            if (ans29_3 == null)
            {
                string elecradioSection5 = Request.Form["elecRadio"];
                Answer answer34 = new Answer()
                {
                    AnsDes = elecradioSection5,
                    QuestionId = 770,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer34);
            }
            else
            {
                string elecradioSection5 = Request.Form["elecRadio"];
                ans29_3.AnsDes = elecradioSection5;
                ans29_3.AnserTypeId = 4;
                ans29_3.CreateDate = DateTime.Now;
                ans29_3.QuestionId = 770;
                ans29_3.UserId = user.Id;
                ans29_3.AnsMonth = ansMonth; ans29_3.SRId = sR.Id;
            }
            ///tranformer Radio  :
            var ans29_4 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 771).FirstOrDefault();
            if (ans29_4 == null)
            {
                string tranRadio = Request.Form["transformerRadio"];
                Answer answer34 = new Answer()
                {
                    AnsDes = tranRadio,
                    QuestionId = 771,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer34);
            }
            else
            {
                string tranRadio = Request.Form["transformerRadio"];
                ans29_4.AnsDes = tranRadio;
                ans29_4.AnserTypeId = 4;
                ans29_4.CreateDate = DateTime.Now;
                ans29_4.QuestionId = 771;
                ans29_4.UserId = user.Id;
                ans29_4.AnsMonth = ansMonth; ans29_4.SRId = sR.Id;
            }



            //หมายเลขผู้ใช้ไฟ  :
            var ans30 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 772).FirstOrDefault();
            if (ans30 == null)
            {
                Answer answer30 = new Answer()
                {
                    AnsDes = this.numberuserTextbox.Value,
                    QuestionId = 772,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer30);
            }
            else
            {
                ans30.AnsDes = this.numberuserTextbox.Value;
                ans30.AnserTypeId = 1;
                ans30.CreateDate = DateTime.Now;
                ans30.QuestionId = 772;
                ans30.UserId = user.Id;
                ans30.AnsMonth = ansMonth; ans30.SRId = sR.Id;
            }

            //หน่วยใช้ไฟไฟ  :
            var ans31 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 773).FirstOrDefault();
            if (ans31 == null)
            {
                Answer answer31 = new Answer()
                {
                    AnsDes = this.kwhMeterTextbox.Value,
                    QuestionId = 773,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer31);
            }
            else
            {
                ans31.AnsDes = this.kwhMeterTextbox.Value;
                ans31.AnserTypeId = 1;
                ans31.CreateDate = DateTime.Now;
                ans31.QuestionId = 773;
                ans31.UserId = user.Id;
                ans31.AnsMonth = ansMonth; ans31.SRId = sR.Id;
            }

            //แรงดัน AC (kWh Meter) :
            var ans32 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 774).FirstOrDefault();
            if (ans32 == null)
            {
                Answer answer32 = new Answer()
                {
                    AnsDes = this.acTextbox.Value,
                    QuestionId = 774,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer32);
            }
            else
            {
                ans32.AnsDes = this.acTextbox.Value;
                ans32.AnserTypeId = 1;
                ans32.CreateDate = DateTime.Now;
                ans32.QuestionId = 774;
                ans32.UserId = user.Id;
                ans32.AnsMonth = ansMonth; ans32.SRId = sR.Id;
            }

            //กระแส Line AC (kWh Meter) :
            var ans33 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 775).FirstOrDefault();
            if (ans33 == null)
            {
                Answer answer33 = new Answer()
                {
                    AnsDes = this.lineAcTextbox.Value,
                    QuestionId = 775,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer33);
            }
            else
            {
                ans33.AnsDes = this.lineAcTextbox.Value;
                ans33.AnserTypeId = 1;
                ans33.CreateDate = DateTime.Now;
                ans33.QuestionId = 775;
                ans33.UserId = user.Id;
                ans33.AnsMonth = ansMonth; ans33.SRId = sR.Id;
            }

            // กระแส Neutron AC(kWh Meter) :     
            var ans34 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 776).FirstOrDefault();
            if (ans34 == null)
            {
                Answer answer34 = new Answer()
                {
                    AnsDes = this.neutronacTextbox.Value,
                    QuestionId = 776,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer34);
            }
            else
            {
                ans34.AnsDes = this.neutronacTextbox.Value;
                ans34.AnserTypeId = 1;
                ans34.CreateDate = DateTime.Now;
                ans34.QuestionId = 776;
                ans34.UserId = user.Id;
                ans34.AnsMonth = ansMonth; ans34.SRId = sR.Id;
            }

            //สภาพ kWh Meter Radio  :
            var ans35 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 777).FirstOrDefault();
            if (ans35 == null)
            {
                string conRadio = Request.Form["conditionRadio"];
                Answer answer35 = new Answer()
                {
                    AnsDes = conRadio,
                    QuestionId = 777,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer35);
            }
            else
            {
                string conRadio = Request.Form["conditionRadio"];
                ans35.AnsDes = conRadio;
                ans35.AnserTypeId = 4;
                ans35.CreateDate = DateTime.Now;
                ans35.QuestionId = 777;
                ans35.UserId = user.Id;
                ans35.AnsMonth = ansMonth; ans35.SRId = sR.Id;
            }
            //สภาพMDB/ Circuit Breaker Radio  :
            var ans36 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 778).FirstOrDefault();
            if (ans36 == null)
            {
                string CircuitBreakerRadio = Request.Form["MDBCircuitBreakerRadio"];
                Answer answer36 = new Answer()
                {
                    AnsDes = CircuitBreakerRadio,
                    QuestionId = 778,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer36);
            }
            else
            {
                string CircuitBreakerRadio = Request.Form["MDBCircuitBreakerRadio"];
                ans36.AnsDes = CircuitBreakerRadio;
                ans36.AnserTypeId = 4;
                ans36.CreateDate = DateTime.Now;
                ans36.QuestionId = 778;
                ans36.UserId = user.Id;
                ans36.AnsMonth = ansMonth; ans36.SRId = sR.Id;
            }


            //UPS ภายในตู้ Radio  :
            var ans37 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 779).FirstOrDefault();
            if (ans37 == null)
            {
                //UPS ภายในตู้ Radio  :
                string innerUPS = Request.Form["inupsRadio"];
                Answer answer43 = new Answer()
                {
                    AnsDes = innerUPS,
                    QuestionId = 779,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer43);
            }
            else
            {
                string innerUPS = Request.Form["inupsRadio"];
                ans37.AnsDes = innerUPS;
                ans37.AnserTypeId = 4;
                ans37.CreateDate = DateTime.Now;
                ans37.QuestionId = 779;
                ans37.UserId = user.Id;
                ans37.AnsMonth = ansMonth; ans37.SRId = sR.Id;
            }


            // AC from UPS :     
            var ans38 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 780).FirstOrDefault();
            if (ans38 == null)
            {
                Answer answer44 = new Answer()
                {
                    AnsDes = this.acfromupsTextbox.Value,
                    QuestionId = 780,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer44);
            }
            else
            {
                ans38.AnsDes = this.acfromupsTextbox.Value;
                ans38.AnserTypeId = 4;
                ans38.CreateDate = DateTime.Now;
                ans38.QuestionId = 780;
                ans38.UserId = user.Id;
                ans38.AnsMonth = ansMonth; ans38.SRId = sR.Id;
            }

            // กระเเส โหลด :
            var ans39 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 781).FirstOrDefault();
            if (ans39 == null)
            {

                Answer answer45 = new Answer()
                {
                    AnsDes = this.electricloadTextbox.Value,
                    QuestionId = 781,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer45);
            }
            else
            {

                ans39.AnsDes = this.electricloadTextbox.Value;
                ans39.AnserTypeId = 4;
                ans39.CreateDate = DateTime.Now;
                ans39.QuestionId = 781;
                ans39.UserId = user.Id;
                ans39.AnsMonth = ansMonth; ans39.SRId = sR.Id;
            }



            //upsmode
            var ans41 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 782).FirstOrDefault();
            if (ans41 == null)
            {
                string xx = Request.Form["upsModeRadio"];
                Answer answer47 = new Answer()
                {
                    AnsDes = xx,
                    QuestionId = 782,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer47);
            }
            else
            {
                string xx = Request.Form["upsModeRadio"];
                ans41.AnsDes = xx;
                ans41.AnserTypeId = 4;
                ans41.CreateDate = DateTime.Now;
                ans41.QuestionId = 782;
                ans41.UserId = user.Id;
                ans41.AnsMonth = ansMonth;
                ans41.SRId = sR.Id;
            }


            //EMER GENNNARATOR   :
            var ans42 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 783).FirstOrDefault();
            if (ans42 == null)
            {
                string emergen = Request.Form["emergeneratorRadio"];
                Answer answer48__ = new Answer()
                {
                    AnsDes = emergen,
                    QuestionId = 783,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer48__);
            }
            else
            {
                string emergen = Request.Form["emergeneratorRadio"];
                ans42.AnsDes = emergen;
                ans42.AnserTypeId = 4;
                ans42.CreateDate = DateTime.Now;
                ans42.QuestionId = 783;
                ans42.UserId = user.Id;
                ans42.AnsMonth = ansMonth;
                ans42.SRId = sR.Id;
            }

            //สภาพ batterry bank  :
            var ans43 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 784).FirstOrDefault();
            if (ans43 == null)
            {
                string statebat = Request.Form["stateBatteryBankRadio"];
                Answer answer49__ = new Answer()
                {
                    AnsDes = statebat,
                    QuestionId = 784,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer49__);
            }
            else
            {
                string statebat = Request.Form["stateBatteryBankRadio"];
                ans43.AnsDes = statebat;
                ans43.AnserTypeId = 4;
                ans43.CreateDate = DateTime.Now;
                ans43.QuestionId = 784;
                ans43.UserId = user.Id;
                ans43.AnsMonth = ansMonth; ans43.SRId = sR.Id;
            }


            //ONU/Modem Network  :
            var ans44 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 785).FirstOrDefault();
            if (ans44 == null)
            {
                string modemnet = Request.Form["onuModemRadio"];
                Answer aa = new Answer()
                {
                    AnsDes = modemnet,
                    QuestionId = 785,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(aa);
            }
            else
            {
                string modemnet = Request.Form["onuModemRadio"];
                ans44.AnsDes = modemnet;
                ans44.AnserTypeId = 4;
                ans44.CreateDate = DateTime.Now;
                ans44.QuestionId = 785;
                ans44.UserId = user.Id;
                ans44.AnsMonth = ansMonth; ans44.SRId = sR.Id;
            }



            //Swicth 8 part :
            var ans45 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 786).FirstOrDefault();
            if (ans45 == null)
            {
                string swiftpart = Request.Form["switchportRadio"];
                Answer answer50 = new Answer()
                {
                    AnsDes = swiftpart,
                    QuestionId = 786,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer50);
            }
            else
            {
                string swiftpart = Request.Form["switchportRadio"];
                ans45.AnsDes = swiftpart;
                ans45.AnserTypeId = 4;
                ans45.CreateDate = DateTime.Now;
                ans45.QuestionId = 786;
                ans45.UserId = user.Id;
                ans45.AnsMonth = ansMonth; ans45.SRId = sR.Id;
            }


            //Swicth 48 port :
            var ans46 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 787).FirstOrDefault();
            if (ans46 == null)
            {
                string ee = Request.Form["switch48portRadio"];
                Answer answer51 = new Answer()
                {
                    AnsDes = ee,
                    QuestionId = 787,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer51);
            }
            else
            {
                string ee = Request.Form["switch48portRadio"];
                ans46.AnsDes = ee;
                ans46.AnserTypeId = 4;
                ans46.CreateDate = DateTime.Now;
                ans46.QuestionId = 787;
                ans46.UserId = user.Id;
                ans46.AnsMonth = ansMonth; ans46.SRId = sR.Id;
            }


            //Outdoor AP ตัวที่ 1  :
            var ans47 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 788).FirstOrDefault();
            if (ans47 == null)
            {
                string otap = Request.Form["outdoorapRadio"];
                Answer answer52 = new Answer()
                {
                    AnsDes = otap,
                    QuestionId = 788,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer52);
            }
            else
            {
                string otap = Request.Form["outdoorapRadio"];
                ans47.AnsDes = otap;
                ans47.AnserTypeId = 4;
                ans47.CreateDate = DateTime.Now;
                ans47.QuestionId = 788;
                ans47.UserId = user.Id;
                ans47.AnsMonth = ansMonth; ans47.SRId = sR.Id;
            }



            //Outdoor AP ตัวที่ 2 :
            var ans48 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 789).FirstOrDefault();
            if (ans48 == null)
            {
                string otap2 = Request.Form["outdoorap2Radio"];
                Answer answer53 = new Answer()
                {
                    AnsDes = otap2,
                    QuestionId = 789,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer53);
            }
            else
            {
                string otap2 = Request.Form["outdoorap2Radio"];
                ans48.AnsDes = otap2;
                ans48.AnserTypeId = 4;
                ans48.CreateDate = DateTime.Now;
                ans48.QuestionId = 789;
                ans48.UserId = user.Id;
                ans48.AnsMonth = ansMonth; ans48.SRId = sR.Id;
            }


            //indoor AP ตัวที่ 1 :
            var ans49 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 790).FirstOrDefault();
            if (ans49 == null)
            {
                string inap2 = Request.Form["indoorapRadio"];
                Answer answer54 = new Answer()
                {
                    AnsDes = inap2,
                    QuestionId = 790,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer54);
            }
            else
            {
                string inap2 = Request.Form["indoorapRadio"];
                ans49.AnsDes = inap2;
                ans49.AnserTypeId = 4;
                ans49.CreateDate = DateTime.Now;
                ans49.QuestionId = 790;
                ans49.UserId = user.Id;
                ans49.AnsMonth = ansMonth; ans49.SRId = sR.Id;
            }

            //indoor AP ตัวที่ 2 :
            var ans49__2 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 791).FirstOrDefault();
            if (ans49__2 == null)
            {
                string inapp = Request.Form["indoorap2Radio"];
                Answer answer54 = new Answer()
                {
                    AnsDes = inapp,
                    QuestionId = 791,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer54);
            }
            else
            {
                string inapp = Request.Form["indoorap2Radio"];
                ans49__2.AnsDes = inapp;
                ans49__2.AnserTypeId = 4;
                ans49__2.CreateDate = DateTime.Now;
                ans49__2.QuestionId = 791;
                ans49__2.UserId = user.Id;
                ans49__2.AnsMonth = ansMonth; ans49__2.SRId = sR.Id;
            }



            //การ Wiring สายไฟ :
            var ans50 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 792).FirstOrDefault();
            if (ans50 == null)
            {
                string wiring = Request.Form["wiringelecRadio"];
                Answer answer56 = new Answer()
                {
                    AnsDes = wiring,
                    QuestionId = 792,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer56);
            }
            else
            {
                string wiring = Request.Form["wiringelecRadio"];
                ans50.AnsDes = wiring;
                ans50.AnserTypeId = 4;
                ans50.CreateDate = DateTime.Now;
                ans50.QuestionId = 792;
                ans50.UserId = user.Id;
                ans50.AnsMonth = ansMonth; ans50.SRId = sR.Id;
            }


            //การ Wiring Patch cord และ สาย LAN :
            var ans51 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 793).FirstOrDefault();
            if (ans51 == null)
            {
                string wiringPatch = Request.Form["wiringpatchRadio"];
                Answer answer57 = new Answer()
                {
                    AnsDes = wiringPatch,
                    QuestionId = 793,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer57);
            }
            else
            {
                string wiringPatch = Request.Form["wiringpatchRadio"];
                ans51.AnsDes = wiringPatch;
                ans51.AnserTypeId = 4;
                ans51.CreateDate = DateTime.Now;
                ans51.QuestionId = 793;
                ans51.UserId = user.Id;
                ans51.AnsMonth = ansMonth; 
                ans51.SRId = sR.Id;
            }



            //ความแข็งแรงจุดต่อ Ground Bar :
            var ans51_ = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 794).FirstOrDefault();
            if (ans51_ == null)
            {
                string gb = Request.Form["groundbarRadio"];
                Answer answer58 = new Answer()
                {
                    AnsDes = gb,
                    QuestionId = 794,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer58);
            }
            else
            {
                string gb = Request.Form["groundbarRadio"];
                ans51_.AnsDes = gb;
                ans51_.AnserTypeId = 4;
                ans51_.CreateDate = DateTime.Now;
                ans51_.QuestionId = 794;
                ans51_.UserId = user.Id;
                ans51_.AnsMonth = ansMonth;
                ans51_.SRId = sR.Id;
            }


            //ความแข็งแรงของน็อตขันหางปลาอุปกรณ์ :
            var ans52 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 795).FirstOrDefault();
            if (ans52 == null)
            {
                string fishnot = Request.Form["notfishRadio"];
                Answer answer59 = new Answer()
                {
                    AnsDes = fishnot,
                    QuestionId = 795,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer59);
            }
            else
            {
                string fishnot = Request.Form["notfishRadio"];
                ans52.AnsDes = fishnot;
                ans52.AnserTypeId = 4;
                ans52.CreateDate = DateTime.Now;
                ans52.QuestionId = 795;
                ans52.UserId = user.Id;
                ans52.AnsMonth = ansMonth; ans52.SRId = sR.Id;
            }
            //สายกราวด์เรียบร้อย ปลอดภัย สมบูรณ์ :
            var ans53 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 796).FirstOrDefault();
            if (ans53 == null)
            {
                string ffss = Request.Form["safegroundRadio"];
                Answer answer60 = new Answer()
                {
                    AnsDes = ffss,
                    QuestionId = 796,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer60);
            }
            else
            {
                string ffss = Request.Form["safegroundRadio"];
                ans53.AnsDes = ffss;
                ans53.AnserTypeId = 4;
                ans53.CreateDate = DateTime.Now;
                ans53.QuestionId = 796;
                ans53.UserId = user.Id;
                ans53.AnsMonth = ansMonth; ans53.SRId = sR.Id;
            }

            //สถานะไฟฟ้ารั่วลง Ground :
            var ans54 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 797).FirstOrDefault();
            if (ans54 == null)
            {
                string elecground = Request.Form["brokenElecRadio"];
                Answer answer61 = new Answer()
                {
                    AnsDes = elecground,
                    QuestionId = 797,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer61);
            }
            else
            {

                string elecground = Request.Form["brokenElecRadio"];
                ans54.AnsDes = elecground;
                ans54.AnserTypeId = 4;
                ans54.CreateDate = DateTime.Now;
                ans54.QuestionId = 797;
                ans54.UserId = user.Id;
                ans54.AnsMonth = ansMonth; ans54.SRId = sR.Id;
            }


            //Fire Alarm และ Smoke Detector :
            var ans55 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 798).FirstOrDefault();
            if (ans55 == null)
            {
                string firesmokeDetec = Request.Form["firesmokedDectorRadio"];
                Answer answer62 = new Answer()
                {
                    AnsDes = firesmokeDetec,
                    QuestionId = 798,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer62);
            }
            else
            {
                string firesmokeDetec = Request.Form["firesmokedDectorRadio"];
                ans55.AnsDes = firesmokeDetec;
                ans55.AnserTypeId = 4;
                ans55.CreateDate = DateTime.Now;
                ans55.QuestionId = 798;
                ans55.UserId = user.Id;
                ans55.AnsMonth = ansMonth; ans55.SRId = sR.Id;
            }



            //Fire Alarm Manual Switch :
            var ans56 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 799).FirstOrDefault();
            if (ans56 == null)
            {
                string FireAlarmManualSwitch = Request.Form["firealarmManualswitchRadio"];
                Answer answer63 = new Answer()
                {
                    AnsDes = FireAlarmManualSwitch,
                    QuestionId = 799,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer63);
            }
            else
            {
                string FireAlarmManualSwitch = Request.Form["firealarmManualswitchRadio"];
                ans56.AnsDes = FireAlarmManualSwitch;
                ans56.AnserTypeId = 4;
                ans56.CreateDate = DateTime.Now;
                ans56.QuestionId = 799;
                ans56.UserId = user.Id;
                ans56.AnsMonth = ansMonth; ans56.SRId = sR.Id;
            }



            // Battery Fire Alarm ก้อนที่ 1 :    

            var ans57 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 800).FirstOrDefault();
            if (ans57 == null)
            {
                Answer answer64 = new Answer()
                {
                    AnsDes = this.battFirealarm1Textbox.Value,
                    QuestionId = 800,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer64);
            }
            else
            {

                ans57.AnsDes = this.battFirealarm1Textbox.Value;
                ans57.AnserTypeId = 1;
                ans57.CreateDate = DateTime.Now;
                ans57.QuestionId = 800;
                ans57.UserId = user.Id;
                ans57.AnsMonth = ansMonth; ans57.SRId = sR.Id;
            }
            var ans58 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 801).FirstOrDefault();
            if (ans58 == null)
            {
                // Battery Fire Alarm ก้อนที่ 2 : 

                Answer answer65 = new Answer()
                {
                    AnsDes = this.battFirealarm3Textbox.Value,
                    QuestionId = 801,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer65);
            }
            else
            {
                ans58.AnsDes = this.battFirealarm3Textbox.Value;
                ans58.AnserTypeId = 1;
                ans58.CreateDate = DateTime.Now;
                ans58.QuestionId = 801;
                ans58.UserId = user.Id;
                ans58.AnsMonth = ansMonth; ans58.SRId = sR.Id;
            }


            //ไฟแสงสว่างฉุกเฉิน :
            var ans59 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 802).FirstOrDefault();
            if (ans59 == null)
            {
                string emerr = Request.Form["emerLightRadio"];
                Answer answer66 = new Answer()
                {
                    AnsDes = emerr,
                    QuestionId = 802,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer66);
            }
            else
            {
                string emerr = Request.Form["emerLightRadio"];
                ans59.AnsDes = emerr;
                ans59.AnserTypeId = 4;
                ans59.CreateDate = DateTime.Now;
                ans59.QuestionId = 802;
                ans59.UserId = user.Id;
                ans59.AnsMonth = ansMonth; ans59.SRId = sR.Id;
            }


            //ระบบ Monitor กล้องวงจรปิด :
            var ans60 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 803).FirstOrDefault();
            if (ans60 == null)
            {
                string monitorr = Request.Form["monitorCameraRadio"];
                Answer answer67 = new Answer()
                {
                    AnsDes = monitorr,
                    QuestionId = 803,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer67);
            }
            else
            {
                string monitorr = Request.Form["monitorCameraRadio"];
                ans60.AnsDes = monitorr;
                ans60.AnserTypeId = 4;
                ans60.CreateDate = DateTime.Now;
                ans60.QuestionId = 803;
                ans60.UserId = user.Id;
                ans60.AnsMonth = ansMonth; ans60.SRId = sR.Id;
            }

            // hall
            var ans61 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 804).FirstOrDefault();
            if (ans61 == null)
            {
                string camerahall = Request.Form["cameraHallRadio"];
                Answer answer68 = new Answer()
                {
                    AnsDes = camerahall,
                    QuestionId = 804,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer68);
            }
            else
            {
                string camerahall = Request.Form["cameraHallRadio"];
                ans61.AnsDes = camerahall;
                ans61.AnserTypeId = 4;
                ans61.CreateDate = DateTime.Now;
                ans61.QuestionId = 804;
                ans61.UserId = user.Id;
                ans61.AnsMonth = ansMonth; ans61.SRId = sR.Id;
            }

            // meeting
            var ans62 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 805).FirstOrDefault();
            if (ans62 == null)
            {
                string camerameet = Request.Form["camerameetingRadio"];
                Answer answer69 = new Answer()
                {
                    AnsDes = camerameet,
                    QuestionId = 805,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer69);
            }
            else
            {
                string camerameet = Request.Form["camerameetingRadio"];
                ans62.AnsDes = camerameet;
                ans62.AnserTypeId = 4;
                ans62.CreateDate = DateTime.Now;
                ans62.QuestionId = 805;
                ans62.UserId = user.Id;
                ans62.AnsMonth = ansMonth; ans62.SRId = sR.Id;
            }
            // in
            var ans63 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 806).FirstOrDefault();
            if (ans63 == null)
            {
                string camerain = Request.Form["camerainRadio"];
                Answer answer70 = new Answer()
                {
                    AnsDes = camerain,
                    QuestionId = 806,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer70);
            }
            else
            {
                string camerain = Request.Form["camerainRadio"];
                ans63.AnsDes = camerain;
                ans63.AnserTypeId = 4;
                ans63.CreateDate = DateTime.Now;
                ans63.QuestionId = 806;
                ans63.UserId = user.Id;
                ans63.AnsMonth = ansMonth; ans63.SRId = sR.Id;
            }
            // back
            var ans64 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 807).FirstOrDefault();
            if (ans64 == null)
            {
                string cameraback = Request.Form["camerabackRadio"];
                Answer answer71 = new Answer()
                {
                    AnsDes = cameraback,
                    QuestionId = 807,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer71);
            }
            else
            {
                string cameraback = Request.Form["camerabackRadio"];
                ans64.AnsDes = cameraback;
                ans64.AnserTypeId = 4;
                ans64.CreateDate = DateTime.Now;
                ans64.QuestionId = 807;
                ans64.UserId = user.Id;
                ans64.AnsMonth = ansMonth; ans64.SRId = sR.Id;
            }
            // font
            var ans65 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 808).FirstOrDefault();
            if (ans65 == null)
            {
                string camerafont = Request.Form["camerafont2Radio"];
                Answer answer72 = new Answer()
                {
                    AnsDes = camerafont,
                    QuestionId = 808,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer72);
            }
            else
            {
                string camerafont = Request.Form["camerafont2Radio"];
                ans65.AnsDes = camerafont;
                ans65.AnserTypeId = 4;
                ans65.CreateDate = DateTime.Now;
                ans65.QuestionId = 808;
                ans65.UserId = user.Id;
                ans65.AnsMonth = ansMonth; ans65.SRId = sR.Id;
            }

            //  จอทีวีห้องประชุม   :
            var ans66 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 809).FirstOrDefault();
            if (ans66 == null)
            {
                string tv = Request.Form["televisRadio"];
                Answer answer73 = new Answer()
                {
                    AnsDes = tv,
                    QuestionId = 809,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer73);
            }
            else
            {
                string tv = Request.Form["televisRadio"];
                ans66.AnsDes = tv;
                ans66.AnserTypeId = 4;
                ans66.CreateDate = DateTime.Now;
                ans66.QuestionId = 809;
                ans66.UserId = user.Id;
                ans66.AnsMonth = ansMonth; ans66.SRId = sR.Id;
            }


            //  คอมพิวเตอร์เจ้าหน้าที่ศูนย์  :
            var ans67 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 810).FirstOrDefault();
            if (ans67 == null)
            {
                string comagent = Request.Form["computerAgentRadio"];
                Answer answer74 = new Answer()
                {
                    AnsDes = comagent,
                    QuestionId = 810,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer74);
            }
            else
            {
                string comagent = Request.Form["computerAgentRadio"];
                ans67.AnsDes = comagent;
                ans67.AnserTypeId = 4;
                ans67.CreateDate = DateTime.Now;
                ans67.QuestionId = 810;
                ans67.UserId = user.Id;
                ans67.AnsMonth = ansMonth; ans67.SRId = sR.Id;
            }


            //  Printer  :
            var ans68 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 811).FirstOrDefault();
            if (ans68 == null)
            {
                string print = Request.Form["printerRadio"];
                Answer answer75 = new Answer()
                {
                    AnsDes = print,
                    QuestionId = 811,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer75);
            }
            else
            {
                string print = Request.Form["printerRadio"];
                ans68.AnsDes = print;
                ans68.AnserTypeId = 4;
                ans68.CreateDate = DateTime.Now;
                ans68.QuestionId = 811;
                ans68.UserId = user.Id;
                ans68.AnsMonth = ansMonth; ans68.SRId = sR.Id;
            }


            // คอมพิวเตอร์ตัวที่ 1  :
            var ans69 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 812).FirstOrDefault();
            if (ans69 == null)
            {
                string com1 = Request.Form["Com1Radio"];
                Answer answer76 = new Answer()
                {
                    AnsDes = com1,
                    QuestionId = 812,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer76);
            }
            else
            {
                string com1 = Request.Form["Com1Radio"];
                ans69.AnsDes = com1;
                ans69.AnserTypeId = 4;
                ans69.CreateDate = DateTime.Now;
                ans69.QuestionId = 812;
                ans69.UserId = user.Id;
                ans69.AnsMonth = ansMonth; ans69.SRId = sR.Id;
            }


            // คอมพิวเตอร์ตัวที่ 2  :
            var ans70 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 813).FirstOrDefault();
            if (ans70 == null)
            {
                string com2 = Request.Form["Com2Radio"];
                Answer answer76 = new Answer()
                {
                    AnsDes = com2,
                    QuestionId = 813,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer76);
            }
            else
            {
                string com2 = Request.Form["Com2Radio"];
                ans70.AnsDes = com2;
                ans70.AnserTypeId = 4;
                ans70.CreateDate = DateTime.Now;
                ans70.QuestionId = 813;
                ans70.UserId = user.Id;
                ans70.AnsMonth = ansMonth; ans70.SRId = sR.Id;
            }



            // คอมพิวเตอร์ตัวที่ 3  :
            var ans71 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 814).FirstOrDefault();
            if (ans71 == null)
            {
                string com3 = Request.Form["com3Radio"];
                Answer answer76 = new Answer()
                {
                    AnsDes = com3,
                    QuestionId = 814,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer76);
            }
            else
            {
                string com3 = Request.Form["com3Radio"];
                ans71.AnsDes = com3;
                ans71.AnserTypeId = 4;
                ans71.CreateDate = DateTime.Now;
                ans71.QuestionId = 814;
                ans71.UserId = user.Id;
                ans71.AnsMonth = ansMonth; ans71.SRId = sR.Id;
            }



            // คอมพิวเตอร์ตัวที่ 4  :
            var ans72 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 815).FirstOrDefault();
            if (ans72 == null)
            {
                string com4 = Request.Form["com4Radio"];
                Answer answer76 = new Answer()
                {
                    AnsDes = com4,
                    QuestionId = 815,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer76);
            }
            else
            {
                string com4 = Request.Form["com4Radio"];
                ans72.AnsDes = com4;
                ans72.AnserTypeId = 4;
                ans72.CreateDate = DateTime.Now;
                ans72.QuestionId = 815;
                ans72.UserId = user.Id;
                ans72.AnsMonth = ansMonth; ans72.SRId = sR.Id;
            }





            // คอมพิวเตอร์ตัวที่ 5  :
            var ans73 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 816).FirstOrDefault();
            if (ans73 == null)
            {
                string com5 = Request.Form["com5Radio"];
                Answer answer81 = new Answer()
                {
                    AnsDes = com5,
                    QuestionId = 816,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer81);
            }
            else
            {
                string com5 = Request.Form["com5Radio"];
                ans73.AnsDes = com5;
                ans73.AnserTypeId = 4;
                ans73.CreateDate = DateTime.Now;
                ans73.QuestionId = 816;
                ans73.UserId = user.Id;
                ans73.AnsMonth = ansMonth; ans73.SRId = sR.Id;
            }




            // คอมพิวเตอร์ตัวที่ 6  :
            var ans74 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 817).FirstOrDefault();
            if (ans74 == null)
            {
                string com6 = Request.Form["com6Radio"];
                Answer answer82 = new Answer()
                {
                    AnsDes = com6,
                    QuestionId = 817,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer82);
            }
            else
            {
                string com6 = Request.Form["com6Radio"];
                ans74.AnsDes = com6;
                ans74.AnserTypeId = 4;
                ans74.CreateDate = DateTime.Now;
                ans74.QuestionId = 817;
                ans74.UserId = user.Id;
                ans74.AnsMonth = ansMonth; ans74.SRId = sR.Id;
            }



            // คอมพิวเตอร์ตัวที่ 7  :
            var ans75 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 818).FirstOrDefault();
            if (ans75 == null)
            {
                string com7 = Request.Form["com7Radio"];
                Answer answer83 = new Answer()
                {
                    AnsDes = com7,
                    QuestionId = 818,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer83);
            }
            else
            {
                string com7 = Request.Form["com7Radio"];
                ans75.AnsDes = com7;
                ans75.AnserTypeId = 4;
                ans75.CreateDate = DateTime.Now;
                ans75.QuestionId = 818;
                ans75.UserId = user.Id;
                ans75.AnsMonth = ansMonth; ans75.SRId = sR.Id;
            }



            // คอมพิวเตอร์ตัวที่ 8  :
            var ans76 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 819).FirstOrDefault();
            if (ans76 == null)
            {
                string com8 = Request.Form["com8Radio"];
                Answer answer84 = new Answer()
                {
                    AnsDes = com8,
                    QuestionId = 819,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer84);
            }
            else
            {
                string com8 = Request.Form["com8Radio"];
                ans76.AnsDes = com8;
                ans76.AnserTypeId = 4;
                ans76.CreateDate = DateTime.Now;
                ans76.QuestionId = 819;
                ans76.UserId = user.Id;
                ans76.AnsMonth = ansMonth; ans76.SRId = sR.Id;
            }



            // คอมพิวเตอร์ตัวที่ 9  :
            var ans77 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 820).FirstOrDefault();
            if (ans77 == null)
            {
                string com9 = Request.Form["com9Radio"];
                Answer answer85 = new Answer()
                {
                    AnsDes = com9,
                    QuestionId = 820,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer85);
            }
            else
            {
                string com9 = Request.Form["com9Radio"];
                ans77.AnsDes = com9;
                ans77.AnserTypeId = 4;
                ans77.CreateDate = DateTime.Now;
                ans77.QuestionId = 820;
                ans77.UserId = user.Id;
                ans77.AnsMonth = ansMonth; ans76.SRId = sR.Id;
            }



            // คอมพิวเตอร์ตัวที่ 10  :
            var ans78 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 821).FirstOrDefault();
            if (ans78 == null)
            {
                string com10 = Request.Form["com10Radio"];
                Answer answer86 = new Answer()
                {
                    AnsDes = com10,
                    QuestionId = 821,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer86);
            }
            else
            {
                string com10 = Request.Form["com10Radio"];
                ans78.AnsDes = com10;
                ans78.AnserTypeId = 4;
                ans78.CreateDate = DateTime.Now;
                ans78.QuestionId = 821;
                ans78.UserId = user.Id;
                ans78.AnsMonth = ansMonth; ans78.SRId = sR.Id;

            }

            // คอมพิวเตอร์ตัวที่ 11  822
            var ans79 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 821).FirstOrDefault();
            if (ans79 == null)
            {
                string com11 = Request.Form["com11Radio"];
                Answer answer87 = new Answer()
                {
                    AnsDes = com11,
                    QuestionId = 822,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer87);
            }
            else
            {
                string com11 = Request.Form["com11Radio"];
                ans79.AnsDes = com11;
                ans79.AnserTypeId = 4;
                ans79.CreateDate = DateTime.Now;
                ans79.QuestionId = 822;
                ans79.UserId = user.Id;
                ans79.AnsMonth = ansMonth; ans79.SRId = sR.Id;
            }

            // แอ 1  :
            var ans80 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 823).FirstOrDefault();
            if (ans80 == null)
            {
                string air1 = Request.Form["airhall"];
                Answer answer88 = new Answer()
                {
                    AnsDes = air1,
                    QuestionId = 823,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer88);
            }
            else
            {
                string air1 = Request.Form["airhall"];
                ans80.AnsDes = air1;
                ans80.AnserTypeId = 4;
                ans80.CreateDate = DateTime.Now;
                ans80.QuestionId = 823;
                ans80.UserId = user.Id;
                ans80.AnsMonth = ansMonth; ans80.SRId = sR.Id;
            }

            // แอ 2  :
            var ans81 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 824).FirstOrDefault();
            if (ans81 == null)
            {
                string air2 = Request.Form["airmeeting"];
                Answer answer89 = new Answer()
                {
                    AnsDes = air2,
                    QuestionId = 824,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer89);
            }
            else
            {
                string air2 = Request.Form["airmeeting"];
                ans81.AnsDes = air2;
                ans81.AnserTypeId = 4;
                ans81.CreateDate = DateTime.Now;
                ans81.QuestionId = 824;
                ans81.UserId = user.Id;
                ans81.AnsMonth = ansMonth; ans81.SRId = sR.Id;
            }

            // แอ 3  :
            var ans82 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 825).FirstOrDefault();
            if (ans82 == null)
            {
                string air3 = Request.Form["airserver"];
                Answer answer90 = new Answer()
                {
                    AnsDes = air3,
                    QuestionId = 825,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer90);
            }
            else
            {
                string air3 = Request.Form["airserver"];
                ans82.AnsDes = air3;
                ans82.AnserTypeId = 4;
                ans82.CreateDate = DateTime.Now;
                ans82.QuestionId = 825;
                ans82.UserId = user.Id;
                ans82.AnsMonth = ansMonth; ans82.SRId = sR.Id;
            }

            // แอ 4  :
            var ans83 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 826).FirstOrDefault();
            if (ans83 == null)
            {
                string air4 = Request.Form["airtoilet"];
                Answer answer91 = new Answer()
                {
                    AnsDes = air4,
                    QuestionId = 826,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer91);
            }
            else
            {
                string air4 = Request.Form["airtoilet"];
                ans83.AnsDes = air4;
                ans83.AnserTypeId = 4;
                ans83.CreateDate = DateTime.Now;
                ans83.QuestionId = 826;
                ans83.UserId = user.Id;
                ans83.AnsMonth = ansMonth; ans83.SRId = sR.Id;
            }

            // แอ 5  :
            var ans84 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 827).FirstOrDefault();
            if (ans84 == null)
            {
                string air5 = Request.Form["airpump"];
                Answer answer92 = new Answer()
                {
                    AnsDes = air5,
                    QuestionId = 827,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer92);
            }
            else
            {
                string air5 = Request.Form["airpump"];
                ans84.AnsDes = air5;
                ans84.AnserTypeId = 4;
                ans84.CreateDate = DateTime.Now;
                ans84.QuestionId = 827;
                ans84.UserId = user.Id;
                ans84.AnsMonth = ansMonth; ans84.SRId = sR.Id;
            }

            // ปั้ม  :
            var ans85_1 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 828).FirstOrDefault();
            if (ans85_1 == null)
            {
                string pump1 = Request.Form["meterwater"];
                Answer answer93 = new Answer()
                {
                    AnsDes = pump1,
                    QuestionId = 828,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer93);
            }
            else
            {
                string pump1 = Request.Form["meterwater"];
                ans85_1.AnsDes = pump1;
                ans85_1.AnserTypeId = 4;
                ans85_1.CreateDate = DateTime.Now;
                ans85_1.QuestionId = 828;
                ans85_1.UserId = user.Id;
                ans85_1.AnsMonth = ansMonth; ans85_1.SRId = sR.Id;
            }

            // ปั้ม  :
            var ans86_1 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 829).FirstOrDefault();
            if (ans86_1 == null)
            {
                string pump2 = Request.Form["pumpwater"];
                Answer answer94 = new Answer()
                {
                    AnsDes = pump2,
                    QuestionId = 829,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer94);
            }
            else
            {
                string pump2 = Request.Form["pumpwater"];
                ans86_1.AnsDes = pump2;
                ans86_1.AnserTypeId = 4;
                ans86_1.CreateDate = DateTime.Now;
                ans86_1.QuestionId = 829;
                ans86_1.UserId = user.Id;
                ans86_1.AnsMonth = ansMonth; ans86_1.SRId = sR.Id;

            }

            // ปั้ม :
            var ans87_1 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 830).FirstOrDefault();
            if (ans87_1 == null)
            {
                string pump3 = Request.Form["cableandplugpumpwater"];
                Answer answer95 = new Answer()
                {
                    AnsDes = pump3,
                    QuestionId = 830,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer95);
            }
            else
            {
                string pump3 = Request.Form["cableandplugpumpwater"];
                ans87_1.AnsDes = pump3;
                ans87_1.AnserTypeId = 4;
                ans87_1.CreateDate = DateTime.Now;
                ans87_1.QuestionId = 830;
                ans87_1.UserId = user.Id;
                ans87_1.AnsMonth = ansMonth; ans87_1.SRId = sR.Id;

            }

            // ปั้ม  :
            var ans88_1 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 831).FirstOrDefault();
            if (ans88_1 == null)
            {
                string pump4 = Request.Form["toiletitem"];
                Answer answer96 = new Answer()
                {
                    AnsDes = pump4,
                    QuestionId = 831,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer96);
            }
            else
            {
                string pump4 = Request.Form["toiletitem"];
                ans88_1.AnsDes = pump4;
                ans88_1.AnserTypeId = 4;
                ans88_1.CreateDate = DateTime.Now;
                ans88_1.QuestionId = 831;
                ans88_1.UserId = user.Id;
                ans88_1.AnsMonth = ansMonth; ans88_1.SRId = sR.Id;

            }

            // อาคาร  :
            var ans89_1 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 832).FirstOrDefault();
            if (ans89_1 == null)
            {
                string building1 = Request.Form["cleaningin"];
                Answer answer97 = new Answer()
                {
                    AnsDes = building1,
                    QuestionId = 832,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer97);
            }
            else
            {
                string building1 = Request.Form["cleaningin"];
                ans89_1.AnsDes = building1;
                ans89_1.AnserTypeId = 4;
                ans89_1.CreateDate = DateTime.Now;
                ans89_1.QuestionId = 832;
                ans89_1.UserId = user.Id;
                ans89_1.AnsMonth = ansMonth; ans89_1.SRId = sR.Id;

            }

            // อาคาร  :
            var ans90_1 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 833).FirstOrDefault();
            if (ans90_1 == null)
            {
                string building2 = Request.Form["cleaningout"];
                Answer answer98 = new Answer()
                {
                    AnsDes = building2,
                    QuestionId = 833,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer98);
            }
            else
            {
                string building2 = Request.Form["cleaningout"];
                ans90_1.AnsDes = building2;
                ans90_1.AnserTypeId = 4;
                ans90_1.CreateDate = DateTime.Now;
                ans90_1.QuestionId = 833;
                ans90_1.UserId = user.Id;
                ans90_1.AnsMonth = ansMonth; ans90_1.SRId = sR.Id;
            }

            // อาคาร  :
            var ans91 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 834).FirstOrDefault();
            if (ans91 == null)
            {
                string building3 = Request.Form["cleaningDrain"];
                Answer answer99 = new Answer()
                {
                    AnsDes = building3,
                    QuestionId = 834,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer99);
            }
            else
            {
                string building3 = Request.Form["cleaningDrain"];
                ans91.AnsDes = building3;
                ans91.AnserTypeId = 4;
                ans91.CreateDate = DateTime.Now;
                ans91.QuestionId = 834;
                ans91.UserId = user.Id;
                ans91.AnsMonth = ansMonth; ans91.SRId = sR.Id;
            }

            // อาคาร  :
            var ans92 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 835).FirstOrDefault();
            if (ans92 == null)
            {
                string building4 = Request.Form["Handrail"];
                Answer answer100 = new Answer()
                {
                    AnsDes = building4,
                    QuestionId = 835,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer100);
            }
            else
            {
                string building4 = Request.Form["Handrail"];
                ans92.AnsDes = building4;
                ans92.AnserTypeId = 4;
                ans92.CreateDate = DateTime.Now;
                ans92.QuestionId = 835;
                ans92.UserId = user.Id;
                ans92.AnsMonth = ansMonth; ans92.SRId = sR.Id;

            }

            // อาคาร  :
            var ans93 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 836).FirstOrDefault();
            if (ans93 == null)
            {
                string building5 = Request.Form["doorfont"];
                Answer answer101 = new Answer()
                {
                    AnsDes = building5,
                    QuestionId = 836,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer101);
            }
            else
            {
                string building5 = Request.Form["doorfont"];
                ans93.AnsDes = building5;
                ans93.AnserTypeId = 4;
                ans93.CreateDate = DateTime.Now;
                ans93.QuestionId = 836;
                ans93.UserId = user.Id;
                ans93.AnsMonth = ansMonth; ans93.SRId = sR.Id;
            }

            // อาคาร  :
            var ans94 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 837).FirstOrDefault();
            if (ans94 == null)
            {
                string building6 = Request.Form["doorfontmeeting"];
                Answer answer102 = new Answer()
                {
                    AnsDes = building6,
                    QuestionId = 837,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer102);
            }
            else
            {

                string building6 = Request.Form["doorfontmeeting"];
                ans94.AnsDes = building6;
                ans94.AnserTypeId = 4;
                ans94.CreateDate = DateTime.Now;
                ans94.QuestionId = 837;
                ans94.UserId = user.Id;
                ans94.AnsMonth = ansMonth; ans94.SRId = sR.Id;
            }

            // อาคาร  :
            var ans95 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 838).FirstOrDefault();
            if (ans95 == null)
            {
                string building7 = Request.Form["doorpump"];
                Answer answer103 = new Answer()
                {
                    AnsDes = building7,
                    QuestionId = 838,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer103);
            }
            else
            {
                string building7 = Request.Form["doorpump"];
                ans95.AnsDes = building7;
                ans95.AnserTypeId = 4;
                ans95.CreateDate = DateTime.Now;
                ans95.QuestionId = 838;
                ans95.UserId = user.Id;
                ans95.AnsMonth = ansMonth; ans95.SRId = sR.Id;
            }


            // อุปกรณ์ LNB/BUC   :
            var ans62_ = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 839).FirstOrDefault();
            if (ans62_ == null)
            {
                string tools = Request.Form["toolslnbRadio"];
                Answer answer104 = new Answer()
                {
                    AnsDes = tools,
                    QuestionId = 839,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer104);
            }
            else
            {
                string tools = Request.Form["toolslnbRadio"];
                ans62_.AnsDes = tools;
                ans62_.AnserTypeId = 4;
                ans62_.CreateDate = DateTime.Now;
                ans62_.QuestionId = 839;
                ans62_.UserId = user.Id;
                ans62_.AnsMonth = ansMonth; ans62_.SRId = sR.Id;
            }


            // การเก็บสาย RG และการพันหัว   :
            var ans63_ = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 840).FirstOrDefault();
            if (ans63_ == null)
            {
                string toolsRG = Request.Form["wiringrgRadio"];
                Answer answer105 = new Answer()
                {
                    AnsDes = toolsRG,
                    QuestionId = 840,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer105);
            }
            else
            {
                string toolsRG = Request.Form["wiringrgRadio"];
                ans63_.AnsDes = toolsRG;
                ans63_.AnserTypeId = 4;
                ans63_.CreateDate = DateTime.Now;
                ans63_.QuestionId = 840;
                ans63_.UserId = user.Id;
                ans63_.AnsMonth = ansMonth; ans63_.SRId = sR.Id;
            }



            // ฐานและระดับของเสาจาน  :
            var ans64_ = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 841).FirstOrDefault();
            if (ans64 == null)
            {
                string baseOneiei = Request.Form["baseOnRadio"];
                Answer answer106 = new Answer()
                {
                    AnsDes = baseOneiei,
                    QuestionId = 841,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer106);
            }
            else
            {
                string baseOneiei = Request.Form["baseOnRadio"];
                ans64_.AnsDes = baseOneiei;
                ans64_.AnserTypeId = 4;
                ans64_.CreateDate = DateTime.Now;
                ans64_.QuestionId = 841;
                ans64_.UserId = user.Id;
                ans64_.AnsMonth = ansMonth; ans64_.SRId = sR.Id;
            }


            // แนว Line Of Sight  :
            var ans65_ = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 842).FirstOrDefault();
            if (ans65_ == null)
            {
                string lineOf = Request.Form["lineOfsightRadio"];
                Answer answer107 = new Answer()
                {
                    AnsDes = lineOf,
                    QuestionId = 842,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer107);
            }
            else
            {
                string lineOf = Request.Form["lineOfsightRadio"];
                ans65_.AnsDes = lineOf;
                ans65_.AnserTypeId = 4;
                ans65_.CreateDate = DateTime.Now;
                ans65_.QuestionId = 842;
                ans65_.UserId = user.Id;
                ans65_.AnsMonth = ansMonth; ans65_.SRId = sR.Id;
            }


            // ความสะอาดของหน้าจาน  :
            var ans66_ = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 843).FirstOrDefault();
            if (ans66_ == null)
            {
                string clendDish = Request.Form["cleaningDishRadio"];
                Answer answer108 = new Answer()
                {
                    AnsDes = clendDish,
                    QuestionId = 843,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer108);
            }
            else
            {
                string clendDish = Request.Form["cleaningDishRadio"];
                ans66_.AnsDes = clendDish;
                ans66_.AnserTypeId = 4;
                ans66_.CreateDate = DateTime.Now;
                ans66_.QuestionId = 843;
                ans66_.UserId = user.Id;
                ans66_.AnsMonth = ansMonth; ans66_.SRId = sR.Id;

            }


            // LNB Band Switch  :
            var ans67_ = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 844).FirstOrDefault();
            if (ans67_ == null)
            {
                string lnbswitch = Request.Form["lnbbandswitchRadio"];
                Answer answer109 = new Answer()
                {
                    AnsDes = lnbswitch,
                    QuestionId = 844,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer109);
            }
            else
            {
                string lnbswitch = Request.Form["lnbbandswitchRadio"];
                ans67_.AnsDes = lnbswitch;
                ans67_.AnserTypeId = 4;
                ans67_.CreateDate = DateTime.Now;
                ans67_.QuestionId = 844;
                ans67_.UserId = user.Id;
                ans67_.AnsMonth = ansMonth; ans67_.SRId = sR.Id;
            }

            // ระบบ Solar Cell :
            var ans68_ = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 845).FirstOrDefault();
            if (ans68_ == null)
            {
                string solarCells = Request.Form["solarcellSystemRadio"];
                Answer answer110 = new Answer()
                {
                    AnsDes = solarCells,
                    QuestionId = 845,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer110);
            }
            else
            {
                string solarCells = Request.Form["solarcellSystemRadio"];
                ans68_.AnsDes = solarCells;
                ans68_.AnserTypeId = 4;
                ans68_.CreateDate = DateTime.Now;
                ans68_.QuestionId = 845;
                ans68_.UserId = user.Id;
                ans68_.AnsMonth = ansMonth; ans68_.SRId = sR.Id;
            }


            // แผง PV Panel:
            var ans69_ = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 846).FirstOrDefault();
            if (ans69_ == null)
            {
                string pv = Request.Form["pvPanelRadio"];
                Answer answer111 = new Answer()
                {
                    AnsDes = pv,
                    QuestionId = 846,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer111);
            }
            else
            {
                string pv = Request.Form["pvPanelRadio"];
                ans69_.AnsDes = pv;
                ans69_.AnserTypeId = 4;
                ans69_.CreateDate = DateTime.Now;
                ans69_.QuestionId = 846;
                ans69_.UserId = user.Id;
                ans69_.AnsMonth = ansMonth; ans69_.SRId = sR.Id;
            }



            // อุปกรณ์ Charger :
            var ans70_ = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 847).FirstOrDefault();
            if (ans70_ == null)
            {
                string charGer = Request.Form["toolsCharger"];
                Answer answer112 = new Answer()
                {
                    AnsDes = charGer,
                    QuestionId = 847,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer112);
            }
            else
            {
                string charGer = Request.Form["toolsCharger"];
                ans70_.AnsDes = charGer;
                ans70_.AnserTypeId = 4;
                ans70_.CreateDate = DateTime.Now;
                ans70_.QuestionId = 847;
                ans70_.UserId = user.Id;
                ans70_.AnsMonth = ansMonth; ans70_.SRId = sR.Id;
            }




            // ความสะอาดแผง PV :
            var ans71_ = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 848).FirstOrDefault();
            if (ans71_ == null)
            {
                string cleanPv = Request.Form["cleanIngpvRadio"];
                Answer answer113 = new Answer()
                {
                    AnsDes = cleanPv,
                    QuestionId = 848,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer113);
            }
            else
            {
                string cleanPv = Request.Form["cleanIngpvRadio"];
                ans71_.AnsDes = cleanPv;
                ans71_.AnserTypeId = 4;
                ans71_.CreateDate = DateTime.Now;
                ans71_.QuestionId = 848;
                ans71_.UserId = user.Id;
                ans71_.AnsMonth = ansMonth; ans71_.SRId = sR.Id;
            }



            // การติดตั้งแผง PV :
            var ans72_ = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 849).FirstOrDefault();
            if (ans72_ == null)
            {
                string intPv = Request.Form["installPvRadio"];
                Answer answer114 = new Answer()
                {
                    AnsDes = intPv,
                    QuestionId = 849,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer114);
            }
            else
            {
                string intPv = Request.Form["installPvRadio"];
                ans72_.AnsDes = intPv;
                ans72_.AnserTypeId = 4;
                ans72_.CreateDate = DateTime.Now;
                ans72_.QuestionId = 849;
                ans72_.UserId = user.Id;
                ans72_.AnsMonth = ansMonth; ans72_.SRId = sR.Id;
            }




            // แรงดันไฟจาก Inverter :        
            var ans73_ = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 850).FirstOrDefault();
            if (ans73_ == null)
            {
                Answer answer115 = new Answer()
                {
                    AnsDes = this.voltageInverterTextbox.Value,
                    QuestionId = 850,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer115);
            }
            else
            {

                ans73_.AnsDes = this.voltageInverterTextbox.Value;
                ans73_.AnserTypeId = 1;
                ans73_.CreateDate = DateTime.Now;
                ans73_.QuestionId = 850;
                ans73_.UserId = user.Id;
                ans73_.AnsMonth = ansMonth; ans73_.SRId = sR.Id;
            }


            // กระแส Load :          
            var ans74_ = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 851).FirstOrDefault();
            if (ans74_ == null)
            {
                Answer answer116 = new Answer()
                {
                    AnsDes = this.voltageLoadTextbox.Value,
                    QuestionId = 851,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer116);
            }
            else
            {
                ans74_.AnsDes = this.voltageLoadTextbox.Value;
                ans74_.AnserTypeId = 1;
                ans74_.CreateDate = DateTime.Now;
                ans74_.QuestionId = 851;
                ans74_.UserId = user.Id;
                ans74_.AnsMonth = ansMonth; ans74_.SRId = sR.Id;
            }


            // Download (for ONU/VSAT) : 
            var ans79_ = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 852).FirstOrDefault();
            if (ans79_ == null)
            {
                Answer answer117 = new Answer()
                {
                    AnsDes = this.dowloadforOnuTextbox.Value,
                    QuestionId = 852,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer117);
            }
            else
            {
                ans79_.AnsDes = this.dowloadforOnuTextbox.Value;
                ans79_.AnserTypeId = 1;
                ans79_.CreateDate = DateTime.Now;
                ans79_.QuestionId = 852;
                ans79_.UserId = user.Id;
                ans79_.AnsMonth = ansMonth; ans79_.SRId = sR.Id;

            }


            // Upload (for ONU/VSAT) :        
            var ans80_ = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 853).FirstOrDefault();
            if (ans80_ == null)
            {
                Answer answer118 = new Answer()
                {
                    AnsDes = this.uploadforOnuTextbox.Value,
                    QuestionId = 853,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer118);
            }
            else
            {
                ans80_.AnsDes = this.uploadforOnuTextbox.Value;
                ans80_.AnserTypeId = 1;
                ans80_.CreateDate = DateTime.Now;
                ans80_.QuestionId = 853;
                ans80_.UserId = user.Id;
                ans80_.AnsMonth = ansMonth; ans80_.SRId = sR.Id;
            }


            // Ping Test (for ONU/VSAT):    
            var ans81_ = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 854).FirstOrDefault();
            if (ans81_ == null)
            {
                Answer answer119 = new Answer()
                {
                    AnsDes = this.pingTestTextbox.Value,
                    QuestionId = 854,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer119);
            }
            else
            {
                ans81_.AnsDes = this.pingTestTextbox.Value;
                ans81_.AnserTypeId = 1;
                ans81_.CreateDate = DateTime.Now;
                ans81_.QuestionId = 854;
                ans81_.UserId = user.Id;
                ans81_.AnsMonth = ansMonth; ans81_.SRId = sR.Id;
            }


            // Download (for WIFI):    
            var ans82_ = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 855).FirstOrDefault();
            if (ans82_ == null)
            {
                Answer answer120 = new Answer()
                {
                    AnsDes = this.dowloadForwifiTextbox.Value,
                    QuestionId = 855,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer120);
            }
            else
            {
                ans82_.AnsDes = this.dowloadForwifiTextbox.Value;
                ans82_.AnserTypeId = 1;
                ans82_.CreateDate = DateTime.Now;
                ans82_.QuestionId = 855;
                ans82_.UserId = user.Id;
                ans82_.AnsMonth = ansMonth; ans82_.SRId = sR.Id;
            }


            // Upload (for WIFI):   
            var ans83_ = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 856).FirstOrDefault();
            if (ans83_ == null)
            {
                Answer answer121 = new Answer()
                {
                    AnsDes = this.uploadForwifiTextbox.Value,
                    QuestionId = 856,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer121);
            }
            else
            {
                ans83_.AnsDes = this.uploadForwifiTextbox.Value;
                ans83_.AnserTypeId = 1;
                ans83_.CreateDate = DateTime.Now;
                ans83_.QuestionId = 856;
                ans83_.UserId = user.Id;
                ans83_.AnsMonth = ansMonth; ans83_.SRId = sR.Id;
            }

            // Ping Test (for WIFI) :        
            var ans84_ = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 857).FirstOrDefault();
            if (ans84_ == null)
            {
                Answer answer122 = new Answer()
                {
                    AnsDes = this.pingtestForwifiTextbox.Value,
                    QuestionId = 857,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer122);
            }
            else
            {
                ans84_.AnsDes = this.pingtestForwifiTextbox.Value;
                ans84_.AnserTypeId = 1;
                ans84_.CreateDate = DateTime.Now;
                ans84_.QuestionId = 857;
                ans84_.UserId = user.Id;
                ans84_.AnsMonth = ansMonth; ans84_.SRId = sR.Id;
            }


            // Download (for LAN) :   
            var ans85_ = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 858).FirstOrDefault();
            if (ans85_ == null)
            {
                Answer answer123 = new Answer()
                {
                    AnsDes = this.dowlaodForlanTextbox.Value,
                    QuestionId = 858,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer123);
            }
            else
            {
                ans85_.AnsDes = this.dowlaodForlanTextbox.Value;
                ans85_.AnserTypeId = 1;
                ans85_.CreateDate = DateTime.Now;
                ans85_.QuestionId = 858;
                ans85_.UserId = user.Id;
                ans85_.AnsMonth = ansMonth; ans85_.SRId = sR.Id;
            }


            //Upload (for LAN) :   
            var ans86_ = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 859).FirstOrDefault();
            if (ans86_ == null)
            {
                Answer answer124 = new Answer()
                {
                    AnsDes = this.uploadForlandTextbox.Value,
                    QuestionId = 859,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer124);
            }
            else
            {
                ans86_.AnsDes = this.uploadForlandTextbox.Value;
                ans86_.AnserTypeId = 1;
                ans86_.CreateDate = DateTime.Now;
                ans86_.QuestionId = 859;
                ans86_.UserId = user.Id;
                ans86_.AnsMonth = ansMonth; ans86_.SRId = sR.Id;
            }


            //Ping Test  (for LAN) :    
            var ans87_ = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 860).FirstOrDefault();
            if (ans87_ == null)
            {
                Answer answer125 = new Answer()
                {
                    AnsDes = this.pingtestForlanTextbox.Value,
                    QuestionId = 860,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer125);
            }
            else
            {
                ans87_.AnsDes = this.pingtestForlanTextbox.Value;
                ans87_.AnserTypeId = 1;
                ans87_.CreateDate = DateTime.Now;
                ans87_.QuestionId = 860;
                ans87_.UserId = user.Id;
                ans87_.AnsMonth = ansMonth; ans87_.SRId = sR.Id;
            }

            //  ปัญหาที่พบ 1 :   
            var ans96 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 861).FirstOrDefault();
            if (ans96 == null)
            {
                Answer answer126 = new Answer()
                {
                    AnsDes = this.problemTextbox1.Value,
                    QuestionId = 861,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer126);
            }
            else
            {
                ans96.AnsDes = this.problemTextbox1.Value;
                ans96.AnserTypeId = 1;
                ans96.CreateDate = DateTime.Now;
                ans96.QuestionId = 861;
                ans96.UserId = user.Id;
                ans96.AnsMonth = ansMonth; ans96.SRId = sR.Id;
            }

            //  วิธีแก้ปัญหา 1 :       
            var ans97 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 862).FirstOrDefault();
            if (ans97 == null)
            {
                Answer answer127 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox1.Value,
                    QuestionId = 862,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer127);
            }
            else
            {
                ans97.AnsDes = this.problemTextbox1.Value;
                ans97.AnserTypeId = 1;
                ans97.CreateDate = DateTime.Now;
                ans97.QuestionId = 862;
                ans97.UserId = user.Id;
                ans97.AnsMonth = ansMonth; ans97.SRId = sR.Id;
            }



            //  ปัญหาที่พบ 2 :     
            var ans98 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 863).FirstOrDefault();
            if (ans98 == null)
            {
                Answer answer128 = new Answer()
                {
                    AnsDes = this.problemTextbox2.Value,
                    QuestionId = 863,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer128);
            }
            else
            {
                ans98.AnsDes = this.problemTextbox2.Value;
                ans98.AnserTypeId = 1;
                ans98.CreateDate = DateTime.Now;
                ans98.QuestionId = 863;
                ans98.UserId = user.Id;
                ans98.AnsMonth = ansMonth; ans98.SRId = sR.Id;
            }

            //  วิธีแก้ปัญหา 2 : 
            var ans99 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 864).FirstOrDefault();
            if (ans99 == null)
            {
                Answer answer129 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox2.Value,
                    QuestionId = 864,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer129);
            }
            else
            {
                ans99.AnsDes = this.howtoSolveTextbox2.Value;
                ans99.AnserTypeId = 1;
                ans99.CreateDate = DateTime.Now;
                ans99.QuestionId = 864;
                ans99.UserId = user.Id;
                ans99.AnsMonth = ansMonth; ans99.SRId = sR.Id;
            }



            //  ปัญหาที่พบ 3 :       
            var ans100 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 865).FirstOrDefault();
            if (ans100 == null)
            {
                Answer answer130 = new Answer()
                {
                    AnsDes = this.problemTextbox3.Value,
                    QuestionId = 865,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer130);
            }
            else
            {
                ans100.AnsDes = this.problemTextbox3.Value;
                ans100.AnserTypeId = 1;
                ans100.CreateDate = DateTime.Now;
                ans100.QuestionId = 865;
                ans100.UserId = user.Id;
                ans100.AnsMonth = ansMonth; ans100.SRId = sR.Id;
            }

            //  วิธีแก้ปัญหา 3 :    
            var ans101 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 866).FirstOrDefault();
            if (ans101 == null)
            {
                Answer answer131 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox3.Value,
                    QuestionId = 866,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer131);
            }
            else
            {
                ans101.AnsDes = this.howtoSolveTextbox3.Value;
                ans101.AnserTypeId = 1;
                ans101.CreateDate = DateTime.Now;
                ans101.QuestionId = 866;
                ans101.UserId = user.Id;
                ans101.AnsMonth = ansMonth; ans101.SRId = sR.Id;
            }



            //  ปัญหาที่พบ 4 :     
            var ans102 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 867).FirstOrDefault();
            if (ans102 == null)
            {
                Answer answer132 = new Answer()
                {
                    AnsDes = this.problemTextbox4.Value,
                    QuestionId = 867,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer132);
            }
            else
            {
                ans102.AnsDes = this.problemTextbox4.Value;
                ans102.AnserTypeId = 1;
                ans102.CreateDate = DateTime.Now;
                ans102.QuestionId = 867;
                ans102.UserId = user.Id;
                ans102.AnsMonth = ansMonth; ans102.SRId = sR.Id;
            }

            //  วิธีแก้ปัญหา 4 :   
            var ans103 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 868).FirstOrDefault();
            if (ans103 == null)
            {
                Answer answer133 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox4.Value,
                    QuestionId = 868,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer133);
            }
            else
            {
                ans103.AnsDes = this.howtoSolveTextbox4.Value;
                ans103.AnserTypeId = 1;
                ans103.CreateDate = DateTime.Now;
                ans103.QuestionId = 868;
                ans103.UserId = user.Id;
                ans103.AnsMonth = ansMonth; ans103.SRId = sR.Id;
            }





            //  ปัญหาที่พบ 5 :        
            var ans104 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 869).FirstOrDefault();
            if (ans104 == null)
            {
                Answer answer134 = new Answer()
                {
                    AnsDes = this.problemTextbox5.Value,
                    QuestionId = 869,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer134);
            }
            else
            {
                ans104.AnsDes = this.problemTextbox5.Value;
                ans104.AnserTypeId = 1;
                ans104.CreateDate = DateTime.Now;
                ans104.QuestionId = 869;
                ans104.UserId = user.Id;
                ans104.AnsMonth = ansMonth; ans104.SRId = sR.Id;
            }

            //  วิธีแก้ปัญหา 5 :      
            var ans105 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 870).FirstOrDefault();
            if (ans105 == null)
            {
                Answer answer135 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox5.Value,
                    QuestionId = 870,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer135);
            }
            else
            {
                ans105.AnsDes = this.howtoSolveTextbox5.Value;
                ans105.AnserTypeId = 1;
                ans105.CreateDate = DateTime.Now;
                ans105.QuestionId = 870;
                ans105.UserId = user.Id;
                ans105.AnsMonth = ansMonth; ans105.SRId = sR.Id;
            }


            //  ปัญหาที่พบ 6 :          
            var ans106 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 871).FirstOrDefault();
            if (ans106 == null)
            {
                Answer answer136 = new Answer()
                {
                    AnsDes = this.problemTextbox6.Value,
                    QuestionId = 871,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer136);
            }
            else
            {
                ans106.AnsDes = this.problemTextbox6.Value;
                ans106.AnserTypeId = 1;
                ans106.CreateDate = DateTime.Now;
                ans106.QuestionId = 871;
                ans106.UserId = user.Id;
                ans106.AnsMonth = ansMonth; ans106.SRId = sR.Id;
            }

            //  วิธีแก้ปัญหา 6 :     
            var ans107 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 872).FirstOrDefault();
            if (ans107 == null)
            {
                Answer answer137 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox6.Value,
                    QuestionId = 872,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer137);
            }
            else
            {
                ans107.AnsDes = this.howtoSolveTextbox6.Value;
                ans107.AnserTypeId = 1;
                ans107.CreateDate = DateTime.Now;
                ans107.QuestionId = 872;
                ans107.UserId = user.Id;
                ans107.AnsMonth = ansMonth; ans107.SRId = sR.Id;
            }

            //  ปัญหาที่พบ 7 :     
            var ans108 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 873).FirstOrDefault();
            if (ans108 == null)
            {

                Answer answer138 = new Answer()
                {
                    AnsDes = this.problemTextbox7.Value,
                    QuestionId = 873,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer138);
            }
            else
            {
                ans108.AnsDes = this.problemTextbox7.Value;
                ans108.AnserTypeId = 1;
                ans108.CreateDate = DateTime.Now;
                ans108.QuestionId = 873;
                ans108.UserId = user.Id;
                ans108.AnsMonth = ansMonth; ans108.SRId = sR.Id;
            }

            //  วิธีแก้ปัญหา 7 :  
            var ans109 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 874).FirstOrDefault();
            if (ans109 == null)
            {
                Answer answer139 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox7.Value,
                    QuestionId = 874,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer139);
            }
            else
            {
                ans109.AnsDes = this.howtoSolveTextbox7.Value;
                ans109.AnserTypeId = 1;
                ans109.CreateDate = DateTime.Now;
                ans109.QuestionId = 874;
                ans109.UserId = user.Id;
                ans109.AnsMonth = ansMonth; ans109.SRId = sR.Id;
            }



            ///////////////////////////////////////////////////////////////////////////////
            //  ปัญหาที่พบ 8 :         
            var ans110 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 875).FirstOrDefault();
            if (ans110 == null)
            {
                Answer answer140 = new Answer()
                {
                    AnsDes = this.problemTextbox8.Value,
                    QuestionId = 875,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer140);
            }
            else
            {
                ans110.AnsDes = this.problemTextbox8.Value;
                ans110.AnserTypeId = 1;
                ans110.CreateDate = DateTime.Now;
                ans110.QuestionId = 875;
                ans110.UserId = user.Id;
                ans110.AnsMonth = ansMonth; ans110.SRId = sR.Id;
            }

            //  วิธีแก้ปัญหา 8 :    
            var ans111 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 876).FirstOrDefault();
            if (ans111 == null)
            {
                Answer answer141 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox8.Value,
                    QuestionId = 876,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer141);
            }
            else
            {
                ans111.AnsDes = this.howtoSolveTextbox8.Value;
                ans111.AnserTypeId = 1;
                ans111.CreateDate = DateTime.Now;
                ans111.QuestionId = 876;
                ans111.UserId = user.Id;
                ans111.AnsMonth = ansMonth; ans111.SRId = sR.Id;
            }
            //////////////////////////////////////////////////////////////////////////////////



            ///////////////////////////////////////////////////////////////////////////////
            //  ปัญหาที่พบ 9 :         \
            var ans112 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 877).FirstOrDefault();
            if (ans112 == null)
            {
                Answer answer142 = new Answer()
                {
                    AnsDes = this.problemTextbox9.Value,
                    QuestionId = 877,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer142);
            }
            else
            {
                ans112.AnsDes = this.problemTextbox9.Value;
                ans112.AnserTypeId = 1;
                ans112.CreateDate = DateTime.Now;
                ans112.QuestionId = 877;
                ans112.UserId = user.Id;
                ans112.AnsMonth = ansMonth; ans112.SRId = sR.Id;
            }

            //  วิธีแก้ปัญหา 9 :          
            var ans113 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 878).FirstOrDefault();
            if (ans113 == null)
            {
                Answer answer143 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox9.Value,
                    QuestionId = 878,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer143);
            }
            else
            {
                ans113.AnsDes = this.howtoSolveTextbox9.Value;
                ans113.AnserTypeId = 1;
                ans113.CreateDate = DateTime.Now;
                ans113.QuestionId = 878;
                ans113.UserId = user.Id;
                ans113.AnsMonth = ansMonth; ans113.SRId = sR.Id;
            }
            //////////////////////////////////////////////////////////////////////////////////



            ///////////////////////////////////////////////////////////////////////////////
            //  ปัญหาที่พบ 10 :  
            var ans114 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 879).FirstOrDefault();
            if (ans114 == null)
            {
                Answer answer144 = new Answer()
                {
                    AnsDes = this.problemTextbox10.Value,
                    QuestionId = 879,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer144);
            }
            else
            {
                ans114.AnsDes = this.problemTextbox10.Value;
                ans114.AnserTypeId = 1;
                ans114.CreateDate = DateTime.Now;
                ans114.QuestionId = 879;
                ans114.UserId = user.Id;
                ans114.AnsMonth = ansMonth; ans114.SRId = sR.Id;
            }

            //  วิธีแก้ปัญหา 10 :     
            var ans115 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 880).FirstOrDefault();
            if (ans115 == null)
            {
                Answer answer145 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox10.Value,
                    QuestionId = 880,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer145);
            }
            else
            {
                ans115.AnsDes = this.howtoSolveTextbox10.Value;
                ans115.AnserTypeId = 1;
                ans115.CreateDate = DateTime.Now;
                ans115.QuestionId = 880;
                ans115.UserId = user.Id;
                ans115.AnsMonth = ansMonth; ans115.SRId = sR.Id;
            }
            //////////////////////////////////////////////////////////////////////////////////
            ///




            ///////////////////////////////////////////////////////////////////////////////
            //  ปัญหาที่พบ 11 :   
            var ans116 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 881).FirstOrDefault();
            if (ans116 == null)
            {
                Answer answer146 = new Answer()
                {
                    AnsDes = this.problemTextbox11.Value,
                    QuestionId = 881,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer146);
            }
            else
            {
                ans116.AnsDes = this.problemTextbox11.Value;
                ans116.AnserTypeId = 1;
                ans116.CreateDate = DateTime.Now;
                ans116.QuestionId = 881;
                ans116.UserId = user.Id;
                ans116.AnsMonth = ansMonth; ans116.SRId = sR.Id;
            }

            //  วิธีแก้ปัญหา 11 : 
            var ans117 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 882).FirstOrDefault();
            if (ans117 == null)
            {
                Answer answer147 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox11.Value,
                    QuestionId = 882,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer147);
            }
            else
            {
                ans117.AnsDes = this.problemTextbox11.Value;
                ans117.AnserTypeId = 1;
                ans117.CreateDate = DateTime.Now;
                ans117.QuestionId = 882;
                ans117.UserId = user.Id;
                ans117.AnsMonth = ansMonth; ans117.SRId = sR.Id;

            }
            //////////////////////////////////////////////////////////////////////////////////
            ///






            ///////////////////////////////////////////////////////////////////////////////
            //  ปัญหาที่พบ 12 :
            var ans118 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 883).FirstOrDefault();
            if (ans118 == null)
            {
                Answer answer148 = new Answer()
                {
                    AnsDes = this.problemTextbox12.Value,
                    QuestionId = 883,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer148);
            }
            else
            {
                ans118.AnsDes = this.problemTextbox12.Value;
                ans118.AnserTypeId = 1;
                ans118.CreateDate = DateTime.Now;
                ans118.QuestionId = 883;
                ans118.UserId = user.Id;
                ans118.AnsMonth = ansMonth; ans118.SRId = sR.Id;
            }

            //  วิธีแก้ปัญหา 12 :   
            var ans119 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 884).FirstOrDefault();
            if (ans119 == null)
            {
                Answer answer149 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox12.Value,
                    QuestionId = 884,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer149);
            }
            else
            {
                ans119.AnsDes = this.howtoSolveTextbox12.Value;
                ans119.AnserTypeId = 1;
                ans119.CreateDate = DateTime.Now;
                ans119.QuestionId = 884;
                ans119.UserId = user.Id;
                ans119.AnsMonth = ansMonth; ans119.SRId = sR.Id;
            }
            //////////////////////////////////////////////////////////////////////////////////
            ///




            ///////////////////////////////////////////////////////////////////////////////
            //  ปัญหาที่พบ 13 :    
            var ans120 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 885).FirstOrDefault();
            if (ans120 == null)
            {
                Answer answer150 = new Answer()
                {
                    AnsDes = this.problemTextbox13.Value,
                    QuestionId = 885,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer150);
            }
            else
            {
                ans120.AnsDes = this.problemTextbox13.Value;
                ans120.AnserTypeId = 1;
                ans120.CreateDate = DateTime.Now;
                ans120.QuestionId = 885;
                ans120.UserId = user.Id;
                ans120.AnsMonth = ansMonth; ans120.SRId = sR.Id;
            }

            //  วิธีแก้ปัญหา 13 : 
            var ans121 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 886).FirstOrDefault();
            if (ans121 == null)
            {
                Answer answer151 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox13.Value,
                    QuestionId = 886,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer151);
            }
            else
            {
                ans121.AnsDes = this.howtoSolveTextbox13.Value;
                ans121.AnserTypeId = 1;
                ans121.CreateDate = DateTime.Now;
                ans121.QuestionId = 886;
                ans121.UserId = user.Id;
                ans121.AnsMonth = ansMonth; ans121.SRId = sR.Id;
            }
            //////////////////////////////////////////////////////////////////////////////////
            ///



            ///////////////////////////////////////////////////////////////////////////////
            //  ปัญหาที่พบ 14 :      
            var ans122 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 887).FirstOrDefault();
            if (ans122 == null)
            {
                Answer answer152 = new Answer()
                {
                    AnsDes = this.problemTextbox14.Value,
                    QuestionId = 887,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer152);
            }
            else
            {
                ans122.AnsDes = this.problemTextbox14.Value;
                ans122.AnserTypeId = 1;
                ans122.CreateDate = DateTime.Now;
                ans122.QuestionId = 887;
                ans122.UserId = user.Id;
                ans122.AnsMonth = ansMonth; ans122.SRId = sR.Id;
            }

            //  วิธีแก้ปัญหา 14 :  
            var ans123 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 888).FirstOrDefault();
            if (ans123 == null)
            {
                Answer answer153 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox14.Value,
                    QuestionId = 888,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer153);
            }
            else
            {
                ans123.AnsDes = this.howtoSolveTextbox14.Value;
                ans123.AnserTypeId = 1;
                ans123.CreateDate = DateTime.Now;
                ans123.QuestionId = 888;
                ans123.UserId = user.Id;
                ans123.AnsMonth = ansMonth; ans123.SRId = sR.Id;
            }
            //////////////////////////////////////////////////////////////////////////////////
            ///




            ///////////////////////////////////////////////////////////////////////////////
            //  ปัญหาที่พบ 15 :          
            var ans124 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 889).FirstOrDefault();
            if (ans124 == null)
            {
                Answer answer154 = new Answer()
                {
                    AnsDes = this.problemTextbox15.Value,
                    QuestionId = 889,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer154);
            }
            else
            {
                ans124.AnsDes = this.problemTextbox15.Value;
                ans124.AnserTypeId = 1;
                ans124.CreateDate = DateTime.Now;
                ans124.QuestionId = 889;
                ans124.UserId = user.Id;
                ans124.AnsMonth = ansMonth; ans124.SRId = sR.Id;
            }

            //  วิธีแก้ปัญหา 15 :       
            var ans125 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 890).FirstOrDefault();
            if (ans125 == null)
            {
                Answer answer155 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox15.Value,
                    QuestionId = 890,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer155);
            }
            else
            {
                ans125.AnsDes = this.howtoSolveTextbox15.Value;
                ans125.AnserTypeId = 1;
                ans125.CreateDate = DateTime.Now;
                ans125.QuestionId = 890;
                ans125.UserId = user.Id;
                ans125.AnsMonth = ansMonth; ans125.SRId = sR.Id;
            }
            //////////////////////////////////////////////////////////////////////////////////
            ///



            //////////////////////////////////////////////////////////////////////////////////
            // รายการอุปกรณ์ 1 :  
            var ans126 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 891).FirstOrDefault();
            if (ans126 == null)
            {
                Answer answer156 = new Answer()
                {
                    AnsDes = this.toolsListTextbox1.Value,
                    QuestionId = 891,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer156);
            }
            else
            {
                ans126.AnsDes = this.toolsListTextbox1.Value;
                ans126.AnserTypeId = 1;
                ans126.CreateDate = DateTime.Now;
                ans126.QuestionId = 891;
                ans126.UserId = user.Id;
                ans126.AnsMonth = ansMonth; ans126.SRId = sR.Id;
            }

            //  SerialNumber :           
            var ans127 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 892).FirstOrDefault();
            if (ans127 == null)
            {
                Answer answer157 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox1.Value,
                    QuestionId = 892,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer157);
            }
            else
            {
                ans127.AnsDes = this.serialNumberTextbox1.Value;
                ans127.AnserTypeId = 1;
                ans127.CreateDate = DateTime.Now;
                ans127.QuestionId = 892;
                ans127.UserId = user.Id;
                ans127.AnsMonth = ansMonth; ans127.SRId = sR.Id;
            }

            //  new SerialNumber :        

            var ans128 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 893).FirstOrDefault();
            if (ans128 == null)
            {
                Answer answer158 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox1.Value,
                    QuestionId = 893,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer158);
            }
            else
            {
                ans128.AnsDes = this.newSerialNumberTextbox1.Value;
                ans128.AnserTypeId = 1;
                ans128.CreateDate = DateTime.Now;
                ans128.QuestionId = 893;
                ans128.UserId = user.Id;
                ans128.AnsMonth = ansMonth; ans128.SRId = sR.Id;
            }

            //  หมายเหตุ :          
            var ans129 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 894).FirstOrDefault();
            if (ans129 == null)
            {
                Answer answer159 = new Answer()
                {
                    AnsDes = this.noteTextbox1.Value,
                    QuestionId = 894,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer159);
            }
            else
            {
                ans129.AnsDes = this.noteTextbox1.Value;
                ans129.AnserTypeId = 1;
                ans129.CreateDate = DateTime.Now;
                ans129.QuestionId = 894;
                ans129.UserId = user.Id;
                ans129.AnsMonth = ansMonth; ans129.SRId = sR.Id;
            }
            //////////////////////////////////////////////////////////////////////////////////






            //////////////////////////////////////////////////////////////////////////////////
            // รายการอุปกรณ์ 2 :      
            var ans130 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 895).FirstOrDefault();
            if (ans130 == null)
            {
                Answer answer160 = new Answer()
                {
                    AnsDes = this.toolsListTextbox2.Value,
                    QuestionId = 895,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer160);
            }
            else
            {
                ans130.AnsDes = this.toolsListTextbox2.Value;
                ans130.AnserTypeId = 1;
                ans130.CreateDate = DateTime.Now;
                ans130.QuestionId = 895;
                ans130.UserId = user.Id;
                ans130.AnsMonth = ansMonth; ans130.SRId = sR.Id;
            }

            //  SerialNumber 2 :           
            var ans131 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 896).FirstOrDefault();
            if (ans131 == null)
            {
                Answer answer161 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox2.Value,
                    QuestionId = 896,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer161);
            }
            else
            {
                ans131.AnsDes = this.serialNumberTextbox2.Value;
                ans131.AnserTypeId = 1;
                ans131.CreateDate = DateTime.Now;
                ans131.QuestionId = 896;
                ans131.UserId = user.Id;
                ans131.AnsMonth = ansMonth; ans131.SRId = sR.Id;
            }

            //  new SerialNumber 2 :  
            var ans132 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 897).FirstOrDefault();
            if (ans132 == null)
            {
                Answer answer162 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox2.Value,
                    QuestionId = 897,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer162);
            }
            else
            {
                ans132.AnsDes = this.serialNumberTextbox2.Value;
                ans132.AnserTypeId = 1;
                ans132.CreateDate = DateTime.Now;
                ans132.QuestionId = 897;
                ans132.UserId = user.Id;
                ans132.AnsMonth = ansMonth; ans132.SRId = sR.Id;
            }

            //  หมายเหตุ  2:           
            var ans133 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 898).FirstOrDefault();
            if (ans133 == null)
            {
                Answer answer163 = new Answer()
                {
                    AnsDes = this.noteTextbox2.Value,
                    QuestionId = 898,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer163);
            }
            else
            {
                ans133.AnsDes = this.noteTextbox2.Value;
                ans133.AnserTypeId = 1;
                ans133.CreateDate = DateTime.Now;
                ans133.QuestionId = 898;
                ans133.UserId = user.Id;
                ans133.AnsMonth = ansMonth; ans133.SRId = sR.Id;
            }
            //////////////////////////////////////////////////////////////////////////////////



            //////////////////////////////////////////////////////////////////////////////////
            // รายการอุปกรณ์ 3 :      
            var ans134 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 899).FirstOrDefault();
            if (ans134 == null)
            {
                Answer answer164 = new Answer()
                {
                    AnsDes = this.toolsListTextbox3.Value,
                    QuestionId = 899,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer164);
            }
            else
            {
                ans134.AnsDes = this.toolsListTextbox3.Value;
                ans134.AnserTypeId = 1;
                ans134.CreateDate = DateTime.Now;
                ans134.QuestionId = 899;
                ans134.UserId = user.Id;
                ans134.AnsMonth = ansMonth; ans134.SRId = sR.Id;
            }

            //  SerialNumber 3 :
            var ans135 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 900).FirstOrDefault();
            if (ans135 == null)
            {
                Answer answer165 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox3.Value,
                    QuestionId = 900,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer165);
            }
            else
            {
                ans135.AnsDes = this.serialNumberTextbox3.Value;
                ans135.AnserTypeId = 1;
                ans135.CreateDate = DateTime.Now;
                ans135.QuestionId = 900;
                ans135.UserId = user.Id;
                ans135.AnsMonth = ansMonth; ans135.SRId = sR.Id;
            }

            //  new SerialNumber 3 :         
            var ans136 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 901).FirstOrDefault();
            if (ans136 == null)
            {
                Answer answer166 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox3.Value,
                    QuestionId = 901,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer166);
            }
            else
            {
                ans136.AnsDes = this.newSerialNumberTextbox3.Value;
                ans136.AnserTypeId = 1;
                ans136.CreateDate = DateTime.Now;
                ans136.QuestionId = 901;
                ans136.UserId = user.Id;
                ans136.AnsMonth = ansMonth; ans136.SRId = sR.Id;
            }

            //  หมายเหตุ  3:           
            var ans137 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 902).FirstOrDefault();
            if (ans137 == null)
            {
                Answer answer167 = new Answer()
                {
                    AnsDes = this.noteTextbox3.Value,
                    QuestionId = 902,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer167);
            }
            else
            {
                ans137.AnsDes = this.noteTextbox3.Value;
                ans137.AnserTypeId = 1;
                ans137.CreateDate = DateTime.Now;
                ans137.QuestionId = 902;
                ans137.UserId = user.Id;
                ans137.AnsMonth = ansMonth; ans137.SRId = sR.Id;
            }
            //////////////////////////////////////////////////////////////////////////////////




            //////////////////////////////////////////////////////////////////////////////////
            // รายการอุปกรณ์ 4 :   
            var ans138 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 903).FirstOrDefault();
            if (ans138 == null)
            {
                Answer answer168 = new Answer()
                {
                    AnsDes = this.toolsListTextbox4.Value,
                    QuestionId = 903,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer168);
            }
            else
            {
                ans138.AnsDes = this.toolsListTextbox4.Value;
                ans138.AnserTypeId = 1;
                ans138.CreateDate = DateTime.Now;
                ans138.QuestionId = 903;
                ans138.UserId = user.Id;
                ans138.AnsMonth = ansMonth; ans138.SRId = sR.Id;
            }

            //  SerialNumber 4 :    

            var ans139 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 904).FirstOrDefault();
            if (ans139 == null)
            {
                Answer answer169 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox4.Value,
                    QuestionId = 904,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer169);
            }
            else
            {
                ans139.AnsDes = this.serialNumberTextbox4.Value;
                ans139.AnserTypeId = 1;
                ans139.CreateDate = DateTime.Now;
                ans139.QuestionId = 904;
                ans139.UserId = user.Id;
                ans139.AnsMonth = ansMonth; ans139.SRId = sR.Id;
            }

            //  new SerialNumber 4 :  

            var ans140 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 905).FirstOrDefault();
            if (ans140 == null)
            {
                Answer answer170 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox4.Value,
                    QuestionId = 905,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer170);
            }
            else
            {
                ans140.AnsDes = this.newSerialNumberTextbox4.Value;
                ans140.AnserTypeId = 1;
                ans140.CreateDate = DateTime.Now;
                ans140.QuestionId = 905;
                ans140.UserId = user.Id;
                ans140.AnsMonth = ansMonth; ans140.SRId = sR.Id;
            }

            //  หมายเหตุ  4:  
            var ans141 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 906).FirstOrDefault();
            if (ans141 == null)
            {
                Answer answer171 = new Answer()
                {
                    AnsDes = this.noteTextbox4.Value,
                    QuestionId = 906,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer171);
            }
            else
            {
                ans141.AnsDes = this.noteTextbox4.Value;
                ans141.AnserTypeId = 1;
                ans141.CreateDate = DateTime.Now;
                ans141.QuestionId = 906;
                ans141.UserId = user.Id;
                ans141.AnsMonth = ansMonth; ans141.SRId = sR.Id;
            }
            //////////////////////////////////////////////////////////////////////////////////




            //////////////////////////////////////////////////////////////////////////////////
            // รายการอุปกรณ์ 5 :   
            var ans142 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 907).FirstOrDefault();
            if (ans142 == null)
            {
                Answer answer172 = new Answer()
                {
                    AnsDes = this.toolsListTextbox5.Value,
                    QuestionId = 907,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer172);
            }
            else
            {
                ans142.AnsDes = this.toolsListTextbox5.Value;
                ans142.AnserTypeId = 1;
                ans142.CreateDate = DateTime.Now;
                ans142.QuestionId = 907;
                ans142.UserId = user.Id;
                ans142.AnsMonth = ansMonth; ans142.SRId = sR.Id;
            }

            //  SerialNumber 5 :      
            var ans143 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 908).FirstOrDefault();
            if (ans143 == null)
            {
                Answer answer173 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox5.Value,
                    QuestionId = 908,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer173);
            }
            else
            {
                ans143.AnsDes = this.serialNumberTextbox5.Value;
                ans143.AnserTypeId = 1;
                ans143.CreateDate = DateTime.Now;
                ans143.QuestionId = 908;
                ans143.UserId = user.Id;
                ans143.AnsMonth = ansMonth; ans143.SRId = sR.Id;
            }

            //  new SerialNumber 5 :    
            var ans144 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 909).FirstOrDefault();
            if (ans144 == null)
            {
                Answer answer174 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox5.Value,
                    QuestionId = 909,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer174);
            }
            else
            {
                ans144.AnsDes = this.newSerialNumberTextbox5.Value;
                ans144.AnserTypeId = 1;
                ans144.CreateDate = DateTime.Now;
                ans144.QuestionId = 909;
                ans144.UserId = user.Id;
                ans144.AnsMonth = ansMonth; ans144.SRId = sR.Id;

            }

            //  หมายเหตุ  5:        
            var ans145 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 910).FirstOrDefault();
            if (ans145 == null)
            {
                Answer answer175 = new Answer()
                {
                    AnsDes = this.noteTextbox5.Value,
                    QuestionId = 910,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer175);
            }
            else
            {
                ans145.AnsDes = this.noteTextbox5.Value;
                ans145.AnserTypeId = 1;
                ans145.CreateDate = DateTime.Now;
                ans145.QuestionId = 910;
                ans145.UserId = user.Id;
                ans145.AnsMonth = ansMonth; ans145.SRId = sR.Id;
            }
            //////////////////////////////////////////////////////////////////////////////////






            //////////////////////////////////////////////////////////////////////////////////
            // รายการอุปกรณ์ 6 :      
            var ans146 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 911).FirstOrDefault();
            if (ans146 == null)
            {
                Answer answer176 = new Answer()
                {
                    AnsDes = this.toolsListTextbox6.Value,
                    QuestionId = 911,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer176);
            }
            else
            {
                ans146.AnsDes = this.toolsListTextbox6.Value;
                ans146.AnserTypeId = 1;
                ans146.CreateDate = DateTime.Now;
                ans146.QuestionId = 911;
                ans146.UserId = user.Id;
                ans146.AnsMonth = ansMonth; ans146.SRId = sR.Id;
            }

            //  SerialNumber 6 :    
            var ans147 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 912).FirstOrDefault();
            if (ans147 == null)
            {
                Answer answer177 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox6.Value,
                    QuestionId = 912,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer177);
            }
            else
            {
                ans147.AnsDes = this.serialNumberTextbox6.Value;
                ans147.AnserTypeId = 1;
                ans147.CreateDate = DateTime.Now;
                ans147.QuestionId = 912;
                ans147.UserId = user.Id;
                ans147.AnsMonth = ansMonth; ans147.SRId = sR.Id;
            }

            //  new SerialNumber 6 :        
            var ans148 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 913).FirstOrDefault();
            if (ans148 == null)
            {
                Answer answer178 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox6.Value,
                    QuestionId = 913,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer178);
            }
            else
            {
                ans148.AnsDes = this.newSerialNumberTextbox6.Value;
                ans148.AnserTypeId = 1;
                ans148.CreateDate = DateTime.Now;
                ans148.QuestionId = 913;
                ans148.UserId = user.Id;
                ans148.AnsMonth = ansMonth; ans148.SRId = sR.Id;
            }

            //  หมายเหตุ  6:      
            var ans149 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 914).FirstOrDefault();
            if (ans149 == null)
            {
                Answer answer179 = new Answer()
                {
                    AnsDes = this.noteTextbox6.Value,
                    QuestionId = 914,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer179);
            }
            else
            {
                ans149.AnsDes = this.noteTextbox6.Value;
                ans149.AnserTypeId = 1;
                ans149.CreateDate = DateTime.Now;
                ans149.QuestionId = 914;
                ans149.UserId = user.Id;
                ans149.AnsMonth = ansMonth; ans149.SRId = sR.Id;
            }
            //////////////////////////////////////////////////////////////////////////////////




            //////////////////////////////////////////////////////////////////////////////////
            // รายการอุปกรณ์ 7 :   
            var ans150 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 915).FirstOrDefault();
            if (ans150 == null)
            {
                Answer answer180 = new Answer()
                {
                    AnsDes = this.toolsListTextbox7.Value,
                    QuestionId = 915,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer180);
            }
            else
            {
                ans150.AnsDes = this.toolsListTextbox7.Value;
                ans150.AnserTypeId = 1;
                ans150.CreateDate = DateTime.Now;
                ans150.QuestionId = 915;
                ans150.UserId = user.Id;
                ans150.AnsMonth = ansMonth; ans150.SRId = sR.Id;
            }

            //  SerialNumber 7 :        
            var ans151 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 916).FirstOrDefault();
            if (ans151 == null)
            {
                Answer answer181 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox7.Value,
                    QuestionId = 916,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer181);
            }
            else
            {
                ans151.AnsDes = this.serialNumberTextbox7.Value;
                ans151.AnserTypeId = 1;
                ans151.CreateDate = DateTime.Now;
                ans151.QuestionId = 916;
                ans151.UserId = user.Id;
                ans151.AnsMonth = ansMonth; ans151.SRId = sR.Id;
            }

            //  new SerialNumber 7 :     
            var ans152 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 917).FirstOrDefault();
            if (ans152 == null)
            {
                Answer answer182 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox7.Value,
                    QuestionId = 917,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer182);
            }
            else
            {
                ans152.AnsDes = this.newSerialNumberTextbox7.Value;
                ans152.AnserTypeId = 1;
                ans152.CreateDate = DateTime.Now;
                ans152.QuestionId = 917;
                ans152.UserId = user.Id;
                ans152.AnsMonth = ansMonth; ans152.SRId = sR.Id;
            }

            //  หมายเหตุ  7:       
            var ans153 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 918).FirstOrDefault();
            if (ans153 == null)
            {
                Answer answer183 = new Answer()
                {
                    AnsDes = this.noteTextbox7.Value,
                    QuestionId = 918,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer183);
            }
            else
            {
                ans153.AnsDes = this.noteTextbox7.Value;
                ans153.AnserTypeId = 1;
                ans153.CreateDate = DateTime.Now;
                ans153.QuestionId = 918;
                ans153.UserId = user.Id;
                ans153.AnsMonth = ansMonth; ans153.SRId = sR.Id;
            }
            //////////////////////////////////////////////////////////////////////////////////



            //////////////////////////////////////////////////////////////////////////////////
            // รายการอุปกรณ์ 8 :  
            var ans154 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 919).FirstOrDefault();
            if (ans154 == null)
            {
                Answer answer184 = new Answer()
                {
                    AnsDes = this.toolsListTextbox8.Value,
                    QuestionId = 919,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer184);
            }
            else
            {
                ans154.AnsDes = this.toolsListTextbox8.Value;
                ans154.AnserTypeId = 1;
                ans154.CreateDate = DateTime.Now;
                ans154.QuestionId = 919;
                ans154.UserId = user.Id;
                ans154.AnsMonth = ansMonth; ans154.SRId = sR.Id;
            }

            //  SerialNumber 8 :        
            var ans155 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 920).FirstOrDefault();
            if (ans155 == null)
            {
                Answer answer185 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox8.Value,
                    QuestionId = 920,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer185);
            }
            else
            {
                ans155.AnsDes = this.serialNumberTextbox8.Value;
                ans155.AnserTypeId = 1;
                ans155.CreateDate = DateTime.Now;
                ans155.QuestionId = 920;
                ans155.UserId = user.Id;
                ans155.AnsMonth = ansMonth; ans155.SRId = sR.Id;
            }

            //  new SerialNumber 8 :     
            var ans156 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 921).FirstOrDefault();
            if (ans156 == null)
            {
                Answer answer186 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox8.Value,
                    QuestionId = 921,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer186);
            }
            else
            {
                ans156.AnsDes = this.newSerialNumberTextbox8.Value;
                ans156.AnserTypeId = 1;
                ans156.CreateDate = DateTime.Now;
                ans156.QuestionId = 921;
                ans156.UserId = user.Id;
                ans156.AnsMonth = ansMonth; ans156.SRId = sR.Id;
            }

            //  หมายเหตุ  8:       
            var ans157 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 922).FirstOrDefault();
            if (ans157 == null)
            {
                Answer answer187 = new Answer()
                {
                    AnsDes = this.noteTextbox8.Value,
                    QuestionId = 922,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer187);
            }
            else
            {
                ans157.AnsDes = this.noteTextbox8.Value;
                ans157.AnserTypeId = 1;
                ans157.CreateDate = DateTime.Now;
                ans157.QuestionId = 922;
                ans157.UserId = user.Id;
                ans157.AnsMonth = ansMonth; ans157.SRId = sR.Id;
            }
            //////////////////////////////////////////////////////////////////////////////////



            //////////////////////////////////////////////////////////////////////////////////
            // รายการอุปกรณ์ 9 :   
            var ans158 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 923).FirstOrDefault();
            if (ans158 == null)
            {
                Answer answer188 = new Answer()
                {
                    AnsDes = this.toolsListTextbox9.Value,
                    QuestionId = 923,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer188);
            }
            else
            {
                ans158.AnsDes = this.toolsListTextbox9.Value;
                ans158.AnserTypeId = 1;
                ans158.CreateDate = DateTime.Now;
                ans158.QuestionId = 923;
                ans158.UserId = user.Id;
                ans158.AnsMonth = ansMonth; ans158.SRId = sR.Id;
            }

            //  SerialNumber 9 :  
            var ans159 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 924).FirstOrDefault();
            if (ans159 == null)
            {
                Answer answer189 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox9.Value,
                    QuestionId = 924,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer189);
            }
            else
            {
                ans159.AnsDes = this.serialNumberTextbox9.Value;
                ans159.AnserTypeId = 1;
                ans159.CreateDate = DateTime.Now;
                ans159.QuestionId = 924;
                ans159.UserId = user.Id;
                ans159.AnsMonth = ansMonth; ans159.SRId = sR.Id;
            }

            //  new SerialNumber 9 :      
            var ans160 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 925).FirstOrDefault();
            if (ans160 == null)
            {
                Answer answer190 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox9.Value,
                    QuestionId = 925,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer190);
            }
            else
            {
                ans160.AnsDes = this.newSerialNumberTextbox9.Value;
                ans160.AnserTypeId = 1;
                ans160.CreateDate = DateTime.Now;
                ans160.QuestionId = 925;
                ans160.UserId = user.Id;
                ans160.AnsMonth = ansMonth; ans160.SRId = sR.Id;
            }

            //  หมายเหตุ  9:   
            var ans161 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 926).FirstOrDefault();
            if (ans161 == null)
            {
                Answer answer191 = new Answer()
                {
                    AnsDes = this.noteTextbox9.Value,
                    QuestionId = 926,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer191);
            }
            else
            {
                ans161.AnsDes = this.noteTextbox9.Value;
                ans161.AnserTypeId = 1;
                ans161.CreateDate = DateTime.Now;
                ans161.QuestionId = 926;
                ans161.UserId = user.Id;
                ans161.AnsMonth = ansMonth; ans161.SRId = sR.Id;
            }
            //////////////////////////////////////////////////////////////////////////////////










            //////////////////////////////////////////////////////////////////////////////////
            // รายการอุปกรณ์ 10 : 
            var ans162 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 927).FirstOrDefault();
            if (ans162 == null)
            {
                Answer answer192 = new Answer()
                {
                    AnsDes = this.toolsListTextbox10.Value,
                    QuestionId = 927,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer192);
            }
            else
            {
                ans162.AnsDes = this.toolsListTextbox10.Value;
                ans162.AnserTypeId = 1;
                ans162.CreateDate = DateTime.Now;
                ans162.QuestionId = 927;
                ans162.UserId = user.Id;
                ans162.AnsMonth = ansMonth; ans162.SRId = sR.Id;
            }

            //  SerialNumber 10 : 
            var ans163 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 928).FirstOrDefault();
            if (ans163 == null)
            {
                Answer answer193 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox10.Value,
                    QuestionId = 928,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer193);
            }
            else
            {
                ans163.AnsDes = this.serialNumberTextbox10.Value;
                ans163.AnserTypeId = 1;
                ans163.CreateDate = DateTime.Now;
                ans163.QuestionId = 928;
                ans163.UserId = user.Id;
                ans163.AnsMonth = ansMonth; ans163.SRId = sR.Id;
            }

            //  new SerialNumber 10 :
            var ans164 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 929).FirstOrDefault();
            if (ans164 == null)
            {
                Answer answer194 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox10.Value,
                    QuestionId = 929,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer194);
            }
            else
            {

                ans164.AnsDes = this.newSerialNumberTextbox10.Value;
                ans164.AnserTypeId = 1;
                ans164.CreateDate = DateTime.Now;
                ans164.QuestionId = 929;
                ans164.UserId = user.Id;
                ans164.AnsMonth = ansMonth; ans164.SRId = sR.Id;
            }

            //  หมายเหตุ  10:           
            var ans165 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 930).FirstOrDefault();
            if (ans165 == null)
            {

                Answer answer195 = new Answer()
                {
                    AnsDes = this.noteTextbox10.Value,
                    QuestionId = 930,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer195);
            }
            else
            {
                ans165.AnsDes = this.noteTextbox10.Value;
                ans165.AnserTypeId = 1;
                ans165.CreateDate = DateTime.Now;
                ans165.QuestionId = 930;
                ans165.UserId = user.Id;
                ans165.AnsMonth = ansMonth; ans165.SRId = sR.Id;

            }
            //////////////////////////////////////////////////////////////////////////////////






            //////////////////////////////////////////////////////////////////////////////////
            // รายการอุปกรณ์ 11 :      
            var ans166 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 931).FirstOrDefault();
            if (ans166 == null)
            {
                Answer answer196 = new Answer()
                {
                    AnsDes = this.toolsListTextbox11.Value,
                    QuestionId = 931,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer196);
            }
            else
            {
                ans166.AnsDes = this.toolsListTextbox11.Value;
                ans166.AnserTypeId = 1;
                ans166.CreateDate = DateTime.Now;
                ans166.QuestionId = 931;
                ans166.UserId = user.Id;
                ans166.AnsMonth = ansMonth; ans166.SRId = sR.Id;
            }

            //  SerialNumber 11 :           
            var ans167 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 932).FirstOrDefault();
            if (ans167 == null)
            {
                Answer answer197 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox11.Value,
                    QuestionId = 932,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer197);
            }
            else
            {
                ans167.AnsDes = this.serialNumberTextbox11.Value;
                ans167.AnserTypeId = 1;
                ans167.CreateDate = DateTime.Now;
                ans167.QuestionId = 932;
                ans167.UserId = user.Id;
                ans167.AnsMonth = ansMonth; ans167.SRId = sR.Id;
            }

            //  new SerialNumber 11 :         
            var ans168 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 933).FirstOrDefault();
            if (ans168 == null)
            {

                Answer answer198 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox11.Value,
                    QuestionId = 933,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer198);
            }
            else
            {
                ans168.AnsDes = this.newSerialNumberTextbox11.Value;
                ans168.AnserTypeId = 1;
                ans168.CreateDate = DateTime.Now;
                ans168.QuestionId = 933;
                ans168.UserId = user.Id;
                ans168.AnsMonth = ansMonth; ans168.SRId = sR.Id;
            }

            //  หมายเหตุ  11:     
            var ans169 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 934).FirstOrDefault();
            if (ans169 == null)
            {
                Answer answer199 = new Answer()
                {
                    AnsDes = this.noteTextbox11.Value,
                    QuestionId = 934,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer199);
            }
            else
            {
                ans169.AnsDes = this.noteTextbox11.Value;
                ans169.AnserTypeId = 1;
                ans169.CreateDate = DateTime.Now;
                ans169.QuestionId = 934;
                ans169.UserId = user.Id;
                ans169.AnsMonth = ansMonth; ans169.SRId = sR.Id;
            }
            //////////////////////////////////////////////////////////////////////////////////
            ///








            //////////////////////////////////////////////////////////////////////////////////
            // รายการอุปกรณ์ 12 :      
            var ans170 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 935).FirstOrDefault();
            if (ans170 == null)
            {
                Answer answer200 = new Answer()
                {
                    AnsDes = this.toolsListTextbox12.Value,
                    QuestionId = 935,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer200);
            }
            else
            {
                ans170.AnsDes = this.toolsListTextbox12.Value;
                ans170.AnserTypeId = 1;
                ans170.CreateDate = DateTime.Now;
                ans170.QuestionId = 935;
                ans170.UserId = user.Id;
                ans170.AnsMonth = ansMonth; ans170.SRId = sR.Id;

            }

            //  SerialNumber 12 :       
            var ans171 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 936).FirstOrDefault();
            if (ans171 == null)
            {
                Answer answer201 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox12.Value,
                    QuestionId = 936,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer201);
            }
            else
            {
                ans171.AnsDes = this.serialNumberTextbox12.Value;
                ans171.AnserTypeId = 1;
                ans171.CreateDate = DateTime.Now;
                ans171.QuestionId = 936;
                ans171.UserId = user.Id;
                ans171.AnsMonth = ansMonth; ans171.SRId = sR.Id;
            }

            //  new SerialNumber 12 :           
            var ans172 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 937).FirstOrDefault();
            if (ans172 == null)
            {
                Answer answer202 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox12.Value,
                    QuestionId = 937,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer202);
            }
            else
            {
                ans172.AnsDes = this.newSerialNumberTextbox12.Value;
                ans172.AnserTypeId = 1;
                ans172.CreateDate = DateTime.Now;
                ans172.QuestionId = 937;
                ans172.UserId = user.Id;
                ans172.AnsMonth = ansMonth; ans172.SRId = sR.Id;
            }

            //  หมายเหตุ  12:          
            var ans173 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 938).FirstOrDefault();
            if (ans173 == null)
            {
                Answer answer203 = new Answer()
                {
                    AnsDes = this.noteTextbox12.Value,
                    QuestionId = 938,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer203);
            }
            else
            {
                ans173.AnsDes = this.noteTextbox12.Value;
                ans173.AnserTypeId = 1;
                ans173.CreateDate = DateTime.Now;
                ans173.QuestionId = 938;
                ans173.UserId = user.Id;
                ans173.AnsMonth = ansMonth; ans173.SRId = sR.Id;
            }
            //////////////////////////////////////////////////////////////////////////////////
            ///






            //////////////////////////////////////////////////////////////////////////////////
            // รายการอุปกรณ์ 13 :    
            var ans174 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 939).FirstOrDefault();
            if (ans174 == null)
            {
                Answer answer204 = new Answer()
                {
                    AnsDes = this.toolsListTextbox13.Value,
                    QuestionId = 939,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer204);
            }
            else
            {
                ans174.AnsDes = this.toolsListTextbox13.Value;
                ans174.AnserTypeId = 1;
                ans174.CreateDate = DateTime.Now;
                ans174.QuestionId = 939;
                ans174.UserId = user.Id;
                ans174.AnsMonth = ansMonth; ans174.SRId = sR.Id;
            }

            //  SerialNumber 13 :     
            var ans175 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 940).FirstOrDefault();
            if (ans175 == null)
            {
                Answer answer205 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox13.Value,
                    QuestionId = 940,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer205);
            }
            else
            {
                ans175.AnsDes = this.serialNumberTextbox13.Value;
                ans175.AnserTypeId = 1;
                ans175.CreateDate = DateTime.Now;
                ans175.QuestionId = 940;
                ans175.UserId = user.Id;
                ans175.AnsMonth = ansMonth; ans175.SRId = sR.Id;
            }

            //  new SerialNumber 13 :   
            var ans176 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 941).FirstOrDefault();
            if (ans176 == null)
            {
                Answer answer206 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox13.Value,
                    QuestionId = 941,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer206);
            }
            else
            {
                ans176.AnsDes = this.newSerialNumberTextbox13.Value;
                ans176.AnserTypeId = 1;
                ans176.CreateDate = DateTime.Now;
                ans176.QuestionId = 941;
                ans176.UserId = user.Id;
                ans176.AnsMonth = ansMonth; ans176.SRId = sR.Id;
            }

            //  หมายเหตุ  13   :    
            var ans177 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 942).FirstOrDefault();
            if (ans177 == null)
            {
                Answer answer207 = new Answer()
                {
                    AnsDes = this.noteTextbox13.Value,
                    QuestionId = 942,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer207);
            }
            else
            {
                ans177.AnsDes = this.noteTextbox13.Value;
                ans177.AnserTypeId = 1;
                ans177.CreateDate = DateTime.Now;
                ans177.QuestionId = 942;
                ans177.UserId = user.Id;
                ans177.AnsMonth = ansMonth; ans177.SRId = sR.Id;
            }
            //////////////////////////////////////////////////////////////////////////////////



            //////////////////////////////////////////////////////////////////////////////////
            // รายการอุปกรณ์ 14 :    
            var ans178 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 943).FirstOrDefault();
            if (ans178 == null)
            {
                Answer answer208 = new Answer()
                {
                    AnsDes = this.toolsListTextbox14.Value,
                    QuestionId = 943,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer208);
            }
            else
            {
                ans178.AnsDes = this.toolsListTextbox14.Value;
                ans178.AnserTypeId = 1;
                ans178.CreateDate = DateTime.Now;
                ans178.QuestionId = 943;
                ans178.UserId = user.Id;
                ans178.AnsMonth = ansMonth; ans178.SRId = sR.Id;

            }
            //  SerialNumber 14 :    
            var ans179 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 944).FirstOrDefault();
            if (ans179 == null)
            {
                Answer answer209 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox14.Value,
                    QuestionId = 944,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer209);
            }
            else
            {
                ans179.AnsDes = this.serialNumberTextbox14.Value;
                ans179.AnserTypeId = 1;
                ans179.CreateDate = DateTime.Now;
                ans179.QuestionId = 944;
                ans179.UserId = user.Id;
                ans179.AnsMonth = ansMonth; ans179.SRId = sR.Id;
            }

            //  new SerialNumber 14 :       
            var ans180 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 945).FirstOrDefault();
            if (ans180 == null)
            {
                Answer answer210 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox14.Value,
                    QuestionId = 945,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer210);
            }
            else
            {
                ans180.AnsDes = this.newSerialNumberTextbox14.Value;
                ans180.AnserTypeId = 1;
                ans180.CreateDate = DateTime.Now;
                ans180.QuestionId = 945;
                ans180.UserId = user.Id;
                ans180.AnsMonth = ansMonth; ans180.SRId = sR.Id;
            }

            //  หมายเหตุ  14   :    
            var ans181 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 946).FirstOrDefault();
            if (ans181 == null)
            {
                Answer answer211 = new Answer()
                {
                    AnsDes = this.noteTextbox14.Value,
                    QuestionId = 946,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer211);
            }
            else
            {
                ans181.AnsDes = this.noteTextbox14.Value;
                ans181.AnserTypeId = 1;
                ans181.CreateDate = DateTime.Now;
                ans181.QuestionId = 946;
                ans181.UserId = user.Id;
                ans181.AnsMonth = ansMonth; ans181.SRId = sR.Id;
            }
            //////////////////////////////////////////////////////////////////////////////////






            //////////////////////////////////////////////////////////////////////////////////
            // รายการอุปกรณ์ 15 :      
            var ans182 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 947).FirstOrDefault();
            if (ans182 == null)
            {
                Answer answer212 = new Answer()
                {
                    AnsDes = this.toolsListTextbox15.Value,
                    QuestionId = 947,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer212);
            }
            else
            {
                ans182.AnsDes = this.toolsListTextbox15.Value;
                ans182.AnserTypeId = 1;
                ans182.CreateDate = DateTime.Now;
                ans182.QuestionId = 947;
                ans182.UserId = user.Id;
                ans182.AnsMonth = ansMonth; ans182.SRId = sR.Id;
            }

            //  SerialNumber 15 :     
            var ans183 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 948).FirstOrDefault();
            if (ans183 == null)
            {
                Answer answer213 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox15.Value,
                    QuestionId = 948,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer213);
            }
            else
            {
                ans183.AnsDes = this.serialNumberTextbox15.Value;
                ans183.AnserTypeId = 1;
                ans183.CreateDate = DateTime.Now;
                ans183.QuestionId = 948;
                ans183.UserId = user.Id;
                ans183.AnsMonth = ansMonth; ans183.SRId = sR.Id;
            }

            //  new SerialNumber 15 :         
            var ans184 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 949).FirstOrDefault();
            if (ans184 == null)
            {
                Answer answer214 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox15.Value,
                    QuestionId = 949,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer214);
            }
            else
            {
                ans184.AnsDes = this.newSerialNumberTextbox15.Value;
                ans184.AnserTypeId = 1;
                ans184.CreateDate = DateTime.Now;
                ans184.QuestionId = 949;
                ans184.UserId = user.Id;
                ans184.AnsMonth = ansMonth; ans184.SRId = sR.Id;
            }

            //  หมายเหตุ  15   :   
            var ans185 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 950).FirstOrDefault();
            if (ans185 == null)
            {
                Answer answer215 = new Answer()
                {
                    AnsDes = this.noteTextbox15.Value,
                    QuestionId = 950,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer215);
            }
            else
            {
                ans185.AnsDes = this.noteTextbox15.Value;
                ans185.AnserTypeId = 1;
                ans185.CreateDate = DateTime.Now;
                ans185.QuestionId = 950;
                ans185.UserId = user.Id;
                ans185.AnsMonth = ansMonth; ans185.SRId = sR.Id;
            }
            //////////////////////////////////////////////////////////////////////////////////
            ///


            // team name :    
            var ans186 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 951).FirstOrDefault();
            if (ans186 == null)
            {
                Answer answer216 = new Answer()
                {
                    AnsDes = this.nameTeampmTextbox.Value,
                    QuestionId = 951,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer216);
            }
            else
            {
                ans186.AnsDes = this.nameTeampmTextbox.Value;
                ans186.AnserTypeId = 1;
                ans186.CreateDate = DateTime.Now;
                ans186.QuestionId = 951;
                ans186.UserId = user.Id;
                ans186.AnsMonth = ansMonth; ans186.SRId = sR.Id;
            }


            // วันที่ทำ PM :    
            var ans187 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 952).FirstOrDefault();
            if (ans187 == null)
            {
                Answer answer217 = new Answer()
                {
                    AnsDes = this.dayDopmTextbox.Value,
                    QuestionId = 952,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer217);
            }
            else
            {
                ans187.AnsDes = this.dayDopmTextbox.Value;
                ans187.AnserTypeId = 1;
                ans187.CreateDate = DateTime.Now;
                ans187.QuestionId = 952;
                ans187.UserId = user.Id;
                ans187.AnsMonth = ansMonth; ans187.SRId = sR.Id;
            }


            // ชื่อเจ้าหน้าที่ประจำศูนย์ :
            var ans188 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 953).FirstOrDefault();
            if (ans188 == null)
            {
                Answer answer218 = new Answer()
                {
                    AnsDes = this.nameAgentareaTextbox.Value,
                    QuestionId = 953,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer218);
            }
            else
            {
                ans188.AnsDes = this.nameAgentareaTextbox.Value;
                ans188.AnserTypeId = 1;
                ans188.CreateDate = DateTime.Now;
                ans188.QuestionId = 953;
                ans188.UserId = user.Id;
                ans188.AnsMonth = ansMonth; ans188.SRId = sR.Id;
            }


            // เบอร์โทรติดต่อ :    
            var ans189 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 954).FirstOrDefault();
            if (ans189 == null)
            {
                Answer answer219 = new Answer()
                {
                    AnsDes = this.telephoneAgentTextbox.Value,
                    QuestionId = 954,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer219);
            }
            else
            {
                ans189.AnsDes = this.telephoneAgentTextbox.Value;
                ans189.AnserTypeId = 1;
                ans189.CreateDate = DateTime.Now;
                ans189.QuestionId = 954;
                ans189.UserId = user.Id;
                ans189.AnsMonth = ansMonth; ans189.SRId = sR.Id;
            }

            // รูปภาพป้ายชื่อโรงเรียน  :
            var ans190 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 955).FirstOrDefault();
            if (ans190 == null)
            {
                string billBoardSchool = Request.Form["billBoardSchoolRadio"];
                Answer answer220 = new Answer()
                {
                    AnsDes = billBoardSchool,
                    QuestionId = 955,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer220);
            }
            else
            {
                string billBoardSchool = Request.Form["billBoardSchoolRadio"];
                ans190.AnsDes = billBoardSchool;
                ans190.AnserTypeId = 4;
                ans190.CreateDate = DateTime.Now;
                ans190.QuestionId = 955;
                ans190.UserId = user.Id;
                ans190.AnsMonth = ansMonth; ans190.SRId = sR.Id;

            }


            // รูปภาพด้านหน้าศูนย์ (ถ่ายคู่กับ จนท.ประจำศูนย์)  :
            var ans191 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 956).FirstOrDefault();
            if (ans191 == null)
            {
                string picTuragent = Request.Form["pictureWithagentRadio"];
                Answer answer221 = new Answer()
                {
                    AnsDes = picTuragent,
                    QuestionId = 956,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer221);
            }
            else
            {
                string picTuragent = Request.Form["pictureWithagentRadio"];
                ans191.AnsDes = picTuragent;
                ans191.AnserTypeId = 4;
                ans191.CreateDate = DateTime.Now;
                ans191.QuestionId = 956;
                ans191.UserId = user.Id;
                ans191.AnsMonth = ansMonth; ans191.SRId = sR.Id;
            }


            // รูปภาพด้านหลังศูนย์ :
            var ans192 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 957).FirstOrDefault();
            if (ans192 == null)
            {
                string behinddHall = Request.Form["pictureBehindHallRadio"];
                Answer answer222 = new Answer()
                {
                    AnsDes = behinddHall,
                    QuestionId = 957,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer222);
            }
            else
            {
                string behinddHall = Request.Form["pictureBehindHallRadio"];
                ans192.AnsDes = behinddHall;
                ans192.AnserTypeId = 4;
                ans192.CreateDate = DateTime.Now;
                ans192.QuestionId = 957;
                ans192.UserId = user.Id;
                ans192.AnsMonth = ansMonth; ans192.SRId = sR.Id;
            }


            // รูปภาพบริเวณห้องโถง :
            var ans193 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 958).FirstOrDefault();
            if (ans193 == null)
            {
                string picInhall = Request.Form["picInlobbyRadio"];
                Answer answer223 = new Answer()
                {
                    AnsDes = picInhall,
                    QuestionId = 958,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer223);
            }
            else
            {
                string picInhall = Request.Form["picInlobbyRadio"];
                ans193.AnsDes = picInhall;
                ans193.AnserTypeId = 4;
                ans193.CreateDate = DateTime.Now;
                ans193.QuestionId = 958;
                ans193.UserId = user.Id;
                ans193.AnsMonth = ansMonth; ans193.SRId = sR.Id;
            }

            // รูปภาพบริเวณห้องประชุม :
            var ans194 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 959).FirstOrDefault();
            if (ans194 == null)
            {
                string picMett = Request.Form["picinMeetingroomRadio"];
                Answer answer224 = new Answer()
                {
                    AnsDes = picMett,
                    QuestionId = 959,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer224);
            }
            else
            {
                string picMett = Request.Form["picinMeetingroomRadio"];
                ans194.AnsDes = picMett;
                ans194.AnserTypeId = 4;
                ans194.CreateDate = DateTime.Now;
                ans194.QuestionId = 959;
                ans194.UserId = user.Id;
                ans194.AnsMonth = ansMonth; ans194.SRId = sR.Id;

            }

            // รูปภาพบริเวณห้อง Server :
            var ans195 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 960).FirstOrDefault();
            if (ans195 == null)
            {
                string picinserVer = Request.Form["picInserverRadio"];
                Answer answer225 = new Answer()
                {
                    AnsDes = picinserVer,
                    QuestionId = 960,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer225);
            }
            else
            {
                string picinserVer = Request.Form["picInserverRadio"];
                ans195.AnsDes = picinserVer;
                ans195.AnserTypeId = 4;
                ans195.CreateDate = DateTime.Now;
                ans195.QuestionId = 960;
                ans195.UserId = user.Id;
                ans195.AnsMonth = ansMonth; ans195.SRId = sR.Id;

            }



            // รูปภาพบริเวณห้องน้ำ :
            var ans196 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 961).FirstOrDefault();
            if (ans196 == null)
            {
                string picIntoileteiei = Request.Form["picIntoiletRadio"];
                Answer answer226 = new Answer()
                {
                    AnsDes = picIntoileteiei,
                    QuestionId = 961,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer226);
            }
            else
            {
                string picIntoileteiei = Request.Form["picIntoiletRadio"];
                ans196.AnsDes = picIntoileteiei;
                ans196.AnserTypeId = 4;
                ans196.CreateDate = DateTime.Now;
                ans196.QuestionId = 961;
                ans196.UserId = user.Id;
                ans196.AnsMonth = ansMonth; ans196.SRId = sR.Id;
            }




            // รูปภาพบริเวณห้องปั๊มน้ำ  :
            var ans197 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 962).FirstOrDefault();
            if (ans197 == null)
            {
                string picinWaterpump = Request.Form["pictureInwaterpumpRadio"];
                Answer answer227 = new Answer()
                {
                    AnsDes = picinWaterpump,
                    QuestionId = 962,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer227);
            }
            else
            {
                string picinWaterpump = Request.Form["pictureInwaterpumpRadio"];
                ans197.AnsDes = picinWaterpump;
                ans197.AnserTypeId = 4;
                ans197.CreateDate = DateTime.Now;
                ans197.QuestionId = 962;
                ans197.UserId = user.Id;
                ans197.AnsMonth = ansMonth; ans197.SRId = sR.Id;
            }



            // รูป PEA Meter  :
            var ans198 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 963).FirstOrDefault();
            if (ans198 == null)
            {

                string picMeter = Request.Form["picpeaMeterRadio"];
                Answer answer228 = new Answer()
                {
                    AnsDes = picMeter,
                    QuestionId = 963,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer228);
            }
            else
            {
                string picMeter = Request.Form["picpeaMeterRadio"];
                ans198.AnsDes = picMeter;
                ans198.AnserTypeId = 4;
                ans198.CreateDate = DateTime.Now;
                ans198.QuestionId = 963;
                ans198.UserId = user.Id;
                ans198.AnsMonth = ansMonth; ans198.SRId = sR.Id;
            }

            // รูป PEA Meter  :
            var ans199 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 964).FirstOrDefault();
            if (ans199 == null)
            {
                string acPic = Request.Form["acPicRadio"];
                Answer answer229 = new Answer()
                {
                    AnsDes = acPic,
                    QuestionId = 964,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer229);
            }
            else
            {
                string acPic = Request.Form["acPicRadio"];
                ans199.AnsDes = acPic;
                ans199.AnserTypeId = 4;
                ans199.CreateDate = DateTime.Now;
                ans199.QuestionId = 964;
                ans199.UserId = user.Id;
                ans199.AnsMonth = ansMonth; ans199.SRId = sR.Id;
            }


            // รูป PEA Meter  :
            var ans200 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 965).FirstOrDefault();
            if (ans200 == null)
            {
                string recGroundBar = Request.Form["recGroundBargroundRadio"];
                Answer answer230 = new Answer()
                {
                    AnsDes = recGroundBar,
                    QuestionId = 965,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer230);
            }
            else
            {
                string recGroundBar = Request.Form["recGroundBargroundRadio"];
                ans200.AnsDes = recGroundBar;
                ans200.AnserTypeId = 4;
                ans200.CreateDate = DateTime.Now;
                ans200.QuestionId = 965;
                ans200.UserId = user.Id;
                ans200.AnsMonth = ansMonth; ans200.SRId = sR.Id;
            }


            // รูปการตรวจสอบสถานะไฟฟ้ารั่วลง Ground (Lamp Test)   :
            var ans201 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 966).FirstOrDefault();
            if (ans201 == null)
            {
                string lightleak = Request.Form["lightleakRadio"];
                Answer answer231 = new Answer()
                {
                    AnsDes = lightleak,
                    QuestionId = 966,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer231);
            }
            else
            {
                string lightleak = Request.Form["lightleakRadio"];
                ans201.AnsDes = lightleak;
                ans201.AnserTypeId = 4;
                ans201.CreateDate = DateTime.Now;
                ans201.QuestionId = 966;
                ans201.UserId = user.Id;
                ans201.AnsMonth = ansMonth; ans201.SRId = sR.Id;
            }


            // รูป MDB  :
            var ans202 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 967).FirstOrDefault();
            if (ans202 == null)
            {

                string mdbPic = Request.Form["mdbPicRadio"];
                Answer answer232 = new Answer()
                {
                    AnsDes = mdbPic,
                    QuestionId = 967,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer232);
            }
            else
            {
                string mdbPic = Request.Form["mdbPicRadio"];
                ans202.AnsDes = mdbPic;
                ans202.AnserTypeId = 4;
                ans202.CreateDate = DateTime.Now;
                ans202.QuestionId = 967;
                ans202.UserId = user.Id;
                ans202.AnsMonth = ansMonth; ans202.SRId = sR.Id;
            }

            // รูป Fire Alarm Control  :
            var ans203 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 968).FirstOrDefault();
            if (ans203 == null)
            {
                string picFilealarm = Request.Form["picFilealarmRadio"];
                Answer answer233 = new Answer()
                {
                    AnsDes = picFilealarm,
                    QuestionId = 968,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer233);
            }
            else
            {
                string picFilealarm = Request.Form["picFilealarmRadio"];
                ans203.AnsDes = picFilealarm;
                ans203.AnserTypeId = 4;
                ans203.CreateDate = DateTime.Now;
                ans203.QuestionId = 968;
                ans203.UserId = user.Id;
                ans203.AnsMonth = ansMonth; ans203.SRId = sR.Id;
            }

            // รูปภาพรวมอุปกรณ์ทั้งหมดภายในตู้ Rack  :
            var ans204 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 969).FirstOrDefault();
            if (ans204 == null)
            {
                string alltoolsInrack = Request.Form["alltoolsInrackRadio"];
                Answer answer234 = new Answer()
                {
                    AnsDes = alltoolsInrack,
                    QuestionId = 969,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer234);
            }
            else
            {
                string alltoolsInrack = Request.Form["alltoolsInrackRadio"];
                ans204.AnsDes = alltoolsInrack;
                ans204.AnserTypeId = 4;
                ans204.CreateDate = DateTime.Now;
                ans204.QuestionId = 969;
                ans204.UserId = user.Id;
                ans204.AnsMonth = ansMonth; ans204.SRId = sR.Id;
            }


            // รูปหน้าจอ UPS แสดงค่าต่างๆ และ Serial NO. :
            var ans205 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 970).FirstOrDefault();
            if (ans205 == null)
            {
                string upsAndserial = Request.Form["upsAndserialRadio"];
                Answer answer235 = new Answer()
                {
                    AnsDes = upsAndserial,
                    QuestionId = 970,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer235);
            }
            else
            {
                string upsAndserial = Request.Form["upsAndserialRadio"];
                ans205.AnsDes = upsAndserial;
                ans205.AnserTypeId = 4;
                ans205.CreateDate = DateTime.Now;
                ans205.QuestionId = 970;
                ans205.UserId = user.Id;
                ans205.AnsMonth = ansMonth; ans205.SRId = sR.Id;

            }


            // รูป ONU/Modem พร้อม Serial NO. และ MAC. :
            var ans206 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 971).FirstOrDefault();
            if (ans206 == null)
            {
                string picOnu = Request.Form["picOnuRadio"];
                Answer answer236 = new Answer()
                {
                    AnsDes = picOnu,
                    QuestionId = 971,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer236);
            }
            else
            {
                string picOnu = Request.Form["picOnuRadio"];
                ans206.AnsDes = picOnu;
                ans206.AnserTypeId = 4;
                ans206.CreateDate = DateTime.Now;
                ans206.QuestionId = 971;
                ans206.UserId = user.Id;
                ans206.AnsMonth = ansMonth; ans206.SRId = sR.Id;

            }

            // รูป Power Supply พร้อม Serial NO :
            var ans207 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 972).FirstOrDefault();
            if (ans207 == null)
            {

                string picPsu = Request.Form["picPsuRadio"];
                Answer answer237 = new Answer()
                {
                    AnsDes = picPsu,
                    QuestionId = 972,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer237);
            }
            else
            {
                string picPsu = Request.Form["picPsuRadio"];
                ans207.AnsDes = picPsu;
                ans207.AnserTypeId = 4;
                ans207.CreateDate = DateTime.Now;
                ans207.QuestionId = 972;
                ans207.UserId = user.Id;
                ans207.AnsMonth = ansMonth; ans207.SRId = sR.Id;

            }


            // รูป Power Supply พร้อม Serial NO :
            var ans208 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 973).FirstOrDefault();
            if (ans208 == null)
            {

                string picSwitch = Request.Form["picSwitchRadio"];
                Answer answer238 = new Answer()
                {
                    AnsDes = picSwitch,
                    QuestionId = 973,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer238);
            }
            else
            {
                string picSwitch = Request.Form["picSwitchRadio"];
                ans208.AnsDes = picSwitch;
                ans208.AnserTypeId = 4;
                ans208.CreateDate = DateTime.Now;
                ans208.QuestionId = 973;
                ans208.UserId = user.Id;
                ans208.AnsMonth = ansMonth; ans208.SRId = sR.Id;

            }



            // รูป Switch 48 Port พร้อม Serial NO. และ MAC:
            var ans209 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 974).FirstOrDefault();
            if (ans209 == null)
            {
                string picSwitch48 = Request.Form["picSwitch48Radio"];
                Answer answer239 = new Answer()
                {
                    AnsDes = picSwitch48,
                    QuestionId = 974,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer239);
            }
            else
            {

                string picSwitch48 = Request.Form["picSwitch48Radio"];
                ans209.AnsDes = picSwitch48;
                ans209.AnserTypeId = 4;
                ans209.CreateDate = DateTime.Now;
                ans209.QuestionId = 974;
                ans209.UserId = user.Id;
                ans209.AnsMonth = ansMonth; ans209.SRId = sR.Id;
            }


            // รูป Outdoor AP ทั้ง 2 จุด พร้อม Serial NO. และ MAC :
            var ans210 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 975).FirstOrDefault();
            if (ans210 == null)
            {
                string picOutdoor = Request.Form["picOutdoorRadio"];
                Answer answer240 = new Answer()
                {
                    AnsDes = picOutdoor,
                    QuestionId = 975,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer240);
            }
            else
            {
                string picOutdoor = Request.Form["picOutdoorRadio"];
                ans210.AnsDes = picOutdoor;
                ans210.AnserTypeId = 4;
                ans210.CreateDate = DateTime.Now;
                ans210.QuestionId = 975;
                ans210.UserId = user.Id;
                ans210.AnsMonth = ansMonth; ans210.SRId = sR.Id;
            }


            // รูป Indoor AP ทั้ง 2 จุด พร้อม Serial NO. และ MAC:
            var ans211 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 976).FirstOrDefault();
            if (ans211 == null)
            {
                string picIndoortwoway = Request.Form["picIndoortwowayRadio"];
                Answer answer241 = new Answer()
                {
                    AnsDes = picIndoortwoway,
                    QuestionId = 976,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer241);
            }
            else
            {
                string picIndoortwoway = Request.Form["picIndoortwowayRadio"];
                ans211.AnsDes = picIndoortwoway;
                ans211.AnserTypeId = 4;
                ans211.CreateDate = DateTime.Now;
                ans211.QuestionId = 976;
                ans211.UserId = user.Id;
                ans211.AnsMonth = ansMonth; ans211.SRId = sR.Id;

            }



            // รูปการ Test Speed จาก App Nperf โดยใช้ WIFI :
            var ans212 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 977).FirstOrDefault();
            if (ans212 == null)
            {
                string picspeedTest = Request.Form["picspeedTestRadio"];
                Answer answer242 = new Answer()
                {
                    AnsDes = picspeedTest,
                    QuestionId = 977,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer242);
            }
            else
            {
                string picspeedTest = Request.Form["picspeedTestRadio"];
                ans212.AnsDes = picspeedTest;
                ans212.AnserTypeId = 4;
                ans212.CreateDate = DateTime.Now;
                ans212.QuestionId = 977;
                ans212.UserId = user.Id;
                ans212.AnsMonth = ansMonth; ans212.SRId = sR.Id;

            }



            // รูปการ Test Speed จาก App Nperf โดยใช้ LAN :
            var ans213 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 978).FirstOrDefault();
            if (ans213 == null)
            {
                string picspeedTestwithLan = Request.Form["picspeedTestwithLanRadio"];
                Answer answer243 = new Answer()
                {
                    AnsDes = picspeedTestwithLan,
                    QuestionId = 978,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer243);
            }
            else
            {
                string picspeedTestwithLan = Request.Form["picspeedTestwithLanRadio"];
                ans213.AnsDes = picspeedTestwithLan;
                ans213.AnserTypeId = 4;
                ans213.CreateDate = DateTime.Now;
                ans213.QuestionId = 978;
                ans213.UserId = user.Id;
                ans213.AnsMonth = ansMonth; ans213.SRId = sR.Id;

            }


            // รูป ก่อน-หลัง การทำความสะอาดรางระบายน้ำ :
            var ans214 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 979).FirstOrDefault();
            if (ans214 == null)
            {
                string picbeforeAftercanel = Request.Form["picbeforeAftercanelRadio"];
                Answer answer244 = new Answer()
                {
                    AnsDes = picbeforeAftercanel,
                    QuestionId = 979,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer244);
            }
            else
            {
                string picbeforeAftercanel = Request.Form["picbeforeAftercanelRadio"];
                ans214.AnsDes = picbeforeAftercanel;
                ans214.AnserTypeId = 4;
                ans214.CreateDate = DateTime.Now;
                ans214.QuestionId = 979;
                ans214.UserId = user.Id;
                ans214.AnsMonth = ansMonth; ans214.SRId = sR.Id;

            }


            // รูปหน้าจอ Monitor กล้องวงจรปิดผ่านจอทีวีในห้องประชุม :
            var ans215 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 980).FirstOrDefault();
            if (ans215 == null)
            {
                string picMonitor = Request.Form["picMonitorRadio"];
                Answer answer245 = new Answer()
                {
                    AnsDes = picMonitor,
                    QuestionId = 980,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer245);
            }
            else
            {
                string picMonitor = Request.Form["picMonitorRadio"];
                ans215.AnsDes = picMonitor;
                ans215.AnserTypeId = 4;
                ans215.CreateDate = DateTime.Now;
                ans215.QuestionId = 980;
                ans215.UserId = user.Id;
                ans215.AnsMonth = ansMonth; ans215.SRId = sR.Id;
            }



            // รูปภาพก่อน-หลัง การทำความสะอาดแอร์ห้องโถง  :
            var ans216 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 981).FirstOrDefault();
            if (ans216 == null)
            {
                string beforeArterairClean = Request.Form["beforeArterairCleanRadio"];
                Answer answer246 = new Answer()
                {
                    AnsDes = beforeArterairClean,
                    QuestionId = 981,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer246);
            }
            else
            {
                string beforeArterairClean = Request.Form["beforeArterairCleanRadio"];
                ans216.AnsDes = beforeArterairClean;
                ans216.AnserTypeId = 4;
                ans216.CreateDate = DateTime.Now;
                ans216.QuestionId = 981;
                ans216.UserId = user.Id;
                ans216.AnsMonth = ansMonth; ans216.SRId = sR.Id;

            }



            // รูปภาพก่อน-หลัง การทำความสะอาดแอร์ห้องประชุม :
            var ans217 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 982).FirstOrDefault();
            if (ans217 == null)
            {
                string picairInmeeting = Request.Form["picairInmeetingRadio"];
                Answer answer247 = new Answer()
                {
                    AnsDes = picairInmeeting,
                    QuestionId = 982,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer247);
            }
            else
            {
                string picairInmeeting = Request.Form["picairInmeetingRadio"];
                ans217.AnsDes = picairInmeeting;
                ans217.AnserTypeId = 4;
                ans217.CreateDate = DateTime.Now;
                ans217.QuestionId = 982;
                ans217.UserId = user.Id;
                ans217.AnsMonth = ansMonth; ans217.SRId = sR.Id;

            }



            // รูปภาพก่อน-หลัง การทำความสะอาดแอร์ห้อง Server :
            var ans218 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 983).FirstOrDefault();
            if (ans218 == null)
            {
                string picAirserver = Request.Form["picAirserverRadio"];
                Answer answer248 = new Answer()
                {
                    AnsDes = picAirserver,
                    QuestionId = 983,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer248);
            }
            else
            {
                string picAirserver = Request.Form["picAirserverRadio"];
                ans218.AnsDes = picAirserver;
                ans218.AnserTypeId = 4;
                ans218.CreateDate = DateTime.Now;
                ans218.QuestionId = 983;
                ans218.UserId = user.Id;
                ans218.AnsMonth = ansMonth; ans218.SRId = sR.Id;

            }

            // รูปจุดติดตั้งจานดาวเทียม:
            var ans219 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 984).FirstOrDefault();
            if (ans219 == null)
            {
                string inStallBase = Request.Form["inStallBaseRadio"];
                Answer answer249 = new Answer()
                {
                    AnsDes = inStallBase,
                    QuestionId = 984,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer249);
            }
            else
            {

                string inStallBase = Request.Form["inStallBaseRadio"];
                ans219.AnsDes = inStallBase;
                ans219.AnserTypeId = 4;
                ans219.CreateDate = DateTime.Now;
                ans219.QuestionId = 984;
                ans219.UserId = user.Id;
                ans219.AnsMonth = ansMonth; ans219.SRId = sR.Id;
            }



            // รูปความสะอาดบริเวณจานดาวเทียมr :
            var ans220 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 985).FirstOrDefault();
            if (ans220 == null)
            {
                string picCleansatellite = Request.Form["picCleansatelliteRadio"];
                Answer answer250 = new Answer()
                {
                    AnsDes = picCleansatellite,
                    QuestionId = 985,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer250);
            }
            else
            {
                string picCleansatellite = Request.Form["picCleansatelliteRadio"];
                ans220.AnsDes = picCleansatellite;
                ans220.AnserTypeId = 4;
                ans220.CreateDate = DateTime.Now;
                ans220.QuestionId = 985;
                ans220.UserId = user.Id;
                ans220.AnsMonth = ansMonth; ans220.SRId = sR.Id;

            }




            // รูป LNB พร้อม Part NO. :
            var ans221 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 986).FirstOrDefault();
            if (ans221 == null)
            {
                string picLnb = Request.Form["picLnbRadio"];
                Answer answer251 = new Answer()
                {
                    AnsDes = picLnb,
                    QuestionId = 986,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer251);
            }
            else
            {

                string picLnb = Request.Form["picLnbRadio"];
                ans221.AnsDes = picLnb;
                ans221.AnserTypeId = 4;
                ans221.CreateDate = DateTime.Now;
                ans221.QuestionId = 986;
                ans221.UserId = user.Id;
                ans221.AnsMonth = ansMonth; ans221.SRId = sR.Id;
            }



            // รูป BUC พร้อม Part NO :
            var ans222 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 987).FirstOrDefault();
            if (ans222 == null)
            {
                string picBUC = Request.Form["picBUCRadio"];
                Answer answer252 = new Answer()
                {
                    AnsDes = picBUC,
                    QuestionId = 987,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer252);
            }
            else
            {
                string picBUC = Request.Form["picBUCRadio"];
                ans222.AnsDes = picBUC;
                ans222.AnserTypeId = 4;
                ans222.CreateDate = DateTime.Now;
                ans222.QuestionId = 987;
                ans222.UserId = user.Id;
                ans222.AnsMonth = ansMonth; ans222.SRId = sR.Id;


            }




            // รูปการเก็บสายและพันหัวที่ LNB/BUC :
            var ans223 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 988).FirstOrDefault();
            if (ans223 == null)
            {
                string picWiringLnb = Request.Form["picWiringLnbRadio"];
                Answer answer253 = new Answer()
                {
                    AnsDes = picWiringLnb,
                    QuestionId = 988,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer253);
            }
            else
            {
                string picWiringLnb = Request.Form["picWiringLnbRadio"];
                ans223.AnsDes = picWiringLnb;
                ans223.AnserTypeId = 4;
                ans223.CreateDate = DateTime.Now;
                ans223.QuestionId = 988;
                ans223.UserId = user.Id;
                ans223.AnsMonth = ansMonth; ans223.SRId = sR.Id;

            }



            // รูปแนว Line Of Sight (ดูการถูกบังของหน้าจานดาวเทียม) :
            var ans224 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 989).FirstOrDefault();
            if (ans224 == null)
            {
                string picLineofSight = Request.Form["picLineofSightRadio"];
                Answer answer254 = new Answer()
                {
                    AnsDes = picLineofSight,
                    QuestionId = 989,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer254);
            }
            else
            {
                string picLineofSight = Request.Form["picLineofSightRadio"];
                ans224.AnsDes = picLineofSight;
                ans224.AnserTypeId = 4;
                ans224.CreateDate = DateTime.Now;
                ans224.QuestionId = 989;
                ans224.UserId = user.Id;
                ans224.AnsMonth = ansMonth; ans224.SRId = sR.Id;

            }


            // รูปจุดติดตั้ง Solar Cell :
            var ans225 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 990).FirstOrDefault();
            if (ans225 == null)
            {
                string picBaseSolarcell = Request.Form["picBaseSolarcellRadio"];
                Answer answer255 = new Answer()
                {
                    AnsDes = picBaseSolarcell,
                    QuestionId = 990,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer255);
            }
            else
            {
                string picBaseSolarcell = Request.Form["picBaseSolarcellRadio"];
                ans225.AnsDes = picBaseSolarcell;
                ans225.AnserTypeId = 4;
                ans225.CreateDate = DateTime.Now;
                ans225.QuestionId = 990;
                ans225.UserId = user.Id;
                ans225.AnsMonth = ansMonth; ans225.SRId = sR.Id;
            }



            // รูปอุปกรณ์ Solar Cell ภายในห้อง :
            var ans226 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 991).FirstOrDefault();
            if (ans226 == null)
            {
                string solarcellToolsinroom = Request.Form["solarcellToolsinroomRadio"];
                Answer answer256 = new Answer()
                {
                    AnsDes = solarcellToolsinroom,
                    QuestionId = 991,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer256);
            }
            else
            {
                string solarcellToolsinroom = Request.Form["solarcellToolsinroomRadio"];
                ans226.AnsDes = solarcellToolsinroom;
                ans226.AnserTypeId = 4;
                ans226.CreateDate = DateTime.Now;
                ans226.QuestionId = 991;
                ans226.UserId = user.Id;
                ans226.AnsMonth = ansMonth; ans226.SRId = sR.Id;

            }


            // รูปหน้าจอ Charger แสดงค่าต่างๆ :
            var ans227 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 992).FirstOrDefault();
            if (ans227 == null)
            {

                string screenCharger = Request.Form["screenChargerRadio"];
                Answer answer257 = new Answer()
                {
                    AnsDes = screenCharger,
                    QuestionId = 992,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer257);
            }
            else
            {
                string screenCharger = Request.Form["screenChargerRadio"];
                ans227.AnsDes = screenCharger;
                ans227.AnserTypeId = 4;
                ans227.CreateDate = DateTime.Now;
                ans227.QuestionId = 992;
                ans227.UserId = user.Id;
                ans227.AnsMonth = ansMonth; ans227.SRId = sR.Id;

            }



            // รูปหน้าจอ Inverter แสดงค่าต่างๆ :
            var ans228 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 993).FirstOrDefault();
            if (ans228 == null)
            {
                string screenInverter = Request.Form["screenInverterRadio"];
                Answer answer258 = new Answer()
                {
                    AnsDes = screenInverter,
                    QuestionId = 993,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer258);
            }
            else
            {
                string screenInverter = Request.Form["screenInverterRadio"];
                ans228.AnsDes = screenInverter;
                ans228.AnserTypeId = 4;
                ans228.CreateDate = DateTime.Now;
                ans228.QuestionId = 993;
                ans228.UserId = user.Id;
                ans228.AnsMonth = ansMonth; ans228.SRId = sR.Id;

            }


            // รูป Circuit Breaker ภายในตู้ :
            var ans229 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 994).FirstOrDefault();
            if (ans229 == null)
            {
                string piccircuitBreaker = Request.Form["piccircuitBreakerRadio"];
                Answer answer259 = new Answer()
                {
                    AnsDes = piccircuitBreaker,
                    QuestionId = 994,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer259);
            }
            else
            {
                string piccircuitBreaker = Request.Form["piccircuitBreakerRadio"];
                ans229.AnsDes = piccircuitBreaker;
                ans229.AnserTypeId = 4;
                ans229.CreateDate = DateTime.Now;
                ans229.QuestionId = 994;
                ans229.UserId = user.Id;
                ans229.AnsMonth = ansMonth; ans229.SRId = sR.Id;

            }



            // รูป Terminal ต่อสายภายในตู้ :
            var ans230 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 995).FirstOrDefault();
            if (ans230 == null)
            {
                string picTerminal = Request.Form["picTerminalRadio"];
                Answer answer260 = new Answer()
                {
                    AnsDes = picTerminal,
                    QuestionId = 995,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer260);
            }
            else
            {
                string picTerminal = Request.Form["picTerminalRadio"];
                ans230.AnsDes = picTerminal;
                ans230.AnserTypeId = 4;
                ans230.CreateDate = DateTime.Now;
                ans230.QuestionId = 995;
                ans230.UserId = user.Id;
                ans230.AnsMonth = ansMonth; ans230.SRId = sR.Id;

            }


            // รูปความสะอาดแผง PV :
            var ans231 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 996).FirstOrDefault();
            if (ans231 == null)
            {
                string picCleaningPv = Request.Form["picCleaningPvRadio"];
                Answer answer261 = new Answer()
                {
                    AnsDes = picCleaningPv,
                    QuestionId = 996,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer261);
            }
            else
            {
                string picCleaningPv = Request.Form["picCleaningPvRadio"];
                ans231.AnsDes = picCleaningPv;
                ans231.AnserTypeId = 4;
                ans231.CreateDate = DateTime.Now;
                ans231.QuestionId = 996;
                ans231.UserId = user.Id;
                ans231.AnsMonth = ansMonth; ans231.SRId = sR.Id;

            }


            // รูปภาพรวมดูสิ่งบดบังแสงอาทิตย์  :
            var ans232 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 997).FirstOrDefault();
            if (ans232 == null)
            {
                string picSunrise = Request.Form["picSunriseRadio"];
                Answer answer262 = new Answer()
                {
                    AnsDes = picSunrise,
                    QuestionId = 997,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer262);
            }
            else
            {
                string picSunrise = Request.Form["picSunriseRadio"];
                ans232.AnsDes = picSunrise;
                ans232.AnserTypeId = 4;
                ans232.CreateDate = DateTime.Now;
                ans232.QuestionId = 997;
                ans232.UserId = user.Id;
                ans232.AnsMonth = ansMonth; ans232.SRId = sR.Id;

            }

            // รูปคอมพิวเตอร์ตัวที่ 1 พร้อม Serial NO. :
            var ans233 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 998).FirstOrDefault();
            if (ans233 == null)
            {
                string piccomAgent1 = Request.Form["piccomAgentRadio1"];
                Answer answer263 = new Answer()
                {
                    AnsDes = piccomAgent1,
                    QuestionId = 998,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer263);
            }
            else
            {
                string piccomAgent1 = Request.Form["piccomAgentRadio1"];
                ans233.AnsDes = piccomAgent1;
                ans233.AnserTypeId = 4;
                ans233.CreateDate = DateTime.Now;
                ans233.QuestionId = 998;
                ans233.UserId = user.Id;
                ans233.AnsMonth = ansMonth; ans233.SRId = sR.Id;

            }


            // รูปคอมพิวเตอร์ตัวที่ 2 พร้อม Serial NO. :
            var ans234 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 999).FirstOrDefault();
            if (ans234 == null)
            {
                string piccomAgent2 = Request.Form["piccomAgentRadio2"];
                Answer answer264 = new Answer()
                {
                    AnsDes = piccomAgent2,
                    QuestionId = 999,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer264);
            }
            else
            {
                string piccomAgent2 = Request.Form["piccomAgentRadio2"];
                ans234.AnsDes = piccomAgent2;
                ans234.AnserTypeId = 4;
                ans234.CreateDate = DateTime.Now;
                ans234.QuestionId = 999;
                ans234.UserId = user.Id;
                ans234.AnsMonth = ansMonth; ans234.SRId = sR.Id;

            }



            // รูปคอมพิวเตอร์ตัวที่ 3 พร้อม Serial NO. :
            var ans235 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 1000).FirstOrDefault();
            if (ans235 == null)
            {
                string piccomAgent3 = Request.Form["piccomAgentRadio3"];
                Answer answer265 = new Answer()
                {
                    AnsDes = piccomAgent3,
                    QuestionId = 1000,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer265);
            }
            else
            {
                string piccomAgent3 = Request.Form["piccomAgentRadio3"];
                ans235.AnsDes = piccomAgent3;
                ans235.AnserTypeId = 4;
                ans235.CreateDate = DateTime.Now;
                ans235.QuestionId = 1000;
                ans235.UserId = user.Id;
                ans235.AnsMonth = ansMonth; ans235.SRId = sR.Id;

            }



            // รูปคอมพิวเตอร์ตัวที่ 4 พร้อม Serial NO. :
            var ans236 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 1001).FirstOrDefault();
            if (ans236 == null)
            {
                string piccomAgent4 = Request.Form["piccomAgentRadio4"];
                Answer answer266 = new Answer()
                {
                    AnsDes = piccomAgent4,
                    QuestionId = 1001,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer266);
            }
            else
            {
                string piccomAgent4 = Request.Form["piccomAgentRadio4"];
                ans236.AnsDes = piccomAgent4;
                ans236.AnserTypeId = 4;
                ans236.CreateDate = DateTime.Now;
                ans236.QuestionId = 1001;
                ans236.UserId = user.Id;
                ans236.AnsMonth = ansMonth; ans236.SRId = sR.Id;
            }


            // รูปคอมพิวเตอร์ตัวที่ 5 พร้อม Serial NO.  :
            var ans237 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 1002).FirstOrDefault();
            if (ans237 == null)
            {
                string piccomAgent5 = Request.Form["piccomAgentRadio5"];
                Answer answer267 = new Answer()
                {
                    AnsDes = piccomAgent5,
                    QuestionId = 1002,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer267);
            }
            else
            {
                string piccomAgent5 = Request.Form["piccomAgentRadio5"];
                ans237.AnsDes = piccomAgent5;
                ans237.AnserTypeId = 4;
                ans237.CreateDate = DateTime.Now;
                ans237.QuestionId = 1002;
                ans237.UserId = user.Id;
                ans237.AnsMonth = ansMonth; ans237.SRId = sR.Id;
            }


            // รูปคอมพิวเตอร์ตัวที่ 6 พร้อม Serial NO.  :
            var ans238 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 1003).FirstOrDefault();
            if (ans238 == null)
            {
                string piccomAgent6 = Request.Form["piccomAgentRadio6"];
                Answer answer268 = new Answer()
                {
                    AnsDes = piccomAgent6,
                    QuestionId = 1003,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer268);
            }
            else
            {
                string piccomAgent6 = Request.Form["piccomAgentRadio6"];
                ans238.AnsDes = piccomAgent6;
                ans238.AnserTypeId = 4;
                ans238.CreateDate = DateTime.Now;
                ans238.QuestionId = 1003;
                ans238.UserId = user.Id;
                ans238.AnsMonth = ansMonth; ans238.SRId = sR.Id;
            }


            // รูปคอมพิวเตอร์ตัวที่ 7 พร้อม Serial NO.  :
            var ans239 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 1004).FirstOrDefault();
            if (ans239 == null)
            {
                string piccomAgent7 = Request.Form["piccomAgentRadio7"];
                Answer answer269 = new Answer()
                {
                    AnsDes = piccomAgent7,
                    QuestionId = 1004,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer269);
            }
            else
            {
                string piccomAgent7 = Request.Form["piccomAgentRadio7"];
                ans239.AnsDes = piccomAgent7;
                ans239.AnserTypeId = 4;
                ans239.CreateDate = DateTime.Now;
                ans239.QuestionId = 1004;
                ans239.UserId = user.Id;
                ans239.AnsMonth = ansMonth; ans239.SRId = sR.Id;
            }


            // รูปคอมพิวเตอร์ตัวที่ 8 พร้อม Serial NO.  :
            var ans240 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 1005).FirstOrDefault();
            if (ans240 == null)
            {
                string piccomAgent8 = Request.Form["piccomAgentRadio8"];
                Answer answer270 = new Answer()
                {
                    AnsDes = piccomAgent8,
                    QuestionId = 1005,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer270);
            }
            else
            {
                string piccomAgent8 = Request.Form["piccomAgentRadio8"];
                ans240.AnsDes = piccomAgent8;
                ans240.AnserTypeId = 4;
                ans240.CreateDate = DateTime.Now;
                ans240.QuestionId = 1005;
                ans240.UserId = user.Id;
                ans240.AnsMonth = ansMonth; ans240.SRId = sR.Id;
            }

            // รูปคอมพิวเตอร์ตัวที่ 9 พร้อม Serial NO.  :
            var ans241 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 1006).FirstOrDefault();
            if (ans241 == null)
            {
                string piccomAgent9 = Request.Form["piccomAgentRadio9"];
                Answer answer271 = new Answer()
                {
                    AnsDes = piccomAgent9,
                    QuestionId = 1006,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer271);
            }
            else
            {
                string piccomAgent9 = Request.Form["piccomAgentRadio9"];
                ans241.AnsDes = piccomAgent9;
                ans241.AnserTypeId = 4;
                ans241.CreateDate = DateTime.Now;
                ans241.QuestionId = 1006;
                ans241.UserId = user.Id;
                ans241.AnsMonth = ansMonth; ans241.SRId = sR.Id;
            }

            // รูปคอมพิวเตอร์ตัวที่ 10 พร้อม Serial NO.  :
            var ans242 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 1007).FirstOrDefault();
            if (ans242 == null)
            {
                string piccomAgent10 = Request.Form["piccomAgentRadio10"];
                Answer answer272 = new Answer()
                {
                    AnsDes = piccomAgent10,
                    QuestionId = 1007,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer272);
            }
            else
            {
                string piccomAgent10 = Request.Form["piccomAgentRadio10"];
                ans242.AnsDes = piccomAgent10;
                ans242.AnserTypeId = 4;
                ans242.CreateDate = DateTime.Now;
                ans242.QuestionId = 1007;
                ans242.UserId = user.Id;
                ans242.AnsMonth = ansMonth; ans242.SRId = sR.Id;
            }

            // รูปคอมพิวเตอร์ตัวที่ 11 พร้อม Serial NO.  :
            var ans243 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 1008).FirstOrDefault();
            if (ans243 == null)
            {
                string piccomAgent11 = Request.Form["piccomAgentRadio11"];
                Answer answer273 = new Answer()
                {
                    AnsDes = piccomAgent11,
                    QuestionId = 1008,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer273);
            }
            else
            {
                string piccomAgent11 = Request.Form["piccomAgentRadio11"];
                ans243.AnsDes = piccomAgent11;
                ans243.AnserTypeId = 4;
                ans243.CreateDate = DateTime.Now;
                ans243.QuestionId = 1008;
                ans243.UserId = user.Id;
                ans243.AnsMonth = ansMonth; ans243.SRId = sR.Id;
            }

            // รูปคอมพิวเตอร์ตัวที่ 12 พร้อม Serial NO.  :
            var ans244 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 1009).FirstOrDefault();
            if (ans244 == null)
            {
                string piccomAgent12 = Request.Form["piccomAgentRadio12"];
                Answer answer274 = new Answer()
                {
                    AnsDes = piccomAgent12,
                    QuestionId = 1009,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer274);
            }
            else
            {
                string piccomAgent12 = Request.Form["piccomAgentRadio12"];
                ans244.AnsDes = piccomAgent12;
                ans244.AnserTypeId = 4;
                ans244.CreateDate = DateTime.Now;
                ans244.QuestionId = 1009;
                ans244.UserId = user.Id;
                ans244.AnsMonth = ansMonth; ans244.SRId = sR.Id;

            }

            //1.รูป PICTURE CHECKLIST :

            var ans255 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 1010).FirstOrDefault();
            if (ans255 == null)
            {

                if (this.pictureChecklistImages.HasFile)
                {
                    string extension = this.pictureChecklistImages.PostedFile.FileName.Split('.')[1];
                    string newFileName = "images/pictureChecklist_BB2_2_3_2_" + DateTime.Now.ToString("yyyyMMddHHmmss") + "." + extension;
                    this.pictureChecklistImages.PostedFile.SaveAs(Server.MapPath(newFileName));

                    Answer answer275 = new Answer()
                    {
                        AnsDes = newFileName,
                        QuestionId = 1010,
                        AnserTypeId = 3,
                        CreateDate = DateTime.Now,
                        SRId = sR.Id,
                        UserId = 1,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer275);
                }
            }
            else
            {

                if (this.pictureChecklistImages.HasFile)
                {
                    string extension = this.pictureChecklistImages.PostedFile.FileName.Split('.')[1];
                    string newFileName = "images/pictureChecklist_BB2_2_3_2_" + DateTime.Now.ToString("yyyyMMddHHmmss") + "." + extension;
                    this.pictureChecklistImages.PostedFile.SaveAs(Server.MapPath(newFileName));


                    ans255.AnsDes = newFileName;
                    ans255.QuestionId = 1010;
                    ans255.AnserTypeId = 3;
                    ans255.CreateDate = DateTime.Now;
                    ans255.UserId = user.Id;
                    ans255.AnsMonth = ansMonth;
                    ans255.SRId = sR.Id;

                }
            }

            //2.รูป VSAT PICTURE CHECKLIST :
            var ans256 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 1011).FirstOrDefault();
            if (ans256 == null)
            {

                if (this.vsatpictureChecklistImages.HasFile)
                {
                    string extension = this.vsatpictureChecklistImages.PostedFile.FileName.Split('.')[1];
                    string newFileName = "images/VsatPictureChecklist_BB2_2_3_2_" + DateTime.Now.ToString("yyyyMMddHHmmss") + "." + extension;
                    this.vsatpictureChecklistImages.PostedFile.SaveAs(Server.MapPath(newFileName));

                    Answer answer276 = new Answer()
                    {
                        AnsDes = newFileName,
                        QuestionId = 1011,
                        AnserTypeId = 3,
                        CreateDate = DateTime.Now,
                        SRId = sR.Id,
                        UserId = 1,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer276);
                }
            }
            else
            {

                if (this.vsatpictureChecklistImages.HasFile)
                {
                    string extension = this.vsatpictureChecklistImages.PostedFile.FileName.Split('.')[1];
                    string newFileName = "images/VsatPictureChecklist_BB2_2_3_2_" + DateTime.Now.ToString("yyyyMMddHHmmss") + "." + extension;
                    this.vsatpictureChecklistImages.PostedFile.SaveAs(Server.MapPath(newFileName));


                    ans256.AnsDes = newFileName;
                    ans256.QuestionId = 1011;
                    ans256.AnserTypeId = 3;
                    ans256.CreateDate = DateTime.Now;
                    ans256.UserId = user.Id;
                    ans256.AnsMonth = ansMonth;
                    ans256.SRId = sR.Id;



                }
            }



            //3.รูป SOLAR CELL PICTURE CHECKLISTT :

            var ans257 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 1012).FirstOrDefault();
            if (ans257 == null)
            {

                if (this.solarcellpictureChecklistImages.HasFile)
                {
                    string extension = this.solarcellpictureChecklistImages.PostedFile.FileName.Split('.')[1];
                    string newFileName = "images/SolarcellPictureChecklist_BB2_2_3_2_" + DateTime.Now.ToString("yyyyMMddHHmmss") + "." + extension;
                    this.solarcellpictureChecklistImages.PostedFile.SaveAs(Server.MapPath(newFileName));

                    Answer answer277 = new Answer()
                    {
                        AnsDes = newFileName,
                        QuestionId = 1012,
                        AnserTypeId = 3,
                        CreateDate = DateTime.Now,
                        SRId = sR.Id,
                        UserId = 1,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer277);
                }
            }
            else
            {

                if (this.solarcellpictureChecklistImages.HasFile)
                {
                    string extension = this.solarcellpictureChecklistImages.PostedFile.FileName.Split('.')[1];
                    string newFileName = "images/SolarcellPictureChecklist_BB2_2_3_2_" + DateTime.Now.ToString("yyyyMMddHHmmss") + "." + extension;
                    this.solarcellpictureChecklistImages.PostedFile.SaveAs(Server.MapPath(newFileName));

                    ans257.AnsDes = newFileName;
                    ans257.QuestionId = 1012;
                    ans257.AnserTypeId = 3;
                    ans257.CreateDate = DateTime.Now;
                    ans257.UserId = user.Id;
                    ans257.AnsMonth = ansMonth;
                    ans257.SRId = sR.Id;

                }
            }


            //4.COMPUTER PICTURE CHECKLIST :

            var ans258 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 4 && x.SRId == sR.Id && x.QuestionId == 1013).FirstOrDefault();
            if (ans258 == null)
            {

                if (this.compictureChecklistImages.HasFile)
                {
                    string extension = this.compictureChecklistImages.PostedFile.FileName.Split('.')[1];
                    string newFileName = "images/ComputerPictureChecklist_BB2_2_3_2_" + DateTime.Now.ToString("yyyyMMddHHmmss") + "." + extension;
                    this.compictureChecklistImages.PostedFile.SaveAs(Server.MapPath(newFileName));

                    Answer answer278 = new Answer()
                    {
                        AnsDes = newFileName,
                        QuestionId = 1013,
                        AnserTypeId = 3,
                        CreateDate = DateTime.Now,
                        SRId = sR.Id,
                        UserId = 1,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer278);

                }
            }
            else
            {
                if (this.compictureChecklistImages.HasFile)
                {
                    string extension = this.compictureChecklistImages.PostedFile.FileName.Split('.')[1];
                    string newFileName = "images/ComputerPictureChecklist_BB2_2_3_2_" + DateTime.Now.ToString("yyyyMMddHHmmss") + "." + extension;
                    this.compictureChecklistImages.PostedFile.SaveAs(Server.MapPath(newFileName));

                    ans258.AnsDes = newFileName;
                    ans258.QuestionId = 1013;
                    ans258.AnserTypeId = 3;
                    ans258.CreateDate = DateTime.Now;
                    ans258.UserId = user.Id;
                    ans258.AnsMonth = ansMonth;
                    ans258.SRId = sR.Id;


                }
            }


            int result = uSOEntities.SaveChanges();
            if (result > 0)
            {
                this.SuccessPanel.Visible = true;
            }

        }




    }
}