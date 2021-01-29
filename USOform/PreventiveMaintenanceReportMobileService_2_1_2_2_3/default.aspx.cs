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



namespace USOform
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
                answers = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 1 && x.AnsMonth == ansMonth).ToList();
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

            ///------------------------------------------START   HEADING----------------------------------------------------------------////

            //1: logoPicture
            var ans1408 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1408).FirstOrDefault();
            if (ans1408 == null)

            {
                if (this.logoPicture.HasFile)
                {
                    string extension = this.logoPicture.PostedFile.FileName.Split('.')[1];
                    string newFileName = "images/logoImagesMobileService_" + DateTime.Now.ToString("yyyyMMddHHmmss") + "." + extension;
                    this.logoPicture.PostedFile.SaveAs(Server.MapPath(newFileName));

                    Answer answe1408 = new Answer()
                    {
                        AnsDes = newFileName,
                        QuestionId = 1408,
                        AnserTypeId = 3,
                        CreateDate = DateTime.Now,
                        UserId = user.Id,
                        AnsMonth = ansMonth,
                        SRId = sR.Id
                    };
                    uSOEntities.Answers.Add(answe1408);
                }
            }
            else
            {
                if (this.logoPicture.HasFile)
                {
                    string extension = this.logoPicture.PostedFile.FileName.Split('.')[1];
                    string newFileName = "images/logoImagesMobileService_" + DateTime.Now.ToString("yyyyMMddHHmmss") + "." + extension;
                    this.logoPicture.PostedFile.SaveAs(Server.MapPath(newFileName));
                    ans1408.QuestionId = 1408;
                    ans1408.AnsDes = newFileName;
                    ans1408.AnserTypeId = 3;
                    ans1408.CreateDate = DateTime.Now;
                    ans1408.UserId = user.Id;
                    ans1408.AnsMonth = ansMonth;
                    ans1408.SRId = sR.Id;

                }
            }

            var ans1409 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1409).FirstOrDefault();
            if (ans1409 == null)
            {
                // กลุ่ม
                Answer answer1409 = new Answer()
                {
                    AnsDes = this.groupTextbox.Value,
                    QuestionId = 1409,
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


                ans1409.QuestionId = 1409;
                ans1409.AnsDes = this.groupTextbox.Value;
                ans1409.AnserTypeId = 1;
                ans1409.CreateDate = DateTime.Now;
                ans1409.UserId = user.Id;
                ans1409.AnsMonth = ansMonth;
                ans1409.SRId = sR.Id;


            }


            var ans1410 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1410).FirstOrDefault();
            if (ans1410 == null)
            {
                // ภูมิภาค
                Answer answer1410 = new Answer()
                {
                    AnsDes = this.AreaTextbox.Value,
                    QuestionId = 1410,
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


                ans1410.QuestionId = 1410;
                ans1410.AnsDes = this.AreaTextbox.Value;
                ans1410.AnserTypeId = 1;
                ans1410.CreateDate = DateTime.Now;
                ans1410.UserId = user.Id;
                ans1410.AnsMonth = ansMonth;
                ans1410.SRId = sR.Id;


            }


            var ans1411 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1411).FirstOrDefault();
            if (ans1411 == null)
            {
                // บริษัท
                Answer answer3 = new Answer()
                {
                    QuestionId = 1411,
                    AnsDes = this.CompanyTextbox.Value,
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


                ans1411.QuestionId = 1411;
                ans1411.AnsDes = this.CompanyTextbox.Value;
                ans1411.AnserTypeId = 1;
                ans1411.CreateDate = DateTime.Now;
                ans1411.UserId = user.Id;
                ans1411.AnsMonth = ansMonth;
                ans1411.SRId = sR.Id;


            }



            var ans1412 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1412).FirstOrDefault();
            if (ans1412 == null)
            {

                //  ส่วนที่ 2 การจัดให้มีบริการสัญญาณโทรศัพท์เคลื่อนที่  (Mobile Service) ประเภทบริการ
                string mbService = Request.Form["mobileServiceAtRadio"];
                Answer answer257 = new Answer()
                {
                    AnsDes = mbService,
                    QuestionId = 1412,
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
                string mbService = Request.Form["mobileServiceAtRadio"];

                ans1412.QuestionId = 1412;
                ans1412.AnsDes = mbService;
                ans1412.AnserTypeId = 4;
                ans1412.CreateDate = DateTime.Now;
                ans1412.UserId = user.Id;
                ans1412.AnsMonth = ansMonth;
                ans1412.SRId = sR.Id;


            }


            var ans1413 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1413).FirstOrDefault();
            if (ans1413 == null)
            {
                //รอบการบำรุงรักษาครั้งที่
                Answer answer4 = new Answer()
                {
                    AnsDes = this.maintenanceCountTextbox.Value,
                    QuestionId = 1413,
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


                ans1413.QuestionId = 1413;
                ans1413.AnsDes = this.maintenanceCountTextbox.Value;
                ans1413.AnserTypeId = 1;
                ans1413.CreateDate = DateTime.Now;
                ans1413.UserId = user.Id;
                ans1413.AnsMonth = ansMonth;
                ans1413.SRId = sR.Id;


            }


            var ans1414 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1414).FirstOrDefault();
            if (ans1414 == null)
            {
                //ปีพุทธศักราช
                Answer answer5 = new Answer()
                {
                    AnsDes = this.yearTextbox.Value,
                    QuestionId = 1414,
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


                ans1414.QuestionId = 1414;
                ans1414.AnsDes = this.yearTextbox.Value;
                ans1414.AnserTypeId = 1;
                ans1414.CreateDate = DateTime.Now;
                ans1414.UserId = user.Id;
                ans1414.AnsMonth = ansMonth;
                ans1414.SRId = sR.Id;


            }





            var ans1415 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1415).FirstOrDefault();
            if (ans1415 == null)
            {

                //วัน เดือน ปี ที่เริ่มต้น
                Answer answer8 = new Answer()
                {
                    AnsDes = this.startDatepicker.Value,
                    QuestionId = 1415,
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


                ans1415.QuestionId = 1415;
                ans1415.AnsDes = this.startDatepicker.Value;
                ans1415.AnserTypeId = 1;
                ans1415.CreateDate = DateTime.Now;
                ans1415.UserId = user.Id;
                ans1415.AnsMonth = ansMonth;
                ans1415.SRId = sR.Id;


            }


            var ans1416 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1416).FirstOrDefault();
            if (ans1416 == null)
            {

                //ถึง 
                Answer answer9 = new Answer()
                {
                    AnsDes = this.endDatepicker.Value,
                    QuestionId = 1416,
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


                ans1416.QuestionId = 1416;
                ans1416.AnsDes = this.endDatepicker.Value;
                ans1416.AnserTypeId = 1;
                ans1416.CreateDate = DateTime.Now;
                ans1416.UserId = user.Id;
                ans1416.AnsMonth = ansMonth;
                ans1416.SRId = sR.Id;


            }


            var ans1417 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1417).FirstOrDefault();
            if (ans1417 == null)
            {

                //สถานที่ SITE CODE
                Answer answer10 = new Answer()
                {
                    AnsDes = this.siteCodeTextbox.Value,
                    QuestionId = 1417,
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


                ans1417.QuestionId = 1417;
                ans1417.AnsDes = this.siteCodeTextbox.Value;
                ans1417.AnserTypeId = 1;
                ans1417.CreateDate = DateTime.Now;
                ans1417.UserId = user.Id;
                ans1417.AnsMonth = ansMonth;
                ans1417.SRId = sR.Id;


            }


            ///------------------------------------------END  HEADING----------------------------------------------------------------////





            //////////////////////////////////    Sectionid  = 125    /////////////////////////////////
            ///


            var ans1418 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1418).FirstOrDefault();
            if (ans1418 == null)
            {

                //Cabinet ID:
                Answer answer11 = new Answer()
                {
                    AnsDes = this.cabinetIdTextbox.Value,
                    QuestionId = 1418,
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


                ans1418.QuestionId = 1418;
                ans1418.AnsDes = this.cabinetIdTextbox.Value;
                ans1418.AnserTypeId = 1;
                ans1418.CreateDate = DateTime.Now;
                ans1418.UserId = user.Id;
                ans1418.AnsMonth = ansMonth;
                ans1418.SRId = sR.Id;


            }



            var ans1419 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1419).FirstOrDefault();
            if (ans1419 == null)
            {

                //Site Code :
                Answer answer12 = new Answer()
                {
                    AnsDes = this.sitecodeTextboxSection2.Value,
                    QuestionId = 1419,
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


                ans1419.QuestionId = 1419;
                ans1419.AnsDes = this.sitecodeTextboxSection2.Value;
                ans1419.AnserTypeId = 1;
                ans1419.CreateDate = DateTime.Now;
                ans1419.UserId = user.Id;
                ans1419.AnsMonth = ansMonth;
                ans1419.SRId = sR.Id;


            }


            var ans1420 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1420).FirstOrDefault();
            if (ans1420 == null)
            {

                //Village ID :
                Answer answer13 = new Answer()
                {
                    QuestionId = 1420,
                    AnsDes = this.VillageIdTextbox.Value,
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


                ans1420.QuestionId = 1420;
                ans1420.AnsDes = this.VillageIdTextbox.Value;
                ans1420.AnserTypeId = 1;
                ans1420.CreateDate = DateTime.Now;
                ans1420.UserId = user.Id;
                ans1420.AnsMonth = ansMonth;
                ans1420.SRId = sR.Id;


            }


            var ans1421 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1421).FirstOrDefault();
            if (ans1421 == null)
            {

                //Village  :
                Answer answer14 = new Answer()
                {
                    AnsDes = this.villageTextbox.Value,
                    QuestionId = 1421,
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


                ans1421.QuestionId = 1421;
                ans1421.AnsDes = this.villageTextbox.Value;
                ans1421.AnserTypeId = 1;
                ans1421.CreateDate = DateTime.Now;
                ans1421.UserId = user.Id;
                ans1421.AnsMonth = ansMonth;
                ans1421.SRId = sR.Id;


            }




            var ans1422 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1422).FirstOrDefault();
            if (ans1422 == null)
            {

                //Sub-District :
                Answer answer16 = new Answer()
                {
                    AnsDes = this.subdistrictTextbox.Value,
                    QuestionId = 1422,
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


                ans1422.QuestionId = 1422;
                ans1422.AnsDes = this.subdistrictTextbox.Value;
                ans1422.AnserTypeId = 1;
                ans1422.CreateDate = DateTime.Now;
                ans1422.UserId = user.Id;
                ans1422.AnsMonth = ansMonth;
                ans1422.SRId = sR.Id;


            }


            var ans1423 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1423).FirstOrDefault();
            if (ans1423 == null)
            {

                //District :
                Answer answer1423 = new Answer()
                {
                    AnsDes = this.DistrictTextbox.Value,
                    QuestionId = 1423,
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


                ans1423.QuestionId = 1423;
                ans1423.AnsDes = this.DistrictTextbox.Value;
                ans1423.AnserTypeId = 1;
                ans1423.CreateDate = DateTime.Now;
                ans1423.UserId = user.Id;
                ans1423.AnsMonth = ansMonth;
                ans1423.SRId = sR.Id;


            }


            var ans1424 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1424).FirstOrDefault();
            if (ans1424 == null)
            {
                //Province :
                Answer answer17 = new Answer()
                {
                    AnsDes = this.provinceTextbox.Value,
                    QuestionId = 1424,
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


                ans1424.QuestionId = 1424;
                ans1424.AnsDes = this.provinceTextbox.Value;
                ans1424.AnserTypeId = 1;
                ans1424.CreateDate = DateTime.Now;
                ans1424.UserId = user.Id;
                ans1424.AnsMonth = ansMonth;
                ans1424.SRId = sR.Id;


            }


            var ans1425 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1425).FirstOrDefault();
            if (ans1425 == null)
            {
                //Type :
                Answer answer18 = new Answer()
                {
                    AnsDes = this.typeTextbox.Value,
                    QuestionId = 1425,
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


                ans1425.QuestionId = 1424;
                ans1425.AnsDes = this.typeTextbox.Value;
                ans1425.AnserTypeId = 1;
                ans1425.CreateDate = DateTime.Now;
                ans1425.UserId = user.Id;
                ans1425.AnsMonth = ansMonth;
                ans1425.SRId = sR.Id;


            }




            var ans1426 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1426).FirstOrDefault();
            if (ans1426 == null)
            {
                //PM Date :
                Answer answer19 = new Answer()
                {
                    AnsDes = this.pmdateTextbox.Value,
                    QuestionId = 1426,
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


                ans1426.QuestionId = 1426;
                ans1426.AnsDes = this.pmdateTextbox.Value;
                ans1426.AnserTypeId = 1;
                ans1426.CreateDate = DateTime.Now;
                ans1426.UserId = user.Id;
                ans1426.AnsMonth = ansMonth;
                ans1426.SRId = sR.Id;


            }



            //ใส่รูปหน้าตู้  :
            var ans1427 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1427).FirstOrDefault();
            if (ans1427 == null)

            {
                if (this.picinfrontCabinetImages.HasFile)
                {
                    string extension = this.picinfrontCabinetImages.PostedFile.FileName.Split('.')[1];
                    string newFileName = "images/picinfrontCabinetImages__" + DateTime.Now.ToString("yyyyMMddHHmmss") + "." + extension;
                    this.picinfrontCabinetImages.PostedFile.SaveAs(Server.MapPath(newFileName));

                    Answer answer20 = new Answer()
                    {
                        AnsDes = newFileName,
                        QuestionId = 1427,
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
                if (this.picinfrontCabinetImages.HasFile)
                {
                    string extension = this.picinfrontCabinetImages.PostedFile.FileName.Split('.')[1];
                    string newFileName = "images/logoImagesMobileService_" + DateTime.Now.ToString("yyyyMMddHHmmss") + "." + extension;
                    this.picinfrontCabinetImages.PostedFile.SaveAs(Server.MapPath(newFileName));
                    ans1408.QuestionId = 1427;
                    ans1408.AnsDes = newFileName;
                    ans1408.AnserTypeId = 3;
                    ans1408.CreateDate = DateTime.Now;
                    ans1408.UserId = user.Id;
                    ans1408.AnsMonth = ansMonth;
                    ans1408.SRId = sR.Id;

                }
            }

            //////////////////////////////////   END  Sectionid  = 125    /////////////////////////////////





            //////////////////////////////////    Sectionid  = 126    /////////////////////////////////

            var ans1428 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1428).FirstOrDefault();
            if (ans1428 == null)
            {
                //signature Executor :
                Answer answer21 = new Answer()
                {
                    AnsDes = this.signatureExecutorTextbox.Value,
                    QuestionId = 1428,
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


                ans1428.QuestionId = 1428;
                ans1428.AnsDes = this.signatureExecutorTextbox.Value;
                ans1428.AnserTypeId = 1;
                ans1428.CreateDate = DateTime.Now;
                ans1428.UserId = user.Id;
                ans1428.AnsMonth = ansMonth;
                ans1428.SRId = sR.Id;


            }


            var ans1431 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1431).FirstOrDefault();
            if (ans1431 == null)
            {
                //signature Supervisor :
                Answer answer22 = new Answer()
                {
                    AnsDes = this.signatureSupervisorTextbox.Value,
                    QuestionId = 1431,
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


                ans1431.QuestionId = 1431;
                ans1431.AnsDes = this.signatureSupervisorTextbox.Value;
                ans1431.AnserTypeId = 1;
                ans1431.CreateDate = DateTime.Now;
                ans1431.UserId = user.Id;
                ans1431.AnsMonth = ansMonth;
                ans1431.SRId = sR.Id;


            }





            var ans1432 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1432).FirstOrDefault();
            if (ans1432 == null)
            {
                //name Executor  :
                Answer answer23 = new Answer()
                {
                    AnsDes = this.nameExecutorTextbox.Value,
                    QuestionId = 1432,
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


                ans1432.QuestionId = 1432;
                ans1432.AnsDes = this.nameExecutorTextbox.Value;
                ans1432.AnserTypeId = 1;
                ans1432.CreateDate = DateTime.Now;
                ans1432.UserId = user.Id;
                ans1432.AnsMonth = ansMonth;
                ans1432.SRId = sR.Id;


            }




            var ans1433 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1433).FirstOrDefault();
            if (ans1433 == null)
            {
                //name Supervisor :
                Answer answer24 = new Answer()
                {
                    AnsDes = this.nameSupervisorTextbox.Value,
                    QuestionId = 1433,
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


                ans1433.QuestionId = 1433;
                ans1433.AnsDes = this.nameSupervisorTextbox.Value;
                ans1433.AnserTypeId = 1;
                ans1433.CreateDate = DateTime.Now;
                ans1433.UserId = user.Id;
                ans1433.AnsMonth = ansMonth;
                ans1433.SRId = sR.Id;


            }



            var ans1434 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1434).FirstOrDefault();
            if (ans1434 == null)
            {
                //Date Executor :
                Answer answer25 = new Answer()
                {
                    AnsDes = this.DateExecutorTextbox.Value,
                    QuestionId = 1434,
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


                ans1434.QuestionId = 1434;
                ans1434.AnsDes = this.DateExecutorTextbox.Value;
                ans1434.AnserTypeId = 1;
                ans1434.CreateDate = DateTime.Now;
                ans1434.UserId = user.Id;
                ans1434.AnsMonth = ansMonth;
                ans1434.SRId = sR.Id;


            }




            var ans1435 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1435).FirstOrDefault();
            if (ans1435 == null)
            {
                //Date Supervisor :
                Answer answer26 = new Answer()
                {
                    AnsDes = this.DateSupervisorTextbox.Value,
                    QuestionId = 1435,
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


                ans1435.QuestionId = 1435;
                ans1435.AnsDes = this.DateSupervisorTextbox.Value;
                ans1435.AnserTypeId = 1;
                ans1435.CreateDate = DateTime.Now;
                ans1435.UserId = user.Id;
                ans1435.AnsMonth = ansMonth;
                ans1435.SRId = sR.Id;


            }
            //////////////////////////////////   END  Sectionid  = 126    /////////////////////////////////




            //////////////////////////////////    Sectionid  = 127    /////////////////////////////////


            var ans1436 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1436).FirstOrDefault();
            if (ans1436 == null)
            {

                //Location name :
                Answer answer27 = new Answer()
                {
                    AnsDes = this.cabinetId2Textbox.Value,
                    QuestionId = 1436,
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


                ans1436.QuestionId = 1436;
                ans1436.AnsDes = this.cabinetId2Textbox.Value;
                ans1436.AnserTypeId = 1;
                ans1436.CreateDate = DateTime.Now;
                ans1436.UserId = user.Id;
                ans1436.AnsMonth = ansMonth;
                ans1436.SRId = sR.Id;


            }




            var ans1437 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1437).FirstOrDefault();
            if (ans1437 == null)
            {


                //Site code section 4 :
                Answer answer28 = new Answer()
                {
                    AnsDes = this.sitecodeTextboxSection4.Value,
                    QuestionId = 1437,
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


                ans1437.QuestionId = 1437;
                ans1437.AnsDes = this.sitecodeTextboxSection4.Value;
                ans1437.AnserTypeId = 1;
                ans1437.CreateDate = DateTime.Now;
                ans1437.UserId = user.Id;
                ans1437.AnsMonth = ansMonth;
                ans1437.SRId = sR.Id;


            }


            var ans1438 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1438).FirstOrDefault();
            if (ans1438 == null)
            {


                //villageIDsection 4 :
                Answer answer29 = new Answer()
                {
                    AnsDes = this.villageIDTextboxSection4.Value,
                    QuestionId = 1438,
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


                ans1438.QuestionId = 1438;
                ans1438.AnsDes = this.villageIDTextboxSection4.Value;
                ans1438.AnserTypeId = 1;
                ans1438.CreateDate = DateTime.Now;
                ans1438.UserId = user.Id;
                ans1438.AnsMonth = ansMonth;
                ans1438.SRId = sR.Id;


            }


            var ans1439 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1439).FirstOrDefault();
            if (ans1439 == null)
            {


                //lat and long  :
                Answer answer30 = new Answer()
                {
                    AnsDes = this.latandlongTextbox.Value,
                    QuestionId = 1439,
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


                ans1439.QuestionId = 1439;
                ans1439.AnsDes = this.latandlongTextbox.Value;
                ans1439.AnserTypeId = 1;
                ans1439.CreateDate = DateTime.Now;
                ans1439.UserId = user.Id;
                ans1439.AnsMonth = ansMonth;
                ans1439.SRId = sR.Id;


            }


            var ans1440 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1440).FirstOrDefault();
            if (ans1440 == null)
            {


                //OLT ID (USO Network) or ISP (Existing Network) :
                Answer answer1440 = new Answer()
                {
                    AnsDes = this.oltorispTextbox.Value,
                    QuestionId = 1440,
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


                ans1440.QuestionId = 1440;
                ans1440.AnsDes = this.oltorispTextbox.Value;
                ans1440.AnserTypeId = 1;
                ans1440.CreateDate = DateTime.Now;
                ans1440.UserId = user.Id;
                ans1440.AnsMonth = ansMonth;
                ans1440.SRId = sR.Id;


            }

            //////////////////////////////////  END  Sectionid  = 127    /////////////////////////////////





            //////////////////////////////////    Sectionid  = 128    /////////////////////////////////
            ///


            var ans1441 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1441).FirstOrDefault();
            if (ans1441 == null)
            {


                //ระบบไฟฟ้า :
                string typeOf = Request.Form["voltSystemRadio"];
                Answer answer31 = new Answer()
                {
                    AnsDes = typeOf,
                    QuestionId = 1441,
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
                string typeOf = Request.Form["voltSystemRadio"];

                ans1441.QuestionId = 1441;
                ans1441.AnsDes = typeOf;
                ans1441.AnserTypeId = 1;
                ans1441.CreateDate = DateTime.Now;
                ans1441.UserId = user.Id;
                ans1441.AnsMonth = ansMonth;
                ans1441.SRId = sR.Id;


            }





            var ans1442 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1442).FirstOrDefault();
            if (ans1442 == null)
            {

                //หมายเลขผู้ใช้ไฟ:
                Answer answer1442 = new Answer()
                {
                    AnsDes = this.numberIdTextbox.Value,
                    QuestionId = 1442,
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


                ans1442.QuestionId = 1442;
                ans1442.AnsDes = this.numberIdTextbox.Value;
                ans1442.AnserTypeId = 1;
                ans1442.CreateDate = DateTime.Now;
                ans1442.UserId = user.Id;
                ans1442.AnsMonth = ansMonth;
                ans1442.SRId = sR.Id;


            }



            var ans1443 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1443).FirstOrDefault();
            if (ans1443 == null)
            {


                //หน่วยใช้ไฟไฟ  :
                Answer answer36 = new Answer()
                {
                    AnsDes = this.kwhMeterTextbox.Value,
                    QuestionId = 1443,
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


                ans1443.QuestionId = 1443;
                ans1443.AnsDes = this.kwhMeterTextbox.Value;
                ans1443.AnserTypeId = 1;
                ans1443.CreateDate = DateTime.Now;
                ans1443.UserId = user.Id;
                ans1443.AnsMonth = ansMonth;
                ans1443.SRId = sR.Id;


            }



            var ans1444 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1444).FirstOrDefault();
            if (ans1444 == null)
            {


                //แรงดัน AC (kWh Meter) :
                Answer answer37 = new Answer()
                {
                    AnsDes = this.acvoltTextbox.Value,
                    QuestionId = 1444,
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


                ans1444.QuestionId = 1444;
                ans1444.AnsDes = this.acvoltTextbox.Value;
                ans1444.AnserTypeId = 1;
                ans1444.CreateDate = DateTime.Now;
                ans1444.UserId = user.Id;
                ans1444.AnsMonth = ansMonth;
                ans1444.SRId = sR.Id;


            }




            var ans1445 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1445).FirstOrDefault();
            if (ans1445 == null)
            {


                //กระแส Line AC (kWh Meter) :
                Answer answer38 = new Answer()
                {
                    AnsDes = this.lineAcTextbox.Value,
                    QuestionId = 1445,
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


                ans1445.QuestionId = 1445;
                ans1445.AnsDes = this.lineAcTextbox.Value;
                ans1445.AnserTypeId = 1;
                ans1445.CreateDate = DateTime.Now;
                ans1445.UserId = user.Id;
                ans1445.AnsMonth = ansMonth;
                ans1445.SRId = sR.Id;


            }







            var ans1446 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1446).FirstOrDefault();
            if (ans1446 == null)
            {


                // กระแส Neutron AC(kWh Meter) :          
                Answer answer39 = new Answer()
                {
                    AnsDes = this.neutronAcTextbox.Value,
                    QuestionId = 1446,
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


                ans1446.QuestionId = 1446;
                ans1446.AnsDes = this.neutronAcTextbox.Value;
                ans1446.AnserTypeId = 1;
                ans1446.CreateDate = DateTime.Now;
                ans1446.UserId = user.Id;
                ans1446.AnsMonth = ansMonth;
                ans1446.SRId = sR.Id;


            }







            var ans1447 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1447).FirstOrDefault();
            if (ans1447 == null)
            {


                //สภาพ kWh Meter Radio  :
                string conRadio = Request.Form["conditionRadio"];
                Answer answer40 = new Answer()
                {
                    AnsDes = conRadio,
                    QuestionId = 1447,
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
                string conRadio = Request.Form["conditionRadio"];


                ans1447.QuestionId = 1447;
                ans1447.AnsDes = conRadio;
                ans1447.AnserTypeId = 1;
                ans1447.CreateDate = DateTime.Now;
                ans1447.UserId = user.Id;
                ans1447.AnsMonth = ansMonth;
                ans1447.SRId = sR.Id;


            }



            var ans1448 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1448).FirstOrDefault();
            if (ans1448 == null)
            {

                //สภาพ MDB/ Circuit Breaker Radio  :
                string CircuitBreakerRadio = Request.Form["MDBCircuitBreakerRadio"];
                Answer answer41 = new Answer()
                {
                    AnsDes = CircuitBreakerRadio,
                    QuestionId = 1448,
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
                string CircuitBreakerRadio = Request.Form["MDBCircuitBreakerRadio"];


                ans1448.QuestionId = 1448;
                ans1448.AnsDes = CircuitBreakerRadio;
                ans1448.AnserTypeId = 1;
                ans1448.CreateDate = DateTime.Now;
                ans1448.UserId = user.Id;
                ans1448.AnsMonth = ansMonth;
                ans1448.SRId = sR.Id;


            }

            //////////////////////////////////  END   Sectionid  = 128    /////////////////////////////////






            //////////////////////////////////     Sectionid  = 129    /////////////////////////////////


            var ans1449 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1449).FirstOrDefault();
            if (ans1449 == null)
            {

                //UPS ภายในตู้ Radio  :
                string innerUPS = Request.Form["inupsRadio"];
                Answer answer42 = new Answer()
                {
                    AnsDes = innerUPS,
                    QuestionId = 1449,
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
                string innerUPS = Request.Form["inupsRadio"];


                ans1449.QuestionId = 1449;
                ans1449.AnsDes = innerUPS;
                ans1449.AnserTypeId = 1;
                ans1449.CreateDate = DateTime.Now;
                ans1449.UserId = user.Id;
                ans1449.AnsMonth = ansMonth;
                ans1449.SRId = sR.Id;


            }





            var ans1450 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1450).FirstOrDefault();
            if (ans1450 == null)
            {
                // AC from UPS :          
                Answer answer43 = new Answer()
                {
                    AnsDes = this.acfromupsTextbox.Value,
                    QuestionId = 1450,
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



                ans1450.QuestionId = 1450;
                ans1450.AnsDes = this.acfromupsTextbox.Value;
                ans1450.AnserTypeId = 1;
                ans1450.CreateDate = DateTime.Now;
                ans1450.UserId = user.Id;
                ans1450.AnsMonth = ansMonth;
                ans1450.SRId = sR.Id;


            }





            var ans1451 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1451).FirstOrDefault();
            if (ans1451 == null)
            {
                // กระเเส โหลด :  
                string emergen = Request.Form["voltageLoadRadio"];
                Answer answer45 = new Answer()
                {
                    AnsDes = emergen,
                    QuestionId = 1451,
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
                string emergen = Request.Form["voltageLoadRadio"];


                ans1451.QuestionId = 1451;
                ans1451.AnsDes = emergen;
                ans1451.AnserTypeId = 1;
                ans1451.CreateDate = DateTime.Now;
                ans1451.UserId = user.Id;
                ans1451.AnsMonth = ansMonth;
                ans1451.SRId = sR.Id;


            }




            var ans1452 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1452).FirstOrDefault();
            if (ans1452 == null)
            {

                // ระดับความจุ Battery :  
                string emerbat = Request.Form["batteryCapacityRadio"];
                Answer answer1452 = new Answer()
                {
                    AnsDes = emerbat,
                    QuestionId = 1452,
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
                string emerbat = Request.Form["batteryCapacityRadio"];


                ans1452.QuestionId = 1452;
                ans1452.AnsDes = emerbat;
                ans1452.AnserTypeId = 1;
                ans1452.CreateDate = DateTime.Now;
                ans1452.UserId = user.Id;
                ans1452.AnsMonth = ansMonth;
                ans1452.SRId = sR.Id;


            }








            var ans1453 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1453).FirstOrDefault();
            if (ans1453 == null)
            {

                // UPS MODE :  
                string UPSMODE = Request.Form["upsModeRadio"];
                Answer answer1453 = new Answer()
                {
                    AnsDes = UPSMODE,
                    QuestionId = 1453,
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
                string UPSMODE = Request.Form["upsModeRadio"];


                ans1453.QuestionId = 1453;
                ans1453.AnsDes = UPSMODE;
                ans1453.AnserTypeId = 4;
                ans1453.CreateDate = DateTime.Now;
                ans1453.UserId = user.Id;
                ans1453.AnsMonth = ansMonth;
                ans1453.SRId = sR.Id;


            }







            var ans1454 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1454).FirstOrDefault();
            if (ans1454 == null)
            {

                // การทำงานของระบบไฟสำรอง :  
                string secondFireRadio1 = Request.Form["secondFireRadio"];
                Answer answer1454 = new Answer()
                {
                    AnsDes = secondFireRadio1,
                    QuestionId = 1454,
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
                string secondFireRadio1 = Request.Form["secondFireRadio"];


                ans1454.QuestionId = 1454;
                ans1454.AnsDes = secondFireRadio1;
                ans1454.AnserTypeId = 4;
                ans1454.CreateDate = DateTime.Now;
                ans1454.UserId = user.Id;
                ans1454.AnsMonth = ansMonth;
                ans1454.SRId = sR.Id;


            }



            var ans1455 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1455).FirstOrDefault();
            if (ans1455 == null)
            {

                // สภาพ Battery Bank :  
                string Batterybank = Request.Form["batterybankRadio"];
                Answer answer1455 = new Answer()
                {
                    AnsDes = Batterybank,
                    QuestionId = 1455,
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
                string Batterybank = Request.Form["batterybankRadio"];


                ans1455.QuestionId = 1455;
                ans1455.AnsDes = Batterybank;
                ans1455.AnserTypeId = 4;
                ans1455.CreateDate = DateTime.Now;
                ans1455.UserId = user.Id;
                ans1455.AnsMonth = ansMonth;
                ans1455.SRId = sR.Id;


            }

            //////////////////////////////////  END  Sectionid  = 129    /////////////////////////////////




            //////////////////////////////////    Sectionid  = 130    /////////////////////////////////


            var ans1456 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1456).FirstOrDefault();
            if (ans1456 == null)
            {



                // >ONU/Modem Network :  
                string ONUModemNetwork = Request.Form["ONUModemNetworkRadio"];
                Answer answer1456 = new Answer()
                {
                    AnsDes = ONUModemNetwork,
                    QuestionId = 1456,
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
                string ONUModemNetwork = Request.Form["ONUModemNetworkRadio"];


                ans1456.QuestionId = 1456;
                ans1456.AnsDes = ONUModemNetwork;
                ans1456.AnserTypeId = 4;
                ans1456.CreateDate = DateTime.Now;
                ans1456.UserId = user.Id;
                ans1456.AnsMonth = ansMonth;
                ans1456.SRId = sR.Id;


            }









            var ans1457 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1457).FirstOrDefault();
            if (ans1457 == null)
            {

                // FEMTO :  
                string femto = Request.Form["femToRadio"];
                Answer answer1457 = new Answer()
                {
                    AnsDes = femto,
                    QuestionId = 1457,
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
                string femto = Request.Form["femToRadio"];


                ans1457.QuestionId = 1457;
                ans1457.AnsDes = femto;
                ans1457.AnserTypeId = 4;
                ans1457.CreateDate = DateTime.Now;
                ans1457.UserId = user.Id;
                ans1457.AnsMonth = ansMonth;
                ans1457.SRId = sR.Id;


            }










            var ans1458 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1458).FirstOrDefault();
            if (ans1458 == null)
            {

                // FEMTO answer :  
                string femtoanswer = Request.Form["femToanswerRadio"];
                Answer answer1458 = new Answer()
                {
                    AnsDes = femtoanswer,
                    QuestionId = 1458,
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
                string femtoanswer = Request.Form["femToanswerRadio"];


                ans1458.QuestionId = 1458;
                ans1458.AnsDes = femtoanswer;
                ans1458.AnserTypeId = 4;
                ans1458.CreateDate = DateTime.Now;
                ans1458.UserId = user.Id;
                ans1458.AnsMonth = ansMonth;
                ans1458.SRId = sR.Id;


            }








            var ans1459 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1459).FirstOrDefault();
            if (ans1459 == null)
            {

                // tpower :  
                string tpower = Request.Form["tpowerRadio"];
                Answer answer1459 = new Answer()
                {
                    AnsDes = tpower,
                    QuestionId = 1459,
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
                string tpower = Request.Form["tpowerRadio"];


                ans1459.QuestionId = 1459;
                ans1459.AnsDes = tpower;
                ans1459.AnserTypeId = 4;
                ans1459.CreateDate = DateTime.Now;
                ans1459.UserId = user.Id;
                ans1459.AnsMonth = ansMonth;
                ans1459.SRId = sR.Id;


            }



            var ans1460 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1460).FirstOrDefault();
            if (ans1460 == null)
            {

                // wireingGroundRadio :  
                string wireingGround = Request.Form["wireingGroundRadio"];
                Answer answer1460 = new Answer()
                {
                    AnsDes = wireingGround,
                    QuestionId = 1460,
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
                string variable = Request.Form["wireingGroundRadio"];


                ans1460.QuestionId = 1460;
                ans1460.AnsDes = variable;
                ans1460.AnserTypeId = 4;
                ans1460.CreateDate = DateTime.Now;
                ans1460.UserId = user.Id;
                ans1460.AnsMonth = ansMonth;
                ans1460.SRId = sR.Id;


            }




            var ans1633 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1633).FirstOrDefault();
            if (ans1633 == null)
            {


                // การ Wiring Patch cord และ สาย LAN :  
                string Wirinlan = Request.Form["WirinlanRadio"];
                Answer answer1633 = new Answer()
                {
                    AnsDes = Wirinlan,
                    QuestionId = 1633,
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
                string variable = Request.Form["WirinlanRadio"];


                ans1633.QuestionId = 1633;
                ans1633.AnsDes = variable;
                ans1633.AnserTypeId = 4;
                ans1633.CreateDate = DateTime.Now;
                ans1633.UserId = user.Id;
                ans1633.AnsMonth = ansMonth;
                ans1633.SRId = sR.Id;


            }

            //////////////////////////////////  END  Sectionid  = 130    /////////////////////////////////






            //////////////////////////////////    Sectionid  = 131    /////////////////////////////////

            var ans1461 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1461).FirstOrDefault();
            if (ans1461 == null)
            {
                //ความแข็งแรงจุดต่อ Ground Bar :
                string gb = Request.Form["groundbarRadio"];
                Answer answer57 = new Answer()
                {
                    AnsDes = gb,
                    QuestionId = 1461,
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
                string variable = Request.Form["groundbarRadio"];


                ans1461.QuestionId = 1461;
                ans1461.AnsDes = variable;
                ans1461.AnserTypeId = 4;
                ans1461.CreateDate = DateTime.Now;
                ans1461.UserId = user.Id;
                ans1461.AnsMonth = ansMonth;
                ans1461.SRId = sR.Id;


            }




            var ans1462 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1462).FirstOrDefault();
            if (ans1462 == null)
            {


                //ความแข็งแรงของน็อตขันหางปลาอุปกรณ์ :
                string fishnot = Request.Form["notfishRadio"];
                Answer answer58 = new Answer()
                {
                    AnsDes = fishnot,
                    QuestionId = 1462,
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
                string variable = Request.Form["notfishRadio"];


                ans1462.QuestionId = 1462;
                ans1462.AnsDes = variable;
                ans1462.AnserTypeId = 4;
                ans1462.CreateDate = DateTime.Now;
                ans1462.UserId = user.Id;
                ans1462.AnsMonth = ansMonth;
                ans1462.SRId = sR.Id;


            }





            var ans1463 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1463).FirstOrDefault();
            if (ans1463 == null)
            {
                //สายกราวด์เรียบร้อย ปลอดภัย สมบูรณ์ :
                string ffss = Request.Form["safegroundRadio"];
                Answer answer59 = new Answer()
                {
                    AnsDes = ffss,
                    QuestionId = 1463,
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
                string variable = Request.Form["safegroundRadio"];


                ans1463.QuestionId = 1463;
                ans1463.AnsDes = variable;
                ans1463.AnserTypeId = 4;
                ans1463.CreateDate = DateTime.Now;
                ans1463.UserId = user.Id;
                ans1463.AnsMonth = ansMonth;
                ans1463.SRId = sR.Id;


            }




            var ans1464 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1464).FirstOrDefault();
            if (ans1464 == null)
            {
                //สถานะไฟฟ้ารั่วลง Ground :
                string elecground = Request.Form["brokenElecRadio"];
                Answer answer60 = new Answer()
                {
                    AnsDes = elecground,
                    QuestionId = 1464,
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
                string variable = Request.Form["brokenElecRadio"];


                ans1464.QuestionId = 1463;
                ans1464.AnsDes = variable;
                ans1464.AnserTypeId = 4;
                ans1464.CreateDate = DateTime.Now;
                ans1464.UserId = user.Id;
                ans1464.AnsMonth = ansMonth;
                ans1464.SRId = sR.Id;


            }

            //////////////////////////////////   END Sectionid  = 131    /////////////////////////////////



            //////////////////////////////////    Sectionid  = 132    /////////////////////////////////



            var ans1465 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1465).FirstOrDefault();
            if (ans1465 == null)
            {
                //ป้ายและตัวเลขแสดงชื่อสถานี :
                string signandnumber = Request.Form["signandnumberRadio"];
                Answer answer1465 = new Answer()
                {
                    AnsDes = signandnumber,
                    QuestionId = 1465,
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
                string variable = Request.Form["signandnumberRadio"];


                ans1465.QuestionId = 1465;
                ans1465.AnsDes = variable;
                ans1465.AnserTypeId = 4;
                ans1465.CreateDate = DateTime.Now;
                ans1465.UserId = user.Id;
                ans1465.AnsMonth = ansMonth;
                ans1465.SRId = sR.Id;


            }




            var ans1466 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1466).FirstOrDefault();
            if (ans1466 == null)
            {
                //การติดตั้งและการยึดตู้อุปกรณ์ :
                string inStall = Request.Form["inStallRadio"];
                Answer answer1466 = new Answer()
                {
                    AnsDes = inStall,
                    QuestionId = 1466,
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
                string variable = Request.Form["inStallRadio"];


                ans1466.QuestionId = 1466;
                ans1466.AnsDes = variable;
                ans1466.AnserTypeId = 4;
                ans1466.CreateDate = DateTime.Now;
                ans1466.UserId = user.Id;
                ans1466.AnsMonth = ansMonth;
                ans1466.SRId = sR.Id;


            }



            var ans1467 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1467).FirstOrDefault();
            if (ans1467 == null)
            {

                //เสาไฟฟ้าที่ติดตั้งอุปกรณ์:
                string inStallSat = Request.Form["inStallSatRadio"];
                Answer answer1467 = new Answer()
                {
                    AnsDes = inStallSat,
                    QuestionId = 1467,
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
                string variable = Request.Form["inStallSatRadio"];


                ans1467.QuestionId = 1467;
                ans1467.AnsDes = variable;
                ans1467.AnserTypeId = 4;
                ans1467.CreateDate = DateTime.Now;
                ans1467.UserId = user.Id;
                ans1467.AnsMonth = ansMonth;
                ans1467.SRId = sR.Id;


            }


            var ans1468 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1468).FirstOrDefault();
            if (ans1468 == null)
            {

                //ช่อง Cable Inlet  และความสะอาด :
                string CableInlet = Request.Form["CableInletRadio"];
                Answer answer1468 = new Answer()
                {
                    AnsDes = CableInlet,
                    QuestionId = 1468,
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
                string variable = Request.Form["CableInletRadio"];


                ans1468.QuestionId = 1468;
                ans1468.AnsDes = variable;
                ans1468.AnserTypeId = 4;
                ans1468.CreateDate = DateTime.Now;
                ans1468.UserId = user.Id;
                ans1468.AnsMonth = ansMonth;
                ans1468.SRId = sR.Id;


            }





            var ans1469 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1469).FirstOrDefault();
            if (ans1469 == null)
            {

                //ช่อง Filter ความสะอาด (T-Power:
                string filterRadio = Request.Form["filterRadio"];
                Answer answer1469 = new Answer()
                {
                    AnsDes = filterRadio,
                    QuestionId = 1469,
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
                string variable = Request.Form["filterRadio"];


                ans1469.QuestionId = 1469;
                ans1469.AnsDes = variable;
                ans1469.AnserTypeId = 4;
                ans1469.CreateDate = DateTime.Now;
                ans1469.UserId = user.Id;
                ans1469.AnsMonth = ansMonth;
                ans1469.SRId = sR.Id;


            }




            var ans1470 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1470).FirstOrDefault();
            if (ans1470 == null)
            {
                //ประตูและยางขอบประตูของตู้อุปกรณ์ :
                string doorToolsRadio = Request.Form["doorToolsRadio"];
                Answer answer1470 = new Answer()
                {
                    AnsDes = doorToolsRadio,
                    QuestionId = 1470,
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
                string variable = Request.Form["doorToolsRadio"];
                ans1470.QuestionId = 1470;
                ans1470.AnsDes = variable;
                ans1470.AnserTypeId = 4;
                ans1470.CreateDate = DateTime.Now;
                ans1470.UserId = user.Id;
                ans1470.AnsMonth = ansMonth;
                ans1470.SRId = sR.Id;
            }




            var ans1471 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1471).FirstOrDefault();
            if (ans1471 == null)
            {
                //แนวสายไฟฟ้าและสายเคเบิ้ลเข้าสถานี :
                string cabletoStationRadio = Request.Form["cabletoStationRadio"];
                Answer answer1471 = new Answer()
                {
                    AnsDes = cabletoStationRadio,
                    QuestionId = 1471,
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
                string variable = Request.Form["cabletoStationRadio"];


                ans1471.QuestionId = 1471;
                ans1471.AnsDes = variable;
                ans1471.AnserTypeId = 4;
                ans1471.CreateDate = DateTime.Now;
                ans1471.UserId = user.Id;
                ans1471.AnsMonth = ansMonth;
                ans1471.SRId = sR.Id;


            }

            ////////////////////////////////// END Sectionid  = 132    /////////////////////////////////




            //////////////////////////////////  Sectionid  = 133     /////////////////////////////////

            var ans1472 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1472).FirstOrDefault();
            if (ans1472 == null)
            {
                // อุปกรณ์ LNB/BUC   :
                string tools = Request.Form["toolslnbRadio"];
                Answer answer88 = new Answer()
                {
                    AnsDes = tools,
                    QuestionId = 1472,
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
                string variable = Request.Form["toolslnbRadio"];


                ans1472.QuestionId = 1472;
                ans1472.AnsDes = variable;
                ans1472.AnserTypeId = 4;
                ans1472.CreateDate = DateTime.Now;
                ans1472.UserId = user.Id;
                ans1472.AnsMonth = ansMonth;
                ans1472.SRId = sR.Id;


            }


            var ans1473 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1473).FirstOrDefault();
            if (ans1473 == null)
            {

                // การเก็บสาย RG และการพันหัว   :
                string toolsRG = Request.Form["wiringrgRadio"];
                Answer answer89 = new Answer()
                {
                    AnsDes = toolsRG,
                    QuestionId = 1473,
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
                string variable = Request.Form["wiringrgRadio"];


                ans1473.QuestionId = 1473;
                ans1473.AnsDes = variable;
                ans1473.AnserTypeId = 4;
                ans1473.CreateDate = DateTime.Now;
                ans1473.UserId = user.Id;
                ans1473.AnsMonth = ansMonth;
                ans1473.SRId = sR.Id;


            }




            var ans1474 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1474).FirstOrDefault();
            if (ans1474 == null)
            {
                // ฐานและระดับของเสาจาน  :
                string baseOneiei = Request.Form["baseOnRadio"];
                Answer answer90 = new Answer()
                {
                    AnsDes = baseOneiei,
                    QuestionId = 1474,
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
                string variable = Request.Form["baseOnRadio"];


                ans1474.QuestionId = 1474;
                ans1474.AnsDes = variable;
                ans1474.AnserTypeId = 4;
                ans1474.CreateDate = DateTime.Now;
                ans1474.UserId = user.Id;
                ans1474.AnsMonth = ansMonth;
                ans1474.SRId = sR.Id;


            }




            var ans1475 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1475).FirstOrDefault();
            if (ans1475 == null)
            {
                // >แนว Line Of Sight  :
                string lineOf = Request.Form["xxlineOfsightRadio"];
                Answer answer91 = new Answer()
                {
                    AnsDes = lineOf,
                    QuestionId = 1475,
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
                string variable = Request.Form["xxlineOfsightRadio"];


                ans1475.QuestionId = 1475;
                ans1475.AnsDes = variable;
                ans1475.AnserTypeId = 4;
                ans1475.CreateDate = DateTime.Now;
                ans1475.UserId = user.Id;
                ans1475.AnsMonth = ansMonth;
                ans1475.SRId = sR.Id;


            }



            var ans1476 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1476).FirstOrDefault();
            if (ans1476 == null)
            {
                // แนว Line Of Sight  :
                string clendDish = Request.Form["cleaningDishRadio"];
                Answer answer92 = new Answer()
                {
                    AnsDes = clendDish,
                    QuestionId = 1476,
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
                string variable = Request.Form["cleaningDishRadio"];


                ans1476.QuestionId = 1476;
                ans1476.AnsDes = variable;
                ans1476.AnserTypeId = 4;
                ans1476.CreateDate = DateTime.Now;
                ans1476.UserId = user.Id;
                ans1476.AnsMonth = ansMonth;
                ans1476.SRId = sR.Id;


            }





            var ans1477 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1477).FirstOrDefault();
            if (ans1477 == null)
            {
                // LNB Band Switch  :
                string lnbswitch = Request.Form["lnbbandswitchRadio"];
                Answer answer93 = new Answer()
                {
                    AnsDes = lnbswitch,
                    QuestionId = 1477,
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
                string variable = Request.Form["lnbbandswitchRadio"];


                ans1477.QuestionId = 1477;
                ans1477.AnsDes = variable;
                ans1477.AnserTypeId = 4;
                ans1477.CreateDate = DateTime.Now;
                ans1477.UserId = user.Id;
                ans1477.AnsMonth = ansMonth;
                ans1477.SRId = sR.Id;


            }

            //////////////////////////////////  END Sectionid  = 133     /////////////////////////////////






            //////////////////////////////////   Sectionid  = 134     /////////////////////////////////

            var ans1478 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1478).FirstOrDefault();
            if (ans1478 == null)
            {

                // ระบบ Solar Cell :
                string solarCells = Request.Form["solarcellSystemRadio"];
                Answer answer94 = new Answer()
                {
                    AnsDes = solarCells,
                    QuestionId = 1478,
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
                string variable = Request.Form["solarcellSystemRadio"];


                ans1478.QuestionId = 1478;
                ans1478.AnsDes = variable;
                ans1478.AnserTypeId = 4;
                ans1478.CreateDate = DateTime.Now;
                ans1478.UserId = user.Id;
                ans1478.AnsMonth = ansMonth;
                ans1478.SRId = sR.Id;


            }




            var ans1479 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1479).FirstOrDefault();
            if (ans1479 == null)
            {
                // แผง PV Panel:
                string pv = Request.Form["pvPanelRadio"];
                Answer answer95 = new Answer()
                {
                    AnsDes = pv,
                    QuestionId = 1479,
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
                string variable = Request.Form["pvPanelRadio"];


                ans1479.QuestionId = 1479;
                ans1479.AnsDes = variable;
                ans1479.AnserTypeId = 4;
                ans1479.CreateDate = DateTime.Now;
                ans1479.UserId = user.Id;
                ans1479.AnsMonth = ansMonth;
                ans1479.SRId = sR.Id;


            }







            var ans1480 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1480).FirstOrDefault();
            if (ans1480 == null)
            {
                // อุปกรณ์ Charger :
                string charGer = Request.Form["toolsCharger"];
                Answer answer96 = new Answer()
                {
                    AnsDes = charGer,
                    QuestionId = 1480,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer96);

            }
            else
            {
                string variable = Request.Form["toolsCharger"];


                ans1480.QuestionId = 1480;
                ans1480.AnsDes = variable;
                ans1480.AnserTypeId = 4;
                ans1480.CreateDate = DateTime.Now;
                ans1480.UserId = user.Id;
                ans1480.AnsMonth = ansMonth;
                ans1480.SRId = sR.Id;


            }


            var ans1481 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1481).FirstOrDefault();
            if (ans1481 == null)
            {
                // ความสะอาดแผง PV :
                string cleanPv = Request.Form["cleanIngpvRadio"];
                Answer answer97 = new Answer()
                {
                    AnsDes = cleanPv,
                    QuestionId = 1481,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer97);


            }
            else
            {
                string variable = Request.Form["cleanIngpvRadio"];


                ans1481.QuestionId = 1481;
                ans1481.AnsDes = variable;
                ans1481.AnserTypeId = 4;
                ans1481.CreateDate = DateTime.Now;
                ans1481.UserId = user.Id;
                ans1481.AnsMonth = ansMonth;
                ans1481.SRId = sR.Id;


            }







            var ans1482 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1482).FirstOrDefault();
            if (ans1482 == null)
            {
                // การติดตั้งแผง PV :
                string intPv = Request.Form["installPvRadio"];
                Answer answer98 = new Answer()
                {
                    AnsDes = intPv,
                    QuestionId = 1482,
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
                string variable = Request.Form["installPvRadio"];


                ans1482.QuestionId = 1482;
                ans1482.AnsDes = variable;
                ans1482.AnserTypeId = 4;
                ans1482.CreateDate = DateTime.Now;
                ans1482.UserId = user.Id;
                ans1482.AnsMonth = ansMonth;
                ans1482.SRId = sR.Id;


            }




            var ans1483 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1483).FirstOrDefault();
            if (ans1483 == null)
            {
                // แรงดันไฟจาก Inverter :          
                Answer voltInverterTextbox = new Answer()
                {
                    AnsDes = this.voltInverterTextbox.Value,
                    QuestionId = 1483,
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



                ans1483.QuestionId = 1483;
                ans1483.AnsDes = this.voltInverterTextbox.Value;
                ans1483.AnserTypeId = 1;
                ans1483.CreateDate = DateTime.Now;
                ans1483.UserId = user.Id;
                ans1483.AnsMonth = ansMonth;
                ans1483.SRId = sR.Id;


            }



            var ans1484 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1484).FirstOrDefault();
            if (ans1484 == null)
            {
                // กระแส Load :          
                Answer loadVoltTageTextbox = new Answer()
                {
                    AnsDes = this.loadVoltTageTextbox.Value,
                    QuestionId = 1484,
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



                ans1484.QuestionId = 1484;
                ans1484.AnsDes = this.loadVoltTageTextbox.Value;
                ans1484.AnserTypeId = 1;
                ans1484.CreateDate = DateTime.Now;
                ans1484.UserId = user.Id;
                ans1484.AnsMonth = ansMonth;
                ans1484.SRId = sR.Id;


            }


            var ans1485 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1485).FirstOrDefault();
            if (ans1485 == null)
            {
                // batterry 1 :          
                Answer answer1485 = new Answer()
                {
                    AnsDes = this.batterTextbox1.Value,
                    QuestionId = 1485,
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



                ans1485.QuestionId = 1485;
                ans1485.AnsDes = this.batterTextbox1.Value;
                ans1485.AnserTypeId = 1;
                ans1485.CreateDate = DateTime.Now;
                ans1485.UserId = user.Id;
                ans1485.AnsMonth = ansMonth;
                ans1485.SRId = sR.Id;


            }






            var ans1486 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1486).FirstOrDefault();
            if (ans1486 == null)
            {
                //  batterry 2 :          
                Answer answer1486 = new Answer()
                {
                    AnsDes = this.batterTextbox2.Value,
                    QuestionId = 1486,
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



                ans1486.QuestionId = 1486;
                ans1486.AnsDes = this.batterTextbox2.Value;
                ans1486.AnserTypeId = 1;
                ans1486.CreateDate = DateTime.Now;
                ans1486.UserId = user.Id;
                ans1486.AnsMonth = ansMonth;
                ans1486.SRId = sR.Id;


            }









            var ans1487 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1487).FirstOrDefault();
            if (ans1487 == null)
            {
                // batterry 3 :         
                Answer answer1487 = new Answer()
                {
                    AnsDes = this.batterTextbox3.Value,
                    QuestionId = 1487,
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



                ans1487.QuestionId = 1487;
                ans1487.AnsDes = this.batterTextbox3.Value;
                ans1487.AnserTypeId = 1;
                ans1487.CreateDate = DateTime.Now;
                ans1487.UserId = user.Id;
                ans1487.AnsMonth = ansMonth;
                ans1487.SRId = sR.Id;


            }



            var ans1488 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1488).FirstOrDefault();
            if (ans1488 == null)
            {
                //  batterry 4 :          
                Answer answer1488 = new Answer()
                {
                    AnsDes = this.batterTextbox4.Value,
                    QuestionId = 1488,
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



                ans1488.QuestionId = 1488;
                ans1488.AnsDes = this.batterTextbox4.Value;
                ans1488.AnserTypeId = 1;
                ans1488.CreateDate = DateTime.Now;
                ans1488.UserId = user.Id;
                ans1488.AnsMonth = ansMonth;
                ans1488.SRId = sR.Id;


            }





            var ans1489 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1489).FirstOrDefault();
            if (ans1489 == null)
            {
                // solar cell 2 :
                string solarcellSystemRadio2 = Request.Form["solarcellSystemRadio2"];
                Answer answer1489 = new Answer()
                {
                    AnsDes = solarcellSystemRadio2,
                    QuestionId = 1489,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer1489);

            }
            else
            {
                // solar cell 2 :
                string solarcellSystemRadio2 = Request.Form["solarcellSystemRadio2"];


                ans1489.QuestionId = 1489;
                ans1489.AnsDes = solarcellSystemRadio2;
                ans1489.AnserTypeId = 4;
                ans1489.CreateDate = DateTime.Now;
                ans1489.UserId = user.Id;
                ans1489.AnsMonth = ansMonth;
                ans1489.SRId = sR.Id;


            }

            //////////////////////////////////   END Sectionid  = 134     /////////////////////////////////



            //////////////////////////////////    Sectionid  = 135     /////////////////////////////////
            var ans1490 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1490).FirstOrDefault();
            if (ans1490 == null)
            {

                // Call Test (for Femto) :
                string callTestforfemtoRadio = Request.Form["callTestforfemtoRadio"];
                Answer answer1490 = new Answer()
                {
                    AnsDes = callTestforfemtoRadio,
                    QuestionId = 1490,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer1490);

            }
            else
            {
                // solar cell 2 :
                string varrible = Request.Form["callTestforfemtoRadio"];


                ans1490.QuestionId = 1490;
                ans1490.AnsDes = varrible;
                ans1490.AnserTypeId = 4;
                ans1490.CreateDate = DateTime.Now;
                ans1490.UserId = user.Id;
                ans1490.AnsMonth = ansMonth;
                ans1490.SRId = sR.Id;


            }





            var ans1491 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1491).FirstOrDefault();
            if (ans1491 == null)
            {
                //  Cell ID/Bsrid (for Femto) :          
                Answer answer1491 = new Answer()
                {
                    AnsDes = this.cellIdTextbox.Value,
                    QuestionId = 1491,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer1491);

            }
            else
            {



                ans1491.QuestionId = 1491;
                ans1491.AnsDes = this.cellIdTextbox.Value;
                ans1491.AnserTypeId = 1;
                ans1491.CreateDate = DateTime.Now;
                ans1491.UserId = user.Id;
                ans1491.AnsMonth = ansMonth;
                ans1491.SRId = sR.Id;


            }






            var ans1492 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1492).FirstOrDefault();
            if (ans1492 == null)
            {
                //  Network strength (>= -77.5 dBm) Section 1 :          
                Answer answer1492 = new Answer()
                {
                    AnsDes = this.netWorkstrTextboxS1.Value,
                    QuestionId = 1492,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer1492);

            }
            else
            {



                ans1492.QuestionId = 1492;
                ans1492.AnsDes = this.netWorkstrTextboxS1.Value;
                ans1492.AnserTypeId = 1;
                ans1492.CreateDate = DateTime.Now;
                ans1492.UserId = user.Id;
                ans1492.AnsMonth = ansMonth;
                ans1492.SRId = sR.Id;


            }



            var ans1493 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1493).FirstOrDefault();
            if (ans1493 == null)
            {
                //  Network strength (>= -77.5 dBm) Section 2 :          
                Answer answer1493 = new Answer()
                {
                    AnsDes = this.netWorkstrTextboxS2.Value,
                    QuestionId = 1493,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer1493);

            }
            else
            {



                ans1493.QuestionId = 1493;
                ans1493.AnsDes = this.netWorkstrTextboxS2.Value;
                ans1493.AnserTypeId = 1;
                ans1493.CreateDate = DateTime.Now;
                ans1493.UserId = user.Id;
                ans1493.AnsMonth = ansMonth;
                ans1493.SRId = sR.Id;


            }






            var ans1494 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1494).FirstOrDefault();
            if (ans1494 == null)
            {
                //  Network strength (>= -77.5 dBm) Section 3 :          
                Answer answer1494 = new Answer()
                {
                    AnsDes = this.netWorkstrTextboxS3.Value,
                    QuestionId = 1494,
                    AnserTypeId = 1,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer1494);


            }
            else
            {



                ans1494.QuestionId = 1494;
                ans1494.AnsDes = this.netWorkstrTextboxS3.Value;
                ans1494.AnserTypeId = 1;
                ans1494.CreateDate = DateTime.Now;
                ans1494.UserId = user.Id;
                ans1494.AnsMonth = ansMonth;
                ans1494.SRId = sR.Id;


            }






            var ans1495 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1495).FirstOrDefault();
            if (ans1495 == null)
            {
                // Download (for ONU/VSAT :          
                Answer answer1495 = new Answer()
                {
                    AnsDes = this.dowloadOnuTextbox.Value,
                    QuestionId = 1495,
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



                ans1495.QuestionId = 1495;
                ans1495.AnsDes = this.dowloadOnuTextbox.Value;
                ans1495.AnserTypeId = 1;
                ans1495.CreateDate = DateTime.Now;
                ans1495.UserId = user.Id;
                ans1495.AnsMonth = ansMonth;
                ans1495.SRId = sR.Id;


            }






            var ans1496 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1496).FirstOrDefault();
            if (ans1496 == null)
            {
                // Upload (for ONU/VSAT) :          
                Answer answer1496 = new Answer()
                {
                    AnsDes = this.uploadforOnuTextbox.Value,
                    QuestionId = 1496,
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



                ans1496.QuestionId = 1496;
                ans1496.AnsDes = this.uploadforOnuTextbox.Value;
                ans1496.AnserTypeId = 1;
                ans1496.CreateDate = DateTime.Now;
                ans1496.UserId = user.Id;
                ans1496.AnsMonth = ansMonth;
                ans1496.SRId = sR.Id;


            }



            var ans1497 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1497).FirstOrDefault();
            if (ans1497 == null)
            {
                // Ping Test (for ONU/VSAT) :          
                Answer answer1497 = new Answer()
                {
                    AnsDes = this.pinngtestforOnuTextbox.Value,
                    QuestionId = 1497,
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



                ans1497.QuestionId = 1497;
                ans1497.AnsDes = this.pinngtestforOnuTextbox.Value;
                ans1497.AnserTypeId = 1;
                ans1497.CreateDate = DateTime.Now;
                ans1497.UserId = user.Id;
                ans1497.AnsMonth = ansMonth;
                ans1497.SRId = sR.Id;


            }





            var ans1498 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1498).FirstOrDefault();
            if (ans1498 == null)
            {
                // Download (for Mobile:          
                Answer answer1498 = new Answer()
                {
                    AnsDes = this.dowloadforMobileTextbox.Value,
                    QuestionId = 1498,
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



                ans1498.QuestionId = 1498;
                ans1498.AnsDes = this.dowloadforMobileTextbox.Value;
                ans1498.AnserTypeId = 1;
                ans1498.CreateDate = DateTime.Now;
                ans1498.UserId = user.Id;
                ans1498.AnsMonth = ansMonth;
                ans1498.SRId = sR.Id;


            }





            var ans1499 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1499).FirstOrDefault();
            if (ans1499 == null)
            {
                //  Upload (for Mobile :          
                Answer answer1499 = new Answer()
                {
                    AnsDes = this.uploadforMobileTextbox.Value,
                    QuestionId = 1499,
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



                ans1499.QuestionId = 1499;
                ans1499.AnsDes = this.uploadforMobileTextbox.Value;
                ans1499.AnserTypeId = 1;
                ans1499.CreateDate = DateTime.Now;
                ans1499.UserId = user.Id;
                ans1499.AnsMonth = ansMonth;
                ans1499.SRId = sR.Id;


            }



            var ans1500 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1500).FirstOrDefault();
            if (ans1500 == null)
            {
                // Ping Test(for Mobile)
                Answer answe1500 = new Answer()
                {
                    AnsDes = this.pingtestFormobileTextbox.Value,
                    QuestionId = 1500,
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



                ans1500.QuestionId = 1500;
                ans1500.AnsDes = this.pingtestFormobileTextbox.Value;
                ans1500.AnserTypeId = 1;
                ans1500.CreateDate = DateTime.Now;
                ans1500.UserId = user.Id;
                ans1500.AnsMonth = ansMonth;
                ans1500.SRId = sR.Id;


            }

            //////////////////////////////////   END Sectionid  = 135     /////////////////////////////////





            //////////////////////////////////    Sectionid  = 136     /////////////////////////////////


            var ans1501 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1501).FirstOrDefault();
            if (ans1501 == null)
            {
                //  ปัญหาที่พบ 1 :           
                Answer answer110 = new Answer()
                {
                    AnsDes = this.problemTextbox1.Value,
                    QuestionId = 1501,
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
                ans1501.QuestionId = 1501;
                ans1501.AnsDes = this.problemTextbox1.Value;
                ans1501.AnserTypeId = 1;
                ans1501.CreateDate = DateTime.Now;
                ans1501.UserId = user.Id;
                ans1501.AnsMonth = ansMonth;
                ans1501.SRId = sR.Id;
            }


            var ans1502 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1502).FirstOrDefault();
            if (ans1502 == null)
            {
                //  วิธีแก้ปัญหา 1 :           
                Answer answer111 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox1.Value,
                    QuestionId = 1502,
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
                ans1502.QuestionId = 1502;
                ans1502.AnsDes = this.howtoSolveTextbox1.Value;
                ans1502.AnserTypeId = 1;
                ans1502.CreateDate = DateTime.Now;
                ans1502.UserId = user.Id;
                ans1502.AnsMonth = ansMonth;
                ans1502.SRId = sR.Id;
            }



            var ans1503 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1503).FirstOrDefault();
            if (ans1503 == null)
            {
                //  ปัญหาที่พบ 2 :           
                Answer answer112 = new Answer()
                {
                    AnsDes = this.problemTextbox2.Value,
                    QuestionId = 1503,
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
                ans1503.QuestionId = 1503;
                ans1503.AnsDes = this.problemTextbox2.Value;
                ans1503.AnserTypeId = 1;
                ans1503.CreateDate = DateTime.Now;
                ans1503.UserId = user.Id;
                ans1503.AnsMonth = ansMonth;
                ans1503.SRId = sR.Id;
            }



            var ans1504 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1504).FirstOrDefault();
            if (ans1504 == null)
            {
                //  วิธีแก้ปัญหา 2 :           
                Answer answer113 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox2.Value,
                    QuestionId = 1504,
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
                ans1504.QuestionId = 1504;
                ans1504.AnsDes = this.howtoSolveTextbox2.Value;
                ans1504.AnserTypeId = 1;
                ans1504.CreateDate = DateTime.Now;
                ans1504.UserId = user.Id;
                ans1504.AnsMonth = ansMonth;
                ans1504.SRId = sR.Id;
            }




            var ans1505 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1505).FirstOrDefault();
            if (ans1505 == null)
            {
                //  ปัญหาที่พบ 3 :           
                Answer answer114 = new Answer()
                {
                    AnsDes = this.problemTextbox3.Value,
                    QuestionId = 1505,
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
                ans1505.QuestionId = 1505;
                ans1505.AnsDes = this.problemTextbox3.Value;
                ans1505.AnserTypeId = 1;
                ans1505.CreateDate = DateTime.Now;
                ans1505.UserId = user.Id;
                ans1505.AnsMonth = ansMonth;
                ans1505.SRId = sR.Id;
            }



            var ans1506 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1506).FirstOrDefault();
            if (ans1506 == null)
            {

                //  วิธีแก้ปัญหา 3 :           
                Answer answer115 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox3.Value,
                    QuestionId = 1506,
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
                ans1506.QuestionId = 1506;
                ans1506.AnsDes = this.howtoSolveTextbox3.Value;
                ans1506.AnserTypeId = 1;
                ans1506.CreateDate = DateTime.Now;
                ans1506.UserId = user.Id;
                ans1506.AnsMonth = ansMonth;
                ans1506.SRId = sR.Id;
            }




            var ans1507 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1507).FirstOrDefault();
            if (ans1507 == null)
            {


                //  ปัญหาที่พบ 4 :           
                Answer answer116 = new Answer()
                {
                    AnsDes = this.problemTextbox4.Value,
                    QuestionId = 1507,
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
                ans1507.QuestionId = 1507;
                ans1507.AnsDes = this.problemTextbox4.Value;
                ans1507.AnserTypeId = 1;
                ans1507.CreateDate = DateTime.Now;
                ans1507.UserId = user.Id;
                ans1507.AnsMonth = ansMonth;
                ans1507.SRId = sR.Id;
            }


            var ans1508 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1508).FirstOrDefault();
            if (ans1508 == null)
            {
                //  วิธีแก้ปัญหา 4 :           
                Answer answer117 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox4.Value,
                    QuestionId = 1508,
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
                ans1508.QuestionId = 1508;
                ans1508.AnsDes = this.howtoSolveTextbox4.Value;
                ans1508.AnserTypeId = 1;
                ans1508.CreateDate = DateTime.Now;
                ans1508.UserId = user.Id;
                ans1508.AnsMonth = ansMonth;
                ans1508.SRId = sR.Id;
            }







            var ans1509 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1509).FirstOrDefault();
            if (ans1509 == null)
            {

                //  ปัญหาที่พบ 5 :           
                Answer answer118 = new Answer()
                {
                    AnsDes = this.problemTextbox5.Value,
                    QuestionId = 1509,
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
                ans1509.QuestionId = 1509;
                ans1509.AnsDes = this.problemTextbox5.Value;
                ans1509.AnserTypeId = 1;
                ans1509.CreateDate = DateTime.Now;
                ans1509.UserId = user.Id;
                ans1509.AnsMonth = ansMonth;
                ans1509.SRId = sR.Id;
            }




            var ans1510 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1510).FirstOrDefault();
            if (ans1510 == null)
            {                    
               //  วิธีแก้ปัญหา 5 :           
                Answer answer119 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox5.Value,
                    QuestionId = 1510,
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
                ans1510.QuestionId = 1510;
                ans1510.AnsDes = this.howtoSolveTextbox5.Value;
                ans1510.AnserTypeId = 1;
                ans1510.CreateDate = DateTime.Now;
                ans1510.UserId = user.Id;
                ans1510.AnsMonth = ansMonth;
                ans1510.SRId = sR.Id;
            }



            var ans1511 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1511).FirstOrDefault();
            if (ans1511 == null)
            {

                //  ปัญหาที่พบ 6 :           
                Answer answer120 = new Answer()
                {
                    AnsDes = this.problemTextbox6.Value,
                    QuestionId = 1511,
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
                ans1511.QuestionId = 1511;
                ans1511.AnsDes = this.problemTextbox6.Value;
                ans1511.AnserTypeId = 1;
                ans1511.CreateDate = DateTime.Now;
                ans1511.UserId = user.Id;
                ans1511.AnsMonth = ansMonth;
                ans1511.SRId = sR.Id;
            }





            var ans1512 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1512).FirstOrDefault();
            if (ans1512 == null)
            {

                //  วิธีแก้ปัญหา 6 :           
                Answer answer121 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox6.Value,
                    QuestionId = 1512,
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
                ans1512.QuestionId = 1512;
                ans1512.AnsDes = this.howtoSolveTextbox6.Value;
                ans1512.AnserTypeId = 1;
                ans1512.CreateDate = DateTime.Now;
                ans1512.UserId = user.Id;
                ans1512.AnsMonth = ansMonth;
                ans1512.SRId = sR.Id;
            }







            var ans1513 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1513).FirstOrDefault();
            if (ans1513 == null)
            {


                //  ปัญหาที่พบ 7 :           
                Answer answer122 = new Answer()
                {
                    AnsDes = this.problemTextbox7.Value,
                    QuestionId = 1513,
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
                ans1513.QuestionId = 1513;
                ans1513.AnsDes = this.problemTextbox7.Value;
                ans1513.AnserTypeId = 1;
                ans1513.CreateDate = DateTime.Now;
                ans1513.UserId = user.Id;
                ans1513.AnsMonth = ansMonth;
                ans1513.SRId = sR.Id;
            }








            var ans1514 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1514).FirstOrDefault();
            if (ans1514 == null)
            {


                //  วิธีแก้ปัญหา 7 :           
                Answer answer123 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox7.Value,
                    QuestionId = 1514,
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
                ans1514.QuestionId = 1514;
                ans1514.AnsDes = this.howtoSolveTextbox7.Value;
                ans1514.AnserTypeId = 1;
                ans1514.CreateDate = DateTime.Now;
                ans1514.UserId = user.Id;
                ans1514.AnsMonth = ansMonth;
                ans1514.SRId = sR.Id;
            }









            var ans1515 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1515).FirstOrDefault();
            if (ans1515 == null)
            {
                //  ปัญหาที่พบ 8 :           
                Answer answer124 = new Answer()
                {
                    AnsDes = this.problemTextbox8.Value,
                    QuestionId = 1515,
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
                ans1515.QuestionId = 1515;
                ans1515.AnsDes = this.problemTextbox8.Value;
                ans1515.AnserTypeId = 1;
                ans1515.CreateDate = DateTime.Now;
                ans1515.UserId = user.Id;
                ans1515.AnsMonth = ansMonth;
                ans1515.SRId = sR.Id;
            }





            var ans1516 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1516).FirstOrDefault();
            if (ans1516 == null)
            {
                //  วิธีแก้ปัญหา 8 :           
                Answer answer125 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox8.Value,
                    QuestionId = 1516,
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
                ans1516.QuestionId = 1516;
                ans1516.AnsDes = this.howtoSolveTextbox8.Value;
                ans1516.AnserTypeId = 1;
                ans1516.CreateDate = DateTime.Now;
                ans1516.UserId = user.Id;
                ans1516.AnsMonth = ansMonth;
                ans1516.SRId = sR.Id;
            }



            var ans1517 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1517).FirstOrDefault();
            if (ans1517 == null)
            {

                //  ปัญหาที่พบ 9 :           
                Answer answer126 = new Answer()
                {
                    AnsDes = this.problemTextbox9.Value,
                    QuestionId = 1517,
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
                ans1517.QuestionId = 1517;
                ans1517.AnsDes = this.problemTextbox9.Value;
                ans1517.AnserTypeId = 1;
                ans1517.CreateDate = DateTime.Now;
                ans1517.UserId = user.Id;
                ans1517.AnsMonth = ansMonth;
                ans1517.SRId = sR.Id;
            }



            var ans1518 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1518).FirstOrDefault();
            if (ans1518 == null)
            {

                //  วิธีแก้ปัญหา 9 :           
                Answer answer127 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox9.Value,
                    QuestionId = 1518,
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
                ans1518.QuestionId = 1518;
                ans1518.AnsDes = this.howtoSolveTextbox9.Value;
                ans1518.AnserTypeId = 1;
                ans1518.CreateDate = DateTime.Now;
                ans1518.UserId = user.Id;
                ans1518.AnsMonth = ansMonth;
                ans1518.SRId = sR.Id;
            }






            var ans1519 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1519).FirstOrDefault();
            if (ans1519 == null)
            {

                //  ปัญหาที่พบ 10 :           
                Answer answer128 = new Answer()
                {
                    AnsDes = this.problemTextbox10.Value,
                    QuestionId = 1519,
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
                ans1519.QuestionId = 1519;
                ans1519.AnsDes = this.problemTextbox10.Value;
                ans1519.AnserTypeId = 1;
                ans1519.CreateDate = DateTime.Now;
                ans1519.UserId = user.Id;
                ans1519.AnsMonth = ansMonth;
                ans1519.SRId = sR.Id;
            }





            var ans1520 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1520).FirstOrDefault();
            if (ans1520 == null)
            {

                //  วิธีแก้ปัญหา 10 :           
                Answer answer129 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox10.Value,
                    QuestionId = 1520,
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
                ans1520.QuestionId = 1520;
                ans1520.AnsDes = this.howtoSolveTextbox10.Value;
                ans1520.AnserTypeId = 1;
                ans1520.CreateDate = DateTime.Now;
                ans1520.UserId = user.Id;
                ans1520.AnsMonth = ansMonth;
                ans1520.SRId = sR.Id;
            }




            var ans1521 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1521).FirstOrDefault();
            if (ans1521 == null)
            {
                //  ปัญหาที่พบ 11 :           
                Answer answer130 = new Answer()
                {
                    AnsDes = this.problemTextbox11.Value,
                    QuestionId = 1521,
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
                ans1521.QuestionId = 1521;
                ans1521.AnsDes = this.problemTextbox11.Value;
                ans1521.AnserTypeId = 1;
                ans1521.CreateDate = DateTime.Now;
                ans1521.UserId = user.Id;
                ans1521.AnsMonth = ansMonth;
                ans1521.SRId = sR.Id;
            }





            var ans1522 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1522).FirstOrDefault();
            if (ans1522 == null)
            {
                //  วิธีแก้ปัญหา 11 :           
                Answer answer131 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox11.Value,
                    QuestionId = 1522,
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
                ans1522.QuestionId = 1522;
                ans1522.AnsDes = this.howtoSolveTextbox11.Value;
                ans1522.AnserTypeId = 1;
                ans1522.CreateDate = DateTime.Now;
                ans1522.UserId = user.Id;
                ans1522.AnsMonth = ansMonth;
                ans1522.SRId = sR.Id;
            }




            var ans1523 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1523).FirstOrDefault();
            if (ans1523 == null)
            {
                //  ปัญหาที่พบ 12 :           
                Answer answer132 = new Answer()
                {
                    AnsDes = this.problemTextbox12.Value,
                    QuestionId = 1523,
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
                ans1523.QuestionId = 1523;
                ans1523.AnsDes = this.problemTextbox12.Value;
                ans1523.AnserTypeId = 1;
                ans1523.CreateDate = DateTime.Now;
                ans1523.UserId = user.Id;
                ans1523.AnsMonth = ansMonth;
                ans1523.SRId = sR.Id;
            }




            var ans1524 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1524).FirstOrDefault();
            if (ans1524 == null)
            {
                //  วิธีแก้ปัญหา 12 :           
                Answer answer133 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox12.Value,
                    QuestionId = 1524,
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
                ans1524.QuestionId = 1524;
                ans1524.AnsDes = this.howtoSolveTextbox12.Value;
                ans1524.AnserTypeId = 1;
                ans1524.CreateDate = DateTime.Now;
                ans1524.UserId = user.Id;
                ans1524.AnsMonth = ansMonth;
                ans1524.SRId = sR.Id;
            }


            var ans1525 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1525).FirstOrDefault();
            if (ans1525 == null)
            {
                //  ปัญหาที่พบ 13 :           
                Answer answer134 = new Answer()
                {
                    AnsDes = this.problemTextbox13.Value,
                    QuestionId = 1525,
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
                ans1525.QuestionId = 1525;
                ans1525.AnsDes = this.problemTextbox13.Value;
                ans1525.AnserTypeId = 1;
                ans1525.CreateDate = DateTime.Now;
                ans1525.UserId = user.Id;
                ans1525.AnsMonth = ansMonth;
                ans1525.SRId = sR.Id;
            }



            var ans1526 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1526).FirstOrDefault();
            if (ans1526 == null)
            {
                //  วิธีแก้ปัญหา 13 :           
                Answer answer135 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox13.Value,
                    QuestionId = 1526,
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
                ans1526.QuestionId = 1526;
                ans1526.AnsDes = this.howtoSolveTextbox13.Value;
                ans1526.AnserTypeId = 1;
                ans1526.CreateDate = DateTime.Now;
                ans1526.UserId = user.Id;
                ans1526.AnsMonth = ansMonth;
                ans1526.SRId = sR.Id;
            }




            var ans1527 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1527).FirstOrDefault();
            if (ans1527 == null)
            {

                //  ปัญหาที่พบ 14 :           
                Answer answer136 = new Answer()
                {
                    AnsDes = this.problemTextbox14.Value,
                    QuestionId = 1527,
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
                ans1527.QuestionId = 1527;
                ans1527.AnsDes = this.problemTextbox14.Value;
                ans1527.AnserTypeId = 1;
                ans1527.CreateDate = DateTime.Now;
                ans1527.UserId = user.Id;
                ans1527.AnsMonth = ansMonth;
                ans1527.SRId = sR.Id;
            }



            var ans1528 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1528).FirstOrDefault();
            if (ans1528 == null)
            {

                //  วิธีแก้ปัญหา 14 :           
                Answer answer137 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox14.Value,
                    QuestionId = 1528,
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
                ans1528.QuestionId = 1528;
                ans1528.AnsDes = this.howtoSolveTextbox14.Value;
                ans1528.AnserTypeId = 1;
                ans1528.CreateDate = DateTime.Now;
                ans1528.UserId = user.Id;
                ans1528.AnsMonth = ansMonth;
                ans1528.SRId = sR.Id;
            }




            var ans1529 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1529).FirstOrDefault();
            if (ans1529 == null)
            {
                //  ปัญหาที่พบ 15 :           
                Answer answer138 = new Answer()
                {
                    AnsDes = this.problemTextbox15.Value,
                    QuestionId = 1529,
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
                ans1529.QuestionId = 1529;
                ans1529.AnsDes = this.problemTextbox15.Value;
                ans1529.AnserTypeId = 1;
                ans1529.CreateDate = DateTime.Now;
                ans1529.UserId = user.Id;
                ans1529.AnsMonth = ansMonth;
                ans1529.SRId = sR.Id;
            }




            var ans1530 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1530).FirstOrDefault();
            if (ans1530 == null)
            {

                //  วิธีแก้ปัญหา 15 :           
                Answer answer139 = new Answer()
                {
                    AnsDes = this.howtoSolveTextbox15.Value,
                    QuestionId = 1530,
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
                ans1530.QuestionId = 1530;
                ans1530.AnsDes = this.howtoSolveTextbox15.Value;
                ans1530.AnserTypeId = 1;
                ans1530.CreateDate = DateTime.Now;
                ans1530.UserId = user.Id;
                ans1530.AnsMonth = ansMonth;
                ans1530.SRId = sR.Id;
            }

            //////////////////////////////////    END Sectionid  = 136     /////////////////////////////////













            //////////////////////////////////     Sectionid  = 137     /////////////////////////////////          

            var ans1531 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1531).FirstOrDefault();
            if (ans1531 == null)
            {


                // รายการอุปกรณ์ 1 :      
                Answer answer141 = new Answer()
                {
                    AnsDes = this.toolsListTextbox1.Value,
                    QuestionId = 1531,
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
                ans1531.QuestionId = 1531;
                ans1531.AnsDes = this.toolsListTextbox1.Value;
                ans1531.AnserTypeId = 1;
                ans1531.CreateDate = DateTime.Now;
                ans1531.UserId = user.Id;
                ans1531.AnsMonth = ansMonth;
                ans1531.SRId = sR.Id;
            }





            var ans1532 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1532).FirstOrDefault();
            if (ans1532 == null)
            {
                //  SerialNumber :           
                Answer answer142 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox1.Value,
                    QuestionId = 1532,
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
                ans1532.QuestionId = 1532;
                ans1532.AnsDes = this.serialNumberTextbox1.Value;
                ans1532.AnserTypeId = 1;
                ans1532.CreateDate = DateTime.Now;
                ans1532.UserId = user.Id;
                ans1532.AnsMonth = ansMonth;
                ans1532.SRId = sR.Id;
            }




            var ans1533 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1533).FirstOrDefault();
            if (ans1533 == null)
            {

                //  new SerialNumber :           
                Answer answer143 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox1.Value,
                    QuestionId = 1533,
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
                ans1533.QuestionId = 1533;
                ans1533.AnsDes = this.newSerialNumberTextbox1.Value;
                ans1533.AnserTypeId = 1;
                ans1533.CreateDate = DateTime.Now;
                ans1533.UserId = user.Id;
                ans1533.AnsMonth = ansMonth;
                ans1533.SRId = sR.Id;
            }





            var ans1534 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1534).FirstOrDefault();
            if (ans1534 == null)
            {

                //  หมายเหตุ :           
                Answer answer144 = new Answer()
                {
                    AnsDes = this.noteTextbox1.Value,
                    QuestionId = 1534,
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
                ans1534.QuestionId = 1534;
                ans1534.AnsDes = this.noteTextbox1.Value;
                ans1534.AnserTypeId = 1;
                ans1534.CreateDate = DateTime.Now;
                ans1534.UserId = user.Id;
                ans1534.AnsMonth = ansMonth;
                ans1534.SRId = sR.Id;
            }




            var ans1535 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1535).FirstOrDefault();
            if (ans1535 == null)
            {
                // รายการอุปกรณ์ 2 :      
                Answer answer145 = new Answer()
                {
                    AnsDes = this.toolsListTextbox2.Value,
                    QuestionId = 1535,
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
                ans1535.QuestionId = 1535;
                ans1535.AnsDes = this.toolsListTextbox2.Value;
                ans1535.AnserTypeId = 1;
                ans1535.CreateDate = DateTime.Now;
                ans1535.UserId = user.Id;
                ans1535.AnsMonth = ansMonth;
                ans1535.SRId = sR.Id;
            }








            var ans1536 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1536).FirstOrDefault();
            if (ans1536 == null)
            {

                //  SerialNumber 2 :           
                Answer answer146 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox2.Value,
                    QuestionId = 1536,
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
                ans1536.QuestionId = 1536;
                ans1536.AnsDes = this.serialNumberTextbox2.Value;
                ans1536.AnserTypeId = 1;
                ans1536.CreateDate = DateTime.Now;
                ans1536.UserId = user.Id;
                ans1536.AnsMonth = ansMonth;
                ans1536.SRId = sR.Id;
            }





            var ans1537 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1537).FirstOrDefault();
            if (ans1537 == null)
            {

                //  new SerialNumber 2 :           
                Answer answer147 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox2.Value,
                    QuestionId = 1537,
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
                ans1537.QuestionId = 1537;
                ans1537.AnsDes = this.newSerialNumberTextbox2.Value;
                ans1537.AnserTypeId = 1;
                ans1537.CreateDate = DateTime.Now;
                ans1537.UserId = user.Id;
                ans1537.AnsMonth = ansMonth;
                ans1537.SRId = sR.Id;
            }



            var ans1538 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1538).FirstOrDefault();
            if (ans1538 == null)
            {


                //  หมายเหตุ  2:           
                Answer answer148 = new Answer()
                {
                    AnsDes = this.noteTextbox2.Value,
                    QuestionId = 1538,
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
                ans1538.QuestionId = 1538;
                ans1538.AnsDes = this.noteTextbox2.Value;
                ans1538.AnserTypeId = 1;
                ans1538.CreateDate = DateTime.Now;
                ans1538.UserId = user.Id;
                ans1538.AnsMonth = ansMonth;
                ans1538.SRId = sR.Id;
            }




            var ans1539 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1539).FirstOrDefault();
            if (ans1539 == null)
            {
                // รายการอุปกรณ์ 3 :      
                Answer answer149 = new Answer()
                {
                    AnsDes = this.toolsListTextbox3.Value,
                    QuestionId = 1539,
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
                ans1539.QuestionId = 1539;
                ans1539.AnsDes = this.toolsListTextbox3.Value;
                ans1539.AnserTypeId = 1;
                ans1539.CreateDate = DateTime.Now;
                ans1539.UserId = user.Id;
                ans1539.AnsMonth = ansMonth;
                ans1539.SRId = sR.Id;
            }



            var ans1540 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1540).FirstOrDefault();
            if (ans1540 == null)
            {
                //  SerialNumber 3 :           
                Answer answer150 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox3.Value,
                    QuestionId = 1540,
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
                ans1540.QuestionId = 1540;
                ans1540.AnsDes = this.serialNumberTextbox3.Value;
                ans1540.AnserTypeId = 1;
                ans1540.CreateDate = DateTime.Now;
                ans1540.UserId = user.Id;
                ans1540.AnsMonth = ansMonth;
                ans1540.SRId = sR.Id;
            }


            var ans1541 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1541).FirstOrDefault();
            if (ans1541 == null)
            {

                //  new SerialNumber 3 :           
                Answer answer151 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox3.Value,
                    QuestionId = 1541,
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
                ans1541.QuestionId = 1541;
                ans1541.AnsDes = this.newSerialNumberTextbox3.Value;
                ans1541.AnserTypeId = 1;
                ans1541.CreateDate = DateTime.Now;
                ans1541.UserId = user.Id;
                ans1541.AnsMonth = ansMonth;
                ans1541.SRId = sR.Id;
            }






            var ans1542 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1542).FirstOrDefault();
            if (ans1542 == null)
            {

                //  หมายเหตุ  3:           
                Answer answer152 = new Answer()
                {
                    AnsDes = this.noteTextbox3.Value,
                    QuestionId = 1542,
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
                ans1542.QuestionId = 1542;
                ans1542.AnsDes = this.noteTextbox3.Value;
                ans1542.AnserTypeId = 1;
                ans1542.CreateDate = DateTime.Now;
                ans1542.UserId = user.Id;
                ans1542.AnsMonth = ansMonth;
                ans1542.SRId = sR.Id;
            }






                var ans1543 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1543).FirstOrDefault();
                if (ans1543 == null)
                {

                    // รายการอุปกรณ์ 4 :      
                    Answer answer153 = new Answer()
                    {
                        AnsDes = this.toolsListTextbox4.Value,
                        QuestionId = 1543,
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
                    ans1543.QuestionId = 1543;
                    ans1543.AnsDes = this.toolsListTextbox4.Value;
                    ans1543.AnserTypeId = 1;
                    ans1543.CreateDate = DateTime.Now;
                    ans1543.UserId = user.Id;
                    ans1543.AnsMonth = ansMonth;
                    ans1543.SRId = sR.Id;


                }


                var ans1544 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1544).FirstOrDefault();
                if (ans1544 == null)
                {

                    //  SerialNumber 4 :           
                    Answer answer154 = new Answer()
                    {
                        AnsDes = this.serialNumberTextbox4.Value,
                        QuestionId = 1544,
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
                    ans1544.QuestionId = 1544;
                    ans1544.AnsDes = this.serialNumberTextbox4.Value;
                    ans1544.AnserTypeId = 1;
                    ans1544.CreateDate = DateTime.Now;
                    ans1544.UserId = user.Id;
                    ans1544.AnsMonth = ansMonth;
                    ans1544.SRId = sR.Id;
                }


            var ans1545 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1545).FirstOrDefault();
            if (ans1545 == null)
            {

                //  new SerialNumber 4 :           
                Answer answer155 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox4.Value,
                    QuestionId = 1545,
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
                ans1545.QuestionId = 1545;
                ans1545.AnsDes = this.newSerialNumberTextbox4.Value;
                ans1545.AnserTypeId = 1;
                ans1545.CreateDate = DateTime.Now;
                ans1545.UserId = user.Id;
                ans1545.AnsMonth = ansMonth;
                ans1545.SRId = sR.Id;
            }



            var ans1546 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1546).FirstOrDefault();
            if (ans1546 == null)
            {

                //  หมายเหตุ  4:           
                Answer answer156 = new Answer()
                {
                    AnsDes = this.noteTextbox4.Value,
                    QuestionId = 1546,
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
                ans1546.QuestionId = 1546;
                ans1546.AnsDes = this.noteTextbox4.Value;
                ans1546.AnserTypeId = 1;
                ans1546.CreateDate = DateTime.Now;
                ans1546.UserId = user.Id;
                ans1546.AnsMonth = ansMonth;
                ans1546.SRId = sR.Id;
            }




            var ans1547 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1547).FirstOrDefault();
            if (ans1547 == null)
            {

                // รายการอุปกรณ์ 5 :      
                Answer answer157 = new Answer()
                {
                    AnsDes = this.toolsListTextbox5.Value,
                    QuestionId = 1547,
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
                ans1547.QuestionId = 1547;
                ans1547.AnsDes = this.toolsListTextbox5.Value;
                ans1547.AnserTypeId = 1;
                ans1547.CreateDate = DateTime.Now;
                ans1547.UserId = user.Id;
                ans1547.AnsMonth = ansMonth;
                ans1547.SRId = sR.Id;
            }


            var ans1548 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1548).FirstOrDefault();
            if (ans1548 == null)
            {

                //  SerialNumber 5 :           
                Answer answer158 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox5.Value,
                    QuestionId = 1548,
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
                ans1548.QuestionId = 1548;
                ans1548.AnsDes = this.serialNumberTextbox5.Value;
                ans1548.AnserTypeId = 1;
                ans1548.CreateDate = DateTime.Now;
                ans1548.UserId = user.Id;
                ans1548.AnsMonth = ansMonth;
                ans1548.SRId = sR.Id;
            }



            var ans1549 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1549).FirstOrDefault();
            if (ans1549 == null)
            {

                //  new SerialNumber 5 :           
                Answer answer159 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox5.Value,
                    QuestionId = 1549,
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
                ans1549.QuestionId = 1549;
                ans1549.AnsDes = this.newSerialNumberTextbox5.Value;
                ans1549.AnserTypeId = 1;
                ans1549.CreateDate = DateTime.Now;
                ans1549.UserId = user.Id;
                ans1549.AnsMonth = ansMonth;
                ans1549.SRId = sR.Id;
            }


            var ans1550 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1550).FirstOrDefault();
            if (ans1550 == null)
            {

                //  หมายเหตุ  5:           
                Answer answer160 = new Answer()
                {
                    AnsDes = this.noteTextbox5.Value,
                    QuestionId = 1550,
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
                ans1550.QuestionId = 1550;
                ans1550.AnsDes = this.noteTextbox5.Value;
                ans1550.AnserTypeId = 1;
                ans1550.CreateDate = DateTime.Now;
                ans1550.UserId = user.Id;
                ans1550.AnsMonth = ansMonth;
                ans1550.SRId = sR.Id;
            }





            var ans1551 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1551).FirstOrDefault();
            if (ans1551 == null)
            {

                // รายการอุปกรณ์ 6 :      
                Answer answer161 = new Answer()
                {
                    AnsDes = this.toolsListTextbox6.Value,
                    QuestionId = 1551,
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
                ans1551.QuestionId = 1551;
                ans1551.AnsDes = this.toolsListTextbox6.Value;
                ans1551.AnserTypeId = 1;
                ans1551.CreateDate = DateTime.Now;
                ans1551.UserId = user.Id;
                ans1551.AnsMonth = ansMonth;
                ans1551.SRId = sR.Id;
            }



            var ans1552 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1552).FirstOrDefault();
            if (ans1552 == null)
            {

                //  SerialNumber 6 :           
                Answer answer162 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox6.Value,
                    QuestionId = 1552,
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
                ans1552.QuestionId = 1552;
                ans1552.AnsDes = this.serialNumberTextbox6.Value;
                ans1552.AnserTypeId = 1;
                ans1552.CreateDate = DateTime.Now;
                ans1552.UserId = user.Id;
                ans1552.AnsMonth = ansMonth;
                ans1552.SRId = sR.Id;
            }






            var ans1553 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1553).FirstOrDefault();
            if (ans1553 == null)
            {

                //  new SerialNumber 6 :           
                Answer answer163 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox6.Value,
                    QuestionId = 1553,
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
                ans1553.QuestionId = 1553;
                ans1553.AnsDes = this.newSerialNumberTextbox6.Value;
                ans1553.AnserTypeId = 1;
                ans1553.CreateDate = DateTime.Now;
                ans1553.UserId = user.Id;
                ans1553.AnsMonth = ansMonth;
                ans1553.SRId = sR.Id;
            }






            var ans1554 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1554).FirstOrDefault();
            if (ans1554 == null)
            {
                //  หมายเหตุ  6:           
                Answer answer164 = new Answer()
                {
                    AnsDes = this.noteTextbox6.Value,
                    QuestionId = 1554,
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
                ans1554.QuestionId = 1554;
                ans1554.AnsDes = this.noteTextbox6.Value;
                ans1554.AnserTypeId = 1;
                ans1554.CreateDate = DateTime.Now;
                ans1554.UserId = user.Id;
                ans1554.AnsMonth = ansMonth;
                ans1554.SRId = sR.Id;
            }



            var ans1555 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1555).FirstOrDefault();
            if (ans1555 == null)
            {
                // รายการอุปกรณ์ 7 :      
                Answer answer165 = new Answer()
                {
                    AnsDes = this.toolsListTextbox7.Value,
                    QuestionId = 1555,
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
                ans1555.QuestionId = 1555;
                ans1555.AnsDes = this.toolsListTextbox7.Value;
                ans1555.AnserTypeId = 1;
                ans1555.CreateDate = DateTime.Now;
                ans1555.UserId = user.Id;
                ans1555.AnsMonth = ansMonth;
                ans1555.SRId = sR.Id;
            }








            var ans1556 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1556).FirstOrDefault();
            if (ans1556 == null)
            {


                //  SerialNumber 7 :           
                Answer answer166 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox7.Value,
                    QuestionId = 1556,
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
                ans1556.QuestionId = 1556;
                ans1556.AnsDes = this.serialNumberTextbox7.Value;
                ans1556.AnserTypeId = 1;
                ans1556.CreateDate = DateTime.Now;
                ans1556.UserId = user.Id;
                ans1556.AnsMonth = ansMonth;
                ans1556.SRId = sR.Id;
            }








            var ans1557 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1557).FirstOrDefault();
            if (ans1557 == null)
            {
                //  new SerialNumber 7 :           
                Answer answer167 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox7.Value,
                    QuestionId = 1557,
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
                ans1557.QuestionId = 1557;
                ans1557.AnsDes = this.newSerialNumberTextbox7.Value;
                ans1557.AnserTypeId = 1;
                ans1557.CreateDate = DateTime.Now;
                ans1557.UserId = user.Id;
                ans1557.AnsMonth = ansMonth;
                ans1557.SRId = sR.Id;
            }





            var ans1558 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1558).FirstOrDefault();
            if (ans1558 == null)
            {
                //  หมายเหตุ  7:           
                Answer answer168 = new Answer()
                {
                    AnsDes = this.noteTextbox7.Value,
                    QuestionId = 1558,
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
                ans1558.QuestionId = 1558;
                ans1558.AnsDes = this.noteTextbox7.Value;
                ans1558.AnserTypeId = 1;
                ans1558.CreateDate = DateTime.Now;
                ans1558.UserId = user.Id;
                ans1558.AnsMonth = ansMonth;
                ans1558.SRId = sR.Id;
            }





            var ans1559 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1559).FirstOrDefault();
            if (ans1559 == null)
            {
                // รายการอุปกรณ์ 8 :      
                Answer answer169 = new Answer()
                {
                    AnsDes = this.toolsListTextbox8.Value,
                    QuestionId = 1559,
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
                ans1559.QuestionId = 1559;
                ans1559.AnsDes = this.toolsListTextbox8.Value;
                ans1559.AnserTypeId = 1;
                ans1559.CreateDate = DateTime.Now;
                ans1559.UserId = user.Id;
                ans1559.AnsMonth = ansMonth;
                ans1559.SRId = sR.Id;
            }






            var ans1560 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1560).FirstOrDefault();
            if (ans1559 == null)
            {

                //  SerialNumber 8 :           
                Answer answer170 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox8.Value,
                    QuestionId = 1560,
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
                ans1560.QuestionId = 1560;
                ans1560.AnsDes = this.serialNumberTextbox8.Value;
                ans1560.AnserTypeId = 1;
                ans1560.CreateDate = DateTime.Now;
                ans1560.UserId = user.Id;
                ans1560.AnsMonth = ansMonth;
                ans1560.SRId = sR.Id;
            }







            var ans1561 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1561).FirstOrDefault();
            if (ans1561 == null)
            {

                //  new SerialNumber 8 :           
                Answer answer171 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox8.Value,
                    QuestionId = 1561,
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
                ans1561.QuestionId = 1561;
                ans1561.AnsDes = this.newSerialNumberTextbox8.Value;
                ans1561.AnserTypeId = 1;
                ans1561.CreateDate = DateTime.Now;
                ans1561.UserId = user.Id;
                ans1561.AnsMonth = ansMonth;
                ans1561.SRId = sR.Id;
            }




            var ans1562 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1562).FirstOrDefault();
            if (ans1562 == null)
            {
                //  หมายเหตุ  8:           
                Answer answer172 = new Answer()
                {
                    AnsDes = this.noteTextbox8.Value,
                    QuestionId = 1562,
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
                ans1562.QuestionId = 1562;
                ans1562.AnsDes = this.noteTextbox8.Value;
                ans1562.AnserTypeId = 1;
                ans1562.CreateDate = DateTime.Now;
                ans1562.UserId = user.Id;
                ans1562.AnsMonth = ansMonth;
                ans1562.SRId = sR.Id;
            }





            var ans1563 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1563).FirstOrDefault();
            if (ans1563 == null)
            {

                // รายการอุปกรณ์ 9 :      
                Answer answer173 = new Answer()
                {
                    AnsDes = this.toolsListTextbox9.Value,
                    QuestionId = 1563,
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
                ans1563.QuestionId = 1563;
                ans1563.AnsDes = this.toolsListTextbox9.Value;
                ans1563.AnserTypeId = 1;
                ans1563.CreateDate = DateTime.Now;
                ans1563.UserId = user.Id;
                ans1563.AnsMonth = ansMonth;
                ans1563.SRId = sR.Id;
            }








            var ans1564 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1564).FirstOrDefault();
            if (ans1564 == null)
            {
                //  SerialNumber 9 :           
                Answer answer174 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox9.Value,
                    QuestionId = 1564,
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
                ans1564.QuestionId = 1564;
                ans1564.AnsDes = this.serialNumberTextbox9.Value;
                ans1564.AnserTypeId = 1;
                ans1564.CreateDate = DateTime.Now;
                ans1564.UserId = user.Id;
                ans1564.AnsMonth = ansMonth;
                ans1564.SRId = sR.Id;
            }



            var ans1565 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1565).FirstOrDefault();
            if (ans1565 == null)
            {
                //  new SerialNumber 9 :           
                Answer answer175 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox9.Value,
                    QuestionId = 1565,
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
                ans1565.QuestionId = 1565;
                ans1565.AnsDes = this.newSerialNumberTextbox9.Value;
                ans1565.AnserTypeId = 1;
                ans1565.CreateDate = DateTime.Now;
                ans1565.UserId = user.Id;
                ans1565.AnsMonth = ansMonth;
                ans1565.SRId = sR.Id;
            }





            var ans1566 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1566).FirstOrDefault();
            if (ans1566 == null)
            {
                //  หมายเหตุ  9:           
                Answer answer176 = new Answer()
                {
                    AnsDes = this.noteTextbox9.Value,
                    QuestionId = 1566,
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
                ans1566.QuestionId = 1566;
                ans1566.AnsDes = this.noteTextbox9.Value;
                ans1566.AnserTypeId = 1;
                ans1566.CreateDate = DateTime.Now;
                ans1566.UserId = user.Id;
                ans1566.AnsMonth = ansMonth;
                ans1566.SRId = sR.Id;
            }



            var ans1567 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1567).FirstOrDefault();
            if (ans1567 == null)
            {
                // รายการอุปกรณ์ 10 :      
                Answer answer177 = new Answer()
                {
                    AnsDes = this.toolsListTextbox10.Value,
                    QuestionId = 1567,
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
                ans1567.QuestionId = 1567;
                ans1567.AnsDes = this.toolsListTextbox10.Value;
                ans1567.AnserTypeId = 1;
                ans1567.CreateDate = DateTime.Now;
                ans1567.UserId = user.Id;
                ans1567.AnsMonth = ansMonth;
                ans1567.SRId = sR.Id;
            }





            var ans1568 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1568).FirstOrDefault();
            if (ans1568 == null)
            {
                //  SerialNumber 10 :           
                Answer answer178 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox10.Value,
                    QuestionId = 1568,
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
                ans1568.QuestionId = 1568;
                ans1568.AnsDes = this.serialNumberTextbox10.Value;
                ans1568.AnserTypeId = 1;
                ans1568.CreateDate = DateTime.Now;
                ans1568.UserId = user.Id;
                ans1568.AnsMonth = ansMonth;
                ans1568.SRId = sR.Id;
            }




            var ans1569 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1569).FirstOrDefault();
            if (ans1569 == null)
            {
                //  new SerialNumber 10 :           
                Answer answer179 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox10.Value,
                    QuestionId = 1569,
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
                ans1569.QuestionId = 1569;
                ans1569.AnsDes = this.newSerialNumberTextbox10.Value;
                ans1569.AnserTypeId = 1;
                ans1569.CreateDate = DateTime.Now;
                ans1569.UserId = user.Id;
                ans1569.AnsMonth = ansMonth;
                ans1569.SRId = sR.Id;
            }





            var ans1570 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1570).FirstOrDefault();
            if (ans1570 == null)
            {
                //  หมายเหตุ  10:           
                Answer answer180 = new Answer()
                {
                    AnsDes = this.noteTextbox10.Value,
                    QuestionId = 1570,
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
                ans1570.QuestionId = 1570;
                ans1570.AnsDes = this.noteTextbox10.Value;
                ans1570.AnserTypeId = 1;
                ans1570.CreateDate = DateTime.Now;
                ans1570.UserId = user.Id;
                ans1570.AnsMonth = ansMonth;
                ans1570.SRId = sR.Id;
            }




            var ans1571 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1571).FirstOrDefault();
            if (ans1571 == null)
            {

                // รายการอุปกรณ์ 11 :      
                Answer answer181 = new Answer()
                {
                    AnsDes = this.toolsListTextbox11.Value,
                    QuestionId = 1571,
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
                ans1571.QuestionId = 1571;
                ans1571.AnsDes = this.toolsListTextbox11.Value;
                ans1571.AnserTypeId = 1;
                ans1571.CreateDate = DateTime.Now;
                ans1571.UserId = user.Id;
                ans1571.AnsMonth = ansMonth;
                ans1571.SRId = sR.Id;
            }






            var ans1572 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1572).FirstOrDefault();
            if (ans1572 == null)
            {

                //  SerialNumber 11 :           
                Answer answer182 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox11.Value,
                    QuestionId = 1572,
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
                ans1572.QuestionId = 1572;
                ans1572.AnsDes = this.serialNumberTextbox11.Value;
                ans1572.AnserTypeId = 1;
                ans1572.CreateDate = DateTime.Now;
                ans1572.UserId = user.Id;
                ans1572.AnsMonth = ansMonth;
                ans1572.SRId = sR.Id;
            }





            var ans1573 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1573).FirstOrDefault();
            if (ans1573 == null)
            {
                //  new SerialNumber 11 :           
                Answer answer183 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox11.Value,
                    QuestionId = 1573,
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
                ans1573.QuestionId = 1573;
                ans1573.AnsDes = this.newSerialNumberTextbox11.Value;
                ans1573.AnserTypeId = 1;
                ans1573.CreateDate = DateTime.Now;
                ans1573.UserId = user.Id;
                ans1573.AnsMonth = ansMonth;
                ans1573.SRId = sR.Id;
            }


            var ans1574 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1574).FirstOrDefault();
            if (ans1574 == null)
            {
                //  หมายเหตุ  11:           
                Answer answer184 = new Answer()
                {
                    AnsDes = this.noteTextbox11.Value,
                    QuestionId = 1574,
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
                ans1574.QuestionId = 1574;
                ans1574.AnsDes = this.noteTextbox11.Value;
                ans1574.AnserTypeId = 1;
                ans1574.CreateDate = DateTime.Now;
                ans1574.UserId = user.Id;
                ans1574.AnsMonth = ansMonth;
                ans1574.SRId = sR.Id;
            }



            var ans1575 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1575).FirstOrDefault();
            if (ans1575 == null)
            {
                // รายการอุปกรณ์ 12 :      
                Answer answer185 = new Answer()
                {
                    AnsDes = this.toolsListTextbox12.Value,
                    QuestionId = 1575,
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
                ans1575.QuestionId = 1575;
                ans1575.AnsDes = this.toolsListTextbox12.Value;
                ans1575.AnserTypeId = 1;
                ans1575.CreateDate = DateTime.Now;
                ans1575.UserId = user.Id;
                ans1575.AnsMonth = ansMonth;
                ans1575.SRId = sR.Id;
            }




            var ans1576 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1576).FirstOrDefault();
            if (ans1576 == null)
            {
                //  SerialNumber 12 :           
                Answer answer186 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox12.Value,
                    QuestionId = 1576,
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
                ans1576.QuestionId = 1576;
                ans1576.AnsDes = this.serialNumberTextbox12.Value;
                ans1576.AnserTypeId = 1;
                ans1576.CreateDate = DateTime.Now;
                ans1576.UserId = user.Id;
                ans1576.AnsMonth = ansMonth;
                ans1576.SRId = sR.Id;
            }




            var ans1577 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1577).FirstOrDefault();
            if (ans1577 == null)
            {
                //  new SerialNumber 12 :           
                Answer answer187 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox12.Value,
                    QuestionId = 1577,
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
                ans1577.QuestionId = 1577;
                ans1577.AnsDes = this.newSerialNumberTextbox12.Value;
                ans1577.AnserTypeId = 1;
                ans1577.CreateDate = DateTime.Now;
                ans1577.UserId = user.Id;
                ans1577.AnsMonth = ansMonth;
                ans1577.SRId = sR.Id;
            }





            var ans1578 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1578).FirstOrDefault();
            if (ans1578 == null)
            {
                //  หมายเหตุ  12:           
                Answer answer188 = new Answer()
                {
                    AnsDes = this.noteTextbox12.Value,
                    QuestionId = 1578,
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
                ans1578.QuestionId = 1578;
                ans1578.AnsDes = this.noteTextbox12.Value;
                ans1578.AnserTypeId = 1;
                ans1578.CreateDate = DateTime.Now;
                ans1578.UserId = user.Id;
                ans1578.AnsMonth = ansMonth;
                ans1578.SRId = sR.Id;
            }






            var ans1579 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1579).FirstOrDefault();
            if (ans1579 == null)
            {
                // รายการอุปกรณ์ 13 :      
                Answer answer189 = new Answer()
                {
                    AnsDes = this.toolsListTextbox13.Value,
                    QuestionId = 1579,
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
                ans1579.QuestionId = 1579;
                ans1579.AnsDes = this.toolsListTextbox13.Value;
                ans1579.AnserTypeId = 1;
                ans1579.CreateDate = DateTime.Now;
                ans1579.UserId = user.Id;
                ans1579.AnsMonth = ansMonth;
                ans1579.SRId = sR.Id;
            }



            var ans1580 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1580).FirstOrDefault();
            if (ans1580 == null)
            {
                //  SerialNumber 13 :           
                Answer answer190 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox13.Value,
                    QuestionId = 1580,
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
                ans1580.QuestionId = 1580;
                ans1580.AnsDes = this.serialNumberTextbox13.Value;
                ans1580.AnserTypeId = 1;
                ans1580.CreateDate = DateTime.Now;
                ans1580.UserId = user.Id;
                ans1580.AnsMonth = ansMonth;
                ans1580.SRId = sR.Id;
            }




            var ans1581 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1581).FirstOrDefault();
            if (ans1581 == null)
            {
                //  new SerialNumber 13 :           
                Answer answer191 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox13.Value,
                    QuestionId = 1581,
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
                ans1581.QuestionId = 1581;
                ans1581.AnsDes = this.newSerialNumberTextbox13.Value;
                ans1581.AnserTypeId = 1;
                ans1581.CreateDate = DateTime.Now;
                ans1581.UserId = user.Id;
                ans1581.AnsMonth = ansMonth;
                ans1581.SRId = sR.Id;
            }



            var ans1582 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1582).FirstOrDefault();
            if (ans1582 == null)
            {
                //  หมายเหตุ  13   :    
                Answer answer192 = new Answer()
                {
                    AnsDes = this.noteTextbox13.Value,
                    QuestionId = 1582,
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
                ans1582.QuestionId = 1582;
                ans1582.AnsDes = this.noteTextbox13.Value;
                ans1582.AnserTypeId = 1;
                ans1582.CreateDate = DateTime.Now;
                ans1582.UserId = user.Id;
                ans1582.AnsMonth = ansMonth;
                ans1582.SRId = sR.Id;
            }


            var ans1583 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1583).FirstOrDefault();
            if (ans1583 == null)
            {
                // รายการอุปกรณ์ 14 :      
                Answer answer193 = new Answer()
                {
                    AnsDes = this.toolsListTextbox14.Value,
                    QuestionId = 1583,
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
                ans1583.QuestionId = 1583;
                ans1583.AnsDes = this.toolsListTextbox14.Value;
                ans1583.AnserTypeId = 1;
                ans1583.CreateDate = DateTime.Now;
                ans1583.UserId = user.Id;
                ans1583.AnsMonth = ansMonth;
                ans1583.SRId = sR.Id;
            }







            var ans1584 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1584).FirstOrDefault();
            if (ans1584 == null)
            {

                //  SerialNumber 14 :           
                Answer answer194 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox14.Value,
                    QuestionId = 1584,
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
                ans1584.QuestionId = 1584;
                ans1584.AnsDes = this.serialNumberTextbox14.Value;
                ans1584.AnserTypeId = 1;
                ans1584.CreateDate = DateTime.Now;
                ans1584.UserId = user.Id;
                ans1584.AnsMonth = ansMonth;
                ans1584.SRId = sR.Id;
            }




            var ans1585 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1585).FirstOrDefault();
            if (ans1585 == null)
            {
                //  new SerialNumber 14 :           
                Answer answer195 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox14.Value,
                    QuestionId = 1585,
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
                ans1585.QuestionId = 1585;
                ans1585.AnsDes = this.newSerialNumberTextbox14.Value;
                ans1585.AnserTypeId = 1;
                ans1585.CreateDate = DateTime.Now;
                ans1585.UserId = user.Id;
                ans1585.AnsMonth = ansMonth;
                ans1585.SRId = sR.Id;
            }




            var ans1586 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1586).FirstOrDefault();
            if (ans1586 == null)
            {
                //  หมายเหตุ  143   :    
                Answer answer196 = new Answer()
                {
                    AnsDes = this.noteTextbox14.Value,
                    QuestionId = 1586,
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
                ans1586.QuestionId = 1586;
                ans1586.AnsDes = this.noteTextbox14.Value;
                ans1586.AnserTypeId = 1;
                ans1586.CreateDate = DateTime.Now;
                ans1586.UserId = user.Id;
                ans1586.AnsMonth = ansMonth;
                ans1586.SRId = sR.Id;
            }




            var ans1587 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1587).FirstOrDefault();
            if (ans1587 == null)
            {

                // รายการอุปกรณ์ 15 :      
                Answer answer197 = new Answer()
                {
                    AnsDes = this.toolsListTextbox15.Value,
                    QuestionId = 1587,
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
                ans1587.QuestionId = 1587;
                ans1587.AnsDes = this.toolsListTextbox15.Value;
                ans1587.AnserTypeId = 1;
                ans1587.CreateDate = DateTime.Now;
                ans1587.UserId = user.Id;
                ans1587.AnsMonth = ansMonth;
                ans1587.SRId = sR.Id;
            }



            var ans1588 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1588).FirstOrDefault();
            if (ans1588 == null)
            {

                //  SerialNumber 15 :           
                Answer answer198 = new Answer()
                {
                    AnsDes = this.serialNumberTextbox15.Value,
                    QuestionId = 1588,
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
                ans1588.QuestionId = 1588;
                ans1588.AnsDes = this.serialNumberTextbox15.Value;
                ans1588.AnserTypeId = 1;
                ans1588.CreateDate = DateTime.Now;
                ans1588.UserId = user.Id;
                ans1588.AnsMonth = ansMonth;
                ans1588.SRId = sR.Id;
            }






            var ans1589 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1589).FirstOrDefault();
            if (ans1589 == null)
            {

                //  new SerialNumber 15 :           
                Answer answer199 = new Answer()
                {
                    AnsDes = this.newSerialNumberTextbox15.Value,
                    QuestionId = 1589,
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
                ans1589.QuestionId = 1589;
                ans1589.AnsDes = this.newSerialNumberTextbox15.Value;
                ans1589.AnserTypeId = 1;
                ans1589.CreateDate = DateTime.Now;
                ans1589.UserId = user.Id;
                ans1589.AnsMonth = ansMonth;
                ans1589.SRId = sR.Id;
            }




            var ans1590 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1590).FirstOrDefault();
            if (ans1590 == null)
            {

                //  หมายเหตุ  15   :    
                Answer answer200 = new Answer()
                {
                    AnsDes = this.noteTextbox15.Value,
                    QuestionId = 1590,
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
                ans1590.QuestionId = 1590;
                ans1590.AnsDes = this.noteTextbox15.Value;
                ans1590.AnserTypeId = 1;
                ans1590.CreateDate = DateTime.Now;
                ans1590.UserId = user.Id;
                ans1590.AnsMonth = ansMonth;
                ans1590.SRId = sR.Id;
            }
            //////////////////////////////////   END Sectionid  = 137     /////////////////////////////////



            //////////////////////////////////    Sectionid  = 138     /////////////////////////////////


            var ans1591 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1591).FirstOrDefault();
            if (ans1591 == null)
            {
                //   name pm :    
                Answer answer1591 = new Answer()
                {
                    AnsDes = this.nameDopmTextbox.Value,
                    QuestionId = 1591,
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
                ans1591.QuestionId = 1591;
                ans1591.AnsDes = this.nameDopmTextbox.Value;
                ans1591.AnserTypeId = 1;
                ans1591.CreateDate = DateTime.Now;
                ans1591.UserId = user.Id;
                ans1591.AnsMonth = ansMonth;
                ans1591.SRId = sR.Id;
            }





            var ans1592 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1592).FirstOrDefault();
            if (ans1592 == null)
            {
                //  นที่ทำ PM :    
                Answer answer1592 = new Answer()
                {
                    AnsDes = this.dayDopmTextbox.Value,
                    QuestionId = 1592,
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
                ans1592.QuestionId = 1592;
                ans1592.AnsDes = this.dayDopmTextbox.Value;
                ans1592.AnserTypeId = 1;
                ans1592.CreateDate = DateTime.Now;
                ans1592.UserId = user.Id;
                ans1592.AnsMonth = ansMonth;
                ans1592.SRId = sR.Id;
            }
            //////////////////////////////////   END Sectionid  = 138     /////////////////////////////////









            //////////////////////////////////    Sectionid  = 139     /////////////////////////////////
            var ans1593 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1593).FirstOrDefault();
            if (ans1593 == null)
            {
                // รูปภาพรวมบริเวณ Site :
                string steAreaRadio = Request.Form["steAreaRadio"];
                Answer answer1593 = new Answer()
                {
                    AnsDes = steAreaRadio,
                    QuestionId = 1593,
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
                string variable = Request.Form["steAreaRadio"];
                ans1593.QuestionId = 1593;
                ans1593.AnsDes = variable;
                ans1593.AnserTypeId = 4;
                ans1593.CreateDate = DateTime.Now;
                ans1593.UserId = user.Id;
                ans1593.AnsMonth = ansMonth;
                ans1593.SRId = sR.Id;
            }





            var ans1594 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1594).FirstOrDefault();
            if (ans1594 == null)
            {
                // รูปภาพรวมบริเวณ Site :
                string beforeAfterRadio = Request.Form["beforeAfterRadio"];
                Answer answer1594 = new Answer()
                {
                    AnsDes = beforeAfterRadio,
                    QuestionId = 1594,
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
                string variable = Request.Form["beforeAfterRadio"];
                ans1594.QuestionId = 1594;
                ans1594.AnsDes = variable;
                ans1594.AnserTypeId = 4;
                ans1594.CreateDate = DateTime.Now;
                ans1594.UserId = user.Id;
                ans1594.AnsMonth = ansMonth;
                ans1594.SRId = sR.Id;
            }



            var ans1595 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1595).FirstOrDefault();
            if (ans1595 == null)
            {
                // รูปภายในตู้ ก่อน-หลัง :
                string picIncontainRadio = Request.Form["picIncontainRadio"];
                Answer answer1595 = new Answer()
                {
                    AnsDes = picIncontainRadio,
                    QuestionId = 1595,
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
                string variable = Request.Form["picIncontainRadio"];
                ans1595.QuestionId = 1595;
                ans1595.AnsDes = variable;
                ans1595.AnserTypeId = 4;
                ans1595.CreateDate = DateTime.Now;
                ans1595.UserId = user.Id;
                ans1595.AnsMonth = ansMonth;
                ans1595.SRId = sR.Id;
            }




            var ans1596 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1596).FirstOrDefault();
            if (ans1596 == null)
            {
                // รูปขณะทำความสะอาดตู้ ก่อน-หลัง :
                string beforeCleanRaio = Request.Form["beforeCleanRaio"];
                Answer answer1596 = new Answer()
                {
                    AnsDes = beforeCleanRaio,
                    QuestionId = 1596,
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
                string variable = Request.Form["beforeCleanRaio"];
                ans1596.QuestionId = 1596;
                ans1596.AnsDes = variable;
                ans1596.AnserTypeId = 4;
                ans1596.CreateDate = DateTime.Now;
                ans1596.UserId = user.Id;
                ans1596.AnsMonth = ansMonth;
                ans1596.SRId = sR.Id;
            }








            var ans1597 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1597).FirstOrDefault();
            if (ans1597 == null)
            {
                // รูปสถานะ Circuit Breaker (ON):
                string circuitBreakOnRaio = Request.Form["circuitBreakOnRaio"];
                Answer answer1597 = new Answer()
                {
                    AnsDes = circuitBreakOnRaio,
                    QuestionId = 1597,
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
                string variable = Request.Form["circuitBreakOnRaio"];
                ans1597.QuestionId = 1597;
                ans1597.AnsDes = variable;
                ans1597.AnserTypeId = 4;
                ans1597.CreateDate = DateTime.Now;
                ans1597.UserId = user.Id;
                ans1597.AnsMonth = ansMonth;
                ans1597.SRId = sR.Id;
            }




            var ans1598 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1598).FirstOrDefault();
            if (ans1598 == null)
            {
                // รูป Circuit Breaker ภายในตู้:
                string circuitInRadio = Request.Form["circuitInRadio"];
                Answer answer1598 = new Answer()
                {
                    AnsDes = circuitInRadio,
                    QuestionId = 1598,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer1598);
            }
            else
            {
                string variable = Request.Form["circuitInRadio"];
                ans1598.QuestionId = 1598;
                ans1598.AnsDes = variable;
                ans1598.AnserTypeId = 4;
                ans1598.CreateDate = DateTime.Now;
                ans1598.UserId = user.Id;
                ans1598.AnsMonth = ansMonth;
                ans1598.SRId = sR.Id;
            }



            var ans1599 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1599).FirstOrDefault();
            if (ans1599 == null)
            {
                // รูป Circuit Breaker ภายในตู้:
                string terminalRaio = Request.Form["terminalRaio"];
                Answer answer1599 = new Answer()
                {
                    AnsDes = terminalRaio,
                    QuestionId = 1599,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer1599);
            }
            else
            {
                string variable = Request.Form["terminalRaio"];
                ans1599.QuestionId = 1599;
                ans1599.AnsDes = variable;
                ans1599.AnserTypeId = 4;
                ans1599.CreateDate = DateTime.Now;
                ans1599.UserId = user.Id;
                ans1599.AnsMonth = ansMonth;
                ans1599.SRId = sR.Id;
            }


            var ans1600 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1600).FirstOrDefault();
            if (ans1600 == null)
            {
                // รูปการตรวจสอบ Ground และ Bar Ground :
                string GroundAndBarGroundRaio = Request.Form["GroundAndBarGroundRaio"];
                Answer answer1600 = new Answer()
                {
                    AnsDes = GroundAndBarGroundRaio,
                    QuestionId = 1600,
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
                string variable = Request.Form["GroundAndBarGroundRaio"];
                ans1600.QuestionId = 1600;
                ans1600.AnsDes = variable;
                ans1600.AnserTypeId = 4;
                ans1600.CreateDate = DateTime.Now;
                ans1600.UserId = user.Id;
                ans1600.AnsMonth = ansMonth;
                ans1600.SRId = sR.Id;
            }




            var ans1601 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1601).FirstOrDefault();
            if (ans1601 == null)
            {
                // รูปการตรวจสอบสถานะไฟฟ้ารั่วลง Ground (Lamp Test:
                string groundLampRadio = Request.Form["groundLampRadio"];
                Answer answer1601 = new Answer()
                {
                    AnsDes = groundLampRadio,
                    QuestionId = 1601,
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
                string variable = Request.Form["groundLampRadio"];
                ans1601.QuestionId = 1601;
                ans1601.AnsDes = variable;
                ans1601.AnserTypeId = 4;
                ans1601.CreateDate = DateTime.Now;
                ans1601.UserId = user.Id;
                ans1601.AnsMonth = ansMonth;
                ans1601.SRId = sR.Id;
            }



            var ans1602 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1602).FirstOrDefault();
            if (ans1602 == null)
            {
                // รูป PEA Meter :
                string peaMeterRaio = Request.Form["peaMeterRaio"];
                Answer answer1602 = new Answer()
                {
                    AnsDes = peaMeterRaio,
                    QuestionId = 1602,
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
                string variable = Request.Form["peaMeterRaio"];
                ans1602.QuestionId = 1602;
                ans1602.AnsDes = variable;
                ans1602.AnserTypeId = 4;
                ans1602.CreateDate = DateTime.Now;
                ans1602.UserId = user.Id;
                ans1602.AnsMonth = ansMonth;
                ans1602.SRId = sR.Id;
            }



            var ans1603 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1603).FirstOrDefault();
            if (ans1603 == null)
            {
                // >รูปการวัดแรงดัน AC และกระแส AC :
                string acAndACRadio = Request.Form["acAndACRadio"];
                Answer answer1603 = new Answer()
                {
                    AnsDes = acAndACRadio,
                    QuestionId = 1603,
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
                string variable = Request.Form["acAndACRadio"];
                ans1603.QuestionId = 1603;
                ans1603.AnsDes = variable;
                ans1603.AnserTypeId = 4;
                ans1603.CreateDate = DateTime.Now;
                ans1603.UserId = user.Id;
                ans1603.AnsMonth = ansMonth;
                ans1603.SRId = sR.Id;
            }



            var ans1604 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1604).FirstOrDefault();
            if (ans1604 == null)
            {
                // รูปหน้าจอ UPS แสดงค่าต่างๆ และ Serial NO. :
                string monitorSerRadio = Request.Form["monitorSerRadio"];
                Answer answer1604 = new Answer()
                {
                    AnsDes = monitorSerRadio,
                    QuestionId = 1604,
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
                string variable = Request.Form["monitorSerRadio"];
                ans1604.QuestionId = 1604;
                ans1604.AnsDes = variable;
                ans1604.AnserTypeId = 4;
                ans1604.CreateDate = DateTime.Now;
                ans1604.UserId = user.Id;
                ans1604.AnsMonth = ansMonth;
                ans1604.SRId = sR.Id;
            }



            var ans1605 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1605).FirstOrDefault();
            if (ans1605 == null)
            {
                // รูป ONU/Modem พร้อม Serial NO. และ MAC :
                string ONUModemAndMacRadio = Request.Form["ONUModemAndMacRadio"];
                Answer answer1605 = new Answer()
                {
                    AnsDes = ONUModemAndMacRadio,
                    QuestionId = 1605,
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
                string variable = Request.Form["ONUModemAndMacRadio"];
                ans1605.QuestionId = 1605;
                ans1605.AnsDes = variable;
                ans1605.AnserTypeId = 4;
                ans1605.CreateDate = DateTime.Now;
                ans1605.UserId = user.Id;
                ans1605.AnsMonth = ansMonth;
                ans1605.SRId = sR.Id;
            }


            var ans1606 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1606).FirstOrDefault();
            if (ans1606 == null)
            {
                // รูปการ Test Speed ONU (30/10 mbps) :
                string testSpeedOnuRadio = Request.Form["testSpeedOnuRadio"];
                Answer answer1606 = new Answer()
                {
                    AnsDes = testSpeedOnuRadio,
                    QuestionId = 1606,
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
                string variable = Request.Form["testSpeedOnuRadio"];
                ans1606.QuestionId = 1606;
                ans1606.AnsDes = variable;
                ans1606.AnserTypeId = 4;
                ans1606.CreateDate = DateTime.Now;
                ans1606.UserId = user.Id;
                ans1606.AnsMonth = ansMonth;
                ans1606.SRId = sR.Id;
            }




            var ans1607 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1607).FirstOrDefault();
            if (ans1607 == null)
            {
                // รูปการ Test Network strength (>= -77.5 dBm) Section 1:
                string pictestNetworkRadioSec1 = Request.Form["pictestNetworkRadioSec1"];
                Answer answer1607 = new Answer()
                {
                    AnsDes = pictestNetworkRadioSec1,
                    QuestionId = 1607,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer1607);
            }
            else
            {
                string variable = Request.Form["pictestNetworkRadioSec1"];
                ans1607.QuestionId = 1607;
                ans1607.AnsDes = variable;
                ans1607.AnserTypeId = 4;
                ans1607.CreateDate = DateTime.Now;
                ans1607.UserId = user.Id;
                ans1607.AnsMonth = ansMonth;
                ans1607.SRId = sR.Id;
            }




            var ans1608 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1608).FirstOrDefault();
            if (ans1608 == null)
            {
                // รูปการ Test Network strength (>= -77.5 dBm) Section 2:
                string pictestNetworkRadioSec2 = Request.Form["pictestNetworkRadioSec2"];
                Answer answer1608 = new Answer()
                {
                    AnsDes = pictestNetworkRadioSec2,
                    QuestionId = 1608,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer1608);
            }
            else
            {
                string variable = Request.Form["pictestNetworkRadioSec2"];
                ans1608.QuestionId = 1608;
                ans1608.AnsDes = variable;
                ans1608.AnserTypeId = 4;
                ans1608.CreateDate = DateTime.Now;
                ans1608.UserId = user.Id;
                ans1608.AnsMonth = ansMonth;
                ans1608.SRId = sR.Id;
            }




            var ans1609 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1609).FirstOrDefault();
            if (ans1609 == null)
            {
                // รูปการ Test Network strength (>= -77.5 dBm) Section 3:
                string pictestNetworkRadioSec3 = Request.Form["pictestNetworkRadioSec3"];
                Answer answer1609 = new Answer()
                {
                    AnsDes = pictestNetworkRadioSec3,
                    QuestionId = 1609,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer1609);
            }
            else
            {
                string variable = Request.Form["pictestNetworkRadioSec3"];
                ans1609.QuestionId = 1609;
                ans1609.AnsDes = variable;
                ans1609.AnserTypeId = 4;
                ans1609.CreateDate = DateTime.Now;
                ans1609.UserId = user.Id;
                ans1609.AnsMonth = ansMonth;
                ans1609.SRId = sR.Id;
            }





            var ans1610 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1610).FirstOrDefault();
            if (ans1610 == null)
            {
                // รูปการ Test Network strength (>= -77.5 dBm) Section 3:
                string testSpeedVsatRadio = Request.Form["testSpeedVsatRadio"];
                Answer answer1610 = new Answer()
                {
                    AnsDes = testSpeedVsatRadio,
                    QuestionId = 1610,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer1610);
            }
            else
            {
                string variable = Request.Form["testSpeedVsatRadio"];
                ans1610.QuestionId = 1610;
                ans1610.AnsDes = variable;
                ans1610.AnserTypeId = 4;
                ans1610.CreateDate = DateTime.Now;
                ans1610.UserId = user.Id;
                ans1610.AnsMonth = ansMonth;
                ans1610.SRId = sR.Id;
            }




            var ans1611 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1611).FirstOrDefault();
            if (ans1611 == null)
            {
                //รูป Femto พร้อม Serial NO. และ MAC :
                string femtoSerandMacRaio = Request.Form["femtoSerandMacRaio"];
                Answer answer1611 = new Answer()
                {
                    AnsDes = femtoSerandMacRaio,
                    QuestionId = 1611,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer1611);
            }
            else
            {
                string variable = Request.Form["femtoSerandMacRaio"];
                ans1611.QuestionId = 1611;
                ans1611.AnsDes = variable;
                ans1611.AnserTypeId = 4;
                ans1611.CreateDate = DateTime.Now;
                ans1611.UserId = user.Id;
                ans1611.AnsMonth = ansMonth;
                ans1611.SRId = sR.Id;
            }




            var ans1612 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1612).FirstOrDefault();
            if (ans1612 == null)
            {
                //รูปการ Test Femto 3G (PSC 408-412)   :
                string testFemtoRadio = Request.Form["testFemtoRadio"];
                Answer answer1612 = new Answer()
                {
                    AnsDes = testFemtoRadio,
                    QuestionId = 1612,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer1612);
            }
            else
            {
                string variable = Request.Form["testFemtoRadio"];
                ans1612.QuestionId = 1612;
                ans1612.AnsDes = variable;
                ans1612.AnserTypeId = 4;
                ans1612.CreateDate = DateTime.Now;
                ans1612.UserId = user.Id;
                ans1612.AnsMonth = ansMonth;
                ans1612.SRId = sR.Id;
            }





            var ans1613 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1613).FirstOrDefault();
            if (ans1613 == null)
            {
                // รูปการ Test Femto 4G(PCI 480 - 503) * เฉพาะ 4G:
                string testFemto4gRadio = Request.Form["testFemto4gRadio"];
                Answer answer1613 = new Answer()
                {
                    AnsDes = testFemto4gRadio,
                    QuestionId = 1613,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer1613);

            }
            else
            {
                string variable = Request.Form["testFemto4gRadio"];
                ans1613.QuestionId = 1613;
                ans1613.AnsDes = variable;
                ans1613.AnserTypeId = 4;
                ans1613.CreateDate = DateTime.Now;
                ans1613.UserId = user.Id;
                ans1613.AnsMonth = ansMonth;
                ans1613.SRId = sR.Id;
            }








            // ---------------------    SECTION ID 140   -----------------------------


            var ans1614 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1614).FirstOrDefault();
            if (ans1614 == null)
            {
                // รูปจุดติดตั้งจานดาวเทียม :
                string inStallSatRadio = Request.Form["inStallSatRadio"];
                Answer answer1614 = new Answer()
                {
                    AnsDes = inStallSatRadio,
                    QuestionId = 1614,
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
                string variable = Request.Form["inStallSatRadio"];
                ans1614.QuestionId = 1614;
                ans1614.AnsDes = variable;
                ans1614.AnserTypeId = 4;
                ans1614.CreateDate = DateTime.Now;
                ans1614.UserId = user.Id;
                ans1614.AnsMonth = ansMonth;
                ans1614.SRId = sR.Id;
            }





            var ans1615 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1615).FirstOrDefault();
            if (ans1615 == null)
            {
                // รูปความสะอาดบริเวณจานดาวเทียม :
                string cleanSatRadio = Request.Form["cleanSatRadio"];
                Answer answer1615 = new Answer()
                {
                    AnsDes = cleanSatRadio,
                    QuestionId = 1615,
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
                string variable = Request.Form["cleanSatRadio"];
                ans1615.QuestionId = 1615;
                ans1615.AnsDes = variable;
                ans1615.AnserTypeId = 4;
                ans1615.CreateDate = DateTime.Now;
                ans1615.UserId = user.Id;
                ans1615.AnsMonth = ansMonth;
                ans1615.SRId = sR.Id;
            }




            var ans1616 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1616).FirstOrDefault();
            if (ans1616 == null)
            {
                //รูป LNB พร้อม Part NO :
                string lnbWithpartRadio = Request.Form["lnbWithpartRadio"];
                Answer answer1616 = new Answer()
                {
                    AnsDes = lnbWithpartRadio,
                    QuestionId = 1616,
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
                string variable = Request.Form["lnbWithpartRadio"];
                ans1616.QuestionId = 1616;
                ans1616.AnsDes = variable;
                ans1616.AnserTypeId = 4;
                ans1616.CreateDate = DateTime.Now;
                ans1616.UserId = user.Id;
                ans1616.AnsMonth = ansMonth;
                ans1616.SRId = sR.Id;
            }



            var ans1617 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1617).FirstOrDefault();
            if (ans1617 == null)
            {
                //รูป BUC พร้อม Part NO :
                string bucWithpartRadio = Request.Form["bucWithpartRadio"];
                Answer answer1617 = new Answer()
                {
                    AnsDes = bucWithpartRadio,
                    QuestionId = 1617,
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
                string variable = Request.Form["bucWithpartRadio"];
                ans1617.QuestionId = 1617;
                ans1617.AnsDes = variable;
                ans1617.AnserTypeId = 4;
                ans1617.CreateDate = DateTime.Now;
                ans1617.UserId = user.Id;
                ans1617.AnsMonth = ansMonth;
                ans1617.SRId = sR.Id;
            }





            var ans1618 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1618).FirstOrDefault();
            if (ans1618 == null)
            {
                //รูปการเก็บสายและพันหัวที่ LNB/BUC :
                string wireingLnbRadio = Request.Form["wireingLnbRadio"];
                Answer answer1618 = new Answer()
                {
                    AnsDes = wireingLnbRadio,
                    QuestionId = 1618,
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
                string variable = Request.Form["wireingLnbRadio"];
                ans1618.QuestionId = 1618;
                ans1618.AnsDes = variable;
                ans1618.AnserTypeId = 4;
                ans1618.CreateDate = DateTime.Now;
                ans1618.UserId = user.Id;
                ans1618.AnsMonth = ansMonth;
                ans1618.SRId = sR.Id;
            }




            var ans1619 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1619).FirstOrDefault();
            if (ans1619 == null)
            {
                //แนว Line Of Sight (ดูการถูกบังของหน้าจานดาวเทียม)  :
                string lineOfsightRadio = Request.Form["lineOfsightRadio"];
                Answer answer1619 = new Answer()
                {
                    AnsDes = lineOfsightRadio,
                    QuestionId = 1619,
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
                string variable = Request.Form["lineOfsightRadio"];
                ans1619.QuestionId = 1619;
                ans1619.AnsDes = variable;
                ans1619.AnserTypeId = 4;
                ans1619.CreateDate = DateTime.Now;
                ans1619.UserId = user.Id;
                ans1619.AnsMonth = ansMonth;
                ans1619.SRId = sR.Id;
            }

            // ---------------------    END SECTION ID 140   ----------------------------- //



            // ---------------------    SECTION ID 141   --------------------------------- //

            var ans1620 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1620).FirstOrDefault();
            if (ans1620 == null)
            {
                //รูปจุดติดตั้ง Solar Cell  :
                string solarCellRadio = Request.Form["solarCellRadio"];
                Answer answer1620 = new Answer()
                {
                    AnsDes = solarCellRadio,
                    QuestionId = 1620,
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
                string variable = Request.Form["solarCellRadio"];
                ans1620.QuestionId = 1620;
                ans1620.AnsDes = variable;
                ans1620.AnserTypeId = 4;
                ans1620.CreateDate = DateTime.Now;
                ans1620.UserId = user.Id;
                ans1620.AnsMonth = ansMonth;
                ans1620.SRId = sR.Id;
            }


            var ans1621 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1621).FirstOrDefault();
            if (ans1621 == null)
            {
                //รูปจุดติดตั้ง Solar Cell :
                string toolsinSolarcellRadio = Request.Form["toolsinSolarcellRadio"];
                Answer answer1621 = new Answer()
                {
                    AnsDes = toolsinSolarcellRadio,
                    QuestionId = 1621,
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
                string variable = Request.Form["toolsinSolarcellRadio"];
                ans1621.QuestionId = 1621;
                ans1621.AnsDes = variable;
                ans1621.AnserTypeId = 4;
                ans1621.CreateDate = DateTime.Now;
                ans1621.UserId = user.Id;
                ans1621.AnsMonth = ansMonth;
                ans1621.SRId = sR.Id;
            }




            var ans1622 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1622).FirstOrDefault();
            if (ans1622 == null)
            {
                //รูปอุปกรณ์ภายในตู้ Solar Cell :
                string monitoringChargerRadio = Request.Form["monitoringChargerRadio"];
                Answer answer1622 = new Answer()
                {
                    AnsDes = monitoringChargerRadio,
                    QuestionId = 1622,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer1622);

            }
            else
            {
                string variable = Request.Form["monitoringChargerRadio"];
                ans1622.QuestionId = 1622;
                ans1622.AnsDes = variable;
                ans1622.AnserTypeId = 4;
                ans1622.CreateDate = DateTime.Now;
                ans1622.UserId = user.Id;
                ans1622.AnsMonth = ansMonth;
                ans1622.SRId = sR.Id;
            }



            var ans1623 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1623).FirstOrDefault();
            if (ans1623 == null)
            {
                // รูปหน้าจอ Inverter แสดงค่าต่างๆ :
                string moniteringInverterRadio = Request.Form["moniteringInverterRadio"];
                Answer answer1623 = new Answer()
                {
                    AnsDes = moniteringInverterRadio,
                    QuestionId = 1623,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer1623);

            }
            else
            {
                string variable = Request.Form["moniteringInverterRadio"];
                ans1623.QuestionId = 1623;
                ans1623.AnsDes = variable;
                ans1623.AnserTypeId = 4;
                ans1623.CreateDate = DateTime.Now;
                ans1623.UserId = user.Id;
                ans1623.AnsMonth = ansMonth;
                ans1623.SRId = sR.Id;
            }





            var ans1624 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1624).FirstOrDefault();
            if (ans1624 == null)
            {
                // รูปความสะอาดแผง PV :
                string cleaningPVRadio = Request.Form["cleaningPVRadio"];
                Answer answer1624 = new Answer()
                {
                    AnsDes = cleaningPVRadio,
                    QuestionId = 1624,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer1624);

            }
            else
            {
                string variable = Request.Form["cleaningPVRadio"];
                ans1624.QuestionId = 1624;
                ans1624.AnsDes = variable;
                ans1624.AnserTypeId = 4;
                ans1624.CreateDate = DateTime.Now;
                ans1624.UserId = user.Id;
                ans1624.AnsMonth = ansMonth;
                ans1624.SRId = sR.Id;
            }






            var ans1625 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1625).FirstOrDefault();
            if (ans1625 == null)
            {
                // รูปภาพรวมดูสิ่งบดบังแสงอาทิตย์ :
                string sunRiseingRadio = Request.Form["sunRiseingRadio"];
                Answer answer1625 = new Answer()
                {
                    AnsDes = sunRiseingRadio,
                    QuestionId = 1625,
                    AnserTypeId = 4,
                    CreateDate = DateTime.Now,
                    UserId = user.Id,
                    AnsMonth = ansMonth,
                    SRId = sR.Id
                };
                uSOEntities.Answers.Add(answer1625);

            }
            else
            {
                string variable = Request.Form["sunRiseingRadio"];
                ans1625.QuestionId = 1625;
                ans1625.AnsDes = variable;
                ans1625.AnserTypeId = 4;
                ans1625.CreateDate = DateTime.Now;
                ans1625.UserId = user.Id;
                ans1625.AnsMonth = ansMonth;
                ans1625.SRId = sR.Id;
            }






            var ans1626 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1626).FirstOrDefault();
            if (ans1626 == null)
            {
                // รูปการวัดแรงดัน Battery ก้อนที่ 1 :
                string batteryVoltRadio1 = Request.Form["batteryVoltRadio1"];
                Answer answer1626 = new Answer()
                {
                    AnsDes = batteryVoltRadio1,
                    QuestionId = 1626,
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
                string variable = Request.Form["batteryVoltRadio1"];
                ans1626.QuestionId = 1626;
                ans1626.AnsDes = variable;
                ans1626.AnserTypeId = 4;
                ans1626.CreateDate = DateTime.Now;
                ans1626.UserId = user.Id;
                ans1626.AnsMonth = ansMonth;
                ans1626.SRId = sR.Id;
            }








            var ans1627 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1627).FirstOrDefault();
            if (ans1627 == null)
            {
                // รูปการวัดแรงดัน Battery ก้อนที่ 2 :
                string batteryVoltRadio2 = Request.Form["batteryVoltRadio2"];
                Answer answer1627 = new Answer()
                {
                    AnsDes = batteryVoltRadio2,
                    QuestionId = 1627,
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
                string variable = Request.Form["batteryVoltRadio2"];
                ans1627.QuestionId = 1627;
                ans1627.AnsDes = variable;
                ans1627.AnserTypeId = 4;
                ans1627.CreateDate = DateTime.Now;
                ans1627.UserId = user.Id;
                ans1627.AnsMonth = ansMonth;
                ans1627.SRId = sR.Id;
            }




            var ans1628 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1628).FirstOrDefault();
            if (ans1628 == null)
            {
                // รูปการวัดแรงดัน Battery ก้อนที่ 3 :
                string batteryVoltRadio3 = Request.Form["batteryVoltRadio3"];
                Answer answer1628 = new Answer()
                {
                    AnsDes = batteryVoltRadio3,
                    QuestionId = 1628,
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
                string variable = Request.Form["batteryVoltRadio3"];
                ans1628.QuestionId = 1628;
                ans1628.AnsDes = variable;
                ans1628.AnserTypeId = 4;
                ans1628.CreateDate = DateTime.Now;
                ans1628.UserId = user.Id;
                ans1628.AnsMonth = ansMonth;
                ans1628.SRId = sR.Id;
            }






            var ans1629 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1629).FirstOrDefault();
            if (ans1629 == null)
            {
                // รูปการวัดแรงดัน Battery ก้อนที่ 4 :
                string batteryVoltRadio4 = Request.Form["batteryVoltRadio4"];
                Answer answer1629 = new Answer()
                {
                    AnsDes = batteryVoltRadio4,
                    QuestionId = 1629,
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
                string variable = Request.Form["batteryVoltRadio4"];
                ans1629.QuestionId = 1629;
                ans1629.AnsDes = variable;
                ans1629.AnserTypeId = 4;
                ans1629.CreateDate = DateTime.Now;
                ans1629.UserId = user.Id;
                ans1629.AnsMonth = ansMonth;
                ans1629.SRId = sR.Id;
            }




            //1.รูป PICTURE CHECKLIST :
            var ans1630 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1630).FirstOrDefault();
            if (ans1630 == null)
            {

                if (this.pictureChecklistImages.HasFile)
                {
                    string extension = this.pictureChecklistImages.PostedFile.FileName.Split('.')[1];
                    string newFileName = "images/pictureChecklist_MobileService_" + DateTime.Now.ToString("yyyyMMddHHmmss") + "." + extension;
                    this.pictureChecklistImages.PostedFile.SaveAs(Server.MapPath(newFileName));

                    Answer answer259 = new Answer()
                    {
                        AnsDes = newFileName,
                        QuestionId = 1630,
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
                    string newFileName = "images/pictureChecklist_MobileService_" + DateTime.Now.ToString("yyyyMMddHHmmss") + "." + extension;
                    this.pictureChecklistImages.PostedFile.SaveAs(Server.MapPath(newFileName));
                    ans1630.QuestionId = 1630;
                    ans1630.AnsDes = newFileName;
                    ans1630.AnserTypeId = 3;
                    ans1630.CreateDate = DateTime.Now;
                    ans1630.UserId = user.Id;
                    ans1630.AnsMonth = ansMonth;
                    ans1630.SRId = sR.Id;

                }
            }






          
            var ans1631 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1631).FirstOrDefault();
            if (ans1631 == null)
            {
                //2.รูป VSAT PICTURE CHECKLIST :
                if (this.vsatpictureChecklistImages.HasFile)
                {
                    string extension = this.vsatpictureChecklistImages.PostedFile.FileName.Split('.')[1];
                    string newFileName = "images/VsatPictureChecklist_" + DateTime.Now.ToString("yyyyMMddHHmmss") + "." + extension;
                    this.vsatpictureChecklistImages.PostedFile.SaveAs(Server.MapPath(newFileName));

                    Answer answer260 = new Answer()
                    {
                        AnsDes = newFileName,
                        QuestionId = 1631,
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
                if (this.pictureChecklistImages.HasFile)
                {
                    string extension = this.vsatpictureChecklistImages.PostedFile.FileName.Split('.')[1];
                    string newFileName = "images/pictureChecklist_MobileService_" + DateTime.Now.ToString("yyyyMMddHHmmss") + "." + extension;
                    this.vsatpictureChecklistImages.PostedFile.SaveAs(Server.MapPath(newFileName));
                    ans1631.QuestionId = 1631;
                    ans1631.AnsDes = newFileName;
                    ans1631.AnserTypeId = 3;
                    ans1631.CreateDate = DateTime.Now;
                    ans1631.UserId = user.Id;
                    ans1631.AnsMonth = ansMonth;
                    ans1631.SRId = sR.Id;

                }
            }




            var ans1632 = uSOEntities.Answers.Where(x => x.Question.Section.HeadId == 7 && x.SRId == sR.Id && x.QuestionId == 1632).FirstOrDefault();
            if (ans1632 == null)
            {
                //3.รูป SOLAR CELL PICTURE CHECKLISTT :
                if (this.solarcellpictureChecklistImages.HasFile)
                {
                    string extension = this.solarcellpictureChecklistImages.PostedFile.FileName.Split('.')[1];
                    string newFileName = "images/SolarcellPictureChecklist_MobileService_" + DateTime.Now.ToString("yyyyMMddHHmmss") + "." + extension;
                    this.solarcellpictureChecklistImages.PostedFile.SaveAs(Server.MapPath(newFileName));

                    Answer answer261 = new Answer()
                    {
                        AnsDes = newFileName,
                        QuestionId = 1632,
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
                if (this.pictureChecklistImages.HasFile)
                {
                    string extension = this.solarcellpictureChecklistImages.PostedFile.FileName.Split('.')[1];
                    string newFileName = "images/SolarcellPictureChecklist_MobileService_" + DateTime.Now.ToString("yyyyMMddHHmmss") + "." + extension;
                    this.solarcellpictureChecklistImages.PostedFile.SaveAs(Server.MapPath(newFileName));
                    ans1632.QuestionId = 1632;
                    ans1632.AnsDes = newFileName;
                    ans1632.AnserTypeId = 3;
                    ans1632.CreateDate = DateTime.Now;
                    ans1632.UserId = user.Id;
                    ans1632.AnsMonth = ansMonth;
                    ans1632.SRId = sR.Id;

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

