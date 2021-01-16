using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CommonClassLibrary;

namespace USOform.PreventiveMaintenanceReportBBUSOWrap
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        USOEntities uSOEntities;

        public WebForm1()
        {
            uSOEntities = new USOEntities();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            //this.GetData();
        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            // กลุ่ม
            Answer answer1 = new Answer() { 
                AnsDes = this.GroupNameTextBox.Text,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                QuestionId = 1,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer1);

            // ภูมิภาค
            Answer answer2 = new Answer()
            {
                AnsDes = this.AreaTextbox.Value,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                QuestionId = 2,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer2);

            // บริษัท
            Answer answer3 = new Answer()
            {
                AnsDes = this.CompanyTextbox.Value,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                QuestionId = 3,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer3);

            //รอบการบำรุงรักษาครั้งที่
            Answer answer4 = new Answer()
            {
                AnsDes = this.maintenanceCountTextbox.Value,
                QuestionId = 4,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,               
                UserId = 1
            };
            uSOEntities.Answers.Add(answer4);

            //ปีพุทธศักราช
            Answer answer5 = new Answer()
            {
                AnsDes = this.maintenanceCountTextbox.Value,
                QuestionId = 5,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer5);

            //วัน เดือน ปี ที่เริ่มต้น
            Answer answer8 = new Answer()
            {
                AnsDes = this.startDatepicker.Value,
                QuestionId = 8,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1,
                //StartDate = DateTime.ParseExact(this.startDateTextbox2.Value, "dd/MM/yyyy", CultureInfo.GetCultureInfo("en-US")),
            };
            uSOEntities.Answers.Add(answer8);

            //ถึง 
            Answer answer9 = new Answer()
            {
                AnsDes = this.endDatepicker.Value,
                QuestionId = 9,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1,
                //StartDate = DateTime.ParseExact(this.startDateTextbox2.Value, "dd/MM/yyyy", CultureInfo.GetCultureInfo("en-US")),
            };
            uSOEntities.Answers.Add(answer9);

            //สถานที่ SITE CODE
            Answer answer10 = new Answer()
            {
                AnsDes = this.siteCodeTextbox.Value,
                QuestionId = 10,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer10);

            //Cabinet ID:
            Answer answer11 = new Answer()
            {
                AnsDes = this.cabinetIdTextbox.Value,
                QuestionId = 11,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer11);

            //Site Code :
            Answer answer12 = new Answer()
            {
                AnsDes = this.sitecodeTextboxSection2.Value,
                QuestionId = 12,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer12);

            //Village ID :
            Answer answer13 = new Answer()
            {
                AnsDes = this.VillageIdTextbox.Value,
                QuestionId = 13,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer13);

            
            //Village  :
            Answer answer14 = new Answer()
            {
                AnsDes = this.villageTextbox.Value,
                QuestionId = 14,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer14);

            //School 's name  :
            Answer answer15 = new Answer()
            {
                AnsDes = this.schoolnameTextbox.Value,
                QuestionId = 15,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer15);

            //Sub-District :
            Answer answer16 = new Answer()
            {
                AnsDes = this.subdistrictTextbox.Value,
                QuestionId = 16,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer16);

            //Province :
            Answer answer17 = new Answer()
            {
                AnsDes = this.provinceTextbox.Value,
                QuestionId = 17,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer17);

            //Type :
            Answer answer18 = new Answer()
            {
                AnsDes = this.typeTextbox.Value,
                QuestionId = 18,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer18);

            //PM Date :
            Answer answer19 = new Answer()
            {
                AnsDes = this.pmdateTextbox.Value,
                QuestionId = 19,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer19);

          


            //ใส่รูปหน้าอาคารศูนย์ USO Net :
            if (this.usonetsignboardImage.HasFile)
            {
                string extension = this.usonetsignboardImage.PostedFile.FileName.Split('.')[1];
                string newFileName = "images/" + DateTime.Now.ToString("yyyyMMddHHmmss") + "." + extension;
                this.usonetsignboardImage.PostedFile.SaveAs(Server.MapPath(newFileName));

                Answer answer20 = new Answer()
                {
                    AnsDes = newFileName,
                    QuestionId = 20,
                    AnserTypeId = 3,
                    CreateDate = DateTime.Now,
                    UserId = 1
                };
                uSOEntities.Answers.Add(answer20);
            }


            //signature Executor :
            Answer answer21 = new Answer()
            {
                AnsDes = this.signatureExecutorTextbox.Value,
                QuestionId = 21,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer21);

            //signature Supervisor :
            Answer answer22 = new Answer()
            {
                AnsDes = this.signatureSupervisorTextbox.Value,
                QuestionId = 22,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer22);

            //name Executor  :
            Answer answer23 = new Answer()
            {
                AnsDes = this.nameExecutorTextbox.Value,
                QuestionId = 23,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer23);

            //name Supervisor :
            Answer answer24 = new Answer()
            {
                AnsDes = this.nameSupervisorTextbox.Value,
                QuestionId = 24,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer24);

            //Date Executor :
            Answer answer25 = new Answer()
            {
                AnsDes = this.DateExecutorTextbox.Value,
                QuestionId = 25,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer25);

            //Date Supervisor :
            Answer answer26 = new Answer()
            {
                AnsDes = this.DateSupervisorTextbox.Value,
                QuestionId = 26,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer26);


















            //ใส่ป้ายหน้าโรงเรียน :
            if (this.signboardschoolImage.HasFile)
            {
                string extension = this.signboardschoolImage.PostedFile.FileName.Split('.')[1];
                string newFileName = "images/" + DateTime.Now.ToString("yyyyMMddHHmmss") + "." + extension;
                this.signboardschoolImage.PostedFile.SaveAs(Server.MapPath(newFileName));

                Answer answer6 = new Answer()
                {
                    AnsDes = newFileName,
                    QuestionId = 6,
                    AnserTypeId = 3,
                    CreateDate = DateTime.Now,
                    UserId = 1
                };
                uSOEntities.Answers.Add(answer6);
            }






























            string xx = Request.Form["upsModeRadio"];
            Answer answer7 = new Answer()
            {
                AnsDes = xx,
                QuestionId = 7,
                AnserTypeId = 3,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer7);



            int result = uSOEntities.SaveChanges();
            if (result > 0)
            {
                this.SuccessPanel.Visible = true;
            }
        }

        //void GetData()
        //{
        //    var collection = uSOEntities.Answers.Where(x => x.User.OrganizationId == 1 && x.Question.SectionId == 6).ToList();
        //    this.ResultRepeater.DataSource = collection.OrderByDescending(x => x.CreateDate).ToList();
        //    this.ResultRepeater.DataBind();
        //}
    }
}