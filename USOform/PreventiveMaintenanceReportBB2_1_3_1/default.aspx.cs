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

namespace USOform.PreventiveMaintenanceReportBB2._1_3._1
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
            this.GroupNameTextBox.Value = answers.Where(x => x.QuestionId == 1014).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1014).FirstOrDefault().AnsDes : "";
            this.AreaTextbox.Value = answers.Where(x => x.QuestionId == 1015).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1015).FirstOrDefault().AnsDes : "";
            this.CompanyTextbox.Value = answers.Where(x => x.QuestionId == 1016).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1016).FirstOrDefault().AnsDes : "";
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
                Response.Redirect("~/login/login.aspx");
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




            var ans1 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1014).FirstOrDefault();
            if (ans1 == null)
            {
                Answer answer1 = new Answer()
                {
                    AnsDes = this.GroupNameTextBox.Value,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    QuestionId = 1014,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer1);
            }
            else
            {
                ans1.AnsDes = this.GroupNameTextBox.Value;
                ans1.AnserTypeId = 1;
                ans1.CreateDate = DateTime.Now;
                ans1.QuestionId = 1014;
                ans1.UserId = user.Id;
                ans1.AnsMonth = ansMonth;
                ans1.SRId = sR.Id;
            }

            // ภูมิภาค
            var ans2 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1015).FirstOrDefault();
            if (ans2 == null)
            {
                Answer answer2 = new Answer()
                {
                    AnsDes = this.AreaTextbox.Value,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    QuestionId = 1015,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer2);
            }
            else
            {
                ans2.AnsDes = this.AreaTextbox.Value;
                ans2.AnserTypeId = 1;
                ans2.CreateDate = DateTime.Now;
                ans2.QuestionId = 1015;
                ans2.UserId = user.Id;
                ans2.AnsMonth = ansMonth;
                ans2.SRId = sR.Id;
            }



            // บริษัท

            var ans3 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1016).FirstOrDefault();
            if (ans3 == null)
            {
                Answer answer3 = new Answer()
                {
                    AnsDes = this.CompanyTextbox.Value,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    QuestionId = 1016,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer3);
            }
            else
            {
                ans3.AnsDes = this.CompanyTextbox.Value;
                ans3.AnserTypeId = 1;
                ans3.CreateDate = DateTime.Now;
                ans3.QuestionId = 1016;
                ans3.UserId = user.Id;
                ans3.AnsMonth = ansMonth;
                ans3.SRId = sR.Id;


            }




            var ans3_1 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1017).FirstOrDefault();
            if (ans3_1 == null)
            {
                string category = Request.Form["category"];
                Answer answer4 = new Answer()
                {
                    AnsDes = category,
                    QuestionId = 1017,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer4);
            }
            else
            {
                string category = Request.Form["category"];
                ans3_1.AnsDes = category;
                ans3_1.AnserTypeId = 4;
                ans3_1.CreateDate = DateTime.Now;
                ans3_1.QuestionId = 1017;
                ans3_1.UserId = user.Id;
                ans3_1.AnsMonth = ansMonth; ans3_1.SRId = sR.Id;


            }


            //รอบการบำรุงรักษาครั้งที่
            var ans4 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1018).FirstOrDefault();
            if (ans4 == null)
            {
                Answer answer4 = new Answer()
                {
                    AnsDes = this.maintenanceCountTextbox.Value,
                    QuestionId = 1018,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer4);
            }
            else
            {
                ans4.AnsDes = this.maintenanceCountTextbox.Value;
                ans4.AnserTypeId = 1;
                ans4.CreateDate = DateTime.Now;
                ans4.QuestionId = 1018;
                ans4.UserId = user.Id;
                ans4.AnsMonth = ansMonth; ans4.SRId = sR.Id;


            }


            //ปีพุทธศักราช

            var ans5 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1019).FirstOrDefault();
            if (ans5 == null)
            {
                Answer answer5 = new Answer()
                {
                    AnsDes = this.yearTextbox.Value,
                    QuestionId = 1019,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer5);
            }
            else
            {
                ans5.AnsDes = this.yearTextbox.Value;
                ans5.AnserTypeId = 1;
                ans5.CreateDate = DateTime.Now;
                ans5.QuestionId = 1019;
                ans5.UserId = user.Id;
                ans5.AnsMonth = ansMonth; ans5.SRId = sR.Id;

            }

            //วัน เดือน ปี ที่เริ่มต้น
            var ans6 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1020).FirstOrDefault();
            if (ans6 == null)
            {
                Answer answer6 = new Answer()
                {
                    AnsDes = this.startDatepicker.Value,
                    //  StartDate = DateTime.ParseExact(this.startDatepicker.Value, "MM/dd/yyyy", CultureInfo.GetCultureInfo("en-GB")),
                    QuestionId = 1020,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                    //StartDate = DateTime.ParseExact(this.startDateTextbox2.Value, "MM/dd/yyyy", CultureInfo.GetCultureInfo("en-US")),
                };
                uSOEntities.Answers.Add(answer6);
            }
            else
            {
                ans6.AnsDes = this.startDatepicker.Value;
                ans6.AnserTypeId = 1;
                ans6.CreateDate = DateTime.Now;
                ans6.QuestionId = 1020;
                ans6.UserId = user.Id;
                ans6.AnsMonth = ansMonth; ans6.SRId = sR.Id;

            }

            //ถึง 
            var ans7 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1021).FirstOrDefault();
            if (ans7 == null)
            {
                Answer answer7 = new Answer()
                {
                    AnsDes = this.endDatepicker.Value,
                    // EndDate = DateTime.ParseExact(this.endDatepicker.Value, "MM/dd/yyyy", CultureInfo.GetCultureInfo("en-GB")),
                    QuestionId = 1021,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                    //StartDate = DateTime.ParseExact(this.startDateTextbox2.Value, "MM/dd/yyyy", CultureInfo.GetCultureInfo("en-US")),
                };
                uSOEntities.Answers.Add(answer7);
            }
            else
            {
                ans7.AnsDes = this.endDatepicker.Value;
                ans7.AnserTypeId = 1;
                ans7.CreateDate = DateTime.Now;
                ans7.QuestionId = 1021;
                ans7.UserId = user.Id;
                ans7.AnsMonth = ansMonth; ans7.SRId = sR.Id;
            }

            var ans8 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1022).FirstOrDefault();
            if (ans8 == null)
            {
                //สถานที่ SITE CODE
                Answer answer8 = new Answer()
                {
                    AnsDes = this.siteCodeTextbox.Value,
                    QuestionId = 1022,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer8);
            }
            else
            {
                ans8.AnsDes = this.siteCodeTextbox.Value;
                ans8.AnserTypeId = 1;
                ans8.CreateDate = DateTime.Now;
                ans8.QuestionId = 1022;
                ans8.UserId = user.Id;
                ans8.AnsMonth = ansMonth; ans8.SRId = sR.Id;

            }

            var ans9 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1023).FirstOrDefault();
            //ใส่รูป Logo 
            if (ans9 == null)
            {
                if (this.pictureOrganize_.HasFile)
                {
                    string extension = this.pictureOrganize_.PostedFile.FileName.Split('.')[1];
                    string newFileName = "images/PictureOrganize_BB2_1_3_1_" + DateTime.Now.ToString("yyyyMMddHHmmss") + "." + extension;
                    this.pictureOrganize_.PostedFile.SaveAs(Server.MapPath(newFileName));

                    Answer answer9 = new Answer()
                    {
                        AnsDes = newFileName,
                        QuestionId = 1023,
                        AnserTypeId = 3,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth,
                        SRId = sR.Id
                    };
                    uSOEntities.Answers.Add(answer9);
                }
            }
            else
            {
                if (this.pictureOrganize_.HasFile)
                {
                    string extension = this.pictureOrganize_.PostedFile.FileName.Split('.')[1];
                    string newFileName = "images/PictureOrganize_BB2_1_3_1_" + DateTime.Now.ToString("yyyyMMddHHmmss") + "." + extension;
                    this.pictureOrganize_.PostedFile.SaveAs(Server.MapPath(newFileName));



                    ans9.AnsDes = newFileName;
                    ans9.QuestionId = 1023;
                    ans9.AnserTypeId = 3;
                    ans9.CreateDate = DateTime.Now;
                    ans9.UserId = user.Id;
                    ans9.AnsMonth = ansMonth;
                    ans9.SRId = sR.Id;


                }
            }



            //Cabinet ID:
            var ans10 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1024).FirstOrDefault();
            if (ans10 == null)
            {
                Answer answer10 = new Answer()
                {
                    AnsDes = this.cabinetIdTextbox.Value,
                    QuestionId = 1024,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer10);
            }
            else
            {
                ans10.AnsDes = this.cabinetIdTextbox.Value;
                ans10.AnserTypeId = 1;
                ans10.CreateDate = DateTime.Now;
                ans10.QuestionId = 1024;
                ans10.UserId = user.Id;
                ans10.AnsMonth = ansMonth; ans10.SRId = sR.Id;
            }

            //Site Code :
            var ans11 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1025).FirstOrDefault();
            if (ans11 == null)
            {
                Answer answer11 = new Answer()
                {
                    AnsDes = this.sitecodeTextboxSection2.Value,
                    QuestionId = 1025,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer11);
            }
            else
            {
                ans11.AnsDes = this.sitecodeTextboxSection2.Value;
                ans11.AnserTypeId = 1;
                ans11.CreateDate = DateTime.Now;
                ans11.QuestionId = 1025;
                ans11.UserId = user.Id;
                ans11.AnsMonth = ansMonth; ans11.SRId = sR.Id;
            }

            //Village ID :
            var ans12 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1026).FirstOrDefault();
            if (ans12 == null)
            {
                Answer answer12 = new Answer()
                {
                    AnsDes = this.VillageIdTextbox.Value,
                    QuestionId = 1026,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer12);
            }
            else
            {
                ans12.AnsDes = this.VillageIdTextbox.Value;
                ans12.AnserTypeId = 1;
                ans12.CreateDate = DateTime.Now;
                ans12.QuestionId = 1026;
                ans12.UserId = user.Id;
                ans12.AnsMonth = ansMonth; ans12.SRId = sR.Id;
            }

            //Village  :
            var ans13 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1027).FirstOrDefault();
            if (ans13 == null)
            {
                Answer answer13 = new Answer()
                {
                    AnsDes = this.villageTextbox.Value,
                    QuestionId = 1027,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer13);
            }
            else
            {
                ans13.AnsDes = this.VillageIdTextbox.Value;
                ans13.AnserTypeId = 1;
                ans13.CreateDate = DateTime.Now;
                ans13.QuestionId = 1027;
                ans13.UserId = user.Id;
                ans13.AnsMonth = ansMonth; ans13.SRId = sR.Id;
            }


            //Sub-District :
            var ans14 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1028).FirstOrDefault();
            if (ans14 == null)
            {
                Answer answer14 = new Answer()
                {
                    AnsDes = this.subdistrictTextbox.Value,
                    QuestionId = 1028,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer14);
            }
            else
            {
                ans14.AnsDes = this.subdistrictTextbox.Value;
                ans14.AnserTypeId = 1;
                ans14.CreateDate = DateTime.Now;
                ans14.QuestionId = 1028;
                ans14.UserId = user.Id;
                ans14.AnsMonth = ansMonth; ans14.SRId = sR.Id;

            }
            //District :
            var ans15 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1029).FirstOrDefault();
            if (ans15 == null)
            {

                Answer answer15 = new Answer()
                {
                    AnsDes = this.districtTextbox.Value,
                    QuestionId = 1029,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer15);
            }
            else
            {
                ans15.AnsDes = this.districtTextbox.Value;
                ans15.AnserTypeId = 1;
                ans15.CreateDate = DateTime.Now;
                ans15.QuestionId = 1029;
                ans15.UserId = user.Id;
                ans15.AnsMonth = ansMonth; ans15.SRId = sR.Id;
            }
            //Province :
            var ans16 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1030).FirstOrDefault();
            if (ans16 == null)
            {
                Answer answer16 = new Answer()
                {
                    AnsDes = this.provinceTextbox.Value,
                    QuestionId = 1030,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer16);
            }
            else
            {
                ans16.AnsDes = this.provinceTextbox.Value;
                ans16.AnserTypeId = 1;
                ans16.CreateDate = DateTime.Now;
                ans16.QuestionId = 1030;
                ans16.UserId = user.Id;
                ans16.AnsMonth = ansMonth; ans16.SRId = sR.Id;
            }

            //Type :
            var ans17 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1031).FirstOrDefault();
            if (ans17 == null)
            {
                Answer answer17 = new Answer()
                {
                    AnsDes = this.typeTextbox.Value,
                    QuestionId = 1031,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer17);
            }
            else
            {
                ans17.AnsDes = this.typeTextbox.Value;
                ans17.AnserTypeId = 1;
                ans17.CreateDate = DateTime.Now;
                ans17.QuestionId = 1031;
                ans17.UserId = user.Id;
                ans17.AnsMonth = ansMonth; ans17.SRId = sR.Id;
            }
            //PM Date :
            var ans18 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1032).FirstOrDefault();
            if (ans18 == null)
            {
                Answer answer18 = new Answer()
                {
                    AnsDes = this.pmdateTextbox.Value,
                    QuestionId = 1032,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer18);
            }
            else
            {
                ans18.AnsDes = this.pmdateTextbox.Value;
                ans18.AnserTypeId = 1;
                ans18.CreateDate = DateTime.Now;
                ans18.QuestionId = 1032;
                ans18.UserId = user.Id;
                ans18.AnsMonth = ansMonth; ans18.SRId = sR.Id;

            }


            var ans19 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1033).FirstOrDefault();
            //ใส่รูปหน้าอาคารศูนย์ USO Net :
            if (ans19 == null)
            {
                if (this.signboardfontImage.HasFile)
                {
                    string extension = this.signboardfontImage.PostedFile.FileName.Split('.')[1];
                    string newFileName = "images/UsonetPictureBB2_2_3_2_" + DateTime.Now.ToString("yyyyMMddHHmmss") + "." + extension;
                    this.signboardfontImage.PostedFile.SaveAs(Server.MapPath(newFileName));

                    Answer answer19 = new Answer()
                    {
                        AnsDes = newFileName,
                        QuestionId = 1033,
                        AnserTypeId = 3,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth,
                        SRId = sR.Id
                    };
                    uSOEntities.Answers.Add(answer19);
                }
            }
            else
            {
                if (this.signboardfontImage.HasFile)
                {
                    string extension = this.signboardfontImage.PostedFile.FileName.Split('.')[1];
                    string newFileName = "images/UsonetPictureBB2_2_3_2_" + DateTime.Now.ToString("yyyyMMddHHmmss") + "." + extension;
                    this.signboardfontImage.PostedFile.SaveAs(Server.MapPath(newFileName));

                    ans19.QuestionId = 1033;
                    ans19.AnsDes = newFileName;
                    ans19.AnserTypeId = 3;
                    ans19.CreateDate = DateTime.Now;
                    ans19.UserId = user.Id;
                    ans19.AnsMonth = ansMonth;
                    ans19.SRId = sR.Id;
                }
            }




            //signature Executor :       
            var ans1034 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1034).FirstOrDefault();
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

            string ans1034EIEI = string.Format("images/{0}", filename);


            int mod1428 = sx.Length % 4;
            if (mod1428 > 0)
            {
                sx += new string('=', 4 - mod1428);
            }
            if (ans1034 == null)
            {
                //signature Executor :
                Answer answer21 = new Answer()
                {
                    AnsDes = ans1034EIEI,
                    QuestionId = 1034,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer21);
            }
            else
            {
                ans1034.QuestionId = 1034;
                ans1034.AnsDes = ans1034EIEI;
                ans1034.AnserTypeId = 1;
                ans1034.CreateDate = DateTime.Now;
                ans1034.UserId = user.Id;
                ans1034.AnsMonth = ansMonth;
                ans1034.SRId = sR.Id;

            }





            //signature Supervisor :
            var ans1035 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1035).FirstOrDefault();
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
            string ans1035Images = string.Format("images/{0}", filename2);

            int mod4 = s.Length % 4;
            if (mod4 > 0)
            {
                s += new string('=', 4 - mod4);
            }
            if (ans1035 == null)
            {
                //signature Supervisor :
                Answer answer22 = new Answer()
                {
                    AnsDes = ans1035Images,
                    QuestionId = 1035,
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
                ans1035.QuestionId = 1035;
                ans1035.AnsDes = ans1035Images;
                ans1035.AnserTypeId = 3;
                ans1035.CreateDate = DateTime.Now;
                ans1035.UserId = user.Id;
                ans1035.AnsMonth = ansMonth;
                ans1035.SRId = sR.Id;

            }























































            //name Executor  :
            var ans22 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1036).FirstOrDefault();
            if (ans22 == null)
            {
                Answer answer22 = new Answer()
                {
                    AnsDes = this.nameExecutorTextbox.Value,
                    QuestionId = 1036,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer22);
            }
            else
            {
                ans22.AnsDes = this.nameExecutorTextbox.Value;
                ans22.AnserTypeId = 1;
                ans22.CreateDate = DateTime.Now;
                ans22.QuestionId = 1036;
                ans22.UserId = user.Id;
                ans22.AnsMonth = ansMonth; ans22.SRId = sR.Id;
            }
            //name Supervisor :
            var ans23 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1037).FirstOrDefault();
            if (ans23 == null)
            {
                Answer answer23 = new Answer()
                {
                    AnsDes = this.nameSupervisorTextbox.Value,
                    QuestionId = 1037,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer23);
            }
            else
            {
                ans23.AnsDes = this.nameSupervisorTextbox.Value;
                ans23.AnserTypeId = 1;
                ans23.CreateDate = DateTime.Now;
                ans23.QuestionId = 1037;
                ans23.UserId = user.Id;
                ans23.AnsMonth = ansMonth; ans23.SRId = sR.Id;
            }
            //Date Executor :
            var ans24 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1038).FirstOrDefault();
            if (ans24 == null)
            {
                Answer answer24 = new Answer()
                {
                    AnsDes = this.DateExecutorTextbox.Value,
                    QuestionId = 1038,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer24);
            }
            else
            {
                ans24.AnsDes = this.DateExecutorTextbox.Value;
                ans24.AnserTypeId = 1;
                ans24.CreateDate = DateTime.Now;
                ans24.QuestionId = 1038;
                ans24.UserId = user.Id;
                ans24.AnsMonth = ansMonth; ans24.SRId = sR.Id;
            }
            //Date Supervisor :
            var ans25 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1039).FirstOrDefault();
            if (ans25 == null)
            {
                Answer answer25 = new Answer()
                {
                    AnsDes = this.DateSupervisorTextbox.Value,
                    QuestionId = 1039,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer25);
            }
            else
            {
                ans25.AnsDes = this.DateSupervisorTextbox.Value;
                ans25.AnserTypeId = 1;
                ans25.CreateDate = DateTime.Now;
                ans25.QuestionId = 1039;
                ans25.UserId = user.Id;
                ans25.AnsMonth = ansMonth; ans25.SRId = sR.Id;
            }

            var ans26 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1040).FirstOrDefault();
            if (ans26 == null)
            {
                Answer answer26 = new Answer()
                {
                    AnsDes = this.cabinetIDTextboxSection4.Value,
                    QuestionId = 1040,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer26);
            }
            else
            {
                ans26.AnsDes = this.cabinetIDTextboxSection4.Value;
                ans26.AnserTypeId = 1;
                ans26.CreateDate = DateTime.Now;
                ans26.QuestionId = 1040;
                ans26.UserId = user.Id;
                ans26.AnsMonth = ansMonth; ans26.SRId = sR.Id;
            }

            //Site code section 4 :
            var ans27 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1041).FirstOrDefault();
            if (ans27 == null)
            {
                Answer answer27 = new Answer()
                {
                    AnsDes = this.sitecodeTextboxSection4.Value,
                    QuestionId = 1041,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer27);
            }
            else
            {
                ans27.AnsDes = this.sitecodeTextboxSection4.Value;
                ans27.AnserTypeId = 1;
                ans27.CreateDate = DateTime.Now;
                ans27.QuestionId = 1041;
                ans27.UserId = user.Id;
                ans27.AnsMonth = ansMonth; ans27.SRId = sR.Id;
            }

            //villageIDsection 4 :
            var ans28 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1042).FirstOrDefault();
            if (ans28 == null)
            {
                Answer answer28 = new Answer()
                {
                    AnsDes = this.villageIDTextboxSection4.Value,
                    QuestionId = 1042,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer28);
            }
            else
            {
                ans28.AnsDes = this.villageIDTextboxSection4.Value;
                ans28.AnserTypeId = 1;
                ans28.CreateDate = DateTime.Now;
                ans28.QuestionId = 1042;
                ans28.UserId = user.Id;
                ans28.AnsMonth = ansMonth; ans28.SRId = sR.Id;
            }


            //lat and long  :
            var ans29 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1043).FirstOrDefault();
            if (ans29 == null)
            {
                Answer answer29 = new Answer()
                {
                    AnsDes = this.latandlongTextbox.Value,
                    QuestionId = 1043,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer29);
            }
            else
            {
                ans29.AnsDes = this.latandlongTextbox.Value;
                ans29.AnserTypeId = 1;
                ans29.CreateDate = DateTime.Now;
                ans29.QuestionId = 1043;
                ans29.UserId = user.Id;
                ans29.AnsMonth = ansMonth; ans29.SRId = sR.Id;
            }

            //type of signal Radio  :
            var ans29_1 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1044).FirstOrDefault();
            if (ans29_1 == null)
            {
                string typeOf = Request.Form["typeofsignalRadio"];
                Answer answer32 = new Answer()
                {
                    AnsDes = typeOf,
                    QuestionId = 1044,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer32);
            }
            else
            {
                string typeOf = Request.Form["typeofsignalRadio"];
                ans29_1.AnsDes = typeOf;
                ans29_1.AnserTypeId = 4;
                ans29_1.CreateDate = DateTime.Now;
                ans29_1.QuestionId = 1044;
                ans29_1.UserId = user.Id;
                ans29_1.AnsMonth = ansMonth; ans29_1.SRId = sR.Id;
            }


            //oltid  :
            var ans29_2 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1045).FirstOrDefault();
            if (ans29_2 == null)
            {
                Answer answer33 = new Answer()
                {
                    AnsDes = this.oltidTextbox.Value,
                    QuestionId = 1045,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer33);
            }
            else
            {
                ans29_2.AnsDes = this.oltidTextbox.Value;
                ans29_2.AnserTypeId = 1;
                ans29_2.CreateDate = DateTime.Now;
                ans29_2.QuestionId = 1045;
                ans29_2.UserId = user.Id;
                ans29_2.AnsMonth = ansMonth; ans29_2.SRId = sR.Id;
            }

            //elecSystem Radio  :
            var ans29_3 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1046).FirstOrDefault();
            if (ans29_3 == null)
            {
                string elecradioSection5 = Request.Form["elecRadio"];
                Answer answer34 = new Answer()
                {
                    AnsDes = elecradioSection5,
                    QuestionId = 1046,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer34);
            }
            else
            {
                string elecradioSection5 = Request.Form["elecRadio"];
                ans29_3.AnsDes = elecradioSection5;
                ans29_3.AnserTypeId = 4;
                ans29_3.CreateDate = DateTime.Now;
                ans29_3.QuestionId = 1046;
                ans29_3.UserId = user.Id;
                ans29_3.AnsMonth = ansMonth; ans29_3.SRId = sR.Id;
            }


            //หมายเลขผู้ใช้ไฟ  :
            var ans30 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1047).FirstOrDefault();
            if (ans30 == null)
            {
                Answer answer30 = new Answer()
                {
                    AnsDes = this.numberuserTextbox.Value,
                    QuestionId = 1047,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer30);
            }
            else
            {
                ans30.AnsDes = this.numberuserTextbox.Value;
                ans30.AnserTypeId = 1;
                ans30.CreateDate = DateTime.Now;
                ans30.QuestionId = 1047;
                ans30.UserId = user.Id;
                ans30.AnsMonth = ansMonth; ans30.SRId = sR.Id;
            }

            //หน่วยใช้ไฟไฟ  :
            var ans31 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1048).FirstOrDefault();
            if (ans31 == null)
            {
                Answer answer31 = new Answer()
                {
                    AnsDes = this.kwhMeterTextbox.Value,
                    QuestionId = 1048,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer31);
            }
            else
            {
                ans31.AnsDes = this.kwhMeterTextbox.Value;
                ans31.AnserTypeId = 1;
                ans31.CreateDate = DateTime.Now;
                ans31.QuestionId = 1048;
                ans31.UserId = user.Id;
                ans31.AnsMonth = ansMonth; ans31.SRId = sR.Id;
            }

            //แรงดัน AC (kWh Meter) :
            var ans32 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1049).FirstOrDefault();
            if (ans32 == null)
            {
                Answer answer32 = new Answer()
                {
                    AnsDes = this.acTextbox.Value,
                    QuestionId = 1049,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer32);
            }
            else
            {
                ans32.AnsDes = this.acTextbox.Value;
                ans32.AnserTypeId = 1;
                ans32.CreateDate = DateTime.Now;
                ans32.QuestionId = 1049;
                ans32.UserId = user.Id;
                ans32.AnsMonth = ansMonth; ans32.SRId = sR.Id;
            }

            //กระแส Line AC (kWh Meter) :
            var ans33 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1050).FirstOrDefault();
            if (ans33 == null)
            {
                Answer answer33 = new Answer()
                {
                    AnsDes = this.lineAcTextbox.Value,
                    QuestionId = 1050,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer33);
            }
            else
            {
                ans33.AnsDes = this.lineAcTextbox.Value;
                ans33.AnserTypeId = 1;
                ans33.CreateDate = DateTime.Now;
                ans33.QuestionId = 1050;
                ans33.UserId = user.Id;
                ans33.AnsMonth = ansMonth; ans33.SRId = sR.Id;
            }

            // กระแส Neutron AC(kWh Meter) :     
            var ans34 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1051).FirstOrDefault();
            if (ans34 == null)
            {
                Answer answer34 = new Answer()
                {
                    AnsDes = this.neutronacTextbox.Value,
                    QuestionId = 1051,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer34);
            }
            else
            {
                ans34.AnsDes = this.neutronacTextbox.Value;
                ans34.AnserTypeId = 1;
                ans34.CreateDate = DateTime.Now;
                ans34.QuestionId = 1051;
                ans34.UserId = user.Id;
                ans34.AnsMonth = ansMonth; ans34.SRId = sR.Id;
            }

            //สภาพ kWh Meter Radio  :
            var ans35 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1052).FirstOrDefault();
            if (ans35 == null)
            {
                string conRadio = Request.Form["conditionRadio"];
                Answer answer35 = new Answer()
                {
                    AnsDes = conRadio,
                    QuestionId = 1052,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer35);
            }
            else
            {
                string conRadio = Request.Form["conditionRadio"];
                ans35.AnsDes = conRadio;
                ans35.AnserTypeId = 4;
                ans35.CreateDate = DateTime.Now;
                ans35.QuestionId = 1052;
                ans35.UserId = user.Id;
                ans35.AnsMonth = ansMonth; ans35.SRId = sR.Id;
            }
            //สภาพ Circuit Breaker Radio  :
            var ans36 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1053).FirstOrDefault();
            if (ans36 == null)
            {
                string CircuitBreakerRadio = Request.Form["CircuitBreakerRadio"];
                Answer answer36 = new Answer()
                {
                    AnsDes = CircuitBreakerRadio,
                    QuestionId = 1053,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer36);
            }
            else
            {
                string CircuitBreakerRadio = Request.Form["CircuitBreakerRadio"];
                ans36.AnsDes = CircuitBreakerRadio;
                ans36.AnserTypeId = 4;
                ans36.CreateDate = DateTime.Now;
                ans36.QuestionId = 1053;
                ans36.UserId = user.Id;
                ans36.AnsMonth = ansMonth; ans36.SRId = sR.Id;
            }



            var ans37 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1054).FirstOrDefault();
            if (ans37 == null)
            {
                //UPS ภายในตู้ Radio  :
                string innerUPS = Request.Form["inupsRadio"];
                Answer answer43 = new Answer()
                {
                    AnsDes = innerUPS,
                    QuestionId = 1054,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer43);
            }
            else
            {
                string innerUPS = Request.Form["inupsRadio"];
                ans37.AnsDes = innerUPS;
                ans37.AnserTypeId = 4;
                ans37.CreateDate = DateTime.Now;
                ans37.QuestionId = 1054;
                ans37.UserId = user.Id;
                ans37.AnsMonth = ansMonth; ans37.SRId = sR.Id;
            }


            // AC from UPS :     
            var ans38 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1055).FirstOrDefault();
            if (ans38 == null)
            {
                Answer answer44 = new Answer()
                {
                    AnsDes = this.acfromupsTextbox.Value,
                    QuestionId = 1055,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer44);
            }
            else
            {
                ans38.AnsDes = this.acfromupsTextbox.Value;
                ans38.AnserTypeId = 4;
                ans38.CreateDate = DateTime.Now;
                ans38.QuestionId = 1055;
                ans38.UserId = user.Id;
                ans38.AnsMonth = ansMonth; ans38.SRId = sR.Id;
            }

            // กระเเส โหลด :
            var ans39 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1056).FirstOrDefault();
            if (ans39 == null)
            {
                string levelLoad = Request.Form["levelLoadRadio"];
                Answer answer45 = new Answer()
                {
                    AnsDes = levelLoad,
                    QuestionId = 1056,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer45);
            }
            else
            {
                string levelLoad = Request.Form["levelLoadRadio"];
                ans39.AnsDes = levelLoad;
                ans39.AnserTypeId = 4;
                ans39.CreateDate = DateTime.Now;
                ans39.QuestionId = 1056;
                ans39.UserId = user.Id;
                ans39.AnsMonth = ansMonth; ans39.SRId = sR.Id;
            }



            //levelBatteryRadio
            var ans40 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1057).FirstOrDefault();
            if (ans40 == null)
            {
                string levelbat = Request.Form["levelBatteryRadio"];
                Answer answer46 = new Answer()
                {
                    AnsDes = levelbat,
                    QuestionId = 1057,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer46);
            }
            else
            {
                string levelbat = Request.Form["levelBatteryRadio"];
                ans40.AnsDes = levelbat;
                ans40.AnserTypeId = 4;
                ans40.CreateDate = DateTime.Now;
                ans40.QuestionId = 1057;
                ans40.UserId = user.Id;
                ans40.AnsMonth = ansMonth; ans39.SRId = sR.Id;
            }

            //upsmode
            var ans41 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1058).FirstOrDefault();
            if (ans41 == null)
            {
                string xx = Request.Form["upsModeRadio"];
                Answer answer47 = new Answer()
                {
                    AnsDes = xx,
                    QuestionId = 1058,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer47);
            }
            else
            {
                string xx = Request.Form["upsModeRadio"];
                ans41.AnsDes = xx;
                ans41.AnserTypeId = 4;
                ans41.CreateDate = DateTime.Now;
                ans41.QuestionId = 1058;
                ans41.UserId = user.Id;
                ans41.AnsMonth = ansMonth; ans39.SRId = sR.Id;
            }


            //EMER GENNNARATOR   :
            var ans42 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1059).FirstOrDefault();
            if (ans42 == null)
            {
                string emergen = Request.Form["emergeneratorRadio"];
                Answer answer48 = new Answer()
                {
                    AnsDes = emergen,
                    QuestionId = 1059,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer48);
            }
            else
            {
                string emergen = Request.Form["emergeneratorRadio"];
                ans42.AnsDes = emergen;
                ans42.AnserTypeId = 4;
                ans42.CreateDate = DateTime.Now;
                ans42.QuestionId = 1059;
                ans42.UserId = user.Id;
                ans42.AnsMonth = ansMonth; ans39.SRId = sR.Id;
            }

            //สภาพ batterry bank  :
            var ans43 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1060).FirstOrDefault();
            if (ans43 == null)
            {
                string statebat = Request.Form["stateBatteryBankRadio"];
                Answer answer49 = new Answer()
                {
                    AnsDes = statebat,
                    QuestionId = 1060,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer49);
            }
            else
            {
                string statebat = Request.Form["stateBatteryBankRadio"];
                ans43.AnsDes = statebat;
                ans43.AnserTypeId = 4;
                ans43.CreateDate = DateTime.Now;
                ans43.QuestionId = 1060;
                ans43.UserId = user.Id;
                ans43.AnsMonth = ansMonth; ans43.SRId = sR.Id;
            }

            //ONU/Modem Network  :
            var ans44 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1061).FirstOrDefault();
            if (ans44 == null)
            {
                string modemnet = Request.Form["onuModemRadio"];
                Answer aa = new Answer()
                {
                    AnsDes = modemnet,
                    QuestionId = 1061,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(aa);
            }
            else
            {
                string modemnet = Request.Form["onuModemRadio"];
                ans44.AnsDes = modemnet;
                ans44.AnserTypeId = 4;
                ans44.CreateDate = DateTime.Now;
                ans44.QuestionId = 1061;
                ans44.UserId = user.Id;
                ans44.AnsMonth = ansMonth; ans44.SRId = sR.Id;
            }


            //Power Supply (for Switch)
            var ans45 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1062).FirstOrDefault();
            if (ans45 == null)
            {
                string powersub = Request.Form["powersubRadio"];
                Answer answer50 = new Answer()
                {
                    AnsDes = powersub,
                    QuestionId = 1062,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer50);
            }
            else
            {
                string powersub = Request.Form["powersubRadio"];
                ans45.AnsDes = powersub;
                ans45.AnserTypeId = 4;
                ans45.CreateDate = DateTime.Now;
                ans45.QuestionId = 1062;
                ans45.UserId = user.Id;
                ans45.AnsMonth = ansMonth; ans45.SRId = sR.Id;
            }


            //Swicth 8 port :
            var ans46 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1063).FirstOrDefault();
            if (ans46 == null)
            {
                string ee = Request.Form["switchportRadio"];
                Answer answer51 = new Answer()
                {
                    AnsDes = ee,
                    QuestionId = 1063,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer51);
            }
            else
            {
                string ee = Request.Form["switchportRadio"];
                ans46.AnsDes = ee;
                ans46.AnserTypeId = 4;
                ans46.CreateDate = DateTime.Now;
                ans46.QuestionId = 1063;
                ans46.UserId = user.Id;
                ans46.AnsMonth = ansMonth; ans46.SRId = sR.Id;
            }


            //Outdoor AP 2.4 :
            var ans47 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1064).FirstOrDefault();
            if (ans47 == null)
            {
                string otap = Request.Form["outdoorapRadio2_4"];
                Answer answer52 = new Answer()
                {
                    AnsDes = otap,
                    QuestionId = 1064,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer52);
            }
            else
            {
                string otap = Request.Form["outdoorapRadio2_4"];
                ans47.AnsDes = otap;
                ans47.AnserTypeId = 4;
                ans47.CreateDate = DateTime.Now;
                ans47.QuestionId = 1064;
                ans47.UserId = user.Id;
                ans47.AnsMonth = ansMonth; ans47.SRId = sR.Id;
            }



            //Outdoor AP 5 :
            var ans48 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1065).FirstOrDefault();
            if (ans48 == null)
            {
                string otap2 = Request.Form["outdoorapRadio5"];
                Answer answer53 = new Answer()
                {
                    AnsDes = otap2,
                    QuestionId = 1065,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer53);
            }
            else
            {
                string otap2 = Request.Form["outdoorapRadio5"];
                ans48.AnsDes = otap2;
                ans48.AnserTypeId = 4;
                ans48.CreateDate = DateTime.Now;
                ans48.QuestionId = 1065;
                ans48.UserId = user.Id;
                ans48.AnsMonth = ansMonth; ans48.SRId = sR.Id;
            }


            //ระบบระบายอากาศ (T-Power)
            var ans49 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1066).FirstOrDefault();
            if (ans49 == null)
            {
                string tpower = Request.Form["tpowerRadio"];
                Answer answer54 = new Answer()
                {
                    AnsDes = tpower,
                    QuestionId = 1066,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer54);
            }
            else
            {
                string tpower = Request.Form["tpowerRadio"];
                ans49.AnsDes = tpower;
                ans49.AnserTypeId = 4;
                ans49.CreateDate = DateTime.Now;
                ans49.QuestionId = 1066;
                ans49.UserId = user.Id;
                ans49.AnsMonth = ansMonth; ans49.SRId = sR.Id;
            }



            //การ Wiring สายไฟ :
            var ans50 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1067).FirstOrDefault();
            if (ans50 == null)
            {
                string wiring = Request.Form["wiringelecRadio"];
                Answer answer56 = new Answer()
                {
                    AnsDes = wiring,
                    QuestionId = 1067,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer56);
            }
            else
            {
                string wiring = Request.Form["wiringelecRadio"];
                ans50.AnsDes = wiring;
                ans50.AnserTypeId = 4;
                ans50.CreateDate = DateTime.Now;
                ans50.QuestionId = 1067;
                ans50.UserId = user.Id;
                ans50.AnsMonth = ansMonth; ans50.SRId = sR.Id;
            }


            //การ Wiring Patch cord และ สาย LAN :
            var ans51 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1068).FirstOrDefault();
            if (ans51 == null)
            {
                string wiringPatch = Request.Form["wiringpatchRadio"];
                Answer answer57 = new Answer()
                {
                    AnsDes = wiringPatch,
                    QuestionId = 1068,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer57);
            }
            else
            {
                string wiringPatch = Request.Form["wiringpatchRadio"];
                ans51.AnsDes = wiringPatch;
                ans51.AnserTypeId = 4;
                ans51.CreateDate = DateTime.Now;
                ans51.QuestionId = 1068;
                ans51.UserId = user.Id;
                ans51.AnsMonth = ansMonth; ans51.SRId = sR.Id;
            }



            //ความแข็งแรงจุดต่อ Ground Bar :
            var ans51_ = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1069).FirstOrDefault();
            if (ans51_ == null)
            {
                string gb = Request.Form["groundbarRadio"];
                Answer answer58 = new Answer()
                {
                    AnsDes = gb,
                    QuestionId = 1069,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer58);
            }
            else
            {
                string gb = Request.Form["groundbarRadio"];
                ans51_.AnsDes = gb;
                ans51_.AnserTypeId = 4;
                ans51_.CreateDate = DateTime.Now;
                ans51_.QuestionId = 1069;
                ans51_.UserId = user.Id;
                ans51_.AnsMonth = ansMonth; ans51.SRId = sR.Id;
            }


            //ความแข็งแรงของน็อตขันหางปลาอุปกรณ์ :
            var ans52 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1070).FirstOrDefault();
            if (ans52 == null)
            {
                string fishnot = Request.Form["notfishRadio"];
                Answer answer59 = new Answer()
                {
                    AnsDes = fishnot,
                    QuestionId = 1070,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer59);
            }
            else
            {
                string fishnot = Request.Form["notfishRadio"];
                ans52.AnsDes = fishnot;
                ans52.AnserTypeId = 4;
                ans52.CreateDate = DateTime.Now;
                ans52.QuestionId = 1070;
                ans52.UserId = user.Id;
                ans52.AnsMonth = ansMonth; ans52.SRId = sR.Id;
            }
            //สายกราวด์เรียบร้อย ปลอดภัย สมบูรณ์ :
            var ans53 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1071).FirstOrDefault();
            if (ans53 == null)
            {
                string ffss = Request.Form["safegroundRadio"];
                Answer answer60 = new Answer()
                {
                    AnsDes = ffss,
                    QuestionId = 1071,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer60);
            }
            else
            {
                string ffss = Request.Form["safegroundRadio"];
                ans53.AnsDes = ffss;
                ans53.AnserTypeId = 4;
                ans53.CreateDate = DateTime.Now;
                ans53.QuestionId = 1071;
                ans53.UserId = user.Id;
                ans53.AnsMonth = ansMonth; ans53.SRId = sR.Id;
            }

            //สถานะไฟฟ้ารั่วลง Ground :
            var ans54 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1072).FirstOrDefault();
            if (ans54 == null)
            {
                string elecground = Request.Form["brokenElecRadio"];
                Answer answer61 = new Answer()
                {
                    AnsDes = elecground,
                    QuestionId = 1072,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer61);
            }
            else
            {

                string elecground = Request.Form["brokenElecRadio"];
                ans54.AnsDes = elecground;
                ans54.AnserTypeId = 4;
                ans54.CreateDate = DateTime.Now;
                ans54.QuestionId = 1072;
                ans54.UserId = user.Id;
                ans54.AnsMonth = ansMonth; ans54.SRId = sR.Id;
            }

            //////////// an1-an7 ////////////
            //iป้ายและตัวเลขแสดงชื่อสถานี :
            var ans55 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1073).FirstOrDefault();
            if (ans55 == null)
            {
                string stationradio = Request.Form["nameStationRadio"];
                Answer an1 = new Answer()
                {
                    AnsDes = stationradio,
                    QuestionId = 1073,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(an1);
            }
            else
            {
                string stationradio = Request.Form["nameStationRadio"];
                ans55.AnsDes = stationradio;
                ans55.AnserTypeId = 4;
                ans55.CreateDate = DateTime.Now;
                ans55.QuestionId = 1073;
                ans55.UserId = user.Id;
                ans55.AnsMonth = ansMonth; ans55.SRId = sR.Id;
            }

            //การติดตั้งและการยึดตู้อุปกรณ์ :
            var ans56 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1074).FirstOrDefault();
            if (ans56 == null)
            {
                string installbox = Request.Form["installandboxRadio"];
                Answer an2 = new Answer()
                {
                    AnsDes = installbox,
                    QuestionId = 1074,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(an2);
            }
            else
            {
                string installbox = Request.Form["installandboxRadio"];
                ans56.AnsDes = installbox;
                ans56.AnserTypeId = 4;
                ans56.CreateDate = DateTime.Now;
                ans56.QuestionId = 1074;
                ans56.UserId = user.Id;
                ans56.AnsMonth = ansMonth; ans56.SRId = sR.Id;
            }

            //เสาไฟฟ้าที่ตั้งตั้งอุปกรณ์ :
            var ans57 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1075).FirstOrDefault();
            if (ans57 == null)
            {
                string postElec = Request.Form["postElectriInstallRadio"];
                Answer an3 = new Answer()
                {
                    AnsDes = postElec,
                    QuestionId = 1075,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(an3);
            }
            else
            {
                string postElec = Request.Form["postElectriInstallRadio"]; ;
                ans57.AnsDes = postElec;
                ans57.AnserTypeId = 4;
                ans57.CreateDate = DateTime.Now;
                ans57.QuestionId = 1075;
                ans57.UserId = user.Id;
                ans57.AnsMonth = ansMonth; ans57.SRId = sR.Id;
            }

            //แนวสายไฟฟ้าและสายเคเบิ้ลเข้าสถานี :
            var ans58 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1076).FirstOrDefault();
            if (ans58 == null)
            {
                string cableinStatiom = Request.Form["cableInStationRadio"];
                Answer an4 = new Answer()
                {
                    AnsDes = cableinStatiom,
                    QuestionId = 1076,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(an4);
            }
            else
            {
                string cableinStatiom = Request.Form["cableInStationRadio"];
                ans58.AnsDes = cableinStatiom;
                ans58.AnserTypeId = 4;
                ans58.CreateDate = DateTime.Now;
                ans58.QuestionId = 1076;
                ans58.UserId = user.Id;
                ans58.AnsMonth = ansMonth; ans58.SRId = sR.Id;
            }


            //ช่อง Cable Inlet  และความสะอาด :
            var ans59 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1077).FirstOrDefault();
            if (ans59 == null)
            {
                string cleancable = Request.Form["cleanCableRadio"];
                Answer an5 = new Answer()
                {
                    AnsDes = cleancable,
                    QuestionId = 1077,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(an5);
            }
            else
            {
                string cleancable = Request.Form["cleanCableRadio"];
                ans59.AnsDes = cleancable;
                ans59.AnserTypeId = 4;
                ans59.CreateDate = DateTime.Now;
                ans59.QuestionId = 1077;
                ans59.UserId = user.Id;
                ans59.AnsMonth = ansMonth; ans59.SRId = sR.Id;
            }
            //ช่อง Filter ความสะอาด (T-Power)
            var ans60 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1078).FirstOrDefault();
            if (ans60 == null)
            {
                string cleanfilter = Request.Form["CleanfilterTpowerRadio"];
                Answer an6 = new Answer()
                {
                    AnsDes = cleanfilter,
                    QuestionId = 1078,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(an6);
            }
            else
            {
                string cleanfilter = Request.Form["CleanfilterTpowerRadio"];
                ans60.AnsDes = cleanfilter;
                ans60.AnserTypeId = 4;
                ans60.CreateDate = DateTime.Now;
                ans60.QuestionId = 1078;
                ans60.UserId = user.Id;
                ans60.AnsMonth = ansMonth; ans60.SRId = sR.Id;
            }

            //ประตูและยางขอบประตูของตู้อุปกรณ์ :
            var ans61 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1079).FirstOrDefault();
            if (ans61 == null)
            {
                string doorboxd = Request.Form["doorandboxRadio"];
                Answer an7 = new Answer()
                {
                    AnsDes = doorboxd,
                    QuestionId = 1079,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(an7);
            }
            else
            {
                string doorboxd = Request.Form["doorandboxRadio"];
                ans61.AnsDes = doorboxd;
                ans61.AnserTypeId = 4;
                ans61.CreateDate = DateTime.Now;
                ans61.QuestionId = 1079;
                ans61.UserId = user.Id;
                ans61.AnsMonth = ansMonth; ans61.SRId = sR.Id;
            }


            // อุปกรณ์ LNB/BUC   :
            var ans62 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1080).FirstOrDefault();
            if (ans62 == null)
            {
                string tools = Request.Form["toolslnbRadio"];
                Answer answer104 = new Answer()
                {
                    AnsDes = tools,
                    QuestionId = 1080,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer104);
            }
            else
            {
                string tools = Request.Form["toolslnbRadio"];
                ans62.AnsDes = tools;
                ans62.AnserTypeId = 4;
                ans62.CreateDate = DateTime.Now;
                ans62.QuestionId = 1080;
                ans62.UserId = user.Id;
                ans62.AnsMonth = ansMonth; ans62.SRId = sR.Id;
            }


            // การเก็บสาย RG และการพันหัว   :
            var ans63 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1081).FirstOrDefault();
            if (ans63 == null)
            {
                string toolsRG = Request.Form["wiringrgRadio"];
                Answer answer105 = new Answer()
                {
                    AnsDes = toolsRG,
                    QuestionId = 1081,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer105);
            }
            else
            {
                string toolsRG = Request.Form["wiringrgRadio"];
                ans63.AnsDes = toolsRG;
                ans63.AnserTypeId = 4;
                ans63.CreateDate = DateTime.Now;
                ans63.QuestionId = 1081;
                ans63.UserId = user.Id;
                ans63.AnsMonth = ansMonth; ans63.SRId = sR.Id;
            }



            // ฐานและระดับของเสาจาน  :
            var ans64 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1082).FirstOrDefault();
            if (ans64 == null)
            {
                string baseOneiei = Request.Form["baseOnRadio"];
                Answer answer106 = new Answer()
                {
                    AnsDes = baseOneiei,
                    QuestionId = 1082,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer106);
            }
            else
            {
                string baseOneiei = Request.Form["baseOnRadio"];
                ans64.AnsDes = baseOneiei;
                ans64.AnserTypeId = 4;
                ans64.CreateDate = DateTime.Now;
                ans64.QuestionId = 1082;
                ans64.UserId = user.Id;
                ans64.AnsMonth = ansMonth; ans64.SRId = sR.Id;
            }


            // แนว Line Of Sight  :
            var ans65_ = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1083).FirstOrDefault();
            if (ans65_ == null)
            {
                string lineOf = Request.Form["lineOfsightRadio"];
                Answer answer107 = new Answer()
                {
                    AnsDes = lineOf,
                    QuestionId = 1083,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer107);
            }
            else
            {
                string lineOf = Request.Form["lineOfsightRadio"];
                ans65_.AnsDes = lineOf;
                ans65_.AnserTypeId = 4;
                ans65_.CreateDate = DateTime.Now;
                ans65_.QuestionId = 1083;
                ans65_.UserId = user.Id;
                ans65_.AnsMonth = ansMonth; ans65_.SRId = sR.Id;
            }


            // ความสะอาดของหน้าจาน  :
            var ans66_ = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1084).FirstOrDefault();
            if (ans66_ == null)
            {
                string clendDish = Request.Form["cleaningDishRadio"];
                Answer answer108 = new Answer()
                {
                    AnsDes = clendDish,
                    QuestionId = 1084,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer108);
            }
            else
            {
                string clendDish = Request.Form["cleaningDishRadio"];
                ans66_.AnsDes = clendDish;
                ans66_.AnserTypeId = 4;
                ans66_.CreateDate = DateTime.Now;
                ans66_.QuestionId = 1084;
                ans66_.UserId = user.Id;
                ans66_.AnsMonth = ansMonth; ans66_.SRId = sR.Id;

            }


            // LNB Band Switch  :
            var ans67_ = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1085).FirstOrDefault();
            if (ans67_ == null)
            {
                string lnbswitch = Request.Form["lnbbandswitchRadio"];
                Answer answer109 = new Answer()
                {
                    AnsDes = lnbswitch,
                    QuestionId = 1085,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer109);
            }
            else
            {
                string lnbswitch = Request.Form["lnbbandswitchRadio"];
                ans67_.AnsDes = lnbswitch;
                ans67_.AnserTypeId = 4;
                ans67_.CreateDate = DateTime.Now;
                ans67_.QuestionId = 1085;
                ans67_.UserId = user.Id;
                ans67_.AnsMonth = ansMonth; ans67_.SRId = sR.Id;
            }


            // ระบบ Solar Cell :
            var ans68_ = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1086).FirstOrDefault();
            if (ans68_ == null)
            {
                string solarCells = Request.Form["solarcellSystemRadio"];
                Answer answer110 = new Answer()
                {
                    AnsDes = solarCells,
                    QuestionId = 1086,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer110);
            }
            else
            {
                string solarCells = Request.Form["solarcellSystemRadio"];
                ans68_.AnsDes = solarCells;
                ans68_.AnserTypeId = 4;
                ans68_.CreateDate = DateTime.Now;
                ans68_.QuestionId = 1086;
                ans68_.UserId = user.Id;
                ans68_.AnsMonth = ansMonth; ans68_.SRId = sR.Id;
            }


            // แผง PV Panel:
            var ans69_ = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1087).FirstOrDefault();
            if (ans69_ == null)
            {
                string pv = Request.Form["pvPanelRadio"];
                Answer answer111 = new Answer()
                {
                    AnsDes = pv,
                    QuestionId = 1087,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer111);
            }
            else
            {
                string pv = Request.Form["pvPanelRadio"];
                ans69_.AnsDes = pv;
                ans69_.AnserTypeId = 4;
                ans69_.CreateDate = DateTime.Now;
                ans69_.QuestionId = 1087;
                ans69_.UserId = user.Id;
                ans69_.AnsMonth = ansMonth; ans69_.SRId = sR.Id;
            }



            // อุปกรณ์ Charger :
            var ans70_ = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1088).FirstOrDefault();
            if (ans70_ == null)
            {
                string charGer = Request.Form["toolsCharger"];
                Answer answer112 = new Answer()
                {
                    AnsDes = charGer,
                    QuestionId = 1088,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer112);
            }
            else
            {
                string charGer = Request.Form["toolsCharger"];
                ans70_.AnsDes = charGer;
                ans70_.AnserTypeId = 4;
                ans70_.CreateDate = DateTime.Now;
                ans70_.QuestionId = 1088;
                ans70_.UserId = user.Id;
                ans70_.AnsMonth = ansMonth; ans70_.SRId = sR.Id;
            }




            // ความสะอาดแผง PV :
            var ans71_ = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1089).FirstOrDefault();
            if (ans71_ == null)
            {
                string cleanPv = Request.Form["cleanIngpvRadio"];
                Answer answer113 = new Answer()
                {
                    AnsDes = cleanPv,
                    QuestionId = 1089,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer113);
            }
            else
            {
                string cleanPv = Request.Form["cleanIngpvRadio"];
                ans71_.AnsDes = cleanPv;
                ans71_.AnserTypeId = 4;
                ans71_.CreateDate = DateTime.Now;
                ans71_.QuestionId = 1089;
                ans71_.UserId = user.Id;
                ans71_.AnsMonth = ansMonth; ans71_.SRId = sR.Id;
            }



            // การติดตั้งแผง PV :
            var ans72_ = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1090).FirstOrDefault();
            if (ans72_ == null)
            {
                string intPv = Request.Form["installPvRadio"];
                Answer answer114 = new Answer()
                {
                    AnsDes = intPv,
                    QuestionId = 1090,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer114);
            }
            else
            {
                string intPv = Request.Form["installPvRadio"];
                ans72_.AnsDes = intPv;
                ans72_.AnserTypeId = 4;
                ans72_.CreateDate = DateTime.Now;
                ans72_.QuestionId = 1090;
                ans72_.UserId = user.Id;
                ans72_.AnsMonth = ansMonth; 
                ans72_.SRId = sR.Id;
            }




            // แรงดันไฟจาก Inverter :        
            var ans73_ = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1091).FirstOrDefault();
            if (ans73_ == null)
            {
                Answer answer115 = new Answer()
                {
                    AnsDes = this.voltageInverterTextbox.Value,
                    QuestionId = 1091,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer115);
            }
            else
            {

                ans73_.AnsDes = this.voltageInverterTextbox.Value;
                ans73_.AnserTypeId = 1;
                ans73_.CreateDate = DateTime.Now;
                ans73_.QuestionId = 1091;
                ans73_.UserId = user.Id;
                ans73_.AnsMonth = ansMonth; ans73_.SRId = sR.Id;
            }


            // กระแส Load :          
            var ans74_ = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1092).FirstOrDefault();
            if (ans74_ == null)
            {
                Answer answer116 = new Answer()
                {
                    AnsDes = this.voltageLoadTextbox.Value,
                    QuestionId = 1092,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer116);
            }
            else
            {
                ans74_.AnsDes = this.voltageLoadTextbox.Value;
                ans74_.AnserTypeId = 1;
                ans74_.CreateDate = DateTime.Now;
                ans74_.QuestionId = 1092;
                ans74_.UserId = user.Id;
                ans74_.AnsMonth = ansMonth; ans74_.SRId = sR.Id;
            }
            //bat1-bat4//////////////////////////
            // แรงดัน Battery ก้อนที่ 1 
            var ans75_ = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1093).FirstOrDefault();
            if (ans75_ == null)
            {
                Answer bat1 = new Answer()
                {
                    AnsDes = this.powerBatterytext1.Value,
                    QuestionId = 1093,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(bat1);
            }
            else
            {
                ans75_.AnsDes = this.powerBatterytext1.Value;
                ans75_.AnserTypeId = 1;
                ans75_.CreateDate = DateTime.Now;
                ans75_.QuestionId = 1093;
                ans75_.UserId = user.Id;
                ans75_.AnsMonth = ansMonth; ans75_.SRId = sR.Id;
            }

            // แรงดัน Battery ก้อนที่ 2   
            var ans76_ = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1094).FirstOrDefault();
            if (ans76_ == null)
            {
                Answer bat2 = new Answer()
                {
                    AnsDes = this.powerBatterytext2.Value,
                    QuestionId = 1094,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(bat2);
            }
            else
            {
                ans76_.AnsDes = this.powerBatterytext2.Value;
                ans76_.AnserTypeId = 1;
                ans76_.CreateDate = DateTime.Now;
                ans76_.QuestionId = 1094;
                ans76_.UserId = user.Id;
                ans76_.AnsMonth = ansMonth; ans76_.SRId = sR.Id;
            }

            // แรงดัน Battery ก้อนที่ 3    
            var ans77_ = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1095).FirstOrDefault();
            if (ans77_ == null)
            {
                Answer bat3 = new Answer()
                {
                    AnsDes = this.powerBatterytext3.Value,
                    QuestionId = 1095,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(bat3);
            }
            else
            {
                ans77_.AnsDes = this.powerBatterytext3.Value;
                ans77_.AnserTypeId = 1;
                ans77_.CreateDate = DateTime.Now;
                ans77_.QuestionId = 1095;
                ans77_.UserId = user.Id;
                ans77_.AnsMonth = ansMonth; ans77_.SRId = sR.Id;
            }

            // แรงดัน Battery ก้อนที่ 4  
            var ans78_ = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1096).FirstOrDefault();
            if (ans78_ == null)
            {
                Answer bat4 = new Answer()
                {
                    AnsDes = this.powerBatterytext4.Value,
                    QuestionId = 1096,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(bat4);
            }
            else
            {
                ans78_.AnsDes = this.powerBatterytext4.Value;
                ans78_.AnserTypeId = 1;
                ans78_.CreateDate = DateTime.Now;
                ans78_.QuestionId = 1096;
                ans78_.UserId = user.Id;
                ans78_.AnsMonth = ansMonth; ans78_.SRId = sR.Id;
            }

            // Download (for ONU/VSAT) : 
            var ans79_ = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1097).FirstOrDefault();
            if (ans79_ == null)
            {
                Answer answer117 = new Answer()
                {
                    AnsDes = this.dowloadforOnuTextbox.Value,
                    QuestionId = 1097,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer117);
            }
            else
            {
                ans79_.AnsDes = this.dowloadforOnuTextbox.Value;
                ans79_.AnserTypeId = 1;
                ans79_.CreateDate = DateTime.Now;
                ans79_.QuestionId = 1097;
                ans79_.UserId = user.Id;
                ans79_.AnsMonth = ansMonth; ans79_.SRId = sR.Id;

            }


            // Upload (for ONU/VSAT) :        
            var ans80_ = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1098).FirstOrDefault();
            if (ans80_ == null)
            {
                Answer answer118 = new Answer()
                {
                    AnsDes = this.uploadforOnuTextbox.Value,
                    QuestionId = 1098,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer118);
            }
            else
            {
                ans80_.AnsDes = this.uploadforOnuTextbox.Value;
                ans80_.AnserTypeId = 1;
                ans80_.CreateDate = DateTime.Now;
                ans80_.QuestionId = 1098;
                ans80_.UserId = user.Id;
                ans80_.AnsMonth = ansMonth; ans80_.SRId = sR.Id;
            }


            // Ping Test (for ONU/VSAT):    
            var ans81_ = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1099).FirstOrDefault();
            if (ans81_ == null)
            {
                Answer answer119 = new Answer()
                {
                    AnsDes = this.pingTestTextbox.Value,
                    QuestionId = 1099,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer119);
            }
            else
            {
                ans81_.AnsDes = this.pingTestTextbox.Value;
                ans81_.AnserTypeId = 1;
                ans81_.CreateDate = DateTime.Now;
                ans81_.QuestionId = 1099;
                ans81_.UserId = user.Id;
                ans81_.AnsMonth = ansMonth; ans81_.SRId = sR.Id;
            }


            // Download (for WIFI):    
            var ans82_ = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1100).FirstOrDefault();
            if (ans82_ == null)
            {
                Answer answer120 = new Answer()
                {
                    AnsDes = this.dowloadForwifiTextbox.Value,
                    QuestionId = 1100,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer120);
            }
            else
            {
                ans82_.AnsDes = this.dowloadForwifiTextbox.Value;
                ans82_.AnserTypeId = 1;
                ans82_.CreateDate = DateTime.Now;
                ans82_.QuestionId = 1100;
                ans82_.UserId = user.Id;
                ans82_.AnsMonth = ansMonth; ans82_.SRId = sR.Id;
            }


            // Upload (for WIFI):   
            var ans83_ = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1101).FirstOrDefault();
            if (ans83_ == null)
            {
                Answer answer121 = new Answer()
                {
                    AnsDes = this.uploadForwifiTextbox.Value,
                    QuestionId = 1101,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer121);
            }
            else
            {
                ans83_.AnsDes = this.uploadForwifiTextbox.Value;
                ans83_.AnserTypeId = 1;
                ans83_.CreateDate = DateTime.Now;
                ans83_.QuestionId = 1101;
                ans83_.UserId = user.Id;
                ans83_.AnsMonth = ansMonth; ans83_.SRId = sR.Id;
            }

            // Ping Test (for WIFI) :        
            var ans84_ = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1102).FirstOrDefault();
            if (ans84_ == null)
            {
                Answer answer122 = new Answer()
                {
                    AnsDes = this.pingtestForwifiTextbox.Value,
                    QuestionId = 1102,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer122);
            }
            else
            {
                ans84_.AnsDes = this.pingtestForwifiTextbox.Value;
                ans84_.AnserTypeId = 1;
                ans84_.CreateDate = DateTime.Now;
                ans84_.QuestionId = 1102;
                ans84_.UserId = user.Id;
                ans84_.AnsMonth = ansMonth; ans84_.SRId = sR.Id;
            }



            //  ปัญหาที่พบ 1 : 
            var ans85 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1103).FirstOrDefault();
            if (ans85 == null)
            {
                Answer answer62_ = new Answer()
                {
                    AnsDes = this.problemTextbox1.Value,
                    QuestionId = 1103,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer62_);
            }
            else
            {
                ans85.AnsDes = this.problemTextbox1.Value;
                ans85.AnserTypeId = 1;
                ans85.CreateDate = DateTime.Now;
                ans85.QuestionId = 1103;
                ans85.UserId = user.Id;
                ans85.AnsMonth = ansMonth; ans85.SRId = sR.Id;
            }
            //  วิธีแก้ปัญหา 1 :   
            var ans86 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1104).FirstOrDefault();
            if (ans86 == null)
            {
                Answer answer63_ = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox1.Value,
                    QuestionId = 1104,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer63_);
            }
            else
            {
                ans86.AnsDes = this.howtoSolveTextbox1.Value;
                ans86.AnserTypeId = 1;
                ans86.CreateDate = DateTime.Now;
                ans86.QuestionId = 1104;
                ans86.UserId = user.Id;
                ans86.AnsMonth = ansMonth; ans86.SRId = sR.Id;
            }


            //  ปัญหาที่พบ 2 :  
            var ans87 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1105).FirstOrDefault();
            if (ans87 == null)
            {
                Answer answer64_ = new Answer()
                {
                    AnsDes = this.problemTextbox2.Value,
                    QuestionId = 1105,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer64_);
            }
            else
            {
                ans87.AnsDes = this.problemTextbox2.Value;
                ans87.AnserTypeId = 1;
                ans87.CreateDate = DateTime.Now;
                ans87.QuestionId = 1105;
                ans87.UserId = user.Id;
                ans87.AnsMonth = ansMonth; ans87.SRId = sR.Id;
            }

            //  วิธีแก้ปัญหา 2 :   
            var ans65 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1106).FirstOrDefault();
            if (ans65 == null)
            {
                Answer answer65_ = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox2.Value,
                    QuestionId = 1106,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer65_);
            }
            else
            {
                ans65.AnsDes = this.howtoSolveTextbox2.Value;
                ans65.AnserTypeId = 1;
                ans65.CreateDate = DateTime.Now;
                ans65.QuestionId = 1106;
                ans65.UserId = user.Id;
                ans65.AnsMonth = ansMonth; ans65.SRId = sR.Id;
            }


            //  ปัญหาที่พบ 3 :    
            var ans66 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1107).FirstOrDefault();
            if (ans66 == null)
            {
                Answer answer66 = new Answer()
                {
                    AnsDes = this.problemTextbox3.Value,
                    QuestionId = 1107,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer66);
            }
            else
            {
                ans66.AnsDes = this.problemTextbox3.Value;
                ans66.AnserTypeId = 1;
                ans66.CreateDate = DateTime.Now;
                ans66.QuestionId = 1107;
                ans66.UserId = user.Id;
                ans66.AnsMonth = ansMonth; ans66.SRId = sR.Id;
            }
            //  วิธีแก้ปัญหา 3 :   
            var ans67 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1108).FirstOrDefault();
            if (ans67 == null)
            {
                Answer answer67 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox3.Value,
                    QuestionId = 1108,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer67);
            }
            else
            {

                ans67.AnsDes = this.howtoSolveTextbox3.Value;
                ans67.AnserTypeId = 1;
                ans67.CreateDate = DateTime.Now;
                ans67.QuestionId = 1108;
                ans67.UserId = user.Id;
                ans67.AnsMonth = ansMonth; ans67.SRId = sR.Id;
            }


            //  ปัญหาที่พบ 4 :    
            var ans68 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1109).FirstOrDefault();
            if (ans68 == null)
            {
                Answer answer68 = new Answer()
                {
                    AnsDes = this.problemTextbox4.Value,
                    QuestionId = 1109,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer68);
            }
            else
            {
                ans68.AnsDes = this.problemTextbox4.Value;
                ans68.AnserTypeId = 1;
                ans68.CreateDate = DateTime.Now;
                ans68.QuestionId = 1109;
                ans68.UserId = user.Id;
                ans68.AnsMonth = ansMonth; ans68.SRId = sR.Id;
            }

            //  วิธีแก้ปัญหา 4 :        
            var ans69 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1110).FirstOrDefault();
            if (ans69 == null)
            {
                Answer answer69 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox4.Value,
                    QuestionId = 1110,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer69);
            }
            else
            {
                ans69.AnsDes = this.howtoSolveTextbox4.Value;
                ans69.AnserTypeId = 1;
                ans69.CreateDate = DateTime.Now;
                ans69.QuestionId = 1110;
                ans69.UserId = user.Id;
                ans69.AnsMonth = ansMonth; ans69.SRId = sR.Id;
            }




            //  ปัญหาที่พบ 5 :  
            var ans70 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1111).FirstOrDefault();
            if (ans70 == null)
            {
                Answer answer70 = new Answer()
                {
                    AnsDes = this.problemTextbox5.Value,
                    QuestionId = 1111,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer70);
            }
            else
            {
                ans70.AnsDes = this.problemTextbox5.Value;
                ans70.AnserTypeId = 1;
                ans70.CreateDate = DateTime.Now;
                ans70.QuestionId = 1111;
                ans70.UserId = user.Id;
                ans70.AnsMonth = ansMonth; ans70.SRId = sR.Id;
            }

            //  วิธีแก้ปัญหา 5 :  
            var ans71 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1112).FirstOrDefault();
            if (ans71 == null)
            {
                Answer answer71 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox5.Value,
                    QuestionId = 1112,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer71);
            }
            else
            {
                ans71.AnsDes = this.howtoSolveTextbox5.Value;
                ans71.AnserTypeId = 1;
                ans71.CreateDate = DateTime.Now;
                ans71.QuestionId = 1112;
                ans71.UserId = user.Id;
                ans71.AnsMonth = ansMonth; ans71.SRId = sR.Id;
            }

            //  ปัญหาที่พบ 6 :  
            var ans72 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1113).FirstOrDefault();
            if (ans72 == null)
            {
                Answer answer72 = new Answer()
                {
                    AnsDes = this.problemTextbox6.Value,
                    QuestionId = 1113,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer72);
            }
            else
            {
                ans72.AnsDes = this.problemTextbox6.Value;
                ans72.AnserTypeId = 1;
                ans72.CreateDate = DateTime.Now;
                ans72.QuestionId = 1113;
                ans72.UserId = user.Id;
                ans72.AnsMonth = ansMonth; ans72.SRId = sR.Id;
            }
            //  วิธีแก้ปัญหา 6 :
            var ans73 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1114).FirstOrDefault();
            if (ans73 == null)
            {
                Answer answer73 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox6.Value,
                    QuestionId = 1114,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer73);
            }
            else
            {
                ans73.AnsDes = this.howtoSolveTextbox6.Value;
                ans73.AnserTypeId = 1;
                ans73.CreateDate = DateTime.Now;
                ans73.QuestionId = 1114;
                ans73.UserId = user.Id;
                ans73.AnsMonth = ansMonth; ans73.SRId = sR.Id;
            }
            //  ปัญหาที่พบ 7 :   
            var ans74 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1115).FirstOrDefault();
            if (ans74 == null)
            {

                Answer answer74 = new Answer()
                {
                    AnsDes = this.problemTextbox7.Value,
                    QuestionId = 1115,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer74);
            }
            else
            {
                ans74.AnsDes = this.problemTextbox7.Value;
                ans74.AnserTypeId = 1;
                ans74.CreateDate = DateTime.Now;
                ans74.QuestionId = 1115;
                ans74.UserId = user.Id;
                ans74.AnsMonth = ansMonth; ans74.SRId = sR.Id;
            }
            //  วิธีแก้ปัญหา 7 :    
            var ans75 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1116).FirstOrDefault();
            if (ans75 == null)
            {
                Answer answer75 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox7.Value,
                    QuestionId = 1116,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer75);
            }
            else
            {
                ans75.AnsDes = this.howtoSolveTextbox7.Value;
                ans75.AnserTypeId = 1;
                ans75.CreateDate = DateTime.Now;
                ans75.QuestionId = 1116;
                ans75.UserId = user.Id;
                ans75.AnsMonth = ansMonth; ans75.SRId = sR.Id;
            }


            ///////////////////////////////////////////////////////////////////////////////
            //  ปัญหาที่พบ 8 :      
            var ans76 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1117).FirstOrDefault();
            if (ans76 == null)
            {
                Answer answer76 = new Answer()
                {
                    AnsDes = this.problemTextbox8.Value,
                    QuestionId = 1117,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer76);
            }
            else
            {
                ans76.AnsDes = this.problemTextbox8.Value;
                ans76.AnserTypeId = 1;
                ans76.CreateDate = DateTime.Now;
                ans76.QuestionId = 1117;
                ans76.UserId = user.Id;
                ans76.AnsMonth = ansMonth; ans76.SRId = sR.Id;
            }
            //  วิธีแก้ปัญหา 8 : 
            var ans77 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1118).FirstOrDefault();
            if (ans77 == null)
            {
                Answer answer77 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox8.Value,
                    QuestionId = 1118,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer77);
            }
            else
            {
                ans77.AnsDes = this.howtoSolveTextbox8.Value;
                ans77.AnserTypeId = 1;
                ans77.CreateDate = DateTime.Now;
                ans77.QuestionId = 1118;
                ans77.UserId = user.Id;
                ans77.AnsMonth = ansMonth; ans77.SRId = sR.Id;
            }
            //////////////////////////////////////////////////////////////////////////////////



            ///////////////////////////////////////////////////////////////////////////////
            //  ปัญหาที่พบ 9 :     
            var ans78 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1119).FirstOrDefault();
            if (ans78 == null)
            {
                Answer answer78 = new Answer()
                {
                    AnsDes = this.problemTextbox9.Value,
                    QuestionId = 1119,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer78);
            }
            else
            {
                ans78.AnsDes = this.problemTextbox9.Value;
                ans78.AnserTypeId = 1;
                ans78.CreateDate = DateTime.Now;
                ans78.QuestionId = 1119;
                ans78.UserId = user.Id;
                ans78.AnsMonth = ansMonth; ans78.SRId = sR.Id;
            }
            //  วิธีแก้ปัญหา 9 :  
            var ans79 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1120).FirstOrDefault();
            if (ans79 == null)
            {
                Answer answer79 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox9.Value,
                    QuestionId = 1120,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer79);
            }
            else
            {
                ans79.AnsDes = this.howtoSolveTextbox9.Value;
                ans79.AnserTypeId = 1;
                ans79.CreateDate = DateTime.Now;
                ans79.QuestionId = 1120;
                ans79.UserId = user.Id;
                ans79.AnsMonth = ansMonth; ans79.SRId = sR.Id;
            }
            //////////////////////////////////////////////////////////////////////////////////



            ///////////////////////////////////////////////////////////////////////////////
            //  ปัญหาที่พบ 10 :   
            var ans80 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1121).FirstOrDefault();
            if (ans80 == null)
            {
                Answer answer80 = new Answer()
                {
                    AnsDes = this.problemTextbox10.Value,
                    QuestionId = 1121,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer80);
            }
            else
            {
                ans80.AnsDes = this.problemTextbox10.Value;
                ans80.AnserTypeId = 1;
                ans80.CreateDate = DateTime.Now;
                ans80.QuestionId = 1121;
                ans80.UserId = user.Id;
                ans80.AnsMonth = ansMonth; ans80.SRId = sR.Id;
            }
            //  วิธีแก้ปัญหา 10 :  
            var ans81 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1122).FirstOrDefault();
            if (ans81 == null)
            {
                Answer answer81 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox10.Value,
                    QuestionId = 1122,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer81);
            }
            else
            {
                ans81.AnsDes = this.howtoSolveTextbox10.Value;
                ans81.AnserTypeId = 1;
                ans81.CreateDate = DateTime.Now;
                ans81.QuestionId = 1122;
                ans81.UserId = user.Id;
                ans81.AnsMonth = ansMonth; ans81.SRId = sR.Id;
            }
            //////////////////////////////////////////////////////////////////////////////////
            ///




            ///////////////////////////////////////////////////////////////////////////////
            //  ปัญหาที่พบ 11 : 
            var ans82 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1123).FirstOrDefault();
            if (ans82 == null)
            {
                Answer answer82 = new Answer()
                {
                    AnsDes = this.problemTextbox11.Value,
                    QuestionId = 1123,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer82);
            }
            else
            {
                ans82.AnsDes = this.problemTextbox11.Value;
                ans82.AnserTypeId = 1;
                ans82.CreateDate = DateTime.Now;
                ans82.QuestionId = 1123;
                ans82.UserId = user.Id;
                ans82.AnsMonth = ansMonth; ans82.SRId = sR.Id;
            }

            //  วิธีแก้ปัญหา 11 :  
            var ans83 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1124).FirstOrDefault();
            if (ans83 == null)
            {
                Answer answer83 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox11.Value,
                    QuestionId = 1124,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer83);
            }
            else
            {
                ans83.AnsDes = this.howtoSolveTextbox11.Value;
                ans83.AnserTypeId = 1;
                ans83.CreateDate = DateTime.Now;
                ans83.QuestionId = 1124;
                ans83.UserId = user.Id;
                ans83.AnsMonth = ansMonth; ans83.SRId = sR.Id;
            }
            //////////////////////////////////////////////////////////////////////////////////
            ///






            ///////////////////////////////////////////////////////////////////////////////
            //  ปัญหาที่พบ 12 :   
            var ans84 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1125).FirstOrDefault();
            if (ans84 == null)
            {
                Answer answer84 = new Answer()
                {
                    AnsDes = this.problemTextbox12.Value,
                    QuestionId = 1125,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer84);
            }
            else
            {
                ans84.AnsDes = this.problemTextbox12.Value;
                ans84.AnserTypeId = 1;
                ans84.CreateDate = DateTime.Now;
                ans84.QuestionId = 1125;
                ans84.UserId = user.Id;
                ans84.AnsMonth = ansMonth; ans84.SRId = sR.Id;
            }

            //  วิธีแก้ปัญหา 12 :    
            var ans85_ = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1126).FirstOrDefault();
            if (ans85_ == null)
            {
                Answer answer85 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox12.Value,
                    QuestionId = 1126,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer85);
            }
            else
            {
                ans85_.AnsDes = this.howtoSolveTextbox12.Value;
                ans85_.AnserTypeId = 1;
                ans85_.CreateDate = DateTime.Now;
                ans85_.QuestionId = 1126;
                ans85_.UserId = user.Id;
                ans85_.AnsMonth = ansMonth; ans85_.SRId = sR.Id;
            }
            //////////////////////////////////////////////////////////////////////////////////
            ///




            ///////////////////////////////////////////////////////////////////////////////
            //  ปัญหาที่พบ 13 : 
            var ans86_ = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1127).FirstOrDefault();
            if (ans86_ == null)
            {
                Answer answer86 = new Answer()
                {
                    AnsDes = this.problemTextbox13.Value,
                    QuestionId = 1127,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer86);
            }
            else
            {
                ans86_.AnsDes = this.problemTextbox13.Value;
                ans86_.AnserTypeId = 1;
                ans86_.CreateDate = DateTime.Now;
                ans86_.QuestionId = 1127;
                ans86_.UserId = user.Id;
                ans86_.AnsMonth = ansMonth; ans86_.SRId = sR.Id;
            }

            //  วิธีแก้ปัญหา 13 :    
            var ans87_ = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1128).FirstOrDefault();
            if (ans87_ == null)
            {
                Answer answer87 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox13.Value,
                    QuestionId = 1128,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer87);
            }
            else
            {
                ans87_.AnsDes = this.howtoSolveTextbox13.Value;
                ans87_.AnserTypeId = 1;
                ans87_.CreateDate = DateTime.Now;
                ans87_.QuestionId = 1128;
                ans87_.UserId = user.Id;
                ans87_.AnsMonth = ansMonth; ans87_.SRId = sR.Id;
            }
            //////////////////////////////////////////////////////////////////////////////////
            ///



            ///////////////////////////////////////////////////////////////////////////////
            //  ปัญหาที่พบ 14 : 
            var ans88 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1129).FirstOrDefault();
            if (ans88 == null)
            {
                Answer answer88 = new Answer()
                {
                    AnsDes = this.problemTextbox14.Value,
                    QuestionId = 1129,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer88);
            }
            else
            {
                ans88.AnsDes = this.problemTextbox14.Value;
                ans88.AnserTypeId = 1;
                ans88.CreateDate = DateTime.Now;
                ans88.QuestionId = 1129;
                ans88.UserId = user.Id;
                ans88.AnsMonth = ansMonth; ans88.SRId = sR.Id;
            }
            //  วิธีแก้ปัญหา 14 :         
            var ans89 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1130).FirstOrDefault();
            if (ans89 == null)
            {
                Answer answer89 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox14.Value,
                    QuestionId = 1130,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer89);
            }
            else
            {
                ans89.AnsDes = this.howtoSolveTextbox14.Value;
                ans89.AnserTypeId = 1;
                ans89.CreateDate = DateTime.Now;
                ans89.QuestionId = 1130;
                ans89.UserId = user.Id;
                ans89.AnsMonth = ansMonth; ans89.SRId = sR.Id;
            }
            //////////////////////////////////////////////////////////////////////////////////
            ///




            ///////////////////////////////////////////////////////////////////////////////
            //  ปัญหาที่พบ 15 :  
            var ans90 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1131).FirstOrDefault();
            if (ans90 == null)
            {
                Answer answer90 = new Answer()

                {
                    AnsDes = this.problemTextbox15.Value,
                    QuestionId = 1131,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer90);
            }
            else
            {
                ans90.AnsDes = this.problemTextbox15.Value;
                ans90.AnserTypeId = 1;
                ans90.CreateDate = DateTime.Now;
                ans90.QuestionId = 1131;
                ans90.UserId = user.Id;
                ans90.AnsMonth = ansMonth; ans90.SRId = sR.Id;
            }

            //  วิธีแก้ปัญหา 15 :  
            var ans91 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1132).FirstOrDefault();
            if (ans91 == null)
            {
                Answer answer91 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox15.Value,
                    QuestionId = 1132,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer91);
            }
            else
            {
                ans91.AnsDes = this.howtoSolveTextbox15.Value;
                ans91.AnserTypeId = 1;
                ans91.CreateDate = DateTime.Now;
                ans91.QuestionId = 1132;
                ans91.UserId = user.Id;
                ans91.AnsMonth = ansMonth; ans91.SRId = sR.Id;
            }
            //////////////////////////////////////////////////////////////////////////////////
            ///
            //////////////////////////////////////////////////////////////////////////////////
            ///



            //////////////////////////////////////////////////////////////////////////////////
            // รายการอุปกรณ์ 1 :      
            var ans92 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1133).FirstOrDefault();
            if (ans92 == null)
            {
                Answer answer156 = new Answer()
                {
                    AnsDes = this.toolsListTextbox1.Value,
                    QuestionId = 1133,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer156);
            }
            else
            {
                ans92.AnsDes = this.toolsListTextbox1.Value;
                ans92.AnserTypeId = 1;
                ans92.CreateDate = DateTime.Now;
                ans92.QuestionId = 1133;
                ans92.UserId = user.Id;
                ans92.AnsMonth = ansMonth; ans92.SRId = sR.Id;
            }

            //  SerialNumber :   
            var ans93 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1134).FirstOrDefault();
            if (ans93 == null)
            {
                Answer answer157 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox1.Value,
                    QuestionId = 1134,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer157);
            }
            else
            {
                ans93.AnsDes = this.serialNumberTextbox1.Value;
                ans93.AnserTypeId = 1;
                ans93.CreateDate = DateTime.Now;
                ans93.QuestionId = 1134;
                ans93.UserId = user.Id;
                ans93.AnsMonth = ansMonth; ans93.SRId = sR.Id;
            }

            //  new SerialNumber :  
            var ans94 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1135).FirstOrDefault();
            if (ans94 == null)
            {
                Answer answer158 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox1.Value,
                    QuestionId = 1135,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer158);
            }
            else
            {
                ans94.AnsDes = this.newSerialNumberTextbox1.Value;
                ans94.AnserTypeId = 1;
                ans94.CreateDate = DateTime.Now;
                ans94.QuestionId = 1135;
                ans94.UserId = user.Id;
                ans94.AnsMonth = ansMonth; ans94.SRId = sR.Id;
            }

            //  หมายเหตุ :  
            var ans95 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1136).FirstOrDefault();
            if (ans95 == null)
            {
                Answer answer159 = new Answer()
                {
                    AnsDes = this.noteTextbox1.Value,
                    QuestionId = 1136,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer159);
            }
            else
            {
                ans95.AnsDes = this.noteTextbox1.Value;
                ans95.AnserTypeId = 1;
                ans95.CreateDate = DateTime.Now;
                ans95.QuestionId = 1136;
                ans95.UserId = user.Id;
                ans95.AnsMonth = ansMonth; ans95.SRId = sR.Id;
            }
            //////////////////////////////////////////////////////////////////////////////////






            //////////////////////////////////////////////////////////////////////////////////
            // รายการอุปกรณ์ 2 :  
            var ans96 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1137).FirstOrDefault();
            if (ans96 == null)
            {
                Answer answer160 = new Answer()
                {
                    AnsDes = this.toolsListTextbox2.Value,
                    QuestionId = 1137,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer160);
            }
            else
            {
                ans96.AnsDes = this.toolsListTextbox2.Value;
                ans96.AnserTypeId = 1;
                ans96.CreateDate = DateTime.Now;
                ans96.QuestionId = 1137;
                ans96.UserId = user.Id;
                ans96.AnsMonth = ansMonth; ans96.SRId = sR.Id;
            }

            //  SerialNumber 2 :    
            var ans97 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1138).FirstOrDefault();
            if (ans97 == null)
            {
                Answer answer161 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox2.Value,
                    QuestionId = 1138,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer161);
            }
            else
            {
                ans97.AnsDes = this.serialNumberTextbox2.Value;
                ans97.AnserTypeId = 1;
                ans97.CreateDate = DateTime.Now;
                ans97.QuestionId = 1138;
                ans97.UserId = user.Id;
                ans97.AnsMonth = ansMonth; ans97.SRId = sR.Id;
            }
            //  new SerialNumber 2 :         
            var ans98 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1139).FirstOrDefault();
            if (ans98 == null)
            {
                Answer answer162 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox2.Value,
                    QuestionId = 1139,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer162);
            }
            else
            {

                ans98.AnsDes = this.newSerialNumberTextbox2.Value;
                ans98.AnserTypeId = 1;
                ans98.CreateDate = DateTime.Now;
                ans98.QuestionId = 1139;
                ans98.UserId = user.Id;
                ans98.AnsMonth = ansMonth; ans98.SRId = sR.Id;
            }

            //  หมายเหตุ  2:           
            var ans99 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1140).FirstOrDefault();
            if (ans99 == null)
            {
                Answer answer163 = new Answer()
                {
                    AnsDes = this.noteTextbox2.Value,
                    QuestionId = 1140,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer163);
            }
            else
            {
                ans99.AnsDes = this.noteTextbox2.Value;
                ans99.AnserTypeId = 1;
                ans99.CreateDate = DateTime.Now;
                ans99.QuestionId = 1140;
                ans99.UserId = user.Id;
                ans99.AnsMonth = ansMonth; ans99.SRId = sR.Id;
            }
            //////////////////////////////////////////////////////////////////////////////////



            //////////////////////////////////////////////////////////////////////////////////
            // รายการอุปกรณ์ 3 :   
            var ans100 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1141).FirstOrDefault();
            if (ans100 == null)
            {
                Answer answer164 = new Answer()
                {
                    AnsDes = this.toolsListTextbox3.Value,
                    QuestionId = 1141,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer164);
            }
            else
            {
                ans100.AnsDes = this.toolsListTextbox3.Value;
                ans100.AnserTypeId = 1;
                ans100.CreateDate = DateTime.Now;
                ans100.QuestionId = 1141;
                ans100.UserId = user.Id;
                ans100.AnsMonth = ansMonth; ans100.SRId = sR.Id;
            }

            //  SerialNumber 3 :  
            var ans101 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1142).FirstOrDefault();
            if (ans101 == null)
            {
                Answer answer165 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox3.Value,
                    QuestionId = 1142,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer165);
            }
            else
            {
                ans101.AnsDes = this.serialNumberTextbox3.Value;
                ans101.AnserTypeId = 1;
                ans101.CreateDate = DateTime.Now;
                ans101.QuestionId = 1142;
                ans101.UserId = user.Id;
                ans101.AnsMonth = ansMonth; ans101.SRId = sR.Id;
            }

            //  new SerialNumber 3 : 
            var ans102 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1143).FirstOrDefault();
            if (ans102 == null)
            {
                Answer answer166 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox3.Value,
                    QuestionId = 1143,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer166);
            }
            else
            {
                ans102.AnsDes = this.newSerialNumberTextbox3.Value;
                ans102.AnserTypeId = 1;
                ans102.CreateDate = DateTime.Now;
                ans102.QuestionId = 1143;
                ans102.UserId = user.Id;
                ans102.AnsMonth = ansMonth; ans102.SRId = sR.Id;
            }

            //  หมายเหตุ  3:     
            var ans103 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1144).FirstOrDefault();
            if (ans103 == null)
            {
                Answer answer167 = new Answer()
                {
                    AnsDes = this.noteTextbox3.Value,
                    QuestionId = 1144,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer167);
            }
            else
            {
                ans103.AnsDes = this.noteTextbox3.Value;
                ans103.AnserTypeId = 1;
                ans103.CreateDate = DateTime.Now;
                ans103.QuestionId = 1144;
                ans103.UserId = user.Id;
                ans103.AnsMonth = ansMonth; ans103.SRId = sR.Id;
            }
            //////////////////////////////////////////////////////////////////////////////////




            //////////////////////////////////////////////////////////////////////////////////
            // รายการอุปกรณ์ 4 :
            var ans104 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1145).FirstOrDefault();
            if (ans104 == null)
            {
                Answer answer168 = new Answer()
                {
                    AnsDes = this.toolsListTextbox4.Value,
                    QuestionId = 1145,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer168);
            }
            else
            {
                ans104.AnsDes = this.toolsListTextbox4.Value;
                ans104.AnserTypeId = 1;
                ans104.CreateDate = DateTime.Now;
                ans104.QuestionId = 1145;
                ans104.UserId = user.Id;
                ans104.AnsMonth = ansMonth; ans104.SRId = sR.Id;
            }

            //  SerialNumber 4 :      
            var ans105 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1146).FirstOrDefault();
            if (ans105 == null)
            {
                Answer answer169 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox4.Value,
                    QuestionId = 1146,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer169);
            }
            else
            {
                ans105.AnsDes = this.serialNumberTextbox4.Value;
                ans105.AnserTypeId = 1;
                ans105.CreateDate = DateTime.Now;
                ans105.QuestionId = 1146;
                ans105.UserId = user.Id;
                ans105.AnsMonth = ansMonth; ans105.SRId = sR.Id;
            }

            //  new SerialNumber 4 :   
            var ans106 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1147).FirstOrDefault();
            if (ans106 == null)
            {
                Answer answer170 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox4.Value,
                    QuestionId = 1147,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer170);
            }
            else
            {
                ans106.AnsDes = this.newSerialNumberTextbox4.Value;
                ans106.AnserTypeId = 1;
                ans106.CreateDate = DateTime.Now;
                ans106.QuestionId = 1147;
                ans106.UserId = user.Id;
                ans106.AnsMonth = ansMonth; ans106.SRId = sR.Id;
            }

            //  หมายเหตุ  4:
            var ans107 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1148).FirstOrDefault();
            if (ans107 == null)
            {
                Answer answer171 = new Answer()
                {
                    AnsDes = this.noteTextbox4.Value,
                    QuestionId = 1148,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer171);
            }
            else
            {
                ans107.AnsDes = this.noteTextbox4.Value;
                ans107.AnserTypeId = 1;
                ans107.CreateDate = DateTime.Now;
                ans107.QuestionId = 1148;
                ans107.UserId = user.Id;
                ans107.AnsMonth = ansMonth; ans107.SRId = sR.Id;
            }
            //////////////////////////////////////////////////////////////////////////////////




            //////////////////////////////////////////////////////////////////////////////////
            // รายการอุปกรณ์ 5 : 
            var ans108 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1149).FirstOrDefault();
            if (ans108 == null)
            {
                Answer answer172 = new Answer()
                {
                    AnsDes = this.toolsListTextbox5.Value,
                    QuestionId = 1149,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer172);
            }
            else
            {
                ans108.AnsDes = this.toolsListTextbox5.Value;
                ans108.AnserTypeId = 1;
                ans108.CreateDate = DateTime.Now;
                ans108.QuestionId = 1149;
                ans108.UserId = user.Id;
                ans108.AnsMonth = ansMonth; ans108.SRId = sR.Id;
            }

            //  SerialNumber 5 :   
            var ans109 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1150).FirstOrDefault();
            if (ans109 == null)
            {
                Answer answer173 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox5.Value,
                    QuestionId = 1150,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer173);
            }
            else
            {
                ans109.AnsDes = this.serialNumberTextbox5.Value;
                ans109.AnserTypeId = 1;
                ans109.CreateDate = DateTime.Now;
                ans109.QuestionId = 1150;
                ans109.UserId = user.Id;
                ans109.AnsMonth = ansMonth; ans109.SRId = sR.Id;
            }

            //  new SerialNumber 5 : 
            var ans110 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1151).FirstOrDefault();
            if (ans110 == null)
            {
                Answer answer174 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox5.Value,
                    QuestionId = 1151,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer174);
            }
            else
            {
                ans110.AnsDes = this.newSerialNumberTextbox5.Value;
                ans110.AnserTypeId = 1;
                ans110.CreateDate = DateTime.Now;
                ans110.QuestionId = 1151;
                ans110.UserId = user.Id;
                ans110.AnsMonth = ansMonth; ans110.SRId = sR.Id;
            }

            //  หมายเหตุ  5:  
            var ans111 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1152).FirstOrDefault();
            if (ans111 == null)
            {
                Answer answer175 = new Answer()
                {
                    AnsDes = this.noteTextbox5.Value,
                    QuestionId = 1152,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer175);
            }
            else
            {
                ans111.AnsDes = this.noteTextbox5.Value;
                ans111.AnserTypeId = 1;
                ans111.CreateDate = DateTime.Now;
                ans111.QuestionId = 1152;
                ans111.UserId = user.Id;
                ans111.AnsMonth = ansMonth; ans111.SRId = sR.Id;
            }
            //////////////////////////////////////////////////////////////////////////////////






            //////////////////////////////////////////////////////////////////////////////////
            // รายการอุปกรณ์ 6 :  
            var ans112 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1153).FirstOrDefault();
            if (ans112 == null)
            {
                Answer answer176 = new Answer()
                {
                    AnsDes = this.toolsListTextbox6.Value,
                    QuestionId = 1153,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer176);
            }
            else
            {
                ans112.AnsDes = this.toolsListTextbox6.Value;
                ans112.AnserTypeId = 1;
                ans112.CreateDate = DateTime.Now;
                ans112.QuestionId = 1153;
                ans112.UserId = user.Id;
                ans112.AnsMonth = ansMonth; ans112.SRId = sR.Id;
            }

            //  SerialNumber 6 :   
            var ans113 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1154).FirstOrDefault();
            if (ans113 == null)
            {
                Answer answer177 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox6.Value,
                    QuestionId = 1154,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer177);
            }
            else
            {
                ans113.AnsDes = this.serialNumberTextbox6.Value;
                ans113.AnserTypeId = 1;
                ans113.CreateDate = DateTime.Now;
                ans113.QuestionId = 1154;
                ans113.UserId = user.Id;
                ans113.AnsMonth = ansMonth; ans113.SRId = sR.Id;
            }

            //  new SerialNumber 6 :           
            var ans114 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1155).FirstOrDefault();
            if (ans114 == null)
            {
                Answer answer178 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox6.Value,
                    QuestionId = 1155,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer178);
            }
            else
            {
                ans114.AnsDes = this.newSerialNumberTextbox6.Value;
                ans114.AnserTypeId = 1;
                ans114.CreateDate = DateTime.Now;
                ans114.QuestionId = 1155;
                ans114.UserId = user.Id;
                ans114.AnsMonth = ansMonth; ans114.SRId = sR.Id;
            }

            //  หมายเหตุ  6:   
            var ans115 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1156).FirstOrDefault();
            if (ans115 == null)
            {
                Answer answer179 = new Answer()
                {
                    AnsDes = this.noteTextbox6.Value,
                    QuestionId = 1156,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer179);
            }
            else
            {
                ans115.AnsDes = this.noteTextbox6.Value;
                ans115.AnserTypeId = 1;
                ans115.CreateDate = DateTime.Now;
                ans115.QuestionId = 1156;
                ans115.UserId = user.Id;
                ans115.AnsMonth = ansMonth; ans115.SRId = sR.Id;
            }
            //////////////////////////////////////////////////////////////////////////////////




            //////////////////////////////////////////////////////////////////////////////////
            // รายการอุปกรณ์ 7 :      
            var ans116 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1157).FirstOrDefault();
            if (ans116 == null)
            {
                Answer answer180 = new Answer()
                {
                    AnsDes = this.toolsListTextbox7.Value,
                    QuestionId = 1157,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer180);
            }
            else
            {
                ans116.AnsDes = this.toolsListTextbox7.Value;
                ans116.AnserTypeId = 1;
                ans116.CreateDate = DateTime.Now;
                ans116.QuestionId = 1157;
                ans116.UserId = user.Id;
                ans116.AnsMonth = ansMonth; ans116.SRId = sR.Id;
            }

            //  SerialNumber 7 :  
            var ans117 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1158).FirstOrDefault();
            if (ans117 == null)
            {
                Answer answer181 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox7.Value,
                    QuestionId = 1158,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer181);
            }
            else
            {
                ans117.AnsDes = this.serialNumberTextbox7.Value;
                ans117.AnserTypeId = 1;
                ans117.CreateDate = DateTime.Now;
                ans117.QuestionId = 1158;
                ans117.UserId = user.Id;
                ans117.AnsMonth = ansMonth; ans117.SRId = sR.Id;
            }

            //  new SerialNumber 7 :  
            var ans118 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1159).FirstOrDefault();
            if (ans118 == null)
            {
                Answer answer182 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox7.Value,
                    QuestionId = 1159,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer182);
            }
            else
            {
                ans118.AnsDes = this.newSerialNumberTextbox7.Value;
                ans118.AnserTypeId = 1;
                ans118.CreateDate = DateTime.Now;
                ans118.QuestionId = 1159;
                ans118.UserId = user.Id;
                ans118.AnsMonth = ansMonth; ans118.SRId = sR.Id;
            }

            //  หมายเหตุ  7:  
            var ans119 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1160).FirstOrDefault();
            if (ans119 == null)
            {
                Answer answer183 = new Answer()
                {
                    AnsDes = this.noteTextbox7.Value,
                    QuestionId = 1160,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer183);
            }
            else
            {
                ans119.AnsDes = this.noteTextbox7.Value;
                ans119.AnserTypeId = 1;
                ans119.CreateDate = DateTime.Now;
                ans119.QuestionId = 1160;
                ans119.UserId = user.Id;
                ans119.AnsMonth = ansMonth; ans119.SRId = sR.Id;
            }
            //////////////////////////////////////////////////////////////////////////////////



            //////////////////////////////////////////////////////////////////////////////////
            // รายการอุปกรณ์ 8 :  
            var ans120 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1161).FirstOrDefault();
            if (ans120 == null)
            {
                Answer answer184 = new Answer()
                {
                    AnsDes = this.toolsListTextbox8.Value,
                    QuestionId = 1161,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer184);
            }
            else
            {
                ans120.AnsDes = this.toolsListTextbox8.Value;
                ans120.AnserTypeId = 1;
                ans120.CreateDate = DateTime.Now;
                ans120.QuestionId = 1161;
                ans120.UserId = user.Id;
                ans120.AnsMonth = ansMonth; ans120.SRId = sR.Id;
            }

            //  SerialNumber 8 :    
            var ans121 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1162).FirstOrDefault();
            if (ans121 == null)
            {
                Answer answer185 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox8.Value,
                    QuestionId = 1162,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer185);
            }
            else
            {
                ans121.AnsDes = this.serialNumberTextbox8.Value;
                ans121.AnserTypeId = 1;
                ans121.CreateDate = DateTime.Now;
                ans121.QuestionId = 1162;
                ans121.UserId = user.Id;
                ans121.AnsMonth = ansMonth; ans121.SRId = sR.Id;
            }

            //  new SerialNumber 8 :    
            var ans122 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1163).FirstOrDefault();
            if (ans122 == null)
            {
                Answer answer186 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox8.Value,
                    QuestionId = 1163,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer186);
            }
            else
            {
                ans122.AnsDes = this.newSerialNumberTextbox8.Value;
                ans122.AnserTypeId = 1;
                ans122.CreateDate = DateTime.Now;
                ans122.QuestionId = 1163;
                ans122.UserId = user.Id;
                ans122.AnsMonth = ansMonth; ans122.SRId = sR.Id;
            }

            //  หมายเหตุ  8:          
            var ans123 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1164).FirstOrDefault();
            if (ans123 == null)
            {
                Answer answer187 = new Answer()
                {
                    AnsDes = this.noteTextbox8.Value,
                    QuestionId = 1164,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer187);
            }
            else
            {
                ans123.AnsDes = this.noteTextbox8.Value;
                ans123.AnserTypeId = 1;
                ans123.CreateDate = DateTime.Now;
                ans123.QuestionId = 1164;
                ans123.UserId = user.Id;
                ans123.AnsMonth = ansMonth; ans123.SRId = sR.Id;
            }
            //////////////////////////////////////////////////////////////////////////////////



            //////////////////////////////////////////////////////////////////////////////////
            // รายการอุปกรณ์ 9 :   
            var ans124 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1165).FirstOrDefault();
            if (ans124 == null)
            {
                Answer answer188 = new Answer()
                {
                    AnsDes = this.toolsListTextbox9.Value,
                    QuestionId = 1165,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer188);
            }
            else
            {
                ans124.AnsDes = this.toolsListTextbox9.Value;
                ans124.AnserTypeId = 1;
                ans124.CreateDate = DateTime.Now;
                ans124.QuestionId = 1165;
                ans124.UserId = user.Id;
                ans124.AnsMonth = ansMonth; ans124.SRId = sR.Id;
            }

            //  SerialNumber 9 :      
            var ans125 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1166).FirstOrDefault();
            if (ans125 == null)
            {
                Answer answer189 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox9.Value,
                    QuestionId = 1166,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer189);
            }
            else
            {
                ans125.AnsDes = this.serialNumberTextbox9.Value;
                ans125.AnserTypeId = 1;
                ans125.CreateDate = DateTime.Now;
                ans125.QuestionId = 1166;
                ans125.UserId = user.Id;
                ans125.AnsMonth = ansMonth; ans125.SRId = sR.Id;
            }

            //  new SerialNumber 9 :      
            var ans126 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1167).FirstOrDefault();
            if (ans126 == null)
            {
                Answer answer190 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox9.Value,
                    QuestionId = 1167,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer190);
            }
            else
            {
                ans126.AnsDes = this.newSerialNumberTextbox9.Value;
                ans126.AnserTypeId = 1;
                ans126.CreateDate = DateTime.Now;
                ans126.QuestionId = 1167;
                ans126.UserId = user.Id;
                ans126.AnsMonth = ansMonth; ans126.SRId = sR.Id;
            }

            //  หมายเหตุ  9:     
            var ans127 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1168).FirstOrDefault();
            if (ans127 == null)
            {
                Answer answer191 = new Answer()
                {
                    AnsDes = this.noteTextbox9.Value,
                    QuestionId = 1168,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer191);
            }
            else
            {
                ans127.AnsDes = this.noteTextbox9.Value;
                ans127.AnserTypeId = 1;
                ans127.CreateDate = DateTime.Now;
                ans127.QuestionId = 1168;
                ans127.UserId = user.Id;
                ans127.AnsMonth = ansMonth; ans127.SRId = sR.Id;
            }
            //////////////////////////////////////////////////////////////////////////////////










            //////////////////////////////////////////////////////////////////////////////////
            // รายการอุปกรณ์ 10 :  
            var ans128 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1169).FirstOrDefault();
            if (ans128 == null)
            {
                Answer answer192 = new Answer()
                {
                    AnsDes = this.toolsListTextbox10.Value,
                    QuestionId = 1169,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer192);
            }
            else
            {
                ans128.AnsDes = this.toolsListTextbox10.Value;
                ans128.AnserTypeId = 1;
                ans128.CreateDate = DateTime.Now;
                ans128.QuestionId = 1169;
                ans128.UserId = user.Id;
                ans128.AnsMonth = ansMonth; ans128.SRId = sR.Id;
            }

            //  SerialNumber 10 :
            var ans129 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1170).FirstOrDefault();
            if (ans129 == null)
            {
                Answer answer193 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox10.Value,
                    QuestionId = 1170,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer193);
            }
            else
            {
                ans129.AnsDes = this.serialNumberTextbox10.Value;
                ans129.AnserTypeId = 1;
                ans129.CreateDate = DateTime.Now;
                ans129.QuestionId = 1170;
                ans129.UserId = user.Id;
                ans129.AnsMonth = ansMonth; ans129.SRId = sR.Id;
            }

            //  new SerialNumber 10 :    
            var ans130 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1171).FirstOrDefault();
            if (ans130 == null)
            {
                Answer answer194 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox10.Value,
                    QuestionId = 1171,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer194);
            }
            else
            {
                ans130.AnsDes = this.newSerialNumberTextbox10.Value;
                ans130.AnserTypeId = 1;
                ans130.CreateDate = DateTime.Now;
                ans130.QuestionId = 1171;
                ans130.UserId = user.Id;
                ans130.AnsMonth = ansMonth; ans130.SRId = sR.Id;
            }

            //  หมายเหตุ  10:    
            var ans131 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1172).FirstOrDefault();
            if (ans131 == null)
            {
                Answer answer195 = new Answer()
                {
                    AnsDes = this.noteTextbox10.Value,
                    QuestionId = 1172,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer195);
            }
            else
            {
                ans131.AnsDes = this.noteTextbox10.Value;
                ans131.AnserTypeId = 1;
                ans131.CreateDate = DateTime.Now;
                ans131.QuestionId = 1172;
                ans131.UserId = user.Id;
                ans131.AnsMonth = ansMonth; ans131.SRId = sR.Id;
            }
            //////////////////////////////////////////////////////////////////////////////////






            //////////////////////////////////////////////////////////////////////////////////
            // รายการอุปกรณ์ 11 : 
            var ans132 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1173).FirstOrDefault();
            if (ans132 == null)
            {
                Answer answer196 = new Answer()
                {
                    AnsDes = this.toolsListTextbox11.Value,
                    QuestionId = 1173,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer196);
            }
            else
            {
                ans132.AnsDes = this.toolsListTextbox11.Value;
                ans132.AnserTypeId = 1;
                ans132.CreateDate = DateTime.Now;
                ans132.QuestionId = 1173;
                ans132.UserId = user.Id;
                ans132.AnsMonth = ansMonth; ans132.SRId = sR.Id;
            }

            //  SerialNumber 11 :
            var ans133 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1174).FirstOrDefault();
            if (ans133 == null)
            {
                Answer answer197 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox11.Value,
                    QuestionId = 1174,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer197);
            }
            else
            {
                ans133.AnsDes = this.serialNumberTextbox11.Value;
                ans133.AnserTypeId = 1;
                ans133.CreateDate = DateTime.Now;
                ans133.QuestionId = 1174;
                ans133.UserId = user.Id;
                ans133.AnsMonth = ansMonth; ans133.SRId = sR.Id;
            }

            //  new SerialNumber 11 :  
            var ans134 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1175).FirstOrDefault();
            if (ans134 == null)
            {
                Answer answer198 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox11.Value,
                    QuestionId = 1175,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer198);
            }
            else
            {
                ans134.AnsDes = this.newSerialNumberTextbox11.Value;
                ans134.AnserTypeId = 1;
                ans134.CreateDate = DateTime.Now;
                ans134.QuestionId = 1175;
                ans134.UserId = user.Id;
                ans134.AnsMonth = ansMonth; ans134.SRId = sR.Id;
            }

            //  หมายเหตุ  11:      
            var ans135 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1176).FirstOrDefault();
            if (ans135 == null)
            {
                Answer answer199 = new Answer()
                {
                    AnsDes = this.noteTextbox11.Value,
                    QuestionId = 1176,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer199);
            }
            else
            {
                ans135.AnsDes = this.noteTextbox11.Value;
                ans135.AnserTypeId = 1;
                ans135.CreateDate = DateTime.Now;
                ans135.QuestionId = 1176;
                ans135.UserId = user.Id;
                ans135.AnsMonth = ansMonth; ans135.SRId = sR.Id;
            }
            //////////////////////////////////////////////////////////////////////////////////
            ///








            //////////////////////////////////////////////////////////////////////////////////
            // รายการอุปกรณ์ 12 :   
            var ans136 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1177).FirstOrDefault();
            if (ans136 == null)
            {
                Answer answer200 = new Answer()
                {
                    AnsDes = this.toolsListTextbox12.Value,
                    QuestionId = 1177,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer200);
            }
            else
            {
                ans136.AnsDes = this.toolsListTextbox12.Value;
                ans136.AnserTypeId = 1;
                ans136.CreateDate = DateTime.Now;
                ans136.QuestionId = 1177;
                ans136.UserId = user.Id;
                ans136.AnsMonth = ansMonth; ans136.SRId = sR.Id;
            }

            //  SerialNumber 12 :   
            var ans137 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1178).FirstOrDefault();
            if (ans137 == null)
            {
                Answer answer201 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox12.Value,
                    QuestionId = 1178,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer201);
            }
            else
            {
                ans137.AnsDes = this.serialNumberTextbox12.Value;
                ans137.AnserTypeId = 1;
                ans137.CreateDate = DateTime.Now;
                ans137.QuestionId = 1178;
                ans137.UserId = user.Id;
                ans137.AnsMonth = ansMonth; ans137.SRId = sR.Id;
            }

            //  new SerialNumber 12 :    
            var ans138 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1179).FirstOrDefault();
            if (ans138 == null)
            {
                Answer answer202 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox12.Value,
                    QuestionId = 1179,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer202);
            }
            else
            {
                ans138.AnsDes = this.newSerialNumberTextbox12.Value;
                ans138.AnserTypeId = 1;
                ans138.CreateDate = DateTime.Now;
                ans138.QuestionId = 1179;
                ans138.UserId = user.Id;
                ans138.AnsMonth = ansMonth; ans138.SRId = sR.Id;
            }

            //  หมายเหตุ  12:     
            var ans139 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1180).FirstOrDefault();
            if (ans139 == null)
            {
                Answer answer203 = new Answer()
                {
                    AnsDes = this.noteTextbox12.Value,
                    QuestionId = 1180,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer203);
            }
            else
            {
                ans139.AnsDes = this.noteTextbox12.Value;
                ans139.AnserTypeId = 1;
                ans139.CreateDate = DateTime.Now;
                ans139.QuestionId = 1180;
                ans139.UserId = user.Id;
                ans139.AnsMonth = ansMonth; ans139.SRId = sR.Id;
            }
            //////////////////////////////////////////////////////////////////////////////////
            ///






            //////////////////////////////////////////////////////////////////////////////////
            // รายการอุปกรณ์ 13 :    
            var ans140 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1181).FirstOrDefault();
            if (ans140 == null)
            {
                Answer answer204 = new Answer()
                {
                    AnsDes = this.toolsListTextbox13.Value,
                    QuestionId = 1181,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer204);
            }
            else
            {
                ans140.AnsDes = this.toolsListTextbox13.Value;
                ans140.AnserTypeId = 1;
                ans140.CreateDate = DateTime.Now;
                ans140.QuestionId = 1181;
                ans140.UserId = user.Id;
                ans140.AnsMonth = ansMonth; ans140.SRId = sR.Id;
            }
            var ans141 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1182).FirstOrDefault();
            if (ans141 == null)
            {
                //  SerialNumber 13 :           
                Answer answer205 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox13.Value,
                    QuestionId = 1182,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer205);
            }
            else
            {
                ans141.AnsDes = this.serialNumberTextbox13.Value;
                ans141.AnserTypeId = 1;
                ans141.CreateDate = DateTime.Now;
                ans141.QuestionId = 1182;
                ans141.UserId = user.Id;
                ans141.AnsMonth = ansMonth; ans141.SRId = sR.Id;
            }

            //  new SerialNumber 13 :   
            var ans142 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1183).FirstOrDefault();
            if (ans142 == null)
            {
                Answer answer206 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox13.Value,
                    QuestionId = 1183,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer206);
            }
            else
            {
                ans142.AnsDes = this.newSerialNumberTextbox13.Value;
                ans142.AnserTypeId = 1;
                ans142.CreateDate = DateTime.Now;
                ans142.QuestionId = 1183;
                ans142.UserId = user.Id;
                ans142.AnsMonth = ansMonth; ans142.SRId = sR.Id;
            }

            //  หมายเหตุ  13   :    
            var ans143 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1184).FirstOrDefault();
            if (ans143 == null)
            {
                Answer answer207 = new Answer()
                {
                    AnsDes = this.noteTextbox13.Value,
                    QuestionId = 1184,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer207);
            }
            else
            {
                ans143.AnsDes = this.noteTextbox13.Value;
                ans143.AnserTypeId = 1;
                ans143.CreateDate = DateTime.Now;
                ans143.QuestionId = 1184;
                ans143.UserId = user.Id;
                ans143.AnsMonth = ansMonth; ans143.SRId = sR.Id;
            }
            //////////////////////////////////////////////////////////////////////////////////



            //////////////////////////////////////////////////////////////////////////////////
            // รายการอุปกรณ์ 14 : 
            var ans144 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1185).FirstOrDefault();
            if (ans144 == null)
            {
                Answer answer208 = new Answer()
                {
                    AnsDes = this.toolsListTextbox14.Value,
                    QuestionId = 1185,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer208);
            }
            else
            {
                ans144.AnsDes = this.toolsListTextbox14.Value;
                ans144.AnserTypeId = 1;
                ans144.CreateDate = DateTime.Now;
                ans144.QuestionId = 1185;
                ans144.UserId = user.Id;
                ans144.AnsMonth = ansMonth; ans144.SRId = sR.Id;
            }

            //  SerialNumber 14 :     
            var ans145 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1186).FirstOrDefault();
            if (ans145 == null)
            {
                Answer answer209 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox14.Value,
                    QuestionId = 1186,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer209);
            }
            else
            {
                ans145.AnsDes = this.serialNumberTextbox14.Value;
                ans145.AnserTypeId = 1;
                ans145.CreateDate = DateTime.Now;
                ans145.QuestionId = 1186;
                ans145.UserId = user.Id;
                ans145.AnsMonth = ansMonth; ans145.SRId = sR.Id;
            }

            //  new SerialNumber 14 :  
            var ans146 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1187).FirstOrDefault();
            if (ans146 == null)
            {
                Answer answer210 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox14.Value,
                    QuestionId = 1187,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer210);
            }
            else
            {
                ans146.AnsDes = this.newSerialNumberTextbox14.Value;
                ans146.AnserTypeId = 1;
                ans146.CreateDate = DateTime.Now;
                ans146.QuestionId = 1187;
                ans146.UserId = user.Id;
                ans146.AnsMonth = ansMonth; ans146.SRId = sR.Id;
            }

            //  หมายเหตุ  143   :    
            var ans147 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1188).FirstOrDefault();
            if (ans147 == null)
            {
                Answer answer211 = new Answer()
                {
                    AnsDes = this.noteTextbox14.Value,
                    QuestionId = 1188,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer211);
            }
            else
            {
                ans147.AnsDes = this.noteTextbox14.Value;
                ans147.AnserTypeId = 1;
                ans147.CreateDate = DateTime.Now;
                ans147.QuestionId = 1188;
                ans147.UserId = user.Id;
                ans147.AnsMonth = ansMonth; ans147.SRId = sR.Id;
            }
            //////////////////////////////////////////////////////////////////////////////////






            //////////////////////////////////////////////////////////////////////////////////
            // รายการอุปกรณ์ 15 :  
            var ans148 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1189).FirstOrDefault();
            if (ans148 == null)
            {
                Answer answer212 = new Answer()
                {
                    AnsDes = this.toolsListTextbox15.Value,
                    QuestionId = 1189,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer212);
            }
            else
            {
                ans148.AnsDes = this.toolsListTextbox15.Value;
                ans148.AnserTypeId = 1;
                ans148.CreateDate = DateTime.Now;
                ans148.QuestionId = 1189;
                ans148.UserId = user.Id;
                ans148.AnsMonth = ansMonth; ans148.SRId = sR.Id;
            }

            //  SerialNumber 15 :    
            var ans149 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1190).FirstOrDefault();
            if (ans149 == null)
            {
                Answer answer213 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox15.Value,
                    QuestionId = 1190,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer213);
            }
            else
            {
                ans149.AnsDes = this.serialNumberTextbox15.Value;
                ans149.AnserTypeId = 1;
                ans149.CreateDate = DateTime.Now;
                ans149.QuestionId = 1190;
                ans149.UserId = user.Id;
                ans149.AnsMonth = ansMonth; ans149.SRId = sR.Id;
            }

            //  new SerialNumber 15 :      
            var ans150 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1191).FirstOrDefault();
            if (ans150 == null)
            {
                Answer answer214 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox15.Value,
                    QuestionId = 1191,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer214);
            }
            else
            {
                ans150.AnsDes = this.newSerialNumberTextbox15.Value;
                ans150.AnserTypeId = 1;
                ans150.CreateDate = DateTime.Now;
                ans150.QuestionId = 1191;
                ans150.UserId = user.Id;
                ans150.AnsMonth = ansMonth; ans150.SRId = sR.Id;
            }

            //  หมายเหตุ  15   :   
            var ans151 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1192).FirstOrDefault();
            if (ans151 == null)
            {
                Answer answer215 = new Answer()
                {
                    AnsDes = this.noteTextbox15.Value,
                    QuestionId = 1192,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer215);
            }
            else
            {
                ans151.AnsDes = this.noteTextbox15.Value;
                ans151.AnserTypeId = 1;
                ans151.CreateDate = DateTime.Now;
                ans151.QuestionId = 1192;
                ans151.UserId = user.Id;
                ans151.AnsMonth = ansMonth; ans151.SRId = sR.Id;
            }
            //////////////////////////////////////////////////////////////////////////////////
            ///


            //  namepm :    

            var ans152 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1193).FirstOrDefault();
            if (ans152 == null)
            {
                Answer answer216 = new Answer()
                {
                    AnsDes = this.namepmTextbox.Value,
                    QuestionId = 1193,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer216);
            }
            else
            {
                ans152.AnsDes = this.namepmTextbox.Value;
                ans152.AnserTypeId = 1;
                ans152.CreateDate = DateTime.Now;
                ans152.QuestionId = 1193;
                ans152.UserId = user.Id;
                ans152.AnsMonth = ansMonth; ans152.SRId = sR.Id;
            }


            // วันที่ทำ PM :  
            var ans153 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1194).FirstOrDefault();
            if (ans153 == null)
            {
                Answer answer217 = new Answer()
                {
                    AnsDes = this.dayDopmTextbox.Value,
                    QuestionId = 1194,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer217);
            }
            else
            {
                ans153.AnsDes = this.dayDopmTextbox.Value;
                ans153.AnserTypeId = 1;
                ans153.CreateDate = DateTime.Now;
                ans153.QuestionId = 1194;
                ans153.UserId = user.Id;
                ans153.AnsMonth = ansMonth; ans153.SRId = sR.Id;
            }


            // รรูปภาพรวมบริเวณ Site :
            var ans154 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1195).FirstOrDefault();
            if (ans154 == null)
            {
                string picallsite = Request.Form["picallsiteRadio"];
                Answer answer220 = new Answer()
                {
                    AnsDes = picallsite,
                    QuestionId = 1195,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer220);
            }
            else
            {
                string picallsite = Request.Form["picallsiteRadio"];
                ans154.AnsDes = picallsite;
                ans154.AnserTypeId = 4;
                ans154.CreateDate = DateTime.Now;
                ans154.QuestionId = 1195;
                ans154.UserId = user.Id;
                ans154.AnsMonth = ansMonth; ans154.SRId = sR.Id;
            }


            // รูปหน้าตู้ ก่อน-หลัง  :
            var ans155 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1196).FirstOrDefault();
            if (ans155 == null)
            {
                string picturefontback = Request.Form["picturefontbackRadio"];
                Answer answer221 = new Answer()
                {
                    AnsDes = picturefontback,
                    QuestionId = 1196,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer221);
            }
            else
            {
                string picturefontback = Request.Form["picturefontbackRadio"];
                ans155.AnsDes = picturefontback;
                ans155.AnserTypeId = 4;
                ans155.CreateDate = DateTime.Now;
                ans155.QuestionId = 1196;
                ans155.UserId = user.Id;
                ans155.AnsMonth = ansMonth; ans155.SRId = sR.Id;

            }


            // ูปภายในตู้ ก่อน-หลัง :
            var ans156 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1197).FirstOrDefault();
            if (ans156 == null)
            {
                string pictureinfontback = Request.Form["pictureinfontbackRadio"];
                Answer answer222 = new Answer()
                {
                    AnsDes = pictureinfontback,
                    QuestionId = 1197,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer222);
            }
            else
            {
                string pictureinfontback = Request.Form["pictureinfontbackRadio"];
                ans156.AnsDes = pictureinfontback;
                ans156.AnserTypeId = 4;
                ans156.CreateDate = DateTime.Now;
                ans156.QuestionId = 1197;
                ans156.UserId = user.Id;
                ans156.AnsMonth = ansMonth; ans156.SRId = sR.Id;
            }


            // ูปขณะทำความสะอาดตู้ ก่อน-หลัง :
            var ans157 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1198).FirstOrDefault();
            if (ans157 == null)
            {
                string picCleanbox = Request.Form["picCleanboxRadio"];
                Answer answer223 = new Answer()
                {
                    AnsDes = picCleanbox,
                    QuestionId = 1198,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer223);
            }
            else
            {
                string picCleanbox = Request.Form["picCleanboxRadio"];
                ans157.AnsDes = picCleanbox;
                ans157.AnserTypeId = 4;
                ans157.CreateDate = DateTime.Now;
                ans157.QuestionId = 1198;
                ans157.UserId = user.Id;
                ans157.AnsMonth = ansMonth; ans157.SRId = sR.Id;
            }

            // ูปสถานะ Circuit Breaker (ON) :
            var ans158 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1199).FirstOrDefault();
            if (ans158 == null)
            {
                string picCircuitOn = Request.Form["picCircuitOnRadio"];
                Answer answer224 = new Answer()
                {
                    AnsDes = picCircuitOn,
                    QuestionId = 1199,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer224);
            }
            else
            {
                string picCircuitOn = Request.Form["picCircuitOnRadio"];
                ans158.AnsDes = picCircuitOn;
                ans158.AnserTypeId = 4;
                ans158.CreateDate = DateTime.Now;
                ans158.QuestionId = 1199;
                ans158.UserId = user.Id;
                ans158.AnsMonth = ansMonth; ans158.SRId = sR.Id;
            }

            // ูปการตรวจสอบงานติดตั้งระบบ Ground และ Bar Ground :
            var ans159 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1200).FirstOrDefault();
            if (ans159 == null)
            {
                string picGroundandbar = Request.Form["picGroundandbarRadio"];
                Answer answer225 = new Answer()
                {
                    AnsDes = picGroundandbar,
                    QuestionId = 1200,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer225);
            }
            else
            {
                string picGroundandbar = Request.Form["picGroundandbarRadio"];
                ans159.AnsDes = picGroundandbar;
                ans159.AnserTypeId = 4;
                ans159.CreateDate = DateTime.Now;
                ans159.QuestionId = 1200;
                ans159.UserId = user.Id;
                ans159.AnsMonth = ansMonth; ans159.SRId = sR.Id;
            }



            // ูปการตรวจสอบสถานะไฟฟ้ารั่วลง Ground (Lamp Test) :
            var ans160 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1201).FirstOrDefault();
            if (ans160 == null)
            {
                string picElecGroundTest = Request.Form["picElecGroundTestRadio"];
                Answer answer226 = new Answer()
                {
                    AnsDes = picElecGroundTest,
                    QuestionId = 1201,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer226);
            }
            else
            {
                string picElecGroundTest = Request.Form["picElecGroundTestRadio"];
                ans160.AnsDes = picElecGroundTest;
                ans160.AnserTypeId = 4;
                ans160.CreateDate = DateTime.Now;
                ans160.QuestionId = 1201;
                ans160.UserId = user.Id;
                ans160.AnsMonth = ansMonth; ans160.SRId = sR.Id;
            }




            // ูป PEA Meter  :
            var ans161 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1202).FirstOrDefault();
            if (ans161 == null)
            {
                string picMeter = Request.Form["picpeaMeterRadio"];
                Answer answer227 = new Answer()
                {
                    AnsDes = picMeter,
                    QuestionId = 1202,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer227);
            }
            else
            {
                string picMeter = Request.Form["picpeaMeterRadio"];
                ans161.AnsDes = picMeter;
                ans161.AnserTypeId = 4;
                ans161.CreateDate = DateTime.Now;
                ans161.QuestionId = 1202;
                ans161.UserId = user.Id;
                ans161.AnsMonth = ansMonth; ans161.SRId = sR.Id;
            }



            // ูปการวัดแรงดัน AC และกระแส AC  :
            var ans162 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1203).FirstOrDefault();
            if (ans162 == null)
            {
                string acPic = Request.Form["acPicRadio"];
                Answer answer228 = new Answer()
                {
                    AnsDes = acPic,
                    QuestionId = 1203,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer228);
            }
            else
            {
                string acPic = Request.Form["acPicRadio"];
                ans162.AnsDes = acPic;
                ans162.AnserTypeId = 4;
                ans162.CreateDate = DateTime.Now;
                ans162.QuestionId = 1203;
                ans162.UserId = user.Id;
                ans162.AnsMonth = ansMonth; ans162.SRId = sR.Id;
            }

            // ูปหน้าจอ UPS แสดงค่าต่างๆ และ Serial N  :
            var ans163 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1204).FirstOrDefault();
            if (ans163 == null)
            {
                string picUPS = Request.Form["picUPSRadio"];
                Answer answer229 = new Answer()
                {
                    AnsDes = picUPS,
                    QuestionId = 1204,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer229);
            }
            else
            {
                string picUPS = Request.Form["picUPSRadio"];
                ans163.AnsDes = picUPS;
                ans163.AnserTypeId = 4;
                ans163.CreateDate = DateTime.Now;
                ans163.QuestionId = 1204;
                ans163.UserId = user.Id;
                ans163.AnsMonth = ansMonth; ans163.SRId = sR.Id;
            }


            // ูป ONU/Modem พร้อม Serial NO. และ MAC  :
            var ans164 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1205).FirstOrDefault();
            if (ans164 == null)
            {
                string picONUModem = Request.Form["picONUModemRadio"];
                Answer answer230 = new Answer()
                {
                    AnsDes = picONUModem,
                    QuestionId = 1205,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer230);
            }
            else
            {
                string picONUModem = Request.Form["picONUModemRadio"];
                ans164.AnsDes = picONUModem;
                ans164.AnserTypeId = 4;
                ans164.CreateDate = DateTime.Now;
                ans164.QuestionId = 1205;
                ans164.UserId = user.Id;
                ans164.AnsMonth = ansMonth; ans164.SRId = sR.Id;
            }


            // รูป Power Supply พร้อม Serial NO.   :
            var ans165 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1206).FirstOrDefault();
            if (ans165 == null)
            {
                string picpowersub = Request.Form["picpowersubRadio"];
                Answer answer231 = new Answer()
                {
                    AnsDes = picpowersub,
                    QuestionId = 1206,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer231);
            }
            else
            {
                string picpowersub = Request.Form["picpowersubRadio"];
                ans165.AnsDes = picpowersub;
                ans165.AnserTypeId = 4;
                ans165.CreateDate = DateTime.Now;
                ans165.QuestionId = 1206;
                ans165.UserId = user.Id;
                ans165.AnsMonth = ansMonth; ans165.SRId = sR.Id;
            }


            //รูป Switch 8 Port พร้อม Serial NO. และ MAC
            var ans166 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1207).FirstOrDefault();
            if (ans166 == null)
            {
                string picSwitch8port = Request.Form["picSwitch8portRadio"];
                Answer answer232 = new Answer()
                {
                    AnsDes = picSwitch8port,
                    QuestionId = 1207,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer232);
            }
            else
            {
                string picSwitch8port = Request.Form["picSwitch8portRadio"];
                ans166.AnsDes = picSwitch8port;
                ans166.AnserTypeId = 4;
                ans166.CreateDate = DateTime.Now;
                ans166.QuestionId = 1207;
                ans166.UserId = user.Id;
                ans166.AnsMonth = ansMonth; ans166.SRId = sR.Id;
            }

            // รูป Outdoor AP 2.4 GHz พร้อม Serial NO. และ MAC
            var ans167 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1208).FirstOrDefault();
            if (ans167 == null)
            {
                string picOutdoor2_4 = Request.Form["picOutdoor2_4Radio"];
                Answer answer233 = new Answer()
                {
                    AnsDes = picOutdoor2_4,
                    QuestionId = 1208,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer233);
            }
            else
            {
                string picOutdoor2_4 = Request.Form["picOutdoor2_4Radio"];
                ans167.AnsDes = picOutdoor2_4;
                ans167.AnserTypeId = 4;
                ans167.CreateDate = DateTime.Now;
                ans167.QuestionId = 1208;
                ans167.UserId = user.Id;
                ans167.AnsMonth = ansMonth; ans167.SRId = sR.Id;
            }

            // ูป Outdoor AP 5 GHz พร้อม Serial NO. และ MAC  :
            var ans168 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1209).FirstOrDefault();
            if (ans168 == null)
            {

                string picOutdoor5 = Request.Form["picOutdoor5Radio"];
                Answer answer234 = new Answer()
                {
                    AnsDes = picOutdoor5,
                    QuestionId = 1209,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer234);
            }
            else
            {
                string picOutdoor5 = Request.Form["picOutdoor5Radio"];
                ans168.AnsDes = picOutdoor5;
                ans168.AnserTypeId = 4;
                ans168.CreateDate = DateTime.Now;
                ans168.QuestionId = 1209;
                ans168.UserId = user.Id;
                ans168.AnsMonth = ansMonth; ans168.SRId = sR.Id;

            }


            // รูปการ Test Speed ONU (30/10 mbps) :
            var ans169 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1636).FirstOrDefault();
            if (ans169 == null)
            {
                string picOnu3010 = Request.Form["picOnu3010Radio"];
                Answer answer235 = new Answer()
                {
                    AnsDes = picOnu3010,
                    QuestionId = 1636,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer235);
            }
            else
            {
                string picOnu3010 = Request.Form["picOnu3010Radio"];
                ans169.AnsDes = picOnu3010;
                ans169.AnserTypeId = 4;
                ans169.CreateDate = DateTime.Now;
                ans169.QuestionId = 1636;
                ans169.UserId = user.Id;
                ans169.AnsMonth = ansMonth; ans169.SRId = sR.Id;
            }


            // ูปการ Test Speed VSAT (30/5 mbps) *เฉพาะ SAT. :
            var ans170 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1637).FirstOrDefault();
            if (ans170 == null)
            {
                string pictestVSAT305 = Request.Form["pictestVSAT305Radio"];
                Answer answer236 = new Answer()
                {
                    AnsDes = pictestVSAT305,
                    QuestionId = 1637,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer236);
            }
            else
            {
                string pictestVSAT305 = Request.Form["pictestVSAT305Radio"];
                ans170.AnsDes = pictestVSAT305;
                ans170.AnserTypeId = 4;
                ans170.CreateDate = DateTime.Now;
                ans170.QuestionId = 1637;
                ans170.UserId = user.Id;
                ans170.AnsMonth = ansMonth; ans170.SRId = sR.Id;
            }

            //รูป Cable Inlet ด้านในและด้านนอก  :
            var ans171 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1638).FirstOrDefault();
            if (ans171 == null)
            {
                string picCableinout = Request.Form["picCableinoutRadio"];
                Answer answer237 = new Answer()
                {
                    AnsDes = picCableinout,
                    QuestionId = 1638,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer237);
            }
            else
            {
                string picCableinout = Request.Form["picCableinoutRadio"];
                ans171.AnsDes = picCableinout;
                ans171.AnserTypeId = 4;
                ans171.CreateDate = DateTime.Now;
                ans171.QuestionId = 1638;
                ans171.UserId = user.Id;
                ans171.AnsMonth = ansMonth; ans171.SRId = sR.Id;
            }


            // ูป Filter ก่อน-หลัง ทำความสะอาด :
            var ans172 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1639).FirstOrDefault();
            if (ans172 == null)
            {
                string picFillter = Request.Form["picFillterRadio"];
                Answer answer238 = new Answer()
                {
                    AnsDes = picFillter,
                    QuestionId = 1639,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer238);
            }
            else
            {
                string picFillter = Request.Form["picFillterRadio"];
                ans172.AnsDes = picFillter;
                ans172.AnserTypeId = 4;
                ans172.CreateDate = DateTime.Now;
                ans172.QuestionId = 1639;
                ans172.UserId = user.Id;
                ans172.AnsMonth = ansMonth; ans172.SRId = sR.Id;
            }


            // รูปจุดติดตั้งจานดาวเทียม:
            var ans173 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1210).FirstOrDefault();
            if (ans173 == null)
            {
                string inStallBase = Request.Form["inStallBaseRadio"];
                Answer answer249 = new Answer()
                {
                    AnsDes = inStallBase,
                    QuestionId = 1210,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer249);
            }
            else
            {
                string inStallBase = Request.Form["inStallBaseRadio"];
                ans173.AnsDes = inStallBase;
                ans173.AnserTypeId = 4;
                ans173.CreateDate = DateTime.Now;
                ans173.QuestionId = 1210;
                ans173.UserId = user.Id;
                ans173.AnsMonth = ansMonth; ans173.SRId = sR.Id;
            }



            // รูปความสะอาดบริเวณจานดาวเทียมr :
            var ans174 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1211).FirstOrDefault();
            if (ans174 == null)
            {
                string picCleansatellite = Request.Form["picCleansatelliteRadio"];
                Answer answer250 = new Answer()
                {
                    AnsDes = picCleansatellite,
                    QuestionId = 1211,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer250);
            }
            else
            {
                string picCleansatellite = Request.Form["picCleansatelliteRadio"];
                ans174.AnsDes = picCleansatellite;
                ans174.AnserTypeId = 4;
                ans174.CreateDate = DateTime.Now;
                ans174.QuestionId = 1211;
                ans174.UserId = user.Id;
                ans174.AnsMonth = ansMonth; ans174.SRId = sR.Id;
            }




            // รูป LNB พร้อม Part NO. :
            var ans175 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1212).FirstOrDefault();
            if (ans175 == null)
            {
                string picLnb = Request.Form["picLnbRadio"];
                Answer answer251 = new Answer()
                {
                    AnsDes = picLnb,
                    QuestionId = 1212,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer251);
            }
            else
            {
                string picLnb = Request.Form["picLnbRadio"];
                ans175.AnsDes = picLnb;
                ans175.AnserTypeId = 4;
                ans175.CreateDate = DateTime.Now;
                ans175.QuestionId = 1212;
                ans175.UserId = user.Id;
                ans175.AnsMonth = ansMonth; ans175.SRId = sR.Id;
            }



            // รูป BUC พร้อม Part NO :
            var ans176 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1213).FirstOrDefault();
            if (ans176 == null)
            {
                string picBUC = Request.Form["picBUCRadio"];
                Answer answer252 = new Answer()
                {
                    AnsDes = picBUC,
                    QuestionId = 1213,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer252);
            }
            else
            {
                string picBUC = Request.Form["picBUCRadio"];
                ans176.AnsDes = picBUC;
                ans176.AnserTypeId = 4;
                ans176.CreateDate = DateTime.Now;
                ans176.QuestionId = 1213;
                ans176.UserId = user.Id;
                ans176.AnsMonth = ansMonth; ans176.SRId = sR.Id;
            }




            // รูปการเก็บสายและพันหัวที่ LNB/BUC :
            var ans177 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1214).FirstOrDefault();
            if (ans177 == null)
            {
                string picWiringLnb = Request.Form["picWiringLnbRadio"];
                Answer answer253 = new Answer()
                {
                    AnsDes = picWiringLnb,
                    QuestionId = 1214,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer253);
            }
            else
            {
                string picWiringLnb = Request.Form["picWiringLnbRadio"];
                ans177.AnsDes = picWiringLnb;
                ans177.AnserTypeId = 4;
                ans177.CreateDate = DateTime.Now;
                ans177.QuestionId = 1214;
                ans177.UserId = user.Id;
                ans177.AnsMonth = ansMonth; ans177.SRId = sR.Id;
            }



            // รูปแนว Line Of Sight (ดูการถูกบังของหน้าจานดาวเทียม) :
            var ans178 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1215).FirstOrDefault();
            if (ans178 == null)
            {
                string picLineofSight = Request.Form["picLineofSightRadio"];
                Answer answer254 = new Answer()
                {
                    AnsDes = picLineofSight,
                    QuestionId = 1215,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer254);
            }
            else
            {
                string picLineofSight = Request.Form["picLineofSightRadio"];
                ans178.AnsDes = picLineofSight;
                ans178.AnserTypeId = 4;
                ans178.CreateDate = DateTime.Now;
                ans178.QuestionId = 1215;
                ans178.UserId = user.Id;
                ans178.AnsMonth = ansMonth; ans178.SRId = sR.Id;
            }


            // รูปจุดติดตั้ง Solar Cell :
            var ans179 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1216).FirstOrDefault();
            if (ans179 == null)
            {
                string picBaseSolarcell = Request.Form["picBaseSolarcellRadio"];
                Answer answer255 = new Answer()
                {
                    AnsDes = picBaseSolarcell,
                    QuestionId = 1216,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer255);
            }
            else
            {
                string picBaseSolarcell = Request.Form["picBaseSolarcellRadio"];
                ans179.AnsDes = picBaseSolarcell;
                ans179.AnserTypeId = 4;
                ans179.CreateDate = DateTime.Now;
                ans179.QuestionId = 1216;
                ans179.UserId = user.Id;
                ans179.AnsMonth = ansMonth; ans179.SRId = sR.Id;
            }



            // รูปอุปกรณ์ Solar Cell ภายในห้อง :
            var ans180 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1217).FirstOrDefault();
            if (ans180 == null)
            {
                string solarcellToolsinroom = Request.Form["solarcellToolsinroomRadio"];
                Answer answer256 = new Answer()
                {
                    AnsDes = solarcellToolsinroom,
                    QuestionId = 1217,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer256);
            }
            else
            {
                string solarcellToolsinroom = Request.Form["solarcellToolsinroomRadio"];
                ans180.AnsDes = solarcellToolsinroom;
                ans180.AnserTypeId = 4;
                ans180.CreateDate = DateTime.Now;
                ans180.QuestionId = 1217;
                ans180.UserId = user.Id;
                ans180.AnsMonth = ansMonth; ans180.SRId = sR.Id;
            }


            // รูปหน้าจอ Charger แสดงค่าต่างๆ :
            var ans181 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1218).FirstOrDefault();
            if (ans181 == null)
            {
                string screenCharger = Request.Form["screenChargerRadio"];
                Answer answer257 = new Answer()
                {
                    AnsDes = screenCharger,
                    QuestionId = 1218,
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
                string screenCharger = Request.Form["screenChargerRadio"];
                ans181.AnsDes = screenCharger;
                ans181.AnserTypeId = 4;
                ans181.CreateDate = DateTime.Now;
                ans181.QuestionId = 1218;
                ans181.UserId = user.Id;
                ans181.AnsMonth = ansMonth; ans181.SRId = sR.Id;
            }



            // รูปหน้าจอ Inverter แสดงค่าต่างๆ :
            var ans182 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1219).FirstOrDefault();
            if (ans182 == null)
            {
                string screenInverter = Request.Form["screenInverterRadio"];
                Answer answer258 = new Answer()
                {
                    AnsDes = screenInverter,
                    QuestionId = 1219,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer258);
            }
            else
            {
                string screenInverter = Request.Form["screenInverterRadio"];
                ans182.AnsDes = screenInverter;
                ans182.AnserTypeId = 4;
                ans181.CreateDate = DateTime.Now;
                ans182.QuestionId = 1219;
                ans182.UserId = user.Id;
                ans182.AnsMonth = ansMonth; ans182.SRId = sR.Id;

            }


            // รูป Circuit Breaker ภายในตู้ :
            var ans183 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1220).FirstOrDefault();
            if (ans183 == null)
            {
                string piccircuitBreaker = Request.Form["piccircuitBreakerRadio"];
                Answer answer259 = new Answer()
                {
                    AnsDes = piccircuitBreaker,
                    QuestionId = 1220,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer259);
            }
            else
            {
                string piccircuitBreaker = Request.Form["piccircuitBreakerRadio"];
                ans183.AnsDes = piccircuitBreaker;
                ans183.AnserTypeId = 4;
                ans183.CreateDate = DateTime.Now;
                ans183.QuestionId = 1220;
                ans183.UserId = user.Id;
                ans183.AnsMonth = ansMonth; ans183.SRId = sR.Id;
            }



            // รูป Terminal ต่อสายภายในตู้ :
            var ans184 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1221).FirstOrDefault();
            if (ans184 == null)
            {
                string picTerminal = Request.Form["picTerminalRadio"];
                Answer answer260 = new Answer()
                {
                    AnsDes = picTerminal,
                    QuestionId = 1221,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer260);
            }
            else
            {
                string picTerminal = Request.Form["picTerminalRadio"];
                ans184.AnsDes = picTerminal;
                ans184.AnserTypeId = 4;
                ans184.CreateDate = DateTime.Now;
                ans184.QuestionId = 1221;
                ans184.UserId = user.Id;
                ans184.AnsMonth = ansMonth; ans184.SRId = sR.Id;
            }

            ////////////
            // รูปการวัดแรงดัน Battery ก้อนที่ 1 :
            var ans185 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1222).FirstOrDefault();
            if (ans185 == null)
            {
                string picbattery1s = Request.Form["picbattery1sRadio"];
                Answer answer261 = new Answer()
                {
                    AnsDes = picbattery1s,
                    QuestionId = 1222,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer261);
            }
            else
            {
                string picbattery1s = Request.Form["picbattery1sRadio"];
                ans185.AnsDes = picbattery1s;
                ans185.AnserTypeId = 4;
                ans185.CreateDate = DateTime.Now;
                ans185.QuestionId = 1222;
                ans185.UserId = user.Id;
                ans185.AnsMonth = ansMonth; ans185.SRId = sR.Id;
            }

            // รูปการวัดแรงดัน Battery ก้อนที่ 2:
            var ans186 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1223).FirstOrDefault();
            if (ans186 == null)
            {
                string picbattery2s = Request.Form["picbattery2sRadio"];
                Answer picbt1 = new Answer()
                {
                    AnsDes = picbattery2s,
                    QuestionId = 1223,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(picbt1);
            }
            else
            {
                string picbattery2s = Request.Form["picbattery2sRadio"];
                ans186.AnsDes = picbattery2s;
                ans186.AnserTypeId = 4;
                ans186.CreateDate = DateTime.Now;
                ans186.QuestionId = 1223;
                ans186.UserId = user.Id;
                ans186.AnsMonth = ansMonth; ans186.SRId = sR.Id;
            }

            // รูปการวัดแรงดัน Battery ก้อนที่ 3:
            var ans187 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1224).FirstOrDefault();
            if (ans187 == null)
            {
                string picbattery3s = Request.Form["picbattery3sRadio"];
                Answer picbt2 = new Answer()
                {
                    AnsDes = picbattery3s,
                    QuestionId = 1224,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(picbt2);
            }
            else
            {
                string picbattery3s = Request.Form["picbattery3sRadio"];
                ans187.AnsDes = picbattery3s;
                ans187.AnserTypeId = 4;
                ans187.CreateDate = DateTime.Now;
                ans187.QuestionId = 1224;
                ans187.UserId = user.Id;
                ans187.AnsMonth = ansMonth; ans187.SRId = sR.Id;
            }

            // รูปการวัดแรงดัน Battery ก้อนที่ 4 :
            var ans188 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1225).FirstOrDefault();
            if (ans188 == null)
            {
                string picbattery4s = Request.Form["picbattery4sRadio"];
                Answer picbt3 = new Answer()
                {
                    AnsDes = picbattery4s,
                    QuestionId = 1225,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(picbt3);
            }
            else
            {
                string picbattery4s = Request.Form["picbattery4sRadio"];
                ans188.AnsDes = picbattery4s;
                ans188.AnserTypeId = 4;
                ans188.CreateDate = DateTime.Now;
                ans188.QuestionId = 1225;
                ans188.UserId = user.Id;
                ans188.AnsMonth = ansMonth; ans188.SRId = sR.Id;
            }
            ///////
            ///


            // รูปความสะอาดแผง PV :
            var ans189 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1226).FirstOrDefault();
            if (ans189 == null)
            {
                string picCleaningPv = Request.Form["picCleaningPvRadio"];
                Answer picbt4 = new Answer()
                {
                    AnsDes = picCleaningPv,
                    QuestionId = 1226,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(picbt4);
            }
            else
            {
                string picCleaningPv = Request.Form["picCleaningPvRadio"];
                ans189.AnsDes = picCleaningPv;
                ans189.AnserTypeId = 4;
                ans189.CreateDate = DateTime.Now;
                ans189.QuestionId = 1226;
                ans189.UserId = user.Id;
                ans189.AnsMonth = ansMonth; ans189.SRId = sR.Id;
            }


            // รูปภาพรวมดูสิ่งบดบังแสงอาทิตย์  :
            var ans190 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1227).FirstOrDefault();
            if (ans190 == null)
            {
                string picSunrise = Request.Form["picSunriseRadio"];
                Answer answer262 = new Answer()
                {
                    AnsDes = picSunrise,
                    QuestionId = 1227,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer262);
            }
            else
            {
                string picSunrise = Request.Form["picSunriseRadio"];
                ans190.AnsDes = picSunrise;
                ans190.AnserTypeId = 4;
                ans190.CreateDate = DateTime.Now;
                ans190.QuestionId = 1227;
                ans190.UserId = user.Id;
                ans190.AnsMonth = ansMonth; ans190.SRId = sR.Id;
            }

            //1.รูป PICTURE CHECKLIST :
            var ans191 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1228).FirstOrDefault();
            if (ans191 == null)
            {

                if (this.pictureChecklistImages.HasFile)
                {
                    string extension = this.pictureChecklistImages.PostedFile.FileName.Split('.')[1];
                    string newFileName = "images/pictureChecklist_BB2_1_3_1_" + DateTime.Now.ToString("yyyyMMddHHmmss") + "." + extension;
                    this.pictureChecklistImages.PostedFile.SaveAs(Server.MapPath(newFileName));

                    Answer answer275 = new Answer()
                    {
                        AnsDes = newFileName,
                        QuestionId = 1228,
                        AnserTypeId = 3,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth,
                        SRId = sR.Id
                    };
                    uSOEntities.Answers.Add(answer275);
                }
            }
            else
            {
                if (this.pictureChecklistImages.HasFile)
                {
                    string extension = this.pictureChecklistImages.PostedFile.FileName.Split('.')[1];
                    string newFileName = "images/pictureChecklist_BB2_1_3_1_" + DateTime.Now.ToString("yyyyMMddHHmmss") + "." + extension;
                    this.pictureChecklistImages.PostedFile.SaveAs(Server.MapPath(newFileName));



                    ans191.QuestionId = 1228;
                    ans191.AnsDes = newFileName;
                    ans191.AnserTypeId = 3;
                    ans191.CreateDate = DateTime.Now;
                    ans191.UserId = user.Id;
                    ans191.AnsMonth = ansMonth;
                    ans191.SRId = sR.Id;

                }


            }





            var ans192 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1229).FirstOrDefault();
            if (ans192 == null)
            {
                //2.รูป VSAT PICTURE CHECKLIST :
                if (this.vsatpictureChecklistImages.HasFile)
                {
                    string extension = this.vsatpictureChecklistImages.PostedFile.FileName.Split('.')[1];
                    string newFileName = "images/VsatPictureChecklist_BB2_1_3_1_" + DateTime.Now.ToString("yyyyMMddHHmmss") + "." + extension;
                    this.vsatpictureChecklistImages.PostedFile.SaveAs(Server.MapPath(newFileName));

                    Answer answer276 = new Answer()
                    {
                        AnsDes = newFileName,
                        QuestionId = 1229,
                        AnserTypeId = 3,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth,
                        SRId = sR.Id
                    };
                    uSOEntities.Answers.Add(answer276);
                }
            }
            else
            {
                if (this.vsatpictureChecklistImages.HasFile)
                {
                    string extension = this.vsatpictureChecklistImages.PostedFile.FileName.Split('.')[1];
                    string newFileName = "images/VsatPictureChecklist_BB2_1_3_1_" + DateTime.Now.ToString("yyyyMMddHHmmss") + "." + extension;
                    this.vsatpictureChecklistImages.PostedFile.SaveAs(Server.MapPath(newFileName));

                    ans192.QuestionId = 1229;
                    ans192.AnsDes = newFileName;
                    ans192.AnserTypeId = 3;
                    ans192.CreateDate = DateTime.Now;
                    ans192.UserId = user.Id;
                    ans192.AnsMonth = ansMonth;
                    ans192.SRId = sR.Id;

                }



            }



            //3.รูป SOLAR CELL PICTURE CHECKLISTT :


            var ans193 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 5 && x.SRId == sR.Id && x.QuestionId == 1230).FirstOrDefault();
            if (ans193 == null)
            {
                if (this.solarcellpictureChecklistImages.HasFile)
                {
                    string extension = this.solarcellpictureChecklistImages.PostedFile.FileName.Split('.')[1];
                    string newFileName = "images/SolarcellPictureChecklist_BB2_1_3_1_" + DateTime.Now.ToString("yyyyMMddHHmmss") + "." + extension;
                    this.solarcellpictureChecklistImages.PostedFile.SaveAs(Server.MapPath(newFileName));

                    Answer answer277 = new Answer()
                    {
                        AnsDes = newFileName,
                        QuestionId = 1230,
                        AnserTypeId = 3,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth,
                        SRId = sR.Id
                    };
                    uSOEntities.Answers.Add(answer277);
                }
            }
            else
            {

                if (this.solarcellpictureChecklistImages.HasFile)
                {
                    string extension = this.solarcellpictureChecklistImages.PostedFile.FileName.Split('.')[1];
                    string newFileName = "images/SolarcellPictureChecklist_BB2_1_3_1_" + DateTime.Now.ToString("yyyyMMddHHmmss") + "." + extension;
                    this.solarcellpictureChecklistImages.PostedFile.SaveAs(Server.MapPath(newFileName));

                    ans193.QuestionId = 1230;
                    ans193.AnsDes = newFileName;
                    ans193.AnserTypeId = 3;
                    ans193.CreateDate = DateTime.Now;
                    ans193.UserId = user.Id;
                    ans193.AnsMonth = ansMonth;
                    ans193.SRId = sR.Id;


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