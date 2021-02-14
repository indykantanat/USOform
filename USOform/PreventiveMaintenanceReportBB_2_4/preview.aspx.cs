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

namespace USOform.PreventiveMaintenanceReportBB_2_4
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
        int GetQuarter(DateTime dt)
        {
            return (dt.Month - 1) / 3 + 1;
        }



        void SetForm()
        {

            this.groupLabel.Text = answers.Where(x => x.QuestionId == 265).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 265).FirstOrDefault().AnsDes : "";
            this.AreaLabel.Text = answers.Where(x => x.QuestionId == 266).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 266).FirstOrDefault().AnsDes : "";
            this.CompanyLabel.Text = answers.Where(x => x.QuestionId == 267).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 267).FirstOrDefault().AnsDes : "";
            this.maintenanceCountLabel.Text = answers.Where(x => x.QuestionId == 268).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 268).FirstOrDefault().AnsDes : "";
            this.yearLabel.Text = answers.Where(x => x.QuestionId == 269).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 269).FirstOrDefault().AnsDes : "";
            this.startDatepickerLabel.Text = answers.Where(x => x.QuestionId == 270).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 270).FirstOrDefault().AnsDes : "";
            this.endDatepickerLabel.Text = answers.Where(x => x.QuestionId == 271).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 271).FirstOrDefault().AnsDes : "";
            this.siteCodeLabel.Text = answers.Where(x => x.QuestionId == 1634).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1634).FirstOrDefault().AnsDes : "";
            this.cabinetIdLabel.Text = answers.Where(x => x.QuestionId == 272).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 272).FirstOrDefault().AnsDes : "";
            this.sitecodeLabelSection2.Text = answers.Where(x => x.QuestionId == 273).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 273).FirstOrDefault().AnsDes : "";
            this.VillageIdLabel.Text = answers.Where(x => x.QuestionId == 274).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 274).FirstOrDefault().AnsDes : "";
            this.phoNameLabel.Text = answers.Where(x => x.QuestionId == 275).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 275).FirstOrDefault().AnsDes : "";
            this.villageLabel.Text = answers.Where(x => x.QuestionId == 276).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 276).FirstOrDefault().AnsDes : "";
            this.subdistrictLabel.Text = answers.Where(x => x.QuestionId == 277).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 277).FirstOrDefault().AnsDes : "";
            this.DistrictLabel.Text = answers.Where(x => x.QuestionId == 278).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 278).FirstOrDefault().AnsDes : "";
            this.provinceLabel.Text = answers.Where(x => x.QuestionId == 279).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 279).FirstOrDefault().AnsDes : "";
            this.provinceLabel.Text = answers.Where(x => x.QuestionId == 279).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 279).FirstOrDefault().AnsDes : "";
            this.typeLabel.Text = answers.Where(x => x.QuestionId == 280).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 280).FirstOrDefault().AnsDes : "";
            this.pmdateLabel.Text = answers.Where(x => x.QuestionId == 281).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 281).FirstOrDefault().AnsDes : "";
            //  this.signatureExecutorLabel.Text = answers.Where(x => x.QuestionId == 282).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 282).FirstOrDefault().AnsDes : "";
            //this.signatureSupervisorLabel.Text = answers.Where(x => x.QuestionId == 283).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 283).FirstOrDefault().AnsDes : "";
            this.nameExecutorLabel.Text = answers.Where(x => x.QuestionId == 284).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 284).FirstOrDefault().AnsDes : "";
            this.nameSupervisorLabel.Text = answers.Where(x => x.QuestionId == 285).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 285).FirstOrDefault().AnsDes : "";
            this.DateExecutorLabel.Text = answers.Where(x => x.QuestionId == 286).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 286).FirstOrDefault().AnsDes : "";
            this.DateSupervisorLabel.Text = answers.Where(x => x.QuestionId == 287).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 287).FirstOrDefault().AnsDes : "";
            this.cabinetId2Label.Text = answers.Where(x => x.QuestionId == 288).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 288).FirstOrDefault().AnsDes : "";
            this.sitecodeLabelSection4.Text = answers.Where(x => x.QuestionId == 289).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 289).FirstOrDefault().AnsDes : "";
            this.villageIDLabelSection4.Text = answers.Where(x => x.QuestionId == 290).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 290).FirstOrDefault().AnsDes : "";
            this.latandlongLabel.Text = answers.Where(x => x.QuestionId == 291).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 291).FirstOrDefault().AnsDes : "";
            this.oltIdLabel.Text = answers.Where(x => x.QuestionId == 293).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 293).FirstOrDefault().AnsDes : "";
            this.numberIdLabel.Text = answers.Where(x => x.QuestionId == 295).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 295).FirstOrDefault().AnsDes : "";
            this.kwhMeterLabel.Text = answers.Where(x => x.QuestionId == 296).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 296).FirstOrDefault().AnsDes : "";
            this.acvoltLabel.Text = answers.Where(x => x.QuestionId == 297).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 297).FirstOrDefault().AnsDes : "";
            this.lineAcLabel.Text = answers.Where(x => x.QuestionId == 298).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 298).FirstOrDefault().AnsDes : "";
            this.neutronAcEIEILabel.Text = answers.Where(x => x.QuestionId == 299).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 299).FirstOrDefault().AnsDes : "";
            this.acfromupsLabel.Text = answers.Where(x => x.QuestionId == 303).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 303).FirstOrDefault().AnsDes : "";
            this.voltInverterLabel.Text = answers.Where(x => x.QuestionId == 339).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 339).FirstOrDefault().AnsDes : "";
            this.loadVoltTageLabel.Text = answers.Where(x => x.QuestionId == 340).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 340).FirstOrDefault().AnsDes : "";
            this.batterLabel1.Text = answers.Where(x => x.QuestionId == 341).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 341).FirstOrDefault().AnsDes : "";
            this.batterLabel2.Text = answers.Where(x => x.QuestionId == 342).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 342).FirstOrDefault().AnsDes : "";
            this.batterLabel3.Text = answers.Where(x => x.QuestionId == 343).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 343).FirstOrDefault().AnsDes : "";
            this.batterLabel4.Text = answers.Where(x => x.QuestionId == 344).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 344).FirstOrDefault().AnsDes : "";
            this.dowloadOnuLabel.Text = answers.Where(x => x.QuestionId == 345).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 345).FirstOrDefault().AnsDes : "";
            this.uploadforOnuLabel.Text = answers.Where(x => x.QuestionId == 346).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 346).FirstOrDefault().AnsDes : "";
            this.pinngtestforOnuLabel.Text = answers.Where(x => x.QuestionId == 347).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 347).FirstOrDefault().AnsDes : "";
            this.dowloadforMobileLabel.Text = answers.Where(x => x.QuestionId == 348).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 348).FirstOrDefault().AnsDes : "";
            this.uploadforMobileLabel.Text = answers.Where(x => x.QuestionId == 349).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 349).FirstOrDefault().AnsDes : "";
            this.pingtestFormobileLabel.Text = answers.Where(x => x.QuestionId == 350).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 350).FirstOrDefault().AnsDes : "";
            //ปัญหาและวิธีแก้ไข
            this.problemLabel1.Text = answers.Where(x => x.QuestionId == 351).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 351).FirstOrDefault().AnsDes : "";
            this.howtoSolveLabel1.Text = answers.Where(x => x.QuestionId == 352).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 352).FirstOrDefault().AnsDes : "";
            this.problemLabel2.Text = answers.Where(x => x.QuestionId == 353).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 353).FirstOrDefault().AnsDes : "";
            this.howtoSolveLabel2.Text = answers.Where(x => x.QuestionId == 354).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 354).FirstOrDefault().AnsDes : "";
            this.problemLabel3.Text = answers.Where(x => x.QuestionId == 355).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 355).FirstOrDefault().AnsDes : "";
            this.howtoSolveLabel3.Text = answers.Where(x => x.QuestionId == 356).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 356).FirstOrDefault().AnsDes : "";
            this.problemLabel4.Text = answers.Where(x => x.QuestionId == 357).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 357).FirstOrDefault().AnsDes : "";
            this.howtoSolveLabel4.Text = answers.Where(x => x.QuestionId == 358).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 358).FirstOrDefault().AnsDes : "";
            this.problemLabel5.Text = answers.Where(x => x.QuestionId == 359).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 359).FirstOrDefault().AnsDes : "";
            this.howtoSolveLabel5.Text = answers.Where(x => x.QuestionId == 360).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 360).FirstOrDefault().AnsDes : "";
            this.problemLabel6.Text = answers.Where(x => x.QuestionId == 361).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 361).FirstOrDefault().AnsDes : "";
            this.howtoSolveLabel6.Text = answers.Where(x => x.QuestionId == 362).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 362).FirstOrDefault().AnsDes : "";
            this.problemLabel7.Text = answers.Where(x => x.QuestionId == 363).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 363).FirstOrDefault().AnsDes : "";
            this.howtoSolveLabel7.Text = answers.Where(x => x.QuestionId == 364).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 364).FirstOrDefault().AnsDes : "";
            this.problemLabel8.Text = answers.Where(x => x.QuestionId == 365).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 365).FirstOrDefault().AnsDes : "";
            this.howtoSolveLabel8.Text = answers.Where(x => x.QuestionId == 366).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 366).FirstOrDefault().AnsDes : "";
            this.problemLabel9.Text = answers.Where(x => x.QuestionId == 367).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 367).FirstOrDefault().AnsDes : "";
            this.howtoSolveLabel9.Text = answers.Where(x => x.QuestionId == 368).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 368).FirstOrDefault().AnsDes : "";
            this.problemLabel10.Text = answers.Where(x => x.QuestionId == 369).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 369).FirstOrDefault().AnsDes : "";
            this.howtoSolveLabel10.Text = answers.Where(x => x.QuestionId == 370).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 370).FirstOrDefault().AnsDes : "";
            this.problemLabel11.Text = answers.Where(x => x.QuestionId == 371).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 371).FirstOrDefault().AnsDes : "";
            this.howtoSolveLabel11.Text = answers.Where(x => x.QuestionId == 372).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 372).FirstOrDefault().AnsDes : "";
            this.problemLabel12.Text = answers.Where(x => x.QuestionId == 373).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 373).FirstOrDefault().AnsDes : "";
            this.howtoSolveLabel12.Text = answers.Where(x => x.QuestionId == 374).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 374).FirstOrDefault().AnsDes : "";
            this.problemLabel13.Text = answers.Where(x => x.QuestionId == 375).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 375).FirstOrDefault().AnsDes : "";
            this.howtoSolveLabel13.Text = answers.Where(x => x.QuestionId == 376).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 376).FirstOrDefault().AnsDes : "";
            this.problemLabel14.Text = answers.Where(x => x.QuestionId == 377).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 377).FirstOrDefault().AnsDes : "";
            this.howtoSolveLabel14.Text = answers.Where(x => x.QuestionId == 378).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 378).FirstOrDefault().AnsDes : "";
            this.problemLabel15.Text = answers.Where(x => x.QuestionId == 379).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 379).FirstOrDefault().AnsDes : "";
            this.howtoSolveLabel15.Text = answers.Where(x => x.QuestionId == 380).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 380).FirstOrDefault().AnsDes : "";
            //รายการอุปกรณ์
            this.toolsListLabel1.Text = answers.Where(x => x.QuestionId == 381).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 381).FirstOrDefault().AnsDes : "";
            this.serialNumberLabel1.Text = answers.Where(x => x.QuestionId == 382).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 382).FirstOrDefault().AnsDes : "";
            this.newSerialNumberLabel1.Text = answers.Where(x => x.QuestionId == 383).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 383).FirstOrDefault().AnsDes : "";
            this.noteLabel1.Text = answers.Where(x => x.QuestionId == 384).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 384).FirstOrDefault().AnsDes : "";
            this.toolsListLabel2.Text = answers.Where(x => x.QuestionId == 385).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 385).FirstOrDefault().AnsDes : "";
            this.serialNumberLabel2.Text = answers.Where(x => x.QuestionId == 386).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 386).FirstOrDefault().AnsDes : "";
            this.newSerialNumberLabel2.Text = answers.Where(x => x.QuestionId == 387).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 387).FirstOrDefault().AnsDes : "";
            this.noteLabel2.Text = answers.Where(x => x.QuestionId == 388).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 388).FirstOrDefault().AnsDes : "";
            this.toolsListLabel3.Text = answers.Where(x => x.QuestionId == 389).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 389).FirstOrDefault().AnsDes : "";
            this.serialNumberLabel3.Text = answers.Where(x => x.QuestionId == 390).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 390).FirstOrDefault().AnsDes : "";
            this.newSerialNumberLabel3.Text = answers.Where(x => x.QuestionId == 391).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 391).FirstOrDefault().AnsDes : "";
            this.noteLabel3.Text = answers.Where(x => x.QuestionId == 392).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 392).FirstOrDefault().AnsDes : "";
            this.toolsListLabel4.Text = answers.Where(x => x.QuestionId == 393).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 393).FirstOrDefault().AnsDes : "";
            this.serialNumberLabel4.Text = answers.Where(x => x.QuestionId == 394).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 394).FirstOrDefault().AnsDes : "";
            this.newSerialNumberLabel4.Text = answers.Where(x => x.QuestionId == 395).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 395).FirstOrDefault().AnsDes : "";
            this.noteLabel4.Text = answers.Where(x => x.QuestionId == 396).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 396).FirstOrDefault().AnsDes : "";
            this.toolsListLabel5.Text = answers.Where(x => x.QuestionId == 397).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 397).FirstOrDefault().AnsDes : "";
            this.serialNumberLabel5.Text = answers.Where(x => x.QuestionId == 398).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 398).FirstOrDefault().AnsDes : "";
            this.newSerialNumberLabel5.Text = answers.Where(x => x.QuestionId == 399).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 399).FirstOrDefault().AnsDes : "";
            this.noteLabel5.Text = answers.Where(x => x.QuestionId == 400).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 400).FirstOrDefault().AnsDes : "";
            this.toolsListLabel6.Text = answers.Where(x => x.QuestionId == 401).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 401).FirstOrDefault().AnsDes : "";
            this.serialNumberLabel6.Text = answers.Where(x => x.QuestionId == 402).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 402).FirstOrDefault().AnsDes : "";
            this.newSerialNumberLabel6.Text = answers.Where(x => x.QuestionId == 403).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 403).FirstOrDefault().AnsDes : "";
            this.noteLabel6.Text = answers.Where(x => x.QuestionId == 404).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 404).FirstOrDefault().AnsDes : "";
            this.toolsListLabel7.Text = answers.Where(x => x.QuestionId == 405).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 405).FirstOrDefault().AnsDes : "";
            this.serialNumberLabel7.Text = answers.Where(x => x.QuestionId == 406).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 406).FirstOrDefault().AnsDes : "";
            this.newSerialNumberLabel7.Text = answers.Where(x => x.QuestionId == 407).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 407).FirstOrDefault().AnsDes : "";
            this.noteLabel7.Text = answers.Where(x => x.QuestionId == 408).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 408).FirstOrDefault().AnsDes : "";
            this.toolsListLabel8.Text = answers.Where(x => x.QuestionId == 409).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 409).FirstOrDefault().AnsDes : "";
            this.serialNumberLabel8.Text = answers.Where(x => x.QuestionId == 410).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 410).FirstOrDefault().AnsDes : "";
            this.newSerialNumberLabel8.Text = answers.Where(x => x.QuestionId == 411).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 411).FirstOrDefault().AnsDes : "";
            this.noteLabel8.Text = answers.Where(x => x.QuestionId == 412).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 412).FirstOrDefault().AnsDes : "";
            this.toolsListLabel9.Text = answers.Where(x => x.QuestionId == 413).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 413).FirstOrDefault().AnsDes : "";
            this.serialNumberLabel9.Text = answers.Where(x => x.QuestionId == 414).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 414).FirstOrDefault().AnsDes : "";
            this.newSerialNumberLabel9.Text = answers.Where(x => x.QuestionId == 415).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 415).FirstOrDefault().AnsDes : "";
            this.noteLabel9.Text = answers.Where(x => x.QuestionId == 416).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 416).FirstOrDefault().AnsDes : "";
            this.toolsListLabel10.Text = answers.Where(x => x.QuestionId == 417).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 417).FirstOrDefault().AnsDes : "";
            this.serialNumberLabel10.Text = answers.Where(x => x.QuestionId == 418).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 418).FirstOrDefault().AnsDes : "";
            this.newSerialNumberLabel10.Text = answers.Where(x => x.QuestionId == 419).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 419).FirstOrDefault().AnsDes : "";
            this.noteLabel10.Text = answers.Where(x => x.QuestionId == 420).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 420).FirstOrDefault().AnsDes : "";
            this.toolsListLabel11.Text = answers.Where(x => x.QuestionId == 421).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 421).FirstOrDefault().AnsDes : "";
            this.serialNumberLabel11.Text = answers.Where(x => x.QuestionId == 422).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 422).FirstOrDefault().AnsDes : "";
            this.newSerialNumberLabel11.Text = answers.Where(x => x.QuestionId == 423).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 423).FirstOrDefault().AnsDes : "";
            this.noteLabel11.Text = answers.Where(x => x.QuestionId == 424).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 424).FirstOrDefault().AnsDes : "";
            this.toolsListLabel12.Text = answers.Where(x => x.QuestionId == 425).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 425).FirstOrDefault().AnsDes : "";
            this.serialNumberLabel12.Text = answers.Where(x => x.QuestionId == 426).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 426).FirstOrDefault().AnsDes : "";
            this.newSerialNumberLabel12.Text = answers.Where(x => x.QuestionId == 427).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 427).FirstOrDefault().AnsDes : "";
            this.noteLabel12.Text = answers.Where(x => x.QuestionId == 428).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 428).FirstOrDefault().AnsDes : "";
            this.toolsListLabel13.Text = answers.Where(x => x.QuestionId == 429).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 429).FirstOrDefault().AnsDes : "";
            this.serialNumberLabel13.Text = answers.Where(x => x.QuestionId == 430).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 430).FirstOrDefault().AnsDes : "";
            this.newSerialNumberLabel13.Text = answers.Where(x => x.QuestionId == 431).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 431).FirstOrDefault().AnsDes : "";
            this.noteLabel13.Text = answers.Where(x => x.QuestionId == 432).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 432).FirstOrDefault().AnsDes : "";
            this.toolsListLabel14.Text = answers.Where(x => x.QuestionId == 433).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 433).FirstOrDefault().AnsDes : "";
            this.serialNumberLabel14.Text = answers.Where(x => x.QuestionId == 434).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 434).FirstOrDefault().AnsDes : "";
            this.newSerialNumberLabel14.Text = answers.Where(x => x.QuestionId == 435).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 435).FirstOrDefault().AnsDes : "";
            this.noteLabel14.Text = answers.Where(x => x.QuestionId == 436).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 436).FirstOrDefault().AnsDes : "";
            this.toolsListLabel15.Text = answers.Where(x => x.QuestionId == 437).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 437).FirstOrDefault().AnsDes : "";
            this.serialNumberLabel15.Text = answers.Where(x => x.QuestionId == 438).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 438).FirstOrDefault().AnsDes : "";
            this.newSerialNumberLabel15.Text = answers.Where(x => x.QuestionId == 439).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 439).FirstOrDefault().AnsDes : "";
            this.noteLabel15.Text = answers.Where(x => x.QuestionId == 440).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 440).FirstOrDefault().AnsDes : "";
            this.nameDopmLabel.Text = answers.Where(x => x.QuestionId == 441).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 441).FirstOrDefault().AnsDes : "";
            this.dayDopmLabel.Text = answers.Where(x => x.QuestionId == 442).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 442).FirstOrDefault().AnsDes : "";




































        }
    }
}