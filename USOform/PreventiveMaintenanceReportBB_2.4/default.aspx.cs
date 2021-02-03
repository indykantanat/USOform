
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

namespace USOform.Preventive_Maintenance__PM__Report_BB2._4
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
            SR sR = uSOEntities.SRs.Where(x => x.Quarter == currentQuarter && x.Status == 1).FirstOrDefault();
            if (sR == null)
            {
                string srCode = "Q" + currentQuarter.ToString() + "/" + DateTime.Now.ToString("yyyy", CultureInfo.GetCultureInfo("th-US"));
                uSOEntities.SRs.Add(new SR
                {
                    Code = srCode,
                    CreatedDate = DateTime.Now,
                    Detail = "",
                    LastUpdated = DateTime.Now,
                    LastUser = user.Id,
                    SiteId = siteId,
                    Quarter = currentQuarter,
                    Status = 1
                });
            }
            else
            {
                sR.LastUser = user.Id;
                sR.LastUpdated = DateTime.Now;
            }




            //string ansMonth = DateTime.Now.ToString("yyyyMM", CultureInfo.GetCultureInfo("en-US"));
            //ใส่รูปหน้าตู้  :
            var ans264 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 264).FirstOrDefault();
            if (ans264 == null)

            {
                //1: logoPicture
                if (this.logoPicture2.HasFile)
                {
                    string extension = this.logoPicture2.PostedFile.FileName.Split('.')[1];
                    string newFileName = "images/logoImages_bb_2_4_" + DateTime.Now.ToString("yyyyMMddHHmmss") + "." + extension;
                    this.logoPicture2.PostedFile.SaveAs(Server.MapPath(newFileName));

                    Answer answe264 = new Answer()
                    {
                        AnsDes = newFileName,
                        QuestionId = 264,
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
                if (this.logoPicture2.HasFile)
                {
                    string extension = this.logoPicture2.PostedFile.FileName.Split('.')[1];
                    string newFileName = "images/logoImages_bb_2_4_" + DateTime.Now.ToString("yyyyMMddHHmmss") + "." + extension;
                    this.logoPicture2.PostedFile.SaveAs(Server.MapPath(newFileName));
                    ans264.QuestionId = 264;
                    ans264.AnsDes = newFileName;
                    ans264.AnserTypeId = 3;
                    ans264.CreateDate = DateTime.Now;
                    ans264.UserId = user.Id;
                    ans264.AnsMonth = ansMonth; ans264.SRId = sR.Id;
                }
            }



            ///-----------------Section id = 26 ----------------////

            var ans265 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 265).FirstOrDefault();
            if (ans265 == null)
            {
                // กลุ่ม
                Answer answer1409 = new Answer()
                {
                    AnsDes = this.groupTextbox.Value,
                    QuestionId = 265,
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
                ans265.QuestionId = 265;
                ans265.AnsDes = this.groupTextbox.Value;
                ans265.AnserTypeId = 1;
                ans265.CreateDate = DateTime.Now;
                ans265.UserId = user.Id;
                ans265.AnsMonth = ansMonth; ans265.SRId = sR.Id;

            }



            var ans266 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 266).FirstOrDefault();
            if (ans266 == null)
            {
                // ภูมิภาค
                Answer answer1410 = new Answer()
                {
                    AnsDes = this.AreaTextbox.Value,
                    QuestionId = 266,
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
                ans266.QuestionId = 266;
                ans266.AnsDes = this.AreaTextbox.Value;
                ans266.AnserTypeId = 1;
                ans266.CreateDate = DateTime.Now;
                ans266.UserId = user.Id;
                ans266.AnsMonth = ansMonth; ans266.SRId = sR.Id;

            }





            var ans267 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 267).FirstOrDefault();
            if (ans267 == null)
            {
                // บริษัท
                Answer answer3 = new Answer()
                {
                    AnsDes = this.CompanyTextbox.Value,
                    QuestionId = 267,
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
                ans267.QuestionId = 267;
                ans267.AnsDes = this.CompanyTextbox.Value;
                ans267.AnserTypeId = 1;
                ans267.CreateDate = DateTime.Now;
                ans267.UserId = user.Id;
                ans267.AnsMonth = ansMonth; ans267.SRId = sR.Id;

            }







            var ans268 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 268).FirstOrDefault();
            if (ans268 == null)
            {
                //รอบการบำรุงรักษาครั้งที่
                Answer answer4 = new Answer()
                {
                    AnsDes = this.maintenanceCountTextbox.Value,
                    QuestionId = 268,
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
                ans268.QuestionId = 268;
                ans268.AnsDes = this.maintenanceCountTextbox.Value;
                ans268.AnserTypeId = 1;
                ans268.CreateDate = DateTime.Now;
                ans268.UserId = user.Id;
                ans268.AnsMonth = ansMonth; ans268.SRId = sR.Id;

            }





            var ans269 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 269).FirstOrDefault();
            if (ans269 == null)
            {
                //ปีพุทธศักราช
                Answer answer5 = new Answer()
                {
                    AnsDes = this.yearTextbox.Value,
                    QuestionId = 269,
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
                ans269.QuestionId = 269;
                ans269.AnsDes = this.yearTextbox.Value;
                ans269.AnserTypeId = 1;
                ans269.CreateDate = DateTime.Now;
                ans269.UserId = user.Id;
                ans269.AnsMonth = ansMonth; ans269.SRId = sR.Id;

            }



            var ans270 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 270).FirstOrDefault();
            if (ans270 == null)
            {
                //วัน เดือน ปี ที่เริ่มต้น
                Answer answer8 = new Answer()
                {
                    AnsDes = this.startDatepicker.Value,
                    QuestionId = 270,
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
                ans270.QuestionId = 270;
                ans270.AnsDes = this.startDatepicker.Value;
                ans270.AnserTypeId = 1;
                ans270.CreateDate = DateTime.Now;
                ans270.UserId = user.Id;
                ans270.AnsMonth = ansMonth; ans270.SRId = sR.Id;

            }





            var ans271 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 271).FirstOrDefault();
            if (ans271 == null)
            {
                //ถึง 
                Answer answer9 = new Answer()
                {
                    AnsDes = this.endDatepicker.Value,
                    QuestionId = 271,
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
                ans271.QuestionId = 271;
                ans271.AnsDes = this.endDatepicker.Value;
                ans271.AnserTypeId = 1;
                ans271.CreateDate = DateTime.Now;
                ans271.UserId = user.Id;
                ans271.AnsMonth = ansMonth; ans271.SRId = sR.Id;

            }


            var ans1634 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 1634).FirstOrDefault();
            if (ans1634 == null)
            {
                //สถานที่ SITE CODE
                Answer answer10 = new Answer()
                {
                    AnsDes = this.siteCodeTextbox.Value,
                    QuestionId = 1634,
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
                ans1634.QuestionId = 1634;
                ans1634.AnsDes = this.siteCodeTextbox.Value;
                ans1634.AnserTypeId = 1;
                ans1634.CreateDate = DateTime.Now;
                ans1634.UserId = user.Id;
                ans1634.AnsMonth = ansMonth; ans1634.SRId = sR.Id;

            }

            ///--------------------  Section id = 26 --------------------////



            ///----------------------------/    Sectionid  = 27    ---------------------------------///

            var ans272 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 272).FirstOrDefault();
            if (ans272 == null)
            {
                //Cabinet ID:
                Answer answer11 = new Answer()
                {
                    AnsDes = this.cabinetIdTextbox.Value,
                    QuestionId = 272,
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
                ans272.QuestionId = 272;
                ans272.AnsDes = this.cabinetIdTextbox.Value;
                ans272.AnserTypeId = 1;
                ans272.CreateDate = DateTime.Now;
                ans272.UserId = user.Id;
                ans272.AnsMonth = ansMonth; ans272.SRId = sR.Id;

            }



            var ans273 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 273).FirstOrDefault();
            if (ans273 == null)
            {
                //Site Code :
                Answer answer12 = new Answer()
                {
                    AnsDes = this.sitecodeTextboxSection2.Value,
                    QuestionId = 273,
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
                ans273.QuestionId = 273;
                ans273.AnsDes = this.sitecodeTextboxSection2.Value;
                ans273.AnserTypeId = 1;
                ans273.CreateDate = DateTime.Now;
                ans273.UserId = user.Id;
                ans273.AnsMonth = ansMonth; ans273.SRId = sR.Id;

            }



            var ans274 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 274).FirstOrDefault();
            if (ans274 == null)
            {
                //Village ID :
                Answer answer13 = new Answer()
                {
                    AnsDes = this.VillageIdTextbox.Value,
                    QuestionId = 274,
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
                ans274.QuestionId = 274;
                ans274.AnsDes = this.VillageIdTextbox.Value;
                ans274.AnserTypeId = 1;
                ans274.CreateDate = DateTime.Now;
                ans274.UserId = user.Id;
                ans274.AnsMonth = ansMonth; ans274.SRId = sR.Id;

            }




            var ans275 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 275).FirstOrDefault();
            if (ans275 == null)
            {
                //PHO’s Name : :
                Answer answer275 = new Answer()
                {
                    AnsDes = this.phoNameTextbox.Value,
                    QuestionId = 275,
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
                ans275.QuestionId = 275;
                ans275.AnsDes = this.phoNameTextbox.Value;
                ans275.AnserTypeId = 1;
                ans275.CreateDate = DateTime.Now;
                ans275.UserId = user.Id;
                ans275.AnsMonth = ansMonth; ans275.SRId = sR.Id;

            }





            var ans276 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 276).FirstOrDefault();
            if (ans276 == null)
            {
                //Village  :
                Answer answer14 = new Answer()
                {
                    AnsDes = this.villageTextbox.Value,
                    QuestionId = 276,
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
                ans276.QuestionId = 276;
                ans276.AnsDes = this.villageTextbox.Value;
                ans276.AnserTypeId = 1;
                ans276.CreateDate = DateTime.Now;
                ans276.UserId = user.Id;
                ans276.AnsMonth = ansMonth; ans276.SRId = sR.Id;

            }



            var ans277 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 277).FirstOrDefault();
            if (ans277 == null)
            {
                //Sub-District :
                Answer answer16 = new Answer()
                {
                    AnsDes = this.subdistrictTextbox.Value,
                    QuestionId = 277,
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
                ans277.QuestionId = 277;
                ans277.AnsDes = this.subdistrictTextbox.Value;
                ans277.AnserTypeId = 1;
                ans277.CreateDate = DateTime.Now;
                ans277.UserId = user.Id;
                ans277.AnsMonth = ansMonth; ans277.SRId = sR.Id;

            }









            var ans278 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 278).FirstOrDefault();
            if (ans278 == null)
            {
                //District :
                Answer answer1423 = new Answer()
                {
                    AnsDes = this.DistrictTextbox.Value,
                    QuestionId = 278,
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
                ans278.QuestionId = 278;
                ans278.AnsDes = this.DistrictTextbox.Value;
                ans278.AnserTypeId = 1;
                ans278.CreateDate = DateTime.Now;
                ans278.UserId = user.Id;
                ans278.AnsMonth = ansMonth; ans278.SRId = sR.Id;

            }








            var ans279 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 279).FirstOrDefault();
            if (ans279 == null)
            {
                //Province :
                Answer answer17 = new Answer()
                {
                    AnsDes = this.provinceTextbox.Value,
                    QuestionId = 279,
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
                ans279.QuestionId = 279;
                ans279.AnsDes = this.provinceTextbox.Value;
                ans279.AnserTypeId = 1;
                ans279.CreateDate = DateTime.Now;
                ans279.UserId = user.Id;
                ans279.AnsMonth = ansMonth; ans279.SRId = sR.Id;

            }




            var ans280 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 280).FirstOrDefault();
            if (ans280 == null)
            {
                //Type :
                Answer answer18 = new Answer()
                {
                    AnsDes = this.typeTextbox.Value,
                    QuestionId = 280,
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
                ans280.QuestionId = 280;
                ans280.AnsDes = this.typeTextbox.Value;
                ans280.AnserTypeId = 1;
                ans280.CreateDate = DateTime.Now;
                ans280.UserId = user.Id;
                ans280.AnsMonth = ansMonth; ans280.SRId = sR.Id;

            }


            var ans281 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 281).FirstOrDefault();
            if (ans281 == null)
            {
                //PM Date :
                Answer answer19 = new Answer()
                {
                    AnsDes = this.pmdateTextbox.Value,
                    QuestionId = 281,
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
                ans281.QuestionId = 281;
                ans281.AnsDes = this.pmdateTextbox.Value;
                ans281.AnserTypeId = 1;
                ans281.CreateDate = DateTime.Now;
                ans281.UserId = user.Id;
                ans281.AnsMonth = ansMonth; ans281.SRId = sR.Id;

            }





            //ใส่รูปหน้าตู้  :
            var ans1635 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 1635).FirstOrDefault();
            if (ans1635 == null)

            {
                //ใส่รูปหน้าอาคารศูนย์ USO Net :
                if (this.picinfrontImages.HasFile)
                {
                    string extension = this.picinfrontImages.PostedFile.FileName.Split('.')[1];
                    string newFileName = "images/picinfrontusonetImages_bb_2_4_" + DateTime.Now.ToString("yyyyMMddHHmmss") + "." + extension;
                    this.picinfrontImages.PostedFile.SaveAs(Server.MapPath(newFileName));

                    Answer answer20 = new Answer()
                    {
                        AnsDes = newFileName,
                        QuestionId = 1635,
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
                    string newFileName = "images/picinfrontusonetImages_bb_2_4_" + DateTime.Now.ToString("yyyyMMddHHmmss") + "." + extension;
                    this.picinfrontImages.PostedFile.SaveAs(Server.MapPath(newFileName));
                    ans1635.QuestionId = 1635;
                    ans1635.AnsDes = newFileName;
                    ans1635.AnserTypeId = 3;
                    ans1635.CreateDate = DateTime.Now;
                    ans1635.UserId = user.Id;
                    ans1635.AnsMonth = ansMonth; ans1635.SRId = sR.Id;
                }
            }


            //////////////////////////////////    Sectionid  = 27    /////////////////////////////////

            var ans282 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 282).FirstOrDefault();
            if (ans282 == null)
            {
                //signature Executor :
                Answer answer21 = new Answer()
                {
                    AnsDes = this.signatureExecutorTextbox.Value,
                    QuestionId = 282,
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
                ans282.QuestionId = 282;
                ans282.AnsDes = this.signatureExecutorTextbox.Value;
                ans282.AnserTypeId = 1;
                ans282.CreateDate = DateTime.Now;
                ans282.UserId = user.Id;
                ans282.AnsMonth = ansMonth; ans282.SRId = sR.Id;

            }


            var ans283 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 283).FirstOrDefault();
            if (ans283 == null)
            {
                //signature Supervisor :
                Answer answer22 = new Answer()
                {
                    AnsDes = this.signatureSupervisorTextbox.Value,
                    QuestionId = 283,
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
                ans283.QuestionId = 283;
                ans283.AnsDes = this.signatureSupervisorTextbox.Value;
                ans283.AnserTypeId = 1;
                ans283.CreateDate = DateTime.Now;
                ans283.UserId = user.Id;
                ans283.AnsMonth = ansMonth; ans283.SRId = sR.Id;

            }





            var ans284 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 284).FirstOrDefault();
            if (ans284 == null)
            {
                //name Executor  :
                Answer answer23 = new Answer()
                {
                    AnsDes = this.nameExecutorTextbox.Value,
                    QuestionId = 284,
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
                ans284.QuestionId = 284;
                ans284.AnsDes = this.nameExecutorTextbox.Value;
                ans284.AnserTypeId = 1;
                ans284.CreateDate = DateTime.Now;
                ans284.UserId = user.Id;
                ans284.AnsMonth = ansMonth; ans284.SRId = sR.Id;

            }





            var ans285 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 285).FirstOrDefault();
            if (ans285 == null)
            {
                //name Supervisor :
                Answer answer24 = new Answer()
                {
                    AnsDes = this.nameSupervisorTextbox.Value,
                    QuestionId = 285,
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
                ans285.QuestionId = 285;
                ans285.AnsDes = this.nameSupervisorTextbox.Value;
                ans285.AnserTypeId = 1;
                ans285.CreateDate = DateTime.Now;
                ans285.UserId = user.Id;
                ans285.AnsMonth = ansMonth; ans285.SRId = sR.Id;

            }



            var ans286 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 286).FirstOrDefault();
            if (ans286 == null)
            {
                //Date Executor :
                Answer answer25 = new Answer()
                {
                    AnsDes = this.DateExecutorTextbox.Value,
                    QuestionId = 286,
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
                ans286.QuestionId = 286;
                ans286.AnsDes = this.DateExecutorTextbox.Value;
                ans286.AnserTypeId = 1;
                ans286.CreateDate = DateTime.Now;
                ans286.UserId = user.Id;
                ans286.AnsMonth = ansMonth; ans286.SRId = sR.Id;

            }



            var ans287 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 287).FirstOrDefault();
            if (ans287 == null)
            {
                //Date Supervisor :
                Answer answer26 = new Answer()
                {
                    AnsDes = this.DateSupervisorTextbox.Value,
                    QuestionId = 287,
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
                ans287.QuestionId = 287;
                ans287.AnsDes = this.DateSupervisorTextbox.Value;
                ans287.AnserTypeId = 1;
                ans287.CreateDate = DateTime.Now;
                ans287.UserId = user.Id;
                ans287.AnsMonth = ansMonth; ans287.SRId = sR.Id;

            }

            //////////////////////////////////    Sectionid  = 29    /////////////////////////////////


            var ans288 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 288).FirstOrDefault();
            if (ans288 == null)
            {

                //cabibnet  :
                Answer answer27 = new Answer()
                {
                    AnsDes = this.cabinetId2Textbox.Value,
                    QuestionId = 288,
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
                ans288.QuestionId = 288;
                ans288.AnsDes = this.cabinetId2Textbox.Value;
                ans288.AnserTypeId = 1;
                ans288.CreateDate = DateTime.Now;
                ans288.UserId = user.Id;
                ans288.AnsMonth = ansMonth; ans288.SRId = sR.Id;

            }


            var ans289 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 289).FirstOrDefault();
            if (ans289 == null)
            {


                //Site code section 4 :
                Answer answer28 = new Answer()
                {
                    AnsDes = this.sitecodeTextboxSection4.Value,
                    QuestionId = 289,
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
                ans289.QuestionId = 289;
                ans289.AnsDes = this.sitecodeTextboxSection4.Value;
                ans289.AnserTypeId = 1;
                ans289.CreateDate = DateTime.Now;
                ans289.UserId = user.Id;
                ans289.AnsMonth = ansMonth; ans289.SRId = sR.Id;

            }





            var ans290 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 290).FirstOrDefault();
            if (ans290 == null)
            {
                //villageIDsection 4 :
                Answer answer29 = new Answer()
                {
                    AnsDes = this.villageIDTextboxSection4.Value,
                    QuestionId = 290,
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
                ans290.QuestionId = 290;
                ans290.AnsDes = this.villageIDTextboxSection4.Value;
                ans290.AnserTypeId = 1;
                ans290.CreateDate = DateTime.Now;
                ans290.UserId = user.Id;
                ans290.AnsMonth = ansMonth; ans290.SRId = sR.Id;

            }



            var ans291 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 291).FirstOrDefault();
            if (ans291 == null)
            {
                //lat and long  :
                Answer answer30 = new Answer()
                {
                    AnsDes = this.latandlongTextbox.Value,
                    QuestionId = 291,
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
                ans291.QuestionId = 291;
                ans291.AnsDes = this.latandlongTextbox.Value;
                ans291.AnserTypeId = 1;
                ans291.CreateDate = DateTime.Now;
                ans291.UserId = user.Id;
                ans291.AnsMonth = ansMonth; ans291.SRId = sR.Id;

            }



            var ans292 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 292).FirstOrDefault();
            if (ans292 == null)
            {
                //TypeofSignal :
                string typeOf = Request.Form["TypeofSignaleieiRadio"];
                Answer answer31 = new Answer()
                {
                    AnsDes = typeOf,
                    QuestionId = 292,
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
                string typeOf = Request.Form["TypeofSignaleieiRadio"];
                ans292.QuestionId = 292;
                ans292.AnsDes = typeOf;
                ans292.AnserTypeId = 1;
                ans292.CreateDate = DateTime.Now;
                ans292.UserId = user.Id;
                ans292.AnsMonth = ansMonth; ans292.SRId = sR.Id;

            }




            var ans293 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 293).FirstOrDefault();
            if (ans293 == null)
            {
                //OLT ID : :
                Answer answer1440 = new Answer()
                {
                    AnsDes = this.oltIdTextbox.Value,
                    QuestionId = 293,
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

                ans293.QuestionId = 293;
                ans293.AnsDes = this.oltIdTextbox.Value;
                ans293.AnserTypeId = 1;
                ans293.CreateDate = DateTime.Now;
                ans293.UserId = user.Id;
                ans293.AnsMonth = ansMonth; ans293.SRId = sR.Id;

            }


            //////////////////////////////////    Sectionid  = 29    /////////////////////////////////
            ///



            var ans294 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 294).FirstOrDefault();
            if (ans294 == null)
            {

                //ระบบไฟฟ้า :
                string typeOffire = Request.Form["voltSystemRadio"];
                Answer answer294 = new Answer()
                {
                    AnsDes = typeOffire,
                    QuestionId = 294,
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
                string typeOffire = Request.Form["voltSystemRadio"];
                ans294.QuestionId = 294;
                ans294.AnsDes = typeOffire;
                ans294.AnserTypeId = 1;
                ans294.CreateDate = DateTime.Now;
                ans294.UserId = user.Id;
                ans294.AnsMonth = ansMonth; ans294.SRId = sR.Id;

            }




            var ans295 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 295).FirstOrDefault();
            if (ans295 == null)
            {
                //หมายเลขผู้ใช้ไฟ:
                Answer answer1442 = new Answer()
                {
                    AnsDes = this.numberIdTextbox.Value,
                    QuestionId = 295,
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

                ans295.QuestionId = 295;
                ans295.AnsDes = this.numberIdTextbox.Value;
                ans295.AnserTypeId = 1;
                ans295.CreateDate = DateTime.Now;
                ans295.UserId = user.Id;
                ans295.AnsMonth = ansMonth; ans295.SRId = sR.Id;

            }




            var ans296 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 296).FirstOrDefault();
            if (ans296 == null)
            {
                //หน่วยใช้ไฟไฟ  :
                Answer answer36 = new Answer()
                {
                    AnsDes = this.kwhMeterTextbox.Value,
                    QuestionId = 296,
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

                ans296.QuestionId = 296;
                ans296.AnsDes = this.kwhMeterTextbox.Value;
                ans296.AnserTypeId = 1;
                ans296.CreateDate = DateTime.Now;
                ans296.UserId = user.Id;
                ans296.AnsMonth = ansMonth; ans296.SRId = sR.Id;

            }




            var ans297 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 297).FirstOrDefault();
            if (ans297 == null)
            {

                //แรงดัน AC (kWh Meter) :
                Answer answer37 = new Answer()
                {
                    AnsDes = this.acvoltTextbox.Value,
                    QuestionId = 297,
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

                ans297.QuestionId = 297;
                ans297.AnsDes = this.acvoltTextbox.Value;
                ans297.AnserTypeId = 1;
                ans297.CreateDate = DateTime.Now;
                ans297.UserId = user.Id;
                ans297.AnsMonth = ansMonth; ans297.SRId = sR.Id;

            }



            var ans298 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 298).FirstOrDefault();
            if (ans298 == null)
            {
                //กระแส Line AC (kWh Meter) :
                Answer answer38 = new Answer()
                {
                    AnsDes = this.lineAcTextbox.Value,
                    QuestionId = 298,
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

                ans298.QuestionId = 298;
                ans298.AnsDes = this.lineAcTextbox.Value;
                ans298.AnserTypeId = 1;
                ans298.CreateDate = DateTime.Now;
                ans298.UserId = user.Id;
                ans298.AnsMonth = ansMonth; ans298.SRId = sR.Id;

            }



            var ans299 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 299).FirstOrDefault();
            if (ans299 == null)
            {

                // กระแส Neutron AC(kWh Meter) :          
                Answer answer39 = new Answer()
                {
                    AnsDes = this.neutronAcEIEITextbox.Value,
                    QuestionId = 299,
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

                ans299.QuestionId = 299;
                ans299.AnsDes = this.neutronAcEIEITextbox.Value;
                ans299.AnserTypeId = 1;
                ans299.CreateDate = DateTime.Now;
                ans299.UserId = user.Id;
                ans299.AnsMonth = ansMonth; ans299.SRId = sR.Id;

            }




            var ans300 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 300).FirstOrDefault();
            if (ans300 == null)
            {

                //สภาพ kWh Meter Radio  :
                string conRadio = Request.Form["conditionRadio"];
                Answer answer40 = new Answer()
                {
                    AnsDes = conRadio,
                    QuestionId = 300,
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
                ans300.QuestionId = 300;
                ans300.AnsDes = varibles;
                ans300.AnserTypeId = 1;
                ans300.CreateDate = DateTime.Now;
                ans300.UserId = user.Id;
                ans300.AnsMonth = ansMonth; ans300.SRId = sR.Id;

            }


            var ans301 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 301).FirstOrDefault();
            if (ans301 == null)
            {

                //สภาพ MDB/ Circuit Breaker Radio  :
                string CircuitBreakerRadio = Request.Form["MDBCircuitBreakerRadio"];
                Answer answer41 = new Answer()
                {
                    AnsDes = CircuitBreakerRadio,
                    QuestionId = 301,
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
                ans301.QuestionId = 301;
                ans301.AnsDes = varibles;
                ans301.AnserTypeId = 1;
                ans301.CreateDate = DateTime.Now;
                ans301.UserId = user.Id;
                ans301.AnsMonth = ansMonth; ans301.SRId = sR.Id;

            }

            //-------------------------------------   Sectionid  = 30    -----------------------------------------//

            var ans302 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 302).FirstOrDefault();
            if (ans302 == null)
            {

                //UPS ภายในตู้ Radio  :
                string innerUPS = Request.Form["inupsRadio"];
                Answer answer42 = new Answer()
                {
                    AnsDes = innerUPS,
                    QuestionId = 302,
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
                ans302.QuestionId = 302;
                ans302.AnsDes = varibles;
                ans302.AnserTypeId = 1;
                ans302.CreateDate = DateTime.Now;
                ans302.UserId = user.Id;
                ans302.AnsMonth = ansMonth; ans302.SRId = sR.Id;

            }




            var ans303 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 303).FirstOrDefault();
            if (ans303 == null)
            {
                // AC from UPS :          
                Answer answer43 = new Answer()
                {
                    AnsDes = this.acfromupsTextbox.Value,
                    QuestionId = 303,
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

                ans303.QuestionId = 303;
                ans303.AnsDes = this.acfromupsTextbox.Value;
                ans303.AnserTypeId = 1;
                ans303.CreateDate = DateTime.Now;
                ans303.UserId = user.Id;
                ans303.AnsMonth = ansMonth; ans303.SRId = sR.Id;

            }



            var ans304 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 304).FirstOrDefault();
            if (ans304 == null)
            {

                // กระเเส โหลด :  
                string emergen = Request.Form["voltageLoadRadio"];
                Answer answer45 = new Answer()
                {
                    AnsDes = emergen,
                    QuestionId = 304,
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
                ans304.QuestionId = 304;
                ans304.AnsDes = varibles;
                ans304.AnserTypeId = 4;
                ans304.CreateDate = DateTime.Now;
                ans304.UserId = user.Id;
                ans304.AnsMonth = ansMonth; ans304.SRId = sR.Id;

            }






            var ans305 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 305).FirstOrDefault();
            if (ans305 == null)
            {

                // ระดับความจุ Battery :  
                string emerbat = Request.Form["batteryCapacityRadio"];
                Answer answer1452 = new Answer()
                {
                    AnsDes = emerbat,
                    QuestionId = 305,
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
                ans305.QuestionId = 305;
                ans305.AnsDes = varibles;
                ans305.AnserTypeId = 4;
                ans305.CreateDate = DateTime.Now;
                ans305.UserId = user.Id;
                ans305.AnsMonth = ansMonth; ans305.SRId = sR.Id;

            }




            var ans306 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 306).FirstOrDefault();
            if (ans306 == null)
            {

                // UPS MODE :  
                string UPSMODE = Request.Form["upsModeRadio"];
                Answer answer1453 = new Answer()
                {
                    AnsDes = UPSMODE,
                    QuestionId = 306,
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
                ans306.QuestionId = 306;
                ans306.AnsDes = varibles;
                ans306.AnserTypeId = 4;
                ans306.CreateDate = DateTime.Now;
                ans306.UserId = user.Id;
                ans306.AnsMonth = ansMonth; ans306.SRId = sR.Id;

            }



            var ans307 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 307).FirstOrDefault();
            if (ans307 == null)
            {

                // การทำงานของระบบไฟสำรอง :  
                string secondFireRadio1 = Request.Form["secondFireRadio"];
                Answer answer1454 = new Answer()
                {
                    AnsDes = secondFireRadio1,
                    QuestionId = 307,
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
                ans307.QuestionId = 307;
                ans307.AnsDes = varibles;
                ans307.AnserTypeId = 4;
                ans307.CreateDate = DateTime.Now;
                ans307.UserId = user.Id;
                ans307.AnsMonth = ansMonth; ans307.SRId = sR.Id;

            }



            var ans308 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 308).FirstOrDefault();
            if (ans308 == null)
            {
                // สภาพ Battery Bank :  
                string Batterybank = Request.Form["batterybankRadio"];
                Answer answer1455 = new Answer()
                {
                    AnsDes = Batterybank,
                    QuestionId = 308,
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
                ans308.QuestionId = 308;
                ans308.AnsDes = varibles;
                ans308.AnserTypeId = 4;
                ans308.CreateDate = DateTime.Now;
                ans308.UserId = user.Id;
                ans308.AnsMonth = ansMonth; ans308.SRId = sR.Id;

            }



















            ////   Sectionid  = 31    

            var ans309 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 309).FirstOrDefault();
            if (ans309 == null)
            {
                // ONU/Modem Network :  
                string ONUModemNetwork = Request.Form["ONUModemNetworkRadio"];
                Answer answer1456 = new Answer()
                {
                    AnsDes = ONUModemNetwork,
                    QuestionId = 309,
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
                ans309.QuestionId = 309;
                ans309.AnsDes = varibles;
                ans309.AnserTypeId = 4;
                ans309.CreateDate = DateTime.Now;
                ans309.UserId = user.Id;
                ans309.AnsMonth = ansMonth; ans309.SRId = sR.Id;

            }



            var ans310 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 310).FirstOrDefault();
            if (ans310 == null)
            {

                // Power Supply (for Switch) :  
                string femto = Request.Form["psuForswitchRadio"];
                Answer answer1457 = new Answer()
                {
                    AnsDes = femto,
                    QuestionId = 310,
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
                ans310.QuestionId = 310;
                ans310.AnsDes = varibles;
                ans310.AnserTypeId = 4;
                ans310.CreateDate = DateTime.Now;
                ans310.UserId = user.Id;
                ans310.AnsMonth = ansMonth; ans310.SRId = sR.Id;

            }





            var ans311 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 311).FirstOrDefault();
            if (ans311 == null)
            {

                // Switch 8 Port :  
                string femtoanswer = Request.Form["switchPortRadio"];
                Answer answer1458 = new Answer()
                {
                    AnsDes = femtoanswer,
                    QuestionId = 311,
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
                ans311.QuestionId = 311;
                ans311.AnsDes = varibles;
                ans311.AnserTypeId = 4;
                ans311.CreateDate = DateTime.Now;
                ans311.UserId = user.Id;
                ans311.AnsMonth = ansMonth; ans311.SRId = sR.Id;

            }




            var ans312 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 312).FirstOrDefault();
            if (ans312 == null)
            {

                // Outdoor AP 2.4 GH :  
                string tpower = Request.Form["OutdoorAP24Radio"];
                Answer answer1459 = new Answer()
                {
                    AnsDes = tpower,
                    QuestionId = 312,
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
                ans312.QuestionId = 312;
                ans312.AnsDes = varibles;
                ans312.AnserTypeId = 4;
                ans312.CreateDate = DateTime.Now;
                ans312.UserId = user.Id;
                ans312.AnsMonth = ansMonth; ans312.SRId = sR.Id;

            }






            var ans313 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 313).FirstOrDefault();
            if (ans313 == null)
            {

                // Outdoor AP 5 GHz:  
                string wireingGround = Request.Form["OutdoorAP5GHzRadio"];
                Answer answer1460 = new Answer()
                {
                    AnsDes = wireingGround,
                    QuestionId = 313,
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
                ans313.QuestionId = 313;
                ans313.AnsDes = varibles;
                ans313.AnserTypeId = 4;
                ans313.CreateDate = DateTime.Now;
                ans313.UserId = user.Id;
                ans313.AnsMonth = ansMonth; ans313.SRId = sR.Id;

            }



            var ans314 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 314).FirstOrDefault();
            if (ans314 == null)
            {

                //t-power :  
                string Wirinlan = Request.Form["tPowerRadio"];
                Answer answer1633 = new Answer()
                {
                    AnsDes = Wirinlan,
                    QuestionId = 314,
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
                ans314.QuestionId = 314;
                ans314.AnsDes = varibles;
                ans314.AnserTypeId = 4;
                ans314.CreateDate = DateTime.Now;
                ans314.UserId = user.Id;
                ans314.AnsMonth = ansMonth; ans314.SRId = sR.Id;

            }





            var ans315 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 315).FirstOrDefault();
            if (ans315 == null)
            {

                //การ Wiring สายไฟและสาย Ground :  
                string WiringGroundRadio = Request.Form["WiringGroundRadio"];
                Answer answer314 = new Answer()
                {
                    AnsDes = WiringGroundRadio,
                    QuestionId = 315,
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
                ans315.QuestionId = 315;
                ans315.AnsDes = varibles;
                ans315.AnserTypeId = 4;
                ans315.CreateDate = DateTime.Now;
                ans315.UserId = user.Id;
                ans315.AnsMonth = ansMonth; ans315.SRId = sR.Id;

            }





            var ans316 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 316).FirstOrDefault();
            if (ans316 == null)
            {
                //การ Wiring สายไฟและสาย Ground :  
                string wirePatchRadio = Request.Form["wirePatchRadio"];
                Answer answer315 = new Answer()
                {
                    AnsDes = wirePatchRadio,
                    QuestionId = 316,
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
                ans316.QuestionId = 316;
                ans316.AnsDes = varibles;
                ans316.AnserTypeId = 4;
                ans316.CreateDate = DateTime.Now;
                ans316.UserId = user.Id;
                ans316.AnsMonth = ansMonth; ans316.SRId = sR.Id;

            }


            ////----------------------------------------   Sectionid  = 32   
            ///

            var ans317 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 317).FirstOrDefault();
            if (ans317 == null)
            {
                //ความแข็งแรงจุดต่อ Ground Bar :
                string gb = Request.Form["groundbarRadio"];
                Answer answer57 = new Answer()
                {
                    AnsDes = gb,
                    QuestionId = 317,
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
                ans317.QuestionId = 317;
                ans317.AnsDes = varibles;
                ans317.AnserTypeId = 4;
                ans317.CreateDate = DateTime.Now;
                ans317.UserId = user.Id;
                ans317.AnsMonth = ansMonth; ans317.SRId = sR.Id;

            }






            var ans318 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 318).FirstOrDefault();
            if (ans318 == null)
            {
                //ความแข็งแรงของน็อตขันหางปลาอุปกรณ์ :
                string fishnot = Request.Form["notfishRadio"];
                Answer answer58 = new Answer()
                {
                    AnsDes = fishnot,
                    QuestionId = 318,
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
                string varibles = Request.Form["notfishRadio"];
                ans318.QuestionId = 318;
                ans318.AnsDes = varibles;
                ans318.AnserTypeId = 4;
                ans318.CreateDate = DateTime.Now;
                ans318.UserId = user.Id;
                ans318.AnsMonth = ansMonth; ans318.SRId = sR.Id;

            }



            var ans319 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 319).FirstOrDefault();
            if (ans319 == null)
            {
                //สายกราวด์เรียบร้อย ปลอดภัย สมบูรณ์ :
                string ffss = Request.Form["safegroundRadio"];
                Answer answer59 = new Answer()
                {
                    AnsDes = ffss,
                    QuestionId = 319,
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
                ans319.QuestionId = 319;
                ans319.AnsDes = varibles;
                ans319.AnserTypeId = 4;
                ans319.CreateDate = DateTime.Now;
                ans319.UserId = user.Id;
                ans319.AnsMonth = ansMonth; ans319.SRId = sR.Id;

            }


            var ans320 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 320).FirstOrDefault();
            if (ans320 == null)
            {
                //สถานะไฟฟ้ารั่วลง Ground :
                string elecground = Request.Form["brokenElecRadio"];
                Answer answer60 = new Answer()
                {
                    AnsDes = elecground,
                    QuestionId = 320,
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
                ans320.QuestionId = 320;
                ans320.AnsDes = varibles;
                ans320.AnserTypeId = 4;
                ans320.CreateDate = DateTime.Now;
                ans320.UserId = user.Id;
                ans320.AnsMonth = ansMonth; ans320.SRId = sR.Id;

            }



            ////-----------------------------------------------------   Sectionid  = 33 
            ///


            var ans321 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 321).FirstOrDefault();
            if (ans321 == null)
            {
                //ป้ายและตัวเลขแสดงชื่อสถานี :
                string signandnumber = Request.Form["signandnumberRadio"];
                Answer answer1465 = new Answer()
                {
                    AnsDes = signandnumber,
                    QuestionId = 321,
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
                ans321.QuestionId = 321;
                ans321.AnsDes = varibles;
                ans321.AnserTypeId = 4;
                ans321.CreateDate = DateTime.Now;
                ans321.UserId = user.Id;
                ans321.AnsMonth = ansMonth; ans321.SRId = sR.Id;

            }



            var ans322 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 322).FirstOrDefault();
            if (ans322 == null)
            {

                //การติดตั้งและการยึดตู้อุปกรณ์ :
                string inStall = Request.Form["inStallRadio"];
                Answer answer1466 = new Answer()
                {
                    AnsDes = inStall,
                    QuestionId = 322,
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
                ans322.QuestionId = 322;
                ans322.AnsDes = varibles;
                ans322.AnserTypeId = 4;
                ans322.CreateDate = DateTime.Now;
                ans322.UserId = user.Id;
                ans322.AnsMonth = ansMonth; ans322.SRId = sR.Id;

            }


            var ans323 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 323).FirstOrDefault();
            if (ans323 == null)
            {
                //เสาไฟฟ้าที่ติดตั้งอุปกรณ์:
                string inStallVoltRadio = Request.Form["inStallVoltRadio"];
                Answer answer1467 = new Answer()
                {
                    AnsDes = inStallVoltRadio,
                    QuestionId = 323,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer1467);
            }
            else
            {
                string inStallVoltRadio = Request.Form["inStallVoltRadio"];
                ans323.QuestionId = 323;
                ans323.AnsDes = inStallVoltRadio;
                ans323.AnserTypeId = 4;
                ans323.CreateDate = DateTime.Now;
                ans323.UserId = user.Id;
                ans323.AnsMonth = ansMonth; ans323.SRId = sR.Id;

            }






            var ans324 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 324).FirstOrDefault();
            if (ans324 == null)
            {


                //ช่อง Cable Inlet  และความสะอาด :
                string CableInlet = Request.Form["CableInletRadio"];
                Answer answer1468 = new Answer()
                {
                    AnsDes = CableInlet,
                    QuestionId = 324,
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
                ans324.QuestionId = 324;
                ans324.AnsDes = varibles;
                ans324.AnserTypeId = 4;
                ans324.CreateDate = DateTime.Now;
                ans324.UserId = user.Id;
                ans324.AnsMonth = ansMonth; ans324.SRId = sR.Id;

            }



            var ans325 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 325).FirstOrDefault();
            if (ans325 == null)
            {


                //ช่อง Filter ความสะอาด (T-Power:
                string filterRadio = Request.Form["filterRadio"];
                Answer answer1469 = new Answer()
                {
                    AnsDes = filterRadio,
                    QuestionId = 325,
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
                ans325.QuestionId = 325;
                ans325.AnsDes = varibles;
                ans325.AnserTypeId = 4;
                ans325.CreateDate = DateTime.Now;
                ans325.UserId = user.Id;
                ans325.AnsMonth = ansMonth; ans325.SRId = sR.Id;

            }






            var ans326 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 326).FirstOrDefault();
            if (ans326 == null)
            {


                //ประตูและยางขอบประตูของตู้อุปกรณ์ :
                string doorToolsRadio = Request.Form["doorToolsRadio"];
                Answer answer1470 = new Answer()
                {
                    AnsDes = doorToolsRadio,
                    QuestionId = 326,
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
                ans326.QuestionId = 326;
                ans326.AnsDes = varibles;
                ans326.AnserTypeId = 4;
                ans326.CreateDate = DateTime.Now;
                ans326.UserId = user.Id;
                ans326.AnsMonth = ansMonth; ans326.SRId = sR.Id;

            }





            var ans327 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 327).FirstOrDefault();
            if (ans327 == null)
            {


                //แนวสายไฟฟ้าและสายเคเบิ้ลเข้าสถานี :
                string cabletoStationRadio = Request.Form["cabletoStationRadio"];
                Answer answer1471 = new Answer()
                {
                    AnsDes = cabletoStationRadio,
                    QuestionId = 327,
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
                ans327.QuestionId = 327;
                ans327.AnsDes = varibles;
                ans327.AnserTypeId = 4;
                ans327.CreateDate = DateTime.Now;
                ans327.UserId = user.Id;
                ans327.AnsMonth = ansMonth; ans327.SRId = sR.Id;

            }



            ////----------------------------------   Sectionid  = 34
            ///



            var ans328 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 328).FirstOrDefault();
            if (ans328 == null)
            {

                // อุปกรณ์ LNB/BUC   :
                string tools = Request.Form["toolslnbRadio"];
                Answer answer88 = new Answer()
                {
                    AnsDes = tools,
                    QuestionId = 328,
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
                ans328.QuestionId = 328;
                ans328.AnsDes = varibles;
                ans328.AnserTypeId = 4;
                ans328.CreateDate = DateTime.Now;
                ans328.UserId = user.Id;
                ans328.AnsMonth = ansMonth; ans328.SRId = sR.Id;

            }






            var ans329 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 329).FirstOrDefault();
            if (ans329 == null)
            {


                // การเก็บสาย RG และการพันหัว   :
                string toolsRG = Request.Form["wiringrgRadio"];
                Answer answer89 = new Answer()
                {
                    AnsDes = toolsRG,
                    QuestionId = 329,
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
                ans329.QuestionId = 329;
                ans329.AnsDes = varibles;
                ans329.AnserTypeId = 4;
                ans329.CreateDate = DateTime.Now;
                ans329.UserId = user.Id;
                ans329.AnsMonth = ansMonth; ans329.SRId = sR.Id;

            }


            var ans330 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 330).FirstOrDefault();
            if (ans330 == null)
            {


                // ฐานและระดับของเสาจาน  :
                string baseOneiei = Request.Form["baseOnRadio"];
                Answer answer90 = new Answer()
                {
                    AnsDes = baseOneiei,
                    QuestionId = 330,
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
                ans330.QuestionId = 330;
                ans330.AnsDes = varibles;
                ans330.AnserTypeId = 4;
                ans330.CreateDate = DateTime.Now;
                ans330.UserId = user.Id;
                ans330.AnsMonth = ansMonth; ans330.SRId = sR.Id;

            }





            var ans331 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 331).FirstOrDefault();
            if (ans331 == null)
            {


                // >แนว Line Of Sight  :
                string lineOf = Request.Form["xxlineOfsightRadio"];
                Answer answer91 = new Answer()
                {
                    AnsDes = lineOf,
                    QuestionId = 331,
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
                ans331.QuestionId = 331;
                ans331.AnsDes = varibles;
                ans331.AnserTypeId = 4;
                ans331.CreateDate = DateTime.Now;
                ans331.UserId = user.Id;
                ans331.AnsMonth = ansMonth; ans331.SRId = sR.Id;

            }



            var ans332 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 332).FirstOrDefault();
            if (ans332 == null)
            {



                string clendDish = Request.Form["cleaningDishRadio"];
                Answer answer92 = new Answer()
                {
                    AnsDes = clendDish,
                    QuestionId = 332,
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
                ans332.QuestionId = 332;
                ans332.AnsDes = varibles;
                ans332.AnserTypeId = 4;
                ans332.CreateDate = DateTime.Now;
                ans332.UserId = user.Id;
                ans332.AnsMonth = ansMonth; ans332.SRId = sR.Id;

            }




            var ans333 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 333).FirstOrDefault();
            if (ans333 == null)
            {
                // LNB Band Switch  :
                string lnbswitch = Request.Form["lnbbandswitchRadio"];
                Answer answer93 = new Answer()
                {
                    AnsDes = lnbswitch,
                    QuestionId = 333,
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
                ans333.QuestionId = 333;
                ans333.AnsDes = varibles;
                ans333.AnserTypeId = 4;
                ans333.CreateDate = DateTime.Now;
                ans333.UserId = user.Id;
                ans333.AnsMonth = ansMonth; ans333.SRId = sR.Id;

            }



            ////----------------------------------   Sectionid  = 35 -----------------------////


            var ans334 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 334).FirstOrDefault();
            if (ans334 == null)
            {
                // ระบบ Solar Cell :
                string solarCells = Request.Form["solarcellSystemRadio"];
                Answer answer94 = new Answer()
                {
                    AnsDes = solarCells,
                    QuestionId = 334,
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
                ans334.QuestionId = 334;
                ans334.AnsDes = varibles;
                ans334.AnserTypeId = 4;
                ans334.CreateDate = DateTime.Now;
                ans334.UserId = user.Id;
                ans334.AnsMonth = ansMonth; ans334.SRId = sR.Id;

            }



            var ans335 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 335).FirstOrDefault();
            if (ans335 == null)
            {

                // แผง PV Panel:
                string pv = Request.Form["pvPanelRadio"];
                Answer answer95 = new Answer()
                {
                    AnsDes = pv,
                    QuestionId = 335,
                    AnserTypeId = 4,
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
                ans335.QuestionId = 335;
                ans335.AnsDes = varibles;
                ans335.AnserTypeId = 4;
                ans335.CreateDate = DateTime.Now;
                ans335.UserId = user.Id;
                ans335.AnsMonth = ansMonth; ans335.SRId = sR.Id;

            }




            var ans336 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 336).FirstOrDefault();
            if (ans336 == null)
            {
                // อุปกรณ์ Charger :
                string charGer = Request.Form["toolsCharger"];
                Answer answer96 = new Answer()
                {
                    AnsDes = charGer,
                    QuestionId = 336,
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
                ans336.QuestionId = 336;
                ans336.AnsDes = varibles;
                ans336.AnserTypeId = 4;
                ans336.CreateDate = DateTime.Now;
                ans336.UserId = user.Id;
                ans336.AnsMonth = ansMonth; ans336.SRId = sR.Id;

            }






            var ans337 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 337).FirstOrDefault();
            if (ans337 == null)
            {
                // ความสะอาดแผง PV :
                string cleanPv = Request.Form["cleanIngpvRadio"];
                Answer answer97 = new Answer()
                {
                    AnsDes = cleanPv,
                    QuestionId = 337,
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
                ans337.QuestionId = 337;
                ans337.AnsDes = varibles;
                ans337.AnserTypeId = 4;
                ans337.CreateDate = DateTime.Now;
                ans337.UserId = user.Id;
                ans337.AnsMonth = ansMonth; ans337.SRId = sR.Id;

            }




            var ans338 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 338).FirstOrDefault();
            if (ans338 == null)
            {
                // การติดตั้งแผง PV :
                string installPvRadio = Request.Form["installPvRadio"];
                Answer answer98 = new Answer()
                {
                    AnsDes = installPvRadio,
                    QuestionId = 338,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer98);
            }
            else
            {
                string installPvRadio = Request.Form["installPvRadio"];
                ans338.QuestionId = 338;
                ans338.AnsDes = installPvRadio;
                ans338.AnserTypeId = 4;
                ans338.CreateDate = DateTime.Now;
                ans338.UserId = user.Id;
                ans338.AnsMonth = ansMonth; ans338.SRId = sR.Id;

            }




            var ans339 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 339).FirstOrDefault();
            if (ans339 == null)
            {
                // แรงดันไฟจาก Inverter :          
                Answer voltInverterTextbox = new Answer()
                {
                    AnsDes = this.voltInverterTextbox.Value,
                    QuestionId = 339,
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

                ans339.QuestionId = 339;
                ans339.AnsDes = this.voltInverterTextbox.Value;
                ans339.AnserTypeId = 1;
                ans339.CreateDate = DateTime.Now;
                ans339.UserId = user.Id;
                ans339.AnsMonth = ansMonth; ans339.SRId = sR.Id;

            }



            var ans340 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 340).FirstOrDefault();
            if (ans340 == null)
            {
                // กระแส Load :          
                Answer loadVoltTageTextbox = new Answer()
                {
                    AnsDes = this.loadVoltTageTextbox.Value,
                    QuestionId = 340,
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

                ans340.QuestionId = 340;
                ans340.AnsDes = this.loadVoltTageTextbox.Value;
                ans340.AnserTypeId = 1;
                ans340.CreateDate = DateTime.Now;
                ans340.UserId = user.Id;
                ans340.AnsMonth = ansMonth; ans340.SRId = sR.Id;

            }






            var ans341 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 341).FirstOrDefault();
            if (ans341 == null)
            {
                // batterry 1 :          
                Answer answer1485 = new Answer()
                {
                    AnsDes = this.batterTextbox1.Value,
                    QuestionId = 341,
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

                ans341.QuestionId = 341;
                ans341.AnsDes = this.batterTextbox1.Value;
                ans341.AnserTypeId = 1;
                ans341.CreateDate = DateTime.Now;
                ans341.UserId = user.Id;
                ans341.AnsMonth = ansMonth; ans341.SRId = sR.Id;

            }





            var ans342 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 342).FirstOrDefault();
            if (ans342 == null)
            {
                //  batterry 2 :          
                Answer answer1486 = new Answer()
                {
                    AnsDes = this.batterTextbox2.Value,
                    QuestionId = 342,
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

                ans342.QuestionId = 342;
                ans342.AnsDes = this.batterTextbox2.Value;
                ans342.AnserTypeId = 1;
                ans342.CreateDate = DateTime.Now;
                ans342.UserId = user.Id;
                ans342.AnsMonth = ansMonth; ans342.SRId = sR.Id;

            }




            var ans343 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 343).FirstOrDefault();
            if (ans343 == null)
            {
                // batterry 3 :         
                Answer answer1487 = new Answer()
                {
                    AnsDes = this.batterTextbox3.Value,
                    QuestionId = 343,
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

                ans343.QuestionId = 343;
                ans343.AnsDes = this.batterTextbox3.Value;
                ans343.AnserTypeId = 1;
                ans343.CreateDate = DateTime.Now;
                ans343.UserId = user.Id;
                ans343.AnsMonth = ansMonth; ans343.SRId = sR.Id;

            }





            var ans344 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 344).FirstOrDefault();
            if (ans344 == null)
            {
                //  batterry 4 :          
                Answer answer1488 = new Answer()
                {
                    AnsDes = this.batterTextbox4.Value,
                    QuestionId = 344,
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

                ans344.QuestionId = 344;
                ans344.AnsDes = this.batterTextbox4.Value;
                ans344.AnserTypeId = 1;
                ans344.CreateDate = DateTime.Now;
                ans344.UserId = user.Id;
                ans344.AnsMonth = ansMonth; ans344.SRId = sR.Id;

            }






            ////----------------------------------   Sectionid  = 36     -------------------------//
            ///

            var ans345 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 345).FirstOrDefault();
            if (ans345 == null)
            {
                // Download (for ONU/VSAT :          
                Answer answer1495 = new Answer()
                {
                    AnsDes = this.dowloadOnuTextbox.Value,
                    QuestionId = 345,
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

                ans345.QuestionId = 345;
                ans345.AnsDes = this.dowloadOnuTextbox.Value;
                ans345.AnserTypeId = 1;
                ans345.CreateDate = DateTime.Now;
                ans345.UserId = user.Id;
                ans345.AnsMonth = ansMonth; ans345.SRId = sR.Id;

            }



            var ans346 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 346).FirstOrDefault();
            if (ans346 == null)
            {
                // Upload (for ONU/VSAT) :          
                Answer answer1496 = new Answer()
                {
                    AnsDes = this.uploadforOnuTextbox.Value,
                    QuestionId = 346,
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

                ans346.QuestionId = 346;
                ans346.AnsDes = this.uploadforOnuTextbox.Value;
                ans346.AnserTypeId = 1;
                ans346.CreateDate = DateTime.Now;
                ans346.UserId = user.Id;
                ans346.AnsMonth = ansMonth; ans346.SRId = sR.Id;

            }







            var ans347 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 347).FirstOrDefault();
            if (ans347 == null)
            {
                // Ping Test (for ONU/VSAT) :          
                Answer answer1497 = new Answer()
                {
                    AnsDes = this.pinngtestforOnuTextbox.Value,
                    QuestionId = 347,
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

                ans347.QuestionId = 347;
                ans347.AnsDes = this.pinngtestforOnuTextbox.Value;
                ans347.AnserTypeId = 1;
                ans347.CreateDate = DateTime.Now;
                ans347.UserId = user.Id;
                ans347.AnsMonth = ansMonth; ans347.SRId = sR.Id;

            }



            var ans348 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 348).FirstOrDefault();
            if (ans348 == null)
            {
                // Download (for Mobile:          
                Answer answer1498 = new Answer()
                {
                    AnsDes = this.dowloadforMobileTextbox.Value,
                    QuestionId = 348,
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

                ans348.QuestionId = 348;
                ans348.AnsDes = this.dowloadforMobileTextbox.Value;
                ans348.AnserTypeId = 1;
                ans348.CreateDate = DateTime.Now;
                ans348.UserId = user.Id;
                ans348.AnsMonth = ansMonth; ans348.SRId = sR.Id;

            }


            var ans349 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 349).FirstOrDefault();
            if (ans349 == null)
            {
                //  Upload (for Mobile :          
                Answer answer1499 = new Answer()
                {
                    AnsDes = this.uploadforMobileTextbox.Value,
                    QuestionId = 349,
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

                ans349.QuestionId = 349;
                ans349.AnsDes = this.uploadforMobileTextbox.Value;
                ans349.AnserTypeId = 1;
                ans349.CreateDate = DateTime.Now;
                ans349.UserId = user.Id;
                ans349.AnsMonth = ansMonth; ans349.SRId = sR.Id;

            }


            var ans350 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 350).FirstOrDefault();
            if (ans350 == null)
            {
                // Ping Test(for Mobile)
                Answer answe1500 = new Answer()
                {
                    AnsDes = this.pingtestFormobileTextbox.Value,
                    QuestionId = 350,
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

                ans350.QuestionId = 350;
                ans350.AnsDes = this.pingtestFormobileTextbox.Value;
                ans350.AnserTypeId = 1;
                ans350.CreateDate = DateTime.Now;
                ans350.UserId = user.Id;
                ans350.AnsMonth = ansMonth; ans350.SRId = sR.Id;

            }










            ////----------------   Sectionid  = 37  --------------------//
            ///



            var ans351 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 351).FirstOrDefault();
            if (ans351 == null)
            {
                //  ปัญหาที่พบ 1 :           
                Answer answer110 = new Answer()
                {
                    AnsDes = this.problemTextbox1.Value,
                    QuestionId = 351,
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

                ans351.QuestionId = 351;
                ans351.AnsDes = this.problemTextbox1.Value;
                ans351.AnserTypeId = 1;
                ans351.CreateDate = DateTime.Now;
                ans351.UserId = user.Id;
                ans351.AnsMonth = ansMonth; ans351.SRId = sR.Id;

            }



            var ans352 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 352).FirstOrDefault();
            if (ans352 == null)
            {
                //  วิธีแก้ปัญหา 1 :           
                Answer answer111 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox1.Value,
                    QuestionId = 352,
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

                ans352.QuestionId = 352;
                ans352.AnsDes = this.howtoSolveTextbox1.Value;
                ans352.AnserTypeId = 1;
                ans352.CreateDate = DateTime.Now;
                ans352.UserId = user.Id;
                ans352.AnsMonth = ansMonth; ans352.SRId = sR.Id;

            }




            var ans353 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 353).FirstOrDefault();
            if (ans353 == null)
            {

                //  ปัญหาที่พบ 2 :           
                Answer answer112 = new Answer()
                {
                    AnsDes = this.problemTextbox2.Value,
                    QuestionId = 353,
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

                ans353.QuestionId = 353;
                ans353.AnsDes = this.problemTextbox2.Value;
                ans353.AnserTypeId = 1;
                ans353.CreateDate = DateTime.Now;
                ans353.UserId = user.Id;
                ans353.AnsMonth = ansMonth; ans353.SRId = sR.Id;

            }


            var ans354 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 354).FirstOrDefault();
            if (ans354 == null)
            {

                //  วิธีแก้ปัญหา 2 :           
                Answer answer113 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox2.Value,
                    QuestionId = 354,
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

                ans354.QuestionId = 354;
                ans354.AnsDes = this.howtoSolveTextbox2.Value;
                ans354.AnserTypeId = 1;
                ans354.CreateDate = DateTime.Now;
                ans354.UserId = user.Id;
                ans354.AnsMonth = ansMonth; ans354.SRId = sR.Id;

            }


            var ans355 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 355).FirstOrDefault();
            if (ans355 == null)
            {

                //  ปัญหาที่พบ 3 :           
                Answer answer114 = new Answer()
                {
                    AnsDes = this.problemTextbox3.Value,
                    QuestionId = 355,
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

                ans355.QuestionId = 355;
                ans355.AnsDes = this.problemTextbox3.Value;
                ans355.AnserTypeId = 1;
                ans355.CreateDate = DateTime.Now;
                ans355.UserId = user.Id;
                ans355.AnsMonth = ansMonth; ans355.SRId = sR.Id;

            }


            var ans356 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 356).FirstOrDefault();
            if (ans356 == null)
            {

                //  วิธีแก้ปัญหา 3 :           
                Answer answer115 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox3.Value,
                    QuestionId = 356,
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

                ans356.QuestionId = 356;
                ans356.AnsDes = this.howtoSolveTextbox3.Value;
                ans356.AnserTypeId = 1;
                ans356.CreateDate = DateTime.Now;
                ans356.UserId = user.Id;
                ans356.AnsMonth = ansMonth; ans356.SRId = sR.Id;

            }





            var ans357 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 357).FirstOrDefault();
            if (ans357 == null)
            {

                //  ปัญหาที่พบ 4 :           
                Answer answer116 = new Answer()
                {
                    AnsDes = this.problemTextbox4.Value,
                    QuestionId = 357,
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

                ans357.QuestionId = 357;
                ans357.AnsDes = this.problemTextbox4.Value;
                ans357.AnserTypeId = 1;
                ans357.CreateDate = DateTime.Now;
                ans357.UserId = user.Id;
                ans357.AnsMonth = ansMonth; ans357.SRId = sR.Id;

            }


            var ans358 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 358).FirstOrDefault();
            if (ans358 == null)
            {

                //  วิธีแก้ปัญหา 4 :           
                Answer answer117 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox4.Value,
                    QuestionId = 358,
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

                ans358.QuestionId = 358;
                ans358.AnsDes = this.howtoSolveTextbox4.Value;
                ans358.AnserTypeId = 1;
                ans358.CreateDate = DateTime.Now;
                ans358.UserId = user.Id;
                ans358.AnsMonth = ansMonth; ans358.SRId = sR.Id;

            }



            var ans359 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 359).FirstOrDefault();
            if (ans359 == null)
            {

                //  ปัญหาที่พบ 5 :           
                Answer answer118 = new Answer()
                {
                    AnsDes = this.problemTextbox5.Value,
                    QuestionId = 359,
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

                ans359.QuestionId = 359;
                ans359.AnsDes = this.problemTextbox5.Value;
                ans359.AnserTypeId = 1;
                ans359.CreateDate = DateTime.Now;
                ans359.UserId = user.Id;
                ans359.AnsMonth = ansMonth; ans359.SRId = sR.Id;

            }



            var ans360 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 360).FirstOrDefault();
            if (ans360 == null)
            {

                //  วิธีแก้ปัญหา 5 :           
                Answer answer119 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox5.Value,
                    QuestionId = 360,
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

                ans360.QuestionId = 360;
                ans360.AnsDes = this.howtoSolveTextbox5.Value;
                ans360.AnserTypeId = 1;
                ans360.CreateDate = DateTime.Now;
                ans360.UserId = user.Id;
                ans360.AnsMonth = ansMonth; ans360.SRId = sR.Id;

            }



            var ans361 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 361).FirstOrDefault();
            if (ans361 == null)
            {

                //  ปัญหาที่พบ 6 :           
                Answer answer120 = new Answer()
                {
                    AnsDes = this.problemTextbox6.Value,
                    QuestionId = 361,
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

                ans361.QuestionId = 361;
                ans361.AnsDes = this.problemTextbox6.Value;
                ans361.AnserTypeId = 1;
                ans361.CreateDate = DateTime.Now;
                ans361.UserId = user.Id;
                ans361.AnsMonth = ansMonth; ans361.SRId = sR.Id;

            }




            var ans362 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 362).FirstOrDefault();
            if (ans362 == null)
            {

                //  วิธีแก้ปัญหา 6 :           
                Answer answer121 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox6.Value,
                    QuestionId = 362,
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

                ans362.QuestionId = 362;
                ans362.AnsDes = this.howtoSolveTextbox6.Value;
                ans362.AnserTypeId = 1;
                ans362.CreateDate = DateTime.Now;
                ans362.UserId = user.Id;
                ans362.AnsMonth = ansMonth; ans362.SRId = sR.Id;

            }


            var ans363 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 363).FirstOrDefault();
            if (ans363 == null)
            {

                //  ปัญหาที่พบ 7 :           
                Answer answer122 = new Answer()
                {
                    AnsDes = this.problemTextbox7.Value,
                    QuestionId = 363,
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

                ans363.QuestionId = 363;
                ans363.AnsDes = this.problemTextbox7.Value;
                ans363.AnserTypeId = 1;
                ans363.CreateDate = DateTime.Now;
                ans363.UserId = user.Id;
                ans363.AnsMonth = ansMonth; ans363.SRId = sR.Id;

            }



            var ans364 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 364).FirstOrDefault();
            if (ans364 == null)
            {

                //  วิธีแก้ปัญหา 7 :           
                Answer answer123 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox7.Value,
                    QuestionId = 364,
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

                ans364.QuestionId = 364;
                ans364.AnsDes = this.howtoSolveTextbox7.Value;
                ans364.AnserTypeId = 1;
                ans364.CreateDate = DateTime.Now;
                ans364.UserId = user.Id;
                ans364.AnsMonth = ansMonth; ans364.SRId = sR.Id;

            }





            var ans365 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 365).FirstOrDefault();
            if (ans365 == null)
            {

                //  ปัญหาที่พบ 8 :           
                Answer answer124 = new Answer()
                {
                    AnsDes = this.problemTextbox8.Value,
                    QuestionId = 365,
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

                ans365.QuestionId = 365;
                ans365.AnsDes = this.problemTextbox8.Value;
                ans365.AnserTypeId = 1;
                ans365.CreateDate = DateTime.Now;
                ans365.UserId = user.Id;
                ans365.AnsMonth = ansMonth; ans365.SRId = sR.Id;

            }



            var ans366 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 366).FirstOrDefault();
            if (ans366 == null)
            {

                //  วิธีแก้ปัญหา 8 :           
                Answer answer125 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox8.Value,
                    QuestionId = 366,
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

                ans366.QuestionId = 366;
                ans366.AnsDes = this.howtoSolveTextbox8.Value;
                ans366.AnserTypeId = 1;
                ans366.CreateDate = DateTime.Now;
                ans366.UserId = user.Id;
                ans366.AnsMonth = ansMonth; ans366.SRId = sR.Id;

            }





            var ans367 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 367).FirstOrDefault();
            if (ans367 == null)
            {
                //  ปัญหาที่พบ 9 :           
                Answer answer126 = new Answer()
                {
                    AnsDes = this.problemTextbox9.Value,
                    QuestionId = 367,
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

                ans367.QuestionId = 367;
                ans367.AnsDes = this.problemTextbox9.Value;
                ans367.AnserTypeId = 1;
                ans367.CreateDate = DateTime.Now;
                ans367.UserId = user.Id;
                ans367.AnsMonth = ansMonth; ans367.SRId = sR.Id;

            }




            var ans368 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 368).FirstOrDefault();
            if (ans368 == null)
            {
                //  วิธีแก้ปัญหา 9 :           
                Answer answer127 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox9.Value,
                    QuestionId = 368,
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

                ans368.QuestionId = 368;
                ans368.AnsDes = this.howtoSolveTextbox9.Value;
                ans368.AnserTypeId = 1;
                ans368.CreateDate = DateTime.Now;
                ans368.UserId = user.Id;
                ans368.AnsMonth = ansMonth; ans368.SRId = sR.Id;

            }



            var ans369 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 369).FirstOrDefault();
            if (ans369 == null)
            {

                //  ปัญหาที่พบ 10 :           
                Answer answer128 = new Answer()
                {
                    AnsDes = this.problemTextbox10.Value,
                    QuestionId = 369,
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

                ans369.QuestionId = 369;
                ans369.AnsDes = this.problemTextbox10.Value;
                ans369.AnserTypeId = 1;
                ans369.CreateDate = DateTime.Now;
                ans369.UserId = user.Id;
                ans369.AnsMonth = ansMonth; ans369.SRId = sR.Id;

            }





            var ans370 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 370).FirstOrDefault();
            if (ans370 == null)
            {

                //  วิธีแก้ปัญหา 10 :           
                Answer answer129 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox10.Value,
                    QuestionId = 370,
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

                ans370.QuestionId = 370;
                ans370.AnsDes = this.howtoSolveTextbox10.Value;
                ans370.AnserTypeId = 1;
                ans370.CreateDate = DateTime.Now;
                ans370.UserId = user.Id;
                ans370.AnsMonth = ansMonth; ans370.SRId = sR.Id;

            }



            var ans371 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 371).FirstOrDefault();
            if (ans371 == null)
            {
                //  ปัญหาที่พบ 11 :           
                Answer answer130 = new Answer()
                {
                    AnsDes = this.problemTextbox11.Value,
                    QuestionId = 371,
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

                ans371.QuestionId = 371;
                ans371.AnsDes = this.problemTextbox11.Value;
                ans371.AnserTypeId = 1;
                ans371.CreateDate = DateTime.Now;
                ans371.UserId = user.Id;
                ans371.AnsMonth = ansMonth; ans371.SRId = sR.Id;

            }





            var ans372 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 372).FirstOrDefault();
            if (ans372 == null)
            {
                //  วิธีแก้ปัญหา 11 :           
                Answer answer131 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox11.Value,
                    QuestionId = 372,
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

                ans372.QuestionId = 372;
                ans372.AnsDes = this.howtoSolveTextbox11.Value;
                ans372.AnserTypeId = 1;
                ans372.CreateDate = DateTime.Now;
                ans372.UserId = user.Id;
                ans372.AnsMonth = ansMonth; ans372.SRId = sR.Id;

            }



            var ans373 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 373).FirstOrDefault();
            if (ans373 == null)
            {
                //  ปัญหาที่พบ 12 :           
                Answer answer132 = new Answer()
                {
                    AnsDes = this.problemTextbox12.Value,
                    QuestionId = 373,
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

                ans373.QuestionId = 373;
                ans373.AnsDes = this.problemTextbox12.Value;
                ans373.AnserTypeId = 1;
                ans373.CreateDate = DateTime.Now;
                ans373.UserId = user.Id;
                ans373.AnsMonth = ansMonth; ans373.SRId = sR.Id;

            }


            var ans374 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 374).FirstOrDefault();
            if (ans374 == null)
            {
                //  วิธีแก้ปัญหา 12 :           
                Answer answer133 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox12.Value,
                    QuestionId = 374,
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

                ans374.QuestionId = 374;
                ans374.AnsDes = this.howtoSolveTextbox12.Value;
                ans374.AnserTypeId = 1;
                ans374.CreateDate = DateTime.Now;
                ans374.UserId = user.Id;
                ans374.AnsMonth = ansMonth; ans374.SRId = sR.Id;

            }







            var ans375 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 375).FirstOrDefault();
            if (ans375 == null)
            {
                //  ปัญหาที่พบ 13 :           
                Answer answer134 = new Answer()
                {
                    AnsDes = this.problemTextbox13.Value,
                    QuestionId = 375,
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

                ans375.QuestionId = 375;
                ans375.AnsDes = this.problemTextbox13.Value;
                ans375.AnserTypeId = 1;
                ans375.CreateDate = DateTime.Now;
                ans375.UserId = user.Id;
                ans375.AnsMonth = ansMonth; ans375.SRId = sR.Id;

            }



            var ans376 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 376).FirstOrDefault();
            if (ans376 == null)
            {
                //  วิธีแก้ปัญหา 13 :           
                Answer answer135 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox13.Value,
                    QuestionId = 376,
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

                ans376.QuestionId = 376;
                ans376.AnsDes = this.howtoSolveTextbox13.Value;
                ans376.AnserTypeId = 1;
                ans376.CreateDate = DateTime.Now;
                ans376.UserId = user.Id;
                ans376.AnsMonth = ansMonth; ans376.SRId = sR.Id;

            }





            var ans377 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 377).FirstOrDefault();
            if (ans377 == null)
            {
                //  ปัญหาที่พบ 14 :           
                Answer answer136 = new Answer()
                {
                    AnsDes = this.problemTextbox14.Value,
                    QuestionId = 377,
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

                ans377.QuestionId = 377;
                ans377.AnsDes = this.problemTextbox14.Value;
                ans377.AnserTypeId = 1;
                ans377.CreateDate = DateTime.Now;
                ans377.UserId = user.Id;
                ans377.AnsMonth = ansMonth; ans377.SRId = sR.Id;

            }





            var ans378 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 378).FirstOrDefault();
            if (ans378 == null)
            {
                //  วิธีแก้ปัญหา 14 :           
                Answer answer137 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox14.Value,
                    QuestionId = 378,
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

                ans378.QuestionId = 378;
                ans378.AnsDes = this.howtoSolveTextbox14.Value;
                ans378.AnserTypeId = 1;
                ans378.CreateDate = DateTime.Now;
                ans378.UserId = user.Id;
                ans378.AnsMonth = ansMonth; ans378.SRId = sR.Id;

            }







            var ans379 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 379).FirstOrDefault();
            if (ans379 == null)
            {

                //  ปัญหาที่พบ 15 :           
                Answer answer138 = new Answer()
                {
                    AnsDes = this.problemTextbox15.Value,
                    QuestionId = 379,
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

                ans379.QuestionId = 379;
                ans379.AnsDes = this.problemTextbox15.Value;
                ans379.AnserTypeId = 1;
                ans379.CreateDate = DateTime.Now;
                ans379.UserId = user.Id;
                ans379.AnsMonth = ansMonth; ans379.SRId = sR.Id;

            }



            var ans380 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 380).FirstOrDefault();
            if (ans380 == null)
            {

                //  วิธีแก้ปัญหา 15 :           
                Answer answer139 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox15.Value,
                    QuestionId = 380,
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

                ans380.QuestionId = 380;
                ans380.AnsDes = this.howtoSolveTextbox15.Value;
                ans380.AnserTypeId = 1;
                ans380.CreateDate = DateTime.Now;
                ans380.UserId = user.Id;
                ans380.AnsMonth = ansMonth; ans380.SRId = sR.Id;

            }





            // -----------------       Sectionid = 38          ---------------------//




            var ans381 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 381).FirstOrDefault();
            if (ans381 == null)
            {

                // รายการอุปกรณ์ 1 :      
                Answer answer141 = new Answer()
                {
                    AnsDes = this.toolsListTextbox1.Value,
                    QuestionId = 381,
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

                ans381.QuestionId = 381;
                ans381.AnsDes = this.toolsListTextbox1.Value;
                ans381.AnserTypeId = 1;
                ans381.CreateDate = DateTime.Now;
                ans381.UserId = user.Id;
                ans381.AnsMonth = ansMonth; ans381.SRId = sR.Id;

            }



            var ans382 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 382).FirstOrDefault();
            if (ans382 == null)
            {

                //  SerialNumber :           
                Answer answer142 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox1.Value,
                    QuestionId = 382,
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

                ans382.QuestionId = 382;
                ans382.AnsDes = this.serialNumberTextbox1.Value;
                ans382.AnserTypeId = 1;
                ans382.CreateDate = DateTime.Now;
                ans382.UserId = user.Id;
                ans382.AnsMonth = ansMonth; ans382.SRId = sR.Id;

            }






            var ans383 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 383).FirstOrDefault();
            if (ans383 == null)
            {

                //  new SerialNumber :           
                Answer answer143 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox1.Value,
                    QuestionId = 383,
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

                ans383.QuestionId = 383;
                ans383.AnsDes = this.newSerialNumberTextbox1.Value;
                ans383.AnserTypeId = 1;
                ans383.CreateDate = DateTime.Now;
                ans383.UserId = user.Id;
                ans383.AnsMonth = ansMonth; ans383.SRId = sR.Id;

            }




            var ans384 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 384).FirstOrDefault();
            if (ans384 == null)
            {

                //  หมายเหตุ :           
                Answer answer144 = new Answer()
                {
                    AnsDes = this.noteTextbox1.Value,
                    QuestionId = 384,
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

                ans384.QuestionId = 384;
                ans384.AnsDes = this.noteTextbox1.Value;
                ans384.AnserTypeId = 1;
                ans384.CreateDate = DateTime.Now;
                ans384.UserId = user.Id;
                ans384.AnsMonth = ansMonth; ans384.SRId = sR.Id;

            }







            var ans385 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 385).FirstOrDefault();
            if (ans385 == null)
            {

                // รายการอุปกรณ์ 2 :      
                Answer answer145 = new Answer()
                {
                    AnsDes = this.toolsListTextbox2.Value,
                    QuestionId = 385,
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

                ans385.QuestionId = 385;
                ans385.AnsDes = this.toolsListTextbox2.Value;
                ans385.AnserTypeId = 1;
                ans385.CreateDate = DateTime.Now;
                ans385.UserId = user.Id;
                ans385.AnsMonth = ansMonth; ans385.SRId = sR.Id;

            }





            var ans386 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 386).FirstOrDefault();
            if (ans386 == null)
            {

                //  SerialNumber 2 :           
                Answer answer146 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox2.Value,
                    QuestionId = 386,
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

                ans386.QuestionId = 386;
                ans386.AnsDes = this.serialNumberTextbox2.Value;
                ans386.AnserTypeId = 1;
                ans386.CreateDate = DateTime.Now;
                ans386.UserId = user.Id;
                ans386.AnsMonth = ansMonth; ans386.SRId = sR.Id;

            }





            var ans387 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 387).FirstOrDefault();
            if (ans387 == null)
            {

                //  new SerialNumber 2 :           
                Answer answer147 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox2.Value,
                    QuestionId = 387,
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

                ans387.QuestionId = 387;
                ans387.AnsDes = this.newSerialNumberTextbox2.Value;
                ans387.AnserTypeId = 1;
                ans387.CreateDate = DateTime.Now;
                ans387.UserId = user.Id;
                ans387.AnsMonth = ansMonth; ans387.SRId = sR.Id;

            }


            var ans388 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 388).FirstOrDefault();
            if (ans388 == null)
            {

                //  หมายเหตุ  2:           
                Answer answer148 = new Answer()
                {
                    AnsDes = this.noteTextbox2.Value,
                    QuestionId = 388,
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

                ans388.QuestionId = 388;
                ans388.AnsDes = this.noteTextbox2.Value;
                ans388.AnserTypeId = 1;
                ans388.CreateDate = DateTime.Now;
                ans388.UserId = user.Id;
                ans388.AnsMonth = ansMonth; ans388.SRId = sR.Id;

            }





            var ans389 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 389).FirstOrDefault();
            if (ans389 == null)
            {

                // รายการอุปกรณ์ 3 :      
                Answer answer149 = new Answer()
                {
                    AnsDes = this.toolsListTextbox3.Value,
                    QuestionId = 389,
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

                ans389.QuestionId = 389;
                ans389.AnsDes = this.toolsListTextbox3.Value;
                ans389.AnserTypeId = 1;
                ans389.CreateDate = DateTime.Now;
                ans389.UserId = user.Id;
                ans389.AnsMonth = ansMonth; ans389.SRId = sR.Id;

            }

            var ans390 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 390).FirstOrDefault();
            if (ans390 == null)
            {

                //  SerialNumber 3 :           
                Answer answer150 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox3.Value,
                    QuestionId = 390,
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

                ans390.QuestionId = 390;
                ans390.AnsDes = this.serialNumberTextbox3.Value;
                ans390.AnserTypeId = 1;
                ans390.CreateDate = DateTime.Now;
                ans390.UserId = user.Id;
                ans390.AnsMonth = ansMonth; ans390.SRId = sR.Id;

            }

            var ans391 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 391).FirstOrDefault();
            if (ans391 == null)
            {

                //  new SerialNumber 3 :           
                Answer answer151 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox3.Value,
                    QuestionId = 391,
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

                ans391.QuestionId = 391;
                ans391.AnsDes = this.newSerialNumberTextbox3.Value;
                ans391.AnserTypeId = 1;
                ans391.CreateDate = DateTime.Now;
                ans391.UserId = user.Id;
                ans391.AnsMonth = ansMonth; ans391.SRId = sR.Id;

            }


            var ans392 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 392).FirstOrDefault();
            if (ans392 == null)
            {
                //  หมายเหตุ  3:           
                Answer answer152 = new Answer()
                {
                    AnsDes = this.noteTextbox3.Value,
                    QuestionId = 392,
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

                ans392.QuestionId = 392;
                ans392.AnsDes = this.noteTextbox3.Value;
                ans392.AnserTypeId = 1;
                ans392.CreateDate = DateTime.Now;
                ans392.UserId = user.Id;
                ans392.AnsMonth = ansMonth; ans392.SRId = sR.Id;

            }




            var ans393 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 393).FirstOrDefault();
            if (ans393 == null)
            {
                // รายการอุปกรณ์ 4 :      
                Answer answer153 = new Answer()
                {
                    AnsDes = this.toolsListTextbox4.Value,
                    QuestionId = 393,
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

                ans393.QuestionId = 393;
                ans393.AnsDes = this.toolsListTextbox4.Value;
                ans393.AnserTypeId = 1;
                ans393.CreateDate = DateTime.Now;
                ans393.UserId = user.Id;
                ans393.AnsMonth = ansMonth; ans393.SRId = sR.Id;

            }



            var ans394 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 394).FirstOrDefault();
            if (ans394 == null)
            {

                //  SerialNumber 4 :           
                Answer answer154 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox4.Value,
                    QuestionId = 394,
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

                ans394.QuestionId = 394;
                ans394.AnsDes = this.serialNumberTextbox4.Value;
                ans394.AnserTypeId = 1;
                ans394.CreateDate = DateTime.Now;
                ans394.UserId = user.Id;
                ans394.AnsMonth = ansMonth; ans394.SRId = sR.Id;

            }





            var ans395 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 395).FirstOrDefault();
            if (ans395 == null)
            {

                //  new SerialNumber 4 :           
                Answer answer155 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox4.Value,
                    QuestionId = 395,
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

                ans395.QuestionId = 395;
                ans395.AnsDes = this.newSerialNumberTextbox4.Value;
                ans395.AnserTypeId = 1;
                ans395.CreateDate = DateTime.Now;
                ans395.UserId = user.Id;
                ans395.AnsMonth = ansMonth; ans395.SRId = sR.Id;

            }




            var ans396 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 396).FirstOrDefault();
            if (ans396 == null)
            {

                //  หมายเหตุ  4:           
                Answer answer156 = new Answer()
                {
                    AnsDes = this.noteTextbox4.Value,
                    QuestionId = 396,
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

                ans396.QuestionId = 396;
                ans396.AnsDes = this.noteTextbox4.Value;
                ans396.AnserTypeId = 1;
                ans396.CreateDate = DateTime.Now;
                ans396.UserId = user.Id;
                ans396.AnsMonth = ansMonth; ans396.SRId = sR.Id;

            }



            var ans397 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 397).FirstOrDefault();
            if (ans397 == null)
            {

                // รายการอุปกรณ์ 5 :      
                Answer answer157 = new Answer()
                {
                    AnsDes = this.toolsListTextbox5.Value,
                    QuestionId = 397,
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

                ans397.QuestionId = 397;
                ans397.AnsDes = this.toolsListTextbox5.Value;
                ans397.AnserTypeId = 1;
                ans397.CreateDate = DateTime.Now;
                ans397.UserId = user.Id;
                ans397.AnsMonth = ansMonth; ans397.SRId = sR.Id;

            }



            var ans398 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 398).FirstOrDefault();
            if (ans398 == null)
            {

                //  SerialNumber 5 :           
                Answer answer158 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox5.Value,
                    QuestionId = 398,
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

                ans398.QuestionId = 398;
                ans398.AnsDes = this.serialNumberTextbox5.Value;
                ans398.AnserTypeId = 1;
                ans398.CreateDate = DateTime.Now;
                ans398.UserId = user.Id;
                ans398.AnsMonth = ansMonth; ans398.SRId = sR.Id;

            }


            var ans399 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 399).FirstOrDefault();
            if (ans399 == null)
            {

                //  new SerialNumber 5 :           
                Answer answer159 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox5.Value,
                    QuestionId = 399,
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

                ans399.QuestionId = 399;
                ans399.AnsDes = this.newSerialNumberTextbox5.Value;
                ans399.AnserTypeId = 1;
                ans399.CreateDate = DateTime.Now;
                ans399.UserId = user.Id;
                ans399.AnsMonth = ansMonth; ans399.SRId = sR.Id;

            }



            var ans400 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 400).FirstOrDefault();
            if (ans400 == null)
            {

                //  หมายเหตุ  5:           
                Answer answer160 = new Answer()
                {
                    AnsDes = this.noteTextbox5.Value,
                    QuestionId = 400,
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

                ans400.QuestionId = 400;
                ans400.AnsDes = this.noteTextbox5.Value;
                ans400.AnserTypeId = 1;
                ans400.CreateDate = DateTime.Now;
                ans400.UserId = user.Id;
                ans400.AnsMonth = ansMonth; ans400.SRId = sR.Id;

            }



            var ans401 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 401).FirstOrDefault();
            if (ans401 == null)
            {


                // รายการอุปกรณ์ 6 :      
                Answer answer161 = new Answer()
                {
                    AnsDes = this.toolsListTextbox6.Value,
                    QuestionId = 401,
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

                ans401.QuestionId = 401;
                ans401.AnsDes = this.toolsListTextbox6.Value;
                ans401.AnserTypeId = 1;
                ans401.CreateDate = DateTime.Now;
                ans401.UserId = user.Id;
                ans401.AnsMonth = ansMonth; ans401.SRId = sR.Id;

            }




            var ans402 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 402).FirstOrDefault();
            if (ans402 == null)
            {
                //  SerialNumber 6 :           
                Answer answer162 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox6.Value,
                    QuestionId = 402,
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

                ans402.QuestionId = 402;
                ans402.AnsDes = this.serialNumberTextbox6.Value;
                ans402.AnserTypeId = 1;
                ans402.CreateDate = DateTime.Now;
                ans402.UserId = user.Id;
                ans402.AnsMonth = ansMonth; ans402.SRId = sR.Id;

            }


            var ans403 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 403).FirstOrDefault();
            if (ans403 == null)
            {
                //  new SerialNumber 6 :           
                Answer answer163 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox6.Value,
                    QuestionId = 403,
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

                ans403.QuestionId = 403;
                ans403.AnsDes = this.newSerialNumberTextbox6.Value;
                ans403.AnserTypeId = 1;
                ans403.CreateDate = DateTime.Now;
                ans403.UserId = user.Id;
                ans403.AnsMonth = ansMonth; ans403.SRId = sR.Id;

            }


            var ans404 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 404).FirstOrDefault();
            if (ans404 == null)
            {
                //  หมายเหตุ  6:           
                Answer answer164 = new Answer()
                {
                    AnsDes = this.noteTextbox6.Value,
                    QuestionId = 404,
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

                ans404.QuestionId = 404;
                ans404.AnsDes = this.noteTextbox6.Value;
                ans404.AnserTypeId = 1;
                ans404.CreateDate = DateTime.Now;
                ans404.UserId = user.Id;
                ans404.AnsMonth = ansMonth; ans404.SRId = sR.Id;

            }


            var ans405 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 405).FirstOrDefault();
            if (ans405 == null)
            {
                // รายการอุปกรณ์ 7 :      
                Answer answer165 = new Answer()
                {
                    AnsDes = this.toolsListTextbox7.Value,
                    QuestionId = 405,
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

                ans405.QuestionId = 405;
                ans405.AnsDes = this.toolsListTextbox7.Value;
                ans405.AnserTypeId = 1;
                ans405.CreateDate = DateTime.Now;
                ans405.UserId = user.Id;
                ans405.AnsMonth = ansMonth; ans405.SRId = sR.Id;

            }


            var ans406 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 406).FirstOrDefault();
            if (ans406 == null)
            {
                //  SerialNumber 7 :           
                Answer answer166 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox7.Value,
                    QuestionId = 406,
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

                ans406.QuestionId = 406;
                ans406.AnsDes = this.serialNumberTextbox7.Value;
                ans406.AnserTypeId = 1;
                ans406.CreateDate = DateTime.Now;
                ans406.UserId = user.Id;
                ans406.AnsMonth = ansMonth; ans406.SRId = sR.Id;

            }



            var ans407 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 407).FirstOrDefault();
            if (ans407 == null)
            {
                //  new SerialNumber 7 :           
                Answer answer167 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox7.Value,
                    QuestionId = 407,
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

                ans407.QuestionId = 407;
                ans407.AnsDes = this.newSerialNumberTextbox7.Value;
                ans407.AnserTypeId = 1;
                ans407.CreateDate = DateTime.Now;
                ans407.UserId = user.Id;
                ans407.AnsMonth = ansMonth; ans407.SRId = sR.Id;

            }





            var ans408 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 408).FirstOrDefault();
            if (ans408 == null)
            {
                //  หมายเหตุ  7:           
                Answer answer168 = new Answer()
                {
                    AnsDes = this.noteTextbox7.Value,
                    QuestionId = 408,
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

                ans408.QuestionId = 408;
                ans408.AnsDes = this.noteTextbox7.Value;
                ans408.AnserTypeId = 1;
                ans408.CreateDate = DateTime.Now;
                ans408.UserId = user.Id;
                ans408.AnsMonth = ansMonth; ans408.SRId = sR.Id;

            }




            var ans409 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 409).FirstOrDefault();
            if (ans409 == null)
            {
                // รายการอุปกรณ์ 8 :      
                Answer answer169 = new Answer()
                {
                    AnsDes = this.toolsListTextbox8.Value,
                    QuestionId = 409,
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

                ans409.QuestionId = 409;
                ans409.AnsDes = this.toolsListTextbox8.Value;
                ans409.AnserTypeId = 1;
                ans409.CreateDate = DateTime.Now;
                ans409.UserId = user.Id;
                ans409.AnsMonth = ansMonth; ans409.SRId = sR.Id;

            }




            var ans410 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 410).FirstOrDefault();
            if (ans410 == null)
            {
                //  SerialNumber 8 :           
                Answer answer170 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox8.Value,
                    QuestionId = 410,
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

                ans410.QuestionId = 410;
                ans410.AnsDes = this.serialNumberTextbox8.Value;
                ans410.AnserTypeId = 1;
                ans410.CreateDate = DateTime.Now;
                ans410.UserId = user.Id;
                ans410.AnsMonth = ansMonth; ans410.SRId = sR.Id;

            }



            var ans411 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 411).FirstOrDefault();
            if (ans411 == null)
            {
                //  new SerialNumber 8 :           
                Answer answer171 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox8.Value,
                    QuestionId = 411,
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

                ans411.QuestionId = 411;
                ans411.AnsDes = this.newSerialNumberTextbox8.Value;
                ans411.AnserTypeId = 1;
                ans411.CreateDate = DateTime.Now;
                ans411.UserId = user.Id;
                ans411.AnsMonth = ansMonth; ans411.SRId = sR.Id;

            }



            var ans412 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 412).FirstOrDefault();
            if (ans412 == null)
            {
                //  หมายเหตุ  8:           
                Answer answer172 = new Answer()
                {
                    AnsDes = this.noteTextbox8.Value,
                    QuestionId = 412,
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

                ans412.QuestionId = 412;
                ans412.AnsDes = this.noteTextbox8.Value;
                ans412.AnserTypeId = 1;
                ans412.CreateDate = DateTime.Now;
                ans412.UserId = user.Id;
                ans412.AnsMonth = ansMonth; ans412.SRId = sR.Id;

            }


            var ans413 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 413).FirstOrDefault();
            if (ans413 == null)
            {

                // รายการอุปกรณ์ 9 :      
                Answer answer173 = new Answer()
                {
                    AnsDes = this.toolsListTextbox9.Value,
                    QuestionId = 413,
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

                ans413.QuestionId = 413;
                ans413.AnsDes = this.toolsListTextbox9.Value;
                ans413.AnserTypeId = 1;
                ans413.CreateDate = DateTime.Now;
                ans413.UserId = user.Id;
                ans413.AnsMonth = ansMonth; ans413.SRId = sR.Id;

            }



            var ans414 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 414).FirstOrDefault();
            if (ans414 == null)
            {

                //  SerialNumber 9 :           
                Answer answer174 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox9.Value,
                    QuestionId = 414,
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

                ans414.QuestionId = 414;
                ans414.AnsDes = this.serialNumberTextbox9.Value;
                ans414.AnserTypeId = 1;
                ans414.CreateDate = DateTime.Now;
                ans414.UserId = user.Id;
                ans414.AnsMonth = ansMonth; ans414.SRId = sR.Id;

            }



            var ans415 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 415).FirstOrDefault();
            if (ans415 == null)
            {

                //  new SerialNumber 9 :           
                Answer answer175 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox9.Value,
                    QuestionId = 415,
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

                ans415.QuestionId = 415;
                ans415.AnsDes = this.newSerialNumberTextbox9.Value;
                ans415.AnserTypeId = 1;
                ans415.CreateDate = DateTime.Now;
                ans415.UserId = user.Id;
                ans415.AnsMonth = ansMonth; ans415.SRId = sR.Id;

            }


            var ans416 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 416).FirstOrDefault();
            if (ans416 == null)
            {
                //  หมายเหตุ  9:           
                Answer answer176 = new Answer()
                {
                    AnsDes = this.noteTextbox9.Value,
                    QuestionId = 416,
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

                ans416.QuestionId = 416;
                ans416.AnsDes = this.noteTextbox9.Value;
                ans416.AnserTypeId = 1;
                ans416.CreateDate = DateTime.Now;
                ans416.UserId = user.Id;
                ans416.AnsMonth = ansMonth; ans416.SRId = sR.Id;

            }







            var ans417 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 417).FirstOrDefault();
            if (ans417 == null)
            {
                // รายการอุปกรณ์ 10 :      
                Answer answer177 = new Answer()
                {
                    AnsDes = this.toolsListTextbox10.Value,
                    QuestionId = 417,
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

                ans417.QuestionId = 417;
                ans417.AnsDes = this.toolsListTextbox10.Value;
                ans417.AnserTypeId = 1;
                ans417.CreateDate = DateTime.Now;
                ans417.UserId = user.Id;
                ans417.AnsMonth = ansMonth; ans417.SRId = sR.Id;

            }


            var ans418 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 418).FirstOrDefault();
            if (ans418 == null)
            {
                //  SerialNumber 10 :           
                Answer answer178 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox10.Value,
                    QuestionId = 418,
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

                ans418.QuestionId = 418;
                ans418.AnsDes = this.serialNumberTextbox10.Value;
                ans418.AnserTypeId = 1;
                ans418.CreateDate = DateTime.Now;
                ans418.UserId = user.Id;
                ans418.AnsMonth = ansMonth; ans418.SRId = sR.Id;

            }



            var ans419 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 419).FirstOrDefault();
            if (ans419 == null)
            {

                //  new SerialNumber 10 :           
                Answer answer179 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox10.Value,
                    QuestionId = 419,
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

                ans419.QuestionId = 419;
                ans419.AnsDes = this.newSerialNumberTextbox10.Value;
                ans419.AnserTypeId = 1;
                ans419.CreateDate = DateTime.Now;
                ans419.UserId = user.Id;
                ans419.AnsMonth = ansMonth; ans419.SRId = sR.Id;

            }




            var ans420 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 420).FirstOrDefault();
            if (ans420 == null)
            {

                //  หมายเหตุ  10:           
                Answer answer180 = new Answer()
                {
                    AnsDes = this.noteTextbox10.Value,
                    QuestionId = 420,
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

                ans420.QuestionId = 420;
                ans420.AnsDes = this.noteTextbox10.Value;
                ans420.AnserTypeId = 1;
                ans420.CreateDate = DateTime.Now;
                ans420.UserId = user.Id;
                ans420.AnsMonth = ansMonth; ans420.SRId = sR.Id;

            }



            var ans421 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 421).FirstOrDefault();
            if (ans421 == null)
            {
                // รายการอุปกรณ์ 11 :      
                Answer answer181 = new Answer()
                {
                    AnsDes = this.toolsListTextbox11.Value,
                    QuestionId = 421,
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

                ans421.QuestionId = 421;
                ans421.AnsDes = this.toolsListTextbox11.Value;
                ans421.AnserTypeId = 1;
                ans421.CreateDate = DateTime.Now;
                ans421.UserId = user.Id;
                ans421.AnsMonth = ansMonth; ans421.SRId = sR.Id;

            }



            var ans422 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 422).FirstOrDefault();
            if (ans422 == null)
            {
                //  SerialNumber 11 :           
                Answer answer182 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox11.Value,
                    QuestionId = 422,
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

                ans422.QuestionId = 422;
                ans422.AnsDes = this.serialNumberTextbox11.Value;
                ans422.AnserTypeId = 1;
                ans422.CreateDate = DateTime.Now;
                ans422.UserId = user.Id;
                ans422.AnsMonth = ansMonth; ans422.SRId = sR.Id;

            }



            var ans423 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 423).FirstOrDefault();
            if (ans423 == null)
            {
                //  new SerialNumber 11 :           
                Answer answer183 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox11.Value,
                    QuestionId = 423,
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

                ans423.QuestionId = 423;
                ans423.AnsDes = this.newSerialNumberTextbox11.Value;
                ans423.AnserTypeId = 1;
                ans423.CreateDate = DateTime.Now;
                ans423.UserId = user.Id;
                ans423.AnsMonth = ansMonth; ans423.SRId = sR.Id;

            }




            var ans424 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 424).FirstOrDefault();
            if (ans424 == null)
            {
                //  หมายเหตุ  11:           
                Answer answer184 = new Answer()
                {
                    AnsDes = this.noteTextbox11.Value,
                    QuestionId = 424,
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

                ans424.QuestionId = 424;
                ans424.AnsDes = this.noteTextbox11.Value;
                ans424.AnserTypeId = 1;
                ans424.CreateDate = DateTime.Now;
                ans424.UserId = user.Id;
                ans424.AnsMonth = ansMonth; ans424.SRId = sR.Id;

            }




            var ans425 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 425).FirstOrDefault();
            if (ans425 == null)
            {
                // รายการอุปกรณ์ 12 :      
                Answer answer185 = new Answer()
                {
                    AnsDes = this.toolsListTextbox12.Value,
                    QuestionId = 425,
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
                ans425.QuestionId = 425;
                ans425.AnsDes = this.toolsListTextbox12.Value;
                ans425.AnserTypeId = 1;
                ans425.CreateDate = DateTime.Now;
                ans425.UserId = user.Id;
                ans425.AnsMonth = ansMonth; ans425.SRId = sR.Id;

            }






            var ans426 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 426).FirstOrDefault();
            if (ans426 == null)
            {
                //  SerialNumber 12 :           
                Answer answer186 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox12.Value,
                    QuestionId = 426,
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
                ans426.QuestionId = 426;
                ans426.AnsDes = this.serialNumberTextbox12.Value;
                ans426.AnserTypeId = 1;
                ans426.CreateDate = DateTime.Now;
                ans426.UserId = user.Id;
                ans426.AnsMonth = ansMonth; ans426.SRId = sR.Id;

            }



            var ans427 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 427).FirstOrDefault();
            if (ans427 == null)
            {
                //  new SerialNumber 12 :           
                Answer answer187 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox12.Value,
                    QuestionId = 427,
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
                ans427.QuestionId = 427;
                ans427.AnsDes = this.newSerialNumberTextbox12.Value;
                ans427.AnserTypeId = 1;
                ans427.CreateDate = DateTime.Now;
                ans427.UserId = user.Id;
                ans427.AnsMonth = ansMonth; ans427.SRId = sR.Id;

            }




            var ans428 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 428).FirstOrDefault();
            if (ans428 == null)
            {
                //  หมายเหตุ  12:           
                Answer answer188 = new Answer()
                {
                    AnsDes = this.noteTextbox12.Value,
                    QuestionId = 428,
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
                ans428.QuestionId = 428;
                ans428.AnsDes = this.noteTextbox12.Value;
                ans428.AnserTypeId = 1;
                ans428.CreateDate = DateTime.Now;
                ans428.UserId = user.Id;
                ans428.AnsMonth = ansMonth; ans428.SRId = sR.Id;

            }



            var ans429 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 429).FirstOrDefault();
            if (ans429 == null)
            {

                // รายการอุปกรณ์ 13 :      
                Answer answer189 = new Answer()
                {
                    AnsDes = this.toolsListTextbox13.Value,
                    QuestionId = 429,
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
                ans429.QuestionId = 429;
                ans429.AnsDes = this.toolsListTextbox13.Value;
                ans429.AnserTypeId = 1;
                ans429.CreateDate = DateTime.Now;
                ans429.UserId = user.Id;
                ans429.AnsMonth = ansMonth; ans429.SRId = sR.Id;

            }




            var ans430 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 430).FirstOrDefault();
            if (ans430 == null)
            {
                //  SerialNumber 13 :           
                Answer answer190 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox13.Value,
                    QuestionId = 430,
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
                ans430.QuestionId = 430;
                ans430.AnsDes = this.serialNumberTextbox13.Value;
                ans430.AnserTypeId = 1;
                ans430.CreateDate = DateTime.Now;
                ans430.UserId = user.Id;
                ans430.AnsMonth = ansMonth; ans430.SRId = sR.Id;

            }





            var ans431 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 431).FirstOrDefault();
            if (ans431 == null)
            {
                //  new SerialNumber 13 :           
                Answer answer191 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox13.Value,
                    QuestionId = 431,
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
                ans431.QuestionId = 431;
                ans431.AnsDes = this.newSerialNumberTextbox13.Value;
                ans431.AnserTypeId = 1;
                ans431.CreateDate = DateTime.Now;
                ans431.UserId = user.Id;
                ans431.AnsMonth = ansMonth; ans431.SRId = sR.Id;

            }




            var ans432 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 432).FirstOrDefault();
            if (ans432 == null)
            {
                //  หมายเหตุ  13   :    
                Answer answer192 = new Answer()
                {
                    AnsDes = this.noteTextbox13.Value,
                    QuestionId = 432,
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
                ans432.QuestionId = 432;
                ans432.AnsDes = this.noteTextbox13.Value;
                ans432.AnserTypeId = 1;
                ans432.CreateDate = DateTime.Now;
                ans432.UserId = user.Id;
                ans432.AnsMonth = ansMonth; ans432.SRId = sR.Id;

            }


            var ans433 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 433).FirstOrDefault();
            if (ans433 == null)
            {

                // รายการอุปกรณ์ 14 :      
                Answer answer193 = new Answer()
                {
                    AnsDes = this.toolsListTextbox14.Value,
                    QuestionId = 433,
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
                ans433.QuestionId = 433;
                ans433.AnsDes = this.toolsListTextbox14.Value;
                ans433.AnserTypeId = 1;
                ans433.CreateDate = DateTime.Now;
                ans433.UserId = user.Id;
                ans433.AnsMonth = ansMonth; ans433.SRId = sR.Id;

            }


            var ans434 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 434).FirstOrDefault();
            if (ans434 == null)
            {

                //  SerialNumber 14 :           
                Answer answer194 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox14.Value,
                    QuestionId = 434,
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
                ans434.QuestionId = 434;
                ans434.AnsDes = this.serialNumberTextbox14.Value;
                ans434.AnserTypeId = 1;
                ans434.CreateDate = DateTime.Now;
                ans434.UserId = user.Id;
                ans434.AnsMonth = ansMonth; ans434.SRId = sR.Id;

            }


            var ans435 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 435).FirstOrDefault();
            if (ans435 == null)
            {

                //  new SerialNumber 14 :           
                Answer answer195 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox14.Value,
                    QuestionId = 435,
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
                ans435.QuestionId = 435;
                ans435.AnsDes = this.newSerialNumberTextbox14.Value;
                ans435.AnserTypeId = 1;
                ans435.CreateDate = DateTime.Now;
                ans435.UserId = user.Id;
                ans435.AnsMonth = ansMonth; ans435.SRId = sR.Id;

            }




            var ans436 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 436).FirstOrDefault();
            if (ans436 == null)
            {
                //  หมายเหตุ  143   :    
                Answer answer196 = new Answer()
                {
                    AnsDes = this.noteTextbox14.Value,
                    QuestionId = 436,
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
                ans436.QuestionId = 436;
                ans436.AnsDes = this.noteTextbox14.Value;
                ans436.AnserTypeId = 1;
                ans436.CreateDate = DateTime.Now;
                ans436.UserId = user.Id;
                ans436.AnsMonth = ansMonth; ans436.SRId = sR.Id;

            }



            var ans437 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 437).FirstOrDefault();
            if (ans437 == null)
            {

                // รายการอุปกรณ์ 15 :      
                Answer answer197 = new Answer()
                {
                    AnsDes = this.toolsListTextbox15.Value,
                    QuestionId = 437,
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
                ans437.QuestionId = 437;
                ans437.AnsDes = this.toolsListTextbox15.Value;
                ans437.AnserTypeId = 1;
                ans437.CreateDate = DateTime.Now;
                ans437.UserId = user.Id;
                ans437.AnsMonth = ansMonth; ans437.SRId = sR.Id;

            }

            var ans438 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 438).FirstOrDefault();
            if (ans438 == null)
            {
                //  SerialNumber 15 :           
                Answer answer198 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox15.Value,
                    QuestionId = 438,
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
                ans438.QuestionId = 438;
                ans438.AnsDes = this.serialNumberTextbox15.Value;
                ans438.AnserTypeId = 1;
                ans438.CreateDate = DateTime.Now;
                ans438.UserId = user.Id;
                ans438.AnsMonth = ansMonth; ans438.SRId = sR.Id;

            }



            var ans439 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 439).FirstOrDefault();
            if (ans439 == null)
            {
                //  new SerialNumber 15 :           
                Answer answer199 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox15.Value,
                    QuestionId = 439,
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
                ans439.QuestionId = 439;
                ans439.AnsDes = this.newSerialNumberTextbox15.Value;
                ans439.AnserTypeId = 1;
                ans439.CreateDate = DateTime.Now;
                ans439.UserId = user.Id;
                ans439.AnsMonth = ansMonth; ans439.SRId = sR.Id;

            }


            var ans440 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 440).FirstOrDefault();
            if (ans440 == null)
            {
                //  หมายเหตุ  15   :    
                Answer answer200 = new Answer()
                {
                    AnsDes = this.noteTextbox15.Value,
                    QuestionId = 440,
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
                ans440.QuestionId = 440;
                ans440.AnsDes = this.noteTextbox15.Value;
                ans440.AnserTypeId = 1;
                ans440.CreateDate = DateTime.Now;
                ans440.UserId = user.Id;
                ans440.AnsMonth = ansMonth; ans440.SRId = sR.Id;

            }









            //------------------ section = 39   -----------------//

            var ans441 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 441).FirstOrDefault();
            if (ans441 == null)
            {
                //   name pm :    
                Answer answer1591 = new Answer()
                {
                    AnsDes = this.nameDopmTextbox.Value,
                    QuestionId = 441,
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
                ans441.QuestionId = 441;
                ans441.AnsDes = this.nameDopmTextbox.Value;
                ans441.AnserTypeId = 1;
                ans441.CreateDate = DateTime.Now;
                ans441.UserId = user.Id;
                ans441.AnsMonth = ansMonth; ans441.SRId = sR.Id;

            }


            var ans442 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 442).FirstOrDefault();
            if (ans442 == null)
            {
                //  วันที่ทำ PM :    
                Answer answer1592 = new Answer()
                {
                    AnsDes = this.dayDopmTextbox.Value,
                    QuestionId = 442,
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
                ans442.QuestionId = 442;
                ans442.AnsDes = this.dayDopmTextbox.Value;
                ans442.AnserTypeId = 1;
                ans442.CreateDate = DateTime.Now;
                ans442.UserId = user.Id;
                ans442.AnsMonth = ansMonth; ans442.SRId = sR.Id;

            }








            //----------------- section = 40  -----------------------------//


            var ans443 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 443).FirstOrDefault();
            if (ans443 == null)
            {

                // รูปภาพรวมบริเวณ Site :
                string steAreaRadio = Request.Form["steAreaRadio"];
                Answer answer1593 = new Answer()
                {
                    AnsDes = steAreaRadio,
                    QuestionId = 443,
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
                string varribles = Request.Form["steAreaRadio"];
                ans443.QuestionId = 443;
                ans443.AnsDes = varribles;
                ans443.AnserTypeId = 4;
                ans443.CreateDate = DateTime.Now;
                ans443.UserId = user.Id;
                ans443.AnsMonth = ansMonth; ans443.SRId = sR.Id;

            }




            var ans444 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 444).FirstOrDefault();
            if (ans444 == null)
            {

                // รูปหน้าตู้ ก่อน-หลัง Site :
                string beforeAfterRadio = Request.Form["beforeAfterRadio"];
                Answer answer1594 = new Answer()
                {
                    AnsDes = beforeAfterRadio,
                    QuestionId = 444,
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
                string varribles = Request.Form["beforeAfterRadio"];
                ans444.QuestionId = 444;
                ans444.AnsDes = varribles;
                ans444.AnserTypeId = 4;
                ans444.CreateDate = DateTime.Now;
                ans444.UserId = user.Id;
                ans444.AnsMonth = ansMonth; ans444.SRId = sR.Id;

            }





            var ans445 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 445).FirstOrDefault();
            if (ans445 == null)
            {

                // รูปภายในตู้ ก่อน-หลัง :
                string picIncontainRadio = Request.Form["picIncontainRadio"];
                Answer answer1595 = new Answer()
                {
                    AnsDes = picIncontainRadio,
                    QuestionId = 445,
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
                string varribles = Request.Form["picIncontainRadio"];
                ans445.QuestionId = 445;
                ans445.AnsDes = varribles;
                ans445.AnserTypeId = 4;
                ans445.CreateDate = DateTime.Now;
                ans445.UserId = user.Id;
                ans445.AnsMonth = ansMonth; ans445.SRId = sR.Id;

            }




            var ans446 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 446).FirstOrDefault();
            if (ans446 == null)
            {

                // รูปขณะทำความสะอาดตู้ ก่อน-หลัง :
                string beforeCleanRaio = Request.Form["beforeCleanRaio"];
                Answer answer1596 = new Answer()
                {
                    AnsDes = beforeCleanRaio,
                    QuestionId = 446,
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
                string varribles = Request.Form["beforeCleanRaio"];
                ans446.QuestionId = 446;
                ans446.AnsDes = varribles;
                ans446.AnserTypeId = 4;
                ans446.CreateDate = DateTime.Now;
                ans446.UserId = user.Id;
                ans446.AnsMonth = ansMonth; ans446.SRId = sR.Id;

            }



            var ans447 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 447).FirstOrDefault();
            if (ans447 == null)
            {

                // รูปสถานะ Circuit Breaker (ON):
                string circuitBreakOnRaio = Request.Form["circuitBreakOnRaio"];
                Answer answer1597 = new Answer()
                {
                    AnsDes = circuitBreakOnRaio,
                    QuestionId = 447,
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
                string varribles = Request.Form["circuitBreakOnRaio"];
                ans447.QuestionId = 447;
                ans447.AnsDes = varribles;
                ans447.AnserTypeId = 4;
                ans447.CreateDate = DateTime.Now;
                ans447.UserId = user.Id;
                ans447.AnsMonth = ansMonth; ans447.SRId = sR.Id;

            }






            var ans448 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 448).FirstOrDefault();
            if (ans448 == null)
            {
                // รูปการตรวจสอบ Ground และ Bar Ground :
                string GroundAndBarGroundRaio = Request.Form["GroundAndBarGroundRaio"];
                Answer answer1600 = new Answer()
                {
                    AnsDes = GroundAndBarGroundRaio,
                    QuestionId = 448,
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
                string varribles = Request.Form["GroundAndBarGroundRaio"];
                ans448.QuestionId = 448;
                ans448.AnsDes = varribles;
                ans448.AnserTypeId = 4;
                ans448.CreateDate = DateTime.Now;
                ans448.UserId = user.Id;
                ans448.AnsMonth = ansMonth; ans448.SRId = sR.Id;

            }



            var ans449 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 449).FirstOrDefault();
            if (ans449 == null)
            {
                // รูปการตรวจสอบสถานะไฟฟ้ารั่วลง Ground (Lamp Test:
                string groundLampRadio = Request.Form["groundLampRadio"];
                Answer answer1601 = new Answer()
                {
                    AnsDes = groundLampRadio,
                    QuestionId = 449,
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
                string varribles = Request.Form["groundLampRadio"];
                ans449.QuestionId = 449;
                ans449.AnsDes = varribles;
                ans449.AnserTypeId = 4;
                ans449.CreateDate = DateTime.Now;
                ans449.UserId = user.Id;
                ans449.AnsMonth = ansMonth; ans449.SRId = sR.Id;

            }


            var ans450 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 450).FirstOrDefault();
            if (ans450 == null)
            {
                // รูป PEA Meter :
                string peaMeterRaio = Request.Form["peaMeterRaio"];
                Answer answer1602 = new Answer()
                {
                    AnsDes = peaMeterRaio,
                    QuestionId = 450,
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
                string varribles = Request.Form["peaMeterRaio"];
                ans450.QuestionId = 450;
                ans450.AnsDes = varribles;
                ans450.AnserTypeId = 4;
                ans450.CreateDate = DateTime.Now;
                ans450.UserId = user.Id;
                ans450.AnsMonth = ansMonth; ans450.SRId = sR.Id;

            }



            var ans451 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 451).FirstOrDefault();
            if (ans451 == null)
            {
                // >รูปการวัดแรงดัน AC และกระแส AC :
                string acAndACRadio = Request.Form["acAndACRadio"];
                Answer answer1603 = new Answer()
                {
                    AnsDes = acAndACRadio,
                    QuestionId = 451,
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
                string varribles = Request.Form["acAndACRadio"];
                ans451.QuestionId = 451;
                ans451.AnsDes = varribles;
                ans451.AnserTypeId = 4;
                ans451.CreateDate = DateTime.Now;
                ans451.UserId = user.Id;
                ans451.AnsMonth = ansMonth; ans451.SRId = sR.Id;

            }



            var ans452 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 452).FirstOrDefault();
            if (ans452 == null)
            {
                // รูปหน้าจอ UPS แสดงค่าต่างๆ และ Serial NO. :
                string monitorSerRadio = Request.Form["monitorSerRadio"];
                Answer answer1604 = new Answer()
                {
                    AnsDes = monitorSerRadio,
                    QuestionId = 452,
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
                string varribles = Request.Form["monitorSerRadio"];
                ans452.QuestionId = 452;
                ans452.AnsDes = varribles;
                ans452.AnserTypeId = 4;
                ans452.CreateDate = DateTime.Now;
                ans452.UserId = user.Id;
                ans452.AnsMonth = ansMonth; ans452.SRId = sR.Id;

            }


            var ans453 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 453).FirstOrDefault();
            if (ans453 == null)
            {
                // รูป ONU/Modem พร้อม Serial NO. และ MAC :
                string ONUModemAndMacRadio = Request.Form["ONUModemAndMacRadio"];
                Answer answer1605 = new Answer()
                {
                    AnsDes = ONUModemAndMacRadio,
                    QuestionId = 453,
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
                string varribles = Request.Form["ONUModemAndMacRadio"];
                ans453.QuestionId = 453;
                ans453.AnsDes = varribles;
                ans453.AnserTypeId = 4;
                ans453.CreateDate = DateTime.Now;
                ans453.UserId = user.Id;
                ans453.AnsMonth = ansMonth; ans453.SRId = sR.Id;

            }





            var ans454 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 454).FirstOrDefault();
            if (ans454 == null)
            {
                // รูป Power Supply พร้อม Serial NO.  :
                string psuAndSerialRadio = Request.Form["psuAndSerialRadio"];
                Answer answer454 = new Answer()
                {
                    AnsDes = psuAndSerialRadio,
                    QuestionId = 454,
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
                string varribles = Request.Form["psuAndSerialRadio"];
                ans454.QuestionId = 454;
                ans454.AnsDes = varribles;
                ans454.AnserTypeId = 4;
                ans454.CreateDate = DateTime.Now;
                ans454.UserId = user.Id;
                ans454.AnsMonth = ansMonth; ans454.SRId = sR.Id;

            }


            var ans455 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 455).FirstOrDefault();
            if (ans455 == null)
            {

                // รูป Switch 8 Port พร้อม Serial NO. และ MAC  :
                string switch8PortRadio = Request.Form["switch8PortRadio"];
                Answer answer455 = new Answer()
                {
                    AnsDes = switch8PortRadio,
                    QuestionId = 455,
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
                string varribles = Request.Form["switch8PortRadio"];
                ans455.QuestionId = 455;
                ans455.AnsDes = varribles;
                ans455.AnserTypeId = 4;
                ans455.CreateDate = DateTime.Now;
                ans455.UserId = user.Id;
                ans455.AnsMonth = ansMonth; ans455.SRId = sR.Id;

            }



            var ans456 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 456).FirstOrDefault();
            if (ans456 == null)
            {

                // รูป Outdoor AP 2.4 GHz พร้อม Serial NO. และ MAC :
                string outDoorApRadio = Request.Form["outDoorApRadio"];
                Answer answer456 = new Answer()
                {
                    AnsDes = outDoorApRadio,
                    QuestionId = 456,
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
                string varribles = Request.Form["outDoorApRadio"];
                ans456.QuestionId = 456;
                ans456.AnsDes = varribles;
                ans456.AnserTypeId = 4;
                ans456.CreateDate = DateTime.Now;
                ans456.UserId = user.Id;
                ans456.AnsMonth = ansMonth; ans456.SRId = sR.Id;

            }





            var ans457 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 457).FirstOrDefault();
            if (ans457 == null)
            {

                // รูป Outdoor AP 5 GHz พร้อม Serial NO. และ MAC :
                string outDoorAp5GhzRadioWithser = Request.Form["outDoorAp5GhzRadioWithser"];
                Answer answer457 = new Answer()
                {
                    AnsDes = outDoorAp5GhzRadioWithser,
                    QuestionId = 457,
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
                string varribles = Request.Form["outDoorAp5GhzRadioWithser"];
                ans457.QuestionId = 457;
                ans457.AnsDes = varribles;
                ans457.AnserTypeId = 4;
                ans457.CreateDate = DateTime.Now;
                ans457.UserId = user.Id;
                ans457.AnsMonth = ansMonth; ans457.SRId = sR.Id;

            }




            var ans458 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 458).FirstOrDefault();
            if (ans458 == null)
            {
                // รูปการ Test Speed ONU (30/10 mbps) :
                string testSpeedOnuRadio = Request.Form["testSpeedOnuRadio"];
                Answer answer1606 = new Answer()
                {
                    AnsDes = testSpeedOnuRadio,
                    QuestionId = 458,
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
                string varribles = Request.Form["testSpeedOnuRadio"];
                ans458.QuestionId = 458;
                ans458.AnsDes = varribles;
                ans458.AnserTypeId = 4;
                ans458.CreateDate = DateTime.Now;
                ans458.UserId = user.Id;
                ans458.AnsMonth = ansMonth; ans458.SRId = sR.Id;

            }





            var ans459 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 459).FirstOrDefault();
            if (ans459 == null)
            {
                // รูปการ Test Speed VSAT (30/5 mbps) *เฉพาะ SAT :
                string testSpeedVsatRadio = Request.Form["testSpeedVsatRadio"];
                Answer answer459 = new Answer()
                {
                    AnsDes = testSpeedVsatRadio,
                    QuestionId = 459,
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
                string varribles = Request.Form["testSpeedVsatRadio"];
                ans459.QuestionId = 459;
                ans459.AnsDes = varribles;
                ans459.AnserTypeId = 4;
                ans459.CreateDate = DateTime.Now;
                ans459.UserId = user.Id;
                ans459.AnsMonth = ansMonth; ans459.SRId = sR.Id;

            }




            var ans460 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 460).FirstOrDefault();
            if (ans460 == null)
            {
                // รูป Cable Inlet ด้านในและด้านนอก :
                string cableInlet = Request.Form["eieicableInletRadio"];
                Answer answer460 = new Answer()
                {
                    AnsDes = cableInlet,
                    QuestionId = 460,
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
                string varribles = Request.Form["eieicableInletRadio"];
                ans460.QuestionId = 460;
                ans460.AnsDes = varribles;
                ans460.AnserTypeId = 4;
                ans460.CreateDate = DateTime.Now;
                ans460.UserId = user.Id;
                ans460.AnsMonth = ansMonth; ans460.SRId = sR.Id;

            }



            var ans461 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 461).FirstOrDefault();
            if (ans461 == null)
            {
                // รูป Filter ก่อน-หลัง ทำความสะอาด :
                string filterBeforeCleanRadio = Request.Form["filterBeforeCleanRadio"];
                Answer answer461 = new Answer()
                {
                    AnsDes = filterBeforeCleanRadio,
                    QuestionId = 461,
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
                string varribles = Request.Form["filterBeforeCleanRadio"];
                ans461.QuestionId = 461;
                ans461.AnsDes = varribles;
                ans461.AnserTypeId = 4;
                ans461.CreateDate = DateTime.Now;
                ans461.UserId = user.Id;
                ans461.AnsMonth = ansMonth; ans461.SRId = sR.Id;

            }














            // ------------------------    SECTION 41 :  ------------------------------- // 



            var ans462 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 462).FirstOrDefault();
            if (ans462 == null)
            {
                // รูปจุดติดตั้งจานดาวเทียม :
                string inStallSatRadio = Request.Form["inStallSatRadio"];
                Answer answer1614 = new Answer()
                {
                    AnsDes = inStallSatRadio,
                    QuestionId = 462,
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
                string varribles = Request.Form["inStallSatRadio"];
                ans462.QuestionId = 462;
                ans462.AnsDes = varribles;
                ans462.AnserTypeId = 4;
                ans462.CreateDate = DateTime.Now;
                ans462.UserId = user.Id;
                ans462.AnsMonth = ansMonth; ans462.SRId = sR.Id;

            }





            var ans463 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 463).FirstOrDefault();
            if (ans463 == null)
            {
                // รูปความสะอาดบริเวณจานดาวเทียม :
                string cleanSatRadio = Request.Form["cleanSatRadio"];
                Answer answer1615 = new Answer()
                {
                    AnsDes = cleanSatRadio,
                    QuestionId = 463,
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
                string varribles = Request.Form["cleanSatRadio"];
                ans463.QuestionId = 463;
                ans463.AnsDes = varribles;
                ans463.AnserTypeId = 4;
                ans463.CreateDate = DateTime.Now;
                ans463.UserId = user.Id;
                ans463.AnsMonth = ansMonth; ans463.SRId = sR.Id;

            }


            var ans464 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 464).FirstOrDefault();
            if (ans464 == null)
            {
                //รูป LNB พร้อม Part NO :
                string lnbWithpartRadio = Request.Form["lnbWithpartRadio"];
                Answer answer1616 = new Answer()
                {
                    AnsDes = lnbWithpartRadio,
                    QuestionId = 464,
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
                string varribles = Request.Form["lnbWithpartRadio"];
                ans464.QuestionId = 464;
                ans464.AnsDes = varribles;
                ans464.AnserTypeId = 4;
                ans464.CreateDate = DateTime.Now;
                ans464.UserId = user.Id;
                ans464.AnsMonth = ansMonth; ans464.SRId = sR.Id;

            }




            var ans465 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 465).FirstOrDefault();
            if (ans465 == null)
            {
                //รูป BUC พร้อม Part NO :
                string bucWithpartRadio = Request.Form["bucWithpartRadio"];
                Answer answer1617 = new Answer()
                {
                    AnsDes = bucWithpartRadio,
                    QuestionId = 465,
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
                string varribles = Request.Form["bucWithpartRadio"];
                ans465.QuestionId = 465;
                ans465.AnsDes = varribles;
                ans465.AnserTypeId = 4;
                ans465.CreateDate = DateTime.Now;
                ans465.UserId = user.Id;
                ans465.AnsMonth = ansMonth; ans465.SRId = sR.Id;

            }


            var ans466 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 466).FirstOrDefault();
            if (ans466 == null)
            {
                //รูปการเก็บสายและพันหัวที่ LNB/BUC :
                string wireingLnbRadio = Request.Form["wireingLnbRadio"];
                Answer answer1618 = new Answer()
                {
                    AnsDes = wireingLnbRadio,
                    QuestionId = 466,
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
                string varribles = Request.Form["wireingLnbRadio"];
                ans465.QuestionId = 466;
                ans465.AnsDes = varribles;
                ans465.AnserTypeId = 4;
                ans465.CreateDate = DateTime.Now;
                ans465.UserId = user.Id;
                ans465.AnsMonth = ansMonth; ans465.SRId = sR.Id;

            }





            var ans467 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 467).FirstOrDefault();
            if (ans467 == null)
            {
                //แนว Line Of Sight (ดูการถูกบังของหน้าจานดาวเทียม)  :
                string lineOfsightRadio = Request.Form["lineOfsightRadio"];
                Answer answer1619 = new Answer()
                {
                    AnsDes = lineOfsightRadio,
                    QuestionId = 467,
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
                string varribles = Request.Form["lineOfsightRadio"];
                ans467.QuestionId = 467;
                ans467.AnsDes = varribles;
                ans467.AnserTypeId = 4;
                ans467.CreateDate = DateTime.Now;
                ans467.UserId = user.Id;
                ans467.AnsMonth = ansMonth; ans467.SRId = sR.Id;

            }







            //-------------------------------    SECTION 42 : -------------------------------//


            var ans468 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 468).FirstOrDefault();
            if (ans468 == null)
            {
                //รูปจุดติดตั้ง Solar Cell  :
                string solarCellRadio = Request.Form["solarCellRadio"];
                Answer answer1620 = new Answer()
                {
                    AnsDes = solarCellRadio,
                    QuestionId = 468,
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
                string varribles = Request.Form["solarCellRadio"];
                ans468.QuestionId = 468;
                ans468.AnsDes = varribles;
                ans468.AnserTypeId = 4;
                ans468.CreateDate = DateTime.Now;
                ans468.UserId = user.Id;
                ans468.AnsMonth = ansMonth; ans468.SRId = sR.Id;

            }



            var ans469 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 469).FirstOrDefault();
            if (ans469 == null)
            {
                //รูปจุดติดตั้ง Solar Cell :
                string toolsinSolarcellRadio = Request.Form["toolsinSolarcellRadio"];
                Answer answer1621 = new Answer()
                {
                    AnsDes = toolsinSolarcellRadio,
                    QuestionId = 469,
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
                string varribles = Request.Form["toolsinSolarcellRadio"];
                ans469.QuestionId = 469;
                ans469.AnsDes = varribles;
                ans469.AnserTypeId = 4;
                ans469.CreateDate = DateTime.Now;
                ans469.UserId = user.Id;
                ans469.AnsMonth = ansMonth; ans469.SRId = sR.Id;

            }



            var ans470 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 470).FirstOrDefault();
            if (ans470 == null)
            {
                //รูปหน้าจอ Charger แสดงค่าต่างๆ:
                string chargerRadio = Request.Form["chargerRadio"];
                Answer answer470 = new Answer()
                {
                    AnsDes = chargerRadio,
                    QuestionId = 470,
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
                string varribles = Request.Form["chargerRadio"];
                ans470.QuestionId = 470;
                ans470.AnsDes = varribles;
                ans470.AnserTypeId = 4;
                ans470.CreateDate = DateTime.Now;
                ans470.UserId = user.Id;
                ans470.AnsMonth = ansMonth; ans470.SRId = sR.Id;

            }



            var ans471 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 471).FirstOrDefault();
            if (ans471 == null)
            {
                //รูปหน้าจอ Inverter แสดงค่าต่างๆ:
                string snowingInverter = Request.Form["snowingInverterRadio"];
                Answer answer471 = new Answer()
                {
                    AnsDes = snowingInverter,
                    QuestionId = 471,
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
                string varribles = Request.Form["snowingInverterRadio"];
                ans471.QuestionId = 471;
                ans471.AnsDes = varribles;
                ans471.AnserTypeId = 4;
                ans471.CreateDate = DateTime.Now;
                ans471.UserId = user.Id;
                ans471.AnsMonth = ansMonth; ans471.SRId = sR.Id;

            }



            var ans472 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 472).FirstOrDefault();
            if (ans472 == null)
            {
                //รูป Circuit Breaker ภายในตู้:
                string cirBreakerRadio = Request.Form["cirBreakerRadio"];
                Answer answer472 = new Answer()
                {
                    AnsDes = cirBreakerRadio,
                    QuestionId = 472,
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
                string varribles = Request.Form["cirBreakerRadio"];
                ans472.QuestionId = 472;
                ans472.AnsDes = varribles;
                ans472.AnserTypeId = 4;
                ans472.CreateDate = DateTime.Now;
                ans472.UserId = user.Id;
                ans472.AnsMonth = ansMonth; ans472.SRId = sR.Id;

            }





            var ans473 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 473).FirstOrDefault();
            if (ans473 == null)
            {
                //>รูป Terminal ต่อสายภายในตู้ :
                string termialInnerRadio = Request.Form["termialInnerRadio"];
                Answer answer473 = new Answer()
                {
                    AnsDes = termialInnerRadio,
                    QuestionId = 473,
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
                string varribles = Request.Form["termialInnerRadio"];
                ans473.QuestionId = 473;
                ans473.AnsDes = varribles;
                ans473.AnserTypeId = 4;
                ans473.CreateDate = DateTime.Now;
                ans473.UserId = user.Id;
                ans473.AnsMonth = ansMonth; ans473.SRId = sR.Id;

            }




            var ans474 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 474).FirstOrDefault();
            if (ans474 == null)
            {
                // รูปการวัดแรงดัน Battery ก้อนที่ 1 :
                string batteryVoltRadio1 = Request.Form["batteryVoltRadio1"];
                Answer answer1626 = new Answer()
                {
                    AnsDes = batteryVoltRadio1,
                    QuestionId = 474,
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
                string varribles = Request.Form["batteryVoltRadio1"];
                ans474.QuestionId = 474;
                ans474.AnsDes = varribles;
                ans474.AnserTypeId = 4;
                ans474.CreateDate = DateTime.Now;
                ans474.UserId = user.Id;
                ans474.AnsMonth = ansMonth; ans474.SRId = sR.Id;

            }



            var ans475 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 475).FirstOrDefault();
            if (ans475 == null)
            {
                // รูปการวัดแรงดัน Battery ก้อนที่ 2 :
                string batteryVoltRadio2 = Request.Form["batteryVoltRadio2"];
                Answer answer1627 = new Answer()
                {
                    AnsDes = batteryVoltRadio2,
                    QuestionId = 475,
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
                string varribles = Request.Form["batteryVoltRadio2"];
                ans475.QuestionId = 475;
                ans475.AnsDes = varribles;
                ans475.AnserTypeId = 4;
                ans475.CreateDate = DateTime.Now;
                ans475.UserId = user.Id;
                ans475.AnsMonth = ansMonth; ans475.SRId = sR.Id;

            }


            var ans476 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 476).FirstOrDefault();
            if (ans476 == null)
            {
                // รูปการวัดแรงดัน Battery ก้อนที่ 3 :
                string batteryVoltRadio3 = Request.Form["batteryVoltRadio3"];
                Answer answer1628 = new Answer()
                {
                    AnsDes = batteryVoltRadio3,
                    QuestionId = 476,
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
                string varribles = Request.Form["batteryVoltRadio3"];
                ans476.QuestionId = 476;
                ans476.AnsDes = varribles;
                ans476.AnserTypeId = 4;
                ans476.CreateDate = DateTime.Now;
                ans476.UserId = user.Id;
                ans476.AnsMonth = ansMonth; ans476.SRId = sR.Id;

            }




            var ans477 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 477).FirstOrDefault();
            if (ans477 == null)
            {
                // รูปการวัดแรงดัน Battery ก้อนที่ 4 :
                string batteryVoltRadio4 = Request.Form["batteryVoltRadio4"];
                Answer answer1629 = new Answer()
                {
                    AnsDes = batteryVoltRadio4,
                    QuestionId = 477,
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
                string varribles = Request.Form["batteryVoltRadio4"];
                ans477.QuestionId = 477;
                ans477.AnsDes = varribles;
                ans477.AnserTypeId = 4;
                ans477.CreateDate = DateTime.Now;
                ans477.UserId = user.Id;
                ans477.AnsMonth = ansMonth; ans477.SRId = sR.Id;

            }




            var ans478 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 478).FirstOrDefault();
            if (ans478 == null)
            {
                // รูปความสะอาดแผง PV :
                string cleaninPVVRADIO = Request.Form["cleaninPVVRADIO"];
                Answer answer478 = new Answer()
                {
                    AnsDes = cleaninPVVRADIO,
                    QuestionId = 478,
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
                string varribles = Request.Form["cleaninPVVRADIO"];
                ans478.QuestionId = 478;
                ans478.AnsDes = varribles;
                ans478.AnserTypeId = 4;
                ans478.CreateDate = DateTime.Now;
                ans478.UserId = user.Id;
                ans478.AnsMonth = ansMonth; ans478.SRId = sR.Id;

            }




            var ans479 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 479).FirstOrDefault();
            if (ans479 == null)
            {
                // รูปภาพรวมดูสิ่งบดบังแสงอาทิตย์ :
                string sunnyRadio = Request.Form["sunnyRadio"];
                Answer answer479 = new Answer()
                {
                    AnsDes = sunnyRadio,
                    QuestionId = 479,
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
                string varribles = Request.Form["sunnyRadio"];
                ans479.QuestionId = 479;
                ans479.AnsDes = varribles;
                ans479.AnserTypeId = 4;
                ans479.CreateDate = DateTime.Now;
                ans479.UserId = user.Id;
                ans479.AnsMonth = ansMonth; ans479.SRId = sR.Id;

            }









            var ans480 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 480).FirstOrDefault();
            if (ans480 == null)

            {
                //1.รูป PICTURE CHECKLIST :
                if (this.pictureChecklistImages.HasFile)
                {
                    string extension = this.pictureChecklistImages.PostedFile.FileName.Split('.')[1];
                    string newFileName = "images/pictureChecklist_bb_2_4_" + DateTime.Now.ToString("yyyyMMddHHmmss") + "." + extension;
                    this.pictureChecklistImages.PostedFile.SaveAs(Server.MapPath(newFileName));

                    Answer answer259 = new Answer()
                    {
                        AnsDes = newFileName,
                        QuestionId = 480,
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
                    string newFileName = "images/pictureChecklist_bb_2_4_" + DateTime.Now.ToString("yyyyMMddHHmmss") + "." + extension;
                    this.pictureChecklistImages.PostedFile.SaveAs(Server.MapPath(newFileName));
                    ans480.QuestionId = 480;
                    ans480.AnsDes = newFileName;
                    ans480.AnserTypeId = 3;
                    ans480.CreateDate = DateTime.Now;
                    ans480.UserId = user.Id;
                    ans480.AnsMonth = ansMonth; ans480.SRId = sR.Id;
                }
            }






            var ans481 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 481).FirstOrDefault();
            if (ans481 == null)

            {
                //2.รูป VSAT PICTURE CHECKLIST :
                if (this.vsatpictureChecklistImages.HasFile)
                {
                    string extension = this.vsatpictureChecklistImages.PostedFile.FileName.Split('.')[1];
                    string newFileName = "images/vsatpictureChecklist_bb_2_4_" + DateTime.Now.ToString("yyyyMMddHHmmss") + "." + extension;
                    this.vsatpictureChecklistImages.PostedFile.SaveAs(Server.MapPath(newFileName));

                    Answer answer260 = new Answer()
                    {
                        AnsDes = newFileName,
                        QuestionId = 481,
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
                    string newFileName = "images/vsatpictureChecklist_bb_2_4_" + DateTime.Now.ToString("yyyyMMddHHmmss") + "." + extension;
                    this.vsatpictureChecklistImages.PostedFile.SaveAs(Server.MapPath(newFileName));
                    ans481.QuestionId = 481;
                    ans481.AnsDes = newFileName;
                    ans481.AnserTypeId = 3;
                    ans481.CreateDate = DateTime.Now;
                    ans481.UserId = user.Id;
                    ans481.AnsMonth = ansMonth; ans481.SRId = sR.Id;
                }
            }




            var ans482 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 2 && x.AnsMonth == ansMonth && x.QuestionId == 482).FirstOrDefault();
            if (ans482 == null)

            {
                //3.รูป SOLAR CELL PICTURE CHECKLISTT :
                if (this.solarcellpictureChecklistImages.HasFile)
                {
                    string extension = this.solarcellpictureChecklistImages.PostedFile.FileName.Split('.')[1];
                    string newFileName = "images/SolarcellPictureChecklist_bb_2_4_" + DateTime.Now.ToString("yyyyMMddHHmmss") + "." + extension;
                    this.solarcellpictureChecklistImages.PostedFile.SaveAs(Server.MapPath(newFileName));

                    Answer answer261 = new Answer()
                    {
                        AnsDes = newFileName,
                        QuestionId = 482,
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
                    string newFileName = "images/SolarcellPictureChecklist_bb_2_4_" + DateTime.Now.ToString("yyyyMMddHHmmss") + "." + extension;
                    this.solarcellpictureChecklistImages.PostedFile.SaveAs(Server.MapPath(newFileName));
                    ans482.QuestionId = 482;
                    ans482.AnsDes = newFileName;
                    ans482.AnserTypeId = 3;
                    ans482.CreateDate = DateTime.Now;
                    ans482.UserId = user.Id;
                    ans482.AnsMonth = ansMonth; ans482.SRId = sR.Id;
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