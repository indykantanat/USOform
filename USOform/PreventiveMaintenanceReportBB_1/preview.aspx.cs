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

namespace USOform.PreventiveMaintenanceReportBB_1
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
                int currentQuarter = int.Parse(Request["qurter"]);
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
            this.GroupNameLabel.Text = answers.Where(x => x.QuestionId == 1231).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1231).FirstOrDefault().AnsDes : "";
            this.AreaLabel.Text = answers.Where(x => x.QuestionId == 1232).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1232).FirstOrDefault().AnsDes : "";
            this.CompanyLabel.Text = answers.Where(x => x.QuestionId == 1233).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1233).FirstOrDefault().AnsDes : "";
            this.maintenanceCountLabel.Text = answers.Where(x => x.QuestionId == 1234).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1234).FirstOrDefault().AnsDes : "";
            this.yearLabel.Text = answers.Where(x => x.QuestionId == 1235).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1235).FirstOrDefault().AnsDes : "";
            this.startDatepickerLabel.Text = answers.Where(x => x.QuestionId == 1236).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1236).FirstOrDefault().AnsDes : "";
            this.endDatepickerLabel.Text = answers.Where(x => x.QuestionId == 1237).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1237).FirstOrDefault().AnsDes : "";
            this.siteCodeLabel.Text = answers.Where(x => x.QuestionId == 1238).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1238).FirstOrDefault().AnsDes : "";
            this.cabinetIdLabel.Text = answers.Where(x => x.QuestionId == 1240).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1240).FirstOrDefault().AnsDes : "";
            this.sitecodeLabelSection2.Text = answers.Where(x => x.QuestionId == 1241).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1241).FirstOrDefault().AnsDes : "";
            this.VillageIdLabel.Text = answers.Where(x => x.QuestionId == 1242).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1242).FirstOrDefault().AnsDes : "";
            this.villageLabel.Text = answers.Where(x => x.QuestionId == 1243).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1243).FirstOrDefault().AnsDes : "";
            this.subdistrictLabel.Text = answers.Where(x => x.QuestionId == 1244).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1244).FirstOrDefault().AnsDes : "";
            this.districtLabel.Text = answers.Where(x => x.QuestionId == 1245).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1245).FirstOrDefault().AnsDes : "";
            this.provinceLabel.Text = answers.Where(x => x.QuestionId == 1246).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1246).FirstOrDefault().AnsDes : "";
            this.typeLabel.Text = answers.Where(x => x.QuestionId == 1247).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1247).FirstOrDefault().AnsDes : "";
            this.pmdateLabel.Text = answers.Where(x => x.QuestionId == 1248).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1248).FirstOrDefault().AnsDes : "";
            //this.signatureExecutorLabel.Text = answers.Where(x => x.QuestionId == 1250).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1250).FirstOrDefault().AnsDes : "";
            //this.signatureSupervisorLabel.Text = answers.Where(x => x.QuestionId == 1251).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1251).FirstOrDefault().AnsDes : "";
            this.nameExecutorLabel.Text = answers.Where(x => x.QuestionId == 1252).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1252).FirstOrDefault().AnsDes : "";
            this.nameSupervisorLabel.Text = answers.Where(x => x.QuestionId == 1253).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1253).FirstOrDefault().AnsDes : "";
            this.DateExecutorLabel.Text = answers.Where(x => x.QuestionId == 1254).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1254).FirstOrDefault().AnsDes : "";
            this.DateSupervisorLabel.Text = answers.Where(x => x.QuestionId == 1255).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1255).FirstOrDefault().AnsDes : "";
            this.CabinetLabel.Text = answers.Where(x => x.QuestionId == 1256).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1256).FirstOrDefault().AnsDes : "";
            this.sitecodeLabelSection4.Text = answers.Where(x => x.QuestionId == 1257).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1257).FirstOrDefault().AnsDes : "";
            this.villageIDLabelSection4.Text = answers.Where(x => x.QuestionId == 1258).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1258).FirstOrDefault().AnsDes : "";
            this.latandlongLabel.Text = answers.Where(x => x.QuestionId == 1259).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1259).FirstOrDefault().AnsDes : "";
            this.numberuserLabel.Text = answers.Where(x => x.QuestionId == 1260).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1260).FirstOrDefault().AnsDes : "";
            this.kwhMeterLabel.Text = answers.Where(x => x.QuestionId == 1261).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1261).FirstOrDefault().AnsDes : "";
            this.acLabel.Text = answers.Where(x => x.QuestionId == 1262).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1262).FirstOrDefault().AnsDes : "";
            this.lineAcLabel.Text = answers.Where(x => x.QuestionId == 1263).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1263).FirstOrDefault().AnsDes : "";
            this.neutronacLabel.Text = answers.Where(x => x.QuestionId == 1264).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1264).FirstOrDefault().AnsDes : "";
            this.dcLabel.Text = answers.Where(x => x.QuestionId == 1267).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1267).FirstOrDefault().AnsDes : "";
            this.loaddcLabel.Text = answers.Where(x => x.QuestionId == 1268).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1268).FirstOrDefault().AnsDes : "";
            this.RectifierLabel.Text = answers.Where(x => x.QuestionId == 1269).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1269).FirstOrDefault().AnsDes : "";
            this.BatteryVoltageLabel.Text = answers.Where(x => x.QuestionId == 1270).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1270).FirstOrDefault().AnsDes : "";
            this.BatteryTempTexbox.Text = answers.Where(x => x.QuestionId == 1271).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1271).FirstOrDefault().AnsDes : "";
            this.BatteryVoltageLabel1.Text = answers.Where(x => x.QuestionId == 1272).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1272).FirstOrDefault().AnsDes : "";
            this.BatteryVoltageLabel2.Text = answers.Where(x => x.QuestionId == 1273).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1273).FirstOrDefault().AnsDes : "";
            this.BatteryVoltageLabel3.Text = answers.Where(x => x.QuestionId == 1274).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1274).FirstOrDefault().AnsDes : "";
            this.BatteryVoltageLabel4.Text = answers.Where(x => x.QuestionId == 1275).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1275).FirstOrDefault().AnsDes : "";
            this.BatteryCapacityLabel.Text = answers.Where(x => x.QuestionId == 1276).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1276).FirstOrDefault().AnsDes : "";

            this.problemLabel1.Text = answers.Where(x => x.QuestionId == 1292).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1292).FirstOrDefault().AnsDes : "";
            this.howtoSolveLabel1.Text = answers.Where(x => x.QuestionId == 1293).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1293).FirstOrDefault().AnsDes : "";
            this.problemLabel2.Text = answers.Where(x => x.QuestionId == 1294).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1294).FirstOrDefault().AnsDes : "";
            this.howtoSolveLabel2.Text = answers.Where(x => x.QuestionId == 1295).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1295).FirstOrDefault().AnsDes : "";
            this.problemLabel3.Text = answers.Where(x => x.QuestionId == 1296).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1296).FirstOrDefault().AnsDes : "";
            this.howtoSolveLabel3.Text = answers.Where(x => x.QuestionId == 1297).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1297).FirstOrDefault().AnsDes : "";
            this.problemLabel4.Text = answers.Where(x => x.QuestionId == 1298).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1298).FirstOrDefault().AnsDes : "";
            this.howtoSolveLabel4.Text = answers.Where(x => x.QuestionId == 1299).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1299).FirstOrDefault().AnsDes : "";
            this.problemLabel5.Text = answers.Where(x => x.QuestionId == 1300).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1300).FirstOrDefault().AnsDes : "";
            this.howtoSolveLabel5.Text = answers.Where(x => x.QuestionId == 1301).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1301).FirstOrDefault().AnsDes : "";
            this.problemLabel6.Text = answers.Where(x => x.QuestionId == 1302).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1302).FirstOrDefault().AnsDes : "";
            this.howtoSolveLabel6.Text = answers.Where(x => x.QuestionId == 1303).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1303).FirstOrDefault().AnsDes : "";
            this.problemLabel7.Text = answers.Where(x => x.QuestionId == 1304).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1304).FirstOrDefault().AnsDes : "";
            this.howtoSolveLabel7.Text = answers.Where(x => x.QuestionId == 1305).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1305).FirstOrDefault().AnsDes : "";
            this.problemLabel8.Text = answers.Where(x => x.QuestionId == 1307).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1307).FirstOrDefault().AnsDes : "";
            this.howtoSolveLabel8.Text = answers.Where(x => x.QuestionId == 1308).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1308).FirstOrDefault().AnsDes : "";
            this.problemLabel9.Text = answers.Where(x => x.QuestionId == 1309).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1309).FirstOrDefault().AnsDes : "";
            this.howtoSolveLabel9.Text = answers.Where(x => x.QuestionId == 1310).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1310).FirstOrDefault().AnsDes : "";
            this.problemLabel10.Text = answers.Where(x => x.QuestionId == 1311).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1311).FirstOrDefault().AnsDes : "";
            this.howtoSolveLabel10.Text = answers.Where(x => x.QuestionId == 1312).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1312).FirstOrDefault().AnsDes : "";
            this.problemLabel11.Text = answers.Where(x => x.QuestionId == 1313).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1313).FirstOrDefault().AnsDes : "";
            this.howtoSolveLabel11.Text = answers.Where(x => x.QuestionId == 1314).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1314).FirstOrDefault().AnsDes : "";
            this.problemLabel12.Text = answers.Where(x => x.QuestionId == 1315).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1315).FirstOrDefault().AnsDes : "";
            this.howtoSolveLabel12.Text = answers.Where(x => x.QuestionId == 1316).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1316).FirstOrDefault().AnsDes : "";
            this.problemLabel13.Text = answers.Where(x => x.QuestionId == 1317).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1317).FirstOrDefault().AnsDes : "";
            this.howtoSolveLabel13.Text = answers.Where(x => x.QuestionId == 1318).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1318).FirstOrDefault().AnsDes : "";
            this.problemLabel14.Text = answers.Where(x => x.QuestionId == 1319).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1319).FirstOrDefault().AnsDes : "";
            this.howtoSolveLabel14.Text = answers.Where(x => x.QuestionId == 1320).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1320).FirstOrDefault().AnsDes : "";
            this.problemLabel15.Text = answers.Where(x => x.QuestionId == 1321).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1321).FirstOrDefault().AnsDes : "";
            this.howtoSolveLabel15.Text = answers.Where(x => x.QuestionId == 1322).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1322).FirstOrDefault().AnsDes : "";

            this.toolsListLabel1.Text = answers.Where(x => x.QuestionId == 1323).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1323).FirstOrDefault().AnsDes : "";
            this.serialNumberLabel1.Text = answers.Where(x => x.QuestionId == 1324).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1324).FirstOrDefault().AnsDes : "";
            this.newSerialNumberLabel1.Text = answers.Where(x => x.QuestionId == 1325).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1325).FirstOrDefault().AnsDes : "";
            this.noteLabel1.Text = answers.Where(x => x.QuestionId == 1326).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1326).FirstOrDefault().AnsDes : "";
            this.toolsListLabel2.Text = answers.Where(x => x.QuestionId == 1327).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1327).FirstOrDefault().AnsDes : "";
            this.serialNumberLabel2.Text = answers.Where(x => x.QuestionId == 1328).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1328).FirstOrDefault().AnsDes : "";
            this.newSerialNumberLabel2.Text = answers.Where(x => x.QuestionId == 1329).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1329).FirstOrDefault().AnsDes : "";
            this.noteLabel2.Text = answers.Where(x => x.QuestionId == 1330).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1330).FirstOrDefault().AnsDes : "";
            this.toolsListLabel3.Text = answers.Where(x => x.QuestionId == 1331).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1331).FirstOrDefault().AnsDes : "";
            this.serialNumberLabel3.Text = answers.Where(x => x.QuestionId == 1332).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1332).FirstOrDefault().AnsDes : "";
            this.newSerialNumberLabel3.Text = answers.Where(x => x.QuestionId == 1333).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1333).FirstOrDefault().AnsDes : "";
            this.noteLabel3.Text = answers.Where(x => x.QuestionId == 1334).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1334).FirstOrDefault().AnsDes : "";
            this.toolsListLabel4.Text = answers.Where(x => x.QuestionId == 1335).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1335).FirstOrDefault().AnsDes : "";
            this.serialNumberLabel4.Text = answers.Where(x => x.QuestionId == 1336).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1336).FirstOrDefault().AnsDes : "";
            this.newSerialNumberLabel4.Text = answers.Where(x => x.QuestionId == 1337).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1337).FirstOrDefault().AnsDes : "";
            this.noteLabel4.Text = answers.Where(x => x.QuestionId == 1338).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1338).FirstOrDefault().AnsDes : "";
            this.toolsListLabel5.Text = answers.Where(x => x.QuestionId == 1339).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1339).FirstOrDefault().AnsDes : "";
            this.serialNumberLabel5.Text = answers.Where(x => x.QuestionId == 1340).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1340).FirstOrDefault().AnsDes : "";
            this.newSerialNumberLabel5.Text = answers.Where(x => x.QuestionId == 1341).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1341).FirstOrDefault().AnsDes : "";
            this.noteLabel5.Text = answers.Where(x => x.QuestionId == 1342).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1342).FirstOrDefault().AnsDes : "";
            this.toolsListLabel6.Text = answers.Where(x => x.QuestionId == 1343).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1343).FirstOrDefault().AnsDes : "";
            this.serialNumberLabel6.Text = answers.Where(x => x.QuestionId == 1344).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1344).FirstOrDefault().AnsDes : "";
            this.newSerialNumberLabel6.Text = answers.Where(x => x.QuestionId == 1345).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1345).FirstOrDefault().AnsDes : "";
            this.noteLabel6.Text = answers.Where(x => x.QuestionId == 1346).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1346).FirstOrDefault().AnsDes : "";
            this.toolsListLabel7.Text = answers.Where(x => x.QuestionId == 1347).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1347).FirstOrDefault().AnsDes : "";
            this.serialNumberLabel7.Text = answers.Where(x => x.QuestionId == 1348).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1348).FirstOrDefault().AnsDes : "";
            this.newSerialNumberLabel7.Text = answers.Where(x => x.QuestionId == 1349).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1349).FirstOrDefault().AnsDes : "";
            this.noteLabel7.Text = answers.Where(x => x.QuestionId == 1350).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1350).FirstOrDefault().AnsDes : "";
            this.toolsListLabel8.Text = answers.Where(x => x.QuestionId == 1351).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1351).FirstOrDefault().AnsDes : "";
            this.serialNumberLabel8.Text = answers.Where(x => x.QuestionId == 1352).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1352).FirstOrDefault().AnsDes : "";
            this.newSerialNumberLabel8.Text = answers.Where(x => x.QuestionId == 1353).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1353).FirstOrDefault().AnsDes : "";
            this.noteLabel8.Text = answers.Where(x => x.QuestionId == 1354).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1354).FirstOrDefault().AnsDes : "";
            this.toolsListLabel9.Text = answers.Where(x => x.QuestionId == 1355).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1355).FirstOrDefault().AnsDes : "";
            this.serialNumberLabel9.Text = answers.Where(x => x.QuestionId == 1356).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1356).FirstOrDefault().AnsDes : "";
            this.newSerialNumberLabel9.Text = answers.Where(x => x.QuestionId == 1357).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1357).FirstOrDefault().AnsDes : "";
            this.noteLabel9.Text = answers.Where(x => x.QuestionId == 1358).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1358).FirstOrDefault().AnsDes : "";
            this.toolsListLabel10.Text = answers.Where(x => x.QuestionId == 1359).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1359).FirstOrDefault().AnsDes : "";
            this.serialNumberLabel10.Text = answers.Where(x => x.QuestionId == 1360).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1360).FirstOrDefault().AnsDes : "";
            this.newSerialNumberLabel10.Text = answers.Where(x => x.QuestionId == 1361).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1361).FirstOrDefault().AnsDes : "";
            this.noteLabel10.Text = answers.Where(x => x.QuestionId == 1362).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1362).FirstOrDefault().AnsDes : "";
            this.toolsListLabel11.Text = answers.Where(x => x.QuestionId == 1363).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1363).FirstOrDefault().AnsDes : "";
            this.serialNumberLabel11.Text = answers.Where(x => x.QuestionId == 1364).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1364).FirstOrDefault().AnsDes : "";
            this.newSerialNumberLabel11.Text = answers.Where(x => x.QuestionId == 1365).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1365).FirstOrDefault().AnsDes : "";
            this.noteLabel11.Text = answers.Where(x => x.QuestionId == 1366).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1366).FirstOrDefault().AnsDes : "";
            this.toolsListLabel12.Text = answers.Where(x => x.QuestionId == 1367).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1367).FirstOrDefault().AnsDes : "";
            this.serialNumberLabel12.Text = answers.Where(x => x.QuestionId == 1368).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1368).FirstOrDefault().AnsDes : "";
            this.newSerialNumberLabel12.Text = answers.Where(x => x.QuestionId == 1369).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1369).FirstOrDefault().AnsDes : "";
            this.noteLabel12.Text = answers.Where(x => x.QuestionId == 1370).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1370).FirstOrDefault().AnsDes : "";
            this.toolsListLabel13.Text = answers.Where(x => x.QuestionId == 1371).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1371).FirstOrDefault().AnsDes : "";
            this.serialNumberLabel13.Text = answers.Where(x => x.QuestionId == 1372).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1372).FirstOrDefault().AnsDes : "";
            this.newSerialNumberLabel13.Text = answers.Where(x => x.QuestionId == 1373).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1373).FirstOrDefault().AnsDes : "";
            this.noteLabel13.Text = answers.Where(x => x.QuestionId == 1374).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1374).FirstOrDefault().AnsDes : "";
            this.toolsListLabel14.Text = answers.Where(x => x.QuestionId == 1375).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1375).FirstOrDefault().AnsDes : "";
            this.serialNumberLabel14.Text = answers.Where(x => x.QuestionId == 1376).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1376).FirstOrDefault().AnsDes : "";
            this.newSerialNumberLabel14.Text = answers.Where(x => x.QuestionId == 1377).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1377).FirstOrDefault().AnsDes : "";
            this.noteLabel14.Text = answers.Where(x => x.QuestionId == 1378).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1378).FirstOrDefault().AnsDes : "";
            this.toolsListLabel15.Text = answers.Where(x => x.QuestionId == 1379).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1379).FirstOrDefault().AnsDes : "";
            this.serialNumberLabel15.Text = answers.Where(x => x.QuestionId == 1380).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1380).FirstOrDefault().AnsDes : "";
            this.newSerialNumberLabel15.Text = answers.Where(x => x.QuestionId == 1381).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1381).FirstOrDefault().AnsDes : "";
            this.noteLabel15.Text = answers.Where(x => x.QuestionId == 1382).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1382).FirstOrDefault().AnsDes : "";
            this.nameTeampmLabel.Text = answers.Where(x => x.QuestionId == 1383).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1383).FirstOrDefault().AnsDes : "";
            this.dayDopmLabel.Text = answers.Where(x => x.QuestionId == 1384).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1384).FirstOrDefault().AnsDes : "";
        }



    }
}