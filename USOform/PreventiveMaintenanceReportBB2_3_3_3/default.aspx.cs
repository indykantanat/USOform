
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

namespace USOform.PreventiveMaintenanceReportBB2._3_3._3
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




            ///---------------section 44 ----------------////
            var ans483 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 483).FirstOrDefault();
            if (ans483 == null)

            {
                //1: logoPicture
                if (this.logoPictureOga.HasFile)
                {
                    string extension = this.logoPictureOga.PostedFile.FileName.Split('.')[1];
                    string newFileName = "images/logoImages_bb_2_3_3_3_" + DateTime.Now.ToString("yyyyMMddHHmmss") + "." + extension;
                    this.logoPictureOga.PostedFile.SaveAs(Server.MapPath(newFileName));

                    Answer answe264 = new Answer()
                    {
                        AnsDes = newFileName,
                        QuestionId = 483,
                        AnserTypeId = 3,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth,
                        SRId = sR.Id
                    };
                    uSOEntities.Answers.Add(answe264);
                }
            }
            else
            {
                if (this.logoPictureOga.HasFile)
                {
                    string extension = this.logoPictureOga.PostedFile.FileName.Split('.')[1];
                    string newFileName = "images/logoImages_bb_2_3_3_3_" + DateTime.Now.ToString("yyyyMMddHHmmss") + "." + extension;
                    this.logoPictureOga.PostedFile.SaveAs(Server.MapPath(newFileName));
                    ans483.QuestionId = 483;
                    ans483.AnsDes = newFileName;
                    ans483.AnserTypeId = 3;
                    ans483.CreateDate = DateTime.Now;
                    ans483.UserId = user.Id;
                    ans483.AnsMonth = ansMonth; ans483.SRId = sR.Id;
                }
            }






            var ans484 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 484).FirstOrDefault();
            if (ans484 == null)
            {
                // กลุ่ม
                Answer answer1409 = new Answer()
                {
                    AnsDes = this.groupTextbox.Value,
                    QuestionId = 484,
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
                ans484.QuestionId = 484;
                ans484.AnsDes = this.groupTextbox.Value;
                ans484.AnserTypeId = 1;
                ans484.CreateDate = DateTime.Now;
                ans484.UserId = user.Id;
                ans484.AnsMonth = ansMonth; ans484.SRId = sR.Id;

            }




            var ans485 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 485).FirstOrDefault();
            if (ans485 == null)
            {
                // ภูมิภาค
                Answer answer1410 = new Answer()
                {
                    AnsDes = this.AreaTextbox.Value,
                    QuestionId = 485,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer1410);
            }
            else
            {
                ans485.QuestionId = 485;
                ans485.AnsDes = this.AreaTextbox.Value;
                ans485.AnserTypeId = 1;
                ans485.CreateDate = DateTime.Now;
                ans485.UserId = user.Id;
                ans485.AnsMonth = ansMonth; ans485.SRId = sR.Id;

            }



            var ans486 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 486).FirstOrDefault();
            if (ans486 == null)
            {
                // บริษัท
                Answer answer3 = new Answer()
                {
                    AnsDes = this.CompanyTextbox.Value,
                    QuestionId = 486,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer3);
            }
            else
            {
                ans486.QuestionId = 486;
                ans486.AnsDes = this.CompanyTextbox.Value;
                ans486.AnserTypeId = 1;
                ans486.CreateDate = DateTime.Now;
                ans486.UserId = user.Id;
                ans486.AnsMonth = ansMonth; ans486.SRId = sR.Id;

            }



            var ans487 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 487).FirstOrDefault();
            if (ans487 == null)
            {

                //ส่วนที่ 1 การจัดให้มีบริการอินเทอร์เน็ตความเร็วสูง (Broadband Internet Service :
                string seLectOptionRadio = Request.Form["seLectOptionRadio"];
                Answer answer31 = new Answer()
                {
                    AnsDes = seLectOptionRadio,
                    QuestionId = 487,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer31);
            }
            else
            {
                string varibles = Request.Form["seLectOptionRadio"];
                ans487.QuestionId = 487;
                ans487.AnsDes = varibles;
                ans487.AnserTypeId = 4;
                ans487.CreateDate = DateTime.Now;
                ans487.UserId = user.Id;
                ans487.AnsMonth = ansMonth; ans487.SRId = sR.Id;

            }




            var ans488 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 488).FirstOrDefault();
            if (ans488 == null)
            {

                //รอบการบำรุงรักษาครั้งที่
                Answer answer4 = new Answer()
                {
                    AnsDes = this.maintenanceCountTextbox.Value,
                    QuestionId = 488,
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
                ans488.QuestionId = 488;
                ans488.AnsDes = this.maintenanceCountTextbox.Value;
                ans488.AnserTypeId = 1;
                ans488.CreateDate = DateTime.Now;
                ans488.UserId = user.Id;
                ans488.AnsMonth = ansMonth; ans488.SRId = sR.Id;

            }


            var ans489 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 489).FirstOrDefault();
            if (ans489 == null)
            {

                //ปีพุทธศักราช
                Answer answer5 = new Answer()
                {
                    AnsDes = this.yearTextbox.Value,
                    QuestionId = 489,
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
                ans489.QuestionId = 489;
                ans489.AnsDes = this.yearTextbox.Value;
                ans489.AnserTypeId = 1;
                ans489.CreateDate = DateTime.Now;
                ans489.UserId = user.Id;
                ans489.AnsMonth = ansMonth; ans489.SRId = sR.Id;

            }


            var ans490 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 490).FirstOrDefault();
            if (ans490 == null)
            {

                //วัน เดือน ปี ที่เริ่มต้น
                Answer answer8 = new Answer()
                {
                    AnsDes = this.startDatepicker.Value,
                    QuestionId = 490,
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
                ans490.QuestionId = 490;
                ans490.AnsDes = this.startDatepicker.Value;
                ans490.AnserTypeId = 1;
                ans490.CreateDate = DateTime.Now;
                ans490.UserId = user.Id;
                ans490.AnsMonth = ansMonth; ans490.SRId = sR.Id;

            }



            var ans491 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 491).FirstOrDefault();
            if (ans491 == null)
            {

                //ถึง 
                Answer answer9 = new Answer()
                {
                    AnsDes = this.endDatepicker.Value,
                    QuestionId = 491,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id

                };
                uSOEntities.Answers.Add(answer9);
            }
            else
            {
                ans491.QuestionId = 491;
                ans491.AnsDes = this.endDatepicker.Value;
                ans491.AnserTypeId = 1;
                ans491.CreateDate = DateTime.Now;
                ans491.UserId = user.Id;
                ans491.AnsMonth = ansMonth; ans491.SRId = sR.Id;

            }




            var ans1640 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 1640).FirstOrDefault();
            if (ans1640 == null)
            {

                //สถานที่ SITE CODE
                Answer answer10 = new Answer()
                {
                    AnsDes = this.siteCodeTextbox.Value,
                    QuestionId = 1640,
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
                ans1640.QuestionId = 1640;
                ans1640.AnsDes = this.siteCodeTextbox.Value;
                ans1640.AnserTypeId = 1;
                ans1640.CreateDate = DateTime.Now;
                ans1640.UserId = user.Id;
                ans1640.AnsMonth = ansMonth; ans1640.SRId = sR.Id;

            }

            ///--------------------   END  SECTION 44  --------------------//



            //------------------ secion 45   ----------------------------//


            var ans492 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 492).FirstOrDefault();
            if (ans492 == null)
            {

                //Cabinet ID:
                Answer answer11 = new Answer()
                {
                    AnsDes = this.cabinetIdTextbox.Value,
                    QuestionId = 492,
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
                ans492.QuestionId = 492;
                ans492.AnsDes = this.cabinetIdTextbox.Value;
                ans492.AnserTypeId = 1;
                ans492.CreateDate = DateTime.Now;
                ans492.UserId = user.Id;
                ans492.AnsMonth = ansMonth; ans492.SRId = sR.Id;

            }




            var ans493 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 493).FirstOrDefault();
            if (ans493 == null)
            {

                //Site Code :
                Answer answer12 = new Answer()
                {
                    AnsDes = this.sitecodeTextboxSection2.Value,
                    QuestionId = 493,
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
                ans493.QuestionId = 493;
                ans493.AnsDes = this.sitecodeTextboxSection2.Value;
                ans493.AnserTypeId = 1;
                ans493.CreateDate = DateTime.Now;
                ans493.UserId = user.Id;
                ans493.AnsMonth = ansMonth; ans493.SRId = sR.Id;

            }


            var ans494 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 494).FirstOrDefault();
            if (ans494 == null)
            {

                //Village ID :
                Answer answer13 = new Answer()
                {
                    AnsDes = this.VillageIdTextbox.Value,
                    QuestionId = 494,
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
                ans494.QuestionId = 494;
                ans494.AnsDes = this.VillageIdTextbox.Value;
                ans494.AnserTypeId = 1;
                ans494.CreateDate = DateTime.Now;
                ans494.UserId = user.Id;
                ans494.AnsMonth = ansMonth; ans494.SRId = sR.Id;

            }





            var ans495 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 495).FirstOrDefault();
            if (ans495 == null)
            {

                //Village  :
                Answer answer14 = new Answer()
                {
                    AnsDes = this.villageTextbox.Value,
                    QuestionId = 495,
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
                ans495.QuestionId = 495;
                ans495.AnsDes = this.villageTextbox.Value;
                ans495.AnserTypeId = 1;
                ans495.CreateDate = DateTime.Now;
                ans495.UserId = user.Id;
                ans495.AnsMonth = ansMonth; ans495.SRId = sR.Id;

            }



            var ans496 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 496).FirstOrDefault();
            if (ans496 == null)
            {

                //SChool’s Name : :
                Answer answer275 = new Answer()
                {
                    AnsDes = this.schoolNameTextbox.Value,
                    QuestionId = 496,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer275);
            }
            else
            {
                ans496.QuestionId = 496;
                ans496.AnsDes = this.schoolNameTextbox.Value;
                ans496.AnserTypeId = 1;
                ans496.CreateDate = DateTime.Now;
                ans496.UserId = user.Id;
                ans496.AnsMonth = ansMonth; ans496.SRId = sR.Id;

            }



            var ans497 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 497).FirstOrDefault();
            if (ans497 == null)
            {

                //Sub-District :
                Answer answer16 = new Answer()
                {
                    AnsDes = this.subdistrictTextbox.Value,
                    QuestionId = 497,
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
                ans497.QuestionId = 497;
                ans497.AnsDes = this.subdistrictTextbox.Value;
                ans497.AnserTypeId = 1;
                ans497.CreateDate = DateTime.Now;
                ans497.UserId = user.Id;
                ans497.AnsMonth = ansMonth; ans497.SRId = sR.Id;

            }



            var ans498 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 498).FirstOrDefault();
            if (ans498 == null)
            {

                //District :
                Answer answer1423 = new Answer()
                {
                    AnsDes = this.DistrictTextboxEIEI.Value,
                    QuestionId = 498,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer1423);
            }
            else
            {
                ans498.QuestionId = 498;
                ans498.AnsDes = this.DistrictTextboxEIEI.Value;
                ans498.AnserTypeId = 1;
                ans498.CreateDate = DateTime.Now;
                ans498.UserId = user.Id;
                ans498.AnsMonth = ansMonth; ans498.SRId = sR.Id;

            }

            var ans499 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 499).FirstOrDefault();
            if (ans499 == null)
            {

                //Province :
                Answer answer17 = new Answer()
                {
                    AnsDes = this.provinceTextbox.Value,
                    QuestionId = 499,
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
                ans499.QuestionId = 499;
                ans499.AnsDes = this.provinceTextbox.Value;
                ans499.AnserTypeId = 1;
                ans499.CreateDate = DateTime.Now;
                ans499.UserId = user.Id;
                ans499.AnsMonth = ansMonth; ans499.SRId = sR.Id;

            }


            var ans500 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 500).FirstOrDefault();
            if (ans500 == null)
            {

                //Type :
                Answer answer18 = new Answer()
                {
                    AnsDes = this.typeTextbox.Value,
                    QuestionId = 500,
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
                ans500.QuestionId = 500;
                ans500.AnsDes = this.typeTextbox.Value;
                ans500.AnserTypeId = 1;
                ans500.CreateDate = DateTime.Now;
                ans500.UserId = user.Id;
                ans500.AnsMonth = ansMonth; ans500.SRId = sR.Id;

            }


            var ans501 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 501).FirstOrDefault();
            if (ans501 == null)
            {
                //PM Date :
                Answer answer19 = new Answer()
                {
                    AnsDes = this.pmdateTextbox.Value,
                    QuestionId = 501,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer19);
            }
            else
            {
                ans501.QuestionId = 501;
                ans501.AnsDes = this.pmdateTextbox.Value;
                ans501.AnserTypeId = 1;
                ans501.CreateDate = DateTime.Now;
                ans501.UserId = user.Id;
                ans501.AnsMonth = ansMonth; ans501.SRId = sR.Id;

            }







            var ans502 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 502).FirstOrDefault();
            if (ans502 == null)

            {
                //ใส่ป้ายหน้าโรงเรียน :
                if (this.picinfrontImages.HasFile)
                {
                    string extension = this.picinfrontImages.PostedFile.FileName.Split('.')[1];
                    string newFileName = "images/siteboardschool_Images_bb_2_3_3_3_" + DateTime.Now.ToString("yyyyMMddHHmmss") + "." + extension;
                    this.picinfrontImages.PostedFile.SaveAs(Server.MapPath(newFileName));

                    Answer answer20 = new Answer()
                    {
                        AnsDes = newFileName,
                        QuestionId = 502,
                        AnserTypeId = 3,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth,
                        SRId = sR.Id
                    };
                    uSOEntities.Answers.Add(answer20);
                }

            }
            else
            {
                if (this.picinfrontImages.HasFile)
                {
                    string extension = this.picinfrontImages.PostedFile.FileName.Split('.')[1];
                    string newFileName = "images/siteboardschool_Images_bb_2_3_3_3_" + DateTime.Now.ToString("yyyyMMddHHmmss") + "." + extension;
                    this.picinfrontImages.PostedFile.SaveAs(Server.MapPath(newFileName));
                    ans502.QuestionId = 502;
                    ans502.AnsDes = newFileName;
                    ans502.AnserTypeId = 3;
                    ans502.CreateDate = DateTime.Now;
                    ans502.UserId = user.Id;
                    ans502.AnsMonth = ansMonth; ans502.SRId = sR.Id;
                }
            }




            var ans503 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 503).FirstOrDefault();
            if (ans503 == null)

            {
                //รูปบริเวณห้องบริการ WiFi - Computer :
                if (this.wifiHallImages.HasFile)
                {
                    string extension = this.wifiHallImages.PostedFile.FileName.Split('.')[1];
                    string newFileName = "images/wificomputerimages_bb_2_3_3_" + DateTime.Now.ToString("yyyyMMddHHmmss") + "." + extension;
                    this.wifiHallImages.PostedFile.SaveAs(Server.MapPath(newFileName));

                    Answer answer20 = new Answer()
                    {
                        AnsDes = newFileName,
                        QuestionId = 503,
                        AnserTypeId = 3,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth,
                        SRId = sR.Id
                    };
                    uSOEntities.Answers.Add(answer20);
                }

            }
            else
            {
                if (this.wifiHallImages.HasFile)
                {
                    string extension = this.wifiHallImages.PostedFile.FileName.Split('.')[1];
                    string newFileName = "images/wificomputerimages_bb_2_3_3_" + DateTime.Now.ToString("yyyyMMddHHmmss") + "." + extension;
                    this.wifiHallImages.PostedFile.SaveAs(Server.MapPath(newFileName));
                    ans503.QuestionId = 503;
                    ans503.AnsDes = newFileName;
                    ans503.AnserTypeId = 3;
                    ans503.CreateDate = DateTime.Now;
                    ans503.UserId = user.Id;
                    ans503.AnsMonth = ansMonth; ans503.SRId = sR.Id;
                }
            }




            var ans504 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 504).FirstOrDefault();
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
            
            string anseeiei = string.Format("images/{0}", filename);


            int mod1428 = sx.Length % 4;
            if (mod1428 > 0)
            {
                sx += new string('=', 4 - mod1428);
            }
            if (ans504 == null)
            {
                //signature Executor :
                Answer answer21 = new Answer()
                {
                    AnsDes = anseeiei,
                    QuestionId = 504,
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
                ans504.QuestionId = 504;
                ans504.AnsDes = anseeiei;
                ans504.AnserTypeId = 1;
                ans504.CreateDate = DateTime.Now;
                ans504.UserId = user.Id;
                ans504.AnsMonth = ansMonth; ans504.SRId = sR.Id;

            }







            var ans505 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 505).FirstOrDefault();
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
            string asn505eiei = string.Format("images/{0}", filename2);
            int mod4 = s.Length % 4;
            if (mod4 > 0)
            {
                s += new string('=', 4 - mod4);
            }
            if (ans505 == null)
            {
                //signature Supervisor :
                Answer answer22 = new Answer()
                {
                    AnsDes = asn505eiei,
                    QuestionId = 505,
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
                ans505.QuestionId = 505;
                ans505.AnsDes = asn505eiei;
                ans505.AnserTypeId = 3;
                ans505.CreateDate = DateTime.Now;
                ans505.UserId = user.Id;
                ans505.AnsMonth = ansMonth;
                ans505.SRId = sR.Id;

            }





            var ans506 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 506).FirstOrDefault();
            if (ans506 == null)
            {

                //name Executor  :
                Answer answer23 = new Answer()
                {
                    AnsDes = this.nameExecutorTextbox.Value,
                    QuestionId = 506,
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
                ans506.QuestionId = 506;
                ans506.AnsDes = this.nameExecutorTextbox.Value;
                ans506.AnserTypeId = 1;
                ans506.CreateDate = DateTime.Now;
                ans506.UserId = user.Id;
                ans506.AnsMonth = ansMonth; ans506.SRId = sR.Id;

            }



            var ans507 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 507).FirstOrDefault();
            if (ans507 == null)
            {

                //name Supervisor :
                Answer answer24 = new Answer()
                {
                    AnsDes = this.nameSupervisorTextbox.Value,
                    QuestionId = 507,
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
                ans507.QuestionId = 507;
                ans507.AnsDes = this.nameSupervisorTextbox.Value;
                ans507.AnserTypeId = 1;
                ans507.CreateDate = DateTime.Now;
                ans507.UserId = user.Id;
                ans507.AnsMonth = ansMonth; ans507.SRId = sR.Id;

            }



            var ans508 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 508).FirstOrDefault();
            if (ans508 == null)
            {


                //Date Executor :
                Answer answer25 = new Answer()
                {
                    AnsDes = this.DateExecutorTextbox.Value,
                    QuestionId = 508,
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
                ans508.QuestionId = 508;
                ans508.AnsDes = this.DateExecutorTextbox.Value;
                ans508.AnserTypeId = 1;
                ans508.CreateDate = DateTime.Now;
                ans508.UserId = user.Id;
                ans508.AnsMonth = ansMonth; ans508.SRId = sR.Id;

            }




            var ans509 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 509).FirstOrDefault();
            if (ans509 == null)
            {
                //Date Supervisor :
                Answer answer26 = new Answer()
                {
                    AnsDes = this.DateSupervisorTextbox.Value,
                    QuestionId = 509,
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
                ans509.QuestionId = 509;
                ans509.AnsDes = this.DateSupervisorTextbox.Value;
                ans509.AnserTypeId = 1;
                ans509.CreateDate = DateTime.Now;
                ans509.UserId = user.Id;
                ans509.AnsMonth = ansMonth; ans509.SRId = sR.Id;

            }





            var ans510 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 510).FirstOrDefault();
            if (ans510 == null)
            {
                //cabibnet  :
                Answer answer27 = new Answer()
                {
                    AnsDes = this.cabinetId2Textbox.Value,
                    QuestionId = 510,
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
                ans510.QuestionId = 510;
                ans510.AnsDes = this.cabinetId2Textbox.Value;
                ans510.AnserTypeId = 1;
                ans510.CreateDate = DateTime.Now;
                ans510.UserId = user.Id;
                ans510.AnsMonth = ansMonth; ans510.SRId = sR.Id;

            }






            var ans511 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 511).FirstOrDefault();
            if (ans511 == null)
            {
                //Site code section 4 :
                Answer answer28 = new Answer()
                {
                    AnsDes = this.sitecodeTextboxSection4.Value,
                    QuestionId = 511,
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
                ans511.QuestionId = 511;
                ans511.AnsDes = this.sitecodeTextboxSection4.Value;
                ans511.AnserTypeId = 1;
                ans511.CreateDate = DateTime.Now;
                ans511.UserId = user.Id;
                ans511.AnsMonth = ansMonth; ans511.SRId = sR.Id;

            }



            var ans512 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 512).FirstOrDefault();
            if (ans512 == null)
            {
                //villageIDsection 4 :
                Answer answer29 = new Answer()
                {
                    AnsDes = this.villageIDTextboxSection4.Value,
                    QuestionId = 512,
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
                ans512.QuestionId = 512;
                ans512.AnsDes = this.villageIDTextboxSection4.Value;
                ans512.AnserTypeId = 1;
                ans512.CreateDate = DateTime.Now;
                ans512.UserId = user.Id;
                ans512.AnsMonth = ansMonth; ans512.SRId = sR.Id;

            }



            var ans513 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 513).FirstOrDefault();
            if (ans513 == null)
            {
                //lat and long  :
                Answer answer30 = new Answer()
                {
                    AnsDes = this.latandlongTextbox.Value,
                    QuestionId = 513,
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
                ans513.QuestionId = 513;
                ans513.AnsDes = this.latandlongTextbox.Value;
                ans513.AnserTypeId = 1;
                ans513.CreateDate = DateTime.Now;
                ans513.UserId = user.Id;
                ans513.AnsMonth = ansMonth; ans513.SRId = sR.Id;

            }






            var ans514 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 514).FirstOrDefault();
            if (ans514 == null)
            {
                //TypeofSignal :
                string typeOf = Request.Form["TypeofSignaleieiRadio"];
                Answer answer514 = new Answer()
                {
                    AnsDes = typeOf,
                    QuestionId = 514,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer514);
            }
            else
            {
                string varibles = Request.Form["TypeofSignaleieiRadio"];
                ans514.QuestionId = 514;
                ans514.AnsDes = varibles;
                ans514.AnserTypeId = 4;
                ans514.CreateDate = DateTime.Now;
                ans514.UserId = user.Id;
                ans514.AnsMonth = ansMonth; ans514.SRId = sR.Id;

            }



            var ans515 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 515).FirstOrDefault();
            if (ans515 == null)
            {
                //OLT ID : :
                Answer answer1440 = new Answer()
                {
                    AnsDes = this.oltIdTextbox.Value,
                    QuestionId = 515,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer1440);
            }
            else
            {
                ans515.QuestionId = 515;
                ans515.AnsDes = this.oltIdTextbox.Value;
                ans515.AnserTypeId = 4;
                ans515.CreateDate = DateTime.Now;
                ans515.UserId = user.Id;
                ans515.AnsMonth = ansMonth; ans515.SRId = sR.Id;

            }




            var ans516 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 516).FirstOrDefault();
            if (ans516 == null)
            {
                //ระบบไฟฟ้า :
                string typeOffire = Request.Form["voltSystemRadio"];
                Answer answer294 = new Answer()
                {
                    AnsDes = typeOffire,
                    QuestionId = 516,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer294);
            }
            else
            {
                string varibles = Request.Form["voltSystemRadio"];
                ans516.QuestionId = 516;
                ans516.AnsDes = varibles;
                ans516.AnserTypeId = 4;
                ans516.CreateDate = DateTime.Now;
                ans516.UserId = user.Id;
                ans516.AnsMonth = ansMonth; ans516.SRId = sR.Id;

            }







            var ans517 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 517).FirstOrDefault();
            if (ans517 == null)
            {
                //หมายเลขผู้ใช้ไฟ:
                Answer answer1442 = new Answer()
                {
                    AnsDes = this.numberIdTextbox.Value,
                    QuestionId = 517,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer1442);
            }
            else
            {

                ans517.QuestionId = 517;
                ans517.AnsDes = this.numberIdTextbox.Value;
                ans517.AnserTypeId = 4;
                ans517.CreateDate = DateTime.Now;
                ans517.UserId = user.Id;
                ans517.AnsMonth = ansMonth; ans517.SRId = sR.Id;

            }




            var ans518 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 518).FirstOrDefault();
            if (ans518 == null)
            {
                //หน่วยใช้ไฟไฟ  :
                Answer answer36 = new Answer()
                {
                    AnsDes = this.kwhMeterTextbox.Value,
                    QuestionId = 518,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer36);
            }
            else
            {

                ans518.QuestionId = 518;
                ans518.AnsDes = this.kwhMeterTextbox.Value;
                ans518.AnserTypeId = 4;
                ans518.CreateDate = DateTime.Now;
                ans518.UserId = user.Id;
                ans518.AnsMonth = ansMonth; ans518.SRId = sR.Id;

            }



            var ans519 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 519).FirstOrDefault();
            if (ans519 == null)
            {
                //แรงดัน AC (kWh Meter) :
                Answer answer37 = new Answer()
                {
                    AnsDes = this.acvoltTextbox.Value,
                    QuestionId = 519,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer37);
            }
            else
            {

                ans519.QuestionId = 519;
                ans519.AnsDes = this.acvoltTextbox.Value;
                ans519.AnserTypeId = 4;
                ans519.CreateDate = DateTime.Now;
                ans519.UserId = user.Id;
                ans519.AnsMonth = ansMonth; ans519.SRId = sR.Id;

            }





            var ans520 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 520).FirstOrDefault();
            if (ans520 == null)
            {
                //กระแส Line AC (kWh Meter) :
                Answer answer38 = new Answer()
                {
                    AnsDes = this.lineAcTextbox.Value,
                    QuestionId = 520,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer38);
            }
            else
            {

                ans520.QuestionId = 520;
                ans520.AnsDes = this.lineAcTextbox.Value;
                ans520.AnserTypeId = 4;
                ans520.CreateDate = DateTime.Now;
                ans520.UserId = user.Id;
                ans520.AnsMonth = ansMonth; ans520.SRId = sR.Id;

            }




            var ans521 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 521).FirstOrDefault();
            if (ans521 == null)
            {
                // กระแส Neutron AC(kWh Meter) :          
                Answer answer39 = new Answer()
                {
                    AnsDes = this.neutronAcEIEITextbox.Value,
                    QuestionId = 521,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer39);
            }
            else
            {

                ans521.QuestionId = 521;
                ans521.AnsDes = this.neutronAcEIEITextbox.Value;
                ans521.AnserTypeId = 4;
                ans521.CreateDate = DateTime.Now;
                ans521.UserId = user.Id;
                ans521.AnsMonth = ansMonth; ans521.SRId = sR.Id;

            }




            var ans522 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 522).FirstOrDefault();
            if (ans522 == null)
            {
                //สภาพ kWh Meter Radio  :
                string conRadio = Request.Form["conditionRadio"];
                Answer answer40 = new Answer()
                {
                    AnsDes = conRadio,
                    QuestionId = 522,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer40);
            }
            else
            {
                string varibles = Request.Form["conditionRadio"];
                ans522.QuestionId = 522;
                ans522.AnsDes = varibles;
                ans522.AnserTypeId = 4;
                ans522.CreateDate = DateTime.Now;
                ans522.UserId = user.Id;
                ans522.AnsMonth = ansMonth; ans522.SRId = sR.Id;

            }






            var ans523 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 523).FirstOrDefault();
            if (ans523 == null)
            {
                //สภาพ MDB/ Circuit Breaker Radio  :
                string CircuitBreakerRadio = Request.Form["MDBCircuitBreakerRadio"];
                Answer answer41 = new Answer()
                {
                    AnsDes = CircuitBreakerRadio,
                    QuestionId = 523,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer41);
            }
            else
            {
                string varibles = Request.Form["MDBCircuitBreakerRadio"];
                ans523.QuestionId = 523;
                ans523.AnsDes = varibles;
                ans523.AnserTypeId = 4;
                ans523.CreateDate = DateTime.Now;
                ans523.UserId = user.Id;
                ans523.AnsMonth = ansMonth; ans523.SRId = sR.Id;

            }



            var ans524 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 524).FirstOrDefault();
            if (ans524 == null)
            {
                //UPS ภายในตู้ Radio  :
                string innerUPS = Request.Form["inupsRadio"];
                Answer answer42 = new Answer()
                {
                    AnsDes = innerUPS,
                    QuestionId = 524,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer42);
            }
            else
            {
                string varibles = Request.Form["inupsRadio"];
                ans524.QuestionId = 524;
                ans524.AnsDes = varibles;
                ans524.AnserTypeId = 4;
                ans524.CreateDate = DateTime.Now;
                ans524.UserId = user.Id;
                ans524.AnsMonth = ansMonth; ans524.SRId = sR.Id;

            }




            var ans525 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 525).FirstOrDefault();
            if (ans525 == null)
            {
                // AC from UPS :          
                Answer answer43 = new Answer()
                {
                    AnsDes = this.acfromupsTextbox.Value,
                    QuestionId = 525,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer43);
            }
            else
            {

                ans525.QuestionId = 525;
                ans525.AnsDes = this.acfromupsTextbox.Value;
                ans525.AnserTypeId = 4;
                ans525.CreateDate = DateTime.Now;
                ans525.UserId = user.Id;
                ans525.AnsMonth = ansMonth; ans525.SRId = sR.Id;

            }






            var ans526 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 526).FirstOrDefault();
            if (ans526 == null)
            {
                // กระเเส โหลด :  
                string emergen = Request.Form["voltageLoadRadio"];
                Answer answer45 = new Answer()
                {
                    AnsDes = emergen,
                    QuestionId = 526,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer45);
            }
            else
            {
                string varibles = Request.Form["voltageLoadRadio"];
                ans526.QuestionId = 526;
                ans526.AnsDes = varibles;
                ans526.AnserTypeId = 4;
                ans526.CreateDate = DateTime.Now;
                ans526.UserId = user.Id;
                ans526.AnsMonth = ansMonth; ans526.SRId = sR.Id;

            }




            var ans527 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 527).FirstOrDefault();
            if (ans527 == null)
            {
                // ระดับความจุ Battery :  
                string emerbat = Request.Form["batteryCapacityRadio"];
                Answer answer1452 = new Answer()
                {
                    AnsDes = emerbat,
                    QuestionId = 527,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer1452);
            }
            else
            {
                string varibles = Request.Form["batteryCapacityRadio"];
                ans527.QuestionId = 527;
                ans527.AnsDes = varibles;
                ans527.AnserTypeId = 4;
                ans527.CreateDate = DateTime.Now;
                ans527.UserId = user.Id;
                ans527.AnsMonth = ansMonth; ans527.SRId = sR.Id;

            }





            var ans528 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 528).FirstOrDefault();
            if (ans528 == null)
            {
                // UPS MODE :  
                string UPSMODE = Request.Form["upsModeRadio"];
                Answer answer1453 = new Answer()
                {
                    AnsDes = UPSMODE,
                    QuestionId = 528,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer1453);
            }
            else
            {
                string varibles = Request.Form["upsModeRadio"];
                ans528.QuestionId = 528;
                ans528.AnsDes = varibles;
                ans528.AnserTypeId = 4;
                ans528.CreateDate = DateTime.Now;
                ans528.UserId = user.Id;
                ans526.AnsMonth = ansMonth; ans526.SRId = sR.Id;

            }





            var ans529 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 529).FirstOrDefault();
            if (ans529 == null)
            {
                // การทำงานของระบบไฟสำรอง :  
                string secondFireRadio1 = Request.Form["secondFireRadio"];
                Answer answer1454 = new Answer()
                {
                    AnsDes = secondFireRadio1,
                    QuestionId = 529,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer1454);
            }
            else
            {
                string varibles = Request.Form["secondFireRadio"];
                ans529.QuestionId = 529;
                ans529.AnsDes = varibles;
                ans529.AnserTypeId = 4;
                ans529.CreateDate = DateTime.Now;
                ans529.UserId = user.Id;
                ans529.AnsMonth = ansMonth; ans529.SRId = sR.Id;

            }



            var ans530 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 530).FirstOrDefault();
            if (ans530 == null)
            {
                // สภาพ Battery Bank :  
                string Batterybank = Request.Form["batterybankRadio"];
                Answer answer1455 = new Answer()
                {
                    AnsDes = Batterybank,
                    QuestionId = 530,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer1455);
            }
            else
            {
                string varibles = Request.Form["batterybankRadio"];
                ans530.QuestionId = 530;
                ans530.AnsDes = varibles;
                ans530.AnserTypeId = 4;
                ans530.CreateDate = DateTime.Now;
                ans530.UserId = user.Id;
                ans530.AnsMonth = ansMonth; ans530.SRId = sR.Id;

            }



            var ans531 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 531).FirstOrDefault();
            if (ans531 == null)
            {
                // ONU/Modem Network :  
                string ONUModemNetwork = Request.Form["ONUModemNetworkRadio"];
                Answer answer1456 = new Answer()
                {
                    AnsDes = ONUModemNetwork,
                    QuestionId = 531,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer1456);
            }
            else
            {
                string varibles = Request.Form["ONUModemNetworkRadio"];
                ans531.QuestionId = 531;
                ans531.AnsDes = varibles;
                ans531.AnserTypeId = 4;
                ans531.CreateDate = DateTime.Now;
                ans531.UserId = user.Id;
                ans531.AnsMonth = ansMonth; ans531.SRId = sR.Id;

            }



            var ans532 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 532).FirstOrDefault();
            if (ans532 == null)
            {
                // Power Supply (for Switch) :  
                string femto = Request.Form["psuForswitchRadio"];
                Answer answer1457 = new Answer()
                {
                    AnsDes = femto,
                    QuestionId = 532,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer1457);
            }
            else
            {
                string varibles = Request.Form["psuForswitchRadio"];
                ans532.QuestionId = 532;
                ans532.AnsDes = varibles;
                ans532.AnserTypeId = 4;
                ans532.CreateDate = DateTime.Now;
                ans532.UserId = user.Id;
                ans532.AnsMonth = ansMonth; ans532.SRId = sR.Id;

            }






            var ans533 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 533).FirstOrDefault();
            if (ans533 == null)
            {
                // Switch 8 Port :  
                string femtoanswer = Request.Form["switchPortRadio"];
                Answer answer1458 = new Answer()
                {
                    AnsDes = femtoanswer,
                    QuestionId = 533,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer1458);
            }
            else
            {
                string varibles = Request.Form["switchPortRadio"];
                ans533.QuestionId = 533;
                ans533.AnsDes = varibles;
                ans533.AnserTypeId = 4;
                ans533.CreateDate = DateTime.Now;
                ans533.UserId = user.Id;
                ans533.AnsMonth = ansMonth; ans533.SRId = sR.Id;

            }







            var ans534 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 534).FirstOrDefault();
            if (ans534 == null)
            {
                // Outdoor AP 2.4 GH :  
                string tpower = Request.Form["OutdoorAP24Radio"];
                Answer answer1459 = new Answer()
                {
                    AnsDes = tpower,
                    QuestionId = 534,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer1459);
            }
            else
            {
                string varibles = Request.Form["OutdoorAP24Radio"];
                ans534.QuestionId = 534;
                ans534.AnsDes = varibles;
                ans534.AnserTypeId = 4;
                ans534.CreateDate = DateTime.Now;
                ans534.UserId = user.Id;
                ans534.AnsMonth = ansMonth; ans534.SRId = sR.Id;

            }



            var ans535 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 535).FirstOrDefault();
            if (ans535 == null)
            {
                // Outdoor AP 5 GHz:  
                string wireingGround = Request.Form["OutdoorAP5GHzRadio"];
                Answer answer1460 = new Answer()
                {
                    AnsDes = wireingGround,
                    QuestionId = 535,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer1460);
            }
            else
            {
                string varibles = Request.Form["OutdoorAP5GHzRadio"];
                ans535.QuestionId = 535;
                ans535.AnsDes = varibles;
                ans535.AnserTypeId = 4;
                ans535.CreateDate = DateTime.Now;
                ans535.UserId = user.Id;
                ans535.AnsMonth = ansMonth; ans535.SRId = sR.Id;

            }




            var ans536 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 536).FirstOrDefault();
            if (ans536 == null)
            {
                //t-power :  
                string Wirinlan = Request.Form["tPowerRadio"];
                Answer answer1633 = new Answer()
                {
                    AnsDes = Wirinlan,
                    QuestionId = 536,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer1633);
            }
            else
            {
                string varibles = Request.Form["tPowerRadio"];
                ans536.QuestionId = 536;
                ans536.AnsDes = varibles;
                ans536.AnserTypeId = 4;
                ans536.CreateDate = DateTime.Now;
                ans536.UserId = user.Id;
                ans536.AnsMonth = ansMonth; ans536.SRId = sR.Id;

            }




            var ans537 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 537).FirstOrDefault();
            if (ans537 == null)
            {
                //การ Wiring สายไฟและสาย Ground :  
                string WiringGroundRadio = Request.Form["WiringGroundRadio"];
                Answer answer314 = new Answer()
                {
                    AnsDes = WiringGroundRadio,
                    QuestionId = 537,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer314);
            }
            else
            {
                string varibles = Request.Form["WiringGroundRadio"];
                ans537.QuestionId = 537;
                ans537.AnsDes = varibles;
                ans537.AnserTypeId = 4;
                ans537.CreateDate = DateTime.Now;
                ans537.UserId = user.Id;
                ans537.AnsMonth = ansMonth; ans537.SRId = sR.Id;

            }







            var ans538 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 538).FirstOrDefault();
            if (ans538 == null)
            {
                //การ Wiring สายไฟและสาย Ground :  
                string wirePatchRadio = Request.Form["wirePatchRadio"];
                Answer answer315 = new Answer()
                {
                    AnsDes = wirePatchRadio,
                    QuestionId = 538,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer315);
            }
            else
            {
                string varibles = Request.Form["wirePatchRadio"];
                ans538.QuestionId = 538;
                ans538.AnsDes = varibles;
                ans538.AnserTypeId = 4;
                ans538.CreateDate = DateTime.Now;
                ans538.UserId = user.Id;
                ans538.AnsMonth = ansMonth; ans538.SRId = sR.Id;

            }






            var ans539 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 539).FirstOrDefault();
            if (ans539 == null)
            {
                //ความแข็งแรงจุดต่อ Ground Bar :
                string gb = Request.Form["groundbarRadio"];
                Answer answer57 = new Answer()
                {
                    AnsDes = gb,
                    QuestionId = 539,
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
                string varibles = Request.Form["groundbarRadio"];
                ans539.QuestionId = 539;
                ans539.AnsDes = varibles;
                ans539.AnserTypeId = 4;
                ans539.CreateDate = DateTime.Now;
                ans539.UserId = user.Id;
                ans539.AnsMonth = ansMonth; ans539.SRId = sR.Id;

            }



            var ans540 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 540).FirstOrDefault();
            if (ans540 == null)
            {
                //ความแข็งแรงของน็อตขันหางปลาอุปกรณ์ :
                string fishnot = Request.Form["notfishRadio"];
                Answer answer58 = new Answer()
                {
                    AnsDes = fishnot,
                    QuestionId = 540,
                    AnserTypeId = 3,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer58);
            }
            else
            {
                string varibles = Request.Form["notfishRadio"];
                ans540.QuestionId = 540;
                ans540.AnsDes = varibles;
                ans540.AnserTypeId = 4;
                ans540.CreateDate = DateTime.Now;
                ans540.UserId = user.Id;
                ans540.AnsMonth = ansMonth; ans540.SRId = sR.Id;

            }




            var ans541 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 541).FirstOrDefault();
            if (ans541 == null)
            {
                //สายกราวด์เรียบร้อย ปลอดภัย สมบูรณ์ :
                string ffss = Request.Form["safegroundRadio"];
                Answer answer59 = new Answer()
                {
                    AnsDes = ffss,
                    QuestionId = 541,
                    AnserTypeId = 3,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer59);
            }
            else
            {
                string varibles = Request.Form["safegroundRadio"];
                ans541.QuestionId = 541;
                ans541.AnsDes = varibles;
                ans541.AnserTypeId = 4;
                ans541.CreateDate = DateTime.Now;
                ans541.UserId = user.Id;
                ans541.AnsMonth = ansMonth; ans541.SRId = sR.Id;

            }




            var ans542 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 542).FirstOrDefault();
            if (ans542 == null)
            {
                //สถานะไฟฟ้ารั่วลง Ground :
                string elecground = Request.Form["brokenElecRadio"];
                Answer answer60 = new Answer()
                {
                    AnsDes = elecground,
                    QuestionId = 542,
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
                string varibles = Request.Form["brokenElecRadio"];
                ans542.QuestionId = 542;
                ans542.AnsDes = varibles;
                ans542.AnserTypeId = 4;
                ans542.CreateDate = DateTime.Now;
                ans542.UserId = user.Id;
                ans542.AnsMonth = ansMonth; ans542.SRId = sR.Id;

            }



            var ans543 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 543).FirstOrDefault();
            if (ans543 == null)
            {
                // คอมพิวเตอร์ตัวที่ 1  :
                string com1 = Request.Form["ComRadio1"];
                Answer answer76 = new Answer()
                {
                    AnsDes = com1,
                    QuestionId = 543,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer76);
            }
            else
            {
                string varibles = Request.Form["ComRadio1"];
                ans543.QuestionId = 543;
                ans543.AnsDes = varibles;
                ans543.AnserTypeId = 4;
                ans543.CreateDate = DateTime.Now;
                ans543.UserId = user.Id;
                ans543.AnsMonth = ansMonth; ans543.SRId = sR.Id;

            }





            var ans544 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 544).FirstOrDefault();
            if (ans544 == null)
            {
                // คอมพิวเตอร์ตัวที่ 2  :
                string com2 = Request.Form["ComRadio2"];
                Answer answer78 = new Answer()
                {
                    AnsDes = com2,
                    QuestionId = 544,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer78);
            }
            else
            {
                string varibles = Request.Form["ComRadio2"];
                ans544.QuestionId = 544;
                ans544.AnsDes = varibles;
                ans544.AnserTypeId = 4;
                ans544.CreateDate = DateTime.Now;
                ans544.UserId = user.Id;
                ans544.AnsMonth = ansMonth; ans544.SRId = sR.Id;

            }




            var ans545 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 545).FirstOrDefault();
            if (ans545 == null)
            {
                // คอมพิวเตอร์ตัวที่ 3  :
                string com3 = Request.Form["ComRadio3"];
                Answer answer79 = new Answer()
                {
                    AnsDes = com3,
                    QuestionId = 545,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer79);
            }
            else
            {
                string varibles = Request.Form["ComRadio3"];
                ans545.QuestionId = 545;
                ans545.AnsDes = varibles;
                ans545.AnserTypeId = 4;
                ans545.CreateDate = DateTime.Now;
                ans545.UserId = user.Id;
                ans545.AnsMonth = ansMonth; ans545.SRId = sR.Id;

            }






            var ans546 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 546).FirstOrDefault();
            if (ans546 == null)
            {
                // คอมพิวเตอร์ตัวที่ 4  :
                string com4 = Request.Form["ComRadio4"];
                Answer answer80 = new Answer()
                {
                    AnsDes = com4,
                    QuestionId = 546,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer80);
            }
            else
            {
                string varibles = Request.Form["ComRadio4"];
                ans546.QuestionId = 546;
                ans546.AnsDes = varibles;
                ans546.AnserTypeId = 4;
                ans546.CreateDate = DateTime.Now;
                ans546.UserId = user.Id;
                ans546.AnsMonth = ansMonth; ans546.SRId = sR.Id;

            }


            var ans547 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 547).FirstOrDefault();
            if (ans547 == null)
            {
                // คอมพิวเตอร์ตัวที่ 5  :
                string com5 = Request.Form["ComRadio5"];
                Answer answer81 = new Answer()
                {
                    AnsDes = com5,
                    QuestionId = 547,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer81);
            }
            else
            {
                string varibles = Request.Form["ComRadio5"];
                ans547.QuestionId = 547;
                ans547.AnsDes = varibles;
                ans547.AnserTypeId = 4;
                ans547.CreateDate = DateTime.Now;
                ans547.UserId = user.Id;
                ans547.AnsMonth = ansMonth; ans547.SRId = sR.Id;

            }


            var ans548 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 548).FirstOrDefault();
            if (ans548 == null)
            {
                // UPS สำหรับคอมพิวเตอร์ตัวที่ 1 :
                string ups1 = Request.Form["upsRadio1"];
                Answer answer548 = new Answer()
                {
                    AnsDes = ups1,
                    QuestionId = 548,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer548);
            }
            else
            {
                string varibles = Request.Form["upsRadio1"];
                ans548.QuestionId = 548;
                ans548.AnsDes = varibles;
                ans548.AnserTypeId = 4;
                ans548.CreateDate = DateTime.Now;
                ans548.UserId = user.Id;
                ans548.AnsMonth = ansMonth; ans548.SRId = sR.Id;

            }



            var ans549 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 549).FirstOrDefault();
            if (ans549 == null)
            {
                // UPS สำหรับคอมพิวเตอร์ตัวที่ 2 :
                string ups2 = Request.Form["upsRadio2"];
                Answer answer549 = new Answer()
                {
                    AnsDes = ups2,
                    QuestionId = 549,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer549);
            }
            else
            {
                string varibles = Request.Form["upsRadio2"];
                ans549.QuestionId = 549;
                ans549.AnsDes = varibles;
                ans549.AnserTypeId = 4;
                ans549.CreateDate = DateTime.Now;
                ans549.UserId = user.Id;
                ans549.AnsMonth = ansMonth; ans549.SRId = sR.Id;

            }


            var ans550 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 550).FirstOrDefault();
            if (ans550 == null)
            {
                // UPS สำหรับคอมพิวเตอร์ตัวที่ 3 :
                string ups3 = Request.Form["upsRadio3"];
                Answer answer550 = new Answer()
                {
                    AnsDes = ups3,
                    QuestionId = 550,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer550);
            }
            else
            {
                string varibles = Request.Form["upsRadio3"];
                ans550.QuestionId = 550;
                ans550.AnsDes = varibles;
                ans550.AnserTypeId = 4;
                ans550.CreateDate = DateTime.Now;
                ans550.UserId = user.Id;
                ans550.AnsMonth = ansMonth; ans550.SRId = sR.Id;

            }


            var ans551 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 551).FirstOrDefault();
            if (ans551 == null)
            {
                // UPS สำหรับคอมพิวเตอร์ตัวที่ 4 :
                string ups4 = Request.Form["upsRadio4"];
                Answer answer551 = new Answer()
                {
                    AnsDes = ups4,
                    QuestionId = 551,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer551);
            }
            else
            {
                string varibles = Request.Form["upsRadio4"];
                ans551.QuestionId = 551;
                ans551.AnsDes = varibles;
                ans551.AnserTypeId = 4;
                ans551.CreateDate = DateTime.Now;
                ans551.UserId = user.Id;
                ans551.AnsMonth = ansMonth; ans551.SRId = sR.Id;

            }



            var ans552 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 552).FirstOrDefault();
            if (ans552 == null)
            {
                // UPS สำหรับคอมพิวเตอร์ตัวที่ 5 :
                string ups5 = Request.Form["upsRadio5"];
                Answer answer552 = new Answer()
                {
                    AnsDes = ups5,
                    QuestionId = 552,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer552);
            }
            else
            {
                string varibles = Request.Form["upsRadio5"];
                ans552.QuestionId = 552;
                ans552.AnsDes = varibles;
                ans552.AnserTypeId = 4;
                ans552.CreateDate = DateTime.Now;
                ans552.UserId = user.Id;
                ans552.AnsMonth = ansMonth; ans552.SRId = sR.Id;

            }






            var ans553 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 553).FirstOrDefault();
            if (ans553 == null)
            {
                // Test ใช้งาน Internet (Speed Test) คอมพิวเตอร์ตัวที่ 1 :
                string speedTestRaio1 = Request.Form["speedTestRaio1"];
                Answer answer553 = new Answer()
                {
                    AnsDes = speedTestRaio1,
                    QuestionId = 553,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer553);
            }
            else
            {
                string varibles = Request.Form["speedTestRaio1"];
                ans553.QuestionId = 553;
                ans553.AnsDes = varibles;
                ans553.AnserTypeId = 4;
                ans553.CreateDate = DateTime.Now;
                ans553.UserId = user.Id;
                ans553.AnsMonth = ansMonth; ans553.SRId = sR.Id;

            }






            var ans554 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 554).FirstOrDefault();
            if (ans554 == null)
            {
                // Test ใช้งาน Internet (Speed Test) คอมพิวเตอร์ตัวที่ 2 :
                string speedTestRaio2 = Request.Form["speedTestRaio2"];
                Answer answer554 = new Answer()
                {
                    AnsDes = speedTestRaio2,
                    QuestionId = 554,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer554);
            }
            else
            {
                string varibles = Request.Form["speedTestRaio2"];
                ans554.QuestionId = 554;
                ans554.AnsDes = varibles;
                ans554.AnserTypeId = 4;
                ans554.CreateDate = DateTime.Now;
                ans554.UserId = user.Id;
                ans554.AnsMonth = ansMonth; ans554.SRId = sR.Id;

            }




            var ans555 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 555).FirstOrDefault();
            if (ans555 == null)
            {
                // Test ใช้งาน Internet (Speed Test) คอมพิวเตอร์ตัวที่ 3 :
                string speedTestRaio3 = Request.Form["speedTestRaio3"];
                Answer answer555 = new Answer()
                {
                    AnsDes = speedTestRaio3,
                    QuestionId = 555,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer555);
            }
            else
            {
                string varibles = Request.Form["speedTestRaio3"];
                ans555.QuestionId = 555;
                ans555.AnsDes = varibles;
                ans555.AnserTypeId = 4;
                ans555.CreateDate = DateTime.Now;
                ans555.UserId = user.Id;
                ans555.AnsMonth = ansMonth; ans555.SRId = sR.Id;

            }






            var ans556 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 556).FirstOrDefault();
            if (ans556 == null)
            {
                // Test ใช้งาน Internet (Speed Test) คอมพิวเตอร์ตัวที่ 4 :
                string speedTestRaio4 = Request.Form["speedTestRaio4"];
                Answer answer556 = new Answer()
                {
                    AnsDes = speedTestRaio4,
                    QuestionId = 556,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer556);
            }
            else
            {
                string varibles = Request.Form["speedTestRaio4"];
                ans556.QuestionId = 556;
                ans556.AnsDes = varibles;
                ans556.AnserTypeId = 4;
                ans556.CreateDate = DateTime.Now;
                ans556.UserId = user.Id;
                ans556.AnsMonth = ansMonth; ans556.SRId = sR.Id;

            }





            var ans557 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 557).FirstOrDefault();
            if (ans557 == null)
            {
                // Test ใช้งาน Internet (Speed Test) คอมพิวเตอร์ตัวที่ 5 :
                string speedTestRaio5 = Request.Form["speedTestRaio5"];
                Answer answer557 = new Answer()
                {
                    AnsDes = speedTestRaio5,
                    QuestionId = 557,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer557);
            }
            else
            {
                string varibles = Request.Form["speedTestRaio5"];
                ans557.QuestionId = 557;
                ans557.AnsDes = varibles;
                ans557.AnserTypeId = 4;
                ans557.CreateDate = DateTime.Now;
                ans557.UserId = user.Id;
                ans557.AnsMonth = ansMonth; ans557.SRId = sR.Id;

            }







            var ans558 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 558).FirstOrDefault();
            if (ans558 == null)
            {
                //ป้ายและตัวเลขแสดงชื่อสถานี :
                string signandnumber = Request.Form["signandnumberRadio"];
                Answer answer1465 = new Answer()
                {
                    AnsDes = signandnumber,
                    QuestionId = 558,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer1465);
            }
            else
            {
                string varibles = Request.Form["signandnumberRadio"];
                ans558.QuestionId = 558;
                ans558.AnsDes = varibles;
                ans558.AnserTypeId = 4;
                ans558.CreateDate = DateTime.Now;
                ans558.UserId = user.Id;
                ans558.AnsMonth = ansMonth; ans558.SRId = sR.Id;

            }








            var ans559 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 559).FirstOrDefault();
            if (ans559 == null)
            {
                //การติดตั้งและการยึดตู้อุปกรณ์ :
                string inStall = Request.Form["inStallRadio"];
                Answer answer1466 = new Answer()
                {
                    AnsDes = inStall,
                    QuestionId = 559,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer1466);
            }
            else
            {
                string varibles = Request.Form["inStallRadio"];
                ans559.QuestionId = 559;
                ans559.AnsDes = varibles;
                ans559.AnserTypeId = 4;
                ans559.CreateDate = DateTime.Now;
                ans559.UserId = user.Id;
                ans559.AnsMonth = ansMonth; ans559.SRId = sR.Id;

            }





            var ans560 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 560).FirstOrDefault();
            if (ans560 == null)
            {
                //เสาไฟฟ้าที่ติดตั้งอุปกรณ์:
                string UPPERinStallSatRadio = Request.Form["UPPERinStallSatRadio"];
                Answer answer1467 = new Answer()
                {
                    AnsDes = UPPERinStallSatRadio,
                    QuestionId = 560,
                    AnserTypeId = 3,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer1467);
            }
            else
            {
                string varibles = Request.Form["UPPERinStallSatRadio"];
                ans560.QuestionId = 560;
                ans560.AnsDes = varibles;
                ans560.AnserTypeId = 4;
                ans560.CreateDate = DateTime.Now;
                ans560.UserId = user.Id;
                ans560.AnsMonth = ansMonth; ans560.SRId = sR.Id;

            }





            var ans561 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 561).FirstOrDefault();
            if (ans561 == null)
            {
                //แนวสายไฟฟ้าและสายเคเบิ้ลเข้าสถานี :
                string cabletoStationRadio = Request.Form["cabletoStationRadio"];
                Answer answer1471 = new Answer()
                {
                    AnsDes = cabletoStationRadio,
                    QuestionId = 561,
                    AnserTypeId = 3,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer1471);
            }
            else
            {
                string varibles = Request.Form["cabletoStationRadio"];
                ans561.QuestionId = 561;
                ans561.AnsDes = varibles;
                ans561.AnserTypeId = 4;
                ans561.CreateDate = DateTime.Now;
                ans561.UserId = user.Id;
                ans561.AnsMonth = ansMonth; ans561.SRId = sR.Id;

            }






            var ans562 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 562).FirstOrDefault();
            if (ans562 == null)
            {
                //ช่อง Cable Inlet  และความสะอาด :
                string CableInlet = Request.Form["CableInletRadio"];
                Answer answer1468 = new Answer()
                {
                    AnsDes = CableInlet,
                    QuestionId = 562,
                    AnserTypeId = 3,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer1468);
            }
            else
            {
                string varibles = Request.Form["CableInletRadio"];
                ans562.QuestionId = 562;
                ans562.AnsDes = varibles;
                ans562.AnserTypeId = 4;
                ans562.CreateDate = DateTime.Now;
                ans562.UserId = user.Id;
                ans562.AnsMonth = ansMonth; ans562.SRId = sR.Id;

            }


            var ans563 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 563).FirstOrDefault();
            if (ans563 == null)
            {
                //ช่อง Filter ความสะอาด (T-Power:
                string filterRadio = Request.Form["filterRadio"];
                Answer answer1469 = new Answer()
                {
                    AnsDes = filterRadio,
                    QuestionId = 563,
                    AnserTypeId = 3,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer1469);
            }
            else
            {
                string varibles = Request.Form["filterRadio"];
                ans563.QuestionId = 563;
                ans563.AnsDes = varibles;
                ans563.AnserTypeId = 4;
                ans563.CreateDate = DateTime.Now;
                ans563.UserId = user.Id;
                ans563.AnsMonth = ansMonth; ans563.SRId = sR.Id;

            }



            var ans564 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 564).FirstOrDefault();
            if (ans564 == null)
            {
                //ประตูและยางขอบประตูของตู้อุปกรณ์ :
                string doorToolsRadio = Request.Form["doorToolsRadio"];
                Answer answer1470 = new Answer()
                {
                    AnsDes = doorToolsRadio,
                    QuestionId = 564,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer1470);
            }
            else
            {
                string varibles = Request.Form["doorToolsRadio"];
                ans564.QuestionId = 564;
                ans564.AnsDes = varibles;
                ans564.AnserTypeId = 4;
                ans564.CreateDate = DateTime.Now;
                ans564.UserId = user.Id;
                ans564.AnsMonth = ansMonth; ans564.SRId = sR.Id;

            }





            var ans565 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 565).FirstOrDefault();
            if (ans565 == null)
            {
                // อุปกรณ์ LNB/BUC   :
                string tools = Request.Form["toolslnbRadio"];
                Answer answer88 = new Answer()
                {
                    AnsDes = tools,
                    QuestionId = 565,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer88);
            }
            else
            {
                string varibles = Request.Form["toolslnbRadio"];
                ans565.QuestionId = 565;
                ans565.AnsDes = varibles;
                ans565.AnserTypeId = 4;
                ans565.CreateDate = DateTime.Now;
                ans565.UserId = user.Id;
                ans565.AnsMonth = ansMonth; ans565.SRId = sR.Id;

            }





            var ans566 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 566).FirstOrDefault();
            if (ans566 == null)
            {
                // การเก็บสาย RG และการพันหัว   :
                string toolsRG = Request.Form["wiringrgRadio"];
                Answer answer89 = new Answer()
                {
                    AnsDes = toolsRG,
                    QuestionId = 566,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer89);
            }
            else
            {
                string varibles = Request.Form["wiringrgRadio"];
                ans566.QuestionId = 566;
                ans566.AnsDes = varibles;
                ans566.AnserTypeId = 4;
                ans566.CreateDate = DateTime.Now;
                ans566.UserId = user.Id;
                ans566.AnsMonth = ansMonth; ans566.SRId = sR.Id;

            }



            var ans567 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 567).FirstOrDefault();
            if (ans567 == null)
            {
                // ฐานและระดับของเสาจาน  :
                string baseOneiei = Request.Form["baseOnRadio"];
                Answer answer90 = new Answer()
                {
                    AnsDes = baseOneiei,
                    QuestionId = 567,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer90);
            }
            else
            {
                string varibles = Request.Form["baseOnRadio"];
                ans567.QuestionId = 567;
                ans567.AnsDes = varibles;
                ans567.AnserTypeId = 4;
                ans567.CreateDate = DateTime.Now;
                ans567.UserId = user.Id;
                ans567.AnsMonth = ansMonth; ans567.SRId = sR.Id;

            }







            var ans568 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 568).FirstOrDefault();
            if (ans568 == null)
            {
                // >แนว Line Of Sight  :
                string lineOf = Request.Form["xxlineOfsightRadio"];
                Answer answer91 = new Answer()
                {
                    AnsDes = lineOf,
                    QuestionId = 568,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer91);
            }
            else
            {
                string varibles = Request.Form["xxlineOfsightRadio"];
                ans568.QuestionId = 568;
                ans568.AnsDes = varibles;
                ans568.AnserTypeId = 4;
                ans568.CreateDate = DateTime.Now;
                ans568.UserId = user.Id;
                ans568.AnsMonth = ansMonth; ans568.SRId = sR.Id;

            }






            var ans569 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 569).FirstOrDefault();
            if (ans569 == null)
            {
                // แนว Line Of Sight  :
                string clendDish = Request.Form["cleaningDishRadio"];
                Answer answer92 = new Answer()
                {
                    AnsDes = clendDish,
                    QuestionId = 569,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer92);
            }
            else
            {
                string varibles = Request.Form["cleaningDishRadio"];
                ans569.QuestionId = 569;
                ans569.AnsDes = varibles;
                ans569.AnserTypeId = 4;
                ans569.CreateDate = DateTime.Now;
                ans569.UserId = user.Id;
                ans569.AnsMonth = ansMonth; ans569.SRId = sR.Id;

            }



            var ans570 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 570).FirstOrDefault();
            if (ans570 == null)
            {
                // LNB Band Switch  :
                string lnbswitch = Request.Form["lnbbandswitchRadio"];
                Answer answer93 = new Answer()
                {
                    AnsDes = lnbswitch,
                    QuestionId = 570,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer93);
            }
            else
            {
                string varibles = Request.Form["lnbbandswitchRadio"];
                ans570.QuestionId = 570;
                ans570.AnsDes = varibles;
                ans570.AnserTypeId = 4;
                ans570.CreateDate = DateTime.Now;
                ans570.UserId = user.Id;
                ans570.AnsMonth = ansMonth; ans570.SRId = sR.Id;

            }







            var ans571 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 571).FirstOrDefault();
            if (ans571 == null)
            {
                // ระบบ Solar Cell :
                string solarCells = Request.Form["solarcellSystemRadio"];
                Answer answer94 = new Answer()
                {
                    AnsDes = solarCells,
                    QuestionId = 571,
                    AnserTypeId = 3,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer94);
            }
            else
            {
                string varibles = Request.Form["solarcellSystemRadio"];
                ans571.QuestionId = 571;
                ans571.AnsDes = varibles;
                ans571.AnserTypeId = 4;
                ans571.CreateDate = DateTime.Now;
                ans571.UserId = user.Id;
                ans571.AnsMonth = ansMonth; ans571.SRId = sR.Id;

            }



            var ans572 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 572).FirstOrDefault();
            if (ans572 == null)
            {
                // แผง PV Panel:
                string pv = Request.Form["pvPanelRadio"];
                Answer answer95 = new Answer()
                {
                    AnsDes = pv,
                    QuestionId = 572,
                    AnserTypeId = 3,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer95);
            }
            else
            {
                string varibles = Request.Form["pvPanelRadio"];
                ans572.QuestionId = 572;
                ans572.AnsDes = varibles;
                ans572.AnserTypeId = 4;
                ans572.CreateDate = DateTime.Now;
                ans572.UserId = user.Id;
                ans572.AnsMonth = ansMonth; ans572.SRId = sR.Id;

            }




            var ans573 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 573).FirstOrDefault();
            if (ans573 == null)
            {
                // อุปกรณ์ Charger :
                string charGer = Request.Form["toolsCharger"];
                Answer answer96 = new Answer()
                {
                    AnsDes = charGer,
                    QuestionId = 573,
                    AnserTypeId = 3,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer96);
            }
            else
            {
                string varibles = Request.Form["toolsCharger"];
                ans573.QuestionId = 573;
                ans573.AnsDes = varibles;
                ans573.AnserTypeId = 4;
                ans573.CreateDate = DateTime.Now;
                ans573.UserId = user.Id;
                ans573.AnsMonth = ansMonth; ans573.SRId = sR.Id;

            }





            var ans574 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 574).FirstOrDefault();
            if (ans574 == null)
            {
                // ความสะอาดแผง PV :
                string cleanPv = Request.Form["cleanIngpvRadio"];
                Answer answer97 = new Answer()
                {
                    AnsDes = cleanPv,
                    QuestionId = 574,
                    AnserTypeId = 3,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer97);
            }
            else
            {
                string varibles = Request.Form["cleanIngpvRadio"];
                ans574.QuestionId = 574;
                ans574.AnsDes = varibles;
                ans574.AnserTypeId = 4;
                ans574.CreateDate = DateTime.Now;
                ans574.UserId = user.Id;
                ans574.AnsMonth = ansMonth; ans574.SRId = sR.Id;

            }






            var ans575 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 575).FirstOrDefault();
            if (ans575 == null)
            {
                // การติดตั้งแผง PV :
                string intPv = Request.Form["installPvRadio"];
                Answer answer98 = new Answer()
                {
                    AnsDes = intPv,
                    QuestionId = 575,
                    AnserTypeId = 3,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer98);
            }
            else
            {
                string varibles = Request.Form["installPvRadio"];
                ans575.QuestionId = 575;
                ans575.AnsDes = varibles;
                ans575.AnserTypeId = 4;
                ans575.CreateDate = DateTime.Now;
                ans575.UserId = user.Id;
                ans575.AnsMonth = ansMonth; ans575.SRId = sR.Id;

            }







            var ans576 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 576).FirstOrDefault();
            if (ans576 == null)
            {
                // แรงดันไฟจาก Inverter :          
                Answer voltInverterTextbox = new Answer()
                {
                    AnsDes = this.voltInverterTextbox.Value,
                    QuestionId = 576,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(voltInverterTextbox);
            }
            else
            {

                ans576.QuestionId = 576;
                ans576.AnsDes = this.voltInverterTextbox.Value;
                ans576.AnserTypeId = 4;
                ans576.CreateDate = DateTime.Now;
                ans576.UserId = user.Id;
                ans576.AnsMonth = ansMonth; ans576.SRId = sR.Id;

            }






            var ans577 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 577).FirstOrDefault();
            if (ans577 == null)
            {
                // กระแส Load :          
                Answer loadVoltTageTextbox = new Answer()
                {
                    AnsDes = this.loadVoltTageTextbox.Value,
                    QuestionId = 577,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(loadVoltTageTextbox);
            }
            else
            {

                ans577.QuestionId = 577;
                ans577.AnsDes = this.loadVoltTageTextbox.Value;
                ans577.AnserTypeId = 4;
                ans577.CreateDate = DateTime.Now;
                ans577.UserId = user.Id;
                ans577.AnsMonth = ansMonth; ans577.SRId = sR.Id;

            }







            var ans578 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 578).FirstOrDefault();
            if (ans578 == null)
            {
                // batterry 1 :          
                Answer answer1485 = new Answer()
                {
                    AnsDes = this.batterTextbox1.Value,
                    QuestionId = 578,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer1485);
            }
            else
            {

                ans578.QuestionId = 578;
                ans578.AnsDes = this.batterTextbox1.Value;
                ans578.AnserTypeId = 4;
                ans578.CreateDate = DateTime.Now;
                ans578.UserId = user.Id;
                ans578.AnsMonth = ansMonth; ans578.SRId = sR.Id;

            }


            var ans579 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 579).FirstOrDefault();
            if (ans579 == null)
            {
                //  batterry 2 :          
                Answer answer1486 = new Answer()
                {
                    AnsDes = this.batterTextbox2.Value,
                    QuestionId = 579,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer1486);
            }
            else
            {

                ans579.QuestionId = 579;
                ans579.AnsDes = this.batterTextbox2.Value;
                ans579.AnserTypeId = 4;
                ans579.CreateDate = DateTime.Now;
                ans579.UserId = user.Id;
                ans579.AnsMonth = ansMonth; ans579.SRId = sR.Id;

            }





            var ans580 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 580).FirstOrDefault();
            if (ans580 == null)
            {
                // batterry 3 :         
                Answer answer1487 = new Answer()
                {
                    AnsDes = this.batterTextbox3.Value,
                    QuestionId = 580,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer1487);
            }
            else
            {

                ans580.QuestionId = 580;
                ans580.AnsDes = this.batterTextbox3.Value;
                ans580.AnserTypeId = 4;
                ans580.CreateDate = DateTime.Now;
                ans580.UserId = user.Id;
                ans580.AnsMonth = ansMonth; ans580.SRId = sR.Id;

            }







            var ans581 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 581).FirstOrDefault();
            if (ans581 == null)
            {
                //  batterry 4 :          
                Answer answer1488 = new Answer()
                {
                    AnsDes = this.batterTextbox4.Value,
                    QuestionId = 581,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer1488);
            }
            else
            {

                ans581.QuestionId = 581;
                ans581.AnsDes = this.batterTextbox4.Value;
                ans581.AnserTypeId = 4;
                ans581.CreateDate = DateTime.Now;
                ans581.UserId = user.Id;
                ans581.AnsMonth = ansMonth; ans581.SRId = sR.Id;

            }





            var ans582 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 582).FirstOrDefault();
            if (ans582 == null)
            {
                // Download (for ONU/VSAT :          
                Answer answer1495 = new Answer()
                {
                    AnsDes = this.dowloadOnuTextbox.Value,
                    QuestionId = 582,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer1495);
            }
            else
            {

                ans582.QuestionId = 582;
                ans582.AnsDes = this.dowloadOnuTextbox.Value;
                ans582.AnserTypeId = 4;
                ans582.CreateDate = DateTime.Now;
                ans582.UserId = user.Id;
                ans582.AnsMonth = ansMonth; ans582.SRId = sR.Id;

            }




            var ans583 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 583).FirstOrDefault();
            if (ans583 == null)
            {
                // Upload (for ONU/VSAT) :          
                Answer answer1496 = new Answer()
                {
                    AnsDes = this.uploadforOnuTextbox.Value,
                    QuestionId = 583,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer1496);
            }
            else
            {

                ans583.QuestionId = 583;
                ans583.AnsDes = this.uploadforOnuTextbox.Value;
                ans583.AnserTypeId = 4;
                ans583.CreateDate = DateTime.Now;
                ans583.UserId = user.Id;
                ans583.AnsMonth = ansMonth; ans583.SRId = sR.Id;

            }



            var ans584 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 584).FirstOrDefault();
            if (ans584 == null)
            {
                // Ping Test (for ONU/VSAT) :          
                Answer answer1497 = new Answer()
                {
                    AnsDes = this.pinngtestforOnuTextbox.Value,
                    QuestionId = 584,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer1497);
            }
            else
            {

                ans584.QuestionId = 584;
                ans584.AnsDes = this.pinngtestforOnuTextbox.Value;
                ans584.AnserTypeId = 4;
                ans584.CreateDate = DateTime.Now;
                ans584.UserId = user.Id;
                ans584.AnsMonth = ansMonth; ans584.SRId = sR.Id;

            }





            var ans585 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 585).FirstOrDefault();
            if (ans585 == null)
            {
                // Download (for Mobile:          
                Answer answer1498 = new Answer()
                {
                    AnsDes = this.dowloadforMobileTextbox.Value,
                    QuestionId = 585,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer1498);
            }
            else
            {

                ans585.QuestionId = 585;
                ans585.AnsDes = this.dowloadforMobileTextbox.Value;
                ans585.AnserTypeId = 4;
                ans585.CreateDate = DateTime.Now;
                ans585.UserId = user.Id;
                ans585.AnsMonth = ansMonth; ans585.SRId = sR.Id;

            }






            var ans586 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 586).FirstOrDefault();
            if (ans586 == null)
            {
                //  Upload (for Mobile :          
                Answer answer1499 = new Answer()
                {
                    AnsDes = this.uploadforMobileTextbox.Value,
                    QuestionId = 586,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer1499);
            }
            else
            {

                ans586.QuestionId = 586;
                ans586.AnsDes = this.uploadforMobileTextbox.Value;
                ans586.AnserTypeId = 4;
                ans586.CreateDate = DateTime.Now;
                ans586.UserId = user.Id;
                ans586.AnsMonth = ansMonth; ans586.SRId = sR.Id;

            }





            var ans587 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 587).FirstOrDefault();
            if (ans587 == null)
            {
                // Ping Test(for Mobile)
                Answer answe1500 = new Answer()
                {
                    AnsDes = this.pingtestFormobileTextbox.Value,
                    QuestionId = 587,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answe1500);
            }
            else
            {

                ans587.QuestionId = 587;
                ans587.AnsDes = this.pingtestFormobileTextbox.Value;
                ans587.AnserTypeId = 4;
                ans587.CreateDate = DateTime.Now;
                ans587.UserId = user.Id;
                ans587.AnsMonth = ansMonth; ans587.SRId = sR.Id;

            }






            var ans588 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 588).FirstOrDefault();
            if (ans588 == null)
            {
                //  ปัญหาที่พบ 1 :           
                Answer answer110 = new Answer()
                {
                    AnsDes = this.problemTextbox1.Value,
                    QuestionId = 588,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer110);
            }
            else
            {

                ans588.QuestionId = 588;
                ans588.AnsDes = this.problemTextbox1.Value;
                ans588.AnserTypeId = 4;
                ans588.CreateDate = DateTime.Now;
                ans588.UserId = user.Id;
                ans588.AnsMonth = ansMonth; ans588.SRId = sR.Id;

            }




            var ans589 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 589).FirstOrDefault();
            if (ans589 == null)
            {
                //  วิธีแก้ปัญหา 1 :           
                Answer answer111 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox1.Value,
                    QuestionId = 589,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer111);
            }
            else
            {

                ans589.QuestionId = 589;
                ans589.AnsDes = this.howtoSolveTextbox1.Value;
                ans589.AnserTypeId = 4;
                ans589.CreateDate = DateTime.Now;
                ans589.UserId = user.Id;
                ans589.AnsMonth = ansMonth; ans589.SRId = sR.Id;

            }




            var ans590 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 590).FirstOrDefault();
            if (ans590 == null)
            {
                //  ปัญหาที่พบ 2 :           
                Answer answer112 = new Answer()
                {
                    AnsDes = this.problemTextbox2.Value,
                    QuestionId = 590,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer112);
            }
            else
            {

                ans590.QuestionId = 590;
                ans590.AnsDes = this.problemTextbox2.Value;
                ans590.AnserTypeId = 4;
                ans590.CreateDate = DateTime.Now;
                ans590.UserId = user.Id;
                ans590.AnsMonth = ansMonth; ans590.SRId = sR.Id;

            }




            var ans591 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 591).FirstOrDefault();
            if (ans591 == null)
            {
                //  วิธีแก้ปัญหา 2 :           
                Answer answer113 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox2.Value,
                    QuestionId = 591,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer113);
            }
            else
            {

                ans591.QuestionId = 591;
                ans591.AnsDes = this.howtoSolveTextbox2.Value;
                ans591.AnserTypeId = 4;
                ans591.CreateDate = DateTime.Now;
                ans591.UserId = user.Id;
                ans591.AnsMonth = ansMonth; ans591.SRId = sR.Id;

            }




            var ans592 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 592).FirstOrDefault();
            if (ans592 == null)
            {
                //  ปัญหาที่พบ 3 :           
                Answer answer114 = new Answer()
                {
                    AnsDes = this.problemTextbox3.Value,
                    QuestionId = 592,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer114);
            }
            else
            {

                ans592.QuestionId = 592;
                ans592.AnsDes = this.problemTextbox3.Value;
                ans592.AnserTypeId = 4;
                ans592.CreateDate = DateTime.Now;
                ans592.UserId = user.Id;
                ans592.AnsMonth = ansMonth; ans592.SRId = sR.Id;

            }



            var ans593 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 593).FirstOrDefault();
            if (ans593 == null)
            {
                //  วิธีแก้ปัญหา 3 :           
                Answer answer115 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox3.Value,
                    QuestionId = 593,
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

                ans593.QuestionId = 593;
                ans593.AnsDes = this.howtoSolveTextbox3.Value;
                ans593.AnserTypeId = 4;
                ans593.CreateDate = DateTime.Now;
                ans593.UserId = user.Id;
                ans593.AnsMonth = ansMonth; ans593.SRId = sR.Id;

            }



            var ans594 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 594).FirstOrDefault();
            if (ans594 == null)
            {
                //  ปัญหาที่พบ 4 :           
                Answer answer116 = new Answer()
                {
                    AnsDes = this.problemTextbox4.Value,
                    QuestionId = 594,
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

                ans594.QuestionId = 594;
                ans594.AnsDes = this.problemTextbox4.Value;
                ans594.AnserTypeId = 4;
                ans594.CreateDate = DateTime.Now;
                ans594.UserId = user.Id;
                ans594.AnsMonth = ansMonth; ans594.SRId = sR.Id;

            }


            var ans595 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 595).FirstOrDefault();
            if (ans595 == null)
            {
                //  วิธีแก้ปัญหา 4 :           
                Answer answer117 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox4.Value,
                    QuestionId = 595,
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

                ans595.QuestionId = 595;
                ans595.AnsDes = this.howtoSolveTextbox4.Value;
                ans595.AnserTypeId = 4;
                ans595.CreateDate = DateTime.Now;
                ans595.UserId = user.Id;
                ans595.AnsMonth = ansMonth; ans595.SRId = sR.Id;

            }




            var ans596 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 596).FirstOrDefault();
            if (ans596 == null)
            {
                //  ปัญหาที่พบ 5 :           
                Answer answer118 = new Answer()
                {
                    AnsDes = this.problemTextbox5.Value,
                    QuestionId = 596,
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

                ans596.QuestionId = 596;
                ans596.AnsDes = this.problemTextbox5.Value;
                ans596.AnserTypeId = 4;
                ans596.CreateDate = DateTime.Now;
                ans596.UserId = user.Id;
                ans596.AnsMonth = ansMonth; ans596.SRId = sR.Id;

            }


            var ans597 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 597).FirstOrDefault();
            if (ans597 == null)
            {
                //  วิธีแก้ปัญหา 5 :           
                Answer answer119 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox5.Value,
                    QuestionId = 597,
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

                ans597.QuestionId = 597;
                ans597.AnsDes = this.howtoSolveTextbox5.Value;
                ans597.AnserTypeId = 4;
                ans597.CreateDate = DateTime.Now;
                ans597.UserId = user.Id;
                ans597.AnsMonth = ansMonth; ans597.SRId = sR.Id;

            }




            var ans598 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 598).FirstOrDefault();
            if (ans598 == null)
            {
                //  ปัญหาที่พบ 6 :           
                Answer answer120 = new Answer()
                {
                    AnsDes = this.problemTextbox6.Value,
                    QuestionId = 598,
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

                ans598.QuestionId = 598;
                ans598.AnsDes = this.problemTextbox6.Value;
                ans598.AnserTypeId = 4;
                ans598.CreateDate = DateTime.Now;
                ans598.UserId = user.Id;
                ans598.AnsMonth = ansMonth; ans598.SRId = sR.Id;

            }



            var ans599 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 599).FirstOrDefault();
            if (ans599 == null)
            {
                //  วิธีแก้ปัญหา 6 :           
                Answer answer121 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox6.Value,
                    QuestionId = 599,
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

                ans599.QuestionId = 599;
                ans599.AnsDes = this.howtoSolveTextbox6.Value;
                ans599.AnserTypeId = 4;
                ans599.CreateDate = DateTime.Now;
                ans599.UserId = user.Id;
                ans599.AnsMonth = ansMonth; ans599.SRId = sR.Id;

            }





            var ans600 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 600).FirstOrDefault();
            if (ans600 == null)
            {
                //  ปัญหาที่พบ 7 :           
                Answer answer122 = new Answer()
                {
                    AnsDes = this.problemTextbox7.Value,
                    QuestionId = 600,
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

                ans600.QuestionId = 600;
                ans600.AnsDes = this.problemTextbox7.Value;
                ans600.AnserTypeId = 4;
                ans600.CreateDate = DateTime.Now;
                ans600.UserId = user.Id;
                ans600.AnsMonth = ansMonth; ans600.SRId = sR.Id;

            }







            var ans601 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 601).FirstOrDefault();
            if (ans601 == null)
            {
                //  วิธีแก้ปัญหา 7 :           
                Answer answer123 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox7.Value,
                    QuestionId = 601,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer123);
            }
            else
            {

                ans601.QuestionId = 601;
                ans601.AnsDes = this.howtoSolveTextbox7.Value;
                ans601.AnserTypeId = 4;
                ans601.CreateDate = DateTime.Now;
                ans601.UserId = user.Id;
                ans601.AnsMonth = ansMonth; ans601.SRId = sR.Id;

            }



            var ans602 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 602).FirstOrDefault();
            if (ans602 == null)
            {
                //  ปัญหาที่พบ 8 :           
                Answer answer124 = new Answer()
                {
                    AnsDes = this.problemTextbox8.Value,
                    QuestionId = 602,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer124);
            }
            else
            {

                ans602.QuestionId = 602;
                ans602.AnsDes = this.problemTextbox8.Value;
                ans602.AnserTypeId = 4;
                ans602.CreateDate = DateTime.Now;
                ans602.UserId = user.Id;
                ans602.AnsMonth = ansMonth; ans602.SRId = sR.Id;

            }




            var ans603 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 603).FirstOrDefault();
            if (ans603 == null)
            {
                //  วิธีแก้ปัญหา 8 :           
                Answer answer125 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox8.Value,
                    QuestionId = 603,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer125);
            }
            else
            {
                ans603.QuestionId = 603;
                ans603.AnsDes = this.howtoSolveTextbox8.Value;
                ans603.AnserTypeId = 4;
                ans603.CreateDate = DateTime.Now;
                ans603.UserId = user.Id;
                ans603.AnsMonth = ansMonth; ans603.SRId = sR.Id;

            }




            var ans604 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 604).FirstOrDefault();
            if (ans604 == null)
            {
                //  ปัญหาที่พบ 9 :           
                Answer answer126 = new Answer()
                {
                    AnsDes = this.problemTextbox9.Value,
                    QuestionId = 604,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer126);
            }
            else
            {
                ans604.QuestionId = 604;
                ans604.AnsDes = this.problemTextbox9.Value;
                ans604.AnserTypeId = 4;
                ans604.CreateDate = DateTime.Now;
                ans604.UserId = user.Id;
                ans604.AnsMonth = ansMonth; ans604.SRId = sR.Id;

            }





            var ans605 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 605).FirstOrDefault();
            if (ans605 == null)
            {
                //  วิธีแก้ปัญหา 9 :           
                Answer answer127 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox9.Value,
                    QuestionId = 605,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer127);
            }
            else
            {
                ans605.QuestionId = 605;
                ans605.AnsDes = this.howtoSolveTextbox9.Value;
                ans605.AnserTypeId = 4;
                ans605.CreateDate = DateTime.Now;
                ans605.UserId = user.Id;
                ans605.AnsMonth = ansMonth; ans605.SRId = sR.Id;

            }






            var ans606 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 606).FirstOrDefault();
            if (ans606 == null)
            {
                //  ปัญหาที่พบ 10 :           
                Answer answer128 = new Answer()
                {
                    AnsDes = this.problemTextbox10.Value,
                    QuestionId = 606,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer128);
            }
            else
            {
                ans606.QuestionId = 606;
                ans606.AnsDes = this.problemTextbox10.Value;
                ans606.AnserTypeId = 4;
                ans606.CreateDate = DateTime.Now;
                ans606.UserId = user.Id;
                ans606.AnsMonth = ansMonth; ans606.SRId = sR.Id;

            }





            var ans607 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 607).FirstOrDefault();
            if (ans607 == null)
            {
                //  วิธีแก้ปัญหา 10 :           
                Answer answer129 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox10.Value,
                    QuestionId = 607,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer129);
            }
            else
            {
                ans607.QuestionId = 607;
                ans607.AnsDes = this.howtoSolveTextbox10.Value;
                ans607.AnserTypeId = 4;
                ans607.CreateDate = DateTime.Now;
                ans607.UserId = user.Id;
                ans607.AnsMonth = ansMonth; ans607.SRId = sR.Id;
            }





            var ans608 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 608).FirstOrDefault();
            if (ans608 == null)
            {
                //  ปัญหาที่พบ 11 :           
                Answer answer130 = new Answer()
                {
                    AnsDes = this.problemTextbox11.Value,
                    QuestionId = 608,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer130);
            }
            else
            {
                ans608.QuestionId = 608;
                ans608.AnsDes = this.problemTextbox11.Value;
                ans608.AnserTypeId = 4;
                ans608.CreateDate = DateTime.Now;
                ans608.UserId = user.Id;
                ans608.AnsMonth = ansMonth; ans608.SRId = sR.Id;
            }





            var ans609 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 609).FirstOrDefault();
            if (ans609 == null)
            {
                //  วิธีแก้ปัญหา 11 :           
                Answer answer131 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox11.Value,
                    QuestionId = 609,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer131);
            }
            else
            {
                ans609.QuestionId = 609;
                ans609.AnsDes = this.howtoSolveTextbox11.Value;
                ans609.AnserTypeId = 4;
                ans609.CreateDate = DateTime.Now;
                ans609.UserId = user.Id;
                ans609.AnsMonth = ansMonth; ans609.SRId = sR.Id;
            }




            var ans610 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 610).FirstOrDefault();
            if (ans610 == null)
            {
                //  ปัญหาที่พบ 12 :           
                Answer answer132 = new Answer()
                {
                    AnsDes = this.problemTextbox12.Value,
                    QuestionId = 610,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer132);
            }
            else
            {
                ans610.QuestionId = 610;
                ans610.AnsDes = this.problemTextbox12.Value;
                ans610.AnserTypeId = 4;
                ans610.CreateDate = DateTime.Now;
                ans610.UserId = user.Id;
                ans610.AnsMonth = ansMonth; ans610.SRId = sR.Id;
            }



            var ans611 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 611).FirstOrDefault();
            if (ans611 == null)
            {
                //  วิธีแก้ปัญหา 12 :           
                Answer answer133 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox12.Value,
                    QuestionId = 611,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer133);
            }
            else
            {
                ans611.QuestionId = 611;
                ans611.AnsDes = this.howtoSolveTextbox12.Value;
                ans611.AnserTypeId = 4;
                ans611.CreateDate = DateTime.Now;
                ans611.UserId = user.Id;
                ans611.AnsMonth = ansMonth; ans611.SRId = sR.Id;
            }






            var ans612 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 612).FirstOrDefault();
            if (ans612 == null)
            {
                //  ปัญหาที่พบ 13 :           
                Answer answer134 = new Answer()
                {
                    AnsDes = this.problemTextbox13.Value,
                    QuestionId = 612,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer134);
            }
            else
            {
                ans612.QuestionId = 612;
                ans612.AnsDes = this.problemTextbox13.Value;
                ans612.AnserTypeId = 4;
                ans612.CreateDate = DateTime.Now;
                ans612.UserId = user.Id;
                ans612.AnsMonth = ansMonth; ans612.SRId = sR.Id;
            }




            var ans613 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 613).FirstOrDefault();
            if (ans613 == null)
            {
                //  วิธีแก้ปัญหา 13 :           
                Answer answer135 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox13.Value,
                    QuestionId = 613,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer135);
            }
            else
            {
                ans613.QuestionId = 613;
                ans613.AnsDes = this.howtoSolveTextbox13.Value;
                ans613.AnserTypeId = 4;
                ans613.CreateDate = DateTime.Now;
                ans613.UserId = user.Id;
                ans613.AnsMonth = ansMonth; ans613.SRId = sR.Id;
            }




            var ans614 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 614).FirstOrDefault();
            if (ans614 == null)
            {
                //  ปัญหาที่พบ 14 :           
                Answer answer136 = new Answer()
                {
                    AnsDes = this.problemTextbox14.Value,
                    QuestionId = 614,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer136);

            }
            else
            {
                ans614.QuestionId = 614;
                ans614.AnsDes = this.problemTextbox14.Value;
                ans614.AnserTypeId = 4;
                ans614.CreateDate = DateTime.Now;
                ans614.UserId = user.Id;
                ans614.AnsMonth = ansMonth; ans614.SRId = sR.Id;
            }




            var ans615 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 615).FirstOrDefault();
            if (ans615 == null)
            {
                //  วิธีแก้ปัญหา 14 :           
                Answer answer137 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox14.Value,
                    QuestionId = 615,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer137);

            }
            else
            {
                ans615.QuestionId = 615;
                ans615.AnsDes = this.howtoSolveTextbox14.Value;
                ans615.AnserTypeId = 4;
                ans615.CreateDate = DateTime.Now;
                ans615.UserId = user.Id;
                ans615.AnsMonth = ansMonth; ans615.SRId = sR.Id;
            }






            var ans616 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 616).FirstOrDefault();
            if (ans616 == null)
            {
                //  ปัญหาที่พบ 15 :           
                Answer answer138 = new Answer()
                {
                    AnsDes = this.problemTextbox15.Value,
                    QuestionId = 616,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer138);

            }
            else
            {
                ans616.QuestionId = 616;
                ans616.AnsDes = this.problemTextbox15.Value;
                ans616.AnserTypeId = 4;
                ans616.CreateDate = DateTime.Now;
                ans616.UserId = user.Id;
                ans616.AnsMonth = ansMonth; ans616.SRId = sR.Id;
            }





            var ans617 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 617).FirstOrDefault();
            if (ans617 == null)
            {
                //  วิธีแก้ปัญหา 15 :           
                Answer answer139 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox15.Value,
                    QuestionId = 617,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer139);

            }
            else
            {
                ans617.QuestionId = 617;
                ans617.AnsDes = this.howtoSolveTextbox15.Value;
                ans617.AnserTypeId = 4;
                ans617.CreateDate = DateTime.Now;
                ans617.UserId = user.Id;
                ans617.AnsMonth = ansMonth; ans617.SRId = sR.Id;
            }









            var ans618 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 618).FirstOrDefault();
            if (ans618 == null)
            {
                // รายการอุปกรณ์ 1 :      
                Answer answer141 = new Answer()
                {
                    AnsDes = this.toolsListTextbox1.Value,
                    QuestionId = 618,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer141);

            }
            else
            {
                ans618.QuestionId = 618;
                ans618.AnsDes = this.toolsListTextbox1.Value;
                ans618.AnserTypeId = 4;
                ans618.CreateDate = DateTime.Now;
                ans618.UserId = user.Id;
                ans618.AnsMonth = ansMonth; ans618.SRId = sR.Id;
            }




            var ans619 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 619).FirstOrDefault();
            if (ans619 == null)
            {
                //  SerialNumber :           
                Answer answer142 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox1.Value,
                    QuestionId = 619,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer142);

            }
            else
            {
                ans619.QuestionId = 619;
                ans619.AnsDes = this.serialNumberTextbox1.Value;
                ans619.AnserTypeId = 4;
                ans619.CreateDate = DateTime.Now;
                ans619.UserId = user.Id;
                ans619.AnsMonth = ansMonth; ans619.SRId = sR.Id;
            }




            var ans620 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 620).FirstOrDefault();
            if (ans620 == null)
            {
                //  new SerialNumber :           
                Answer answer143 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox1.Value,
                    QuestionId = 620,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer143);

            }
            else
            {
                ans620.QuestionId = 620;
                ans620.AnsDes = this.newSerialNumberTextbox1.Value;
                ans620.AnserTypeId = 4;
                ans620.CreateDate = DateTime.Now;
                ans620.UserId = user.Id;
                ans620.AnsMonth = ansMonth; ans620.SRId = sR.Id;
            }






            var ans621 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 621).FirstOrDefault();
            if (ans621 == null)
            {
                //  หมายเหตุ :           
                Answer answer144 = new Answer()
                {
                    AnsDes = this.noteTextbox1.Value,
                    QuestionId = 621,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer144);

            }
            else
            {
                ans621.QuestionId = 621;
                ans621.AnsDes = this.noteTextbox1.Value;
                ans621.AnserTypeId = 4;
                ans621.CreateDate = DateTime.Now;
                ans621.UserId = user.Id;
                ans621.AnsMonth = ansMonth; ans621.SRId = sR.Id;
            }







            var ans622 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 622).FirstOrDefault();
            if (ans622 == null)
            {
                // รายการอุปกรณ์ 2 :      
                Answer answer145 = new Answer()
                {
                    AnsDes = this.toolsListTextbox2.Value,
                    QuestionId = 622,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer145);

            }
            else
            {
                ans622.QuestionId = 622;
                ans622.AnsDes = this.toolsListTextbox2.Value;
                ans622.AnserTypeId = 4;
                ans622.CreateDate = DateTime.Now;
                ans622.UserId = user.Id;
                ans622.AnsMonth = ansMonth; ans622.SRId = sR.Id;
            }




            var ans623 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 623).FirstOrDefault();
            if (ans623 == null)
            {
                //  SerialNumber 2 :           
                Answer answer146 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox2.Value,
                    QuestionId = 623,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer146);

            }
            else
            {
                ans623.QuestionId = 623;
                ans623.AnsDes = this.serialNumberTextbox2.Value;
                ans623.AnserTypeId = 4;
                ans623.CreateDate = DateTime.Now;
                ans623.UserId = user.Id;
                ans623.AnsMonth = ansMonth; ans623.SRId = sR.Id;
            }




            var ans624 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 624).FirstOrDefault();
            if (ans624 == null)
            {
                //  new SerialNumber 2 :           
                Answer answer147 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox2.Value,
                    QuestionId = 624,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer147);

            }
            else
            {
                ans624.QuestionId = 624;
                ans624.AnsDes = this.newSerialNumberTextbox2.Value;
                ans624.AnserTypeId = 4;
                ans624.CreateDate = DateTime.Now;
                ans624.UserId = user.Id;
                ans624.AnsMonth = ansMonth; ans624.SRId = sR.Id;
            }




            var ans625 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 625).FirstOrDefault();
            if (ans625 == null)
            {
                //  หมายเหตุ  2:           
                Answer answer148 = new Answer()
                {
                    AnsDes = this.noteTextbox2.Value,
                    QuestionId = 625,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer148);

            }
            else
            {
                ans625.QuestionId = 625;
                ans625.AnsDes = this.noteTextbox2.Value;
                ans625.AnserTypeId = 4;
                ans625.CreateDate = DateTime.Now;
                ans625.UserId = user.Id;
                ans625.AnsMonth = ansMonth; ans625.SRId = sR.Id;
            }





            var ans626 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 626).FirstOrDefault();
            if (ans626 == null)
            {
                // รายการอุปกรณ์ 3 :      
                Answer answer149 = new Answer()
                {
                    AnsDes = this.toolsListTextbox3.Value,
                    QuestionId = 626,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer149);

            }
            else
            {
                ans626.QuestionId = 626;
                ans626.AnsDes = this.toolsListTextbox3.Value;
                ans626.AnserTypeId = 4;
                ans626.CreateDate = DateTime.Now;
                ans626.UserId = user.Id;
                ans626.AnsMonth = ansMonth; ans626.SRId = sR.Id;
            }






            var ans627 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 627).FirstOrDefault();
            if (ans627 == null)
            {
                //  SerialNumber 3 :           
                Answer answer150 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox3.Value,
                    QuestionId = 627,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer150);

            }
            else
            {
                ans627.QuestionId = 627;
                ans627.AnsDes = this.serialNumberTextbox3.Value;
                ans627.AnserTypeId = 4;
                ans627.CreateDate = DateTime.Now;
                ans627.UserId = user.Id;
                ans627.AnsMonth = ansMonth; ans627.SRId = sR.Id;
            }



            var ans628 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 628).FirstOrDefault();
            if (ans628 == null)
            {
                //  new SerialNumber 3 :           
                Answer answer151 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox3.Value,
                    QuestionId = 628,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer151);

            }
            else
            {
                ans628.QuestionId = 628;
                ans628.AnsDes = this.newSerialNumberTextbox3.Value;
                ans628.AnserTypeId = 4;
                ans628.CreateDate = DateTime.Now;
                ans628.UserId = user.Id;
                ans628.AnsMonth = ansMonth; ans628.SRId = sR.Id;
            }




            var ans629 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 629).FirstOrDefault();
            if (ans629 == null)
            {
                //  หมายเหตุ  3:           
                Answer answer152 = new Answer()
                {
                    AnsDes = this.noteTextbox3.Value,
                    QuestionId = 629,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer152);

            }
            else
            {
                ans629.QuestionId = 629;
                ans629.AnsDes = this.noteTextbox3.Value;
                ans629.AnserTypeId = 4;
                ans629.CreateDate = DateTime.Now;
                ans629.UserId = user.Id;
                ans629.AnsMonth = ansMonth; ans629.SRId = sR.Id;
            }




            var ans630 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 630).FirstOrDefault();
            if (ans630 == null)
            {
                // รายการอุปกรณ์ 4 :      
                Answer answer153 = new Answer()
                {
                    AnsDes = this.toolsListTextbox4.Value,
                    QuestionId = 630,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer153);

            }
            else
            {
                ans630.QuestionId = 630;
                ans630.AnsDes = this.toolsListTextbox4.Value;
                ans630.AnserTypeId = 4;
                ans630.CreateDate = DateTime.Now;
                ans630.UserId = user.Id;
                ans630.AnsMonth = ansMonth; ans630.SRId = sR.Id;
            }





            var ans631 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 631).FirstOrDefault();
            if (ans631 == null)
            {
                //  SerialNumber 4 :           
                Answer answer154 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox4.Value,
                    QuestionId = 631,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer154);

            }
            else
            {
                ans631.QuestionId = 631;
                ans631.AnsDes = this.serialNumberTextbox4.Value;
                ans631.AnserTypeId = 4;
                ans631.CreateDate = DateTime.Now;
                ans631.UserId = user.Id;
                ans631.AnsMonth = ansMonth; ans631.SRId = sR.Id;
            }





            var ans632 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 632).FirstOrDefault();
            if (ans632 == null)
            {
                //  new SerialNumber 4 :           
                Answer answer155 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox4.Value,
                    QuestionId = 632,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer155);

            }
            else
            {
                ans632.QuestionId = 632;
                ans632.AnsDes = this.newSerialNumberTextbox4.Value;
                ans632.AnserTypeId = 4;
                ans632.CreateDate = DateTime.Now;
                ans632.UserId = user.Id;
                ans632.AnsMonth = ansMonth; ans632.SRId = sR.Id;
            }




            var ans633 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 633).FirstOrDefault();
            if (ans633 == null)
            {
                //  หมายเหตุ  4:           
                Answer answer156 = new Answer()
                {
                    AnsDes = this.noteTextbox4.Value,
                    QuestionId = 633,
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
                ans633.QuestionId = 633;
                ans633.AnsDes = this.noteTextbox4.Value;
                ans633.AnserTypeId = 4;
                ans633.CreateDate = DateTime.Now;
                ans633.UserId = user.Id;
                ans633.AnsMonth = ansMonth; ans633.SRId = sR.Id;
            }


            var ans634 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 634).FirstOrDefault();
            if (ans634 == null)
            {
                // รายการอุปกรณ์ 5 :      
                Answer answer157 = new Answer()
                {
                    AnsDes = this.toolsListTextbox5.Value,
                    QuestionId = 634,
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
                ans634.QuestionId = 634;
                ans634.AnsDes = this.toolsListTextbox5.Value;
                ans634.AnserTypeId = 4;
                ans634.CreateDate = DateTime.Now;
                ans634.UserId = user.Id;
                ans634.AnsMonth = ansMonth; ans634.SRId = sR.Id;
            }




            var ans635 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 635).FirstOrDefault();
            if (ans635 == null)
            {
                //  SerialNumber 5 :           
                Answer answer158 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox5.Value,
                    QuestionId = 635,
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
                ans635.QuestionId = 635;
                ans635.AnsDes = this.serialNumberTextbox5.Value;
                ans635.AnserTypeId = 4;
                ans635.CreateDate = DateTime.Now;
                ans635.UserId = user.Id;
                ans635.AnsMonth = ansMonth; ans635.SRId = sR.Id;
            }




            var ans636 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 636).FirstOrDefault();
            if (ans636 == null)
            {
                //  new SerialNumber 5 :           
                Answer answer159 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox5.Value,
                    QuestionId = 636,
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
                ans636.QuestionId = 636;
                ans636.AnsDes = this.newSerialNumberTextbox5.Value;
                ans636.AnserTypeId = 4;
                ans636.CreateDate = DateTime.Now;
                ans636.UserId = user.Id;
                ans636.AnsMonth = ansMonth; ans636.SRId = sR.Id;
            }


            var ans637 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 637).FirstOrDefault();
            if (ans637 == null)
            {

                //  หมายเหตุ  5:           
                Answer answer160 = new Answer()
                {
                    AnsDes = this.noteTextbox5.Value,
                    QuestionId = 637,
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
                ans637.QuestionId = 637;
                ans637.AnsDes = this.noteTextbox5.Value;
                ans637.AnserTypeId = 4;
                ans637.CreateDate = DateTime.Now;
                ans637.UserId = user.Id;
                ans637.AnsMonth = ansMonth; ans637.SRId = sR.Id;
            }






            var ans638 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 638).FirstOrDefault();
            if (ans638 == null)
            {
                // รายการอุปกรณ์ 6 :      
                Answer answer161 = new Answer()
                {
                    AnsDes = this.toolsListTextbox6.Value,
                    QuestionId = 638,
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
                ans638.QuestionId = 638;
                ans638.AnsDes = this.toolsListTextbox6.Value;
                ans638.AnserTypeId = 4;
                ans638.CreateDate = DateTime.Now;
                ans638.UserId = user.Id;
                ans638.AnsMonth = ansMonth; ans638.SRId = sR.Id;
            }






            var ans639 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 639).FirstOrDefault();
            if (ans639 == null)
            {
                //  SerialNumber 6 :           
                Answer answer162 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox6.Value,
                    QuestionId = 639,
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
                ans639.QuestionId = 639;
                ans639.AnsDes = this.serialNumberTextbox6.Value;
                ans639.AnserTypeId = 4;
                ans639.CreateDate = DateTime.Now;
                ans639.UserId = user.Id;
                ans639.AnsMonth = ansMonth; ans639.SRId = sR.Id;
            }




            var ans640 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 640).FirstOrDefault();
            if (ans640 == null)
            {
                //  new SerialNumber 6 :           
                Answer answer163 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox6.Value,
                    QuestionId = 640,
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
                ans640.QuestionId = 640;
                ans640.AnsDes = this.newSerialNumberTextbox6.Value;
                ans640.AnserTypeId = 4;
                ans640.CreateDate = DateTime.Now;
                ans640.UserId = user.Id;
                ans640.AnsMonth = ansMonth; ans640.SRId = sR.Id;
            }



            var ans641 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 641).FirstOrDefault();
            if (ans641 == null)
            {
                //  หมายเหตุ  6:           
                Answer answer164 = new Answer()
                {
                    AnsDes = this.noteTextbox6.Value,
                    QuestionId = 641,
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
                ans641.QuestionId = 641;
                ans641.AnsDes = this.noteTextbox6.Value;
                ans641.AnserTypeId = 4;
                ans641.CreateDate = DateTime.Now;
                ans641.UserId = user.Id;
                ans641.AnsMonth = ansMonth; ans641.SRId = sR.Id;
            }




            var ans642 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 642).FirstOrDefault();
            if (ans642 == null)
            {
                // รายการอุปกรณ์ 7 :      
                Answer answer165 = new Answer()
                {
                    AnsDes = this.toolsListTextbox7.Value,
                    QuestionId = 642,
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
                ans642.QuestionId = 642;
                ans642.AnsDes = this.toolsListTextbox7.Value;
                ans642.AnserTypeId = 4;
                ans642.CreateDate = DateTime.Now;
                ans642.UserId = user.Id;
                ans642.AnsMonth = ansMonth; ans642.SRId = sR.Id;
            }



            var ans643 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 643).FirstOrDefault();
            if (ans643 == null)
            {
                //  SerialNumber 7 :           
                Answer answer166 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox7.Value,
                    QuestionId = 643,
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
                ans643.QuestionId = 643;
                ans643.AnsDes = this.serialNumberTextbox7.Value;
                ans643.AnserTypeId = 4;
                ans643.CreateDate = DateTime.Now;
                ans643.UserId = user.Id;
                ans643.AnsMonth = ansMonth; ans643.SRId = sR.Id;
            }




            var ans644 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 644).FirstOrDefault();
            if (ans644 == null)
            {
                //  new SerialNumber 7 :           
                Answer answer167 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox7.Value,
                    QuestionId = 644,
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
                ans644.QuestionId = 644;
                ans644.AnsDes = this.newSerialNumberTextbox7.Value;
                ans644.AnserTypeId = 4;
                ans644.CreateDate = DateTime.Now;
                ans644.UserId = user.Id;
                ans644.AnsMonth = ansMonth; ans644.SRId = sR.Id;
            }



            var ans645 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 645).FirstOrDefault();
            if (ans645 == null)
            {
                //  หมายเหตุ  7:           
                Answer answer168 = new Answer()
                {
                    AnsDes = this.noteTextbox7.Value,
                    QuestionId = 645,
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
                ans645.QuestionId = 645;
                ans645.AnsDes = this.noteTextbox7.Value;
                ans645.AnserTypeId = 4;
                ans645.CreateDate = DateTime.Now;
                ans645.UserId = user.Id;
                ans645.AnsMonth = ansMonth; ans645.SRId = sR.Id;
            }







            var ans646 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 646).FirstOrDefault();
            if (ans646 == null)
            {
                // รายการอุปกรณ์ 8 :      
                Answer answer169 = new Answer()
                {
                    AnsDes = this.toolsListTextbox8.Value,
                    QuestionId = 646,
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
                ans646.QuestionId = 646;
                ans646.AnsDes = this.toolsListTextbox8.Value;
                ans646.AnserTypeId = 4;
                ans646.CreateDate = DateTime.Now;
                ans646.UserId = user.Id;
                ans646.AnsMonth = ansMonth; ans646.SRId = sR.Id;
            }





            var ans647 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 647).FirstOrDefault();
            if (ans647 == null)
            {
                //  SerialNumber 8 :           
                Answer answer170 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox8.Value,
                    QuestionId = 647,
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
                ans647.QuestionId = 647;
                ans647.AnsDes = this.serialNumberTextbox8.Value;
                ans647.AnserTypeId = 4;
                ans647.CreateDate = DateTime.Now;
                ans647.UserId = user.Id;
                ans647.AnsMonth = ansMonth; ans647.SRId = sR.Id;
            }




            var ans648 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 648).FirstOrDefault();
            if (ans648 == null)
            {
                //  new SerialNumber 8 :           
                Answer answer171 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox8.Value,
                    QuestionId = 648,
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
                ans648.QuestionId = 648;
                ans648.AnsDes = this.newSerialNumberTextbox8.Value;
                ans648.AnserTypeId = 4;
                ans648.CreateDate = DateTime.Now;
                ans648.UserId = user.Id;
                ans648.AnsMonth = ansMonth; ans648.SRId = sR.Id;
            }




            var ans649 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 649).FirstOrDefault();
            if (ans649 == null)
            {
                //  หมายเหตุ  8:           
                Answer answer172 = new Answer()
                {
                    AnsDes = this.noteTextbox8.Value,
                    QuestionId = 649,
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
                ans649.QuestionId = 649;
                ans649.AnsDes = this.noteTextbox8.Value;
                ans649.AnserTypeId = 4;
                ans649.CreateDate = DateTime.Now;
                ans649.UserId = user.Id;
                ans649.AnsMonth = ansMonth; ans649.SRId = sR.Id;
            }



            var ans650 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 650).FirstOrDefault();
            if (ans650 == null)
            {
                // รายการอุปกรณ์ 9 :      
                Answer answer173 = new Answer()
                {
                    AnsDes = this.toolsListTextbox9.Value,
                    QuestionId = 650,
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
                ans650.QuestionId = 650;
                ans650.AnsDes = this.toolsListTextbox9.Value;
                ans650.AnserTypeId = 4;
                ans650.CreateDate = DateTime.Now;
                ans650.UserId = user.Id;
                ans650.AnsMonth = ansMonth; ans650.SRId = sR.Id;
            }





            var ans651 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 651).FirstOrDefault();
            if (ans651 == null)
            {
                //  SerialNumber 9 :           
                Answer answer174 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox9.Value,
                    QuestionId = 651,
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
                ans651.QuestionId = 651;
                ans651.AnsDes = this.serialNumberTextbox9.Value;
                ans651.AnserTypeId = 4;
                ans651.CreateDate = DateTime.Now;
                ans651.UserId = user.Id;
                ans651.AnsMonth = ansMonth; ans651.SRId = sR.Id;
            }




            var ans652 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 652).FirstOrDefault();
            if (ans652 == null)
            {
                //  new SerialNumber 9 :           
                Answer answer175 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox9.Value,
                    QuestionId = 652,
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
                ans652.QuestionId = 652;
                ans652.AnsDes = this.newSerialNumberTextbox9.Value;
                ans652.AnserTypeId = 4;
                ans652.CreateDate = DateTime.Now;
                ans652.UserId = user.Id;
                ans652.AnsMonth = ansMonth; ans652.SRId = sR.Id;
            }




            var ans653 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 653).FirstOrDefault();
            if (ans653 == null)
            {
                //  หมายเหตุ  9:           
                Answer answer176 = new Answer()
                {
                    AnsDes = this.noteTextbox9.Value,
                    QuestionId = 653,
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
                ans653.QuestionId = 653;
                ans653.AnsDes = this.noteTextbox9.Value;
                ans653.AnserTypeId = 4;
                ans653.CreateDate = DateTime.Now;
                ans653.UserId = user.Id;
                ans653.AnsMonth = ansMonth; ans653.SRId = sR.Id;
            }




            var ans654 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 654).FirstOrDefault();
            if (ans654 == null)
            {
                // รายการอุปกรณ์ 10 :      
                Answer answer177 = new Answer()
                {
                    AnsDes = this.toolsListTextbox10.Value,
                    QuestionId = 654,
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
                ans654.QuestionId = 654;
                ans654.AnsDes = this.toolsListTextbox10.Value;
                ans654.AnserTypeId = 4;
                ans654.CreateDate = DateTime.Now;
                ans654.UserId = user.Id;
                ans654.AnsMonth = ansMonth; ans654.SRId = sR.Id;
            }






            var ans655 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 655).FirstOrDefault();
            if (ans655 == null)
            {
                //  SerialNumber 10 :           
                Answer answer178 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox10.Value,
                    QuestionId = 655,
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
                ans655.QuestionId = 655;
                ans655.AnsDes = this.serialNumberTextbox10.Value;
                ans655.AnserTypeId = 4;
                ans655.CreateDate = DateTime.Now;
                ans655.UserId = user.Id;
                ans655.AnsMonth = ansMonth; ans655.SRId = sR.Id;
            }





            var ans656 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 656).FirstOrDefault();
            if (ans656 == null)
            {
                //  new SerialNumber 10 :           
                Answer answer179 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox10.Value,
                    QuestionId = 656,
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
                ans656.QuestionId = 656;
                ans656.AnsDes = this.newSerialNumberTextbox10.Value;
                ans656.AnserTypeId = 4;
                ans656.CreateDate = DateTime.Now;
                ans656.UserId = user.Id;
                ans656.AnsMonth = ansMonth; ans656.SRId = sR.Id;
            }


            var ans657 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 657).FirstOrDefault();
            if (ans657 == null)
            {
                //  หมายเหตุ  10:           
                Answer answer180 = new Answer()
                {
                    AnsDes = this.noteTextbox10.Value,
                    QuestionId = 657,
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
                ans657.QuestionId = 657;
                ans657.AnsDes = this.noteTextbox10.Value;
                ans657.AnserTypeId = 4;
                ans657.CreateDate = DateTime.Now;
                ans657.UserId = user.Id;
                ans657.AnsMonth = ansMonth; ans657.SRId = sR.Id;
            }






            var ans658 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 658).FirstOrDefault();
            if (ans658 == null)
            {
                // รายการอุปกรณ์ 11 :      
                Answer answer181 = new Answer()
                {
                    AnsDes = this.toolsListTextbox11.Value,
                    QuestionId = 658,
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
                ans658.QuestionId = 658;
                ans658.AnsDes = this.toolsListTextbox11.Value;
                ans658.AnserTypeId = 4;
                ans658.CreateDate = DateTime.Now;
                ans658.UserId = user.Id;
                ans658.AnsMonth = ansMonth; ans658.SRId = sR.Id;
            }






            var ans659 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 659).FirstOrDefault();
            if (ans659 == null)
            {
                //  SerialNumber 11 :           
                Answer answer182 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox11.Value,
                    QuestionId = 659,
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
                ans659.QuestionId = 659;
                ans659.AnsDes = this.serialNumberTextbox11.Value;
                ans659.AnserTypeId = 4;
                ans659.CreateDate = DateTime.Now;
                ans659.UserId = user.Id;
                ans659.AnsMonth = ansMonth; ans659.SRId = sR.Id;
            }





            var ans660 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 660).FirstOrDefault();
            if (ans660 == null)
            {
                //  new SerialNumber 11 :           
                Answer answer183 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox11.Value,
                    QuestionId = 660,
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
                ans660.QuestionId = 660;
                ans660.AnsDes = this.newSerialNumberTextbox11.Value;
                ans660.AnserTypeId = 4;
                ans660.CreateDate = DateTime.Now;
                ans660.UserId = user.Id;
                ans660.AnsMonth = ansMonth; ans660.SRId = sR.Id;
            }




            var ans661 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 661).FirstOrDefault();
            if (ans661 == null)
            {
                //  หมายเหตุ  11:           
                Answer answer184 = new Answer()
                {
                    AnsDes = this.noteTextbox11.Value,
                    QuestionId = 661,
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
                ans661.QuestionId = 661;
                ans661.AnsDes = this.noteTextbox11.Value;
                ans661.AnserTypeId = 4;
                ans661.CreateDate = DateTime.Now;
                ans661.UserId = user.Id;
                ans661.AnsMonth = ansMonth; ans661.SRId = sR.Id;
            }




            var ans662 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 662).FirstOrDefault();
            if (ans662 == null)
            {

                // รายการอุปกรณ์ 12 :      
                Answer answer185 = new Answer()
                {
                    AnsDes = this.toolsListTextbox12.Value,
                    QuestionId = 662,
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
                ans662.QuestionId = 662;
                ans662.AnsDes = this.toolsListTextbox12.Value;
                ans662.AnserTypeId = 4;
                ans662.CreateDate = DateTime.Now;
                ans662.UserId = user.Id;
                ans662.AnsMonth = ansMonth; ans662.SRId = sR.Id;
            }







            var ans663 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 663).FirstOrDefault();
            if (ans663 == null)
            {
                //  SerialNumber 12 :           
                Answer answer186 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox12.Value,
                    QuestionId = 663,
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
                ans663.QuestionId = 663;
                ans663.AnsDes = this.serialNumberTextbox12.Value;
                ans663.AnserTypeId = 4;
                ans663.CreateDate = DateTime.Now;
                ans663.UserId = user.Id;
                ans663.AnsMonth = ansMonth; ans663.SRId = sR.Id;
            }




            var ans664 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 664).FirstOrDefault();
            if (ans664 == null)
            {
                //  new SerialNumber 12 :           
                Answer answer187 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox12.Value,
                    QuestionId = 664,
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
                ans664.QuestionId = 664;
                ans664.AnsDes = this.newSerialNumberTextbox12.Value;
                ans664.AnserTypeId = 4;
                ans664.CreateDate = DateTime.Now;
                ans664.UserId = user.Id;
                ans664.AnsMonth = ansMonth; ans664.SRId = sR.Id;
            }



            var ans665 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 665).FirstOrDefault();
            if (ans665 == null)
            {
                //  หมายเหตุ  12:           
                Answer answer188 = new Answer()
                {
                    AnsDes = this.noteTextbox12.Value,
                    QuestionId = 665,
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
                ans665.QuestionId = 665;
                ans665.AnsDes = this.noteTextbox12.Value;
                ans665.AnserTypeId = 4;
                ans665.CreateDate = DateTime.Now;
                ans665.UserId = user.Id;
                ans665.AnsMonth = ansMonth; ans665.SRId = sR.Id;
            }




            var ans666 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 666).FirstOrDefault();
            if (ans666 == null)
            {
                // รายการอุปกรณ์ 13 :      
                Answer answer189 = new Answer()
                {
                    AnsDes = this.toolsListTextbox13.Value,
                    QuestionId = 666,
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
                ans666.QuestionId = 666;
                ans666.AnsDes = this.toolsListTextbox13.Value;
                ans666.AnserTypeId = 4;
                ans666.CreateDate = DateTime.Now;
                ans666.UserId = user.Id;
                ans666.AnsMonth = ansMonth; ans666.SRId = sR.Id;
            }



            var ans667 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 667).FirstOrDefault();
            if (ans667 == null)
            {
                //  SerialNumber 13 :           
                Answer answer190 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox13.Value,
                    QuestionId = 667,
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
                ans667.QuestionId = 667;
                ans667.AnsDes = this.serialNumberTextbox13.Value;
                ans667.AnserTypeId = 4;
                ans667.CreateDate = DateTime.Now;
                ans667.UserId = user.Id;
                ans667.AnsMonth = ansMonth; ans667.SRId = sR.Id;
            }





            var ans668 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 668).FirstOrDefault();
            if (ans668 == null)
            {
                //  new SerialNumber 13 :           
                Answer answer191 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox13.Value,
                    QuestionId = 668,
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
                ans668.QuestionId = 668;
                ans668.AnsDes = this.newSerialNumberTextbox13.Value;
                ans668.AnserTypeId = 4;
                ans668.CreateDate = DateTime.Now;
                ans668.UserId = user.Id;
                ans668.AnsMonth = ansMonth; ans668.SRId = sR.Id;
            }






            var ans669 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 669).FirstOrDefault();
            if (ans669 == null)
            {
                //  หมายเหตุ  13   :    
                Answer answer192 = new Answer()
                {
                    AnsDes = this.noteTextbox13.Value,
                    QuestionId = 669,
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
                ans669.QuestionId = 669;
                ans669.AnsDes = this.noteTextbox13.Value;
                ans669.AnserTypeId = 4;
                ans669.CreateDate = DateTime.Now;
                ans669.UserId = user.Id;
                ans669.AnsMonth = ansMonth; ans669.SRId = sR.Id;
            }







            var ans670 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 670).FirstOrDefault();
            if (ans670 == null)
            {
                // รายการอุปกรณ์ 14 :      
                Answer answer193 = new Answer()
                {
                    AnsDes = this.toolsListTextbox14.Value,
                    QuestionId = 670,
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
                ans670.QuestionId = 670;
                ans670.AnsDes = this.toolsListTextbox14.Value;
                ans670.AnserTypeId = 4;
                ans670.CreateDate = DateTime.Now;
                ans670.UserId = user.Id;
                ans670.AnsMonth = ansMonth; ans670.SRId = sR.Id;
            }




            var ans671 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 671).FirstOrDefault();
            if (ans671 == null)
            {
                //  SerialNumber 14 :           
                Answer answer194 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox14.Value,
                    QuestionId = 671,
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
                ans671.QuestionId = 671;
                ans671.AnsDes = this.serialNumberTextbox14.Value;
                ans671.AnserTypeId = 4;
                ans671.CreateDate = DateTime.Now;
                ans671.UserId = user.Id;
                ans671.AnsMonth = ansMonth; ans671.SRId = sR.Id;
            }




            var ans672 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 672).FirstOrDefault();
            if (ans672 == null)
            {
                //  new SerialNumber 14 :           
                Answer answer195 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox14.Value,
                    QuestionId = 672,
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
                ans672.QuestionId = 672;
                ans672.AnsDes = this.newSerialNumberTextbox14.Value;
                ans672.AnserTypeId = 4;
                ans672.CreateDate = DateTime.Now;
                ans672.UserId = user.Id;
                ans672.AnsMonth = ansMonth; ans672.SRId = sR.Id;
            }



            var ans673 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 673).FirstOrDefault();
            if (ans673 == null)
            {
                //  หมายเหตุ  143   :    
                Answer answer196 = new Answer()
                {
                    AnsDes = this.noteTextbox14.Value,
                    QuestionId = 673,
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
                ans673.QuestionId = 673;
                ans673.AnsDes = this.noteTextbox14.Value;
                ans673.AnserTypeId = 4;
                ans673.CreateDate = DateTime.Now;
                ans673.UserId = user.Id;
                ans673.AnsMonth = ansMonth; ans673.SRId = sR.Id;
            }




            var ans674 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 674).FirstOrDefault();
            if (ans674 == null)
            {
                // รายการอุปกรณ์ 15 :      
                Answer answer197 = new Answer()
                {
                    AnsDes = this.toolsListTextbox15.Value,
                    QuestionId = 674,
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
                ans674.QuestionId = 674;
                ans674.AnsDes = this.toolsListTextbox15.Value;
                ans674.AnserTypeId = 4;
                ans674.CreateDate = DateTime.Now;
                ans674.UserId = user.Id;
                ans674.AnsMonth = ansMonth; ans674.SRId = sR.Id;
            }





            var ans675 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 675).FirstOrDefault();
            if (ans675 == null)
            {
                //  SerialNumber 15 :           
                Answer answer198 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox15.Value,
                    QuestionId = 675,
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
                ans675.QuestionId = 675;
                ans675.AnsDes = this.serialNumberTextbox15.Value;
                ans675.AnserTypeId = 1;
                ans675.CreateDate = DateTime.Now;
                ans675.UserId = user.Id;
                ans675.AnsMonth = ansMonth; ans675.SRId = sR.Id;
            }





            var ans676 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 676).FirstOrDefault();
            if (ans676 == null)
            {
                //  new SerialNumber 15 :           
                Answer answer199 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox15.Value,
                    QuestionId = 676,
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
                ans676.QuestionId = 676;
                ans676.AnsDes = this.newSerialNumberTextbox15.Value;
                ans676.AnserTypeId = 1;
                ans676.CreateDate = DateTime.Now;
                ans676.UserId = user.Id;
                ans676.AnsMonth = ansMonth; ans676.SRId = sR.Id;
            }






            var ans677 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 677).FirstOrDefault();
            if (ans677 == null)
            {
                //  หมายเหตุ  15   :    
                Answer answer200 = new Answer()
                {
                    AnsDes = this.noteTextbox15.Value,
                    QuestionId = 677,
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
                ans677.QuestionId = 677;
                ans677.AnsDes = this.noteTextbox15.Value;
                ans677.AnserTypeId = 1;
                ans677.CreateDate = DateTime.Now;
                ans677.UserId = user.Id;
                ans677.AnsMonth = ansMonth; ans677.SRId = sR.Id;
            }





            var ans678 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 678).FirstOrDefault();
            if (ans678 == null)
            {
                //   name pm :    
                Answer answer1591 = new Answer()
                {
                    AnsDes = this.nameDopmTextbox.Value,
                    QuestionId = 678,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer1591);

            }
            else
            {
                ans678.QuestionId = 678;
                ans678.AnsDes = this.nameDopmTextbox.Value;
                ans678.AnserTypeId = 1;
                ans678.CreateDate = DateTime.Now;
                ans678.UserId = user.Id;
                ans678.AnsMonth = ansMonth; ans678.SRId = sR.Id;
            }



            var ans679 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 679).FirstOrDefault();
            if (ans679 == null)
            {

                //  วันที่ทำ PM :    
                Answer answer1592 = new Answer()
                {
                    AnsDes = this.dayDopmTextbox.Value,
                    QuestionId = 679,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer1592);

            }
            else
            {
                ans679.QuestionId = 679;
                ans679.AnsDes = this.dayDopmTextbox.Value;
                ans679.AnserTypeId = 1;
                ans679.CreateDate = DateTime.Now;
                ans679.UserId = user.Id;
                ans679.AnsMonth = ansMonth; ans679.SRId = sR.Id;
            }



            var ans680 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 680).FirstOrDefault();
            if (ans680 == null)
            {

                // รูปภาพรวมบริเวณ Site :
                string steAreaRadio = Request.Form["steAreaRadio"];
                Answer answer1593 = new Answer()
                {
                    AnsDes = steAreaRadio,
                    QuestionId = 680,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer1593);

            }
            else
            {
                string steAreaRadio = Request.Form["steAreaRadio"];
                ans680.QuestionId = 680;
                ans680.AnsDes = steAreaRadio;
                ans680.AnserTypeId = 1;
                ans680.CreateDate = DateTime.Now;
                ans680.UserId = user.Id;
                ans680.AnsMonth = ansMonth; ans680.SRId = sR.Id;
            }






            var ans681 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 681).FirstOrDefault();
            if (ans681 == null)
            {

                // รูปหน้าตู้ ก่อน-หลัง Site :
                string beforeAfterRadio = Request.Form["beforeAfterRadio"];
                Answer answer1594 = new Answer()
                {
                    AnsDes = beforeAfterRadio,
                    QuestionId = 681,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer1594);

            }
            else
            {
                string varibles = Request.Form["beforeAfterRadio"];
                ans681.QuestionId = 681;
                ans681.AnsDes = varibles;
                ans681.AnserTypeId = 1;
                ans681.CreateDate = DateTime.Now;
                ans681.UserId = user.Id;
                ans681.AnsMonth = ansMonth; ans681.SRId = sR.Id;
            }









            var ans682 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 682).FirstOrDefault();
            if (ans682 == null)
            {

                // รูปภายในตู้ ก่อน-หลัง :
                string picIncontainRadio = Request.Form["picIncontainRadio"];
                Answer answer1595 = new Answer()
                {
                    AnsDes = picIncontainRadio,
                    QuestionId = 682,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer1595);

            }
            else
            {
                string varibles = Request.Form["picIncontainRadio"];
                ans682.QuestionId = 682;
                ans682.AnsDes = varibles;
                ans682.AnserTypeId = 1;
                ans682.CreateDate = DateTime.Now;
                ans682.UserId = user.Id;
                ans682.AnsMonth = ansMonth; ans682.SRId = sR.Id;
            }





            var ans683 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 683).FirstOrDefault();
            if (ans683 == null)
            {

                // รูปขณะทำความสะอาดตู้ ก่อน-หลัง :
                string beforeCleanRaio = Request.Form["beforeCleanRaio"];
                Answer answer1596 = new Answer()
                {
                    AnsDes = beforeCleanRaio,
                    QuestionId = 683,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer1596);

            }
            else
            {
                string varibles = Request.Form["beforeCleanRaio"];
                ans683.QuestionId = 683;
                ans683.AnsDes = varibles;
                ans683.AnserTypeId = 1;
                ans683.CreateDate = DateTime.Now;
                ans683.UserId = user.Id;
                ans683.AnsMonth = ansMonth; ans683.SRId = sR.Id;
            }




            var ans684 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 684).FirstOrDefault();
            if (ans684 == null)
            {


                // รูปสถานะ Circuit Breaker (ON):
                string circuitBreakOnRaio = Request.Form["circuitBreakOnRaio"];
                Answer answer1597 = new Answer()
                {
                    AnsDes = circuitBreakOnRaio,
                    QuestionId = 684,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer1597);

            }
            else
            {
                string varibles = Request.Form["circuitBreakOnRaio"];
                ans684.QuestionId = 684;
                ans684.AnsDes = varibles;
                ans684.AnserTypeId = 1;
                ans684.CreateDate = DateTime.Now;
                ans684.UserId = user.Id;
                ans684.AnsMonth = ansMonth; ans684.SRId = sR.Id;
            }



            var ans685 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 685).FirstOrDefault();
            if (ans685 == null)
            {



                // รูปการตรวจสอบ Ground และ Bar Ground :
                string GroundAndBarGroundRaio = Request.Form["GroundAndBarGroundRaio"];
                Answer answer1600 = new Answer()
                {
                    AnsDes = GroundAndBarGroundRaio,
                    QuestionId = 685,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer1600);

            }
            else
            {
                string varibles = Request.Form["GroundAndBarGroundRaio"];
                ans685.QuestionId = 685;
                ans685.AnsDes = varibles;
                ans685.AnserTypeId = 1;
                ans685.CreateDate = DateTime.Now;
                ans685.UserId = user.Id;
                ans685.AnsMonth = ansMonth; ans685.SRId = sR.Id;
            }




            var ans686 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 686).FirstOrDefault();
            if (ans686 == null)
            {

                // รูปการตรวจสอบสถานะไฟฟ้ารั่วลง Ground (Lamp Test:
                string groundLampRadio = Request.Form["groundLampRadio"];
                Answer answer1601 = new Answer()
                {
                    AnsDes = groundLampRadio,
                    QuestionId = 686,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer1601);

            }
            else
            {
                string varibles = Request.Form["groundLampRadio"];
                ans686.QuestionId = 686;
                ans686.AnsDes = varibles;
                ans686.AnserTypeId = 1;
                ans686.CreateDate = DateTime.Now;
                ans686.UserId = user.Id;
                ans686.AnsMonth = ansMonth; ans686.SRId = sR.Id;
            }






            var ans687 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 687).FirstOrDefault();
            if (ans687 == null)
            {

                // รูป PEA Meter :
                string peaMeterRaio = Request.Form["peaMeterRaio"];
                Answer answer1602 = new Answer()
                {
                    AnsDes = peaMeterRaio,
                    QuestionId = 687,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer1602);

            }
            else
            {
                string varibles = Request.Form["peaMeterRaio"];
                ans687.QuestionId = 687;
                ans687.AnsDes = varibles;
                ans687.AnserTypeId = 1;
                ans687.CreateDate = DateTime.Now;
                ans687.UserId = user.Id;
                ans687.AnsMonth = ansMonth; ans687.SRId = sR.Id;
            }




            var ans688 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 688).FirstOrDefault();
            if (ans688 == null)
            {

                // >รูปการวัดแรงดัน AC และกระแส AC :
                string acAndACRadio = Request.Form["acAndACRadio"];
                Answer answer1603 = new Answer()
                {
                    AnsDes = acAndACRadio,
                    QuestionId = 688,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer1603);

            }
            else
            {
                string varibles = Request.Form["acAndACRadio"];
                ans688.QuestionId = 688;
                ans688.AnsDes = varibles;
                ans688.AnserTypeId = 1;
                ans688.CreateDate = DateTime.Now;
                ans688.UserId = user.Id;
                ans688.AnsMonth = ansMonth; ans688.SRId = sR.Id;
            }


            var ans689 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 689).FirstOrDefault();
            if (ans689 == null)
            {

                // รูปหน้าจอ UPS แสดงค่าต่างๆ และ Serial NO. :
                string monitorSerRadio = Request.Form["monitorSerRadio"];
                Answer answer1604 = new Answer()
                {
                    AnsDes = monitorSerRadio,
                    QuestionId = 689,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer1604);

            }
            else
            {
                string varibles = Request.Form["monitorSerRadio"];
                ans689.QuestionId = 689;
                ans689.AnsDes = varibles;
                ans689.AnserTypeId = 1;
                ans689.CreateDate = DateTime.Now;
                ans689.UserId = user.Id;
                ans689.AnsMonth = ansMonth; ans689.SRId = sR.Id;
            }





            var ans690 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 690).FirstOrDefault();
            if (ans690 == null)
            {

                // รูป ONU/Modem พร้อม Serial NO. และ MAC :
                string ONUModemAndMacRadio = Request.Form["ONUModemAndMacRadio"];
                Answer answer1605 = new Answer()
                {
                    AnsDes = ONUModemAndMacRadio,
                    QuestionId = 690,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer1605);

            }
            else
            {
                string varibles = Request.Form["v"];
                ans690.QuestionId = 690;
                ans690.AnsDes = varibles;
                ans690.AnserTypeId = 1;
                ans690.CreateDate = DateTime.Now;
                ans690.UserId = user.Id;
                ans690.AnsMonth = ansMonth; ans690.SRId = sR.Id;
            }





            var ans691 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 691).FirstOrDefault();
            if (ans691 == null)
            {

                // รูป Power Supply พร้อม Serial NO.  :
                string psuAndSerialRadio = Request.Form["psuAndSerialRadio"];
                Answer answer454 = new Answer()
                {
                    AnsDes = psuAndSerialRadio,
                    QuestionId = 691,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer454);

            }
            else
            {
                string varibles = Request.Form["psuAndSerialRadio"];
                ans691.QuestionId = 691;
                ans691.AnsDes = varibles;
                ans691.AnserTypeId = 1;
                ans691.CreateDate = DateTime.Now;
                ans691.UserId = user.Id;
                ans691.AnsMonth = ansMonth; ans691.SRId = sR.Id;
            }





            var ans692 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 692).FirstOrDefault();
            if (ans692 == null)
            {

                // รูป Switch 8 Port พร้อม Serial NO. และ MAC  :
                string switch8PortRadio = Request.Form["switch8PortRadio"];
                Answer answer455 = new Answer()
                {
                    AnsDes = switch8PortRadio,
                    QuestionId = 692,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer455);

            }
            else
            {
                string varibles = Request.Form["switch8PortRadio"];
                ans692.QuestionId = 692;
                ans692.AnsDes = varibles;
                ans692.AnserTypeId = 1;
                ans692.CreateDate = DateTime.Now;
                ans692.UserId = user.Id;
                ans692.AnsMonth = ansMonth; ans692.SRId = sR.Id;
            }





            var ans693 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 693).FirstOrDefault();
            if (ans693 == null)
            {
                // รูป Outdoor AP 2.4 GHz พร้อม Serial NO. และ MAC :
                string outDoorApRadio = Request.Form["outDoorApRadio"];
                Answer answer456 = new Answer()
                {
                    AnsDes = outDoorApRadio,
                    QuestionId = 693,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer456);

            }
            else
            {
                string varibles = Request.Form["outDoorApRadio"];
                ans693.QuestionId = 693;
                ans693.AnsDes = varibles;
                ans693.AnserTypeId = 1;
                ans693.CreateDate = DateTime.Now;
                ans693.UserId = user.Id;
                ans693.AnsMonth = ansMonth; ans693.SRId = sR.Id;
            }



            var ans694 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 694).FirstOrDefault();
            if (ans694 == null)
            {
                // รูป Outdoor AP 5 GHz พร้อม Serial NO. และ MAC :
                string outDoorAp5GhzRadio = Request.Form["PASSoutDoorAp5GhzRadio"];
                Answer answer457 = new Answer()
                {
                    AnsDes = outDoorAp5GhzRadio,
                    QuestionId = 694,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer457);

            }
            else
            {
                string varibles = Request.Form["PASSoutDoorAp5GhzRadio"];
                ans694.QuestionId = 694;
                ans694.AnsDes = varibles;
                ans694.AnserTypeId = 1;
                ans694.CreateDate = DateTime.Now;
                ans694.UserId = user.Id;
                ans694.AnsMonth = ansMonth; ans694.SRId = sR.Id;
            }



            var ans695 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 695).FirstOrDefault();
            if (ans695 == null)
            {

                // รูปการ Test Speed ONU (30/10 mbps) :
                string testSpeedOnuRadio = Request.Form["testSpeedOnuRadio"];
                Answer answer1606 = new Answer()
                {
                    AnsDes = testSpeedOnuRadio,
                    QuestionId = 695,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer1606);

            }
            else
            {
                string varibles = Request.Form["testSpeedOnuRadio"];
                ans695.QuestionId = 695;
                ans695.AnsDes = varibles;
                ans695.AnserTypeId = 1;
                ans695.CreateDate = DateTime.Now;
                ans695.UserId = user.Id;
                ans695.AnsMonth = ansMonth; ans695.SRId = sR.Id;
            }





            var ans696 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 696).FirstOrDefault();
            if (ans696 == null)
            {

                // รูปการ Test Speed VSAT (30/5 mbps) *เฉพาะ SAT :
                string testSpeedVsatRadio = Request.Form["testSpeedVsatRadio"];
                Answer answer459 = new Answer()
                {
                    AnsDes = testSpeedVsatRadio,
                    QuestionId = 696,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer459);

            }
            else
            {
                string varibles = Request.Form["testSpeedVsatRadio"];
                ans696.QuestionId = 696;
                ans696.AnsDes = varibles;
                ans696.AnserTypeId = 1;
                ans696.CreateDate = DateTime.Now;
                ans696.UserId = user.Id;
                ans696.AnsMonth = ansMonth; ans696.SRId = sR.Id;
            }



            var ans697 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 697).FirstOrDefault();
            if (ans697 == null)
            {


                // รูป Cable Inlet ด้านในและด้านนอก :
                string cableInlet = Request.Form["eieicableInletRadio"];
                Answer answer460 = new Answer()
                {
                    AnsDes = cableInlet,
                    QuestionId = 697,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer460);

            }
            else
            {
                string varibles = Request.Form["eieicableInletRadio"];
                ans697.QuestionId = 697;
                ans697.AnsDes = varibles;
                ans697.AnserTypeId = 1;
                ans697.CreateDate = DateTime.Now;
                ans697.UserId = user.Id;
                ans697.AnsMonth = ansMonth; ans697.SRId = sR.Id;
            }



            var ans698 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 698).FirstOrDefault();
            if (ans698 == null)
            {


                // รูป Filter ก่อน-หลัง ทำความสะอาด :
                string filterBeforeCleanRadio = Request.Form["filterBeforeCleanRadio"];
                Answer answer461 = new Answer()
                {
                    AnsDes = filterBeforeCleanRadio,
                    QuestionId = 698,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer461);

            }
            else
            {
                string varibles = Request.Form["filterBeforeCleanRadio"];
                ans698.QuestionId = 698;
                ans698.AnsDes = varibles;
                ans698.AnserTypeId = 1;
                ans698.CreateDate = DateTime.Now;
                ans698.UserId = user.Id;
                ans698.AnsMonth = ansMonth; ans698.SRId = sR.Id;
            }





            var ans699 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 699).FirstOrDefault();
            if (ans699 == null)
            {
                // รูปจุดติดตั้งจานดาวเทียม :
                string inStallSatRadio = Request.Form["inStallSatRadio"];
                Answer answer1614 = new Answer()
                {
                    AnsDes = inStallSatRadio,
                    QuestionId = 699,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer1614);

            }
            else
            {
                string varibles = Request.Form["inStallSatRadio"];
                ans699.QuestionId = 699;
                ans699.AnsDes = varibles;
                ans699.AnserTypeId = 1;
                ans699.CreateDate = DateTime.Now;
                ans699.UserId = user.Id;
                ans699.AnsMonth = ansMonth; ans699.SRId = sR.Id;
            }




            var ans700 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 700).FirstOrDefault();
            if (ans700 == null)
            {
                // รูปความสะอาดบริเวณจานดาวเทียม :
                string cleanSatRadio = Request.Form["cleanSatRadio"];
                Answer answer1615 = new Answer()
                {
                    AnsDes = cleanSatRadio,
                    QuestionId = 700,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer1615);

            }
            else
            {
                string varibles = Request.Form["cleanSatRadio"];
                ans700.QuestionId = 700;
                ans700.AnsDes = varibles;
                ans700.AnserTypeId = 1;
                ans700.CreateDate = DateTime.Now;
                ans700.UserId = user.Id;
                ans700.AnsMonth = ansMonth; ans700.SRId = sR.Id;
            }






            var ans701 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 701).FirstOrDefault();
            if (ans701 == null)
            {
                //รูป LNB พร้อม Part NO :
                string lnbWithpartRadio = Request.Form["lnbWithpartRadio"];
                Answer answer1616 = new Answer()
                {
                    AnsDes = lnbWithpartRadio,
                    QuestionId = 701,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer1616);

            }
            else
            {
                string varibles = Request.Form["lnbWithpartRadio"];
                ans701.QuestionId = 701;
                ans701.AnsDes = varibles;
                ans701.AnserTypeId = 1;
                ans701.CreateDate = DateTime.Now;
                ans701.UserId = user.Id;
                ans701.AnsMonth = ansMonth; ans701.SRId = sR.Id;
            }






            var ans702 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 702).FirstOrDefault();
            if (ans702 == null)
            {
                //รูป BUC พร้อม Part NO :
                string bucWithpartRadio = Request.Form["bucWithpartRadio"];
                Answer answer1617 = new Answer()
                {
                    AnsDes = bucWithpartRadio,
                    QuestionId = 702,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer1617);

            }
            else
            {
                string varibles = Request.Form["bucWithpartRadio"];
                ans702.QuestionId = 702;
                ans702.AnsDes = varibles;
                ans702.AnserTypeId = 1;
                ans702.CreateDate = DateTime.Now;
                ans702.UserId = user.Id;
                ans702.AnsMonth = ansMonth; ans702.SRId = sR.Id;
            }





            var ans703 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 703).FirstOrDefault();
            if (ans703 == null)
            {
                //รูปการเก็บสายและพันหัวที่ LNB/BUC :
                string wireingLnbRadio = Request.Form["wireingLnbRadio"];
                Answer answer1618 = new Answer()
                {
                    AnsDes = wireingLnbRadio,
                    QuestionId = 703,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer1618);

            }
            else
            {
                string varibles = Request.Form["wireingLnbRadio"];
                ans703.QuestionId = 703;
                ans703.AnsDes = varibles;
                ans703.AnserTypeId = 1;
                ans703.CreateDate = DateTime.Now;
                ans703.UserId = user.Id;
                ans703.AnsMonth = ansMonth; ans703.SRId = sR.Id;
            }


            var ans704 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 704).FirstOrDefault();
            if (ans704 == null)
            {
                //แนว Line Of Sight (ดูการถูกบังของหน้าจานดาวเทียม)  :
                string lineOfsightRadio = Request.Form["lineOfsightRadio"];
                Answer answer1619 = new Answer()
                {
                    AnsDes = lineOfsightRadio,
                    QuestionId = 704,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer1619);

            }
            else
            {
                string varibles = Request.Form["lineOfsightRadio"];
                ans704.QuestionId = 704;
                ans704.AnsDes = varibles;
                ans704.AnserTypeId = 1;
                ans704.CreateDate = DateTime.Now;
                ans704.UserId = user.Id;
                ans704.AnsMonth = ansMonth; ans704.SRId = sR.Id;
            }




            //-----------------------------   - SECTION 42   ----------------------------------------//


            var ans705 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 705).FirstOrDefault();
            if (ans705 == null)
            {
                //รูปจุดติดตั้ง Solar Cell  :
                string solarCellRadio = Request.Form["solarCellRadio"];
                Answer answer1620 = new Answer()
                {
                    AnsDes = solarCellRadio,
                    QuestionId = 705,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer1620);

            }
            else
            {
                string varibles = Request.Form["solarCellRadio"];
                ans705.QuestionId = 705;
                ans705.AnsDes = varibles;
                ans705.AnserTypeId = 1;
                ans705.CreateDate = DateTime.Now;
                ans705.UserId = user.Id;
                ans705.AnsMonth = ansMonth; ans705.SRId = sR.Id;
            }




            var ans706 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 706).FirstOrDefault();
            if (ans706 == null)
            {
                //รูปจุดติดตั้ง Solar Cell :
                string toolsinSolarcellRadio = Request.Form["toolsinSolarcellRadio"];
                Answer answer1621 = new Answer()
                {
                    AnsDes = toolsinSolarcellRadio,
                    QuestionId = 706,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer1621);

            }
            else
            {
                string varibles = Request.Form["toolsinSolarcellRadio"];
                ans706.QuestionId = 706;
                ans706.AnsDes = varibles;
                ans706.AnserTypeId = 1;
                ans706.CreateDate = DateTime.Now;
                ans706.UserId = user.Id;
                ans706.AnsMonth = ansMonth; ans706.SRId = sR.Id;
            }


            var ans707 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 707).FirstOrDefault();
            if (ans707 == null)
            {
                //รูปหน้าจอ Charger แสดงค่าต่างๆ:
                string chargerRadio = Request.Form["chargerRadio"];
                Answer answer470 = new Answer()
                {
                    AnsDes = chargerRadio,
                    QuestionId = 707,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer470);

            }
            else
            {
                string varibles = Request.Form["chargerRadio"];
                ans707.QuestionId = 707;
                ans707.AnsDes = varibles;
                ans707.AnserTypeId = 1;
                ans707.CreateDate = DateTime.Now;
                ans707.UserId = user.Id;
                ans707.AnsMonth = ansMonth; ans707.SRId = sR.Id;
            }



            var ans708 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 708).FirstOrDefault();
            if (ans708 == null)
            {
                //รูปหน้าจอ Inverter แสดงค่าต่างๆ:
                string snowingInverter = Request.Form["snowingInverterRadio"];
                Answer answer471 = new Answer()
                {
                    AnsDes = snowingInverter,
                    QuestionId = 708,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer471);

            }
            else
            {
                string varibles = Request.Form["snowingInverterRadio"];
                ans708.QuestionId = 708;
                ans708.AnsDes = varibles;
                ans708.AnserTypeId = 1;
                ans708.CreateDate = DateTime.Now;
                ans708.UserId = user.Id;
                ans708.AnsMonth = ansMonth; ans708.SRId = sR.Id;
            }



            var ans709 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 709).FirstOrDefault();
            if (ans709 == null)
            {
                //รูป Circuit Breaker ภายในตู้:
                string cirBreakerRadio = Request.Form["cirBreakerRadio"];
                Answer answer472 = new Answer()
                {
                    AnsDes = cirBreakerRadio,
                    QuestionId = 709,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer472);

            }
            else
            {
                string varibles = Request.Form["cirBreakerRadio"];
                ans709.QuestionId = 709;
                ans709.AnsDes = varibles;
                ans709.AnserTypeId = 1;
                ans708.CreateDate = DateTime.Now;
                ans709.UserId = user.Id;
                ans709.AnsMonth = ansMonth; ans709.SRId = sR.Id;
            }




            var ans710 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 710).FirstOrDefault();
            if (ans710 == null)
            {
                //>รูป Terminal ต่อสายภายในตู้ :
                string termialInnerRadio = Request.Form["termialInnerRadio"];
                Answer answer473 = new Answer()
                {
                    AnsDes = termialInnerRadio,
                    QuestionId = 710,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer473);

            }
            else
            {
                string varibles = Request.Form["termialInnerRadio"];
                ans710.QuestionId = 710;
                ans710.AnsDes = varibles;
                ans710.AnserTypeId = 1;
                ans710.CreateDate = DateTime.Now;
                ans710.UserId = user.Id;
                ans710.AnsMonth = ansMonth; ans710.SRId = sR.Id;
            }



            var ans711 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 711).FirstOrDefault();
            if (ans711 == null)
            {
                // รูปการวัดแรงดัน Battery ก้อนที่ 1 :
                string batteryVoltRadio1 = Request.Form["batteryVoltRadio1"];
                Answer answer1626 = new Answer()
                {
                    AnsDes = batteryVoltRadio1,
                    QuestionId = 711,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer1626);

            }
            else
            {
                string varibles = Request.Form["batteryVoltRadio1"];
                ans711.QuestionId = 711;
                ans711.AnsDes = varibles;
                ans711.AnserTypeId = 1;
                ans711.CreateDate = DateTime.Now;
                ans711.UserId = user.Id;
                ans711.AnsMonth = ansMonth; ans711.SRId = sR.Id;
            }




            var ans712 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 712).FirstOrDefault();
            if (ans712 == null)
            {
                // รูปการวัดแรงดัน Battery ก้อนที่ 2 :
                string batteryVoltRadio2 = Request.Form["batteryVoltRadio2"];
                Answer answer1627 = new Answer()
                {
                    AnsDes = batteryVoltRadio2,
                    QuestionId = 712,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer1627);

            }
            else
            {
                string varibles = Request.Form["batteryVoltRadio2"];
                ans712.QuestionId = 712;
                ans712.AnsDes = varibles;
                ans712.AnserTypeId = 1;
                ans712.CreateDate = DateTime.Now;
                ans712.UserId = user.Id;
                ans712.AnsMonth = ansMonth; ans712.SRId = sR.Id;
            }






            var ans713 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 713).FirstOrDefault();
            if (ans713 == null)
            {
                // รูปการวัดแรงดัน Battery ก้อนที่ 3 :
                string batteryVoltRadio3 = Request.Form["batteryVoltRadio3"];
                Answer answer1628 = new Answer()
                {
                    AnsDes = batteryVoltRadio3,
                    QuestionId = 713,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer1628);

            }
            else
            {
                string varibles = Request.Form["batteryVoltRadio3"];
                ans713.QuestionId = 713;
                ans713.AnsDes = varibles;
                ans713.AnserTypeId = 1;
                ans713.CreateDate = DateTime.Now;
                ans713.UserId = user.Id;
                ans713.AnsMonth = ansMonth; ans713.SRId = sR.Id;
            }





            var ans714 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 714).FirstOrDefault();
            if (ans714 == null)
            {
                // รูปการวัดแรงดัน Battery ก้อนที่ 4 :
                string batteryVoltRadio4 = Request.Form["batteryVoltRadio4"];
                Answer answer1629 = new Answer()
                {
                    AnsDes = batteryVoltRadio4,
                    QuestionId = 714,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer1629);

            }
            else
            {
                string varibles = Request.Form["batteryVoltRadio4"];
                ans714.QuestionId = 714;
                ans714.AnsDes = varibles;
                ans714.AnserTypeId = 1;
                ans714.CreateDate = DateTime.Now;
                ans714.UserId = user.Id;
                ans714.AnsMonth = ansMonth; ans714.SRId = sR.Id;
            }







            var ans715 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 715).FirstOrDefault();
            if (ans715 == null)
            {
                // รูปความสะอาดแผง PV :
                string cleaninPVVRADIO = Request.Form["cleaninPVVRADIO"];
                Answer answer478 = new Answer()
                {
                    AnsDes = cleaninPVVRADIO,
                    QuestionId = 715,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer478);

            }
            else
            {
                string varibles = Request.Form["cleaninPVVRADIO"];
                ans715.QuestionId = 715;
                ans715.AnsDes = varibles;
                ans715.AnserTypeId = 1;
                ans715.CreateDate = DateTime.Now;
                ans715.UserId = user.Id;
                ans715.AnsMonth = ansMonth; ans715.SRId = sR.Id;
            }






            var ans716 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 716).FirstOrDefault();
            if (ans716 == null)
            {
                // รูปภาพรวมดูสิ่งบดบังแสงอาทิตย์ :
                string sunnyRadio = Request.Form["sunnyRadio"];
                Answer answer479 = new Answer()
                {
                    AnsDes = sunnyRadio,
                    QuestionId = 716,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer479);

            }
            else
            {
                string varibles = Request.Form["sunnyRadio"];
                ans716.QuestionId = 716;
                ans716.AnsDes = varibles;
                ans716.AnserTypeId = 1;
                ans716.CreateDate = DateTime.Now;
                ans716.UserId = user.Id;
                ans716.AnsMonth = ansMonth; ans716.SRId = sR.Id;
            }





            var ans717 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 717).FirstOrDefault();
            if (ans717 == null)
            {
                // คอมพิวเตอร์ตัวที่ 1  :
                string PicComRadio1 = Request.Form["PicComRadio1"];
                Answer answer717 = new Answer()
                {
                    AnsDes = PicComRadio1,
                    QuestionId = 717,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer717);

            }
            else
            {
                string varibles = Request.Form["PicComRadio1"];
                ans717.QuestionId = 717;
                ans717.AnsDes = varibles;
                ans717.AnserTypeId = 1;
                ans717.CreateDate = DateTime.Now;
                ans717.UserId = user.Id;
                ans717.AnsMonth = ansMonth; ans717.SRId = sR.Id;
            }






            var ans718 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 718).FirstOrDefault();
            if (ans718 == null)
            {
                // คอมพิวเตอร์ตัวที่ 2  :
                string PicComRadio2 = Request.Form["PicComRadio2"];
                Answer answer718 = new Answer()
                {
                    AnsDes = PicComRadio2,
                    QuestionId = 718,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer718);

            }
            else
            {
                string varibles = Request.Form["PicComRadio2"];
                ans718.QuestionId = 718;
                ans718.AnsDes = varibles;
                ans718.AnserTypeId = 1;
                ans718.CreateDate = DateTime.Now;
                ans718.UserId = user.Id;
                ans718.AnsMonth = ansMonth; ans718.SRId = sR.Id;
            }








            var ans719 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 719).FirstOrDefault();
            if (ans719 == null)
            {
                // คอมพิวเตอร์ตัวที่ 3  :
                string PicComRadio3 = Request.Form["PicComRadio3"];
                Answer answer719 = new Answer()
                {
                    AnsDes = PicComRadio3,
                    QuestionId = 719,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer719);

            }
            else
            {
                string varibles = Request.Form["PicComRadio3"];
                ans719.QuestionId = 719;
                ans719.AnsDes = varibles;
                ans719.AnserTypeId = 1;
                ans719.CreateDate = DateTime.Now;
                ans719.UserId = user.Id;
                ans719.AnsMonth = ansMonth; ans719.SRId = sR.Id;
            }






            var ans720 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 720).FirstOrDefault();
            if (ans720 == null)
            {
                // คอมพิวเตอร์ตัวที่ 4  :
                string PicComRadio4 = Request.Form["PicComRadio4"];
                Answer answer720 = new Answer()
                {
                    AnsDes = PicComRadio4,
                    QuestionId = 720,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer720);

            }
            else
            {
                string varibles = Request.Form["PicComRadio4"];
                ans720.QuestionId = 720;
                ans720.AnsDes = varibles;
                ans720.AnserTypeId = 1;
                ans720.CreateDate = DateTime.Now;
                ans720.UserId = user.Id;
                ans720.AnsMonth = ansMonth; ans720.SRId = sR.Id;
            }






            var ans721 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 721).FirstOrDefault();
            if (ans721 == null)
            {
                // คอมพิวเตอร์ตัวที่ 5  :
                string PicComRadio5 = Request.Form["PicComRadio5"];
                Answer answer721 = new Answer()
                {
                    AnsDes = PicComRadio5,
                    QuestionId = 721,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer721);

            }
            else
            {
                string varibles = Request.Form["PicComRadio5"];
                ans721.QuestionId = 721;
                ans721.AnsDes = varibles;
                ans721.AnserTypeId = 1;
                ans721.CreateDate = DateTime.Now;
                ans721.UserId = user.Id;
                ans721.AnsMonth = ansMonth; ans721.SRId = sR.Id;
            }



            var ans722 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 722).FirstOrDefault();
            if (ans722 == null)
            {
                // UPS สำหรับคอมพิวเตอร์ตัวที่ 1 :
                string PicupsRadio1 = Request.Form["PicupsRadio1"];
                Answer answer722 = new Answer()
                {
                    AnsDes = PicupsRadio1,
                    QuestionId = 722,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer722);

            }
            else
            {
                string varibles = Request.Form["PicupsRadio1"];
                ans722.QuestionId = 722;
                ans722.AnsDes = varibles;
                ans722.AnserTypeId = 1;
                ans722.CreateDate = DateTime.Now;
                ans722.UserId = user.Id;
                ans722.AnsMonth = ansMonth; ans722.SRId = sR.Id;
            }





            var ans723 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 723).FirstOrDefault();
            if (ans723 == null)
            {
                // UPS สำหรับคอมพิวเตอร์ตัวที่ 2 :
                string PicupsRadio2 = Request.Form["PicupsRadio2"];
                Answer answer723 = new Answer()
                {
                    AnsDes = PicupsRadio2,
                    QuestionId = 723,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer723);

            }
            else
            {
                string varibles = Request.Form["PicupsRadio2"];
                ans723.QuestionId = 723;
                ans723.AnsDes = varibles;
                ans723.AnserTypeId = 1;
                ans723.CreateDate = DateTime.Now;
                ans723.UserId = user.Id;
                ans723.AnsMonth = ansMonth; ans723.SRId = sR.Id;
            }



            var ans724 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 724).FirstOrDefault();
            if (ans724 == null)
            {
                // UPS สำหรับคอมพิวเตอร์ตัวที่ 3 :
                string PicupsRadio3 = Request.Form["PicupsRadio3"];
                Answer answer724 = new Answer()
                {
                    AnsDes = PicupsRadio3,
                    QuestionId = 724,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer724);


            }
            else
            {
                string varibles = Request.Form["PicupsRadio3"];
                ans724.QuestionId = 724;
                ans724.AnsDes = varibles;
                ans724.AnserTypeId = 1;
                ans724.CreateDate = DateTime.Now;
                ans724.UserId = user.Id;
                ans724.AnsMonth = ansMonth; ans724.SRId = sR.Id;
            }




            var ans725 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 725).FirstOrDefault();
            if (ans725 == null)
            {
                // UPS สำหรับคอมพิวเตอร์ตัวที่ 4 :
                string PicupsRadio4 = Request.Form["PicupsRadio4"];
                Answer answer725 = new Answer()
                {
                    AnsDes = PicupsRadio4,
                    QuestionId = 725,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer725);


            }
            else
            {
                string varibles = Request.Form["PicupsRadio4"];
                ans725.QuestionId = 725;
                ans725.AnsDes = varibles;
                ans725.AnserTypeId = 1;
                ans725.CreateDate = DateTime.Now;
                ans725.UserId = user.Id;
                ans725.AnsMonth = ansMonth; ans725.SRId = sR.Id;
            }





            var ans726 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 726).FirstOrDefault();
            if (ans726 == null)
            {
                // UPS สำหรับคอมพิวเตอร์ตัวที่ 5 :
                string PicupsRadio5 = Request.Form["PicupsRadio5"];
                Answer answer726 = new Answer()
                {
                    AnsDes = PicupsRadio5,
                    QuestionId = 726,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer726);


            }
            else
            {
                string varibles = Request.Form["PicupsRadio5"];
                ans726.QuestionId = 726;
                ans726.AnsDes = varibles;
                ans726.AnserTypeId = 1;
                ans726.CreateDate = DateTime.Now;
                ans726.UserId = user.Id;
                ans726.AnsMonth = ansMonth; ans726.SRId = sR.Id;
            }





            var ans727 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 727).FirstOrDefault();
            if (ans727 == null)
            {
                // Test ใช้งาน Internet (Speed Test) คอมพิวเตอร์ตัวที่ 1 :
                string PicspeedTestRaio1 = Request.Form["PicspeedTestRaio1"];
                Answer answer727 = new Answer()
                {
                    AnsDes = PicspeedTestRaio1,
                    QuestionId = 727,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer727);


            }
            else
            {
                string varibles = Request.Form["PicspeedTestRaio1"];
                ans727.QuestionId = 727;
                ans727.AnsDes = varibles;
                ans727.AnserTypeId = 1;
                ans727.CreateDate = DateTime.Now;
                ans727.UserId = user.Id;
                ans727.AnsMonth = ansMonth; ans727.SRId = sR.Id;
            }








            var ans728 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 728).FirstOrDefault();
            if (ans728 == null)
            {
                // Test ใช้งาน Internet (Speed Test) คอมพิวเตอร์ตัวที่ 2 :
                string PicspeedTestRaio2 = Request.Form["PicspeedTestRaio2"];
                Answer answer728 = new Answer()
                {
                    AnsDes = PicspeedTestRaio2,
                    QuestionId = 728,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer728);


            }
            else
            {
                string varibles = Request.Form["PicspeedTestRaio2"];
                ans728.QuestionId = 728;
                ans728.AnsDes = varibles;
                ans728.AnserTypeId = 1;
                ans728.CreateDate = DateTime.Now;
                ans728.UserId = user.Id;
                ans728.AnsMonth = ansMonth; ans728.SRId = sR.Id;
            }




            var ans729 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 729).FirstOrDefault();
            if (ans729 == null)
            {
                // Test ใช้งาน Internet (Speed Test) คอมพิวเตอร์ตัวที่ 3 :
                string PicspeedTestRaio3 = Request.Form["PicspeedTestRaio3"];
                Answer answer729 = new Answer()
                {
                    AnsDes = PicspeedTestRaio3,
                    QuestionId = 729,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer729);


            }
            else
            {
                string varibles = Request.Form["PicspeedTestRaio3"];
                ans729.QuestionId = 729;
                ans729.AnsDes = varibles;
                ans729.AnserTypeId = 1;
                ans729.CreateDate = DateTime.Now;
                ans729.UserId = user.Id;
                ans729.AnsMonth = ansMonth; ans729.SRId = sR.Id;
            }



            var ans730 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 730).FirstOrDefault();
            if (ans730 == null)
            {
                // Test ใช้งาน Internet (Speed Test) คอมพิวเตอร์ตัวที่ 4 :
                string PicspeedTestRaio4 = Request.Form["PicspeedTestRaio4"];
                Answer answer730 = new Answer()
                {
                    AnsDes = PicspeedTestRaio4,
                    QuestionId = 730,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer730);


            }
            else
            {
                string varibles = Request.Form["PicspeedTestRaio4"];
                ans730.QuestionId = 730;
                ans730.AnsDes = varibles;
                ans730.AnserTypeId = 1;
                ans730.CreateDate = DateTime.Now;
                ans730.UserId = user.Id;
                ans730.AnsMonth = ansMonth; ans730.SRId = sR.Id;
            }




            var ans731 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 731).FirstOrDefault();
            if (ans731 == null)
            {
                // Test ใช้งาน Internet (Speed Test) คอมพิวเตอร์ตัวที่ 5 :
                string PicspeedTestRaio5 = Request.Form["PicspeedTestRaio5"];
                Answer answer731 = new Answer()
                {
                    AnsDes = PicspeedTestRaio5,
                    QuestionId = 731,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer731);


            }
            else
            {
                string varibles = Request.Form["PicspeedTestRaio5"];
                ans731.QuestionId = 731;
                ans731.AnsDes = varibles;
                ans731.AnserTypeId = 1;
                ans731.CreateDate = DateTime.Now;
                ans731.UserId = user.Id;
                ans731.AnsMonth = ansMonth; ans731.SRId = sR.Id;
            }




            var ans732 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 732).FirstOrDefault();
            if (ans732 == null)

            {
                //1.รูป PICTURE CHECKLIST :
                if (this.pictureChecklistImages.HasFile)
                {
                    string extension = this.pictureChecklistImages.PostedFile.FileName.Split('.')[1];
                    string newFileName = "images/pictureChecklist_bb_2_3_3_3_" + DateTime.Now.ToString("yyyyMMddHHmmss") + "." + extension;
                    this.pictureChecklistImages.PostedFile.SaveAs(Server.MapPath(newFileName));

                    Answer answer259 = new Answer()
                    {
                        AnsDes = newFileName,
                        QuestionId = 732,
                        AnserTypeId = 3,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth,
                        SRId = sR.Id
                    };
                    uSOEntities.Answers.Add(answer259);
                }

            }
            else
            {
                if (this.pictureChecklistImages.HasFile)
                {
                    string extension = this.pictureChecklistImages.PostedFile.FileName.Split('.')[1];
                    string newFileName = "images/pictureChecklist_bb_2_3_3_3_" + DateTime.Now.ToString("yyyyMMddHHmmss") + "." + extension;
                    this.pictureChecklistImages.PostedFile.SaveAs(Server.MapPath(newFileName));
                    ans732.QuestionId = 732;
                    ans732.AnsDes = newFileName;
                    ans732.AnserTypeId = 3;
                    ans732.CreateDate = DateTime.Now;
                    ans732.UserId = user.Id;
                    ans732.AnsMonth = ansMonth; ans732.SRId = sR.Id;
                }
            }






            var ans733 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 733).FirstOrDefault();
            if (ans733 == null)

            {
                //2.รูป VSAT PICTURE CHECKLIST :
                if (this.vsatpictureChecklistImages.HasFile)
                {
                    string extension = this.vsatpictureChecklistImages.PostedFile.FileName.Split('.')[1];
                    string newFileName = "images/VsatPictureChecklist_bb_2_3_3_3_" + DateTime.Now.ToString("yyyyMMddHHmmss") + "." + extension;
                    this.vsatpictureChecklistImages.PostedFile.SaveAs(Server.MapPath(newFileName));

                    Answer answer260 = new Answer()
                    {
                        AnsDes = newFileName,
                        QuestionId = 733,
                        AnserTypeId = 3,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth,
                        SRId = sR.Id
                    };
                    uSOEntities.Answers.Add(answer260);
                }

            }
            else
            {
                if (this.vsatpictureChecklistImages.HasFile)
                {
                    string extension = this.vsatpictureChecklistImages.PostedFile.FileName.Split('.')[1];
                    string newFileName = "images/VsatPictureChecklist_bb_2_3_3_3_" + DateTime.Now.ToString("yyyyMMddHHmmss") + "." + extension;
                    this.vsatpictureChecklistImages.PostedFile.SaveAs(Server.MapPath(newFileName));
                    ans733.QuestionId = 733;
                    ans733.AnsDes = newFileName;
                    ans733.AnserTypeId = 3;
                    ans733.CreateDate = DateTime.Now;
                    ans733.UserId = user.Id;
                    ans733.AnsMonth = ansMonth; ans733.SRId = sR.Id;
                }
            }










            var ans734 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 734).FirstOrDefault();
            if (ans734 == null)

            {
                //3.รูป SOLAR CELL PICTURE CHECKLISTT :
                if (this.solarcellpictureChecklistImages.HasFile)
                {
                    string extension = this.solarcellpictureChecklistImages.PostedFile.FileName.Split('.')[1];
                    string newFileName = "images/SolarcellPictureChecklist_bb_2_3_3_3_" + DateTime.Now.ToString("yyyyMMddHHmmss") + "." + extension;
                    this.solarcellpictureChecklistImages.PostedFile.SaveAs(Server.MapPath(newFileName));

                    Answer answer261 = new Answer()
                    {
                        AnsDes = newFileName,
                        QuestionId = 734,
                        AnserTypeId = 3,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth,
                        SRId = sR.Id
                    };
                    uSOEntities.Answers.Add(answer261);
                }


            }
            else
            {
                if (this.solarcellpictureChecklistImages.HasFile)
                {
                    string extension = this.solarcellpictureChecklistImages.PostedFile.FileName.Split('.')[1];
                    string newFileName = "images/SolarcellPictureChecklist_bb_2_3_3_3_" + DateTime.Now.ToString("yyyyMMddHHmmss") + "." + extension;
                    this.solarcellpictureChecklistImages.PostedFile.SaveAs(Server.MapPath(newFileName));
                    ans734.QuestionId = 734;
                    ans734.AnsDes = newFileName;
                    ans734.AnserTypeId = 3;
                    ans734.CreateDate = DateTime.Now;
                    ans734.UserId = user.Id;
                    ans734.AnsMonth = ansMonth; ans734.SRId = sR.Id;
                }
            }








            var ans735 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 3 && x.SRId == sR.Id && x.QuestionId == 735).FirstOrDefault();
            if (ans735 == null)

            {
                //4. COMPUTER PICTURE CHECKLIST :
                if (this.computerChecklistImages.HasFile)
                {
                    string extension = this.computerChecklistImages.PostedFile.FileName.Split('.')[1];
                    string newFileName = "images/computerpicturechecklist_bb_2_3_3_3_" + DateTime.Now.ToString("yyyyMMddHHmmss") + "." + extension;
                    this.computerChecklistImages.PostedFile.SaveAs(Server.MapPath(newFileName));

                    Answer answer261 = new Answer()
                    {
                        AnsDes = newFileName,
                        QuestionId = 735,
                        AnserTypeId = 3,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth,
                        SRId = sR.Id
                    };
                    uSOEntities.Answers.Add(answer261);
                }



            }
            else
            {
                if (this.computerChecklistImages.HasFile)
                {
                    string extension = this.computerChecklistImages.PostedFile.FileName.Split('.')[1];
                    string newFileName = "images/computerpicturechecklist_bb_2_3_3_3_" + DateTime.Now.ToString("yyyyMMddHHmmss") + "." + extension;
                    this.computerChecklistImages.PostedFile.SaveAs(Server.MapPath(newFileName));
                    ans735.QuestionId = 735;
                    ans735.AnsDes = newFileName;
                    ans735.AnserTypeId = 3;
                    ans735.CreateDate = DateTime.Now;
                    ans735.UserId = user.Id;
                    ans735.AnsMonth = ansMonth; 
                    ans735.SRId = sR.Id;
                }
            }

            int result = uSOEntities.SaveChanges();
            if (result > 0)
            {
                this.SuccessPanel.Visible = true;
            }


        }


        void SetForm()
        {
            this.groupTextbox.Value = answers.Where(x => x.QuestionId == 484).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 484).FirstOrDefault().AnsDes : "";
            this.AreaTextbox.Value = answers.Where(x => x.QuestionId == 485).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 485).FirstOrDefault().AnsDes : "";
            this.CompanyTextbox.Value = answers.Where(x => x.QuestionId == 486).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 485).FirstOrDefault().AnsDes : "";
            this.maintenanceCountTextbox.Value = answers.Where(x => x.QuestionId == 488).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 488).FirstOrDefault().AnsDes : "";
            this.yearTextbox.Value = answers.Where(x => x.QuestionId == 489).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 489).FirstOrDefault().AnsDes : "";
            this.startDatepicker.Value = answers.Where(x => x.QuestionId == 490).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 490).FirstOrDefault().AnsDes : "";
            this.endDatepicker.Value = answers.Where(x => x.QuestionId == 491).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 491).FirstOrDefault().AnsDes : "";
            this.siteCodeTextbox.Value = answers.Where(x => x.QuestionId == 1640).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 1640).FirstOrDefault().AnsDes : "";
            this.cabinetIdTextbox.Value = answers.Where(x => x.QuestionId == 492).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 492).FirstOrDefault().AnsDes : "";
            this.sitecodeTextboxSection2.Value = answers.Where(x => x.QuestionId == 493).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 493).FirstOrDefault().AnsDes : "";
            this.VillageIdTextbox.Value = answers.Where(x => x.QuestionId == 494).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 494).FirstOrDefault().AnsDes : "";
            this.villageTextbox.Value = answers.Where(x => x.QuestionId == 495).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 495).FirstOrDefault().AnsDes : "";
            this.schoolNameTextbox.Value = answers.Where(x => x.QuestionId == 496).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 496).FirstOrDefault().AnsDes : "";
            this.subdistrictTextbox.Value = answers.Where(x => x.QuestionId == 497).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 497).FirstOrDefault().AnsDes : "";
            this.DistrictTextboxEIEI.Value = answers.Where(x => x.QuestionId == 498).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 498).FirstOrDefault().AnsDes : "";
            this.provinceTextbox.Value = answers.Where(x => x.QuestionId == 499).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 499).FirstOrDefault().AnsDes : "";
            this.typeTextbox.Value = answers.Where(x => x.QuestionId == 500).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 500).FirstOrDefault().AnsDes : "";
            this.pmdateTextbox.Value = answers.Where(x => x.QuestionId == 501).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 501).FirstOrDefault().AnsDes : "";
            //this.signatureExecutorTextbox.Value = answers.Where(x => x.QuestionId == 504).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 504).FirstOrDefault().AnsDes : "";
            //this.signatureSupervisorTextbox.Value = answers.Where(x => x.QuestionId == 505).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 505).FirstOrDefault().AnsDes : "";
            this.nameExecutorTextbox.Value = answers.Where(x => x.QuestionId == 506).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 506).FirstOrDefault().AnsDes : "";
            this.nameSupervisorTextbox.Value = answers.Where(x => x.QuestionId == 507).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 507).FirstOrDefault().AnsDes : "";
            this.DateExecutorTextbox.Value = answers.Where(x => x.QuestionId == 508).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 508).FirstOrDefault().AnsDes : "";
            this.DateSupervisorTextbox.Value = answers.Where(x => x.QuestionId == 509).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 509).FirstOrDefault().AnsDes : "";
            this.cabinetId2Textbox.Value = answers.Where(x => x.QuestionId == 510).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 510).FirstOrDefault().AnsDes : "";
            this.sitecodeTextboxSection4.Value = answers.Where(x => x.QuestionId == 511).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 511).FirstOrDefault().AnsDes : "";
            this.villageIDTextboxSection4.Value = answers.Where(x => x.QuestionId == 512).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 512).FirstOrDefault().AnsDes : "";
            this.latandlongTextbox.Value = answers.Where(x => x.QuestionId == 513).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 513).FirstOrDefault().AnsDes : "";
            this.oltIdTextbox.Value = answers.Where(x => x.QuestionId == 515).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 515).FirstOrDefault().AnsDes : "";
            this.numberIdTextbox.Value = answers.Where(x => x.QuestionId == 517).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 517).FirstOrDefault().AnsDes : "";
            this.kwhMeterTextbox.Value = answers.Where(x => x.QuestionId == 518).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 518).FirstOrDefault().AnsDes : "";
            this.acvoltTextbox.Value = answers.Where(x => x.QuestionId == 519).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 519).FirstOrDefault().AnsDes : "";
            this.lineAcTextbox.Value = answers.Where(x => x.QuestionId == 520).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 520).FirstOrDefault().AnsDes : "";
            this.neutronAcEIEITextbox.Value = answers.Where(x => x.QuestionId == 521).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 521).FirstOrDefault().AnsDes : "";
            this.neutronAcEIEITextbox.Value = answers.Where(x => x.QuestionId == 521).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 521).FirstOrDefault().AnsDes : "";
            this.acfromupsTextbox.Value = answers.Where(x => x.QuestionId == 525).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 525).FirstOrDefault().AnsDes : "";
            this.voltInverterTextbox.Value = answers.Where(x => x.QuestionId == 576).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 576).FirstOrDefault().AnsDes : "";
            this.loadVoltTageTextbox.Value = answers.Where(x => x.QuestionId == 577).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 577).FirstOrDefault().AnsDes : "";
            this.batterTextbox1.Value = answers.Where(x => x.QuestionId == 578).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 578).FirstOrDefault().AnsDes : "";
            this.batterTextbox2.Value = answers.Where(x => x.QuestionId == 579).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 579).FirstOrDefault().AnsDes : "";
            this.batterTextbox3.Value = answers.Where(x => x.QuestionId == 580).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 580).FirstOrDefault().AnsDes : "";
            this.batterTextbox4.Value = answers.Where(x => x.QuestionId == 581).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 581).FirstOrDefault().AnsDes : "";
            this.dowloadOnuTextbox.Value = answers.Where(x => x.QuestionId == 582).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 582).FirstOrDefault().AnsDes : "";
            this.uploadforOnuTextbox.Value = answers.Where(x => x.QuestionId == 583).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 583).FirstOrDefault().AnsDes : "";
            this.pinngtestforOnuTextbox.Value = answers.Where(x => x.QuestionId == 584).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 584).FirstOrDefault().AnsDes : "";
            this.dowloadforMobileTextbox.Value = answers.Where(x => x.QuestionId == 585).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 585).FirstOrDefault().AnsDes : "";
            this.uploadforMobileTextbox.Value = answers.Where(x => x.QuestionId == 586).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 586).FirstOrDefault().AnsDes : "";
            this.pingtestFormobileTextbox.Value = answers.Where(x => x.QuestionId == 587).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 587).FirstOrDefault().AnsDes : "";

            //  ปัญหาที่พบและวิธีการแก้ปัญหา 
            this.problemTextbox1.Value = answers.Where(x => x.QuestionId == 588).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 588).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox1.Value = answers.Where(x => x.QuestionId == 589).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 589).FirstOrDefault().AnsDes : "";
            this.problemTextbox2.Value = answers.Where(x => x.QuestionId == 590).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 590).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox2.Value = answers.Where(x => x.QuestionId == 591).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 591).FirstOrDefault().AnsDes : "";
            this.problemTextbox3.Value = answers.Where(x => x.QuestionId == 592).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 592).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox3.Value = answers.Where(x => x.QuestionId == 593).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 593).FirstOrDefault().AnsDes : "";
            this.problemTextbox4.Value = answers.Where(x => x.QuestionId == 594).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 594).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox4.Value = answers.Where(x => x.QuestionId == 595).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 595).FirstOrDefault().AnsDes : "";
            this.problemTextbox5.Value = answers.Where(x => x.QuestionId == 596).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 596).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox5.Value = answers.Where(x => x.QuestionId == 597).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 597).FirstOrDefault().AnsDes : "";
            this.problemTextbox6.Value = answers.Where(x => x.QuestionId == 598).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 598).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox6.Value = answers.Where(x => x.QuestionId == 599).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 599).FirstOrDefault().AnsDes : "";
            this.problemTextbox7.Value = answers.Where(x => x.QuestionId == 600).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 600).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox7.Value = answers.Where(x => x.QuestionId == 601).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 601).FirstOrDefault().AnsDes : "";
            this.problemTextbox8.Value = answers.Where(x => x.QuestionId == 602).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 602).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox8.Value = answers.Where(x => x.QuestionId == 603).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 603).FirstOrDefault().AnsDes : "";
            this.problemTextbox9.Value = answers.Where(x => x.QuestionId == 604).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 604).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox9.Value = answers.Where(x => x.QuestionId == 605).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 605).FirstOrDefault().AnsDes : "";
            this.problemTextbox10.Value = answers.Where(x => x.QuestionId == 606).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 606).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox10.Value = answers.Where(x => x.QuestionId == 607).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 607).FirstOrDefault().AnsDes : "";
            this.problemTextbox11.Value = answers.Where(x => x.QuestionId == 608).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 608).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox11.Value = answers.Where(x => x.QuestionId == 609).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 609).FirstOrDefault().AnsDes : "";
            this.problemTextbox12.Value = answers.Where(x => x.QuestionId == 610).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 610).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox12.Value = answers.Where(x => x.QuestionId == 611).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 611).FirstOrDefault().AnsDes : "";
            this.problemTextbox13.Value = answers.Where(x => x.QuestionId == 612).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 612).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox13.Value = answers.Where(x => x.QuestionId == 613).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 613).FirstOrDefault().AnsDes : "";
            this.problemTextbox14.Value = answers.Where(x => x.QuestionId == 614).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 614).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox14.Value = answers.Where(x => x.QuestionId == 615).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 615).FirstOrDefault().AnsDes : "";
            this.problemTextbox15.Value = answers.Where(x => x.QuestionId == 616).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 616).FirstOrDefault().AnsDes : "";
            this.howtoSolveTextbox15.Value = answers.Where(x => x.QuestionId == 617).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 617).FirstOrDefault().AnsDes : "";

            // รายการอุปกรณ์
            this.toolsListTextbox1.Value = answers.Where(x => x.QuestionId == 618).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 618).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox1.Value = answers.Where(x => x.QuestionId == 619).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 619).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox1.Value = answers.Where(x => x.QuestionId == 620).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 620).FirstOrDefault().AnsDes : "";
            this.noteTextbox1.Value = answers.Where(x => x.QuestionId == 621).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 621).FirstOrDefault().AnsDes : "";
            this.toolsListTextbox2.Value = answers.Where(x => x.QuestionId == 622).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 622).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox2.Value = answers.Where(x => x.QuestionId == 623).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 623).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox2.Value = answers.Where(x => x.QuestionId == 624).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 624).FirstOrDefault().AnsDes : "";
            this.noteTextbox2.Value = answers.Where(x => x.QuestionId == 625).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 625).FirstOrDefault().AnsDes : "";
            this.toolsListTextbox3.Value = answers.Where(x => x.QuestionId == 626).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 626).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox3.Value = answers.Where(x => x.QuestionId == 627).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 627).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox3.Value = answers.Where(x => x.QuestionId == 628).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 628).FirstOrDefault().AnsDes : "";
            this.noteTextbox3.Value = answers.Where(x => x.QuestionId == 629).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 629).FirstOrDefault().AnsDes : "";
            this.toolsListTextbox4.Value = answers.Where(x => x.QuestionId == 630).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 630).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox4.Value = answers.Where(x => x.QuestionId == 631).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 631).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox4.Value = answers.Where(x => x.QuestionId == 632).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 632).FirstOrDefault().AnsDes : "";
            this.noteTextbox4.Value = answers.Where(x => x.QuestionId == 633).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 633).FirstOrDefault().AnsDes : "";
            this.toolsListTextbox5.Value = answers.Where(x => x.QuestionId == 634).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 634).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox5.Value = answers.Where(x => x.QuestionId == 635).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 635).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox5.Value = answers.Where(x => x.QuestionId == 636).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 636).FirstOrDefault().AnsDes : "";
            this.noteTextbox5.Value = answers.Where(x => x.QuestionId == 637).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 637).FirstOrDefault().AnsDes : "";
            this.toolsListTextbox6.Value = answers.Where(x => x.QuestionId == 638).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 638).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox6.Value = answers.Where(x => x.QuestionId == 639).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 639).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox6.Value = answers.Where(x => x.QuestionId == 640).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 640).FirstOrDefault().AnsDes : "";
            this.noteTextbox6.Value = answers.Where(x => x.QuestionId == 641).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 641).FirstOrDefault().AnsDes : "";
            this.toolsListTextbox7.Value = answers.Where(x => x.QuestionId == 642).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 642).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox7.Value = answers.Where(x => x.QuestionId == 643).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 643).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox7.Value = answers.Where(x => x.QuestionId == 644).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 644).FirstOrDefault().AnsDes : "";
            this.noteTextbox7.Value = answers.Where(x => x.QuestionId == 645).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 645).FirstOrDefault().AnsDes : "";
            this.toolsListTextbox8.Value = answers.Where(x => x.QuestionId == 646).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 646).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox8.Value = answers.Where(x => x.QuestionId == 647).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 647).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox8.Value = answers.Where(x => x.QuestionId == 648).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 648).FirstOrDefault().AnsDes : "";
            this.noteTextbox7.Value = answers.Where(x => x.QuestionId == 649).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 649).FirstOrDefault().AnsDes : "";
            this.toolsListTextbox9.Value = answers.Where(x => x.QuestionId == 650).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 650).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox9.Value = answers.Where(x => x.QuestionId == 651).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 651).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox9.Value = answers.Where(x => x.QuestionId == 652).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 652).FirstOrDefault().AnsDes : "";
            this.noteTextbox9.Value = answers.Where(x => x.QuestionId == 653).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 653).FirstOrDefault().AnsDes : "";
            this.toolsListTextbox10.Value = answers.Where(x => x.QuestionId == 654).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 654).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox10.Value = answers.Where(x => x.QuestionId == 655).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 655).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox10.Value = answers.Where(x => x.QuestionId == 656).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 656).FirstOrDefault().AnsDes : "";
            this.noteTextbox10.Value = answers.Where(x => x.QuestionId == 657).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 657).FirstOrDefault().AnsDes : "";
            this.toolsListTextbox11.Value = answers.Where(x => x.QuestionId == 658).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 658).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox11.Value = answers.Where(x => x.QuestionId == 659).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 659).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox11.Value = answers.Where(x => x.QuestionId == 660).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 660).FirstOrDefault().AnsDes : "";
            this.noteTextbox11.Value = answers.Where(x => x.QuestionId == 661).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 661).FirstOrDefault().AnsDes : "";
            this.toolsListTextbox12.Value = answers.Where(x => x.QuestionId == 662).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 662).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox12.Value = answers.Where(x => x.QuestionId == 663).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 663).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox12.Value = answers.Where(x => x.QuestionId == 664).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 664).FirstOrDefault().AnsDes : "";
            this.noteTextbox12.Value = answers.Where(x => x.QuestionId == 665).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 665).FirstOrDefault().AnsDes : "";
            this.toolsListTextbox13.Value = answers.Where(x => x.QuestionId == 666).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 666).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox13.Value = answers.Where(x => x.QuestionId == 667).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 667).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox13.Value = answers.Where(x => x.QuestionId == 668).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 668).FirstOrDefault().AnsDes : "";
            this.noteTextbox13.Value = answers.Where(x => x.QuestionId == 669).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 669).FirstOrDefault().AnsDes : "";
            this.toolsListTextbox14.Value = answers.Where(x => x.QuestionId == 670).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 670).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox14.Value = answers.Where(x => x.QuestionId == 671).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 671).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox14.Value = answers.Where(x => x.QuestionId == 672).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 672).FirstOrDefault().AnsDes : "";
            this.noteTextbox14.Value = answers.Where(x => x.QuestionId == 673).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 673).FirstOrDefault().AnsDes : "";
            this.toolsListTextbox15.Value = answers.Where(x => x.QuestionId == 674).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 674).FirstOrDefault().AnsDes : "";
            this.serialNumberTextbox15.Value = answers.Where(x => x.QuestionId == 675).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 675).FirstOrDefault().AnsDes : "";
            this.newSerialNumberTextbox15.Value = answers.Where(x => x.QuestionId == 676).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 676).FirstOrDefault().AnsDes : "";
            this.noteTextbox15.Value = answers.Where(x => x.QuestionId == 677).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 677).FirstOrDefault().AnsDes : "";



            this.nameDopmTextbox.Value = answers.Where(x => x.QuestionId == 678).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 678).FirstOrDefault().AnsDes : "";
            this.dayDopmTextbox.Value = answers.Where(x => x.QuestionId == 679).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 679).FirstOrDefault().AnsDes : "";
            // this.dayDopmTextbox.Value = answers.Where(x => x.QuestionId == 679).FirstOrDefault() != null ? answers.Where(x => x.QuestionId == 679).FirstOrDefault().AnsDes : "";















        }
































    }
}