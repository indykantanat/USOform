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

            User user = (User)Session["strUsername"];
            if (user != null)
            {
                string ansMonth = Request["AnsMonth"] != null ? Request["AnsMonth"] : DateTime.Now.ToString("yyyyMM", CultureInfo.GetCultureInfo("en-US"));
                answers = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.AnsMonth == ansMonth).ToList();
            }
            else
            {
                Response.Redirect("/login/login.aspx");
                Response.End();

            }

            if (!IsPostBack)
            {
                if (answers.Count() > 0)
                {
                    SetForm();
                }
            }


            //if (!IsPostBack)
            //{
            //    User user = (User)Session["strUsername"];
            //    if (user != null)
            //    {
            //        //string ansMonth = Request["AnsMonth"] != null ? Request["AnsMonth"] : DateTime.Now.ToString("yyyyMM", CultureInfo.GetCultureInfo("en-US"));
            //        long siteId = long.Parse(Request["SiteId"]);
            //        int currentQuarter = this.GetQuarter(DateTime.Now);
            //        SR sR = uSOEntities.SRs.Where(x => x.Quarter == currentQuarter && x.Status == 1).FirstOrDefault();
            //        if (sR != null)
            //        {
            //            answers = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id).ToList();
            //            if (answers.Count() > 0)
            //            {
            //                SetForm();
            //            }
            //        }
            //    }
            //    else
            //    {
            //        Response.Redirect("/login/login.aspx");
            //        Response.End();

            //    }
            //}
        }

        int GetQuarter(DateTime dt)
        {
            return (dt.Month - 1) / 3 + 1;
        }

      
        void SetForm() {
         
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
            this.numberIdTextbox.Value = answers.Where(x => x.QuestionId == 1442).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1415).FirstOrDefault().AnsDes : "";
            this.kwhMeterTextbox.Value = answers.Where(x => x.QuestionId == 1443).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1415).FirstOrDefault().AnsDes : "";
            this.acvoltTextbox.Value = answers.Where(x => x.QuestionId == 1444).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1415).FirstOrDefault().AnsDes : "";
            this.lineAcTextbox.Value = answers.Where(x => x.QuestionId == 1445).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1415).FirstOrDefault().AnsDes : "";
            this.neutronAcTextbox.Value = answers.Where(x => x.QuestionId == 1446).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1415).FirstOrDefault().AnsDes : "";
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
            this.toolsListTextbox1.Value = answers.Where(x => x.QuestionId == 1531).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1531).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox1.Value = answers.Where(x => x.QuestionId == 1532).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1532).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox1.Value = answers.Where(x => x.QuestionId == 1533).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1533).FirstOrDefault().AnsDes : "";
            this.noteTextbox1.Value = answers.Where(x => x.QuestionId == 1534).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1534).FirstOrDefault().AnsDes : "";
            this.toolsListTextbox2.Value = answers.Where(x => x.QuestionId == 1535).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1535).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox2.Value = answers.Where(x => x.QuestionId == 1536).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1536).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox2.Value = answers.Where(x => x.QuestionId == 1537).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1537).FirstOrDefault().AnsDes : "";
            this.noteTextbox2.Value = answers.Where(x => x.QuestionId == 1538).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1538).FirstOrDefault().AnsDes : "";
            this.toolsListTextbox3.Value = answers.Where(x => x.QuestionId == 1539).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1539).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox3.Value = answers.Where(x => x.QuestionId == 1540).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1540).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox3.Value = answers.Where(x => x.QuestionId == 1541).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1541).FirstOrDefault().AnsDes : "";
            this.noteTextbox3.Value = answers.Where(x => x.QuestionId == 1542).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1542).FirstOrDefault().AnsDes : "";
            this.toolsListTextbox4.Value = answers.Where(x => x.QuestionId == 1543).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1543).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox4.Value = answers.Where(x => x.QuestionId == 1544).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1544).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox4.Value = answers.Where(x => x.QuestionId == 1545).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1545).FirstOrDefault().AnsDes : "";
            this.noteTextbox4.Value = answers.Where(x => x.QuestionId == 1546).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1546).FirstOrDefault().AnsDes : "";
            this.toolsListTextbox5.Value = answers.Where(x => x.QuestionId == 1547).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1547).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox5.Value = answers.Where(x => x.QuestionId == 1548).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1548).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox5.Value = answers.Where(x => x.QuestionId == 1549).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1549).FirstOrDefault().AnsDes : "";
            this.noteTextbox5.Value = answers.Where(x => x.QuestionId == 1550).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1550).FirstOrDefault().AnsDes : "";
            this.toolsListTextbox6.Value = answers.Where(x => x.QuestionId == 1551).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1551).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox6.Value = answers.Where(x => x.QuestionId == 1552).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1552).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox6.Value = answers.Where(x => x.QuestionId == 1553).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1553).FirstOrDefault().AnsDes : "";
            this.noteTextbox6.Value = answers.Where(x => x.QuestionId == 1554).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1554).FirstOrDefault().AnsDes : "";
            this.toolsListTextbox7.Value = answers.Where(x => x.QuestionId == 1555).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1555).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox7.Value = answers.Where(x => x.QuestionId == 1556).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1556).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox7.Value = answers.Where(x => x.QuestionId == 1557).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1557).FirstOrDefault().AnsDes : "";
            this.noteTextbox7.Value = answers.Where(x => x.QuestionId == 1558).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1558).FirstOrDefault().AnsDes : "";
            this.toolsListTextbox8.Value = answers.Where(x => x.QuestionId == 1559).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1559).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox8.Value = answers.Where(x => x.QuestionId == 1560).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1560).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox8.Value = answers.Where(x => x.QuestionId == 1561).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1561).FirstOrDefault().AnsDes : "";
            this.noteTextbox8.Value = answers.Where(x => x.QuestionId == 1562).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1562).FirstOrDefault().AnsDes : "";
            this.toolsListTextbox9.Value = answers.Where(x => x.QuestionId == 1563).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1563).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox9.Value = answers.Where(x => x.QuestionId == 1564).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1564).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox9.Value = answers.Where(x => x.QuestionId == 1565).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1565).FirstOrDefault().AnsDes : "";
            this.noteTextbox9.Value = answers.Where(x => x.QuestionId == 1566).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1566).FirstOrDefault().AnsDes : "";
            this.toolsListTextbox10.Value = answers.Where(x => x.QuestionId == 1567).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1567).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox10.Value = answers.Where(x => x.QuestionId == 1568).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1568).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox10.Value = answers.Where(x => x.QuestionId == 1569).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1569).FirstOrDefault().AnsDes : "";
            this.noteTextbox10.Value = answers.Where(x => x.QuestionId == 1570).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1570).FirstOrDefault().AnsDes : "";
            this.toolsListTextbox11.Value = answers.Where(x => x.QuestionId == 1571).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1571).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox11.Value = answers.Where(x => x.QuestionId == 1572).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1572).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox11.Value = answers.Where(x => x.QuestionId == 1573).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1573).FirstOrDefault().AnsDes : "";
            this.noteTextbox11.Value = answers.Where(x => x.QuestionId == 1574).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1574).FirstOrDefault().AnsDes : "";
            this.toolsListTextbox12.Value = answers.Where(x => x.QuestionId == 1575).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1575).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox12.Value = answers.Where(x => x.QuestionId == 1576).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1576).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox12.Value = answers.Where(x => x.QuestionId == 1577).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1577).FirstOrDefault().AnsDes : "";
            this.noteTextbox12.Value = answers.Where(x => x.QuestionId == 1578).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1578).FirstOrDefault().AnsDes : "";
            this.toolsListTextbox13.Value = answers.Where(x => x.QuestionId == 1579).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1579).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox13.Value = answers.Where(x => x.QuestionId == 1580).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1580).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox13.Value = answers.Where(x => x.QuestionId == 1581).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1581).FirstOrDefault().AnsDes : "";
            this.noteTextbox13.Value = answers.Where(x => x.QuestionId == 1582).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1582).FirstOrDefault().AnsDes : "";
            this.toolsListTextbox14.Value = answers.Where(x => x.QuestionId == 1583).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1583).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox14.Value = answers.Where(x => x.QuestionId == 1584).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1584).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox14.Value = answers.Where(x => x.QuestionId == 1585).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1585).FirstOrDefault().AnsDes : "";
            this.noteTextbox14.Value = answers.Where(x => x.QuestionId == 1586).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1586).FirstOrDefault().AnsDes : "";
            this.toolsListTextbox15.Value = answers.Where(x => x.QuestionId == 1587).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1587).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox15.Value = answers.Where(x => x.QuestionId == 1588).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1588).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox15.Value = answers.Where(x => x.QuestionId == 1589).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1589).FirstOrDefault().AnsDes : "";
            this.noteTextbox15.Value = answers.Where(x => x.QuestionId == 1590).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1590).FirstOrDefault().AnsDes : "";
            this.nameDopmTextbox.Value = answers.Where(x => x.QuestionId == 1591).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1591).FirstOrDefault().AnsDes : "";
            this.dayDopmTextbox.Value = answers.Where(x => x.QuestionId == 1592).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1592).FirstOrDefault().AnsDes : "";


        }






        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            User user = (User)Session["strUsername"];
            if (user != null)
            {

            }
            else
            {
                Response.Redirect("/login/login.aspx");
                Response.End();

            }

            string ansMonth = DateTime.Now.ToString("yyyyMM", CultureInfo.GetCultureInfo("en-US"));
            long siteId = long.Parse(Request["SiteId"]);
            int currentQuarter = this.GetQuarter(DateTime.Now);
            SR sR = uSOEntities.SRs.Where(x => x.Quarter == currentQuarter && x.Status == 1).FirstOrDefault();
            if (sR == null)
            {
                string srCode = "Q" + currentQuarter.ToString() + "/" + DateTime.Now.ToString("yyyy", CultureInfo.GetCultureInfo("th-US"));
                uSOEntities.SRs.Add(new SR
                {
                    Code = srCode,
                    CreatedDate = DateTime.Now,
                    Detail = "",
                    LastUpdated = DateTime.Now,
                    LastUser = user.Id,
                    SiteId = siteId,
                    Quarter = currentQuarter,
                    Status = 1
                });
            }
            else
            {
                sR.LastUser = user.Id;
                sR.LastUpdated = DateTime.Now;
            }

            ///------------------------------------------START   HEADING----------------------------------------------------------------////

            //1: logoPicture
            var ans1408 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1408).FirstOrDefault();
            if (ans1408 == null)

            {
                if (this.logoPicture.HasFile)
                {
                    string extension = this.logoPicture.PostedFile.FileName.Split('.')[1];
                    string newFileName = "images/logoImagesMobileService_" + DateTime.Now.ToString("yyyyMMddHHmmss") + "." + extension;
                    this.logoPicture.PostedFile.SaveAs(Server.MapPath(newFileName));

                    Answer answe1408 = new Answer()
                    {
                        AnsDes = newFileName,
                        QuestionId = 1408,
                        AnserTypeId = 3,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth,
                        SRId = sR.Id
                    };
                    uSOEntities.Answers.Add(answe1408);
                }
            }
            else
            {
                if (this.logoPicture.HasFile)
                {
                    string extension = this.logoPicture.PostedFile.FileName.Split('.')[1];
                    string newFileName = "images/logoImagesMobileService_" + DateTime.Now.ToString("yyyyMMddHHmmss") + "." + extension;
                    this.logoPicture.PostedFile.SaveAs(Server.MapPath(newFileName));
                    ans1408.QuestionId = 1408;
                    ans1408.AnsDes = newFileName;
                    ans1408.AnserTypeId = 3;
                    ans1408.CreateDate = DateTime.Now;
                    ans1408.UserId = user.Id;
                    ans1408.AnsMonth = ansMonth;
                    ans1408.SRId = sR.Id;

                }
            }

            var ans1409 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1409).FirstOrDefault();
            if (ans1409 == null) 
            {
                // กลุ่ม
                Answer answer1409 = new Answer()
                {
                    AnsDes = this.groupTextbox.Value,
                    QuestionId = 1409,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer1409);
            }
            else
            {

                {
                    ans1409.QuestionId = 1409;
                    ans1409.AnsDes = this.groupTextbox.Value;
                    ans1409.AnserTypeId = 1;
                    ans1409.CreateDate = DateTime.Now;
                    ans1409.UserId = user.Id;
                    ans1409.AnsMonth = ansMonth;
                    ans1409.SRId = sR.Id;
                }

            }







            // ภูมิภาค
            Answer answer1410 = new Answer()
                {
                    AnsDes = this.AreaTextbox.Value,
                    QuestionId = 1410,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer1410);

                // บริษัท
                Answer answer3 = new Answer()
                {
                    AnsDes = this.CompanyTextbox.Value,
                    QuestionId = 1411,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer3);


            //  ส่วนที่ 2 การจัดให้มีบริการสัญญาณโทรศัพท์เคลื่อนที่  (Mobile Service) ประเภทบริการ
            //        string mbService = Request.Form["mobileServiceAtRadio"];
            //        Answer answer257 = new Answer()
            //        {
            //            AnsDes = mbService,
            //            QuestionId = 1412,
            //            AnserTypeId = 4,
            //            CreateDate = DateTime.Now,
            //            UserId = user.Id,
            //            AnsMonth = ansMonth,
            //            SRId = sR.Id,
            //};
            //        uSOEntities.Answers.Add(answer257);
            var ans1412 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1412).FirstOrDefault();
            if (ans1412 == null)
            {

                //  ส่วนที่ 2 การจัดให้มีบริการสัญญาณโทรศัพท์เคลื่อนที่  (Mobile Service) ประเภทบริการ
                string mbService = Request.Form["mobileServiceAtRadio"];
                Answer answer257 = new Answer()
                {
                    AnsDes = mbService,
                    QuestionId = 1412,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer257);
            }
            else
            {
                string mbService = Request.Form["mobileServiceAtRadio"];

                ans1412.QuestionId = 1412;
                ans1412.AnsDes = mbService;
                ans1412.AnserTypeId = 4;
                ans1412.CreateDate = DateTime.Now;
                ans1412.UserId = user.Id;
                ans1412.AnsMonth = ansMonth;
                ans1412.SRId = sR.Id;


            }

            //รอบการบำรุงรักษาครั้งที่
            Answer answer4 = new Answer()
                {
                    AnsDes = this.maintenanceCountTextbox.Value,
                    QuestionId = 1413,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer4);

                //ปีพุทธศักราช
                Answer answer5 = new Answer()
                {
                    AnsDes = this.yearTextbox.Value,
                    QuestionId = 1414,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer5);

                //วัน เดือน ปี ที่เริ่มต้น
                Answer answer8 = new Answer()
                {
                    AnsDes = this.startDatepicker.Value,
                    QuestionId = 1415,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,

                };
                uSOEntities.Answers.Add(answer8);

                //ถึง 
                Answer answer9 = new Answer()
                {
                    AnsDes = this.endDatepicker.Value,
                    QuestionId = 1416,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,

                };
                uSOEntities.Answers.Add(answer9);

                //สถานที่ SITE CODE
                Answer answer10 = new Answer()
                {
                    AnsDes = this.siteCodeTextbox.Value,
                    QuestionId = 1417,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer10);

                ///------------------------------------------END  HEADING----------------------------------------------------------------////





                //////////////////////////////////    Sectionid  = 125    /////////////////////////////////
                //Cabinet ID:
                Answer answer11 = new Answer()
                {
                    AnsDes = this.cabinetIdTextbox.Value,
                    QuestionId = 1418,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer11);

                //Site Code :
                Answer answer12 = new Answer()
                {
                    AnsDes = this.sitecodeTextboxSection2.Value,
                    QuestionId = 1419,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer12);

                //Village ID :
                Answer answer13 = new Answer()
                {
                    AnsDes = this.VillageIdTextbox.Value,
                    QuestionId = 1420,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer13);


                //Village  :
                Answer answer14 = new Answer()
                {
                    AnsDes = this.villageTextbox.Value,
                    QuestionId = 1421,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer14);



                //Sub-District :
                Answer answer16 = new Answer()
                {
                    AnsDes = this.subdistrictTextbox.Value,
                    QuestionId = 1422,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer16);


                //District :
                Answer answer1423 = new Answer()
                {
                    AnsDes = this.DistrictTextbox.Value,
                    QuestionId = 1423,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer1423);

                //Province :
                Answer answer17 = new Answer()
                {
                    AnsDes = this.provinceTextbox.Value,
                    QuestionId = 1424,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer17);

                //Type :
                Answer answer18 = new Answer()
                {
                    AnsDes = this.typeTextbox.Value,
                    QuestionId = 1425,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer18);

                //PM Date :
                Answer answer19 = new Answer()
                {
                    AnsDes = this.pmdateTextbox.Value,
                    QuestionId = 1426,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer19);




                //ใส่รูปหน้าอาคารศูนย์ USO Net :
                if (this.picinfrontImages.HasFile)
                {
                    string extension = this.picinfrontImages.PostedFile.FileName.Split('.')[1];
                    string newFileName = "images/picinfrontImages_" + DateTime.Now.ToString("yyyyMMddHHmmss") + "." + extension;
                    this.picinfrontImages.PostedFile.SaveAs(Server.MapPath(newFileName));

                    Answer answer20 = new Answer()
                    {
                        AnsDes = newFileName,
                        QuestionId = 1427,
                        AnserTypeId = 3,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth,
                    };
                    uSOEntities.Answers.Add(answer20);
                }

                //////////////////////////////////   END  Sectionid  = 125    /////////////////////////////////





                //////////////////////////////////    Sectionid  = 126    /////////////////////////////////
                ///

                //signature Executor :
                Answer answer21 = new Answer()
                {
                    AnsDes = this.signatureExecutorTextbox.Value,
                    QuestionId = 1428,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer21);

                //signature Supervisor :
                Answer answer22 = new Answer()
                {
                    AnsDes = this.signatureSupervisorTextbox.Value,
                    QuestionId = 1431,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer22);

                //name Executor  :
                Answer answer23 = new Answer()
                {
                    AnsDes = this.nameExecutorTextbox.Value,
                    QuestionId = 1432,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer23);

                //name Supervisor :
                Answer answer24 = new Answer()
                {
                    AnsDes = this.nameSupervisorTextbox.Value,
                    QuestionId = 1433,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer24);

                //Date Executor :
                Answer answer25 = new Answer()
                {
                    AnsDes = this.DateExecutorTextbox.Value,
                    QuestionId = 1434,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer25);

                //Date Supervisor :
                Answer answer26 = new Answer()
                {
                    AnsDes = this.DateSupervisorTextbox.Value,
                    QuestionId = 1435,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer26);

                //////////////////////////////////   END  Sectionid  = 126    /////////////////////////////////
                ///



                //////////////////////////////////    Sectionid  = 127    /////////////////////////////////
                ///
                //Location name :
                Answer answer27 = new Answer()
                {
                    AnsDes = this.cabinetId2Textbox.Value,
                    QuestionId = 1436,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer27);

                //Site code section 4 :
                Answer answer28 = new Answer()
                {
                    AnsDes = this.sitecodeTextboxSection4.Value,
                    QuestionId = 1437,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer28);


                //villageIDsection 4 :
                Answer answer29 = new Answer()
                {
                    AnsDes = this.villageIDTextboxSection4.Value,
                    QuestionId = 1438,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer29);

                //lat and long  :
                Answer answer30 = new Answer()
                {
                    AnsDes = this.latandlongTextbox.Value,
                    QuestionId = 1439,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer30);

                //OLT ID (USO Network) or ISP (Existing Network) :
                Answer answer1440 = new Answer()
                {
                    AnsDes = this.oltorispTextbox.Value,
                    QuestionId = 1440,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer1440);
                //////////////////////////////////  END  Sectionid  = 127    /////////////////////////////////
                ///




                //////////////////////////////////    Sectionid  = 128    /////////////////////////////////
                ///

                //ระบบไฟฟ้า :
                string typeOf = Request.Form["voltSystemRadio"];
                Answer answer31 = new Answer()
                {
                    AnsDes = typeOf,
                    QuestionId = 1441,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer31);


                //หมายเลขผู้ใช้ไฟ:
                Answer answer1442 = new Answer()
                {
                    AnsDes = this.numberIdTextbox.Value,
                    QuestionId = 1442,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer1442);




                //หน่วยใช้ไฟไฟ  :
                Answer answer36 = new Answer()
                {
                    AnsDes = this.kwhMeterTextbox.Value,
                    QuestionId = 1443,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer36);


                //แรงดัน AC (kWh Meter) :
                Answer answer37 = new Answer()
                {
                    AnsDes = this.acvoltTextbox.Value,
                    QuestionId = 1444,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer37);


                //กระแส Line AC (kWh Meter) :
                Answer answer38 = new Answer()
                {
                    AnsDes = this.lineAcTextbox.Value,
                    QuestionId = 1445,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer38);


                // กระแส Neutron AC(kWh Meter) :          
                Answer answer39 = new Answer()
                {
                    AnsDes = this.neutronAcTextbox.Value,
                    QuestionId = 1446,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer39);

                //สภาพ kWh Meter Radio  :
                string conRadio = Request.Form["conditionRadio"];
                Answer answer40 = new Answer()
                {
                    AnsDes = conRadio,
                    QuestionId = 1447,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer40);

                //สภาพ MDB/ Circuit Breaker Radio  :
                string CircuitBreakerRadio = Request.Form["MDBCircuitBreakerRadio"];
                Answer answer41 = new Answer()
                {
                    AnsDes = CircuitBreakerRadio,
                    QuestionId = 1448,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer41);

                //////////////////////////////////  END   Sectionid  = 128    /////////////////////////////////
                ///





                //////////////////////////////////     Sectionid  = 129    /////////////////////////////////
                ///
                //UPS ภายในตู้ Radio  :
                string innerUPS = Request.Form["inupsRadio"];
                Answer answer42 = new Answer()
                {
                    AnsDes = innerUPS,
                    QuestionId = 1449,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer42);


                // AC from UPS :          
                Answer answer43 = new Answer()
                {
                    AnsDes = this.acfromupsTextbox.Value,
                    QuestionId = 1450,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer43);

                // กระเเส โหลด :  
                string emergen = Request.Form["voltageLoadRadio"];
                Answer answer45 = new Answer()
                {
                    AnsDes = emergen,
                    QuestionId = 1451,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer45);

                // ระดับความจุ Battery :  
                string emerbat = Request.Form["batteryCapacityRadio"];
                Answer answer1452 = new Answer()
                {
                    AnsDes = emerbat,
                    QuestionId = 1452,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer1452);

                // UPS MODE :  
                string UPSMODE = Request.Form["upsModeRadio"];
                Answer answer1453 = new Answer()
                {
                    AnsDes = UPSMODE,
                    QuestionId = 1453,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer1453);



                // การทำงานของระบบไฟสำรอง :  
                string secondFireRadio1 = Request.Form["secondFireRadio"];
                Answer answer1454 = new Answer()
                {
                    AnsDes = secondFireRadio1,
                    QuestionId = 1454,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer1454);


                // สภาพ Battery Bank :  
                string Batterybank = Request.Form["batterybankRadio"];
                Answer answer1455 = new Answer()
                {
                    AnsDes = Batterybank,
                    QuestionId = 1455,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer1455);

                //////////////////////////////////  END  Sectionid  = 129    /////////////////////////////////
                ///



                //////////////////////////////////    Sectionid  = 130    /////////////////////////////////
                ///
                // >ONU/Modem Network :  
                string ONUModemNetwork = Request.Form["ONUModemNetworkRadio"];
                Answer answer1456 = new Answer()
                {
                    AnsDes = ONUModemNetwork,
                    QuestionId = 1456,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer1456);


                // FEMTO :  
                string femto = Request.Form["femToRadio"];
                Answer answer1457 = new Answer()
                {
                    AnsDes = femto,
                    QuestionId = 1457,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer1457);

                // FEMTO answer :  
                string femtoanswer = Request.Form["femToanswerRadio"];
                Answer answer1458 = new Answer()
                {
                    AnsDes = femtoanswer,
                    QuestionId = 1458,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer1458);


                // tpower :  
                string tpower = Request.Form["tpowerRadio"];
                Answer answer1459 = new Answer()
                {
                    AnsDes = tpower,
                    QuestionId = 1459,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer1459);

                // wireingGroundRadio :  
                string wireingGround = Request.Form["wireingGroundRadio"];
                Answer answer1460 = new Answer()
                {
                    AnsDes = wireingGround,
                    QuestionId = 1460,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer1460);

                // การ Wiring Patch cord และ สาย LAN :  
                string Wirinlan = Request.Form["WirinlanRadio"];
                Answer answer1633 = new Answer()
                {
                    AnsDes = Wirinlan,
                    QuestionId = 1633,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer1633);

                //////////////////////////////////  END  Sectionid  = 130    /////////////////////////////////
                ///





                //////////////////////////////////    Sectionid  = 131    /////////////////////////////////
                ///

                //ความแข็งแรงจุดต่อ Ground Bar :
                string gb = Request.Form["groundbarRadio"];
                Answer answer57 = new Answer()
                {
                    AnsDes = gb,
                    QuestionId = 1461,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer57);



                //ความแข็งแรงของน็อตขันหางปลาอุปกรณ์ :
                string fishnot = Request.Form["notfishRadio"];
                Answer answer58 = new Answer()
                {
                    AnsDes = fishnot,
                    QuestionId = 1462,
                    AnserTypeId = 3,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer58);

                //สายกราวด์เรียบร้อย ปลอดภัย สมบูรณ์ :
                string ffss = Request.Form["safegroundRadio"];
                Answer answer59 = new Answer()
                {
                    AnsDes = ffss,
                    QuestionId = 1463,
                    AnserTypeId = 3,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer59);


                //สถานะไฟฟ้ารั่วลง Ground :
                string elecground = Request.Form["brokenElecRadio"];
                Answer answer60 = new Answer()
                {
                    AnsDes = elecground,
                    QuestionId = 1464,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer60);

                //////////////////////////////////   END Sectionid  = 131    /////////////////////////////////
                ///


                //////////////////////////////////    Sectionid  = 132    /////////////////////////////////
                ///

                //ป้ายและตัวเลขแสดงชื่อสถานี :
                string signandnumber = Request.Form["signandnumberRadio"];
                Answer answer1465 = new Answer()
                {
                    AnsDes = signandnumber,
                    QuestionId = 1465,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer1465);

                //การติดตั้งและการยึดตู้อุปกรณ์ :
                string inStall = Request.Form["inStallRadio"];
                Answer answer1466 = new Answer()
                {
                    AnsDes = inStall,
                    QuestionId = 1466,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer1466);


                //เสาไฟฟ้าที่ติดตั้งอุปกรณ์:
                string inStallSat = Request.Form["inStallSatRadio"];
                Answer answer1467 = new Answer()
                {
                    AnsDes = inStallSat,
                    QuestionId = 1467,
                    AnserTypeId = 3,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer1467);


                //ช่อง Cable Inlet  และความสะอาด :
                string CableInlet = Request.Form["CableInletRadio"];
                Answer answer1468 = new Answer()
                {
                    AnsDes = CableInlet,
                    QuestionId = 1468,
                    AnserTypeId = 3,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer1468);


                //ช่อง Filter ความสะอาด (T-Power:
                string filterRadio = Request.Form["filterRadio"];
                Answer answer1469 = new Answer()
                {
                    AnsDes = filterRadio,
                    QuestionId = 1469,
                    AnserTypeId = 3,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer1469);


                //ประตูและยางขอบประตูของตู้อุปกรณ์ :
                string doorToolsRadio = Request.Form["doorToolsRadio"];
                Answer answer1470 = new Answer()
                {
                    AnsDes = doorToolsRadio,
                    QuestionId = 1470,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer1470);


                //แนวสายไฟฟ้าและสายเคเบิ้ลเข้าสถานี :
                string cabletoStationRadio = Request.Form["cabletoStationRadio"];
                Answer answer1471 = new Answer()
                {
                    AnsDes = cabletoStationRadio,
                    QuestionId = 1471,
                    AnserTypeId = 3,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer1471);

                ////////////////////////////////// END Sectionid  = 132    /////////////////////////////////
                ///



                //////////////////////////////////  Sectionid  = 133     /////////////////////////////////
                ///

                // อุปกรณ์ LNB/BUC   :
                string tools = Request.Form["toolslnbRadio"];
                Answer answer88 = new Answer()
                {
                    AnsDes = tools,
                    QuestionId = 1472,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer88);


                // การเก็บสาย RG และการพันหัว   :
                string toolsRG = Request.Form["wiringrgRadio"];
                Answer answer89 = new Answer()
                {
                    AnsDes = toolsRG,
                    QuestionId = 1473,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer89);



                // ฐานและระดับของเสาจาน  :
                string baseOneiei = Request.Form["baseOnRadio"];
                Answer answer90 = new Answer()
                {
                    AnsDes = baseOneiei,
                    QuestionId = 1474,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer90);


                // >แนว Line Of Sight  :
                string lineOf = Request.Form["xxlineOfsightRadio"];
                Answer answer91 = new Answer()
                {
                    AnsDes = lineOf,
                    QuestionId = 1475,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer91);


                // แนว Line Of Sight  :
                string clendDish = Request.Form["cleaningDishRadio"];
                Answer answer92 = new Answer()
                {
                    AnsDes = clendDish,
                    QuestionId = 1476,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer92);


                // LNB Band Switch  :
                string lnbswitch = Request.Form["lnbbandswitchRadio"];
                Answer answer93 = new Answer()
                {
                    AnsDes = lnbswitch,
                    QuestionId = 1477,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer93);
                //////////////////////////////////  END Sectionid  = 133     /////////////////////////////////
                ///





                //////////////////////////////////   Sectionid  = 134     /////////////////////////////////
                ///
                // ระบบ Solar Cell :
                string solarCells = Request.Form["solarcellSystemRadio"];
                Answer answer94 = new Answer()
                {
                    AnsDes = solarCells,
                    QuestionId = 1478,
                    AnserTypeId = 3,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer94);


                // แผง PV Panel:
                string pv = Request.Form["pvPanelRadio"];
                Answer answer95 = new Answer()
                {
                    AnsDes = pv,
                    QuestionId = 1479,
                    AnserTypeId = 3,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer95);



                // อุปกรณ์ Charger :
                string charGer = Request.Form["toolsCharger"];
                Answer answer96 = new Answer()
                {
                    AnsDes = charGer,
                    QuestionId = 1480,
                    AnserTypeId = 3,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer96);




                // ความสะอาดแผง PV :
                string cleanPv = Request.Form["cleanIngpvRadio"];
                Answer answer97 = new Answer()
                {
                    AnsDes = cleanPv,
                    QuestionId = 1481,
                    AnserTypeId = 3,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer97);



                // การติดตั้งแผง PV :
                string intPv = Request.Form["installPvRadio"];
                Answer answer98 = new Answer()
                {
                    AnsDes = intPv,
                    QuestionId = 1482,
                    AnserTypeId = 3,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer98);


                // แรงดันไฟจาก Inverter :          
                Answer voltInverterTextbox = new Answer()
                {
                    AnsDes = this.voltInverterTextbox.Value,
                    QuestionId = 1483,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(voltInverterTextbox);


                // กระแส Load :          
                Answer loadVoltTageTextbox = new Answer()
                {
                    AnsDes = this.loadVoltTageTextbox.Value,
                    QuestionId = 1484,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(loadVoltTageTextbox);


                // batterry 1 :          
                Answer answer1485 = new Answer()
                {
                    AnsDes = this.batterTextbox1.Value,
                    QuestionId = 1485,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer1485);



                //  batterry 2 :          
                Answer answer1486 = new Answer()
                {
                    AnsDes = this.batterTextbox2.Value,
                    QuestionId = 1486,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer1486);


                // batterry 3 :         
                Answer answer1487 = new Answer()
                {
                    AnsDes = this.batterTextbox3.Value,
                    QuestionId = 1487,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer1487);


                //  batterry 4 :          
                Answer answer1488 = new Answer()
                {
                    AnsDes = this.batterTextbox4.Value,
                    QuestionId = 1488,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer1488);



                // solar cell 2 :
                string solarcellSystemRadio2 = Request.Form["solarcellSystemRadio2"];
                Answer answer1489 = new Answer()
                {
                    AnsDes = solarcellSystemRadio2,
                    QuestionId = 1489,
                    AnserTypeId = 3,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer1489);

                //////////////////////////////////   END Sectionid  = 134     /////////////////////////////////
                ///


                //////////////////////////////////    Sectionid  = 135     /////////////////////////////////
                ///



                // Call Test (for Femto) :
                string callTestforfemtoRadio = Request.Form["callTestforfemtoRadio"];
                Answer answer1490 = new Answer()
                {
                    AnsDes = callTestforfemtoRadio,
                    QuestionId = 1490,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer1490);


                //  Cell ID/Bsrid (for Femto) :          
                Answer answer1491 = new Answer()
                {
                    AnsDes = this.cellIdTextbox.Value,
                    QuestionId = 1491,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer1491);



                //  Network strength (>= -77.5 dBm) Section 1 :          
                Answer answer1492 = new Answer()
                {
                    AnsDes = this.netWorkstrTextboxS1.Value,
                    QuestionId = 1492,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer1492);

                //  Network strength (>= -77.5 dBm) Section 2 :          
                Answer answer1493 = new Answer()
                {
                    AnsDes = this.netWorkstrTextboxS2.Value,
                    QuestionId = 1493,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer1493);

                //  Network strength (>= -77.5 dBm) Section 3 :          
                Answer answer1494 = new Answer()
                {
                    AnsDes = this.netWorkstrTextboxS3.Value,
                    QuestionId = 1494,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer1494);

                // Download (for ONU/VSAT :          
                Answer answer1495 = new Answer()
                {
                    AnsDes = this.dowloadOnuTextbox.Value,
                    QuestionId = 1495,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer1495);

                // Upload (for ONU/VSAT) :          
                Answer answer1496 = new Answer()
                {
                    AnsDes = this.uploadforOnuTextbox.Value,
                    QuestionId = 1496,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer1496);

                // Ping Test (for ONU/VSAT) :          
                Answer answer1497 = new Answer()
                {
                    AnsDes = this.pinngtestforOnuTextbox.Value,
                    QuestionId = 1497,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer1497);

                // Download (for Mobile:          
                Answer answer1498 = new Answer()
                {
                    AnsDes = this.dowloadforMobileTextbox.Value,
                    QuestionId = 1498,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer1498);

                //  Upload (for Mobile :          
                Answer answer1499 = new Answer()
                {
                    AnsDes = this.uploadforMobileTextbox.Value,
                    QuestionId = 1499,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer1499);


                // Ping Test(for Mobile)
                Answer answe1500 = new Answer()
                {
                    AnsDes = this.pingtestFormobileTextbox.Value,
                    QuestionId = 1500,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answe1500);
                //////////////////////////////////   END Sectionid  = 135     /////////////////////////////////
                ///




                //////////////////////////////////    Sectionid  = 136     /////////////////////////////////
                ///

                //  ปัญหาที่พบ 1 :           
                Answer answer110 = new Answer()
                {
                    AnsDes = this.problemTextbox1.Value,
                    QuestionId = 1501,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer110);

                //  วิธีแก้ปัญหา 1 :           
                Answer answer111 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox1.Value,
                    QuestionId = 1502,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer111);



                //  ปัญหาที่พบ 2 :           
                Answer answer112 = new Answer()
                {
                    AnsDes = this.problemTextbox2.Value,
                    QuestionId = 1503,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer112);

                //  วิธีแก้ปัญหา 2 :           
                Answer answer113 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox2.Value,
                    QuestionId = 1504,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer113);



                //  ปัญหาที่พบ 3 :           
                Answer answer114 = new Answer()
                {
                    AnsDes = this.problemTextbox3.Value,
                    QuestionId = 1505,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer114);

                //  วิธีแก้ปัญหา 3 :           
                Answer answer115 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox3.Value,
                    QuestionId = 1506,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer115);



                //  ปัญหาที่พบ 4 :           
                Answer answer116 = new Answer()
                {
                    AnsDes = this.problemTextbox4.Value,
                    QuestionId = 1507,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer116);

                //  วิธีแก้ปัญหา 4 :           
                Answer answer117 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox4.Value,
                    QuestionId = 1508,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer117);





                //  ปัญหาที่พบ 5 :           
                Answer answer118 = new Answer()
                {
                    AnsDes = this.problemTextbox5.Value,
                    QuestionId = 1509,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer118);

                //  วิธีแก้ปัญหา 5 :           
                Answer answer119 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox5.Value,
                    QuestionId = 1510,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer119);


                //  ปัญหาที่พบ 6 :           
                Answer answer120 = new Answer()
                {
                    AnsDes = this.problemTextbox6.Value,
                    QuestionId = 1511,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer120);

                //  วิธีแก้ปัญหา 6 :           
                Answer answer121 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox6.Value,
                    QuestionId = 1512,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer121);

                //  ปัญหาที่พบ 7 :           
                Answer answer122 = new Answer()
                {
                    AnsDes = this.problemTextbox7.Value,
                    QuestionId = 1513,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer122);

                //  วิธีแก้ปัญหา 7 :           
                Answer answer123 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox7.Value,
                    QuestionId = 1514,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer123);



                ///////////////////////////////////////////////////////////////////////////////
                //  ปัญหาที่พบ 8 :           
                Answer answer124 = new Answer()
                {
                    AnsDes = this.problemTextbox8.Value,
                    QuestionId = 1515,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer124);

                //  วิธีแก้ปัญหา 8 :           
                Answer answer125 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox8.Value,
                    QuestionId = 1516,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer125);
                //////////////////////////////////////////////////////////////////////////////////



                ///////////////////////////////////////////////////////////////////////////////
                //  ปัญหาที่พบ 9 :           
                Answer answer126 = new Answer()
                {
                    AnsDes = this.problemTextbox9.Value,
                    QuestionId = 1517,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer126);

                //  วิธีแก้ปัญหา 9 :           
                Answer answer127 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox9.Value,
                    QuestionId = 1518,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer127);
                //////////////////////////////////////////////////////////////////////////////////



                ///////////////////////////////////////////////////////////////////////////////
                //  ปัญหาที่พบ 10 :           
                Answer answer128 = new Answer()
                {
                    AnsDes = this.problemTextbox10.Value,
                    QuestionId = 1519,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer128);

                //  วิธีแก้ปัญหา 10 :           
                Answer answer129 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox10.Value,
                    QuestionId = 1520,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer129);
                //////////////////////////////////////////////////////////////////////////////////
                ///




                ///////////////////////////////////////////////////////////////////////////////
                //  ปัญหาที่พบ 11 :           
                Answer answer130 = new Answer()
                {
                    AnsDes = this.problemTextbox11.Value,
                    QuestionId = 1521,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer130);

                //  วิธีแก้ปัญหา 11 :           
                Answer answer131 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox11.Value,
                    QuestionId = 1522,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer131);
                //////////////////////////////////////////////////////////////////////////////////
                ///






                ///////////////////////////////////////////////////////////////////////////////
                //  ปัญหาที่พบ 12 :           
                Answer answer132 = new Answer()
                {
                    AnsDes = this.problemTextbox12.Value,
                    QuestionId = 1523,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer132);

                //  วิธีแก้ปัญหา 12 :           
                Answer answer133 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox12.Value,
                    QuestionId = 1524,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer133);
                //////////////////////////////////////////////////////////////////////////////////
                ///




                ///////////////////////////////////////////////////////////////////////////////
                //  ปัญหาที่พบ 13 :           
                Answer answer134 = new Answer()
                {
                    AnsDes = this.problemTextbox13.Value,
                    QuestionId = 1525,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer134);

                //  วิธีแก้ปัญหา 13 :           
                Answer answer135 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox13.Value,
                    QuestionId = 1526,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer135);
                //////////////////////////////////////////////////////////////////////////////////
                ///



                ///////////////////////////////////////////////////////////////////////////////
                //  ปัญหาที่พบ 14 :           
                Answer answer136 = new Answer()
                {
                    AnsDes = this.problemTextbox14.Value,
                    QuestionId = 1527,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer136);

                //  วิธีแก้ปัญหา 14 :           
                Answer answer137 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox14.Value,
                    QuestionId = 1528,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer137);
                //////////////////////////////////////////////////////////////////////////////////
                ///




                ///////////////////////////////////////////////////////////////////////////////
                //  ปัญหาที่พบ 15 :           
                Answer answer138 = new Answer()
                {
                    AnsDes = this.problemTextbox15.Value,
                    QuestionId = 1529,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer138);

                //  วิธีแก้ปัญหา 15 :           
                Answer answer139 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox15.Value,
                    QuestionId = 1530,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer139);
                //////////////////////////////////////////////////////////////////////////////////

                //////////////////////////////////    END Sectionid  = 136     /////////////////////////////////
                ///












                //////////////////////////////////     Sectionid  = 137     /////////////////////////////////          



                //////////////////////////////////////////////////////////////////////////////////
                // รายการอุปกรณ์ 1 :      
                Answer answer141 = new Answer()
                {
                    AnsDes = this.toolsListTextbox1.Value,
                    QuestionId = 1531,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer141);

                //  SerialNumber :           
                Answer answer142 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox1.Value,
                    QuestionId = 1532,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer142);

                //  new SerialNumber :           
                Answer answer143 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox1.Value,
                    QuestionId = 1533,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer143);

                //  หมายเหตุ :           
                Answer answer144 = new Answer()
                {
                    AnsDes = this.noteTextbox1.Value,
                    QuestionId = 1534,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer144);
                //////////////////////////////////////////////////////////////////////////////////






                //////////////////////////////////////////////////////////////////////////////////
                // รายการอุปกรณ์ 2 :      
                Answer answer145 = new Answer()
                {
                    AnsDes = this.toolsListTextbox2.Value,
                    QuestionId = 1535,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer145);

                //  SerialNumber 2 :           
                Answer answer146 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox2.Value,
                    QuestionId = 1536,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer146);

                //  new SerialNumber 2 :           
                Answer answer147 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox2.Value,
                    QuestionId = 1537,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer147);

                //  หมายเหตุ  2:           
                Answer answer148 = new Answer()
                {
                    AnsDes = this.noteTextbox2.Value,
                    QuestionId = 1538,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer148);
                //////////////////////////////////////////////////////////////////////////////////



                //////////////////////////////////////////////////////////////////////////////////
                // รายการอุปกรณ์ 3 :      
                Answer answer149 = new Answer()
                {
                    AnsDes = this.toolsListTextbox3.Value,
                    QuestionId = 1539,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer149);

                //  SerialNumber 3 :           
                Answer answer150 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox3.Value,
                    QuestionId = 1540,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer150);

                //  new SerialNumber 3 :           
                Answer answer151 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox3.Value,
                    QuestionId = 1541,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer151);

                //  หมายเหตุ  3:           
                Answer answer152 = new Answer()
                {
                    AnsDes = this.noteTextbox3.Value,
                    QuestionId = 1542,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer152);
                //////////////////////////////////////////////////////////////////////////////////




                //////////////////////////////////////////////////////////////////////////////////
                // รายการอุปกรณ์ 4 :      
                Answer answer153 = new Answer()
                {
                    AnsDes = this.toolsListTextbox4.Value,
                    QuestionId = 1543,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer153);

                //  SerialNumber 4 :           
                Answer answer154 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox4.Value,
                    QuestionId = 1544,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer154);

                //  new SerialNumber 4 :           
                Answer answer155 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox4.Value,
                    QuestionId = 1545,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer155);

                //  หมายเหตุ  4:           
                Answer answer156 = new Answer()
                {
                    AnsDes = this.noteTextbox4.Value,
                    QuestionId = 1546,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer156);
                //////////////////////////////////////////////////////////////////////////////////




                //////////////////////////////////////////////////////////////////////////////////
                // รายการอุปกรณ์ 5 :      
                Answer answer157 = new Answer()
                {
                    AnsDes = this.toolsListTextbox5.Value,
                    QuestionId = 1547,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer157);

                //  SerialNumber 5 :           
                Answer answer158 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox5.Value,
                    QuestionId = 1548,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer158);

                //  new SerialNumber 5 :           
                Answer answer159 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox5.Value,
                    QuestionId = 1549,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer159);

                //  หมายเหตุ  5:           
                Answer answer160 = new Answer()
                {
                    AnsDes = this.noteTextbox5.Value,
                    QuestionId = 1550,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer160);
                //////////////////////////////////////////////////////////////////////////////////






                //////////////////////////////////////////////////////////////////////////////////
                // รายการอุปกรณ์ 6 :      
                Answer answer161 = new Answer()
                {
                    AnsDes = this.toolsListTextbox6.Value,
                    QuestionId = 1551,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer161);

                //  SerialNumber 6 :           
                Answer answer162 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox6.Value,
                    QuestionId = 1552,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer162);

                //  new SerialNumber 6 :           
                Answer answer163 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox6.Value,
                    QuestionId = 1553,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer163);

                //  หมายเหตุ  6:           
                Answer answer164 = new Answer()
                {
                    AnsDes = this.noteTextbox6.Value,
                    QuestionId = 1554,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer164);
                //////////////////////////////////////////////////////////////////////////////////




                //////////////////////////////////////////////////////////////////////////////////
                // รายการอุปกรณ์ 7 :      
                Answer answer165 = new Answer()
                {
                    AnsDes = this.toolsListTextbox7.Value,
                    QuestionId = 1555,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer165);

                //  SerialNumber 7 :           
                Answer answer166 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox7.Value,
                    QuestionId = 1556,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer166);

                //  new SerialNumber 7 :           
                Answer answer167 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox7.Value,
                    QuestionId = 1557,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer167);

                //  หมายเหตุ  7:           
                Answer answer168 = new Answer()
                {
                    AnsDes = this.noteTextbox7.Value,
                    QuestionId = 1558,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer168);
                //////////////////////////////////////////////////////////////////////////////////



                //////////////////////////////////////////////////////////////////////////////////
                // รายการอุปกรณ์ 8 :      
                Answer answer169 = new Answer()
                {
                    AnsDes = this.toolsListTextbox8.Value,
                    QuestionId = 1559,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer169);

                //  SerialNumber 8 :           
                Answer answer170 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox8.Value,
                    QuestionId = 1560,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer170);

                //  new SerialNumber 8 :           
                Answer answer171 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox8.Value,
                    QuestionId = 1561,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer171);

                //  หมายเหตุ  8:           
                Answer answer172 = new Answer()
                {
                    AnsDes = this.noteTextbox8.Value,
                    QuestionId = 1562,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer172);
                //////////////////////////////////////////////////////////////////////////////////



                //////////////////////////////////////////////////////////////////////////////////
                // รายการอุปกรณ์ 9 :      
                Answer answer173 = new Answer()
                {
                    AnsDes = this.toolsListTextbox9.Value,
                    QuestionId = 1563,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer173);

                //  SerialNumber 9 :           
                Answer answer174 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox9.Value,
                    QuestionId = 1564,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer174);

                //  new SerialNumber 9 :           
                Answer answer175 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox9.Value,
                    QuestionId = 1565,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer175);

                //  หมายเหตุ  9:           
                Answer answer176 = new Answer()
                {
                    AnsDes = this.noteTextbox9.Value,
                    QuestionId = 1566,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer176);
                //////////////////////////////////////////////////////////////////////////////////










                //////////////////////////////////////////////////////////////////////////////////
                // รายการอุปกรณ์ 10 :      
                Answer answer177 = new Answer()
                {
                    AnsDes = this.toolsListTextbox10.Value,
                    QuestionId = 1567,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer177);

                //  SerialNumber 10 :           
                Answer answer178 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox10.Value,
                    QuestionId = 1568,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer178);

                //  new SerialNumber 10 :           
                Answer answer179 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox10.Value,
                    QuestionId = 1569,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer179);

                //  หมายเหตุ  10:           
                Answer answer180 = new Answer()
                {
                    AnsDes = this.noteTextbox10.Value,
                    QuestionId = 1570,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer180);
                //////////////////////////////////////////////////////////////////////////////////






                //////////////////////////////////////////////////////////////////////////////////
                // รายการอุปกรณ์ 11 :      
                Answer answer181 = new Answer()
                {
                    AnsDes = this.toolsListTextbox11.Value,
                    QuestionId = 1571,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer181);

                //  SerialNumber 11 :           
                Answer answer182 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox11.Value,
                    QuestionId = 1572,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer182);

                //  new SerialNumber 11 :           
                Answer answer183 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox11.Value,
                    QuestionId = 1573,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer183);

                //  หมายเหตุ  11:           
                Answer answer184 = new Answer()
                {
                    AnsDes = this.noteTextbox11.Value,
                    QuestionId = 1574,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer184);
                //////////////////////////////////////////////////////////////////////////////////
                ///








                //////////////////////////////////////////////////////////////////////////////////
                // รายการอุปกรณ์ 12 :      
                Answer answer185 = new Answer()
                {
                    AnsDes = this.toolsListTextbox12.Value,
                    QuestionId = 1575,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer185);

                //  SerialNumber 12 :           
                Answer answer186 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox12.Value,
                    QuestionId = 1576,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer186);

                //  new SerialNumber 12 :           
                Answer answer187 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox12.Value,
                    QuestionId = 1577,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer187);

                //  หมายเหตุ  12:           
                Answer answer188 = new Answer()
                {
                    AnsDes = this.noteTextbox12.Value,
                    QuestionId = 1578,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer188);
                //////////////////////////////////////////////////////////////////////////////////
                ///






                //////////////////////////////////////////////////////////////////////////////////
                // รายการอุปกรณ์ 13 :      
                Answer answer189 = new Answer()
                {
                    AnsDes = this.toolsListTextbox13.Value,
                    QuestionId = 1579,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer189);

                //  SerialNumber 13 :           
                Answer answer190 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox13.Value,
                    QuestionId = 1580,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer190);

                //  new SerialNumber 13 :           
                Answer answer191 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox13.Value,
                    QuestionId = 1581,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer191);

                //  หมายเหตุ  13   :    
                Answer answer192 = new Answer()
                {
                    AnsDes = this.noteTextbox13.Value,
                    QuestionId = 1582,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer192);
                //////////////////////////////////////////////////////////////////////////////////



                //////////////////////////////////////////////////////////////////////////////////
                // รายการอุปกรณ์ 14 :      
                Answer answer193 = new Answer()
                {
                    AnsDes = this.toolsListTextbox14.Value,
                    QuestionId = 1583,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer193);

                //  SerialNumber 14 :           
                Answer answer194 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox14.Value,
                    QuestionId = 1584,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer194);

                //  new SerialNumber 14 :           
                Answer answer195 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox14.Value,
                    QuestionId = 1585,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer195);

                //  หมายเหตุ  143   :    
                Answer answer196 = new Answer()
                {
                    AnsDes = this.noteTextbox14.Value,
                    QuestionId = 1586,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer196);
                //////////////////////////////////////////////////////////////////////////////////






                //////////////////////////////////////////////////////////////////////////////////
                // รายการอุปกรณ์ 15 :      
                Answer answer197 = new Answer()
                {
                    AnsDes = this.toolsListTextbox15.Value,
                    QuestionId = 1587,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer197);

                //  SerialNumber 15 :           
                Answer answer198 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox15.Value,
                    QuestionId = 1588,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer198);

                //  new SerialNumber 15 :           
                Answer answer199 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox15.Value,
                    QuestionId = 1589,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer199);

                //  หมายเหตุ  15   :    
                Answer answer200 = new Answer()
                {
                    AnsDes = this.noteTextbox15.Value,
                    QuestionId = 1590,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer200);
                //////////////////////////////////////////////////////////////////////////////////
                ///

                //////////////////////////////////   END Sectionid  = 137     /////////////////////////////////



                //////////////////////////////////    Sectionid  = 138     /////////////////////////////////
                //   name pm :    
                Answer answer1591 = new Answer()
                {
                    AnsDes = this.nameDopmTextbox.Value,
                    QuestionId = 1591,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer1591);


                //  นที่ทำ PM :    
                Answer answer1592 = new Answer()
                {
                    AnsDes = this.dayDopmTextbox.Value,
                    QuestionId = 1592,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer1592);
                //////////////////////////////////   END Sectionid  = 138     /////////////////////////////////









                //////////////////////////////////    Sectionid  = 139     /////////////////////////////////



                // รูปภาพรวมบริเวณ Site :
                string steAreaRadio = Request.Form["steAreaRadio"];
                Answer answer1593 = new Answer()
                {
                    AnsDes = steAreaRadio,
                    QuestionId = 1593,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer1593);


                // รูปภาพรวมบริเวณ Site :
                string beforeAfterRadio = Request.Form["beforeAfterRadio"];
                Answer answer1594 = new Answer()
                {
                    AnsDes = beforeAfterRadio,
                    QuestionId = 1594,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer1594);


                // รูปภายในตู้ ก่อน-หลัง :
                string picIncontainRadio = Request.Form["picIncontainRadio"];
                Answer answer1595 = new Answer()
                {
                    AnsDes = picIncontainRadio,
                    QuestionId = 1595,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer1595);


                // รูปขณะทำความสะอาดตู้ ก่อน-หลัง :
                string beforeCleanRaio = Request.Form["beforeCleanRaio"];
                Answer answer1596 = new Answer()
                {
                    AnsDes = beforeCleanRaio,
                    QuestionId = 1596,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer1596);


                // รูปสถานะ Circuit Breaker (ON):
                string circuitBreakOnRaio = Request.Form["circuitBreakOnRaio"];
                Answer answer1597 = new Answer()
                {
                    AnsDes = beforeCleanRaio,
                    QuestionId = 1597,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer1597);


                // รูป Circuit Breaker ภายในตู้:
                string circuitInRadio = Request.Form["circuitInRadio"];
                Answer answer1598 = new Answer()
                {
                    AnsDes = circuitInRadio,
                    QuestionId = 1598,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer1598);



                // รูป Circuit Breaker ภายในตู้:
                string terminalRaio = Request.Form["terminalRaio"];
                Answer answer1599 = new Answer()
                {
                    AnsDes = terminalRaio,
                    QuestionId = 1599,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer1599);



                // รูปการตรวจสอบ Ground และ Bar Ground :
                string GroundAndBarGroundRaio = Request.Form["GroundAndBarGroundRaio"];
                Answer answer1600 = new Answer()
                {
                    AnsDes = GroundAndBarGroundRaio,
                    QuestionId = 1600,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer1600);


                // รูปการตรวจสอบสถานะไฟฟ้ารั่วลง Ground (Lamp Test:
                string groundLampRadio = Request.Form["groundLampRadio"];
                Answer answer1601 = new Answer()
                {
                    AnsDes = groundLampRadio,
                    QuestionId = 1601,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer1601);

                // รูป PEA Meter :
                string peaMeterRaio = Request.Form["peaMeterRaio"];
                Answer answer1602 = new Answer()
                {
                    AnsDes = peaMeterRaio,
                    QuestionId = 1602,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer1602);


                // >รูปการวัดแรงดัน AC และกระแส AC :
                string acAndACRadio = Request.Form["acAndACRadio"];
                Answer answer1603 = new Answer()
                {
                    AnsDes = acAndACRadio,
                    QuestionId = 1603,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer1603);


                // รูปหน้าจอ UPS แสดงค่าต่างๆ และ Serial NO. :
                string monitorSerRadio = Request.Form["monitorSerRadio"];
                Answer answer1604 = new Answer()
                {
                    AnsDes = acAndACRadio,
                    QuestionId = 1604,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer1604);



                // รูป ONU/Modem พร้อม Serial NO. และ MAC :
                string ONUModemAndMacRadio = Request.Form["ONUModemAndMacRadio"];
                Answer answer1605 = new Answer()
                {
                    AnsDes = ONUModemAndMacRadio,
                    QuestionId = 1605,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer1605);



                // รูปการ Test Speed ONU (30/10 mbps) :
                string testSpeedOnuRadio = Request.Form["testSpeedOnuRadio"];
                Answer answer1606 = new Answer()
                {
                    AnsDes = testSpeedOnuRadio,
                    QuestionId = 1606,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer1606);


                // รูปการ Test Network strength (>= -77.5 dBm) Section 1:
                string pictestNetworkRadioSec1 = Request.Form["pictestNetworkRadioSec1"];
                Answer answer1607 = new Answer()
                {
                    AnsDes = pictestNetworkRadioSec1,
                    QuestionId = 1607,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer1607);


                // รูปการ Test Network strength (>= -77.5 dBm) Section 2:
                string pictestNetworkRadioSec2 = Request.Form["pictestNetworkRadioSec2"];
                Answer answer1608 = new Answer()
                {
                    AnsDes = pictestNetworkRadioSec2,
                    QuestionId = 1608,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer1608);


                // รูปการ Test Network strength (>= -77.5 dBm) Section 3:
                string pictestNetworkRadioSec3 = Request.Form["pictestNetworkRadioSec3"];
                Answer answer1609 = new Answer()
                {
                    AnsDes = pictestNetworkRadioSec3,
                    QuestionId = 1609,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer1609);


                // รูปการ Test Network strength (>= -77.5 dBm) Section 3:
                string testSpeedVsatRadio = Request.Form["testSpeedVsatRadio"];
                Answer answer1610 = new Answer()
                {
                    AnsDes = testSpeedVsatRadio,
                    QuestionId = 1610,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer1610);

                //รูป Femto พร้อม Serial NO. และ MAC :
                string femtoSerandMacRaio = Request.Form["femtoSerandMacRaio"];
                Answer answer1611 = new Answer()
                {
                    AnsDes = femtoSerandMacRaio,
                    QuestionId = 1611,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer1611);


                //รูปการ Test Femto 3G (PSC 408-412)   :
                string testFemtoRadio = Request.Form["testFemtoRadio"];
                Answer answer1612 = new Answer()
                {
                    AnsDes = testFemtoRadio,
                    QuestionId = 1612,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer1612);




                // รูปการ Test Femto 4G(PCI 480 - 503) * เฉพาะ 4G:
                string testFemto4gRadio = Request.Form["testFemto4gRadio"];
                Answer answer1613 = new Answer()
                {
                    AnsDes = testFemto4gRadio,
                    QuestionId = 1613,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer1613);






                // ---------------------    SECTION ID 140   -----------------------------

                // รูปจุดติดตั้งจานดาวเทียม :
                string inStallSatRadio = Request.Form["inStallSatRadio"];
                Answer answer1614 = new Answer()
                {
                    AnsDes = inStallSatRadio,
                    QuestionId = 1614,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer1614);


                // รูปความสะอาดบริเวณจานดาวเทียม :
                string cleanSatRadio = Request.Form["cleanSatRadio"];
                Answer answer1615 = new Answer()
                {
                    AnsDes = cleanSatRadio,
                    QuestionId = 1615,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer1615);



                //รูป LNB พร้อม Part NO :
                string lnbWithpartRadio = Request.Form["lnbWithpartRadio"];
                Answer answer1616 = new Answer()
                {
                    AnsDes = lnbWithpartRadio,
                    QuestionId = 1616,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer1616);


                //รูป BUC พร้อม Part NO :
                string bucWithpartRadio = Request.Form["bucWithpartRadio"];
                Answer answer1617 = new Answer()
                {
                    AnsDes = bucWithpartRadio,
                    QuestionId = 1617,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer1617);


                //รูปการเก็บสายและพันหัวที่ LNB/BUC :
                string wireingLnbRadio = Request.Form["wireingLnbRadio"];
                Answer answer1618 = new Answer()
                {
                    AnsDes = wireingLnbRadio,
                    QuestionId = 1618,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer1618);


                //แนว Line Of Sight (ดูการถูกบังของหน้าจานดาวเทียม)  :
                string lineOfsightRadio = Request.Form["lineOfsightRadio"];
                Answer answer1619 = new Answer()
                {
                    AnsDes = lineOfsightRadio,
                    QuestionId = 1619,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer1619);

                // ---------------------    END SECTION ID 140   -----------------------------



                // ---------------------    SECTION ID 141   -----------------------------



                //รูปจุดติดตั้ง Solar Cell  :
                string solarCellRadio = Request.Form["solarCellRadio"];
                Answer answer1620 = new Answer()
                {
                    AnsDes = solarCellRadio,
                    QuestionId = 1620,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer1620);


                //รูปจุดติดตั้ง Solar Cell :
                string toolsinSolarcellRadio = Request.Form["toolsinSolarcellRadio"];
                Answer answer1621 = new Answer()
                {
                    AnsDes = toolsinSolarcellRadio,
                    QuestionId = 1621,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer1621);


                //รูปอุปกรณ์ภายในตู้ Solar Cell :
                string monitoringChargerRadio = Request.Form["monitoringChargerRadio"];
                Answer answer1622 = new Answer()
                {
                    AnsDes = toolsinSolarcellRadio,
                    QuestionId = 1622,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer1622);



                // รูปหน้าจอ Inverter แสดงค่าต่างๆ :
                string moniteringInverterRadio = Request.Form["moniteringInverterRadio"];
                Answer answer1623 = new Answer()
                {
                    AnsDes = moniteringInverterRadio,
                    QuestionId = 1623,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer1623);


                // รูปความสะอาดแผง PV :
                string cleaningPVRadio = Request.Form["cleaningPVRadio"];
                Answer answer1624 = new Answer()
                {
                    AnsDes = cleaningPVRadio,
                    QuestionId = 1624,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer1624);


                // รูปภาพรวมดูสิ่งบดบังแสงอาทิตย์ :
                string sunRiseingRadio = Request.Form["sunRiseingRadio"];
                Answer answer1625 = new Answer()
                {
                    AnsDes = sunRiseingRadio,
                    QuestionId = 1625,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer1625);



                // รูปการวัดแรงดัน Battery ก้อนที่ 1 :
                string batteryVoltRadio1 = Request.Form["batteryVoltRadio1"];
                Answer answer1626 = new Answer()
                {
                    AnsDes = batteryVoltRadio1,
                    QuestionId = 1626,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer1626);

                // รูปการวัดแรงดัน Battery ก้อนที่ 2 :
                string batteryVoltRadio2 = Request.Form["batteryVoltRadio2"];
                Answer answer1627 = new Answer()
                {
                    AnsDes = batteryVoltRadio2,
                    QuestionId = 1627,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer1627);



                // รูปการวัดแรงดัน Battery ก้อนที่ 3 :
                string batteryVoltRadio3 = Request.Form["batteryVoltRadio3"];
                Answer answer1628 = new Answer()
                {
                    AnsDes = batteryVoltRadio3,
                    QuestionId = 1628,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer1628);



                // รูปการวัดแรงดัน Battery ก้อนที่ 4 :
                string batteryVoltRadio4 = Request.Form["batteryVoltRadio4"];
                Answer answer1629 = new Answer()
                {
                    AnsDes = batteryVoltRadio4,
                    QuestionId = 1629,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                };
                uSOEntities.Answers.Add(answer1629);




                //1.รูป PICTURE CHECKLIST :
                if (this.pictureChecklistImages.HasFile)
                {
                    string extension = this.pictureChecklistImages.PostedFile.FileName.Split('.')[1];
                    string newFileName = "images/pictureChecklist_" + DateTime.Now.ToString("yyyyMMddHHmmss") + "." + extension;
                    this.pictureChecklistImages.PostedFile.SaveAs(Server.MapPath(newFileName));

                    Answer answer259 = new Answer()
                    {
                        AnsDes = newFileName,
                        QuestionId = 1630,
                        AnserTypeId = 3,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth,
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
                        QuestionId = 1631,
                        AnserTypeId = 3,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth,
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
                        QuestionId = 1632,
                        AnserTypeId = 3,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth,
                    };
                    uSOEntities.Answers.Add(answer261);
                }














































                int result = uSOEntities.SaveChanges();
                if (result > 0)
                {
                    this.SuccessPanel.Visible = true;
                }
            }








        


    }
}
