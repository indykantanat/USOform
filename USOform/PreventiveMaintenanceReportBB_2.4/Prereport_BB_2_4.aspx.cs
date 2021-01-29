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

namespace USOform.PreventiveMaintenanceReportBB_2._4
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
                string ansMonth = Request["AnsMonth"] != null ? Request["AnsMonth"] : DateTime.Now.ToString("yyyyMM", CultureInfo.GetCultureInfo("en-US"));
                answers = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth).ToList();
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

            //logoPicture2
            // this.groupTextbox.Value = answers.Where(x => x.QuestionId == 1409).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1409).FirstOrDefault().AnsDes : "";
            this.groupTextbox.Value = answers.Where(x => x.QuestionId == 265).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 265).FirstOrDefault().AnsDes : "";
            this.AreaTextbox.Value = answers.Where(x => x.QuestionId == 266).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 266).FirstOrDefault().AnsDes : "";
            this.CompanyTextbox.Value = answers.Where(x => x.QuestionId == 267).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 267).FirstOrDefault().AnsDes : "";
            this.maintenanceCountTextbox.Value = answers.Where(x => x.QuestionId == 268).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 268).FirstOrDefault().AnsDes : "";
            this.yearTextbox.Value = answers.Where(x => x.QuestionId == 269).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 269).FirstOrDefault().AnsDes : "";
            this.startDatepicker.Value = answers.Where(x => x.QuestionId == 270).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 270).FirstOrDefault().AnsDes : "";
            this.endDatepicker.Value = answers.Where(x => x.QuestionId == 271).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 271).FirstOrDefault().AnsDes : "";
            this.siteCodeTextbox.Value = answers.Where(x => x.QuestionId == 1634).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1634).FirstOrDefault().AnsDes : "";
            this.cabinetIdTextbox.Value = answers.Where(x => x.QuestionId == 272).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 272).FirstOrDefault().AnsDes : "";
            this.sitecodeTextboxSection2.Value = answers.Where(x => x.QuestionId == 273).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 273).FirstOrDefault().AnsDes : "";
            this.VillageIdTextbox.Value = answers.Where(x => x.QuestionId == 274).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 274).FirstOrDefault().AnsDes : "";
            this.phoNameTextbox.Value = answers.Where(x => x.QuestionId == 275).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 275).FirstOrDefault().AnsDes : "";
            this.villageTextbox.Value = answers.Where(x => x.QuestionId == 276).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 276).FirstOrDefault().AnsDes : "";
            this.subdistrictTextbox.Value = answers.Where(x => x.QuestionId == 277).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 277).FirstOrDefault().AnsDes : "";
            this.DistrictTextbox.Value = answers.Where(x => x.QuestionId == 278).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 278).FirstOrDefault().AnsDes : "";
            this.provinceTextbox.Value = answers.Where(x => x.QuestionId == 279).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 279).FirstOrDefault().AnsDes : "";
            this.provinceTextbox.Value = answers.Where(x => x.QuestionId == 279).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 279).FirstOrDefault().AnsDes : "";
            this.typeTextbox.Value = answers.Where(x => x.QuestionId == 280).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 280).FirstOrDefault().AnsDes : "";
            this.pmdateTextbox.Value = answers.Where(x => x.QuestionId == 281).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 281).FirstOrDefault().AnsDes : "";
            this.signatureExecutorTextbox.Value = answers.Where(x => x.QuestionId == 282).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 282).FirstOrDefault().AnsDes : "";
            this.signatureSupervisorTextbox.Value = answers.Where(x => x.QuestionId == 283).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 283).FirstOrDefault().AnsDes : "";
            this.nameExecutorTextbox.Value = answers.Where(x => x.QuestionId == 284).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 284).FirstOrDefault().AnsDes : "";
            this.nameSupervisorTextbox.Value = answers.Where(x => x.QuestionId == 285).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 285).FirstOrDefault().AnsDes : "";
            this.DateExecutorTextbox.Value = answers.Where(x => x.QuestionId == 286).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 286).FirstOrDefault().AnsDes : "";
            this.DateSupervisorTextbox.Value = answers.Where(x => x.QuestionId == 287).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 287).FirstOrDefault().AnsDes : "";
            this.cabinetId2Textbox.Value = answers.Where(x => x.QuestionId == 288).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 288).FirstOrDefault().AnsDes : "";
            this.sitecodeTextboxSection4.Value = answers.Where(x => x.QuestionId == 289).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 289).FirstOrDefault().AnsDes : "";
            this.villageIDTextboxSection4.Value = answers.Where(x => x.QuestionId == 290).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 290).FirstOrDefault().AnsDes : "";
            this.latandlongTextbox.Value = answers.Where(x => x.QuestionId == 291).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 291).FirstOrDefault().AnsDes : "";
            this.oltIdTextbox.Value = answers.Where(x => x.QuestionId == 293).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 293).FirstOrDefault().AnsDes : "";
            this.numberIdTextbox.Value = answers.Where(x => x.QuestionId == 295).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 295).FirstOrDefault().AnsDes : "";
            this.kwhMeterTextbox.Value = answers.Where(x => x.QuestionId == 296).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 296).FirstOrDefault().AnsDes : "";
            this.acvoltTextbox.Value = answers.Where(x => x.QuestionId == 297).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 297).FirstOrDefault().AnsDes : "";
            this.lineAcTextbox.Value = answers.Where(x => x.QuestionId == 298).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 298).FirstOrDefault().AnsDes : "";
            this.neutronAcEIEITextbox.Value = answers.Where(x => x.QuestionId == 299).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 299).FirstOrDefault().AnsDes : "";
            this.acfromupsTextbox.Value = answers.Where(x => x.QuestionId == 303).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 303).FirstOrDefault().AnsDes : "";
            this.voltInverterTextbox.Value = answers.Where(x => x.QuestionId == 339).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 339).FirstOrDefault().AnsDes : "";
            this.loadVoltTageTextbox.Value = answers.Where(x => x.QuestionId == 340).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 340).FirstOrDefault().AnsDes : "";
            this.batterTextbox1.Value = answers.Where(x => x.QuestionId == 341).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 341).FirstOrDefault().AnsDes : "";
            this.batterTextbox2.Value = answers.Where(x => x.QuestionId == 342).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 342).FirstOrDefault().AnsDes : "";
            this.batterTextbox3.Value = answers.Where(x => x.QuestionId == 343).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 343).FirstOrDefault().AnsDes : "";
            this.batterTextbox4.Value = answers.Where(x => x.QuestionId == 344).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 344).FirstOrDefault().AnsDes : "";
            this.dowloadOnuTextbox.Value = answers.Where(x => x.QuestionId == 345).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 345).FirstOrDefault().AnsDes : "";
            this.uploadforOnuTextbox.Value = answers.Where(x => x.QuestionId == 346).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 346).FirstOrDefault().AnsDes : "";
            this.pinngtestforOnuTextbox.Value = answers.Where(x => x.QuestionId == 347).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 347).FirstOrDefault().AnsDes : "";
            this.dowloadforMobileTextbox.Value = answers.Where(x => x.QuestionId == 348).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 348).FirstOrDefault().AnsDes : "";
            this.uploadforMobileTextbox.Value = answers.Where(x => x.QuestionId == 349).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 349).FirstOrDefault().AnsDes : "";
            this.pingtestFormobileTextbox.Value = answers.Where(x => x.QuestionId == 350).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 350).FirstOrDefault().AnsDes : "";
            //ปัญหาและวิธีแก้ไข
            this.problemTextbox1.Value = answers.Where(x => x.QuestionId == 351).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 351).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox1.Value = answers.Where(x => x.QuestionId == 352).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 352).FirstOrDefault().AnsDes : "";
            this.problemTextbox2.Value = answers.Where(x => x.QuestionId == 353).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 353).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox2.Value = answers.Where(x => x.QuestionId == 354).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 354).FirstOrDefault().AnsDes : "";
            this.problemTextbox3.Value = answers.Where(x => x.QuestionId == 355).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 355).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox3.Value = answers.Where(x => x.QuestionId == 356).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 356).FirstOrDefault().AnsDes : "";
            this.problemTextbox4.Value = answers.Where(x => x.QuestionId == 357).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 357).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox4.Value = answers.Where(x => x.QuestionId == 358).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 358).FirstOrDefault().AnsDes : "";
            this.problemTextbox5.Value = answers.Where(x => x.QuestionId == 359).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 359).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox5.Value = answers.Where(x => x.QuestionId == 360).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 360).FirstOrDefault().AnsDes : "";
            this.problemTextbox6.Value = answers.Where(x => x.QuestionId == 361).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 361).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox6.Value = answers.Where(x => x.QuestionId == 362).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 362).FirstOrDefault().AnsDes : "";
            this.problemTextbox7.Value = answers.Where(x => x.QuestionId == 363).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 363).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox7.Value = answers.Where(x => x.QuestionId == 364).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 364).FirstOrDefault().AnsDes : "";
            this.problemTextbox8.Value = answers.Where(x => x.QuestionId == 365).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 365).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox8.Value = answers.Where(x => x.QuestionId == 366).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 366).FirstOrDefault().AnsDes : "";
            this.problemTextbox9.Value = answers.Where(x => x.QuestionId == 367).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 367).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox9.Value = answers.Where(x => x.QuestionId == 368).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 368).FirstOrDefault().AnsDes : "";
            this.problemTextbox10.Value = answers.Where(x => x.QuestionId == 369).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 369).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox10.Value = answers.Where(x => x.QuestionId == 370).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 370).FirstOrDefault().AnsDes : "";
            this.problemTextbox11.Value = answers.Where(x => x.QuestionId == 371).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 371).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox11.Value = answers.Where(x => x.QuestionId == 372).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 372).FirstOrDefault().AnsDes : "";
            this.problemTextbox12.Value = answers.Where(x => x.QuestionId == 373).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 373).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox12.Value = answers.Where(x => x.QuestionId == 374).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 374).FirstOrDefault().AnsDes : "";
            this.problemTextbox13.Value = answers.Where(x => x.QuestionId == 375).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 375).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox13.Value = answers.Where(x => x.QuestionId == 376).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 376).FirstOrDefault().AnsDes : "";
            this.problemTextbox14.Value = answers.Where(x => x.QuestionId == 377).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 377).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox14.Value = answers.Where(x => x.QuestionId == 378).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 378).FirstOrDefault().AnsDes : "";
            this.problemTextbox15.Value = answers.Where(x => x.QuestionId == 379).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 379).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox15.Value = answers.Where(x => x.QuestionId == 380).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 380).FirstOrDefault().AnsDes : "";
            //รายการอุปกรณ์
            this.toolsListTextbox1.Value = answers.Where(x => x.QuestionId == 381).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 381).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox1.Value = answers.Where(x => x.QuestionId == 382).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 382).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox1.Value = answers.Where(x => x.QuestionId == 383).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 383).FirstOrDefault().AnsDes : "";
            this.noteTextbox1.Value = answers.Where(x => x.QuestionId == 384).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 384).FirstOrDefault().AnsDes : "";
            this.toolsListTextbox2.Value = answers.Where(x => x.QuestionId == 385).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 385).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox2.Value = answers.Where(x => x.QuestionId == 386).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 386).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox2.Value = answers.Where(x => x.QuestionId == 387).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 387).FirstOrDefault().AnsDes : "";
            this.noteTextbox2.Value = answers.Where(x => x.QuestionId == 388).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 388).FirstOrDefault().AnsDes : "";
            this.toolsListTextbox3.Value = answers.Where(x => x.QuestionId == 389).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 389).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox3.Value = answers.Where(x => x.QuestionId == 390).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 390).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox3.Value = answers.Where(x => x.QuestionId == 391).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 391).FirstOrDefault().AnsDes : "";
            this.noteTextbox3.Value = answers.Where(x => x.QuestionId == 392).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 392).FirstOrDefault().AnsDes : "";
            this.toolsListTextbox4.Value = answers.Where(x => x.QuestionId == 393).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 393).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox4.Value = answers.Where(x => x.QuestionId == 394).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 394).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox4.Value = answers.Where(x => x.QuestionId == 395).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 395).FirstOrDefault().AnsDes : "";
            this.noteTextbox4.Value = answers.Where(x => x.QuestionId == 396).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 396).FirstOrDefault().AnsDes : "";
            this.toolsListTextbox5.Value = answers.Where(x => x.QuestionId == 397).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 397).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox5.Value = answers.Where(x => x.QuestionId == 398).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 398).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox5.Value = answers.Where(x => x.QuestionId == 399).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 399).FirstOrDefault().AnsDes : "";
            this.noteTextbox5.Value = answers.Where(x => x.QuestionId == 400).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 400).FirstOrDefault().AnsDes : "";
            this.toolsListTextbox6.Value = answers.Where(x => x.QuestionId == 401).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 401).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox6.Value = answers.Where(x => x.QuestionId == 402).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 402).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox6.Value = answers.Where(x => x.QuestionId == 403).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 403).FirstOrDefault().AnsDes : "";
            this.noteTextbox6.Value = answers.Where(x => x.QuestionId == 404).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 404).FirstOrDefault().AnsDes : "";
            this.toolsListTextbox7.Value = answers.Where(x => x.QuestionId == 405).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 405).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox7.Value = answers.Where(x => x.QuestionId == 406).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 406).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox7.Value = answers.Where(x => x.QuestionId == 407).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 407).FirstOrDefault().AnsDes : "";
            this.noteTextbox7.Value = answers.Where(x => x.QuestionId == 408).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 408).FirstOrDefault().AnsDes : "";
            this.toolsListTextbox8.Value = answers.Where(x => x.QuestionId == 409).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 409).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox8.Value = answers.Where(x => x.QuestionId == 410).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 410).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox8.Value = answers.Where(x => x.QuestionId == 411).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 411).FirstOrDefault().AnsDes : "";
            this.noteTextbox8.Value = answers.Where(x => x.QuestionId == 412).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 412).FirstOrDefault().AnsDes : "";
            this.toolsListTextbox9.Value = answers.Where(x => x.QuestionId == 413).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 413).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox9.Value = answers.Where(x => x.QuestionId == 414).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 414).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox9.Value = answers.Where(x => x.QuestionId == 415).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 415).FirstOrDefault().AnsDes : "";
            this.noteTextbox9.Value = answers.Where(x => x.QuestionId == 416).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 416).FirstOrDefault().AnsDes : "";
            this.toolsListTextbox10.Value = answers.Where(x => x.QuestionId == 417).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 417).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox10.Value = answers.Where(x => x.QuestionId == 418).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 418).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox10.Value = answers.Where(x => x.QuestionId == 419).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 419).FirstOrDefault().AnsDes : "";
            this.noteTextbox10.Value = answers.Where(x => x.QuestionId == 420).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 420).FirstOrDefault().AnsDes : "";
            this.toolsListTextbox11.Value = answers.Where(x => x.QuestionId == 421).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 421).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox11.Value = answers.Where(x => x.QuestionId == 422).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 422).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox11.Value = answers.Where(x => x.QuestionId == 423).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 423).FirstOrDefault().AnsDes : "";
            this.noteTextbox11.Value = answers.Where(x => x.QuestionId == 424).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 424).FirstOrDefault().AnsDes : "";
            this.toolsListTextbox12.Value = answers.Where(x => x.QuestionId == 425).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 425).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox12.Value = answers.Where(x => x.QuestionId == 426).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 426).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox12.Value = answers.Where(x => x.QuestionId == 427).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 427).FirstOrDefault().AnsDes : "";
            this.noteTextbox12.Value = answers.Where(x => x.QuestionId == 428).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 428).FirstOrDefault().AnsDes : "";
            this.toolsListTextbox13.Value = answers.Where(x => x.QuestionId == 429).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 429).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox13.Value = answers.Where(x => x.QuestionId == 430).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 430).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox13.Value = answers.Where(x => x.QuestionId == 431).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 431).FirstOrDefault().AnsDes : "";
            this.noteTextbox13.Value = answers.Where(x => x.QuestionId == 432).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 432).FirstOrDefault().AnsDes : "";
            this.toolsListTextbox14.Value = answers.Where(x => x.QuestionId == 433).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 433).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox14.Value = answers.Where(x => x.QuestionId == 434).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 434).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox14.Value = answers.Where(x => x.QuestionId == 435).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 435).FirstOrDefault().AnsDes : "";
            this.noteTextbox14.Value = answers.Where(x => x.QuestionId == 436).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 436).FirstOrDefault().AnsDes : "";
            this.toolsListTextbox15.Value = answers.Where(x => x.QuestionId == 437).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 437).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox15.Value = answers.Where(x => x.QuestionId == 438).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 438).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox15.Value = answers.Where(x => x.QuestionId == 439).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 439).FirstOrDefault().AnsDes : "";
            this.noteTextbox15.Value = answers.Where(x => x.QuestionId == 440).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 440).FirstOrDefault().AnsDes : "";
            this.nameDopmTextbox.Value = answers.Where(x => x.QuestionId == 441).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 441).FirstOrDefault().AnsDes : "";
            this.dayDopmTextbox.Value = answers.Where(x => x.QuestionId == 442).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 442).FirstOrDefault().AnsDes : "";
     



































        }
    }
}