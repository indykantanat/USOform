using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CommonClassLibrary;

namespace USOform.PreventiveMaintenanceReportBB2._3_3._3
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

        }
        protected void SubmitButton_Click(object sender, EventArgs e)
        {

            ///-----------------START   HEADING----------------////
            //1: logoPicture
            if (this.logoPictureOga.HasFile)
            {
                string extension = this.logoPictureOga.PostedFile.FileName.Split('.')[1];
                string newFileName = "images/logoImages_" + DateTime.Now.ToString("yyyyMMddHHmmss") + "." + extension;
                this.logoPictureOga.PostedFile.SaveAs(Server.MapPath(newFileName));

                Answer answe264 = new Answer()
                {
                    AnsDes = newFileName,
                    QuestionId = 483,
                    AnserTypeId = 3,
                    CreateDate = DateTime.Now,
                    UserId = 1
                };
                uSOEntities.Answers.Add(answe264);
            }

            // กลุ่ม
            Answer answer1409 = new Answer()
            {
                AnsDes = this.groupTextbox.Value,
                QuestionId = 484,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer1409);

            // ภูมิภาค
            Answer answer1410 = new Answer()
            {
                AnsDes = this.AreaTextbox.Value,
                QuestionId = 485,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer1410);

            // บริษัท
            Answer answer3 = new Answer()
            {
                AnsDes = this.CompanyTextbox.Value,
                QuestionId = 486,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer3);

            //ส่วนที่ 1 การจัดให้มีบริการอินเทอร์เน็ตความเร็วสูง (Broadband Internet Service :
            string seLectOptionRadio = Request.Form["seLectOptionRadio"];
            Answer answer31 = new Answer()
            {
                AnsDes = seLectOptionRadio,
                QuestionId = 487,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer31);



            //รอบการบำรุงรักษาครั้งที่
            Answer answer4 = new Answer()
            {
                AnsDes = this.maintenanceCountTextbox.Value,
                QuestionId = 488,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer4);

            //ปีพุทธศักราช
            Answer answer5 = new Answer()
            {
                AnsDes = this.yearTextbox.Value,
                QuestionId = 489,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer5);

            //วัน เดือน ปี ที่เริ่มต้น
            Answer answer8 = new Answer()
            {
                AnsDes = this.startDatepicker.Value,
                QuestionId = 490,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1,

            };
            uSOEntities.Answers.Add(answer8);

            //ถึง 
            Answer answer9 = new Answer()
            {
                AnsDes = this.endDatepicker.Value,
                QuestionId = 491,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1,

            };
            uSOEntities.Answers.Add(answer9);

            //สถานที่ SITE CODE
            Answer answer10 = new Answer()
            {
                AnsDes = this.siteCodeTextbox.Value,
                QuestionId = 1640,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer10);

            ///-------END  HEADING--------------------



            // secion 45
            //Cabinet ID:
            Answer answer11 = new Answer()
            {
                AnsDes = this.cabinetIdTextbox.Value,
                QuestionId = 492,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer11);

            //Site Code :
            Answer answer12 = new Answer()
            {
                AnsDes = this.sitecodeTextboxSection2.Value,
                QuestionId = 493,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer12);

            //Village ID :
            Answer answer13 = new Answer()
            {
                AnsDes = this.VillageIdTextbox.Value,
                QuestionId = 494,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer13);

            //Village  :
            Answer answer14 = new Answer()
            {
                AnsDes = this.villageTextbox.Value,
                QuestionId = 495,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer14);
         
            //SChool’s Name : :
            Answer answer275 = new Answer()
            {
                AnsDes = this.schoolNameTextbox.Value,
                QuestionId = 496,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer275);


            //Sub-District :
            Answer answer16 = new Answer()
            {
                AnsDes = this.subdistrictTextbox.Value,
                QuestionId = 497,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer16);


            //District :
            Answer answer1423 = new Answer()
            {
                AnsDes = this.DistrictTextboxEIEI.Value,
                QuestionId = 498,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer1423);

            //Province :
            Answer answer17 = new Answer()
            {
                AnsDes = this.provinceTextbox.Value,
                QuestionId = 499,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer17);

            //Type :
            Answer answer18 = new Answer()
            {
                AnsDes = this.typeTextbox.Value,
                QuestionId = 500,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer18);

            //PM Date :
            Answer answer19 = new Answer()
            {
                AnsDes = this.pmdateTextbox.Value,
                QuestionId = 501,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer19);




            //ใส่ป้ายหน้าโรงเรียน :
            if (this.picinfrontImages.HasFile)
            {
                string extension = this.picinfrontImages.PostedFile.FileName.Split('.')[1];
                string newFileName = "images/picinfrontImages_" + DateTime.Now.ToString("yyyyMMddHHmmss") + "." + extension;
                this.picinfrontImages.PostedFile.SaveAs(Server.MapPath(newFileName));

                Answer answer20 = new Answer()
                {
                    AnsDes = newFileName,
                    QuestionId = 502,
                    AnserTypeId = 3,
                    CreateDate = DateTime.Now,
                    UserId = 1
                };
                uSOEntities.Answers.Add(answer20);
            }



            //รูปบริเวณห้องบริการ WiFi - Computer :
            if (this.wifiHallImages.HasFile)
            {
                string extension = this.wifiHallImages.PostedFile.FileName.Split('.')[1];
                string newFileName = "images/picinfrontImages_" + DateTime.Now.ToString("yyyyMMddHHmmss") + "." + extension;
                this.wifiHallImages.PostedFile.SaveAs(Server.MapPath(newFileName));

                Answer answer20 = new Answer()
                {
                    AnsDes = newFileName,
                    QuestionId = 503,
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
                QuestionId = 504,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer21);

            //signature Supervisor :
            Answer answer22 = new Answer()
            {
                AnsDes = this.signatureSupervisorTextbox.Value,
                QuestionId = 505,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer22);

            //name Executor  :
            Answer answer23 = new Answer()
            {
                AnsDes = this.nameExecutorTextbox.Value,
                QuestionId = 506,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer23);

            //name Supervisor :
            Answer answer24 = new Answer()
            {
                AnsDes = this.nameSupervisorTextbox.Value,
                QuestionId = 507,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer24);

            //Date Executor :
            Answer answer25 = new Answer()
            {
                AnsDes = this.DateExecutorTextbox.Value,
                QuestionId = 508,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer25);

            //Date Supervisor :
            Answer answer26 = new Answer()
            {
                AnsDes = this.DateSupervisorTextbox.Value,
                QuestionId = 509,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer26);


            //cabibnet  :
            Answer answer27 = new Answer()
            {
                AnsDes = this.cabinetId2Textbox.Value,
                QuestionId = 510,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer27);

            //Site code section 4 :
            Answer answer28 = new Answer()
            {
                AnsDes = this.sitecodeTextboxSection4.Value,
                QuestionId = 511,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer28);


            //villageIDsection 4 :
            Answer answer29 = new Answer()
            {
                AnsDes = this.villageIDTextboxSection4.Value,
                QuestionId = 512,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer29);

            //lat and long  :
            Answer answer30 = new Answer()
            {
                AnsDes = this.latandlongTextbox.Value,
                QuestionId = 513,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer30);



            //TypeofSignal :
            string typeOf = Request.Form["TypeofSignaleieiRadio"];
            Answer answer514 = new Answer()
            {
                AnsDes = typeOf,
                QuestionId = 514,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer514);

            //OLT ID : :
            Answer answer1440 = new Answer()
            {
                AnsDes = this.oltIdTextbox.Value,
                QuestionId = 515,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer1440);





            //ระบบไฟฟ้า :
            string typeOffire = Request.Form["voltSystemRadio"];
            Answer answer294 = new Answer()
            {
                AnsDes = typeOffire,
                QuestionId = 516,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer294);


            //หมายเลขผู้ใช้ไฟ:
            Answer answer1442 = new Answer()
            {
                AnsDes = this.numberIdTextbox.Value,
                QuestionId = 517,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer1442);




            //หน่วยใช้ไฟไฟ  :
            Answer answer36 = new Answer()
            {
                AnsDes = this.kwhMeterTextbox.Value,
                QuestionId = 518,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer36);


            //แรงดัน AC (kWh Meter) :
            Answer answer37 = new Answer()
            {
                AnsDes = this.acvoltTextbox.Value,
                QuestionId = 519,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer37);


            //กระแส Line AC (kWh Meter) :
            Answer answer38 = new Answer()
            {
                AnsDes = this.lineAcTextbox.Value,
                QuestionId = 520,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer38);


            // กระแส Neutron AC(kWh Meter) :          
            Answer answer39 = new Answer()
            {
                AnsDes = this.neutronAcEIEITextbox.Value,
                QuestionId = 521,
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
                QuestionId = 522,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer40);

            //สภาพ MDB/ Circuit Breaker Radio  :
            string CircuitBreakerRadio = Request.Form["MDBCircuitBreakerRadio"];
            Answer answer41 = new Answer()
            {
                AnsDes = CircuitBreakerRadio,
                QuestionId = 523,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer41);


            //UPS ภายในตู้ Radio  :
            string innerUPS = Request.Form["inupsRadio"];
            Answer answer42 = new Answer()
            {
                AnsDes = innerUPS,
                QuestionId = 524,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer42);


            // AC from UPS :          
            Answer answer43 = new Answer()
            {
                AnsDes = this.acfromupsTextbox.Value,
                QuestionId = 525,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer43);

            // กระเเส โหลด :  
            string emergen = Request.Form["voltageLoadRadio"];
            Answer answer45 = new Answer()
            {
                AnsDes = emergen,
                QuestionId = 526,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer45);

            // ระดับความจุ Battery :  
            string emerbat = Request.Form["batteryCapacityRadio"];
            Answer answer1452 = new Answer()
            {
                AnsDes = emerbat,
                QuestionId = 527,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer1452);

            // UPS MODE :  
            string UPSMODE = Request.Form["upsModeRadio"];
            Answer answer1453 = new Answer()
            {
                AnsDes = UPSMODE,
                QuestionId = 528,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer1453);



            // การทำงานของระบบไฟสำรอง :  
            string secondFireRadio1 = Request.Form["secondFireRadio"];
            Answer answer1454 = new Answer()
            {
                AnsDes = secondFireRadio1,
                QuestionId = 529,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer1454);


            // สภาพ Battery Bank :  
            string Batterybank = Request.Form["batterybankRadio"];
            Answer answer1455 = new Answer()
            {
                AnsDes = Batterybank,
                QuestionId = 530,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer1455);


            // ONU/Modem Network :  
            string ONUModemNetwork = Request.Form["ONUModemNetworkRadio"];
            Answer answer1456 = new Answer()
            {
                AnsDes = ONUModemNetwork,
                QuestionId = 531,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer1456);


            // Power Supply (for Switch) :  
            string femto = Request.Form["psuForswitchRadio"];
            Answer answer1457 = new Answer()
            {
                AnsDes = femto,
                QuestionId = 532,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer1457);

            // Switch 8 Port :  
            string femtoanswer = Request.Form["switchPortRadio"];
            Answer answer1458 = new Answer()
            {
                AnsDes = femtoanswer,
                QuestionId = 533,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer1458);


            // Outdoor AP 2.4 GH :  
            string tpower = Request.Form["OutdoorAP24Radio"];
            Answer answer1459 = new Answer()
            {
                AnsDes = tpower,
                QuestionId = 534,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer1459);

            // Outdoor AP 5 GHz:  
            string wireingGround = Request.Form["OutdoorAP5GHzRadio"];
            Answer answer1460 = new Answer()
            {
                AnsDes = wireingGround,
                QuestionId = 535,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer1460);

            //t-power :  
            string Wirinlan = Request.Form["tPowerRadio"];
            Answer answer1633 = new Answer()
            {
                AnsDes = Wirinlan,
                QuestionId = 536,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer1633);


            //การ Wiring สายไฟและสาย Ground :  
            string WiringGroundRadio = Request.Form["WiringGroundRadio"];
            Answer answer314 = new Answer()
            {
                AnsDes = WiringGroundRadio,
                QuestionId = 537,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer314);



            //การ Wiring สายไฟและสาย Ground :  
            string wirePatchRadio = Request.Form["wirePatchRadio"];
            Answer answer315 = new Answer()
            {
                AnsDes = wirePatchRadio,
                QuestionId = 538,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer315);


            //ความแข็งแรงจุดต่อ Ground Bar :
            string gb = Request.Form["groundbarRadio"];
            Answer answer57 = new Answer()
            {
                AnsDes = gb,
                QuestionId = 539,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer57);



            //ความแข็งแรงของน็อตขันหางปลาอุปกรณ์ :
            string fishnot = Request.Form["notfishRadio"];
            Answer answer58 = new Answer()
            {
                AnsDes = fishnot,
                QuestionId = 540,
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
                QuestionId = 541,
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
                QuestionId = 542,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer60);


            // คอมพิวเตอร์ตัวที่ 1  :
            string com1 = Request.Form["ComRadio1"];
            Answer answer76 = new Answer()
            {
                AnsDes = com1,
                QuestionId = 543,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer76);


            // คอมพิวเตอร์ตัวที่ 2  :
            string com2 = Request.Form["ComRadio2"];
            Answer answer78 = new Answer()
            {
                AnsDes = com2,
                QuestionId = 544,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer78);


            // คอมพิวเตอร์ตัวที่ 3  :
            string com3 = Request.Form["ComRadio3"];
            Answer answer79 = new Answer()
            {
                AnsDes = com3,
                QuestionId = 545,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer79);


            // คอมพิวเตอร์ตัวที่ 4  :
            string com4 = Request.Form["ComRadio4"];
            Answer answer80 = new Answer()
            {
                AnsDes = com4,
                QuestionId = 546,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer80);



            // คอมพิวเตอร์ตัวที่ 5  :
            string com5 = Request.Form["ComRadio5"];
            Answer answer81 = new Answer()
            {
                AnsDes = com5,
                QuestionId = 547,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer81);


            // UPS สำหรับคอมพิวเตอร์ตัวที่ 1 :
            string ups1 = Request.Form["upsRadio1"];
            Answer answer548 = new Answer()
            {
                AnsDes = ups1,
                QuestionId = 548,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer548);


            // UPS สำหรับคอมพิวเตอร์ตัวที่ 2 :
            string ups2 = Request.Form["upsRadio2"];
            Answer answer549 = new Answer()
            {
                AnsDes = ups2,
                QuestionId = 549,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer549);


            // UPS สำหรับคอมพิวเตอร์ตัวที่ 3 :
            string ups3 = Request.Form["upsRadio3"];
            Answer answer550 = new Answer()
            {
                AnsDes = ups3,
                QuestionId = 550,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer550);



            // UPS สำหรับคอมพิวเตอร์ตัวที่ 4 :
            string ups4 = Request.Form["upsRadio4"];
            Answer answer551 = new Answer()
            {
                AnsDes = ups4,
                QuestionId = 551,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer551);


            // UPS สำหรับคอมพิวเตอร์ตัวที่ 5 :
            string ups5 = Request.Form["upsRadio5"];
            Answer answer552 = new Answer()
            {
                AnsDes = ups5,
                QuestionId = 552,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer552);




            // Test ใช้งาน Internet (Speed Test) คอมพิวเตอร์ตัวที่ 1 :
            string speedTestRaio1 = Request.Form["speedTestRaio1"];
            Answer answer553 = new Answer()
            {
                AnsDes = speedTestRaio1,
                QuestionId = 553,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer553);



            // Test ใช้งาน Internet (Speed Test) คอมพิวเตอร์ตัวที่ 2 :
            string speedTestRaio2 = Request.Form["speedTestRaio2"];
            Answer answer554 = new Answer()
            {
                AnsDes = speedTestRaio2,
                QuestionId = 554,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer554);



            // Test ใช้งาน Internet (Speed Test) คอมพิวเตอร์ตัวที่ 3 :
            string speedTestRaio3 = Request.Form["speedTestRaio3"];
            Answer answer555 = new Answer()
            {
                AnsDes = speedTestRaio3,
                QuestionId = 555,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer555);




            // Test ใช้งาน Internet (Speed Test) คอมพิวเตอร์ตัวที่ 4 :
            string speedTestRaio4 = Request.Form["speedTestRaio4"];
            Answer answer556 = new Answer()
            {
                AnsDes = speedTestRaio4,
                QuestionId = 556,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer556);




            // Test ใช้งาน Internet (Speed Test) คอมพิวเตอร์ตัวที่ 5 :
            string speedTestRaio5 = Request.Form["speedTestRaio5"];
            Answer answer557 = new Answer()
            {
                AnsDes = speedTestRaio5,
                QuestionId = 557,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer557);










            //ป้ายและตัวเลขแสดงชื่อสถานี :
            string signandnumber = Request.Form["signandnumberRadio"];
            Answer answer1465 = new Answer()
            {
                AnsDes = signandnumber,
                QuestionId = 558,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer1465);

            //การติดตั้งและการยึดตู้อุปกรณ์ :
            string inStall = Request.Form["inStallRadio"];
            Answer answer1466 = new Answer()
            {
                AnsDes = inStall,
                QuestionId = 559,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer1466);


            //เสาไฟฟ้าที่ติดตั้งอุปกรณ์:
            string inStallSat = Request.Form["inStallSatRadio"];
            Answer answer1467 = new Answer()
            {
                AnsDes = inStallSat,
                QuestionId = 560,
                AnserTypeId = 3,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer1467);


            //แนวสายไฟฟ้าและสายเคเบิ้ลเข้าสถานี :
            string cabletoStationRadio = Request.Form["cabletoStationRadio"];
            Answer answer1471 = new Answer()
            {
                AnsDes = cabletoStationRadio,
                QuestionId = 561,
                AnserTypeId = 3,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer1471);

            //ช่อง Cable Inlet  และความสะอาด :
            string CableInlet = Request.Form["CableInletRadio"];
            Answer answer1468 = new Answer()
            {
                AnsDes = CableInlet,
                QuestionId = 562,
                AnserTypeId = 3,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer1468);


            //ช่อง Filter ความสะอาด (T-Power:
            string filterRadio = Request.Form["filterRadio"];
            Answer answer1469 = new Answer()
            {
                AnsDes = filterRadio,
                QuestionId = 563,
                AnserTypeId = 3,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer1469);


            //ประตูและยางขอบประตูของตู้อุปกรณ์ :
            string doorToolsRadio = Request.Form["doorToolsRadio"];
            Answer answer1470 = new Answer()
            {
                AnsDes = doorToolsRadio,
                QuestionId = 564,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer1470);




            // อุปกรณ์ LNB/BUC   :
            string tools = Request.Form["toolslnbRadio"];
            Answer answer88 = new Answer()
            {
                AnsDes = tools,
                QuestionId = 565,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer88);


            // การเก็บสาย RG และการพันหัว   :
            string toolsRG = Request.Form["wiringrgRadio"];
            Answer answer89 = new Answer()
            {
                AnsDes = toolsRG,
                QuestionId = 566,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer89);

            // ฐานและระดับของเสาจาน  :
            string baseOneiei = Request.Form["baseOnRadio"];
            Answer answer90 = new Answer()
            {
                AnsDes = baseOneiei,
                QuestionId = 567,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer90);


            // >แนว Line Of Sight  :
            string lineOf = Request.Form["xxlineOfsightRadio"];
            Answer answer91 = new Answer()
            {
                AnsDes = lineOf,
                QuestionId = 568,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer91);


            // แนว Line Of Sight  :
            string clendDish = Request.Form["cleaningDishRadio"];
            Answer answer92 = new Answer()
            {
                AnsDes = clendDish,
                QuestionId = 569,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer92);


            // LNB Band Switch  :
            string lnbswitch = Request.Form["lnbbandswitchRadio"];
            Answer answer93 = new Answer()
            {
                AnsDes = lnbswitch,
                QuestionId = 570,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer93);



            // ระบบ Solar Cell :
            string solarCells = Request.Form["solarcellSystemRadio"];
            Answer answer94 = new Answer()
            {
                AnsDes = solarCells,
                QuestionId = 571,
                AnserTypeId = 3,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer94);


            // แผง PV Panel:
            string pv = Request.Form["pvPanelRadio"];
            Answer answer95 = new Answer()
            {
                AnsDes = pv,
                QuestionId = 572,
                AnserTypeId = 3,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer95);

            // อุปกรณ์ Charger :
            string charGer = Request.Form["toolsCharger"];
            Answer answer96 = new Answer()
            {
                AnsDes = charGer,
                QuestionId = 573,
                AnserTypeId = 3,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer96);


            // ความสะอาดแผง PV :
            string cleanPv = Request.Form["cleanIngpvRadio"];
            Answer answer97 = new Answer()
            {
                AnsDes = cleanPv,
                QuestionId = 574,
                AnserTypeId = 3,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer97);


            // การติดตั้งแผง PV :
            string intPv = Request.Form["installPvRadio"];
            Answer answer98 = new Answer()
            {
                AnsDes = intPv,
                QuestionId = 575,
                AnserTypeId = 3,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer98);


            // แรงดันไฟจาก Inverter :          
            Answer voltInverterTextbox = new Answer()
            {
                AnsDes = this.voltInverterTextbox.Value,
                QuestionId = 576,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(voltInverterTextbox);


            // กระแส Load :          
            Answer loadVoltTageTextbox = new Answer()
            {
                AnsDes = this.loadVoltTageTextbox.Value,
                QuestionId = 577,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(loadVoltTageTextbox);


            // batterry 1 :          
            Answer answer1485 = new Answer()
            {
                AnsDes = this.batterTextbox1.Value,
                QuestionId = 578,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer1485);



            //  batterry 2 :          
            Answer answer1486 = new Answer()
            {
                AnsDes = this.batterTextbox2.Value,
                QuestionId = 579,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer1486);


            // batterry 3 :         
            Answer answer1487 = new Answer()
            {
                AnsDes = this.batterTextbox3.Value,
                QuestionId = 580,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer1487);


            //  batterry 4 :          
            Answer answer1488 = new Answer()
            {
                AnsDes = this.batterTextbox4.Value,
                QuestionId = 581,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer1488);



            // Download (for ONU/VSAT :          
            Answer answer1495 = new Answer()
            {
                AnsDes = this.dowloadOnuTextbox.Value,
                QuestionId = 582,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer1495);

            // Upload (for ONU/VSAT) :          
            Answer answer1496 = new Answer()
            {
                AnsDes = this.uploadforOnuTextbox.Value,
                QuestionId = 583,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer1496);

            // Ping Test (for ONU/VSAT) :          
            Answer answer1497 = new Answer()
            {
                AnsDes = this.pinngtestforOnuTextbox.Value,
                QuestionId = 584,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer1497);

            // Download (for Mobile:          
            Answer answer1498 = new Answer()
            {
                AnsDes = this.dowloadforMobileTextbox.Value,
                QuestionId = 585,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer1498);

            //  Upload (for Mobile :          
            Answer answer1499 = new Answer()
            {
                AnsDes = this.uploadforMobileTextbox.Value,
                QuestionId = 586,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer1499);


            // Ping Test(for Mobile)
            Answer answe1500 = new Answer()
            {
                AnsDes = this.pingtestFormobileTextbox.Value,
                QuestionId = 587,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answe1500);

            //  ปัญหาที่พบ 1 :           
            Answer answer110 = new Answer()
            {
                AnsDes = this.problemTextbox1.Value,
                QuestionId = 588,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer110);

            //  วิธีแก้ปัญหา 1 :           
            Answer answer111 = new Answer()
            {
                AnsDes = this.howtoSolveTextbox1.Value,
                QuestionId = 589,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer111);



            //  ปัญหาที่พบ 2 :           
            Answer answer112 = new Answer()
            {
                AnsDes = this.problemTextbox2.Value,
                QuestionId = 590,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer112);

            //  วิธีแก้ปัญหา 2 :           
            Answer answer113 = new Answer()
            {
                AnsDes = this.howtoSolveTextbox2.Value,
                QuestionId = 591,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer113);



            //  ปัญหาที่พบ 3 :           
            Answer answer114 = new Answer()
            {
                AnsDes = this.problemTextbox3.Value,
                QuestionId = 592,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer114);

            //  วิธีแก้ปัญหา 3 :           
            Answer answer115 = new Answer()
            {
                AnsDes = this.howtoSolveTextbox3.Value,
                QuestionId = 593,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer115);



            //  ปัญหาที่พบ 4 :           
            Answer answer116 = new Answer()
            {
                AnsDes = this.problemTextbox4.Value,
                QuestionId = 594,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer116);

            //  วิธีแก้ปัญหา 4 :           
            Answer answer117 = new Answer()
            {
                AnsDes = this.howtoSolveTextbox4.Value,
                QuestionId = 595,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer117);





            //  ปัญหาที่พบ 5 :           
            Answer answer118 = new Answer()
            {
                AnsDes = this.problemTextbox5.Value,
                QuestionId = 596,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer118);

            //  วิธีแก้ปัญหา 5 :           
            Answer answer119 = new Answer()
            {
                AnsDes = this.howtoSolveTextbox5.Value,
                QuestionId = 597,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer119);


            //  ปัญหาที่พบ 6 :           
            Answer answer120 = new Answer()
            {
                AnsDes = this.problemTextbox6.Value,
                QuestionId = 598,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer120);

            //  วิธีแก้ปัญหา 6 :           
            Answer answer121 = new Answer()
            {
                AnsDes = this.howtoSolveTextbox6.Value,
                QuestionId = 599,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer121);

            //  ปัญหาที่พบ 7 :           
            Answer answer122 = new Answer()
            {
                AnsDes = this.problemTextbox7.Value,
                QuestionId = 600,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer122);

            //  วิธีแก้ปัญหา 7 :           
            Answer answer123 = new Answer()
            {
                AnsDes = this.howtoSolveTextbox7.Value,
                QuestionId = 601,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer123);



            ///////////////////////////////////////////////////////////////////////////////
            //  ปัญหาที่พบ 8 :           
            Answer answer124 = new Answer()
            {
                AnsDes = this.problemTextbox8.Value,
                QuestionId = 602,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer124);

            //  วิธีแก้ปัญหา 8 :           
            Answer answer125 = new Answer()
            {
                AnsDes = this.howtoSolveTextbox8.Value,
                QuestionId = 603,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer125);
            //////////////////////////////////////////////////////////////////////////////////



            ///////////////////////////////////////////////////////////////////////////////
            //  ปัญหาที่พบ 9 :           
            Answer answer126 = new Answer()
            {
                AnsDes = this.problemTextbox9.Value,
                QuestionId = 604,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer126);

            //  วิธีแก้ปัญหา 9 :           
            Answer answer127 = new Answer()
            {
                AnsDes = this.howtoSolveTextbox9.Value,
                QuestionId = 605,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer127);
            //////////////////////////////////////////////////////////////////////////////////



            ///////////////////////////////////////////////////////////////////////////////
            //  ปัญหาที่พบ 10 :           
            Answer answer128 = new Answer()
            {
                AnsDes = this.problemTextbox10.Value,
                QuestionId = 606,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer128);

            //  วิธีแก้ปัญหา 10 :           
            Answer answer129 = new Answer()
            {
                AnsDes = this.howtoSolveTextbox10.Value,
                QuestionId = 607,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer129);
            //////////////////////////////////////////////////////////////////////////////////
            ///




            ///////////////////////////////////////////////////////////////////////////////
            //  ปัญหาที่พบ 11 :           
            Answer answer130 = new Answer()
            {
                AnsDes = this.problemTextbox11.Value,
                QuestionId = 608,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer130);

            //  วิธีแก้ปัญหา 11 :           
            Answer answer131 = new Answer()
            {
                AnsDes = this.howtoSolveTextbox11.Value,
                QuestionId = 609,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer131);
            //////////////////////////////////////////////////////////////////////////////////
            ///






            ///////////////////////////////////////////////////////////////////////////////
            //  ปัญหาที่พบ 12 :           
            Answer answer132 = new Answer()
            {
                AnsDes = this.problemTextbox12.Value,
                QuestionId = 610,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer132);

            //  วิธีแก้ปัญหา 12 :           
            Answer answer133 = new Answer()
            {
                AnsDes = this.howtoSolveTextbox12.Value,
                QuestionId = 611,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer133);
            //////////////////////////////////////////////////////////////////////////////////
            ///




            ///////////////////////////////////////////////////////////////////////////////
            //  ปัญหาที่พบ 13 :           
            Answer answer134 = new Answer()
            {
                AnsDes = this.problemTextbox13.Value,
                QuestionId = 612,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer134);

            //  วิธีแก้ปัญหา 13 :           
            Answer answer135 = new Answer()
            {
                AnsDes = this.howtoSolveTextbox13.Value,
                QuestionId = 613,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer135);
            //////////////////////////////////////////////////////////////////////////////////
            ///



            ///////////////////////////////////////////////////////////////////////////////
            //  ปัญหาที่พบ 14 :           
            Answer answer136 = new Answer()
            {
                AnsDes = this.problemTextbox14.Value,
                QuestionId = 614,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer136);

            //  วิธีแก้ปัญหา 14 :           
            Answer answer137 = new Answer()
            {
                AnsDes = this.howtoSolveTextbox14.Value,
                QuestionId = 615,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer137);
            //////////////////////////////////////////////////////////////////////////////////
            ///




            ///////////////////////////////////////////////////////////////////////////////
            //  ปัญหาที่พบ 15 :           
            Answer answer138 = new Answer()
            {
                AnsDes = this.problemTextbox15.Value,
                QuestionId = 616,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer138);

            //  วิธีแก้ปัญหา 15 :           
            Answer answer139 = new Answer()
            {
                AnsDes = this.howtoSolveTextbox15.Value,
                QuestionId = 617,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer139);
            //////////////////////////////////////////////////////////////////////////////////





            // รายการอุปกรณ์ 1 :      
            Answer answer141 = new Answer()
            {
                AnsDes = this.toolsListTextbox1.Value,
                QuestionId = 618,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer141);

            //  SerialNumber :           
            Answer answer142 = new Answer()
            {
                AnsDes = this.serialNumberTextbox1.Value,
                QuestionId = 619,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer142);

            //  new SerialNumber :           
            Answer answer143 = new Answer()
            {
                AnsDes = this.newSerialNumberTextbox1.Value,
                QuestionId = 620,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer143);

            //  หมายเหตุ :           
            Answer answer144 = new Answer()
            {
                AnsDes = this.noteTextbox1.Value,
                QuestionId = 621,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer144);
            //////////////////////////////////////////////////////////////////////////////////






            //////////////////////////////////////////////////////////////////////////////////
            // รายการอุปกรณ์ 2 :      
            Answer answer145 = new Answer()
            {
                AnsDes = this.toolsListTextbox2.Value,
                QuestionId = 622,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer145);

            //  SerialNumber 2 :           
            Answer answer146 = new Answer()
            {
                AnsDes = this.serialNumberTextbox2.Value,
                QuestionId = 623,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer146);

            //  new SerialNumber 2 :           
            Answer answer147 = new Answer()
            {
                AnsDes = this.newSerialNumberTextbox2.Value,
                QuestionId = 624,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer147);

            //  หมายเหตุ  2:           
            Answer answer148 = new Answer()
            {
                AnsDes = this.noteTextbox2.Value,
                QuestionId = 625,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer148);
            //////////////////////////////////////////////////////////////////////////////////



            //////////////////////////////////////////////////////////////////////////////////
            // รายการอุปกรณ์ 3 :      
            Answer answer149 = new Answer()
            {
                AnsDes = this.toolsListTextbox3.Value,
                QuestionId = 626,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer149);

            //  SerialNumber 3 :           
            Answer answer150 = new Answer()
            {
                AnsDes = this.serialNumberTextbox3.Value,
                QuestionId = 627,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer150);

            //  new SerialNumber 3 :           
            Answer answer151 = new Answer()
            {
                AnsDes = this.newSerialNumberTextbox3.Value,
                QuestionId = 628,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer151);

            //  หมายเหตุ  3:           
            Answer answer152 = new Answer()
            {
                AnsDes = this.noteTextbox3.Value,
                QuestionId = 629,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer152);
            //////////////////////////////////////////////////////////////////////////////////




            //////////////////////////////////////////////////////////////////////////////////
            // รายการอุปกรณ์ 4 :      
            Answer answer153 = new Answer()
            {
                AnsDes = this.toolsListTextbox4.Value,
                QuestionId = 630,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer153);

            //  SerialNumber 4 :           
            Answer answer154 = new Answer()
            {
                AnsDes = this.serialNumberTextbox4.Value,
                QuestionId = 631,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer154);

            //  new SerialNumber 4 :           
            Answer answer155 = new Answer()
            {
                AnsDes = this.newSerialNumberTextbox4.Value,
                QuestionId = 632,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer155);

            //  หมายเหตุ  4:           
            Answer answer156 = new Answer()
            {
                AnsDes = this.noteTextbox4.Value,
                QuestionId = 633,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer156);
            //////////////////////////////////////////////////////////////////////////////////




            //////////////////////////////////////////////////////////////////////////////////
            // รายการอุปกรณ์ 5 :      
            Answer answer157 = new Answer()
            {
                AnsDes = this.toolsListTextbox5.Value,
                QuestionId = 634,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer157);

            //  SerialNumber 5 :           
            Answer answer158 = new Answer()
            {
                AnsDes = this.serialNumberTextbox5.Value,
                QuestionId = 635,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer158);

            //  new SerialNumber 5 :           
            Answer answer159 = new Answer()
            {
                AnsDes = this.newSerialNumberTextbox5.Value,
                QuestionId = 636,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer159);

            //  หมายเหตุ  5:           
            Answer answer160 = new Answer()
            {
                AnsDes = this.noteTextbox5.Value,
                QuestionId = 637,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer160);
            //////////////////////////////////////////////////////////////////////////////////






            //////////////////////////////////////////////////////////////////////////////////
            // รายการอุปกรณ์ 6 :      
            Answer answer161 = new Answer()
            {
                AnsDes = this.toolsListTextbox6.Value,
                QuestionId = 638,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer161);

            //  SerialNumber 6 :           
            Answer answer162 = new Answer()
            {
                AnsDes = this.serialNumberTextbox6.Value,
                QuestionId = 639,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer162);

            //  new SerialNumber 6 :           
            Answer answer163 = new Answer()
            {
                AnsDes = this.newSerialNumberTextbox6.Value,
                QuestionId = 640,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer163);

            //  หมายเหตุ  6:           
            Answer answer164 = new Answer()
            {
                AnsDes = this.noteTextbox6.Value,
                QuestionId = 641,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer164);
            //////////////////////////////////////////////////////////////////////////////////




            //////////////////////////////////////////////////////////////////////////////////
            // รายการอุปกรณ์ 7 :      
            Answer answer165 = new Answer()
            {
                AnsDes = this.toolsListTextbox7.Value,
                QuestionId = 642,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer165);

            //  SerialNumber 7 :           
            Answer answer166 = new Answer()
            {
                AnsDes = this.serialNumberTextbox7.Value,
                QuestionId = 643,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer166);

            //  new SerialNumber 7 :           
            Answer answer167 = new Answer()
            {
                AnsDes = this.newSerialNumberTextbox7.Value,
                QuestionId = 644,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer167);

            //  หมายเหตุ  7:           
            Answer answer168 = new Answer()
            {
                AnsDes = this.noteTextbox7.Value,
                QuestionId = 645,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer168);
            //////////////////////////////////////////////////////////////////////////////////



            //////////////////////////////////////////////////////////////////////////////////
            // รายการอุปกรณ์ 8 :      
            Answer answer169 = new Answer()
            {
                AnsDes = this.toolsListTextbox8.Value,
                QuestionId = 646,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer169);

            //  SerialNumber 8 :           
            Answer answer170 = new Answer()
            {
                AnsDes = this.serialNumberTextbox8.Value,
                QuestionId = 647,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer170);

            //  new SerialNumber 8 :           
            Answer answer171 = new Answer()
            {
                AnsDes = this.newSerialNumberTextbox8.Value,
                QuestionId = 648,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer171);

            //  หมายเหตุ  8:           
            Answer answer172 = new Answer()
            {
                AnsDes = this.noteTextbox8.Value,
                QuestionId = 649,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer172);
            //////////////////////////////////////////////////////////////////////////////////



            //////////////////////////////////////////////////////////////////////////////////
            // รายการอุปกรณ์ 9 :      
            Answer answer173 = new Answer()
            {
                AnsDes = this.toolsListTextbox9.Value,
                QuestionId = 650,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer173);

            //  SerialNumber 9 :           
            Answer answer174 = new Answer()
            {
                AnsDes = this.serialNumberTextbox9.Value,
                QuestionId = 651,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer174);

            //  new SerialNumber 9 :           
            Answer answer175 = new Answer()
            {
                AnsDes = this.newSerialNumberTextbox9.Value,
                QuestionId = 652,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer175);

            //  หมายเหตุ  9:           
            Answer answer176 = new Answer()
            {
                AnsDes = this.noteTextbox9.Value,
                QuestionId = 653,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer176);
            //////////////////////////////////////////////////////////////////////////////////










            //////////////////////////////////////////////////////////////////////////////////
            // รายการอุปกรณ์ 10 :      
            Answer answer177 = new Answer()
            {
                AnsDes = this.toolsListTextbox10.Value,
                QuestionId = 654,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer177);

            //  SerialNumber 10 :           
            Answer answer178 = new Answer()
            {
                AnsDes = this.serialNumberTextbox10.Value,
                QuestionId = 655,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer178);

            //  new SerialNumber 10 :           
            Answer answer179 = new Answer()
            {
                AnsDes = this.newSerialNumberTextbox10.Value,
                QuestionId = 656,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer179);

            //  หมายเหตุ  10:           
            Answer answer180 = new Answer()
            {
                AnsDes = this.noteTextbox10.Value,
                QuestionId = 657,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer180);
            //////////////////////////////////////////////////////////////////////////////////






            //////////////////////////////////////////////////////////////////////////////////
            // รายการอุปกรณ์ 11 :      
            Answer answer181 = new Answer()
            {
                AnsDes = this.toolsListTextbox11.Value,
                QuestionId = 658,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer181);

            //  SerialNumber 11 :           
            Answer answer182 = new Answer()
            {
                AnsDes = this.serialNumberTextbox11.Value,
                QuestionId = 659,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer182);

            //  new SerialNumber 11 :           
            Answer answer183 = new Answer()
            {
                AnsDes = this.newSerialNumberTextbox11.Value,
                QuestionId = 660,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer183);

            //  หมายเหตุ  11:           
            Answer answer184 = new Answer()
            {
                AnsDes = this.noteTextbox11.Value,
                QuestionId = 661,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer184);
            //////////////////////////////////////////////////////////////////////////////////
            ///








            //////////////////////////////////////////////////////////////////////////////////
            // รายการอุปกรณ์ 12 :      
            Answer answer185 = new Answer()
            {
                AnsDes = this.toolsListTextbox12.Value,
                QuestionId = 662,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer185);

            //  SerialNumber 12 :           
            Answer answer186 = new Answer()
            {
                AnsDes = this.serialNumberTextbox12.Value,
                QuestionId = 663,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer186);

            //  new SerialNumber 12 :           
            Answer answer187 = new Answer()
            {
                AnsDes = this.newSerialNumberTextbox12.Value,
                QuestionId = 664,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer187);

            //  หมายเหตุ  12:           
            Answer answer188 = new Answer()
            {
                AnsDes = this.noteTextbox12.Value,
                QuestionId = 665,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer188);
            //////////////////////////////////////////////////////////////////////////////////
            ///






            //////////////////////////////////////////////////////////////////////////////////
            // รายการอุปกรณ์ 13 :      
            Answer answer189 = new Answer()
            {
                AnsDes = this.toolsListTextbox13.Value,
                QuestionId = 666,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer189);

            //  SerialNumber 13 :           
            Answer answer190 = new Answer()
            {
                AnsDes = this.serialNumberTextbox13.Value,
                QuestionId = 667,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer190);

            //  new SerialNumber 13 :           
            Answer answer191 = new Answer()
            {
                AnsDes = this.newSerialNumberTextbox13.Value,
                QuestionId = 668,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer191);

            //  หมายเหตุ  13   :    
            Answer answer192 = new Answer()
            {
                AnsDes = this.noteTextbox13.Value,
                QuestionId = 669,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer192);
            //////////////////////////////////////////////////////////////////////////////////



            //////////////////////////////////////////////////////////////////////////////////
            // รายการอุปกรณ์ 14 :      
            Answer answer193 = new Answer()
            {
                AnsDes = this.toolsListTextbox14.Value,
                QuestionId = 670,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer193);

            //  SerialNumber 14 :           
            Answer answer194 = new Answer()
            {
                AnsDes = this.serialNumberTextbox14.Value,
                QuestionId = 671,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer194);

            //  new SerialNumber 14 :           
            Answer answer195 = new Answer()
            {
                AnsDes = this.newSerialNumberTextbox14.Value,
                QuestionId = 672,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer195);

            //  หมายเหตุ  143   :    
            Answer answer196 = new Answer()
            {
                AnsDes = this.noteTextbox14.Value,
                QuestionId = 673,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer196);
            //////////////////////////////////////////////////////////////////////////////////






            //////////////////////////////////////////////////////////////////////////////////
            // รายการอุปกรณ์ 15 :      
            Answer answer197 = new Answer()
            {
                AnsDes = this.toolsListTextbox15.Value,
                QuestionId = 674,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer197);

            //  SerialNumber 15 :           
            Answer answer198 = new Answer()
            {
                AnsDes = this.serialNumberTextbox15.Value,
                QuestionId = 675,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer198);

            //  new SerialNumber 15 :           
            Answer answer199 = new Answer()
            {
                AnsDes = this.newSerialNumberTextbox15.Value,
                QuestionId = 676,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer199);

            //  หมายเหตุ  15   :    
            Answer answer200 = new Answer()
            {
                AnsDes = this.noteTextbox15.Value,
                QuestionId = 677,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer200);
            //////////////////////////////////////////////////////////////////////////////////
            ///


            //   name pm :    
            Answer answer1591 = new Answer()
            {
                AnsDes = this.nameDopmTextbox.Value,
                QuestionId = 678,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer1591);


            //  วันที่ทำ PM :    
            Answer answer1592 = new Answer()
            {
                AnsDes = this.dayDopmTextbox.Value,
                QuestionId = 679,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer1592);


            // รูปภาพรวมบริเวณ Site :
            string steAreaRadio = Request.Form["steAreaRadio"];
            Answer answer1593 = new Answer()
            {
                AnsDes = steAreaRadio,
                QuestionId = 680,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer1593);


            // รูปหน้าตู้ ก่อน-หลัง Site :
            string beforeAfterRadio = Request.Form["beforeAfterRadio"];
            Answer answer1594 = new Answer()
            {
                AnsDes = beforeAfterRadio,
                QuestionId = 681,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer1594);


            // รูปภายในตู้ ก่อน-หลัง :
            string picIncontainRadio = Request.Form["picIncontainRadio"];
            Answer answer1595 = new Answer()
            {
                AnsDes = picIncontainRadio,
                QuestionId = 682,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer1595);


            // รูปขณะทำความสะอาดตู้ ก่อน-หลัง :
            string beforeCleanRaio = Request.Form["beforeCleanRaio"];
            Answer answer1596 = new Answer()
            {
                AnsDes = beforeCleanRaio,
                QuestionId = 683,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer1596);


            // รูปสถานะ Circuit Breaker (ON):
            string circuitBreakOnRaio = Request.Form["circuitBreakOnRaio"];
            Answer answer1597 = new Answer()
            {
                AnsDes = beforeCleanRaio,
                QuestionId = 684,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer1597);


            // รูปการตรวจสอบ Ground และ Bar Ground :
            string GroundAndBarGroundRaio = Request.Form["GroundAndBarGroundRaio"];
            Answer answer1600 = new Answer()
            {
                AnsDes = GroundAndBarGroundRaio,
                QuestionId = 685,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer1600);


            // รูปการตรวจสอบสถานะไฟฟ้ารั่วลง Ground (Lamp Test:
            string groundLampRadio = Request.Form["groundLampRadio"];
            Answer answer1601 = new Answer()
            {
                AnsDes = groundLampRadio,
                QuestionId = 686,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer1601);

            // รูป PEA Meter :
            string peaMeterRaio = Request.Form["peaMeterRaio"];
            Answer answer1602 = new Answer()
            {
                AnsDes = peaMeterRaio,
                QuestionId = 687,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer1602);


            // >รูปการวัดแรงดัน AC และกระแส AC :
            string acAndACRadio = Request.Form["acAndACRadio"];
            Answer answer1603 = new Answer()
            {
                AnsDes = acAndACRadio,
                QuestionId = 688,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer1603);


            // รูปหน้าจอ UPS แสดงค่าต่างๆ และ Serial NO. :
            string monitorSerRadio = Request.Form["monitorSerRadio"];
            Answer answer1604 = new Answer()
            {
                AnsDes = acAndACRadio,
                QuestionId = 689,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer1604);



            // รูป ONU/Modem พร้อม Serial NO. และ MAC :
            string ONUModemAndMacRadio = Request.Form["ONUModemAndMacRadio"];
            Answer answer1605 = new Answer()
            {
                AnsDes = ONUModemAndMacRadio,
                QuestionId = 690,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer1605);


            // รูป Power Supply พร้อม Serial NO.  :
            string psuAndSerialRadio = Request.Form["psuAndSerialRadio"];
            Answer answer454 = new Answer()
            {
                AnsDes = psuAndSerialRadio,
                QuestionId = 691,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer454);


            // รูป Switch 8 Port พร้อม Serial NO. และ MAC  :
            string switch8PortRadio = Request.Form["switch8PortRadio"];
            Answer answer455 = new Answer()
            {
                AnsDes = switch8PortRadio,
                QuestionId = 692,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer455);


            // รูป Outdoor AP 2.4 GHz พร้อม Serial NO. และ MAC :
            string outDoorApRadio = Request.Form["outDoorApRadio"];
            Answer answer456 = new Answer()
            {
                AnsDes = outDoorApRadio,
                QuestionId = 693,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer456);

            // รูป Outdoor AP 5 GHz พร้อม Serial NO. และ MAC :
            string outDoorAp5GhzRadio = Request.Form["outDoorAp5GhzRadio"];
            Answer answer457 = new Answer()
            {
                AnsDes = outDoorAp5GhzRadio,
                QuestionId = 694,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer457);

            // รูปการ Test Speed ONU (30/10 mbps) :
            string testSpeedOnuRadio = Request.Form["testSpeedOnuRadio"];
            Answer answer1606 = new Answer()
            {
                AnsDes = testSpeedOnuRadio,
                QuestionId = 695,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer1606);

            // รูปการ Test Speed VSAT (30/5 mbps) *เฉพาะ SAT :
            string testSpeedVsatRadio = Request.Form["testSpeedVsatRadio"];
            Answer answer459 = new Answer()
            {
                AnsDes = testSpeedVsatRadio,
                QuestionId = 696,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer459);


            // รูป Cable Inlet ด้านในและด้านนอก :
            string cableInlet = Request.Form["eieicableInletRadio"];
            Answer answer460 = new Answer()
            {
                AnsDes = cableInlet,
                QuestionId = 697,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer460);

            // รูป Filter ก่อน-หลัง ทำความสะอาด :
            string filterBeforeCleanRadio = Request.Form["filterBeforeCleanRadio"];
            Answer answer461 = new Answer()
            {
                AnsDes = filterBeforeCleanRadio,
                QuestionId = 698,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer461);





            // รูปจุดติดตั้งจานดาวเทียม :
            string inStallSatRadio = Request.Form["inStallSatRadio"];
            Answer answer1614 = new Answer()
            {
                AnsDes = inStallSatRadio,
                QuestionId = 699,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer1614);


            // รูปความสะอาดบริเวณจานดาวเทียม :
            string cleanSatRadio = Request.Form["cleanSatRadio"];
            Answer answer1615 = new Answer()
            {
                AnsDes = cleanSatRadio,
                QuestionId = 700,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer1615);



            //รูป LNB พร้อม Part NO :
            string lnbWithpartRadio = Request.Form["lnbWithpartRadio"];
            Answer answer1616 = new Answer()
            {
                AnsDes = lnbWithpartRadio,
                QuestionId = 701,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer1616);


            //รูป BUC พร้อม Part NO :
            string bucWithpartRadio = Request.Form["bucWithpartRadio"];
            Answer answer1617 = new Answer()
            {
                AnsDes = bucWithpartRadio,
                QuestionId = 702,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer1617);


            //รูปการเก็บสายและพันหัวที่ LNB/BUC :
            string wireingLnbRadio = Request.Form["wireingLnbRadio"];
            Answer answer1618 = new Answer()
            {
                AnsDes = wireingLnbRadio,
                QuestionId = 703,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer1618);


            //แนว Line Of Sight (ดูการถูกบังของหน้าจานดาวเทียม)  :
            string lineOfsightRadio = Request.Form["lineOfsightRadio"];
            Answer answer1619 = new Answer()
            {
                AnsDes = lineOfsightRadio,
                QuestionId = 704,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer1619);




            // SECTION 42
            //รูปจุดติดตั้ง Solar Cell  :
            string solarCellRadio = Request.Form["solarCellRadio"];
            Answer answer1620 = new Answer()
            {
                AnsDes = solarCellRadio,
                QuestionId = 705,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer1620);


            //รูปจุดติดตั้ง Solar Cell :
            string toolsinSolarcellRadio = Request.Form["toolsinSolarcellRadio"];
            Answer answer1621 = new Answer()
            {
                AnsDes = toolsinSolarcellRadio,
                QuestionId = 706,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer1621);



            //รูปหน้าจอ Charger แสดงค่าต่างๆ:
            string chargerRadio = Request.Form["chargerRadio"];
            Answer answer470 = new Answer()
            {
                AnsDes = chargerRadio,
                QuestionId = 707,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer470);



            //รูปหน้าจอ Inverter แสดงค่าต่างๆ:
            string snowingInverter = Request.Form["snowingInverterRadio"];
            Answer answer471 = new Answer()
            {
                AnsDes = snowingInverter,
                QuestionId = 708,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer471);



            //รูป Circuit Breaker ภายในตู้:
            string cirBreakerRadio = Request.Form["cirBreakerRadio"];
            Answer answer472 = new Answer()
            {
                AnsDes = cirBreakerRadio,
                QuestionId = 709,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer472);


            //>รูป Terminal ต่อสายภายในตู้ :
            string termialInnerRadio = Request.Form["termialInnerRadio"];
            Answer answer473 = new Answer()
            {
                AnsDes = termialInnerRadio,
                QuestionId = 710,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer473);




            // รูปการวัดแรงดัน Battery ก้อนที่ 1 :
            string batteryVoltRadio1 = Request.Form["batteryVoltRadio1"];
            Answer answer1626 = new Answer()
            {
                AnsDes = batteryVoltRadio1,
                QuestionId = 711,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer1626);

            // รูปการวัดแรงดัน Battery ก้อนที่ 2 :
            string batteryVoltRadio2 = Request.Form["batteryVoltRadio2"];
            Answer answer1627 = new Answer()
            {
                AnsDes = batteryVoltRadio2,
                QuestionId = 712,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer1627);



            // รูปการวัดแรงดัน Battery ก้อนที่ 3 :
            string batteryVoltRadio3 = Request.Form["batteryVoltRadio3"];
            Answer answer1628 = new Answer()
            {
                AnsDes = batteryVoltRadio3,
                QuestionId = 713,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer1628);



            // รูปการวัดแรงดัน Battery ก้อนที่ 4 :
            string batteryVoltRadio4 = Request.Form["batteryVoltRadio4"];
            Answer answer1629 = new Answer()
            {
                AnsDes = batteryVoltRadio4,
                QuestionId = 714,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer1629);




            // รูปความสะอาดแผง PV :
            string cleaninPVVRADIO = Request.Form["cleaninPVVRADIO"];
            Answer answer478 = new Answer()
            {
                AnsDes = cleaninPVVRADIO,
                QuestionId = 715,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer478);


            // รูปภาพรวมดูสิ่งบดบังแสงอาทิตย์ :
            string sunnyRadio = Request.Form["sunnyRadio"];
            Answer answer479 = new Answer()
            {
                AnsDes = sunnyRadio,
                QuestionId = 716,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer479);








            // คอมพิวเตอร์ตัวที่ 1  :
            string PicComRadio1 = Request.Form["PicComRadio1"];
            Answer answer717 = new Answer()
            {
                AnsDes = PicComRadio1,
                QuestionId = 717,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer717);


            // คอมพิวเตอร์ตัวที่ 2  :
            string PicComRadio2 = Request.Form["PicComRadio2"];
            Answer answer718 = new Answer()
            {
                AnsDes = PicComRadio2,
                QuestionId = 718,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer718);


            // คอมพิวเตอร์ตัวที่ 3  :
            string PicComRadio3 = Request.Form["PicComRadio3"];
            Answer answer719 = new Answer()
            {
                AnsDes = PicComRadio3,
                QuestionId = 719,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer719);


            // คอมพิวเตอร์ตัวที่ 4  :
            string PicComRadio4 = Request.Form["PicComRadio4"];
            Answer answer720 = new Answer()
            {
                AnsDes = PicComRadio4,
                QuestionId = 720,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer720);



            // คอมพิวเตอร์ตัวที่ 5  :
            string PicComRadio5 = Request.Form["PicComRadio5"];
            Answer answer721 = new Answer()
            {
                AnsDes = PicComRadio5,
                QuestionId = 721,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer721);


            // UPS สำหรับคอมพิวเตอร์ตัวที่ 1 :
            string PicupsRadio1 = Request.Form["PicupsRadio1"];
            Answer answer722 = new Answer()
            {
                AnsDes = PicupsRadio1,
                QuestionId = 722,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer722);


            // UPS สำหรับคอมพิวเตอร์ตัวที่ 2 :
            string PicupsRadio2 = Request.Form["PicupsRadio2"];
            Answer answer723 = new Answer()
            {
                AnsDes = PicupsRadio2,
                QuestionId = 723,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer723);


            // UPS สำหรับคอมพิวเตอร์ตัวที่ 3 :
            string PicupsRadio3 = Request.Form["PicupsRadio3"];
            Answer answer724 = new Answer()
            {
                AnsDes = PicupsRadio3,
                QuestionId = 724,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer724);



            // UPS สำหรับคอมพิวเตอร์ตัวที่ 4 :
            string PicupsRadio4 = Request.Form["PicupsRadio4"];
            Answer answer725 = new Answer()
            {
                AnsDes = PicupsRadio4,
                QuestionId = 725,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer725);


            // UPS สำหรับคอมพิวเตอร์ตัวที่ 5 :
            string PicupsRadio5 = Request.Form["PicupsRadio5"];
            Answer answer726 = new Answer()
            {
                AnsDes = PicupsRadio5,
                QuestionId = 726,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer726);




            // Test ใช้งาน Internet (Speed Test) คอมพิวเตอร์ตัวที่ 1 :
            string PicspeedTestRaio1 = Request.Form["PicspeedTestRaio1"];
            Answer answer727 = new Answer()
            {
                AnsDes = PicspeedTestRaio1,
                QuestionId = 727,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer727);



            // Test ใช้งาน Internet (Speed Test) คอมพิวเตอร์ตัวที่ 2 :
            string PicspeedTestRaio2 = Request.Form["PicspeedTestRaio2"];
            Answer answer728 = new Answer()
            {
                AnsDes = PicspeedTestRaio2,
                QuestionId = 728,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer728);



            // Test ใช้งาน Internet (Speed Test) คอมพิวเตอร์ตัวที่ 3 :
            string PicspeedTestRaio3 = Request.Form["PicspeedTestRaio3"];
            Answer answer729 = new Answer()
            {
                AnsDes = PicspeedTestRaio3,
                QuestionId = 729,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer729);




            // Test ใช้งาน Internet (Speed Test) คอมพิวเตอร์ตัวที่ 4 :
            string PicspeedTestRaio4 = Request.Form["PicspeedTestRaio4"];
            Answer answer730 = new Answer()
            {
                AnsDes = PicspeedTestRaio4,
                QuestionId = 730,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer730);




            // Test ใช้งาน Internet (Speed Test) คอมพิวเตอร์ตัวที่ 5 :
            string PicspeedTestRaio5 = Request.Form["PicspeedTestRaio5"];
            Answer answer731 = new Answer()
            {
                AnsDes = PicspeedTestRaio5,
                QuestionId = 731,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer731);






            //1.รูป PICTURE CHECKLIST :
            if (this.pictureChecklistImages.HasFile)
            {
                string extension = this.pictureChecklistImages.PostedFile.FileName.Split('.')[1];
                string newFileName = "images/pictureChecklist_" + DateTime.Now.ToString("yyyyMMddHHmmss") + "." + extension;
                this.pictureChecklistImages.PostedFile.SaveAs(Server.MapPath(newFileName));

                Answer answer259 = new Answer()
                {
                    AnsDes = newFileName,
                    QuestionId = 732,
                    AnserTypeId = 3,
                    CreateDate = DateTime.Now,
                    UserId = 1
                };
                uSOEntities.Answers.Add(answer259);
            }


            //2.รูป VSAT PICTURE CHECKLIST :
            if (this.vsatpictureChecklistImages.HasFile)
            {
                string extension = this.vsatpictureChecklistImages.PostedFile.FileName.Split('.')[1];
                string newFileName = "images/VsatPictureChecklist_" + DateTime.Now.ToString("yyyyMMddHHmmss") + "." + extension;
                this.vsatpictureChecklistImages.PostedFile.SaveAs(Server.MapPath(newFileName));

                Answer answer260 = new Answer()
                {
                    AnsDes = newFileName,
                    QuestionId = 733,
                    AnserTypeId = 3,
                    CreateDate = DateTime.Now,
                    UserId = 1
                };
                uSOEntities.Answers.Add(answer260);
            }



            //3.รูป SOLAR CELL PICTURE CHECKLISTT :
            if (this.solarcellpictureChecklistImages.HasFile)
            {
                string extension = this.solarcellpictureChecklistImages.PostedFile.FileName.Split('.')[1];
                string newFileName = "images/SolarcellPictureChecklist_" + DateTime.Now.ToString("yyyyMMddHHmmss") + "." + extension;
                this.solarcellpictureChecklistImages.PostedFile.SaveAs(Server.MapPath(newFileName));

                Answer answer261 = new Answer()
                {
                    AnsDes = newFileName,
                    QuestionId = 734,
                    AnserTypeId = 3,
                    CreateDate = DateTime.Now,
                    UserId = 1
                };
                uSOEntities.Answers.Add(answer261);
            }






            //4. COMPUTER PICTURE CHECKLIST :
            if (this.computerChecklistImages.HasFile)
            {
                string extension = this.computerChecklistImages.PostedFile.FileName.Split('.')[1];
                string newFileName = "images/SolarcellPictureChecklist_" + DateTime.Now.ToString("yyyyMMddHHmmss") + "." + extension;
                this.computerChecklistImages.PostedFile.SaveAs(Server.MapPath(newFileName));

                Answer answer261 = new Answer()
                {
                    AnsDes = newFileName,
                    QuestionId = 735,
                    AnserTypeId = 3,
                    CreateDate = DateTime.Now,
                    UserId = 1
                };
                uSOEntities.Answers.Add(answer261);
            }


















































            int result = uSOEntities.SaveChanges();
            if (result > 0)
            {
                this.SuccessPanel.Visible = true;
            }


        }

    }
}