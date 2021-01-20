using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CommonClassLibrary;

namespace USOform.Preventive_Maintenance__PM__Report_BB2._4
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
            if (this.logoPicture2.HasFile)
            {
                string extension = this.logoPicture2.PostedFile.FileName.Split('.')[1];
                string newFileName = "images/logoImages_" + DateTime.Now.ToString("yyyyMMddHHmmss") + "." + extension;
                this.logoPicture2.PostedFile.SaveAs(Server.MapPath(newFileName));

                Answer answe264 = new Answer()
                {
                    AnsDes = newFileName,
                    QuestionId = 264,
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
                QuestionId = 265,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer1409);

            // ภูมิภาค
            Answer answer1410 = new Answer()
            {
                AnsDes = this.AreaTextbox.Value,
                QuestionId = 266,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer1410);

            // บริษัท
            Answer answer3 = new Answer()
            {
                AnsDes = this.CompanyTextbox.Value,
                QuestionId = 267,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer3);



            //รอบการบำรุงรักษาครั้งที่
            Answer answer4 = new Answer()
            {
                AnsDes = this.maintenanceCountTextbox.Value,
                QuestionId = 268,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer4);

            //ปีพุทธศักราช
            Answer answer5 = new Answer()
            {
                AnsDes = this.yearTextbox.Value,
                QuestionId = 269,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer5);

            //วัน เดือน ปี ที่เริ่มต้น
            Answer answer8 = new Answer()
            {
                AnsDes = this.startDatepicker.Value,
                QuestionId = 270,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1,

            };
            uSOEntities.Answers.Add(answer8);

            //ถึง 
            Answer answer9 = new Answer()
            {
                AnsDes = this.endDatepicker.Value,
                QuestionId = 271,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1,

            };
            uSOEntities.Answers.Add(answer9);

            //สถานที่ SITE CODE
            Answer answer10 = new Answer()
            {
                AnsDes = this.siteCodeTextbox.Value,
                QuestionId = 1634,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer10);

            ///-------END  HEADING--------------------



            //////////////////////////////////    Sectionid  = 27    /////////////////////////////////
            ///
            //Cabinet ID:
            Answer answer11 = new Answer()
            {
                AnsDes = this.cabinetIdTextbox.Value,
                QuestionId = 272,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer11);

            //Site Code :
            Answer answer12 = new Answer()
            {
                AnsDes = this.sitecodeTextboxSection2.Value,
                QuestionId = 273,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer12);

            //Village ID :
            Answer answer13 = new Answer()
            {
                AnsDes = this.VillageIdTextbox.Value,
                QuestionId = 274,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer13);

            //PHO’s Name : :
            Answer answer275 = new Answer()
            {
                AnsDes = this.phoNameTextbox.Value,
                QuestionId = 275,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer275);


            //Village  :
            Answer answer14 = new Answer()
            {
                AnsDes = this.villageTextbox.Value,
                QuestionId = 276,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer14);



            //Sub-District :
            Answer answer16 = new Answer()
            {
                AnsDes = this.subdistrictTextbox.Value,
                QuestionId = 277,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer16);


            //District :
            Answer answer1423 = new Answer()
            {
                AnsDes = this.DistrictTextbox.Value,
                QuestionId = 278,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer1423);

            //Province :
            Answer answer17 = new Answer()
            {
                AnsDes = this.provinceTextbox.Value,
                QuestionId = 279,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer17);

            //Type :
            Answer answer18 = new Answer()
            {
                AnsDes = this.typeTextbox.Value,
                QuestionId = 280,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer18);

            //PM Date :
            Answer answer19 = new Answer()
            {
                AnsDes = this.pmdateTextbox.Value,
                QuestionId = 281,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer19);




            //ใส่รูปหน้าอาคารศูนย์ USO Net :
            if (this.picinfrontImages.HasFile)
            {
                string extension = this.picinfrontImages.PostedFile.FileName.Split('.')[1];
                string newFileName = "images/picinfrontImages_" + DateTime.Now.ToString("yyyyMMddHHmmss") + "." + extension;
                this.picinfrontImages.PostedFile.SaveAs(Server.MapPath(newFileName));

                Answer answer20 = new Answer()
                {
                    AnsDes = newFileName,
                    QuestionId = 1635,
                    AnserTypeId = 3,
                    CreateDate = DateTime.Now,
                    UserId = 1
                };
                uSOEntities.Answers.Add(answer20);
            }

        




            //////////////////////////////////    Sectionid  = 27    /////////////////////////////////
            ///

            //signature Executor :
            Answer answer21 = new Answer()
            {
                AnsDes = this.signatureExecutorTextbox.Value,
                QuestionId = 282,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer21);

            //signature Supervisor :
            Answer answer22 = new Answer()
            {
                AnsDes = this.signatureSupervisorTextbox.Value,
                QuestionId = 283,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer22);

            //name Executor  :
            Answer answer23 = new Answer()
            {
                AnsDes = this.nameExecutorTextbox.Value,
                QuestionId = 284,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer23);

            //name Supervisor :
            Answer answer24 = new Answer()
            {
                AnsDes = this.nameSupervisorTextbox.Value,
                QuestionId = 285,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer24);

            //Date Executor :
            Answer answer25 = new Answer()
            {
                AnsDes = this.DateExecutorTextbox.Value,
                QuestionId = 286,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer25);

            //Date Supervisor :
            Answer answer26 = new Answer()
            {
                AnsDes = this.DateSupervisorTextbox.Value,
                QuestionId = 287,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer26);




            //////////////////////////////////    Sectionid  = 29    /////////////////////////////////
            
            //cabibnet  :
            Answer answer27 = new Answer()
            {
                AnsDes = this.cabinetId2Textbox.Value,
                QuestionId = 288,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer27);

            //Site code section 4 :
            Answer answer28 = new Answer()
            {
                AnsDes = this.sitecodeTextboxSection4.Value,
                QuestionId = 289,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer28);


            //villageIDsection 4 :
            Answer answer29 = new Answer()
            {
                AnsDes = this.villageIDTextboxSection4.Value,
                QuestionId = 290,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer29);

            //lat and long  :
            Answer answer30 = new Answer()
            {
                AnsDes = this.latandlongTextbox.Value,
                QuestionId = 291,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer30);



            //TypeofSignal :
            string typeOf = Request.Form["TypeofSignaleieiRadio"];
            Answer answer31 = new Answer()
            {
                AnsDes = typeOf,
                QuestionId = 292,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer31);

            //OLT ID : :
            Answer answer1440 = new Answer()
            {
                AnsDes = this.oltIdTextbox.Value,
                QuestionId = 293,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer1440);








            //////////////////////////////////    Sectionid  = 29    /////////////////////////////////
            //ระบบไฟฟ้า :
            string typeOffire = Request.Form["voltSystemRadio"];
            Answer answer294 = new Answer()
            {
                AnsDes = typeOffire,
                QuestionId = 294,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer294);


            //หมายเลขผู้ใช้ไฟ:
            Answer answer1442 = new Answer()
            {
                AnsDes = this.numberIdTextbox.Value,
                QuestionId = 295,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer1442);




            //หน่วยใช้ไฟไฟ  :
            Answer answer36 = new Answer()
            {
                AnsDes = this.kwhMeterTextbox.Value,
                QuestionId = 296,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer36);


            //แรงดัน AC (kWh Meter) :
            Answer answer37 = new Answer()
            {
                AnsDes = this.acvoltTextbox.Value,
                QuestionId = 297,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer37);


            //กระแส Line AC (kWh Meter) :
            Answer answer38 = new Answer()
            {
                AnsDes = this.lineAcTextbox.Value,
                QuestionId = 298,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer38);


            // กระแส Neutron AC(kWh Meter) :          
            Answer answer39 = new Answer()
            {
                AnsDes = this.neutronAcEIEITextbox.Value,
                QuestionId = 299,
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
                QuestionId = 300,
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
                QuestionId = 301,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer41);






            //////////////////////////////////    Sectionid  = 30    /////////////////////////////////
            //UPS ภายในตู้ Radio  :
            string innerUPS = Request.Form["inupsRadio"];
            Answer answer42 = new Answer()
            {
                AnsDes = innerUPS,
                QuestionId = 302,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer42);


            // AC from UPS :          
            Answer answer43 = new Answer()
            {
                AnsDes = this.acfromupsTextbox.Value,
                QuestionId = 303,
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
                QuestionId = 304,
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
                QuestionId = 305,
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
                QuestionId = 306,
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
                QuestionId = 307,
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
                QuestionId = 308,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer1455);









            ////   Sectionid  = 31    
            // ONU/Modem Network :  
            string ONUModemNetwork = Request.Form["ONUModemNetworkRadio"];
            Answer answer1456 = new Answer()
            {
                AnsDes = ONUModemNetwork,
                QuestionId = 309,
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
                QuestionId = 310,
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
                QuestionId = 311,
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
                QuestionId = 312,
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
                QuestionId = 313,
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
                QuestionId = 314,
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
                QuestionId = 315,
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
                QuestionId = 316,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer315);







            ////   Sectionid  = 32   
            ///
            //ความแข็งแรงจุดต่อ Ground Bar :
            string gb = Request.Form["groundbarRadio"];
            Answer answer57 = new Answer()
            {
                AnsDes = gb,
                QuestionId = 317,
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
                QuestionId = 318,
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
                QuestionId = 319,
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
                QuestionId = 320,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer60);







            ////   Sectionid  = 33 
            //ป้ายและตัวเลขแสดงชื่อสถานี :
            string signandnumber = Request.Form["signandnumberRadio"];
            Answer answer1465 = new Answer()
            {
                AnsDes = signandnumber,
                QuestionId = 321,
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
                QuestionId = 322,
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
                QuestionId = 323,
                AnserTypeId = 3,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer1467);


            //ช่อง Cable Inlet  และความสะอาด :
            string CableInlet = Request.Form["CableInletRadio"];
            Answer answer1468 = new Answer()
            {
                AnsDes = CableInlet,
                QuestionId = 324,
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
                QuestionId = 325,
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
                QuestionId = 326,
                AnserTypeId = 4,
                CreateDate = DateTime.Now, 
                UserId = 1
            };
            uSOEntities.Answers.Add(answer1470);


            //แนวสายไฟฟ้าและสายเคเบิ้ลเข้าสถานี :
            string cabletoStationRadio = Request.Form["cabletoStationRadio"];
            Answer answer1471 = new Answer()
            {
                AnsDes = cabletoStationRadio,
                QuestionId = 327,
                AnserTypeId = 3,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer1471);



            ////----------------------------------   Sectionid  = 34
            // อุปกรณ์ LNB/BUC   :
            string tools = Request.Form["toolslnbRadio"];
            Answer answer88 = new Answer()
            {
                AnsDes = tools,
                QuestionId = 328,
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
                QuestionId = 329,
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
                QuestionId = 330,
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
                QuestionId = 331,
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
                QuestionId = 332,
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
                QuestionId = 333,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer93);






            ////----------------------------------   Sectionid  = 35
            // ระบบ Solar Cell :
            string solarCells = Request.Form["solarcellSystemRadio"];
            Answer answer94 = new Answer()
            {
                AnsDes = solarCells,
                QuestionId = 334,
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
                QuestionId = 335,
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
                QuestionId = 336,
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
                QuestionId = 337,
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
                QuestionId = 338,
                AnserTypeId = 3,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer98);


            // แรงดันไฟจาก Inverter :          
            Answer voltInverterTextbox = new Answer()
            {
                AnsDes = this.voltInverterTextbox.Value,
                QuestionId = 339,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(voltInverterTextbox);


            // กระแส Load :          
            Answer loadVoltTageTextbox = new Answer()
            {
                AnsDes = this.loadVoltTageTextbox.Value,
                QuestionId = 340,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(loadVoltTageTextbox);


            // batterry 1 :          
            Answer answer1485 = new Answer()
            {
                AnsDes = this.batterTextbox1.Value,
                QuestionId = 341,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer1485);



            //  batterry 2 :          
            Answer answer1486 = new Answer()
            {
                AnsDes = this.batterTextbox2.Value,
                QuestionId = 342,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer1486);


            // batterry 3 :         
            Answer answer1487 = new Answer()
            {
                AnsDes = this.batterTextbox3.Value,
                QuestionId = 343,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer1487);


            //  batterry 4 :          
            Answer answer1488 = new Answer()
            {
                AnsDes = this.batterTextbox4.Value,
                QuestionId = 344,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer1488);





            ////----------------------------------   Sectionid  = 36
            // Download (for ONU/VSAT :          
            Answer answer1495 = new Answer()
            {
                AnsDes = this.dowloadOnuTextbox.Value,
                QuestionId = 345,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer1495);

            // Upload (for ONU/VSAT) :          
            Answer answer1496 = new Answer()
            {
                AnsDes = this.uploadforOnuTextbox.Value,
                QuestionId = 346,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer1496);

            // Ping Test (for ONU/VSAT) :          
            Answer answer1497 = new Answer()
            {
                AnsDes = this.pinngtestforOnuTextbox.Value,
                QuestionId = 347,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer1497);

            // Download (for Mobile:          
            Answer answer1498 = new Answer()
            {
                AnsDes = this.dowloadforMobileTextbox.Value,
                QuestionId = 348,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer1498);

            //  Upload (for Mobile :          
            Answer answer1499 = new Answer()
            {
                AnsDes = this.uploadforMobileTextbox.Value,
                QuestionId = 349,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer1499);


            // Ping Test(for Mobile)
            Answer answe1500 = new Answer()
            {
                AnsDes = this.pingtestFormobileTextbox.Value,
                QuestionId = 350,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answe1500);









            ////----------------------------------   Sectionid  = 37 
            //  ปัญหาที่พบ 1 :           
            Answer answer110 = new Answer()
            {
                AnsDes = this.problemTextbox1.Value,
                QuestionId = 351,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer110);

            //  วิธีแก้ปัญหา 1 :           
            Answer answer111 = new Answer()
            {
                AnsDes = this.howtoSolveTextbox1.Value,
                QuestionId = 352,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer111);



            //  ปัญหาที่พบ 2 :           
            Answer answer112 = new Answer()
            {
                AnsDes = this.problemTextbox2.Value,
                QuestionId = 353,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer112);

            //  วิธีแก้ปัญหา 2 :           
            Answer answer113 = new Answer()
            {
                AnsDes = this.howtoSolveTextbox2.Value,
                QuestionId = 354,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer113);



            //  ปัญหาที่พบ 3 :           
            Answer answer114 = new Answer()
            {
                AnsDes = this.problemTextbox3.Value,
                QuestionId = 355,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer114);

            //  วิธีแก้ปัญหา 3 :           
            Answer answer115 = new Answer()
            {
                AnsDes = this.howtoSolveTextbox3.Value,
                QuestionId = 356,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer115);



            //  ปัญหาที่พบ 4 :           
            Answer answer116 = new Answer()
            {
                AnsDes = this.problemTextbox4.Value,
                QuestionId = 357,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer116);

            //  วิธีแก้ปัญหา 4 :           
            Answer answer117 = new Answer()
            {
                AnsDes = this.howtoSolveTextbox4.Value,
                QuestionId = 358,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer117);





            //  ปัญหาที่พบ 5 :           
            Answer answer118 = new Answer()
            {
                AnsDes = this.problemTextbox5.Value,
                QuestionId = 359,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer118);

            //  วิธีแก้ปัญหา 5 :           
            Answer answer119 = new Answer()
            {
                AnsDes = this.howtoSolveTextbox5.Value,
                QuestionId = 360,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer119);


            //  ปัญหาที่พบ 6 :           
            Answer answer120 = new Answer()
            {
                AnsDes = this.problemTextbox6.Value,
                QuestionId = 361,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer120);

            //  วิธีแก้ปัญหา 6 :           
            Answer answer121 = new Answer()
            {
                AnsDes = this.howtoSolveTextbox6.Value,
                QuestionId = 362,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer121);

            //  ปัญหาที่พบ 7 :           
            Answer answer122 = new Answer()
            {
                AnsDes = this.problemTextbox7.Value,
                QuestionId = 363,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer122);

            //  วิธีแก้ปัญหา 7 :           
            Answer answer123 = new Answer()
            {
                AnsDes = this.howtoSolveTextbox7.Value,
                QuestionId = 364,
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
                QuestionId = 365,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer124);

            //  วิธีแก้ปัญหา 8 :           
            Answer answer125 = new Answer()
            {
                AnsDes = this.howtoSolveTextbox8.Value,
                QuestionId = 366,
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
                QuestionId = 367,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer126);

            //  วิธีแก้ปัญหา 9 :           
            Answer answer127 = new Answer()
            {
                AnsDes = this.howtoSolveTextbox9.Value,
                QuestionId = 368,
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
                QuestionId = 369,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer128);

            //  วิธีแก้ปัญหา 10 :           
            Answer answer129 = new Answer()
            {
                AnsDes = this.howtoSolveTextbox10.Value,
                QuestionId = 370,
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
                QuestionId = 371,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer130);

            //  วิธีแก้ปัญหา 11 :           
            Answer answer131 = new Answer()
            {
                AnsDes = this.howtoSolveTextbox11.Value,
                QuestionId = 372,
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
                QuestionId = 373,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer132);

            //  วิธีแก้ปัญหา 12 :           
            Answer answer133 = new Answer()
            {
                AnsDes = this.howtoSolveTextbox12.Value,
                QuestionId = 374,
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
                QuestionId = 375,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer134);

            //  วิธีแก้ปัญหา 13 :           
            Answer answer135 = new Answer()
            {
                AnsDes = this.howtoSolveTextbox13.Value,
                QuestionId = 376,
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
                QuestionId = 377,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer136);

            //  วิธีแก้ปัญหา 14 :           
            Answer answer137 = new Answer()
            {
                AnsDes = this.howtoSolveTextbox14.Value,
                QuestionId = 378,
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
                QuestionId = 379,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer138);

            //  วิธีแก้ปัญหา 15 :           
            Answer answer139 = new Answer()
            {
                AnsDes = this.howtoSolveTextbox15.Value,
                QuestionId = 380,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer139);
            //////////////////////////////////////////////////////////////////////////////////



            // ------------------------------------   Sectionid = 38          
            // รายการอุปกรณ์ 1 :      
            Answer answer141 = new Answer()
            {
                AnsDes = this.toolsListTextbox1.Value,
                QuestionId = 381,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer141);

            //  SerialNumber :           
            Answer answer142 = new Answer()
            {
                AnsDes = this.serialNumberTextbox1.Value,
                QuestionId = 382,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer142);

            //  new SerialNumber :           
            Answer answer143 = new Answer()
            {
                AnsDes = this.newSerialNumberTextbox1.Value,
                QuestionId = 383,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer143);

            //  หมายเหตุ :           
            Answer answer144 = new Answer()
            {
                AnsDes = this.noteTextbox1.Value,
                QuestionId = 384,
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
                QuestionId = 385,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer145);

            //  SerialNumber 2 :           
            Answer answer146 = new Answer()
            {
                AnsDes = this.serialNumberTextbox2.Value,
                QuestionId = 386,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer146);

            //  new SerialNumber 2 :           
            Answer answer147 = new Answer()
            {
                AnsDes = this.newSerialNumberTextbox2.Value,
                QuestionId = 387,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer147);

            //  หมายเหตุ  2:           
            Answer answer148 = new Answer()
            {
                AnsDes = this.noteTextbox2.Value,
                QuestionId = 388,
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
                QuestionId = 389,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer149);

            //  SerialNumber 3 :           
            Answer answer150 = new Answer()
            {
                AnsDes = this.serialNumberTextbox3.Value,
                QuestionId = 390,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer150);

            //  new SerialNumber 3 :           
            Answer answer151 = new Answer()
            {
                AnsDes = this.newSerialNumberTextbox3.Value,
                QuestionId = 391,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer151);

            //  หมายเหตุ  3:           
            Answer answer152 = new Answer()
            {
                AnsDes = this.noteTextbox3.Value,
                QuestionId = 392,
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
                QuestionId = 393,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer153);

            //  SerialNumber 4 :           
            Answer answer154 = new Answer()
            {
                AnsDes = this.serialNumberTextbox4.Value,
                QuestionId = 394,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer154);

            //  new SerialNumber 4 :           
            Answer answer155 = new Answer()
            {
                AnsDes = this.newSerialNumberTextbox4.Value,
                QuestionId = 395,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer155);

            //  หมายเหตุ  4:           
            Answer answer156 = new Answer()
            {
                AnsDes = this.noteTextbox4.Value,
                QuestionId = 396,
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
                QuestionId = 397,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer157);

            //  SerialNumber 5 :           
            Answer answer158 = new Answer()
            {
                AnsDes = this.serialNumberTextbox5.Value,
                QuestionId = 398,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer158);

            //  new SerialNumber 5 :           
            Answer answer159 = new Answer()
            {
                AnsDes = this.newSerialNumberTextbox5.Value,
                QuestionId = 399,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer159);

            //  หมายเหตุ  5:           
            Answer answer160 = new Answer()
            {
                AnsDes = this.noteTextbox5.Value,
                QuestionId = 400,
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
                QuestionId = 401,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer161);

            //  SerialNumber 6 :           
            Answer answer162 = new Answer()
            {
                AnsDes = this.serialNumberTextbox6.Value,
                QuestionId = 402,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer162);

            //  new SerialNumber 6 :           
            Answer answer163 = new Answer()
            {
                AnsDes = this.newSerialNumberTextbox6.Value,
                QuestionId = 403,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer163);

            //  หมายเหตุ  6:           
            Answer answer164 = new Answer()
            {
                AnsDes = this.noteTextbox6.Value,
                QuestionId = 404,
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
                QuestionId = 405,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer165);

            //  SerialNumber 7 :           
            Answer answer166 = new Answer()
            {
                AnsDes = this.serialNumberTextbox7.Value,
                QuestionId = 406,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer166);

            //  new SerialNumber 7 :           
            Answer answer167 = new Answer()
            {
                AnsDes = this.newSerialNumberTextbox7.Value,
                QuestionId = 407,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer167);

            //  หมายเหตุ  7:           
            Answer answer168 = new Answer()
            {
                AnsDes = this.noteTextbox7.Value,
                QuestionId = 408,
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
                QuestionId = 409,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer169);

            //  SerialNumber 8 :           
            Answer answer170 = new Answer()
            {
                AnsDes = this.serialNumberTextbox8.Value,
                QuestionId = 410,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer170);

            //  new SerialNumber 8 :           
            Answer answer171 = new Answer()
            {
                AnsDes = this.newSerialNumberTextbox8.Value,
                QuestionId = 411,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer171);

            //  หมายเหตุ  8:           
            Answer answer172 = new Answer()
            {
                AnsDes = this.noteTextbox8.Value,
                QuestionId = 412,
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
                QuestionId = 413,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer173);

            //  SerialNumber 9 :           
            Answer answer174 = new Answer()
            {
                AnsDes = this.serialNumberTextbox9.Value,
                QuestionId = 414,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer174);

            //  new SerialNumber 9 :           
            Answer answer175 = new Answer()
            {
                AnsDes = this.newSerialNumberTextbox9.Value,
                QuestionId = 415,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer175);

            //  หมายเหตุ  9:           
            Answer answer176 = new Answer()
            {
                AnsDes = this.noteTextbox9.Value,
                QuestionId = 416,
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
                QuestionId = 417,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer177);

            //  SerialNumber 10 :           
            Answer answer178 = new Answer()
            {
                AnsDes = this.serialNumberTextbox10.Value,
                QuestionId = 418,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer178);

            //  new SerialNumber 10 :           
            Answer answer179 = new Answer()
            {
                AnsDes = this.newSerialNumberTextbox10.Value,
                QuestionId = 419,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer179);

            //  หมายเหตุ  10:           
            Answer answer180 = new Answer()
            {
                AnsDes = this.noteTextbox10.Value,
                QuestionId = 420,
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
                QuestionId = 421,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer181);

            //  SerialNumber 11 :           
            Answer answer182 = new Answer()
            {
                AnsDes = this.serialNumberTextbox11.Value,
                QuestionId = 422,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer182);

            //  new SerialNumber 11 :           
            Answer answer183 = new Answer()
            {
                AnsDes = this.newSerialNumberTextbox11.Value,
                QuestionId = 423,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer183);

            //  หมายเหตุ  11:           
            Answer answer184 = new Answer()
            {
                AnsDes = this.noteTextbox11.Value,
                QuestionId = 424,
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
                QuestionId = 425,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer185);

            //  SerialNumber 12 :           
            Answer answer186 = new Answer()
            {
                AnsDes = this.serialNumberTextbox12.Value,
                QuestionId = 426,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer186);

            //  new SerialNumber 12 :           
            Answer answer187 = new Answer()
            {
                AnsDes = this.newSerialNumberTextbox12.Value,
                QuestionId = 427,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer187);

            //  หมายเหตุ  12:           
            Answer answer188 = new Answer()
            {
                AnsDes = this.noteTextbox12.Value,
                QuestionId = 428,
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
                QuestionId = 429,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer189);

            //  SerialNumber 13 :           
            Answer answer190 = new Answer()
            {
                AnsDes = this.serialNumberTextbox13.Value,
                QuestionId = 430,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer190);

            //  new SerialNumber 13 :           
            Answer answer191 = new Answer()
            {
                AnsDes = this.newSerialNumberTextbox13.Value,
                QuestionId = 431,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer191);

            //  หมายเหตุ  13   :    
            Answer answer192 = new Answer()
            {
                AnsDes = this.noteTextbox13.Value,
                QuestionId = 432,
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
                QuestionId = 433,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer193);

            //  SerialNumber 14 :           
            Answer answer194 = new Answer()
            {
                AnsDes = this.serialNumberTextbox14.Value,
                QuestionId = 434,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer194);

            //  new SerialNumber 14 :           
            Answer answer195 = new Answer()
            {
                AnsDes = this.newSerialNumberTextbox14.Value,
                QuestionId = 435,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer195);

            //  หมายเหตุ  143   :    
            Answer answer196 = new Answer()
            {
                AnsDes = this.noteTextbox14.Value,
                QuestionId = 436,
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
                QuestionId = 437,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer197);

            //  SerialNumber 15 :           
            Answer answer198 = new Answer()
            {
                AnsDes = this.serialNumberTextbox15.Value,
                QuestionId = 438,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer198);

            //  new SerialNumber 15 :           
            Answer answer199 = new Answer()
            {
                AnsDes = this.newSerialNumberTextbox15.Value,
                QuestionId = 439,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer199);

            //  หมายเหตุ  15   :    
            Answer answer200 = new Answer()
            {
                AnsDes = this.noteTextbox15.Value,
                QuestionId = 440,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer200);
            //////////////////////////////////////////////////////////////////////////////////
            ///

            // section = 39
            //   name pm :    
            Answer answer1591 = new Answer()
            {
                AnsDes = this.nameDopmTextbox.Value,
                QuestionId = 441,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer1591);


            //  วันที่ทำ PM :    
            Answer answer1592 = new Answer()
            {
                AnsDes = this.dayDopmTextbox.Value,
                QuestionId = 442,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer1592);



            // section = 40
            // รูปภาพรวมบริเวณ Site :
            string steAreaRadio = Request.Form["steAreaRadio"];
            Answer answer1593 = new Answer()
            {
                AnsDes = steAreaRadio,
                QuestionId = 443,
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
                QuestionId = 444,
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
                QuestionId = 445,
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
                QuestionId = 446,
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
                QuestionId = 447,
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
                QuestionId = 448,
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
                QuestionId = 449,
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
                QuestionId = 450,
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
                QuestionId = 451,
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
                QuestionId = 452,
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
                QuestionId = 453,
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
                QuestionId = 454,
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
                QuestionId = 455,
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
                QuestionId = 456,
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
                QuestionId = 457,
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
                QuestionId = 458,
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
                QuestionId = 459,
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
                QuestionId = 460,
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
                QuestionId = 461,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer461);


            // ------------------------    SECTION 42 :  ------------------------------- // 

            // รูปจุดติดตั้งจานดาวเทียม :
            string inStallSatRadio = Request.Form["inStallSatRadio"];
            Answer answer1614 = new Answer()
            {
                AnsDes = inStallSatRadio,
                QuestionId = 462,
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
                QuestionId = 463,
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
                QuestionId = 464,
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
                QuestionId = 465,
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
                QuestionId = 466,
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
                QuestionId = 467,
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
                QuestionId = 468,
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
                QuestionId = 469,
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
                QuestionId = 470,
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
                QuestionId = 471,
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
                QuestionId = 472,
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
                QuestionId = 473,
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
                QuestionId = 474,
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
                QuestionId = 475,
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
                QuestionId = 476,
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
                QuestionId = 477,
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
                QuestionId = 478,
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
                QuestionId = 479,
                AnserTypeId = 4,
                CreateDate = DateTime.Now,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer479);




            //1.รูป PICTURE CHECKLIST :
            if (this.pictureChecklistImages.HasFile)
            {
                string extension = this.pictureChecklistImages.PostedFile.FileName.Split('.')[1];
                string newFileName = "images/pictureChecklist_" + DateTime.Now.ToString("yyyyMMddHHmmss") + "." + extension;
                this.pictureChecklistImages.PostedFile.SaveAs(Server.MapPath(newFileName));

                Answer answer259 = new Answer()
                {
                    AnsDes = newFileName,
                    QuestionId = 480,
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
                    QuestionId = 481,
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
                    QuestionId = 482,
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