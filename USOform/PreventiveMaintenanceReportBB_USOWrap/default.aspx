<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="USOform.PreventiveMaintenanceReportBBUSOWrap.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>รายงาน PM From BB Zone C+ บริการ USO Wrap</title>
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link href="~/style/Mystyle.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous" />
    <script src="previewImg.js"></script>
  
    
  
    <script src="spinner.js"></script>


    <%--font style--%>
    <link rel="preconnect" href="https://fonts.gstatic.com" />
    <link href="https://fonts.googleapis.com/css2?family=Sarabun:wght@100;300;400;500;600;700&display=swap" rel="stylesheet" />




    <%--    date time picker JQURRY--%>
    <link rel="stylesheet" href="//code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css" />
    <link rel="stylesheet" href="/resources/demos/style.css">
    <script src="https://code.jquery.com/jquery-1.12.4.js"></script>
    <script src="https://code.jquery.com/ui/1.12.1/jquery-ui.js"></script>
</head>

<body style="background-color: lightgrey;">
     
    <form id="form1" runat="server">   
        <div class="container bg-white Myfont">
            <div class="alert alert-success" role="alert" runat="server" id="SuccessPanel" visible="false">
                This is a success alert with <a href="#" class="alert-link">an example link</a>. Give it a click if you like.
            </div>

            <%--////////////////////////////////    HEADER CONTENT    ///////////////////////////////////////////////--%>
            <div class="row">
                <div class="col-12 text-left ">
                    <div>
                        <h5>รายงานผลการตรวจสอบและบำรุงรักษาชุดอุปกรณ์ Broadband Internet Service (Preventive Maintenance (PM) Report)</h5>
                    </div>
                    <div>
                        <h5>โครงการจัดให้มีสัญญาณโทรศัพท์เคลื่อนที่และบริการอินเทอร์เน็ตความเร็วสูงในพื้นที่ชายขอบ (Zone C+)</h5>
                    </div>
                </div>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-1">กลุ่ม :</label>
                <div class="col-sm-4">
                    <asp:TextBox ID="GroupNameTextBox" runat="server" CssClass="form-control" required="required"></asp:TextBox>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-1">ภาค :</label>
                <div class="col-sm-4">
                    <input type="text" class="form-control" id="AreaTextbox" runat="server" required="required" />
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-1">บริษัท :</label>
                <div class="col-sm-4">
                    <input type="text" class="form-control" id="CompanyTextbox" runat="server" required="required" />
                </div>
            </div>



            <div class="form-row mt-3">
                <label class="control-label col-sm-12">ส่วนที่ 1 การจัดให้มีบริการอินเทอร์เน็ตความเร็วสูง (Broadband Internet Service) บริการ USO Wrap</label>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-2">รอบการบำรุงรักษาครั้งที่</label>
                <div class="col-sm-1">
                    <input type="text" class="form-control" id="maintenanceCountTextbox" runat="server" required="required" />
                </div>
                /
              <div class="col-sm-3">
                  <input type="text" class="form-control" placeholder="ปีพุทธศักราช" id="yearTextbox" runat="server" required="required" />
              </div>
            </div>

            <%-- QuestionId = 8,--%>
            <div class="row text-left mt-3">
                <div class="col-md-12">
                    <div>
                        <label>
                            <div>วัน เดือน ปี</div>
                        </label>
                        <input class="form-control" type="text" id="startDatepicker" runat="server" required="required" />

                        <%-- QuestionId = 9,--%>
                        <label>
                            <div>ถึง</div>
                        </label>
                        <input class="form-control" type="text" id="endDatepicker" runat="server" required="required" />
                    </div>
                </div>
            </div>


            <%-- QuestionId = 10,--%>
            <div class="form-row mt-3">
                <label class="control-label col-sm-2">สถานที่ (Site code)</label>
                <div class="col-sm-4">
                    <input type="text" class="form-control" id="siteCodeTextbox" runat="server" required="required" />
                </div>
            </div>
            <%--////////////////////////////////    END HEADER CONTENT    ///////////////////////////////////////////////--%>











            <%--////////////// SECTION 2  //////////////////--%>
            <div class="row mt-3">
                <div class="col-md-12 bg-primary text-white text-center">
                    <h3>PREVENTIVE MAINTENANCE SITE REPORT (PM)</h3>
                </div>
            </div>

            <%-- QuestionId = 11,--%>
            <div class="form-row mt-3">
                <label class="control-label col-sm-1">Cabinet ID :</label>
                <div class="col-sm-11">
                    <input type="text" class="form-control" id="cabinetIdTextbox" runat="server" required="required" />
                </div>
            </div>

            <%-- QuestionId = 12,--%>
            <div class="form-row mt-3">
                <label class="control-label col-sm-1">Site Code :</label>
                <div class="col-sm-11">
                    <input class="form-control" type="text" id="sitecodeTextboxSection2" runat="server" required="required" />
                </div>
            </div>

            <%-- QuestionId = 13,--%>
            <div class="form-row mt-3">
                <label class="control-label col-sm-1">Village ID :</label>
                <div class="col-sm-11">
                    <input type="text" class="form-control" id="VillageIdTextbox" runat="server" required="required" />
                </div>
            </div>

            <%-- QuestionId = 14,--%>
            <div class="form-row mt-3">
                <label class="control-label col-sm-1">Village :</label>
                <div class="col-sm-11">
                    <input type="text" class="form-control" id="villageTextbox" runat="server" required="required" />
                </div>
            </div>


            <%-- QuestionId = 15,--%>
            <div class="form-row mt-3">
                <label class="control-label col-sm-1">School’s name :</label>
                <div class="col-sm-11">
                    <input type="text" class="form-control" id="schoolnameTextbox" runat="server" required="required" />
                </div>
            </div>

            <%-- QuestionId = 16,--%>
            <div class="form-row mt-3">
                <label class="control-label col-sm-1">Sub-District :</label>
                <div class="col-sm-11">
                    <input type="text" class="form-control" id="subdistrictTextbox" runat="server" required="required" />
                </div>
            </div>

            <%-- QuestionId = 17,--%>
            <div class="form-row mt-3">
                <label class="control-label col-sm-1">Province :</label>
                <div class="col-sm-11">
                    <input type="text" class="form-control" id="provinceTextbox" runat="server" required="required" />
                </div>
            </div>

            <%-- QuestionId = 18,--%>
            <div class="form-row mt-3">
                <label class="control-label col-sm-1">Type :</label>
                <div class="col-sm-11">
                    <input type="text" class="form-control" id="typeTextbox" runat="server" required="required" />
                </div>
            </div>


            <%-- QuestionId = 19,--%>
            <div class="form-row mt-3">
                <label class="control-label col-sm-1">PM Date : </label>
                <div class="col-sm-11">
                    <input type="text" class="form-control" id="pmdateTextbox" runat="server" required="required" />
                </div>
            </div>


            <%-- QuestionId = 6, --%>
            <div class="row mt-3">
                <div class="col-sm-12 bg-primary text-white">ใส่ป้ายหน้าโรงเรียน</div>

                <asp:FileUpload ID="signboardschoolImage" runat="server" data-thumbnail="user_img_0" accept="image/*" onchange="previewImage(this)" required="required" />             
            </div>
            <%-- onchange="previewImage(this)"--%>
            <div class="row ml-3 mt-3">
                <img id="user_img_0" src="https://placehold.it/250x250" class="placeholder2" />
            </div>


            <%-- QuestionId = 20, --%>
            <div class="row mt-3">
                <div class="col-sm-12 bg-primary text-white">ใส่รูปหน้าอาคารศูนย์ USO Net</div>
                <%--OLD RESOUCE <asp:FileUpload ID="Building2Image" runat="server" data-thumbnail="user_img_1" accept="image/*" onchange="previewImage(this)" />--%>
                <asp:FileUpload ID="usonetsignboardImage" runat="server" data-thumbnail="user_img_1" accept="image/*" onchange="previewImage(this)" required="required" />
            </div>
            <div class="row ml-3 mt-3">
                <img id="user_img_1" src="https://placehold.it/250x250" class="placeholder2" />
            </div>


            <%--////////////// -------------END  SECTION ID 2-----------------  //////////////////--%>





            <%--////////////// -------------START  SECTION ID 3 -----------------  //////////////////--%>
            <div class="row mt-3">
                <div class="col-md-12 bg-warning text-white text-center Myfont">
                    <h4>Contractor</h4>
                </div>
            </div>

            <div class="row mt-3">
                <div class="col-md-6  text-center Myfont">
                    <span>Executor</span>
                </div>
                <div class="col-md-6 text-center  Myfont">
                    <span>Supervisor</span>
                </div>
            </div>


            <div class="row mt-3">
                <div class="col-md-1 text-center">
                    <span>Signature</span>
                </div>
                <div class="col-md-5 text-center">
                    <%-- QuestionId = 21, --%>
                    <input type="text" class="form-control" id="signatureExecutorTextbox" runat="server" required="required" />
                </div>
                <div class="col-md-6 text-center">
                    <%-- QuestionId = 22, --%>
                    <input type="text" class="form-control" id="signatureSupervisorTextbox" runat="server" required="required" />
                </div>
            </div>

            <div class="row mt-3">
                <div class="col-md-1 text-center">
                    <span>Name</span>
                </div>
                <div class="col-md-5 text-center">
                    <%-- QuestionId = 23, --%>
                    <input type="text" class="form-control" id="nameExecutorTextbox" runat="server" required="required" />
                </div>
                <div class="col-md-6 text-center">
                    <%-- QuestionId = 24, --%>
                    <input type="text" class="form-control" id="nameSupervisorTextbox" runat="server" required="required" />
                </div>
            </div>


            <div class="row mt-3">
                <div class="col-md-1 text-center">
                    <span>Date</span>
                </div>
                <div class="col-md-5 text-center">
                    <%-- QuestionId = 25, --%>
                    <input type="text" class="form-control" id="DateExecutorTextbox" runat="server" required="required" />
                </div>
                <div class="col-md-6 text-center">
                    <%-- QuestionId = 26, --%>
                    <input type="text" class="form-control" id="DateSupervisorTextbox" runat="server" required="required" />
                </div>
            </div>

            <%--////////////// -------------END  SECTION ID 3-----------------  //////////////////--%>
            <br />


            <%--////////////// ------------- SECTION ID 4-----------------  //////////////////--%>
            <div class="row ">
                <div class="col-md-12 bg-success text-white text-center Myfont">
                    <h3>1. รายละเอียดศูนย์</h3>
                </div>
            </div>
            <form class="mt-3">
                <div class="form-row mt-3">
                    <%-- QuestionId = 27, --%>
                    <label class="control-label col-sm-1">Location Name</label>
                    <div class="col-sm-11">
                        <input type="text" class="form-control" id="LocationnameTextbox" runat="server" required="required" />
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-1">Site Code</label>
                    <div class="col-sm-11">
                        <%-- QuestionId = 28, --%>
                        <input type="text" class="form-control" id="sitecodeTextboxSection4" runat="server" required="required" />
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-1">Village ID</label>
                    <div class="col-sm-11">
                        <%-- QuestionId = 29, --%>
                        <input type="text" class="form-control" id="villageIDTextboxSection4" runat="server" required="required" />
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-1">LAT & LONG</label>
                    <div class="col-sm-11">
                        <%-- QuestionId = 30, --%>
                        <input type="text" class="form-control" id="latandlongTextbox" runat="server" required="required" />
                    </div>
                </div>


                <%-- QuestionId = 31, --%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-2">Type of Signal</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="typeofsignalRadio" value="OFC" runat="server" />OFC
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input"  name="typeofsignalRadio" value="Satellite" runat="server" />Satellite
                        </label>
                    </div>
                </div>

                <%-- QuestionId = 32, --%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-2">ISP (Existing Network)</label>
                    <div class="col-sm-10">
                        <input type="text" class="form-control" id="ispTextbox" runat="server" required="required" />
                    </div>
                </div>
                <%--////////////// -------------END  SECTION ID 4-----------------  //////////////////--%>



              



                <%--////////////// -------------START  SECTION ID 5-----------------  //////////////////--%>
                <div class="row mt-3">
                    <div class="col-md-12 bg-primary text-white text-center Myfont">
                        <h3>2.ระบบไฟฟ้า (หลัก)</h3>
                    </div>
                </div>
                <div class="form-row mt-3">
                    <%------ QuestionId = 33, ------------------------------------------------------------------------------------------------------------%>
                    <label class="control-label col-sm-2">ระบบไฟฟ้า</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="elecRadio" value="PEA" />PEA
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="elecRadio" value="SolarCell" />Solar Cell
                        </label>
                    </div>
                </div>



                <div class="form-row mt-3">
                    <%------ QuestionId = 34, ---------------------------------------------------------------------------------------------------------%>
                    <label class="control-label col-sm-2">หม้อแปลงไฟฟ้า</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="transformerRadio" value="1Phase" />1 Phase
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="transformerRadio" value="3Phase" />3 Phase
                        </label>
                    </div>
                </div>


                <div class="form-row mt-3">
                    <%------ QuestionId = 35, ----------------------------------------------------------------------------------------------------------%>
                    <label class="control-label col-sm-2">หมายเลขผู้ใช้ไฟ</label>
                    <div class="col-sm-10">
                        <input type="text" class="form-control" id="numberuserTextbox" runat="server" required="required" />
                    </div>
                </div>

                <div class="form-row mt-3">
                    <%------ QuestionId = 36, ----------------------------------------------------------------------------------------------------------%>
                    <label class="control-label col-sm-2">หน่วยใช้ไฟ (kWh Meter)</label>
                    <div class="col-sm-8">
                        <input type="text" class="form-control" id="kwhMeterTextbox" runat="server" required="required" />
                    </div>
                    <label class="control-label col-sm-2">kWh</label>
                </div>


                <div class="form-row mt-3">
                    <%------ QuestionId = 37, ---------------------------------------------------------------------------------------------------------%>
                    <label class="control-label col-sm-2">แรงดัน AC (kWh Meter)</label>
                    <div class="col-sm-8">
                        <input type="text" class="form-control" id="acTextbox" runat="server" required="required" />
                    </div>
                    <label class="control-label col-sm-2">V.</label>
                </div>

                <div class="form-row mt-3">
                    <%------ QuestionId = 38, ----------------------------------------------------------------------------------------------------------%>
                    <label class="control-label col-sm-2">กระแส Line AC (kWh Meter)</label>
                    <div class="col-sm-8">
                        <input type="text" class="form-control" id="lineAcTextbox" runat="server" required="required" />
                    </div>
                    <label class="control-label col-sm-2">A.</label>
                </div>

                <div class="form-row mt-3">
                    <%------ QuestionId = 39, -----------------------------------------------------------------------------------------------------------%>
                    <label class="control-label col-sm-2">กระแส Neutron AC (kWh Meter)</label>
                    <div class="col-sm-8">
                        <input type="text" class="form-control" id="neutronacTextbox" runat="server" required="required" />
                    </div>
                    <label class="control-label col-sm-2">A.</label>
                </div>

                <div class="form-row mt-3">
                    <%------ QuestionId = 40, -----------------------------------------------------------------------------------------------------------%>
                    <label class="control-label col-sm-2">สภาพ kWh Meter</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="conditionRadio" value="ปกติ" />ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="conditionRadio" value="ชำรุด/ใช้งานไม่ได้" />ชำรุด/ใช้งานไม่ได้
                        </label>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <%------ QuestionId = 41, ----------------------------------------------------------------------------------------------------------%>
                    <label class="control-label col-sm-2">สภาพ MDB/ Circuit Breaker</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="MDBCircuitBreakerRadio" value="ปกติ" />ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="MDBCircuitBreakerRadio" value="ชำรุด/ใช้งานไม่ได้" />ชำรุด/ใช้งานไม่ได้
                        </label>
                    </div>
                </div>
                <%--////////////// -------------END  SECTION ID 5-----------------  //////////////////--%>











                <%--////////////// -------------START  SECTION ID 6 -----------------  //////////////////--%>
                <div class="row mt-3">
                    <div class="col-md-12 bg-primary text-white text-center Myfont">
                        <h3>3.ระบบไฟ (สำรอง)</h3>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <%------ QuestionId = 42, ----------------------------------------------------------------------------------------------------------%>
                    <label class="control-label col-sm-2">UPS ภายในตู้</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="inupsRadio" value="มี" />มี
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="inupsRadio" value="ไม่มี" />ไม่มี
                        </label>
                    </div>
                </div>


                <div class="form-row mt-3">
                    <%------ QuestionId = 43, ---------------------------------------------------------------------------------------------------------%>
                    <label class="control-label col-sm-2">แรงดัน AC จาก UPS</label>
                    <div class="col-sm-8">
                        <input type="text" class="form-control" id="acfromupsTextbox" runat="server" required="required" />
                    </div>
                    <label class="control-label col-sm-2">V.</label>
                </div>

                <%------ QuestionId = 44, --------------------------------------------------------------------------------------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-2">กระแส Load</label>
                    <div class="col-sm-8">
                        <input type="text" class="form-control" id="electricloadTextbox" runat="server" required="required" />
                    </div>
                    <label class="control-label col-sm-2">A.</label>
                </div>


                <%------ QuestionId = 7 , ---------------------------------------------------------------------------------------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-2">UPS MODE</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="upsModeRadio" value="LINE" required="required" />LINE
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="upsModeRadio" value="BATT." required="required" />BATT.
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="upsModeRadio" value="BYPASS" required="required" />BYPASS
                        </label>
                    </div>
                </div>



                <%------ QuestionId = 45, ---------------------------------------------------------------------------------------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-2">การทำงานของระบบไฟสำรอง</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="emergeneratorRadio" value="ปกติ" />ปกติ
                        </label>
                    </div>

                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="emergeneratorRadio" value="ชำรุด/ใช้งานไม่ได้" />ชำรุด/ใช้งานไม่ได้
                        </label>
                    </div>
                </div>

                <%------ QuestionId = 46, ----------------------------------------------------------------------------------------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-2">สภาพ Battery Bank</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="stateBatteryBankRadio" value="ปกติ" />ปกติ
                        </label>
                    </div>

                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="stateBatteryBankRadio" value="ชำรุด/ใช้งานไม่ได้" />ชำรุด/ใช้งานไม่ได้
                        </label>
                    </div>
                </div>
                <%--////////////// -------------END  SECTION ID 6 -----------------  //////////////////--%>









                <%--////////////// -------------START  SECTION ID 7 -----------------  //////////////////--%>
                <div class="row mt-3">
                    <div class="col-md-12 bg-primary text-white text-center Myfont">
                        <h3>4.รายละเอียดอุปกรณ์ Network ภายในศูนย์</h3>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <%------ QuestionId = 47, --------------------------------------------------------------------------------------------------------%>
                    <label class="control-label col-sm-2">ONU/Modem Network</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="onuModemRadio" value="USO" />USO
                        </label>
                    </div>

                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="onuModemRadio" value="TRUE" />TRUE
                        </label>
                    </div>

                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="onuModemRadio" value="3BB" />3BB
                        </label>
                    </div>

                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="onuModemRadio" value="Satellite" />Satellite
                        </label>
                    </div>
                </div>


                <%------ QuestionId = 48, --------------------------------------------------------------------------------------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-2">Switch 8 Port</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="switchportRadio" value="ปกติ" />ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="switchportRadio" value="ชำรุด/ใช้งานไม่ได้" />ชำรุด/ใช้งานไม่ได้
                        </label>
                    </div>
                </div>


                <%------ QuestionId = 49, --------------------------------------------------------------------------------------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-2">Switch 48 Port</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="switch48portRadio" value="ปกติ" />ปกติ
                        </label>
                    </div>

                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="switch48portRadio" value="ชำรุด/ใช้งานไม่ได้" />ชำรุด/ใช้งานไม่ได้
                        </label>
                    </div>
                </div>


                <%------ QuestionId = 50, --------------------------------------------------------------------------------------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-2">Outdoor AP ตัวที่ 1</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="outdoorapRadio" value="ปกติ" />ปกติ
                        </label>
                    </div>

                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="outdoorapRadio" value="ชำรุด/ใช้งานไม่ได้" />ชำรุด/ใช้งานไม่ได้
                        </label>
                    </div>
                </div>


                <%------ QuestionId = 51, -------------------------------------------------------------------------------------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-2">Outdoor AP ตัวที่ 2</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="outdoorap2Radio" value="ปกติ" />ปกติ
                        </label>
                    </div>

                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="outdoorap2Radio" value="ชำรุด/ใช้งานไม่ได้" />ชำรุด/ใช้งานไม่ได้
                        </label>
                    </div>
                </div>


                <%------ QuestionId = 52, --------------------------------------------------------------------------------------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-2">Indoor AP ตัวที่ 1</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="indoorapRadio" value="ปกติ" />ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="indoorapRadio" value="ชำรุด/ใช้งานไม่ได้" />ชำรุด/ใช้งานไม่ได้
                        </label>
                    </div>
                </div>


                <%------ QuestionId = 53, -----------------------------------------------------------------------------------------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-2">Indoor AP ตัวที่ 2</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="indoorap2Radio" value="ปกติ" />ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="indoorap2Radio" value="ชำรุด/ใช้งานไม่ได้" />ชำรุด/ใช้งานไม่ได้
                        </label>
                    </div>
                </div>

                <%------ QuestionId = 54, ------------------------------------------------------------------------------------------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-2">การ Wiring สายไฟ</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="wiringelecRadio" value="เรียบร้อย" />เรียบร้อย
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="wiringelecRadio" value="ไม่เรียบร้อย" />ไม่เรียบร้อย
                        </label>
                    </div>
                </div>

                <%------ QuestionId = 55, ------------------------------------------------------------------------------------------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-2">การ Wiring Patch cord และ สาย LAN</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="wiringpatchRadio" value="เรียบร้อย" />เรียบร้อย
                        </label>
                    </div>

                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="wiringpatchRadio" value="ไม่เรียบร้อย" />ไม่เรียบร้อย
                        </label>
                    </div>
                </div>
                <%--////////////// -------------END  SECTION ID 7 -----------------  //////////////////--%>



                <%--////////////// -------------START  SECTION ID 8 -----------------  //////////////////--%>
                <div class="row mt-3">
                    <div class="col-md-12 bg-success text-white text-center Myfont">
                        <h3>5.ระบบ Ground</h3>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <%---------------------- QuestionId = 57, ---------------------------%>
                    <label class="control-label col-sm-4">ความแข็งแรงจุดต่อ Ground Bar</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="groundbarRadio" value="ปกติ" />ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="groundbarRadio" value="ชำรุด" />ชำรุด
                        </label>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <%---------------------- QuestionId = 58, ---------------------------%>
                    <label class="control-label col-sm-4">ความแข็งแรงของน็อตขันหางปลาอุปกรณ์</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="notfishRadio" value="ปกติ" />ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="notfishRadio" value="ชำรุด" />ชำรุด
                        </label>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <%---------------------- QuestionId = 59, ---------------------------%>
                    <label class="control-label col-sm-4">สายกราวด์เรียบร้อย ปลอดภัย สมบูรณ์</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="safegroundRadio" value="ปกติ" />ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="safegroundRadio" value="ชำรุด" />ชำรุด
                        </label>
                    </div>
                </div>



                <%---------------------- QuestionId = 60, ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">สถานะไฟฟ้ารั่วลง Ground</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="brokenElecRadio" value="ไม่พบไฟฟ้ารั่ว" />ไม่พบไฟฟ้ารั่ว
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="brokenElecRadio" value="พบไฟฟ้ารั่ว" />พบไฟฟ้ารั่ว
                        </label>
                    </div>
                </div>
                <%--////////////// -------------END  SECTION ID 8 -----------------  //////////////////--%>





                <%--////////////// -------------START  SECTION ID 9 -----------------  //////////////////--%>
                <div class="row mt-3">
                    <div class="col-md-12 bg-success text-white text-center Myfont">
                        <h3>6.ระบบความปลอดภัยและเตือนภัย</h3>
                    </div>
                </div>
                <%---------------------- QuestionId = 61 ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">Fire Alarm และ Smoke Detector</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="firesmokedDectorRadio" value="ปกติ" />ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="firesmokedDectorRadio" value="ชำรุด/ใช้งานไม่ได้" />ชำรุด/ใช้งานไม่ได้
                        </label>
                    </div>
                </div>


                <div class="form-row mt-3">
                    <%---------------------- QuestionId = 62 ---------------------------%>
                    <label class="control-label col-sm-4">Fire Alarm Manual Switch</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="firealarmManualswitchRadio" value="ปกติ" />ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="firealarmManualswitchRadio" value="ชำรุด/ใช้งานไม่ได้" />ชำรุด/ใช้งานไม่ได้
                        </label>
                    </div>
                </div>



                <div class="form-row mt-3">
                    <%---------------------- QuestionId = 63 ---------------------------%>
                    <label class="control-label col-sm-2">Battery Fire Alarm ก้อนที่ 1</label>
                    <div class="col-sm-8">
                        <input type="text" class="form-control" id="battFirealarm1Textbox" runat="server" required="required" />
                    </div>
                    <label class="control-label col-sm-2">V.</label>
                </div>


                <%---------------------- QuestionId = 64 ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-2">Battery Fire Alarm ก้อนที่ 2</label>
                    <div class="col-sm-8">
                        <%--                        <input type="text" class="form-control"  runat="server"  required="required" id="battFirealarm2Textbox" />--%>
                        <input type="text" class="form-control" id="battFirealarm3Textbox" runat="server" required="required" />
                    </div>
                    <label class="control-label col-sm-2">V.</label>
                </div>

                <%---------------------- QuestionId = 65 ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">ไฟแสงสว่างฉุกเฉิน</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="emerLightRadio" value="ปกติ" />ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="emerLightRadio" value="ชำรุด/ใช้งานไม่ได้" />ชำรุด/ใช้งานไม่ได้
                        </label>
                    </div>
                </div>


                <%---------------------- QuestionId = 66 ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">ระบบ Monitor กล้องวงจรปิด</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="monitorCameraRadio" value="ปกติ" />ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="monitorCameraRadio" value="ไม่สามารถ Monitor ได้" />ไม่สามารถ Monitor ได้
                        </label>
                    </div>
                </div>



                <%---------------------- QuestionId = 67 ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">กล้องวงจรปิดห้อง Computer</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="cameraComputerRadio" value="ปกติ" />ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="cameraComputerRadio" value="ชำรุด" />ชำรุด
                        </label>
                    </div>
                </div>


                <%---------------------- QuestionId = 68 ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">กล้องวงจรปิดภายนอกอาคาร 1</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="cameraOutRadio" value="ปกติ" />ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="cameraOutRadio" value="ชำรุด" />ชำรุด
                        </label>
                    </div>
                </div>





                <%---------------------- QuestionId = 69 ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">กล้องวงจรปิดภายนอกอาคาร 2</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="cameraOut2Radio" value="ปกติ" />ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="cameraOut2Radio" value="ชำรุด" />ชำรุด
                        </label>
                    </div>
                </div>

                <%--////////////// -------------END  SECTION ID 9 -----------------  //////////////////--%>





                <%--////////////// -------------START  SECTION ID 10 -----------------  //////////////////--%>
                <div class="row mt-3">
                    <div class="col-md-12 bg-primary text-white text-center Myfont">
                        <h3>7.ระบบสารสนเทศ</h3>
                    </div>
                </div>

                <%---------------------- QuestionId = 70 ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">จอทีวีห้องประชุม</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="televisRadio" value="ปกติ" />ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="televisRadio" value="ชำรุด/ใช้งานไม่ได้" />ชำรุด/ใช้งานไม่ได้
                        </label>
                    </div>
                </div>


                <%---------------------- QuestionId = 71 ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">คอมพิวเตอร์เจ้าหน้าที่ศูนย์</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="computerAgentRadio" value="ปกติ" />ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="computerAgentRadio" value="ชำรุด/ใช้งานไม่ได้" />ชำรุด/ใช้งานไม่ได้
                        </label>
                    </div>
                </div>






                <%---------------------- QuestionId = 72 ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">Printer</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="printerRadio" value="ปกติ" />ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="printerRadio" value="ชำรุด/ใช้งานไม่ได้" />ชำรุด/ใช้งานไม่ได้
                        </label>
                    </div>
                </div>



                <%---------------------- QuestionId = 73 ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">คอมพิวเตอร์ตัวที่ 1</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="Com1Radio" value="ปกติ" />ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="Com1Radio" value="ชำรุด/ใช้งานไม่ได้" />ชำรุด/ใช้งานไม่ได้
                        </label>
                    </div>
                </div>


                <%---------------------- QuestionId = 74 ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">คอมพิวเตอร์ตัวที่ 2</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="com2Radio" value="ปกติ" />ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="com2Radio" value="ชำรุด/ใช้งานไม่ได้" />ชำรุด/ใช้งานไม่ได้
                        </label>
                    </div>
                </div>



                <%---------------------- QuestionId = 75 ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">คอมพิวเตอร์ตัวที่ 3</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="com3Radio" value="ปกติ" />ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="com3Radio" value="ชำรุด/ใช้งานไม่ได้" />ชำรุด/ใช้งานไม่ได้
                        </label>
                    </div>
                </div>




                <%---------------------- QuestionId = 76 ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">คอมพิวเตอร์ตัวที่ 4</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="com4Radio" value="ปกติ" />ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="com4Radio" value="ชำรุด/ใช้งานไม่ได้" />ชำรุด/ใช้งานไม่ได้
                        </label>
                    </div>
                </div>



                <%---------------------- QuestionId = 77 ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">คอมพิวเตอร์ตัวที่ 5</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="com5Radio" value="ปกติ" />ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="com5Radio" value="ชำรุด/ใช้งานไม่ได้" />ชำรุด/ใช้งานไม่ได้
                        </label>
                    </div>
                </div>




                <%---------------------- QuestionId = 78 ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">คอมพิวเตอร์ตัวที่ 6</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="com6Radio" value="ปกติ" />ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="com6Radio" value="ชำรุด/ใช้งานไม่ได้" />ชำรุด/ใช้งานไม่ได้
                        </label>
                    </div>
                </div>




                <%---------------------- QuestionId = 79 ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">คอมพิวเตอร์ตัวที่ 7</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="com7Radio" value="ปกติ" />ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="com7Radio" value="ชำรุด/ใช้งานไม่ได้" />ชำรุด/ใช้งานไม่ได้
                        </label>
                    </div>
                </div>





                <%---------------------- QuestionId = 80 ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">คอมพิวเตอร์ตัวที่ 8</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="com8Radio" value="ปกติ" />ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="com8Radio" value="ชำรุด/ใช้งานไม่ได้" />ชำรุด/ใช้งานไม่ได้
                        </label>
                    </div>
                </div>



                <%---------------------- QuestionId = 81 ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">คอมพิวเตอร์ตัวที่ 9</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="" value="" />ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="" value="" />ชำรุด/ใช้งานไม่ได้
                        </label>
                    </div>
                </div>



                <%---------------------- QuestionId = 82 ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">คอมพิวเตอร์ตัวที่ 10</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="com10Radio" value="ปกติ" />ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="com10Radio" value="ชำรุด/ใช้งานไม่ได้" />ชำรุด/ใช้งานไม่ได้
                        </label>
                    </div>
                </div>
                <%--////////////// -------------END  SECTION ID 10 -----------------  //////////////////--%>












                <%--////////////// -------------START  SECTION ID 11 -----------------  //////////////////--%>
                <div class="row mt-3">
                    <div class="col-md-12 bg-primary text-white text-center Myfont">
                        <h3>8.ระบบเครื่องปรับอากาศและระบายอากาศ</h3>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <%---------------------- QuestionId = 83 ---------------------------%>
                    <label class="control-label col-sm-4">เครื่องปรับอากาศ 1</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="airRadio" value="ปกติ" />ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="airRadio" value="ชำรุด/ใช้งานไม่ได้" />ชำรุด/ใช้งานไม่ได้
                        </label>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <%---------------------- QuestionId = 84 ---------------------------%>
                    <label class="control-label col-sm-4">เครื่องปรับอากาศ 2</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="air2Radio" value="ปกติ" />ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="air2Radio" value="ชำรุด/ใช้งานไม่ได้" />ชำรุด/ใช้งานไม่ได้
                        </label>
                    </div>
                </div>
                <%--////////////// -------------END  SECTION ID 11 -----------------  //////////////////--%>







                <%--////////////// -------------START  SECTION ID 12 -----------------  //////////////////--%>
                <div class="row mt-3">
                    <div class="col-md-12 bg-primary text-white text-center Myfont">
                        <h3>9.อาคาร</h3>
                    </div>
                </div>

                <%---------------------- QuestionId = 85 ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-2">ความสะอาดภายในห้อง</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="cleaninroomRadio" value="สะอาด">สะอาด
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="cleaninroomRadio" value="ไม่สะอาด/ไม่เรียบร้อย">ไม่สะอาด/ไม่เรียบร้อย
                        </label>
                    </div>
                </div>

                <%---------------------- QuestionId = 86 ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-2">ความสะอาดรอบห้องภายนอก</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="cleanoutroomRadio" value="สะอาด" />สะอาด
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="cleanoutroomRadio" value="ไม่สะอาด/ไม่เรียบร้อย" />ไม่สะอาด/ไม่เรียบร้อย
                        </label>
                    </div>
                </div>


                <%---------------------- QuestionId = 87 ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-2">ประตูห้อง</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="doorRadio" value="ปกติ" />ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="doorRadio" value="ชำรุด" />ชำรุด
                        </label>
                    </div>
                </div>


                <%--////////////// -------------EnD  SECTION ID 12 -----------------  //////////////////--%>











                <%--////////////// -------------START  SECTION ID 13 -----------------  //////////////////--%>



                <div class="row mt-3">
                    <div class="col-md-12 bg-primary text-white text-center Myfont">
                        <h3>10.อุปกรณ์ระบบ VSAT (เฉพาะศูนย์ที่เป็น VSAT)</h3>
                    </div>
                </div>

                <%---------------------- QuestionId = 88 ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">อุปกรณ์ LNB/BUC</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="toolslnbRadio" value="ปกติ" />ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="toolslnbRadio" value="ชำรุด/ใช้งานไม่ได้" />ชำรุด/ใช้งานไม่ได้
                        </label>
                    </div>
                </div>


                <%---------------------- QuestionId = 89 ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">การเก็บสาย RG และการพันหัว</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="wiringrgRadio" value="ปกติ" />ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="wiringrgRadio" value="ไม่เรียบร้อย/ไม่แน่น" />ไม่เรียบร้อย/ไม่แน่น
                        </label>
                    </div>
                </div>



                <%---------------------- QuestionId = 90  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">ฐานและระดับของเสาจาน</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="baseOnRadio" value="ปกติ" />ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="baseOnRadio" value="ไม่ได้ระดับ/เอียง" />ไม่ได้ระดับ/เอียง
                        </label>
                    </div>
                </div>



                <%---------------------- QuestionId = 91  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">แนว Line Of Sight</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="lineOfsightRadio" value="ปกติ" />ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="lineOfsightRadio" value="โดนบัง" />โดนบัง
                        </label>
                    </div>
                </div>




                <%---------------------- QuestionId = 92  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">ความสะอาดของหน้าจาน</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="cleaningDishRadio" value="ปกติ" />ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="cleaningDishRadio" value="สกปรก" />สกปรก
                        </label>
                    </div>
                </div>




                <%---------------------- QuestionId = 93  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">LNB Band Switch</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="lnbbandswitchRadio" value="HIGHBAND" />HIGH BAND
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="lnbbandswitchRadio" value="LOWBAND" />LOW BAND
                        </label>
                    </div>
                </div>
                <%--////////////// -------------END  SECTION ID 13 -----------------  //////////////////--%>












                <%--////////////// --------------------- START  SECTION ID 14 ---------------------------  //////////////////--%>
                <div class="row mt-3">
                    <div class="col-md-12 bg-primary text-white text-center Myfont">
                        <h3>11.อุปกรณ์ระบบ Solar Cell (เฉพาะศูนย์ที่ใช้ Solar Cell)</h3>
                    </div>
                </div>


                <%---------------------- QuestionId = 94  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">ระบบ Solar Cell</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="solarcellSystemRadio" value="ปกติ" />ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="solarcellSystemRadio" value="ชำรุด/ใช้งานไม่ได้" />ชำรุด/ใช้งานไม่ได้
                        </label>
                    </div>
                </div>


                <%---------------------- QuestionId = 95  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">แผง PV Panel</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="pvPanelRadio" value="ปกติ" />ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="pvPanelRadio" value="ชำรุด/ใช้งานไม่ได้" />ชำรุด/ใช้งานไม่ได้
                        </label>
                    </div>
                </div>


                <%---------------------- QuestionId = 96  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">อุปกรณ์ Charger</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="toolsCharger" value="ปกติ" />ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="toolsCharger" value="ชำรุด/ใช้งานไม่ได้" />ชำรุด/ใช้งานไม่ได้
                        </label>
                    </div>
                </div>



                <%---------------------- QuestionId = 97  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">ความสะอาดแผง PV</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="cleanIngpvRadio" value="ปกติ" />ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="cleanIngpvRadio" value="สกปรก" />สกปรก
                        </label>
                    </div>
                </div>



                <%---------------------- QuestionId = 98  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">การติดตั้งแผง PV</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="installPvRadio" value="ที่โล่งรับแดดปกติ" />ที่โล่งรับแดดปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="installPvRadio" value="มีอาคาร/ต้นไม้บัง" />มีอาคาร/ต้นไม้บัง
                        </label>
                    </div>
                </div>



                <%---------------------- QuestionId = 99  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-2">แรงดันไฟจาก Inverter</label>
                    <div class="col-sm-8">
                        <input type="text" class="form-control" id="voltageInverterTextbox" runat="server" required="required" />
                    </div>
                    <label class="control-label col-sm-2">V.</label>
                </div>



                <%---------------------- QuestionId = 100  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-2">กระแส Load</label>
                    <div class="col-sm-8">
                        <input type="text" class="form-control" id="voltageLoadTextbox" runat="server" required="required" />
                    </div>
                    <label class="control-label col-sm-2">A.</label>
                </div>
                <%--////////////// ---------------------------END  SECTION ID 14 -----------------------------  //////////////////--%>












                <%--////////////// --------------------- START  SECTION ID 15 ---------------------------  //////////////////--%>
                <div class="row mt-3">
                    <div class="col-md-12 bg-primary text-white text-center Myfont">
                        <h3>12. คุณภาพของสัญญาณ</h3>
                    </div>
                </div>

                <%---------------------- QuestionId = 101  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-2">Download (for ONU/VSAT)</label>
                    <div class="col-sm-8">
                        <input type="text" class="form-control" id="dowloadforOnuTextbox" runat="server" required="required" />
                    </div>
                    <label class="control-label col-sm-2">Mb/s</label>
                </div>

                <%---------------------- QuestionId = 102  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-2">Upload (for ONU/VSAT)</label>
                    <div class="col-sm-8">
                        <input type="text" class="form-control" id="uploadforOnuTextbox" runat="server" required="required" />
                    </div>
                    <label class="control-label col-sm-2">Mb/s</label>
                </div>



                <%---------------------- QuestionId = 103  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-2">Ping Test (for ONU/VSAT)</label>
                    <div class="col-sm-8">
                        <input type="text" class="form-control" id="pingTestTextbox" runat="server" required="required" />
                    </div>
                    <label class="control-label col-sm-2">ms</label>
                </div>



                <%---------------------- QuestionId = 104  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-2">Download (for WIFI)</label>
                    <div class="col-sm-8">
                        <input type="text" class="form-control" id="dowloadForwifiTextbox" runat="server" required="required" />
                    </div>
                    <label class="control-label col-sm-2">Mb/s</label>
                </div>

                <%---------------------- QuestionId = 105  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-2">Upload (for WIFI)</label>
                    <div class="col-sm-8">
                        <input type="text" class="form-control" id="uploadForwifiTextbox" runat="server" required="required" />
                    </div>
                    <label class="control-label col-sm-2">Mb/s</label>
                </div>


                <%---------------------- QuestionId = 106  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-2">Ping Test (for WIFI)</label>
                    <div class="col-sm-8">
                        <input type="text" class="form-control" id="pingtestForwifiTextbox" runat="server" required="required" />
                    </div>
                    <label class="control-label col-sm-2">ms</label>
                </div>


                <%---------------------- QuestionId = 107  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-2">Download (for LAN)</label>
                    <div class="col-sm-8">
                        <input type="text" class="form-control" id="dowlaodForlanTextbox" runat="server" required="required" />
                    </div>
                    <label class="control-label col-sm-2">Mb/s</label>
                </div>



                <%---------------------- QuestionId = 108  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-2">Upload (for LAN)</label>
                    <div class="col-sm-8">
                        <input type="text" class="form-control" id="uploadForlandTextbox" runat="server" required="required" />
                    </div>
                    <label class="control-label col-sm-2">Mb/s</label>
                </div>



                <%---------------------- QuestionId = 109  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-2">Ping Test  (for LAN)</label>
                    <div class="col-sm-8">
                        <input type="text" class="form-control" id="pingtestForlanTextbox" runat="server" required="required" />
                    </div>
                    <label class="control-label col-sm-2">ms</label>
                </div>
                <%--////////////// --------------------- END  SECTION ID 15 ---------------------------  //////////////////--%>








                <%--////////////// --------------------- START  SECTION ID 16 ---------------------------  //////////////////--%>
                <div class="row mt-3">
                    <div class="col-md-12 bg-primary text-white text-center Myfont">
                        <h3>13.ปัญหาที่พบและการแก้ไข</h3>
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
                                <%---------------------- QuestionId = 110  ---------------------------%>
                                <input type="text" class="form-control" id="problemTextbox1" runat="server" />
                            </div>
                            <div class="divTableCell">
                                <%---------------------- QuestionId = 111  ---------------------------%>
                                <input type="text" class="form-control" id="howtoSolveTextbox1" runat="server" />
                            </div>
                        </div>

                        <div class="divTableRow">
                            <div class="divTableCell">&nbsp;2</div>
                            <div class="divTableCell">
                                <%---------------------- QuestionId = 112  ---------------------------%>
                                <input type="text" class="form-control" id="problemTextbox2" runat="server" />
                            </div>
                            <div class="divTableCell">
                                <%---------------------- QuestionId = 113  ---------------------------%>
                                <input type="text" class="form-control" id="howtoSolveTextbox2" runat="server" />
                            </div>
                        </div>

                        <div class="divTableRow">
                            <div class="divTableCell">&nbsp;3</div>
                            <div class="divTableCell">
                                <%---------------------- QuestionId = 114  ---------------------------%>
                                <input type="text" class="form-control" id="problemTextbox3" runat="server" />
                            </div>
                            <div class="divTableCell">
                                <%---------------------- QuestionId = 115  ---------------------------%>
                                <input type="text" class="form-control" id="howtoSolveTextbox3" runat="server" />
                            </div>
                        </div>

                        <div class="divTableRow">
                            <div class="divTableCell">&nbsp;4</div>
                            <div class="divTableCell">
                                <%---------------------- QuestionId = 116  ---------------------------%>
                                <input type="text" class="form-control" id="problemTextbox4" runat="server" />
                            </div>
                            <div class="divTableCell">
                                <%---------------------- QuestionId = 117  ---------------------------%>
                                <input type="text" class="form-control" id="howtoSolveTextbox4" runat="server" />
                            </div>
                        </div>

                        <div class="divTableRow">
                            <div class="divTableCell">&nbsp;5</div>
                            <div class="divTableCell">
                                <%---------------------- QuestionId = 118  ---------------------------%>
                                <input type="text" class="form-control" id="problemTextbox5" runat="server" />
                            </div>
                            <div class="divTableCell">
                                <%---------------------- QuestionId = 119  ---------------------------%>
                                <input type="text" class="form-control " id="howtoSolveTextbox5" runat="server" />
                            </div>
                        </div>
                        <div class="divTableRow">
                            <div class="divTableCell">&nbsp;6</div>
                            <div class="divTableCell">
                                <%---------------------- QuestionId = 120  ---------------------------%>
                                <input type="text" class="form-control" id="problemTextbox6" runat="server" />
                            </div>
                            <div class="divTableCell">
                                <%---------------------- QuestionId = 121  ---------------------------%>
                                <input type="text" class="form-control" id="howtoSolveTextbox6" runat="server" />
                            </div>
                        </div>
                        <div class="divTableRow">
                            <div class="divTableCell">&nbsp;7</div>
                            <div class="divTableCell">
                                <%---------------------- QuestionId = 122  ---------------------------%>
                                <input type="text" class="form-control" id="problemTextbox7" runat="server" />
                            </div>
                            <div class="divTableCell">
                                <%---------------------- QuestionId = 123  ---------------------------%>
                                <input type="text" class="form-control" id="howtoSolveTextbox7" runat="server" />
                            </div>
                        </div>
                        <div class="divTableRow">
                            <div class="divTableCell">&nbsp;8</div>
                            <div class="divTableCell">
                                <%---------------------- QuestionId = 124  ---------------------------%>
                                <input type="text" class="form-control" id="problemTextbox8" runat="server" />
                            </div>
                            <div class="divTableCell">
                                <%---------------------- QuestionId = 125  ---------------------------%>
                                <input type="text" class="form-control" id="howtoSolveTextbox8" runat="server" />
                            </div>
                        </div>
                        <div class="divTableRow">
                            <div class="divTableCell">&nbsp;9</div>
                            <div class="divTableCell">
                                <%---------------------- QuestionId = 126  ---------------------------%>
                                <input type="text" class="form-control" id="problemTextbox9" runat="server" />
                            </div>
                            <div class="divTableCell">
                                <%---------------------- QuestionId = 127  ---------------------------%>
                                <input type="text" class="form-control" id="howtoSolveTextbox9" runat="server" />
                            </div>
                        </div>
                        <div class="divTableRow">
                            <div class="divTableCell">&nbsp;10</div>
                            <div class="divTableCell">
                                <%---------------------- QuestionId = 128  ---------------------------%>
                                <input type="text" class="form-control" id="problemTextbox10" runat="server" />
                            </div>
                            <div class="divTableCell">
                                <%---------------------- QuestionId = 129  ---------------------------%>
                                <input type="text" class="form-control" id="howtoSolveTextbox10" runat="server" />
                            </div>
                        </div>
                        <div class="divTableRow">
                            <div class="divTableCell">&nbsp;11</div>
                            <div class="divTableCell">
                                <%---------------------- QuestionId = 130  ---------------------------%>
                                <input type="text" class="form-control" id="problemTextbox11" runat="server" />
                            </div>
                            <div class="divTableCell">
                                <%---------------------- QuestionId = 131  ---------------------------%>
                                <input type="text" class="form-control" id="howtoSolveTextbox11" runat="server" />
                            </div>
                        </div>
                        <div class="divTableRow">
                            <div class="divTableCell">&nbsp;12</div>
                            <div class="divTableCell">
                                <%---------------------- QuestionId = 132  ---------------------------%>
                                <input type="text" class="form-control" id="problemTextbox12" runat="server" />
                            </div>
                            <div class="divTableCell">
                                <%---------------------- QuestionId = 133  ---------------------------%>
                                <input type="text" class="form-control" id="howtoSolveTextbox12" runat="server" />
                            </div>
                        </div>
                        <div class="divTableRow">
                            <div class="divTableCell">&nbsp;13</div>
                            <div class="divTableCell">
                                <%---------------------- QuestionId = 134  ---------------------------%>
                                <input type="text" class="form-control" id="problemTextbox13" runat="server" />
                            </div>
                            <div class="divTableCell">
                                <%---------------------- QuestionId = 135  ---------------------------%>
                                <input type="text" class="form-control" id="howtoSolveTextbox13" runat="server" />
                            </div>
                        </div>
                        <div class="divTableRow">
                            <div class="divTableCell">&nbsp;14</div>
                            <div class="divTableCell">
                                <%---------------------- QuestionId = 136  ---------------------------%>
                                <input type="text" class="form-control" id="problemTextbox14" runat="server" />
                            </div>
                            <div class="divTableCell">
                                <%---------------------- QuestionId = 137  ---------------------------%>
                                <input type="text" class="form-control" id="howtoSolveTextbox14" runat="server" />
                            </div>
                        </div>
                        <div class="divTableRow">
                            <div class="divTableCell">&nbsp;15</div>
                            <div class="divTableCell">
                                <%---------------------- QuestionId = 138  ---------------------------%>
                                <input type="text" class="form-control" id="problemTextbox15" runat="server" />
                            </div>
                            <div class="divTableCell">
                                <%---------------------- QuestionId = 139  ---------------------------%>
                                <input type="text" class="form-control" id="howtoSolveTextbox15" runat="server" />
                            </div>
                        </div>
                    </div>
                </div>
                <%--////////////// --------------------- END  SECTION ID 16 ---------------------------  //////////////////--%>

                <br />


                <%--////////////// --------------------- START  SECTION ID 17 ---------------------------  //////////////////--%>
                <div class="row mt-3">
                    <div class="col-md-12 bg-primary text-white text-center Myfont">
                        <h3>14.ข้อมูลรายการทรัพย์สิน</h3>
                    </div>
                </div>

                <div class="table-responsive-sm text-center Myfont">
                    <table class="table table-sm table-hover" style="width: 100%;" border="0">
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
                                    <%---------------------- QuestionId = 141  ---------------------------%>
                                    <input type="text" class="form-control form-control-sm" id="toolsListTextbox1" runat="server" /></td>
                                <td>
                                    <%---------------------- QuestionId = 142  ---------------------------%>
                                    <input type="text" class="form-control form-control-sm" id="serialNumberTextbox1" runat="server" /></td>
                                <td>
                                    <%---------------------- QuestionId = 143  ---------------------------%>
                                    <input type="text" class="form-control form-control-sm" id="newSerialNumberTextbox1" runat="server" /></td>
                                <td>
                                    <%---------------------- QuestionId = 144  ---------------------------%>
                                    <input type="text" class="form-control form-control-sm" id="noteTextbox1" runat="server" /></td>
                            </tr>
                            <tr>

                                <td>2</td>
                                <td>
                                    <%---------------------- QuestionId = 145  ---------------------------%>
                                    <input type="text" class="form-control form-control-sm" id="toolsListTextbox2" runat="server" /></td>
                                <td>
                                    <%---------------------- QuestionId = 146  ---------------------------%>
                                    <input type="text" class="form-control form-control-sm" id="serialNumberTextbox2" runat="server" /></td>
                                <td>
                                    <%---------------------- QuestionId = 147  ---------------------------%>
                                    <input type="text" class="form-control form-control-sm" id="newSerialNumberTextbox2" runat="server" /></td>
                                <td>
                                    <%---------------------- QuestionId = 148  ---------------------------%>
                                    <input type="text" class="form-control form-control-sm" id="noteTextbox2" runat="server" /></td>
                            </tr>
                            <tr>
                                <td>3</td>
                                <td>
                                    <%---------------------- QuestionId = 149  ---------------------------%>
                                    <input type="text" class="form-control form-control-sm" id="toolsListTextbox3" runat="server" /></td>
                                <td>
                                    <%---------------------- QuestionId = 150  ---------------------------%>
                                    <input type="text" class="form-control form-control-sm" id="serialNumberTextbox3" runat="server" /></td>
                                <td>
                                    <%---------------------- QuestionId = 151  ---------------------------%>
                                    <input type="text" class="form-control form-control-sm" id="newSerialNumberTextbox3" runat="server" /></td>
                                <td>
                                    <%---------------------- QuestionId = 152  ---------------------------%>
                                    <input type="text" class="form-control form-control-sm" id="noteTextbox3" runat="server" /></td>
                            </tr>
                            <tr>
                                <td>4</td>
                                <td>
                                    <%---------------------- QuestionId = 153  ---------------------------%>
                                    <input type="text" class="form-control form-control-sm" id="toolsListTextbox4" runat="server" /></td>
                                <td>
                                    <%---------------------- QuestionId = 154  ---------------------------%>
                                    <input type="text" class="form-control form-control-sm" id="serialNumberTextbox4" runat="server" /></td>
                                <td>
                                    <%---------------------- QuestionId = 155  ---------------------------%>
                                    <input type="text" class="form-control form-control-sm" id="newSerialNumberTextbox4" runat="server" /></td>
                                <td>
                                    <%---------------------- QuestionId = 156  ---------------------------%>
                                    <input type="text" class="form-control form-control-sm" id="noteTextbox4" runat="server" /></td>
                            </tr>
                            <tr>
                                <td>5</td>
                                <td>
                                    <%---------------------- QuestionId = 157  ---------------------------%>
                                    <input type="text" class="form-control form-control-sm" id="toolsListTextbox5" runat="server" /></td>
                                <td>
                                    <%---------------------- QuestionId = 158  ---------------------------%>
                                    <input type="text" class="form-control form-control-sm" id="serialNumberTextbox5" runat="server" /></td>
                                <td>
                                    <%---------------------- QuestionId = 159  ---------------------------%>
                                    <input type="text" class="form-control form-control-sm" id="newSerialNumberTextbox5" runat="server" /></td>
                                <td>
                                    <%---------------------- QuestionId = 160  ---------------------------%>
                                    <input type="text" class="form-control form-control-sm" id="noteTextbox5" runat="server" /></td>
                            </tr>
                            <tr>
                                <td>6</td>
                                <td>
                                    <%---------------------- QuestionId = 161  ---------------------------%>
                                    <input type="text" class="form-control form-control-sm" id="toolsListTextbox6" runat="server" /></td>
                                <td>
                                    <%---------------------- QuestionId = 162  ---------------------------%>
                                    <input type="text" class="form-control form-control-sm" id="serialNumberTextbox6" runat="server" /></td>
                                <td>
                                    <%---------------------- QuestionId = 163  ---------------------------%>
                                    <input type="text" class="form-control form-control-sm" id="newSerialNumberTextbox6" runat="server" /></td>
                                <td>
                                    <%---------------------- QuestionId = 164  ---------------------------%>
                                    <input type="text" class="form-control form-control-sm" id="noteTextbox6" runat="server" /></td>
                            </tr>
                            <tr>
                                <td>7</td>
                                <td>
                                    <%---------------------- QuestionId = 165  ---------------------------%>
                                    <input type="text" class="form-control form-control-sm" id="toolsListTextbox7" runat="server" /></td>
                                <td>
                                    <%---------------------- QuestionId = 166  ---------------------------%>
                                    <input type="text" class="form-control form-control-sm" id="serialNumberTextbox7" runat="server" /></td>
                                <td>
                                    <%---------------------- QuestionId = 167  ---------------------------%>
                                    <input type="text" class="form-control form-control-sm" id="newSerialNumberTextbox7" runat="server" /></td>
                                <td>
                                    <%---------------------- QuestionId = 168  ---------------------------%>
                                    <input type="text" class="form-control form-control-sm" id="noteTextbox7" runat="server" /></td>
                            </tr>
                            <tr>
                                <td>8</td>
                                <td>
                                    <%---------------------- QuestionId = 169  ---------------------------%>
                                    <input type="text" class="form-control form-control-sm" id="toolsListTextbox8" runat="server" /></td>
                                <td>
                                    <%---------------------- QuestionId = 170  ---------------------------%>
                                    <input type="text" class="form-control form-control-sm" id="serialNumberTextbox8" runat="server" /></td>
                                <td>
                                    <%---------------------- QuestionId = 171  ---------------------------%>
                                    <input type="text" class="form-control form-control-sm" id="newSerialNumberTextbox8" runat="server" /></td>
                                <td>
                                    <%---------------------- QuestionId = 172  ---------------------------%>
                                    <input type="text" class="form-control form-control-sm" id="noteTextbox8" runat="server" /></td>
                            </tr>
                            <tr>
                                <td>9</td>
                                <td>
                                    <%---------------------- QuestionId = 173  ---------------------------%>
                                    <input type="text" class="form-control form-control-sm" id="toolsListTextbox9" runat="server" /></td>
                                <td>
                                    <%---------------------- QuestionId = 174  ---------------------------%>
                                    <input type="text" class="form-control form-control-sm" id="serialNumberTextbox9" runat="server" /></td>
                                <td>
                                    <%---------------------- QuestionId = 175  ---------------------------%>
                                    <input type="text" class="form-control form-control-sm" id="newSerialNumberTextbox9" runat="server" /></td>
                                <td>
                                    <%---------------------- QuestionId = 176  ---------------------------%>
                                    <input type="text" class="form-control form-control-sm" id="noteTextbox9" runat="server" /></td>
                            </tr>
                            <tr>
                                <td>10</td>
                                <td>
                                    <%---------------------- QuestionId = 177  ---------------------------%>
                                    <input type="text" class="form-control form-control-sm" id="toolsListTextbox10" runat="server" /></td>
                                <td>
                                    <%---------------------- QuestionId = 178  ---------------------------%>
                                    <input type="text" class="form-control form-control-sm" id="serialNumberTextbox10" runat="server" /></td>
                                <td>
                                    <%---------------------- QuestionId = 179  ---------------------------%>
                                    <input type="text" class="form-control form-control-sm" id="newSerialNumberTextbox10" runat="server" /></td>
                                <td>
                                    <%---------------------- QuestionId = 180  ---------------------------%>
                                    <input type="text" class="form-control form-control-sm" id="noteTextbox10" runat="server" /></td>
                            </tr>
                            <tr>
                                <td>11</td>
                                <td>
                                    <%---------------------- QuestionId = 181  ---------------------------%>
                                    <input type="text" class="form-control form-control-sm" id="toolsListTextbox11" runat="server" /></td>
                                <td>
                                    <%---------------------- QuestionId = 182  ---------------------------%>
                                    <input type="text" class="form-control form-control-sm" id="serialNumberTextbox11" runat="server" /></td>
                                <td>
                                    <%---------------------- QuestionId = 183  ---------------------------%>
                                    <input type="text" class="form-control form-control-sm" id="newSerialNumberTextbox11" runat="server" /></td>
                                <td>
                                    <%---------------------- QuestionId = 184  ---------------------------%>
                                    <input type="text" class="form-control form-control-sm" id="noteTextbox11" runat="server" /></td>
                            </tr>
                            <tr>
                                <td>12</td>
                                <td>
                                    <%---------------------- QuestionId = 185  ---------------------------%>
                                    <input type="text" class="form-control form-control-sm" id="toolsListTextbox12" runat="server" /></td>
                                <td>
                                    <%---------------------- QuestionId = 186  ---------------------------%>
                                    <input type="text" class="form-control form-control-sm" id="serialNumberTextbox12" runat="server" /></td>
                                <td>
                                    <%---------------------- QuestionId = 187  ---------------------------%>
                                    <input type="text" class="form-control form-control-sm" id="newSerialNumberTextbox12" runat="server" /></td>
                                <td>
                                    <%---------------------- QuestionId = 188  ---------------------------%>
                                    <input type="text" class="form-control form-control-sm" id="noteTextbox12" runat="server" /></td>
                            </tr>
                            <tr>
                                <td>13</td>
                                <td>
                                    <%---------------------- QuestionId = 189  ---------------------------%>
                                    <input type="text" class="form-control form-control-sm" id="toolsListTextbox13" runat="server" /></td>
                                <td>
                                    <%---------------------- QuestionId = 190  ---------------------------%>
                                    <input type="text" class="form-control form-control-sm" id="serialNumberTextbox13" runat="server" /></td>
                                <td>
                                    <%---------------------- QuestionId = 191  ---------------------------%>
                                    <input type="text" class="form-control form-control-sm" id="newSerialNumberTextbox13" runat="server" /></td>
                                <td>
                                    <%---------------------- QuestionId = 192  ---------------------------%>
                                    <input type="text" class="form-control form-control-sm" id="noteTextbox13" runat="server" /></td>
                            </tr>
                            <tr>
                                <td>14</td>
                                <td>
                                    <%---------------------- QuestionId = 193  ---------------------------%>
                                    <input type="text" class="form-control form-control-sm" id="toolsListTextbox14" runat="server" /></td>
                                <td>
                                    <%---------------------- QuestionId = 194  ---------------------------%>
                                    <input type="text" class="form-control form-control-sm" id="serialNumberTextbox14" runat="server" /></td>
                                <td>
                                    <%---------------------- QuestionId = 195  ---------------------------%>
                                    <input type="text" class="form-control form-control-sm" id="newSerialNumberTextbox14" runat="server" /></td>
                                <td>
                                    <%---------------------- QuestionId = 196  ---------------------------%>
                                    <input type="text" class="form-control form-control-sm" id="noteTextbox14" runat="server" /></td>
                            </tr>
                            <tr>
                                <td>15</td>
                                <td>
                                    <%---------------------- QuestionId = 197  ---------------------------%>
                                    <input type="text" class="form-control form-control-sm" id="toolsListTextbox15" runat="server" /></td>
                                <td>
                                    <%---------------------- QuestionId = 198  ---------------------------%>
                                    <input type="text" class="form-control form-control-sm" id="serialNumberTextbox15" runat="server" /></td>
                                <td>
                                    <%---------------------- QuestionId = 199  ---------------------------%>
                                    <input type="text" class="form-control form-control-sm" id="newSerialNumberTextbox15" runat="server" /></td>
                                <td>
                                    <%---------------------- QuestionId = 200  ---------------------------%>
                                    <input type="text" class="form-control form-control-sm" id="noteTextbox15" runat="server" /></td>
                            </tr>
                        </tbody>
                    </table>

                </div>
                <%--////////////// --------------------- END  SECTION ID 17 ---------------------------  //////////////////--%>










                <%--////////////// --------------------- START  SECTION ID 18 ---------------------------  //////////////////--%>
                <div class="row mt-3">
                    <div class="col-md-12 bg-primary text-white text-center Myfont">
                        <h3>15.รายละเอียดผู้ทำ PM</h3>
                    </div>
                </div>

                <%---------------------- QuestionId = 201  ---------------------------%>
                <div class="row mt-3">
                    <div class="col-md-3 text-center">
                        <span>ชื่อทีม</span>
                    </div>
                    <div class="col-md-9">
                        <input type="text" class="form-control" id="nameTeampmTextbox" runat="server" />
                    </div>

                </div>

                <%---------------------- QuestionId = 202  ---------------------------%>
                <div class="row mt-3">
                    <div class="col-md-3 text-center">
                        <span>วันที่ทำ PM</span>
                    </div>
                    <div class="col-md-9">
                        <input type="text" class="form-control" id="dayDopmTextbox" runat="server" />
                    </div>
                </div>
                <%--////////////// --------------------- END  SECTION ID 18 ---------------------------  //////////////////--%>








                <%--////////////// --------------------- START  SECTION ID 19 ---------------------------  //////////////////--%>
                <div class="row mt-3">
                    <div class="col-md-12 bg-primary text-white text-center Myfont">
                        <h3>16.รายละเอียด เจ้าหน้าที่ประจำศูนย์</h3>
                    </div>
                </div>
                <%---------------------- QuestionId = 203  ---------------------------%>
                <div class="row mt-3">
                    <div class="col-md-3 text-center">
                        <span>ชื่อเจ้าหน้าที่ประจำศูนย์</span>
                    </div>
                    <div class="col-md-9">
                        <input type="text" class="form-control" id="nameAgentareaTextbox" runat="server" />
                    </div>
                </div>

                <%---------------------- QuestionId = 204  ---------------------------%>
                <div class="row mt-3">
                    <div class="col-md-3 text-center">
                        <span>เบอร์โทรติดต่อ</span>
                    </div>
                    <div class="col-md-9">
                        <input type="text" class="form-control" id="telephoneAgentTextbox" runat="server" />
                    </div>
                </div>
                <%--////////////// --------------------- END  SECTION ID 19 ---------------------------  //////////////////--%>






                <%--////////////// --------------------- START  SECTION ID 20 ---------------------------  //////////////////--%>
                <div class="row mt-3">
                    <div class="col-md-12 bg-success text-white text-center Myfont">
                        <h3>PICTURE CHECKLIST</h3>
                    </div>
                </div>

                <%---------------------- QuestionId = 205  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูปภาพป้ายชื่อโรงเรียน</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="billBoardSchoolRadio" value="PASS" />PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="billBoardSchoolRadio" value="NOTPASS" />NOT PASS
                        </label>
                    </div>
                </div>

                <%---------------------- QuestionId = 206  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูปภาพด้านหน้าศูนย์ (ถ่ายคู่กับ จนท.ประจำศูนย์)</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="pictureWithagentRadio" value="PASS">PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="pictureWithagentRadio" value="NOTPASS">NOT PASS
                        </label>
                    </div>
                </div>

                <%---------------------- QuestionId = 207  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูปภาพด้านหลังศูนย์</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="pictureBehindHallRadio" value="PASS" />PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="pictureBehindHallRadio" value="NOTPASS" />NOT PASS
                        </label>
                    </div>
                </div>


                <%---------------------- QuestionId = 208  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูปภาพบริเวณห้องโถง</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="picInlobbyRadio" value="PASS" />PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="picInlobbyRadio" value="NOTPASS" />NOT PASS
                        </label>
                    </div>
                </div>


                <%---------------------- QuestionId = 209  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูปภาพบริเวณห้องประชุม</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="picinMeetingroomRadio" value="PASS" />PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="picinMeetingroomRadio" value="NOTPASS" />NOT PASS
                        </label>
                    </div>
                </div>

                <%---------------------- QuestionId = 210  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูปภาพบริเวณห้อง Server</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="picInserverRadio" value="PASS" />PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="picInserverRadio" value="NOTPASS" />NOT PASS
                        </label>
                    </div>
                </div>

                <%---------------------- QuestionId = 211  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูปภาพบริเวณห้องน้ำ</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="picIntoiletRadio" value="PASS">PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="picIntoiletRadio" value="NOTPASS">NOT PASS
                        </label>
                    </div>
                </div>
                <%---------------------- QuestionId = 212  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูปภาพบริเวณห้องปั๊มน้ำ</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="pictureInwaterpumpRadio" value="PASS" />PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="pictureInwaterpumpRadio" value="NOTPASS" />NOT PASS
                        </label>
                    </div>
                </div>


                <%---------------------- QuestionId = 213  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูป PEA Meter</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="picpeaMeterRadio" value="PASS" />PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="picpeaMeterRadio" value="NOTPASS" />NOT PASS
                        </label>
                    </div>
                </div>

                <%---------------------- QuestionId = 214  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูปการวัดแรงดัน AC และกระแส AC </label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="acPicRadio" value="PASS" />PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="acPicRadio" value="NOTPASS" />NOT PASS
                        </label>
                    </div>
                </div>

                <%---------------------- QuestionId = 215  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูปการวัดค่า Ground และ Bar Ground  </label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="recGroundBargroundRadio" value="PASS" />PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="recGroundBargroundRadio" value="NOTPASS" />NOT PASS
                        </label>
                    </div>
                </div>


                <%---------------------- QuestionId = 216  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูปการตรวจสอบสถานะไฟฟ้ารั่วลง Ground (Lamp Test) </label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="lightleakRadio" value="PASS" />PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="lightleakRadio" value="NOTPASS" />NOT PASS
                        </label>
                    </div>
                </div>

                <%---------------------- QuestionId = 217  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูป MDB  </label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="mdbPicRadio" value="PASS" />PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="mdbPicRadio" value="NOTPASS" />NOT PASS
                        </label>
                    </div>
                </div>

                <%---------------------- QuestionId = 218  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูป Fire Alarm Control </label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="picFilealarmRadio" value="PASS" />PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="picFilealarmRadio" value="NOTPASS" />NOT PASS
                        </label>
                    </div>
                </div>

                <%---------------------- QuestionId = 219  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูปภาพรวมอุปกรณ์ทั้งหมดภายในตู้ Rack</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="alltoolsInrackRadio" value="PASS" />PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="alltoolsInrackRadio" value="NOTPASS" />NOT PASS
                        </label>
                    </div>
                </div>

                <%---------------------- QuestionId = 220  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูปหน้าจอ UPS แสดงค่าต่างๆ และ Serial NO.</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="upsAndserialRadio" value="PASS">PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="upsAndserialRadio" value="NOTPASS">NOT PASS
                        </label>
                    </div>
                </div>


                <%---------------------- QuestionId = 221  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูป ONU/Modem พร้อม Serial NO. และ MAC</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="picOnuRadio" value="PASS">PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="picOnuRadio" value="NOTPASS">NOT PASS
                        </label>
                    </div>
                </div>

                <%---------------------- QuestionId = 222  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูป Power Supply พร้อม Serial NO.</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="picPsuRadio" value="PASS">PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="picPsuRadio" value="NOTPASS">NOT PASS
                        </label>
                    </div>
                </div>

                <%---------------------- QuestionId = 223  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูป Switch 8 Port พร้อม Serial NO. และ MAC  </label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" name="picSwitchRadio" value="PASS" />PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="picSwitchRadio" value="NOTPASS" />NOT PASS
                        </label>
                    </div>
                </div>

                <%---------------------- QuestionId = 224  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4" for="">รูป Switch 48 Port พร้อม Serial NO. และ MAC </label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="picSwitch48Radio" value="PASS" />PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" name="picSwitch48Radio" value="NOTPASS" />NOT PASS
                        </label>
                    </div>
                </div>

                <%---------------------- QuestionId = 225  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูป Outdoor AP ทั้ง 2 จุด พร้อม Serial NO. และ MAC </label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="picOutdoorRadio" value="PASS">PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="picOutdoorRadio" value="NOTPASS">NOT PASS
                        </label>
                    </div>
                </div>

                <%---------------------- QuestionId = 226  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูป Indoor AP ทั้ง 2 จุด พร้อม Serial NO. และ MAC </label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="picIndoortwowayRadio" value="PASS">PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="picIndoortwowayRadio" value="NOTPASS">NOT PASS
                        </label>
                    </div>
                </div>

                <%---------------------- QuestionId = 227  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูปการ Test Speed จาก App Nperf โดยใช้ WIFI </label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="picspeedTestRadio" value="PASS">PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="picspeedTestRadio" value="NOTPASS">NOT PASS
                        </label>
                    </div>
                </div>


                <%---------------------- QuestionId = 228  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูปการ Test Speed จาก App Nperf โดยใช้ LAN </label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="picspeedTestwithLanRadio" value="PASS">PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="picspeedTestwithLanRadio" value="NOTPASS">NOT PASS
                        </label>
                    </div>
                </div>


                <%---------------------- QuestionId = 229  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูป ก่อน-หลัง การทำความสะอาดรางระบายน้ำ </label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="picbeforeAftercanelRadio" value="PASS" />PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="picbeforeAftercanelRadio" value="NOTPASS" />NOT PASS
                        </label>
                    </div>
                </div>

                <%---------------------- QuestionId = 230  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูปหน้าจอ Monitor กล้องวงจรปิดผ่านจอทีวีในห้องประชุม </label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="picMonitorRadio" value="PASS" />PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="picMonitorRadio" value="NOTPASS" />NOT PASS
                        </label>
                    </div>
                </div>



                <%---------------------- QuestionId = 231  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูปภาพก่อน-หลัง การทำความสะอาดแอร์ห้องโถง </label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="beforeArterairCleanRadio" value="PASS">PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="beforeArterairCleanRadio" value="NOTPASS">NOT PASS
                        </label>
                    </div>
                </div>

                <%---------------------- QuestionId = 232  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูปภาพก่อน-หลัง การทำความสะอาดแอร์ห้องประชุม </label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="picairInmeetingRadio" value="PASS" />PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="picairInmeetingRadio" value="NOTPASS" />NOT PASS
                        </label>
                    </div>
                </div>

                <%---------------------- QuestionId = 233  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูปภาพก่อน-หลัง การทำความสะอาดแอร์ห้อง Server </label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="picAirserverRadio" value="PASS" />PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="picAirserverRadio" value="NOTPASS" />NOT PASS
                        </label>
                    </div>
                </div>
                <%--////////////// --------------------- END  SECTION ID 20 ---------------------------  //////////////////--%>







                <%--////////////// --------------------- START  SECTION ID 21 ---------------------------  //////////////////--%>
                <div class="row mt-3">
                    <div class="col-md-12 bg-primary text-white text-center Myfont">
                        <h3>VSAT PICTURE CHECKLIST</h3>
                    </div>
                </div>

                <%---------------------- QuestionId = 234  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูปจุดติดตั้งจานดาวเทียม</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="inStallBaseRadio" value="PASS" />PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="inStallBaseRadio" value="NOTPASS" />NOT PASS
                        </label>
                    </div>
                </div>

                <%---------------------- QuestionId = 235  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูปความสะอาดบริเวณจานดาวเทียม</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="picCleansatelliteRadio" value="PASS" />PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="picCleansatelliteRadio" value="NOTPASS" />NOT PASS
                        </label>
                    </div>
                </div>



                <%---------------------- QuestionId = 236  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูป LNB พร้อม Part NO.</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="picLnbRadio" value="PASS">PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="picLnbRadio" value="NOTPASS">NOT PASS
                        </label>
                    </div>
                </div>

                <%---------------------- QuestionId = 237  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูป BUC พร้อม Part NO.</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="picBUCRadio" value="PASS" />PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="picBUCRadio" value="NOTPASS" />NOT PASS
                        </label>
                    </div>
                </div>

                <%---------------------- QuestionId = 238  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูปการเก็บสายและพันหัวที่ LNB/BUC</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="picWiringLnbRadio" value="PASS">PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="picWiringLnbRadio" value="NOTPASS">NOT PASS
                        </label>
                    </div>
                </div>

                <%---------------------- QuestionId = 239  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูปแนว Line Of Sight (ดูการถูกบังของหน้าจานดาวเทียม)</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="picLineofSightRadio" value="PASS" />PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="picLineofSightRadio" value="NOTPASS" />NOT PASS
                        </label>
                    </div>
                </div>
                <%--////////////// --------------------- END  SECTION ID 21 ---------------------------  //////////////////--%>
















                <%--////////////// --------------------- START  SECTION ID 22 ---------------------------  //////////////////--%>
                <div class="row mt-3">
                    <div class="col-md-12 bg-primary text-white text-center Myfont">
                        <h3>SOLAR CELL PICTURE CHECKLIST</h3>
                    </div>
                </div>

                <%---------------------- QuestionId = 240  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูปจุดติดตั้ง Solar Cell</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="picBaseSolarcellRadio" value="PASS">PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="picBaseSolarcellRadio" value="NOTPASS">NOT PASS
                        </label>
                    </div>
                </div>

                 <%---------------------- QuestionId = 241  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูปอุปกรณ์ Solar Cell ภายในห้อง</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="solarcellToolsinroomRadio" value="PASS"/>PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input"  name="solarcellToolsinroomRadio" value="NOTPASS"/>NOT PASS
                        </label>
                    </div>
                </div>



                 <%---------------------- QuestionId = 242  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูปหน้าจอ Charger แสดงค่าต่างๆ</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input"  name="screenChargerRadio" value="PASS"/>PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="screenChargerRadio" value="NOTPASS"/>NOT PASS
                        </label>
                    </div>
                </div>


                 <%---------------------- QuestionId = 243  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูปหน้าจอ Inverter แสดงค่าต่างๆ</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="screenInverterRadio" value="PASS"/>PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="screenInverterRadio" value="NOTPASS"/>NOT PASS
                        </label>
                    </div>
                </div>


                 <%---------------------- QuestionId = 244  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูป Circuit Breaker ภายในตู้</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input"  name="piccircuitBreakerRadio" value="PASS"/>PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="piccircuitBreakerRadio" value="NOTPASS"/>NOT PASS
                        </label>
                    </div>
                </div>

                 <%---------------------- QuestionId = 245  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูป Terminal ต่อสายภายในตู้</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input"  name="picTerminalRadio" value="PASS"/>PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input"  name="picTerminalRadio" value="NOTPASS"/>NOT PASS
                        </label>
                    </div>
                </div>




                 <%---------------------- QuestionId = 246  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูปความสะอาดแผง PV</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input"  name="picCleaningPvRadio" value="PASS">PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input"  name="picCleaningPvRadio" value="NOTPASS">NOT PASS
                        </label>
                    </div>
                </div>




                     <%---------------------- QuestionId = 247  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูปภาพรวมดูสิ่งบดบังแสงอาทิตย์</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input"  name="picSunriseRadio" value="PASS">PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input"  name="picSunriseRadio" value="NOTPASS">NOT PASS
                        </label>
                    </div>
                </div>
                 <%--////////////// --------------------- END  SECTION ID 22 ---------------------------  //////////////////--%>







                 <%--////////////// --------------------- START  SECTION ID 23 ---------------------------  //////////////////--%>
                <div class="row mt-3">
                    <div class="col-md-12 bg-primary text-white text-center Myfont">
                        <h3>COMPUTER PICTURE CHECKLIST</h3>
                    </div>
                </div>

                
                     <%---------------------- QuestionId = 248  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูปคอมพิวเตอร์ตัวที่ 1 พร้อม Serial NO.(เครื่องผู้ดูแล)</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="piccomAgentRadio1" value="PASS"/>PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input"  name="piccomAgentRadio1" value="NOTPASS"/>NOT PASS
                        </label>
                    </div>
                </div>


                  <%---------------------- QuestionId = 249  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูปคอมพิวเตอร์ตัวที่ 2 พร้อม Serial NO.</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="piccomAgentRadio2" value="PASS">PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input"  name="piccomAgentRadio2" value="NOTPASS">NOT PASS
                        </label>
                    </div>
                </div>



                  <%---------------------- QuestionId = 250  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูปคอมพิวเตอร์ตัวที่ 3 พร้อม Serial NO.</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input"  name="piccomAgentRadio3" value="PASS"/>PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="piccomAgentRadio3" value="NOTPASS"/>NOT PASS
                        </label>
                    </div>
                </div>





                 <%---------------------- QuestionId = 251  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูปคอมพิวเตอร์ตัวที่ 4 พร้อม Serial NO.</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input"  name="piccomAgentRadio4" value="PASS"/>PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input"  name="piccomAgentRadio4" value="NOTPASS"/>NOT PASS
                        </label>
                    </div>
                </div>




                 <%---------------------- QuestionId = 252  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูปคอมพิวเตอร์ตัวที่ 5 พร้อม Serial NO.</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input"  name="piccomAgentRadio5" value="PASS"/>PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input"  name="piccomAgentRadio5" value="NOTPASS"/>NOT PASS
                        </label>
                    </div>
                </div>



                <%---------------------- QuestionId = 253  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูปคอมพิวเตอร์ตัวที่ 6 พร้อม Serial NO.</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="piccomAgentRadio6" value="PASS"/>PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input"  name="piccomAgentRadio6" value="NOTPASS"/>NOT PASS
                        </label>
                    </div>
                </div>


                 <%---------------------- QuestionId = 254  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูปคอมพิวเตอร์ตัวที่ 7 พร้อม Serial NO.</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input"  name="piccomAgentRadio7" value="PASS"/>PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input"  name="piccomAgentRadio7" value="NOTPASS"/>NOT PASS
                        </label>
                    </div>
                </div>

                 <%---------------------- QuestionId = 255  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูปคอมพิวเตอร์ตัวที่ 8 พร้อม Serial NO.</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="piccomAgentRadio8" value="PASS">PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input"  name="piccomAgentRadio8" value="NOTPASS">NOT PASS
                        </label>
                    </div>
                </div>



                 <%---------------------- QuestionId = 256  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูปคอมพิวเตอร์ตัวที่ 9 พร้อม Serial NO.</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="piccomAgentRadio9" value="PASS">PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input"  name="piccomAgentRadio9" value="NOTPASS">NOT PASS
                        </label>
                    </div>
                </div>

                 <%---------------------- QuestionId = 257  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูปคอมพิวเตอร์ตัวที่ 10 พร้อม Serial NO.</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="piccomAgentRadio10" value="PASS"/>PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="piccomAgentRadio10" value="NOTPASS"/>NOT PASS
                        </label>
                    </div>
                </div>
                 <%---------------------- QuestionId = 258  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูปคอมพิวเตอร์ตัวที่ 11 พร้อม Serial NO.</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input"  name="piccomAgentRadio11" value="PASS"/>PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" " name="piccomAgentRadio11" value="NOTPASS"/>NOT PASS
                        </label>
                    </div>
                </div>
                  <%--////////////// --------------------- END  SECTION ID 23 ---------------------------  //////////////////--%>





                 <%--////////////// --------------------- START  SECTION ID 24 ---------------------------  //////////////////--%>

                <div class="row mt-3">
                    <div class="col-sm-12 text-black text-center Myfont">
                        <h3>รูปภาพประกอบรายงาน</h3>
                    </div>
                </div>



                <%---------------------- QuestionId = 259  ---------------------------%>
                <div class="row mt-3 ">
                    <div class="col-sm-12">1.รูป PICTURE CHECKLIST </div>
                     <asp:FileUpload ID="pictureChecklistImages" runat="server" data-thumbnail="user_img_2" accept="image/" onchange="previewImage(this)" required="required" />
                   <%-- <input type="file" name="image2" onchange="previewImage(this)" accept="image/*" data-thumbnail="user_img_2" />--%>
                </div>
                <div class="row ml-3 mt-3">
                    <img id="user_img_2" src="https://placehold.it/250x250" class="placeholder2" />
                </div>



                 <%---------------------- QuestionId = 260  ---------------------------%>
                <div class="row mt-3">
                    <div class="col-sm-12">2.รูป VSAT PICTURE CHECKLIST</div>
                       <asp:FileUpload ID="vsatpictureChecklistImages" runat="server" data-thumbnail="user_img_3" accept="image/" onchange="previewImage(this)" required="required" />
