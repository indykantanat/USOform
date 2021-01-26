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

namespace USOform.PreventiveMaintenanceReportMobileService_2_1_2_2_3
{
    public partial class prereport_mobileService : System.Web.UI.Page
    {
        USOEntities uSOEntities;
        public List<Answer> answers;

        public prereport_mobileService()
        {
            uSOEntities = new USOEntities();
            answers = new List<Answer>();
        }
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                User user = (User)Session["strUsername"];
                if (user != null)
                {
                    string ansMonth = Request["AnsMonth"] != null ? Request["AnsMonth"] : DateTime.Now.ToString("yyyyMM", CultureInfo.GetCultureInfo("en-US"));
                    answers = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.AnsMonth == ansMonth).ToList();
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
        void SetForm() {
            //this.piclogo.Value = answers.Where(x => x.QuestionId == 1408).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1408).FirstOrDefault().AnsDes : "";
            this.groupTextbox.Value = answers.Where(x => x.QuestionId == 1409).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1409).FirstOrDefault().AnsDes : "";
            this.AreaTextbox.Value = answers.Where(x => x.QuestionId == 1410).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1409).FirstOrDefault().AnsDes : "";
            this.CompanyTextbox.Value = answers.Where(x => x.QuestionId == 1411).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1409).FirstOrDefault().AnsDes : "";
            this.maintenanceCountTextbox.Value = answers.Where(x => x.QuestionId == 1413).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1409).FirstOrDefault().AnsDes : "";
            this.yearTextbox.Value = answers.Where(x => x.QuestionId == 1414).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1409).FirstOrDefault().AnsDes : "";
            this.startDatepicker.Value = answers.Where(x => x.QuestionId == 1415).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1415).FirstOrDefault().AnsDes : "";
            this.endDatepicker.Value = answers.Where(x => x.QuestionId == 1416).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1415).FirstOrDefault().AnsDes : "";
            this.siteCodeTextbox.Value = answers.Where(x => x.QuestionId == 1417).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1415).FirstOrDefault().AnsDes : "";
            this.cabinetIdTextbox.Value = answers.Where(x => x.QuestionId == 1418).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1415).FirstOrDefault().AnsDes : "";
            this.sitecodeTextboxSection2.Value = answers.Where(x => x.QuestionId == 1419).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1415).FirstOrDefault().AnsDes : "";
            this.VillageIdTextbox.Value = answers.Where(x => x.QuestionId == 1420).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1415).FirstOrDefault().AnsDes : "";
            this.villageTextbox.Value = answers.Where(x => x.QuestionId == 1421).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1415).FirstOrDefault().AnsDes : "";
            this.subdistrictTextbox.Value = answers.Where(x => x.QuestionId == 1422).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1415).FirstOrDefault().AnsDes : "";
            this.DistrictTextbox.Value = answers.Where(x => x.QuestionId == 1423).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1415).FirstOrDefault().AnsDes : "";
            this.provinceTextbox.Value = answers.Where(x => x.QuestionId == 1424).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1415).FirstOrDefault().AnsDes : "";
            this.typeTextbox.Value = answers.Where(x => x.QuestionId == 1425).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1415).FirstOrDefault().AnsDes : "";
            this.pmdateTextbox.Value = answers.Where(x => x.QuestionId == 1426).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1415).FirstOrDefault().AnsDes : "";
            // this.pmdateTextbox.Value = answers.Where(x => x.QuestionId == 1426).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1415).FirstOrDefault().AnsDes : "";
            this.signatureExecutorTextbox.Value = answers.Where(x => x.QuestionId == 1428).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1415).FirstOrDefault().AnsDes : "";
            this.signatureSupervisorTextbox.Value = answers.Where(x => x.QuestionId == 1431).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1415).FirstOrDefault().AnsDes : "";
            this.nameExecutorTextbox.Value = answers.Where(x => x.QuestionId == 1432).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1415).FirstOrDefault().AnsDes : "";
            this.nameSupervisorTextbox.Value = answers.Where(x => x.QuestionId == 1433).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1415).FirstOrDefault().AnsDes : "";
            this.DateExecutorTextbox.Value = answers.Where(x => x.QuestionId == 1434).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1415).FirstOrDefault().AnsDes : "";
            this.DateSupervisorTextbox.Value = answers.Where(x => x.QuestionId == 1435).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1415).FirstOrDefault().AnsDes : "";
            this.cabinetId2Textbox.Value = answers.Where(x => x.QuestionId == 1436).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1415).FirstOrDefault().AnsDes : "";
            this.sitecodeTextboxSection4.Value = answers.Where(x => x.QuestionId == 1437).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1415).FirstOrDefault().AnsDes : "";
            this.villageIDTextboxSection4.Value = answers.Where(x => x.QuestionId == 1438).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1415).FirstOrDefault().AnsDes : "";
            this.latandlongTextbox.Value = answers.Where(x => x.QuestionId == 1439).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1415).FirstOrDefault().AnsDes : "";
            this.oltorispTextbox.Value = answers.Where(x => x.QuestionId == 1440).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1415).FirstOrDefault().AnsDes : "";
            //this.oltorispTextbox.Value = answers.Where(x => x.QuestionId == 1440).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1415).FirstOrDefault().AnsDes : "";
            this.numberIdTextbox.Value = answers.Where(x => x.QuestionId == 1442).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1415).FirstOrDefault().AnsDes : "";
            this.kwhMeterTextbox.Value = answers.Where(x => x.QuestionId == 1443).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1415).FirstOrDefault().AnsDes : "";
            this.acvoltTextbox.Value = answers.Where(x => x.QuestionId == 1444).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1415).FirstOrDefault().AnsDes : "";
            this.lineAcTextbox.Value = answers.Where(x => x.QuestionId == 1445).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1415).FirstOrDefault().AnsDes : "";
            this.neutronAcTextbox.Value = answers.Where(x => x.QuestionId == 1446).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1415).FirstOrDefault().AnsDes : "";
            //this.neutronAcTextbox.Value = answers.Where(x => x.QuestionId == 1446).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1415).FirstOrDefault().AnsDes : "";
            this.acfromupsTextbox.Value = answers.Where(x => x.QuestionId == 1450).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1415).FirstOrDefault().AnsDes : "";
            this.voltInverterTextbox.Value = answers.Where(x => x.QuestionId == 1483).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1415).FirstOrDefault().AnsDes : "";
            this.loadVoltTageTextbox.Value = answers.Where(x => x.QuestionId == 1484).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1415).FirstOrDefault().AnsDes : "";
            this.batterTextbox1.Value = answers.Where(x => x.QuestionId == 1485).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1415).FirstOrDefault().AnsDes : "";
            this.batterTextbox2.Value = answers.Where(x => x.QuestionId == 1486).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1415).FirstOrDefault().AnsDes : "";
            this.batterTextbox3.Value = answers.Where(x => x.QuestionId == 1487).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1415).FirstOrDefault().AnsDes : "";
            this.batterTextbox4.Value = answers.Where(x => x.QuestionId == 1488).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1415).FirstOrDefault().AnsDes : "";
            this.cellIdTextbox.Value = answers.Where(x => x.QuestionId == 1491).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1415).FirstOrDefault().AnsDes : "";
            this.netWorkstrTextboxS1.Value = answers.Where(x => x.QuestionId == 1492).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1415).FirstOrDefault().AnsDes : "";
            this.netWorkstrTextboxS2.Value = answers.Where(x => x.QuestionId == 1493).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1415).FirstOrDefault().AnsDes : "";
            this.netWorkstrTextboxS3.Value = answers.Where(x => x.QuestionId == 1494).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1415).FirstOrDefault().AnsDes : "";
            this.dowloadOnuTextbox.Value = answers.Where(x => x.QuestionId == 1495).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1415).FirstOrDefault().AnsDes : "";
            this.uploadforOnuTextbox.Value = answers.Where(x => x.QuestionId == 1496).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1415).FirstOrDefault().AnsDes : "";
            this.pinngtestforOnuTextbox.Value = answers.Where(x => x.QuestionId == 1497).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1415).FirstOrDefault().AnsDes : "";
            this.dowloadforMobileTextbox.Value = answers.Where(x => x.QuestionId == 1498).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1415).FirstOrDefault().AnsDes : "";
            this.uploadforMobileTextbox.Value = answers.Where(x => x.QuestionId == 1499).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1415).FirstOrDefault().AnsDes : "";
            this.pingtestFormobileTextbox.Value = answers.Where(x => x.QuestionId == 1500).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1415).FirstOrDefault().AnsDes : "";

            //ปัญหาที่พบและการแก้ไข
            this.problemTextbox1.Value = answers.Where(x => x.QuestionId == 1501).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1501).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox1.Value = answers.Where(x => x.QuestionId == 1502).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1502).FirstOrDefault().AnsDes : "";
            this.problemTextbox2.Value = answers.Where(x => x.QuestionId == 1503).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1503).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox2.Value = answers.Where(x => x.QuestionId == 1504).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1504).FirstOrDefault().AnsDes : "";
            this.problemTextbox3.Value = answers.Where(x => x.QuestionId == 1505).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1505).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox3.Value = answers.Where(x => x.QuestionId == 1506).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1506).FirstOrDefault().AnsDes : "";
            this.problemTextbox4.Value = answers.Where(x => x.QuestionId == 1507).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1507).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox4.Value = answers.Where(x => x.QuestionId == 1508).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1508).FirstOrDefault().AnsDes : "";
            this.problemTextbox5.Value = answers.Where(x => x.QuestionId == 1509).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1509).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox5.Value = answers.Where(x => x.QuestionId == 1510).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1510).FirstOrDefault().AnsDes : "";
            this.problemTextbox6.Value = answers.Where(x => x.QuestionId == 1511).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1511).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox6.Value = answers.Where(x => x.QuestionId == 1512).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1512).FirstOrDefault().AnsDes : "";
            this.problemTextbox7.Value = answers.Where(x => x.QuestionId == 1513).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1513).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox7.Value = answers.Where(x => x.QuestionId == 1514).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1514).FirstOrDefault().AnsDes : "";
            this.problemTextbox8.Value = answers.Where(x => x.QuestionId == 1515).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1515).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox8.Value = answers.Where(x => x.QuestionId == 1516).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1516).FirstOrDefault().AnsDes : "";
            this.problemTextbox9.Value = answers.Where(x => x.QuestionId == 1517).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1517).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox9.Value = answers.Where(x => x.QuestionId == 1518).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1518).FirstOrDefault().AnsDes : "";
            this.problemTextbox10.Value = answers.Where(x => x.QuestionId == 1519).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1419).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox10.Value = answers.Where(x => x.QuestionId == 1520).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1520).FirstOrDefault().AnsDes : "";
            this.problemTextbox11.Value = answers.Where(x => x.QuestionId == 1521).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1521).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox11.Value = answers.Where(x => x.QuestionId == 1522).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1522).FirstOrDefault().AnsDes : "";
            this.problemTextbox12.Value = answers.Where(x => x.QuestionId == 1523).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1523).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox12.Value = answers.Where(x => x.QuestionId == 1524).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1524).FirstOrDefault().AnsDes : "";
            this.problemTextbox13.Value = answers.Where(x => x.QuestionId == 1525).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1525).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox13.Value = answers.Where(x => x.QuestionId == 1526).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1526).FirstOrDefault().AnsDes : "";
            this.problemTextbox14.Value = answers.Where(x => x.QuestionId == 1527).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1527).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox14.Value = answers.Where(x => x.QuestionId == 1528).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1528).FirstOrDefault().AnsDes : "";
            this.problemTextbox15.Value = answers.Where(x => x.QuestionId == 1529).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1529).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox15.Value = answers.Where(x => x.QuestionId == 1530).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1530).FirstOrDefault().AnsDes : "";

            //ข้อมูลรายการทรัพย์สิน









































        }
    }
}
