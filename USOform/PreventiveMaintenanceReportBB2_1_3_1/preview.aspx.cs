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

namespace USOform.PreventiveMaintenanceReportBB2_1_3_1
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
            //this.GetData();
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
        void SetForm()
        {
            this.GroupNameLabel.Text = answers.Where(x => x.QuestionId == 1014).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1014).FirstOrDefault().AnsDes : "";
            this.AreaTextbox.Value = answers.Where(x => x.QuestionId == 1015).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1015).FirstOrDefault().AnsDes : "";
            this.CompanyLabel.Text = answers.Where(x => x.QuestionId == 1016).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1016).FirstOrDefault().AnsDes : "";
            this.maintenanceCountTextbox.Value = answers.Where(x => x.QuestionId == 1018).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1018).FirstOrDefault().AnsDes : "";
            this.yearTextbox.Value = answers.Where(x => x.QuestionId == 1019).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1019).FirstOrDefault().AnsDes : "";
            this.startDatepicker.Value = answers.Where(x => x.QuestionId == 1020).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1020).FirstOrDefault().AnsDes : "";
            this.endDatepicker.Value = answers.Where(x => x.QuestionId == 1021).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1021).FirstOrDefault().AnsDes : "";
            this.siteCodeTextbox.Value = answers.Where(x => x.QuestionId == 1022).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1022).FirstOrDefault().AnsDes : "";
            this.cabinetIdTextbox.Value = answers.Where(x => x.QuestionId == 1024).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1024).FirstOrDefault().AnsDes : "";
            this.sitecodeTextboxSection2.Value = answers.Where(x => x.QuestionId == 1025).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1025).FirstOrDefault().AnsDes : "";
            this.VillageIdTextbox.Value = answers.Where(x => x.QuestionId == 1026).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1026).FirstOrDefault().AnsDes : "";
            this.villageTextbox.Value = answers.Where(x => x.QuestionId == 1027).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1027).FirstOrDefault().AnsDes : "";
            this.subdistrictTextbox.Value = answers.Where(x => x.QuestionId == 1028).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1028).FirstOrDefault().AnsDes : "";
            this.districtTextbox.Value = answers.Where(x => x.QuestionId == 1029).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1029).FirstOrDefault().AnsDes : "";
            this.provinceTextbox.Value = answers.Where(x => x.QuestionId == 1030).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1030).FirstOrDefault().AnsDes : "";
            this.typeTextbox.Value = answers.Where(x => x.QuestionId == 1031).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1031).FirstOrDefault().AnsDes : "";
            this.pmdateTextbox.Value = answers.Where(x => x.QuestionId == 1032).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1032).FirstOrDefault().AnsDes : "";
            //this.signatureExecutorTextbox.Value = answers.Where(x => x.QuestionId == 1034).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1034).FirstOrDefault().AnsDes : "";
            //this.signatureSupervisorTextbox.Value = answers.Where(x => x.QuestionId == 1035).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1035).FirstOrDefault().AnsDes : "";
            this.nameExecutorTextbox.Value = answers.Where(x => x.QuestionId == 1036).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1036).FirstOrDefault().AnsDes : "";
            this.nameSupervisorTextbox.Value = answers.Where(x => x.QuestionId == 1037).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1037).FirstOrDefault().AnsDes : "";
            this.DateExecutorTextbox.Value = answers.Where(x => x.QuestionId == 1038).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1038).FirstOrDefault().AnsDes : "";
            this.DateSupervisorTextbox.Value = answers.Where(x => x.QuestionId == 1039).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1039).FirstOrDefault().AnsDes : "";
            this.cabinetIDTextboxSection4.Value = answers.Where(x => x.QuestionId == 1040).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1040).FirstOrDefault().AnsDes : "";
            this.sitecodeTextboxSection4.Value = answers.Where(x => x.QuestionId == 1041).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1041).FirstOrDefault().AnsDes : "";
            this.villageIDTextboxSection4.Value = answers.Where(x => x.QuestionId == 1042).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1042).FirstOrDefault().AnsDes : "";
            this.latandlongTextbox.Value = answers.Where(x => x.QuestionId == 1043).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1043).FirstOrDefault().AnsDes : "";
            this.oltidTextbox.Value = answers.Where(x => x.QuestionId == 1045).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1045).FirstOrDefault().AnsDes : "";
            this.numberuserTextbox.Value = answers.Where(x => x.QuestionId == 1047).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1047).FirstOrDefault().AnsDes : "";
            this.kwhMeterTextbox.Value = answers.Where(x => x.QuestionId == 1048).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1048).FirstOrDefault().AnsDes : "";
            this.acTextbox.Value = answers.Where(x => x.QuestionId == 1049).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1049).FirstOrDefault().AnsDes : "";
            this.lineAcTextbox.Value = answers.Where(x => x.QuestionId == 1050).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1050).FirstOrDefault().AnsDes : "";
            this.neutronacTextbox.Value = answers.Where(x => x.QuestionId == 1051).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1051).FirstOrDefault().AnsDes : "";
            this.acfromupsTextbox.Value = answers.Where(x => x.QuestionId == 1055).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1055).FirstOrDefault().AnsDes : "";
            this.voltageInverterTextbox.Value = answers.Where(x => x.QuestionId == 1091).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1091).FirstOrDefault().AnsDes : "";
            this.voltageLoadTextbox.Value = answers.Where(x => x.QuestionId == 1092).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1092).FirstOrDefault().AnsDes : "";
            this.powerBatterytext1.Value = answers.Where(x => x.QuestionId == 1093).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1093).FirstOrDefault().AnsDes : "";
            this.powerBatterytext2.Value = answers.Where(x => x.QuestionId == 1094).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1094).FirstOrDefault().AnsDes : "";
            this.powerBatterytext3.Value = answers.Where(x => x.QuestionId == 1095).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1095).FirstOrDefault().AnsDes : "";
            this.powerBatterytext4.Value = answers.Where(x => x.QuestionId == 1096).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1096).FirstOrDefault().AnsDes : "";
            this.dowloadforOnuTextbox.Value = answers.Where(x => x.QuestionId == 1097).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1097).FirstOrDefault().AnsDes : "";
            this.uploadforOnuTextbox.Value = answers.Where(x => x.QuestionId == 1098).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1098).FirstOrDefault().AnsDes : "";
            this.pingTestTextbox.Value = answers.Where(x => x.QuestionId == 1099).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1099).FirstOrDefault().AnsDes : "";
            this.dowloadForwifiTextbox.Value = answers.Where(x => x.QuestionId == 1100).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1100).FirstOrDefault().AnsDes : "";
            this.uploadForwifiTextbox.Value = answers.Where(x => x.QuestionId == 1101).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1101).FirstOrDefault().AnsDes : "";
            this.pingtestForwifiTextbox.Value = answers.Where(x => x.QuestionId == 1102).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1102).FirstOrDefault().AnsDes : "";

            this.problemTextbox1.Value = answers.Where(x => x.QuestionId == 1103).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1103).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox1.Value = answers.Where(x => x.QuestionId == 1104).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1104).FirstOrDefault().AnsDes : "";
            this.problemTextbox2.Value = answers.Where(x => x.QuestionId == 1105).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1105).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox2.Value = answers.Where(x => x.QuestionId == 1106).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1106).FirstOrDefault().AnsDes : "";
            this.problemTextbox3.Value = answers.Where(x => x.QuestionId == 1107).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1107).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox3.Value = answers.Where(x => x.QuestionId == 1108).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1108).FirstOrDefault().AnsDes : "";
            this.problemTextbox4.Value = answers.Where(x => x.QuestionId == 1109).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1109).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox4.Value = answers.Where(x => x.QuestionId == 1110).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1110).FirstOrDefault().AnsDes : "";
            this.problemTextbox5.Value = answers.Where(x => x.QuestionId == 1111).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1111).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox5.Value = answers.Where(x => x.QuestionId == 1112).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1112).FirstOrDefault().AnsDes : "";
            this.problemTextbox6.Value = answers.Where(x => x.QuestionId == 1113).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1113).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox6.Value = answers.Where(x => x.QuestionId == 1114).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1114).FirstOrDefault().AnsDes : "";
            this.problemTextbox7.Value = answers.Where(x => x.QuestionId == 1115).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1115).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox7.Value = answers.Where(x => x.QuestionId == 1116).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1116).FirstOrDefault().AnsDes : "";
            this.problemTextbox8.Value = answers.Where(x => x.QuestionId == 1117).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1117).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox8.Value = answers.Where(x => x.QuestionId == 1118).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1118).FirstOrDefault().AnsDes : "";
            this.problemTextbox9.Value = answers.Where(x => x.QuestionId == 1119).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1119).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox9.Value = answers.Where(x => x.QuestionId == 1120).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1120).FirstOrDefault().AnsDes : "";
            this.problemTextbox10.Value = answers.Where(x => x.QuestionId == 1121).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1121).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox10.Value = answers.Where(x => x.QuestionId == 1122).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1122).FirstOrDefault().AnsDes : "";
            this.problemTextbox11.Value = answers.Where(x => x.QuestionId == 1123).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1123).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox11.Value = answers.Where(x => x.QuestionId == 1124).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1124).FirstOrDefault().AnsDes : "";
            this.problemTextbox12.Value = answers.Where(x => x.QuestionId == 1125).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1125).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox12.Value = answers.Where(x => x.QuestionId == 1126).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1126).FirstOrDefault().AnsDes : "";
            this.problemTextbox13.Value = answers.Where(x => x.QuestionId == 1127).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1127).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox13.Value = answers.Where(x => x.QuestionId == 1128).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1128).FirstOrDefault().AnsDes : "";
            this.problemTextbox14.Value = answers.Where(x => x.QuestionId == 1129).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1129).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox14.Value = answers.Where(x => x.QuestionId == 1130).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1130).FirstOrDefault().AnsDes : "";
            this.problemTextbox15.Value = answers.Where(x => x.QuestionId == 1131).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1131).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox15.Value = answers.Where(x => x.QuestionId == 1132).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1132).FirstOrDefault().AnsDes : "";

            this.toolsListTextbox1.Value = answers.Where(x => x.QuestionId == 1133).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1133).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox1.Value = answers.Where(x => x.QuestionId == 1134).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1134).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox1.Value = answers.Where(x => x.QuestionId == 1135).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1135).FirstOrDefault().AnsDes : "";
            this.noteTextbox1.Value = answers.Where(x => x.QuestionId == 1136).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1136).FirstOrDefault().AnsDes : "";
            this.toolsListTextbox2.Value = answers.Where(x => x.QuestionId == 1137).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1137).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox2.Value = answers.Where(x => x.QuestionId == 1138).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1138).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox2.Value = answers.Where(x => x.QuestionId == 1139).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1139).FirstOrDefault().AnsDes : "";
            this.noteTextbox2.Value = answers.Where(x => x.QuestionId == 1140).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1140).FirstOrDefault().AnsDes : "";
            this.toolsListTextbox3.Value = answers.Where(x => x.QuestionId == 1141).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1141).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox3.Value = answers.Where(x => x.QuestionId == 1142).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1142).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox3.Value = answers.Where(x => x.QuestionId == 1143).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1143).FirstOrDefault().AnsDes : "";
            this.noteTextbox3.Value = answers.Where(x => x.QuestionId == 1144).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1144).FirstOrDefault().AnsDes : "";
            this.toolsListTextbox4.Value = answers.Where(x => x.QuestionId == 1145).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1145).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox4.Value = answers.Where(x => x.QuestionId == 1146).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1146).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox4.Value = answers.Where(x => x.QuestionId == 1147).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1147).FirstOrDefault().AnsDes : "";
            this.noteTextbox4.Value = answers.Where(x => x.QuestionId == 1148).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1148).FirstOrDefault().AnsDes : "";
            this.toolsListTextbox5.Value = answers.Where(x => x.QuestionId == 1149).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1149).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox5.Value = answers.Where(x => x.QuestionId == 1150).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1150).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox5.Value = answers.Where(x => x.QuestionId == 1151).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1151).FirstOrDefault().AnsDes : "";
            this.noteTextbox5.Value = answers.Where(x => x.QuestionId == 1152).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1152).FirstOrDefault().AnsDes : "";
            this.toolsListTextbox6.Value = answers.Where(x => x.QuestionId == 1153).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1153).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox6.Value = answers.Where(x => x.QuestionId == 1154).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1154).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox6.Value = answers.Where(x => x.QuestionId == 1155).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1155).FirstOrDefault().AnsDes : "";
            this.noteTextbox6.Value = answers.Where(x => x.QuestionId == 1156).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1156).FirstOrDefault().AnsDes : "";
            this.toolsListTextbox7.Value = answers.Where(x => x.QuestionId == 1157).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1157).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox7.Value = answers.Where(x => x.QuestionId == 1158).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1158).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox7.Value = answers.Where(x => x.QuestionId == 1159).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1159).FirstOrDefault().AnsDes : "";
            this.noteTextbox7.Value = answers.Where(x => x.QuestionId == 1160).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1160).FirstOrDefault().AnsDes : "";
            this.toolsListTextbox8.Value = answers.Where(x => x.QuestionId == 1161).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1161).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox8.Value = answers.Where(x => x.QuestionId == 1162).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1162).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox8.Value = answers.Where(x => x.QuestionId == 1163).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1163).FirstOrDefault().AnsDes : "";
            this.noteTextbox8.Value = answers.Where(x => x.QuestionId == 1164).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1164).FirstOrDefault().AnsDes : "";
            this.toolsListTextbox9.Value = answers.Where(x => x.QuestionId == 1165).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1165).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox9.Value = answers.Where(x => x.QuestionId == 1166).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1166).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox9.Value = answers.Where(x => x.QuestionId == 1167).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1167).FirstOrDefault().AnsDes : "";
            this.noteTextbox9.Value = answers.Where(x => x.QuestionId == 1168).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1168).FirstOrDefault().AnsDes : "";
            this.toolsListTextbox10.Value = answers.Where(x => x.QuestionId == 1169).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1169).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox10.Value = answers.Where(x => x.QuestionId == 1170).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1170).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox10.Value = answers.Where(x => x.QuestionId == 1171).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1171).FirstOrDefault().AnsDes : "";
            this.noteTextbox10.Value = answers.Where(x => x.QuestionId == 1172).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1172).FirstOrDefault().AnsDes : "";
            this.toolsListTextbox11.Value = answers.Where(x => x.QuestionId == 1173).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1173).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox11.Value = answers.Where(x => x.QuestionId == 1174).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1174).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox11.Value = answers.Where(x => x.QuestionId == 1175).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1175).FirstOrDefault().AnsDes : "";
            this.noteTextbox11.Value = answers.Where(x => x.QuestionId == 1176).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1176).FirstOrDefault().AnsDes : "";
            this.toolsListTextbox12.Value = answers.Where(x => x.QuestionId == 1177).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1177).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox12.Value = answers.Where(x => x.QuestionId == 1178).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1178).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox12.Value = answers.Where(x => x.QuestionId == 1179).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1179).FirstOrDefault().AnsDes : "";
            this.noteTextbox12.Value = answers.Where(x => x.QuestionId == 1180).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1180).FirstOrDefault().AnsDes : "";
            this.toolsListTextbox13.Value = answers.Where(x => x.QuestionId == 1181).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1181).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox13.Value = answers.Where(x => x.QuestionId == 1182).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1182).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox13.Value = answers.Where(x => x.QuestionId == 1183).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1183).FirstOrDefault().AnsDes : "";
            this.noteTextbox13.Value = answers.Where(x => x.QuestionId == 1184).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1184).FirstOrDefault().AnsDes : "";
            this.toolsListTextbox14.Value = answers.Where(x => x.QuestionId == 1185).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1185).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox14.Value = answers.Where(x => x.QuestionId == 1186).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1186).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox14.Value = answers.Where(x => x.QuestionId == 1187).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1187).FirstOrDefault().AnsDes : "";
            this.noteTextbox14.Value = answers.Where(x => x.QuestionId == 1188).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1188).FirstOrDefault().AnsDes : "";
            this.toolsListTextbox15.Value = answers.Where(x => x.QuestionId == 1189).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1189).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox15.Value = answers.Where(x => x.QuestionId == 1190).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1190).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox15.Value = answers.Where(x => x.QuestionId == 1191).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1191).FirstOrDefault().AnsDes : "";
            this.noteTextbox15.Value = answers.Where(x => x.QuestionId == 1192).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1192).FirstOrDefault().AnsDes : "";

            this.namepmTextbox.Value = answers.Where(x => x.QuestionId == 1193).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1193).FirstOrDefault().AnsDes : "";
            this.dayDopmTextbox.Value = answers.Where(x => x.QuestionId == 1194).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1194).FirstOrDefault().AnsDes : "";
            /////-----Red Only-----///
            //  //this.GroupNameTextBox.Visible=false;
            //this.AreaTextbox.Visible = true;
            //this.CompanyTextbox.Value = answers.Where(x => x.QuestionId == 1016).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1016).FirstOrDefault().AnsDes : "";
            //this.maintenanceCountTextbox.Value = answers.Where(x => x.QuestionId == 1018).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1018).FirstOrDefault().AnsDes : "";
            //this.yearTextbox.Value = answers.Where(x => x.QuestionId == 1019).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1019).FirstOrDefault().AnsDes : "";
            //this.startDatepicker.Value = answers.Where(x => x.QuestionId == 1020).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1020).FirstOrDefault().AnsDes : "";
            //this.endDatepicker.Value = answers.Where(x => x.QuestionId == 1021).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1021).FirstOrDefault().AnsDes : "";
            //this.siteCodeTextbox.Value = answers.Where(x => x.QuestionId == 1022).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1022).FirstOrDefault().AnsDes : "";
            //this.cabinetIdTextbox.Value = answers.Where(x => x.QuestionId == 1024).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1024).FirstOrDefault().AnsDes : "";
            //this.sitecodeTextboxSection2.Value = answers.Where(x => x.QuestionId == 1025).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1025).FirstOrDefault().AnsDes : "";
            //this.VillageIdTextbox.Value = answers.Where(x => x.QuestionId == 1026).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1026).FirstOrDefault().AnsDes : "";
            //this.villageTextbox.Value = answers.Where(x => x.QuestionId == 1027).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1027).FirstOrDefault().AnsDes : "";
            //this.subdistrictTextbox.Value = answers.Where(x => x.QuestionId == 1028).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1028).FirstOrDefault().AnsDes : "";
            //this.districtTextbox.Value = answers.Where(x => x.QuestionId == 1029).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1029).FirstOrDefault().AnsDes : "";
            //this.provinceTextbox.Value = answers.Where(x => x.QuestionId == 1030).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1030).FirstOrDefault().AnsDes : "";
            //this.typeTextbox.Value = answers.Where(x => x.QuestionId == 1031).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1031).FirstOrDefault().AnsDes : "";
            //this.pmdateTextbox.Value = answers.Where(x => x.QuestionId == 1032).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1032).FirstOrDefault().AnsDes : "";
            ////this.signatureExecutorTextbox.Value = answers.Where(x => x.QuestionId == 1034).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1034).FirstOrDefault().AnsDes : "";
            ////this.signatureSupervisorTextbox.Value = answers.Where(x => x.QuestionId == 1035).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1035).FirstOrDefault().AnsDes : "";
            //this.nameExecutorTextbox.Value = answers.Where(x => x.QuestionId == 1036).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1036).FirstOrDefault().AnsDes : "";
            //this.nameSupervisorTextbox.Value = answers.Where(x => x.QuestionId == 1037).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1037).FirstOrDefault().AnsDes : "";
            //this.DateExecutorTextbox.Value = answers.Where(x => x.QuestionId == 1038).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1038).FirstOrDefault().AnsDes : "";
            //this.DateSupervisorTextbox.Value = answers.Where(x => x.QuestionId == 1039).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1039).FirstOrDefault().AnsDes : "";
            //this.cabinetIDTextboxSection4.Value = answers.Where(x => x.QuestionId == 1040).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1040).FirstOrDefault().AnsDes : "";
            //this.sitecodeTextboxSection4.Value = answers.Where(x => x.QuestionId == 1041).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1041).FirstOrDefault().AnsDes : "";
            //this.villageIDTextboxSection4.Value = answers.Where(x => x.QuestionId == 1042).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1042).FirstOrDefault().AnsDes : "";
            //this.latandlongTextbox.Value = answers.Where(x => x.QuestionId == 1043).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1043).FirstOrDefault().AnsDes : "";
            //this.oltidTextbox.Value = answers.Where(x => x.QuestionId == 1045).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1045).FirstOrDefault().AnsDes : "";
            //this.numberuserTextbox.Value = answers.Where(x => x.QuestionId == 1047).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1047).FirstOrDefault().AnsDes : "";
            //this.kwhMeterTextbox.Value = answers.Where(x => x.QuestionId == 1048).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1048).FirstOrDefault().AnsDes : "";
            //this.acTextbox.Value = answers.Where(x => x.QuestionId == 1049).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1049).FirstOrDefault().AnsDes : "";
            //this.lineAcTextbox.Value = answers.Where(x => x.QuestionId == 1050).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1050).FirstOrDefault().AnsDes : "";
            //this.neutronacTextbox.Value = answers.Where(x => x.QuestionId == 1051).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1051).FirstOrDefault().AnsDes : "";
            //this.acfromupsTextbox.Value = answers.Where(x => x.QuestionId == 1055).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1055).FirstOrDefault().AnsDes : "";
            //this.voltageInverterTextbox.Value = answers.Where(x => x.QuestionId == 1091).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1091).FirstOrDefault().AnsDes : "";
            //this.voltageLoadTextbox.Value = answers.Where(x => x.QuestionId == 1092).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1092).FirstOrDefault().AnsDes : "";
            //this.powerBatterytext1.Value = answers.Where(x => x.QuestionId == 1093).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1093).FirstOrDefault().AnsDes : "";
            //this.powerBatterytext2.Value = answers.Where(x => x.QuestionId == 1094).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1094).FirstOrDefault().AnsDes : "";
            //this.powerBatterytext3.Value = answers.Where(x => x.QuestionId == 1095).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1095).FirstOrDefault().AnsDes : "";
            //this.powerBatterytext4.Value = answers.Where(x => x.QuestionId == 1096).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1096).FirstOrDefault().AnsDes : "";
            //this.dowloadforOnuTextbox.Value = answers.Where(x => x.QuestionId == 1097).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1097).FirstOrDefault().AnsDes : "";
            //this.uploadforOnuTextbox.Value = answers.Where(x => x.QuestionId == 1098).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1098).FirstOrDefault().AnsDes : "";
            //this.pingTestTextbox.Value = answers.Where(x => x.QuestionId == 1099).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1099).FirstOrDefault().AnsDes : "";
            //this.dowloadForwifiTextbox.Value = answers.Where(x => x.QuestionId == 1100).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1100).FirstOrDefault().AnsDes : "";
            //this.uploadForwifiTextbox.Value = answers.Where(x => x.QuestionId == 1101).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1101).FirstOrDefault().AnsDes : "";
            //this.pingtestForwifiTextbox.Value = answers.Where(x => x.QuestionId == 1102).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1102).FirstOrDefault().AnsDes : "";

            //this.problemTextbox1.Value = answers.Where(x => x.QuestionId == 1103).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1103).FirstOrDefault().AnsDes : "";
            //this.howtoSolveTextbox1.Value = answers.Where(x => x.QuestionId == 1104).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1104).FirstOrDefault().AnsDes : "";
            //this.problemTextbox2.Value = answers.Where(x => x.QuestionId == 1105).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1105).FirstOrDefault().AnsDes : "";
            //this.howtoSolveTextbox2.Value = answers.Where(x => x.QuestionId == 1106).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1106).FirstOrDefault().AnsDes : "";
            //this.problemTextbox3.Value = answers.Where(x => x.QuestionId == 1107).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1107).FirstOrDefault().AnsDes : "";
            //this.howtoSolveTextbox3.Value = answers.Where(x => x.QuestionId == 1108).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1108).FirstOrDefault().AnsDes : "";
            //this.problemTextbox4.Value = answers.Where(x => x.QuestionId == 1109).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1109).FirstOrDefault().AnsDes : "";
            //this.howtoSolveTextbox4.Value = answers.Where(x => x.QuestionId == 1110).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1110).FirstOrDefault().AnsDes : "";
            //this.problemTextbox5.Value = answers.Where(x => x.QuestionId == 1111).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1111).FirstOrDefault().AnsDes : "";
            //this.howtoSolveTextbox5.Value = answers.Where(x => x.QuestionId == 1112).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1112).FirstOrDefault().AnsDes : "";
            //this.problemTextbox6.Value = answers.Where(x => x.QuestionId == 1113).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1113).FirstOrDefault().AnsDes : "";
            //this.howtoSolveTextbox6.Value = answers.Where(x => x.QuestionId == 1114).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1114).FirstOrDefault().AnsDes : "";
            //this.problemTextbox7.Value = answers.Where(x => x.QuestionId == 1115).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1115).FirstOrDefault().AnsDes : "";
            //this.howtoSolveTextbox7.Value = answers.Where(x => x.QuestionId == 1116).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1116).FirstOrDefault().AnsDes : "";
            //this.problemTextbox8.Value = answers.Where(x => x.QuestionId == 1117).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1117).FirstOrDefault().AnsDes : "";
            //this.howtoSolveTextbox8.Value = answers.Where(x => x.QuestionId == 1118).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1118).FirstOrDefault().AnsDes : "";
            //this.problemTextbox9.Value = answers.Where(x => x.QuestionId == 1119).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1119).FirstOrDefault().AnsDes : "";
            //this.howtoSolveTextbox9.Value = answers.Where(x => x.QuestionId == 1120).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1120).FirstOrDefault().AnsDes : "";
            //this.problemTextbox10.Value = answers.Where(x => x.QuestionId == 1121).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1121).FirstOrDefault().AnsDes : "";
            //this.howtoSolveTextbox10.Value = answers.Where(x => x.QuestionId == 1122).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1122).FirstOrDefault().AnsDes : "";
            //this.problemTextbox11.Value = answers.Where(x => x.QuestionId == 1123).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1123).FirstOrDefault().AnsDes : "";
            //this.howtoSolveTextbox11.Value = answers.Where(x => x.QuestionId == 1124).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1124).FirstOrDefault().AnsDes : "";
            //this.problemTextbox12.Value = answers.Where(x => x.QuestionId == 1125).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1125).FirstOrDefault().AnsDes : "";
            //this.howtoSolveTextbox12.Value = answers.Where(x => x.QuestionId == 1126).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1126).FirstOrDefault().AnsDes : "";
            //this.problemTextbox13.Value = answers.Where(x => x.QuestionId == 1127).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1127).FirstOrDefault().AnsDes : "";
            //this.howtoSolveTextbox13.Value = answers.Where(x => x.QuestionId == 1128).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1128).FirstOrDefault().AnsDes : "";
            //this.problemTextbox14.Value = answers.Where(x => x.QuestionId == 1129).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1129).FirstOrDefault().AnsDes : "";
            //this.howtoSolveTextbox14.Value = answers.Where(x => x.QuestionId == 1130).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1130).FirstOrDefault().AnsDes : "";
            //this.problemTextbox15.Value = answers.Where(x => x.QuestionId == 1131).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1131).FirstOrDefault().AnsDes : "";
            //this.howtoSolveTextbox15.Value = answers.Where(x => x.QuestionId == 1132).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1132).FirstOrDefault().AnsDes : "";

            //this.toolsListTextbox1.Value = answers.Where(x => x.QuestionId == 1133).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1133).FirstOrDefault().AnsDes : "";
            //this.serialNumberTextbox1.Value = answers.Where(x => x.QuestionId == 1134).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1134).FirstOrDefault().AnsDes : "";
            //this.newSerialNumberTextbox1.Value = answers.Where(x => x.QuestionId == 1135).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1135).FirstOrDefault().AnsDes : "";
            //this.noteTextbox1.Value = answers.Where(x => x.QuestionId == 1136).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1136).FirstOrDefault().AnsDes : "";
            //this.toolsListTextbox2.Value = answers.Where(x => x.QuestionId == 1137).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1137).FirstOrDefault().AnsDes : "";
            //this.serialNumberTextbox2.Value = answers.Where(x => x.QuestionId == 1138).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1138).FirstOrDefault().AnsDes : "";
            //this.newSerialNumberTextbox2.Value = answers.Where(x => x.QuestionId == 1139).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1139).FirstOrDefault().AnsDes : "";
            //this.noteTextbox2.Value = answers.Where(x => x.QuestionId == 1140).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1140).FirstOrDefault().AnsDes : "";
            //this.toolsListTextbox3.Value = answers.Where(x => x.QuestionId == 1141).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1141).FirstOrDefault().AnsDes : "";
            //this.serialNumberTextbox3.Value = answers.Where(x => x.QuestionId == 1142).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1142).FirstOrDefault().AnsDes : "";
            //this.newSerialNumberTextbox3.Value = answers.Where(x => x.QuestionId == 1143).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1143).FirstOrDefault().AnsDes : "";
            //this.noteTextbox3.Value = answers.Where(x => x.QuestionId == 1144).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1144).FirstOrDefault().AnsDes : "";
            //this.toolsListTextbox4.Value = answers.Where(x => x.QuestionId == 1145).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1145).FirstOrDefault().AnsDes : "";
            //this.serialNumberTextbox4.Value = answers.Where(x => x.QuestionId == 1146).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1146).FirstOrDefault().AnsDes : "";
            //this.newSerialNumberTextbox4.Value = answers.Where(x => x.QuestionId == 1147).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1147).FirstOrDefault().AnsDes : "";
            //this.noteTextbox4.Value = answers.Where(x => x.QuestionId == 1148).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1148).FirstOrDefault().AnsDes : "";
            //this.toolsListTextbox5.Value = answers.Where(x => x.QuestionId == 1149).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1149).FirstOrDefault().AnsDes : "";
            //this.serialNumberTextbox5.Value = answers.Where(x => x.QuestionId == 1150).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1150).FirstOrDefault().AnsDes : "";
            //this.newSerialNumberTextbox5.Value = answers.Where(x => x.QuestionId == 1151).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1151).FirstOrDefault().AnsDes : "";
            //this.noteTextbox5.Value = answers.Where(x => x.QuestionId == 1152).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1152).FirstOrDefault().AnsDes : "";
            //this.toolsListTextbox6.Value = answers.Where(x => x.QuestionId == 1153).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1153).FirstOrDefault().AnsDes : "";
            //this.serialNumberTextbox6.Value = answers.Where(x => x.QuestionId == 1154).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1154).FirstOrDefault().AnsDes : "";
            //this.newSerialNumberTextbox6.Value = answers.Where(x => x.QuestionId == 1155).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1155).FirstOrDefault().AnsDes : "";
            //this.noteTextbox6.Value = answers.Where(x => x.QuestionId == 1156).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1156).FirstOrDefault().AnsDes : "";
            //this.toolsListTextbox7.Value = answers.Where(x => x.QuestionId == 1157).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1157).FirstOrDefault().AnsDes : "";
            //this.serialNumberTextbox7.Value = answers.Where(x => x.QuestionId == 1158).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1158).FirstOrDefault().AnsDes : "";
            //this.newSerialNumberTextbox7.Value = answers.Where(x => x.QuestionId == 1159).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1159).FirstOrDefault().AnsDes : "";
            //this.noteTextbox7.Value = answers.Where(x => x.QuestionId == 1160).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1160).FirstOrDefault().AnsDes : "";
            //this.toolsListTextbox8.Value = answers.Where(x => x.QuestionId == 1161).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1161).FirstOrDefault().AnsDes : "";
            //this.serialNumberTextbox8.Value = answers.Where(x => x.QuestionId == 1162).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1162).FirstOrDefault().AnsDes : "";
            //this.newSerialNumberTextbox8.Value = answers.Where(x => x.QuestionId == 1163).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1163).FirstOrDefault().AnsDes : "";
            //this.noteTextbox8.Value = answers.Where(x => x.QuestionId == 1164).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1164).FirstOrDefault().AnsDes : "";
            //this.toolsListTextbox9.Value = answers.Where(x => x.QuestionId == 1165).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1165).FirstOrDefault().AnsDes : "";
            //this.serialNumberTextbox9.Value = answers.Where(x => x.QuestionId == 1166).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1166).FirstOrDefault().AnsDes : "";
            //this.newSerialNumberTextbox9.Value = answers.Where(x => x.QuestionId == 1167).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1167).FirstOrDefault().AnsDes : "";
            //this.noteTextbox9.Value = answers.Where(x => x.QuestionId == 1168).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1168).FirstOrDefault().AnsDes : "";
            //this.toolsListTextbox10.Value = answers.Where(x => x.QuestionId == 1169).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1169).FirstOrDefault().AnsDes : "";
            //this.serialNumberTextbox10.Value = answers.Where(x => x.QuestionId == 1170).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1170).FirstOrDefault().AnsDes : "";
            //this.newSerialNumberTextbox10.Value = answers.Where(x => x.QuestionId == 1171).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1171).FirstOrDefault().AnsDes : "";
            //this.noteTextbox10.Value = answers.Where(x => x.QuestionId == 1172).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1172).FirstOrDefault().AnsDes : "";
            //this.toolsListTextbox11.Value = answers.Where(x => x.QuestionId == 1173).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1173).FirstOrDefault().AnsDes : "";
            //this.serialNumberTextbox11.Value = answers.Where(x => x.QuestionId == 1174).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1174).FirstOrDefault().AnsDes : "";
            //this.newSerialNumberTextbox11.Value = answers.Where(x => x.QuestionId == 1175).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1175).FirstOrDefault().AnsDes : "";
            //this.noteTextbox11.Value = answers.Where(x => x.QuestionId == 1176).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1176).FirstOrDefault().AnsDes : "";
            //this.toolsListTextbox12.Value = answers.Where(x => x.QuestionId == 1177).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1177).FirstOrDefault().AnsDes : "";
            //this.serialNumberTextbox12.Value = answers.Where(x => x.QuestionId == 1178).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1178).FirstOrDefault().AnsDes : "";
            //this.newSerialNumberTextbox12.Value = answers.Where(x => x.QuestionId == 1179).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1179).FirstOrDefault().AnsDes : "";
            //this.noteTextbox12.Value = answers.Where(x => x.QuestionId == 1180).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1180).FirstOrDefault().AnsDes : "";
            //this.toolsListTextbox13.Value = answers.Where(x => x.QuestionId == 1181).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1181).FirstOrDefault().AnsDes : "";
            //this.serialNumberTextbox13.Value = answers.Where(x => x.QuestionId == 1182).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1182).FirstOrDefault().AnsDes : "";
            //this.newSerialNumberTextbox13.Value = answers.Where(x => x.QuestionId == 1183).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1183).FirstOrDefault().AnsDes : "";
            //this.noteTextbox13.Value = answers.Where(x => x.QuestionId == 1184).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1184).FirstOrDefault().AnsDes : "";
            //this.toolsListTextbox14.Value = answers.Where(x => x.QuestionId == 1185).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1185).FirstOrDefault().AnsDes : "";
            //this.serialNumberTextbox14.Value = answers.Where(x => x.QuestionId == 1186).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1186).FirstOrDefault().AnsDes : "";
            //this.newSerialNumberTextbox14.Value = answers.Where(x => x.QuestionId == 1187).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1187).FirstOrDefault().AnsDes : "";
            //this.noteTextbox14.Value = answers.Where(x => x.QuestionId == 1188).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1188).FirstOrDefault().AnsDes : "";
            //this.toolsListTextbox15.Value = answers.Where(x => x.QuestionId == 1189).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1189).FirstOrDefault().AnsDes : "";
            //this.serialNumberTextbox15.Value = answers.Where(x => x.QuestionId == 1190).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1190).FirstOrDefault().AnsDes : "";
            //this.newSerialNumberTextbox15.Value = answers.Where(x => x.QuestionId == 1191).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1191).FirstOrDefault().AnsDes : "";
            //this.noteTextbox15.Value = answers.Where(x => x.QuestionId == 1192).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1192).FirstOrDefault().AnsDes : "";

            //this.namepmTextbox.Value = answers.Where(x => x.QuestionId == 1193).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1193).FirstOrDefault().AnsDes : "";
            //this.dayDopmTextbox.Value. = answers.Where(x => x.QuestionId == 1194).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1194).FirstOrDefault().AnsDes : "";
        }

        int GetQuarter(DateTime dt)
        {
            return (dt.Month - 1) / 3 + 1;
        }

















































    }
}