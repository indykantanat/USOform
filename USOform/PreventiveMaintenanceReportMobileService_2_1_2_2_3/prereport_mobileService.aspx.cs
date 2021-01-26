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
    }
}