<%--                    <input type="file" name="image3" onchange="previewImage(this)" accept="image/*" data-thumbnail="user_img_3" />--%>
                </div>
                <div class="row ml-3 mt-3">
                    <img id="user_img_3" src="https://placehold.it/250x250" class="placeholder2" />
                </div>


                 <%---------------------- QuestionId = 261  ---------------------------%>
                <div class="row mt-3">
                    <div class="col-sm-12">3.รูป SOLAR CELL PICTURE CHECKLIST</div>
                       <asp:FileUpload ID="solarcellpictureChecklistImages" runat="server" data-thumbnail="user_img_4" accept="image/" onchange="previewImage(this)" required="required" />
<%--                    <input type="file" name="image4" onchange="previewImage(this)" accept="image/*" data-thumbnail="user_img_4" />--%>
                </div>
                <div class="row ml-3 mt-3">
                    <img id="user_img_4" src="https://placehold.it/250x250" class="placeholder2" />
                </div>



                 <%---------------------- QuestionId = 262  ---------------------------%>
                <div class="row mt-3">
                    <div class="col-sm-12">4.COMPUTER PICTURE CHECKLIST</div>
                       <asp:FileUpload ID="compictureChecklistImages" runat="server" data-thumbnail="user_img_5" accept="image/" onchange="previewImage(this)" required="required" />
