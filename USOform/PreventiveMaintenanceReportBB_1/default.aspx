<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="USOform.PreventiveMaintenanceReportBB1.WebForm1" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>รายงาน PM From BB Zone C+ บริการที่ 1</title>
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <%--<meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=no" />--%>

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
    <link href="http://ajax.googleapis.com/ajax/libs/jqueryui/1.12.1/themes/south-street/jquery-ui.css" rel="stylesheet" />
    <link href="../style/Mystyle.css" rel="stylesheet" />
    <meta http-equiv="Content-Type" content="text/html;charset=utf-8" />
    <%-------//   PREVIEW IMAGES   //--------%>
    <script src="previewImg.js"></script>
    <%-----------//  SIGNATURE PAD  //--------------%>
    <script src="https://cdn.jsdelivr.net/npm/signature_pad@2.3.2/dist/signature_pad.min.js"></script>
    <style type="text/css">
        img {
            position: relative;
            left: 0;
            top: 0;
        }

        .signature-pad {
            position: relative;
            /*  left: 0;
            top: 0;*/
            width: 400px;
            height: 200px;
            border: solid;
            border-width: 1px;
        }

        .signature-pad2 {
            position: relative;
            /*  left: 0;
            top: 0;*/
            width: 400px;
            height: 200px;
            border: solid;
            border-width: 1px;
        }

        table, tr, td {
            border: none;
        }
    </style>
</head>

