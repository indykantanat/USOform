<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="preview.aspx.cs" Inherits="USOform.PreventiveMaintenanceReportBB2_3_3_3.preview" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Preview Broadband Internet Service(Preventive Maintenance (PM) Report) บริการที่ 2.3,3.3 </title>
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link href="../style/Mystyle.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous" />
    <%------//     font style    //---------%>
    <link rel="preconnect" href="https://fonts.gstatic.com" />
    <link href="https://fonts.googleapis.com/css2?family=Sarabun:wght@100;300;400;500;600;700&display=swap" rel="stylesheet" />
    <%-------//    DATE time picker JQURRY   //--------%>
    <link rel="stylesheet" href="//code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css" />
    <link rel="stylesheet" href="/resources/demos/style.css" />
    <script src="https://code.jquery.com/jquery-1.12.4.js"></script>
    <script src="https://code.jquery.com/ui/1.12.1/jquery-ui.js"></script>
    <link href="http://ajax.googleapis.com/ajax/libs/jqueryui/1.12.1/themes/south-street/jquery-ui.css" rel="stylesheet">
    <link href="../style/Mystyle.css" rel="stylesheet" />
    <meta http-equiv="Content-Type" content="text/html;charset=utf-8" />
    <%-------//   PREVIEW IMAGES   //--------%>
    <script src="previewImg.js"></script>
    <%--------------- //   Signature     //-----------------------%>
    <link href="../sig/css/jquery.signature.css" rel="stylesheet" />
    <script src="../sig/js/jquery.signature.min.js"></script>
    <script src="../sig/js/results.js"></script>
    <script src="../sig/js/results.js"></script>
    <%----------------//  Important must have for signature !  //---------------%>
    <meta http-equiv="Content-Type" content="text/html;charset=utf-8" />
    <meta http-equiv="Content-Security-Policy" content="upgrade-insecure-requests" />
    <link href="http://ajax.googleapis.com/ajax/libs/jqueryui/1.12.1/themes/south-street/jquery-ui.css" rel="stylesheet" />
    <link href="../sig/css/jquery.signature.css" rel="stylesheet" />

    <style>
        .kbw-signature {
            width: 400px;
            height: 200px;
        }
    </style>    
</head>