<%--                    <input type="file" name="image5" onchange="previewImage(this)" accept="image/*" data-thumbnail="user_img_5" />--%>
                </div>
                <div class="row ml-3 mt-3">
                    <img id="user_img_5" src="https://placehold.it/250x250" class="placeholder2" />
                </div>
                 <%--////////////// --------------------- END  SECTION ID 24 ---------------------------  //////////////////--%>





                <%--                  EXSAMPLE DATAAA--%>
                <%--                <table>
                    <asp:Repeater runat="server" ID="ResultRepeater">
                        <ItemTemplate>
                            <tr>
                                <td>
                                    <%# Eval("AnsDes") %>
                                </td>
                                <td>
                                    <%# Eval("CreateDate") %></td>
                                <td>
                                    <%# Eval("User.FirstName") %></td>
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                </table>--%>


















                <%--  OLD RESOUCE              <div class="row mt-3">
                    <div class="col-md-12  text-black text-center Myfont">
                        <h3>รูปภาพประกอบรายงาน</h3>
                    </div>
                    <div class="col-md-12 text-center mt-3 table-bordered">
                        <label >1.รูป PICTURE CHECKLIST</label>
                        <input type="file" class="form-control-file" id="">
                    </div>

                    <div class="col-md-12 text-center mt-3 table-bordered">
                        <label >2.รูป VSAT PICTURE CHECKLIST</label>
                        <input type="file" class="form-control-file" id="">
                    </div>

                    <div class="col-md-12 text-center mt-3 table-bordered">
                        <label >3.รูป SOLAR CELL PICTURE CHECKLISTT</label>
                        <input type="file" class="form-control-file" id="">
                    </div>

                    <div class="col-md-12 text-center mt-3 table-bordered">
                        <label >4. COMPUTER PICTURE CHECKLIST</label>
                        <input type="file" class="form-control-file" id="">
                    </div>
                </div>--%>

                <div class="row">
                    <asp:Button ID="SubmitButton" runat="server" Text="บันทึก" CssClass="btn btn-primary btn-block" OnClick="SubmitButton_Click" />
                </div>

            </form>
        </div>
    </form>



    <%--    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>--%>
    <%--    <script src="https://cdnjs.cloudflare.com/ajax/libs/bootstrap-datepicker/1.7.1/js/bootstrap-datepicker.min.js"></script>--%>
    <%--    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js" integrity="sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl" crossorigin="anonymous"></script>--%>













    <%--/////////////////    script START !!   /////////////////////////////--%>
     <script type="text/javascript">
         function GetRadioValue() {
             var radioX = document.getElementById('Radio1');
             alert(radioX.value);
         }
     </script>
    <script type="text/javascript">
        var input = $("#exampleFormControlFile1").change(function () {
            alert(this.value.split("\\").pop())
        })
    </script>

    <%-- <script type="text/javascript">
         $(function () {
             $('#startDateTextbox').datepicker({
                 // ...relevant options...
                 weekStart: 1,
                 daysOfWeekHighlighted: "6,0",
                 autoclose: true,
                 todayHighlight: true,

             });
             $('#startDate2').datepicker({
                 // ...relevant options...
                 weekStart: 1,
                 daysOfWeekHighlighted: "6,0",
                 autoclose: true,
                 todayHighlight: true,
             });
         });
     </script>--%>



    <%--    <script>
        $(function () {
            $("#startDateTextbox2").datepicker();
        });
    </script>--%>




    <script>
        $(function () {
            $("#startDatepicker").datepicker();
        });
    </script>

    <script>
        $(function () {
            $("#endDatepicker").datepicker();
        });
    </script>

    <script>
        $(function () {
            $("#DateExecutorTextbox").datepicker();
        });
    </script>

    <script>
        $(function () {
            $("#DateSupervisorTextbox").datepicker();
        });
    </script>













    <%----------------------------//////////    CSS ONLY !!   ////////--------------------------%>
    <%--  <style type="text/css">
        .datepicker {
            font-size: 0.875em;
        }
            /* solution 2: the original datepicker use 20px so replace with the following:*/

            .datepicker td, .datepicker th {
                width: 1.5em;
                height: 1.5em;
            }

      
        .datepicker2 {
            font-size: 0.875em;
        }
        /* solution 2: the original datepicker use 20px so replace with the following:*/

        .datepicker2 td, .datepicker2 th {
            width: 1.5em;
            height: 1.5em;
        }

        .file {
            visibility: hidden;
            position: absolute;
        }

        .placeholder2 {
            align-items: center;
            align-self: center;
            justify-content: center;
             width:250px;
           height:250px;
        }
    </style>--%>
</body>
</html>