<body style="background-color: lightgray">
    <form id="form1" name="form1" runat="server">
        <div class="container bg-white Myfont mt-3">
            <div class="row pt-5">
                <div class="col-4">
                    <asp:FileUpload ID="pictureOrganize_" runat="server" data-thumbnail="user_img_3" accept="image/" onchange="previewImage(this)" />
                    <div class="row ml-3 mt-3">
                        <img id="user_img_3" src='<% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1239).Count() > 0) Response.Write(answers.Where(x => x.QuestionId == 1239).FirstOrDefault().AnsDes); %>' class="imgLogoOganize  float-left" />

                    </div>
                </div>

                <div class="col-4  d-flex justify-content-center ">
                    <h5 class="headerText">Preventive Maintenance Site Report USO (OLT)</h5>
                </div>
                <div class="col-4 ">
                    <img src="../assets/logo_uso.png" class="logoImg" />
                </div>
            </div>


            <div class="row mt-3">
                <div class="col-12 text-left ">
                    <div>
                        <h5>รายงานผลการตรวจสอบ และบำรุงรักษาชุดอุปกรณ์ Broadband Internet Service (Preventive Maintenance (PM) Report)</h5>
                    </div>
                    <div>
                        <h5>โครงการจัดให้มีสัญญาณโทรศัพท์เคลื่อนที่และบริการอินเทอร์เน็ต ความเร็วสูงในพื้นที่ชายขอบ (Zone C+)</h5>
                    </div>
                </div>
            </div>



            <div class="form-row mt-3">
                <label class="control-label col-sm-1" for="">กลุ่ม :</label>
                <div class="col-sm-4">
                    <input type="text" required="required" class="form-control" id="GroupNameTextBox" runat="server" />
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-1" for="">ภาค :</label>
                <div class="col-sm-4">
                    <input type="text" required="required" class="form-control" id="AreaTextbox" runat="server" />
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-1" for="">บริษัท :</label>
                <div class="col-sm-4">
                    <input type="text" required="required" class="form-control" id="CompanyTextbox" runat="server" />
                </div>
            </div>



            <div class="form-row mt-3">
                <label class="control-label col-sm-8" for="">ส่วนที่ 1 การจัดให้มีบริการอินเทอร์เน็ตความเร็วสูง (Broadband Internet Service) บริการประเภทที่ 1 </label>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-2" for="">รอบการบำรุงรักษา ครั้งที่ </label>
                <div class="col-sm-1">
                    <input type="text" required="required" class="form-control" id="maintenanceCountTextbox" runat="server" />
                </div>
                /
              <div class="col-sm-3">
                  <input type="text" required="required" class="form-control" placeholder="ปีพุทธศักราช" id="yearTextbox" runat="server" />
              </div>
            </div>

            <div class="row text-left mt-3">
                <div class="col-md-12">
                    <div>
                        <label>
                            <div>วัน เดือน ปี</div>
                        </label>
                        <input class="form-control" type="text" id="startDatepicker" runat="server" />

                        <%-- QuestionId = 9,--%>
                        <label>
                            <div>ถึง</div>
                        </label>
                        <input class="form-control" type="text" id="endDatepicker" runat="server" />
                    </div>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-2" for="">สถานที่ (Site code)</label>
                <div class="col-sm-4">
                    <input type="text" required="required" class="form-control" id="siteCodeTextbox" runat="server" />
                </div>
            </div>




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
                    <input type="text" required="required" class="form-control" id="cabinetIdTextbox" runat="server" />
                </div>
            </div>

            <%-- QuestionId = 12,--%>
            <div class="form-row mt-3">
                <label class="control-label col-sm-1">Site Code :</label>
                <div class="col-sm-11">
                    <input class="form-control" type="text" id="sitecodeTextboxSection2" runat="server" />
                </div>
            </div>

            <%-- QuestionId = 13,--%>
            <div class="form-row mt-3">
                <label class="control-label col-sm-1">Village ID :</label>
                <div class="col-sm-11">
                    <input type="text" required="required" class="form-control" id="VillageIdTextbox" runat="server" />
                </div>
            </div>

            <%-- QuestionId = 14,--%>
            <div class="form-row mt-3">
                <label class="control-label col-sm-1">Village :</label>
                <div class="col-sm-11">
                    <input type="text" required="required" class="form-control" id="villageTextbox" runat="server" />
                </div>
            </div>



            <%-- QuestionId = 16,--%>
            <div class="form-row mt-3">
                <label class="control-label col-sm-1">Sub-District :</label>
                <div class="col-sm-11">
                    <input type="text" required="required" class="form-control" id="subdistrictTextbox" runat="server" />
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-1">District :</label>
                <div class="col-sm-11">
                    <input type="text" required="required" class="form-control" id="districtTextbox" runat="server" />
                </div>
            </div>



            <%-- QuestionId = 17,--%>
            <div class="form-row mt-3">
                <label class="control-label col-sm-1">Province :</label>
                <div class="col-sm-11">
                    <input type="text" required="required" class="form-control" id="provinceTextbox" runat="server" />
                </div>
            </div>

            <%-- QuestionId = 18,--%>
            <div class="form-row mt-3">
                <label class="control-label col-sm-1">Type :</label>
                <div class="col-sm-11">
                    <input type="text" required="required" class="form-control" id="typeTextbox" runat="server" />
                </div>
            </div>


            <%-- QuestionId = 19,--%>
            <div class="form-row mt-3">
                <label class="control-label col-sm-1">PM Date : </label>
                <div class="col-sm-11">
                    <input type="text" required="required" class="form-control" id="pmdateTextbox" runat="server" />
                </div>
            </div>


            <%-- QuestionId = 6, --%>
            <div class="row mt-3">
                <div class="col-sm-12 bg-primary text-white">ใส่รูปหน้าตู้</div>
                <asp:FileUpload ID="signboardfontImage" runat="server" data-thumbnail="user_img_0" accept="image/*" onchange="previewImage(this)" />
            </div>
            <div class="row ml-3 mt-3">
                <img id="user_img_0" src='<% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1249).Count() > 0) Response.Write(answers.Where(x => x.QuestionId == 1249).FirstOrDefault().AnsDes); %>' class="placeholder2" />
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
                            <canvas id="signature-pad" class="signature-pad" width="400" height="200"></canvas>
                            <asp:HiddenField ID="SignatureHiddenfieldExecutor" runat="server" />
                            <div>

                                <button type="button" id="clear" onclick="signaturePad.clear();" >Clear</button>
                            </div>
                            <div class="form-group">
                                <label>Name</label>
                                <input type="text" class="form-control" id="nameExecutorTextbox" runat="server" />
                            </div>
                            <div class="form-group">
                                <label>Date</label>
                                <input type="text" class="form-control" id="DateExecutorTextbox" runat="server" />
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
                            <canvas id="signature-pad2" class="signature-pad2" width="400" height="200"></canvas>
                            <asp:HiddenField ID="SignatureHiddenfieldSupervisor" runat="server" />
                            <div>
                                <button type="button" id="clear2" onclick="signaturePad2.clear();" >Clear</button>
                            </div>
                            <div class="form-group">
                                <label>Name</label>
                                <input type="text" class="form-control" id="nameSupervisorTextbox" runat="server" />
                            </div>
                            <div class="form-group">
                                <label>Date</label>
                                <input type="text" class="form-control" id="DateSupervisorTextbox" runat="server" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>

            <%--FOR PREVIEW--%>
            <%-- <img id="user_img_6" src='<% if (answers.Count() > 0) Response.Write(answers.Where(x => x.QuestionId == 1034).FirstOrDefault().AnsDes); %>' class="placeholder2" />--%>
            <%-- <img id="user_img_7" src='<% if (answers.Count() > 0) Response.Write(answers.Where(x => x.QuestionId == 1035).FirstOrDefault().AnsDes); %>' class="placeholder2" />--%>

            <div class="row mt-3">
                <div class="col-md-12 bg-primary text-white text-center Myfont">
                    <h4>1. รายละเอียดสถานี</h4>
                </div>
            </div>

            <div class="form-row mt-3">
                <%-- QuestionId = 27, --%>
                <label class="control-label col-sm-1">Cabinet ID </label>
                <div class="col-sm-11">
                    <input type="text" required="required" class="form-control" id="CabinetTextbox" runat="server" />
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-1">Site Code</label>
                <div class="col-sm-11">
                    <%-- QuestionId = 28, --%>
                    <input type="text" required="required" class="form-control" id="sitecodeTextboxSection4" runat="server" />
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-1">Village ID</label>
                <div class="col-sm-11">
                    <%-- QuestionId = 29, --%>
                    <input type="text" required="required" class="form-control" id="villageIDTextboxSection4" runat="server" />
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-1">LAT & LONG</label>
                <div class="col-sm-11">
                    <%-- QuestionId = 30, --%>
                    <input type="text" required="required" class="form-control" id="latandlongTextbox" runat="server" />
                </div>
            </div>



            <div class="row mt-3">
                <div class="col-md-12 bg-primary text-white text-center Myfont">
                    <h4>2. ระบบไฟฟ้า (หลัก)</h4>
                </div>
            </div>


            <div class="form-row mt-3">
                <%------, ----------------------------------------------------------------------------------------------------------%>
                <label class="control-label col-sm-2">หมายเลขผู้ใช้ไฟ</label>
                <div class="col-sm-10">
                    <input type="text" required="required" class="form-control" id="numberuserTextbox" runat="server" />
                </div>
            </div>

            <div class="form-row mt-3">
                <%------  ----------------------------------------------------------------------------------------------------------%>
                <label class="control-label col-sm-2">หน่วยใช้ไฟ (kWh Meter)</label>
                <div class="col-sm-8">
                    <input type="text" required="required" class="form-control" id="kwhMeterTextbox" runat="server" />
                </div>
                <label class="control-label col-sm-2">kWh</label>
            </div>


            <div class="form-row mt-3">
                <%------ , ---------------------------------------------------------------------------------------------------------%>
                <label class="control-label col-sm-2">แรงดัน AC (kWh Meter)</label>
                <div class="col-sm-8">
                    <input type="text" required="required" class="form-control" id="acTextbox" runat="server" />
                </div>
                <label class="control-label col-sm-2">V.</label>
            </div>

            <div class="form-row mt-3">
                <%------  ----------------------------------------------------------------------------------------------------------%>
                <label class="control-label col-sm-2">กระแส Line AC (kWh Meter)</label>
                <div class="col-sm-8">
                    <input type="text" required="required" class="form-control" id="lineAcTextbox" runat="server" />
                </div>
                <label class="control-label col-sm-2">A.</label>
            </div>

            <div class="form-row mt-3">
                <%------  -----------------------------------------------------------------------------------------------------------%>
                <label class="control-label col-sm-2">กระแส Neutron AC (kWh Meter)</label>
                <div class="col-sm-8">
                    <input type="text" required="required" class="form-control" id="neutronacTextbox" runat="server" />
                </div>
                <label class="control-label col-sm-2">A.</label>
            </div>

            <div class="form-row mt-3">
                <%------  -----------------------------------------------------------------------------------------------------------%>
                <label class="control-label col-sm-2">สภาพ kWh Meter</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="conditionRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1265).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="conditionRadio" value="ชำรุด/ใช้งานไม่ได้" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1265).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); } %> />ชำรุด/ใช้งานไม่ได้
                    </label>
                </div>
            </div>


            <div class="form-row mt-3">
                <%------  ----------------------------------------------------------------------------------------------------------%>
                <label class="control-label col-sm-2">สภาพ Circuit Breaker</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="MDBCircuitBreakerRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1266).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="MDBCircuitBreakerRadio" value="ชำรุด/ใช้งานไม่ได้" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1266).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); } %> />ชำรุด/ใช้งานไม่ได้
                    </label>
                </div>
            </div>
            <%--////////////// -----------------------------  //////////////////--%>


            <div class="row mt-3">
                <div class="col-md-12 bg-primary text-white text-center Myfont">
                    <h4>3. ระบบ Rectifier</h4>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-2" for="">แรงดัน DC</label>
                <div class="col-sm-8">
                    <input type="text" required="required" class="form-control" id="dcTextbox" runat="server" />
                </div>
                <label class="control-label col-sm-2" for="">V.</label>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-2" for="">กระแส Load DC</label>
                <div class="col-sm-8">
                    <input type="text" required="required" class="form-control" id="loaddcTextbox" runat="server" />
                </div>
                <label class="control-label col-sm-2" for="">A.</label>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-2" for="">จำนวน Rectifier Module</label>
                <div class="col-sm-8">
                    <input type="text" required="required" class="form-control" id="RectifierTextbox" runat="server" />
                </div>
                <label class="control-label col-sm-2" for="">Unit.</label>
            </div>


            <div class="row mt-3">
                <div class="col-md-12 bg-primary text-white text-center Myfont">
                    <h4>4. รายละเอียด Battery</h4>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-2" for="">Battery Voltage</label>
                <div class="col-sm-8">
                    <input type="text" required="required" class="form-control" id="BatteryVoltagetextbox" runat="server" />
                </div>
                <label class="control-label col-sm-2" for="">V.</label>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-2" for="">Battery Temperature</label>
                <div class="col-sm-8">
                    <input type="text" required="required" class="form-control" id="BatteryTempTexbox" runat="server" />
                </div>
                <label class="control-label col-sm-2" for="">°C</label>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-2" for="">Battery Voltage ก้อนที่ 1</label>
                <div class="col-sm-8">
                    <input type="text" required="required" class="form-control" id="BatteryVoltagetextbox1" runat="server" />
                </div>
                <label class="control-label col-sm-2" for="">V.</label>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-2" for="">Battery Voltage ก้อนที่ 2</label>
                <div class="col-sm-8">
                    <input type="text" required="required" class="form-control" id="BatteryVoltagetextbox2" runat="server" />
                </div>
                <label class="control-label col-sm-2" for="">V.</label>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-2" for="">Battery Voltage ก้อนที่ 3</label>
                <div class="col-sm-8">
                    <input type="text" required="required" class="form-control" id="BatteryVoltagetextbox3" runat="server" />
                </div>
                <label class="control-label col-sm-2" for="">V.</label>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-2" for="">Battery Voltage ก้อนที่ 4</label>
                <div class="col-sm-8">
                    <input type="text" required="required" class="form-control" id="BatteryVoltagetextbox4" runat="server" />
                </div>
                <label class="control-label col-sm-2" for="">V.</label>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-2" for="">Battery Capacity </label>
                <div class="col-sm-8">
                    <input type="text" required="required" class="form-control" id="BatteryCapacitytextbox" runat="server" />
                </div>
                <label class="control-label col-sm-2" for="">Ah.</label>
            </div>




            <div class="row mt-3">
                <div class="col-md-12 bg-primary text-white text-center Myfont">
                    <h4>5.ระบบ Alarm</h4>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-3" for="">Door Alarm</label>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="dooralarmRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1277).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %>>ปกติ 
                    </label>
                </div>

                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="dooralarmRadio" value="ไม่ส่งAlarm" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1277).FirstOrDefault().AnsDes == "ไม่ส่งAlarm") { Response.Write("checked"); } else { Response.Write(""); } %>>ไม่ส่ง Alarm
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-3" for="">Main Power Failure Alarm</label>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="maimpowerFailureAlarm" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1278).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %>>ปกติ 
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="maimpowerFailureAlarm" value="ไม่ส่งAlarm" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1278).FirstOrDefault().AnsDes == "ไม่ส่งAlarm") { Response.Write("checked"); } else { Response.Write(""); } %> />ไม่ส่ง Alarm
                    </label>
                </div>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-3" for="">Rectifier 1 Comm. Fail Alarm</label>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="rectifier1Radio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1279).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %> />ปกติ 
                    </label>
                </div>

                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="rectifier1Radio" value="ไม่ส่งAlarm" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1279).FirstOrDefault().AnsDes == "ไม่ส่งAlarm") { Response.Write("checked"); } else { Response.Write(""); } %> />ไม่ส่ง Alarm
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-3" for="">Rectifier 2 Comm. Fail Alarm</label>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="rectifier2Radio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1280).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %> />ปกติ 
                    </label>
                </div>

                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="rectifier2Radio" value="ไม่ส่งAlarm" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1280).FirstOrDefault().AnsDes == "ไม่ส่งAlarm") { Response.Write("checked"); } else { Response.Write(""); } %>>ไม่ส่ง Alarm
                    </label>
                </div>
            </div>





            <div class="row mt-3">
                <div class="col-md-12 bg-primary text-white text-center Myfont">
                    <h4>6.ระบบ Ground</h4>
                </div>
            </div>


            <div class="form-row mt-3">
                <%----------------------  ---------------------------%>
                <label class="control-label col-sm-3">ความแข็งแรงจุดต่อ Ground Bar</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="groundbarRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1281).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="groundbarRadio" value="ชำรุด" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1281).FirstOrDefault().AnsDes == "ชำรุด") { Response.Write("checked"); } else { Response.Write(""); } %> />ชำรุด
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <%----------------------  ---------------------------%>
                <label class="control-label col-sm-3">ความแข็งแรงของน็อตขันหางปลาอุปกรณ์</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="notfishRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1282).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="notfishRadio" value="ชำรุด" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1282).FirstOrDefault().AnsDes == "ชำรุด") { Response.Write("checked"); } else { Response.Write(""); } %> />ชำรุด
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <%---------------------- , ---------------------------%>
                <label class="control-label col-sm-3">สายกราวด์เรียบร้อย ปลอดภัย สมบูรณ์</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="safegroundRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1283).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="safegroundRadio" value="ชำรุด" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1283).FirstOrDefault().AnsDes == "ชำรุด") { Response.Write("checked"); } else { Response.Write(""); } %> />ชำรุด
                    </label>
                </div>
            </div>



            <%----------------------  ---------------------------%>
            <div class="form-row mt-3">
                <label class="control-label col-sm-3">สถานะไฟฟ้ารั่วลง Ground</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="brokenElecRadio" value="ไม่พบไฟฟ้ารั่ว" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1284).FirstOrDefault().AnsDes == "ไม่พบไฟฟ้ารั่ว") { Response.Write("checked"); } else { Response.Write(""); } %> />ไม่พบไฟฟ้ารั่ว
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="brokenElecRadio" value="พบไฟฟ้ารั่ว" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1284).FirstOrDefault().AnsDes == "พบไฟฟ้ารั่ว") { Response.Write("checked"); } else { Response.Write(""); } %> />พบไฟฟ้ารั่ว
                    </label>
                </div>
            </div>
            <%--////////////// ------------------------------  //////////////////--%>

            <div class="row mt-3">
                <div class="col-md-12 bg-success text-white text-center Myfont">
                    <h4>7.สภาพแวดล้อมและความสะอาดโดยรอบ</h4>
                </div>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-3" for="">ป้ายและตัวเลขแสดงชื่อสถานี</label>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="nameStationRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1285).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %> />ปกติ     
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="nameStationRadio" value="ไม่ชัดเจน" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1285).FirstOrDefault().AnsDes == "ไม่ชัดเจน") { Response.Write("checked"); } else { Response.Write(""); } %> />ไม่ชัดเจน        
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-3" for="">การติดตั้งและการยึดตู้อุปกรณ์</label>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="installandboxRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1286).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %> />ปกติ     
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="installandboxRadio" value="ชำรุด" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1286).FirstOrDefault().AnsDes == "ชำรุด") { Response.Write("checked"); } else { Response.Write(""); } %> />ชำรุด        
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-3" for="">เสาไฟฟ้าที่ตั้งตั้งอุปกรณ์</label>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="postElectriInstallRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1287).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %> />ปกติ     
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="postElectriInstallRadio" value="ชำรุด/เอียง" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1287).FirstOrDefault().AnsDes == "ชำรุด/เอียง") { Response.Write("checked"); } else { Response.Write(""); } %> />ชำรุด/เอียง        
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-3" for="">แนวสายไฟฟ้าและสายเคเบิ้ลเข้าสถานี</label>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="cableInStationRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1288).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %> />ปกติ     
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="cableInStationRadio" value="ตกหย่อน/ไม่ได้ยึดโยง" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1288).FirstOrDefault().AnsDes == "ตกหย่อน/ไม่ได้ยึดโยง") { Response.Write("checked"); } else { Response.Write(""); } %> />ตกหย่อน/ไม่ได้ยึดโยง       
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-3" for="">ช่อง Cable Inlet  และความสะอาด</label>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="cleanCableRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1289).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %> />ปกติ     
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="cleanCableRadio" value="ไม่ได้อุดซิลีโคน" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1289).FirstOrDefault().AnsDes == "ไม่ได้อุดซิลีโคน") { Response.Write("checked"); } else { Response.Write(""); } %> />ไม่ได้อุดซิลีโคน       
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-3" for="">ความสะอาดภายในตู้</label>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="CleaninboxRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1290).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %> />ปกติ     
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="CleaninboxRadio" value="มีฝุ่น/สิ่งสกปรก" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1290).FirstOrDefault().AnsDes == "มีฝุ่น/สิ่งสกปรก") { Response.Write("checked"); } else { Response.Write(""); } %> />มีฝุ่น/สิ่งสกปรก      
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-3" for="">ประตูและยางขอบประตูของตู้อุปกรณ์</label>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="doorandboxRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1291).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %> />ปกติ     
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="doorandboxRadio" value="ชำรุด" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1291).FirstOrDefault().AnsDes == "ชำรุด") { Response.Write("checked"); } else { Response.Write(""); } %> />ชำรุด      
                    </label>
                </div>
            </div>




            <div class="row mt-3">
                <div class="col-md-12 bg-warning text-white text-center Myfont">
                    <h3>8. ปัญหาที่พบและการแก้ไข</h3>
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
                            <%----------------------   ---------------------------%>
                            <input type="text" class="form-control" id="problemTextbox1" runat="server" />
                        </div>
                        <div class="divTableCell">
                            <%----------------------   ---------------------------%>
                            <input type="text" class="form-control" id="howtoSolveTextbox1" runat="server" />
                        </div>
                    </div>

                    <div class="divTableRow">
                        <div class="divTableCell">&nbsp;2</div>
                        <div class="divTableCell">
                            <%----------------------  ---------------------------%>
                            <input type="text" class="form-control" id="problemTextbox2" runat="server" />
                        </div>
                        <div class="divTableCell">
                            <%----------------------   ---------------------------%>
                            <input type="text" class="form-control" id="howtoSolveTextbox2" runat="server" />
                        </div>
                    </div>

                    <div class="divTableRow">
                        <div class="divTableCell">&nbsp;3</div>
                        <div class="divTableCell">
                            <%----------------------   ---------------------------%>
                            <input type="text" class="form-control" id="problemTextbox3" runat="server" />
                        </div>
                        <div class="divTableCell">
                            <%----------------------   ---------------------------%>
                            <input type="text" class="form-control" id="howtoSolveTextbox3" runat="server" />
                        </div>
                    </div>

                    <div class="divTableRow">
                        <div class="divTableCell">&nbsp;4</div>
                        <div class="divTableCell">
                            <%----------------------   ---------------------------%>
                            <input type="text" class="form-control" id="problemTextbox4" runat="server" />
                        </div>
                        <div class="divTableCell">
                            <%----------------------   ---------------------------%>
                            <input type="text" class="form-control" id="howtoSolveTextbox4" runat="server" />
                        </div>
                    </div>

                    <div class="divTableRow">
                        <div class="divTableCell">&nbsp;5</div>
                        <div class="divTableCell">
                            <%----------------------   ---------------------------%>
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
                            <%----------------------  ---------------------------%>
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
                            <%---------------------- 4  ---------------------------%>
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
                            <%----------------------   ---------------------------%>
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
                            <%----------------------   ---------------------------%>
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
                            <%----------------------   ---------------------------%>
                            <input type="text" class="form-control" id="problemTextbox12" runat="server" />
                        </div>
                        <div class="divTableCell">
                            <%----------------------  ---------------------------%>
                            <input type="text" class="form-control" id="howtoSolveTextbox12" runat="server" />
                        </div>
                    </div>
                    <div class="divTableRow">
                        <div class="divTableCell">&nbsp;13</div>
                        <div class="divTableCell">
                            <%----------------------  ---------------------------%>
                            <input type="text" class="form-control" id="problemTextbox13" runat="server" />
                        </div>
                        <div class="divTableCell">
                            <%----------------------   ---------------------------%>
                            <input type="text" class="form-control" id="howtoSolveTextbox13" runat="server" />
                        </div>
                    </div>
                    <div class="divTableRow">
                        <div class="divTableCell">&nbsp;14</div>
                        <div class="divTableCell">
                            <%---------------------- ---------------------------%>
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
                            <%----------------------   ---------------------------%>
                            <input type="text" class="form-control" id="problemTextbox15" runat="server" />
                        </div>
                        <div class="divTableCell">
                            <%----------------------   ---------------------------%>
                            <input type="text" class="form-control" id="howtoSolveTextbox15" runat="server" />
                        </div>
                    </div>
                </div>
            </div>


            <div class="row mt-3">
                <div class="col-md-12 bg-primary text-white text-center Myfont">
                    <h3>9.ข้อมูลรายการทรัพย์สิน</h3>
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
                                <%---------------------- QuestionId =   ---------------------------%>
                                <input type="text" class="form-control form-control-sm" id="toolsListTextbox1" runat="server" /></td>
                            <td>
                                <%---------------------- QuestionId =   ---------------------------%>
                                <input type="text" class="form-control form-control-sm" id="serialNumberTextbox1" runat="server" /></td>
                            <td>
                                <%---------------------- QuestionId =   ---------------------------%>
                                <input type="text" class="form-control form-control-sm" id="newSerialNumberTextbox1" runat="server" /></td>
                            <td>
                                <%---------------------- QuestionId =   ---------------------------%>
                                <input type="text" class="form-control form-control-sm" id="noteTextbox1" runat="server" /></td>
                        </tr>
                        <tr>

                            <td>2</td>
                            <td>
                                <%---------------------- QuestionId =   ---------------------------%>
                                <input type="text" class="form-control form-control-sm" id="toolsListTextbox2" runat="server" /></td>
                            <td>
                                <%---------------------- QuestionId =   ---------------------------%>
                                <input type="text" class="form-control form-control-sm" id="serialNumberTextbox2" runat="server" /></td>
                            <td>
                                <%---------------------- QuestionId =   ---------------------------%>
                                <input type="text" class="form-control form-control-sm" id="newSerialNumberTextbox2" runat="server" /></td>
                            <td>
                                <%---------------------- QuestionId =   ---------------------------%>
                                <input type="text" class="form-control form-control-sm" id="noteTextbox2" runat="server" /></td>
                        </tr>
                        <tr>
                            <td>3</td>
                            <td>
                                <%---------------------- QuestionId =   ---------------------------%>
                                <input type="text" class="form-control form-control-sm" id="toolsListTextbox3" runat="server" /></td>
                            <td>
                                <%---------------------- QuestionId =   ---------------------------%>
                                <input type="text" class="form-control form-control-sm" id="serialNumberTextbox3" runat="server" /></td>
                            <td>
                                <%---------------------- QuestionId =   ---------------------------%>
                                <input type="text" class="form-control form-control-sm" id="newSerialNumberTextbox3" runat="server" /></td>
                            <td>
                                <%---------------------- QuestionId =   ---------------------------%>
                                <input type="text" class="form-control form-control-sm" id="noteTextbox3" runat="server" /></td>
                        </tr>
                        <tr>
                            <td>4</td>
                            <td>
                                <%---------------------- QuestionId =   ---------------------------%>
                                <input type="text" class="form-control form-control-sm" id="toolsListTextbox4" runat="server" /></td>
                            <td>
                                <%---------------------- QuestionId =   ---------------------------%>
                                <input type="text" class="form-control form-control-sm" id="serialNumberTextbox4" runat="server" /></td>
                            <td>
                                <%---------------------- QuestionId =   ---------------------------%>
                                <input type="text" class="form-control form-control-sm" id="newSerialNumberTextbox4" runat="server" /></td>
                            <td>
                                <%---------------------- QuestionId =   ---------------------------%>
                                <input type="text" class="form-control form-control-sm" id="noteTextbox4" runat="server" /></td>
                        </tr>
                        <tr>
                            <td>5</td>
                            <td>
                                <%---------------------- QuestionId =   ---------------------------%>
                                <input type="text" class="form-control form-control-sm" id="toolsListTextbox5" runat="server" /></td>
                            <td>
                                <%---------------------- QuestionId =   ---------------------------%>
                                <input type="text" class="form-control form-control-sm" id="serialNumberTextbox5" runat="server" /></td>
                            <td>
                                <%---------------------- QuestionId =   ---------------------------%>
                                <input type="text" class="form-control form-control-sm" id="newSerialNumberTextbox5" runat="server" /></td>
                            <td>
                                <%---------------------- QuestionId =   ---------------------------%>
                                <input type="text" class="form-control form-control-sm" id="noteTextbox5" runat="server" /></td>
                        </tr>
                        <tr>
                            <td>6</td>
                            <td>
                                <%---------------------- QuestionId =   ---------------------------%>
                                <input type="text" class="form-control form-control-sm" id="toolsListTextbox6" runat="server" /></td>
                            <td>
                                <%---------------------- QuestionId =   ---------------------------%>
                                <input type="text" class="form-control form-control-sm" id="serialNumberTextbox6" runat="server" /></td>
                            <td>
                                <%---------------------- QuestionId =   ---------------------------%>
                                <input type="text" class="form-control form-control-sm" id="newSerialNumberTextbox6" runat="server" /></td>
                            <td>
                                <%---------------------- QuestionId =   ---------------------------%>
                                <input type="text" class="form-control form-control-sm" id="noteTextbox6" runat="server" /></td>
                        </tr>
                        <tr>
                            <td>7</td>
                            <td>
                                <%---------------------- QuestionId =   ---------------------------%>
                                <input type="text" class="form-control form-control-sm" id="toolsListTextbox7" runat="server" /></td>
                            <td>
                                <%---------------------- QuestionId =   ---------------------------%>
                                <input type="text" class="form-control form-control-sm" id="serialNumberTextbox7" runat="server" /></td>
                            <td>
                                <%---------------------- QuestionId =   ---------------------------%>
                                <input type="text" class="form-control form-control-sm" id="newSerialNumberTextbox7" runat="server" /></td>
                            <td>
                                <%---------------------- QuestionId =   ---------------------------%>
                                <input type="text" class="form-control form-control-sm" id="noteTextbox7" runat="server" /></td>
                        </tr>
                        <tr>
                            <td>8</td>
                            <td>
                                <%---------------------- QuestionId =   ---------------------------%>
                                <input type="text" class="form-control form-control-sm" id="toolsListTextbox8" runat="server" /></td>
                            <td>
                                <%---------------------- QuestionId =   ---------------------------%>
                                <input type="text" class="form-control form-control-sm" id="serialNumberTextbox8" runat="server" /></td>
                            <td>
                                <%---------------------- QuestionId =   ---------------------------%>
                                <input type="text" class="form-control form-control-sm" id="newSerialNumberTextbox8" runat="server" /></td>
                            <td>
                                <%---------------------- QuestionId =   ---------------------------%>
                                <input type="text" class="form-control form-control-sm" id="noteTextbox8" runat="server" /></td>
                        </tr>
                        <tr>
                            <td>9</td>
                            <td>
                                <%---------------------- QuestionId =   ---------------------------%>
                                <input type="text" class="form-control form-control-sm" id="toolsListTextbox9" runat="server" /></td>
                            <td>
                                <%---------------------- QuestionId =   ---------------------------%>
                                <input type="text" class="form-control form-control-sm" id="serialNumberTextbox9" runat="server" /></td>
                            <td>
                                <%---------------------- QuestionId =   ---------------------------%>
                                <input type="text" class="form-control form-control-sm" id="newSerialNumberTextbox9" runat="server" /></td>
                            <td>
                                <%---------------------- QuestionId =   ---------------------------%>
                                <input type="text" class="form-control form-control-sm" id="noteTextbox9" runat="server" /></td>
                        </tr>
                        <tr>
                            <td>10</td>
                            <td>
                                <%---------------------- QuestionId =   ---------------------------%>
                                <input type="text" class="form-control form-control-sm" id="toolsListTextbox10" runat="server" /></td>
                            <td>
                                <%---------------------- QuestionId =   ---------------------------%>
                                <input type="text" class="form-control form-control-sm" id="serialNumberTextbox10" runat="server" /></td>
                            <td>
                                <%---------------------- QuestionId =   ---------------------------%>
                                <input type="text" class="form-control form-control-sm" id="newSerialNumberTextbox10" runat="server" /></td>
                            <td>
                                <%---------------------- QuestionId =   ---------------------------%>
                                <input type="text" class="form-control form-control-sm" id="noteTextbox10" runat="server" /></td>
                        </tr>
                        <tr>
                            <td>11</td>
                            <td>
                                <%---------------------- QuestionId =   ---------------------------%>
                                <input type="text" class="form-control form-control-sm" id="toolsListTextbox11" runat="server" /></td>
                            <td>
                                <%---------------------- QuestionId =   ---------------------------%>
                                <input type="text" class="form-control form-control-sm" id="serialNumberTextbox11" runat="server" /></td>
                            <td>
                                <%---------------------- QuestionId =   ---------------------------%>
                                <input type="text" class="form-control form-control-sm" id="newSerialNumberTextbox11" runat="server" /></td>
                            <td>
                                <%---------------------- QuestionId =   ---------------------------%>
                                <input type="text" class="form-control form-control-sm" id="noteTextbox11" runat="server" /></td>
                        </tr>
                        <tr>
                            <td>12</td>
                            <td>
                                <%---------------------- QuestionId =   ---------------------------%>
                                <input type="text" class="form-control form-control-sm" id="toolsListTextbox12" runat="server" /></td>
                            <td>
                                <%---------------------- QuestionId =   ---------------------------%>
                                <input type="text" class="form-control form-control-sm" id="serialNumberTextbox12" runat="server" /></td>
                            <td>
                                <%---------------------- QuestionId =   ---------------------------%>
                                <input type="text" class="form-control form-control-sm" id="newSerialNumberTextbox12" runat="server" /></td>
                            <td>
                                <%---------------------- QuestionId =   ---------------------------%>
                                <input type="text" class="form-control form-control-sm" id="noteTextbox12" runat="server" /></td>
                        </tr>
                        <tr>
                            <td>13</td>
                            <td>
                                <%---------------------- QuestionId =   ---------------------------%>
                                <input type="text" class="form-control form-control-sm" id="toolsListTextbox13" runat="server" /></td>
                            <td>
                                <%---------------------- QuestionId =   ---------------------------%>
                                <input type="text" class="form-control form-control-sm" id="serialNumberTextbox13" runat="server" /></td>
                            <td>
                                <%---------------------- QuestionId =   ---------------------------%>
                                <input type="text" class="form-control form-control-sm" id="newSerialNumberTextbox13" runat="server" /></td>
                            <td>
                                <%---------------------- QuestionId =   ---------------------------%>
                                <input type="text" class="form-control form-control-sm" id="noteTextbox13" runat="server" /></td>
                        </tr>
                        <tr>
                            <td>14</td>
                            <td>
                                <%---------------------- QuestionId =   ---------------------------%>
                                <input type="text" class="form-control form-control-sm" id="toolsListTextbox14" runat="server" /></td>
                            <td>
                                <%---------------------- QuestionId =   ---------------------------%>
                                <input type="text" class="form-control form-control-sm" id="serialNumberTextbox14" runat="server" /></td>
                            <td>
                                <%---------------------- QuestionId =   ---------------------------%>
                                <input type="text" class="form-control form-control-sm" id="newSerialNumberTextbox14" runat="server" /></td>
                            <td>
                                <%---------------------- QuestionId =   ---------------------------%>
                                <input type="text" class="form-control form-control-sm" id="noteTextbox14" runat="server" /></td>
                        </tr>
                        <tr>
                            <td>15</td>
                            <td>
                                <%---------------------- QuestionId =   ---------------------------%>
                                <input type="text" class="form-control form-control-sm" id="toolsListTextbox15" runat="server" /></td>
                            <td>
                                <%---------------------- QuestionId =   ---------------------------%>
                                <input type="text" class="form-control form-control-sm" id="serialNumberTextbox15" runat="server" /></td>
                            <td>
                                <%---------------------- QuestionId =   ---------------------------%>
                                <input type="text" class="form-control form-control-sm" id="newSerialNumberTextbox15" runat="server" /></td>
                            <td>
                                <%---------------------- QuestionId =   ---------------------------%>
                                <input type="text" class="form-control form-control-sm" id="noteTextbox15" runat="server" /></td>
                        </tr>
                    </tbody>
                </table>

            </div>
            <%--////////////// --------------------- --------------------------  //////////////////--%>

            <div class="row mt-3">
                <div class="col-md-12 bg-primary text-white text-center Myfont">
                    <h3>10. รายละเอียดผู้ทำ PM</h3>
                </div>
            </div>

            <%----------------------  ---------------------------%>
            <div class="row mt-3">
                <div class="col-md-3 text-center">
                    <span>ชื่อทีม</span>
                </div>
                <div class="col-sm-5">
                    <input type="text" required="required" class="form-control" id="nameTeampmTextbox" runat="server" />
                </div>

            </div>

            <%---------------------- QuestionId = ---------------------------%>
            <div class="row mt-3">
                <div class="col-md-3 text-center">
                    <span>วันที่ทำ PM</span>
                </div>
                <div class="col-sm-5">
                    <input type="text" required="required" class="form-control" id="dayDopmTextbox" runat="server" />
                </div>
            </div>


            <div class="row mt-3">
                <div class="col-md-12 bg-success text-white text-center Myfont">
                    <h3>PICTURE CHECKLIST</h3>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4" for="">รูปหน้าตู้ ก่อน-หลัง</label>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="picfontFontbackRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1385).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %>>PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="picfontFontbackRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1385).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %>>NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4" for="">รูปภายในตู้ ก่อน-หลัง</label>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="picInFontbackRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1386).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %>>PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="picInFontbackRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1386).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %>>NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4" for="">รูปขณะทำความสะอาดตู้ ก่อน-หลัง</label>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="cleanfontbackRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1387).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %>>PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="cleanfontbackRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1387).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %>>NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4" for="">รูปสถานะ Circuit Breaker (ON)</label>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="picstatusCircuitRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1388).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %>>PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="picstatusCircuitRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1388).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %>>NOT PASS
                    </label>
                </div>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-4" for="">รูปการจับยึด Bar Ground และการต่อ Ground</label>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="picBargroundRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1389).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %>>PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="picBargroundRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1389).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %>>NOT PASS
                    </label>
                </div>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-4" for="">รูปการตรวจสอบสถานะไฟฟ้ารั่วลง Ground (Lamp Test)</label>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="picStatusGroundRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1390).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %>>PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="picStatusGroundRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1390).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %>>NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4" for="">รูป PEA Meter</label>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="picPEAMeterRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1391).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %>>PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="picPEAMeterRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1391).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %>>NOT PASS
                    </label>
                </div>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-4" for="">รูปการวัดแรงดัน AC และกระแส AC </label>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="picACradio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1392).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %>>PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="picACradio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1392).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %>>NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4" for="">รูปแรงดัน DC และกระแส DC </label>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="picDCradio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1393).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %>>PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="picDCradio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1393).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %>>NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4" for="">รูปการวัดแรงดัน Battery รวม </label>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="picBatteryAllRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1394).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %>>PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="picBatteryAllRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1394).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %>>NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4" for="">รูปการวัดแรงดัน Battery ก้อนที่ 1 และ Serial NO.  </label>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="picBatteryRadio1" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1395).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %>>PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="picBatteryRadio1" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1395).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %>>NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4" for="">รูปการวัดแรงดัน Battery ก้อนที่ 2 และ Serial NO. </label>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="picBatteryRadio2" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1396).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %>>PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="picBatteryRadio2" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1396).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %>>NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4" for="">รูปการวัดแรงดัน Battery ก้อนที่ 3 และ Serial NO.</label>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="picBatteryRadio3" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1397).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %>>PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="picBatteryRadio3" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1397).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %>>NOT PASS
                    </label>
                </div>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-4" for="">รูปการวัดแรงดัน Battery ก้อนที่ 4 และ Serial NO. </label>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="picBatteryRadio4" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1398).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %>>PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="picBatteryRadio4" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1398).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %>>NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4" for="">รูปการ Test Door Alarm </label>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="picTestDoorRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1399).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %>>PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="picTestDoorRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1399).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %>>NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4" for="">รูปการ Test Rectifier 1 Comm. Fail  Alarm </label>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="picTestRetifier1" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1400).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %>>PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="picTestRetifier1" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1400).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %>>NOT PASS
                    </label>
                </div>
            </div>
            <div class="form-row mt-3">
                <label class="control-label col-sm-4" for="">รูปการ Test Rectifier 2 Comm. Fail  Alarm </label>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="picTestRetifier2" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1401).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %>>PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="picTestRetifier2" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1401).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %>>NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4" for="">รูป Rectifier Module และ Serial NO.</label>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="picRetifierModule" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1402).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %>>PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="picRetifierModule" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1402).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %>>NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4" for="">รูป Cable Inlet ด้านในและด้านนอก </label>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="picCableinlet" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1403).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %>>PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="picCableinlet" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1403).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %>>NOT PASS
                    </label>
                </div>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-4" for="">รูป ODF โดยรวม </label>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="picODFAll" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1404).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %>>PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="picODFAll" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1404).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %>>NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4" for="">รูปอุปกรณ์ OLT โดยรวม</label>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="picOLTAll" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1405).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %>>PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="picOLTAll" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1405).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %>>NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4" for="">รูป Control Rectifier แสดงแรงดันและกระแส Load </label>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="picConRetifier" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1406).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %>>PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="picConRetifier" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1406).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %>>NOT PASS
                    </label>
                </div>
            </div>






            <div class="row mt-3">
                <div class="col-sm-12 text-black text-center Myfont">
                    <h3>รูปภาพประกอบรายงาน</h3>
                </div>
            </div>



            <%---------------------- QuestionId = 259  ---------------------------%>
            <div class="row mt-3 ">
                <div class="col-sm-12">1.รูป PICTURE CHECKLIST </div>
                <asp:FileUpload ID="pictureChecklistImages" runat="server" data-thumbnail="user_img_2" accept="image/" onchange="previewImage(this)" />
                <%-- <input type="file" name="image2" onchange="previewImage(this)" accept="image/*" data-thumbnail="user_img_2" />--%>
            </div>
            <div class="row ml-3 mt-3">
                <img id="user_img_2" src='<% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1407).Count() > 0) Response.Write(answers.Where(x => x.QuestionId == 1407).FirstOrDefault().AnsDes); %>' class="placeholder2" />
            </div>



            <div class="row justify-content-center mt-5">
                <div class="col-md-6">
                    <asp:Button ID="SubmitButton" runat="server" Text="บันทึก" CssClass="btn btn-primary btn-block" OnClick="SubmitButton_Click" OnClientClick="return signatureValidation();" />
                </div>
            </div>


            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    </form>








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


    <%---------//  NEW Signature  //-----------%>
    <script>
        var signaturePad = new SignaturePad(document.getElementById('signature-pad'), {
            backgroundColor: 'rgba(255, 255, 255, 0)',
            penColor: 'rgb(0, 0, 0)'
        });      
    </script>
    <script>
        var signaturePad2 = new SignaturePad(document.getElementById('signature-pad2'), {
            backgroundColor: 'rgba(255, 255, 255, 0)',
            penColor: 'rgb(0, 0, 0)'
        });
    </script>

    <script>
        function signatureValidation() {
            //SIGNATURE EXECUTOR PAD
            var data = signaturePad.toDataURL('image/png')
            console.log("data 1 is =>", data);
            SignatureHiddenfieldExecutor.value = data;
            console.log('Signature Hiddenfield Executor is =>' + SignatureHiddenfieldExecutor.value);

            //SIGNATURE SUPERVISOR PAD
            var dataSignatureSupervisor = signaturePad2.toDataURL('image/png');
            console.log("data 2 is =>", dataSignatureSupervisor);
            SignatureHiddenfieldSupervisor.value = dataSignatureSupervisor;
            console.log('Signature Hiddenfield Supervisor is =>' + SignatureHiddenfieldSupervisor.value);

            if (SignatureHiddenfieldExecutor.value == SignatureHiddenfieldSupervisor.value) {
                alert('กรุณาเซ็นลายเซ็นด้วยค่ะ');
                return false;
            }

        }
    </script>
</body>
</html>