<body style="background-color: lightgray">
    <form id="form1" runat="server">
        <div class="container bg-white Myfont mt-3">
            <%-----------------------------------------------//   HEADER CONTENT    //------------------------------------------------------------%>
         
            <div class="row pt-5">
                <div class="col-4">
                 
                      <img id="user_img_10" src='<% if (answers.Count() > 0) Response.Write(answers.Where(x => x.QuestionId == 483).FirstOrDefault().AnsDes); %>' class="imgLogoOganize float-left" />
                </div>
                <div class="col-4  d-flex justify-content-center ">
                    <h5 class="headerText">Preventive Maintenance Site Report USO (School’s WIFI)</h5>
                </div>
                <div class="col-4 ">
                    <img src="../assets/logo_uso.png" class="logoImg" />
                </div>
            </div>
            <div class="row">
                <div class="col-12 text-left ">
                    <div>
                        <h5>รายงานผลการตรวจสอบ และบำรุงรักษาชุดอุปกรณ์ Broadband Internet Service(Preventive Maintenance (PM) Report)</h5>
                    </div>
                    <div>
                        <h5>โครงการจัดให้มีสัญญาณโทรศัพท์เคลื่อนที่และบริการอินเทอร์เน็ตความเร็วสูงในพื้นที่ชายขอบ (Zone C+) </h5>
                    </div>
                </div>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-1" >กลุ่ม :</label>
                <div class="col-sm-4">
                    <asp:Label  id="groupLabel" runat="server" />
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-1" >ภาค :</label>
                <div class="col-sm-4">
                    <asp:Label  id="AreaLabel" runat="server" />
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-1" >บริษัท :</label>
                <div class="col-sm-4">
                    <asp:Label  id="CompanyLabel" runat="server" />
                </div>
            </div>



            <div class="form-row mt-3">
                <label class="control-label col-sm-7" >ส่วนที่ 1 การจัดให้มีบริการอินเทอร์เน็ตความเร็วสูง (Broadband Internet Service) บริการประเภทที่</label>
                <div class="form-check-inline">
                    <label class="form-check-label" >
                        <input type="radio" class="form-check-input" name="seLectOptionRadio" value="2.3" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 487).FirstOrDefault().AnsDes == "2.3") { Response.Write("checked"); } else { Response.Write(""); }  %> />2.3
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label" >
                        <input type="radio" class="form-check-input" name="seLectOptionRadio" value="3.3" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 487).FirstOrDefault().AnsDes == "3.3") { Response.Write("checked"); } else { Response.Write(""); }  %> />3.3
                    </label>
                </div>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-2" >รอบการบำรุงรักษา ครั้งที่ </label>
                <div class="col-sm-1">
                    <asp:Label  id="maintenanceCountLabel" runat="server" />
                </div>
                /
              <div class="col-sm-2">
                  <asp:Label  id="yearLabel" runat="server" placeholder="ปีพุทธศักราช" />
              </div>
            </div>

            <div class="row text-left mt-3">
                <div class="col-md-12">
                    <div>
                        <label>
                            <div>วัน เดือน ปี</div>
                        </label>
                        <asp:Label  data-date-format="dd/mm/yyyy" id="startDatepickerLabel" runat="server" />

                        <label>
                            <div>ถึง</div>
                        </label>
                        <asp:Label data-date-format="dd/mm/yyyy" id="endDatepickerLabel" runat="server" />
                    </div>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-2" >สถานที่ (Site code)</label>
                <div class="col-sm-4">
                    <asp:Label  id="siteCodeLabel" runat="server" />
                </div>
            </div>
            <%--////////////////////////////////    END HEADER CONTENT    ///////////////////////////////////////////////--%>











            <%--/////////////////////////////////////////   FORM START     /////////////////////////////////////////--%>

            <div class="row mt-3">
                <div class="col-md-12 bg-primary text-white text-center Myfont">
                    <h4>PREVENTIVE MAINTENANCE SITE REPORT (PM)</h4>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-1" >Cabinet ID :</label>
                <div class="col-sm-3">
                    <asp:Label  id="cabinetIdLabel" runat="server" />
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-1" >Site Code :</label>
                <div class="col-sm-3">
                    <asp:Label  id="sitecodeLabelSection2" runat="server" />
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-1" >Village ID :</label>
                <div class="col-sm-3">
                    <asp:Label  id="VillageIdLabel" runat="server" />
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-1" >Village :</label>
                <div class="col-sm-3">
                    <asp:Label  id="villageLabel" runat="server" />
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-1" >School’s name</label>
                <div class="col-sm-3">
                    <asp:Label  id="schoolNameLabel" runat="server" />
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-1" >Sub-District :</label>
                <div class="col-sm-3">
                    <asp:Label  id="subdistrictLabel" runat="server" />
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-1" >District :</label>
                <div class="col-sm-3">
                    <asp:Label  id="DistrictLabelEIEI" runat="server" />
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-1" >Province :</label>
                <div class="col-sm-3">
                    <asp:Label  id="provinceLabel" runat="server" />
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-1" >Type :</label>
                <div class="col-sm-3">
                    <asp:Label  id="typeLabel" runat="server" />
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-1" >PM Date :</label>
                <div class="col-sm-3">
                    <asp:Label  id="pmdateLabel" runat="server" />
                </div>
            </div>



            <div class="form-row mt-3 table-bordered">
                <div class="col-sm-12 bg-primary text-white">ใส่ป้ายหน้าโรงเรียน</div>
              
            </div>
               <div class="row ml-3 mt-3">
                <img id="user_img_0" src='<% if (answers.Count() > 0) Response.Write(answers.Where(x => x.QuestionId == 502).FirstOrDefault().AnsDes); %>' class="placeholder2" />
            </div>


            <div class="form-row mt-3 table-bordered">
                <div class="col-sm-12 bg-primary text-white">รูปบริเวณห้องบริการ WiFi - Computer</div>
               
            </div>
               <div class="row ml-3 mt-3">
                <img id="user_img_1" src='<% if (answers.Count() > 0) Response.Write(answers.Where(x => x.QuestionId == 503).FirstOrDefault().AnsDes); %>' class="placeholder2" />
            </div>











         <div class="row mt-3">
                <div class="col-md-12 bg-warning text-white text-center Myfont">
                    <h4>Contractor</h4>
                </div>
            </div>
            <div class="row mt-2">
                <div class="col-lg-6">               
                         <div class="card">
                        <div class="card-header">
                            Executor
                        </div>                                        
                              <div class="card-body">
                        <img src='<% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 504).Count() > 0) Response.Write(answers.Where(x => x.QuestionId == 504).FirstOrDefault().AnsDes); %>' />
                            <div class="form-group">
                                <label>Name</label>
                                <asp:Label  id="nameExecutorLabel" runat="server"  />
                            </div>
                            <div class="form-group">
                                <label>Date</label>
                                <asp:Label  id="DateExecutorLabel" runat="server"  />
                            </div>
                
                        </div>                                   
                    </div>                                    
                </div>

                <div class="col-lg-6">
                    <div class="card">
                        <div class="card-header">
                            Supervisor
                        </div>
                        <div class="card-body">
                            <img src='<% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 505).Count() > 0) Response.Write(answers.Where(x => x.QuestionId == 505).FirstOrDefault().AnsDes); %>' />
                            <div class="form-group">
                                <label>Name : </label>
                                <asp:Label  id="nameSupervisorLabel" runat="server"  />
                            </div>
                            <div class="form-group">
                                <label>Date : </label>
                                <asp:Label  id="DateSupervisorLabel" runat="server"  />
                            </div>
                        </div>
                    </div>
                </div>
            </div>

            <%--------// FOR PREVIEW/  /-----------%>
            <%-- <img id="user_img_6" src='<% if (answers.Count() > 0) Response.Write(answers.Where(x => x.QuestionId == 758).FirstOrDefault().AnsDes); %>' class="placeholder2" />--%>
            <%-- <img id="user_img_7" src='<% if (answers.Count() > 0) Response.Write(answers.Where(x => x.QuestionId == 759).FirstOrDefault().AnsDes); %>' class="placeholder2" />--%>

            <div class="row mt-3">
                <div class="col-md-12 bg-primary text-white text-center Myfont">
                    <h4>1. รายละเอียดสถานี</h4>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-2" >Cabinet ID :</label>
                <div class="col-sm-4">
                    <asp:Label  id="cabinetId2Label" runat="server" />
                </div>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-2" >Site code :</label>
                <div class="col-sm-4">
                    <asp:Label  id="sitecodeLabelSection4" runat="server" />
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-2" >Village ID :</label>
                <div class="col-sm-4">
                    <asp:Label  id="villageIDLabelSection4" runat="server" />
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-2" >LAT & LONG :</label>
                <div class="col-sm-4">
                    <asp:Label  id="latandlongLabel" runat="server" />
                </div>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-2" >Type of Signal</label>
                <div class="form-check-inline">
                    <label class="form-check-label" >
                        <input type="radio" class="form-check-input" name="TypeofSignaleieiRadio" value="OFC" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 514).FirstOrDefault().AnsDes == "OFC") { Response.Write("checked"); } else { Response.Write(""); }  %> />OFC
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label" >
                        <input type="radio" class="form-check-input" name="TypeofSignaleieiRadio" value="Satellite" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 514).FirstOrDefault().AnsDes == "Satellite") { Response.Write("checked"); } else { Response.Write(""); }  %> />Satellite
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-2" >OLT ID :</label>
                <div class="col-sm-4">
                    <asp:Label  id="oltIdLabel" runat="server" />
                </div>
            </div>

            <div class="row mt-3">
                <div class="col-md-12 bg-primary text-white text-center Myfont">
                    <h4>2. ระบบไฟฟ้า (หลัก)</h4>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-2" >ระบบไฟฟ้า</label>
                <div class="form-check-inline">
                    <label class="form-check-label" >
                        <input type="radio" class="form-check-input" name="voltSystemRadio" value="PEA" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 516).FirstOrDefault().AnsDes == "PEA") { Response.Write("checked"); } else { Response.Write(""); }  %> />PEA
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label" >
                        <input type="radio" class="form-check-input" name="voltSystemRadio" value="SolarCell" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 516).FirstOrDefault().AnsDes == "SolarCell") { Response.Write("checked"); } else { Response.Write(""); }  %>>Solar Cell
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-2" >หมายเลขผู้ใช้ไฟ</label>
                <div class="col-sm-4">
                    <asp:Label  id="numberIdLabel" runat="server" />
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-2" >หน่วยใช้ไฟ (kWh Meter)</label>
                <div class="col-sm-2">
                    <asp:Label  id="kwhMeterLabel" runat="server" />
                </div>
                <label class="control-label col-sm-1" >kWh</label>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-2" >แรงดัน AC (kWh Meter)</label>
                <div class="col-sm-2">
                    <asp:Label  id="acvoltLabel" runat="server" />
                </div>
                <label class="control-label col-sm-1" >V.</label>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-2" >กระแส Line AC (kWh Meter)</label>
                <div class="col-sm-2">
                    <asp:Label  id="lineAcLabel" runat="server" />
                </div>
                <label class="control-label col" >A.</label>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-2" >กระแส Neutron AC (kWh Meter)</label>
                <div class="col-sm-2">
                    <asp:Label  id="neutronAcEIEILabel" runat="server" />
                </div>
                <label class="control-label col" >A.</label>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-2" >สภาพ kWh Meter</label>
                <div class="form-check-inline">
                    <label class="form-check-label" >
                        <input type="radio" class="form-check-input" name="conditionRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 522).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); }  %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label" >
                        <input type="radio" class="form-check-input" name="conditionRadio" value="ชำรุด/ใช้งานไม่ได้" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 522).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); }  %> />ชำรุด/ใช้งานไม่ได้
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-2" >สภาพ Circuit Breaker</label>
                <div class="form-check-inline">
                    <label class="form-check-label" >
                        <input type="radio" class="form-check-input" name="MDBCircuitBreakerRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 523).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); }  %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label" >
                        <input type="radio" class="form-check-input" name="MDBCircuitBreakerRadio" value="ชำรุด/ใช้งานไม่ได้" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 523).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); }  %> />ชำรุด/ใช้งานไม่ได้
                    </label>
                </div>
            </div>


            <div class="row mt-3">
                <div class="col-md-12 bg-primary text-white text-center Myfont">
                    <h4>3. ระบบไฟฟ้า (สำรอง)</h4>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-2">UPS ภายในตู้</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="inupsRadio" value="มี" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 524).FirstOrDefault().AnsDes == "มี") { Response.Write("checked"); } else { Response.Write(""); }  %> />มี
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="inupsRadio" value="ไม่มี" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 524).FirstOrDefault().AnsDes == "ไม่มี") { Response.Write("checked"); } else { Response.Write(""); }  %> />ไม่มี
                    </label>
                </div>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-2">แรงดัน AC จาก UPS</label>
                <div class="col-sm-1">
                    <asp:Label  id="acfromupsLabel" runat="server" required="required" />
                </div>
                <label class="control-label col-sm-2">V.</label>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-2">ระดับกระแส Load </label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="voltageLoadRadio" value="1" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 526).FirstOrDefault().AnsDes == "1") { Response.Write("checked"); } else { Response.Write(""); }  %> />1
                    </label>
                </div>

                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="voltageLoadRadio" value="2" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 526).FirstOrDefault().AnsDes == "2") { Response.Write("checked"); } else { Response.Write(""); }  %> />2
                    </label>
                </div>

                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="voltageLoadRadio" value="3" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 526).FirstOrDefault().AnsDes == "3") { Response.Write("checked"); } else { Response.Write(""); }  %> />3
                    </label>
                </div>

                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="voltageLoadRadio" value="4" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 526).FirstOrDefault().AnsDes == "4") { Response.Write("checked"); } else { Response.Write(""); }  %> />4
                    </label>                 
                </div>
                  <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="voltageLoadRadio" value="5" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 526).FirstOrDefault().AnsDes == "5") { Response.Write("checked"); } else { Response.Write(""); }  %> />5
                        </label>
                    </div>
                <label class="control-label col-sm-2">(ขีดล่าง =1 , ขีดบน = 5)</label>

            </div>



            <div class="form-row mt-3">
                <label class="control-label col-sm-2">ระดับความจุ Battery</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="batteryCapacityRadio" value="1" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 527).FirstOrDefault().AnsDes == "1") { Response.Write("checked"); } else { Response.Write(""); }  %> />1
                    </label>
                </div>

                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="batteryCapacityRadio" value="2" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 527).FirstOrDefault().AnsDes == "2") { Response.Write("checked"); } else { Response.Write(""); }  %> />2
                    </label>
                </div>

                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="batteryCapacityRadio" value="3" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 527).FirstOrDefault().AnsDes == "3") { Response.Write("checked"); } else { Response.Write(""); }  %> />3
                    </label>
                </div>

                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="batteryCapacityRadio" value="4" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 527).FirstOrDefault().AnsDes == "4") { Response.Write("checked"); } else { Response.Write(""); }  %> />4
                    </label>                  
                </div>
                 <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="batteryCapacityRadio" value="5" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 527).FirstOrDefault().AnsDes == "5") { Response.Write("checked"); } else { Response.Write(""); }  %> />5
                        </label>
                    </div>
                <label class="control-label col-sm-2">(ขีดล่าง =1 , ขีดบน = 5)</label>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-2">UPS MODE</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="upsModeRadio" value="LINE" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 528).FirstOrDefault().AnsDes == "LINE") { Response.Write("checked"); } else { Response.Write(""); }  %> />LINE
                    </label>
                </div>

                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="upsModeRadio" value="BATT" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 528).FirstOrDefault().AnsDes == "BATT") { Response.Write("checked"); } else { Response.Write(""); }  %> />BATT.
                    </label>
                </div>

                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="upsModeRadio" value="BYPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 528).FirstOrDefault().AnsDes == "BYPASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />BYPASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-2">การทำงานของระบบไฟสำรอง</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="secondFireRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 529).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); }  %> />ปกติ
                    </label>
                </div>

                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="secondFireRadio" value="ชำรุด/ใช้งานไม่ได้" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 529).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); }  %> />ชำรุด/ใช้งานไม่ได้
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-2">สภาพ Battery Bank</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="batterybankRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 530).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); }  %> />ปกติ
                    </label>
                </div>

                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="batterybankRadio" value="ชำรุด/ใช้งานไม่ได้" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 530).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); }  %> />ชำรุด/ใช้งานไม่ได้
                    </label>
                </div>
            </div>



















            <div class="row mt-3">
                <div class="col-md-12 bg-primary text-white text-center Myfont">
                    <h4>4.รายละเอียดอุปกรณ์ Network ภายในตู้</h4>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-3" >ONU/Modem Network</label>
                <div class="form-check-inline">
                    <label class="form-check-label" >
                        <input type="radio" class="form-check-input" name="ONUModemNetworkRadio" value="USO" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 531).FirstOrDefault().AnsDes == "USO") { Response.Write("checked"); } else { Response.Write(""); }  %> />USO
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label" >
                        <input type="radio" class="form-check-input" name="ONUModemNetworkRadio" value="TRUE" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 531).FirstOrDefault().AnsDes == "TRUE") { Response.Write("checked"); } else { Response.Write(""); }  %> />TRUE
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label" >
                        <input type="radio" class="form-check-input" name="ONUModemNetworkRadio" value="3BB" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 531).FirstOrDefault().AnsDes == "3BB") { Response.Write("checked"); } else { Response.Write(""); }  %> />3BB
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label" >
                        <input type="radio" class="form-check-input" name="ONUModemNetworkRadio" value="Satellite" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 531).FirstOrDefault().AnsDes == "Satellite") { Response.Write("checked"); } else { Response.Write(""); }  %> />Satellite
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-3" >Power Supply (for Switch)</label>
                <div class="form-check-inline">
                    <label class="form-check-label" >
                        <input type="radio" class="form-check-input" name="psuForswitchRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 532).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); }  %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label" >
                        <input type="radio" class="form-check-input" name="psuForswitchRadio" value="ชำรุด/ใช้งานไม่ได้" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 532).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); }  %> />ชำรุด/ใช้งานไม่ได้
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-3" >Switch 8 Port</label>
                <div class="form-check-inline">
                    <label class="form-check-label" >
                        <input type="radio" class="form-check-input" name="switchPortRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 533).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); }  %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label" >
                        <input type="radio" class="form-check-input" name="switchPortRadio" value="ชำรุด/ใช้งานไม่ได้" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 533).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); }  %> />ชำรุด/ใช้งานไม่ได้
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-3" >Outdoor AP 2.4 GHz</label>
                <div class="form-check-inline">
                    <label class="form-check-label" >
                        <input type="radio" class="form-check-input" name="OutdoorAP24Radio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 534).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); }  %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label" >
                        <input type="radio" class="form-check-input" name="OutdoorAP24Radio" value="ชำรุด/ใช้งานไม่ได้" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 534).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); }  %> />ชำรุด/ใช้งานไม่ได้
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-3" >Outdoor AP 5 GHz</label>
                <div class="form-check-inline">
                    <label class="form-check-label" >
                        <input type="radio" class="form-check-input" name="OutdoorAP5GHzRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 535).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); }  %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label" >
                        <input type="radio" class="form-check-input" name="OutdoorAP5GHzRadio" value="ชำรุด/ใช้งานไม่ได้" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 535).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); }  %> />ชำรุด/ใช้งานไม่ได้
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-3" >ระบบระบายอากาศ (T-Power)</label>
                <div class="form-check-inline">
                    <label class="form-check-label" >
                        <input type="radio" class="form-check-input" name="tPowerRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 536).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); }  %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label" >
                        <input type="radio" class="form-check-input" name="tPowerRadio" value="ชำรุด/ใช้งานไม่ได้" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 536).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); }  %> />ชำรุด/ใช้งานไม่ได้
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-3" >การ Wiring สายไฟและสาย Ground</label>
                <div class="form-check-inline">
                    <label class="form-check-label" >
                        <input type="radio" class="form-check-input" name="WiringGroundRadio" value="เรียบร้อย" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 537).FirstOrDefault().AnsDes == "เรียบร้อย") { Response.Write("checked"); } else { Response.Write(""); }  %> />เรียบร้อย
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label" >
                        <input type="radio" class="form-check-input" name="WiringGroundRadio" value="ไม่เรียบร้อย" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 537).FirstOrDefault().AnsDes == "ไม่เรียบร้อย") { Response.Write("checked"); } else { Response.Write(""); }  %> />ไม่เรียบร้อย
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-3" >การ Wiring Patch cord และ สาย LAN</label>
                <div class="form-check-inline">
                    <label class="form-check-label" >
                        <input type="radio" class="form-check-input" name="wirePatchRadio" value="เรียบร้อย" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 538).FirstOrDefault().AnsDes == "เรียบร้อย") { Response.Write("checked"); } else { Response.Write(""); }  %> />เรียบร้อย
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label" >
                        <input type="radio" class="form-check-input" name="wirePatchRadio" value="ไม่เรียบร้อย" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 538).FirstOrDefault().AnsDes == "ไม่เรียบร้อย") { Response.Write("checked"); } else { Response.Write(""); }  %> />ไม่เรียบร้อย
                    </label>
                </div>
            </div>


            <div class="row mt-3">
                <div class="col-md-12 bg-primary text-white text-center Myfont">
                    <h4>5.ระบบ Ground</h4>
                </div>
            </div>
            <div class="form-row mt-3">
                <label class="control-label col-sm-4">ความแข็งแรงจุดต่อ Ground Bar</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="groundbarRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 539).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); }  %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="groundbarRadio" value="ชำรุด" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 539).FirstOrDefault().AnsDes == "ชำรุด") { Response.Write("checked"); } else { Response.Write(""); }  %> />ชำรุด
                    </label>
                </div>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-4">ความแข็งแรงของน็อตขันหางปลาอุปกรณ์</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="notfishRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 540).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); }  %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="notfishRadio" value="ชำรุด" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 540).FirstOrDefault().AnsDes == "ชำรุด") { Response.Write("checked"); } else { Response.Write(""); }  %> />ชำรุด
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">สายกราวด์เรียบร้อย ปลอดภัย สมบูรณ์</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="safegroundRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 541).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); }  %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="safegroundRadio" value="ชำรุด" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 541).FirstOrDefault().AnsDes == "ชำรุด") { Response.Write("checked"); } else { Response.Write(""); }  %> />ชำรุด
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">สถานะไฟฟ้ารั่วลง Ground</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="brokenElecRadio" value="ไม่พบไฟฟ้ารั่ว" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 542).FirstOrDefault().AnsDes == "ไม่พบไฟฟ้ารั่ว") { Response.Write("checked"); } else { Response.Write(""); }  %> />ไม่พบไฟฟ้ารั่ว
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="brokenElecRadio" value="พบไฟฟ้ารั่ว" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 542).FirstOrDefault().AnsDes == "พบไฟฟ้ารั่ว") { Response.Write("checked"); } else { Response.Write(""); }  %> />พบไฟฟ้ารั่ว
                    </label>
                </div>
            </div>





            <div class="row mt-3">
                <div class="col-md-12 bg-primary text-white text-center Myfont">
                    <h4>6.ระบบสารสนเทศ</h4>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">คอมพิวเตอร์ตัวที่ 1</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="ComRadio1" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 543).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); }  %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="ComRadio1" value="ชำรุด/ใช้งานไม่ได้" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 543).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); }  %> />ชำรุด/ใช้งานไม่ได้
                    </label>
                </div>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-4">คอมพิวเตอร์ตัวที่ 2</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="ComRadio2" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 544).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); }  %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="ComRadio2" value="ชำรุด/ใช้งานไม่ได้" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 544).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); }  %> />ชำรุด/ใช้งานไม่ได้
                    </label>
                </div>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-4">คอมพิวเตอร์ตัวที่ 3</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="ComRadio3" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 545).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); }  %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="ComRadio3" value="ชำรุด/ใช้งานไม่ได้" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 545).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); }  %> />ชำรุด/ใช้งานไม่ได้
                    </label>
                </div>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-4">คอมพิวเตอร์ตัวที่ 4</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="ComRadio4" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 546).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); }  %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="ComRadio4" value="ชำรุด/ใช้งานไม่ได้" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 546).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); }  %> />ชำรุด/ใช้งานไม่ได้
                    </label>
                </div>
            </div>



            <div class="form-row mt-3">
                <label class="control-label col-sm-4">คอมพิวเตอร์ตัวที่ 5</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="ComRadio5" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 547).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); }  %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="ComRadio5" value="ชำรุด/ใช้งานไม่ได้" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 547).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); }  %> />ชำรุด/ใช้งานไม่ได้
                    </label>
                </div>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-4">UPS สำหรับคอมพิวเตอร์ตัวที่ 1</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="upsRadio1" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 548).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); }  %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="upsRadio1" value="ชำรุด/ใช้งานไม่ได้" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 548).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); }  %> />ชำรุด/ใช้งานไม่ได้
                    </label>
                </div>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-4">UPS สำหรับคอมพิวเตอร์ตัวที่ 2</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="upsRadio2" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 549).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); }  %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="upsRadio2" value="ชำรุด/ใช้งานไม่ได้" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 549).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); }  %> />ชำรุด/ใช้งานไม่ได้
                    </label>
                </div>
            </div>



            <div class="form-row mt-3">
                <label class="control-label col-sm-4">UPS สำหรับคอมพิวเตอร์ตัวที่ 3</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="upsRadio3" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 550).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); }  %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="upsRadio3" value="ชำรุด/ใช้งานไม่ได้" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 550).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); }  %> />ชำรุด/ใช้งานไม่ได้
                    </label>
                </div>
            </div>



            <div class="form-row mt-3">
                <label class="control-label col-sm-4">UPS สำหรับคอมพิวเตอร์ตัวที่ 4</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="upsRadio4" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 551).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); }  %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="upsRadio4" value="ชำรุด/ใช้งานไม่ได้" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 551).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); }  %> />ชำรุด/ใช้งานไม่ได้
                    </label>
                </div>
            </div>



            <div class="form-row mt-3">
                <label class="control-label col-sm-4">UPS สำหรับคอมพิวเตอร์ตัวที่ 5</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="upsRadio5" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 552).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); }  %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="upsRadio5" value="ชำรุด/ใช้งานไม่ได้" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 552).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); }  %> />ชำรุด/ใช้งานไม่ได้
                    </label>
                </div>
            </div>





            <div class="form-row mt-3">
                <label class="control-label col-sm-4">Test ใช้งาน Internet (Speed Test) คอมพิวเตอร์ตัวที่ 1</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="speedTestRaio1" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 553).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); }  %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="speedTestRaio1" value="ชำรุด/ใช้งานไม่ได้" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 553).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); }  %> />ชำรุด/ใช้งานไม่ได้
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">Test ใช้งาน Internet (Speed Test) คอมพิวเตอร์ตัวที่ 2</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="speedTestRaio2" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 554).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); }  %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="speedTestRaio2" value="ชำรุด/ใช้งานไม่ได้" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 554).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); }  %> />ชำรุด/ใช้งานไม่ได้
                    </label>
                </div>
            </div>
            <div class="form-row mt-3">
                <label class="control-label col-sm-4">Test ใช้งาน Internet (Speed Test) คอมพิวเตอร์ตัวที่ 3</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="speedTestRaio3" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 555).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); }  %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="speedTestRaio3" value="ชำรุด/ใช้งานไม่ได้" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 555).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); }  %> />ชำรุด/ใช้งานไม่ได้
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">Test ใช้งาน Internet (Speed Test) คอมพิวเตอร์ตัวที่ 4</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="speedTestRaio4" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 556).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); }  %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="speedTestRaio4" value="ชำรุด/ใช้งานไม่ได้" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 556).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); }  %> />ชำรุด/ใช้งานไม่ได้
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">Test ใช้งาน Internet (Speed Test) คอมพิวเตอร์ตัวที่ 5</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="speedTestRaio5" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 557).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); }  %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="speedTestRaio5" value="ชำรุด/ใช้งานไม่ได้" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 557).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); }  %> />ชำรุด/ใช้งานไม่ได้
                    </label>
                </div>
            </div>







            <div class="row mt-3">
                <div class="col-md-12 bg-primary text-white text-center Myfont">
                    <h4>7.สภาพแวดล้อมและความสะอาดโดยรอบ</h4>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">ป้ายและตัวเลขแสดงชื่อสถานี</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="signandnumberRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 558).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); }  %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="signandnumberRadio" value="ไม่ชัดเจน" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 558).FirstOrDefault().AnsDes == "ไม่ชัดเจน") { Response.Write("checked"); } else { Response.Write(""); }  %> />ไม่ชัดเจน
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">การติดตั้งและการยึดตู้อุปกรณ์</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="inStallRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 559).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); }  %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="inStallRadio" value="ชำรุด" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 559).FirstOrDefault().AnsDes == "ชำรุด") { Response.Write("checked"); } else { Response.Write(""); }  %> />ชำรุด
                    </label>
                </div>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-4">เสาไฟฟ้าที่ติดตั้งอุปกรณ์</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="UPPERinStallSatRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 560).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); }  %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="UPPERinStallSatRadio" value="ชำรุด/เอียง" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 560).FirstOrDefault().AnsDes == "ชำรุด/เอียง") { Response.Write("checked"); } else { Response.Write(""); }  %> />ชำรุด/เอียง
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">แนวสายไฟฟ้าและสายเคเบิ้ลเข้าสถานี</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="cabletoStationRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 561).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); }  %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="cabletoStationRadio" value="ชำรุด/เอียง" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 561).FirstOrDefault().AnsDes == "ชำรุด/เอียง") { Response.Write("checked"); } else { Response.Write(""); }  %> />ตกหย่อน/ไม่ได้จับยึด
                    </label>
                </div>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-4">ช่อง Cable Inlet  และความสะอาด</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="CableInletRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 562).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); }  %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="CableInletRadio" value="ไม่ได้อุดซิลีโคน" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 562).FirstOrDefault().AnsDes == "ไม่ได้อุดซิลีโคน") { Response.Write("checked"); } else { Response.Write(""); }  %> />ไม่ได้อุดซิลีโคน
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">ช่อง Filter ความสะอาด (T-Power)</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="filterRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 563).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); }  %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="filterRadio" value="มีฝุ่น/สิ่งสกปรก" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 563).FirstOrDefault().AnsDes == "มีฝุ่น/สิ่งสกปรก") { Response.Write("checked"); } else { Response.Write(""); }  %> />มีฝุ่น/สิ่งสกปรก
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">ประตูและยางขอบประตูของตู้อุปกรณ์</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="doorToolsRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 564).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); }  %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="doorToolsRadio" value="ชำรุด" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 564).FirstOrDefault().AnsDes == "ชำรุด") { Response.Write("checked"); } else { Response.Write(""); }  %> />ชำรุด
                    </label>
                </div>
            </div>

            <div class="row mt-3">
                <div class="col-md-12 bg-primary text-white text-center Myfont">
                    <h5>8.อุปกรณ์ระบบ VSAT (เฉพาะ Site ที่เป็น VSAT)</h5>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">อุปกรณ์ LNB/BUC</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="toolslnbRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 565).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); }  %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="toolslnbRadio" value="ชำรุด/ใช้งานไม่ได้" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 565).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); }  %> />ชำรุด/ใช้งานไม่ได้
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">การเก็บสาย RG และการพันหัว</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="wiringrgRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 566).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); }  %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="wiringrgRadio" value="ไม่เรียบร้อย/ไม่แน่น" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 566).FirstOrDefault().AnsDes == "ไม่เรียบร้อย/ไม่แน่น") { Response.Write("checked"); } else { Response.Write(""); }  %> />ไม่เรียบร้อย/ไม่แน่น
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">ฐานและระดับของเสาจาน</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="baseOnRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 567).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); }  %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="baseOnRadio" value="ไม่ได้ระดับ/เอียง" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 567).FirstOrDefault().AnsDes == "ไม่ได้ระดับ/เอียง") { Response.Write("checked"); } else { Response.Write(""); }  %> />ไม่ได้ระดับ/เอียง
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">แนว Line Of Sight</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="xxlineOfsightRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 568).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); }  %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="xxlineOfsightRadio" value="โดนบัง" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 568).FirstOrDefault().AnsDes == "โดนบัง") { Response.Write("checked"); } else { Response.Write(""); }  %> />โดนบัง
                    </label>
                </div>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-4">ความสะอาดของหน้าจาน</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="cleaningDishRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 569).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); }  %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="cleaningDishRadio" value="สกปรก" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 569).FirstOrDefault().AnsDes == "สกปรก") { Response.Write("checked"); } else { Response.Write(""); }  %>>สกปรก
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">LNB Band Switch</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="lnbbandswitchRadio" value="HIGHBAND" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 570).FirstOrDefault().AnsDes == "HIGHBAND") { Response.Write("checked"); } else { Response.Write(""); }  %>>HIGH BAND
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="lnbbandswitchRadio" value="LOWBAND" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 570).FirstOrDefault().AnsDes == "LOWBAND") { Response.Write("checked"); } else { Response.Write(""); }  %>>LOW BAND
                    </label>
                </div>
            </div>
















            <div class="row mt-3">
                <div class="col-md-12 bg-primary text-white text-center Myfont">
                    <h5>9.อุปกรณ์ระบบ Solar Cell (เฉพาะ Site ที่ใช้ Solar Cell)</h5>
                </div>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-4">ระบบ Solar Cell</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="solarcellSystemRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 571).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); }  %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="solarcellSystemRadio" value="ชำรุด/ใช้งานไม่ได้" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 571).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); }  %> />ชำรุด/ใช้งานไม่ได้
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">แผง PV Panel</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="pvPanelRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 572).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); }  %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="pvPanelRadio" value="ชำรุด/ใช้งานไม่ได้" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 572).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); }  %> />ชำรุด/ใช้งานไม่ได้
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">อุปกรณ์ Charger</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="toolsCharger" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 573).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); }  %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="toolsCharger" value="ชำรุด/ใช้งานไม่ได้" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 573).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); }  %> />ชำรุด/ใช้งานไม่ได้
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">ความสะอาดแผง PV </label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="cleanIngpvRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 574).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); }  %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="cleanIngpvRadio" value="สกปรก" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 574).FirstOrDefault().AnsDes == "สกปรก") { Response.Write("checked"); } else { Response.Write(""); }  %> />สกปรก
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">การติดตั้งแผง PV </label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="installPvRadio" value="ที่โล่งรับแดดปกติ " <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 575).FirstOrDefault().AnsDes == "ที่โล่งรับแดดปกติ") { Response.Write("checked"); } else { Response.Write(""); }  %> />ที่โล่งรับแดดปกติ 
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="installPvRadio" value="มีอาคาร/ต้นไม้บัง" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 575).FirstOrDefault().AnsDes == "มีอาคาร/ต้นไม้บัง") { Response.Write("checked"); } else { Response.Write(""); }  %> />มีอาคาร/ต้นไม้บัง
                    </label>
                </div>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-2">แรงดันไฟจาก Inverter</label>
                <div class="col-sm-2">
                    <asp:Label  id="voltInverterLabel" runat="server" />
                </div>
                <label class="control-label col">V.</label>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-2">กระแส Load</label>
                <div class="col-sm-2">
                    <asp:Label  id="loadVoltTageLabel" runat="server" />
                </div>
                <label class="control-label col">A.</label>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-2">แรงดัน Battery ก้อนที่ 1</label>
                <div class="col-sm-2">
                    <asp:Label  id="batterLabel1" runat="server" />
                </div>
                <label class="control-label col">V.</label>
            </div>
            <div class="form-row mt-3">
                <label class="control-label col-sm-2">แรงดัน Battery ก้อนที่ 2</label>
                <div class="col-sm-2">
                    <asp:Label  id="batterLabel2" runat="server" />
                </div>
                <label class="control-label col">V.</label>
            </div>
            <div class="form-row mt-3">
                <label class="control-label col-sm-2">แรงดัน Battery ก้อนที่ 3</label>
                <div class="col-sm-2">
                    <asp:Label  id="batterLabel3" runat="server" />
                </div>
                <label class="control-label col">V.</label>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-2">แรงดัน Battery ก้อนที่ 4</label>
                <div class="col-sm-2">
                    <asp:Label  id="batterLabel4" runat="server" />
                </div>
                <label class="control-label col">V.</label>
            </div>

















            <div class="row mt-3">
                <div class="col-md-12 bg-primary text-white text-center Myfont">
                    <h5>10. คุณภาพของสัญญาณ</h5>
                </div>
            </div>



            <div class="form-row mt-3">
                <label class="control-label col-sm-2">Download (for ONU/VSAT)</label>
                <div class="col-sm-2">
                    <asp:Label  id="dowloadOnuLabel" runat="server" />
                </div>
                <label class="control-label col">Mb/s</label>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-2">Upload (for ONU/VSAT)</label>
                <div class="col-sm-2">
                    <asp:Label  id="uploadforOnuLabel" runat="server" />
                </div>
                <label class="control-label col">Mb/s</label>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-2">Ping Test (for ONU/VSAT)</label>
                <div class="col-sm-2">
                    <asp:Label  id="pinngtestforOnuLabel" runat="server" />
                </div>
                <label class="control-label col">ms</label>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-2">Download (for WIFI)</label>
                <div class="col-sm-2">
                    <asp:Label  id="dowloadforMobileLabel" runat="server" />
                </div>
                <label class="control-label col">Mb/s</label>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-2">Upload (for WIFI)</label>
                <div class="col-sm-2">
                    <asp:Label  id="uploadforMobileLabel" runat="server" />
                </div>
                <label class="control-label col">Mb/s</label>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-2">Ping Test (for WIFI)</label>
                <div class="col-sm-2">
                    <asp:Label  id="pingtestFormobileLabel" runat="server" />
                </div>
                <label class="control-label col">Ms</label>
            </div>


            <div class="row mt-3">
                <div class="col-md-12 bg-warning text-white text-center Myfont">
                    <h5>11.ปัญหาที่พบและการแก้ไข</h5>
                </div>
            </div>

            <div class="divTable" style="width: 100%;">
                <div class="divTableBody">
                    <div class="divTableRow">
                        <div class="divTableCell">ลำดับ</div>
                        <div class="divTableCell">ปัญหาที่พบ</div>
                        <div class="divTableCell">แนวทางการแก้ไข</div>
                    </div>


                    <div class="divTableRow">
                        <div class="divTableCell">&nbsp;1</div>
                        <div class="divTableCell">

                            <asp:Label  id="problemLabel1" runat="server" />
                        </div>
                        <div class="divTableCell">

                            <asp:Label  id="howtoSolveLabel1" runat="server" />
                        </div>
                    </div>

                    <div class="divTableRow">
                        <div class="divTableCell">&nbsp;2</div>
                        <div class="divTableCell">

                            <asp:Label  id="problemLabel2" runat="server" />
                        </div>
                        <div class="divTableCell">

                            <asp:Label  id="howtoSolveLabel2" runat="server" />
                        </div>
                    </div>

                    <div class="divTableRow">
                        <div class="divTableCell">&nbsp;3</div>
                        <div class="divTableCell">

                            <asp:Label  id="problemLabel3" runat="server" />
                        </div>
                        <div class="divTableCell">

                            <asp:Label  id="howtoSolveLabel3" runat="server" />
                        </div>
                    </div>

                    <div class="divTableRow">
                        <div class="divTableCell">&nbsp;4</div>
                        <div class="divTableCell">

                            <asp:Label  id="problemLabel4" runat="server" />
                        </div>
                        <div class="divTableCell">

                            <asp:Label  id="howtoSolveLabel4" runat="server" />
                        </div>
                    </div>

                    <div class="divTableRow">
                        <div class="divTableCell">&nbsp;5</div>
                        <div class="divTableCell">

                            <asp:Label  id="problemLabel5" runat="server" />
                        </div>
                        <div class="divTableCell">

                            <asp:Label id="howtoSolveLabel5" runat="server" />
                        </div>
                    </div>
                    <div class="divTableRow">
                        <div class="divTableCell">&nbsp;6</div>
                        <div class="divTableCell">

                            <asp:Label  id="problemLabel6" runat="server" />
                        </div>
                        <div class="divTableCell">

                            <asp:Label  id="howtoSolveLabel6" runat="server" />
                        </div>
                    </div>
                    <div class="divTableRow">
                        <div class="divTableCell">&nbsp;7</div>
                        <div class="divTableCell">

                            <asp:Label  id="problemLabel7" runat="server" />
                        </div>
                        <div class="divTableCell">

                            <asp:Label  id="howtoSolveLabel7" runat="server" />
                        </div>
                    </div>
                    <div class="divTableRow">
                        <div class="divTableCell">&nbsp;8</div>
                        <div class="divTableCell">

                            <asp:Label  id="problemLabel8" runat="server" />
                        </div>
                        <div class="divTableCell">

                            <asp:Label  id="howtoSolveLabel8" runat="server" />
                        </div>
                    </div>
                    <div class="divTableRow">
                        <div class="divTableCell">&nbsp;9</div>
                        <div class="divTableCell">

                            <asp:Label  id="problemLabel9" runat="server" />
                        </div>
                        <div class="divTableCell">

                            <asp:Label  id="howtoSolveLabel9" runat="server" />
                        </div>
                    </div>
                    <div class="divTableRow">
                        <div class="divTableCell">&nbsp;10</div>
                        <div class="divTableCell">

                            <asp:Label  id="problemLabel10" runat="server" />
                        </div>
                        <div class="divTableCell">

                            <asp:Label  id="howtoSolveLabel10" runat="server" />
                        </div>
                    </div>
                    <div class="divTableRow">
                        <div class="divTableCell">&nbsp;11</div>
                        <div class="divTableCell">

                            <asp:Label  id="problemLabel11" runat="server" />
                        </div>
                        <div class="divTableCell">

                            <asp:Label  id="howtoSolveLabel11" runat="server" />
                        </div>
                    </div>
                    <div class="divTableRow">
                        <div class="divTableCell">&nbsp;12</div>
                        <div class="divTableCell">

                            <asp:Label  id="problemLabel12" runat="server" />
                        </div>
                        <div class="divTableCell">

                            <asp:Label  id="howtoSolveLabel12" runat="server" />
                        </div>
                    </div>
                    <div class="divTableRow">
                        <div class="divTableCell">&nbsp;13</div>
                        <div class="divTableCell">

                            <asp:Label  id="problemLabel13" runat="server" />
                        </div>
                        <div class="divTableCell">

                            <asp:Label  id="howtoSolveLabel13" runat="server" />
                        </div>
                    </div>
                    <div class="divTableRow">
                        <div class="divTableCell">&nbsp;14</div>
                        <div class="divTableCell">

                            <asp:Label  id="problemLabel14" runat="server" />
                        </div>
                        <div class="divTableCell">

                            <asp:Label  id="howtoSolveLabel14" runat="server" />
                        </div>
                    </div>
                    <div class="divTableRow">
                        <div class="divTableCell">&nbsp;15</div>
                        <div class="divTableCell">

                            <asp:Label  id="problemLabel15" runat="server" />
                        </div>
                        <div class="divTableCell">

                            <asp:Label  id="howtoSolveLabel15" runat="server" />
                        </div>
                    </div>
                </div>
            </div>





            <div class="row mt-3">
                <div class="col-md-12 bg-primary text-white text-center Myfont">
                    <h3>11.ข้อมูลรายการทรัพย์สิน</h3>
                </div>
            </div>

            <div class="table-responsive-sm text-center Myfont">
                <table class="table table-sm" style="width: 100%;" border="0">
                    <thead>
                        <tr>
                            <th scope="col">ลำดับ</th>
                            <th scope="col">รายการอุปกรณ์</th>
                            <th scope="col">Serial Number</th>
                            <th scope="col">Serial Number ใหม่</th>
                            <th scope="col">หมายเหตุ</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td>1</td>
                            <td>

                                <asp:Label  id="toolsListLabel1" runat="server" /></td>
                            <td>

                                <asp:Label  id="serialNumberLabel1" runat="server" /></td>
                            <td>

                                <asp:Label  id="newSerialNumberLabel1" runat="server" /></td>
                            <td>

                                <asp:Label  id="noteLabel1" runat="server" /></td>
                        </tr>
                        <tr>

                            <td>2</td>
                            <td>

                                <asp:Label  id="toolsListLabel2" runat="server" /></td>
                            <td>

                                <asp:Label  id="serialNumberLabel2" runat="server" /></td>
                            <td>

                                <asp:Label  id="newSerialNumberLabel2" runat="server" /></td>
                            <td>

                                <asp:Label  id="noteLabel2" runat="server" /></td>
                        </tr>
                        <tr>
                            <td>3</td>
                            <td>

                                <asp:Label  id="toolsListLabel3" runat="server" /></td>
                            <td>

                                <asp:Label  id="serialNumberLabel3" runat="server" /></td>
                            <td>

                                <asp:Label  id="newSerialNumberLabel3" runat="server" /></td>
                            <td>

                                <asp:Label  id="noteLabel3" runat="server" /></td>
                        </tr>
                        <tr>
                            <td>4</td>
                            <td>

                                <asp:Label  id="toolsListLabel4" runat="server" /></td>
                            <td>

                                <asp:Label  id="serialNumberLabel4" runat="server" /></td>
                            <td>

                                <asp:Label  id="newSerialNumberLabel4" runat="server" /></td>
                            <td>

                                <asp:Label  id="noteLabel4" runat="server" /></td>
                        </tr>
                        <tr>
                            <td>5</td>
                            <td>

                                <asp:Label  id="toolsListLabel5" runat="server" /></td>
                            <td>

                                <asp:Label  id="serialNumberLabel5" runat="server" /></td>
                            <td>

                                <asp:Label  id="newSerialNumberLabel5" runat="server" /></td>
                            <td>

                                <asp:Label  id="noteLabel5" runat="server" /></td>
                        </tr>
                        <tr>
                            <td>6</td>
                            <td>

                                <asp:Label  id="toolsListLabel6" runat="server" /></td>
                            <td>

                                <asp:Label  id="serialNumberLabel6" runat="server" /></td>
                            <td>

                                <asp:Label  id="newSerialNumberLabel6" runat="server" /></td>
                            <td>

                                <asp:Label  id="noteLabel6" runat="server" /></td>
                        </tr>
                        <tr>
                            <td>7</td>
                            <td>

                                <asp:Label  id="toolsListLabel7" runat="server" /></td>
                            <td>

                                <asp:Label  id="serialNumberLabel7" runat="server" /></td>
                            <td>

                                <asp:Label  id="newSerialNumberLabel7" runat="server" /></td>
                            <td>

                                <asp:Label  id="noteLabel7" runat="server" /></td>
                        </tr>
                        <tr>
                            <td>8</td>
                            <td>

                                <asp:Label  id="toolsListLabel8" runat="server" /></td>
                            <td>

                                <asp:Label  id="serialNumberLabel8" runat="server" /></td>
                            <td>

                                <asp:Label  id="newSerialNumberLabel8" runat="server" /></td>
                            <td>

                                <asp:Label  id="noteLabel8" runat="server" /></td>
                        </tr>
                        <tr>
                            <td>9</td>
                            <td>

                                <asp:Label  id="toolsListLabel9" runat="server" /></td>
                            <td>

                                <asp:Label  id="serialNumberLabel9" runat="server" /></td>
                            <td>

                                <asp:Label  id="newSerialNumberLabel9" runat="server" /></td>
                            <td>

                                <asp:Label  id="noteLabel9" runat="server" /></td>
                        </tr>
                        <tr>
                            <td>10</td>
                            <td>

                                <asp:Label  id="toolsListLabel10" runat="server" /></td>
                            <td>

                                <asp:Label  id="serialNumberLabel10" runat="server" /></td>
                            <td>

                                <asp:Label  id="newSerialNumberLabel10" runat="server" /></td>
                            <td>

                                <asp:Label  id="noteLabel10" runat="server" /></td>
                        </tr>
                        <tr>
                            <td>11</td>
                            <td>

                                <asp:Label  id="toolsListLabel11" runat="server" /></td>
                            <td>

                                <asp:Label  id="serialNumberLabel11" runat="server" /></td>
                            <td>

                                <asp:Label  id="newSerialNumberLabel11" runat="server" /></td>
                            <td>

                                <asp:Label  id="noteLabel11" runat="server" /></td>
                        </tr>
                        <tr>
                            <td>12</td>
                            <td>

                                <asp:Label  id="toolsListLabel12" runat="server" /></td>
                            <td>

                                <asp:Label  id="serialNumberLabel12" runat="server" /></td>
                            <td>

                                <asp:Label  id="newSerialNumberLabel12" runat="server" /></td>
                            <td>

                                <asp:Label  id="noteLabel12" runat="server" /></td>
                        </tr>
                        <tr>
                            <td>13</td>
                            <td>

                                <asp:Label  id="toolsListLabel13" runat="server" /></td>
                            <td>

                                <asp:Label  id="serialNumberLabel13" runat="server" /></td>
                            <td>

                                <asp:Label  id="newSerialNumberLabel13" runat="server" /></td>
                            <td>

                                <asp:Label  id="noteLabel13" runat="server" /></td>
                        </tr>
                        <tr>
                            <td>14</td>
                            <td>

                                <asp:Label  id="toolsListLabel14" runat="server" /></td>
                            <td>

                                <asp:Label  id="serialNumberLabel14" runat="server" /></td>
                            <td>

                                <asp:Label  id="newSerialNumberLabel14" runat="server" /></td>
                            <td>

                                <asp:Label  id="noteLabel14" runat="server" /></td>
                        </tr>
                        <tr>
                            <td>15</td>
                            <td>

                                <asp:Label  id="toolsListLabel15" runat="server" /></td>
                            <td>

                                <asp:Label  id="serialNumberLabel15" runat="server" /></td>
                            <td>

                                <asp:Label  id="newSerialNumberLabel15" runat="server" /></td>
                            <td>

                                <asp:Label  id="noteLabel15" runat="server" /></td>
                        </tr>
                    </tbody>
                </table>
            </div>



            <div class="row mt-3">
                <div class="col-md-12 bg-primary text-white text-center Myfont">
                    <h3>12. รายละเอียดผู้ทำ PM</h3>
                </div>
            </div>
            <div class="row mt-3">
                <div class="col-md-3 text-center">
                    <span>ชื่อ</span>
                </div>
                <div class="col-md-9">
                    <asp:Label  id="nameDopmLabel" runat="server" />
                </div>
            </div>
            <div class="row mt-3">
                <div class="col-md-3 text-center">
                    <span>วันที่ทำ PM</span>
                </div>
                <div class="col-md-9">
                    <asp:Label  id="dayDopmLabel" runat="server" />
                </div>
            </div>





            <div class="row mt-3">
                <div class="col-md-12 bg-success text-white text-center Myfont">
                    <h3>PICTURE CHECKLIST</h3>
                </div>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูปภาพรวมบริเวณ Site</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="steAreaRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 680).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="steAreaRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 680).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูปหน้าตู้ ก่อน-หลัง</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="beforeAfterRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 681).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="beforeAfterRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 681).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูปภายในตู้ ก่อน-หลัง</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="picIncontainRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 682).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="picIncontainRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 682).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูปขณะทำความสะอาดตู้ ก่อน-หลัง</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="beforeCleanRaio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 683).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="beforeCleanRaio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 683).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูปสถานะ Circuit Breaker (ON)</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="circuitBreakOnRaio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 684).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="circuitBreakOnRaio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 684).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูปการตรวจสอบ Ground และ Bar Ground</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="GroundAndBarGroundRaio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 685).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="GroundAndBarGroundRaio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 685).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />NOT PASS
                    </label>
                </div>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูปการตรวจสอบสถานะไฟฟ้ารั่วลง Ground (Lamp Test)</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="groundLampRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 686).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="groundLampRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 686).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูป PEA Meter</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="peaMeterRaio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 687).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="peaMeterRaio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 687).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูปการวัดแรงดัน AC และกระแส AC </label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="acAndACRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 688).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="acAndACRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 688).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูปหน้าจอ UPS แสดงค่าต่างๆ และ Serial NO.  </label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="monitorSerRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 689).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="monitorSerRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 689).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูป ONU/Modem พร้อม Serial NO. และ MAC </label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="ONUModemAndMacRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 690).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="ONUModemAndMacRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 690).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />NOT PASS
                    </label>
                </div>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูป Power Supply พร้อม Serial NO. </label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="psuAndSerialRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 691).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="psuAndSerialRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 691).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูป Switch 8 Port พร้อม Serial NO. และ MAC</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="switch8PortRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 692).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="switch8PortRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 692).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูป Outdoor AP 2.4 GHz พร้อม Serial NO. และ MAC</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="outDoorApRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 693).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="outDoorApRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 693).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูป Outdoor AP 5 GHz พร้อม Serial NO. และ MAC</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="PASSoutDoorAp5GhzRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 694).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="PASSoutDoorAp5GhzRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 694).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />NOT PASS
                    </label>
                </div>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูปการ Test Speed ONU (30/10 mbps) </label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="testSpeedOnuRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 695).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="testSpeedOnuRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 695).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูปการ Test Speed VSAT (30/5 mbps) *เฉพาะ SAT</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="testSpeedVsatRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 696).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="testSpeedVsatRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 696).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูป Cable Inlet ด้านในและด้านนอก</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="eieicableInletRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 697).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="eieicableInletRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 697).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูป Filter ก่อน-หลัง ทำความสะอาด</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="filterBeforeCleanRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 698).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="filterBeforeCleanRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 698).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />NOT PASS
                    </label>
                </div>
            </div>




            <div class="row mt-3">
                <div class="col-md-12 bg-primary text-white text-center Myfont">
                    <h3>VSAT PICTURE CHECKLIST</h3>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูปจุดติดตั้งจานดาวเทียม</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="inStallSatRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 699).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="inStallSatRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 699).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูปความสะอาดบริเวณจานดาวเทียม</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="cleanSatRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 700).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="cleanSatRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 700).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูป LNB พร้อม Part NO.</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="lnbWithpartRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 701).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="lnbWithpartRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 701).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูป BUC พร้อม Part NO.</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="bucWithpartRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 702).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="bucWithpartRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 702).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูปการเก็บสายและพันหัวที่ LNB/BUC</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="wireingLnbRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 703).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="wireingLnbRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 703).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูปแนว Line Of Sight (ดูการถูกบังของหน้าจานดาวเทียม)</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="lineOfsightRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 704).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="lineOfsightRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 704).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />NOT PASS
                    </label>
                </div>
            </div>











            <div class="row mt-3">
                <div class="col-md-12 bg-primary text-white text-center Myfont">
                    <h3>SOLAR CELL PICTURE CHECKLIST</h3>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4" >รูปจุดติดตั้ง Solar Cell</label>
                <div class="form-check-inline">
                    <label class="form-check-label" >
                        <input type="radio" class="form-check-input" name="solarCellRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 705).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label" >
                        <input type="radio" class="form-check-input" name="solarCellRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 705).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4" >รูปอุปกรณ์ภายในตู้ Solar Cell</label>
                <div class="form-check-inline">
                    <label class="form-check-label" >
                        <input type="radio" class="form-check-input" name="toolsinSolarcellRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 706).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label" >
                        <input type="radio" class="form-check-input" name="toolsinSolarcellRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 706).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4" >รูปหน้าจอ Charger แสดงค่าต่างๆ</label>
                <div class="form-check-inline">
                    <label class="form-check-label" >
                        <input type="radio" class="form-check-input" name="chargerRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 707).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label" >
                        <input type="radio" class="form-check-input" name="chargerRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 707).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4" >รูปหน้าจอ Inverter แสดงค่าต่างๆ</label>
                <div class="form-check-inline">
                    <label class="form-check-label" >
                        <input type="radio" class="form-check-input" name="snowingInverterRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 708).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label" >
                        <input type="radio" class="form-check-input" name="snowingInverterRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 708).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />NOT PASS
                    </label>
                </div>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-4" >รูป Circuit Breaker ภายในตู้</label>
                <div class="form-check-inline">
                    <label class="form-check-label" >
                        <input type="radio" class="form-check-input" name="cirBreakerRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 709).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label" >
                        <input type="radio" class="form-check-input" name="cirBreakerRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 709).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4" >รูป Terminal ต่อสายภายในตู้</label>
                <div class="form-check-inline">
                    <label class="form-check-label" >
                        <input type="radio" class="form-check-input" name="termialInnerRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 710).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label" >
                        <input type="radio" class="form-check-input" name="termialInnerRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 710).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4" >รูปการวัดแรงดัน Battery ก้อนที่ 1</label>
                <div class="form-check-inline">
                    <label class="form-check-label" >
                        <input type="radio" class="form-check-input" name="batteryVoltRadio1" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 711).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label" >
                        <input type="radio" class="form-check-input" name="batteryVoltRadio1" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 711).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4" >รูปการวัดแรงดัน Battery ก้อนที่ 2</label>
                <div class="form-check-inline">
                    <label class="form-check-label" >
                        <input type="radio" class="form-check-input" name="batteryVoltRadio2" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 712).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label" >
                        <input type="radio" class="form-check-input" name="batteryVoltRadio2" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 712).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4" >รูปการวัดแรงดัน Battery ก้อนที่ 3</label>
                <div class="form-check-inline">
                    <label class="form-check-label" >
                        <input type="radio" class="form-check-input" name="batteryVoltRadio3" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 713).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label" >
                        <input type="radio" class="form-check-input" name="batteryVoltRadio3" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 713).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4" >รูปการวัดแรงดัน Battery ก้อนที่ 4</label>
                <div class="form-check-inline">
                    <label class="form-check-label" >
                        <input type="radio" class="form-check-input" name="batteryVoltRadio4" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 714).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label" >
                        <input type="radio" class="form-check-input" name="batteryVoltRadio4" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 714).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4" >รูปความสะอาดแผง PV</label>
                <div class="form-check-inline">
                    <label class="form-check-label" >
                        <input type="radio" class="form-check-input" name="cleaninPVVRADIO" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 715).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label" >
                        <input type="radio" class="form-check-input" name="cleaninPVVRADIO" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 715).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4" >รูปภาพรวมดูสิ่งบดบังแสงอาทิตย์</label>
                <div class="form-check-inline">
                    <label class="form-check-label" >
                        <input type="radio" class="form-check-input" name="sunnyRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 716).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label" >
                        <input type="radio" class="form-check-input" name="sunnyRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 716).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />NOT PASS
                    </label>
                </div>
            </div>

            <div class="row mt-3">
                <div class="col-md-12 bg-warning text-white text-center Myfont">
                    <h4>COMPUTER PICTURE CHECKLIST</h4>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-5">รูปคอมพิวเตอร์ตัวที่ 1 พร้อม Serial NO.</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="PicComRadio1" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 717).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="PicComRadio1" value="ชำรุด/ใช้งานไม่ได้" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 717).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); }  %> />ชำรุด/ใช้งานไม่ได้
                    </label>
                </div>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-5">รูปคอมพิวเตอร์ตัวที่ 2 พร้อม Serial NO.</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="PicComRadio2" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 718).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); }  %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="PicComRadio2" value="ชำรุด/ใช้งานไม่ได้" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 718).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); }  %> />ชำรุด/ใช้งานไม่ได้
                    </label>
                </div>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-5">รูปคอมพิวเตอร์ตัวที่ 3 พร้อม Serial NO.</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="PicComRadio3" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 719).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); }  %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="PicComRadio3" value="ชำรุด/ใช้งานไม่ได้" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 719).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); }  %> />ชำรุด/ใช้งานไม่ได้
                    </label>
                </div>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-5">รูปคอมพิวเตอร์ตัวที่ 4 พร้อม Serial NO.</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="PicComRadio4" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 720).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); }  %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="PicComRadio4" value="ชำรุด/ใช้งานไม่ได้" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 720).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); }  %> />ชำรุด/ใช้งานไม่ได้
                    </label>
                </div>
            </div>



            <div class="form-row mt-3">
                <label class="control-label col-sm-5">รูปคอมพิวเตอร์ตัวที่ 5 พร้อม Serial NO.</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="PicComRadio5" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 721).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); }  %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="PicComRadio5" value="ชำรุด/ใช้งานไม่ได้" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 721).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); }  %> />ชำรุด/ใช้งานไม่ได้
                    </label>
                </div>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-5">รูป USP สำหรับคอมพิวเตอร์ตัวที่ 1 พร้อม Serial NO.</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="PicupsRadio1" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 722).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); }  %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="PicupsRadio1" value="ชำรุด/ใช้งานไม่ได้" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 722).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); }  %> />ชำรุด/ใช้งานไม่ได้
                    </label>
                </div>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-5">รูป USP สำหรับคอมพิวเตอร์ตัวที่ 2 พร้อม Serial NO.</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="PicupsRadio2" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 723).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); }  %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="PicupsRadio2" value="ชำรุด/ใช้งานไม่ได้" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 723).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); }  %> />ชำรุด/ใช้งานไม่ได้
                    </label>
                </div>
            </div>



            <div class="form-row mt-3">
                <label class="control-label col-sm-5">รูป USP สำหรับคอมพิวเตอร์ตัวที่ 3 พร้อม Serial NO.</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="PicupsRadio3" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 724).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); }  %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="PicupsRadio3" value="ชำรุด/ใช้งานไม่ได้" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 724).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); }  %> />ชำรุด/ใช้งานไม่ได้
                    </label>
                </div>
            </div>



            <div class="form-row mt-3">
                <label class="control-label col-sm-5">รูป USP สำหรับคอมพิวเตอร์ตัวที่ 4 พร้อม Serial NO.</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="PicupsRadio4" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 725).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); }  %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="PicupsRadio4" value="ชำรุด/ใช้งานไม่ได้" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 725).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); }  %> />ชำรุด/ใช้งานไม่ได้
                    </label>
                </div>
            </div>



            <div class="form-row mt-3">
                <label class="control-label col-sm-5">รูป USP สำหรับคอมพิวเตอร์ตัวที่ 5 พร้อม Serial NO.</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="PicupsRadio5" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 726).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); }  %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="PicupsRadio5" value="ชำรุด/ใช้งานไม่ได้" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 726).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); }  %> />ชำรุด/ใช้งานไม่ได้
                    </label>
                </div>
            </div>





            <div class="form-row mt-3">
                <label class="control-label col-sm-5">รูป Test ใช้งาน Internet (Speed Test) คอมพิวเตอร์ตัวที่ 1 </label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="PicspeedTestRaio1" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 727).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); }  %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="PicspeedTestRaio1" value="ชำรุด/ใช้งานไม่ได้" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 727).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); }  %> />ชำรุด/ใช้งานไม่ได้
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-5">รูป Test ใช้งาน Internet (Speed Test) คอมพิวเตอร์ตัวที่ 2</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="PicspeedTestRaio2" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 728).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); }  %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="PicspeedTestRaio2" value="ชำรุด/ใช้งานไม่ได้" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 728).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); }  %> />ชำรุด/ใช้งานไม่ได้
                    </label>
                </div>
            </div>
            <div class="form-row mt-3">
                <label class="control-label col-sm-5">รูป Test ใช้งาน Internet (Speed Test) คอมพิวเตอร์ตัวที่ 3</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="PicspeedTestRaio3" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 729).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); }  %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="PicspeedTestRaio3" value="ชำรุด/ใช้งานไม่ได้" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 729).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); }  %> />ชำรุด/ใช้งานไม่ได้
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-5">รูป Test ใช้งาน Internet (Speed Test) คอมพิวเตอร์ตัวที่ 4</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="PicspeedTestRaio4" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 730).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); }  %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="PicspeedTestRaio4" value="ชำรุด/ใช้งานไม่ได้" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 730).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); }  %> />ชำรุด/ใช้งานไม่ได้
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-5">รูป Test ใช้งาน Internet (Speed Test) คอมพิวเตอร์ตัวที่ 5</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="PicspeedTestRaio5" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 731).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); }  %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="PicspeedTestRaio5" value="ชำรุด/ใช้งานไม่ได้" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 731).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); }  %> />ชำรุด/ใช้งานไม่ได้
                    </label>
                </div>
            </div>




            <br />

            <div class="row mt-3">
                <div class="col-md-12  text-black text-center Myfont">
                    <h3>รูปภาพประกอบรายงาน</h3>
                </div>
            </div>
            <div class="row mt-3">
                <div class="col-sm-12">1.รูป PICTURE CHECKLIST </div>
              
            </div>
            <div class="row ml-3 mt-3">
                <img id="user_img_2" src='<% if (answers.Count() > 0) Response.Write(answers.Where(x => x.QuestionId == 732).FirstOrDefault().AnsDes); %>' class="placeholder2" />
            </div>




            <div class="row mt-3">
                <div class="col-sm-12">2.รูป VSAT PICTURE CHECKLIST</div>
              
            </div>
            <div class="row ml-3 mt-3">
                <img id="user_img_3" src='<% if (answers.Count() > 0) Response.Write(answers.Where(x => x.QuestionId == 733).FirstOrDefault().AnsDes); %>' class="placeholder2" />
            </div>



            <div class="row mt-3">
                <div class="col-sm-12">3.รูป SOLAR CELL PICTURE CHECKLIST</div>
              
            </div>
            <div class="row ml-3 mt-3">
                <img id="user_img_4" src='<% if (answers.Count() > 0) Response.Write(answers.Where(x => x.QuestionId == 734).FirstOrDefault().AnsDes); %>' class="placeholder2" />
            </div>


            <div class="row mt-3">
                <div class="col-sm-12">4. COMPUTER PICTURE CHECKLIST</div>
              
            </div>
            <div class="row ml-3 mt-3">
                <img id="user_img_5" src='<% if (answers.Count() > 0) Response.Write(answers.Where(x => x.QuestionId == 735).FirstOrDefault().AnsDes); %>' class="placeholder2" />
            </div>

            <br />
            <br />
            <br />
            <br />    
               <div class="row justify-content-center mt-5">
                <div class="row">
                    <button id="printPageButton" onclick="window.print();">พิมพ์หน้านี้</button>
                </div>
            </div>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
    <style>
        .kbw-signature {
            width: 400px;
            height: 200px;
        }
    </style>
       <style type="text/css">
        @media print {
            #non-printable {
                display: none !important;
            }

            #printable {
                display: block;
            }

            .printText {
                border: none !important;
            }

            #printPageButton {
                display: none;
            }
        }
    </style>
</body>
</html>
