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

            //Location name :
            Answer answer27 = new Answer()
            {
                AnsDes = this.LocationnameTextbox.Value,
                QuestionId = 27,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer27);

            //Site code section 4 :
            Answer answer28 = new Answer()
            {
                AnsDes = this.sitecodeTextboxSection4.Value,
                QuestionId = 28,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer28);


            //villageIDsection 4 :
            Answer answer29 = new Answer()
            {
                AnsDes = this.villageIDTextboxSection4.Value,
                QuestionId = 29,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer29);

            //lat and long  :
            Answer answer30 = new Answer()
            {
                AnsDes = this.latandlongTextbox.Value,
                QuestionId = 30,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer30);

            //type of signal Radio  :
            string typeOf = Request.Form["typeofsignalRadio"];
            Answer answer31 = new Answer()
            {
                AnsDes = typeOf,
                QuestionId = 31,
                AnserTypeId = 3,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer31);

            //ISP (Existing Network)  :
            Answer answer32 = new Answer()
            {
                AnsDes = this.ispTextbox.Value,
                QuestionId = 32,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer32);

            //elecSystem Radio  :
            string elecradioSection5 = Request.Form["elecRadio"];
            Answer answer33 = new Answer()
            {
                AnsDes = elecradioSection5,
                QuestionId = 33,
                AnserTypeId = 3,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer33);

            //tranformer Radio  :
            string tranRadio = Request.Form["transformerRadio"];
            Answer answer34 = new Answer()
            {
                AnsDes = tranRadio,
                QuestionId = 34,
                AnserTypeId = 3,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer34);


            //หมายเลขผู้ใช้ไฟ  :
            Answer answer35 = new Answer()
            {
                AnsDes = this.numberuserTextbox.Value,
                QuestionId = 35,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer35);


            //หน่วยใช้ไฟไฟ  :
            Answer answer36 = new Answer()
            {
                AnsDes = this.kwhMeterTextbox.Value,
                QuestionId = 36,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer36);


            //แรงดัน AC (kWh Meter) :
            Answer answer37 = new Answer()
            {
                AnsDes = this.acTextbox.Value,
                QuestionId = 37,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer37);


            //กระแส Line AC (kWh Meter) :
            Answer answer38 = new Answer()
            {
                AnsDes = this.lineAcTextbox.Value,
                QuestionId = 38,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer38);


            // กระแส Neutron AC(kWh Meter) :          
            Answer answer39 = new Answer()
            {
                AnsDes = this.neutronacTextbox.Value,
                QuestionId = 39,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer39);

            //สภาพ kWh Meter Radio  :
            string conRadio = Request.Form["conditionRadio"];
            Answer answer40 = new Answer()
            {
                AnsDes = conRadio,
                QuestionId = 40,
                AnserTypeId = 3, 
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer40);

            //สภาพ MDB/ Circuit Breaker Radio  :
            string CircuitBreakerRadio = Request.Form["MDBCircuitBreakerRadio"];
            Answer answer41 = new Answer()
            {
                AnsDes = CircuitBreakerRadio,
                QuestionId = 41,
                AnserTypeId = 3,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer41);


            //UPS ภายในตู้ Radio  :
            string innerUPS = Request.Form["inupsRadio"];
            Answer answer42 = new Answer()
            {
                AnsDes = innerUPS,
                QuestionId = 42,
                AnserTypeId = 3,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer42);


            // AC from UPS :          
            Answer answer43 = new Answer()
            {
                AnsDes = this.acfromupsTextbox.Value,
                QuestionId = 43,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer43);

            // กระเเส โหลด :          
            Answer answer44 = new Answer()
            {
                AnsDes = this.electricloadTextbox.Value,
                QuestionId = 44,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer44);


            //EMER GENNNARATOR   :
            string emergen = Request.Form["emergeneratorRadio"];
            Answer answer45 = new Answer()
            {
                AnsDes = emergen,
                QuestionId = 45,
                AnserTypeId = 3,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer45);

            //สภาพ batterry bank  :
            string statebat = Request.Form["stateBatteryBankRadio"];
            Answer answer46 = new Answer()
            {
                AnsDes = statebat,
                QuestionId = 46,
                AnserTypeId = 3,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer46);


            //ONU/Modem Network  :
            string modemnet = Request.Form["onuModemRadio"];
            Answer answer47 = new Answer()
            {
                AnsDes = modemnet,
                QuestionId = 47,
                AnserTypeId = 3,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer47);


            //Swicth 8 part :
            string swiftpart = Request.Form["switchportRadio"];
            Answer answer48 = new Answer()
            {
                AnsDes = swiftpart,
                QuestionId = 48,
                AnserTypeId = 3,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer48);


            //Swicth 48 part :
            string ee = Request.Form["switch48portRadio"];
            Answer answer49 = new Answer()
            {
                AnsDes = ee,
                QuestionId = 49,
                AnserTypeId = 3,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer49);


            //Outdoor AP ตัวที่ 1 :
            string otap = Request.Form["outdoorapRadio"];
            Answer answer50 = new Answer()
            {
                AnsDes = otap,
                QuestionId = 50,
                AnserTypeId = 3,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer50);



            //Outdoor AP ตัวที่ 2 :
            string otap2 = Request.Form["outdoorap2Radio"];
            Answer answer51 = new Answer()
            {
                AnsDes = otap2,
                QuestionId = 51,
                AnserTypeId = 3,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer51);


            //indoor AP ตัวที่ 1 :
            string inap2 = Request.Form["indoorapRadio"];
            Answer answer52 = new Answer()
            {
                AnsDes = inap2,
                QuestionId = 52,
                AnserTypeId = 3,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer52);


            //indoor AP ตัวที่ 2 :
            string inapp = Request.Form["indoorap2Radio"];
            Answer answer53 = new Answer()
            {
                AnsDes = inapp,
                QuestionId = 53,
                AnserTypeId = 3,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer53);


            //การ Wiring สายไฟ :
            string wiring = Request.Form["wiringelecRadio"];
            Answer answer54 = new Answer()
            {
                AnsDes = wiring,
                QuestionId = 54,
                AnserTypeId = 3,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer54);


            //การ Wiring Patch cord และ สาย LAN :
            string wiringPatch = Request.Form["wiringpatchRadio"];
            Answer answer55 = new Answer()
            {
                AnsDes = wiringPatch,
                QuestionId = 55,
                AnserTypeId = 3,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer55);

            //ความแข็งแรงจุดต่อ Ground Bar :
            string gb = Request.Form["groundbarRadio"];
            Answer answer57 = new Answer()
            {
                AnsDes = gb,
                QuestionId = 57,
                AnserTypeId = 3,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer57);



            //ความแข็งแรงของน็อตขันหางปลาอุปกรณ์ :
            string fishnot = Request.Form["notfishRadio"];
            Answer answer58 = new Answer()
            {
                AnsDes = fishnot,
                QuestionId = 58,
                AnserTypeId = 3,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer58);

            //สายกราวด์เรียบร้อย ปลอดภัย สมบูรณ์ :
            string ffss = Request.Form["safegroundRadio"];
            Answer answer59 = new Answer()
            {
                AnsDes = ffss,
                QuestionId = 59,
                AnserTypeId = 3,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer59);


            //สถานะไฟฟ้ารั่วลง Ground :
            string elecground = Request.Form["brokenElecRadio"];
            Answer answer60 = new Answer()
            {
                AnsDes = elecground,
                QuestionId = 60,
                AnserTypeId = 3,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer60);




            //Fire Alarm และ Smoke Detector :
            string firesmokeDetec = Request.Form["firesmokedDectorRadio"];
            Answer answer61 = new Answer()
            {
                AnsDes = firesmokeDetec,
                QuestionId = 61,
                AnserTypeId = 3,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer61);



            //Fire Alarm Manual Switch :
            string FireAlarmManualSwitch = Request.Form["firealarmManualswitchRadio"];
            Answer answer62 = new Answer()
            {
                AnsDes = FireAlarmManualSwitch,
                QuestionId = 62,
                AnserTypeId = 3,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer62);



            // Battery Fire Alarm ก้อนที่ 1 :          
            Answer answer63 = new Answer()
            {
                AnsDes = this.battFirealarm1Textbox.Value,
                QuestionId = 63,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer63);

            // Battery Fire Alarm ก้อนที่ 2 :          
            Answer answer64 = new Answer()
            {
                AnsDes = this.battFirealarm2Textbox.Value,
                QuestionId = 64,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer64);


            //ไฟแสงสว่างฉุกเฉิน :
            string emerr = Request.Form["emerLightRadio"];
            Answer answer65 = new Answer()
            {
                AnsDes = emerr,
                QuestionId = 65,
                AnserTypeId = 3,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer65);


            //ระบบ Monitor กล้องวงจรปิด :
            string monitorr = Request.Form["monitorCameraRadio"];
            Answer answer66 = new Answer()
            {
                AnsDes = emerr,
                QuestionId = 66,
                AnserTypeId = 3,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer66);


            //  กล้องวงจรปิด Computer :
            string cameraCom = Request.Form["monitorCameraRadio"];
            Answer answer67 = new Answer()
            {
                AnsDes = cameraCom,
                QuestionId = 67,
                AnserTypeId = 3,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer67);



            //  กล้องวงจรปิดภายนอกอาคาร  :
            string cameraout = Request.Form["cameraOutRadio"];
            Answer answer68 = new Answer()
            {
                AnsDes = cameraout,
                QuestionId = 68,
                AnserTypeId = 3,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer68);


            //  กล้องวงจรปิดภายนอกอาคาร 2  :
            string cameraout2 = Request.Form["cameraOut2Radio"];
            Answer answer69 = new Answer()
            {
                AnsDes = cameraout2,
                QuestionId = 69,
                AnserTypeId = 3,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer69);


            //  จอทีวีห้องประชุม   :
            string tv = Request.Form["televisRadio"];
            Answer answer70 = new Answer()
            {
                AnsDes = tv,
                QuestionId = 70,
                AnserTypeId = 3,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer70);


            //  คอมพิวเตอร์เจ้าหน้าที่ศูนย์  :
            string comagent = Request.Form["computerAgentRadio"];
            Answer answer71 = new Answer()
            {
                AnsDes = comagent,
                QuestionId = 71,
                AnserTypeId = 3,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer71);


            //  Printer  :
            string print = Request.Form["printerRadio"];
            Answer answer72 = new Answer()
            {
                AnsDes = print,
                QuestionId = 72,
                AnserTypeId = 3,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer72);


            // คอมพิวเตอร์ตัวที่ 1  :
            string com1 = Request.Form["Com1Radio"];
            Answer answer73 = new Answer()
            {
                AnsDes = com1,
                QuestionId = 73,
                AnserTypeId = 3,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer73);


            // คอมพิวเตอร์ตัวที่ 2  :
            string com2 = Request.Form["com2Radio"];
            Answer answer74 = new Answer()
            {
                AnsDes = com2,
                QuestionId = 74,
                AnserTypeId = 3,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer74);


            // คอมพิวเตอร์ตัวที่ 3  :
            string com3 = Request.Form["com3Radio"];
            Answer answer75 = new Answer()
            {
                AnsDes = com3,
                QuestionId = 75,
                AnserTypeId = 3,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer75);


            // คอมพิวเตอร์ตัวที่ 4  :
            string com4 = Request.Form["com4Radio"];
            Answer answer76 = new Answer()
            {
                AnsDes = com4,
                QuestionId = 76,
                AnserTypeId = 3,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer76);



            // คอมพิวเตอร์ตัวที่ 5  :
            string com5 = Request.Form["com5Radio"];
            Answer answer77 = new Answer()
            {
                AnsDes = com5,
                QuestionId = 77,
                AnserTypeId = 3,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer77);




            // คอมพิวเตอร์ตัวที่ 6  :
            string com6 = Request.Form["com6Radio"];
            Answer answer78 = new Answer()
            {
                AnsDes = com6,
                QuestionId = 78,
                AnserTypeId = 3,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer78);



            // คอมพิวเตอร์ตัวที่ 7  :
            string com7 = Request.Form["com7Radio"];
            Answer answer79 = new Answer()
            {
                AnsDes = com7,
                QuestionId = 79,
                AnserTypeId = 3,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer79);



            // คอมพิวเตอร์ตัวที่ 8  :
            string com8 = Request.Form["com8Radio"];
            Answer answer80 = new Answer()
            {
                AnsDes = com8,
                QuestionId = 80,
                AnserTypeId = 3,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer80);



            // คอมพิวเตอร์ตัวที่ 9  :
            string com9 = Request.Form["com9Radio"];
            Answer answer81 = new Answer()
            {
                AnsDes = com9,
                QuestionId = 81,
                AnserTypeId = 3,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer81);



            // คอมพิวเตอร์ตัวที่ 10  :
            string com10 = Request.Form["com10Radio"];
            Answer answer82 = new Answer()
            {
                AnsDes = com10,
                QuestionId = 82,
                AnserTypeId = 3,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer82);



























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