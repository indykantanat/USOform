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

namespace USOform.PreventiveMaintenanceReportMobileService_2_1_2_2_3
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
        }

        void SetForm()
        {

            this.groupLabel.Text = answers.Where(x => x.QuestionId == 1409).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1409).FirstOrDefault().AnsDes : "";
            this.AreaLabel.Text = answers.Where(x => x.QuestionId == 1410).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1410).FirstOrDefault().AnsDes : "";
            this.CompanyLabel.Text = answers.Where(x => x.QuestionId == 1411).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1411).FirstOrDefault().AnsDes : "";
            this.maintenanceCountLabel.Text = answers.Where(x => x.QuestionId == 1413).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1413).FirstOrDefault().AnsDes : "";
            this.yearLabel.Text = answers.Where(x => x.QuestionId == 1414).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1414).FirstOrDefault().AnsDes : "";
            this.startDatepickerLabel.Text = answers.Where(x => x.QuestionId == 1415).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1415).FirstOrDefault().AnsDes : "";
            this.endDatepickerLabel.Text = answers.Where(x => x.QuestionId == 1416).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1416).FirstOrDefault().AnsDes : "";
            this.siteCodeLabel.Text = answers.Where(x => x.QuestionId == 1417).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1417).FirstOrDefault().AnsDes : "";
            this.cabinetIdLabel.Text = answers.Where(x => x.QuestionId == 1418).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1418).FirstOrDefault().AnsDes : "";
            this.sitecodeLabelSection2.Text = answers.Where(x => x.QuestionId == 1419).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1419).FirstOrDefault().AnsDes : "";
            this.VillageIdLabel.Text = answers.Where(x => x.QuestionId == 1420).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1420).FirstOrDefault().AnsDes : "";
            this.villageLabel.Text = answers.Where(x => x.QuestionId == 1421).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1421).FirstOrDefault().AnsDes : "";
            this.subdistrictLabel.Text = answers.Where(x => x.QuestionId == 1422).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1422).FirstOrDefault().AnsDes : "";
            this.DistrictLabel1.Text = answers.Where(x => x.QuestionId == 1423).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1423).FirstOrDefault().AnsDes : "";
            this.provinceLabel.Text = answers.Where(x => x.QuestionId == 1424).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1424).FirstOrDefault().AnsDes : "";
            this.typeLabel.Text = answers.Where(x => x.QuestionId == 1425).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1425).FirstOrDefault().AnsDes : "";
            this.pmdateLabel.Text = answers.Where(x => x.QuestionId == 1426).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1426).FirstOrDefault().AnsDes : "";

            //this.SignatureExcutorImage.ImageUrl = answers.Where(x => x.QuestionId == 1428).FirstOrDefault() != null ? this.GetImage(Convert.FromBase64String(answers.Where(x => x.QuestionId == 1428).FirstOrDefault().AnsDes)) : "";
            //  this.redrawSignature.ImageUrl = answers.Where(x => x.QuestionId == 1428).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1428).FirstOrDefault().AnsDes : "";
            //this.signatureSupervisorLabel.Text = answers.Where(x => x.QuestionId == 1431).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1415).FirstOrDefault().AnsDes : "";
            this.nameExecutorLabel.Text = answers.Where(x => x.QuestionId == 1432).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1432).FirstOrDefault().AnsDes : "";
            this.nameSupervisorLabel.Text = answers.Where(x => x.QuestionId == 1433).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1433).FirstOrDefault().AnsDes : "";
            this.DateExecutorLabel.Text = answers.Where(x => x.QuestionId == 1434).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1434).FirstOrDefault().AnsDes : "";
            this.DateSupervisorLabel.Text = answers.Where(x => x.QuestionId == 1435).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1435).FirstOrDefault().AnsDes : "";
            this.cabinetId2Label.Text = answers.Where(x => x.QuestionId == 1436).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1436).FirstOrDefault().AnsDes : "";
            this.sitecodeLabelSection4.Text = answers.Where(x => x.QuestionId == 1437).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1437).FirstOrDefault().AnsDes : "";
            this.villageIDLabelSection4.Text = answers.Where(x => x.QuestionId == 1438).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1438).FirstOrDefault().AnsDes : "";
            this.latandlongLabel.Text = answers.Where(x => x.QuestionId == 1439).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1439).FirstOrDefault().AnsDes : "";
            this.oltorispLabel.Text = answers.Where(x => x.QuestionId == 1440).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1440).FirstOrDefault().AnsDes : "";
            this.numberIdLabel.Text = answers.Where(x => x.QuestionId == 1442).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1442).FirstOrDefault().AnsDes : "";
            this.kwhMeterLabel.Text = answers.Where(x => x.QuestionId == 1443).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1443).FirstOrDefault().AnsDes : "";
            this.acvoltLabel.Text = answers.Where(x => x.QuestionId == 1444).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1444).FirstOrDefault().AnsDes : "";
            this.lineAcLabel.Text = answers.Where(x => x.QuestionId == 1445).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1445).FirstOrDefault().AnsDes : "";
            this.neutronAcLabel.Text = answers.Where(x => x.QuestionId == 1446).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1446).FirstOrDefault().AnsDes : "";
            this.acfromupsLabel.Text = answers.Where(x => x.QuestionId == 1450).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1450).FirstOrDefault().AnsDes : "";
            this.voltInverterLabel.Text = answers.Where(x => x.QuestionId == 1483).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1483).FirstOrDefault().AnsDes : "";
            this.loadVoltTageLabel.Text = answers.Where(x => x.QuestionId == 1484).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1484).FirstOrDefault().AnsDes : "";
            this.batterLabel1.Text = answers.Where(x => x.QuestionId == 1485).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1485).FirstOrDefault().AnsDes : "";
            this.batterLabel2.Text = answers.Where(x => x.QuestionId == 1486).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1486).FirstOrDefault().AnsDes : "";
            this.batterLabel3.Text = answers.Where(x => x.QuestionId == 1487).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1487).FirstOrDefault().AnsDes : "";
            this.batterLabel4.Text = answers.Where(x => x.QuestionId == 1488).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1488).FirstOrDefault().AnsDes : "";
            this.cellIdLabel.Text = answers.Where(x => x.QuestionId == 1491).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1491).FirstOrDefault().AnsDes : "";
            this.netWorkstrLabelS1.Text = answers.Where(x => x.QuestionId == 1492).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1492).FirstOrDefault().AnsDes : "";
            this.netWorkstrLabelS2.Text = answers.Where(x => x.QuestionId == 1493).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1493).FirstOrDefault().AnsDes : "";
            this.netWorkstrLabelS3.Text = answers.Where(x => x.QuestionId == 1494).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1494).FirstOrDefault().AnsDes : "";
            this.dowloadOnuLabel.Text = answers.Where(x => x.QuestionId == 1495).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1495).FirstOrDefault().AnsDes : "";
            this.uploadforOnuLabel.Text = answers.Where(x => x.QuestionId == 1496).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1496).FirstOrDefault().AnsDes : "";
            this.pinngtestforOnuLabel.Text = answers.Where(x => x.QuestionId == 1497).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1497).FirstOrDefault().AnsDes : "";
            this.dowloadforMobileLabel.Text = answers.Where(x => x.QuestionId == 1498).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1498).FirstOrDefault().AnsDes : "";
            this.uploadforMobileLabel.Text = answers.Where(x => x.QuestionId == 1499).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1499).FirstOrDefault().AnsDes : "";
            this.pingtestFormobileLabel.Text = answers.Where(x => x.QuestionId == 1500).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1500).FirstOrDefault().AnsDes : "";

            //ปัญหาที่พบและการแก้ไข
            this.problemLabel1.Text = answers.Where(x => x.QuestionId == 1501).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1501).FirstOrDefault().AnsDes : "";
            this.howtoSolveLabel1.Text = answers.Where(x => x.QuestionId == 1502).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1502).FirstOrDefault().AnsDes : "";
            this.problemLabel2.Text = answers.Where(x => x.QuestionId == 1503).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1503).FirstOrDefault().AnsDes : "";
            this.howtoSolveLabel2.Text = answers.Where(x => x.QuestionId == 1504).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1504).FirstOrDefault().AnsDes : "";
            this.problemLabel3.Text = answers.Where(x => x.QuestionId == 1505).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1505).FirstOrDefault().AnsDes : "";
            this.howtoSolveLabel3.Text = answers.Where(x => x.QuestionId == 1506).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1506).FirstOrDefault().AnsDes : "";
            this.problemLabel4.Text = answers.Where(x => x.QuestionId == 1507).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1507).FirstOrDefault().AnsDes : "";
            this.howtoSolveLabel4.Text = answers.Where(x => x.QuestionId == 1508).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1508).FirstOrDefault().AnsDes : "";
            this.problemLabel5.Text = answers.Where(x => x.QuestionId == 1509).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1509).FirstOrDefault().AnsDes : "";
            this.howtoSolveLabel5.Text = answers.Where(x => x.QuestionId == 1510).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1510).FirstOrDefault().AnsDes : "";
            this.problemLabel6.Text = answers.Where(x => x.QuestionId == 1511).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1511).FirstOrDefault().AnsDes : "";
            this.howtoSolveLabel6.Text = answers.Where(x => x.QuestionId == 1512).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1512).FirstOrDefault().AnsDes : "";
            this.problemLabel7.Text = answers.Where(x => x.QuestionId == 1513).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1513).FirstOrDefault().AnsDes : "";
            this.howtoSolveLabel7.Text = answers.Where(x => x.QuestionId == 1514).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1514).FirstOrDefault().AnsDes : "";
            this.problemLabel8.Text = answers.Where(x => x.QuestionId == 1515).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1515).FirstOrDefault().AnsDes : "";
            this.howtoSolveLabel8.Text = answers.Where(x => x.QuestionId == 1516).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1516).FirstOrDefault().AnsDes : "";
            this.problemLabel9.Text = answers.Where(x => x.QuestionId == 1517).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1517).FirstOrDefault().AnsDes : "";
            this.howtoSolveLabel9.Text = answers.Where(x => x.QuestionId == 1518).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1518).FirstOrDefault().AnsDes : "";
            this.problemLabel10.Text = answers.Where(x => x.QuestionId == 1519).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1519).FirstOrDefault().AnsDes : "";
            this.howtoSolveLabel10.Text = answers.Where(x => x.QuestionId == 1520).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1520).FirstOrDefault().AnsDes : "";
            this.problemLabel11.Text = answers.Where(x => x.QuestionId == 1521).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1521).FirstOrDefault().AnsDes : "";
            this.howtoSolveLabel11.Text = answers.Where(x => x.QuestionId == 1522).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1522).FirstOrDefault().AnsDes : "";
            this.problemLabel12.Text = answers.Where(x => x.QuestionId == 1523).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1523).FirstOrDefault().AnsDes : "";
            this.howtoSolveLabel12.Text = answers.Where(x => x.QuestionId == 1524).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1524).FirstOrDefault().AnsDes : "";
            this.problemLabel13.Text = answers.Where(x => x.QuestionId == 1525).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1525).FirstOrDefault().AnsDes : "";
            this.howtoSolveLabel13.Text = answers.Where(x => x.QuestionId == 1526).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1526).FirstOrDefault().AnsDes : "";
            this.problemLabel14.Text = answers.Where(x => x.QuestionId == 1527).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1527).FirstOrDefault().AnsDes : "";
            this.howtoSolveLabel14.Text = answers.Where(x => x.QuestionId == 1528).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1528).FirstOrDefault().AnsDes : "";
            this.problemLabel15.Text = answers.Where(x => x.QuestionId == 1529).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1529).FirstOrDefault().AnsDes : "";
            this.howtoSolveLabel15.Text = answers.Where(x => x.QuestionId == 1530).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1530).FirstOrDefault().AnsDes : "";

            //ข้อมูลรายการทรัพย์สิน
            this.toolsListLabel1.Text = answers.Where(x => x.QuestionId == 1531).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1531).FirstOrDefault().AnsDes : "";
            this.serialNumberLabel1.Text = answers.Where(x => x.QuestionId == 1532).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1532).FirstOrDefault().AnsDes : "";
            this.newSerialNumberLabel1.Text = answers.Where(x => x.QuestionId == 1533).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1533).FirstOrDefault().AnsDes : "";
            this.noteLabel1.Text = answers.Where(x => x.QuestionId == 1534).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1534).FirstOrDefault().AnsDes : "";
            this.toolsListLabel2.Text = answers.Where(x => x.QuestionId == 1535).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1535).FirstOrDefault().AnsDes : "";
            this.serialNumberLabel2.Text = answers.Where(x => x.QuestionId == 1536).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1536).FirstOrDefault().AnsDes : "";
            this.newSerialNumberLabel2.Text = answers.Where(x => x.QuestionId == 1537).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1537).FirstOrDefault().AnsDes : "";
            this.noteLabel2.Text = answers.Where(x => x.QuestionId == 1538).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1538).FirstOrDefault().AnsDes : "";
            this.toolsListLabel3.Text = answers.Where(x => x.QuestionId == 1539).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1539).FirstOrDefault().AnsDes : "";
            this.serialNumberLabel3.Text = answers.Where(x => x.QuestionId == 1540).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1540).FirstOrDefault().AnsDes : "";
            this.newSerialNumberLabel3.Text = answers.Where(x => x.QuestionId == 1541).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1541).FirstOrDefault().AnsDes : "";
            this.noteLabel3.Text = answers.Where(x => x.QuestionId == 1542).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1542).FirstOrDefault().AnsDes : "";
            this.toolsListLabel4.Text = answers.Where(x => x.QuestionId == 1543).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1543).FirstOrDefault().AnsDes : "";
            this.serialNumberLabel4.Text = answers.Where(x => x.QuestionId == 1544).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1544).FirstOrDefault().AnsDes : "";
            this.newSerialNumberLabel4.Text = answers.Where(x => x.QuestionId == 1545).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1545).FirstOrDefault().AnsDes : "";
            this.noteLabel4.Text = answers.Where(x => x.QuestionId == 1546).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1546).FirstOrDefault().AnsDes : "";
            this.toolsListLabel5.Text = answers.Where(x => x.QuestionId == 1547).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1547).FirstOrDefault().AnsDes : "";
            this.serialNumberLabel5.Text = answers.Where(x => x.QuestionId == 1548).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1548).FirstOrDefault().AnsDes : "";
            this.newSerialNumberLabel5.Text = answers.Where(x => x.QuestionId == 1549).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1549).FirstOrDefault().AnsDes : "";
            this.noteLabel5.Text = answers.Where(x => x.QuestionId == 1550).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1550).FirstOrDefault().AnsDes : "";
            this.toolsListLabel6.Text = answers.Where(x => x.QuestionId == 1551).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1551).FirstOrDefault().AnsDes : "";
            this.serialNumberLabel6.Text = answers.Where(x => x.QuestionId == 1552).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1552).FirstOrDefault().AnsDes : "";
            this.newSerialNumberLabel6.Text = answers.Where(x => x.QuestionId == 1553).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1553).FirstOrDefault().AnsDes : "";
            this.noteLabel6.Text = answers.Where(x => x.QuestionId == 1554).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1554).FirstOrDefault().AnsDes : "";
            this.toolsListLabel7.Text = answers.Where(x => x.QuestionId == 1555).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1555).FirstOrDefault().AnsDes : "";
            this.serialNumberLabel7.Text = answers.Where(x => x.QuestionId == 1556).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1556).FirstOrDefault().AnsDes : "";
            this.newSerialNumberLabel7.Text = answers.Where(x => x.QuestionId == 1557).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1557).FirstOrDefault().AnsDes : "";
            this.noteLabel7.Text = answers.Where(x => x.QuestionId == 1558).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1558).FirstOrDefault().AnsDes : "";
            this.toolsListLabel8.Text = answers.Where(x => x.QuestionId == 1559).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1559).FirstOrDefault().AnsDes : "";
            this.serialNumberLabel8.Text = answers.Where(x => x.QuestionId == 1560).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1560).FirstOrDefault().AnsDes : "";
            this.newSerialNumberLabel8.Text = answers.Where(x => x.QuestionId == 1561).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1561).FirstOrDefault().AnsDes : "";
            this.noteLabel8.Text = answers.Where(x => x.QuestionId == 1562).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1562).FirstOrDefault().AnsDes : "";
            this.toolsListLabel9.Text = answers.Where(x => x.QuestionId == 1563).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1563).FirstOrDefault().AnsDes : "";
            this.serialNumberLabel9.Text = answers.Where(x => x.QuestionId == 1564).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1564).FirstOrDefault().AnsDes : "";
            this.newSerialNumberLabel9.Text = answers.Where(x => x.QuestionId == 1565).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1565).FirstOrDefault().AnsDes : "";
            this.noteLabel9.Text = answers.Where(x => x.QuestionId == 1566).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1566).FirstOrDefault().AnsDes : "";
            this.toolsListLabel10.Text = answers.Where(x => x.QuestionId == 1567).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1567).FirstOrDefault().AnsDes : "";
            this.serialNumberLabel10.Text = answers.Where(x => x.QuestionId == 1568).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1568).FirstOrDefault().AnsDes : "";
            this.newSerialNumberLabel10.Text = answers.Where(x => x.QuestionId == 1569).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1569).FirstOrDefault().AnsDes : "";
            this.noteLabel10.Text = answers.Where(x => x.QuestionId == 1570).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1570).FirstOrDefault().AnsDes : "";
            this.toolsListLabel11.Text = answers.Where(x => x.QuestionId == 1571).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1571).FirstOrDefault().AnsDes : "";
            this.serialNumberLabel11.Text = answers.Where(x => x.QuestionId == 1572).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1572).FirstOrDefault().AnsDes : "";
            this.newSerialNumberLabel11.Text = answers.Where(x => x.QuestionId == 1573).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1573).FirstOrDefault().AnsDes : "";
            this.noteLabel11.Text = answers.Where(x => x.QuestionId == 1574).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1574).FirstOrDefault().AnsDes : "";
            this.toolsListLabel12.Text = answers.Where(x => x.QuestionId == 1575).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1575).FirstOrDefault().AnsDes : "";
            this.serialNumberLabel12.Text = answers.Where(x => x.QuestionId == 1576).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1576).FirstOrDefault().AnsDes : "";
            this.newSerialNumberLabel12.Text = answers.Where(x => x.QuestionId == 1577).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1577).FirstOrDefault().AnsDes : "";
            this.noteLabel12.Text = answers.Where(x => x.QuestionId == 1578).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1578).FirstOrDefault().AnsDes : "";
            this.toolsListLabel13.Text = answers.Where(x => x.QuestionId == 1579).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1579).FirstOrDefault().AnsDes : "";
            this.serialNumberLabel13.Text = answers.Where(x => x.QuestionId == 1580).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1580).FirstOrDefault().AnsDes : "";
            this.newSerialNumberLabel13.Text = answers.Where(x => x.QuestionId == 1581).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1581).FirstOrDefault().AnsDes : "";
            this.noteLabel13.Text = answers.Where(x => x.QuestionId == 1582).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1582).FirstOrDefault().AnsDes : "";
            this.toolsListLabel14.Text = answers.Where(x => x.QuestionId == 1583).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1583).FirstOrDefault().AnsDes : "";
            this.serialNumberLabel14.Text = answers.Where(x => x.QuestionId == 1584).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1584).FirstOrDefault().AnsDes : "";
            this.newSerialNumberLabel14.Text = answers.Where(x => x.QuestionId == 1585).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1585).FirstOrDefault().AnsDes : "";
            this.noteLabel14.Text = answers.Where(x => x.QuestionId == 1586).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1586).FirstOrDefault().AnsDes : "";
            this.toolsListLabel15.Text = answers.Where(x => x.QuestionId == 1587).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1587).FirstOrDefault().AnsDes : "";
            this.serialNumberLabel15.Text = answers.Where(x => x.QuestionId == 1588).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1588).FirstOrDefault().AnsDes : "";
            this.newSerialNumberLabel15.Text = answers.Where(x => x.QuestionId == 1589).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1589).FirstOrDefault().AnsDes : "";
            this.noteLabel15.Text = answers.Where(x => x.QuestionId == 1590).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1590).FirstOrDefault().AnsDes : "";
            this.nameDopmLabel.Text = answers.Where(x => x.QuestionId == 1591).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1591).FirstOrDefault().AnsDes : "";
            this.dayDopmLabel.Text = answers.Where(x => x.QuestionId == 1592).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1592).FirstOrDefault().AnsDes : "";


        }





        int GetQuarter(DateTime dt)
        {
            return (dt.Month - 1) / 3 + 1;
        }
    }
}