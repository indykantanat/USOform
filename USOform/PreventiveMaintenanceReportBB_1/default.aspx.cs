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

namespace USOform.PreventiveMaintenanceReportBB1
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

        int GetQuarter(DateTime dt)
        {
            return (dt.Month - 1) / 3 + 1;
        }

        void SetForm()
        {
            this.GroupNameTextBox.Value = answers.Where(x => x.QuestionId == 1231).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1231).FirstOrDefault().AnsDes : "";
            this.AreaTextbox.Value = answers.Where(x => x.QuestionId == 1232).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1232).FirstOrDefault().AnsDes : "";
            this.CompanyTextbox.Value = answers.Where(x => x.QuestionId == 1233).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1233).FirstOrDefault().AnsDes : "";
            this.maintenanceCountTextbox.Value = answers.Where(x => x.QuestionId == 1234).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1234).FirstOrDefault().AnsDes : "";
            this.yearTextbox.Value = answers.Where(x => x.QuestionId == 1235).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1235).FirstOrDefault().AnsDes : "";
            this.startDatepicker.Value = answers.Where(x => x.QuestionId == 1236).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1236).FirstOrDefault().AnsDes : "";
            this.endDatepicker.Value = answers.Where(x => x.QuestionId == 1237).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1237).FirstOrDefault().AnsDes : "";
            this.siteCodeTextbox.Value = answers.Where(x => x.QuestionId == 1238).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1238).FirstOrDefault().AnsDes : "";
            this.cabinetIdTextbox.Value = answers.Where(x => x.QuestionId == 1240).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1240).FirstOrDefault().AnsDes : "";
            this.sitecodeTextboxSection2.Value = answers.Where(x => x.QuestionId == 1241).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1241).FirstOrDefault().AnsDes : "";
            this.VillageIdTextbox.Value = answers.Where(x => x.QuestionId == 1242).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1242).FirstOrDefault().AnsDes : "";
            this.villageTextbox.Value = answers.Where(x => x.QuestionId == 1243).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1243).FirstOrDefault().AnsDes : "";
            this.subdistrictTextbox.Value = answers.Where(x => x.QuestionId == 1244).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1244).FirstOrDefault().AnsDes : "";
            this.districtTextbox.Value = answers.Where(x => x.QuestionId == 1245).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1245).FirstOrDefault().AnsDes : "";
            this.provinceTextbox.Value = answers.Where(x => x.QuestionId == 1246).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1246).FirstOrDefault().AnsDes : "";
            this.typeTextbox.Value = answers.Where(x => x.QuestionId == 1247).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1247).FirstOrDefault().AnsDes : "";
            this.pmdateTextbox.Value = answers.Where(x => x.QuestionId == 1248).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1248).FirstOrDefault().AnsDes : "";
            this.signatureExecutorTextbox.Value = answers.Where(x => x.QuestionId == 1250).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1250).FirstOrDefault().AnsDes : "";
            this.signatureSupervisorTextbox.Value = answers.Where(x => x.QuestionId == 1251).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1251).FirstOrDefault().AnsDes : "";
            this.nameExecutorTextbox.Value = answers.Where(x => x.QuestionId == 1252).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1252).FirstOrDefault().AnsDes : "";
            this.nameSupervisorTextbox.Value = answers.Where(x => x.QuestionId == 1253).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1253).FirstOrDefault().AnsDes : "";
            this.DateExecutorTextbox.Value = answers.Where(x => x.QuestionId == 1254).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1254).FirstOrDefault().AnsDes : "";
            this.DateSupervisorTextbox.Value = answers.Where(x => x.QuestionId == 1255).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1255).FirstOrDefault().AnsDes : "";
            this.CabinetTextbox.Value = answers.Where(x => x.QuestionId == 1256).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1256).FirstOrDefault().AnsDes : "";
            this.sitecodeTextboxSection4.Value = answers.Where(x => x.QuestionId == 1257).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1257).FirstOrDefault().AnsDes : "";
            this.villageIDTextboxSection4.Value = answers.Where(x => x.QuestionId == 1258).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1258).FirstOrDefault().AnsDes : "";
            this.latandlongTextbox.Value = answers.Where(x => x.QuestionId == 1259).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1259).FirstOrDefault().AnsDes : "";
            this.numberuserTextbox.Value = answers.Where(x => x.QuestionId == 1260).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1260).FirstOrDefault().AnsDes : "";
            this.kwhMeterTextbox.Value = answers.Where(x => x.QuestionId == 1261).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1261).FirstOrDefault().AnsDes : "";
            this.acTextbox.Value = answers.Where(x => x.QuestionId == 1262).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1262).FirstOrDefault().AnsDes : "";
            this.lineAcTextbox.Value = answers.Where(x => x.QuestionId == 1263).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1263).FirstOrDefault().AnsDes : "";
            this.neutronacTextbox.Value = answers.Where(x => x.QuestionId == 1264).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1264).FirstOrDefault().AnsDes : "";
            this.dcTextbox.Value = answers.Where(x => x.QuestionId == 1267).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1267).FirstOrDefault().AnsDes : "";
            this.loaddcTextbox.Value = answers.Where(x => x.QuestionId == 1268).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1268).FirstOrDefault().AnsDes : "";
            this.RectifierTextbox.Value = answers.Where(x => x.QuestionId == 1269).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1269).FirstOrDefault().AnsDes : "";
            this.BatteryVoltagetextbox.Value = answers.Where(x => x.QuestionId == 1270).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1270).FirstOrDefault().AnsDes : "";
            this.BatteryTempTexbox.Value = answers.Where(x => x.QuestionId == 1271).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1271).FirstOrDefault().AnsDes : "";
            this.BatteryVoltagetextbox1.Value = answers.Where(x => x.QuestionId == 1272).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1272).FirstOrDefault().AnsDes : "";
            this.BatteryVoltagetextbox2.Value = answers.Where(x => x.QuestionId == 1273).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1273).FirstOrDefault().AnsDes : "";
            this.BatteryVoltagetextbox3.Value = answers.Where(x => x.QuestionId == 1274).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1274).FirstOrDefault().AnsDes : "";
            this.BatteryVoltagetextbox4.Value = answers.Where(x => x.QuestionId == 1275).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1275).FirstOrDefault().AnsDes : "";
            this.BatteryCapacitytextbox.Value = answers.Where(x => x.QuestionId == 1276).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1276).FirstOrDefault().AnsDes : "";

            this.problemTextbox1.Value = answers.Where(x => x.QuestionId == 1292).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1292).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox1.Value = answers.Where(x => x.QuestionId == 1293).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1293).FirstOrDefault().AnsDes : "";
            this.problemTextbox2.Value = answers.Where(x => x.QuestionId == 1294).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1294).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox2.Value = answers.Where(x => x.QuestionId == 1295).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1295).FirstOrDefault().AnsDes : "";
            this.problemTextbox3.Value = answers.Where(x => x.QuestionId == 1296).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1296).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox3.Value = answers.Where(x => x.QuestionId == 1297).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1297).FirstOrDefault().AnsDes : "";
            this.problemTextbox4.Value = answers.Where(x => x.QuestionId == 1298).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1298).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox4.Value = answers.Where(x => x.QuestionId == 1299).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1299).FirstOrDefault().AnsDes : "";
            this.problemTextbox5.Value = answers.Where(x => x.QuestionId == 1300).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1300).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox5.Value = answers.Where(x => x.QuestionId == 1301).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1301).FirstOrDefault().AnsDes : "";
            this.problemTextbox6.Value = answers.Where(x => x.QuestionId == 1302).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1302).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox6.Value = answers.Where(x => x.QuestionId == 1303).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1303).FirstOrDefault().AnsDes : "";
            this.problemTextbox7.Value = answers.Where(x => x.QuestionId == 1304).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1304).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox7.Value = answers.Where(x => x.QuestionId == 1305).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1305).FirstOrDefault().AnsDes : "";
            this.problemTextbox8.Value = answers.Where(x => x.QuestionId == 1307).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1307).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox8.Value = answers.Where(x => x.QuestionId == 1308).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1308).FirstOrDefault().AnsDes : "";
            this.problemTextbox9.Value = answers.Where(x => x.QuestionId == 1309).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1309).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox9.Value = answers.Where(x => x.QuestionId == 1310).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1310).FirstOrDefault().AnsDes : "";
            this.problemTextbox10.Value = answers.Where(x => x.QuestionId == 1311).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1311).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox10.Value = answers.Where(x => x.QuestionId == 1312).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1312).FirstOrDefault().AnsDes : "";
            this.problemTextbox11.Value = answers.Where(x => x.QuestionId == 1313).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1313).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox11.Value = answers.Where(x => x.QuestionId == 1314).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1314).FirstOrDefault().AnsDes : "";
            this.problemTextbox12.Value = answers.Where(x => x.QuestionId == 1315).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1315).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox12.Value = answers.Where(x => x.QuestionId == 1316).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1316).FirstOrDefault().AnsDes : "";
            this.problemTextbox13.Value = answers.Where(x => x.QuestionId == 1317).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1317).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox13.Value = answers.Where(x => x.QuestionId == 1318).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1318).FirstOrDefault().AnsDes : "";
            this.problemTextbox14.Value = answers.Where(x => x.QuestionId == 1319).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1319).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox14.Value = answers.Where(x => x.QuestionId == 1320).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1320).FirstOrDefault().AnsDes : "";
            this.problemTextbox15.Value = answers.Where(x => x.QuestionId == 1321).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1321).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox15.Value = answers.Where(x => x.QuestionId == 1322).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1322).FirstOrDefault().AnsDes : "";

            this.toolsListTextbox1.Value = answers.Where(x => x.QuestionId == 1323).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1323).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox1.Value = answers.Where(x => x.QuestionId == 1324).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1324).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox1.Value = answers.Where(x => x.QuestionId == 1325).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1325).FirstOrDefault().AnsDes : "";
            this.noteTextbox1.Value = answers.Where(x => x.QuestionId == 1326).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1326).FirstOrDefault().AnsDes : "";
            this.toolsListTextbox2.Value = answers.Where(x => x.QuestionId == 1327).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1327).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox2.Value = answers.Where(x => x.QuestionId == 1328).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1328).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox2.Value = answers.Where(x => x.QuestionId == 1329).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1329).FirstOrDefault().AnsDes : "";
            this.noteTextbox2.Value = answers.Where(x => x.QuestionId == 1330).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1330).FirstOrDefault().AnsDes : "";
            this.toolsListTextbox3.Value = answers.Where(x => x.QuestionId == 1331).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1331).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox3.Value = answers.Where(x => x.QuestionId == 1332).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1332).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox3.Value = answers.Where(x => x.QuestionId == 1333).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1333).FirstOrDefault().AnsDes : "";
            this.noteTextbox3.Value = answers.Where(x => x.QuestionId == 1334).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1334).FirstOrDefault().AnsDes : "";
            this.toolsListTextbox4.Value = answers.Where(x => x.QuestionId == 1335).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1335).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox4.Value = answers.Where(x => x.QuestionId == 1336).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1336).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox4.Value = answers.Where(x => x.QuestionId == 1337).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1337).FirstOrDefault().AnsDes : "";
            this.noteTextbox4.Value = answers.Where(x => x.QuestionId == 1338).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1338).FirstOrDefault().AnsDes : "";
            this.toolsListTextbox5.Value = answers.Where(x => x.QuestionId == 1339).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1339).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox5.Value = answers.Where(x => x.QuestionId == 1340).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1340).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox5.Value = answers.Where(x => x.QuestionId == 1341).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1341).FirstOrDefault().AnsDes : "";
            this.noteTextbox5.Value = answers.Where(x => x.QuestionId == 1342).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1342).FirstOrDefault().AnsDes : "";
            this.toolsListTextbox6.Value = answers.Where(x => x.QuestionId == 1343).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1343).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox6.Value = answers.Where(x => x.QuestionId == 1344).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1344).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox6.Value = answers.Where(x => x.QuestionId == 1345).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1345).FirstOrDefault().AnsDes : "";
            this.noteTextbox6.Value = answers.Where(x => x.QuestionId == 1346).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1346).FirstOrDefault().AnsDes : "";
            this.toolsListTextbox7.Value = answers.Where(x => x.QuestionId == 1347).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1347).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox7.Value = answers.Where(x => x.QuestionId == 1348).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1348).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox7.Value = answers.Where(x => x.QuestionId == 1349).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1349).FirstOrDefault().AnsDes : "";
            this.noteTextbox7.Value = answers.Where(x => x.QuestionId == 1350).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1350).FirstOrDefault().AnsDes : "";
            this.toolsListTextbox8.Value = answers.Where(x => x.QuestionId == 1351).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1351).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox8.Value = answers.Where(x => x.QuestionId == 1352).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1352).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox8.Value = answers.Where(x => x.QuestionId == 1353).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1353).FirstOrDefault().AnsDes : "";
            this.noteTextbox8.Value = answers.Where(x => x.QuestionId == 1354).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1354).FirstOrDefault().AnsDes : "";
            this.toolsListTextbox9.Value = answers.Where(x => x.QuestionId == 1355).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1355).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox9.Value = answers.Where(x => x.QuestionId == 1356).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1356).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox9.Value = answers.Where(x => x.QuestionId == 1357).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1357).FirstOrDefault().AnsDes : "";
            this.noteTextbox9.Value = answers.Where(x => x.QuestionId == 1358).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1358).FirstOrDefault().AnsDes : "";
            this.toolsListTextbox10.Value = answers.Where(x => x.QuestionId == 1359).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1359).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox10.Value = answers.Where(x => x.QuestionId == 1360).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1360).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox10.Value = answers.Where(x => x.QuestionId == 1361).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1361).FirstOrDefault().AnsDes : "";
            this.noteTextbox10.Value = answers.Where(x => x.QuestionId == 1362).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1362).FirstOrDefault().AnsDes : "";
            this.toolsListTextbox11.Value = answers.Where(x => x.QuestionId == 1363).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1363).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox11.Value = answers.Where(x => x.QuestionId == 1364).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1364).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox11.Value = answers.Where(x => x.QuestionId == 1365).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1365).FirstOrDefault().AnsDes : "";
            this.noteTextbox11.Value = answers.Where(x => x.QuestionId == 1366).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1366).FirstOrDefault().AnsDes : "";
            this.toolsListTextbox12.Value = answers.Where(x => x.QuestionId == 1367).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1367).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox12.Value = answers.Where(x => x.QuestionId == 1368).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1368).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox12.Value = answers.Where(x => x.QuestionId == 1369).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1369).FirstOrDefault().AnsDes : "";
            this.noteTextbox12.Value = answers.Where(x => x.QuestionId == 1370).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1370).FirstOrDefault().AnsDes : "";
            this.toolsListTextbox13.Value = answers.Where(x => x.QuestionId == 1371).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1371).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox13.Value = answers.Where(x => x.QuestionId == 1372).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1372).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox13.Value = answers.Where(x => x.QuestionId == 1373).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1373).FirstOrDefault().AnsDes : "";
            this.noteTextbox13.Value = answers.Where(x => x.QuestionId == 1374).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1374).FirstOrDefault().AnsDes : "";
            this.toolsListTextbox14.Value = answers.Where(x => x.QuestionId == 1375).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1375).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox14.Value = answers.Where(x => x.QuestionId == 1376).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1376).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox14.Value = answers.Where(x => x.QuestionId == 1377).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1377).FirstOrDefault().AnsDes : "";
            this.noteTextbox14.Value = answers.Where(x => x.QuestionId == 1378).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1378).FirstOrDefault().AnsDes : "";
            this.toolsListTextbox15.Value = answers.Where(x => x.QuestionId == 1379).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1379).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox15.Value = answers.Where(x => x.QuestionId == 1380).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1380).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox15.Value = answers.Where(x => x.QuestionId == 1381).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1381).FirstOrDefault().AnsDes : "";
            this.noteTextbox15.Value = answers.Where(x => x.QuestionId == 1382).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1382).FirstOrDefault().AnsDes : "";
            this.nameTeampmTextbox.Value = answers.Where(x => x.QuestionId == 1383).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1383).FirstOrDefault().AnsDes : "";
            this.dayDopmTextbox.Value = answers.Where(x => x.QuestionId == 1384).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1384).FirstOrDefault().AnsDes : "";
        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            User user = (User)Session["strUsername"];
            if (user != null)
            {

            }
            else
            {
                Response.Redirect("/UsoLogin.aspx");
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



            var ans1 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1231).FirstOrDefault();
            if (ans1 == null)
            {
                Answer answer1 = new Answer()
                {
                    AnsDes = this.GroupNameTextBox.Value,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    QuestionId = 1231,
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
                ans1.QuestionId = 1231;
                ans1.UserId = user.Id;
                ans1.AnsMonth = ansMonth; ans1.SRId = sR.Id;
            }

            // ภูมิภาค
            var ans2 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1232).FirstOrDefault();
            if (ans2 == null)
            {
                Answer answer2 = new Answer()
                {
                    AnsDes = this.AreaTextbox.Value,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    QuestionId = 1232,
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
                ans2.QuestionId = 1232;
                ans2.UserId = user.Id;
                ans2.AnsMonth = ansMonth; ans2.SRId = sR.Id;
            }



            // บริษัท

            var ans3 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1233).FirstOrDefault();
            if (ans3 == null)
            {
                Answer answer3 = new Answer()
                {
                    AnsDes = this.CompanyTextbox.Value,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    QuestionId = 1233,
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
                ans3.QuestionId = 1233;
                ans3.UserId = user.Id;
                ans3.AnsMonth = ansMonth; ans3.SRId = sR.Id;

            }



            //รอบการบำรุงรักษาครั้งที่
            var ans4 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1234).FirstOrDefault();
            if (ans4 == null)
            {
                Answer answer4 = new Answer()
                {
                    AnsDes = this.maintenanceCountTextbox.Value,
                    QuestionId = 1234,
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
                ans4.QuestionId = 1234;
                ans4.UserId = user.Id;
                ans4.AnsMonth = ansMonth; ans4.SRId = sR.Id;


            }


            //ปีพุทธศักราช

            var ans5 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1235).FirstOrDefault();
            if (ans5 == null)
            {
                Answer answer5 = new Answer()
                {
                    AnsDes = this.yearTextbox.Value,
                    QuestionId = 1235,
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
                ans5.QuestionId = 1235;
                ans5.UserId = user.Id;
                ans5.AnsMonth = ansMonth; ans5.SRId = sR.Id;

            }

            //วัน เดือน ปี ที่เริ่มต้น
            var ans6 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1236).FirstOrDefault();
            if (ans6 == null)
            {
                Answer answer6 = new Answer()
                {
                    AnsDes = this.startDatepicker.Value,
                    //  StartDate = DateTime.ParseExact(this.startDatepicker.Value, "MM/dd/yyyy", CultureInfo.GetCultureInfo("en-GB")),
                    QuestionId = 1236,
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
                ans6.QuestionId = 1236;
                ans6.UserId = user.Id;
                ans6.AnsMonth = ansMonth; ans6.SRId = sR.Id;

            }

            //ถึง 
            var ans7 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1237).FirstOrDefault();
            if (ans7 == null)
            {
                Answer answer7 = new Answer()
                {
                    AnsDes = this.endDatepicker.Value,
                    // EndDate = DateTime.ParseExact(this.endDatepicker.Value, "MM/dd/yyyy", CultureInfo.GetCultureInfo("en-GB")),
                    QuestionId = 1237,
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
                ans7.QuestionId = 1237;
                ans7.UserId = user.Id;
                ans7.AnsMonth = ansMonth; ans7.SRId = sR.Id;
            }

            var ans8 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1238).FirstOrDefault();
            if (ans8 == null)
            {
                //สถานที่ SITE CODE
                Answer answer8 = new Answer()
                {
                    AnsDes = this.siteCodeTextbox.Value,
                    QuestionId = 1238,
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
                ans8.QuestionId = 1238;
                ans8.UserId = user.Id;
                ans8.AnsMonth = ansMonth; ans8.SRId = sR.Id;

            }

            var ans9 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1239).FirstOrDefault();
            //ใส่รูป Logo 
            if (ans9 == null)
            {
                if (this.pictureOrganize_.HasFile)
                {
                    string extension = this.pictureOrganize_.PostedFile.FileName.Split('.')[1];
                    string newFileName = "images/PictureOrganize_BB1_" + DateTime.Now.ToString("yyyyMMddHHmmss") + "." + extension;
                    this.pictureOrganize_.PostedFile.SaveAs(Server.MapPath(newFileName));

                    Answer answer9 = new Answer()
                    {
                        AnsDes = newFileName,
                        QuestionId = 1239,
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
                    string newFileName = "images/PictureOrganize_BB1_" + DateTime.Now.ToString("yyyyMMddHHmmss") + "." + extension;
                    this.pictureOrganize_.PostedFile.SaveAs(Server.MapPath(newFileName));

                    ans9.AnsDes = newFileName;
                    ans9.QuestionId = 1239;
                    ans9.AnserTypeId = 3;
                    ans9.CreateDate = DateTime.Now;
                    ans9.UserId = user.Id;
                    ans9.AnsMonth = ansMonth;
                    ans9.SRId = sR.Id;
                }
            }

            //Cabinet ID:
            var ans10 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1240).FirstOrDefault();
            if (ans10 == null)
            {
                Answer answer10 = new Answer()
                {
                    AnsDes = this.cabinetIdTextbox.Value,
                    QuestionId = 1240,
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
                ans10.QuestionId = 1240;
                ans10.UserId = user.Id;
                ans10.AnsMonth = ansMonth; ans10.SRId = sR.Id;
            }

            //Site Code :
            var ans11 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1241).FirstOrDefault();
            if (ans11 == null)
            {
                Answer answer11 = new Answer()
                {
                    AnsDes = this.sitecodeTextboxSection2.Value,
                    QuestionId = 1241,
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
                ans11.QuestionId = 1241;
                ans11.UserId = user.Id;
                ans11.AnsMonth = ansMonth; ans11.SRId = sR.Id;
            }

            //Village ID :
            var ans12 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1242).FirstOrDefault();
            if (ans12 == null)
            {
                Answer answer12 = new Answer()
                {
                    AnsDes = this.VillageIdTextbox.Value,
                    QuestionId = 1242,
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
                ans12.QuestionId = 1242;
                ans12.UserId = user.Id;
                ans12.AnsMonth = ansMonth; ans12.SRId = sR.Id;
            }

            //Village  :
            var ans13 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1243).FirstOrDefault();
            if (ans13 == null)
            {
                Answer answer13 = new Answer()
                {
                    AnsDes = this.villageTextbox.Value,
                    QuestionId = 1243,
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
                ans13.QuestionId = 1243;
                ans13.UserId = user.Id;
                ans13.AnsMonth = ansMonth; ans13.SRId = sR.Id;
            }


            //Sub-District :
            var ans14 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1244).FirstOrDefault();
            if (ans14 == null)
            {
                Answer answer14 = new Answer()
                {
                    AnsDes = this.subdistrictTextbox.Value,
                    QuestionId = 1244,
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
                ans14.QuestionId = 1244;
                ans14.UserId = user.Id;
                ans14.AnsMonth = ansMonth; ans14.SRId = sR.Id;

            }
            //District :
            var ans15 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1245).FirstOrDefault();
            if (ans15 == null)
            {

                Answer answer15 = new Answer()
                {
                    AnsDes = this.districtTextbox.Value,
                    QuestionId = 1245,
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
                ans15.QuestionId = 1245;
                ans15.UserId = user.Id;
                ans15.AnsMonth = ansMonth; ans15.SRId = sR.Id;
            }
            //Province :
            var ans16 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1246).FirstOrDefault();
            if (ans16 == null)
            {
                Answer answer16 = new Answer()
                {
                    AnsDes = this.provinceTextbox.Value,
                    QuestionId = 1246,
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
                ans16.QuestionId = 1246;
                ans16.UserId = user.Id;
                ans16.AnsMonth = ansMonth; ans16.SRId = sR.Id;
            }

            //Type :
            var ans17 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1247).FirstOrDefault();
            if (ans17 == null)
            {
                Answer answer17 = new Answer()
                {
                    AnsDes = this.typeTextbox.Value,
                    QuestionId = 1247,
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
                ans17.QuestionId = 1247;
                ans17.UserId = user.Id;
                ans17.AnsMonth = ansMonth; ans17.SRId = sR.Id;
            }
            //PM Date :
            var ans18 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1248).FirstOrDefault();
            if (ans18 == null)
            {
                Answer answer18 = new Answer()
                {
                    AnsDes = this.pmdateTextbox.Value,
                    QuestionId = 1248,
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
                ans18.QuestionId = 1248;
                ans18.UserId = user.Id;
                ans18.AnsMonth = ansMonth; ans18.SRId = sR.Id;

            }


            var ans19 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1249).FirstOrDefault();
            //ใส่รูปหน้าอาคารศูนย์ USO Net :
            if (ans19 == null)
            {
                if (this.signboardfontImage.HasFile)
                {
                    string extension = this.signboardfontImage.PostedFile.FileName.Split('.')[1];
                    string newFileName = "images/signboardfontImageBB1_" + DateTime.Now.ToString("yyyyMMddHHmmss") + "." + extension;
                    this.signboardfontImage.PostedFile.SaveAs(Server.MapPath(newFileName));

                    Answer answer19 = new Answer()
                    {
                        AnsDes = newFileName,
                        QuestionId = 1249,
                        AnserTypeId = 3,
                        CreateDate = DateTime.Now,
                        SRId = sR.Id,
                        UserId = user.Id,
                        AnsMonth = ansMonth
                    };
                    uSOEntities.Answers.Add(answer19);
                }
            }
            else
            {

                if (this.signboardfontImage.HasFile)
                {
                    string extension = this.signboardfontImage.PostedFile.FileName.Split('.')[1];
                    string newFileName = "images/signboardfontImageBB1_" + DateTime.Now.ToString("yyyyMMddHHmmss") + "." + extension;
                    this.signboardfontImage.PostedFile.SaveAs(Server.MapPath(newFileName));

                    ans19.AnsDes = newFileName;
                    ans19.QuestionId = 1249;
                    ans19.AnserTypeId = 3;
                    ans19.CreateDate = DateTime.Now;
                    ans19.UserId = user.Id;
                    ans19.AnsMonth = ansMonth;
                    ans19.SRId = sR.Id;

                }
            }

            //signature Executor :
            var ans20 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1250).FirstOrDefault();
            if (ans20 == null)
            {
                Answer answer20 = new Answer()
                {
                    AnsDes = this.signatureExecutorTextbox.Value,
                    QuestionId = 1250,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer20);
            }
            else
            {
                ans20.AnsDes = this.signatureExecutorTextbox.Value;
                ans20.AnserTypeId = 1;
                ans20.CreateDate = DateTime.Now;
                ans20.QuestionId = 1250;
                ans20.UserId = user.Id;
                ans20.AnsMonth = ansMonth; ans20.SRId = sR.Id;
            }


            //signature Supervisor :
            var ans21 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1251).FirstOrDefault();
            if (ans21 == null)
            {
                Answer answer21 = new Answer()
                {
                    AnsDes = this.signatureSupervisorTextbox.Value,
                    QuestionId = 1251,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer21);
            }
            else
            {
                ans21.AnsDes = this.signatureSupervisorTextbox.Value;
                ans21.AnserTypeId = 1;
                ans21.CreateDate = DateTime.Now;
                ans21.QuestionId = 1251;
                ans21.UserId = user.Id;
                ans21.AnsMonth = ansMonth; ans21.SRId = sR.Id;
            }

            //name Executor  :
            var ans22 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1252).FirstOrDefault();
            if (ans22 == null)
            {
                Answer answer22 = new Answer()
                {
                    AnsDes = this.nameExecutorTextbox.Value,
                    QuestionId = 1252,
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
                ans22.QuestionId = 1252;
                ans22.UserId = user.Id;
                ans22.AnsMonth = ansMonth; ans22.SRId = sR.Id;
            }
            //name Supervisor :
            var ans23 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1253).FirstOrDefault();
            if (ans23 == null)
            {
                Answer answer23 = new Answer()
                {
                    AnsDes = this.nameSupervisorTextbox.Value,
                    QuestionId = 1253,
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
                ans23.QuestionId = 1253;
                ans23.UserId = user.Id;
                ans23.AnsMonth = ansMonth; ans23.SRId = sR.Id;
            }
            //Date Executor :
            var ans24 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1254).FirstOrDefault();
            if (ans24 == null)
            {
                Answer answer24 = new Answer()
                {
                    AnsDes = this.DateExecutorTextbox.Value,
                    QuestionId = 1254,
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
                ans24.QuestionId = 1254;
                ans24.UserId = user.Id;
                ans24.AnsMonth = ansMonth; ans24.SRId = sR.Id;
            }
            //Date Supervisor :
            var ans25 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1255).FirstOrDefault();
            if (ans25 == null)
            {
                Answer answer25 = new Answer()
                {
                    AnsDes = this.DateSupervisorTextbox.Value,
                    QuestionId = 1255,
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
                ans25.QuestionId = 1255;
                ans25.UserId = user.Id;
                ans25.AnsMonth = ansMonth; ans25.SRId = sR.Id;
            }

            var ans26 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1256).FirstOrDefault();
            if (ans26 == null)
            {
                Answer answer26 = new Answer()
                {
                    AnsDes = this.CabinetTextbox.Value,
                    QuestionId = 1256,
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
                ans26.AnsDes = this.CabinetTextbox.Value;
                ans26.AnserTypeId = 1;
                ans26.CreateDate = DateTime.Now;
                ans26.QuestionId = 1256;
                ans26.UserId = user.Id;
                ans26.AnsMonth = ansMonth; ans26.SRId = sR.Id;
            }

            //Site code section 4 :
            var ans27 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1257).FirstOrDefault();
            if (ans27 == null)
            {
                Answer answer27 = new Answer()
                {
                    AnsDes = this.sitecodeTextboxSection4.Value,
                    QuestionId = 1257,
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
                ans27.QuestionId = 1257;
                ans27.UserId = user.Id;
                ans27.AnsMonth = ansMonth; ans27.SRId = sR.Id;
            }

            //villageIDsection 4 :
            var ans28 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1258).FirstOrDefault();
            if (ans28 == null)
            {
                Answer answer28 = new Answer()
                {
                    AnsDes = this.villageIDTextboxSection4.Value,
                    QuestionId = 1258,
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
                ans28.QuestionId = 1258;
                ans28.UserId = user.Id;
                ans28.AnsMonth = ansMonth; ans28.SRId = sR.Id;
            }


            //lat and long  :
            var ans29 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1259).FirstOrDefault();
            if (ans29 == null)
            {
                Answer answer29 = new Answer()
                {
                    AnsDes = this.latandlongTextbox.Value,
                    QuestionId = 1259,
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
                ans29.QuestionId = 1259;
                ans29.UserId = user.Id;
                ans29.AnsMonth = ansMonth; ans29.SRId = sR.Id;
            }


            //หมายเลขผู้ใช้ไฟ  :
            var ans30 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1260).FirstOrDefault();
            if (ans30 == null)
            {
                Answer answer30 = new Answer()
                {
                    AnsDes = this.numberuserTextbox.Value,
                    QuestionId = 1260,
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
                ans30.QuestionId = 1260;
                ans30.UserId = user.Id;
                ans30.AnsMonth = ansMonth; ans30.SRId = sR.Id;
            }

            //หน่วยใช้ไฟไฟ  :
            var ans31 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1261).FirstOrDefault();
            if (ans31 == null)
            {
                Answer answer31 = new Answer()
                {
                    AnsDes = this.kwhMeterTextbox.Value,
                    QuestionId = 1261,
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
                ans31.QuestionId = 1261;
                ans31.UserId = user.Id;
                ans31.AnsMonth = ansMonth; ans31.SRId = sR.Id;
            }

            //แรงดัน AC (kWh Meter) :
            var ans32 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1262).FirstOrDefault();
            if (ans32 == null)
            {
                Answer answer32 = new Answer()
                {
                    AnsDes = this.acTextbox.Value,
                    QuestionId = 1262,
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
                ans32.QuestionId = 1262;
                ans32.UserId = user.Id;
                ans32.AnsMonth = ansMonth; ans32.SRId = sR.Id;
            }

            //กระแส Line AC (kWh Meter) :
            var ans33 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1263).FirstOrDefault();
            if (ans33 == null)
            {
                Answer answer33 = new Answer()
                {
                    AnsDes = this.lineAcTextbox.Value,
                    QuestionId = 1263,
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
                ans33.QuestionId = 1263;
                ans33.UserId = user.Id;
                ans33.AnsMonth = ansMonth; ans33.SRId = sR.Id;
            }

            // กระแส Neutron AC(kWh Meter) :     
            var ans34 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1264).FirstOrDefault();
            if (ans34 == null)
            {
                Answer answer34 = new Answer()
                {
                    AnsDes = this.neutronacTextbox.Value,
                    QuestionId = 1264,
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
                ans34.QuestionId = 1264;
                ans34.UserId = user.Id;
                ans34.AnsMonth = ansMonth; ans34.SRId = sR.Id;
            }

            //สภาพ kWh Meter Radio  :
            var ans35 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1265).FirstOrDefault();
            if (ans35 == null)
            {
                string conRadio = Request.Form["conditionRadio"];
                Answer answer35 = new Answer()
                {
                    AnsDes = conRadio,
                    QuestionId = 1265,
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
                ans35.QuestionId = 1265;
                ans35.UserId = user.Id;
                ans35.AnsMonth = ansMonth; ans35.SRId = sR.Id;
            }
            //สภาพ Circuit Breaker Radio  :
            var ans36 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1266).FirstOrDefault();
            if (ans36 == null)
            {
                string CircuitBreakerRadio = Request.Form["MDBCircuitBreakerRadio"];
                Answer answer36 = new Answer()
                {
                    AnsDes = CircuitBreakerRadio,
                    QuestionId = 1266,
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
                ans36.QuestionId = 1266;
                ans36.UserId = user.Id;
                ans36.AnsMonth = ansMonth; ans36.SRId = sR.Id;
            }

            //แรงดัน DC  :
            var ans37 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1267).FirstOrDefault();
            if (ans37 == null)
            {
                Answer answer37 = new Answer()
                {
                    AnsDes = this.dcTextbox.Value,
                    QuestionId = 1267,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer37);
            }
            else
            {
                ans37.AnsDes = this.dcTextbox.Value;
                ans37.AnserTypeId = 1;
                ans37.CreateDate = DateTime.Now;
                ans37.QuestionId = 1267;
                ans37.UserId = user.Id;
                ans37.AnsMonth = ansMonth; ans37.SRId = sR.Id;
            }

            //กระแส Load DC :
            var ans38 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1268).FirstOrDefault();
            if (ans38 == null)
            {
                Answer answer38 = new Answer()
                {
                    AnsDes = this.loaddcTextbox.Value,
                    QuestionId = 1268,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer38);
            }
            else
            {
                ans38.AnsDes = this.loaddcTextbox.Value;
                ans38.AnserTypeId = 1;
                ans38.CreateDate = DateTime.Now;
                ans38.QuestionId = 1268;
                ans38.UserId = user.Id;
                ans38.AnsMonth = ansMonth; ans38.SRId = sR.Id;
            }

            //จำนวน Rectifier Module :
            var ans39 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1269).FirstOrDefault();
            if (ans39 == null)
            {
                Answer answer39 = new Answer()
                {
                    AnsDes = this.RectifierTextbox.Value,
                    QuestionId = 1269,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer39);
            }
            else
            {
                ans39.AnsDes = this.RectifierTextbox.Value;
                ans39.AnserTypeId = 1;
                ans39.CreateDate = DateTime.Now;
                ans39.QuestionId = 1269;
                ans39.UserId = user.Id;
                ans39.AnsMonth = ansMonth; ans39.SRId = sR.Id;
            }

            //Battery Voltage:
            var ans40 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1270).FirstOrDefault();
            if (ans40 == null)
            {
                Answer answer40 = new Answer()
                {
                    AnsDes = this.BatteryVoltagetextbox.Value,
                    QuestionId = 1270,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer40);
            }
            else
            {
                ans40.AnsDes = this.BatteryVoltagetextbox.Value;
                ans40.AnserTypeId = 1;
                ans40.CreateDate = DateTime.Now;
                ans40.QuestionId = 1270;
                ans40.UserId = user.Id;
                ans40.AnsMonth = ansMonth; ans40.SRId = sR.Id;
            }

            //Battery Temperature  :
            var ans41 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1271).FirstOrDefault();
            if (ans41 == null)
            {
                Answer answer41 = new Answer()
                {
                    AnsDes = this.BatteryTempTexbox.Value,
                    QuestionId = 1271,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer41);
            }
            else
            {
                ans41.AnsDes = this.BatteryTempTexbox.Value;
                ans41.AnserTypeId = 1;
                ans41.CreateDate = DateTime.Now;
                ans41.QuestionId = 1271;
                ans41.UserId = user.Id;
                ans41.AnsMonth = ansMonth; ans41.SRId = sR.Id;
            }

            //>Battery Voltage ก้อนที่1  :
            var ans42 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1272).FirstOrDefault();
            if (ans42 == null)
            {
                Answer answer42 = new Answer()
                {
                    AnsDes = this.BatteryVoltagetextbox1.Value,
                    QuestionId = 1272,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer42);
            }
            else
            {
                ans42.AnsDes = this.BatteryVoltagetextbox1.Value;
                ans42.AnserTypeId = 1;
                ans42.CreateDate = DateTime.Now;
                ans42.QuestionId = 1272;
                ans42.UserId = user.Id;
                ans42.AnsMonth = ansMonth; ans42.SRId = sR.Id;
            }

            //>Battery Voltage ก้อนที่2 :
            var ans43 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1273).FirstOrDefault();
            if (ans43 == null)
            {
                Answer answer43 = new Answer()
                {
                    AnsDes = this.BatteryVoltagetextbox2.Value,
                    QuestionId = 1273,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer43);
            }
            else
            {
                ans43.AnsDes = this.BatteryVoltagetextbox2.Value;
                ans43.AnserTypeId = 1;
                ans43.CreateDate = DateTime.Now;
                ans43.QuestionId = 1273;
                ans43.UserId = user.Id;
                ans43.AnsMonth = ansMonth; ans43.SRId = sR.Id;
            }

            //>Battery Voltage ก้อนที่3 :
            var ans44 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1274).FirstOrDefault();
            if (ans44 == null)
            {
                Answer answer44 = new Answer()
                {
                    AnsDes = this.BatteryVoltagetextbox3.Value,
                    QuestionId = 1274,
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
                ans44.AnsDes = this.BatteryVoltagetextbox3.Value;
                ans44.AnserTypeId = 1;
                ans44.CreateDate = DateTime.Now;
                ans44.QuestionId = 1274;
                ans44.UserId = user.Id;
                ans44.AnsMonth = ansMonth; ans44.SRId = sR.Id;
            }

            // >Battery Voltage ก้อนที่4 : 
            var ans45 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1275).FirstOrDefault();
            if (ans45 == null)
            {
                Answer answer45 = new Answer()
                {
                    AnsDes = this.BatteryVoltagetextbox4.Value,
                    QuestionId = 1275,
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
                ans45.AnsDes = this.BatteryVoltagetextbox4.Value;
                ans45.AnserTypeId = 1;
                ans45.CreateDate = DateTime.Now;
                ans45.QuestionId = 1275;
                ans45.UserId = user.Id;
                ans45.AnsMonth = ansMonth; ans45.SRId = sR.Id;
            }
            //Battery Capacity :
            var ans46 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1276).FirstOrDefault();
            if (ans46 == null)
            {
                Answer answer46 = new Answer()
                {
                    AnsDes = this.BatteryCapacitytextbox.Value,
                    QuestionId = 1276,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer46);
            }
            else
            {
                ans46.AnsDes = this.BatteryCapacitytextbox.Value;
                ans46.AnserTypeId = 1;
                ans46.CreateDate = DateTime.Now;
                ans46.QuestionId = 1276;
                ans46.UserId = user.Id;
                ans46.AnsMonth = ansMonth; ans46.SRId = sR.Id;
            }


            //Door Alarm   :
            var ans47 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1277).FirstOrDefault();
            if (ans47 == null)
            {
                string dooralarm = Request.Form["dooralarmRadio"];
                Answer answer47 = new Answer()
                {
                    AnsDes = dooralarm,
                    QuestionId = 1277,
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
                string dooralarm = Request.Form["dooralarmRadio"];
                ans47.AnsDes = dooralarm;
                ans47.AnserTypeId = 4;
                ans47.CreateDate = DateTime.Now;
                ans47.QuestionId = 1277;
                ans47.UserId = user.Id;
                ans47.AnsMonth = ansMonth; ans47.SRId = sR.Id;
            }

            //Main Power Failure Alarm< :
            var ans48 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1278).FirstOrDefault();
            if (ans48 == null)
            {
                string mainpower = Request.Form["maimpowerFailureAlarm"];
                Answer answer48 = new Answer()
                {
                    AnsDes = mainpower,
                    QuestionId = 1278,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer48);
            }
            else
            {
                string mainpower = Request.Form["maimpowerFailureAlarm"];
                ans48.AnsDes = mainpower;
                ans48.AnserTypeId = 4;
                ans48.CreateDate = DateTime.Now;
                ans48.QuestionId = 1278;
                ans48.UserId = user.Id;
                ans48.AnsMonth = ansMonth; ans48.SRId = sR.Id;
            }

            //Rectifier 1 Comm. Fail Alarm :
            var ans49 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1279).FirstOrDefault();
            if (ans49 == null)
            {
                string Rectifier1 = Request.Form["rectifier1Radio"];
                Answer answer49 = new Answer()
                {
                    AnsDes = Rectifier1,
                    QuestionId = 1279,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer49);
            }
            else
            {
                string Rectifier1 = Request.Form["rectifier1Radio"];
                ans49.AnsDes = Rectifier1;
                ans49.AnserTypeId = 4;
                ans49.CreateDate = DateTime.Now;
                ans49.QuestionId = 1279;
                ans49.UserId = user.Id;
                ans49.AnsMonth = ansMonth; ans49.SRId = sR.Id;
            }

            //Rectifier 2 Comm. Fail Alarm :
            var ans50 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1280).FirstOrDefault();
            if (ans50 == null)
            {
                string Rectifier2 = Request.Form["rectifier2Radio"];
                Answer answer50 = new Answer()
                {
                    AnsDes = Rectifier2,
                    QuestionId = 1280,
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
                string Rectifier2 = Request.Form["rectifier2Radio"];
                ans50.AnsDes = Rectifier2;
                ans50.AnserTypeId = 4;
                ans50.CreateDate = DateTime.Now;
                ans50.QuestionId = 1280;
                ans50.UserId = user.Id;
                ans50.AnsMonth = ansMonth; ans50.SRId = sR.Id;
            }

            //ความแข็งแรงจุดต่อ Ground Bar :
            var ans51 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1281).FirstOrDefault();
            if (ans51 == null)
            {
                string gb = Request.Form["groundbarRadio"];
                Answer answer51 = new Answer()
                {
                    AnsDes = gb,
                    QuestionId = 1281,
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
                string gb = Request.Form["groundbarRadio"];
                ans51.AnsDes = gb;
                ans51.AnserTypeId = 4;
                ans51.CreateDate = DateTime.Now;
                ans51.QuestionId = 1281;
                ans51.UserId = user.Id;
                ans51.AnsMonth = ansMonth; ans51.SRId = sR.Id;
            }


            //ความแข็งแรงของน็อตขันหางปลาอุปกรณ์ :
            var ans52 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1282).FirstOrDefault();
            if (ans52 == null)
            {
                string fishnot = Request.Form["notfishRadio"];
                Answer answer52 = new Answer()
                {
                    AnsDes = fishnot,
                    QuestionId = 1282,
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
                string fishnot = Request.Form["notfishRadio"];
                ans52.AnsDes = fishnot;
                ans52.AnserTypeId = 4;
                ans52.CreateDate = DateTime.Now;
                ans52.QuestionId = 1282;
                ans52.UserId = user.Id;
                ans52.AnsMonth = ansMonth; ans52.SRId = sR.Id;
            }
            //สายกราวด์เรียบร้อย ปลอดภัย สมบูรณ์ :
            var ans53 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1283).FirstOrDefault();
            if (ans53 == null)
            {
                string ffss = Request.Form["safegroundRadio"];
                Answer answer53 = new Answer()
                {
                    AnsDes = ffss,
                    QuestionId = 1283,
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
                string ffss = Request.Form["safegroundRadio"];
                ans53.AnsDes = ffss;
                ans53.AnserTypeId = 4;
                ans53.CreateDate = DateTime.Now;
                ans53.QuestionId = 1283;
                ans53.UserId = user.Id;
                ans53.AnsMonth = ansMonth; ans53.SRId = sR.Id;
            }

            //สถานะไฟฟ้ารั่วลง Ground :
            var ans54 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1284).FirstOrDefault();
            if (ans54 == null)
            {
                string elecground = Request.Form["brokenElecRadio"];
                Answer answer54 = new Answer()
                {
                    AnsDes = elecground,
                    QuestionId = 1284,
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

                string elecground = Request.Form["brokenElecRadio"];
                ans54.AnsDes = elecground;
                ans54.AnserTypeId = 4;
                ans54.CreateDate = DateTime.Now;
                ans54.QuestionId = 1284;
                ans54.UserId = user.Id;
                ans54.AnsMonth = ansMonth; ans54.SRId = sR.Id;
            }



            //iป้ายและตัวเลขแสดงชื่อสถานี :
            var ans55 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1285).FirstOrDefault();
            if (ans55 == null)
            {
                string stationradio = Request.Form["nameStationRadio"];
                Answer answer55 = new Answer()
                {
                    AnsDes = stationradio,
                    QuestionId = 1285,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer55);
            }
            else
            {
                string stationradio = Request.Form["nameStationRadio"];
                ans55.AnsDes = stationradio;
                ans55.AnserTypeId = 4;
                ans55.CreateDate = DateTime.Now;
                ans55.QuestionId = 1285;
                ans55.UserId = user.Id;
                ans55.AnsMonth = ansMonth; ans55.SRId = sR.Id;
            }

            //การติดตั้งและการยึดตู้อุปกรณ์ :
            var ans56 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1286).FirstOrDefault();
            if (ans56 == null)
            {
                string installbox = Request.Form["installandboxRadio"];
                Answer answer56 = new Answer()
                {
                    AnsDes = installbox,
                    QuestionId = 1286,
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
                string installbox = Request.Form["installandboxRadio"];
                ans56.AnsDes = installbox;
                ans56.AnserTypeId = 4;
                ans56.CreateDate = DateTime.Now;
                ans56.QuestionId = 1286;
                ans56.UserId = user.Id;
                ans56.AnsMonth = ansMonth; ans56.SRId = sR.Id;
            }

            //เสาไฟฟ้าที่ตั้งตั้งอุปกรณ์ :
            var ans57 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1287).FirstOrDefault();
            if (ans57 == null)
            {
                string postElec = Request.Form["postElectriInstallRadio"];
                Answer answer57 = new Answer()
                {
                    AnsDes = postElec,
                    QuestionId = 1287,
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
                string postElec = Request.Form["postElectriInstallRadio"]; ;
                ans57.AnsDes = postElec;
                ans57.AnserTypeId = 4;
                ans57.CreateDate = DateTime.Now;
                ans57.QuestionId = 1287;
                ans57.UserId = user.Id;
                ans57.AnsMonth = ansMonth; ans57.SRId = sR.Id;
            }

            //แนวสายไฟฟ้าและสายเคเบิ้ลเข้าสถานี :
            var ans58 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1288).FirstOrDefault();
            if (ans58 == null)
            {
                string cableinStatiom = Request.Form["cableInStationRadio"];
                Answer answer58 = new Answer()
                {
                    AnsDes = cableinStatiom,
                    QuestionId = 1288,
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
                string cableinStatiom = Request.Form["cableInStationRadio"];
                ans58.AnsDes = cableinStatiom;
                ans58.AnserTypeId = 4;
                ans58.CreateDate = DateTime.Now;
                ans58.QuestionId = 1288;
                ans58.UserId = user.Id;
                ans58.AnsMonth = ansMonth; ans58.SRId = sR.Id;
            }


            //ช่อง Cable Inlet  และความสะอาด :
            var ans59 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1289).FirstOrDefault();
            if (ans59 == null)
            {
                string cleancable = Request.Form["cleanCableRadio"];
                Answer answer59 = new Answer()
                {
                    AnsDes = cleancable,
                    QuestionId = 1289,
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
                string cleancable = Request.Form["cleanCableRadio"];
                ans59.AnsDes = cleancable;
                ans59.AnserTypeId = 4;
                ans59.CreateDate = DateTime.Now;
                ans59.QuestionId = 1289;
                ans59.UserId = user.Id;
                ans59.AnsMonth = ansMonth; ans59.SRId = sR.Id;
            }
            //ความสะอาดภายในตู้ :
            var ans60 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1290).FirstOrDefault();
            if (ans60 == null)
            {
                string cleanbox = Request.Form["CleaninboxRadio"];
                Answer answer60 = new Answer()
                {
                    AnsDes = cleanbox,
                    QuestionId = 1290,
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
                string cleanbox = Request.Form["CleaninboxRadio"];
                ans60.AnsDes = cleanbox;
                ans60.AnserTypeId = 4;
                ans60.CreateDate = DateTime.Now;
                ans60.QuestionId = 1290;
                ans60.UserId = user.Id;
                ans60.AnsMonth = ansMonth; ans60.SRId = sR.Id;
            }

            //ประตูและยางขอบประตูของตู้อุปกรณ์ :
            var ans61 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1291).FirstOrDefault();
            if (ans61 == null)
            {
                string doorboxd = Request.Form["doorandboxRadio"];
                Answer answer61 = new Answer()
                {
                    AnsDes = doorboxd,
                    QuestionId = 1291,
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
                string doorboxd = Request.Form["doorandboxRadio"];
                ans61.AnsDes = doorboxd;
                ans61.AnserTypeId = 4;
                ans61.CreateDate = DateTime.Now;
                ans61.QuestionId = 1291;
                ans61.UserId = user.Id;
                ans61.AnsMonth = ansMonth; ans61.SRId = sR.Id;
            }

            //  ปัญหาที่พบ 1 : 
            var ans62 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1292).FirstOrDefault();
            if (ans62 == null)
            {
                Answer answer62 = new Answer()
                {
                    AnsDes = this.problemTextbox1.Value,
                    QuestionId = 1292,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer62);
            }
            else
            {
                ans62.AnsDes = this.problemTextbox1.Value;
                ans62.AnserTypeId = 1;
                ans62.CreateDate = DateTime.Now;
                ans62.QuestionId = 1292;
                ans62.UserId = user.Id;
                ans62.AnsMonth = ansMonth; ans62.SRId = sR.Id;
            }
            //  วิธีแก้ปัญหา 1 :   
            var ans63 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1293).FirstOrDefault();
            if (ans63 == null)
            {
                Answer answer63 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox1.Value,
                    QuestionId = 1293,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer63);
            }
            else
            {
                ans63.AnsDes = this.howtoSolveTextbox1.Value;
                ans63.AnserTypeId = 1;
                ans63.CreateDate = DateTime.Now;
                ans63.QuestionId = 1293;
                ans63.UserId = user.Id;
                ans63.AnsMonth = ansMonth; ans63.SRId = sR.Id;
            }


            //  ปัญหาที่พบ 2 :  
            var ans64 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1294).FirstOrDefault();
            if (ans64 == null)
            {
                Answer answer64 = new Answer()
                {
                    AnsDes = this.problemTextbox2.Value,
                    QuestionId = 1294,
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
                ans64.AnsDes = this.problemTextbox2.Value;
                ans64.AnserTypeId = 1;
                ans64.CreateDate = DateTime.Now;
                ans64.QuestionId = 1294;
                ans64.UserId = user.Id;
                ans64.AnsMonth = ansMonth; ans64.SRId = sR.Id;
            }

            //  วิธีแก้ปัญหา 2 :   
            var ans65 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1295).FirstOrDefault();
            if (ans65 == null)
            {
                Answer answer65 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox2.Value,
                    QuestionId = 1295,
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
                ans65.AnsDes = this.howtoSolveTextbox2.Value;
                ans65.AnserTypeId = 1;
                ans65.CreateDate = DateTime.Now;
                ans65.QuestionId = 1295;
                ans65.UserId = user.Id;
                ans65.AnsMonth = ansMonth; ans65.SRId = sR.Id;
            }


            //  ปัญหาที่พบ 3 :    
            var ans66 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1296).FirstOrDefault();
            if (ans66 == null)
            {
                Answer answer66 = new Answer()
                {
                    AnsDes = this.problemTextbox3.Value,
                    QuestionId = 1296,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer66);
            }
            else
            {
                ans66.AnsDes = this.problemTextbox3.Value;
                ans66.AnserTypeId = 1;
                ans66.CreateDate = DateTime.Now;
                ans66.QuestionId = 1296;
                ans66.UserId = user.Id;
                ans66.AnsMonth = ansMonth; ans66.SRId = sR.Id;
            }
            //  วิธีแก้ปัญหา 3 :   
            var ans67 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1297).FirstOrDefault();
            if (ans67 == null)
            {
                Answer answer67 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox3.Value,
                    QuestionId = 1297,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer67);
            }
            else
            {

                ans67.AnsDes = this.howtoSolveTextbox3.Value;
                ans67.AnserTypeId = 1;
                ans67.CreateDate = DateTime.Now;
                ans67.QuestionId = 1297;
                ans67.UserId = user.Id;
                ans67.AnsMonth = ansMonth; ans67.SRId = sR.Id;
            }


            //  ปัญหาที่พบ 4 :    
            var ans68 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1298).FirstOrDefault();
            if (ans68 == null)
            {
                Answer answer68 = new Answer()
                {
                    AnsDes = this.problemTextbox4.Value,
                    QuestionId = 1298,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer68);
            }
            else
            {
                ans68.AnsDes = this.problemTextbox4.Value;
                ans68.AnserTypeId = 1;
                ans68.CreateDate = DateTime.Now;
                ans68.QuestionId = 1298;
                ans68.UserId = user.Id;
                ans68.AnsMonth = ansMonth; ans68.SRId = sR.Id;
            }

            //  วิธีแก้ปัญหา 4 :        
            var ans69 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1299).FirstOrDefault();
            if (ans69 == null)
            {
                Answer answer69 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox4.Value,
                    QuestionId = 1299,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer69);
            }
            else
            {
                ans69.AnsDes = this.howtoSolveTextbox4.Value;
                ans69.AnserTypeId = 1;
                ans69.CreateDate = DateTime.Now;
                ans69.QuestionId = 1299;
                ans69.UserId = user.Id;
                ans69.AnsMonth = ansMonth; ans69.SRId = sR.Id;
            }




            //  ปัญหาที่พบ 5 :  
            var ans70 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1300).FirstOrDefault();
            if (ans70 == null)
            {
                Answer answer70 = new Answer()
                {
                    AnsDes = this.problemTextbox5.Value,
                    QuestionId = 1300,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer70);
            }
            else
            {
                ans70.AnsDes = this.problemTextbox5.Value;
                ans70.AnserTypeId = 1;
                ans70.CreateDate = DateTime.Now;
                ans70.QuestionId = 1300;
                ans70.UserId = user.Id;
                ans70.AnsMonth = ansMonth; ans70.SRId = sR.Id;
            }

            //  วิธีแก้ปัญหา 5 :  
            var ans71 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1301).FirstOrDefault();
            if (ans71 == null)
            {
                Answer answer71 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox5.Value,
                    QuestionId = 1301,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer71);
            }
            else
            {
                ans71.AnsDes = this.howtoSolveTextbox5.Value;
                ans71.AnserTypeId = 1;
                ans71.CreateDate = DateTime.Now;
                ans71.QuestionId = 1301;
                ans71.UserId = user.Id;
                ans71.AnsMonth = ansMonth; ans71.SRId = sR.Id;
            }

            //  ปัญหาที่พบ 6 :  
            var ans72 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1302).FirstOrDefault();
            if (ans72 == null)
            {
                Answer answer72 = new Answer()
                {
                    AnsDes = this.problemTextbox6.Value,
                    QuestionId = 1302,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer72);
            }
            else
            {
                ans72.AnsDes = this.problemTextbox6.Value;
                ans72.AnserTypeId = 1;
                ans72.CreateDate = DateTime.Now;
                ans72.QuestionId = 1302;
                ans72.UserId = user.Id;
                ans72.AnsMonth = ansMonth; ans72.SRId = sR.Id;
            }
            //  วิธีแก้ปัญหา 6 :
            var ans73 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1303).FirstOrDefault();
            if (ans73 == null)
            {
                Answer answer73 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox6.Value,
                    QuestionId = 1303,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer73);
            }
            else
            {
                ans73.AnsDes = this.howtoSolveTextbox6.Value;
                ans73.AnserTypeId = 1;
                ans73.CreateDate = DateTime.Now;
                ans73.QuestionId = 1303;
                ans73.UserId = user.Id;
                ans73.AnsMonth = ansMonth; ans73.SRId = sR.Id;
            }
            //  ปัญหาที่พบ 7 :   
            var ans74 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1304).FirstOrDefault();
            if (ans74 == null)
            {

                Answer answer74 = new Answer()
                {
                    AnsDes = this.problemTextbox7.Value,
                    QuestionId = 1304,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer74);
            }
            else
            {
                ans74.AnsDes = this.problemTextbox7.Value;
                ans74.AnserTypeId = 1;
                ans74.CreateDate = DateTime.Now;
                ans74.QuestionId = 1304;
                ans74.UserId = user.Id;
                ans74.AnsMonth = ansMonth; ans74.SRId = sR.Id;
            }
            //  วิธีแก้ปัญหา 7 :    
            var ans75 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1305).FirstOrDefault();
            if (ans75 == null)
            {
                Answer answer75 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox7.Value,
                    QuestionId = 1305,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer75);
            }
            else
            {
                ans75.AnsDes = this.howtoSolveTextbox7.Value;
                ans75.AnserTypeId = 1;
                ans75.CreateDate = DateTime.Now;
                ans75.QuestionId = 1305;
                ans75.UserId = user.Id;
                ans75.AnsMonth = ansMonth; ans75.SRId = sR.Id;
            }


            ///////////////////////////////////////////////////////////////////////////////
            //  ปัญหาที่พบ 8 :      
            var ans76 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1307).FirstOrDefault();
            if (ans76 == null)
            {
                Answer answer76 = new Answer()
                {
                    AnsDes = this.problemTextbox8.Value,
                    QuestionId = 1307,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer76);
            }
            else
            {
                ans76.AnsDes = this.problemTextbox8.Value;
                ans76.AnserTypeId = 1;
                ans76.CreateDate = DateTime.Now;
                ans76.QuestionId = 1307;
                ans76.UserId = user.Id;
                ans76.AnsMonth = ansMonth; ans76.SRId = sR.Id;
            }
            //  วิธีแก้ปัญหา 8 : 
            var ans77 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1308).FirstOrDefault();
            if (ans77 == null)
            {
                Answer answer77 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox8.Value,
                    QuestionId = 1308,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer77);
            }
            else
            {
                ans77.AnsDes = this.howtoSolveTextbox8.Value;
                ans77.AnserTypeId = 1;
                ans77.CreateDate = DateTime.Now;
                ans77.QuestionId = 1308;
                ans77.UserId = user.Id;
                ans77.AnsMonth = ansMonth; ans77.SRId = sR.Id;
            }
            //////////////////////////////////////////////////////////////////////////////////



            ///////////////////////////////////////////////////////////////////////////////
            //  ปัญหาที่พบ 9 :     
            var ans78 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1309).FirstOrDefault();
            if (ans78 == null)
            {
                Answer answer78 = new Answer()
                {
                    AnsDes = this.problemTextbox9.Value,
                    QuestionId = 1309,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer78);
            }
            else
            {
                ans78.AnsDes = this.problemTextbox9.Value;
                ans78.AnserTypeId = 1;
                ans78.CreateDate = DateTime.Now;
                ans78.QuestionId = 1309;
                ans78.UserId = user.Id;
                ans78.AnsMonth = ansMonth; ans78.SRId = sR.Id;
            }
            //  วิธีแก้ปัญหา 9 :  
            var ans79 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1310).FirstOrDefault();
            if (ans79 == null)
            {
                Answer answer79 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox9.Value,
                    QuestionId = 1310,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer79);
            }
            else
            {
                ans79.AnsDes = this.howtoSolveTextbox9.Value;
                ans79.AnserTypeId = 1;
                ans79.CreateDate = DateTime.Now;
                ans79.QuestionId = 1310;
                ans79.UserId = user.Id;
                ans79.AnsMonth = ansMonth; ans79.SRId = sR.Id;
            }
            //////////////////////////////////////////////////////////////////////////////////



            ///////////////////////////////////////////////////////////////////////////////
            //  ปัญหาที่พบ 10 :   
            var ans80 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1311).FirstOrDefault();
            if (ans80 == null)
            {
                Answer answer80 = new Answer()
                {
                    AnsDes = this.problemTextbox10.Value,
                    QuestionId = 1311,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer80);
            }
            else
            {
                ans80.AnsDes = this.problemTextbox10.Value;
                ans80.AnserTypeId = 1;
                ans80.CreateDate = DateTime.Now;
                ans80.QuestionId = 1311;
                ans80.UserId = user.Id;
                ans80.AnsMonth = ansMonth; ans80.SRId = sR.Id;
            }
            //  วิธีแก้ปัญหา 10 :  
            var ans81 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1312).FirstOrDefault();
            if (ans81 == null)
            {
                Answer answer81 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox10.Value,
                    QuestionId = 1312,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer81);
            }
            else
            {
                ans81.AnsDes = this.howtoSolveTextbox10.Value;
                ans81.AnserTypeId = 1;
                ans81.CreateDate = DateTime.Now;
                ans81.QuestionId = 1312;
                ans81.UserId = user.Id;
                ans81.AnsMonth = ansMonth; ans81.SRId = sR.Id;
            }
            //////////////////////////////////////////////////////////////////////////////////
            ///




            ///////////////////////////////////////////////////////////////////////////////
            //  ปัญหาที่พบ 11 : 
            var ans82 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1313).FirstOrDefault();
            if (ans82 == null)
            {
                Answer answer82 = new Answer()
                {
                    AnsDes = this.problemTextbox11.Value,
                    QuestionId = 1313,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer82);
            }
            else
            {
                ans82.AnsDes = this.problemTextbox11.Value;
                ans82.AnserTypeId = 1;
                ans82.CreateDate = DateTime.Now;
                ans82.QuestionId = 1313;
                ans82.UserId = user.Id;
                ans82.AnsMonth = ansMonth; ans82.SRId = sR.Id;
            }

            //  วิธีแก้ปัญหา 11 :  
            var ans83 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1314).FirstOrDefault();
            if (ans83 == null)
            {
                Answer answer83 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox11.Value,
                    QuestionId = 1314,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer83);
            }
            else
            {
                ans83.AnsDes = this.howtoSolveTextbox11.Value;
                ans83.AnserTypeId = 1;
                ans83.CreateDate = DateTime.Now;
                ans83.QuestionId = 1314;
                ans83.UserId = user.Id;
                ans83.AnsMonth = ansMonth; ans83.SRId = sR.Id;
            }
            //////////////////////////////////////////////////////////////////////////////////
            ///






            ///////////////////////////////////////////////////////////////////////////////
            //  ปัญหาที่พบ 12 :   
            var ans84 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1315).FirstOrDefault();
            if (ans84 == null)
            {
                Answer answer84 = new Answer()
                {
                    AnsDes = this.problemTextbox12.Value,
                    QuestionId = 1315,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer84);
            }
            else
            {
                ans84.AnsDes = this.problemTextbox12.Value;
                ans84.AnserTypeId = 1;
                ans84.CreateDate = DateTime.Now;
                ans84.QuestionId = 1315;
                ans84.UserId = user.Id;
                ans84.AnsMonth = ansMonth; ans84.SRId = sR.Id;
            }

            //  วิธีแก้ปัญหา 12 :    
            var ans85 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1316).FirstOrDefault();
            if (ans85 == null)
            {
                Answer answer85 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox12.Value,
                    QuestionId = 1316,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer85);
            }
            else
            {
                ans85.AnsDes = this.howtoSolveTextbox12.Value;
                ans85.AnserTypeId = 1;
                ans85.CreateDate = DateTime.Now;
                ans85.QuestionId = 1316;
                ans85.UserId = user.Id;
                ans85.AnsMonth = ansMonth; ans85.SRId = sR.Id;
            }
            //////////////////////////////////////////////////////////////////////////////////
            ///




            ///////////////////////////////////////////////////////////////////////////////
            //  ปัญหาที่พบ 13 : 
            var ans86 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1317).FirstOrDefault();
            if (ans86 == null)
            {
                Answer answer86 = new Answer()
                {
                    AnsDes = this.problemTextbox13.Value,
                    QuestionId = 1317,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer86);
            }
            else
            {
                ans86.AnsDes = this.problemTextbox13.Value;
                ans86.AnserTypeId = 1;
                ans86.CreateDate = DateTime.Now;
                ans86.QuestionId = 1317;
                ans86.UserId = user.Id;
                ans86.AnsMonth = ansMonth; ans86.SRId = sR.Id;
            }

            //  วิธีแก้ปัญหา 13 :    
            var ans87 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1318).FirstOrDefault();
            if (ans87 == null)
            {
                Answer answer87 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox13.Value,
                    QuestionId = 1318,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer87);
            }
            else
            {
                ans87.AnsDes = this.howtoSolveTextbox13.Value;
                ans87.AnserTypeId = 1;
                ans87.CreateDate = DateTime.Now;
                ans87.QuestionId = 1318;
                ans87.UserId = user.Id;
                ans87.AnsMonth = ansMonth; ans87.SRId = sR.Id;
            }
            //////////////////////////////////////////////////////////////////////////////////
            ///



            ///////////////////////////////////////////////////////////////////////////////
            //  ปัญหาที่พบ 14 : 
            var ans88 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1319).FirstOrDefault();
            if (ans88 == null)
            {
                Answer answer88 = new Answer()
                {
                    AnsDes = this.problemTextbox14.Value,
                    QuestionId = 1319,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer88);
            }
            else
            {
                ans88.AnsDes = this.problemTextbox14.Value;
                ans88.AnserTypeId = 1;
                ans88.CreateDate = DateTime.Now;
                ans88.QuestionId = 1319;
                ans88.UserId = user.Id;
                ans88.AnsMonth = ansMonth; ans88.SRId = sR.Id;
            }
            //  วิธีแก้ปัญหา 14 :         
            var ans89 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1320).FirstOrDefault();
            if (ans89 == null)
            {
                Answer answer89 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox14.Value,
                    QuestionId = 1320,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer89);
            }
            else
            {
                ans89.AnsDes = this.howtoSolveTextbox14.Value;
                ans89.AnserTypeId = 1;
                ans89.CreateDate = DateTime.Now;
                ans89.QuestionId = 1320;
                ans89.UserId = user.Id;
                ans89.AnsMonth = ansMonth; ans89.SRId = sR.Id;
            }
            //////////////////////////////////////////////////////////////////////////////////
            ///




            ///////////////////////////////////////////////////////////////////////////////
            //  ปัญหาที่พบ 15 :  
            var ans90 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1321).FirstOrDefault();
            if (ans90 == null)
            {
                Answer answer90 = new Answer()

                {
                    AnsDes = this.problemTextbox15.Value,
                    QuestionId = 1321,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer90);
            }
            else
            {
                ans90.AnsDes = this.problemTextbox15.Value;
                ans90.AnserTypeId = 1;
                ans90.CreateDate = DateTime.Now;
                ans90.QuestionId = 1321;
                ans90.UserId = user.Id;
                ans90.AnsMonth = ansMonth; ans90.SRId = sR.Id;
            }

            //  วิธีแก้ปัญหา 15 :  
            var ans91 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1322).FirstOrDefault();
            if (ans91 == null)
            {
                Answer answer91 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox15.Value,
                    QuestionId = 1322,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    SRId = sR.Id,
                    UserId = user.Id,
                    AnsMonth = ansMonth
                };
                uSOEntities.Answers.Add(answer91);
            }
            else
            {
                ans91.AnsDes = this.howtoSolveTextbox15.Value;
                ans91.AnserTypeId = 1;
                ans91.CreateDate = DateTime.Now;
                ans91.QuestionId = 1322;
                ans91.UserId = user.Id;
                ans91.AnsMonth = ansMonth; ans91.SRId = sR.Id;
            }
            //////////////////////////////////////////////////////////////////////////////////
            ///


            //////////////////////////////////////////////////////////////////////////////////
            // รายการอุปกรณ์ 1 :      
            var ans92 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1323).FirstOrDefault();
            if (ans92 == null)
            {
                Answer answer156 = new Answer()
                {
                    AnsDes = this.toolsListTextbox1.Value,
                    QuestionId = 1323,
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
                ans92.AnsDes = this.toolsListTextbox1.Value;
                ans92.AnserTypeId = 1;
                ans92.CreateDate = DateTime.Now;
                ans92.QuestionId = 1323;
                ans92.UserId = user.Id;
                ans92.AnsMonth = ansMonth; ans92.SRId = sR.Id;
            }

            //  SerialNumber :   
            var ans93 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1324).FirstOrDefault();
            if (ans93 == null)
            {
                Answer answer157 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox1.Value,
                    QuestionId = 1324,
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
                ans93.AnsDes = this.serialNumberTextbox1.Value;
                ans93.AnserTypeId = 1;
                ans93.CreateDate = DateTime.Now;
                ans93.QuestionId = 1324;
                ans93.UserId = user.Id;
                ans93.AnsMonth = ansMonth; ans93.SRId = sR.Id;
            }

            //  new SerialNumber :  
            var ans94 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1325).FirstOrDefault();
            if (ans94 == null)
            {
                Answer answer158 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox1.Value,
                    QuestionId = 1325,
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
                ans94.AnsDes = this.newSerialNumberTextbox1.Value;
                ans94.AnserTypeId = 1;
                ans94.CreateDate = DateTime.Now;
                ans94.QuestionId = 1325;
                ans94.UserId = user.Id;
                ans94.AnsMonth = ansMonth; ans94.SRId = sR.Id;
            }

            //  หมายเหตุ :  
            var ans95 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1326).FirstOrDefault();
            if (ans95 == null)
            {
                Answer answer159 = new Answer()
                {
                    AnsDes = this.noteTextbox1.Value,
                    QuestionId = 1326,
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
                ans95.AnsDes = this.noteTextbox1.Value;
                ans95.AnserTypeId = 1;
                ans95.CreateDate = DateTime.Now;
                ans95.QuestionId = 1326;
                ans95.UserId = user.Id;
                ans95.AnsMonth = ansMonth; ans95.SRId = sR.Id;
            }
            //////////////////////////////////////////////////////////////////////////////////






            //////////////////////////////////////////////////////////////////////////////////
            // รายการอุปกรณ์ 2 :  
            var ans96 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1327).FirstOrDefault();
            if (ans96 == null)
            {
                Answer answer160 = new Answer()
                {
                    AnsDes = this.toolsListTextbox2.Value,
                    QuestionId = 1327,
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
                ans96.AnsDes = this.toolsListTextbox2.Value;
                ans96.AnserTypeId = 1;
                ans96.CreateDate = DateTime.Now;
                ans96.QuestionId = 1327;
                ans96.UserId = user.Id;
                ans96.AnsMonth = ansMonth; ans96.SRId = sR.Id;
            }

            //  SerialNumber 2 :    
            var ans97 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1328).FirstOrDefault();
            if (ans97 == null)
            {
                Answer answer161 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox2.Value,
                    QuestionId = 1328,
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
                ans97.AnsDes = this.serialNumberTextbox2.Value;
                ans97.AnserTypeId = 1;
                ans97.CreateDate = DateTime.Now;
                ans97.QuestionId = 1328;
                ans97.UserId = user.Id;
                ans97.AnsMonth = ansMonth; ans97.SRId = sR.Id;
            }
            //  new SerialNumber 2 :         
            var ans98 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1329).FirstOrDefault();
            if (ans98 == null)
            {
                Answer answer162 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox2.Value,
                    QuestionId = 1329,
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

                ans98.AnsDes = this.newSerialNumberTextbox2.Value;
                ans98.AnserTypeId = 1;
                ans98.CreateDate = DateTime.Now;
                ans98.QuestionId = 1329;
                ans98.UserId = user.Id;
                ans98.AnsMonth = ansMonth; ans98.SRId = sR.Id;
            }

            //  หมายเหตุ  2:           
            var ans99 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1330).FirstOrDefault();
            if (ans99 == null)
            {
                Answer answer163 = new Answer()
                {
                    AnsDes = this.noteTextbox2.Value,
                    QuestionId = 1330,
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
                ans99.AnsDes = this.noteTextbox2.Value;
                ans99.AnserTypeId = 1;
                ans99.CreateDate = DateTime.Now;
                ans99.QuestionId = 1330;
                ans99.UserId = user.Id;
                ans99.AnsMonth = ansMonth; ans99.SRId = sR.Id;
            }
            //////////////////////////////////////////////////////////////////////////////////



            //////////////////////////////////////////////////////////////////////////////////
            // รายการอุปกรณ์ 3 :   
            var ans100 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1331).FirstOrDefault();
            if (ans100 == null)
            {
                Answer answer164 = new Answer()
                {
                    AnsDes = this.toolsListTextbox3.Value,
                    QuestionId = 1331,
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
                ans100.AnsDes = this.toolsListTextbox3.Value;
                ans100.AnserTypeId = 1;
                ans100.CreateDate = DateTime.Now;
                ans100.QuestionId = 1331;
                ans100.UserId = user.Id;
                ans100.AnsMonth = ansMonth; ans100.SRId = sR.Id;
            }

            //  SerialNumber 3 :  
            var ans101 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1332).FirstOrDefault();
            if (ans101 == null)
            {
                Answer answer165 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox3.Value,
                    QuestionId = 1332,
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
                ans101.AnsDes = this.serialNumberTextbox3.Value;
                ans101.AnserTypeId = 1;
                ans101.CreateDate = DateTime.Now;
                ans101.QuestionId = 1332;
                ans101.UserId = user.Id;
                ans101.AnsMonth = ansMonth; ans101.SRId = sR.Id;
            }

            //  new SerialNumber 3 : 
            var ans102 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1333).FirstOrDefault();
            if (ans102 == null)
            {
                Answer answer166 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox3.Value,
                    QuestionId = 1333,
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
                ans102.AnsDes = this.newSerialNumberTextbox3.Value;
                ans102.AnserTypeId = 1;
                ans102.CreateDate = DateTime.Now;
                ans102.QuestionId = 1333;
                ans102.UserId = user.Id;
                ans102.AnsMonth = ansMonth; ans102.SRId = sR.Id;
            }

            //  หมายเหตุ  3:     
            var ans103 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1334).FirstOrDefault();
            if (ans103 == null)
            {
                Answer answer167 = new Answer()
                {
                    AnsDes = this.noteTextbox3.Value,
                    QuestionId = 1334,
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
                ans103.AnsDes = this.noteTextbox3.Value;
                ans103.AnserTypeId = 1;
                ans103.CreateDate = DateTime.Now;
                ans103.QuestionId = 1334;
                ans103.UserId = user.Id;
                ans103.AnsMonth = ansMonth; ans103.SRId = sR.Id;
            }
            //////////////////////////////////////////////////////////////////////////////////




            //////////////////////////////////////////////////////////////////////////////////
            // รายการอุปกรณ์ 4 :
            var ans104 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1335).FirstOrDefault();
            if (ans104 == null)
            {
                Answer answer168 = new Answer()
                {
                    AnsDes = this.toolsListTextbox4.Value,
                    QuestionId = 1335,
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
                ans104.AnsDes = this.toolsListTextbox4.Value;
                ans104.AnserTypeId = 1;
                ans104.CreateDate = DateTime.Now;
                ans104.QuestionId = 1335;
                ans104.UserId = user.Id;
                ans104.AnsMonth = ansMonth; ans104.SRId = sR.Id;
            }

            //  SerialNumber 4 :      
            var ans105 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1336).FirstOrDefault();
            if (ans105 == null)
            {
                Answer answer169 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox4.Value,
                    QuestionId = 1336,
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
                ans105.AnsDes = this.serialNumberTextbox4.Value;
                ans105.AnserTypeId = 1;
                ans105.CreateDate = DateTime.Now;
                ans105.QuestionId = 1336;
                ans105.UserId = user.Id;
                ans105.AnsMonth = ansMonth; ans105.SRId = sR.Id;
            }

            //  new SerialNumber 4 :   
            var ans106 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1337).FirstOrDefault();
            if (ans106 == null)
            {
                Answer answer170 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox4.Value,
                    QuestionId = 1337,
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
                ans106.AnsDes = this.newSerialNumberTextbox4.Value;
                ans106.AnserTypeId = 1;
                ans106.CreateDate = DateTime.Now;
                ans106.QuestionId = 1337;
                ans106.UserId = user.Id;
                ans106.AnsMonth = ansMonth; ans106.SRId = sR.Id;
            }

            //  หมายเหตุ  4:
            var ans107 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1338).FirstOrDefault();
            if (ans107 == null)
            {
                Answer answer171 = new Answer()
                {
                    AnsDes = this.noteTextbox4.Value,
                    QuestionId = 1338,
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
                ans107.AnsDes = this.noteTextbox4.Value;
                ans107.AnserTypeId = 1;
                ans107.CreateDate = DateTime.Now;
                ans107.QuestionId = 1338;
                ans107.UserId = user.Id;
                ans107.AnsMonth = ansMonth; ans107.SRId = sR.Id;
            }
            //////////////////////////////////////////////////////////////////////////////////




            //////////////////////////////////////////////////////////////////////////////////
            // รายการอุปกรณ์ 5 : 
            var ans108 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1339).FirstOrDefault();
            if (ans108 == null)
            {
                Answer answer172 = new Answer()
                {
                    AnsDes = this.toolsListTextbox5.Value,
                    QuestionId = 1339,
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
                ans108.AnsDes = this.toolsListTextbox5.Value;
                ans108.AnserTypeId = 1;
                ans108.CreateDate = DateTime.Now;
                ans108.QuestionId = 1339;
                ans108.UserId = user.Id;
                ans108.AnsMonth = ansMonth; ans108.SRId = sR.Id;
            }

            //  SerialNumber 5 :   
            var ans109 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1340).FirstOrDefault();
            if (ans109 == null)
            {
                Answer answer173 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox5.Value,
                    QuestionId = 1340,
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
                ans109.AnsDes = this.serialNumberTextbox5.Value;
                ans109.AnserTypeId = 1;
                ans109.CreateDate = DateTime.Now;
                ans109.QuestionId = 1340;
                ans109.UserId = user.Id;
                ans109.AnsMonth = ansMonth; ans109.SRId = sR.Id;
            }

            //  new SerialNumber 5 : 
            var ans110 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1341).FirstOrDefault();
            if (ans110 == null)
            {
                Answer answer174 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox5.Value,
                    QuestionId = 1341,
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
                ans110.AnsDes = this.newSerialNumberTextbox5.Value;
                ans110.AnserTypeId = 1;
                ans110.CreateDate = DateTime.Now;
                ans110.QuestionId = 1341;
                ans110.UserId = user.Id;
                ans110.AnsMonth = ansMonth; ans110.SRId = sR.Id;
            }

            //  หมายเหตุ  5:  
            var ans111 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1342).FirstOrDefault();
            if (ans111 == null)
            {
                Answer answer175 = new Answer()
                {
                    AnsDes = this.noteTextbox5.Value,
                    QuestionId = 1342,
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
                ans111.AnsDes = this.noteTextbox5.Value;
                ans111.AnserTypeId = 1;
                ans111.CreateDate = DateTime.Now;
                ans111.QuestionId = 1342;
                ans111.UserId = user.Id;
                ans111.AnsMonth = ansMonth; ans111.SRId = sR.Id;
            }
            //////////////////////////////////////////////////////////////////////////////////






            //////////////////////////////////////////////////////////////////////////////////
            // รายการอุปกรณ์ 6 :  
            var ans112 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1343).FirstOrDefault();
            if (ans112 == null)
            {
                Answer answer176 = new Answer()
                {
                    AnsDes = this.toolsListTextbox6.Value,
                    QuestionId = 1343,
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
                ans112.AnsDes = this.toolsListTextbox6.Value;
                ans112.AnserTypeId = 1;
                ans112.CreateDate = DateTime.Now;
                ans112.QuestionId = 1343;
                ans112.UserId = user.Id;
                ans112.AnsMonth = ansMonth; ans112.SRId = sR.Id;
            }

            //  SerialNumber 6 :   
            var ans113 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1344).FirstOrDefault();
            if (ans113 == null)
            {
                Answer answer177 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox6.Value,
                    QuestionId = 1344,
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
                ans113.AnsDes = this.serialNumberTextbox6.Value;
                ans113.AnserTypeId = 1;
                ans113.CreateDate = DateTime.Now;
                ans113.QuestionId = 1344;
                ans113.UserId = user.Id;
                ans113.AnsMonth = ansMonth; ans113.SRId = sR.Id;
            }

            //  new SerialNumber 6 :           
            var ans114 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1345).FirstOrDefault();
            if (ans114 == null)
            {
                Answer answer178 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox6.Value,
                    QuestionId = 1345,
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
                ans114.AnsDes = this.newSerialNumberTextbox6.Value;
                ans114.AnserTypeId = 1;
                ans114.CreateDate = DateTime.Now;
                ans114.QuestionId = 1345;
                ans114.UserId = user.Id;
                ans114.AnsMonth = ansMonth; ans114.SRId = sR.Id;
            }

            //  หมายเหตุ  6:   
            var ans115 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1346).FirstOrDefault();
            if (ans115 == null)
            {
                Answer answer179 = new Answer()
                {
                    AnsDes = this.noteTextbox6.Value,
                    QuestionId = 1346,
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
                ans115.AnsDes = this.noteTextbox6.Value;
                ans115.AnserTypeId = 1;
                ans115.CreateDate = DateTime.Now;
                ans115.QuestionId = 1346;
                ans115.UserId = user.Id;
                ans115.AnsMonth = ansMonth; ans115.SRId = sR.Id;
            }
            //////////////////////////////////////////////////////////////////////////////////




            //////////////////////////////////////////////////////////////////////////////////
            // รายการอุปกรณ์ 7 :      
            var ans116 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1347).FirstOrDefault();
            if (ans116 == null)
            {
                Answer answer180 = new Answer()
                {
                    AnsDes = this.toolsListTextbox7.Value,
                    QuestionId = 1347,
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
                ans116.AnsDes = this.toolsListTextbox7.Value;
                ans116.AnserTypeId = 1;
                ans116.CreateDate = DateTime.Now;
                ans116.QuestionId = 1347;
                ans116.UserId = user.Id;
                ans116.AnsMonth = ansMonth; ans116.SRId = sR.Id;
            }

            //  SerialNumber 7 :  
            var ans117 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1348).FirstOrDefault();
            if (ans117 == null)
            {
                Answer answer181 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox7.Value,
                    QuestionId = 1348,
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
                ans117.AnsDes = this.serialNumberTextbox7.Value;
                ans117.AnserTypeId = 1;
                ans117.CreateDate = DateTime.Now;
                ans117.QuestionId = 1348;
                ans117.UserId = user.Id;
                ans117.AnsMonth = ansMonth; ans117.SRId = sR.Id;
            }

            //  new SerialNumber 7 :  
            var ans118 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1349).FirstOrDefault();
            if (ans118 == null)
            {
                Answer answer182 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox7.Value,
                    QuestionId = 1349,
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
                ans118.AnsDes = this.newSerialNumberTextbox7.Value;
                ans118.AnserTypeId = 1;
                ans118.CreateDate = DateTime.Now;
                ans118.QuestionId = 1349;
                ans118.UserId = user.Id;
                ans118.AnsMonth = ansMonth; ans118.SRId = sR.Id;
            }

            //  หมายเหตุ  7:  
            var ans119 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1350).FirstOrDefault();
            if (ans119 == null)
            {
                Answer answer183 = new Answer()
                {
                    AnsDes = this.noteTextbox7.Value,
                    QuestionId = 1350,
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
                ans119.AnsDes = this.noteTextbox7.Value;
                ans119.AnserTypeId = 1;
                ans119.CreateDate = DateTime.Now;
                ans119.QuestionId = 1350;
                ans119.UserId = user.Id;
                ans119.AnsMonth = ansMonth; ans119.SRId = sR.Id;
            }
            //////////////////////////////////////////////////////////////////////////////////



            //////////////////////////////////////////////////////////////////////////////////
            // รายการอุปกรณ์ 8 :  
            var ans120 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1351).FirstOrDefault();
            if (ans120 == null)
            {
                Answer answer184 = new Answer()
                {
                    AnsDes = this.toolsListTextbox8.Value,
                    QuestionId = 1351,
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
                ans120.AnsDes = this.toolsListTextbox8.Value;
                ans120.AnserTypeId = 1;
                ans120.CreateDate = DateTime.Now;
                ans120.QuestionId = 1351;
                ans120.UserId = user.Id;
                ans120.AnsMonth = ansMonth; ans120.SRId = sR.Id;
            }

            //  SerialNumber 8 :    
            var ans121 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1352).FirstOrDefault();
            if (ans121 == null)
            {
                Answer answer185 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox8.Value,
                    QuestionId = 1352,
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
                ans121.AnsDes = this.serialNumberTextbox8.Value;
                ans121.AnserTypeId = 1;
                ans121.CreateDate = DateTime.Now;
                ans121.QuestionId = 1352;
                ans121.UserId = user.Id;
                ans121.AnsMonth = ansMonth; ans121.SRId = sR.Id;
            }

            //  new SerialNumber 8 :    
            var ans122 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1353).FirstOrDefault();
            if (ans122 == null)
            {
                Answer answer186 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox8.Value,
                    QuestionId = 1353,
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
                ans122.AnsDes = this.newSerialNumberTextbox8.Value;
                ans122.AnserTypeId = 1;
                ans122.CreateDate = DateTime.Now;
                ans122.QuestionId = 1353;
                ans122.UserId = user.Id;
                ans122.AnsMonth = ansMonth; ans122.SRId = sR.Id;
            }

            //  หมายเหตุ  8:          
            var ans123 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1354).FirstOrDefault();
            if (ans123 == null)
            {
                Answer answer187 = new Answer()
                {
                    AnsDes = this.noteTextbox8.Value,
                    QuestionId = 1354,
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
                ans123.AnsDes = this.noteTextbox8.Value;
                ans123.AnserTypeId = 1;
                ans123.CreateDate = DateTime.Now;
                ans123.QuestionId = 1354;
                ans123.UserId = user.Id;
                ans123.AnsMonth = ansMonth; ans123.SRId = sR.Id;
            }
            //////////////////////////////////////////////////////////////////////////////////



            //////////////////////////////////////////////////////////////////////////////////
            // รายการอุปกรณ์ 9 :   
            var ans124 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1355).FirstOrDefault();
            if (ans124 == null)
            {
                Answer answer188 = new Answer()
                {
                    AnsDes = this.toolsListTextbox9.Value,
                    QuestionId = 1355,
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
                ans124.AnsDes = this.toolsListTextbox9.Value;
                ans124.AnserTypeId = 1;
                ans124.CreateDate = DateTime.Now;
                ans124.QuestionId = 1355;
                ans124.UserId = user.Id;
                ans124.AnsMonth = ansMonth; ans124.SRId = sR.Id;
            }

            //  SerialNumber 9 :      
            var ans125 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1356).FirstOrDefault();
            if (ans125 == null)
            {
                Answer answer189 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox9.Value,
                    QuestionId = 1356,
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
                ans125.AnsDes = this.serialNumberTextbox9.Value;
                ans125.AnserTypeId = 1;
                ans125.CreateDate = DateTime.Now;
                ans125.QuestionId = 1356;
                ans125.UserId = user.Id;
                ans125.AnsMonth = ansMonth; ans125.SRId = sR.Id;
            }

            //  new SerialNumber 9 :      
            var ans126 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1357).FirstOrDefault();
            if (ans126 == null)
            {
                Answer answer190 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox9.Value,
                    QuestionId = 1357,
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
                ans126.AnsDes = this.newSerialNumberTextbox9.Value;
                ans126.AnserTypeId = 1;
                ans126.CreateDate = DateTime.Now;
                ans126.QuestionId = 1357;
                ans126.UserId = user.Id;
                ans126.AnsMonth = ansMonth; ans126.SRId = sR.Id;
            }

            //  หมายเหตุ  9:     
            var ans127 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1358).FirstOrDefault();
            if (ans127 == null)
            {
                Answer answer191 = new Answer()
                {
                    AnsDes = this.noteTextbox9.Value,
                    QuestionId = 1358,
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
                ans127.AnsDes = this.noteTextbox9.Value;
                ans127.AnserTypeId = 1;
                ans127.CreateDate = DateTime.Now;
                ans127.QuestionId = 1358;
                ans127.UserId = user.Id;
                ans127.AnsMonth = ansMonth; ans127.SRId = sR.Id;
            }
            //////////////////////////////////////////////////////////////////////////////////










            //////////////////////////////////////////////////////////////////////////////////
            // รายการอุปกรณ์ 10 :  
            var ans128 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1359).FirstOrDefault();
            if (ans128 == null)
            {
                Answer answer192 = new Answer()
                {
                    AnsDes = this.toolsListTextbox10.Value,
                    QuestionId = 1359,
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
                ans128.AnsDes = this.toolsListTextbox10.Value;
                ans128.AnserTypeId = 1;
                ans128.CreateDate = DateTime.Now;
                ans128.QuestionId = 1359;
                ans128.UserId = user.Id;
                ans128.AnsMonth = ansMonth; ans128.SRId = sR.Id;
            }

            //  SerialNumber 10 :
            var ans129 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1360).FirstOrDefault();
            if (ans129 == null)
            {
                Answer answer193 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox10.Value,
                    QuestionId = 1360,
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
                ans129.AnsDes = this.serialNumberTextbox10.Value;
                ans129.AnserTypeId = 1;
                ans129.CreateDate = DateTime.Now;
                ans129.QuestionId = 1360;
                ans129.UserId = user.Id;
                ans129.AnsMonth = ansMonth; ans129.SRId = sR.Id;
            }

            //  new SerialNumber 10 :    
            var ans130 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1361).FirstOrDefault();
            if (ans130 == null)
            {
                Answer answer194 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox10.Value,
                    QuestionId = 1361,
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
                ans130.AnsDes = this.newSerialNumberTextbox10.Value;
                ans130.AnserTypeId = 1;
                ans130.CreateDate = DateTime.Now;
                ans130.QuestionId = 1361;
                ans130.UserId = user.Id;
                ans130.AnsMonth = ansMonth; ans130.SRId = sR.Id;
            }

            //  หมายเหตุ  10:    
            var ans131 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1362).FirstOrDefault();
            if (ans131 == null)
            {
                Answer answer195 = new Answer()
                {
                    AnsDes = this.noteTextbox10.Value,
                    QuestionId = 1362,
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
                ans131.AnsDes = this.noteTextbox10.Value;
                ans131.AnserTypeId = 1;
                ans131.CreateDate = DateTime.Now;
                ans131.QuestionId = 1362;
                ans131.UserId = user.Id;
                ans131.AnsMonth = ansMonth; ans131.SRId = sR.Id;
            }
            //////////////////////////////////////////////////////////////////////////////////






            //////////////////////////////////////////////////////////////////////////////////
            // รายการอุปกรณ์ 11 : 
            var ans132 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1363).FirstOrDefault();
            if (ans132 == null)
            {
                Answer answer196 = new Answer()
                {
                    AnsDes = this.toolsListTextbox11.Value,
                    QuestionId = 1363,
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
                ans132.AnsDes = this.toolsListTextbox11.Value;
                ans132.AnserTypeId = 1;
                ans132.CreateDate = DateTime.Now;
                ans132.QuestionId = 1363;
                ans132.UserId = user.Id;
                ans132.AnsMonth = ansMonth; ans132.SRId = sR.Id;
            }

            //  SerialNumber 11 :
            var ans133 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1364).FirstOrDefault();
            if (ans133 == null)
            {
                Answer answer197 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox11.Value,
                    QuestionId = 1364,
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
                ans133.AnsDes = this.serialNumberTextbox11.Value;
                ans133.AnserTypeId = 1;
                ans133.CreateDate = DateTime.Now;
                ans133.QuestionId = 1364;
                ans133.UserId = user.Id;
                ans133.AnsMonth = ansMonth; ans133.SRId = sR.Id;
            }

            //  new SerialNumber 11 :  
            var ans134 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1365).FirstOrDefault();
            if (ans134 == null)
            {
                Answer answer198 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox11.Value,
                    QuestionId = 1365,
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
                ans134.AnsDes = this.newSerialNumberTextbox11.Value;
                ans134.AnserTypeId = 1;
                ans134.CreateDate = DateTime.Now;
                ans134.QuestionId = 1365;
                ans134.UserId = user.Id;
                ans134.AnsMonth = ansMonth; ans134.SRId = sR.Id;
            }

            //  หมายเหตุ  11:      
            var ans135 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1366).FirstOrDefault();
            if (ans135 == null)
            {
                Answer answer199 = new Answer()
                {
                    AnsDes = this.noteTextbox11.Value,
                    QuestionId = 1366,
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
                ans135.AnsDes = this.noteTextbox11.Value;
                ans135.AnserTypeId = 1;
                ans135.CreateDate = DateTime.Now;
                ans135.QuestionId = 1366;
                ans135.UserId = user.Id;
                ans135.AnsMonth = ansMonth; ans135.SRId = sR.Id;
            }
            //////////////////////////////////////////////////////////////////////////////////
            ///








            //////////////////////////////////////////////////////////////////////////////////
            // รายการอุปกรณ์ 12 :   
            var ans136 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1367).FirstOrDefault();
            if (ans136 == null)
            {
                Answer answer200 = new Answer()
                {
                    AnsDes = this.toolsListTextbox12.Value,
                    QuestionId = 1367,
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
                ans136.AnsDes = this.toolsListTextbox12.Value;
                ans136.AnserTypeId = 1;
                ans136.CreateDate = DateTime.Now;
                ans136.QuestionId = 1367;
                ans136.UserId = user.Id;
                ans136.AnsMonth = ansMonth; ans136.SRId = sR.Id;
            }

            //  SerialNumber 12 :   
            var ans137 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1368).FirstOrDefault();
            if (ans137 == null)
            {
                Answer answer201 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox12.Value,
                    QuestionId = 1368,
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
                ans137.AnsDes = this.serialNumberTextbox12.Value;
                ans137.AnserTypeId = 1;
                ans137.CreateDate = DateTime.Now;
                ans137.QuestionId = 1368;
                ans137.UserId = user.Id;
                ans137.AnsMonth = ansMonth; ans137.SRId = sR.Id;
            }

            //  new SerialNumber 12 :    
            var ans138 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1369).FirstOrDefault();
            if (ans138 == null)
            {
                Answer answer202 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox12.Value,
                    QuestionId = 1369,
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
                ans138.AnsDes = this.newSerialNumberTextbox12.Value;
                ans138.AnserTypeId = 1;
                ans138.CreateDate = DateTime.Now;
                ans138.QuestionId = 1369;
                ans138.UserId = user.Id;
                ans138.AnsMonth = ansMonth; ans138.SRId = sR.Id;
            }

            //  หมายเหตุ  12:     
            var ans139 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1370).FirstOrDefault();
            if (ans139 == null)
            {
                Answer answer203 = new Answer()
                {
                    AnsDes = this.noteTextbox12.Value,
                    QuestionId = 1370,
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
                ans139.AnsDes = this.noteTextbox12.Value;
                ans139.AnserTypeId = 1;
                ans139.CreateDate = DateTime.Now;
                ans139.QuestionId = 1370;
                ans139.UserId = user.Id;
                ans139.AnsMonth = ansMonth; ans139.SRId = sR.Id;
            }
            //////////////////////////////////////////////////////////////////////////////////
            ///






            //////////////////////////////////////////////////////////////////////////////////
            // รายการอุปกรณ์ 13 :    
            var ans140 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1371).FirstOrDefault();
            if (ans140 == null)
            {
                Answer answer204 = new Answer()
                {
                    AnsDes = this.toolsListTextbox13.Value,
                    QuestionId = 1371,
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
                ans140.AnsDes = this.toolsListTextbox13.Value;
                ans140.AnserTypeId = 1;
                ans140.CreateDate = DateTime.Now;
                ans140.QuestionId = 1371;
                ans140.UserId = user.Id;
                ans140.AnsMonth = ansMonth; ans140.SRId = sR.Id;
            }
            var ans141 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1372).FirstOrDefault();
            if (ans141 == null)
            {
                //  SerialNumber 13 :           
                Answer answer205 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox13.Value,
                    QuestionId = 1372,
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
                ans141.AnsDes = this.serialNumberTextbox13.Value;
                ans141.AnserTypeId = 1;
                ans141.CreateDate = DateTime.Now;
                ans141.QuestionId = 1372;
                ans141.UserId = user.Id;
                ans141.AnsMonth = ansMonth; ans141.SRId = sR.Id;
            }

            //  new SerialNumber 13 :   
            var ans142 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1373).FirstOrDefault();
            if (ans142 == null)
            {
                Answer answer206 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox13.Value,
                    QuestionId = 1373,
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
                ans142.AnsDes = this.newSerialNumberTextbox13.Value;
                ans142.AnserTypeId = 1;
                ans142.CreateDate = DateTime.Now;
                ans142.QuestionId = 1373;
                ans142.UserId = user.Id;
                ans142.AnsMonth = ansMonth; ans142.SRId = sR.Id;
            }

            //  หมายเหตุ  13   :    
            var ans143 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1374).FirstOrDefault();
            if (ans143 == null)
            {
                Answer answer207 = new Answer()
                {
                    AnsDes = this.noteTextbox13.Value,
                    QuestionId = 1374,
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
                ans143.AnsDes = this.noteTextbox13.Value;
                ans143.AnserTypeId = 1;
                ans143.CreateDate = DateTime.Now;
                ans143.QuestionId = 1374;
                ans143.UserId = user.Id;
                ans143.AnsMonth = ansMonth; ans143.SRId = sR.Id;
            }
            //////////////////////////////////////////////////////////////////////////////////



            //////////////////////////////////////////////////////////////////////////////////
            // รายการอุปกรณ์ 14 : 
            var ans144 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1375).FirstOrDefault();
            if (ans144 == null)
            {
                Answer answer208 = new Answer()
                {
                    AnsDes = this.toolsListTextbox14.Value,
                    QuestionId = 1375,
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
                ans144.AnsDes = this.toolsListTextbox14.Value;
                ans144.AnserTypeId = 1;
                ans144.CreateDate = DateTime.Now;
                ans144.QuestionId = 1375;
                ans144.UserId = user.Id;
                ans144.AnsMonth = ansMonth; ans144.SRId = sR.Id;
            }

            //  SerialNumber 14 :     
            var ans145 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1376).FirstOrDefault();
            if (ans145 == null)
            {
                Answer answer209 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox14.Value,
                    QuestionId = 1376,
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
                ans145.AnsDes = this.serialNumberTextbox14.Value;
                ans145.AnserTypeId = 1;
                ans145.CreateDate = DateTime.Now;
                ans145.QuestionId = 1376;
                ans145.UserId = user.Id;
                ans145.AnsMonth = ansMonth; ans145.SRId = sR.Id;
            }

            //  new SerialNumber 14 :  
            var ans146 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1377).FirstOrDefault();
            if (ans146 == null)
            {
                Answer answer210 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox14.Value,
                    QuestionId = 1377,
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
                ans146.AnsDes = this.newSerialNumberTextbox14.Value;
                ans146.AnserTypeId = 1;
                ans146.CreateDate = DateTime.Now;
                ans146.QuestionId = 1377;
                ans146.UserId = user.Id;
                ans146.AnsMonth = ansMonth; ans146.SRId = sR.Id;
            }

            //  หมายเหตุ  143   :    
            var ans147 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1378).FirstOrDefault();
            if (ans147 == null)
            {
                Answer answer211 = new Answer()
                {
                    AnsDes = this.noteTextbox14.Value,
                    QuestionId = 1378,
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
                ans147.AnsDes = this.noteTextbox14.Value;
                ans147.AnserTypeId = 1;
                ans147.CreateDate = DateTime.Now;
                ans147.QuestionId = 1378;
                ans147.UserId = user.Id;
                ans147.AnsMonth = ansMonth; ans147.SRId = sR.Id;
            }
            //////////////////////////////////////////////////////////////////////////////////






            //////////////////////////////////////////////////////////////////////////////////
            // รายการอุปกรณ์ 15 :  
            var ans148 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1379).FirstOrDefault();
            if (ans148 == null)
            {
                Answer answer212 = new Answer()
                {
                    AnsDes = this.toolsListTextbox15.Value,
                    QuestionId = 1379,
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
                ans148.AnsDes = this.toolsListTextbox15.Value;
                ans148.AnserTypeId = 1;
                ans148.CreateDate = DateTime.Now;
                ans148.QuestionId = 1379;
                ans148.UserId = user.Id;
                ans148.AnsMonth = ansMonth; ans148.SRId = sR.Id;
            }

            //  SerialNumber 15 :    
            var ans149 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1380).FirstOrDefault();
            if (ans149 == null)
            {
                Answer answer213 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox15.Value,
                    QuestionId = 1380,
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
                ans149.AnsDes = this.serialNumberTextbox15.Value;
                ans149.AnserTypeId = 1;
                ans149.CreateDate = DateTime.Now;
                ans149.QuestionId = 1380;
                ans149.UserId = user.Id;
                ans149.AnsMonth = ansMonth; ans149.SRId = sR.Id;
            }

            //  new SerialNumber 15 :      
            var ans150 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1381).FirstOrDefault();
            if (ans150 == null)
            {
                Answer answer214 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox15.Value,
                    QuestionId = 1381,
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
                ans150.AnsDes = this.newSerialNumberTextbox15.Value;
                ans150.AnserTypeId = 1;
                ans150.CreateDate = DateTime.Now;
                ans150.QuestionId = 1381;
                ans150.UserId = user.Id;
                ans150.AnsMonth = ansMonth; ans150.SRId = sR.Id;
            }

            //  หมายเหตุ  15   :   
            var ans151 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1382).FirstOrDefault();
            if (ans151 == null)
            {
                Answer answer215 = new Answer()
                {
                    AnsDes = this.noteTextbox15.Value,
                    QuestionId = 1382,
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
                ans151.AnsDes = this.noteTextbox15.Value;
                ans151.AnserTypeId = 1;
                ans151.CreateDate = DateTime.Now;
                ans151.QuestionId = 1382;
                ans151.UserId = user.Id;
                ans151.AnsMonth = ansMonth; ans151.SRId = sR.Id;
            }
            //////////////////////////////////////////////////////////////////////////////////
            ///

            // team name :  
            var ans152 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1383).FirstOrDefault();
            if (ans152 == null)
            {
                Answer answer216 = new Answer()
                {
                    AnsDes = this.nameTeampmTextbox.Value,
                    QuestionId = 1383,
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
                ans152.AnsDes = this.nameTeampmTextbox.Value;
                ans152.AnserTypeId = 1;
                ans152.CreateDate = DateTime.Now;
                ans152.QuestionId = 1383;
                ans152.UserId = user.Id;
                ans152.AnsMonth = ansMonth; ans152.SRId = sR.Id;
            }


            // วันที่ทำ PM :  
            var ans153 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1384).FirstOrDefault();
            if (ans153 == null)
            {
                Answer answer217 = new Answer()
                {
                    AnsDes = this.dayDopmTextbox.Value,
                    QuestionId = 1384,
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
                ans153.AnsDes = this.dayDopmTextbox.Value;
                ans153.AnserTypeId = 1;
                ans153.CreateDate = DateTime.Now;
                ans153.QuestionId = 1384;
                ans153.UserId = user.Id;
                ans153.AnsMonth = ansMonth; ans153.SRId = sR.Id;
            }

            //รูปหน้าตู้ ก่อน-หลัง
            var ans154 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1385).FirstOrDefault();
            if (ans154 == null)
            {
                string picfontFontback = Request.Form["picfontFontbackRadio"];
                Answer answer220 = new Answer()
                {
                    AnsDes = picfontFontback,
                    QuestionId = 1385,
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
                string picfontFontback = Request.Form["picfontFontbackRadio"];
                ans154.AnsDes = picfontFontback;
                ans154.AnserTypeId = 4;
                ans154.CreateDate = DateTime.Now;
                ans154.QuestionId = 1385;
                ans154.UserId = user.Id;
                ans154.AnsMonth = ansMonth; ans154.SRId = sR.Id;
            }


            // รูปภายในตู้ ก่อน-หลัง :
            var ans155 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1386).FirstOrDefault();
            if (ans155 == null)
            {
                string picInFontback = Request.Form["picInFontbackRadio"];
                Answer answer221 = new Answer()
                {
                    AnsDes = picInFontback,
                    QuestionId = 1386,
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
                string picInFontback = Request.Form["picInFontbackRadio"];
                ans155.AnsDes = picInFontback;
                ans155.AnserTypeId = 4;
                ans155.CreateDate = DateTime.Now;
                ans155.QuestionId = 1386;
                ans155.UserId = user.Id;
                ans155.AnsMonth = ansMonth; ans155.SRId = sR.Id;
            }


            // รูปขณะทำความสะอาดตู้ ก่อน-หลัง
            var ans156 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1387).FirstOrDefault();
            if (ans156 == null)
            {
                string cleanfontback = Request.Form["cleanfontbackRadio"];
                Answer answer222 = new Answer()
                {
                    AnsDes = cleanfontback,
                    QuestionId = 1387,
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
                string cleanfontback = Request.Form["cleanfontbackRadio"];
                ans156.AnsDes = cleanfontback;
                ans156.AnserTypeId = 4;
                ans156.CreateDate = DateTime.Now;
                ans156.QuestionId = 1387;
                ans156.UserId = user.Id;
                ans156.AnsMonth = ansMonth; ans156.SRId = sR.Id;
            }


            // รูปสถานะ Circuit Breaker (ON)
            var ans157 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1388).FirstOrDefault();
            if (ans157 == null)
            {
                string picstatusCircuit = Request.Form["picstatusCircuitRadio"];
                Answer answer223 = new Answer()
                {
                    AnsDes = picstatusCircuit,
                    QuestionId = 1388,
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
                string picstatusCircuit = Request.Form["picstatusCircuitRadio"];
                ans157.AnsDes = picstatusCircuit;
                ans157.AnserTypeId = 4;
                ans157.CreateDate = DateTime.Now;
                ans157.QuestionId = 1388;
                ans157.UserId = user.Id;
                ans157.AnsMonth = ansMonth; ans157.SRId = sR.Id;
            }

            // รรูปการจับยึด Bar Ground และการต่อ Ground
            var ans158 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1389).FirstOrDefault();
            if (ans158 == null)
            {
                string picBarground = Request.Form["picBargroundRadio"];
                Answer answer224 = new Answer()
                {
                    AnsDes = picBarground,
                    QuestionId = 1389,
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

                string picBarground = Request.Form["picBargroundRadio"];
                ans158.AnsDes = picBarground;
                ans158.AnserTypeId = 4;
                ans158.CreateDate = DateTime.Now;
                ans158.QuestionId = 1389;
                ans158.UserId = user.Id;
                ans158.AnsMonth = ansMonth; ans158.SRId = sR.Id;
            }

            // รูปการตรวจสอบสถานะไฟฟ้ารั่วลง Ground (Lamp Test)
            var ans159 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1390).FirstOrDefault();
            if (ans159 == null)
            {
                string picStatusGround = Request.Form["picStatusGroundRadio"];
                Answer answer225 = new Answer()
                {
                    AnsDes = picStatusGround,
                    QuestionId = 1390,
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
                string picStatusGround = Request.Form["picStatusGroundRadio"];
                ans159.AnsDes = picStatusGround;
                ans159.AnserTypeId = 4;
                ans159.CreateDate = DateTime.Now;
                ans159.QuestionId = 1390;
                ans159.UserId = user.Id;
                ans159.AnsMonth = ansMonth; ans159.SRId = sR.Id;
            }



            // รูป PEA Meter
            var ans160 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1391).FirstOrDefault();
            if (ans160 == null)
            {
                string picPEAMetertex = Request.Form["picPEAMeterRadio"];
                Answer answer226 = new Answer()
                {
                    AnsDes = picPEAMetertex,
                    QuestionId = 1391,
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
                string picPEAMetertex = Request.Form["picPEAMeterRadio"];
                ans160.AnsDes = picPEAMetertex;
                ans160.AnserTypeId = 4;
                ans160.CreateDate = DateTime.Now;
                ans160.QuestionId = 1391;
                ans160.UserId = user.Id;
                ans160.AnsMonth = ansMonth; ans160.SRId = sR.Id;
            }




            // รูปการวัดแรงดัน AC และกระแส AC
            var ans161 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1392).FirstOrDefault();
            if (ans161 == null)
            {
                string picAC = Request.Form["picACradio"];
                Answer answer227 = new Answer()
                {
                    AnsDes = picAC,
                    QuestionId = 1392,
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
                string picAC = Request.Form["picACradio"];
                ans161.AnsDes = picAC;
                ans161.AnserTypeId = 4;
                ans161.CreateDate = DateTime.Now;
                ans161.QuestionId = 1392;
                ans161.UserId = user.Id;
                ans161.AnsMonth = ansMonth; ans161.SRId = sR.Id;
            }



            // รูปแรงดัน DC และกระแส DC
            var ans162 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1393).FirstOrDefault();
            if (ans162 == null)
            {
                string picDC = Request.Form["picDCradio"];
                Answer answer228 = new Answer()
                {
                    AnsDes = picDC,
                    QuestionId = 1393,
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
                string picDC = Request.Form["picDCradio"];
                ans162.AnsDes = picDC;
                ans162.AnserTypeId = 4;
                ans162.CreateDate = DateTime.Now;
                ans162.QuestionId = 1393;
                ans162.UserId = user.Id;
                ans162.AnsMonth = ansMonth; ans162.SRId = sR.Id;
            }

            // รูปการวัดแรงดัน Battery รวม 
            var ans163 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1394).FirstOrDefault();
            if (ans163 == null)
            {
                string picBatteryAllRadiotex = Request.Form["picBatteryAllRadio"];
                Answer answer229 = new Answer()
                {
                    AnsDes = picBatteryAllRadiotex,
                    QuestionId = 1394,
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

                string picBatteryAllRadiotex = Request.Form["picBatteryAllRadio"];
                ans163.AnsDes = picBatteryAllRadiotex;
                ans163.AnserTypeId = 4;
                ans163.CreateDate = DateTime.Now;
                ans163.QuestionId = 1394;
                ans163.UserId = user.Id;
                ans163.AnsMonth = ansMonth; ans163.SRId = sR.Id;
            }


            //รูปการวัดแรงดัน Battery ก้อนที่ 1 และ Serial NO.
            var ans164 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1395).FirstOrDefault();
            if (ans164 == null)
            {
                string picBatteryRadio1tex = Request.Form["picBatteryRadio1"];
                Answer answer230 = new Answer()
                {
                    AnsDes = picBatteryRadio1tex,
                    QuestionId = 1395,
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
                string picBatteryRadio1tex = Request.Form["picBatteryRadio1"];
                ans164.AnsDes = picBatteryRadio1tex;
                ans164.AnserTypeId = 4;
                ans164.CreateDate = DateTime.Now;
                ans164.QuestionId = 1395;
                ans164.UserId = user.Id;
                ans164.AnsMonth = ansMonth; ans164.SRId = sR.Id;
            }


            // รูปการวัดแรงดัน Battery ก้อนที่ 2 และ Serial NO.
            var ans165 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1396).FirstOrDefault();
            if (ans165 == null)
            {
                string picBatteryRadio2tex = Request.Form["picBatteryRadio2"];
                Answer answer231 = new Answer()
                {
                    AnsDes = picBatteryRadio2tex,
                    QuestionId = 1396,
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
                string picBatteryRadio2tex = Request.Form["picBatteryRadio2"];
                ans165.AnsDes = picBatteryRadio2tex;
                ans165.AnserTypeId = 4;
                ans165.CreateDate = DateTime.Now;
                ans165.QuestionId = 1396;
                ans165.UserId = user.Id;
                ans165.AnsMonth = ansMonth; ans165.SRId = sR.Id;
            }


            // รูปการวัดแรงดัน Battery ก้อนที่ 3 และ Serial NO.
            var ans166 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1397).FirstOrDefault();
            if (ans166 == null)
            {
                string picBatteryRadio3tex = Request.Form["picBatteryRadio3"];
                Answer answer232 = new Answer()
                {
                    AnsDes = picBatteryRadio3tex,
                    QuestionId = 1397,
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

                string picBatteryRadio3tex = Request.Form["picBatteryRadio3"];
                ans166.AnsDes = picBatteryRadio3tex;
                ans166.AnserTypeId = 4;
                ans166.CreateDate = DateTime.Now;
                ans166.QuestionId = 1397;
                ans166.UserId = user.Id;
                ans166.AnsMonth = ansMonth; ans166.SRId = sR.Id;
            }

            // รูปการวัดแรงดัน Battery ก้อนที่ 4 และ Serial NO.
            var ans167 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1398).FirstOrDefault();
            if (ans167 == null)
            {
                string picBatteryRadio4tex = Request.Form["picBatteryRadio4"];
                Answer answer233 = new Answer()
                {
                    AnsDes = picBatteryRadio4tex,
                    QuestionId = 1398,
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
                string picBatteryRadio4tex = Request.Form["picBatteryRadio4"];
                ans167.AnsDes = picBatteryRadio4tex;
                ans167.AnserTypeId = 4;
                ans167.CreateDate = DateTime.Now;
                ans167.QuestionId = 1398;
                ans167.UserId = user.Id;
                ans167.AnsMonth = ansMonth; ans167.SRId = sR.Id;
            }

            // รูปการ Test Door Alarm 
            var ans168 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1399).FirstOrDefault();
            if (ans168 == null)
            {
                string picTestDoorRadiotex = Request.Form["picTestDoorRadio"];
                Answer answer234 = new Answer()
                {
                    AnsDes = picTestDoorRadiotex,
                    QuestionId = 1399,
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
                string picTestDoorRadiotex = Request.Form["picTestDoorRadio"];
                ans168.AnsDes = picTestDoorRadiotex;
                ans168.AnserTypeId = 4;
                ans168.CreateDate = DateTime.Now;
                ans168.QuestionId = 1399;
                ans168.UserId = user.Id;
                ans168.AnsMonth = ansMonth; ans168.SRId = sR.Id;
            }


            // รูปการ Test Rectifier 1 Comm. Fail  Alarm
            var ans169 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1400).FirstOrDefault();
            if (ans169 == null)
            {
                string picTestRetifier1tex = Request.Form["picTestRetifier1"];
                Answer answer235 = new Answer()
                {
                    AnsDes = picTestRetifier1tex,
                    QuestionId = 1400,
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
                string picTestRetifier1tex = Request.Form["picTestRetifier1"];
                ans169.AnsDes = picTestRetifier1tex;
                ans169.AnserTypeId = 4;
                ans169.CreateDate = DateTime.Now;
                ans169.QuestionId = 1400;
                ans169.UserId = user.Id;
                ans169.AnsMonth = ansMonth; ans169.SRId = sR.Id;
            }


            // รูปการ Test Rectifier 2 Comm. Fail  Alarm
            var ans170 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1401).FirstOrDefault();
            if (ans170 == null)
            {
                string picTestRetifier2tex = Request.Form["picTestRetifier2"];
                Answer answer236 = new Answer()
                {
                    AnsDes = picTestRetifier2tex,
                    QuestionId = 1401,
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
                string picTestRetifier2tex = Request.Form["picTestRetifier2"];
                ans170.AnsDes = picTestRetifier2tex;
                ans170.AnserTypeId = 4;
                ans170.CreateDate = DateTime.Now;
                ans170.QuestionId = 1401;
                ans170.UserId = user.Id;
                ans170.AnsMonth = ansMonth; ans170.SRId = sR.Id;
            }

            // รูป Rectifier Module และ Serial NO.
            var ans171 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1402).FirstOrDefault();
            if (ans171 == null)
            {
                string picRetifierModuletex = Request.Form["picRetifierModule"];
                Answer answer237 = new Answer()
                {
                    AnsDes = picRetifierModuletex,
                    QuestionId = 1402,
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
                string picRetifierModuletex = Request.Form["picRetifierModule"];
                ans171.AnsDes = picRetifierModuletex;
                ans171.AnserTypeId = 4;
                ans171.CreateDate = DateTime.Now;
                ans171.QuestionId = 1402;
                ans171.UserId = user.Id;
                ans171.AnsMonth = ansMonth; ans171.SRId = sR.Id;
            }


            // รูป Cable Inlet ด้านในและด้านนอก
            var ans172 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1403).FirstOrDefault();
            if (ans172 == null)
            {
                string picCableinlettex = Request.Form["picCableinlet"];
                Answer answer238 = new Answer()
                {
                    AnsDes = picCableinlettex,
                    QuestionId = 1403,
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
                string picCableinlettex = Request.Form["picCableinlet"];
                ans172.AnsDes = picCableinlettex;
                ans172.AnserTypeId = 4;
                ans172.CreateDate = DateTime.Now;
                ans172.QuestionId = 1403;
                ans172.UserId = user.Id;
                ans172.AnsMonth = ansMonth; ans172.SRId = sR.Id;
            }



            // รูป ODF โดยรวม 
            var ans173 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1404).FirstOrDefault();
            if (ans173 == null)
            {
                string picODFAlltex = Request.Form["picODFAll"];
                Answer answer239 = new Answer()
                {
                    AnsDes = picODFAlltex,
                    QuestionId = 1404,
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

                string picODFAlltex = Request.Form["picODFAll"];
                ans173.AnsDes = picODFAlltex;
                ans173.AnserTypeId = 4;
                ans173.CreateDate = DateTime.Now;
                ans173.QuestionId = 1404;
                ans173.UserId = user.Id;
                ans173.AnsMonth = ansMonth; ans173.SRId = sR.Id;

            }


            // รูปอุปกรณ์ OLT โดยรวม
            var ans174 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1405).FirstOrDefault();
            if (ans174 == null)
            {
                string picOLTAlltex = Request.Form["picOLTAll"];
                Answer answer240 = new Answer()
                {
                    AnsDes = picOLTAlltex,
                    QuestionId = 1405,
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
                string picOLTAlltex = Request.Form["picOLTAll"];
                ans174.AnsDes = picOLTAlltex;
                ans174.AnserTypeId = 4;
                ans174.CreateDate = DateTime.Now;
                ans174.QuestionId = 1405;
                ans174.UserId = user.Id;
                ans174.AnsMonth = ansMonth; ans174.SRId = sR.Id;
            }


            // รูป Indoor AP ทั้ง 2 จุด พร้อม Serial NO. และ MAC:
            var ans175 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1406).FirstOrDefault();
            if (ans175 == null)
            {
                string picConRetifiertex = Request.Form["picConRetifier"];
                Answer answer241 = new Answer()
                {
                    AnsDes = picConRetifiertex,
                    QuestionId = 1406,
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
                string picConRetifiertex = Request.Form["picConRetifier"];
                ans175.AnsDes = picConRetifiertex;
                ans175.AnserTypeId = 4;
                ans175.CreateDate = DateTime.Now;
                ans175.QuestionId = 1406;
                ans175.UserId = user.Id;
                ans175.AnsMonth = ansMonth; ans175.SRId = sR.Id;
            }

            //ans176
            //1.รูป PICTURE CHECKLIST :

            var ans9989 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 6 && x.SRId == sR.Id && x.QuestionId == 1407).FirstOrDefault();
            //ใส่รูป Logo 
            if (ans9989 == null)
            {
                if (this.pictureChecklistImages.HasFile)
                {
                    string extension = this.pictureChecklistImages.PostedFile.FileName.Split('.')[1];
                    string newFileName = "images/pictureChecklist_BB1_" + DateTime.Now.ToString("yyyyMMddHHmmss") + "." + extension;
                    this.pictureChecklistImages.PostedFile.SaveAs(Server.MapPath(newFileName));

                    Answer answer275 = new Answer()
                    {
                        AnsDes = newFileName,
                        QuestionId = 1407,
                        AnserTypeId = 3,
                        CreateDate = DateTime.Now,
                        SRId = sR.Id,
                        UserId = user.Id,
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
                    string newFileName = "images/pictureChecklist_BB1_" + DateTime.Now.ToString("yyyyMMddHHmmss") + "." + extension;
                    this.pictureChecklistImages.PostedFile.SaveAs(Server.MapPath(newFileName));


                    ans9989.AnsDes = newFileName;
                    ans9989.QuestionId = 1407;
                    ans9989.AnserTypeId = 3;
                    ans9989.CreateDate = DateTime.Now;
                    ans9989.UserId = user.Id;
                    ans9989.AnsMonth = ansMonth;
                    ans9989.SRId = sR.Id;

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