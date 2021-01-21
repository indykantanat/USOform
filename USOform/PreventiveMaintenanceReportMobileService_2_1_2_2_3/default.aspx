﻿<%@ Page Title="รายงาน PM Form MB" Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="USOform.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
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
    <link rel="stylesheet" href="/resources/demos/style.css" />
    <script src="https://code.jquery.com/jquery-1.12.4.js"></script>
    <script src="https://code.jquery.com/ui/1.12.1/jquery-ui.js"></script>
</head>



<body style="background-color: lightgray">
    <form id="form1" runat="server">
        <div class="container bg-white">
             <div class="alert alert-success" role="alert" runat="server" id="SuccessPanel" visible="false">
                This is a success alert with <a href="#" class="alert-link">an example link</a>. Give it a click if you like.
            </div>


            <div class="row pt-5">
                <div class="col-4">
            <asp:FileUpload ID="logoPicture" runat="server" data-thumbnail="user_img_2" accept="image/" onchange="previewImage(this)" required="required" />
                </div>
                <div class="col-4  d-flex justify-content-center ">
                    <h5 class="headerText">Preventive Maintenance Site Report USO (Mobile)</h5>
                </div>
                <div class="col-4 ">
                    <img src="/assets/logo_uso.png" class="logoImg" />
                </div>
            </div>
           



            <%--////////////////////////////////    HEADER CONTENT    ///////////////////////////////////////////////--%>
            <div class="row">
                <div class="col-12 text-left ">
                    <div>
                        <h5>รายงานผลการตรวจสอบและบำรุงรักษาชุดอุปกรณ์ Mobile Service (Preventive Maintenance (PM) Report)</h5>
                    </div>
                    <div>
                        <h5>โครงการจัดให้มีสัญญาณโทรศัพท์เคลื่อนที่และบริการอินเทอร์เน็ตความเร็วสูงในพื้นที่ชายขอบ (Zone C+) </h5>
                    </div>
                </div>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-1">กลุ่ม :</label>
                <div class="col-sm-4">
                    <input type="text" class="form-control" id="groupTextbox" runat="server" />
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-1">ภาค :</label>
                <div class="col-sm-4">
                    <input type="text" class="form-control" id="AreaTextbox"  runat="server"/>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-1">บริษัท :</label>
                <div class="col-sm-4">
                    <input type="text" class="form-control" id="CompanyTextbox"  runat="server"/>
                </div>
            </div>



            <div class="form-row mt-3">
                <label class="control-label col-sm-7">ส่วนที่ 2 การจัดให้มีบริการสัญญาณโทรศัพท์เคลื่อนที่ (Mobile Service) ประเภทบริการ </label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="mobileServiceAtRadio" value="2.1"  runat="server"/>2.1
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="mobileServiceAtRadio" value="2.2"  runat="server"/>2.2
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="mobileServiceAtRadio" value="3"  runat="server"/>3
                    </label>
                </div>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-2">รอบการบำรุงรักษา ครั้งที่ </label>
                <div class="col-sm-1">
                    <input type="text" class="form-control" id="maintenanceCountTextbox" runat="server" />
                </div>
                /
              <div class="col-sm-1">
                  <input type="text" class="form-control" id="yearTextbox" runat="server" />
              </div>
            </div>



            <div class="row text-left mt-3">
                <div class="col-md-12">
                    <div>
                        <label>
                            <div>วัน เดือน ปี</div>
                        </label>
                        <input data-date-format="dd/mm/yyyy" id="startDatepicker" runat="server" />

                        <label>
                            <div>ถึง</div>
                        </label>
                        <input data-date-format="dd/mm/yyyy" id="endDatepicker"  runat="server"/>
                    </div>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-2">สถานที่ (Site code)</label>
                <div class="col-sm-4">
                    <input type="text" class="form-control" id="siteCodeTextbox"  runat="server"/>
                </div>
            </div>
            <%--////////////////////////////////    END HEADER CONTENT    ///////////////////////////////////////////////--%>





            <%-- //////////////////////////////////    Sectionid  = 125    /////////////////////////////////--%>

            <div class="row ">
                <div class="col-md-12 bg-primary text-white text-center">
                    <h3>PREVENTIVE MAINTENANCE SITE REPORT (PM)</h3>
                </div>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-1">Cabinet ID :</label>
                <div class="col-sm-11">
                    <input type="text" class="form-control" id="cabinetIdTextbox" runat="server" />
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-1">Site Code :</label>
                <div class="col-sm-11">
                    <input class="form-control" id="sitecodeTextboxSection2" runat="server" />
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-1">Village ID :</label>
                <div class="col-sm-11">
                    <input class="form-control" id="VillageIdTextbox" runat="server" />
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-1">Village :</label>
                <div class="col-sm-11">
                    <input class="form-control" id="villageTextbox" runat="server" />
                </div>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-1">Sub-District:</label>
                <div class="col-sm-11">
                    <input class="form-control" id="subdistrictTextbox" runat="server" />
                </div>
            </div>

              <div class="form-row mt-3">
                <label class="control-label col-sm-1">District:</label>
                <div class="col-sm-11">
                    <input class="form-control" id="DistrictTextbox" runat="server" />
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-1">Province :</label>
                <div class="col-sm-11">
                    <input class="form-control" id="provinceTextbox" runat="server" />
                </div>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-1">Type :</label>
                <div class="col-sm-11">
                    <input class="form-control" id="typeTextbox" runat="server" />
                </div>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-1">PM Date : </label>
                <div class="col-sm-11">
                    <input class="form-control" id="pmdateTextbox" runat="server" />
                </div>
            </div>

            <div class="form-row mt-3 table-bordered">
                <div class="col-sm-12 bg-primary text-white">ใส่รูปหน้าตู้</div>              
                <asp:FileUpload ID="picinfrontImages" runat="server" data-thumbnail="" accept="image/" onchange="previewImage(this)" required="required" />
            </div>

               <%-- //////////////////////////////////   END  Sectionid  = 125    /////////////////////////////////--%>


              <%-- //////////////////////////////////     Sectionid  = 126    /////////////////////////////////--%>

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


              <%-- //////////////////////////////////   END  Sectionid  = 126    /////////////////////////////////--%>



              <%-- //////////////////////////////////     Sectionid  = 127     /////////////////////////////////--%>
            <div class="row ">
                <div class="col-md-12 bg-success text-white text-center Myfont">
                    <h3>1. รายละเอียดสถานี</h3>
                </div>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-1">Cabinet ID</label>
                <div class="col-sm-11">
                    <input type="text" class="form-control" id="cabinetId2Textbox" runat="server" required="required" />
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-1">Site Code</label>
                <div class="col-sm-11">
                    <input type="text" class="form-control" id="sitecodeTextboxSection4" runat="server" required="required" />
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-1">Village ID</label>
                <div class="col-sm-11">
                    <input type="text" class="form-control" id="villageIDTextboxSection4"  runat="server" required="required" />
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-1">LAT & LONG</label>
                <div class="col-sm-11">
                    <input type="text" class="form-control" id="latandlongTextbox"  runat="server" required="required" />
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">OLT ID (USO Network) or ISP (Existing Network)</label>
                <div class="col-sm-8">
                    <input type="text" class="form-control" id="oltorispTextbox"  runat="server" required="required" />
                </div>
            </div>

              <%-- //////////////////////////////////   END  Sectionid  = 127    /////////////////////////////////--%>


              <%-- //////////////////////////////////     Sectionid  = 128    /////////////////////////////////--%>
            <div class="row mt-3">
                <div class="col-md-12 bg-primary text-white text-center Myfont">
                    <h3>2. ระบบไฟฟ้า (หลัก)</h3>
                </div>
            </div>

            <div class="form-row mt-3">

                <label class="control-label col-sm-2">ระบบไฟฟ้า</label>
                <div class="form-check-inline">
                    <label class="form-check-label" >
                        <input type="radio" class="form-check-input"  name="voltSystemRadio" value="PEA">PEA
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="voltSystemRadio" value="Solar Cell">Solar Cell
                    </label>
                </div>
            </div>



            <div class="form-row mt-3">
                <label class="control-label col-sm-2">หมายเลขผู้ใช้ไฟ</label>
                <div class="col-sm-10">
                    <input type="text" class="form-control" id="numberIdTextbox" runat="server" required="required" />
                </div>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-2">หน่วยใช้ไฟ (kWh Meter)</label>
                <div class="col-sm-8">
                    <input type="text" class="form-control" id="kwhMeterTextbox" runat="server" required="required" />
                </div>
                <label class="control-label col-sm-2">kWh</label>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-2">แรงดัน AC (kWh Meter)</label>
                <div class="col-sm-8">
                    <input type="text" class="form-control" id="acvoltTextbox" runat="server" required="required"  />
                </div>
                <label class="control-label col-sm-2">V.</label>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-2">กระแส Line AC (kWh Meter)</label>
                <div class="col-sm-8">
                    <input type="text" class="form-control" id="lineAcTextbox"  runat="server" required="required"  />
                </div>
                <label class="control-label col-sm-2">A.</label>
            </div>

             <div class="form-row mt-3">
                <label class="control-label col-sm-2">กระแส Neutron AC (kWh Meter)</label>
                <div class="col-sm-8">
                    <input type="text" class="form-control" id="neutronAcTextbox"  runat="server" required="required"  />
                </div>
                <label class="control-label col-sm-2">A.</label>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-2">สภาพ kWh Meter</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="conditionRadio" value="ปกติ">ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="conditionRadio" value="ชำรุด/ใช้งานไม่ได้">ชำรุด/ใช้งานไม่ได้
                    </label>
                </div>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-2">สภาพ Circuit Breaker</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="MDBCircuitBreakerRadio" value="ปกติ">ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="MDBCircuitBreakerRadio" value="ชำรุด/ใช้งานไม่ได้">ชำรุด/ใช้งานไม่ได้
                    </label>
                </div>
            </div>

              <%-- //////////////////////////////////    END  Sectionid  = 128    /////////////////////////////////--%>



            <%-- //////////////////////////////////      Sectionid  = 129    /////////////////////////////////--%>

            <div class="row mt-3">
                <div class="col-md-12 bg-primary text-white text-center Myfont">
                    <h3>2. ระบบไฟฟ้า (สำรอง)</h3>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-2">UPS ภายในตู้</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="inupsRadio" value="มี">มี
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="inupsRadio" value="ไม่มี">ไม่มี
                    </label>
                </div>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-2">แรงดัน AC จาก UPS</label>
                <div class="col-sm-8">
                    <input type="text" class="form-control" id="acfromupsTextbox" runat="server" required="required"  />
                </div>
                <label class="control-label col-sm-2">V.</label>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-2">ระดับกระแส Load </label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="voltageLoadRadio" value="1">1
                    </label>
                </div>

                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="voltageLoadRadio" value="2">2
                    </label>
                </div>

                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="voltageLoadRadio" value="3">3
                    </label>
                </div>

                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="voltageLoadRadio" value="4">4
                    </label>

                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input"  name="voltageLoadRadio" value="5">5
                        </label>
                    </div>
                </div>
                <label class="control-label col-sm-2">(ขีดล่าง =1 , ขีดบน = 5)</label>

            </div>



            <div class="form-row mt-3">
                <label class="control-label col-sm-2">ระดับความจุ Battery</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="batteryCapacityRadio" value="1">1
                    </label>
                </div>

                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="batteryCapacityRadio" value="2">2
                    </label>
                </div>

                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="batteryCapacityRadio" value="3">3
                    </label>
                </div>

                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="batteryCapacityRadio" value="4">4
                    </label>

                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="batteryCapacityRadio" value="5">5
                        </label>
                    </div>
                </div>
                <label class="control-label col-sm-2">(ขีดล่าง =1 , ขีดบน = 5)</label>
            </div>


              <div class="form-row mt-3">
                <label class="control-label col-sm-2">UPS MODE</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="upsModeRadio" value="LINE" />LINE
                    </label>
                </div>

                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="upsModeRadio" value="BATT" />BATT.
                    </label>
                </div>

                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="upsModeRadio" value="BYPASS" />BYPASS
                    </label>
                </div>
                </div>




            <div class="form-row mt-3">
                <label class="control-label col-sm-2">การทำงานของระบบไฟสำรอง</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="secondFireRadio" value="ปกติ" />ปกติ
                    </label>
                </div>

                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="secondFireRadio" value="ชำรุด/ใช้งานไม่ได้" />ชำรุด/ใช้งานไม่ได้
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-2">สภาพ Battery Bank</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="batterybankRadio" value="ปกติ">ปกติ
                    </label>
                </div>

                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="batterybankRadio" value="ชำรุด/ใช้งานไม่ได้">ชำรุด/ใช้งานไม่ได้
                    </label>
                </div>
            </div>
            <%-- //////////////////////////////////    END   Sectionid  = 129    /////////////////////////////////--%>










               <%-- //////////////////////////////////       Sectionid  = 130     /////////////////////////////////--%>
            <div class="row mt-3">
                <div class="col-md-12 bg-primary text-white text-center Myfont">
                    <h3>4. รายละเอียดอุปกรณ์ Network ภายในตู้</h3>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-2">ONU/Modem Network</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="ONUModemNetworkRadio" value="TOT"/>TOT
                    </label>
                </div>

                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="ONUModemNetworkRadio" value="TRUE"/>TRUE
                    </label>
                </div>

                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="ONUModemNetworkRadio" value="3BB"/>3BB
                    </label>
                </div>

                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="ONUModemNetworkRadio" value="Satellite"/>Satellite
                    </label>
                </div>
            </div>


            <div class="form-row mt-3 ">
                <label class="control-label col-sm-2">FEMTO</label>
                <div class="form-check-inline col-4 ">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="femToRadio" value="3G" />3G
                    </label>
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="femToRadio" value="4G" />4G
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="femToanswerRadio" value="ปกติ"/>ปกติ
                    </label>
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="femToanswerRadio" value="ชำรุด/ใช้งานไม่ได้"/>ชำรุด/ใช้งานไม่ได้
                    </label>
                </div>
            </div>

            <div class="form-row mt-3 ">
                <label class="control-label ">การระบายอากาศ (T-Power)</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="tpowerRadio" value="ปกติ" />ปกติ                
                    </label>
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="tpowerRadio" value="ชำรุด/ใช้งานไม่ได้" />ชำรุด/ใช้งานไม่ได้
                    </label>
                </div>
            </div>


            <div class="form-row mt-3 ">
                <label class="control-label ">การ Wiring สายไฟและสาย Ground</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="wireingGroundRadio" value="เรียบร้อย"/>เรียบร้อย                          
                    </label>
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="wireingGroundRadio" value="ไม่เรียบร้อย"/>ไม่เรียบร้อย
                    </label>
                </div>
            </div>
            <div class="form-row mt-3 ">
                <label class="control-label ">การ Wiring Patch cord และ สาย LAN</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="WirinlanRadio" value="เรียบร้อย" />เรียบร้อย                          
                    </label>
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="WirinlanRadio" value="ไม่เรียบร้อย" />ไม่เรียบร้อย
                    </label>
                </div>
            </div>
            
               <%-- //////////////////////////////////     END   Sectionid  = 130     /////////////////////////////////--%>



            
               <%-- //////////////////////////////////       Sectionid  = 131     /////////////////////////////////--%>
            <div class="row mt-3">
                <div class="col-md-12 bg-success text-white text-center Myfont">
                    <h3>5. ระบบ Ground</h3>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">ความแข็งแรงจุดต่อ Ground Bar</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="groundbarRadio" value="ปกติ" />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="groundbarRadio" value="ชำรุด" />ชำรุด
                    </label>
                </div>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-4">ความแข็งแรงของน็อตขันหางปลาอุปกรณ์</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="notfishRadio" value="ปกติ"/>ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="notfishRadio" value="ชำรุด"/>ชำรุด
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">สายกราวด์เรียบร้อย ปลอดภัย สมบูรณ์</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="safegroundRadio" value="ปกติ">ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="safegroundRadio" value="ชำรุด">ชำรุด
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">สถานะไฟฟ้ารั่วลง Ground</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="brokenElecRadio" value="ไม่พบไฟฟ้ารั่"/>ไม่พบไฟฟ้ารั่ว
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="brokenElecRadio" value="พบไฟฟ้ารั่"/>พบไฟฟ้ารั่ว
                    </label>
                </div>
            </div>
             <%-- //////////////////////////////////   END    Sectionid  = 131     /////////////////////////////////--%>



               <%-- //////////////////////////////////       Sectionid  = 132     /////////////////////////////////--%>

            <div class="row mt-3">
                <div class="col-md-12 bg-success text-white text-center Myfont">
                    <h3>6. สภาพแวดล้อมและความสะอาดโดยรอบ</h3>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">ป้ายและตัวเลขแสดงชื่อสถานี</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="signandnumberRadio" value="ปกติ"/>ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="signandnumberRadio" value="ไม่ชัดเจน"/>ไม่ชัดเจน
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">การติดตั้งและการยึดตู้อุปกรณ์</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="inStallRadio" value="ปกติ"/>ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="inStallRadio" value="ชำรุด"/>ชำรุด
                    </label>
                </div>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-4">เสาไฟฟ้าที่ติดตั้งอุปกรณ์</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="inStallSatRadio" value="ปกติ"/>ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="inStallSatRadio" value="ชำรุด/เอียง"/>ชำรุด/เอียง
                    </label>
                </div>
            </div>

              <div class="form-row mt-3">
                <label class="control-label col-sm-4">แนวสายไฟฟ้าและสายเคเบิ้ลเข้าสถานี</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="cabletoStationRadio" value="ปกติ"/>ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="cabletoStationRadio" value="ชำรุด/เอียง"/>ตกหย่อน/ไม่ได้จับยึด
                    </label>
                </div>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-4">ช่อง Cable Inlet  และความสะอาด</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="CableInletRadio" value="ปกติ"/>ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="CableInletRadio" value="ไม่ได้อุดซิลีโคน"/>ไม่ได้อุดซิลีโคน
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">ช่อง Filter ความสะอาด (T-Power)</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="filterRadio" value="ปกติ">ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="filterRadio" value="มีฝุ่น/สิ่งสกปรก">มีฝุ่น/สิ่งสกปรก
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">ประตูและยางขอบประตูของตู้อุปกรณ์</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="doorToolsRadio" value="ปกติ"/>ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="doorToolsRadio" value="ชำรุด"/>ชำรุด
                    </label>
                </div>
            </div>
   <%-- //////////////////////////////////   END  Sectionid  = 132     /////////////////////////////////--%>






          <%-- //////////////////////////////////     Sectionid  = 133     /////////////////////////////////--%>
            <div class="row mt-3">
                <div class="col-md-12 bg-primary text-white text-center Myfont">
                    <h3>7.อุปกรณ์ระบบ VSAT (เฉพาะ Site ที่เป็น VSAT)</h3>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">อุปกรณ์ LNB/BUC</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="toolslnbRadio" value="ปกติ"/>ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="toolslnbRadio" value="ชำรุด/ใช้งานไม่ได้"/>ชำรุด/ใช้งานไม่ได้
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">การเก็บสาย RG และการพันหัว</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="wiringrgRadio" value="ปกติ">ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="wiringrgRadio" value="ไม่เรียบร้อย/ไม่แน่น">ไม่เรียบร้อย/ไม่แน่น
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">ฐานและระดับของเสาจาน</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="baseOnRadio" value="ปกติ">ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="baseOnRadio" value="ไม่ได้ระดับ/เอียง">ไม่ได้ระดับ/เอียง
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">แนว Line Of Sight</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="xxlineOfsightRadio" value="ปกติ">ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="xxlineOfsightRadio" value="โดนบัง">โดนบัง
                    </label>
                </div>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-4">ความสะอาดของหน้าจาน</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="cleaningDishRadio" value="ปกติ">ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="cleaningDishRadio" value="สกปรก">สกปรก
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">LNB Band Switch</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="lnbbandswitchRadio" value="HIGH BAND">HIGH BAND
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="lnbbandswitchRadio" value="LOW BAND">LOW BAND
                    </label>
                </div>
            </div>
             <%-- //////////////////////////////////   END  Sectionid  = 133     /////////////////////////////////--%>





            <%-- //////////////////////////////////     Sectionid  = 134     /////////////////////////////////--%>
            <div class="row mt-3">
                <div class="col-md-12 bg-primary text-white text-center Myfont">
                    <h3>8.อุปกรณ์ระบบ Solar Cell (เฉพาะ Site ที่ใช้ Solar Cell)</h3>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">ระบบ Solar Cell</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="solarcellSystemRadio" value="ปกติ"/>ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="solarcellSystemRadio" value="ชำรุด/ใช้งานไม่ได้"/>ชำรุด/ใช้งานไม่ได้
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">แผง PV Panel</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="pvPanelRadio" value="ปกติ">ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="pvPanelRadio" value="ชำรุด/ใช้งานไม่ได้">ชำรุด/ใช้งานไม่ได้
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">อุปกรณ์ Charger</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="toolsCharger" value="ปกติ">ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="toolsCharger" value="ชำรุด/ใช้งานไม่ได้">ชำรุด/ใช้งานไม่ได้
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">ความสะอาดแผง PV </label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="cleanIngpvRadio" value="ปกติ">ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="cleanIngpvRadio" value="สกปรก">สกปรก
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">การติดตั้งแผง PV </label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="installPvRadio" value="ที่โล่งรับแดดปกติ " />ที่โล่งรับแดดปกติ 
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="installPvRadio" value="มีอาคาร/ต้นไม้บัง" />มีอาคาร/ต้นไม้บัง
                    </label>
                </div>
            </div>


              <div class="form-row mt-3">
                <label class="control-label col-sm-4">ระบบ Solar Cell</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="solarcellSystemRadio2" value="ปกติ"/>ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="solarcellSystemRadio2" value="ชำรุด/ใช้งานไม่ได้"/>ชำรุด/ใช้งานไม่ได้
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-2">แรงดันไฟจาก Inverter</label>
                <div class="col-sm-8">
                    <input type="text" class="form-control" id="voltInverterTextbox" runat="server" />
                </div>
                <label class="control-label col-sm-2">V.</label>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-2">กระแส Load</label>
                <div class="col-sm-8">
                    <input type="text" class="form-control" id="loadVoltTageTextbox" runat="server" />
                </div>
                <label class="control-label col-sm-2">A.</label>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-2">แรงดัน Battery ก้อนที่ 1</label>
                <div class="col-sm-8">
                    <input type="text" class="form-control" id="batterTextbox1"  runat="server" />
                </div>
                <label class="control-label col-sm-2">V.</label>
            </div>
            <div class="form-row mt-3">
                <label class="control-label col-sm-2">แรงดัน Battery ก้อนที่ 2</label>
                <div class="col-sm-8">
                    <input type="text" class="form-control" id="batterTextbox2"  runat="server" />
                </div>
                <label class="control-label col-sm-2">V.</label>
            </div>
            <div class="form-row mt-3">
                <label class="control-label col-sm-2">แรงดัน Battery ก้อนที่ 3</label>
                <div class="col-sm-8">
                    <input type="text" class="form-control" id="batterTextbox3"  runat="server" />
                </div>
                <label class="control-label col-sm-2">V.</label>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-2">แรงดัน Battery ก้อนที่ 4</label>
                <div class="col-sm-8">
                    <input type="text" class="form-control" id="batterTextbox4"  runat="server" />
                </div>
                <label class="control-label col-sm-2">V.</label>
            </div>

             <%-- //////////////////////////////////  END Sectionid  = 134     /////////////////////////////////--%>








               <%-- //////////////////////////////////  Sectionid  = 135     /////////////////////////////////--%>
            <div class="row mt-3">
                <div class="col-md-12 bg-primary text-white text-center Myfont">
                    <h3>9.คุณภาพของสัญญาณ</h3>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-2">Call Test (for Femto)</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="callTestforfemtoRadio" value="ปกติ"/>ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="callTestforfemtoRadio" value="ชำรุด/ใช้งานไม่ได้"/>ชำรุด/ใช้งานไม่ได้
                    </label>
                </div>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-2">Cell ID/Bsrid (for Femto)</label>
                <div class="col-sm-8">
                    <input type="text" class="form-control" id="cellIdTextbox" runat="server" />
                </div>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-2">Network strength (>= -77.5 dBm) Section 1</label>
                <div class="col-sm-8">
                    <input type="text" class="form-control" id="netWorkstrTextboxS1" runat="server" />
                </div>
                <label class="control-label col-sm-2">dBm</label>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-2">Network strength (>= -77.5 dBm) Section 2</label>
                <div class="col-sm-8">
                    <input type="text" class="form-control" id="netWorkstrTextboxS2" runat="server" />
                </div>
                <label class="control-label col-sm-2">dBm</label>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-2">Network strength (>= -77.5 dBm) Section 3</label>
                <div class="col-sm-8">
                    <input type="text" class="form-control" id="netWorkstrTextboxS3" runat="server" />
                </div>
                <label class="control-label col-sm-2">dBm</label>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-2">Download (for ONU/VSAT)</label>
                <div class="col-sm-8">
                    <input type="text" class="form-control" id="dowloadOnuTextbox" runat="server" />
                </div>
                <label class="control-label col-sm-2">Mb/s</label>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-2">Upload (for ONU/VSAT)</label>
                <div class="col-sm-8">
                    <input type="text" class="form-control" id="uploadforOnuTextbox" runat="server" />
                </div>
                <label class="control-label col-sm-2">Mb/s</label>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-2">Ping Test (for ONU/VSAT)</label>
                <div class="col-sm-8">
                    <input type="text" class="form-control" id="pinngtestforOnuTextbox" runat="server" />
                </div>
                <label class="control-label col-sm-2">ms</label>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-2">Download (for Mobile)</label>
                <div class="col-sm-8">
                    <input type="text" class="form-control" id="dowloadforMobileTextbox" runat="server" />
                </div>
                <label class="control-label col-sm-2">Mb/s</label>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-2">Upload (for Mobile)</label>
                <div class="col-sm-8">
                    <input type="text" class="form-control" id="uploadforMobileTextbox" runat="server" />
                </div>
                <label class="control-label col-sm-2">Mb/s</label>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-2">Ping Test (for Mobile)</label>
                <div class="col-sm-8">
                    <input type="text" class="form-control" id="pingtestFormobileTextbox" runat="server" />
                </div>
                <label class="control-label col-sm-2">Ms</label>
            </div>
               <%-- //////////////////////////////////  END Sectionid  = 135     /////////////////////////////////--%>










               <%-- //////////////////////////////////   Sectionid  = 136     /////////////////////////////////--%>
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
                               
                                <input type="text" class="form-control" id="problemTextbox1" runat="server" />
                            </div>
                            <div class="divTableCell">
                              
                                <input type="text" class="form-control" id="howtoSolveTextbox1" runat="server" />
                            </div>
                        </div>

                        <div class="divTableRow">
                            <div class="divTableCell">&nbsp;2</div>
                            <div class="divTableCell">
                              
                                <input type="text" class="form-control" id="problemTextbox2" runat="server" />
                            </div>
                            <div class="divTableCell">
                              
                                <input type="text" class="form-control" id="howtoSolveTextbox2" runat="server" />
                            </div>
                        </div>

                        <div class="divTableRow">
                            <div class="divTableCell">&nbsp;3</div>
                            <div class="divTableCell">
                               
                                <input type="text" class="form-control" id="problemTextbox3" runat="server" />
                            </div>
                            <div class="divTableCell">
                              
                                <input type="text" class="form-control" id="howtoSolveTextbox3" runat="server" />
                            </div>
                        </div>

                        <div class="divTableRow">
                            <div class="divTableCell">&nbsp;4</div>
                            <div class="divTableCell">
                              
                                <input type="text" class="form-control" id="problemTextbox4" runat="server" />
                            </div>
                            <div class="divTableCell">
                              
                                <input type="text" class="form-control" id="howtoSolveTextbox4" runat="server" />
                            </div>
                        </div>

                        <div class="divTableRow">
                            <div class="divTableCell">&nbsp;5</div>
                            <div class="divTableCell">
                                
                                <input type="text" class="form-control" id="problemTextbox5" runat="server" />
                            </div>
                            <div class="divTableCell">
                                <%----------------------  ---------------------------%>
                                <input type="text" class="form-control " id="howtoSolveTextbox5" runat="server" />
                            </div>
                        </div>
                        <div class="divTableRow">
                            <div class="divTableCell">&nbsp;6</div>
                            <div class="divTableCell">
                                <%----------------------  ---------------------------%>
                                <input type="text" class="form-control" id="problemTextbox6" runat="server" />
                            </div>
                            <div class="divTableCell">
                                <%----------------------   ---------------------------%>
                                <input type="text" class="form-control" id="howtoSolveTextbox6" runat="server" />
                            </div>
                        </div>
                        <div class="divTableRow">
                            <div class="divTableCell">&nbsp;7</div>
                            <div class="divTableCell">
                                <%----------------------   ---------------------------%>
                                <input type="text" class="form-control" id="problemTextbox7" runat="server" />
                            </div>
                            <div class="divTableCell">
                                <%----------------------   ---------------------------%>
                                <input type="text" class="form-control" id="howtoSolveTextbox7" runat="server" />
                            </div>
                        </div>
                        <div class="divTableRow">
                            <div class="divTableCell">&nbsp;8</div>
                            <div class="divTableCell">
                                <%----------------------   ---------------------------%>
                                <input type="text" class="form-control" id="problemTextbox8" runat="server" />
                            </div>
                            <div class="divTableCell">
                                <%----------------------  ---------------------------%>
                                <input type="text" class="form-control" id="howtoSolveTextbox8" runat="server" />
                            </div>
                        </div>
                        <div class="divTableRow">
                            <div class="divTableCell">&nbsp;9</div>
                            <div class="divTableCell">
                                <%----------------------  ---------------------------%>
                                <input type="text" class="form-control" id="problemTextbox9" runat="server" />
                            </div>
                            <div class="divTableCell">
                                <%----------------------   ---------------------------%>
                                <input type="text" class="form-control" id="howtoSolveTextbox9" runat="server" />
                            </div>
                        </div>
                        <div class="divTableRow">
                            <div class="divTableCell">&nbsp;10</div>
                            <div class="divTableCell">
                                <%----------------------   ---------------------------%>
                                <input type="text" class="form-control" id="problemTextbox10" runat="server" />
                            </div>
                            <div class="divTableCell">
                                <%---------------------- ---------------------------%>
                                <input type="text" class="form-control" id="howtoSolveTextbox10" runat="server" />
                            </div>
                        </div>
                        <div class="divTableRow">
                            <div class="divTableCell">&nbsp;11</div>
                            <div class="divTableCell">
                                <%---------------------- ---------------------------%>
                                <input type="text" class="form-control" id="problemTextbox11" runat="server" />
                            </div>
                            <div class="divTableCell">
                                <%----------------------   ---------------------------%>
                                <input type="text" class="form-control" id="howtoSolveTextbox11" runat="server" />
                            </div>
                        </div>
                        <div class="divTableRow">
                            <div class="divTableCell">&nbsp;12</div>
                            <div class="divTableCell">
                                <%---------------------- ---------------------------%>
                                <input type="text" class="form-control" id="problemTextbox12" runat="server" />
                            </div>
                            <div class="divTableCell">
                                <%----------------------   ---------------------------%>
                                <input type="text" class="form-control" id="howtoSolveTextbox12" runat="server" />
                            </div>
                        </div>
                        <div class="divTableRow">
                            <div class="divTableCell">&nbsp;13</div>
                            <div class="divTableCell">
                                <%---------------------- ---------------------------%>
                                <input type="text" class="form-control" id="problemTextbox13" runat="server" />
                            </div>
                            <div class="divTableCell">
                                <%----------------------  ---------------------------%>
                                <input type="text" class="form-control" id="howtoSolveTextbox13" runat="server" />
                            </div>
                        </div>
                        <div class="divTableRow">
                            <div class="divTableCell">&nbsp;14</div>
                            <div class="divTableCell">
                                <%----------------------  ---------------------------%>
                                <input type="text" class="form-control" id="problemTextbox14" runat="server" />
                            </div>
                            <div class="divTableCell">
                                <%----------------------  ---------------------------%>
                                <input type="text" class="form-control" id="howtoSolveTextbox14" runat="server" />
                            </div>
                        </div>
                        <div class="divTableRow">
                            <div class="divTableCell">&nbsp;15</div>
                            <div class="divTableCell">
                                <%-------------------------------------------------%>
                                <input type="text" class="form-control" id="problemTextbox15" runat="server" />
                            </div>
                            <div class="divTableCell">
                                <%---------------------- ---------------------------%>
                                <input type="text" class="form-control" id="howtoSolveTextbox15" runat="server" />
                            </div>
                        </div>
                    </div>
                </div>

               <%-- //////////////////////////////////  END Sectionid  = 136     /////////////////////////////////--%>








               <%-- //////////////////////////////////   Sectionid  = 137     /////////////////////////////////--%>
             <div class="row mt-3">
                    <div class="col-md-12 bg-primary text-white text-center">
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
                         
                                    <input type="text" class="form-control form-control-sm" id="toolsListTextbox1" runat="server" /></td>
                                <td>
                              
                                    <input type="text" class="form-control form-control-sm" id="serialNumberTextbox1" runat="server" /></td>
                                <td>
                                 
                                    <input type="text" class="form-control form-control-sm" id="newSerialNumberTextbox1" runat="server" /></td>
                                <td>
                                 
                                    <input type="text" class="form-control form-control-sm" id="noteTextbox1" runat="server" /></td>
                            </tr>
                            <tr>

                                <td>2</td>
                                <td>
                                  
                                    <input type="text" class="form-control form-control-sm" id="toolsListTextbox2" runat="server" /></td>
                                <td>
                         
                                    <input type="text" class="form-control form-control-sm" id="serialNumberTextbox2" runat="server" /></td>
                                <td>
                              
                                    <input type="text" class="form-control form-control-sm" id="newSerialNumberTextbox2" runat="server" /></td>
                                <td>
                                  
                                    <input type="text" class="form-control form-control-sm" id="noteTextbox2" runat="server" /></td>
                            </tr>
                            <tr>
                                <td>3</td>
                                <td>
                        
                                    <input type="text" class="form-control form-control-sm" id="toolsListTextbox3" runat="server" /></td>
                                <td>
                                
                                    <input type="text" class="form-control form-control-sm" id="serialNumberTextbox3" runat="server" /></td>
                                <td>
                                   
                                    <input type="text" class="form-control form-control-sm" id="newSerialNumberTextbox3" runat="server" /></td>
                                <td>
                                   
                                    <input type="text" class="form-control form-control-sm" id="noteTextbox3" runat="server" /></td>
                            </tr>
                            <tr>
                                <td>4</td>
                                <td>
                               
                                    <input type="text" class="form-control form-control-sm" id="toolsListTextbox4" runat="server" /></td>
                                <td>
                                 
                                    <input type="text" class="form-control form-control-sm" id="serialNumberTextbox4" runat="server" /></td>
                                <td>
                                  
                                    <input type="text" class="form-control form-control-sm" id="newSerialNumberTextbox4" runat="server" /></td>
                                <td>
                                    
                                    <input type="text" class="form-control form-control-sm" id="noteTextbox4" runat="server" /></td>
                            </tr>
                            <tr>
                                <td>5</td>
                                <td>
                               
                                    <input type="text" class="form-control form-control-sm" id="toolsListTextbox5" runat="server" /></td>
                                <td>
                                  
                                    <input type="text" class="form-control form-control-sm" id="serialNumberTextbox5" runat="server" /></td>
                                <td>
                                   
                                    <input type="text" class="form-control form-control-sm" id="newSerialNumberTextbox5" runat="server" /></td>
                                <td>
                                   
                                    <input type="text" class="form-control form-control-sm" id="noteTextbox5" runat="server" /></td>
                            </tr>
                            <tr>
                                <td>6</td>
                                <td>
                                  
                                    <input type="text" class="form-control form-control-sm" id="toolsListTextbox6" runat="server" /></td>
                                <td>
                                
                                    <input type="text" class="form-control form-control-sm" id="serialNumberTextbox6" runat="server" /></td>
                                <td>
                                    
                                    <input type="text" class="form-control form-control-sm" id="newSerialNumberTextbox6" runat="server" /></td>
                                <td>
                                    <%----------------------  ---------------------------%>
                                    <input type="text" class="form-control form-control-sm" id="noteTextbox6" runat="server" /></td>
                            </tr>
                            <tr>
                                <td>7</td>
                                <td>
                                    <%---------------------- ---------------------------%>
                                    <input type="text" class="form-control form-control-sm" id="toolsListTextbox7" runat="server" /></td>
                                <td>
                                    <%----------------------   ---------------------------%>
                                    <input type="text" class="form-control form-control-sm" id="serialNumberTextbox7" runat="server" /></td>
                                <td>
                                    <%----------------------  ---------------------------%>
                                    <input type="text" class="form-control form-control-sm" id="newSerialNumberTextbox7" runat="server" /></td>
                                <td>
                                    <%---------------------- --------------------------%>
                                    <input type="text" class="form-control form-control-sm" id="noteTextbox7" runat="server" /></td>
                            </tr>
                            <tr>
                                <td>8</td>
                                <td>
                                    <%--------------------- ---------------------------%>
                                    <input type="text" class="form-control form-control-sm" id="toolsListTextbox8" runat="server" /></td>
                                <td>
                                    <%-----------------------------------------------%>
                                    <input type="text" class="form-control form-control-sm" id="serialNumberTextbox8" runat="server" /></td>
                                <td>
                                    <%-----------------------------------------------%>
                                    <input type="text" class="form-control form-control-sm" id="newSerialNumberTextbox8" runat="server" /></td>
                                <td>
                                    <%------------------------------------------------%>
                                    <input type="text" class="form-control form-control-sm" id="noteTextbox8" runat="server" /></td>
                            </tr>
                            <tr>
                                <td>9</td>
                                <td>
                                    <%----------------------------------------------%>
                                    <input type="text" class="form-control form-control-sm" id="toolsListTextbox9" runat="server" /></td>
                                <td>
                                    <%----------------------------------------------%>
                                    <input type="text" class="form-control form-control-sm" id="serialNumberTextbox9" runat="server" /></td>
                                <td>
                                    <%-----------------------------------------------%>
                                    <input type="text" class="form-control form-control-sm" id="newSerialNumberTextbox9" runat="server" /></td>
                                <td>
                                    <%---------------------- -------------------------%>
                                    <input type="text" class="form-control form-control-sm" id="noteTextbox9" runat="server" /></td>
                            </tr>
                            <tr>
                                <td>10</td>
                                <td>
                                    <%-----------------------------------------------%>
                                    <input type="text" class="form-control form-control-sm" id="toolsListTextbox10" runat="server" /></td>
                                <td>
                                    <%-------------------------------------------------%>
                                    <input type="text" class="form-control form-control-sm" id="serialNumberTextbox10" runat="server" /></td>
                                <td>
                                    <%-----------------------------------------------%>
                                    <input type="text" class="form-control form-control-sm" id="newSerialNumberTextbox10" runat="server" /></td>
                                <td>
                                    <%-----------------------------------------------%>
                                    <input type="text" class="form-control form-control-sm" id="noteTextbox10" runat="server" /></td>
                            </tr>
                            <tr>
                                <td>11</td>
                                <td>
                                    <%---------------------------------------------%>
                                    <input type="text" class="form-control form-control-sm" id="toolsListTextbox11" runat="server" /></td>
                                <td>
                                    <%---------------------- --------------------------%>
                                    <input type="text" class="form-control form-control-sm" id="serialNumberTextbox11" runat="server" /></td>
                                <td>
                                    <%---------------------- --------------------------%>
                                    <input type="text" class="form-control form-control-sm" id="newSerialNumberTextbox11" runat="server" /></td>
                                <td>
                                    <%-----------------------------------------------%>
                                    <input type="text" class="form-control form-control-sm" id="noteTextbox11" runat="server" /></td>
                            </tr>
                            <tr>
                                <td>12</td>
                                <td>
                                    <%----------------------------------------------%>
                                    <input type="text" class="form-control form-control-sm" id="toolsListTextbox12" runat="server" /></td>
                                <td>
                                    <%--------------------------------------------%>
                                    <input type="text" class="form-control form-control-sm" id="serialNumberTextbox12" runat="server" /></td>
                                <td>
                                    <%-----------------------------------------------%>
                                    <input type="text" class="form-control form-control-sm" id="newSerialNumberTextbox12" runat="server" /></td>
                                <td>
                                    <%-------------------------------------------%>
                                    <input type="text" class="form-control form-control-sm" id="noteTextbox12" runat="server" /></td>
                            </tr>
                            <tr>
                                <td>13</td>
                                <td>
                                    <%------------------------------------------------%>
                                    <input type="text" class="form-control form-control-sm" id="toolsListTextbox13" runat="server" /></td>
                                <td>
                                    <%---------------------------------------------%>
                                    <input type="text" class="form-control form-control-sm" id="serialNumberTextbox13" runat="server" /></td>
                                <td>
                                    <%---------------------------------------------%>
                                    <input type="text" class="form-control form-control-sm" id="newSerialNumberTextbox13" runat="server" /></td>
                                <td>
                                    <%---------------------------------------------%>
                                    <input type="text" class="form-control form-control-sm" id="noteTextbox13" runat="server" /></td>
                            </tr>
                            <tr>
                                <td>14</td>
                                <td>
                                    <%----------------------------------------------%>
                                    <input type="text" class="form-control form-control-sm" id="toolsListTextbox14" runat="server" /></td>
                                <td>
                                    <%----------------------------------------------%>
                                    <input type="text" class="form-control form-control-sm" id="serialNumberTextbox14" runat="server" /></td>
                                <td>
                                    <%----------------------------------------------%>
                                    <input type="text" class="form-control form-control-sm" id="newSerialNumberTextbox14" runat="server" /></td>
                                <td>
                                    <%----------------------------------------------%>
                                    <input type="text" class="form-control form-control-sm" id="noteTextbox14" runat="server" /></td>
                            </tr>
                            <tr>
                                <td>15</td>
                                <td>
                                    <%------------------------------------------%>
                                    <input type="text" class="form-control form-control-sm" id="toolsListTextbox15" runat="server" /></td>
                                <td>
                                    <%----------------------------------------------%>
                                    <input type="text" class="form-control form-control-sm" id="serialNumberTextbox15" runat="server" /></td>
                                <td>
                                    <%-------------------------------------------%>
                                    <input type="text" class="form-control form-control-sm" id="newSerialNumberTextbox15" runat="server" /></td>
                                <td>
                                    <%-------------------------------------------%>
                                    <input type="text" class="form-control form-control-sm" id="noteTextbox15" runat="server" /></td>
                            </tr>
                        </tbody>
                    </table>

                </div>
                <%--////////////// --------------------- END  SECTION ID 137  ---------------------------  //////////////////--%>















              <%--////////////// ---------------------   SECTION ID 138   ---------------------------  //////////////////--%>
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
                    <input type="text" class="form-control" id="nameDopmTextbox" runat="server" />
                </div>

            </div>

            <div class="row mt-3">
                <div class="col-md-3 text-center">
                    <span>วันที่ทำ PM</span>
                </div>
                <div class="col-md-9">
                    <input type="text" class="form-control" id="dayDopmTextbox" runat="server" />
                </div>
            </div>
            
              <%--////////////// ---------------------   END SECTION ID 138   ---------------------------  //////////////////--%>




              <%--////////////// ---------------------    SECTION ID 139   ---------------------------  //////////////////--%>
            <div class="row mt-3">
                <div class="col-md-12 bg-success text-white text-center Myfont">
                    <h3>PICTURE CHECKLIST</h3>
                </div>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูปภาพรวมบริเวณ Site</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="steAreaRadio" value="PASS">PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="steAreaRadio" value="NOTPASS">NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูปหน้าตู้ ก่อน-หลัง</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="beforeAfterRadio" value="PASS">PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="beforeAfterRadio" value="NOTPASS">NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูปภายในตู้ ก่อน-หลัง</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="picIncontainRadio" value="PASS">PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="picIncontainRadio" value="NOTPASS">NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูปขณะทำความสะอาดตู้ ก่อน-หลัง</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="beforeCleanRaio" value="PASS">PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="beforeCleanRaio" value="NOTPASS">NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูปสถานะ Circuit Breaker (ON)</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="circuitBreakOnRaio" value="PASS">PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="circuitBreakOnRaio" value="NOTPASS">NOT PASS
                    </label>
                </div>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูป Circuit Breaker ภายในตู้</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="circuitInRadio" value="PASS">PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="circuitInRadio" value="NOTPASS">NOT PASS
                    </label>
                </div>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูป Terminal ต่อสายภายในตู้</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="terminalRaio" value="PASS">PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="terminalRaio" value="NOTPASS">NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูปการตรวจสอบ Ground และ Bar Ground</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="GroundAndBarGroundRaio" value="PASS">PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="GroundAndBarGroundRaio" value="NOTPASS">NOT PASS
                    </label>
                </div>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูปการตรวจสอบสถานะไฟฟ้ารั่วลง Ground (Lamp Test)</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="groundLampRadio" value="PASS">PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="groundLampRadio" value="NOTPASS">NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูป PEA Meter</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="peaMeterRaio" value="PASS">PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="peaMeterRaio" value="NOTPASS">NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูปการวัดแรงดัน AC และกระแส AC </label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="acAndACRadio" value="PASS">PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="acAndACRadio" value="NOTPASS">NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูปหน้าจอ UPS แสดงค่าต่างๆ และ Serial NO.  </label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="monitorSerRadio" value="PASS">PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="monitorSerRadio" value="NOTPASS">NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูป ONU/Modem พร้อม Serial NO. และ MAC </label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="ONUModemAndMacRadio" value="PASS">PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="ONUModemAndMacRadio" value="NOTPASS">NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูปการ Test Speed ONU (30/10 mbps) </label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="testSpeedOnuRadio" value="PASS">PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="testSpeedOnuRadio" value="NOTPASS">NOT PASS
                    </label>
                </div>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูปการ Test Network strength (>= -77.5 dBm) Section 1 </label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="pictestNetworkRadioSec1" value="PASS">PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="pictestNetworkRadioSec1" value="NOTPASS">NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูปการ Test Network strength (>= -77.5 dBm) Section 2</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="pictestNetworkRadioSec2" value="PASS">PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="pictestNetworkRadioSec2" value="NOTPASS">NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูปการ Test Network strength (>= -77.5 dBm) Section 3</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="pictestNetworkRadioSec3" value="PASS">PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="pictestNetworkRadioSec3" value="NOTPASS">NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูปการ Test Speed VSAT (30/5 mbps) *เฉพาะ SAT</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="testSpeedVsatRadio" value="PASS">PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="testSpeedVsatRadio" value="NOTPASS">NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูป Femto พร้อม Serial NO. และ MAC</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="femtoSerandMacRaio" value="PASS">PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="femtoSerandMacRaio" value="NOTPASS">NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูปการ Test Femto 3G (PSC 408-412)  </label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="testFemtoRadio" value="PASS">PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="testFemtoRadio" value="NOTPASS">NOT PASS
                    </label>
                </div>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูปการ Test Femto 4G (PCI 480-503) *เฉพาะ 4G </label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="testFemto4gRadio" value="PASS">PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="testFemto4gRadio" value="NOTPASS">NOT PASS
                    </label>
                </div>
            </div>

              <%--////////////// ---------------------  END  SECTION ID 139   ---------------------------  //////////////////--%>









              <%--////////////// ---------------------    SECTION ID 140   ---------------------------  //////////////////--%>
            <div class="row mt-3">
                <div class="col-md-12 bg-primary text-white text-center Myfont">
                    <h3>VSAT PICTURE CHECKLIST</h3>
                </div>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูปจุดติดตั้งจานดาวเทียม</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="inStallSatRadio" value="PASS">PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="inStallSatRadio" value="NOTPASS">NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูปความสะอาดบริเวณจานดาวเทียม</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="cleanSatRadio" value="PASS">PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="cleanSatRadio" value="NOTPASS">NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูป LNB พร้อม Part NO.</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="lnbWithpartRadio" value="PASS">PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="lnbWithpartRadio" value="NOTPASS">NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูป BUC พร้อม Part NO.</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="bucWithpartRadio" value="PASS">PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="bucWithpartRadio" value="NOTPASS">NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูปการเก็บสายและพันหัวที่ LNB/BUC</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="wireingLnbRadio" value="PASS">PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="wireingLnbRadio" value="NOTPASS">NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูปแนว Line Of Sight (ดูการถูกบังของหน้าจานดาวเทียม)</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="lineOfsightRadio" value="PASS">PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="lineOfsightRadio" value="NOTPASS">NOT PASS
                    </label>
                </div>
            </div>
            <%--////////////// --------------------- END   SECTION ID 140   ---------------------------  //////////////////--%>
            
            
            
            
            
               <%--////////////// ---------------------    SECTION ID 141   ---------------------------  //////////////////--%>
            <div class="row mt-3">
                <div class="col-md-12 bg-primary text-white text-center Myfont">
                    <h3>SOLAR CELL PICTURE CHECKLIST</h3>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูปจุดติดตั้ง Solar Cell</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="solarCellRadio" value="PASS" />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="solarCellRadio" value="NOTPASS" />NOT PASS
                    </label>
                </div>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูปอุปกรณ์ภายในตู้ Solar Cell</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="toolsinSolarcellRadio" value="PASS">PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="toolsinSolarcellRadio" value="NOTPASS">NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูปหน้าจอ Charger แสดงค่าต่างๆ</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="monitoringChargerRadio" value="PASS">PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="monitoringChargerRadio" value="NOTPASS">NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูปหน้าจอ Inverter แสดงค่าต่างๆ</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="moniteringInverterRadio" value="PASS">PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="moniteringInverterRadio" value="NOTPASS">NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูปความสะอาดแผง PV</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="cleaningPVRadio" value="PASS">PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="cleaningPVRadio" value="NOTPASS">NOT PASS
                    </label>
                </div>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูปภาพรวมดูสิ่งบดบังแสงอาทิตย์</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="sunRiseingRadio" value="PASS">PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="sunRiseingRadio" value="NOTPASS">NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูปการวัดแรงดัน Battery ก้อนที่ 1</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="batteryVoltRadio1" value="PASS">PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="batteryVoltRadio1" value="NOTPASS">NOT PASS
                    </label>
                </div>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูปการวัดแรงดัน Battery ก้อนที่ 2</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="batteryVoltRadio2" value="PASS">PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="batteryVoltRadio2" value="NOTPASS">NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูปการวัดแรงดัน Battery ก้อนที่ 3</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="batteryVoltRadio3" value="PASS">PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="batteryVoltRadio3" value="NOTPASS">NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูปการวัดแรงดัน Battery ก้อนที่ 4</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="batteryVoltRadio4" value="PASS" />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input"  name="batteryVoltRadio4" value="NOTPASS" />NOT PASS
                    </label>
                </div>
            </div>
   <%--////////////// --------------------- END   SECTION ID 141   ---------------------------  //////////////////--%>



        <%--////////////// ---------------------    SECTION ID 142   ---------------------------  //////////////////--%>
