<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="USOform.PreventiveMaintenanceReportBBUSOWrap.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>รายงาน PM From BB Zone C+ บริการ USO Wrap</title>
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link href="~/style/Mystyle.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous" />
    <script src="previewImg.js"></script>

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
        <div class="container bg-white">
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
                <label class="control-label col-sm-1" for="">กลุ่ม :</label>
                <div class="col-sm-4">
                    <asp:TextBox ID="GroupNameTextBox" runat="server" CssClass="form-control" required="required"></asp:TextBox>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-1" for="">ภาค :</label>
                <div class="col-sm-4">
                    <input type="text" class="form-control" id="AreaTextbox" runat="server" required="required" />
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-1" for="">บริษัท :</label>
                <div class="col-sm-4">
                    <input type="text" class="form-control" id="CompanyTextbox" runat="server" required="required" />
                </div>
            </div>



            <div class="form-row mt-3">
                <label class="control-label col-sm-12" for="">ส่วนที่ 1 การจัดให้มีบริการอินเทอร์เน็ตความเร็วสูง (Broadband Internet Service) บริการ USO Wrap</label>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-2" for="">รอบการบำรุงรักษาครั้งที่</label>
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
                <label class="control-label col-sm-1" for="">Cabinet ID :</label>
                <div class="col-sm-11">
                    <input type="text" class="form-control" id="cabinetIdTextbox" runat="server" required="required" />
                </div>
            </div>

            <%-- QuestionId = 12,--%>
            <div class="form-row mt-3">
                <label class="control-label col-sm-1" for="">Site Code :</label>
                <div class="col-sm-11">
                    <input class="form-control" type="text" id="sitecodeTextboxSection2" runat="server" required="required" />
                </div>
            </div>

            <%-- QuestionId = 13,--%>
            <div class="form-row mt-3">
                <label class="control-label col-sm-1" for="">Village ID :</label>
                <div class="col-sm-11">
                    <input type="text" class="form-control" id="VillageIdTextbox" runat="server" required="required" />
                </div>
            </div>

            <%-- QuestionId = 14,--%>
            <div class="form-row mt-3">
                <label class="control-label col-sm-1" for="">Village :</label>
                <div class="col-sm-11">
                    <input type="text" class="form-control" id="villageTextbox" runat="server" required="required" />
                </div>
            </div>


            <%-- QuestionId = 15,--%>
            <div class="form-row mt-3">
                <label class="control-label col-sm-1" for="">School’s name :</label>
                <div class="col-sm-11">
                    <input type="text" class="form-control" id="schoolnameTextbox" runat="server" required="required" />
                </div>
            </div>

            <%-- QuestionId = 16,--%>
            <div class="form-row mt-3">
                <label class="control-label col-sm-1" for="">Sub-District :</label>
                <div class="col-sm-11">
                    <input type="text" class="form-control" id="subdistrictTextbox" runat="server" required="required" />
                </div>
            </div>

            <%-- QuestionId = 17,--%>
            <div class="form-row mt-3">
                <label class="control-label col-sm-1" for="">Province :</label>
                <div class="col-sm-11">
                    <input type="text" class="form-control" id="provinceTextbox" runat="server" required="required" />
                </div>
            </div>

            <%-- QuestionId = 18,--%>
            <div class="form-row mt-3">
                <label class="control-label col-sm-1" for="">Type :</label>
                <div class="col-sm-11">
                    <input type="text" class="form-control" id="typeTextbox" runat="server" required="required" />
                </div>
            </div>


            <%-- QuestionId = 19,--%>
            <div class="form-row mt-3">
                <label class="control-label col-sm-1" for="">PM Date : </label>
                <div class="col-sm-11">
                    <input type="text" class="form-control" id="pmdateTextbox" runat="server" required="required" />
                </div>
            </div>


            <%-- QuestionId = 6, --%>
            <div class="row mt-3">
                <div class="col-sm-12 bg-primary text-white">ใส่ป้ายหน้าโรงเรียน</div>

                <asp:FileUpload ID="signboardschoolImage" runat="server" data-thumbnail="user_img_0" accept="image/*" onchange="previewImage(this)" required="required" />

                <%--    OLD RESOUCE    <input type="file" name="image0" onchange="previewImage(this)" accept="image/*" data-thumbnail="user_img_0" />--%>
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
                    <label class="control-label col-sm-1" for="">Location Name</label>
                    <div class="col-sm-11">
                        <input type="email" class="form-control" id="" name="">
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-1" for="">Site Code</label>
                    <div class="col-sm-11">
                        <input type="email" class="form-control" id="" name="">
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-1" for="">Village ID</label>
                    <div class="col-sm-11">
                        <input type="email" class="form-control" id="" name="">
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-1" for="">LAT & LONG</label>
                    <div class="col-sm-11">
                        <input type="email" class="form-control" id="" name="">
                    </div>
                </div>

                <div class="form-row mt-3">

                    <label class="control-label col-sm-2" for="">Type of Signal</label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="radio2">
                            <input type="radio" class="form-check-input" id="radio2" name="optradio" value="option2">OFC
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="radio3">
                            <input type="radio" class="form-check-input" id="radio3" name="optradio" value="option3">Satellite
                        </label>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-2" for="">ISP (Existing Network)</label>
                    <div class="col-sm-10">
                        <input type="email" class="form-control" id="" name="">
                    </div>
                </div>
                  <%--////////////// -------------END  SECTION ID 4-----------------  //////////////////--%>










  <%--////////////// -------------END  SECTION ID 5-----------------  //////////////////--%>
                <div class="row mt-3">
                    <div class="col-md-12 bg-primary text-white text-center Myfont">
                        <h3>2. ระบบไฟฟ้า (หลัก)</h3>
                    </div>
                </div>

                <div class="form-row mt-3">

                    <label class="control-label col-sm-2" for="">ระบบไฟฟ้า</label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="radio2">
                            <input type="radio" class="form-check-input" id="radio2" name="optradio" value="option2">PEA
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="radio3">
                            <input type="radio" class="form-check-input" id="radio3" name="optradio" value="option3">Solar Cell
                        </label>
                    </div>
                </div>

                <div class="form-row mt-3">

                    <label class="control-label col-sm-2" for="">หม้อแปลงไฟฟ้า</label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="radio2">
                            <input type="radio" class="form-check-input" id="radio2" name="optradio" value="option2">1 Phase
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="radio3">
                            <input type="radio" class="form-check-input" id="radio3" name="optradio" value="option3">3 Phase
                        </label>
                    </div>
                </div>


                <div class="form-row mt-3">
                    <label class="control-label col-sm-2" for="">หมายเลขผู้ใช้ไฟ</label>
                    <div class="col-sm-10">
                        <input type="email" class="form-control" id="" name="">
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-2" for="">หน่วยใช้ไฟ (kWh Meter)</label>
                    <div class="col-sm-8">
                        <input type="email" class="form-control" id="" name="">
                    </div>
                    <label class="control-label col-sm-2" for="">kWh</label>
                </div>


                <div class="form-row mt-3">
                    <label class="control-label col-sm-2" for="">แรงดัน AC (kWh Meter)</label>
                    <div class="col-sm-8">
                        <input type="email" class="form-control" id="" name="">
                    </div>
                    <label class="control-label col-sm-2" for="">V.</label>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-2" for="">กระแส Line AC (kWh Meter)</label>
                    <div class="col-sm-8">
                        <input type="email" class="form-control" id="" name="">
                    </div>
                    <label class="control-label col-sm-2" for="">A.</label>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-2" for="">กระแส Neutron AC (kWh Meter)</label>
                    <div class="col-sm-8">
                        <input type="email" class="form-control" id="" name="">
                    </div>
                    <label class="control-label col-sm-2" for="">A.</label>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-2" for="">สภาพ kWh Meter</label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">ชำรุด/ใช้งานไม่ได้
                        </label>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-2" for="">สภาพ MDB/ Circuit Breaker</label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">ชำรุด/ใช้งานไม่ได้
                        </label>
                    </div>
                </div>

                <div class="row mt-3">
                    <div class="col-md-12 bg-primary text-white text-center Myfont">
                        <h3>3. ระบบไฟ (สำรอง)</h3>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-2" for="">UPS ภายในตู้</label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">มี
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">ไม่มี
                        </label>
                    </div>
                </div>


                <div class="form-row mt-3">
                    <label class="control-label col-sm-2" for="">แรงดัน AC จาก UPS</label>
                    <div class="col-sm-8">
                        <input type="email" class="form-control" id="" name="">
                    </div>
                    <label class="control-label col-sm-2" for="">V.</label>
                </div>


                <div class="form-row mt-3">
                    <label class="control-label col-sm-2" for="">กระแส Load</label>
                    <div class="col-sm-8">
                        <input type="email" class="form-control" id="" name="">
                    </div>
                    <label class="control-label col-sm-2" for="">A.</label>
                </div>
                <%--                ezsample--%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-2" for="">UPS MODE</label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="upsModeRadio" value="LINE" required="required">LINE
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="upsModeRadio" value="BATT." required="required">BATT.
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="upsModeRadio" value="BYPASS" required="required">BYPASS
                        </label>
                    </div>
                </div>




                <div class="form-row mt-3">
                    <label class="control-label col-sm-2" for="">การทำงานของระบบไฟสำรอง</label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">ปกติ
                        </label>
                    </div>

                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">ชำรุด/ใช้งานไม่ได้
                        </label>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-2" for="">สภาพ Battery Bank</label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">ปกติ
                        </label>
                    </div>

                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">ชำรุด/ใช้งานไม่ได้
                        </label>
                    </div>
                </div>

                <div class="row mt-3">
                    <div class="col-md-12 bg-primary text-white text-center Myfont">
                        <h3>4. รายละเอียดอุปกรณ์ Network ภายในตู้</h3>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-2" for="">ONU/Modem Network</label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">TOT
                        </label>
                    </div>

                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">TRUE
                        </label>
                    </div>

                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">3BB
                        </label>
                    </div>

                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">Satellite
                        </label>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-2" for="">Switch 8 Port</label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">ปกติ
                        </label>
                    </div>

                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">ชำรุด/ใช้งานไม่ได้
                        </label>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-2" for="">Switch 48 Port</label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">ปกติ
                        </label>
                    </div>

                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">ชำรุด/ใช้งานไม่ได้
                        </label>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-2" for="">Outdoor AP ตัวที่ 1</label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">ปกติ
                        </label>
                    </div>

                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">ชำรุด/ใช้งานไม่ได้
                        </label>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-2" for="">Outdoor AP ตัวที่ 2</label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">ปกติ
                        </label>
                    </div>

                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">ชำรุด/ใช้งานไม่ได้
                        </label>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-2" for="">Indoor AP ตัวที่ 1</label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">ปกติ
                        </label>
                    </div>

                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">ชำรุด/ใช้งานไม่ได้
                        </label>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-2" for="">Indoor AP ตัวที่ 2</label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">ปกติ
                        </label>
                    </div>

                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">ชำรุด/ใช้งานไม่ได้
                        </label>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-2" for="">การ Wiring สายไฟ</label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">เรียบร้อย
                        </label>
                    </div>

                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">ไม่เรียบร้อย
                        </label>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-2" for="">การ Wiring Patch cord และ สาย LAN</label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">เรียบร้อย
                        </label>
                    </div>

                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">ไม่เรียบร้อย
                        </label>
                    </div>
                </div>





                <div class="row mt-3">
                    <div class="col-md-12 bg-success text-white text-center Myfont">
                        <h3>5. ระบบ Ground</h3>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-4" for="">ความแข็งแรงจุดต่อ Ground Bar</label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">ชำรุด
                        </label>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-4" for="">ความแข็งแรงของน็อตขันหางปลาอุปกรณ์</label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">ชำรุด
                        </label>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-4" for="">สายกราวด์เรียบร้อย ปลอดภัย สมบูรณ์</label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">ชำรุด
                        </label>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-4" for="">สถานะไฟฟ้ารั่วลง Ground</label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">ไม่พบไฟฟ้ารั่ว
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">พบไฟฟ้ารั่ว
                        </label>
                    </div>
                </div>

                <div class="row mt-3">
                    <div class="col-md-12 bg-success text-white text-center Myfont">
                        <h3>6. ระบบความปลอดภัยและเตือนภัย</h3>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-4" for="">Fire Alarm และ Smoke Detector</label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">ชำรุด/ใช้งานไม่ได้
                        </label>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-4" for="">Fire Alarm Manual Switch</label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">ชำรุด/ใช้งานไม่ได้
                        </label>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-2" for="">Battery Fire Alarm ก้อนที่ 1</label>
                    <div class="col-sm-8">
                        <input type="email" class="form-control" id="" name="">
                    </div>
                    <label class="control-label col-sm-2" for="">V.</label>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-2" for="">Battery Fire Alarm ก้อนที่ 2</label>
                    <div class="col-sm-8">
                        <input type="email" class="form-control" id="" name="">
                    </div>
                    <label class="control-label col-sm-2" for="">V.</label>
                </div>


                <div class="form-row mt-3">
                    <label class="control-label col-sm-4" for="">ไฟแสงสว่างฉุกเฉิน</label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">ชำรุด/ใช้งานไม่ได้
                        </label>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-4" for="">ระบบ Monitor กล้องวงจรปิด</label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">ไม่สามารถ Monitor ได้
                        </label>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-4" for="">กล้องวงจรปิดห้อง Computer</label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">ชำรุด
                        </label>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-4" for="">กล้องวงจรปิดภายนอกอาคาร 1</label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">ชำรุด
                        </label>
                    </div>
                </div>


                <div class="form-row mt-3">
                    <label class="control-label col-sm-4" for="">กล้องวงจรปิดภายนอกอาคาร 2</label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">ชำรุด
                        </label>
                    </div>
                </div>

                <div class="row mt-3">
                    <div class="col-md-12 bg-primary text-white text-center Myfont">
                        <h3>7. ระบบสารสนเทศ</h3>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-4" for="">จอทีวีห้องประชุม</label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">ชำรุด/ใช้งานไม่ได้
                        </label>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-4" for="">คอมพิวเตอร์เจ้าหน้าที่ศูนย์</label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">ชำรุด/ใช้งานไม่ได้
                        </label>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-4" for="">Printer</label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">ชำรุด/ใช้งานไม่ได้
                        </label>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-4" for="">คอมพิวเตอร์ตัวที่ 1</label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">ชำรุด/ใช้งานไม่ได้
                        </label>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-4" for="">คอมพิวเตอร์ตัวที่ 2</label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">ชำรุด/ใช้งานไม่ได้
                        </label>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-4" for="">คอมพิวเตอร์ตัวที่ 3</label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">ชำรุด/ใช้งานไม่ได้
                        </label>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-4" for="">คอมพิวเตอร์ตัวที่ 4</label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">ชำรุด/ใช้งานไม่ได้
                        </label>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-4" for="">คอมพิวเตอร์ตัวที่ 5</label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">ชำรุด/ใช้งานไม่ได้
                        </label>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-4" for="">คอมพิวเตอร์ตัวที่ 6</label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">ชำรุด/ใช้งานไม่ได้
                        </label>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-4" for="">คอมพิวเตอร์ตัวที่ 7</label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">ชำรุด/ใช้งานไม่ได้
                        </label>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-4" for="">คอมพิวเตอร์ตัวที่ 8</label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">ชำรุด/ใช้งานไม่ได้
                        </label>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-4" for="">คอมพิวเตอร์ตัวที่ 9</label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">ชำรุด/ใช้งานไม่ได้
                        </label>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-4" for="">คอมพิวเตอร์ตัวที่ 10</label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">ชำรุด/ใช้งานไม่ได้
                        </label>
                    </div>
                </div>



                <%-- SECTION 8--%>
                <div class="row mt-3">
                    <div class="col-md-12 bg-primary text-white text-center Myfont">
                        <h3>8. ระบบเครื่องปรับอากาศและระบายอากาศ</h3>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-4" for="">เครื่องปรับอากาศ 2</label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">ชำรุด/ใช้งานไม่ได้
                        </label>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-4" for="">เครื่องปรับอากาศ 2</label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">ชำรุด/ใช้งานไม่ได้
                        </label>
                    </div>
                </div>



                <div class="row mt-3">
                    <div class="col-md-12 bg-primary text-white text-center Myfont">
                        <h3>9.อาคาร</h3>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-2" for="">ความสะอาดภายในห้อง</label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="radio2">
                            <input type="radio" class="form-check-input" id="radio2" name="optradio" value="option2">สะอาด
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="radio3">
                            <input type="radio" class="form-check-input" id="radio3" name="optradio" value="option3">ไม่สะอาด/ไม่เรียบร้อย
                        </label>
                    </div>
                </div>





                <div class="row mt-3">
                    <div class="col-md-12 bg-primary text-white text-center Myfont">
                        <h3>9. อาคาร (ต่อ)</h3>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-2" for="">ความสะอาดรอบห้องภายนอก</label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="radio2">
                            <input type="radio" class="form-check-input" id="radio2" name="optradio" value="option2">สะอาด
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="radio3">
                            <input type="radio" class="form-check-input" id="radio3" name="optradio" value="option3">ไม่สะอาด/ไม่เรียบร้อย
                        </label>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-2" for="">ประตูห้อง</label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="radio2">
                            <input type="radio" class="form-check-input" id="radio2" name="optradio" value="option2">ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="radio3">
                            <input type="radio" class="form-check-input" id="radio3" name="optradio" value="option3">ชำรุด
                        </label>
                    </div>
                </div>




                <div class="row mt-3">
                    <div class="col-md-12 bg-primary text-white text-center Myfont">
                        <h3>10.อุปกรณ์ระบบ VSAT (เฉพาะศูนย์ที่เป็น VSAT)</h3>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-4" for="">อุปกรณ์ LNB/BUC</label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">ชำรุด/ใช้งานไม่ได้
                        </label>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-4" for="">การเก็บสาย RG และการพันหัว</label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">ไม่เรียบร้อย/ไม่แน่น
                        </label>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-4" for="">ฐานและระดับของเสาจาน</label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">ไม่ได้ระดับ/เอียง
                        </label>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-4" for="">แนว Line Of Sight</label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">โดนบัง
                        </label>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-4" for="">ความสะอาดของหน้าจาน</label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">สกปรก
                        </label>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-4" for="">LNB Band Switch</label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">HIGH BAND
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">LOW BAND
                        </label>
                    </div>
                </div>

                <div class="row mt-3">
                    <div class="col-md-12 bg-primary text-white text-center Myfont">
                        <h3>11.อุปกรณ์ระบบ Solar Cell (เฉพาะศูนย์ที่ใช้ Solar Cell)</h3>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-4" for="">ระบบ Solar Cell</label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">ชำรุด/ใช้งานไม่ได้
                        </label>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-4" for="">แผง PV Panel</label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">ชำรุด/ใช้งานไม่ได้
                        </label>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-4" for="">อุปกรณ์ Charger</label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">ชำรุด/ใช้งานไม่ได้
                        </label>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-4" for="">ความสะอาดแผง PV</label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">สกปรก
                        </label>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-4" for="">การติดตั้งแผง PV</label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">ที่โล่งรับแดดปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">มีอาคาร/ต้นไม้บัง
                        </label>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-2" for="">แรงดันไฟจาก Inverter</label>
                    <div class="col-sm-8">
                        <input type="email" class="form-control" id="" name="">
                    </div>
                    <label class="control-label col-sm-2" for="">V.</label>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-2" for="">กระแส Load</label>
                    <div class="col-sm-8">
                        <input type="email" class="form-control" id="" name="">
                    </div>
                    <label class="control-label col-sm-2" for="">A.</label>
                </div>




                <div class="row mt-3">
                    <div class="col-md-12 bg-primary text-white text-center Myfont">
                        <h3>12. คุณภาพของสัญญาณ</h3>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-2" for="">Download (for ONU/VSAT)</label>
                    <div class="col-sm-8">
                        <input type="email" class="form-control" id="" name="">
                    </div>
                    <label class="control-label col-sm-2" for="">Mb/s</label>
                </div>


                <div class="form-row mt-3">
                    <label class="control-label col-sm-2" for="">Upload (for ONU/VSAT)</label>
                    <div class="col-sm-8">
                        <input type="email" class="form-control" id="" name="">
                    </div>
                    <label class="control-label col-sm-2" for="">Mb/s</label>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-2" for="">Ping Test (for ONU/VSAT)</label>
                    <div class="col-sm-8">
                        <input type="email" class="form-control" id="" name="">
                    </div>
                    <label class="control-label col-sm-2" for="">ms</label>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-2" for="">Download (for WIFI)</label>
                    <div class="col-sm-8">
                        <input type="email" class="form-control" id="" name="">
                    </div>
                    <label class="control-label col-sm-2" for="">Mb/s</label>
                </div>


                <div class="form-row mt-3">
                    <label class="control-label col-sm-2" for="">Upload (for WIFI)</label>
                    <div class="col-sm-8">
                        <input type="email" class="form-control" id="" name="">
                    </div>
                    <label class="control-label col-sm-2" for="">Mb/s</label>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-2" for="">Ping Test (for WIFI)</label>
                    <div class="col-sm-8">
                        <input type="email" class="form-control" id="" name="">
                    </div>
                    <label class="control-label col-sm-2" for="">ms</label>
                </div>


                <div class="form-row mt-3">
                    <label class="control-label col-sm-2" for="">Download (for LAN)</label>
                    <div class="col-sm-8">
                        <input type="email" class="form-control" id="" name="">
                    </div>
                    <label class="control-label col-sm-2" for="">Mb/s</label>
                </div>


                <div class="form-row mt-3">
                    <label class="control-label col-sm-2" for="">Upload (for LAN)</label>
                    <div class="col-sm-8">
                        <input type="email" class="form-control" id="" name="">
                    </div>
                    <label class="control-label col-sm-2" for="">Mb/s</label>
                </div>


                <div class="form-row mt-3">
                    <label class="control-label col-sm-2" for="">Ping Test  (for LAN)</label>
                    <div class="col-sm-8">
                        <input type="email" class="form-control" id="" name="">
                    </div>
                    <label class="control-label col-sm-2" for="">ms</label>
                </div>



                <div class="row mt-3">
                    <div class="col-md-12 bg-primary text-white text-center Myfont">
                        <h3>13. ปัญหาที่พบและการแก้ไข</h3>
                    </div>
                </div>

                <div class="row mt-3">
                    <div class="col-md-1 text-center">
                        <span>ลำดับ</span>
                    </div>
                    <div class="col-md-4 text-center">
                        <span>ปัญหาที่พบ</span>
                    </div>
                    <div class="col-md-7 text-center">
                        <span>แนวทางการแก้ไข</span>
                    </div>
                </div>

                <div class="row mt-3">
                    <div class="col-md-1 text-center">
                        <span>1</span>
                    </div>
                    <div class="col-md-5 text-center">
                        <input type="text" class="form-control" id="" name="">
                    </div>
                    <div class="col-md-6 text-center">
                        <input type="text" class="form-control" id="" name="">
                    </div>
                </div>


                <div class="row mt-3">
                    <div class="col-md-1 text-center">
                        <span>2</span>
                    </div>
                    <div class="col-md-5 text-center">
                        <input type="text" class="form-control" id="" name="">
                    </div>
                    <div class="col-md-6 text-center">
                        <input type="text" class="form-control" id="" name="">
                    </div>
                </div>


                <div class="row mt-3">
                    <div class="col-md-1 text-center">
                        <span>3</span>
                    </div>
                    <div class="col-md-5 text-center">
                        <input type="text" class="form-control" id="" name="">
                    </div>
                    <div class="col-md-6 text-center">
                        <input type="text" class="form-control" id="" name="">
                    </div>
                </div>


                <div class="row mt-3">
                    <div class="col-md-1 text-center">
                        <span>4</span>
                    </div>
                    <div class="col-md-5 text-center">
                        <input type="text" class="form-control" id="" name="">
                    </div>
                    <div class="col-md-6 text-center">
                        <input type="text" class="form-control" id="" name="">
                    </div>
                </div>


                <div class="row mt-3">
                    <div class="col-md-1 text-center">
                        <span>5</span>
                    </div>
                    <div class="col-md-5 text-center">
                        <input type="text" class="form-control" id="" name="">
                    </div>
                    <div class="col-md-6 text-center">
                        <input type="text" class="form-control" id="" name="">
                    </div>
                </div>


                <div class="row mt-3">
                    <div class="col-md-1 text-center">
                        <span>6</span>
                    </div>
                    <div class="col-md-5 text-center">
                        <input type="text" class="form-control" id="" name="">
                    </div>
                    <div class="col-md-6 text-center">
                        <input type="text" class="form-control" id="" name="">
                    </div>
                </div>


                <div class="row mt-3">
                    <div class="col-md-1 text-center">
                        <span>7</span>
                    </div>
                    <div class="col-md-5 text-center">
                        <input type="text" class="form-control" id="" name="">
                    </div>
                    <div class="col-md-6 text-center">
                        <input type="text" class="form-control" id="" name="">
                    </div>
                </div>

                <div class="row mt-3">
                    <div class="col-md-1 text-center">
                        <span>8</span>
                    </div>
                    <div class="col-md-5 text-center">
                        <input type="text" class="form-control" id="" name="">
                    </div>
                    <div class="col-md-6 text-center">
                        <input type="text" class="form-control" id="" name="">
                    </div>
                </div>


                <div class="row mt-3">
                    <div class="col-md-1 text-center">
                        <span>9</span>
                    </div>
                    <div class="col-md-5 text-center">
                        <input type="text" class="form-control" id="" name="">
                    </div>
                    <div class="col-md-6 text-center">
                        <input type="text" class="form-control" id="" name="">
                    </div>
                </div>


                <div class="row mt-3">
                    <div class="col-md-1 text-center">
                        <span>10</span>
                    </div>
                    <div class="col-md-5 text-center">
                        <input type="text" class="form-control" id="" name="">
                    </div>
                    <div class="col-md-6 text-center">
                        <input type="text" class="form-control" id="" name="">
                    </div>
                </div>

                <div class="row mt-3">
                    <div class="col-md-1 text-center">
                        <span>11</span>
                    </div>
                    <div class="col-md-5 text-center">
                        <input type="text" class="form-control" id="" name="">
                    </div>
                    <div class="col-md-6 text-center">
                        <input type="text" class="form-control" id="" name="">
                    </div>
                </div>

                <div class="row mt-3">
                    <div class="col-md-1 text-center">
                        <span>12</span>
                    </div>
                    <div class="col-md-5 text-center">
                        <input type="text" class="form-control" id="" name="">
                    </div>
                    <div class="col-md-6 text-center">
                        <input type="text" class="form-control" id="" name="">
                    </div>
                </div>

                <div class="row mt-3">
                    <div class="col-md-1 text-center">
                        <span>13</span>
                    </div>
                    <div class="col-md-5 text-center">
                        <input type="text" class="form-control" id="" name="">
                    </div>
                    <div class="col-md-6 text-center">
                        <input type="text" class="form-control" id="" name="">
                    </div>
                </div>

                <div class="row mt-3">
                    <div class="col-md-1 text-center">
                        <span>14</span>
                    </div>
                    <div class="col-md-5 text-center">
                        <input type="text" class="form-control" id="" name="">
                    </div>
                    <div class="col-md-6 text-center">
                        <input type="text" class="form-control" id="" name="">
                    </div>
                </div>

                <div class="row mt-3">
                    <div class="col-md-1 text-center">
                        <span>15</span>
                    </div>
                    <div class="col-md-5 text-center">
                        <input type="text" class="form-control" id="" name="">
                    </div>
                    <div class="col-md-6 text-center">
                        <input type="text" class="form-control" id="" name="">
                    </div>
                </div>


                <div class="row mt-3">
                    <div class="col-md-12 bg-primary text-white text-center Myfont">
                        <h3>14.ข้อมูลรายการทรัพย์สิน</h3>
                    </div>
                </div>


                <div class="row mt-3">
                    <div class="col-md-1 text-center">
                        <span>ลำดับ</span>
                    </div>
                    <div class="col-md-3 text-center">
                        <span>รายการอุปกรณ์</span>
                    </div>
                    <div class="col-md-3 text-center">
                        <span>Serial Number</span>
                    </div>
                    <div class="col-md-3 text-center">
                        <span>Serial Number ใหม่</span>
                    </div>
                    <div class="col-md-2 text-center">
                        <span>หมายเหตุ</span>
                    </div>
                </div>

                <div class="row mt-3">
                    <div class="col-md-1 text-center">
                        <span>1</span>
                    </div>
                    <div class="col-md-3 text-center">
                        <input type="text" class="form-control" id="" name="">
                    </div>
                    <div class="col-md-3 text-center">
                        <input type="text" class="form-control" id="" name="">
                    </div>
                    <div class="col-md-3 text-center">
                        <input type="text" class="form-control" id="" name="">
                    </div>
                    <div class="col-md-2 text-center">
                        <input type="text" class="form-control" id="" name="">
                    </div>
                </div>


                <div class="row mt-3">
                    <div class="col-md-1 text-center">
                        <span>2</span>
                    </div>
                    <div class="col-md-3 text-center">
                        <input type="text" class="form-control" id="" name="">
                    </div>
                    <div class="col-md-3 text-center">
                        <input type="text" class="form-control" id="" name="">
                    </div>
                    <div class="col-md-3 text-center">
                        <input type="text" class="form-control" id="" name="">
                    </div>
                    <div class="col-md-2 text-center">
                        <input type="text" class="form-control" id="" name="">
                    </div>
                </div>


                <div class="row mt-3">
                    <div class="col-md-1 text-center">
                        <span>3</span>
                    </div>
                    <div class="col-md-3 text-center">
                        <input type="text" class="form-control" id="" name="">
                    </div>
                    <div class="col-md-3 text-center">
                        <input type="text" class="form-control" id="" name="">
                    </div>
                    <div class="col-md-3 text-center">
                        <input type="text" class="form-control" id="" name="">
                    </div>
                    <div class="col-md-2 text-center">
                        <input type="text" class="form-control" id="" name="">
                    </div>
                </div>


                <div class="row mt-3">
                    <div class="col-md-1 text-center">
                        <span>4</span>
                    </div>
                    <div class="col-md-3 text-center">
                        <input type="text" class="form-control" id="" name="">
                    </div>
                    <div class="col-md-3 text-center">
                        <input type="text" class="form-control" id="" name="">
                    </div>
                    <div class="col-md-3 text-center">
                        <input type="text" class="form-control" id="" name="">
                    </div>
                    <div class="col-md-2 text-center">
                        <input type="text" class="form-control" id="" name="">
                    </div>
                </div>


                <div class="row mt-3">
                    <div class="col-md-1 text-center">
                        <span>5</span>
                    </div>
                    <div class="col-md-3 text-center">
                        <input type="text" class="form-control" id="" name="">
                    </div>
                    <div class="col-md-3 text-center">
                        <input type="text" class="form-control" id="" name="">
                    </div>
                    <div class="col-md-3 text-center">
                        <input type="text" class="form-control" id="" name="">
                    </div>
                    <div class="col-md-2 text-center">
                        <input type="text" class="form-control" id="" name="">
                    </div>
                </div>


                <div class="row mt-3">
                    <div class="col-md-1 text-center">
                        <span>6</span>
                    </div>
                    <div class="col-md-3 text-center">
                        <input type="text" class="form-control" id="" name="">
                    </div>
                    <div class="col-md-3 text-center">
                        <input type="text" class="form-control" id="" name="">
                    </div>
                    <div class="col-md-3 text-center">
                        <input type="text" class="form-control" id="" name="">
                    </div>
                    <div class="col-md-2 text-center">
                        <input type="text" class="form-control" id="" name="">
                    </div>
                </div>


                <div class="row mt-3">
                    <div class="col-md-1 text-center">
                        <span>7</span>
                    </div>
                    <div class="col-md-3 text-center">
                        <input type="text" class="form-control" id="" name="">
                    </div>
                    <div class="col-md-3 text-center">
                        <input type="text" class="form-control" id="" name="">
                    </div>
                    <div class="col-md-3 text-center">
                        <input type="text" class="form-control" id="" name="">
                    </div>
                    <div class="col-md-2 text-center">
                        <input type="text" class="form-control" id="" name="">
                    </div>
                </div>


                <div class="row mt-3">
                    <div class="col-md-1 text-center">
                        <span>8</span>
                    </div>
                    <div class="col-md-3 text-center">
                        <input type="text" class="form-control" id="" name="">
                    </div>
                    <div class="col-md-3 text-center">
                        <input type="text" class="form-control" id="" name="">
                    </div>
                    <div class="col-md-3 text-center">
                        <input type="text" class="form-control" id="" name="">
                    </div>
                    <div class="col-md-2 text-center">
                        <input type="text" class="form-control" id="" name="">
                    </div>
                </div>


                <div class="row mt-3">
                    <div class="col-md-1 text-center">
                        <span>9</span>
                    </div>
                    <div class="col-md-3 text-center">
                        <input type="text" class="form-control" id="" name="">
                    </div>
                    <div class="col-md-3 text-center">
                        <input type="text" class="form-control" id="" name="">
                    </div>
                    <div class="col-md-3 text-center">
                        <input type="text" class="form-control" id="" name="">
                    </div>
                    <div class="col-md-2 text-center">
                        <input type="text" class="form-control" id="" name="">
                    </div>
                </div>


                <div class="row mt-3">
                    <div class="col-md-1 text-center">
                        <span>10</span>
                    </div>
                    <div class="col-md-3 text-center">
                        <input type="text" class="form-control" id="" name="">
                    </div>
                    <div class="col-md-3 text-center">
                        <input type="text" class="form-control" id="" name="">
                    </div>
                    <div class="col-md-3 text-center">
                        <input type="text" class="form-control" id="" name="">
                    </div>
                    <div class="col-md-2 text-center">
                        <input type="text" class="form-control" id="" name="">
                    </div>
                </div>


                <div class="row mt-3">
                    <div class="col-md-1 text-center">
                        <span>11</span>
                    </div>
                    <div class="col-md-3 text-center">
                        <input type="text" class="form-control" id="" name="">
                    </div>
                    <div class="col-md-3 text-center">
                        <input type="text" class="form-control" id="" name="">
                    </div>
                    <div class="col-md-3 text-center">
                        <input type="text" class="form-control" id="" name="">
                    </div>
                    <div class="col-md-2 text-center">
                        <input type="text" class="form-control" id="" name="">
                    </div>
                </div>


                <div class="row mt-3">
                    <div class="col-md-1 text-center">
                        <span>12</span>
                    </div>
                    <div class="col-md-3 text-center">
                        <input type="text" class="form-control" id="" name="">
                    </div>
                    <div class="col-md-3 text-center">
                        <input type="text" class="form-control" id="" name="">
                    </div>
                    <div class="col-md-3 text-center">
                        <input type="text" class="form-control" id="" name="">
                    </div>
                    <div class="col-md-2 text-center">
                        <input type="text" class="form-control" id="" name="">
                    </div>
                </div>


                <div class="row mt-3">
                    <div class="col-md-1 text-center">
                        <span>13</span>
                    </div>
                    <div class="col-md-3 text-center">
                        <input type="text" class="form-control" id="" name="">
                    </div>
                    <div class="col-md-3 text-center">
                        <input type="text" class="form-control" id="" name="">
                    </div>
                    <div class="col-md-3 text-center">
                        <input type="text" class="form-control" id="" name="">
                    </div>
                    <div class="col-md-2 text-center">
                        <input type="text" class="form-control" id="" name="">
                    </div>
                </div>


                <div class="row mt-3">
                    <div class="col-md-1 text-center">
                        <span>14</span>
                    </div>
                    <div class="col-md-3 text-center">
                        <input type="text" class="form-control" id="" name="">
                    </div>
                    <div class="col-md-3 text-center">
                        <input type="text" class="form-control" id="" name="">
                    </div>
                    <div class="col-md-3 text-center">
                        <input type="text" class="form-control" id="" name="">
                    </div>
                    <div class="col-md-2 text-center">
                        <input type="text" class="form-control" id="" name="">
                    </div>
                </div>


                <div class="row mt-3">
                    <div class="col-md-1 text-center">
                        <span>15</span>
                    </div>
                    <div class="col-md-3 text-center">
                        <input type="text" class="form-control" id="" name="">
                    </div>
                    <div class="col-md-3 text-center">
                        <input type="text" class="form-control" id="" name="">
                    </div>
                    <div class="col-md-3 text-center">
                        <input type="text" class="form-control" id="" name="">
                    </div>
                    <div class="col-md-2 text-center">
                        <input type="text" class="form-control" id="" name="">
                    </div>
                </div>


                <div class="row mt-3">
                    <div class="col-md-12 bg-primary text-white text-center Myfont">
                        <h3>15. รายละเอียดผู้ทำ PM</h3>
                    </div>
                </div>

                <div class="row mt-3">
                    <div class="col-md-3 text-center">
                        <span>ชื่อ</span>
                    </div>
                    <div class="col-md-9">
                        <input type="text" class="form-control" id="" name="">
                    </div>

                </div>

                <div class="row mt-3">
                    <div class="col-md-3 text-center">
                        <span>วันที่ทำ PM</span>
                    </div>
                    <div class="col-md-9">
                        <input type="text" class="form-control" id="" name="">
                    </div>
                </div>

                <div class="row mt-3">
                    <div class="col-md-12 bg-primary text-white text-center Myfont">
                        <h3>16. รายละเอียด เจ้าหน้าที่ประจำศูนย์</h3>
                    </div>
                </div>

                <div class="row mt-3">
                    <div class="col-md-3 text-center">
                        <span>ชื่อเจ้าหน้าที่ประจำศูนย์</span>
                    </div>
                    <div class="col-md-9">
                        <input type="text" class="form-control" id="" name="">
                    </div>

                </div>

                <div class="row mt-3">
                    <div class="col-md-3 text-center">
                        <span>เบอร์โทรติดต่อ</span>
                    </div>
                    <div class="col-md-9">
                        <input type="text" class="form-control" id="" name="">
                    </div>
                </div>

                <div class="row mt-3">
                    <div class="col-md-12 bg-success text-white text-center Myfont">
                        <h3>PICTURE CHECKLIST</h3>
                    </div>
                </div>


                                <div class="form-row mt-3">
                    <label class="control-label col-sm-4" for="">รูปภาพป้ายชื่อโรงเรียน</label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">NOT PASS
                        </label>
                    </div>
                </div>


                <div class="form-row mt-3">
                    <label class="control-label col-sm-4" for="">รูปภาพด้านหน้าศูนย์ (ถ่ายคู่กับ จนท.ประจำศูนย์)</label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">NOT PASS
                        </label>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-4" for="">รูปภาพด้านหลังศูนย์</label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">NOT PASS
                        </label>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-4" for="">รูปภาพบริเวณห้องโถง</label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">NOT PASS
                        </label>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-4" for="">รูปภาพบริเวณห้องประชุม</label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">NOT PASS
                        </label>
                    </div>
                </div>


                <div class="form-row mt-3">
                    <label class="control-label col-sm-4" for="">รูปภาพบริเวณห้อง Server</label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">NOT PASS
                        </label>
                    </div>
                </div>


                <div class="form-row mt-3">
                    <label class="control-label col-sm-4" for="">รูปภาพบริเวณห้องน้ำ</label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">NOT PASS
                        </label>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-4" for="">รูปภาพบริเวณห้องปั๊มน้ำ</label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">NOT PASS
                        </label>
                    </div>
                </div>


                <div class="form-row mt-3">
                    <label class="control-label col-sm-4" for="">รูป PEA Meter</label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">NOT PASS
                        </label>
                    </div>
                </div>


                <div class="form-row mt-3">
                    <label class="control-label col-sm-4" for="">รูปการวัดแรงดัน AC และกระแส AC </label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">NOT PASS
                        </label>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-4" for="">รูปการวัดค่า Ground และ Bar Ground  </label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">NOT PASS
                        </label>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-4" for="">รูปการตรวจสอบสถานะไฟฟ้ารั่วลง Ground (Lamp Test) </label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">NOT PASS
                        </label>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-4" for="">รูป MDB  </label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">NOT PASS
                        </label>
                    </div>
                </div>


                <div class="form-row mt-3">
                    <label class="control-label col-sm-4" for="">รูป Fire Alarm Control </label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">NOT PASS
                        </label>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-4" for="">รูปภาพรวมอุปกรณ์ทั้งหมดภายในตู้ Rack</label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">NOT PASS
                        </label>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-4" for="">รูปหน้าจอ UPS แสดงค่าต่างๆ และ Serial NO.</label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">NOT PASS
                        </label>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-4" for="">รูป ONU/Modem พร้อม Serial NO. และ MAC</label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">NOT PASS
                        </label>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-4" for="">รูป Power Supply พร้อม Serial NO.</label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">NOT PASS
                        </label>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-4" for="">รูป Switch 8 Port พร้อม Serial NO. และ MAC  </label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">NOT PASS
                        </label>
                    </div>
                </div>


                <div class="form-row mt-3">
                    <label class="control-label col-sm-4" for="">รูป Switch 48 Port พร้อม Serial NO. และ MAC </label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">NOT PASS
                        </label>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-4" for="">รูป Outdoor AP ทั้ง 2 จุด พร้อม Serial NO. และ MAC </label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">NOT PASS
                        </label>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-4" for="">รูป Indoor AP ทั้ง 2 จุด พร้อม Serial NO. และ MAC </label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">NOT PASS
                        </label>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-4" for="">รูปการ Test Speed จาก App Nperf โดยใช้ WIFI </label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">NOT PASS
                        </label>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-4" for="">รูปการ Test Speed จาก App Nperf โดยใช้ LAN </label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">NOT PASS
                        </label>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-4" for="">รูป ก่อน-หลัง การทำความสะอาดรางระบายน้ำ </label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">NOT PASS
                        </label>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-4" for="">รูปหน้าจอ Monitor กล้องวงจรปิดผ่านจอทีวีในห้องประชุม </label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">NOT PASS
                        </label>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-4" for="">รูปภาพก่อน-หลัง การทำความสะอาดแอร์ห้องโถง </label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">NOT PASS
                        </label>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-4" for="">รูปภาพก่อน-หลัง การทำความสะอาดแอร์ห้องประชุม </label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">NOT PASS
                        </label>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-4" for="">รูปภาพก่อน-หลัง การทำความสะอาดแอร์ห้อง Server </label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">NOT PASS
                        </label>
                    </div>
                </div>




                <div class="row mt-3">
                    <div class="col-md-12 bg-primary text-white text-center Myfont">
                        <h3>VSAT PICTURE CHECKLIST</h3>
                    </div>
                </div>


                <div class="form-row mt-3">
                    <label class="control-label col-sm-4" for="">รูปจุดติดตั้งจานดาวเทียม</label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">NOT PASS
                        </label>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-4" for="">รูปความสะอาดบริเวณจานดาวเทียม</label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">NOT PASS
                        </label>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-4" for="">รูป LNB พร้อม Part NO.</label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">NOT PASS
                        </label>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-4" for="">รูป BUC พร้อม Part NO.</label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">NOT PASS
                        </label>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-4" for="">รูปการเก็บสายและพันหัวที่ LNB/BUC</label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">NOT PASS
                        </label>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-4" for="">รูปแนว Line Of Sight (ดูการถูกบังของหน้าจานดาวเทียม)</label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">NOT PASS
                        </label>
                    </div>
                </div>

                <div class="row mt-3">
                    <div class="col-md-12 bg-primary text-white text-center Myfont">
                        <h3>SOLAR CELL PICTURE CHECKLIST</h3>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-4" for="">รูปจุดติดตั้ง Solar Cell</label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">NOT PASS
                        </label>
                    </div>
                </div>


                <div class="form-row mt-3">
                    <label class="control-label col-sm-4" for="">รูปอุปกรณ์ Solar Cell ภายในห้อง</label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">NOT PASS
                        </label>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-4" for="">รูปหน้าจอ Charger แสดงค่าต่างๆ</label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">NOT PASS
                        </label>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-4" for="">รูปหน้าจอ Inverter แสดงค่าต่างๆ</label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">NOT PASS
                        </label>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-4" for="">รูป Circuit Breaker ภายในตู้</label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">NOT PASS
                        </label>
                    </div>
                </div>


                <div class="form-row mt-3">
                    <label class="control-label col-sm-4" for="">รูป Terminal ต่อสายภายในตู้</label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">NOT PASS
                        </label>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-4" for="">รูปความสะอาดแผง PV</label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">NOT PASS
                        </label>
                    </div>
                </div>


                <div class="form-row mt-3">
                    <label class="control-label col-sm-4" for="">รูปภาพรวมดูสิ่งบดบังแสงอาทิตย์</label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">NOT PASS
                        </label>
                    </div>
                </div>


                <div class="row mt-3">
                    <div class="col-md-12 bg-primary text-white text-center Myfont">
                        <h3>COMPUTER PICTURE CHECKLIST</h3>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-4" for="">รูปคอมพิวเตอร์ตัวที่ 1 พร้อม Serial NO.(เครื่องผู้ดูแล)</label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">NOT PASS
                        </label>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-4" for="">รูปคอมพิวเตอร์ตัวที่ 2 พร้อม Serial NO.</label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">NOT PASS
                        </label>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-4" for="">รูปคอมพิวเตอร์ตัวที่ 3 พร้อม Serial NO.</label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">NOT PASS
                        </label>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-4" for="">รูปคอมพิวเตอร์ตัวที่ 4 พร้อม Serial NO.</label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">NOT PASS
                        </label>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-4" for="">รูปคอมพิวเตอร์ตัวที่ 5 พร้อม Serial NO.</label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">NOT PASS
                        </label>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-4" for="">รูปคอมพิวเตอร์ตัวที่ 6 พร้อม Serial NO.</label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">NOT PASS
                        </label>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-4" for="">รูปคอมพิวเตอร์ตัวที่ 7 พร้อม Serial NO.</label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">NOT PASS
                        </label>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-4" for="">รูปคอมพิวเตอร์ตัวที่ 8 พร้อม Serial NO.</label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">NOT PASS
                        </label>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-4" for="">รูปคอมพิวเตอร์ตัวที่ 9 พร้อม Serial NO.</label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">NOT PASS
                        </label>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-4" for="">รูปคอมพิวเตอร์ตัวที่ 10 พร้อม Serial NO.</label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">NOT PASS
                        </label>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label class="control-label col-sm-4" for="">รูปคอมพิวเตอร์ตัวที่ 11 พร้อม Serial NO.</label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" id="" name="" value="">NOT PASS
                        </label>
                    </div>
                </div>



                <div class="row mt-3">
                    <div class="col-sm-12 text-black text-center Myfont">
                        <h3>รูปภาพประกอบรายงาน</h3>
                    </div>
                </div>

                <div class="row mt-3 ">
                    <div class="col-sm-12">1.รูป PICTURE CHECKLIST </div>
                    <input type="file" name="image2" onchange="previewImage(this)" accept="image/*" data-thumbnail="user_img_2" />
                </div>
                <div class="row ml-3 mt-3">
                    <img id="user_img_2" src="https://placehold.it/250x250" class="placeholder2" />
                </div>

                <div class="row mt-3">
                    <div class="col-sm-12">2.รูป VSAT PICTURE CHECKLIST</div>
                    <input type="file" name="image3" onchange="previewImage(this)" accept="image/*" data-thumbnail="user_img_3" />
                </div>
                <div class="row ml-3 mt-3">
                    <img id="user_img_3" src="https://placehold.it/250x250" class="placeholder2" />
                </div>

                <div class="row mt-3">
                    <div class="col-sm-12">3.รูป SOLAR CELL PICTURE CHECKLISTT</div>
                    <input type="file" name="image4" onchange="previewImage(this)" accept="image/*" data-thumbnail="user_img_4" />
                </div>
                <div class="row ml-3 mt-3">
                    <img id="user_img_4" src="https://placehold.it/250x250" class="placeholder2" />
                </div>

                <div class="row mt-3">
                    <div class="col-sm-12">4.COMPUTER PICTURE CHECKLIST</div>
                    <input type="file" name="image5" onchange="previewImage(this)" accept="image/*" data-thumbnail="user_img_5" />
                </div>
                <div class="row ml-3 mt-3">
                    <img id="user_img_5" src="https://placehold.it/250x250" class="placeholder2" />
                </div>

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
                        <label for="">1.รูป PICTURE CHECKLIST</label>
                        <input type="file" class="form-control-file" id="">
                    </div>

                    <div class="col-md-12 text-center mt-3 table-bordered">
                        <label for="">2.รูป VSAT PICTURE CHECKLIST</label>
                        <input type="file" class="form-control-file" id="">
                    </div>

                    <div class="col-md-12 text-center mt-3 table-bordered">
                        <label for="">3.รูป SOLAR CELL PICTURE CHECKLISTT</label>
                        <input type="file" class="form-control-file" id="">
                    </div>

                    <div class="col-md-12 text-center mt-3 table-bordered">
                        <label for="">4. COMPUTER PICTURE CHECKLIST</label>
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
