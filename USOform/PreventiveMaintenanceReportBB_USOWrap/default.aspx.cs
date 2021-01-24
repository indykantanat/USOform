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


// test new branch
namespace USOform.PreventiveMaintenanceReportBBUSOWrap
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
            //string typeOf = Request.Form["typeofsignalRadio"];
            //if (typeOf == null)
            //    Console.Write("typeOf is NULL");

            //this.GetData();



            if (!IsPostBack)
            {
                User user = (User)Session["strUsername"];
                if (user != null)
                {
                    string ansMonth = Request["AnsMonth"] != null ? Request["AnsMonth"] : DateTime.Now.ToString("yyyyMM", CultureInfo.GetCultureInfo("en-US"));
                    answers = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth).ToList();
                    if (answers.Count() > 0)
                    {
                        SetForm();
                    }
                }
                else
                {
                    Response.Redirect("/login/login.aspx");
                    Response.End();

                }
            }

        }

        void SetForm()
        {
            this.GroupNameTextBox.Text = answers.Where(x => x.QuestionId == 1).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1).FirstOrDefault().AnsDes : "";
            this.AreaTextbox.Value = answers.Where(x => x.QuestionId == 2).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 2).FirstOrDefault().AnsDes : "";
            this.CompanyTextbox.Value = answers.Where(x => x.QuestionId == 3).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 3).FirstOrDefault().AnsDes : "";
            this.maintenanceCountTextbox.Value = answers.Where(x => x.QuestionId == 4).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 4).FirstOrDefault().AnsDes : "";
            this.yearTextbox.Value = answers.Where(x => x.QuestionId == 5).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 5).FirstOrDefault().AnsDes : "";
            this.startDatepicker.Value = answers.Where(x => x.QuestionId == 8).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 8).FirstOrDefault().AnsDes : "";
            this.endDatepicker.Value = answers.Where(x => x.QuestionId == 9).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 9).FirstOrDefault().AnsDes : "";
            this.siteCodeTextbox.Value = answers.Where(x => x.QuestionId == 10).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 10).FirstOrDefault().AnsDes : "";
            this.cabinetIdTextbox.Value = answers.Where(x => x.QuestionId == 11).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 11).FirstOrDefault().AnsDes : "";
            this.sitecodeTextboxSection2.Value = answers.Where(x => x.QuestionId == 12).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 12).FirstOrDefault().AnsDes : "";
            this.VillageIdTextbox.Value = answers.Where(x => x.QuestionId == 13).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 13).FirstOrDefault().AnsDes : "";
            this.villageTextbox.Value = answers.Where(x => x.QuestionId == 14).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 14).FirstOrDefault().AnsDes : "";
            this.schoolnameTextbox.Value = answers.Where(x => x.QuestionId == 15).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 15).FirstOrDefault().AnsDes : "";
            this.subdistrictTextbox.Value = answers.Where(x => x.QuestionId == 16).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 16).FirstOrDefault().AnsDes : "";
            this.districtTextbox.Value = answers.Where(x => x.QuestionId == 1641).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1641).FirstOrDefault().AnsDes : "";
            this.provinceTextbox.Value = answers.Where(x => x.QuestionId == 17).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 17).FirstOrDefault().AnsDes : "";
            this.typeTextbox.Value = answers.Where(x => x.QuestionId == 18).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 18).FirstOrDefault().AnsDes : "";
            this.pmdateTextbox.Value = answers.Where(x => x.QuestionId == 19).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 19).FirstOrDefault().AnsDes : "";
            this.signatureExecutorTextbox.Value = answers.Where(x => x.QuestionId == 21).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 21).FirstOrDefault().AnsDes : "";
            this.signatureSupervisorTextbox.Value = answers.Where(x => x.QuestionId == 22).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 22).FirstOrDefault().AnsDes : "";
            this.nameExecutorTextbox.Value = answers.Where(x => x.QuestionId == 23).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 23).FirstOrDefault().AnsDes : "";
            this.nameSupervisorTextbox.Value = answers.Where(x => x.QuestionId == 24).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 24).FirstOrDefault().AnsDes : "";
            this.DateExecutorTextbox.Value = answers.Where(x => x.QuestionId == 25).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 25).FirstOrDefault().AnsDes : "";
            this.DateSupervisorTextbox.Value = answers.Where(x => x.QuestionId == 26).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 26).FirstOrDefault().AnsDes : "";
            this.LocationnameTextbox.Value = answers.Where(x => x.QuestionId == 27).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 27).FirstOrDefault().AnsDes : "";
            this.sitecodeTextboxSection4.Value = answers.Where(x => x.QuestionId == 28).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 28).FirstOrDefault().AnsDes : "";
            this.villageIDTextboxSection4.Value = answers.Where(x => x.QuestionId == 29).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 29).FirstOrDefault().AnsDes : "";
            this.latandlongTextbox.Value = answers.Where(x => x.QuestionId == 30).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 30).FirstOrDefault().AnsDes : "";
            this.ispTextbox.Value = answers.Where(x => x.QuestionId == 32).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 32).FirstOrDefault().AnsDes : "";
            this.numberuserTextbox.Value = answers.Where(x => x.QuestionId == 35).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 35).FirstOrDefault().AnsDes : "";
            this.kwhMeterTextbox.Value = answers.Where(x => x.QuestionId == 36).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 36).FirstOrDefault().AnsDes : "";
            this.acTextbox.Value = answers.Where(x => x.QuestionId == 37).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 37).FirstOrDefault().AnsDes : "";
            this.lineAcTextbox.Value = answers.Where(x => x.QuestionId == 38).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 38).FirstOrDefault().AnsDes : "";
            this.neutronacTextbox.Value = answers.Where(x => x.QuestionId == 39).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 39).FirstOrDefault().AnsDes : "";
            this.acfromupsTextbox.Value = answers.Where(x => x.QuestionId == 43).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 43).FirstOrDefault().AnsDes : "";
            this.electricloadTextbox.Value = answers.Where(x => x.QuestionId == 44).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 44).FirstOrDefault().AnsDes : "";
            this.battFirealarm1Textbox.Value = answers.Where(x => x.QuestionId == 63).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 63).FirstOrDefault().AnsDes : "";
            this.battFirealarm3Textbox.Value = answers.Where(x => x.QuestionId == 64).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 64).FirstOrDefault().AnsDes : "";
            this.voltageInverterTextbox.Value = answers.Where(x => x.QuestionId == 99).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 99).FirstOrDefault().AnsDes : "";
            this.voltageLoadTextbox.Value = answers.Where(x => x.QuestionId == 100).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 100).FirstOrDefault().AnsDes : "";
            this.dowloadforOnuTextbox.Value = answers.Where(x => x.QuestionId == 101).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 101).FirstOrDefault().AnsDes : "";
            this.uploadforOnuTextbox.Value = answers.Where(x => x.QuestionId == 102).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 102).FirstOrDefault().AnsDes : "";
            this.pingTestTextbox.Value = answers.Where(x => x.QuestionId == 103).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 103).FirstOrDefault().AnsDes : "";
            this.dowloadForwifiTextbox.Value = answers.Where(x => x.QuestionId == 104).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 104).FirstOrDefault().AnsDes : "";
            this.uploadForwifiTextbox.Value = answers.Where(x => x.QuestionId == 105).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 105).FirstOrDefault().AnsDes : "";
            this.pingtestForwifiTextbox.Value = answers.Where(x => x.QuestionId == 106).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 106).FirstOrDefault().AnsDes : "";
            this.dowlaodForlanTextbox.Value = answers.Where(x => x.QuestionId == 107).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 107).FirstOrDefault().AnsDes : "";
            this.uploadForlandTextbox.Value = answers.Where(x => x.QuestionId == 108).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 108).FirstOrDefault().AnsDes : "";
            this.pingtestForlanTextbox.Value = answers.Where(x => x.QuestionId == 109).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 109).FirstOrDefault().AnsDes : "";

            this.problemTextbox1.Value = answers.Where(x => x.QuestionId == 110).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 110).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox1.Value = answers.Where(x => x.QuestionId == 111).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 111).FirstOrDefault().AnsDes : "";
            this.problemTextbox2.Value = answers.Where(x => x.QuestionId == 112).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 112).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox2.Value = answers.Where(x => x.QuestionId == 113).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 113).FirstOrDefault().AnsDes : "";
            this.problemTextbox3.Value = answers.Where(x => x.QuestionId == 114).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 114).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox3.Value = answers.Where(x => x.QuestionId == 115).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 115).FirstOrDefault().AnsDes : "";
            this.problemTextbox4.Value = answers.Where(x => x.QuestionId == 116).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 116).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox4.Value = answers.Where(x => x.QuestionId == 117).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 117).FirstOrDefault().AnsDes : "";
            this.problemTextbox5.Value = answers.Where(x => x.QuestionId == 118).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 118).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox5.Value = answers.Where(x => x.QuestionId == 119).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 119).FirstOrDefault().AnsDes : "";
            this.problemTextbox6.Value = answers.Where(x => x.QuestionId == 120).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 120).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox6.Value = answers.Where(x => x.QuestionId == 121).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 121).FirstOrDefault().AnsDes : "";
            this.problemTextbox7.Value = answers.Where(x => x.QuestionId == 122).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 122).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox7.Value = answers.Where(x => x.QuestionId == 123).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 123).FirstOrDefault().AnsDes : "";
            this.problemTextbox8.Value = answers.Where(x => x.QuestionId == 124).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 124).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox8.Value = answers.Where(x => x.QuestionId == 125).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 125).FirstOrDefault().AnsDes : "";
            this.problemTextbox9.Value = answers.Where(x => x.QuestionId == 126).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 126).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox9.Value = answers.Where(x => x.QuestionId == 127).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 127).FirstOrDefault().AnsDes : "";
            this.problemTextbox10.Value = answers.Where(x => x.QuestionId == 128).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 128).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox10.Value = answers.Where(x => x.QuestionId == 129).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 129).FirstOrDefault().AnsDes : "";
            this.problemTextbox11.Value = answers.Where(x => x.QuestionId == 130).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 130).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox11.Value = answers.Where(x => x.QuestionId == 131).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 131).FirstOrDefault().AnsDes : "";
            this.problemTextbox12.Value = answers.Where(x => x.QuestionId == 132).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 132).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox12.Value = answers.Where(x => x.QuestionId == 133).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 133).FirstOrDefault().AnsDes : "";
            this.problemTextbox13.Value = answers.Where(x => x.QuestionId == 134).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 134).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox13.Value = answers.Where(x => x.QuestionId == 135).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 135).FirstOrDefault().AnsDes : "";
            this.problemTextbox14.Value = answers.Where(x => x.QuestionId == 136).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 136).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox14.Value = answers.Where(x => x.QuestionId == 137).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 137).FirstOrDefault().AnsDes : "";
            this.problemTextbox15.Value = answers.Where(x => x.QuestionId == 138).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 138).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox15.Value = answers.Where(x => x.QuestionId == 139).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 139).FirstOrDefault().AnsDes : "";

            this.toolsListTextbox1.Value = answers.Where(x => x.QuestionId == 141).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 141).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox1.Value = answers.Where(x => x.QuestionId == 142).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 142).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox1.Value = answers.Where(x => x.QuestionId == 143).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 143).FirstOrDefault().AnsDes : "";
            this.noteTextbox1.Value = answers.Where(x => x.QuestionId == 144).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 144).FirstOrDefault().AnsDes : "";
            this.toolsListTextbox2.Value = answers.Where(x => x.QuestionId == 145).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 145).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox2.Value = answers.Where(x => x.QuestionId == 146).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 146).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox2.Value = answers.Where(x => x.QuestionId == 147).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 147).FirstOrDefault().AnsDes : "";
            this.noteTextbox2.Value = answers.Where(x => x.QuestionId == 148).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 148).FirstOrDefault().AnsDes : "";
            this.toolsListTextbox3.Value = answers.Where(x => x.QuestionId == 149).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 149).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox3.Value = answers.Where(x => x.QuestionId == 150).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 150).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox3.Value = answers.Where(x => x.QuestionId == 151).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 151).FirstOrDefault().AnsDes : "";
            this.noteTextbox3.Value = answers.Where(x => x.QuestionId == 152).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 152).FirstOrDefault().AnsDes : "";
            this.toolsListTextbox4.Value = answers.Where(x => x.QuestionId == 153).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 153).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox4.Value = answers.Where(x => x.QuestionId == 154).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 154).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox4.Value = answers.Where(x => x.QuestionId == 155).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 155).FirstOrDefault().AnsDes : "";
            this.noteTextbox4.Value = answers.Where(x => x.QuestionId == 156).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 156).FirstOrDefault().AnsDes : "";
            this.toolsListTextbox5.Value = answers.Where(x => x.QuestionId == 157).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 157).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox5.Value = answers.Where(x => x.QuestionId == 158).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 158).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox5.Value = answers.Where(x => x.QuestionId == 159).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 159).FirstOrDefault().AnsDes : "";
            this.noteTextbox5.Value = answers.Where(x => x.QuestionId == 160).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 160).FirstOrDefault().AnsDes : "";
            this.toolsListTextbox6.Value = answers.Where(x => x.QuestionId == 161).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 161).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox6.Value = answers.Where(x => x.QuestionId == 162).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 162).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox6.Value = answers.Where(x => x.QuestionId == 163).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 163).FirstOrDefault().AnsDes : "";
            this.noteTextbox6.Value = answers.Where(x => x.QuestionId == 164).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 164).FirstOrDefault().AnsDes : "";
            this.toolsListTextbox7.Value = answers.Where(x => x.QuestionId == 165).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 165).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox7.Value = answers.Where(x => x.QuestionId == 166).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 166).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox7.Value = answers.Where(x => x.QuestionId == 167).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 167).FirstOrDefault().AnsDes : "";
            this.noteTextbox7.Value = answers.Where(x => x.QuestionId == 168).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 168).FirstOrDefault().AnsDes : "";
            this.toolsListTextbox8.Value = answers.Where(x => x.QuestionId == 169).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 169).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox8.Value = answers.Where(x => x.QuestionId == 170).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 170).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox8.Value = answers.Where(x => x.QuestionId == 171).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 171).FirstOrDefault().AnsDes : "";
            this.noteTextbox8.Value = answers.Where(x => x.QuestionId == 172).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 172).FirstOrDefault().AnsDes : "";
            this.toolsListTextbox9.Value = answers.Where(x => x.QuestionId == 173).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 173).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox9.Value = answers.Where(x => x.QuestionId == 174).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 174).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox9.Value = answers.Where(x => x.QuestionId == 175).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 175).FirstOrDefault().AnsDes : "";
            this.noteTextbox9.Value = answers.Where(x => x.QuestionId == 176).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 176).FirstOrDefault().AnsDes : "";
            this.toolsListTextbox10.Value = answers.Where(x => x.QuestionId == 177).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 177).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox10.Value = answers.Where(x => x.QuestionId == 178).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 178).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox10.Value = answers.Where(x => x.QuestionId == 179).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 179).FirstOrDefault().AnsDes : "";
            this.noteTextbox10.Value = answers.Where(x => x.QuestionId == 180).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 180).FirstOrDefault().AnsDes : "";
            this.toolsListTextbox11.Value = answers.Where(x => x.QuestionId == 181).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 181).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox11.Value = answers.Where(x => x.QuestionId == 182).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 182).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox11.Value = answers.Where(x => x.QuestionId == 183).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 183).FirstOrDefault().AnsDes : "";
            this.noteTextbox11.Value = answers.Where(x => x.QuestionId == 184).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 184).FirstOrDefault().AnsDes : "";
            this.toolsListTextbox12.Value = answers.Where(x => x.QuestionId == 185).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 185).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox12.Value = answers.Where(x => x.QuestionId == 186).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 186).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox12.Value = answers.Where(x => x.QuestionId == 187).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 187).FirstOrDefault().AnsDes : "";
            this.noteTextbox12.Value = answers.Where(x => x.QuestionId == 188).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 188).FirstOrDefault().AnsDes : "";
            this.toolsListTextbox13.Value = answers.Where(x => x.QuestionId == 189).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 189).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox13.Value = answers.Where(x => x.QuestionId == 190).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 190).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox13.Value = answers.Where(x => x.QuestionId == 191).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 191).FirstOrDefault().AnsDes : "";
            this.noteTextbox13.Value = answers.Where(x => x.QuestionId == 192).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 192).FirstOrDefault().AnsDes : "";
            this.toolsListTextbox14.Value = answers.Where(x => x.QuestionId == 193).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 193).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox14.Value = answers.Where(x => x.QuestionId == 194).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 194).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox14.Value = answers.Where(x => x.QuestionId == 195).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 195).FirstOrDefault().AnsDes : "";
            this.noteTextbox14.Value = answers.Where(x => x.QuestionId == 196).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 196).FirstOrDefault().AnsDes : "";
            this.toolsListTextbox15.Value = answers.Where(x => x.QuestionId == 197).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 197).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox15.Value = answers.Where(x => x.QuestionId == 198).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 198).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox15.Value = answers.Where(x => x.QuestionId == 199).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 199).FirstOrDefault().AnsDes : "";
            this.noteTextbox15.Value = answers.Where(x => x.QuestionId == 200).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 200).FirstOrDefault().AnsDes : "";
            this.nameTeampmTextbox.Value = answers.Where(x => x.QuestionId == 201).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 201).FirstOrDefault().AnsDes : "";
            this.dayDopmTextbox.Value = answers.Where(x => x.QuestionId == 202).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 202).FirstOrDefault().AnsDes : "";
            this.nameAgentareaTextbox.Value = answers.Where(x => x.QuestionId == 203).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 203).FirstOrDefault().AnsDes : "";
            this.telephoneAgentTextbox.Value = answers.Where(x => x.QuestionId == 204).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 204).FirstOrDefault().AnsDes : "";


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
            var ans1 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 1).FirstOrDefault();
            if (ans1 == null)
            {

                // กลุ่ม
                Answer answer1 = new Answer()
                {
                    AnsDes = this.GroupNameTextBox.Text,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    QuestionId = 1,
                    UserId = user.Id,
                    AnsMonth = ansMonth,


                };
                uSOEntities.Answers.Add(answer1);

            }
            else
            {
                ans1.AnsDes = this.GroupNameTextBox.Text;
                ans1.AnserTypeId = 1;
                ans1.CreateDate = DateTime.Now;
                ans1.QuestionId = 1;
                ans1.UserId = user.Id;
                ans1.AnsMonth = ansMonth;

            }

            var ans2 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 2).FirstOrDefault();
            if (ans2 == null)
            {
                // ภูมิภาค
                Answer answer2 = new Answer()
                {
                    AnsDes = this.AreaTextbox.Value,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    QuestionId = 2,
                    UserId = user.Id,
                    AnsMonth = ansMonth,


                };
                uSOEntities.Answers.Add(answer2);
            }
            else
            {
                // ภูมิภาค              
                {
                    ans2.AnsDes = this.AreaTextbox.Value;
                    ans2.AnserTypeId = 1;
                    ans2.CreateDate = DateTime.Now;
                    ans2.QuestionId = 2;
                    ans2.UserId = user.Id;
                    ans2.AnsMonth = ansMonth;
                }

            }


            var ans3 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 3).FirstOrDefault();
            if (ans3 == null)
            {

                Answer answer3 = new Answer()
                {
                    AnsDes = this.CompanyTextbox.Value,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    QuestionId = 3,
                    UserId = user.Id,
                    AnsMonth = ansMonth,

                };
                uSOEntities.Answers.Add(answer3);
            }
            else
            {

                {
                    ans3.AnsDes = this.CompanyTextbox.Value;
                    ans3.AnserTypeId = 1;
                    ans3.CreateDate = DateTime.Now;
                    ans3.QuestionId = 3;
                    ans3.UserId = user.Id;
                    ans3.AnsMonth = ansMonth;
                }

            }


            var ans4 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 4).FirstOrDefault();
            if (ans4 == null)
            {

                Answer answer3 = new Answer()
                {
                    AnsDes = this.maintenanceCountTextbox.Value,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    QuestionId = 4,
                    UserId = user.Id,
                    AnsMonth = ansMonth,

                };
                uSOEntities.Answers.Add(answer3);
            }
            else
            {

                {
                    ans4.AnsDes = this.maintenanceCountTextbox.Value;
                    ans4.AnserTypeId = 1;
                    ans4.CreateDate = DateTime.Now;
                    ans4.QuestionId = 4;
                    ans4.UserId = user.Id;
                    ans4.AnsMonth = ansMonth;
                }

            }


            var ans5 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 5).FirstOrDefault();
            if (ans5 == null)
            {

                Answer answer3 = new Answer()
                {
                    QuestionId = 5,
                    AnsDes = this.yearTextbox.Value,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,

                };
                uSOEntities.Answers.Add(answer3);
            }
            else
            {

                {
                    ans5.QuestionId = 5;
                    ans5.AnsDes = this.yearTextbox.Value;
                    ans5.AnserTypeId = 1;
                    ans5.CreateDate = DateTime.Now;
                    ans5.UserId = user.Id;
                    ans5.AnsMonth = ansMonth;
                }

            }

            var ans6 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 8).FirstOrDefault();
            if (ans6 == null)
            {

                //วัน เดือน ปี ที่เริ่มต้น
                Answer answer8 = new Answer()
                {
                    AnsDes = this.startDatepicker.Value,
                    QuestionId = 8,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,


                };
                uSOEntities.Answers.Add(answer8);
            }
            else
            {

                {
                    ans6.QuestionId = 8;
                    ans6.AnsDes = this.startDatepicker.Value;
                    ans6.AnserTypeId = 1;
                    ans6.CreateDate = DateTime.Now;
                    ans6.UserId = user.Id;
                    ans6.AnsMonth = ansMonth;
                }

            }


            var ans9 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 9).FirstOrDefault();
            if (ans9 == null)
            {

                //ถึง 
                Answer answer9 = new Answer()
                {
                    AnsDes = this.endDatepicker.Value,
                    QuestionId = 9,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,


                };
                uSOEntities.Answers.Add(answer9);
            }
            else
            {

                {
                    ans9.QuestionId = 9;
                    ans9.AnsDes = this.endDatepicker.Value;
                    ans9.AnserTypeId = 1;
                    ans9.CreateDate = DateTime.Now;
                    ans9.UserId = user.Id;
                    ans9.AnsMonth = ansMonth;
                }

            }



            var ans10 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 10).FirstOrDefault();
            if (ans10 == null)
            {


                //สถานที่ SITE CODE
                Answer answer10 = new Answer()
                {
                    AnsDes = this.siteCodeTextbox.Value,
                    QuestionId = 10,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,

                };
                uSOEntities.Answers.Add(answer10);
            }
            else
            {

                {
                    ans10.QuestionId = 10;
                    ans10.AnsDes = this.siteCodeTextbox.Value;
                    ans10.AnserTypeId = 1;
                    ans10.CreateDate = DateTime.Now;
                    ans10.UserId = user.Id;
                    ans10.AnsMonth = ansMonth;
                }

            }




            var ans11 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 11).FirstOrDefault();
            if (ans11 == null)
            {

                //Cabinet ID:
                Answer answer11 = new Answer()
                {
                    AnsDes = this.cabinetIdTextbox.Value,
                    QuestionId = 11,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,

                };
                uSOEntities.Answers.Add(answer11);

            }
            else
            {

                {
                    ans11.QuestionId = 11;
                    ans11.AnsDes = this.cabinetIdTextbox.Value;
                    ans11.AnserTypeId = 1;
                    ans11.CreateDate = DateTime.Now;
                    ans11.UserId = user.Id;
                    ans11.AnsMonth = ansMonth;
                }

            }



            var ans12 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 12).FirstOrDefault();
            if (ans12 == null)
            {

                //Site Code :
                Answer answer12 = new Answer()
                {
                    AnsDes = this.sitecodeTextboxSection2.Value,
                    QuestionId = 12,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer12);

            }
            else
            {

                {
                    ans12.QuestionId = 12;
                    ans12.AnsDes = this.sitecodeTextboxSection2.Value;
                    ans12.AnserTypeId = 1;
                    ans12.CreateDate = DateTime.Now;
                    ans12.UserId = user.Id;
                    ans12.AnsMonth = ansMonth;
                }

            }


            var ans13 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 13).FirstOrDefault();
            if (ans13 == null)
            {

                //Village ID :
                Answer answer13 = new Answer()
                {
                    AnsDes = this.VillageIdTextbox.Value,
                    QuestionId = 13,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer13);

            }
            else
            {

                {
                    ans13.QuestionId = 13;
                    ans13.AnsDes = this.VillageIdTextbox.Value;
                    ans13.AnserTypeId = 1;
                    ans13.CreateDate = DateTime.Now;
                    ans13.UserId = user.Id;
                    ans13.AnsMonth = ansMonth;
                }

            }

            var ans14 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 14).FirstOrDefault();
            if (ans14 == null)
            {


                //Village  :
                Answer answer14 = new Answer()
                {
                    AnsDes = this.villageTextbox.Value,
                    QuestionId = 14,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer14);

            }
            else
            {

                {
                    ans14.QuestionId = 14;
                    ans14.AnsDes = this.villageTextbox.Value;
                    ans14.AnserTypeId = 1;
                    ans14.CreateDate = DateTime.Now;
                    ans14.UserId = user.Id;
                    ans14.AnsMonth = ansMonth;
                }

            }

            var ans15 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 15).FirstOrDefault();
            if (ans15 == null)
            {

                //School 's name  :
                Answer answer15 = new Answer()
                {
                    AnsDes = this.schoolnameTextbox.Value,
                    QuestionId = 15,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer15);

            }
            else
            {

                {
                    ans15.QuestionId = 15;
                    ans15.AnsDes = this.villageTextbox.Value;
                    ans15.AnserTypeId = 1;
                    ans15.CreateDate = DateTime.Now;
                    ans15.UserId = user.Id;
                    ans15.AnsMonth = ansMonth;
                }

            }

            var ans16 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 16).FirstOrDefault();
            if (ans16 == null)
            {

                //Sub-District :
                Answer answer16 = new Answer()
                {
                    AnsDes = this.subdistrictTextbox.Value,
                    QuestionId = 16,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer16);

            }
            else
            {

                {
                    ans16.QuestionId = 16;
                    ans16.AnsDes = this.subdistrictTextbox.Value;
                    ans16.AnserTypeId = 1;
                    ans16.CreateDate = DateTime.Now;
                    ans16.UserId = user.Id;
                    ans16.AnsMonth = ansMonth;
                }

            }

            var ans1641 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 1641).FirstOrDefault();
            if (ans1641 == null)
            {

                //District :
                Answer answer1641 = new Answer()
                {
                    AnsDes = this.districtTextbox.Value,
                    QuestionId = 1641,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer1641);

            }
            else
            {

                {
                    ans1641.QuestionId = 1641;
                    ans1641.AnsDes = this.districtTextbox.Value;
                    ans1641.AnserTypeId = 1;
                    ans1641.CreateDate = DateTime.Now;
                    ans1641.UserId = user.Id;
                    ans1641.AnsMonth = ansMonth;
                }

            }




            var ans17 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 17).FirstOrDefault();
            if (ans17 == null)
            {

                //Province :
                Answer answer17 = new Answer()
                {
                    AnsDes = this.provinceTextbox.Value,
                    QuestionId = 17,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer17);

            }
            else
            {

                {
                    ans17.QuestionId = 17;
                    ans17.AnsDes = this.provinceTextbox.Value;
                    ans17.AnserTypeId = 1;
                    ans17.CreateDate = DateTime.Now;
                    ans17.UserId = user.Id;
                    ans17.AnsMonth = ansMonth;
                }

            }


            var ans18 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 18).FirstOrDefault();
            if (ans18 == null)
            {

                //Province :
                Answer answer17 = new Answer()
                {
                    AnsDes = this.typeTextbox.Value,
                    QuestionId = 18,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer17);

            }
            else
            {

                {
                    ans18.QuestionId = 18;
                    ans18.AnsDes = this.typeTextbox.Value;
                    ans18.AnserTypeId = 1;
                    ans18.CreateDate = DateTime.Now;
                    ans18.UserId = user.Id;
                    ans18.AnsMonth = ansMonth;
                }

            }


            var ans19 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 19).FirstOrDefault();
            if (ans19 == null)
            {


                //PM Date :
                Answer answer19 = new Answer()
                {
                    AnsDes = this.pmdateTextbox.Value,
                    QuestionId = 19,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer19);

            }
            else
            {

                {
                    ans19.QuestionId = 19;
                    ans19.AnsDes = this.pmdateTextbox.Value;
                    ans19.AnserTypeId = 1;
                    ans19.CreateDate = DateTime.Now;
                    ans19.UserId = user.Id;
                    ans19.AnsMonth = ansMonth;
                }

            }



            //ใส่รูปหน้าอาคารศูนย์ USO Net :
            if (this.usonetsignboardImage.HasFile)
            {
                string extension = this.usonetsignboardImage.PostedFile.FileName.Split('.')[1];
                string newFileName = "images/UsonetPicture_" + DateTime.Now.ToString("yyyyMMddHHmmss") + "." + extension;
                this.usonetsignboardImage.PostedFile.SaveAs(Server.MapPath(newFileName));

                Answer answer20 = new Answer()
                {
                    AnsDes = newFileName,
                    QuestionId = 20,
                    AnserTypeId = 3,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer20);
            }



            var ans21 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 21).FirstOrDefault();
            if (ans21 == null)
            {



                //signature Executor :
                Answer answer21 = new Answer()
                {
                    AnsDes = this.signatureExecutorTextbox.Value,
                    QuestionId = 21,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer21);

            }
            else
            {

                {
                    ans21.QuestionId = 21;
                    ans21.AnsDes = this.signatureExecutorTextbox.Value;
                    ans21.AnserTypeId = 1;
                    ans21.CreateDate = DateTime.Now;
                    ans21.UserId = user.Id;
                    ans21.AnsMonth = ansMonth;
                }

            }






            var ans22 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 22).FirstOrDefault();
            if (ans22 == null)
            {

                //signature Executor :
                Answer answer22 = new Answer()
                {
                    AnsDes = this.signatureSupervisorTextbox.Value,
                    QuestionId = 22,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer22);

            }
            else
            {

                {
                    ans22.QuestionId = 21;
                    ans22.AnsDes = this.signatureSupervisorTextbox.Value;
                    ans22.AnserTypeId = 1;
                    ans22.CreateDate = DateTime.Now;
                    ans22.UserId = user.Id;
                    ans22.AnsMonth = ansMonth;
                }

            }


            var ans23 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 23).FirstOrDefault();
            if (ans23 == null)
            {

                //name Executor  :
                Answer answer23 = new Answer()
                {
                    AnsDes = this.nameExecutorTextbox.Value,
                    QuestionId = 23,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer23);

            }
            else
            {

                {
                    ans23.QuestionId = 23;
                    ans23.AnsDes = this.nameExecutorTextbox.Value;
                    ans23.AnserTypeId = 1;
                    ans23.CreateDate = DateTime.Now;
                    ans23.UserId = user.Id;
                    ans23.AnsMonth = ansMonth;
                }

            }







            var ans24 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 24).FirstOrDefault();
            if (ans24 == null)
            {
                //name Supervisor :
                Answer answer24 = new Answer()
                {
                    AnsDes = this.nameSupervisorTextbox.Value,
                    QuestionId = 24,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer24);

            }
            else
            {

                {
                    ans24.QuestionId = 24;
                    ans24.AnsDes = this.nameSupervisorTextbox.Value;
                    ans24.AnserTypeId = 1;
                    ans24.CreateDate = DateTime.Now;
                    ans24.UserId = user.Id;
                    ans24.AnsMonth = ansMonth;
                }

            }





            var ans25 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 25).FirstOrDefault();
            if (ans25 == null)
            {
                //Date Executor :
                Answer answer25 = new Answer()
                {
                    AnsDes = this.DateExecutorTextbox.Value,
                    QuestionId = 25,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer25);

            }
            else
            {

                {
                    ans25.QuestionId = 25;
                    ans25.AnsDes = this.DateExecutorTextbox.Value;
                    ans25.AnserTypeId = 1;
                    ans25.CreateDate = DateTime.Now;
                    ans25.UserId = user.Id;
                    ans25.AnsMonth = ansMonth;
                }

            }


            var ans26 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 26).FirstOrDefault();
            if (ans26 == null)
            {
                //Date Supervisor :
                Answer answer26 = new Answer()
                {
                    AnsDes = this.DateSupervisorTextbox.Value,
                    QuestionId = 26,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer26);

            }
            else
            {

                {
                    ans26.QuestionId = 26;
                    ans26.AnsDes = this.DateSupervisorTextbox.Value;
                    ans26.AnserTypeId = 1;
                    ans26.CreateDate = DateTime.Now;
                    ans26.UserId = user.Id;
                    ans26.AnsMonth = ansMonth;
                }

            }

            var ans27 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 27).FirstOrDefault();
            if (ans27 == null)
            {
                //Location name :
                Answer answer27 = new Answer()
                {
                    AnsDes = this.LocationnameTextbox.Value,
                    QuestionId = 27,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer27);

            }
            else
            {

                {
                    ans27.QuestionId = 27;
                    ans27.AnsDes = this.LocationnameTextbox.Value;
                    ans27.AnserTypeId = 1;
                    ans27.CreateDate = DateTime.Now;
                    ans27.UserId = user.Id;
                    ans27.AnsMonth = ansMonth;
                }

            }


            var ans28 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 28).FirstOrDefault();
            if (ans28 == null)
            {
                //Site code section 4 :
                Answer answer28 = new Answer()
                {
                    AnsDes = this.sitecodeTextboxSection4.Value,
                    QuestionId = 28,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer28);


            }
            else
            {

                {
                    ans28.QuestionId = 28;
                    ans28.AnsDes = this.sitecodeTextboxSection4.Value;
                    ans28.AnserTypeId = 1;
                    ans28.CreateDate = DateTime.Now;
                    ans28.UserId = user.Id;
                    ans28.AnsMonth = ansMonth;
                }

            }

            var ans29 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 29).FirstOrDefault();
            if (ans29 == null)
            {
                //villageIDsection 4 :
                Answer answer29 = new Answer()
                {
                    AnsDes = this.villageIDTextboxSection4.Value,
                    QuestionId = 29,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer29);


            }
            else
            {

                {
                    ans29.QuestionId = 29;
                    ans29.AnsDes = this.villageIDTextboxSection4.Value;
                    ans29.AnserTypeId = 1;
                    ans29.CreateDate = DateTime.Now;
                    ans29.UserId = user.Id;
                    ans29.AnsMonth = ansMonth;
                }

            }


            var ans30 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 30).FirstOrDefault();
            if (ans30 == null)
            {
                //lat and long  :
                Answer answer30 = new Answer()
                {
                    AnsDes = this.latandlongTextbox.Value,
                    QuestionId = 30,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer30);


            }
            else
            {

                {
                    ans30.QuestionId = 30;
                    ans30.AnsDes = this.latandlongTextbox.Value;
                    ans30.AnserTypeId = 1;
                    ans30.CreateDate = DateTime.Now;
                    ans30.UserId = user.Id;
                    ans30.AnsMonth = ansMonth;
                }

            }

            var ans31 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 31).FirstOrDefault();
            if (ans31 == null)
            {

                //type of signal Radio  :
                string typeOf = Request.Form["typeofsignalRadio"];
                Answer answer31 = new Answer()
                {

                    AnsDes = typeOf,
                    QuestionId = 31,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };

                uSOEntities.Answers.Add(answer31);
            }
            else
            {
                string typeOf = Request.Form["typeofsignalRadio"];
                ans31.AnsDes = typeOf;
                ans31.AnserTypeId = 4;
                ans31.CreateDate = DateTime.Now;
                ans31.QuestionId = 31;
                ans31.UserId = user.Id;
                ans31.AnsMonth = ansMonth;

            }





            var ans32 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 32).FirstOrDefault();
            if (ans32 == null)
            {
                //ISP (Existing Network)  :
                Answer answer32 = new Answer()
                {
                    AnsDes = this.ispTextbox.Value,
                    QuestionId = 32,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer32);

            }
            else
            {

                ans32.AnsDes = this.ispTextbox.Value;
                ans32.AnserTypeId = 1;
                ans32.CreateDate = DateTime.Now;
                ans32.QuestionId = 32;
                ans32.UserId = user.Id;
                ans32.AnsMonth = ansMonth;

            }

            var ans33 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 33).FirstOrDefault();
            if (ans33 == null)
            {
                //elecSystem Radio  :
                string elecradioSection5 = Request.Form["elecRadio"];
                Answer answer33 = new Answer()
                {
                    AnsDes = elecradioSection5,
                    QuestionId = 33,
                    AnserTypeId = 3,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer33);
            }
            else
            {
                string elecradioSection5 = Request.Form["elecRadio"];
                ans33.AnsDes = elecradioSection5;
                ans33.AnserTypeId = 4;
                ans33.CreateDate = DateTime.Now;
                ans33.QuestionId = 33;
                ans33.UserId = user.Id;
                ans33.AnsMonth = ansMonth;

            }



            var ans34 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 34).FirstOrDefault();
            if (ans34 == null)
            {

                //tranformer Radio  :
                string tranRadio = Request.Form["transformerRadio"];
                Answer answer34 = new Answer()
                {
                    AnsDes = tranRadio,
                    QuestionId = 34,
                    AnserTypeId = 3,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer34);

            }
            else
            {
                //tranformer Radio  :
                string tranRadio = Request.Form["transformerRadio"];
                ans34.AnsDes = tranRadio;
                ans34.AnserTypeId = 1;
                ans34.CreateDate = DateTime.Now;
                ans34.QuestionId = 34;
                ans34.UserId = user.Id;
                ans34.AnsMonth = ansMonth;

            }



            var ans35 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 35).FirstOrDefault();
            if (ans35 == null)
            {

                //หมายเลขผู้ใช้ไฟ  :
                Answer answer35 = new Answer()
                {
                    AnsDes = this.numberuserTextbox.Value,
                    QuestionId = 35,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer35);

            }
            else
            {

                ans35.AnsDes = this.numberuserTextbox.Value;
                ans35.AnserTypeId = 1;
                ans35.CreateDate = DateTime.Now;
                ans35.QuestionId = 35;
                ans35.UserId = user.Id;
                ans35.AnsMonth = ansMonth;

            }


            var ans36 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 36).FirstOrDefault();
            if (ans36 == null)
            {

                //หน่วยใช้ไฟไฟ  :
                Answer answer36 = new Answer()
                {

                    QuestionId = 36,
                    AnsDes = this.kwhMeterTextbox.Value,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer36);

            }
            else
            {
                ans36.QuestionId = 36;
                ans36.AnsDes = this.kwhMeterTextbox.Value;
                ans36.AnserTypeId = 1;
                ans36.CreateDate = DateTime.Now;
                ans36.UserId = user.Id;
                ans36.AnsMonth = ansMonth;

            }


            var ans37 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 37).FirstOrDefault();
            if (ans37 == null)
            {


                //แรงดัน AC (kWh Meter) :
                Answer answer37 = new Answer()
                {
                    AnsDes = this.acTextbox.Value,
                    QuestionId = 37,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer37);

            }
            else
            {
                ans37.QuestionId = 37;
                ans37.AnsDes = this.acTextbox.Value;
                ans37.AnserTypeId = 1;
                ans37.CreateDate = DateTime.Now;
                ans37.UserId = user.Id;
                ans37.AnsMonth = ansMonth;

            }




            var ans38 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 38).FirstOrDefault();
            if (ans38 == null)
            {

                //กระแส Line AC (kWh Meter) :
                Answer answer38 = new Answer()
                {
                    AnsDes = this.lineAcTextbox.Value,
                    QuestionId = 38,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer38);

            }
            else
            {
                ans38.QuestionId = 38;
                ans38.AnsDes = this.lineAcTextbox.Value;
                ans38.AnserTypeId = 1;
                ans38.CreateDate = DateTime.Now;
                ans38.UserId = user.Id;
                ans38.AnsMonth = ansMonth;

            }



            var ans39 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 39).FirstOrDefault();
            if (ans39 == null)
            {


                // กระแส Neutron AC(kWh Meter) :          
                Answer answer39 = new Answer()
                {
                    AnsDes = this.neutronacTextbox.Value,
                    QuestionId = 39,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer39);

            }
            else
            {
                ans39.QuestionId = 39;
                ans39.AnsDes = this.neutronacTextbox.Value;
                ans39.AnserTypeId = 1;
                ans39.CreateDate = DateTime.Now;
                ans39.UserId = user.Id;
                ans39.AnsMonth = ansMonth;

            }






            var ans40 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 40).FirstOrDefault();
            if (ans40 == null)
            {

                //สภาพ kWh Meter Radio  :
                string conRadio = Request.Form["conditionRadio"];
                Answer answer40 = new Answer()
                {
                    AnsDes = conRadio,
                    QuestionId = 40,
                    AnserTypeId = 3,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer40);

            }
            else
            {
                string conRadio = Request.Form["conditionRadio"];
                ans40.QuestionId = 40;
                ans40.AnsDes = conRadio;
                ans40.AnserTypeId = 1;
                ans40.CreateDate = DateTime.Now;
                ans40.UserId = user.Id;
                ans40.AnsMonth = ansMonth;

            }



            var ans41 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 41).FirstOrDefault();
            if (ans41 == null)
            {

                //สภาพ MDB/ Circuit Breaker Radio  :
                string CircuitBreakerRadio = Request.Form["MDBCircuitBreakerRadio"];
                Answer answer41 = new Answer()
                {
                    AnsDes = CircuitBreakerRadio,
                    QuestionId = 41,
                    AnserTypeId = 3,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer41);

            }
            else
            {
                string CircuitBreakerRadio = Request.Form["MDBCircuitBreakerRadio"];
                ans41.QuestionId = 41;
                ans41.AnsDes = CircuitBreakerRadio;
                ans41.AnserTypeId = 1;
                ans41.CreateDate = DateTime.Now;
                ans41.UserId = user.Id;
                ans41.AnsMonth = ansMonth;

            }




            var ans42 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 42).FirstOrDefault();
            if (ans42 == null)
            {

                //UPS ภายในตู้ Radio  :
                string innerUPS = Request.Form["inupsRadio"];
                Answer answer42 = new Answer()
                {
                    AnsDes = innerUPS,
                    QuestionId = 42,
                    AnserTypeId = 3,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer42);

            }
            else
            {
                string innerUPS = Request.Form["inupsRadio"];
                ans42.QuestionId = 42;
                ans42.AnsDes = innerUPS;
                ans42.AnserTypeId = 1;
                ans42.CreateDate = DateTime.Now;
                ans42.UserId = user.Id;
                ans42.AnsMonth = ansMonth;

            }





            var ans43 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 43).FirstOrDefault();
            if (ans43 == null)
            {

                // AC from UPS :          
                Answer answer43 = new Answer()
                {
                    AnsDes = this.acfromupsTextbox.Value,
                    QuestionId = 43,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer43);

            }
            else
            {

                ans43.QuestionId = 43;
                ans43.AnsDes = this.acfromupsTextbox.Value;
                ans43.AnserTypeId = 1;
                ans43.CreateDate = DateTime.Now;
                ans43.UserId = user.Id;
                ans43.AnsMonth = ansMonth;

            }



            var ans44 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 44).FirstOrDefault();
            if (ans44 == null)
            {
                // กระเเส โหลด :          
                Answer answer44 = new Answer()
                {
                    AnsDes = this.electricloadTextbox.Value,
                    QuestionId = 44,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer44);

            }
            else
            {

                ans44.QuestionId = 44;
                ans44.AnsDes = this.electricloadTextbox.Value;
                ans44.AnserTypeId = 1;
                ans44.CreateDate = DateTime.Now;
                ans44.UserId = user.Id;
                ans44.AnsMonth = ansMonth;

            }



            var ans45 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 45).FirstOrDefault();
            if (ans45 == null)
            {
                //EMER GENNNARATOR   :
                string emergen = Request.Form["emergeneratorRadio"];
                Answer answer45 = new Answer()
                {
                    AnsDes = emergen,
                    QuestionId = 45,
                    AnserTypeId = 3,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer45);

            }
            else
            {
                string emergen = Request.Form["emergeneratorRadio"];
                ans45.QuestionId = 45;
                ans45.AnsDes = emergen;
                ans45.AnserTypeId = 1;
                ans45.CreateDate = DateTime.Now;
                ans45.UserId = user.Id;
                ans45.AnsMonth = ansMonth;

            }






            var ans46 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 46).FirstOrDefault();
            if (ans46 == null)
            {
                //สภาพ batterry bank  :
                string statebat = Request.Form["stateBatteryBankRadio"];
                Answer answer46 = new Answer()
                {
                    AnsDes = statebat,
                    QuestionId = 46,
                    AnserTypeId = 3,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer46);

            }
            else
            {
                string statebat = Request.Form["stateBatteryBankRadio"];
                ans46.QuestionId = 46;
                ans46.AnsDes = statebat;
                ans46.AnserTypeId = 1;
                ans46.CreateDate = DateTime.Now;
                ans46.UserId = user.Id;
                ans46.AnsMonth = ansMonth;

            }





            var ans47 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 47).FirstOrDefault();
            if (ans47 == null)
            {

                //ONU/Modem Network  :
                string modemnet = Request.Form["onuModemRadio"];
                Answer answer47 = new Answer()
                {
                    AnsDes = modemnet,
                    QuestionId = 47,
                    AnserTypeId = 3,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer47);

            }
            else
            {
                string emergen = Request.Form["onuModemRadio"];
                ans47.QuestionId = 46;
                ans47.AnsDes = emergen;
                ans47.AnserTypeId = 1;
                ans47.CreateDate = DateTime.Now;
                ans47.UserId = user.Id;
                ans47.AnsMonth = ansMonth;

            }




            var ans48 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 48).FirstOrDefault();
            if (ans48 == null)
            {
                //Swicth 8 part :
                string swiftpart = Request.Form["switchportRadio"];
                Answer answer48 = new Answer()
                {
                    AnsDes = swiftpart,
                    QuestionId = 48,
                    AnserTypeId = 3,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer48);

            }
            else
            {
                string emergen = Request.Form["switchportRadio"];
                ans48.QuestionId = 48;
                ans48.AnsDes = emergen;
                ans48.AnserTypeId = 1;
                ans48.CreateDate = DateTime.Now;
                ans48.UserId = user.Id;
                ans48.AnsMonth = ansMonth;

            }



            var ans49 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 49).FirstOrDefault();
            if (ans49 == null)
            {
                //Swicth 48 part :
                string ee = Request.Form["switch48portRadio"];
                Answer answer49 = new Answer()
                {
                    AnsDes = ee,
                    QuestionId = 49,
                    AnserTypeId = 3,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer49);

            }
            else
            {
                string emergen = Request.Form["switch48portRadio"];
                ans49.QuestionId = 49;
                ans49.AnsDes = emergen;
                ans49.AnserTypeId = 1;
                ans49.CreateDate = DateTime.Now;
                ans49.UserId = user.Id;
                ans49.AnsMonth = ansMonth;

            }



            var ans50 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 50).FirstOrDefault();
            if (ans50 == null)
            {
                //Outdoor AP ตัวที่ 1 :
                string otap = Request.Form["outdoorapRadio"];
                Answer answer50 = new Answer()
                {
                    AnsDes = otap,
                    QuestionId = 50,
                    AnserTypeId = 3,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer50);


            }
            else
            {
                string emergen = Request.Form["outdoorapRadio"];
                ans50.QuestionId = 50;
                ans50.AnsDes = emergen;
                ans50.AnserTypeId = 1;
                ans50.CreateDate = DateTime.Now;
                ans50.UserId = user.Id;
                ans50.AnsMonth = ansMonth;

            }




            var ans51 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 51).FirstOrDefault();
            if (ans51 == null)
            {

                //Outdoor AP ตัวที่ 2 :
                string otap2 = Request.Form["outdoorap2Radio"];
                Answer answer51 = new Answer()
                {
                    AnsDes = otap2,
                    QuestionId = 51,
                    AnserTypeId = 3,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer51);


            }
            else
            {
                string emergen = Request.Form["outdoorap2Radio"];
                ans51.QuestionId = 51;
                ans51.AnsDes = emergen;
                ans51.AnserTypeId = 1;
                ans51.CreateDate = DateTime.Now;
                ans51.UserId = user.Id;
                ans51.AnsMonth = ansMonth;

            }




            var ans52 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 52).FirstOrDefault();
            if (ans52 == null)
            {

                //indoor AP ตัวที่ 1 :
                string inap2 = Request.Form["indoorapRadio"];
                Answer answer52 = new Answer()
                {
                    AnsDes = inap2,
                    QuestionId = 52,
                    AnserTypeId = 3,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer52);


            }
            else
            {
                string emergen = Request.Form["indoorapRadio"];
                ans52.QuestionId = 52;
                ans52.AnsDes = emergen;
                ans52.AnserTypeId = 1;
                ans52.CreateDate = DateTime.Now;
                ans52.UserId = user.Id;
                ans52.AnsMonth = ansMonth;

            }




            var ans53 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 53).FirstOrDefault();
            if (ans53 == null)
            {


                //indoor AP ตัวที่ 2 :
                string inapp = Request.Form["indoorap2Radio"];
                Answer answer53 = new Answer()
                {
                    AnsDes = inapp,
                    QuestionId = 53,
                    AnserTypeId = 3,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer53);


            }
            else
            {
                string emergen = Request.Form["indoorap2Radio"];
                ans53.QuestionId = 53;
                ans53.AnsDes = emergen;
                ans53.AnserTypeId = 1;
                ans53.CreateDate = DateTime.Now;
                ans53.UserId = user.Id;
                ans53.AnsMonth = ansMonth;

            }



            var ans54 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 54).FirstOrDefault();
            if (ans54 == null)
            {
                //การ Wiring สายไฟ :
                string wiring = Request.Form["wiringelecRadio"];
                Answer answer54 = new Answer()
                {
                    AnsDes = wiring,
                    QuestionId = 54,
                    AnserTypeId = 3,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer54);
            }
            else
            {
                string emergen = Request.Form["wiringelecRadio"];
                ans54.QuestionId = 54;
                ans54.AnsDes = emergen;
                ans54.AnserTypeId = 1;
                ans54.CreateDate = DateTime.Now;
                ans54.UserId = user.Id;
                ans54.AnsMonth = ansMonth;

            }



            var ans55 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 55).FirstOrDefault();
            if (ans55 == null)
            {
                //การ Wiring Patch cord และ สาย LAN :
                string wiringPatch = Request.Form["wiringpatchRadio"];
                Answer answer55 = new Answer()
                {
                    AnsDes = wiringPatch,
                    QuestionId = 55,
                    AnserTypeId = 3,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer55);
            }
            else
            {
                string emergen = Request.Form["wiringpatchRadio"];
                ans55.QuestionId = 55;
                ans55.AnsDes = emergen;
                ans55.AnserTypeId = 1;
                ans55.CreateDate = DateTime.Now;
                ans55.UserId = user.Id;
                ans55.AnsMonth = ansMonth;

            }

            var ans57 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 57).FirstOrDefault();
            if (ans57 == null)
            {

                //ความแข็งแรงจุดต่อ Ground Bar :
                string gb = Request.Form["groundbarRadio"];
                Answer answer57 = new Answer()
                {
                    AnsDes = gb,
                    QuestionId = 57,
                    AnserTypeId = 3,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer57);
            }
            else
            {
                string emergen = Request.Form["groundbarRadio"];
                ans57.QuestionId = 57;
                ans57.AnsDes = emergen;
                ans57.AnserTypeId = 1;
                ans57.CreateDate = DateTime.Now;
                ans57.UserId = user.Id;
                ans57.AnsMonth = ansMonth;

            }




            var ans58 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 58).FirstOrDefault();
            if (ans58 == null)
            {
                //ความแข็งแรงของน็อตขันหางปลาอุปกรณ์ :
                string fishnot = Request.Form["notfishRadio"];
                Answer answer58 = new Answer()
                {
                    AnsDes = fishnot,
                    QuestionId = 58,
                    AnserTypeId = 3,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer58);
            }
            else
            {
                string emergen = Request.Form["notfishRadio"];
                ans58.QuestionId = 58;
                ans58.AnsDes = emergen;
                ans58.AnserTypeId = 1;
                ans58.CreateDate = DateTime.Now;
                ans58.UserId = user.Id;
                ans58.AnsMonth = ansMonth;

            }






            var ans59 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 59).FirstOrDefault();
            if (ans59 == null)
            {
                //สายกราวด์เรียบร้อย ปลอดภัย สมบูรณ์ :
                string ffss = Request.Form["safegroundRadio"];
                Answer answer59 = new Answer()
                {
                    AnsDes = ffss,
                    QuestionId = 59,
                    AnserTypeId = 3,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer59);
            }
            else
            {
                string emergen = Request.Form["safegroundRadio"];
                ans59.QuestionId = 59;
                ans59.AnsDes = emergen;
                ans59.AnserTypeId = 1;
                ans59.CreateDate = DateTime.Now;
                ans59.UserId = user.Id;
                ans59.AnsMonth = ansMonth;

            }



            var ans60 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 60).FirstOrDefault();
            if (ans60 == null)
            {
                //สถานะไฟฟ้ารั่วลง Ground :
                string elecground = Request.Form["brokenElecRadio"];
                Answer answer60 = new Answer()
                {
                    AnsDes = elecground,
                    QuestionId = 60,
                    AnserTypeId = 3,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer60);
            }
            else
            {
                string emergen = Request.Form["brokenElecRadio"];
                ans60.QuestionId = 60;
                ans60.AnsDes = emergen;
                ans60.AnserTypeId = 1;
                ans60.CreateDate = DateTime.Now;
                ans60.UserId = user.Id;
                ans60.AnsMonth = ansMonth;

            }



            var ans61 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 61).FirstOrDefault();
            if (ans61 == null)
            {
                //Fire Alarm และ Smoke Detector :
                string firesmokeDetec = Request.Form["firesmokedDectorRadio"];
                Answer answer61 = new Answer()
                {
                    AnsDes = firesmokeDetec,
                    QuestionId = 61,
                    AnserTypeId = 3,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer61);
            }
            else
            {
                string emergen = Request.Form["firesmokedDectorRadio"];
                ans61.QuestionId = 61;
                ans61.AnsDes = emergen;
                ans61.AnserTypeId = 1;
                ans61.CreateDate = DateTime.Now;
                ans61.UserId = user.Id;
                ans61.AnsMonth = ansMonth;

            }






            var ans62 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 62).FirstOrDefault();
            if (ans62 == null)
            {

                //Fire Alarm Manual Switch :
                string FireAlarmManualSwitch = Request.Form["firealarmManualswitchRadio"];
                Answer answer62 = new Answer()
                {
                    AnsDes = FireAlarmManualSwitch,
                    QuestionId = 62,
                    AnserTypeId = 3,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer62);
            }
            else
            {
                string emergen = Request.Form["firealarmManualswitchRadio"];
                ans62.QuestionId = 62;
                ans62.AnsDes = emergen;
                ans62.AnserTypeId = 1;
                ans62.CreateDate = DateTime.Now;
                ans62.UserId = user.Id;
                ans62.AnsMonth = ansMonth;

            }







            var ans63 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 63).FirstOrDefault();
            if (ans63 == null)
            {

                // Battery Fire Alarm ก้อนที่ 1 :          
                Answer answer63 = new Answer()
                {
                    AnsDes = this.battFirealarm1Textbox.Value,
                    QuestionId = 63,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer63);
            }
            else
            {

                ans63.QuestionId = 63;
                ans63.AnsDes = this.battFirealarm1Textbox.Value;
                ans63.AnserTypeId = 1;
                ans63.CreateDate = DateTime.Now;
                ans63.UserId = user.Id;
                ans63.AnsMonth = ansMonth;

            }



            var ans64 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 64).FirstOrDefault();
            if (ans64 == null)
            {
                // Battery Fire Alarm ก้อนที่ 2 :          
                Answer answer64 = new Answer()
                {
                    AnsDes = this.battFirealarm3Textbox.Value,
                    QuestionId = 64,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer64);
            }
            else
            {

                ans64.QuestionId = 64;
                ans64.AnsDes = this.battFirealarm3Textbox.Value;
                ans64.AnserTypeId = 1;
                ans64.CreateDate = DateTime.Now;
                ans64.UserId = user.Id;
                ans64.AnsMonth = ansMonth;

            }

            var ans65 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 65).FirstOrDefault();
            if (ans65 == null)
            {
                //ไฟแสงสว่างฉุกเฉิน :
                string emerr = Request.Form["emerLightRadio"];
                Answer answer65 = new Answer()
                {
                    AnsDes = emerr,
                    QuestionId = 65,
                    AnserTypeId = 3,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer65);
            }
            else
            {
                string emerr = Request.Form["emerLightRadio"];
                ans65.QuestionId = 65;
                ans65.AnsDes = emerr;
                ans65.AnserTypeId = 1;
                ans65.CreateDate = DateTime.Now;
                ans65.UserId = user.Id;
                ans65.AnsMonth = ansMonth;
            }



            var ans66 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 66).FirstOrDefault();
            if (ans66 == null)
            {
                //ระบบ Monitor กล้องวงจรปิด :
                string monitorr = Request.Form["monitorCameraRadio"];
                Answer answer66 = new Answer()
                {
                    AnsDes = monitorr,
                    QuestionId = 66,
                    AnserTypeId = 3,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer66);
            }
            else
            {
                string emerr = Request.Form["monitorCameraRadio"];
                ans66.QuestionId = 66;
                ans66.AnsDes = emerr;
                ans66.AnserTypeId = 1;
                ans66.CreateDate = DateTime.Now;
                ans66.UserId = user.Id;
                ans66.AnsMonth = ansMonth;
            }



            var ans67 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 67).FirstOrDefault();
            if (ans67 == null)
            {
                //  กล้องวงจรปิด Computer :
                string cameraCom = Request.Form["cameraComputerRadio"];
                Answer answer67 = new Answer()
                {
                    AnsDes = cameraCom,
                    QuestionId = 67,
                    AnserTypeId = 3,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer67);
            }
            else
            {
                string emerr = Request.Form["cameraComputerRadio"];
                ans67.QuestionId = 67;
                ans67.AnsDes = emerr;
                ans67.AnserTypeId = 1;
                ans67.CreateDate = DateTime.Now;
                ans67.UserId = user.Id;
                ans67.AnsMonth = ansMonth;
            }







            var ans68 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 68).FirstOrDefault();
            if (ans68 == null)
            {
                //  กล้องวงจรปิดภายนอกอาคาร  :
                string cameraout = Request.Form["cameraOutRadio"];
                Answer answer68 = new Answer()
                {
                    AnsDes = cameraout,
                    QuestionId = 68,
                    AnserTypeId = 3,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer68);
            }
            else
            {
                string emerr = Request.Form["cameraOutRadio"];
                ans68.QuestionId = 68;
                ans68.AnsDes = emerr;
                ans68.AnserTypeId = 1;
                ans68.CreateDate = DateTime.Now;
                ans68.UserId = user.Id;
                ans68.AnsMonth = ansMonth;
            }






            var ans69 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 69).FirstOrDefault();
            if (ans69 == null)
            {
                //  กล้องวงจรปิดภายนอกอาคาร 2  :
                string cameraout2 = Request.Form["cameraOut2Radio"];
                Answer answer69 = new Answer()
                {
                    AnsDes = cameraout2,
                    QuestionId = 69,
                    AnserTypeId = 3,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer69);

            }
            else
            {
                string emerr = Request.Form["cameraOut2Radio"];
                ans69.QuestionId = 69;
                ans69.AnsDes = emerr;
                ans69.AnserTypeId = 1;
                ans69.CreateDate = DateTime.Now;
                ans69.UserId = user.Id;
                ans69.AnsMonth = ansMonth;
            }


            var ans70 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 70).FirstOrDefault();
            if (ans70 == null)
            {
                //  จอทีวีห้องประชุม   :
                string tv = Request.Form["televisRadio"];
                Answer answer70 = new Answer()
                {
                    AnsDes = tv,
                    QuestionId = 70,
                    AnserTypeId = 3,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer70);

            }
            else
            {
                string emerr = Request.Form["televisRadio"];
                ans70.QuestionId = 70;
                ans70.AnsDes = emerr;
                ans70.AnserTypeId = 1;
                ans70.CreateDate = DateTime.Now;
                ans70.UserId = user.Id;
                ans70.AnsMonth = ansMonth;
            }


            var ans71 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 71).FirstOrDefault();
            if (ans71 == null)
            {

                //  คอมพิวเตอร์เจ้าหน้าที่ศูนย์  :
                string comagent = Request.Form["computerAgentRadio"];
                Answer answer71 = new Answer()
                {
                    AnsDes = comagent,
                    QuestionId = 71,
                    AnserTypeId = 3,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer71);

            }
            else
            {
                string emerr = Request.Form["computerAgentRadio"];
                ans71.QuestionId = 71;
                ans71.AnsDes = emerr;
                ans71.AnserTypeId = 1;
                ans71.CreateDate = DateTime.Now;
                ans71.UserId = user.Id;
                ans71.AnsMonth = ansMonth;
            }



            var ans72 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 72).FirstOrDefault();
            if (ans72 == null)
            {

                //  Printer  :
                string print = Request.Form["printerRadio"];
                Answer answer72 = new Answer()
                {
                    AnsDes = print,
                    QuestionId = 72,
                    AnserTypeId = 3,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer72);

            }
            else
            {
                string emerr = Request.Form["printerRadio"];
                ans72.QuestionId = 72;
                ans72.AnsDes = emerr;
                ans72.AnserTypeId = 1;
                ans72.CreateDate = DateTime.Now;
                ans72.UserId = user.Id;
                ans72.AnsMonth = ansMonth;
            }






            var ans73 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 73).FirstOrDefault();
            if (ans73 == null)
            {

                // คอมพิวเตอร์ตัวที่ 1  :
                string com1 = Request.Form["Com1Radio"];
                Answer answer73 = new Answer()
                {
                    AnsDes = com1,
                    QuestionId = 73,
                    AnserTypeId = 3,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer73);

            }
            else
            {
                string emerr = Request.Form["Com1Radio"];
                ans73.QuestionId = 73;
                ans73.AnsDes = emerr;
                ans73.AnserTypeId = 1;
                ans73.CreateDate = DateTime.Now;
                ans73.UserId = user.Id;
                ans73.AnsMonth = ansMonth;
            }



            var ans74 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 74).FirstOrDefault();
            if (ans74 == null)
            {

                // คอมพิวเตอร์ตัวที่ 2  :
                string com2 = Request.Form["com2Radio"];
                Answer answer74 = new Answer()
                {
                    AnsDes = com2,
                    QuestionId = 74,
                    AnserTypeId = 3,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer74);

            }
            else
            {
                string emerr = Request.Form["com2Radio"];
                ans74.QuestionId = 74;
                ans74.AnsDes = emerr;
                ans74.AnserTypeId = 1;
                ans74.CreateDate = DateTime.Now;
                ans74.UserId = user.Id;
                ans74.AnsMonth = ansMonth;
            }



            var ans75 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 75).FirstOrDefault();
            if (ans75 == null)
            {

                // คอมพิวเตอร์ตัวที่ 2  com3Radio
                string com2 = Request.Form["com2Radio"];
                Answer answer74 = new Answer()
                {
                    AnsDes = com2,
                    QuestionId = 75,
                    AnserTypeId = 3,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer74);

            }
            else
            {
                string emerr = Request.Form["com3Radio"];
                ans75.QuestionId = 75;
                ans75.AnsDes = emerr;
                ans75.AnserTypeId = 1;
                ans75.CreateDate = DateTime.Now;
                ans75.UserId = user.Id;
                ans75.AnsMonth = ansMonth;
            }





            var ans76 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 76).FirstOrDefault();
            if (ans76 == null)
            {

                // คอมพิวเตอร์ตัวที่ 4  :
                string com4 = Request.Form["com4Radio"];
                Answer answer76 = new Answer()
                {
                    AnsDes = com4,
                    QuestionId = 76,
                    AnserTypeId = 3,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer76);


            }
            else
            {
                string emerr = Request.Form["com4Radio"];
                ans76.QuestionId = 76;
                ans76.AnsDes = emerr;
                ans76.AnserTypeId = 1;
                ans76.CreateDate = DateTime.Now;
                ans76.UserId = user.Id;
                ans76.AnsMonth = ansMonth;
            }




            var ans77 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 77).FirstOrDefault();
            if (ans77 == null)
            {


                // คอมพิวเตอร์ตัวที่ 5  :
                string com5 = Request.Form["com5Radio"];
                Answer answer77 = new Answer()
                {
                    AnsDes = com5,
                    QuestionId = 77,
                    AnserTypeId = 3,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer77);


            }
            else
            {
                string emerr = Request.Form["com5Radio"];
                ans77.QuestionId = 77;
                ans77.AnsDes = emerr;
                ans77.AnserTypeId = 1;
                ans77.CreateDate = DateTime.Now;
                ans77.UserId = user.Id;
                ans77.AnsMonth = ansMonth;
            }



            var ans78 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 78).FirstOrDefault();
            if (ans78 == null)
            {

                // คอมพิวเตอร์ตัวที่ 6  :
                string com6 = Request.Form["com6Radio"];
                Answer answer78 = new Answer()
                {
                    AnsDes = com6,
                    QuestionId = 78,
                    AnserTypeId = 3,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer78);


            }
            else
            {
                string emerr = Request.Form["com6Radio"];
                ans78.QuestionId = 78;
                ans78.AnsDes = emerr;
                ans78.AnserTypeId = 1;
                ans78.CreateDate = DateTime.Now;
                ans78.UserId = user.Id;
                ans78.AnsMonth = ansMonth;
            }




            var ans79 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 79).FirstOrDefault();
            if (ans79 == null)
            {
                // คอมพิวเตอร์ตัวที่ 7  :
                string com7 = Request.Form["com7Radio"];
                Answer answer79 = new Answer()
                {
                    AnsDes = com7,
                    QuestionId = 79,
                    AnserTypeId = 3,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer79);



            }
            else
            {
                string emerr = Request.Form["com7Radio"];
                ans79.QuestionId = 79;
                ans79.AnsDes = emerr;
                ans79.AnserTypeId = 1;
                ans79.CreateDate = DateTime.Now;
                ans79.UserId = user.Id;
                ans79.AnsMonth = ansMonth;
            }




            var ans80 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 80).FirstOrDefault();
            if (ans80 == null)
            {

                // คอมพิวเตอร์ตัวที่ 8  :
                string com8 = Request.Form["com8Radio"];
                Answer answer80 = new Answer()
                {
                    AnsDes = com8,
                    QuestionId = 80,
                    AnserTypeId = 3,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer80);



            }
            else
            {
                string emerr = Request.Form["com8Radio"];
                ans80.QuestionId = 80;
                ans80.AnsDes = emerr;
                ans80.AnserTypeId = 1;
                ans80.CreateDate = DateTime.Now;
                ans80.UserId = user.Id;
                ans80.AnsMonth = ansMonth;
            }






            var ans81 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 81).FirstOrDefault();
            if (ans81 == null)
            {


                // คอมพิวเตอร์ตัวที่ 9  :
                string com9 = Request.Form["com9Radio"];
                Answer answer81 = new Answer()
                {
                    AnsDes = com9,
                    QuestionId = 81,
                    AnserTypeId = 3,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer81);



            }
            else
            {
                string emerr = Request.Form["com9Radio"];
                ans81.QuestionId = 81;
                ans81.AnsDes = emerr;
                ans81.AnserTypeId = 1;
                ans81.CreateDate = DateTime.Now;
                ans81.UserId = user.Id;
                ans81.AnsMonth = ansMonth;
            }





            var ans82 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 82).FirstOrDefault();
            if (ans82 == null)
            {

                // คอมพิวเตอร์ตัวที่ 10  :
                string com10 = Request.Form["com10Radio"];
                Answer answer82 = new Answer()
                {
                    AnsDes = com10,
                    QuestionId = 82,
                    AnserTypeId = 3,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer82);



            }
            else
            {
                string emerr = Request.Form["com10Radio"];
                ans82.QuestionId = 82;
                ans82.AnsDes = emerr;
                ans82.AnserTypeId = 1;
                ans82.CreateDate = DateTime.Now;
                ans82.UserId = user.Id;
                ans82.AnsMonth = ansMonth;
            }




            var ans83 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 83).FirstOrDefault();
            if (ans83 == null)
            {

                // แอ 1  :
                string air1 = Request.Form["airRadio"];
                Answer answer83 = new Answer()
                {
                    AnsDes = air1,
                    QuestionId = 83,
                    AnserTypeId = 3,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer83);



            }
            else
            {
                string emerr = Request.Form["airRadio"];
                ans83.QuestionId = 83;
                ans83.AnsDes = emerr;
                ans83.AnserTypeId = 1;
                ans83.CreateDate = DateTime.Now;
                ans83.UserId = user.Id;
                ans83.AnsMonth = ansMonth;
            }





            var ans84 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 84).FirstOrDefault();
            if (ans84 == null)
            {

                // แอ 2  :
                string air2 = Request.Form["air2Radio"];
                Answer answer84 = new Answer()
                {
                    AnsDes = air2,
                    QuestionId = 84,
                    AnserTypeId = 3,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer84);



            }
            else
            {
                string emerr = Request.Form["air2Radio"];
                ans83.QuestionId = 84;
                ans83.AnsDes = emerr;
                ans83.AnserTypeId = 1;
                ans83.CreateDate = DateTime.Now;
                ans83.UserId = user.Id;
                ans83.AnsMonth = ansMonth;
            }







            var ans85 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 85).FirstOrDefault();
            if (ans85 == null)
            {


                // ความสะอาดภายในห้อง   :
                string clean1 = Request.Form["cleaninroomRadio"];
                Answer answer85 = new Answer()
                {
                    AnsDes = clean1,
                    QuestionId = 85,
                    AnserTypeId = 3,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer85);



            }
            else
            {
                string emerr = Request.Form["cleaninroomRadio"];
                ans85.QuestionId = 85;
                ans85.AnsDes = emerr;
                ans85.AnserTypeId = 1;
                ans85.CreateDate = DateTime.Now;
                ans85.UserId = user.Id;
                ans85.AnsMonth = ansMonth;
            }




            var ans86 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 86).FirstOrDefault();
            if (ans86 == null)
            {


                // ความสะอาดภายในห้อง   :
                string cleanout = Request.Form["cleanoutroomRadio"];
                Answer answer86 = new Answer()
                {
                    AnsDes = cleanout,
                    QuestionId = 86,
                    AnserTypeId = 3,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer86);



            }
            else
            {
                string emerr = Request.Form["cleanoutroomRadio"];
                ans86.QuestionId = 86;
                ans86.AnsDes = emerr;
                ans86.AnserTypeId = 1;
                ans86.CreateDate = DateTime.Now;
                ans86.UserId = user.Id;
                ans86.AnsMonth = ansMonth;
            }




            var ans87 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 87).FirstOrDefault();
            if (ans87 == null)
            {


                // ประตู   :
                string dOOr = Request.Form["doorRadio"];
                Answer answer87 = new Answer()
                {
                    AnsDes = dOOr,
                    QuestionId = 87,
                    AnserTypeId = 3,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer87);




            }
            else
            {
                string emerr = Request.Form["doorRadio"];
                ans87.QuestionId = 87;
                ans87.AnsDes = emerr;
                ans87.AnserTypeId = 1;
                ans87.CreateDate = DateTime.Now;
                ans87.UserId = user.Id;
                ans87.AnsMonth = ansMonth;
            }




            var ans88 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 88).FirstOrDefault();
            if (ans88 == null)
            {


                // อุปกรณ์ LNB/BUC   :
                string tools = Request.Form["toolslnbRadio"];
                Answer answer88 = new Answer()
                {
                    AnsDes = tools,
                    QuestionId = 88,
                    AnserTypeId = 3,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer88);

            }
            else
            {
                string emerr = Request.Form["toolslnbRadio"];
                ans88.QuestionId = 88;
                ans88.AnsDes = emerr;
                ans88.AnserTypeId = 1;
                ans88.CreateDate = DateTime.Now;
                ans88.UserId = user.Id;
                ans88.AnsMonth = ansMonth;
            }




            var ans89 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 89).FirstOrDefault();
            if (ans89 == null)
            {

                // การเก็บสาย RG และการพันหัว   :
                string toolsRG = Request.Form["wiringrgRadio"];
                Answer answer89 = new Answer()
                {
                    AnsDes = toolsRG,
                    QuestionId = 89,
                    AnserTypeId = 3,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer89);

            }
            else
            {
                string emerr = Request.Form["wiringrgRadio"];
                ans89.QuestionId = 89;
                ans89.AnsDes = emerr;
                ans89.AnserTypeId = 1;
                ans89.CreateDate = DateTime.Now;
                ans89.UserId = user.Id;
                ans89.AnsMonth = ansMonth;
            }






            var ans90 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 90).FirstOrDefault();
            if (ans90 == null)
            {


                // ฐานและระดับของเสาจาน  :
                string baseOneiei = Request.Form["baseOnRadio"];
                Answer answer90 = new Answer()
                {
                    AnsDes = baseOneiei,
                    QuestionId = 90,
                    AnserTypeId = 3,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer90);

            }
            else
            {
                string emerr = Request.Form["baseOnRadio"];
                ans90.QuestionId = 90;
                ans90.AnsDes = emerr;
                ans90.AnserTypeId = 1;
                ans90.CreateDate = DateTime.Now;
                ans90.UserId = user.Id;
                ans90.AnsMonth = ansMonth;
            }




            var ans91 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 91).FirstOrDefault();
            if (ans91 == null)
            {


                // ฐานและระดับของเสาจาน  :
                string lineOf = Request.Form["lineOfsightRadio"];
                Answer answer91 = new Answer()
                {
                    AnsDes = lineOf,
                    QuestionId = 91,
                    AnserTypeId = 3,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer91);

            }
            else
            {
                string emerr = Request.Form["lineOfsightRadio"];
                ans91.QuestionId = 91;
                ans91.AnsDes = emerr;
                ans91.AnserTypeId = 1;
                ans91.CreateDate = DateTime.Now;
                ans91.UserId = user.Id;
                ans91.AnsMonth = ansMonth;
            }






            var ans92 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 92).FirstOrDefault();
            if (ans92 == null)
            {

                // ความสะอาดของหน้าจาน  :
                string clendDish = Request.Form["cleaningDishRadio"];
                Answer answer92 = new Answer()
                {
                    AnsDes = clendDish,
                    QuestionId = 92,
                    AnserTypeId = 3,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer92);

            }
            else
            {
                string emerr = Request.Form["cleaningDishRadio"];
                ans92.QuestionId = 92;
                ans92.AnsDes = emerr;
                ans92.AnserTypeId = 1;
                ans92.CreateDate = DateTime.Now;
                ans92.UserId = user.Id;
                ans92.AnsMonth = ansMonth;
            }




            var ans93 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 93).FirstOrDefault();
            if (ans93 == null)
            {

                // LNB Band Switch  :
                string lnbswitch = Request.Form["lnbbandswitchRadio"];
                Answer answer93 = new Answer()
                {
                    AnsDes = lnbswitch,
                    QuestionId = 93,
                    AnserTypeId = 3,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer93);

            }
            else
            {
                string emerr = Request.Form["lnbbandswitchRadio"];
                ans93.QuestionId = 93;
                ans93.AnsDes = emerr;
                ans93.AnserTypeId = 1;
                ans93.CreateDate = DateTime.Now;
                ans93.UserId = user.Id;
                ans93.AnsMonth = ansMonth;
            }




            var ans94 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 94).FirstOrDefault();
            if (ans94 == null)
            {

                // ระบบ Solar Cell :
                string solarCells = Request.Form["solarcellSystemRadio"];
                Answer answer94 = new Answer()
                {
                    AnsDes = solarCells,
                    QuestionId = 94,
                    AnserTypeId = 3,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer94);

            }
            else
            {
                string emerr = Request.Form["solarcellSystemRadio"];
                ans94.QuestionId = 94;
                ans94.AnsDes = emerr;
                ans94.AnserTypeId = 1;
                ans94.CreateDate = DateTime.Now;
                ans94.UserId = user.Id;
                ans94.AnsMonth = ansMonth;
            }





            var ans95 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 95).FirstOrDefault();
            if (ans95 == null)
            {

                // แผง PV Panel:
                string pv = Request.Form["pvPanelRadio"];
                Answer answer95 = new Answer()
                {
                    AnsDes = pv,
                    QuestionId = 95,
                    AnserTypeId = 3,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer95);

            }
            else
            {
                string emerr = Request.Form["pvPanelRadio"];
                ans95.QuestionId = 95;
                ans95.AnsDes = emerr;
                ans95.AnserTypeId = 1;
                ans95.CreateDate = DateTime.Now;
                ans95.UserId = user.Id;
                ans95.AnsMonth = ansMonth;
            }






            var ans96 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 96).FirstOrDefault();
            if (ans96 == null)
            {

                // อุปกรณ์ Charger :
                string charGer = Request.Form["toolsCharger"];
                Answer answer96 = new Answer()
                {
                    AnsDes = charGer,
                    QuestionId = 96,
                    AnserTypeId = 3,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer96);


            }
            else
            {
                string emerr = Request.Form["toolsCharger"];
                ans96.QuestionId = 96;
                ans96.AnsDes = emerr;
                ans96.AnserTypeId = 1;
                ans96.CreateDate = DateTime.Now;
                ans96.UserId = user.Id;
                ans96.AnsMonth = ansMonth;
            }





            var ans97 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 97).FirstOrDefault();
            if (ans97 == null)
            {


                // ความสะอาดแผง PV :
                string cleanPv = Request.Form["cleanIngpvRadio"];
                Answer answer97 = new Answer()
                {
                    AnsDes = cleanPv,
                    QuestionId = 97,
                    AnserTypeId = 3,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer97);


            }
            else
            {
                string emerr = Request.Form["cleanIngpvRadio"];
                ans97.QuestionId = 97;
                ans97.AnsDes = emerr;
                ans97.AnserTypeId = 1;
                ans97.CreateDate = DateTime.Now;
                ans97.UserId = user.Id;
                ans97.AnsMonth = ansMonth;
            }





            var ans98 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 98).FirstOrDefault();
            if (ans98 == null)
            {



                // การติดตั้งแผง PV :
                string intPv = Request.Form["installPvRadio"];
                Answer answer98 = new Answer()
                {
                    AnsDes = intPv,
                    QuestionId = 98,
                    AnserTypeId = 3,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer98);



            }
            else
            {
                string emerr = Request.Form["installPvRadio"];
                ans98.QuestionId = 98;
                ans98.AnsDes = emerr;
                ans98.AnserTypeId = 1;
                ans98.CreateDate = DateTime.Now;
                ans98.UserId = user.Id;
                ans98.AnsMonth = ansMonth;
            }




            var ans99 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 99).FirstOrDefault();
            if (ans99 == null)
            {

                // แรงดันไฟจาก Inverter :          
                Answer answer99 = new Answer()
                {
                    AnsDes = this.voltageInverterTextbox.Value,
                    QuestionId = 99,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer99);


            }
            else
            {

                ans99.QuestionId = 99;
                ans99.AnsDes = this.voltageInverterTextbox.Value;
                ans99.AnserTypeId = 1;
                ans99.CreateDate = DateTime.Now;
                ans99.UserId = user.Id;
                ans99.AnsMonth = ansMonth;
            }





            var ans100 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 100).FirstOrDefault();
            if (ans100 == null)
            {

                // กระแส Load :          
                Answer answer100 = new Answer()
                {
                    AnsDes = this.voltageLoadTextbox.Value,
                    QuestionId = 100,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer100);



            }
            else
            {

                ans100.QuestionId = 100;
                ans100.AnsDes = this.voltageLoadTextbox.Value;
                ans100.AnserTypeId = 1;
                ans100.CreateDate = DateTime.Now;
                ans100.UserId = user.Id;
                ans100.AnsMonth = ansMonth;
            }




            var ans101 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 101).FirstOrDefault();
            if (ans101 == null)
            {
                // Download (for ONU/VSAT) :          
                Answer answer101 = new Answer()
                {
                    AnsDes = this.dowloadforOnuTextbox.Value,
                    QuestionId = 101,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer101);
            }
            else
            {
                ans101.QuestionId = 101;
                ans101.AnsDes = this.dowloadforOnuTextbox.Value;
                ans101.AnserTypeId = 1;
                ans101.CreateDate = DateTime.Now;
                ans101.UserId = user.Id;
                ans101.AnsMonth = ansMonth;
            }




            var ans102 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 102).FirstOrDefault();
            if (ans102 == null)
            {
                // Upload (for ONU/VSAT) :          
                Answer answer102 = new Answer()
                {
                    AnsDes = this.uploadforOnuTextbox.Value,
                    QuestionId = 102,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer102);
            }
            else
            {
                ans102.QuestionId = 102;
                ans102.AnsDes = this.uploadforOnuTextbox.Value;
                ans102.AnserTypeId = 1;
                ans102.CreateDate = DateTime.Now;
                ans102.UserId = user.Id;
                ans102.AnsMonth = ansMonth;
            }


            var ans103 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 103).FirstOrDefault();
            if (ans103 == null)
            {

                // Ping Test (for ONU/VSAT):          
                Answer answer103 = new Answer()
                {
                    AnsDes = this.pingTestTextbox.Value,
                    QuestionId = 103,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer103);

            }
            else
            {
                ans103.QuestionId = 103;
                ans103.AnsDes = this.pingTestTextbox.Value;
                ans103.AnserTypeId = 1;
                ans103.CreateDate = DateTime.Now;
                ans103.UserId = user.Id;
                ans103.AnsMonth = ansMonth;
            }



            var ans104 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 104).FirstOrDefault();
            if (ans104 == null)
            {

                // Download (for WIFI):          
                Answer answer104 = new Answer()
                {
                    AnsDes = this.dowloadForwifiTextbox.Value,
                    QuestionId = 104,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer104);

            }
            else
            {
                ans104.QuestionId = 104;
                ans104.AnsDes = this.dowloadForwifiTextbox.Value;
                ans104.AnserTypeId = 1;
                ans104.CreateDate = DateTime.Now;
                ans104.UserId = user.Id;
                ans104.AnsMonth = ansMonth;
            }





            var ans105 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 105).FirstOrDefault();
            if (ans105 == null)
            {
                // Upload (for WIFI):          
                Answer answer105 = new Answer()
                {
                    AnsDes = this.uploadForwifiTextbox.Value,
                    QuestionId = 105,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer105);

            }
            else
            {
                ans105.QuestionId = 105;
                ans105.AnsDes = this.uploadForwifiTextbox.Value;
                ans105.AnserTypeId = 1;
                ans105.CreateDate = DateTime.Now;
                ans105.UserId = user.Id;
                ans105.AnsMonth = ansMonth;
            }




            var ans106 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 106).FirstOrDefault();
            if (ans106 == null)
            {
                // Ping Test (for WIFI) :          
                Answer answer106 = new Answer()
                {
                    AnsDes = this.pingtestForwifiTextbox.Value,
                    QuestionId = 106,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer106);

            }
            else
            {
                ans106.QuestionId = 106;
                ans106.AnsDes = this.pingtestForwifiTextbox.Value;
                ans106.AnserTypeId = 1;
                ans106.CreateDate = DateTime.Now;
                ans106.UserId = user.Id;
                ans106.AnsMonth = ansMonth;
            }



            var ans107 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 107).FirstOrDefault();
            if (ans107 == null)
            {
                // Download (for LAN) :          
                Answer answer107 = new Answer()
                {
                    AnsDes = this.dowlaodForlanTextbox.Value,
                    QuestionId = 107,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer107);

            }
            else
            {
                ans107.QuestionId = 107;
                ans107.AnsDes = this.dowlaodForlanTextbox.Value;
                ans107.AnserTypeId = 1;
                ans107.CreateDate = DateTime.Now;
                ans107.UserId = user.Id;
                ans107.AnsMonth = ansMonth;
            }




            var ans108 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 108).FirstOrDefault();
            if (ans108 == null)
            {
                //Upload (for LAN) :          
                Answer answer108 = new Answer()
                {
                    AnsDes = this.uploadForlandTextbox.Value,
                    QuestionId = 108,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer108);

            }
            else
            {
                ans108.QuestionId = 108;
                ans108.AnsDes = this.uploadForlandTextbox.Value;
                ans108.AnserTypeId = 1;
                ans108.CreateDate = DateTime.Now;
                ans108.UserId = user.Id;
                ans108.AnsMonth = ansMonth;
            }





            var ans109 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 109).FirstOrDefault();
            if (ans109 == null)
            {
                //Ping Test  (for LAN) :          
                Answer answer109 = new Answer()
                {
                    AnsDes = this.pingtestForlanTextbox.Value,
                    QuestionId = 109,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer109);

            }
            else
            {
                ans109.QuestionId = 109;
                ans109.AnsDes = this.pingtestForlanTextbox.Value;
                ans109.AnserTypeId = 1;
                ans109.CreateDate = DateTime.Now;
                ans109.UserId = user.Id;
                ans109.AnsMonth = ansMonth;
            }





            var ans110 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 110).FirstOrDefault();
            if (ans110 == null)
            {
                //  ปัญหาที่พบ 1 :           
                Answer answer110 = new Answer()
                {
                    AnsDes = this.problemTextbox1.Value,
                    QuestionId = 110,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer110);

            }
            else
            {
                ans110.QuestionId = 110;
                ans110.AnsDes = this.problemTextbox1.Value;
                ans110.AnserTypeId = 1;
                ans110.CreateDate = DateTime.Now;
                ans110.UserId = user.Id;
                ans110.AnsMonth = ansMonth;
            }



            var ans111 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 111).FirstOrDefault();
            if (ans111 == null)
            {
                //  วิธีแก้ปัญหา 1 :           
                Answer answer111 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox1.Value,
                    QuestionId = 111,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer111);

            }
            else
            {
                ans111.QuestionId = 111;
                ans111.AnsDes = this.howtoSolveTextbox1.Value;
                ans111.AnserTypeId = 1;
                ans111.CreateDate = DateTime.Now;
                ans111.UserId = user.Id;
                ans111.AnsMonth = ansMonth;
            }





            var ans112 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 112).FirstOrDefault();
            if (ans112 == null)
            {
                //  ปัญหาที่พบ 2 :           
                Answer answer112 = new Answer()
                {
                    AnsDes = this.problemTextbox2.Value,
                    QuestionId = 112,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer112);

            }
            else
            {
                ans112.QuestionId = 112;
                ans112.AnsDes = this.problemTextbox2.Value;
                ans112.AnserTypeId = 1;
                ans112.CreateDate = DateTime.Now;
                ans112.UserId = user.Id;
                ans112.AnsMonth = ansMonth;
            }


            var ans113 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 113).FirstOrDefault();
            if (ans113 == null)
            {
                //  วิธีแก้ปัญหา 2 :           
                Answer answer113 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox2.Value,
                    QuestionId = 113,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer113);

            }
            else
            {
                ans113.QuestionId = 113;
                ans113.AnsDes = this.howtoSolveTextbox2.Value;
                ans113.AnserTypeId = 1;
                ans113.CreateDate = DateTime.Now;
                ans113.UserId = user.Id;
                ans113.AnsMonth = ansMonth;
            }




            var ans114 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 114).FirstOrDefault();
            if (ans114 == null)
            {
                //  ปัญหาที่พบ 3 :           
                Answer answer114 = new Answer()
                {
                    AnsDes = this.problemTextbox3.Value,
                    QuestionId = 114,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer114);

            }
            else
            {
                ans114.QuestionId = 114;
                ans114.AnsDes = this.problemTextbox3.Value;
                ans114.AnserTypeId = 1;
                ans114.CreateDate = DateTime.Now;
                ans114.UserId = user.Id;
                ans114.AnsMonth = ansMonth;
            }





            var ans115 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 115).FirstOrDefault();
            if (ans115 == null)
            {
                //  วิธีแก้ปัญหา 3 :           
                Answer answer115 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox3.Value,
                    QuestionId = 115,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer115);
            }
            else
            {
                ans115.QuestionId = 115;
                ans115.AnsDes = this.howtoSolveTextbox3.Value;
                ans115.AnserTypeId = 1;
                ans115.CreateDate = DateTime.Now;
                ans115.UserId = user.Id;
                ans115.AnsMonth = ansMonth;
            }






            var ans116 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 116).FirstOrDefault();
            if (ans116 == null)
            {
                //  ปัญหาที่พบ 4 :           
                Answer answer116 = new Answer()
                {
                    AnsDes = this.problemTextbox4.Value,
                    QuestionId = 116,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer116);
            }
            else
            {
                ans116.QuestionId = 116;
                ans116.AnsDes = this.problemTextbox4.Value;
                ans116.AnserTypeId = 1;
                ans116.CreateDate = DateTime.Now;
                ans116.UserId = user.Id;
                ans116.AnsMonth = ansMonth;
            }





            var ans117 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 117).FirstOrDefault();
            if (ans117 == null)
            {
                //  วิธีแก้ปัญหา 4 :           
                Answer answer117 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox4.Value,
                    QuestionId = 117,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer117);
            }
            else
            {
                ans117.QuestionId = 117;
                ans117.AnsDes = this.howtoSolveTextbox4.Value;
                ans117.AnserTypeId = 1;
                ans117.CreateDate = DateTime.Now;
                ans117.UserId = user.Id;
                ans117.AnsMonth = ansMonth;
            }





            var ans118 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 118).FirstOrDefault();
            if (ans118 == null)
            {

                //  ปัญหาที่พบ 5 :           
                Answer answer118 = new Answer()
                {
                    AnsDes = this.problemTextbox5.Value,
                    QuestionId = 118,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer118);
            }
            else
            {
                ans118.QuestionId = 118;
                ans118.AnsDes = this.problemTextbox5.Value;
                ans118.AnserTypeId = 1;
                ans118.CreateDate = DateTime.Now;
                ans118.UserId = user.Id;
                ans118.AnsMonth = ansMonth;
            }





            var ans119 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 119).FirstOrDefault();
            if (ans119 == null)
            {
                //  วิธีแก้ปัญหา 5 :           
                Answer answer119 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox5.Value,
                    QuestionId = 119,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer119);

            }
            else
            {
                ans119.QuestionId = 119;
                ans119.AnsDes = this.howtoSolveTextbox5.Value;
                ans119.AnserTypeId = 1;
                ans119.CreateDate = DateTime.Now;
                ans119.UserId = user.Id;
                ans119.AnsMonth = ansMonth;
            }










            var ans120 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 120).FirstOrDefault();
            if (ans120 == null)
            {

                //  ปัญหาที่พบ 6 :           
                Answer answer120 = new Answer()
                {
                    AnsDes = this.problemTextbox6.Value,
                    QuestionId = 120,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer120);

            }
            else
            {
                ans120.QuestionId = 120;
                ans120.AnsDes = this.problemTextbox6.Value;
                ans120.AnserTypeId = 1;
                ans120.CreateDate = DateTime.Now;
                ans120.UserId = user.Id;
                ans120.AnsMonth = ansMonth;
            }







            var ans121 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 121).FirstOrDefault();
            if (ans121 == null)
            {

                //  วิธีแก้ปัญหา 6 :           
                Answer answer121 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox6.Value,
                    QuestionId = 121,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer121);

            }
            else
            {
                ans121.QuestionId = 121;
                ans121.AnsDes = this.howtoSolveTextbox6.Value;
                ans121.AnserTypeId = 1;
                ans121.CreateDate = DateTime.Now;
                ans121.UserId = user.Id;
                ans121.AnsMonth = ansMonth;
            }







            var ans122 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 122).FirstOrDefault();
            if (ans122 == null)
            {

                //  ปัญหาที่พบ 7 :           
                Answer answer122 = new Answer()
                {
                    AnsDes = this.problemTextbox7.Value,
                    QuestionId = 122,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer122);

            }
            else
            {
                ans122.QuestionId = 122;
                ans122.AnsDes = this.problemTextbox7.Value;
                ans122.AnserTypeId = 1;
                ans122.CreateDate = DateTime.Now;
                ans122.UserId = user.Id;
                ans122.AnsMonth = ansMonth;
            }








            var ans123 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 123).FirstOrDefault();
            if (ans123 == null)
            {

                //  วิธีแก้ปัญหา 7 :           
                Answer answer123 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox7.Value,
                    QuestionId = 123,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer123);

            }
            else
            {
                ans123.QuestionId = 123;
                ans123.AnsDes = this.howtoSolveTextbox7.Value;
                ans123.AnserTypeId = 1;
                ans123.CreateDate = DateTime.Now;
                ans123.UserId = user.Id;
                ans123.AnsMonth = ansMonth;
            }








            var ans124 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 124).FirstOrDefault();
            if (ans124 == null)
            {

                //  ปัญหาที่พบ 8 :           
                Answer answer124 = new Answer()
                {
                    AnsDes = this.problemTextbox8.Value,
                    QuestionId = 124,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer124);

            }
            else
            {
                ans124.QuestionId = 124;
                ans124.AnsDes = this.problemTextbox8.Value;
                ans124.AnserTypeId = 1;
                ans124.CreateDate = DateTime.Now;
                ans124.UserId = user.Id;
                ans124.AnsMonth = ansMonth;
            }




            var ans125 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 125).FirstOrDefault();
            if (ans125 == null)
            {
                //  วิธีแก้ปัญหา 8 :           
                Answer answer125 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox8.Value,
                    QuestionId = 125,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer125);

            }
            else
            {
                ans125.QuestionId = 125;
                ans125.AnsDes = this.howtoSolveTextbox8.Value;
                ans125.AnserTypeId = 1;
                ans125.CreateDate = DateTime.Now;
                ans125.UserId = user.Id;
                ans125.AnsMonth = ansMonth;
            }




            var ans126 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 126).FirstOrDefault();
            if (ans126 == null)
            {
                //  ปัญหาที่พบ 9 :           
                Answer answer126 = new Answer()
                {
                    AnsDes = this.problemTextbox9.Value,
                    QuestionId = 126,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer126);

            }
            else
            {
                ans126.QuestionId = 125;
                ans126.AnsDes = this.problemTextbox9.Value;
                ans126.AnserTypeId = 1;
                ans126.CreateDate = DateTime.Now;
                ans126.UserId = user.Id;
                ans126.AnsMonth = ansMonth;
            }



            var ans127 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 127).FirstOrDefault();
            if (ans127 == null)
            {
                //  วิธีแก้ปัญหา 9 :           
                Answer answer127 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox9.Value,
                    QuestionId = 127,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer127);

            }
            else
            {
                ans127.QuestionId = 127;
                ans127.AnsDes = this.howtoSolveTextbox9.Value;
                ans127.AnserTypeId = 1;
                ans127.CreateDate = DateTime.Now;
                ans127.UserId = user.Id;
                ans127.AnsMonth = ansMonth;
            }




            var ans128 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 128).FirstOrDefault();
            if (ans128 == null)
            {

                //  ปัญหาที่พบ 10 :           
                Answer answer128 = new Answer()
                {
                    AnsDes = this.problemTextbox10.Value,
                    QuestionId = 128,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer128);
            }
            else
            {
                ans128.QuestionId = 128;
                ans128.AnsDes = this.problemTextbox10.Value;
                ans128.AnserTypeId = 1;
                ans128.CreateDate = DateTime.Now;
                ans128.UserId = user.Id;
                ans128.AnsMonth = ansMonth;
            }





            var ans129 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 129).FirstOrDefault();
            if (ans129 == null)
            {

                //  วิธีแก้ปัญหา 10 :           
                Answer answer129 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox10.Value,
                    QuestionId = 129,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer129);
            }
            else
            {
                ans129.QuestionId = 129;
                ans129.AnsDes = this.howtoSolveTextbox10.Value;
                ans129.AnserTypeId = 1;
                ans129.CreateDate = DateTime.Now;
                ans129.UserId = user.Id;
                ans129.AnsMonth = ansMonth;
            }




            var ans130 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 130).FirstOrDefault();
            if (ans130 == null)
            {


                //  ปัญหาที่พบ 11 :           
                Answer answer130 = new Answer()
                {
                    AnsDes = this.problemTextbox11.Value,
                    QuestionId = 130,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer130);
            }
            else
            {
                ans130.QuestionId = 130;
                ans130.AnsDes = this.problemTextbox11.Value;
                ans130.AnserTypeId = 1;
                ans130.CreateDate = DateTime.Now;
                ans130.UserId = user.Id;
                ans130.AnsMonth = ansMonth;
            }





            var ans131 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 131).FirstOrDefault();
            if (ans131 == null)
            {


                //  วิธีแก้ปัญหา 11 :           
                Answer answer131 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox11.Value,
                    QuestionId = 131,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer131);
            }
            else
            {
                ans131.QuestionId = 131;
                ans131.AnsDes = this.howtoSolveTextbox11.Value;
                ans131.AnserTypeId = 1;
                ans131.CreateDate = DateTime.Now;
                ans131.UserId = user.Id;
                ans131.AnsMonth = ansMonth;
            }




            var ans132 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 132).FirstOrDefault();
            if (ans132 == null)
            {
                //  ปัญหาที่พบ 12 :           
                Answer answer132 = new Answer()
                {
                    AnsDes = this.problemTextbox12.Value,
                    QuestionId = 132,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer132);
            }
            else
            {
                ans132.QuestionId = 132;
                ans132.AnsDes = this.problemTextbox12.Value;
                ans132.AnserTypeId = 1;
                ans132.CreateDate = DateTime.Now;
                ans132.UserId = user.Id;
                ans132.AnsMonth = ansMonth;
            }







            var ans133 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 133).FirstOrDefault();
            if (ans133 == null)
            {
                //  วิธีแก้ปัญหา 12 :           
                Answer answer133 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox12.Value,
                    QuestionId = 133,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer133);
            }
            else
            {
                ans133.QuestionId = 133;
                ans133.AnsDes = this.howtoSolveTextbox12.Value;
                ans133.AnserTypeId = 1;
                ans133.CreateDate = DateTime.Now;
                ans133.UserId = user.Id;
                ans133.AnsMonth = ansMonth;



                var ans134 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 134).FirstOrDefault();
                if (ans134 == null)
                {
                    //  ปัญหาที่พบ 13 :           
                    Answer answer134 = new Answer()
                    {
                        AnsDes = this.problemTextbox13.Value,
                        QuestionId = 134,
                        AnserTypeId = 1,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer134);
                }
                else
                {
                    ans134.QuestionId = 134;
                    ans134.AnsDes = this.problemTextbox13.Value;
                    ans134.AnserTypeId = 1;
                    ans134.CreateDate = DateTime.Now;
                    ans134.UserId = user.Id;
                    ans134.AnsMonth = ansMonth;
                }



                var ans135 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 135).FirstOrDefault();
                if (ans135 == null)
                {
                    //  วิธีแก้ปัญหา 13 :           
                    Answer answer135 = new Answer()
                    {
                        AnsDes = this.howtoSolveTextbox13.Value,
                        QuestionId = 135,
                        AnserTypeId = 1,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer135);
                }
                else
                {
                    ans135.QuestionId = 135;
                    ans135.AnsDes = this.howtoSolveTextbox13.Value;
                    ans135.AnserTypeId = 1;
                    ans135.CreateDate = DateTime.Now;
                    ans135.UserId = user.Id;
                    ans135.AnsMonth = ansMonth;
                }



                var ans136 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 136).FirstOrDefault();
                if (ans136 == null)
                {
                    //  ปัญหาที่พบ 14 :           
                    Answer answer136 = new Answer()
                    {
                        AnsDes = this.problemTextbox14.Value,
                        QuestionId = 136,
                        AnserTypeId = 1,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer136);
                }
                else
                {
                    ans136.QuestionId = 136;
                    ans136.AnsDes = this.problemTextbox14.Value;
                    ans136.AnserTypeId = 1;
                    ans136.CreateDate = DateTime.Now;
                    ans136.UserId = user.Id;
                    ans135.AnsMonth = ansMonth;
                }




                var ans137 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 137).FirstOrDefault();
                if (ans137 == null)
                {
                    //  วิธีแก้ปัญหา 14 :           
                    Answer answer137 = new Answer()
                    {
                        AnsDes = this.howtoSolveTextbox14.Value,
                        QuestionId = 137,
                        AnserTypeId = 1,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer137);
                }
                else
                {
                    ans137.QuestionId = 137;
                    ans137.AnsDes = this.howtoSolveTextbox14.Value;
                    ans137.AnserTypeId = 1;
                    ans137.CreateDate = DateTime.Now;
                    ans137.UserId = user.Id;
                    ans137.AnsMonth = ansMonth;
                }


                var ans138 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 138).FirstOrDefault();
                if (ans138 == null)
                {
                    //  ปัญหาที่พบ 15 :           
                    Answer answer138 = new Answer()
                    {
                        AnsDes = this.problemTextbox15.Value,
                        QuestionId = 138,
                        AnserTypeId = 1,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer138);
                }
                else
                {
                    ans138.QuestionId = 138;
                    ans138.AnsDes = this.problemTextbox15.Value;
                    ans138.AnserTypeId = 1;
                    ans138.CreateDate = DateTime.Now;
                    ans138.UserId = user.Id;
                    ans138.AnsMonth = ansMonth;
                }


                var ans139 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 139).FirstOrDefault();
                if (ans139 == null)
                {
                    //  วิธีแก้ปัญหา 15 :           
                    Answer answer139 = new Answer()
                    {
                        AnsDes = this.howtoSolveTextbox15.Value,
                        QuestionId = 139,
                        AnserTypeId = 1,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer139);
                }
                else
                {
                    ans139.QuestionId = 139;
                    ans139.AnsDes = this.howtoSolveTextbox15.Value;
                    ans139.AnserTypeId = 1;
                    ans139.CreateDate = DateTime.Now;
                    ans139.UserId = user.Id;
                    ans139.AnsMonth = ansMonth;
                }



                var ans141 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 141).FirstOrDefault();
                if (ans141 == null)
                {
                    // รายการอุปกรณ์ 1 :      
                    Answer answer141 = new Answer()
                    {
                        AnsDes = this.toolsListTextbox1.Value,
                        QuestionId = 141,
                        AnserTypeId = 1,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer141);
                }
                else
                {
                    ans141.QuestionId = 141;
                    ans141.AnsDes = this.toolsListTextbox1.Value;
                    ans141.AnserTypeId = 1;
                    ans141.CreateDate = DateTime.Now;
                    ans141.UserId = user.Id;
                    ans141.AnsMonth = ansMonth;
                }



                var ans142 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 142).FirstOrDefault();
                if (ans142 == null)
                {
                    //  SerialNumber :           
                    Answer answer142 = new Answer()
                    {
                        AnsDes = this.serialNumberTextbox1.Value,
                        QuestionId = 142,
                        AnserTypeId = 1,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer142);
                }
                else
                {
                    ans142.QuestionId = 142;
                    ans142.AnsDes = this.serialNumberTextbox1.Value;
                    ans142.AnserTypeId = 1;
                    ans142.CreateDate = DateTime.Now;
                    ans142.UserId = user.Id;
                    ans142.AnsMonth = ansMonth;
                }


                var ans143 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 143).FirstOrDefault();
                if (ans143 == null)
                {
                    //  new SerialNumber :           
                    Answer answer143 = new Answer()
                    {
                        AnsDes = this.newSerialNumberTextbox1.Value,
                        QuestionId = 143,
                        AnserTypeId = 1,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer143);
                }
                else
                {
                    ans143.QuestionId = 143;
                    ans143.AnsDes = this.newSerialNumberTextbox1.Value;
                    ans143.AnserTypeId = 1;
                    ans143.CreateDate = DateTime.Now;
                    ans143.UserId = user.Id;
                    ans143.AnsMonth = ansMonth;
                }



                var ans144 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 144).FirstOrDefault();
                if (ans144 == null)
                {
                    //  หมายเหตุ :           
                    Answer answer144 = new Answer()
                    {
                        AnsDes = this.noteTextbox1.Value,
                        QuestionId = 144,
                        AnserTypeId = 1,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer144);
                }
                else
                {
                    ans144.QuestionId = 144;
                    ans144.AnsDes = this.noteTextbox1.Value;
                    ans144.AnserTypeId = 1;
                    ans144.CreateDate = DateTime.Now;
                    ans144.UserId = user.Id;
                    ans144.AnsMonth = ansMonth;
                }




                var ans145 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 145).FirstOrDefault();
                if (ans145 == null)
                {
                    // รายการอุปกรณ์ 2 :      
                    Answer answer145 = new Answer()
                    {
                        AnsDes = this.toolsListTextbox2.Value,
                        QuestionId = 145,
                        AnserTypeId = 1,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer145);
                }
                else
                {
                    ans145.QuestionId = 145;
                    ans145.AnsDes = this.toolsListTextbox2.Value;
                    ans145.AnserTypeId = 1;
                    ans145.CreateDate = DateTime.Now;
                    ans145.UserId = user.Id;
                    ans145.AnsMonth = ansMonth;
                }




                var ans146 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 146).FirstOrDefault();
                if (ans146 == null)
                {
                    //  SerialNumber 2 :           
                    Answer answer146 = new Answer()
                    {
                        AnsDes = this.serialNumberTextbox2.Value,
                        QuestionId = 146,
                        AnserTypeId = 1,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer146);
                }
                else
                {
                    ans146.QuestionId = 146;
                    ans146.AnsDes = this.serialNumberTextbox2.Value;
                    ans146.AnserTypeId = 1;
                    ans146.CreateDate = DateTime.Now;
                    ans146.UserId = user.Id;
                    ans146.AnsMonth = ansMonth;
                }




                var ans147 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 147).FirstOrDefault();
                if (ans147 == null)
                {
                    //  new SerialNumber 2 :           
                    Answer answer147 = new Answer()
                    {
                        AnsDes = this.newSerialNumberTextbox2.Value,
                        QuestionId = 147,
                        AnserTypeId = 1,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer147);
                }
                else
                {
                    ans147.QuestionId = 147;
                    ans147.AnsDes = this.newSerialNumberTextbox2.Value;
                    ans147.AnserTypeId = 1;
                    ans147.CreateDate = DateTime.Now;
                    ans147.UserId = user.Id;
                    ans147.AnsMonth = ansMonth;
                }

                var ans148 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 148).FirstOrDefault();
                if (ans148 == null)
                {

                    //  หมายเหตุ  2:           
                    Answer answer148 = new Answer()
                    {
                        AnsDes = this.noteTextbox2.Value,
                        QuestionId = 148,
                        AnserTypeId = 1,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer148);
                }
                else
                {
                    ans148.QuestionId = 148;
                    ans148.AnsDes = this.noteTextbox2.Value;
                    ans148.AnserTypeId = 1;
                    ans148.CreateDate = DateTime.Now;
                    ans148.UserId = user.Id;
                    ans148.AnsMonth = ansMonth;
                }



                var ans149 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 149).FirstOrDefault();
                if (ans149 == null)
                {
                    // รายการอุปกรณ์ 3 :      
                    Answer answer149 = new Answer()
                    {
                        AnsDes = this.toolsListTextbox3.Value,
                        QuestionId = 149,
                        AnserTypeId = 1,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer149);
                }
                else
                {
                    ans149.QuestionId = 149;
                    ans149.AnsDes = this.toolsListTextbox3.Value;
                    ans149.AnserTypeId = 1;
                    ans149.CreateDate = DateTime.Now;
                    ans149.UserId = user.Id;
                    ans149.AnsMonth = ansMonth;
                }




                var ans150 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 150).FirstOrDefault();
                if (ans150 == null)
                {
                    //  SerialNumber 3 :           
                    Answer answer150 = new Answer()
                    {
                        AnsDes = this.serialNumberTextbox3.Value,
                        QuestionId = 150,
                        AnserTypeId = 1,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer150);
                }
                else
                {
                    ans150.QuestionId = 150;
                    ans150.AnsDes = this.serialNumberTextbox3.Value;
                    ans150.AnserTypeId = 1;
                    ans150.CreateDate = DateTime.Now;
                    ans150.UserId = user.Id;
                    ans150.AnsMonth = ansMonth;
                }



                var ans151 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 151).FirstOrDefault();
                if (ans151 == null)
                {
                    //  new SerialNumber 3 :           
                    Answer answer151 = new Answer()
                    {
                        AnsDes = this.newSerialNumberTextbox3.Value,
                        QuestionId = 151,
                        AnserTypeId = 1,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer151);
                }
                else
                {
                    ans151.QuestionId = 151;
                    ans151.AnsDes = this.newSerialNumberTextbox3.Value;
                    ans151.AnserTypeId = 1;
                    ans151.CreateDate = DateTime.Now;
                    ans151.UserId = user.Id;
                    ans151.AnsMonth = ansMonth;
                }



                var ans152 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 151).FirstOrDefault();
                if (ans152 == null)
                {
                    //  หมายเหตุ  3:           
                    Answer answer152 = new Answer()
                    {
                        AnsDes = this.noteTextbox3.Value,
                        QuestionId = 152,
                        AnserTypeId = 1,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer152);
                }
                else
                {
                    ans152.QuestionId = 152;
                    ans152.AnsDes = this.noteTextbox3.Value;
                    ans152.AnserTypeId = 1;
                    ans152.CreateDate = DateTime.Now;
                    ans152.UserId = user.Id;
                    ans152.AnsMonth = ansMonth;
                }



                var ans153 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 153).FirstOrDefault();
                if (ans153 == null)
                {
                    // รายการอุปกรณ์ 4 :      
                    Answer answer153 = new Answer()
                    {
                        AnsDes = this.toolsListTextbox4.Value,
                        QuestionId = 153,
                        AnserTypeId = 1,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer153);
                }
                else
                {
                    ans153.QuestionId = 153;
                    ans153.AnsDes = this.toolsListTextbox4.Value;
                    ans153.AnserTypeId = 1;
                    ans153.CreateDate = DateTime.Now;
                    ans153.UserId = user.Id;
                    ans153.AnsMonth = ansMonth;
                }



                var ans154 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 154).FirstOrDefault();
                if (ans154 == null)
                {
                    //  SerialNumber 4 :           
                    Answer answer154 = new Answer()
                    {
                        AnsDes = this.serialNumberTextbox4.Value,
                        QuestionId = 154,
                        AnserTypeId = 1,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer154);
                }
                else
                {
                    ans154.QuestionId = 154;
                    ans154.AnsDes = this.serialNumberTextbox4.Value;
                    ans154.AnserTypeId = 1;
                    ans154.CreateDate = DateTime.Now;
                    ans154.UserId = user.Id;
                    ans154.AnsMonth = ansMonth;
                }




                var ans155 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 155).FirstOrDefault();
                if (ans155 == null)
                {
                    //  new SerialNumber 4 :           
                    Answer answer155 = new Answer()
                    {
                        AnsDes = this.newSerialNumberTextbox4.Value,
                        QuestionId = 155,
                        AnserTypeId = 1,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer155);
                }
                else
                {
                    ans155.QuestionId = 155;
                    ans155.AnsDes = this.newSerialNumberTextbox4.Value;
                    ans155.AnserTypeId = 1;
                    ans155.CreateDate = DateTime.Now;
                    ans155.UserId = user.Id;
                    ans155.AnsMonth = ansMonth;
                }




                var ans156 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 156).FirstOrDefault();
                if (ans156 == null)
                {
                    //  หมายเหตุ  4:           
                    Answer answer156 = new Answer()
                    {
                        AnsDes = this.noteTextbox4.Value,
                        QuestionId = 156,
                        AnserTypeId = 1,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer156);
                }
                else
                {
                    ans156.QuestionId = 156;
                    ans156.AnsDes = this.noteTextbox4.Value;
                    ans156.AnserTypeId = 1;
                    ans156.CreateDate = DateTime.Now;
                    ans156.UserId = user.Id;
                    ans156.AnsMonth = ansMonth;
                }


                var ans157 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 157).FirstOrDefault();
                if (ans157 == null)
                {

                    // รายการอุปกรณ์ 5 :      
                    Answer answer157 = new Answer()
                    {
                        AnsDes = this.toolsListTextbox5.Value,
                        QuestionId = 157,
                        AnserTypeId = 1,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer157);
                }
                else
                {
                    ans157.QuestionId = 157;
                    ans157.AnsDes = this.toolsListTextbox5.Value;
                    ans157.AnserTypeId = 1;
                    ans157.CreateDate = DateTime.Now;
                    ans157.UserId = user.Id;
                    ans157.AnsMonth = ansMonth;
                }



                var ans158 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 158).FirstOrDefault();
                if (ans158 == null)
                {
                    //  SerialNumber 5 :           
                    Answer answer158 = new Answer()
                    {
                        AnsDes = this.serialNumberTextbox5.Value,
                        QuestionId = 158,
                        AnserTypeId = 1,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer158);
                }
                else
                {
                    ans158.QuestionId = 158;
                    ans158.AnsDes = this.serialNumberTextbox5.Value;
                    ans158.AnserTypeId = 1;
                    ans158.CreateDate = DateTime.Now;
                    ans158.UserId = user.Id;
                    ans158.AnsMonth = ansMonth;
                }


                var ans159 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 159).FirstOrDefault();
                if (ans159 == null)
                {
                    //  new SerialNumber 5 :           
                    Answer answer159 = new Answer()
                    {
                        AnsDes = this.newSerialNumberTextbox5.Value,
                        QuestionId = 159,
                        AnserTypeId = 1,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer159);
                }
                else
                {
                    ans159.QuestionId = 159;
                    ans159.AnsDes = this.newSerialNumberTextbox5.Value;
                    ans159.AnserTypeId = 1;
                    ans159.CreateDate = DateTime.Now;
                    ans159.UserId = user.Id;
                    ans159.AnsMonth = ansMonth;
                }



                var ans160 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 160).FirstOrDefault();
                if (ans160 == null)
                {

                    //  หมายเหตุ  5:           
                    Answer answer160 = new Answer()
                    {
                        AnsDes = this.noteTextbox5.Value,
                        QuestionId = 160,
                        AnserTypeId = 1,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer160);
                }
                else
                {
                    ans160.QuestionId = 160;
                    ans160.AnsDes = this.noteTextbox5.Value;
                    ans160.AnserTypeId = 1;
                    ans160.CreateDate = DateTime.Now;
                    ans160.UserId = user.Id;
                    ans160.AnsMonth = ansMonth;
                }


                var ans161 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 161).FirstOrDefault();
                if (ans161 == null)
                {

                    // รายการอุปกรณ์ 6 :      
                    Answer answer161 = new Answer()
                    {
                        AnsDes = this.toolsListTextbox6.Value,
                        QuestionId = 161,
                        AnserTypeId = 1,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer161);
                }
                else
                {
                    ans161.QuestionId = 161;
                    ans161.AnsDes = this.toolsListTextbox6.Value;
                    ans161.AnserTypeId = 1;
                    ans161.CreateDate = DateTime.Now;
                    ans161.UserId = user.Id;
                    ans161.AnsMonth = ansMonth;
                }



                var ans162 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 162).FirstOrDefault();
                if (ans162 == null)
                {
                    //  SerialNumber 6 :           
                    Answer answer162 = new Answer()
                    {
                        AnsDes = this.serialNumberTextbox6.Value,
                        QuestionId = 162,
                        AnserTypeId = 1,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer162);
                }
                else
                {
                    ans162.QuestionId = 162;
                    ans162.AnsDes = this.serialNumberTextbox6.Value;
                    ans162.AnserTypeId = 1;
                    ans162.CreateDate = DateTime.Now;
                    ans162.UserId = user.Id;
                    ans162.AnsMonth = ansMonth;
                }




                var ans163 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 163).FirstOrDefault();
                if (ans163 == null)
                {
                    //  new SerialNumber 6 :           
                    Answer answer163 = new Answer()
                    {
                        AnsDes = this.newSerialNumberTextbox6.Value,
                        QuestionId = 163,
                        AnserTypeId = 1,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer163);
                }
                else
                {
                    ans163.QuestionId = 163;
                    ans163.AnsDes = this.newSerialNumberTextbox6.Value;
                    ans163.AnserTypeId = 1;
                    ans163.CreateDate = DateTime.Now;
                    ans163.UserId = user.Id;
                    ans163.AnsMonth = ansMonth;
                }



                var ans164 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 164).FirstOrDefault();
                if (ans164 == null)
                { //  หมายเหตุ  6:           
                    Answer answer164 = new Answer()
                    {
                        AnsDes = this.noteTextbox6.Value,
                        QuestionId = 164,
                        AnserTypeId = 1,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer164);
                }
                else
                {
                    ans164.QuestionId = 164;
                    ans164.AnsDes = this.noteTextbox6.Value;
                    ans164.AnserTypeId = 1;
                    ans164.CreateDate = DateTime.Now;
                    ans164.UserId = user.Id;
                    ans164.AnsMonth = ansMonth;
                }




                var ans165 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 165).FirstOrDefault();
                if (ans165 == null)
                {
                    // รายการอุปกรณ์ 7 :      
                    Answer answer165 = new Answer()
                    {
                        AnsDes = this.toolsListTextbox7.Value,
                        QuestionId = 165,
                        AnserTypeId = 1,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer165);
                }
                else
                {
                    ans165.QuestionId = 165;
                    ans165.AnsDes = this.toolsListTextbox7.Value;
                    ans165.AnserTypeId = 1;
                    ans165.CreateDate = DateTime.Now;
                    ans165.UserId = user.Id;
                    ans165.AnsMonth = ansMonth;
                }



                var ans166 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 166).FirstOrDefault();
                if (ans166 == null)
                {
                    //  SerialNumber 7 :           
                    Answer answer166 = new Answer()
                    {
                        AnsDes = this.serialNumberTextbox7.Value,
                        QuestionId = 166,
                        AnserTypeId = 1,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer166);
                }
                else
                {
                    ans166.QuestionId = 166;
                    ans166.AnsDes = this.serialNumberTextbox7.Value;
                    ans166.AnserTypeId = 1;
                    ans166.CreateDate = DateTime.Now;
                    ans166.UserId = user.Id;
                    ans166.AnsMonth = ansMonth;
                }


                var ans167 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 167).FirstOrDefault();
                if (ans167 == null)
                {
                    //  new SerialNumber 7 :           
                    Answer answer167 = new Answer()
                    {
                        AnsDes = this.newSerialNumberTextbox7.Value,
                        QuestionId = 167,
                        AnserTypeId = 1,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer167);
                }
                else
                {
                    ans167.QuestionId = 167;
                    ans167.AnsDes = this.newSerialNumberTextbox7.Value;
                    ans167.AnserTypeId = 1;
                    ans167.CreateDate = DateTime.Now;
                    ans167.UserId = user.Id;
                    ans167.AnsMonth = ansMonth;
                }


                var ans168 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 168).FirstOrDefault();
                if (ans168 == null)
                {
                    //  หมายเหตุ  7:           
                    Answer answer168 = new Answer()
                    {
                        AnsDes = this.noteTextbox7.Value,
                        QuestionId = 168,
                        AnserTypeId = 1,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer168);
                }
                else
                {
                    ans168.QuestionId = 168;
                    ans168.AnsDes = this.noteTextbox7.Value;
                    ans168.AnserTypeId = 1;
                    ans168.CreateDate = DateTime.Now;
                    ans168.UserId = user.Id;
                    ans168.AnsMonth = ansMonth;
                }


                var ans169 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 169).FirstOrDefault();
                if (ans169 == null)
                {
                    // รายการอุปกรณ์ 8 :      
                    Answer answer169 = new Answer()
                    {
                        AnsDes = this.toolsListTextbox8.Value,
                        QuestionId = 169,
                        AnserTypeId = 1,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer169);
                }
                else
                {
                    ans169.QuestionId = 169;
                    ans169.AnsDes = this.toolsListTextbox8.Value;
                    ans169.AnserTypeId = 1;
                    ans169.CreateDate = DateTime.Now;
                    ans169.UserId = user.Id;
                    ans169.AnsMonth = ansMonth;
                }







                var ans170 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 170).FirstOrDefault();
                if (ans170 == null)
                {
                    //  SerialNumber 8 :           
                    Answer answer170 = new Answer()
                    {
                        AnsDes = this.serialNumberTextbox8.Value,
                        QuestionId = 170,
                        AnserTypeId = 1,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer170);
                }
                else
                {
                    ans170.QuestionId = 170;
                    ans170.AnsDes = this.serialNumberTextbox8.Value;
                    ans170.AnserTypeId = 1;
                    ans170.CreateDate = DateTime.Now;
                    ans170.UserId = user.Id;
                    ans170.AnsMonth = ansMonth;
                }




                var ans171 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 171).FirstOrDefault();
                if (ans171 == null)
                {
                    //  new SerialNumber 8 :           
                    Answer answer171 = new Answer()
                    {
                        AnsDes = this.newSerialNumberTextbox8.Value,
                        QuestionId = 171,
                        AnserTypeId = 1,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer171);
                }
                else
                {
                    ans171.QuestionId = 171;
                    ans171.AnsDes = this.newSerialNumberTextbox8.Value;
                    ans171.AnserTypeId = 1;
                    ans171.CreateDate = DateTime.Now;
                    ans171.UserId = user.Id;
                    ans171.AnsMonth = ansMonth;
                }




                var ans172 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 172).FirstOrDefault();
                if (ans172 == null)
                {
                    //  หมายเหตุ  8:           
                    Answer answer172 = new Answer()
                    {
                        AnsDes = this.noteTextbox8.Value,
                        QuestionId = 172,
                        AnserTypeId = 1,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer172);
                }
                else
                {
                    ans172.QuestionId = 172;
                    ans172.AnsDes = this.noteTextbox8.Value;
                    ans172.AnserTypeId = 1;
                    ans172.CreateDate = DateTime.Now;
                    ans172.UserId = user.Id;
                    ans172.AnsMonth = ansMonth;
                }





                var ans173 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 173).FirstOrDefault();
                if (ans173 == null)
                {
                    // รายการอุปกรณ์ 9 :      
                    Answer answer173 = new Answer()
                    {
                        AnsDes = this.toolsListTextbox9.Value,
                        QuestionId = 173,
                        AnserTypeId = 1,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer173);
                }
                else
                {
                    ans173.QuestionId = 173;
                    ans173.AnsDes = this.toolsListTextbox9.Value;
                    ans173.AnserTypeId = 1;
                    ans173.CreateDate = DateTime.Now;
                    ans173.UserId = user.Id;
                    ans173.AnsMonth = ansMonth;
                }





                var ans174 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 174).FirstOrDefault();
                if (ans174 == null)
                {
                    //  SerialNumber 9 :           
                    Answer answer174 = new Answer()
                    {
                        AnsDes = this.serialNumberTextbox9.Value,
                        QuestionId = 174,
                        AnserTypeId = 1,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer174);
                }
                else
                {
                    ans174.QuestionId = 174;
                    ans174.AnsDes = this.serialNumberTextbox9.Value;
                    ans174.AnserTypeId = 1;
                    ans174.CreateDate = DateTime.Now;
                    ans174.UserId = user.Id;
                    ans174.AnsMonth = ansMonth;
                }


                var ans175 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 175).FirstOrDefault();
                if (ans175 == null)
                {
                    //  new SerialNumber 9 :           
                    Answer answer175 = new Answer()
                    {
                        AnsDes = this.newSerialNumberTextbox9.Value,
                        QuestionId = 175,
                        AnserTypeId = 1,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer175);
                }
                else
                {
                    ans175.QuestionId = 175;
                    ans175.AnsDes = this.newSerialNumberTextbox9.Value;
                    ans175.AnserTypeId = 1;
                    ans175.CreateDate = DateTime.Now;
                    ans175.UserId = user.Id;
                    ans175.AnsMonth = ansMonth;
                }

                var ans176 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 176).FirstOrDefault();
                if (ans176 == null)
                {
                    //  หมายเหตุ  9:           
                    Answer answer176 = new Answer()
                    {
                        AnsDes = this.noteTextbox9.Value,
                        QuestionId = 176,
                        AnserTypeId = 1,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer176);
                }
                else
                {
                    ans176.QuestionId = 176;
                    ans176.AnsDes = this.noteTextbox9.Value;
                    ans176.AnserTypeId = 1;
                    ans176.CreateDate = DateTime.Now;
                    ans176.UserId = user.Id;
                    ans176.AnsMonth = ansMonth;
                }






                var ans177 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 177).FirstOrDefault();
                if (ans177 == null)
                {
                    // รายการอุปกรณ์ 10 :      
                    Answer answer177 = new Answer()
                    {
                        AnsDes = this.toolsListTextbox10.Value,
                        QuestionId = 177,
                        AnserTypeId = 1,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer177);

                }
                else
                {
                    ans177.QuestionId = 177;
                    ans177.AnsDes = this.toolsListTextbox10.Value;
                    ans177.AnserTypeId = 1;
                    ans177.CreateDate = DateTime.Now;
                    ans177.UserId = user.Id;
                    ans177.AnsMonth = ansMonth;
                }



                var ans178 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 178).FirstOrDefault();
                if (ans178 == null)
                {
                    //  SerialNumber 10 :           
                    Answer answer178 = new Answer()
                    {
                        AnsDes = this.serialNumberTextbox10.Value,
                        QuestionId = 178,
                        AnserTypeId = 1,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer178);

                }
                else
                {
                    ans178.QuestionId = 178;
                    ans178.AnsDes = this.serialNumberTextbox10.Value;
                    ans178.AnserTypeId = 1;
                    ans178.CreateDate = DateTime.Now;
                    ans178.UserId = user.Id;
                    ans178.AnsMonth = ansMonth;
                }


                var ans179 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 179).FirstOrDefault();
                if (ans179 == null)
                {
                    //  new SerialNumber 10 :           
                    Answer answer179 = new Answer()
                    {
                        AnsDes = this.newSerialNumberTextbox10.Value,
                        QuestionId = 179,
                        AnserTypeId = 1,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer179);

                }
                else
                {
                    ans179.QuestionId = 179;
                    ans179.AnsDes = this.newSerialNumberTextbox10.Value;
                    ans179.AnserTypeId = 1;
                    ans179.CreateDate = DateTime.Now;
                    ans179.UserId = user.Id;
                    ans179.AnsMonth = ansMonth;
                }


                var ans180 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 180).FirstOrDefault();
                if (ans180 == null)
                {
                    //  หมายเหตุ  10:           
                    Answer answer180 = new Answer()
                    {
                        AnsDes = this.noteTextbox10.Value,
                        QuestionId = 180,
                        AnserTypeId = 1,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer180);

                }
                else
                {
                    ans180.QuestionId = 180;
                    ans180.AnsDes = this.noteTextbox10.Value;
                    ans180.AnserTypeId = 1;
                    ans180.CreateDate = DateTime.Now;
                    ans180.UserId = user.Id;
                    ans180.AnsMonth = ansMonth;
                }




                var ans181 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 181).FirstOrDefault();
                if (ans181 == null)
                {
                    // รายการอุปกรณ์ 11 :      
                    Answer answer181 = new Answer()
                    {
                        AnsDes = this.toolsListTextbox11.Value,
                        QuestionId = 181,
                        AnserTypeId = 1,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer181);

                }
                else
                {
                    ans181.QuestionId = 181;
                    ans181.AnsDes = this.toolsListTextbox11.Value;
                    ans181.AnserTypeId = 1;
                    ans181.CreateDate = DateTime.Now;
                    ans181.UserId = user.Id;
                    ans181.AnsMonth = ansMonth;
                }




                var ans182 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 182).FirstOrDefault();
                if (ans182 == null)
                {
                    //  SerialNumber 11 :           
                    Answer answer182 = new Answer()
                    {
                        AnsDes = this.serialNumberTextbox11.Value,
                        QuestionId = 182,
                        AnserTypeId = 1,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer182);

                }
                else
                {
                    ans182.QuestionId = 182;
                    ans182.AnsDes = this.serialNumberTextbox11.Value;
                    ans182.AnserTypeId = 1;
                    ans182.CreateDate = DateTime.Now;
                    ans182.UserId = user.Id;
                    ans182.AnsMonth = ansMonth;
                }





                var ans183 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 183).FirstOrDefault();
                if (ans183 == null)
                {
                    //  new SerialNumber 11 :           
                    Answer answer183 = new Answer()
                    {
                        AnsDes = this.newSerialNumberTextbox11.Value,
                        QuestionId = 183,
                        AnserTypeId = 1,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer183);

                }
                else
                {
                    ans183.QuestionId = 183;
                    ans183.AnsDes = this.newSerialNumberTextbox11.Value;
                    ans183.AnserTypeId = 1;
                    ans183.CreateDate = DateTime.Now;
                    ans183.UserId = user.Id;
                    ans183.AnsMonth = ansMonth;
                }






                var ans184 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 184).FirstOrDefault();
                if (ans184 == null)
                {
                    //  หมายเหตุ  11:           
                    Answer answer184 = new Answer()
                    {
                        AnsDes = this.noteTextbox11.Value,
                        QuestionId = 184,
                        AnserTypeId = 1,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer184);

                }
                else
                {
                    ans184.QuestionId = 184;
                    ans184.AnsDes = this.noteTextbox11.Value;
                    ans184.AnserTypeId = 1;
                    ans184.CreateDate = DateTime.Now;
                    ans184.UserId = user.Id;
                    ans184.AnsMonth = ansMonth;
                }







                var ans185 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 185).FirstOrDefault();
                if (ans185 == null)
                {

                    // รายการอุปกรณ์ 12 :      
                    Answer answer185 = new Answer()
                    {
                        AnsDes = this.toolsListTextbox12.Value,
                        QuestionId = 185,
                        AnserTypeId = 1,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer185);

                }
                else
                {
                    ans185.QuestionId = 185;
                    ans185.AnsDes = this.toolsListTextbox12.Value;
                    ans185.AnserTypeId = 1;
                    ans185.CreateDate = DateTime.Now;
                    ans185.UserId = user.Id;
                    ans185.AnsMonth = ansMonth;
                }




                var ans186 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 186).FirstOrDefault();
                if (ans186 == null)
                {

                    //  SerialNumber 12 :           
                    Answer answer186 = new Answer()
                    {
                        AnsDes = this.serialNumberTextbox12.Value,
                        QuestionId = 186,
                        AnserTypeId = 1,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer186);

                }
                else
                {
                    ans186.QuestionId = 186;
                    ans186.AnsDes = this.serialNumberTextbox12.Value;
                    ans186.AnserTypeId = 1;
                    ans186.CreateDate = DateTime.Now;
                    ans186.UserId = user.Id;
                    ans186.AnsMonth = ansMonth;
                }

                var ans187 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 187).FirstOrDefault();
                if (ans187 == null)
                {

                    //  new SerialNumber 12 :           
                    Answer answer187 = new Answer()
                    {
                        AnsDes = this.newSerialNumberTextbox12.Value,
                        QuestionId = 187,
                        AnserTypeId = 1,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer187);

                }
                else
                {
                    ans187.QuestionId = 187;
                    ans187.AnsDes = this.newSerialNumberTextbox12.Value;
                    ans187.AnserTypeId = 1;
                    ans187.CreateDate = DateTime.Now;
                    ans187.UserId = user.Id;
                    ans187.AnsMonth = ansMonth;
                }





                var ans188 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 188).FirstOrDefault();
                if (ans188 == null)
                {

                    //  หมายเหตุ  12:           
                    Answer answer188 = new Answer()
                    {
                        AnsDes = this.noteTextbox12.Value,
                        QuestionId = 188,
                        AnserTypeId = 1,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer188);

                }
                else
                {
                    ans188.QuestionId = 188;
                    ans188.AnsDes = this.noteTextbox12.Value;
                    ans188.AnserTypeId = 1;
                    ans188.CreateDate = DateTime.Now;
                    ans188.UserId = user.Id;
                    ans188.AnsMonth = ansMonth;
                }






                var ans189 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 189).FirstOrDefault();
                if (ans189 == null)
                {

                    // รายการอุปกรณ์ 13 :      
                    Answer answer189 = new Answer()
                    {
                        AnsDes = this.toolsListTextbox13.Value,
                        QuestionId = 189,
                        AnserTypeId = 1,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer189);

                }
                else
                {
                    ans189.QuestionId = 189;
                    ans189.AnsDes = this.toolsListTextbox13.Value;
                    ans189.AnserTypeId = 1;
                    ans189.CreateDate = DateTime.Now;
                    ans189.UserId = user.Id;
                    ans189.AnsMonth = ansMonth;
                }



                var ans190 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 190).FirstOrDefault();
                if (ans190 == null)
                {

                    //  SerialNumber 13 :           
                    Answer answer190 = new Answer()
                    {
                        AnsDes = this.serialNumberTextbox13.Value,
                        QuestionId = 190,
                        AnserTypeId = 1,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer190);

                }
                else
                {
                    ans190.QuestionId = 190;
                    ans190.AnsDes = this.serialNumberTextbox13.Value;
                    ans190.AnserTypeId = 1;
                    ans190.CreateDate = DateTime.Now;
                    ans190.UserId = user.Id;
                    ans190.AnsMonth = ansMonth;
                }



                var ans191 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 191).FirstOrDefault();
                if (ans191 == null)
                {

                    //  new SerialNumber 13 :           
                    Answer answer191 = new Answer()
                    {
                        AnsDes = this.newSerialNumberTextbox13.Value,
                        QuestionId = 191,
                        AnserTypeId = 1,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer191);

                }
                else
                {
                    ans191.QuestionId = 191;
                    ans191.AnsDes = this.newSerialNumberTextbox13.Value;
                    ans191.AnserTypeId = 1;
                    ans191.CreateDate = DateTime.Now;
                    ans191.UserId = user.Id;
                    ans191.AnsMonth = ansMonth;
                }

                var ans192 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 192).FirstOrDefault();
                if (ans192 == null)
                {

                    //  หมายเหตุ  13   :    
                    Answer answer192 = new Answer()
                    {
                        AnsDes = this.noteTextbox13.Value,
                        QuestionId = 192,
                        AnserTypeId = 1,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer192);

                }
                else
                {
                    ans192.QuestionId = 192;
                    ans192.AnsDes = this.noteTextbox13.Value;
                    ans192.AnserTypeId = 1;
                    ans192.CreateDate = DateTime.Now;
                    ans192.UserId = user.Id;
                    ans192.AnsMonth = ansMonth;
                }


                var ans193 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 193).FirstOrDefault();
                if (ans193 == null)
                {

                    // รายการอุปกรณ์ 14 :      
                    Answer answer193 = new Answer()
                    {
                        AnsDes = this.toolsListTextbox14.Value,
                        QuestionId = 193,
                        AnserTypeId = 1,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer193);

                }
                else
                {
                    ans193.QuestionId = 193;
                    ans193.AnsDes = this.toolsListTextbox14.Value;
                    ans193.AnserTypeId = 1;
                    ans193.CreateDate = DateTime.Now;
                    ans193.UserId = user.Id;
                    ans193.AnsMonth = ansMonth;
                }




                var ans194 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 194).FirstOrDefault();
                if (ans194 == null)
                {
                   //  SerialNumber 14 :           
                    Answer answer194 = new Answer()
                    {
                        AnsDes = this.serialNumberTextbox14.Value,
                        QuestionId = 194,
                        AnserTypeId = 1,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer194);


                }
                else
                {
                    ans194.QuestionId = 194;
                    ans194.AnsDes = this.serialNumberTextbox14.Value;
                    ans194.AnserTypeId = 1;
                    ans194.CreateDate = DateTime.Now;
                    ans194.UserId = user.Id;
                    ans194.AnsMonth = ansMonth;
                }




                var ans195 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 195).FirstOrDefault();
                if (ans195 == null)
                {
                    //  new SerialNumber 14 :           
                    Answer answer195 = new Answer()
                    {
                        AnsDes = this.newSerialNumberTextbox14.Value,
                        QuestionId = 195,
                        AnserTypeId = 1,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer195);
                }
                else
                {
                    ans195.QuestionId = 195;
                    ans195.AnsDes = this.newSerialNumberTextbox14.Value;
                    ans195.AnserTypeId = 1;
                    ans195.CreateDate = DateTime.Now;
                    ans195.UserId = user.Id;
                    ans195.AnsMonth = ansMonth;
                }



                var ans196 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 196).FirstOrDefault();
                if (ans196 == null)
                {
                    //  หมายเหตุ  143   :    
                    Answer answer196 = new Answer()
                    {
                        AnsDes = this.noteTextbox14.Value,
                        QuestionId = 196,
                        AnserTypeId = 1,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer196);
                }
                else
                {
                    ans196.QuestionId = 196;
                    ans196.AnsDes = this.noteTextbox14.Value;
                    ans196.AnserTypeId = 1;
                    ans196.CreateDate = DateTime.Now;
                    ans196.UserId = user.Id;
                    ans196.AnsMonth = ansMonth;
                }

                var ans197 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 197).FirstOrDefault();
                if (ans197 == null)
                {
                    // รายการอุปกรณ์ 15 :      
                    Answer answer197 = new Answer()
                    {
                        AnsDes = this.toolsListTextbox15.Value,
                        QuestionId = 197,
                        AnserTypeId = 1,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer197);
                }
                else
                {
                    ans197.QuestionId = 197;
                    ans197.AnsDes = this.toolsListTextbox15.Value;
                    ans197.AnserTypeId = 1;
                    ans197.CreateDate = DateTime.Now;
                    ans197.UserId = user.Id;
                    ans197.AnsMonth = ansMonth;
                }



                var ans198 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 198).FirstOrDefault();
                if (ans198 == null)
                {
                    //  SerialNumber 15 :           
                    Answer answer198 = new Answer()
                    {
                        AnsDes = this.serialNumberTextbox15.Value,
                        QuestionId = 198,
                        AnserTypeId = 1,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer198);
                }
                else
                {
                    ans198.QuestionId = 198;
                    ans198.AnsDes = this.serialNumberTextbox15.Value;
                    ans198.AnserTypeId = 1;
                    ans198.CreateDate = DateTime.Now;
                    ans198.UserId = user.Id;
                    ans198.AnsMonth = ansMonth;
                }


                var ans199 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 199).FirstOrDefault();
                if (ans199 == null)
                {
                    //  new SerialNumber 15 :           
                    Answer answer199 = new Answer()
                    {
                        AnsDes = this.newSerialNumberTextbox15.Value,
                        QuestionId = 199,
                        AnserTypeId = 1,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer199);
                }
                else
                {
                    ans199.QuestionId = 199;
                    ans199.AnsDes = this.newSerialNumberTextbox15.Value;
                    ans199.AnserTypeId = 1;
                    ans199.CreateDate = DateTime.Now;
                    ans199.UserId = user.Id;
                    ans199.AnsMonth = ansMonth;
                }




                var ans200 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 200).FirstOrDefault();
                if (ans200 == null)
                {
                    //  หมายเหตุ  15   :    
                    Answer answer200 = new Answer()
                    {
                        AnsDes = this.noteTextbox15.Value,
                        QuestionId = 200,
                        AnserTypeId = 1,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer200);
                }
                else
                {
                    ans200.QuestionId = 200;
                    ans200.AnsDes = this.noteTextbox15.Value;
                    ans200.AnserTypeId = 1;
                    ans200.CreateDate = DateTime.Now;
                    ans200.UserId = user.Id;
                    ans200.AnsMonth = ansMonth;
                }




                var ans201 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 201).FirstOrDefault();
                if (ans201 == null)
                {
                    // team name :    
                    Answer answer201 = new Answer()
                    {
                        AnsDes = this.nameTeampmTextbox.Value,
                        QuestionId = 201,
                        AnserTypeId = 1,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer201);
                }
                else
                {
                    ans201.QuestionId = 201;
                    ans201.AnsDes = this.nameTeampmTextbox.Value;
                    ans201.AnserTypeId = 1;
                    ans201.CreateDate = DateTime.Now;
                    ans201.UserId = user.Id;
                    ans201.AnsMonth = ansMonth;
                }

                var ans202 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 202).FirstOrDefault();
                if (ans202 == null)
                {
                    // วันที่ทำ PM :    
                    Answer answer202 = new Answer()
                    {
                        AnsDes = this.dayDopmTextbox.Value,
                        QuestionId = 202,
                        AnserTypeId = 1,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer202);
                }
                else
                {
                    ans202.QuestionId = 202;
                    ans202.AnsDes = this.dayDopmTextbox.Value;
                    ans202.AnserTypeId = 1;
                    ans202.CreateDate = DateTime.Now;
                    ans202.UserId = user.Id;
                    ans202.AnsMonth = ansMonth;
                }


                var ans203 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 203).FirstOrDefault();
                if (ans203 == null)
                {
                    // ชื่อเจ้าหน้าที่ประจำศูนย์ :    
                    Answer answer203 = new Answer()
                    {
                        AnsDes = this.nameAgentareaTextbox.Value,
                        QuestionId = 203,
                        AnserTypeId = 1,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer203);
                }
                else
                {
                    ans203.QuestionId = 203;
                    ans203.AnsDes = this.nameAgentareaTextbox.Value;
                    ans203.AnserTypeId = 1;
                    ans203.CreateDate = DateTime.Now;
                    ans203.UserId = user.Id;
                    ans203.AnsMonth = ansMonth;
                }




                var ans204 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 204).FirstOrDefault();
                if (ans204 == null)
                {
                    // เบอร์โทรติดต่อ :    
                    Answer answer204 = new Answer()
                    {
                        AnsDes = this.telephoneAgentTextbox.Value,
                        QuestionId = 204,
                        AnserTypeId = 1,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer204);
                }
                else
                {
                    ans204.QuestionId = 204;
                    ans204.AnsDes = this.telephoneAgentTextbox.Value;
                    ans204.AnserTypeId = 1;
                    ans204.CreateDate = DateTime.Now;
                    ans204.UserId = user.Id;
                    ans204.AnsMonth = ansMonth;
                }




                var ans205 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 205).FirstOrDefault();
                if (ans205 == null)
                {
                    // รูปภาพป้ายชื่อโรงเรียน  :
                    string billBoardSchool = Request.Form["billBoardSchoolRadio"];
                    Answer answer205 = new Answer()
                    {
                        AnsDes = billBoardSchool,
                        QuestionId = 205,
                        AnserTypeId = 3,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer205);
                }
                else
                {
                    string billBoardSchool = Request.Form["billBoardSchoolRadio"];
                    ans205.QuestionId = 205;
                    ans205.AnsDes = billBoardSchool;
                    ans205.AnserTypeId = 1;
                    ans205.CreateDate = DateTime.Now;
                    ans205.UserId = user.Id;
                    ans205.AnsMonth = ansMonth;
                }




                var ans206 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 206).FirstOrDefault();
                if (ans206 == null)
                {
                    // รูปภาพด้านหน้าศูนย์ (ถ่ายคู่กับ จนท.ประจำศูนย์)  :
                    string picTuragent = Request.Form["pictureWithagentRadio"];
                    Answer answer206 = new Answer()
                    {
                        AnsDes = picTuragent,
                        QuestionId = 206,
                        AnserTypeId = 3,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer206);
                }
                else
                {
                    string billBoardSchool = Request.Form["pictureWithagentRadio"];
                    ans206.QuestionId = 206;
                    ans206.AnsDes = billBoardSchool;
                    ans206.AnserTypeId = 1;
                    ans206.CreateDate = DateTime.Now;
                    ans206.UserId = user.Id;
                    ans206.AnsMonth = ansMonth;
                }



                var ans207 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 207).FirstOrDefault();
                if (ans207 == null)
                {
                    // รูปภาพด้านหลังศูนย์ :
                    string behinddHall = Request.Form["pictureBehindHallRadio"];
                    Answer answer207 = new Answer()
                    {
                        AnsDes = behinddHall,
                        QuestionId = 207,
                        AnserTypeId = 3,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer207);
                }
                else
                {
                    string billBoardSchool = Request.Form["pictureBehindHallRadio"];
                    ans207.QuestionId = 207;
                    ans207.AnsDes = billBoardSchool;
                    ans207.AnserTypeId = 1;
                    ans207.CreateDate = DateTime.Now;
                    ans207.UserId = user.Id;
                    ans207.AnsMonth = ansMonth;
                }



                var ans208 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 208).FirstOrDefault();
                if (ans208 == null)
                {
                    // รูปภาพบริเวณห้องโถง :
                    string picInhall = Request.Form["picInlobbyRadio"];
                    Answer answer208 = new Answer()
                    {
                        AnsDes = picInhall,
                        QuestionId = 208,
                        AnserTypeId = 3,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer208);
                }
                else
                {
                    string billBoardSchool = Request.Form["picInlobbyRadio"];
                    ans208.QuestionId = 208;
                    ans208.AnsDes = billBoardSchool;
                    ans208.AnserTypeId = 1;
                    ans208.CreateDate = DateTime.Now;
                    ans208.UserId = user.Id;
                    ans208.AnsMonth = ansMonth;
                }



                var ans209 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 209).FirstOrDefault();
                if (ans209 == null)
                {
                    // รูปภาพบริเวณห้องประชุม :
                    string picMett = Request.Form["picinMeetingroomRadio"];
                    Answer answer209 = new Answer()
                    {
                        AnsDes = picMett,
                        QuestionId = 209,
                        AnserTypeId = 3,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer209);
                }
                else
                {
                    string billBoardSchool = Request.Form["picinMeetingroomRadio"];
                    ans209.QuestionId = 209;
                    ans209.AnsDes = billBoardSchool;
                    ans209.AnserTypeId = 1;
                    ans209.CreateDate = DateTime.Now;
                    ans209.UserId = user.Id;
                    ans209.AnsMonth = ansMonth;
                }


                var ans210 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 210).FirstOrDefault();
                if (ans210 == null)
                {
                    // รูปภาพบริเวณห้อง Server :
                    string picinserVer = Request.Form["picInserverRadio"];
                    Answer answer210 = new Answer()
                    {
                        AnsDes = picinserVer,
                        QuestionId = 210,
                        AnserTypeId = 3,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer210);
                }
                else
                {
                    string billBoardSchool = Request.Form["picInserverRadio"];
                    ans210.QuestionId = 210;
                    ans210.AnsDes = billBoardSchool;
                    ans210.AnserTypeId = 1;
                    ans210.CreateDate = DateTime.Now;
                    ans210.UserId = user.Id;
                    ans210.AnsMonth = ansMonth;
                }





                var ans211 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 211).FirstOrDefault();
                if (ans211 == null)
                {
                    // รูปภาพบริเวณห้องน้ำ :
                    string picIntoileteiei = Request.Form["picIntoiletRadio"];
                    Answer answer211 = new Answer()
                    {
                        AnsDes = picIntoileteiei,
                        QuestionId = 211,
                        AnserTypeId = 3,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer211);
                }
                else
                {
                    string billBoardSchool = Request.Form["picIntoiletRadio"];
                    ans211.QuestionId = 211;
                    ans211.AnsDes = billBoardSchool;
                    ans211.AnserTypeId = 1;
                    ans211.CreateDate = DateTime.Now;
                    ans211.UserId = user.Id;
                    ans211.AnsMonth = ansMonth;
                }






                var ans212 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 212).FirstOrDefault();
                if (ans212 == null)
                {
                    // รูปภาพบริเวณห้องปั๊มน้ำ  :
                    string picinWaterpump = Request.Form["pictureInwaterpumpRadio"];
                    Answer answer212 = new Answer()
                    {
                        AnsDes = picinWaterpump,
                        QuestionId = 212,
                        AnserTypeId = 3,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer212);
                }
                else
                {
                    string billBoardSchool = Request.Form["pictureInwaterpumpRadio"];
                    ans212.QuestionId = 212;
                    ans212.AnsDes = billBoardSchool;
                    ans212.AnserTypeId = 1;
                    ans212.CreateDate = DateTime.Now;
                    ans212.UserId = user.Id;
                    ans212.AnsMonth = ansMonth;
                }




                var ans213 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 213).FirstOrDefault();
                if (ans213 == null)
                {
                    // รูป PEA Meter  :
                    string picMeter = Request.Form["picpeaMeterRadio"];
                    Answer answer213 = new Answer()
                    {
                        AnsDes = picMeter,
                        QuestionId = 213,
                        AnserTypeId = 3,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer213);
                }
                else
                {
                    string billBoardSchool = Request.Form["picpeaMeterRadio"];
                    ans213.QuestionId = 213;
                    ans213.AnsDes = billBoardSchool;
                    ans213.AnserTypeId = 1;
                    ans213.CreateDate = DateTime.Now;
                    ans213.UserId = user.Id;
                    ans213.AnsMonth = ansMonth;
                }











                var ans214 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 214).FirstOrDefault();
                if (ans214 == null)
                {
                    // รูป PEA Meter  :
                    string acPic = Request.Form["acPicRadio"];
                    Answer answer214 = new Answer()
                    {
                        AnsDes = acPic,
                        QuestionId = 214,
                        AnserTypeId = 3,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer214);
                }
                else
                {
                    string billBoardSchool = Request.Form["acPicRadio"];
                    ans214.QuestionId = 214;
                    ans214.AnsDes = billBoardSchool;
                    ans214.AnserTypeId = 1;
                    ans214.CreateDate = DateTime.Now;
                    ans214.UserId = user.Id;
                    ans214.AnsMonth = ansMonth;
                }








                var ans215 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 215).FirstOrDefault();
                if (ans215 == null)
                {
                    // รูป PEA Meter  :
                    string recGroundBar = Request.Form["recGroundBargroundRadio"];
                    Answer answer215 = new Answer()
                    {
                        AnsDes = recGroundBar,
                        QuestionId = 215,
                        AnserTypeId = 3,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer215);
                }
                else
                {
                    string billBoardSchool = Request.Form["recGroundBargroundRadio"];
                    ans215.QuestionId = 215;
                    ans215.AnsDes = billBoardSchool;
                    ans215.AnserTypeId = 1;
                    ans215.CreateDate = DateTime.Now;
                    ans215.UserId = user.Id;
                    ans215.AnsMonth = ansMonth;
                }






                var ans216 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 216).FirstOrDefault();
                if (ans216 == null)
                {
                    // รูปการตรวจสอบสถานะไฟฟ้ารั่วลง Ground (Lamp Test)   :
                    string lightleak = Request.Form["lightleakRadio"];
                    Answer answer216 = new Answer()
                    {
                        AnsDes = lightleak,
                        QuestionId = 216,
                        AnserTypeId = 3,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer216);
                }
                else
                {
                    string billBoardSchool = Request.Form["lightleakRadio"];
                    ans216.QuestionId = 216;
                    ans216.AnsDes = billBoardSchool;
                    ans216.AnserTypeId = 1;
                    ans216.CreateDate = DateTime.Now;
                    ans216.UserId = user.Id;
                    ans216.AnsMonth = ansMonth;
                }




                var ans217 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 217).FirstOrDefault();
                if (ans217 == null)
                {
                    // รูป MDB  :
                    string mdbPic = Request.Form["mdbPicRadio"];
                    Answer answer217 = new Answer()
                    {
                        AnsDes = mdbPic,
                        QuestionId = 217,
                        AnserTypeId = 3,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer217);
                }
                else
                {
                    string billBoardSchool = Request.Form["mdbPicRadio"];
                    ans217.QuestionId = 217;
                    ans217.AnsDes = billBoardSchool;
                    ans217.AnserTypeId = 1;
                    ans217.CreateDate = DateTime.Now;
                    ans217.UserId = user.Id;
                    ans217.AnsMonth = ansMonth;
                }




                var ans218 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 218).FirstOrDefault();
                if (ans218 == null)
                {
                    // รูป Fire Alarm Control  :
                    string picFilealarm = Request.Form["picFilealarmRadio"];
                    Answer answer218 = new Answer()
                    {
                        AnsDes = picFilealarm,
                        QuestionId = 218,
                        AnserTypeId = 3,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer218);
                }
                else
                {
                    string billBoardSchool = Request.Form["picFilealarmRadio"];
                    ans218.QuestionId = 218;
                    ans218.AnsDes = billBoardSchool;
                    ans218.AnserTypeId = 1;
                    ans218.CreateDate = DateTime.Now;
                    ans218.UserId = user.Id;
                    ans218.AnsMonth = ansMonth;
                }



                var ans219 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 219).FirstOrDefault();
                if (ans219 == null)
                {
                    // รูปภาพรวมอุปกรณ์ทั้งหมดภายในตู้ Rack  :
                    string alltoolsInrack = Request.Form["alltoolsInrackRadio"];
                    Answer answer219 = new Answer()
                    {
                        AnsDes = alltoolsInrack,
                        QuestionId = 219,
                        AnserTypeId = 3,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer219);
                }
                else
                {
                    string billBoardSchool = Request.Form["alltoolsInrackRadio"];
                    ans219.QuestionId = 219;
                    ans219.AnsDes = billBoardSchool;
                    ans219.AnserTypeId = 1;
                    ans219.CreateDate = DateTime.Now;
                    ans219.UserId = user.Id;
                    ans219.AnsMonth = ansMonth;
                }


                var ans220 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 220).FirstOrDefault();
                if (ans220 == null)
                {
                    // รูปหน้าจอ UPS แสดงค่าต่างๆ และ Serial NO. :
                    string upsAndserial = Request.Form["upsAndserialRadio"];
                    Answer answer220 = new Answer()
                    {
                        AnsDes = upsAndserial,
                        QuestionId = 220,
                        AnserTypeId = 3,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer220);
                }
                else
                {
                    string billBoardSchool = Request.Form["upsAndserialRadio"];
                    ans220.QuestionId = 220;
                    ans220.AnsDes = billBoardSchool;
                    ans220.AnserTypeId = 1;
                    ans220.CreateDate = DateTime.Now;
                    ans220.UserId = user.Id;
                    ans220.AnsMonth = ansMonth;
                }




                var ans221 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 221).FirstOrDefault();
                if (ans221 == null)
                {
                    // รูป ONU/Modem พร้อม Serial NO. และ MAC. :
                    string picOnu = Request.Form["picOnuRadio"];
                    Answer answer221 = new Answer()
                    {
                        AnsDes = picOnu,
                        QuestionId = 221,
                        AnserTypeId = 3,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer221);
                }
                else
                {
                    string billBoardSchool = Request.Form["picOnuRadio"];
                    ans221.QuestionId = 221;
                    ans221.AnsDes = billBoardSchool;
                    ans221.AnserTypeId = 1;
                    ans221.CreateDate = DateTime.Now;
                    ans221.UserId = user.Id;
                    ans221.AnsMonth = ansMonth;
                }




                var ans222 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 222).FirstOrDefault();
                if (ans222 == null)
                {
                    // รูป Power Supply พร้อม Serial NO :
                    string picPsu = Request.Form["picPsuRadio"];
                    Answer answer222 = new Answer()
                    {
                        AnsDes = picPsu,
                        QuestionId = 222,
                        AnserTypeId = 3,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer222);
                }
                else
                {
                    string billBoardSchool = Request.Form["picPsuRadio"];
                    ans222.QuestionId = 222;
                    ans222.AnsDes = billBoardSchool;
                    ans222.AnserTypeId = 1;
                    ans222.CreateDate = DateTime.Now;
                    ans222.UserId = user.Id;
                    ans222.AnsMonth = ansMonth;
                }




                var ans223 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 222).FirstOrDefault();
                if (ans223 == null)
                {
                    // รูป Power Supply พร้อม Serial NO :
                    string picSwitch = Request.Form["picSwitchRadio"];
                    Answer answer223 = new Answer()
                    {
                        AnsDes = picSwitch,
                        QuestionId = 223,
                        AnserTypeId = 3,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer223);
                }
                else
                {
                    string billBoardSchool = Request.Form["picSwitchRadio"];
                    ans223.QuestionId = 223;
                    ans223.AnsDes = billBoardSchool;
                    ans223.AnserTypeId = 1;
                    ans223.CreateDate = DateTime.Now;
                    ans223.UserId = user.Id;
                    ans223.AnsMonth = ansMonth;
                }





                var ans224 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 224).FirstOrDefault();
                if (ans224 == null)
                {
                    // รูป Switch 48 Port พร้อม Serial NO. และ MAC:
                    string picSwitch48 = Request.Form["picSwitch48Radio"];
                    Answer answer224 = new Answer()
                    {
                        AnsDes = picSwitch48,
                        QuestionId = 224,
                        AnserTypeId = 3,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer224);
                }
                else
                {
                    string billBoardSchool = Request.Form["picSwitch48Radio"];
                    ans224.QuestionId = 224;
                    ans224.AnsDes = billBoardSchool;
                    ans224.AnserTypeId = 1;
                    ans224.CreateDate = DateTime.Now;
                    ans224.UserId = user.Id;
                    ans224.AnsMonth = ansMonth;
                }





                var ans225 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 225).FirstOrDefault();
                if (ans225 == null)
                {
                    // รูป Outdoor AP ทั้ง 2 จุด พร้อม Serial NO. และ MAC :
                    string picOutdoor = Request.Form["picOutdoorRadio"];
                    Answer answer225 = new Answer()
                    {
                        AnsDes = picOutdoor,
                        QuestionId = 225,
                        AnserTypeId = 3,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer225);
                }
                else
                {
                    string billBoardSchool = Request.Form["picOutdoorRadio"];
                    ans225.QuestionId = 225;
                    ans225.AnsDes = billBoardSchool;
                    ans225.AnserTypeId = 1;
                    ans225.CreateDate = DateTime.Now;
                    ans225.UserId = user.Id;
                    ans225.AnsMonth = ansMonth;
                }




                var ans226 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 226).FirstOrDefault();
                if (ans226 == null)
                {
                    // รูป Indoor AP ทั้ง 2 จุด พร้อม Serial NO. และ MAC:
                    string picIndoortwoway = Request.Form["picIndoortwowayRadio"];
                    Answer answer226 = new Answer()
                    {
                        AnsDes = picIndoortwoway,
                        QuestionId = 226,
                        AnserTypeId = 3,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer226);
                }
                else
                {
                    string billBoardSchool = Request.Form["picIndoortwowayRadio"];
                    ans226.QuestionId = 226;
                    ans226.AnsDes = billBoardSchool;
                    ans226.AnserTypeId = 1;
                    ans226.CreateDate = DateTime.Now;
                    ans226.UserId = user.Id;
                    ans226.AnsMonth = ansMonth;
                }







                var ans227 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 227).FirstOrDefault();
                if (ans227 == null)
                {
                    // รูปการ Test Speed จาก App Nperf โดยใช้ WIFI :
                    string picspeedTest = Request.Form["picspeedTestRadio"];
                    Answer answer227 = new Answer()
                    {
                        AnsDes = picspeedTest,
                        QuestionId = 227,
                        AnserTypeId = 3,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer227);
                }
                else
                {
                    string billBoardSchool = Request.Form["picspeedTestRadio"];
                    ans227.QuestionId = 227;
                    ans227.AnsDes = billBoardSchool;
                    ans227.AnserTypeId = 1;
                    ans227.CreateDate = DateTime.Now;
                    ans227.UserId = user.Id;
                    ans227.AnsMonth = ansMonth;
                }








                var ans228 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 228).FirstOrDefault();
                if (ans228 == null)
                {
                    // รูปการ Test Speed จาก App Nperf โดยใช้ LAN :
                    string picspeedTestwithLan = Request.Form["picspeedTestwithLanRadio"];
                    Answer answer228 = new Answer()
                    {
                        AnsDes = picspeedTestwithLan,
                        QuestionId = 228,
                        AnserTypeId = 3,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer228);
                }
                else
                {
                    string billBoardSchool = Request.Form["picspeedTestwithLanRadio"];
                    ans228.QuestionId = 228;
                    ans228.AnsDes = billBoardSchool;
                    ans228.AnserTypeId = 1;
                    ans228.CreateDate = DateTime.Now;
                    ans228.UserId = user.Id;
                    ans228.AnsMonth = ansMonth;
                }





                var ans229 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 229).FirstOrDefault();
                if (ans229 == null)
                {
                    // รูป ก่อน-หลัง การทำความสะอาดรางระบายน้ำ :
                    string picbeforeAftercanel = Request.Form["picbeforeAftercanelRadio"];
                    Answer answer229 = new Answer()
                    {
                        AnsDes = picbeforeAftercanel,
                        QuestionId = 229,
                        AnserTypeId = 3,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer229);
                }
                else
                {
                    string billBoardSchool = Request.Form["picbeforeAftercanelRadio"];
                    ans229.QuestionId = 229;
                    ans229.AnsDes = billBoardSchool;
                    ans229.AnserTypeId = 1;
                    ans229.CreateDate = DateTime.Now;
                    ans229.UserId = user.Id;
                    ans229.AnsMonth = ansMonth;
                }



                var ans230 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 230).FirstOrDefault();
                if (ans230 == null)
                {
                    // รูปหน้าจอ Monitor กล้องวงจรปิดผ่านจอทีวีในห้องประชุม :
                    string picMonitor = Request.Form["picMonitorRadio"];
                    Answer answer230 = new Answer()
                    {
                        AnsDes = picMonitor,
                        QuestionId = 230,
                        AnserTypeId = 3,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer230);
                }
                else
                {
                    string billBoardSchool = Request.Form["picMonitorRadio"];
                    ans230.QuestionId = 230;
                    ans230.AnsDes = billBoardSchool;
                    ans230.AnserTypeId = 1;
                    ans230.CreateDate = DateTime.Now;
                    ans230.UserId = user.Id;
                    ans230.AnsMonth = ansMonth;
                }



                var ans231 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 231).FirstOrDefault();
                if (ans231 == null)
                {
                    // รูปภาพก่อน-หลัง การทำความสะอาดแอร์ห้องโถง  :
                    string beforeArterairClean = Request.Form["beforeArterairCleanRadio"];
                    Answer answer231 = new Answer()
                    {
                        AnsDes = beforeArterairClean,
                        QuestionId = 231,
                        AnserTypeId = 3,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer231);
                }
                else
                {
                    string billBoardSchool = Request.Form["beforeArterairCleanRadio"];
                    ans231.QuestionId = 231;
                    ans231.AnsDes = billBoardSchool;
                    ans231.AnserTypeId = 1;
                    ans231.CreateDate = DateTime.Now;
                    ans231.UserId = user.Id;
                    ans231.AnsMonth = ansMonth;
                }









                var ans232 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 232).FirstOrDefault();
                if (ans232 == null)
                {
                    // รูปภาพก่อน-หลัง การทำความสะอาดแอร์ห้องประชุม :
                    string picairInmeeting = Request.Form["picairInmeetingRadio"];
                    Answer answer232 = new Answer()
                    {
                        AnsDes = picairInmeeting,
                        QuestionId = 232,
                        AnserTypeId = 3,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer232);
                }
                else
                {
                    string billBoardSchool = Request.Form["picairInmeetingRadio"];
                    ans232.QuestionId = 232;
                    ans232.AnsDes = billBoardSchool;
                    ans232.AnserTypeId = 1;
                    ans232.CreateDate = DateTime.Now;
                    ans232.UserId = user.Id;
                    ans232.AnsMonth = ansMonth;
                }





                var ans233 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 233).FirstOrDefault();
                if (ans233 == null)
                {
                    // รูปภาพก่อน-หลัง การทำความสะอาดแอร์ห้อง Server :
                    string picAirserver = Request.Form["picAirserverRadio"];
                    Answer answer233 = new Answer()
                    {
                        AnsDes = picAirserver,
                        QuestionId = 233,
                        AnserTypeId = 3,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer233);
                }
                else
                {
                    string billBoardSchool = Request.Form["picAirserverRadio"];
                    ans233.QuestionId = 232;
                    ans233.AnsDes = billBoardSchool;
                    ans233.AnserTypeId = 1;
                    ans233.CreateDate = DateTime.Now;
                    ans233.UserId = user.Id;
                    ans233.AnsMonth = ansMonth;
                }




                var ans234 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 234).FirstOrDefault();
                if (ans234 == null)
                {
                    // รูปภาพก่อน-หลัง การทำความสะอาดแอร์ห้อง Server :
                    string inStallBase = Request.Form["inStallBaseRadio"];
                    Answer answer234 = new Answer()
                    {
                        AnsDes = inStallBase,
                        QuestionId = 234,
                        AnserTypeId = 3,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer234);
                }
                else
                {
                    string billBoardSchool = Request.Form["inStallBaseRadio"];
                    ans234.QuestionId = 234;
                    ans234.AnsDes = billBoardSchool;
                    ans234.AnserTypeId = 1;
                    ans234.CreateDate = DateTime.Now;
                    ans234.UserId = user.Id;
                    ans234.AnsMonth = ansMonth;
                }





                var ans235 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 235).FirstOrDefault();
                if (ans235 == null)
                {
                    // รูปความสะอาดบริเวณจานดาวเทียมr :
                    string picCleansatellite = Request.Form["picCleansatelliteRadio"];
                    Answer answer235 = new Answer()
                    {
                        AnsDes = picCleansatellite,
                        QuestionId = 235,
                        AnserTypeId = 3,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer235);
                }
                else
                {
                    string billBoardSchool = Request.Form["picCleansatelliteRadio"];
                    ans235.QuestionId = 235;
                    ans235.AnsDes = billBoardSchool;
                    ans235.AnserTypeId = 1;
                    ans235.CreateDate = DateTime.Now;
                    ans235.UserId = user.Id;
                    ans235.AnsMonth = ansMonth;
                }





                var ans236 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 236).FirstOrDefault();
                if (ans236 == null)
                {
                    // รูป LNB พร้อม Part NO. :
                    string picLnb = Request.Form["picLnbRadio"];
                    Answer answer236 = new Answer()
                    {
                        AnsDes = picLnb,
                        QuestionId = 236,
                        AnserTypeId = 3,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer236);

                }
                else
                {
                    string billBoardSchool = Request.Form["picLnbRadio"];
                    ans236.QuestionId = 236;
                    ans236.AnsDes = billBoardSchool;
                    ans236.AnserTypeId = 1;
                    ans236.CreateDate = DateTime.Now;
                    ans236.UserId = user.Id;
                    ans236.AnsMonth = ansMonth;
                }


                var ans237 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 237).FirstOrDefault();
                if (ans237 == null)
                {
                    // รูป BUC พร้อม Part NO :
                    string picBUC = Request.Form["picBUCRadio"];
                    Answer answer237 = new Answer()
                    {
                        AnsDes = picBUC,
                        QuestionId = 237,
                        AnserTypeId = 3,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer237);


                }
                else
                {
                    string billBoardSchool = Request.Form["picBUCRadio"];
                    ans237.QuestionId = 237;
                    ans237.AnsDes = billBoardSchool;
                    ans237.AnserTypeId = 1;
                    ans237.CreateDate = DateTime.Now;
                    ans237.UserId = user.Id;
                    ans237.AnsMonth = ansMonth;
                }



                var ans238 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 238).FirstOrDefault();
                if (ans238 == null)
                {
                    // รูปการเก็บสายและพันหัวที่ LNB/BUC :
                    string picWiringLnb = Request.Form["picWiringLnbRadio"];
                    Answer answer238 = new Answer()
                    {
                        AnsDes = picWiringLnb,
                        QuestionId = 238,
                        AnserTypeId = 3,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer238);


                }
                else
                {
                    string billBoardSchool = Request.Form["picWiringLnbRadio"];
                    ans238.QuestionId = 238;
                    ans238.AnsDes = billBoardSchool;
                    ans238.AnserTypeId = 1;
                    ans238.CreateDate = DateTime.Now;
                    ans238.UserId = user.Id;
                    ans238.AnsMonth = ansMonth;
                }

                var ans239 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 239).FirstOrDefault();
                if (ans239 == null)
                {
                    // รูปแนว Line Of Sight (ดูการถูกบังของหน้าจานดาวเทียม) :
                    string picLineofSight = Request.Form["picLineofSightRadio"];
                    Answer answer239 = new Answer()
                    {
                        AnsDes = picLineofSight,
                        QuestionId = 239,
                        AnserTypeId = 3,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer239);
                }
                else
                {
                    string billBoardSchool = Request.Form["picLineofSightRadio"];
                    ans239.QuestionId = 239;
                    ans239.AnsDes = billBoardSchool;
                    ans239.AnserTypeId = 1;
                    ans239.CreateDate = DateTime.Now;
                    ans239.UserId = user.Id;
                    ans239.AnsMonth = ansMonth;
                }




                var ans240 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 240).FirstOrDefault();
                if (ans240 == null)
                {
                    // รูปจุดติดตั้ง Solar Cell :
                    string picBaseSolarcell = Request.Form["picBaseSolarcellRadio"];
                    Answer answer240 = new Answer()
                    {
                        AnsDes = picBaseSolarcell,
                        QuestionId = 240,
                        AnserTypeId = 3,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer240);
                }
                else
                {
                    string billBoardSchool = Request.Form["picBaseSolarcellRadio"];
                    ans240.QuestionId = 240;
                    ans240.AnsDes = billBoardSchool;
                    ans240.AnserTypeId = 1;
                    ans240.CreateDate = DateTime.Now;
                    ans240.UserId = user.Id;
                    ans240.AnsMonth = ansMonth;
                }

                var ans241 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 241).FirstOrDefault();
                if (ans241 == null)
                {
                    // รูปอุปกรณ์ Solar Cell ภายในห้อง :
                    string solarcellToolsinroom = Request.Form["solarcellToolsinroomRadio"];
                    Answer answer241 = new Answer()
                    {
                        AnsDes = solarcellToolsinroom,
                        QuestionId = 241,
                        AnserTypeId = 3,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer241);

                }
                else
                {
                    string billBoardSchool = Request.Form["solarcellToolsinroomRadio"];
                    ans241.QuestionId = 241;
                    ans241.AnsDes = billBoardSchool;
                    ans241.AnserTypeId = 1;
                    ans241.CreateDate = DateTime.Now;
                    ans241.UserId = user.Id;
                    ans241.AnsMonth = ansMonth;
                }



                var ans242 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 242).FirstOrDefault();
                if (ans242 == null)
                {
                    // รูปหน้าจอ Charger แสดงค่าต่างๆ :
                    string screenCharger = Request.Form["screenChargerRadio"];
                    Answer answer242 = new Answer()
                    {
                        AnsDes = screenCharger,
                        QuestionId = 242,
                        AnserTypeId = 3,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer242);

                }
                else
                {
                    string billBoardSchool = Request.Form["screenChargerRadio"];
                    ans242.QuestionId = 242;
                    ans242.AnsDes = billBoardSchool;
                    ans242.AnserTypeId = 1;
                    ans242.CreateDate = DateTime.Now;
                    ans242.UserId = user.Id;
                    ans242.AnsMonth = ansMonth;
                }





                var ans243 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 243).FirstOrDefault();
                if (ans243 == null)
                {
                    // รูปหน้าจอ Inverter แสดงค่าต่างๆ :
                    string screenInverter = Request.Form["screenInverterRadio"];
                    Answer answer243 = new Answer()
                    {
                        AnsDes = screenInverter,
                        QuestionId = 243,
                        AnserTypeId = 3,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer243);

                }
                else
                {
                    string billBoardSchool = Request.Form["screenInverterRadio"];
                    ans243.QuestionId = 243;
                    ans243.AnsDes = billBoardSchool;
                    ans243.AnserTypeId = 1;
                    ans243.CreateDate = DateTime.Now;
                    ans243.UserId = user.Id;
                    ans243.AnsMonth = ansMonth;
                }




                var ans244 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 244).FirstOrDefault();
                if (ans244 == null)
                {
                    // รูป Circuit Breaker ภายในตู้ :
                    string piccircuitBreaker = Request.Form["piccircuitBreakerRadio"];
                    Answer answer244 = new Answer()
                    {
                        AnsDes = piccircuitBreaker,
                        QuestionId = 244,
                        AnserTypeId = 3,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer244);

                }
                else
                {
                    string billBoardSchool = Request.Form["piccircuitBreakerRadio"];
                    ans244.QuestionId = 244;
                    ans244.AnsDes = billBoardSchool;
                    ans244.AnserTypeId = 1;
                    ans244.CreateDate = DateTime.Now;
                    ans244.UserId = user.Id;
                    ans244.AnsMonth = ansMonth;
                }


                var ans245 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 245).FirstOrDefault();
                if (ans245 == null)
                {
                    // รูป Terminal ต่อสายภายในตู้ :
                    string picTerminal = Request.Form["picTerminalRadio"];
                    Answer answer245 = new Answer()
                    {
                        AnsDes = picTerminal,
                        QuestionId = 245,
                        AnserTypeId = 3,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer245);

                }
                else
                {
                    string billBoardSchool = Request.Form["picTerminalRadio"];
                    ans245.QuestionId = 245;
                    ans245.AnsDes = billBoardSchool;
                    ans245.AnserTypeId = 1;
                    ans245.CreateDate = DateTime.Now;
                    ans245.UserId = user.Id;
                    ans245.AnsMonth = ansMonth;
                }





                var ans246 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 246).FirstOrDefault();
                if (ans246 == null)
                {
                    // รูปความสะอาดแผง PV :
                    string picCleaningPv = Request.Form["picCleaningPvRadio"];
                    Answer answer246 = new Answer()
                    {
                        AnsDes = picCleaningPv,
                        QuestionId = 246,
                        AnserTypeId = 3,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer246);
                }
                else
                {
                    string billBoardSchool = Request.Form["picCleaningPvRadio"];
                    ans246.QuestionId = 246;
                    ans246.AnsDes = billBoardSchool;
                    ans246.AnserTypeId = 1;
                    ans246.CreateDate = DateTime.Now;
                    ans246.UserId = user.Id;
                    ans246.AnsMonth = ansMonth;
                }

                var ans247 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 247).FirstOrDefault();
                if (ans247 == null)
                {
                    // รูปภาพรวมดูสิ่งบดบังแสงอาทิตย์  :
                    string picSunrise = Request.Form["picSunriseRadio"];
                    Answer answer247 = new Answer()
                    {
                        AnsDes = picSunrise,
                        QuestionId = 247,
                        AnserTypeId = 3,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer247);
                }
                else
                {
                    string billBoardSchool = Request.Form["picSunriseRadio"];
                    ans247.QuestionId = 247;
                    ans247.AnsDes = billBoardSchool;
                    ans247.AnserTypeId = 1;
                    ans247.CreateDate = DateTime.Now;
                    ans247.UserId = user.Id;
                    ans247.AnsMonth = ansMonth;
                }






                var ans248 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 248).FirstOrDefault();
                if (ans248 == null)
                {
                    // รูปคอมพิวเตอร์ตัวที่ 1 พร้อม Serial NO. :
                    string piccomAgent1 = Request.Form["piccomAgentRadio1"];
                    Answer answer248 = new Answer()
                    {
                        AnsDes = piccomAgent1,
                        QuestionId = 248,
                        AnserTypeId = 3,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer248);
                }
                else
                {
                    string billBoardSchool = Request.Form["piccomAgentRadio1"];
                    ans248.QuestionId = 248;
                    ans248.AnsDes = billBoardSchool;
                    ans248.AnserTypeId = 1;
                    ans248.CreateDate = DateTime.Now;
                    ans248.UserId = user.Id;
                    ans248.AnsMonth = ansMonth;
                }





                var ans249 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 249).FirstOrDefault();
                if (ans249 == null)
                {
                    // รูปคอมพิวเตอร์ตัวที่ 2 พร้อม Serial NO. :
                    string piccomAgent2 = Request.Form["piccomAgentRadio2"];
                    Answer answer249 = new Answer()
                    {
                        AnsDes = piccomAgent2,
                        QuestionId = 249,
                        AnserTypeId = 3,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer249);
                }
                else
                {
                    string billBoardSchool = Request.Form["piccomAgentRadio2"];
                    ans249.QuestionId = 249;
                    ans249.AnsDes = billBoardSchool;
                    ans249.AnserTypeId = 1;
                    ans249.CreateDate = DateTime.Now;
                    ans249.UserId = user.Id;
                    ans249.AnsMonth = ansMonth;
                }





                var ans250 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 250).FirstOrDefault();
                if (ans250 == null)
                {
                    // รูปคอมพิวเตอร์ตัวที่ 3 พร้อม Serial NO. :
                    string piccomAgent3 = Request.Form["piccomAgentRadio3"];
                    Answer answer250 = new Answer()
                    {
                        AnsDes = piccomAgent3,
                        QuestionId = 250,
                        AnserTypeId = 3,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer250);
                }
                else
                {
                    string billBoardSchool = Request.Form["piccomAgentRadio3"];
                    ans250.QuestionId = 250;
                    ans250.AnsDes = billBoardSchool;
                    ans250.AnserTypeId = 1;
                    ans250.CreateDate = DateTime.Now;
                    ans250.UserId = user.Id;
                    ans250.AnsMonth = ansMonth;
                }





                var ans251 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 251).FirstOrDefault();
                if (ans251 == null)
                {
                    // รูปคอมพิวเตอร์ตัวที่ 4 พร้อม Serial NO. :
                    string piccomAgent4 = Request.Form["piccomAgentRadio4"];
                    Answer answer251 = new Answer()
                    {
                        AnsDes = piccomAgent4,
                        QuestionId = 251,
                        AnserTypeId = 3,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer251);
                }
                else
                {
                    string billBoardSchool = Request.Form["piccomAgentRadio4"];
                    ans251.QuestionId = 251;
                    ans251.AnsDes = billBoardSchool;
                    ans251.AnserTypeId = 1;
                    ans251.CreateDate = DateTime.Now;
                    ans251.UserId = user.Id;
                    ans251.AnsMonth = ansMonth;
                }





                var ans252 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 252).FirstOrDefault();
                if (ans252 == null)
                {
                    // รูปคอมพิวเตอร์ตัวที่ 5 พร้อม Serial NO.  :
                    string piccomAgent5 = Request.Form["piccomAgentRadio5"];
                    Answer answer252 = new Answer()
                    {
                        AnsDes = piccomAgent5,
                        QuestionId = 252,
                        AnserTypeId = 3,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer252);
                }
                else
                {
                    string billBoardSchool = Request.Form["piccomAgentRadio5"];
                    ans252.QuestionId = 252;
                    ans252.AnsDes = billBoardSchool;
                    ans252.AnserTypeId = 1;
                    ans252.CreateDate = DateTime.Now;
                    ans252.UserId = user.Id;
                    ans252.AnsMonth = ansMonth;
                }



                var ans253 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 253).FirstOrDefault();
                if (ans253 == null)
                {
                    // รูปคอมพิวเตอร์ตัวที่ 6 พร้อม Serial NO.  :
                    string piccomAgent6 = Request.Form["piccomAgentRadio6"];
                    Answer answer253 = new Answer()
                    {
                        AnsDes = piccomAgent6,
                        QuestionId = 253,
                        AnserTypeId = 3,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer253);
                }
                else
                {
                    string billBoardSchool = Request.Form["piccomAgentRadio6"];
                    ans253.QuestionId = 253;
                    ans253.AnsDes = billBoardSchool;
                    ans253.AnserTypeId = 1;
                    ans253.CreateDate = DateTime.Now;
                    ans253.UserId = user.Id;
                    ans253.AnsMonth = ansMonth;
                }






                var ans254 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 254).FirstOrDefault();
                if (ans254 == null)
                {
                    // รูปคอมพิวเตอร์ตัวที่ 7 พร้อม Serial NO.  :
                    string piccomAgent7 = Request.Form["piccomAgentRadio7"];
                    Answer answer254 = new Answer()
                    {
                        AnsDes = piccomAgent7,
                        QuestionId = 254,
                        AnserTypeId = 3,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer254);
                }
                else
                {
                    string billBoardSchool = Request.Form["piccomAgentRadio7"];
                    ans254.QuestionId = 254;
                    ans254.AnsDes = billBoardSchool;
                    ans254.AnserTypeId = 1;
                    ans254.CreateDate = DateTime.Now;
                    ans254.UserId = user.Id;
                    ans254.AnsMonth = ansMonth;
                }





                var ans255 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 255).FirstOrDefault();
                if (ans255 == null)
                {
                    // รูปคอมพิวเตอร์ตัวที่ 8 พร้อม Serial NO.  :
                    string piccomAgent8 = Request.Form["piccomAgentRadio8"];
                    Answer answer255 = new Answer()
                    {
                        AnsDes = piccomAgent8,
                        QuestionId = 255,
                        AnserTypeId = 3,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer255);
                }
                else
                {
                    string billBoardSchool = Request.Form["piccomAgentRadio8"];
                    ans255.QuestionId = 255;
                    ans255.AnsDes = billBoardSchool;
                    ans255.AnserTypeId = 1;
                    ans255.CreateDate = DateTime.Now;
                    ans255.UserId = user.Id;
                    ans255.AnsMonth = ansMonth;
                }




                var ans256 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 256).FirstOrDefault();
                if (ans256 == null)
                {
                    // รูปคอมพิวเตอร์ตัวที่ 9 พร้อม Serial NO.  :
                    string piccomAgent9 = Request.Form["piccomAgentRadio9"];
                    Answer answer256 = new Answer()
                    {
                        AnsDes = piccomAgent9,
                        QuestionId = 256,
                        AnserTypeId = 3,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer256);
                }
                else
                {
                    string billBoardSchool = Request.Form["piccomAgentRadio9"];
                    ans256.QuestionId = 256;
                    ans256.AnsDes = billBoardSchool;
                    ans256.AnserTypeId = 1;
                    ans256.CreateDate = DateTime.Now;
                    ans256.UserId = user.Id;
                    ans256.AnsMonth = ansMonth;
                }



                var ans257 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 257).FirstOrDefault();
                if (ans257 == null)
                {
                    // รูปคอมพิวเตอร์ตัวที่ 10 พร้อม Serial NO.  :
                    string piccomAgent10 = Request.Form["piccomAgentRadio10"];
                    Answer answer257 = new Answer()
                    {
                        AnsDes = piccomAgent10,
                        QuestionId = 257,
                        AnserTypeId = 3,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer257);
                }
                else
                {
                    string billBoardSchool = Request.Form["piccomAgentRadio10"];
                    ans257.QuestionId = 257;
                    ans257.AnsDes = billBoardSchool;
                    ans257.AnserTypeId = 1;
                    ans257.CreateDate = DateTime.Now;
                    ans257.UserId = user.Id;
                    ans257.AnsMonth = ansMonth;
                }


                var ans258 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth && x.QuestionId == 258).FirstOrDefault();
                if (ans258 == null)
                {
                    // รูปคอมพิวเตอร์ตัวที่ 11 พร้อม Serial NO.  :
                    string piccomAgent11 = Request.Form["piccomAgentRadio11"];
                    Answer answer258 = new Answer()
                    {
                        AnsDes = piccomAgent11,
                        QuestionId = 258,
                        AnserTypeId = 3,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer258);
                }
                else
                {
                    string billBoardSchool = Request.Form["piccomAgentRadio11"];
                    ans258.QuestionId = 258;
                    ans258.AnsDes = billBoardSchool;
                    ans258.AnserTypeId = 1;
                    ans258.CreateDate = DateTime.Now;
                    ans258.UserId = user.Id;
                    ans258.AnsMonth = ansMonth;
                }

               

                //1.รูป PICTURE CHECKLIST :
                if (this.pictureChecklistImages.HasFile)
                {
                    string extension = this.pictureChecklistImages.PostedFile.FileName.Split('.')[1];
                    string newFileName = "images/pictureChecklist_" + DateTime.Now.ToString("yyyyMMddHHmmss") + "." + extension;
                    this.pictureChecklistImages.PostedFile.SaveAs(Server.MapPath(newFileName));

                    Answer answer259 = new Answer()
                    {
                        AnsDes = newFileName,
                        QuestionId = 259,
                        AnserTypeId = 3,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer259);
                }

                //2.รูป VSAT PICTURE CHECKLIST :
                if (this.vsatpictureChecklistImages.HasFile)
                {
                    string extension = this.vsatpictureChecklistImages.PostedFile.FileName.Split('.')[1];
                    string newFileName = "images/VsatPictureChecklist_" + DateTime.Now.ToString("yyyyMMddHHmmss") + "." + extension;
                    this.vsatpictureChecklistImages.PostedFile.SaveAs(Server.MapPath(newFileName));

                    Answer answer260 = new Answer()
                    {
                        AnsDes = newFileName,
                        QuestionId = 260,
                        AnserTypeId = 3,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer260);
                }

                //3.รูป SOLAR CELL PICTURE CHECKLISTT :
                if (this.solarcellpictureChecklistImages.HasFile)
                {
                    string extension = this.solarcellpictureChecklistImages.PostedFile.FileName.Split('.')[1];
                    string newFileName = "images/SolarcellPictureChecklist_" + DateTime.Now.ToString("yyyyMMddHHmmss") + "." + extension;
                    this.solarcellpictureChecklistImages.PostedFile.SaveAs(Server.MapPath(newFileName));

                    Answer answer261 = new Answer()
                    {
                        AnsDes = newFileName,
                        QuestionId = 261,
                        AnserTypeId = 3,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer261);
                }

                //4.COMPUTER PICTURE CHECKLIST :
                if (this.compictureChecklistImages.HasFile)
                {
                    string extension = this.compictureChecklistImages.PostedFile.FileName.Split('.')[1];
                    string newFileName = "images/ComputerPictureChecklist_" + DateTime.Now.ToString("yyyyMMddHHmmss") + "." + extension;
                    this.compictureChecklistImages.PostedFile.SaveAs(Server.MapPath(newFileName));

                    Answer answer262 = new Answer()
                    {
                        AnsDes = newFileName,
                        QuestionId = 262,
                        AnserTypeId = 3,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer262);
                }

                //ใส่ป้ายหน้าโรงเรียน :
                if (this.signboardschoolImage.HasFile)
                {
                    string extension = this.signboardschoolImage.PostedFile.FileName.Split('.')[1];
                    string newFileName = "images/SignboardSchool_" + DateTime.Now.ToString("yyyyMMddHHmmss") + "." + extension;
                    this.signboardschoolImage.PostedFile.SaveAs(Server.MapPath(newFileName));

                    Answer answer6 = new Answer()
                    {
                        AnsDes = newFileName,
                        QuestionId = 6,
                        AnserTypeId = 3,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer6);
                }

                string xx = Request.Form["upsModeRadio"];
                Answer answer7 = new Answer()
                {
                    AnsDes = xx,
                    QuestionId = 7,
                    AnserTypeId = 3,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer7);



                int result = uSOEntities.SaveChanges();
                if (result > 0)
                {
                    this.SuccessPanel.Visible = true;
                }
            }



















            // exsample
            //void GetData()
            //{
            //    var collection = uSOEntities.Answers.Where(x => x.User.OrganizationId == 1 && x.Question.SectionId == 6).ToList();
            //    this.ResultRepeater.DataSource = collection.OrderByDescending(x => x.CreateDate).ToList();
            //    this.ResultRepeater.DataBind();
            //}
        }

        protected void testclick(object sender, EventArgs e)
        {
            //Response.Write("<script>alert('testclick');</script>");
        }
    }
}