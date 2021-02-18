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
                //int currentQuarter = this.GetQuarter(DateTime.Now);
                int currentQuarter = int.Parse(Request["qurter"]);
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
            this.AreaLabel.Text = answers.Where(x => x.QuestionId == 1015).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1015).FirstOrDefault().AnsDes : "";
            this.CompanyLabel.Text = answers.Where(x => x.QuestionId == 1016).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1016).FirstOrDefault().AnsDes : "";
            this.maintenanceCountLabel.Text = answers.Where(x => x.QuestionId == 1018).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1018).FirstOrDefault().AnsDes : "";
            this.yearLabel.Text = answers.Where(x => x.QuestionId == 1019).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1019).FirstOrDefault().AnsDes : "";
            this.startDatepickerLabel.Text = answers.Where(x => x.QuestionId == 1020).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1020).FirstOrDefault().AnsDes : "";
            this.endDatepickerLabel.Text = answers.Where(x => x.QuestionId == 1021).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1021).FirstOrDefault().AnsDes : "";
            this.siteCodeLabel.Text = answers.Where(x => x.QuestionId == 1022).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1022).FirstOrDefault().AnsDes : "";
            this.cabinetIdLabel.Text = answers.Where(x => x.QuestionId == 1024).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1024).FirstOrDefault().AnsDes : "";
            this.sitecodeLabelSection2.Text = answers.Where(x => x.QuestionId == 1025).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1025).FirstOrDefault().AnsDes : "";
            this.VillageIdLabel.Text = answers.Where(x => x.QuestionId == 1026).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1026).FirstOrDefault().AnsDes : "";
            this.villageLabel.Text = answers.Where(x => x.QuestionId == 1027).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1027).FirstOrDefault().AnsDes : "";
            this.subdistrictLabel.Text = answers.Where(x => x.QuestionId == 1028).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1028).FirstOrDefault().AnsDes : "";
            this.districtLabel.Text = answers.Where(x => x.QuestionId == 1029).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1029).FirstOrDefault().AnsDes : "";
            this.provinceLabel.Text = answers.Where(x => x.QuestionId == 1030).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1030).FirstOrDefault().AnsDes : "";
            this.typeLabel.Text = answers.Where(x => x.QuestionId == 1031).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1031).FirstOrDefault().AnsDes : "";
            this.pmdateLabel.Text = answers.Where(x => x.QuestionId == 1032).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1032).FirstOrDefault().AnsDes : "";
            //this.signatureExecutorLabel.Text = answers.Where(x => x.QuestionId == 1034).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1034).FirstOrDefault().AnsDes : "";
            //this.signatureSupervisorLabel.Text = answers.Where(x => x.QuestionId == 1035).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1035).FirstOrDefault().AnsDes : "";
            this.nameExecutorLabel.Text = answers.Where(x => x.QuestionId == 1036).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1036).FirstOrDefault().AnsDes : "";
            this.nameSupervisorLabel.Text = answers.Where(x => x.QuestionId == 1037).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1037).FirstOrDefault().AnsDes : "";
            this.DateExecutorLabel.Text = answers.Where(x => x.QuestionId == 1038).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1038).FirstOrDefault().AnsDes : "";
            this.DateSupervisorLabel.Text = answers.Where(x => x.QuestionId == 1039).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1039).FirstOrDefault().AnsDes : "";
            this.cabinetIDLabelSection4.Text = answers.Where(x => x.QuestionId == 1040).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1040).FirstOrDefault().AnsDes : "";
            this.sitecodeLabelSection4.Text = answers.Where(x => x.QuestionId == 1041).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1041).FirstOrDefault().AnsDes : "";
            this.villageIDLabelSection4.Text = answers.Where(x => x.QuestionId == 1042).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1042).FirstOrDefault().AnsDes : "";
            this.latandlongLabel.Text = answers.Where(x => x.QuestionId == 1043).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1043).FirstOrDefault().AnsDes : "";
            this.oltidLabel.Text = answers.Where(x => x.QuestionId == 1045).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1045).FirstOrDefault().AnsDes : "";
            this.numberuserLabel.Text = answers.Where(x => x.QuestionId == 1047).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1047).FirstOrDefault().AnsDes : "";
            this.kwhMeterLabel.Text = answers.Where(x => x.QuestionId == 1048).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1048).FirstOrDefault().AnsDes : "";
            this.acLabel.Text = answers.Where(x => x.QuestionId == 1049).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1049).FirstOrDefault().AnsDes : "";
            this.lineAcLabel.Text = answers.Where(x => x.QuestionId == 1050).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1050).FirstOrDefault().AnsDes : "";
            this.neutronacLabel.Text = answers.Where(x => x.QuestionId == 1051).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1051).FirstOrDefault().AnsDes : "";
            this.acfromupsLabel.Text = answers.Where(x => x.QuestionId == 1055).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1055).FirstOrDefault().AnsDes : "";
            this.voltageInverterLabel.Text = answers.Where(x => x.QuestionId == 1091).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1091).FirstOrDefault().AnsDes : "";
            this.voltageLoadLabel.Text = answers.Where(x => x.QuestionId == 1092).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1092).FirstOrDefault().AnsDes : "";
            this.powerBatteryLabel1.Text = answers.Where(x => x.QuestionId == 1093).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1093).FirstOrDefault().AnsDes : "";
            this.powerBatteryLabel2.Text = answers.Where(x => x.QuestionId == 1094).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1094).FirstOrDefault().AnsDes : "";
            this.powerBatteryLabel3.Text = answers.Where(x => x.QuestionId == 1095).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1095).FirstOrDefault().AnsDes : "";
            this.powerBatteryLabel4.Text = answers.Where(x => x.QuestionId == 1096).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1096).FirstOrDefault().AnsDes : "";
            this.dowloadforOnuLabel.Text = answers.Where(x => x.QuestionId == 1097).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1097).FirstOrDefault().AnsDes : "";
            this.uploadforOnuLabel.Text = answers.Where(x => x.QuestionId == 1098).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1098).FirstOrDefault().AnsDes : "";
            this.pingTestLabel.Text = answers.Where(x => x.QuestionId == 1099).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1099).FirstOrDefault().AnsDes : "";
            this.dowloadForwifiLabel.Text = answers.Where(x => x.QuestionId == 1100).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1100).FirstOrDefault().AnsDes : "";
            this.uploadForwifiLabel.Text = answers.Where(x => x.QuestionId == 1101).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1101).FirstOrDefault().AnsDes : "";
            this.pingtestForwifiLabel.Text = answers.Where(x => x.QuestionId == 1102).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1102).FirstOrDefault().AnsDes : "";

            this.problemLabel1.Text = answers.Where(x => x.QuestionId == 1103).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1103).FirstOrDefault().AnsDes : "";
            this.howtoSolveLabel1.Text = answers.Where(x => x.QuestionId == 1104).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1104).FirstOrDefault().AnsDes : "";
            this.problemLabel2.Text = answers.Where(x => x.QuestionId == 1105).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1105).FirstOrDefault().AnsDes : "";
            this.howtoSolveLabel2.Text = answers.Where(x => x.QuestionId == 1106).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1106).FirstOrDefault().AnsDes : "";
            this.problemLabel3.Text = answers.Where(x => x.QuestionId == 1107).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1107).FirstOrDefault().AnsDes : "";
            this.howtoSolveLabel3.Text = answers.Where(x => x.QuestionId == 1108).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1108).FirstOrDefault().AnsDes : "";
            this.problemLabel4.Text = answers.Where(x => x.QuestionId == 1109).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1109).FirstOrDefault().AnsDes : "";
            this.howtoSolveLabel4.Text = answers.Where(x => x.QuestionId == 1110).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1110).FirstOrDefault().AnsDes : "";
            this.problemLabel5.Text = answers.Where(x => x.QuestionId == 1111).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1111).FirstOrDefault().AnsDes : "";
            this.howtoSolveLabel5.Text = answers.Where(x => x.QuestionId == 1112).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1112).FirstOrDefault().AnsDes : "";
            this.problemLabel6.Text = answers.Where(x => x.QuestionId == 1113).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1113).FirstOrDefault().AnsDes : "";
            this.howtoSolveLabel6.Text = answers.Where(x => x.QuestionId == 1114).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1114).FirstOrDefault().AnsDes : "";
            this.problemLabel7.Text = answers.Where(x => x.QuestionId == 1115).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1115).FirstOrDefault().AnsDes : "";
            this.howtoSolveLabel7.Text = answers.Where(x => x.QuestionId == 1116).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1116).FirstOrDefault().AnsDes : "";
            this.problemLabel8.Text = answers.Where(x => x.QuestionId == 1117).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1117).FirstOrDefault().AnsDes : "";
            this.howtoSolveLabel8.Text = answers.Where(x => x.QuestionId == 1118).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1118).FirstOrDefault().AnsDes : "";
            this.problemLabel9.Text = answers.Where(x => x.QuestionId == 1119).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1119).FirstOrDefault().AnsDes : "";
            this.howtoSolveLabel9.Text = answers.Where(x => x.QuestionId == 1120).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1120).FirstOrDefault().AnsDes : "";
            this.problemLabel10.Text = answers.Where(x => x.QuestionId == 1121).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1121).FirstOrDefault().AnsDes : "";
            this.howtoSolveLabel10.Text = answers.Where(x => x.QuestionId == 1122).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1122).FirstOrDefault().AnsDes : "";
            this.problemLabel11.Text = answers.Where(x => x.QuestionId == 1123).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1123).FirstOrDefault().AnsDes : "";
            this.howtoSolveLabel11.Text = answers.Where(x => x.QuestionId == 1124).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1124).FirstOrDefault().AnsDes : "";
            this.problemLabel12.Text = answers.Where(x => x.QuestionId == 1125).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1125).FirstOrDefault().AnsDes : "";
            this.howtoSolveLabel12.Text = answers.Where(x => x.QuestionId == 1126).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1126).FirstOrDefault().AnsDes : "";
            this.problemLabel13.Text = answers.Where(x => x.QuestionId == 1127).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1127).FirstOrDefault().AnsDes : "";
            this.howtoSolveLabel13.Text = answers.Where(x => x.QuestionId == 1128).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1128).FirstOrDefault().AnsDes : "";
            this.problemLabel14.Text = answers.Where(x => x.QuestionId == 1129).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1129).FirstOrDefault().AnsDes : "";
            this.howtoSolveLabel14.Text = answers.Where(x => x.QuestionId == 1130).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1130).FirstOrDefault().AnsDes : "";
            this.problemLabel15.Text = answers.Where(x => x.QuestionId == 1131).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1131).FirstOrDefault().AnsDes : "";
            this.howtoSolveLabel15.Text = answers.Where(x => x.QuestionId == 1132).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1132).FirstOrDefault().AnsDes : "";

            this.toolsListLabel1.Text = answers.Where(x => x.QuestionId == 1133).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1133).FirstOrDefault().AnsDes : "";
            this.serialNumberLabel1.Text = answers.Where(x => x.QuestionId == 1134).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1134).FirstOrDefault().AnsDes : "";
            this.newSerialNumberLabel1.Text = answers.Where(x => x.QuestionId == 1135).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1135).FirstOrDefault().AnsDes : "";
            this.noteLabel1.Text = answers.Where(x => x.QuestionId == 1136).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1136).FirstOrDefault().AnsDes : "";
            this.toolsListLabel2.Text = answers.Where(x => x.QuestionId == 1137).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1137).FirstOrDefault().AnsDes : "";
            this.serialNumberLabel2.Text = answers.Where(x => x.QuestionId == 1138).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1138).FirstOrDefault().AnsDes : "";
            this.newSerialNumberLabel2.Text = answers.Where(x => x.QuestionId == 1139).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1139).FirstOrDefault().AnsDes : "";
            this.noteLabel2.Text = answers.Where(x => x.QuestionId == 1140).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1140).FirstOrDefault().AnsDes : "";
            this.toolsListLabel3.Text = answers.Where(x => x.QuestionId == 1141).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1141).FirstOrDefault().AnsDes : "";
            this.serialNumberLabel3.Text = answers.Where(x => x.QuestionId == 1142).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1142).FirstOrDefault().AnsDes : "";
            this.newSerialNumberLabel3.Text = answers.Where(x => x.QuestionId == 1143).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1143).FirstOrDefault().AnsDes : "";
            this.noteLabel3.Text = answers.Where(x => x.QuestionId == 1144).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1144).FirstOrDefault().AnsDes : "";
            this.toolsListLabel4.Text = answers.Where(x => x.QuestionId == 1145).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1145).FirstOrDefault().AnsDes : "";
            this.serialNumberLabel4.Text = answers.Where(x => x.QuestionId == 1146).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1146).FirstOrDefault().AnsDes : "";
            this.newSerialNumberLabel4.Text = answers.Where(x => x.QuestionId == 1147).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1147).FirstOrDefault().AnsDes : "";
            this.noteLabel4.Text = answers.Where(x => x.QuestionId == 1148).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1148).FirstOrDefault().AnsDes : "";
            this.toolsListLabel5.Text = answers.Where(x => x.QuestionId == 1149).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1149).FirstOrDefault().AnsDes : "";
            this.serialNumberLabel5.Text = answers.Where(x => x.QuestionId == 1150).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1150).FirstOrDefault().AnsDes : "";
            this.newSerialNumberLabel5.Text = answers.Where(x => x.QuestionId == 1151).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1151).FirstOrDefault().AnsDes : "";
            this.noteLabel5.Text = answers.Where(x => x.QuestionId == 1152).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1152).FirstOrDefault().AnsDes : "";
            this.toolsListLabel6.Text = answers.Where(x => x.QuestionId == 1153).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1153).FirstOrDefault().AnsDes : "";
            this.serialNumberLabel6.Text = answers.Where(x => x.QuestionId == 1154).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1154).FirstOrDefault().AnsDes : "";
            this.newSerialNumberLabel6.Text = answers.Where(x => x.QuestionId == 1155).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1155).FirstOrDefault().AnsDes : "";
            this.noteLabel6.Text = answers.Where(x => x.QuestionId == 1156).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1156).FirstOrDefault().AnsDes : "";
            this.toolsListLabel7.Text = answers.Where(x => x.QuestionId == 1157).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1157).FirstOrDefault().AnsDes : "";
            this.serialNumberLabel7.Text = answers.Where(x => x.QuestionId == 1158).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1158).FirstOrDefault().AnsDes : "";
            this.newSerialNumberLabel7.Text = answers.Where(x => x.QuestionId == 1159).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1159).FirstOrDefault().AnsDes : "";
            this.noteLabel7.Text = answers.Where(x => x.QuestionId == 1160).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1160).FirstOrDefault().AnsDes : "";
            this.toolsListLabel8.Text = answers.Where(x => x.QuestionId == 1161).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1161).FirstOrDefault().AnsDes : "";
            this.serialNumberLabel8.Text = answers.Where(x => x.QuestionId == 1162).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1162).FirstOrDefault().AnsDes : "";
            this.newSerialNumberLabel8.Text = answers.Where(x => x.QuestionId == 1163).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1163).FirstOrDefault().AnsDes : "";
            this.noteLabel8.Text = answers.Where(x => x.QuestionId == 1164).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1164).FirstOrDefault().AnsDes : "";
            this.toolsListLabel9.Text = answers.Where(x => x.QuestionId == 1165).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1165).FirstOrDefault().AnsDes : "";
            this.serialNumberLabel9.Text = answers.Where(x => x.QuestionId == 1166).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1166).FirstOrDefault().AnsDes : "";
            this.newSerialNumberLabel9.Text = answers.Where(x => x.QuestionId == 1167).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1167).FirstOrDefault().AnsDes : "";
            this.noteLabel9.Text = answers.Where(x => x.QuestionId == 1168).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1168).FirstOrDefault().AnsDes : "";
            this.toolsListLabel10.Text = answers.Where(x => x.QuestionId == 1169).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1169).FirstOrDefault().AnsDes : "";
            this.serialNumberLabel10.Text = answers.Where(x => x.QuestionId == 1170).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1170).FirstOrDefault().AnsDes : "";
            this.newSerialNumberLabel10.Text = answers.Where(x => x.QuestionId == 1171).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1171).FirstOrDefault().AnsDes : "";
            this.noteLabel10.Text = answers.Where(x => x.QuestionId == 1172).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1172).FirstOrDefault().AnsDes : "";
            this.toolsListLabel11.Text = answers.Where(x => x.QuestionId == 1173).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1173).FirstOrDefault().AnsDes : "";
            this.serialNumberLabel11.Text = answers.Where(x => x.QuestionId == 1174).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1174).FirstOrDefault().AnsDes : "";
            this.newSerialNumberLabel11.Text = answers.Where(x => x.QuestionId == 1175).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1175).FirstOrDefault().AnsDes : "";
            this.noteLabel11.Text = answers.Where(x => x.QuestionId == 1176).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1176).FirstOrDefault().AnsDes : "";
            this.toolsListLabel12.Text = answers.Where(x => x.QuestionId == 1177).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1177).FirstOrDefault().AnsDes : "";
            this.serialNumberLabel12.Text = answers.Where(x => x.QuestionId == 1178).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1178).FirstOrDefault().AnsDes : "";
            this.newSerialNumberLabel12.Text = answers.Where(x => x.QuestionId == 1179).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1179).FirstOrDefault().AnsDes : "";
            this.noteLabel12.Text = answers.Where(x => x.QuestionId == 1180).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1180).FirstOrDefault().AnsDes : "";
            this.toolsListLabel13.Text = answers.Where(x => x.QuestionId == 1181).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1181).FirstOrDefault().AnsDes : "";
            this.serialNumberLabel13.Text = answers.Where(x => x.QuestionId == 1182).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1182).FirstOrDefault().AnsDes : "";
            this.newSerialNumberLabel13.Text = answers.Where(x => x.QuestionId == 1183).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1183).FirstOrDefault().AnsDes : "";
            this.noteLabel13.Text = answers.Where(x => x.QuestionId == 1184).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1184).FirstOrDefault().AnsDes : "";
            this.toolsListLabel14.Text = answers.Where(x => x.QuestionId == 1185).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1185).FirstOrDefault().AnsDes : "";
            this.serialNumberLabel14.Text = answers.Where(x => x.QuestionId == 1186).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1186).FirstOrDefault().AnsDes : "";
            this.newSerialNumberLabel14.Text = answers.Where(x => x.QuestionId == 1187).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1187).FirstOrDefault().AnsDes : "";
            this.noteLabel14.Text = answers.Where(x => x.QuestionId == 1188).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1188).FirstOrDefault().AnsDes : "";
            this.toolsListLabel15.Text = answers.Where(x => x.QuestionId == 1189).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1189).FirstOrDefault().AnsDes : "";
            this.serialNumberLabel15.Text = answers.Where(x => x.QuestionId == 1190).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1190).FirstOrDefault().AnsDes : "";
            this.newSerialNumberLabel15.Text = answers.Where(x => x.QuestionId == 1191).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1191).FirstOrDefault().AnsDes : "";
            this.noteLabel15.Text = answers.Where(x => x.QuestionId == 1192).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1192).FirstOrDefault().AnsDes : "";

            this.namepmLabel.Text = answers.Where(x => x.QuestionId == 1193).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1193).FirstOrDefault().AnsDes : "";
            this.dayDopmLabel.Text = answers.Where(x => x.QuestionId == 1194).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1194).FirstOrDefault().AnsDes : "";
         
        }

      
















































    }
}