<%--            <div class="row mt-3">
                <div class="col-md-12  text-black text-center Myfont">
                    <h3>รูปภาพประกอบรายงาน</h3>
                </div>
                <div class="col-md-12 text-center mt-3 table-bordered">
                    <label>1.รูป PICTURE CHECKLIST</label>
                    <input type="file" class="form-control-file" id="">
                </div>

                <div class="col-md-12 text-center mt-3 table-bordered">
                    <label>2.รูป VSAT PICTURE CHECKLIST</label>
                    <input type="file" class="form-control-file" id="">
                </div>

                <div class="col-md-12 text-center mt-3 table-bordered">
                    <label>3.รูป SOLAR CELL PICTURE CHECKLISTT</label>
                    <input type="file" class="form-control-file" id="">
                </div>
            </div>--%>
       
                <div class="row mt-3 ">
                    <div class="col-sm-12">1.รูป PICTURE CHECKLIST </div>
                     <asp:FileUpload ID="pictureChecklistImages" runat="server" data-thumbnail="user_img_2" accept="image/" onchange="previewImage(this)" required="required" />
                
                </div>
                <div class="row ml-3 mt-3">
                    <img id="user_img_2" src="https://placehold.it/250x250" class="placeholder2" />
                </div>



         
                <div class="row mt-3">
                    <div class="col-sm-12">2.รูป VSAT PICTURE CHECKLIST</div>
                       <asp:FileUpload ID="vsatpictureChecklistImages" runat="server" data-thumbnail="user_img_3" accept="image/" onchange="previewImage(this)" required="required" />
                  
                </div>
                <div class="row ml-3 mt-3">
                    <img id="user_img_3" src="https://placehold.it/250x250" class="placeholder2" />
                </div>


          
                <div class="row mt-3">
                    <div class="col-sm-12">3.รูป SOLAR CELL PICTURE CHECKLIST</div>
                       <asp:FileUpload ID="solarcellpictureChecklistImages" runat="server" data-thumbnail="user_img_4" accept="image/" onchange="previewImage(this)" required="required" />

                </div>
                <div class="row ml-3 mt-3">
                    <img id="user_img_4" src="https://placehold.it/250x250" class="placeholder2" />
                </div>



        <%--////////////// ---------------------    END SECTION ID 142   ---------------------------  //////////////////--%>





            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />


            <div class="row">
                <asp:Button ID="SubmitButton" runat="server" Text="บันทึก" CssClass="btn btn-primary btn-block" OnClick="SubmitButton_Click" />
            </div>

            <br />
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


    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/bootstrap-datepicker/1.7.1/js/bootstrap-datepicker.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js" integrity="sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl" crossorigin="anonymous"></script>


    <script type="text/javascript">
        var input = $("#exampleFormControlFile1").change(function () {
            alert(this.value.split("\\").pop())
        })
    </script>


    <style type="text/css">
        .datepicker {
            font-size: 0.875em;
        }
            /* solution 2: the original datepicker use 20px so replace with the following:*/

            .datepicker td, .datepicker th {
                width: 1.5em;
                height: 1.5em;
            }

        // solution 2:
        .datepicker2 {
            font-size: 0.875em;
        }
        /* solution 2: the original datepicker use 20px so replace with the following:*/

        .datepicker2 td, .datepicker2 th {
            width: 1.5em;
            height: 1.5em;
        }
    </style>

    <%--  OLD RESOUCE--%>
    <%-- <script type="text/javascript">
            $('#datepicker').datepicker({
                weekStart: 1,
                daysOfWeekHighlighted: "6,0",
                autoclose: true,
                todayHighlight: true,
            });
            $('#datepicker').datepicker("setDate", new Date());
        </script>
        <script type="text/javascript">
            $('#datepicker2').datepicker2({
                weekStart: 1,
                daysOfWeekHighlighted: "6,0",
                autoclose: true,
                todayHighlight: true,
            });
            $('#datepicker2').datepicker2("setDate", new Date());
        </script>--%>

    <script type="text/javascript">
        $(function () {
            $('#startDate').datepicker({
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
    </script>

</body>
</html>