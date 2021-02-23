<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="USOform.Preventive_Maintenance__PM__Report_BB2._4.WebForm1" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>รายงาน PM From BB Zone C+ บริการที่ 2.4</title>
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link href="../style/Mystyle.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous" />
    <%------//     font style    //------------------------------------------------------------%>
    <link rel="preconnect" href="https://fonts.gstatic.com" />
    <link href="https://fonts.googleapis.com/css2?family=Sarabun:wght@100;300;400;500;600;700&display=swap" rel="stylesheet" />
    <%-------//    DATE time picker JQURRY   //-------------------------------------------------%>
    <link rel="stylesheet" href="//code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css" />
    <link rel="stylesheet" href="/resources/demos/style.css" />
    <script src="https://code.jquery.com/jquery-1.12.4.js"></script>
    <script src="https://code.jquery.com/ui/1.12.1/jquery-ui.js"></script>
    <link href="http://ajax.googleapis.com/ajax/libs/jqueryui/1.12.1/themes/south-street/jquery-ui.css" rel="stylesheet" />
    <link href="../style/Mystyle.css" rel="stylesheet" />
    <meta http-equiv="Content-Type" content="text/html;charset=utf-8" />
    <%-------//   PREVIEW IMAGES   //------------------------------------------------------------%>
    <script src="previewImg.js"></script>
    <%--------------- //   Signature     //-----------------------%>
    <link href="../sig/css/jquery.signature.css" rel="stylesheet" />
    <script src="../sig/js/jquery.signature.min.js"></script>
    <script src="../sig/js/results.js"></script>
    <%----------------//  Important must have for signature !  //--------------------------------%>
    <meta http-equiv="Content-Type" content="text/html;charset=utf-8" />
    <meta http-equiv="Content-Security-Policy" content="upgrade-insecure-requests" />
    <link href="http://ajax.googleapis.com/ajax/libs/jqueryui/1.12.1/themes/south-street/jquery-ui.css" rel="stylesheet" />
    <%--//  SIGNATURE PAD  //--%>
    <script src="https://cdn.jsdelivr.net/npm/signature_pad@2.3.2/dist/signature_pad.min.js"></script>
    <style>
        .kbw-signature {
            width: 300px;
            height: 200px;
            -ms-touch-action: none;
            touch-action: none;
        }

        table, tr, td {
            border: none;
        }

        .kbw-signature canvas {
            touch-action: none;
            -ms-touch-action: none;
        }
    </style>
</head>
<body style="background-color: lightgray;">
    <form id="form1" runat="server">
        <div class="container bg-white Myfont mt-3">
            <%--------------------------------------------    Section id = 25  -------------------------------------------------------%>
            <div class="row pt-5">
                <div class="col-4">
                    <asp:FileUpload ID="logoPictureff" runat="server" data-thumbnail="user_img_8" accept="image/" onchange="previewImage(this)" />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" Display="Dynamic" ControlToValidate="logoPictureff" ErrorMessage="กรุณากรอกข้อมูล !" SetFocusOnError="true" ForeColor="#FF0000" Font-Size="12" Font-Bold="true">
                    </asp:RequiredFieldValidator>
                    <img id="user_img_8" src='<% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 264).Count() > 0) Response.Write(answers.Where(x => x.QuestionId == 264).FirstOrDefault().AnsDes); %>' class="placeholder2 float-left" />
                </div>

                <div class="col-4  d-flex justify-content-center ">
                    <h5 class="headerText">Preventive Maintenance Site Report USO (PHO’s WIFI)</h5>
                </div>
                <div class="col-4 ">
                    <img src="../assets/logo_uso.png" class="logoImg" />
                </div>
            </div>



            <div class="row mt-5">
                <div class="col-12 text-left ">
                    <div>
                        <h5>รายงานผลการตรวจสอบ และบำรุงรักษาชุดอุปกรณ์ Broadband Internet Service (Preventive Maintenance (PM) Report)</h5>
                    </div>
                    <div>
                        <h5>โครงการจัดให้มีสัญญาณโทรศัพท์เคลื่อนที่และบริการอินเทอร์เน็ตความเร็วสูงในพื้นที่ชายขอบ (Zone C+) </h5>
                    </div>
                </div>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-1">กลุ่ม :</label>
                <div class="col-sm-4">
                    <input type="text" required="required" class="form-control" id="groupTextbox" runat="server" />
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-1">ภาค :</label>
                <div class="col-sm-4">
                    <input type="text" required="required" class="form-control" id="AreaTextbox" runat="server" />
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-1">บริษัท :</label>
                <div class="col-sm-4">
                    <input type="text" required="required" class="form-control" id="CompanyTextbox" runat="server" />
                </div>
            </div>



            <div class="form-row mt-3">
                <label class="control-label col-sm-12">ส่วนที่ 2 การจัดให้มีบริการสัญญาณโทรศัพท์เคลื่อนที่ (Mobile Service) ประเภทบริการที่ 2.4 </label>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-2">รอบการบำรุงรักษา ครั้งที่ </label>
                <div class="col-sm-1">
                    <input type="text" required="required" class="form-control" id="maintenanceCountTextbox" runat="server" />
                </div>
                /
              <div class="col-sm-1">
                  <input type="text" required="required" class="form-control" id="yearTextbox" runat="server" />
              </div>
            </div>



            <div class="row text-left mt-3">
                <div class="col-md-12">
                    <div>
                        <label>
                            <span>วัน เดือน ปี</span>&nbsp;&nbsp;&nbsp;&nbsp;
                        </label>
                        <input data-date-format="dd/mm/yyyy" id="startDatepicker" runat="server" placeholder="เดือน / วัน / ปี" />&nbsp;&nbsp;&nbsp;&nbsp;
                       <label>
                           <span>ถึง</span>
                       </label>
                        <input data-date-format="dd/mm/yyyy" id="endDatepicker" runat="server" placeholder="เดือน / วัน / ปี" />
                    </div>
                </div>
            </div>


            <%--1635--%>
            <div class="form-row mt-3">
                <label class="control-label col-sm-2">สถานที่ (Site code)</label>
                <div class="col-sm-4">
                    <input type="text" required="required" class="form-control" id="siteCodeTextbox" runat="server" />
                </div>
            </div>
            <%--//   END Section id = 25    //--%>







            <%------------------------------SECTION 27 --------------------------------------------------%>
            <div class="row mt-3">
                <div class="col-md-12 bg-primary text-white text-center Myfont">
                    <h4>PREVENTIVE MAINTENANCE SITE REPORT (PM)</h4>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-1" for="">Cabinet ID :</label>
                <div class="col-sm-11">
                    <input type="text" required="required" class="form-control" id="cabinetIdTextbox" runat="server" />
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-1" for="">Site Code :</label>
                <div class="col-sm-11">
                    <input type="text" required="required" class="form-control" id="sitecodeTextboxSection2" runat="server" />
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-1" for="">Village ID :</label>
                <div class="col-sm-11">
                    <input type="text" required="required" class="form-control" id="VillageIdTextbox" runat="server" />
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-1" for="">PHO’s Name :</label>
                <div class="col-sm-11">
                    <input type="text" required="required" class="form-control" id="phoNameTextbox" runat="server" />
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-1" for="">Village :</label>
                <div class="col-sm-11">
                    <input type="text" required="required" class="form-control" id="villageTextbox" runat="server" />
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-1" for="">Sub-District :</label>
                <div class="col-sm-11">
                    <input type="text" required="required" class="form-control" id="subdistrictTextbox" runat="server" />
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-1" for="">District :</label>
                <div class="col-sm-11">
                    <input type="text" required="required" class="form-control" id="DistrictTextbox" runat="server" />
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-1" for="">Province :</label>
                <div class="col-sm-11">
                    <input type="text" required="required" class="form-control" id="provinceTextbox" runat="server" />
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-1" for="">Type :</label>
                <div class="col-sm-11">
                    <input type="text" required="required" class="form-control" id="typeTextbox" runat="server" />
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-1" for="">PM Date :</label>
                <div class="col-sm-11">
                    <input type="text" required="required" class="form-control" id="pmdateTextbox" runat="server" />
                </div>
            </div>


            <div class="form-row mt-3">
                <div class="col-sm-12 bg-primary text-white">ใส่รูปหน้าตู้</div>
                <asp:FileUpload ID="picinfrontImages" runat="server" data-thumbnail="user_img_5" accept="image/" onchange="previewImage(this)" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" Display="Dynamic" ControlToValidate="picinfrontImages" ErrorMessage="กรุณากรอกข้อมูล !" SetFocusOnError="true" ForeColor="#FF0000" Font-Size="12" Font-Bold="true">
                </asp:RequiredFieldValidator>
            </div>
            <div class="row ml-3 mt-3">
                <img id="user_img_5" src='<% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1635).Count() > 0) Response.Write(answers.Where(x => x.QuestionId == 1635).FirstOrDefault().AnsDes); %>' class="placeholder2" />
            </div>


            <%-- //////////////////////////////////     Sectionid  = 28    /////////////////////////////////--%>

         <%--   <div class="row mt-3">
                <div class="col-md-12 bg-warning text-white text-center Myfont">
                    <h4>Contractor</h4>
                </div>
            </div>
            <div class="row">
                <div class="col-lg-6">
                    <div class="card">
                        <div class="card-header">
                            Executor
                        </div>
                        <div class="card-body">
                            <div id="signatureExecutorTextbox"></div>
                            <div id="redrawSignature1" hidden="hidden"></div>
                            <input type="hidden" id="signatureExecutorJSON" class="ui-state-active" runat="server" />
                            <div class="form-group">
                                <label>Name</label>
                                <input type="text" required="required" class="form-control" id="nameExecutorTextbox" runat="server" />
                            </div>
                            <div class="form-group">
                                <label>Date</label>
                                <input type="text" required="required" class="form-control" id="DateExecutorTextbox" runat="server" />
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
                            <div id="signatureSupervisorTextbox"></div>
                            <div id="redrawSignature1" hidden="hidden"></div>
                            <input type="hidden" id="signatureSupervisorJSON" class="ui-state-active" runat="server" />
                            <div class="form-group">
                                <label>Name</label>
                                <input type="text" required="required" class="form-control" id="nameSupervisorTextbox" runat="server" />
                            </div>
                            <div class="form-group">
                                <label>Date</label>
                                <input type="text" required="required" class="form-control" id="DateSupervisorTextbox" runat="server" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>--%>

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
                                   <button  type="button" id="save">save</button>
                                 <button type="button" id="clear">Clear</button>
                                </div>
                             <div class="form-group">
                                <label>Name</label>
                                <input type="text"  class="form-control" id="nameExecutorTextbox" runat="server" />
                            </div>
                            <div class="form-group">
                                <label>Date</label>
                                <input type="text"  class="form-control" id="DateExecutorTextbox" runat="server" />
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
                                <button type="button" id="save2">Save</button>
                                 <button type="button" id="clear2">Clear</button>
                                </div>                          
                            <div class="form-group">
                                <label>Name</label>
                                <input type="text"  class="form-control" id="nameSupervisorTextbox" runat="server" />
                            </div>
                            <div class="form-group">
                                <label>Date</label>
                                <input type="text"  class="form-control" id="DateSupervisorTextbox" runat="server" />
                            </div>                                       
                        </div>
                    </div>
                </div>
            </div>
            <%--FOR PREVIEW--%>
            <%-- <img id="user_img_6" src='<% if (answers.Count() > 0) Response.Write(answers.Where(x => x.QuestionId == 282).FirstOrDefault().AnsDes); %>' class="placeholder2" />--%>
            <%-- <img id="user_img_7" src='<% if (answers.Count() > 0) Response.Write(answers.Where(x => x.QuestionId == 283).FirstOrDefault().AnsDes); %>' class="placeholder2" />--%>


            <%--------------------------------//   END  Sectionid  = 28  //----------------------------------------%>




            <%-- //////////////////////////////////     Sectionid  = 29    /////////////////////////////////--%>
            <div class="row mt-3">
                <div class="col-md-12 bg-primary text-white text-center Myfont">
                    <h4>1. รายละเอียดสถานี</h4>
                </div>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-1" for="">Cabinet ID :</label>
                <div class="col-sm-11">
                    <input type="text" required="required" class="form-control" id="cabinetId2Textbox" runat="server" />
                </div>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-1" for="">Site code :</label>
                <div class="col-sm-11">
                    <input type="text" required="required" class="form-control" id="sitecodeTextboxSection4" runat="server" />
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-1" for="">Village ID :</label>
                <div class="col-sm-11">
                    <input type="text" required="required" class="form-control" id="villageIDTextboxSection4" runat="server" />
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-2" for="">LAT & LONG :</label>
                <div class="col-sm-10">
                    <input type="text" required="required" class="form-control" id="latandlongTextbox" runat="server" />
                </div>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-2" for="">Type of Signal</label>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="TypeofSignaleieiRadio" value="OFC" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 292).FirstOrDefault().AnsDes == "OFC") { Response.Write("checked"); } else { Response.Write(""); }  %>>OFC
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="TypeofSignaleieiRadio" value="Satellite" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 292).FirstOrDefault().AnsDes == "Satellite") { Response.Write("checked"); } else { Response.Write(""); }  %>>Satellite
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-1" for="">OLT ID :</label>
                <div class="col-sm-11">
                    <input type="text" required="required" class="form-control" id="oltIdTextbox" runat="server" />
                </div>
            </div>












            <%-- //////////////////////////////////     Sectionid  = 29    /////////////////////////////////--%>
            <div class="row mt-3">
                <div class="col-md-12 bg-primary text-white text-center Myfont">
                    <h4>2. ระบบไฟฟ้า (หลัก)</h4>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-2" for="">ระบบไฟฟ้า</label>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="voltSystemRadio" value="PEA" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 294).FirstOrDefault().AnsDes == "PEA") { Response.Write("checked"); } else { Response.Write(""); }  %> />PEA
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="voltSystemRadio" value="SolarCell" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 294).FirstOrDefault().AnsDes == "SolarCell") { Response.Write("checked"); } else { Response.Write(""); }  %>>Solar Cell
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-1" for="">หมายเลขผู้ใช้ไฟ</label>
                <div class="col-sm-11">
                    <input type="text" required="required" class="form-control" id="numberIdTextbox" runat="server" />
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-2" for="">หน่วยใช้ไฟ (kWh Meter)</label>
                <div class="col-sm-8">
                    <input type="text" required="required" class="form-control" id="kwhMeterTextbox" runat="server" />
                </div>
                <label class="control-label col-sm-2" for="">kWh</label>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-2" for="">แรงดัน AC (kWh Meter)</label>
                <div class="col-sm-8">
                    <input type="text" required="required" class="form-control" id="acvoltTextbox" runat="server" />
                </div>
                <label class="control-label col-sm-2" for="">V.</label>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-2" for="">กระแส Line AC (kWh Meter)</label>
                <div class="col-sm-8">
                    <input type="text" required="required" class="form-control" id="lineAcTextbox" runat="server" />
                </div>
                <label class="control-label col-sm-2" for="">A.</label>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-2" for="">กระแส Neutron AC (kWh Meter)</label>
                <div class="col-sm-8">
                    <input type="text" required="required" class="form-control" id="neutronAcEIEITextbox" runat="server" />
                </div>
                <label class="control-label col-sm-2" for="">A.</label>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-2" for="">สภาพ kWh Meter</label>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="conditionRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 300).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); }  %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="conditionRadio" value="ชำรุด/ใช้งานไม่ได้" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 300).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); }  %> />ชำรุด/ใช้งานไม่ได้
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-2" for="">สภาพ Circuit Breaker</label>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="MDBCircuitBreakerRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 301).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); }  %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="MDBCircuitBreakerRadio" value="ชำรุด/ใช้งานไม่ได้" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 301).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); }  %> />ชำรุด/ใช้งานไม่ได้
                    </label>
                </div>
            </div>








            <%-- //////////////////////////////////     Sectionid  = 30    /////////////////////////////////--%>

            <div class="row mt-3">
                <div class="col-md-12 bg-primary text-white text-center Myfont">
                    <h3>3.ระบบไฟฟ้า (สำรอง)</h3>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-2">UPS ภายในตู้</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="inupsRadio" value="มี" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 302).FirstOrDefault().AnsDes == "มี") { Response.Write("checked"); } else { Response.Write(""); }  %> />มี
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="inupsRadio" value="ไม่มี" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 302).FirstOrDefault().AnsDes == "ไม่มี") { Response.Write("checked"); } else { Response.Write(""); }  %> />ไม่มี
                    </label>
                </div>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-2">แรงดัน AC จาก UPS</label>
                <div class="col-sm-8">
                    <input type="text" required="required" class="form-control" id="acfromupsTextbox" runat="server" />
                </div>
                <label class="control-label col-sm-2">V.</label>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-2">ระดับกระแส Load </label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="voltageLoadRadio" value="1" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 304).FirstOrDefault().AnsDes == "1") { Response.Write("checked"); } else { Response.Write(""); }  %> />1
                    </label>
                </div>

                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="voltageLoadRadio" value="2" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 304).FirstOrDefault().AnsDes == "2") { Response.Write("checked"); } else { Response.Write(""); }  %> />2
                    </label>
                </div>

                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="voltageLoadRadio" value="3" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 304).FirstOrDefault().AnsDes == "3") { Response.Write("checked"); } else { Response.Write(""); }  %> />3
                    </label>
                </div>

                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="voltageLoadRadio" value="4" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 304).FirstOrDefault().AnsDes == "4") { Response.Write("checked"); } else { Response.Write(""); }  %> />4
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="voltageLoadRadio" value="5" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 304).FirstOrDefault().AnsDes == "5") { Response.Write("checked"); } else { Response.Write(""); }  %> />5
                    </label>
                </div>
                <label class="control-label col-sm-2">(ขีดล่าง =1 , ขีดบน = 5)</label>

            </div>



            <div class="form-row mt-3">
                <label class="control-label col-sm-2">ระดับความจุ Battery</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="batteryCapacityRadio" value="1" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 305).FirstOrDefault().AnsDes == "1") { Response.Write("checked"); } else { Response.Write(""); }  %> />1
                    </label>
                </div>

                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="batteryCapacityRadio" value="2" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 305).FirstOrDefault().AnsDes == "2") { Response.Write("checked"); } else { Response.Write(""); }  %> />2
                    </label>
                </div>

                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="batteryCapacityRadio" value="3" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 305).FirstOrDefault().AnsDes == "3") { Response.Write("checked"); } else { Response.Write(""); }  %> />3
                    </label>
                </div>

                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="batteryCapacityRadio" value="4" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 305).FirstOrDefault().AnsDes == "4") { Response.Write("checked"); } else { Response.Write(""); }  %> />4
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="batteryCapacityRadio" value="5" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 305).FirstOrDefault().AnsDes == "5") { Response.Write("checked"); } else { Response.Write(""); }  %> />5
                    </label>
                </div>
                <label class="control-label col-sm-2">(ขีดล่าง =1 , ขีดบน = 5)</label>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-2">UPS MODE</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="upsModeRadio" value="LINE" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 306).FirstOrDefault().AnsDes == "LINE") { Response.Write("checked"); } else { Response.Write(""); }  %> />LINE
                    </label>
                </div>

                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="upsModeRadio" value="BATT" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 306).FirstOrDefault().AnsDes == "BATT") { Response.Write("checked"); } else { Response.Write(""); }  %> />BATT.
                    </label>
                </div>

                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="upsModeRadio" value="BYPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 306).FirstOrDefault().AnsDes == "BYPASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />BYPASS
                    </label>
                </div>
            </div>




            <div class="form-row mt-3">
                <label class="control-label col-sm-2">การทำงานของระบบไฟสำรอง</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="secondFireRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 307).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); }  %> />ปกติ
                    </label>
                </div>

                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="secondFireRadio" value="ชำรุด/ใช้งานไม่ได้" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 307).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); }  %> />ชำรุด/ใช้งานไม่ได้
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-2">สภาพ Battery Bank</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="batterybankRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 308).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); }  %> />ปกติ
                    </label>
                </div>

                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="batterybankRadio" value="ชำรุด/ใช้งานไม่ได้" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 308).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); }  %> />ชำรุด/ใช้งานไม่ได้
                    </label>
                </div>
            </div>





            <%-- Sectionid  = 31    --%>
            <div class="row mt-3">
                <div class="col-md-12 bg-primary text-white text-center Myfont">
                    <h4>4.รายละเอียดอุปกรณ์ Network ภายในตู้</h4>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-3" for="">ONU/Modem Network</label>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="ONUModemNetworkRadio" value="USO" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 309).FirstOrDefault().AnsDes == "USO") { Response.Write("checked"); } else { Response.Write(""); }  %> />USO
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="ONUModemNetworkRadio" value="TRUE" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 309).FirstOrDefault().AnsDes == "TRUE") { Response.Write("checked"); } else { Response.Write(""); }  %> />TRUE
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="ONUModemNetworkRadio" value="3BB" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 309).FirstOrDefault().AnsDes == "3BB") { Response.Write("checked"); } else { Response.Write(""); }  %> />3BB
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="ONUModemNetworkRadio" value="Satellite" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 309).FirstOrDefault().AnsDes == "Satellite") { Response.Write("checked"); } else { Response.Write(""); }  %> />Satellite
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-3" for="">Power Supply (for Switch)</label>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="psuForswitchRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 310).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); }  %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="psuForswitchRadio" value="ชำรุด/ใช้งานไม่ได้" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 310).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); }  %> />ชำรุด/ใช้งานไม่ได้
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-3" for="">Switch 8 Port</label>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="switchPortRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 311).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); }  %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="switchPortRadio" value="ชำรุด/ใช้งานไม่ได้" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 311).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); }  %> />ชำรุด/ใช้งานไม่ได้
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-3" for="">Outdoor AP 2.4 GHz</label>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="OutdoorAP24Radio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 312).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); }  %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="OutdoorAP24Radio" value="ชำรุด/ใช้งานไม่ได้" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 312).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); }  %> />ชำรุด/ใช้งานไม่ได้
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-3" for="">Outdoor AP 5 GHz</label>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="OutdoorAP5GHzRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 313).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); }  %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="OutdoorAP5GHzRadio" value="ชำรุด/ใช้งานไม่ได้" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 313).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); }  %> />ชำรุด/ใช้งานไม่ได้
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-3" for="">ระบบระบายอากาศ (T-Power)</label>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="tPowerRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 314).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); }  %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="tPowerRadio" value="ชำรุด/ใช้งานไม่ได้" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 314).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); }  %> />ชำรุด/ใช้งานไม่ได้
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-3" for="">การ Wiring สายไฟและสาย Ground</label>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="WiringGroundRadio" value="เรียบร้อย" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 315).FirstOrDefault().AnsDes == "เรียบร้อย") { Response.Write("checked"); } else { Response.Write(""); }  %> />เรียบร้อย
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="WiringGroundRadio" value="ไม่เรียบร้อย" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 315).FirstOrDefault().AnsDes == "ไม่เรียบร้อย") { Response.Write("checked"); } else { Response.Write(""); }  %> />ไม่เรียบร้อย
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-3" for="">การ Wiring Patch cord และ สาย LAN</label>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="wirePatchRadio" value="เรียบร้อย" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 316).FirstOrDefault().AnsDes == "เรียบร้อย") { Response.Write("checked"); } else { Response.Write(""); }  %> />เรียบร้อย
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="wirePatchRadio" value="ไม่เรียบร้อย" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 316).FirstOrDefault().AnsDes == "ไม่เรียบร้อย") { Response.Write("checked"); } else { Response.Write(""); }  %> />ไม่เรียบร้อย
                    </label>
                </div>
            </div>




            <%-- Sectionid  = 32    --%>
            <div class="row mt-3">
                <div class="col-md-12 bg-success text-white text-center Myfont">
                    <h3>5. ระบบ Ground</h3>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">ความแข็งแรงจุดต่อ Ground Bar</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="groundbarRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 317).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); }  %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="groundbarRadio" value="ชำรุด" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 317).FirstOrDefault().AnsDes == "ชำรุด") { Response.Write("checked"); } else { Response.Write(""); }  %> />ชำรุด
                    </label>
                </div>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-4">ความแข็งแรงของน็อตขันหางปลาอุปกรณ์</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="notfishRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 318).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); }  %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="notfishRadio" value="ชำรุด" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 318).FirstOrDefault().AnsDes == "ชำรุด") { Response.Write("checked"); } else { Response.Write(""); }  %> />ชำรุด
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">สายกราวด์เรียบร้อย ปลอดภัย สมบูรณ์</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="safegroundRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 319).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); }  %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="safegroundRadio" value="ชำรุด" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 319).FirstOrDefault().AnsDes == "ชำรุด") { Response.Write("checked"); } else { Response.Write(""); }  %> />ชำรุด
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">สถานะไฟฟ้ารั่วลง Ground</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="brokenElecRadio" value="ไม่พบไฟฟ้ารั่ว" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 320).FirstOrDefault().AnsDes == "ไม่พบไฟฟ้ารั่ว") { Response.Write("checked"); } else { Response.Write(""); }  %> />ไม่พบไฟฟ้ารั่ว
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="brokenElecRadio" value="พบไฟฟ้ารั่ว" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 320).FirstOrDefault().AnsDes == "พบไฟฟ้ารั่ว") { Response.Write("checked"); } else { Response.Write(""); }  %> />พบไฟฟ้ารั่ว
                    </label>
                </div>
            </div>





            <%-- Sectionid  = 33    --%>
            <div class="row mt-3">
                <div class="col-md-12 bg-success text-white text-center Myfont">
                    <h3>6. สภาพแวดล้อมและความสะอาดโดยรอบ</h3>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">ป้ายและตัวเลขแสดงชื่อสถานี</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="signandnumberRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 321).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); }  %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="signandnumberRadio" value="ไม่ชัดเจน" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 321).FirstOrDefault().AnsDes == "ไม่ชัดเจน") { Response.Write("checked"); } else { Response.Write(""); }  %> />ไม่ชัดเจน
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">การติดตั้งและการยึดตู้อุปกรณ์</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="inStallRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 322).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); }  %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="inStallRadio" value="ชำรุด" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 322).FirstOrDefault().AnsDes == "ชำรุด") { Response.Write("checked"); } else { Response.Write(""); }  %> />ชำรุด
                    </label>
                </div>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-4">เสาไฟฟ้าที่ติดตั้งอุปกรณ์</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="inStallVoltRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 323).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); }  %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="inStallVoltRadio" value="ชำรุด/เอียง" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 323).FirstOrDefault().AnsDes == "ชำรุด/เอียง") { Response.Write("checked"); } else { Response.Write(""); }  %> />ชำรุด/เอียง
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">แนวสายไฟฟ้าและสายเคเบิ้ลเข้าสถานี</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="cabletoStationRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 327).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); }  %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="cabletoStationRadio" value="ชำรุด/เอียง" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 327).FirstOrDefault().AnsDes == "ชำรุด/เอียง") { Response.Write("checked"); } else { Response.Write(""); }  %> />ตกหย่อน/ไม่ได้จับยึด
                    </label>
                </div>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-4">ช่อง Cable Inlet  และความสะอาด</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="CableInletRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 324).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); }  %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="CableInletRadio" value="ไม่ได้อุดซิลีโคน" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 324).FirstOrDefault().AnsDes == "ไม่ได้อุดซิลีโคน") { Response.Write("checked"); } else { Response.Write(""); }  %> />ไม่ได้อุดซิลีโคน
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">ช่อง Filter ความสะอาด (T-Power)</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="filterRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 325).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); }  %>>ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="filterRadio" value="มีฝุ่น/สิ่งสกปรก" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 325).FirstOrDefault().AnsDes == "มีฝุ่น/สิ่งสกปรก") { Response.Write("checked"); } else { Response.Write(""); }  %> />มีฝุ่น/สิ่งสกปรก
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">ประตูและยางขอบประตูของตู้อุปกรณ์</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="doorToolsRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 326).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); }  %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="doorToolsRadio" value="ชำรุด" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 326).FirstOrDefault().AnsDes == "ชำรุด") { Response.Write("checked"); } else { Response.Write(""); }  %> />ชำรุด
                    </label>
                </div>
            </div>




            <%-- Sectionid  = 34    --%>
            <div class="row mt-3">
                <div class="col-md-12 bg-primary text-white text-center Myfont">
                    <h3>7.อุปกรณ์ระบบ VSAT (เฉพาะ Site ที่เป็น VSAT)</h3>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">อุปกรณ์ LNB/BUC</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="toolslnbRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 328).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); }  %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="toolslnbRadio" value="ชำรุด/ใช้งานไม่ได้" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 328).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); }  %> />ชำรุด/ใช้งานไม่ได้
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">การเก็บสาย RG และการพันหัว</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="wiringrgRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 329).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); }  %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="wiringrgRadio" value="ไม่เรียบร้อย/ไม่แน่น" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 329).FirstOrDefault().AnsDes == "ไม่เรียบร้อย/ไม่แน่น") { Response.Write("checked"); } else { Response.Write(""); }  %> />ไม่เรียบร้อย/ไม่แน่น
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">ฐานและระดับของเสาจาน</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="baseOnRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 330).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); }  %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="baseOnRadio" value="ไม่ได้ระดับ/เอียง" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 330).FirstOrDefault().AnsDes == "ไม่ได้ระดับ/เอียง") { Response.Write("checked"); } else { Response.Write(""); }  %> />ไม่ได้ระดับ/เอียง
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">แนว Line Of Sight</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="xxlineOfsightRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 331).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); }  %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="xxlineOfsightRadio" value="โดนบัง" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 331).FirstOrDefault().AnsDes == "โดนบัง") { Response.Write("checked"); } else { Response.Write(""); }  %> />โดนบัง
                    </label>
                </div>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-4">ความสะอาดของหน้าจาน</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="cleaningDishRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 332).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); }  %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="cleaningDishRadio" value="สกปรก" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 332).FirstOrDefault().AnsDes == "สกปรก") { Response.Write("checked"); } else { Response.Write(""); }  %> />สกปรก
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">LNB Band Switch</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="lnbbandswitchRadio" value="HIGHBAND" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 333).FirstOrDefault().AnsDes == "HIGHBAND") { Response.Write("checked"); } else { Response.Write(""); }  %> />HIGH BAND
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="lnbbandswitchRadio" value="LOWBAND" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 333).FirstOrDefault().AnsDes == "LOWBAND") { Response.Write("checked"); } else { Response.Write(""); }  %> />LOW BAND
                    </label>
                </div>
            </div>





            <%-- Sectionid  = 35    --%>
            <div class="row mt-3">
                <div class="col-md-12 bg-primary text-white text-center Myfont">
                    <h3>8.อุปกรณ์ระบบ Solar Cell (เฉพาะ Site ที่ใช้ Solar Cell)</h3>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">ระบบ Solar Cell</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="solarcellSystemRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 334).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); }  %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="solarcellSystemRadio" value="ชำรุด/ใช้งานไม่ได้" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 334).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); }  %> />ชำรุด/ใช้งานไม่ได้
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">แผง PV Panel</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="pvPanelRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 335).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); }  %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="pvPanelRadio" value="ชำรุด/ใช้งานไม่ได้" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 335).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); }  %> />ชำรุด/ใช้งานไม่ได้
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">อุปกรณ์ Charger</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="toolsCharger" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 336).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); }  %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="toolsCharger" value="ชำรุด/ใช้งานไม่ได้" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 336).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); }  %> />ชำรุด/ใช้งานไม่ได้
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">ความสะอาดแผง PV </label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="cleanIngpvRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 337).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); }  %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="cleanIngpvRadio" value="สกปรก" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 337).FirstOrDefault().AnsDes == "สกปรก") { Response.Write("checked"); } else { Response.Write(""); }  %> />สกปรก
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">การติดตั้งแผง PV </label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="installPvRadio" value="ที่โล่งรับแดดปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 338).FirstOrDefault().AnsDes == "ที่โล่งรับแดดปกติ") { Response.Write("checked"); } else { Response.Write(""); }  %> />ที่โล่งรับแดดปกติ 
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="installPvRadio" value="มีอาคาร/ต้นไม้บัง" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 338).FirstOrDefault().AnsDes == "มีอาคาร/ต้นไม้บัง") { Response.Write("checked"); } else { Response.Write(""); }  %> />มีอาคาร/ต้นไม้บัง
                    </label>
                </div>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-2">แรงดันไฟจาก Inverter</label>
                <div class="col-sm-8">
                    <input type="text" required="required" class="form-control" id="voltInverterTextbox" runat="server" />
                </div>
                <label class="control-label col-sm-2">V.</label>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-2">กระแส Load</label>
                <div class="col-sm-8">
                    <input type="text" required="required" class="form-control" id="loadVoltTageTextbox" runat="server" />
                </div>
                <label class="control-label col-sm-2">A.</label>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-2">แรงดัน Battery ก้อนที่ 1</label>
                <div class="col-sm-8">
                    <input type="text" required="required" class="form-control" id="batterTextbox1" runat="server" />
                </div>
                <label class="control-label col-sm-2">V.</label>
            </div>
            <div class="form-row mt-3">
                <label class="control-label col-sm-2">แรงดัน Battery ก้อนที่ 2</label>
                <div class="col-sm-8">
                    <input type="text" required="required" class="form-control" id="batterTextbox2" runat="server" />
                </div>
                <label class="control-label col-sm-2">V.</label>
            </div>
            <div class="form-row mt-3">
                <label class="control-label col-sm-2">แรงดัน Battery ก้อนที่ 3</label>
                <div class="col-sm-8">
                    <input type="text" required="required" class="form-control" id="batterTextbox3" runat="server" />
                </div>
                <label class="control-label col-sm-2">V.</label>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-2">แรงดัน Battery ก้อนที่ 4</label>
                <div class="col-sm-8">
                    <input type="text" required="required" class="form-control" id="batterTextbox4" runat="server" />
                </div>
                <label class="control-label col-sm-2">V.</label>
            </div>




            <%-- Sectionid  = 36    --%>
            <div class="row mt-3">
                <div class="col-md-12 bg-primary text-white text-center Myfont">
                    <h4>9.คุณภาพของสัญญาณ</h4>
                </div>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-3">Download (for ONU/VSAT)</label>
                <div class="col-sm-3">
                    <input type="text" required="required" class="form-control" id="dowloadOnuTextbox" runat="server" />
                </div>
                <label class="control-label col">Mb/s</label>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-3">Upload (for ONU/VSAT)</label>
                <div class="col-sm-3">
                    <input type="text" required="required" class="form-control" id="uploadforOnuTextbox" runat="server" />
                </div>
                <label class="control-label col">Mb/s</label>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-3">Ping Test (for ONU/VSAT)</label>
                <div class="col-sm-3">
                    <input type="text" required="required" class="form-control" id="pinngtestforOnuTextbox" runat="server" />
                </div>
                <label class="control-label col">ms</label>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-3">Download (for Mobile)</label>
                <div class="col-sm-3">
                    <input type="text" required="required" class="form-control" id="dowloadforMobileTextbox" runat="server" />
                </div>
                <label class="control-label col">Mb/s</label>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-3">Upload (for Mobile)</label>
                <div class="col-sm-3">
                    <input type="text" required="required" class="form-control" id="uploadforMobileTextbox" runat="server" />
                </div>
                <label class="control-label col">Mb/s</label>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-3">Ping Test (for Mobile)</label>
                <div class="col-sm-3">
                    <input type="text" required="required" class="form-control" id="pingtestFormobileTextbox" runat="server" />
                </div>
                <label class="control-label col-sm-2">Ms</label>
            </div>



            <%-- Sectionid  = 37     --%>
            <div class="row mt-3">
                <div class="col-md-12 bg-warning text-white text-center">
                    <h3>10. ปัญหาที่พบและการแก้ไข</h3>
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

                            <input type="text"  class="form-control" id="problemTextbox1" runat="server" />
                        </div>
                        <div class="divTableCell">

                            <input type="text"  class="form-control" id="howtoSolveTextbox1" runat="server" />
                        </div>
                    </div>

                    <div class="divTableRow">
                        <div class="divTableCell">&nbsp;2</div>
                        <div class="divTableCell">

                            <input type="text"  class="form-control" id="problemTextbox2" runat="server" />
                        </div>
                        <div class="divTableCell">

                            <input type="text"  class="form-control" id="howtoSolveTextbox2" runat="server" />
                        </div>
                    </div>

                    <div class="divTableRow">
                        <div class="divTableCell">&nbsp;3</div>
                        <div class="divTableCell">

                            <input type="text"  class="form-control" id="problemTextbox3" runat="server" />
                        </div>
                        <div class="divTableCell">

                            <input type="text"  class="form-control" id="howtoSolveTextbox3" runat="server" />
                        </div>
                    </div>

                    <div class="divTableRow">
                        <div class="divTableCell">&nbsp;4</div>
                        <div class="divTableCell">

                            <input type="text"  class="form-control" id="problemTextbox4" runat="server" />
                        </div>
                        <div class="divTableCell">

                            <input type="text"  class="form-control" id="howtoSolveTextbox4" runat="server" />
                        </div>
                    </div>

                    <div class="divTableRow">
                        <div class="divTableCell">&nbsp;5</div>
                        <div class="divTableCell">

                            <input type="text"  class="form-control" id="problemTextbox5" runat="server" />
                        </div>
                        <div class="divTableCell">

                            <input type="text"  class="form-control " id="howtoSolveTextbox5" runat="server" />
                        </div>
                    </div>
                    <div class="divTableRow">
                        <div class="divTableCell">&nbsp;6</div>
                        <div class="divTableCell">

                            <input type="text"  class="form-control" id="problemTextbox6" runat="server" />
                        </div>
                        <div class="divTableCell">

                            <input type="text"  class="form-control" id="howtoSolveTextbox6" runat="server" />
                        </div>
                    </div>
                    <div class="divTableRow">
                        <div class="divTableCell">&nbsp;7</div>
                        <div class="divTableCell">

                            <input type="text"  class="form-control" id="problemTextbox7" runat="server" />
                        </div>
                        <div class="divTableCell">

                            <input type="text"  class="form-control" id="howtoSolveTextbox7" runat="server" />
                        </div>
                    </div>
                    <div class="divTableRow">
                        <div class="divTableCell">&nbsp;8</div>
                        <div class="divTableCell">

                            <input type="text"  class="form-control" id="problemTextbox8" runat="server" />
                        </div>
                        <div class="divTableCell">

                            <input type="text"  class="form-control" id="howtoSolveTextbox8" runat="server" />
                        </div>
                    </div>
                    <div class="divTableRow">
                        <div class="divTableCell">&nbsp;9</div>
                        <div class="divTableCell">

                            <input type="text"  class="form-control" id="problemTextbox9" runat="server" />
                        </div>
                        <div class="divTableCell">

                            <input type="text"  class="form-control" id="howtoSolveTextbox9" runat="server" />
                        </div>
                    </div>
                    <div class="divTableRow">
                        <div class="divTableCell">&nbsp;10</div>
                        <div class="divTableCell">

                            <input type="text"  class="form-control" id="problemTextbox10" runat="server" />
                        </div>
                        <div class="divTableCell">

                            <input type="text"  class="form-control" id="howtoSolveTextbox10" runat="server" />
                        </div>
                    </div>
                    <div class="divTableRow">
                        <div class="divTableCell">&nbsp;11</div>
                        <div class="divTableCell">

                            <input type="text"  class="form-control" id="problemTextbox11" runat="server" />
                        </div>
                        <div class="divTableCell">

                            <input type="text"  class="form-control" id="howtoSolveTextbox11" runat="server" />
                        </div>
                    </div>
                    <div class="divTableRow">
                        <div class="divTableCell">&nbsp;12</div>
                        <div class="divTableCell">

                            <input type="text"  class="form-control" id="problemTextbox12" runat="server" />
                        </div>
                        <div class="divTableCell">

                            <input type="text"  class="form-control" id="howtoSolveTextbox12" runat="server" />
                        </div>
                    </div>
                    <div class="divTableRow">
                        <div class="divTableCell">&nbsp;13</div>
                        <div class="divTableCell">

                            <input type="text"  class="form-control" id="problemTextbox13" runat="server" />
                        </div>
                        <div class="divTableCell">

                            <input type="text"  class="form-control" id="howtoSolveTextbox13" runat="server" />
                        </div>
                    </div>
                    <div class="divTableRow">
                        <div class="divTableCell">&nbsp;14</div>
                        <div class="divTableCell">

                            <input type="text"  class="form-control" id="problemTextbox14" runat="server" />
                        </div>
                        <div class="divTableCell">

                            <input type="text"  class="form-control" id="howtoSolveTextbox14" runat="server" />
                        </div>
                    </div>
                    <div class="divTableRow">
                        <div class="divTableCell">&nbsp;15</div>
                        <div class="divTableCell">

                            <input type="text" class="form-control" id="problemTextbox15" runat="server" />
                        </div>
                        <div class="divTableCell">

                            <input type="text"  class="form-control" id="howtoSolveTextbox15" runat="server" />
                        </div>
                    </div>
                </div>
            </div>




            <%-- Sectionid  = 38     --%>
            <div class="row mt-3">
                <div class="col-md-12 bg-primary text-white text-center Myfont">
                    <h3>11.ข้อมูลรายการทรัพย์สิน</h3>
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

                                <input type="text"  class="form-control form-control-sm" id="toolsListTextbox1" runat="server" /></td>
                            <td>

                                <input type="text"  class="form-control form-control-sm" id="serialNumberTextbox1" runat="server" /></td>
                            <td>

                                <input type="text"  class="form-control form-control-sm" id="newSerialNumberTextbox1" runat="server" /></td>
                            <td>

                                <input type="text"  class="form-control form-control-sm" id="noteTextbox1" runat="server" /></td>
                        </tr>
                        <tr>

                            <td>2</td>
                            <td>

                                <input type="text"  class="form-control form-control-sm" id="toolsListTextbox2" runat="server" /></td>
                            <td>

                                <input type="text"  class="form-control form-control-sm" id="serialNumberTextbox2" runat="server" /></td>
                            <td>

                                <input type="text"  class="form-control form-control-sm" id="newSerialNumberTextbox2" runat="server" /></td>
                            <td>

                                <input type="text"  class="form-control form-control-sm" id="noteTextbox2" runat="server" /></td>
                        </tr>
                        <tr>
                            <td>3</td>
                            <td>

                                <input type="text"  class="form-control form-control-sm" id="toolsListTextbox3" runat="server" /></td>
                            <td>

                                <input type="text"  class="form-control form-control-sm" id="serialNumberTextbox3" runat="server" /></td>
                            <td>

                                <input type="text"  class="form-control form-control-sm" id="newSerialNumberTextbox3" runat="server" /></td>
                            <td>

                                <input type="text"  class="form-control form-control-sm" id="noteTextbox3" runat="server" /></td>
                        </tr>
                        <tr>
                            <td>4</td>
                            <td>

                                <input type="text"  class="form-control form-control-sm" id="toolsListTextbox4" runat="server" /></td>
                            <td>

                                <input type="text"  class="form-control form-control-sm" id="serialNumberTextbox4" runat="server" /></td>
                            <td>

                                <input type="text"  class="form-control form-control-sm" id="newSerialNumberTextbox4" runat="server" /></td>
                            <td>

                                <input type="text"  class="form-control form-control-sm" id="noteTextbox4" runat="server" /></td>
                        </tr>
                        <tr>
                            <td>5</td>
                            <td>

                                <input type="text"  class="form-control form-control-sm" id="toolsListTextbox5" runat="server" /></td>
                            <td>

                                <input type="text"  class="form-control form-control-sm" id="serialNumberTextbox5" runat="server" /></td>
                            <td>

                                <input type="text"  class="form-control form-control-sm" id="newSerialNumberTextbox5" runat="server" /></td>
                            <td>

                                <input type="text"  class="form-control form-control-sm" id="noteTextbox5" runat="server" /></td>
                        </tr>
                        <tr>
                            <td>6</td>
                            <td>

                                <input type="text"  class="form-control form-control-sm" id="toolsListTextbox6" runat="server" /></td>
                            <td>

                                <input type="text"  class="form-control form-control-sm" id="serialNumberTextbox6" runat="server" /></td>
                            <td>

                                <input type="text"  class="form-control form-control-sm" id="newSerialNumberTextbox6" runat="server" /></td>
                            <td>

                                <input type="text"  class="form-control form-control-sm" id="noteTextbox6" runat="server" /></td>
                        </tr>
                        <tr>
                            <td>7</td>
                            <td>

                                <input type="text"  class="form-control form-control-sm" id="toolsListTextbox7" runat="server" /></td>
                            <td>

                                <input type="text"  class="form-control form-control-sm" id="serialNumberTextbox7" runat="server" /></td>
                            <td>

                                <input type="text"  class="form-control form-control-sm" id="newSerialNumberTextbox7" runat="server" /></td>
                            <td>

                                <input type="text"  class="form-control form-control-sm" id="noteTextbox7" runat="server" /></td>
                        </tr>
                        <tr>
                            <td>8</td>
                            <td>

                                <input type="text"  class="form-control form-control-sm" id="toolsListTextbox8" runat="server" /></td>
                            <td>

                                <input type="text"  class="form-control form-control-sm" id="serialNumberTextbox8" runat="server" /></td>
                            <td>

                                <input type="text"  class="form-control form-control-sm" id="newSerialNumberTextbox8" runat="server" /></td>
                            <td>

                                <input type="text"  class="form-control form-control-sm" id="noteTextbox8" runat="server" /></td>
                        </tr>
                        <tr>
                            <td>9</td>
                            <td>

                                <input type="text"  class="form-control form-control-sm" id="toolsListTextbox9" runat="server" /></td>
                            <td>

                                <input type="text"  class="form-control form-control-sm" id="serialNumberTextbox9" runat="server" /></td>
                            <td>

                                <input type="text"  class="form-control form-control-sm" id="newSerialNumberTextbox9" runat="server" /></td>
                            <td>

                                <input type="text"  class="form-control form-control-sm" id="noteTextbox9" runat="server" /></td>
                        </tr>
                        <tr>
                            <td>10</td>
                            <td>

                                <input type="text"  class="form-control form-control-sm" id="toolsListTextbox10" runat="server" /></td>
                            <td>

                                <input type="text"  class="form-control form-control-sm" id="serialNumberTextbox10" runat="server" /></td>
                            <td>

                                <input type="text"  class="form-control form-control-sm" id="newSerialNumberTextbox10" runat="server" /></td>
                            <td>

                                <input type="text"  class="form-control form-control-sm" id="noteTextbox10" runat="server" /></td>
                        </tr>
                        <tr>
                            <td>11</td>
                            <td>

                                <input type="text"  class="form-control form-control-sm" id="toolsListTextbox11" runat="server" /></td>
                            <td>

                                <input type="text"  class="form-control form-control-sm" id="serialNumberTextbox11" runat="server" /></td>
                            <td>

                                <input type="text"  class="form-control form-control-sm" id="newSerialNumberTextbox11" runat="server" /></td>
                            <td>

                                <input type="text"  class="form-control form-control-sm" id="noteTextbox11" runat="server" /></td>
                        </tr>
                        <tr>
                            <td>12</td>
                            <td>

                                <input type="text"  class="form-control form-control-sm" id="toolsListTextbox12" runat="server" /></td>
                            <td>

                                <input type="text"  class="form-control form-control-sm" id="serialNumberTextbox12" runat="server" /></td>
                            <td>

                                <input type="text"  class="form-control form-control-sm" id="newSerialNumberTextbox12" runat="server" /></td>
                            <td>

                                <input type="text"  class="form-control form-control-sm" id="noteTextbox12" runat="server" /></td>
                        </tr>
                        <tr>
                            <td>13</td>
                            <td>

                                <input type="text"  class="form-control form-control-sm" id="toolsListTextbox13" runat="server" /></td>
                            <td>

                                <input type="text"  class="form-control form-control-sm" id="serialNumberTextbox13" runat="server" /></td>
                            <td>

                                <input type="text"  class="form-control form-control-sm" id="newSerialNumberTextbox13" runat="server" /></td>
                            <td>

                                <input type="text"  class="form-control form-control-sm" id="noteTextbox13" runat="server" /></td>
                        </tr>
                        <tr>
                            <td>14</td>
                            <td>

                                <input type="text"  class="form-control form-control-sm" id="toolsListTextbox14" runat="server" /></td>
                            <td>

                                <input type="text"  class="form-control form-control-sm" id="serialNumberTextbox14" runat="server" /></td>
                            <td>

                                <input type="text"  class="form-control form-control-sm" id="newSerialNumberTextbox14" runat="server" /></td>
                            <td>

                                <input type="text"  class="form-control form-control-sm" id="noteTextbox14" runat="server" /></td>
                        </tr>
                        <tr>
                            <td>15</td>
                            <td>

                                <input type="text"  class="form-control form-control-sm" id="toolsListTextbox15" runat="server" /></td>
                            <td>

                                <input type="text"  class="form-control form-control-sm" id="serialNumberTextbox15" runat="server" /></td>
                            <td>

                                <input type="text"  class="form-control form-control-sm" id="newSerialNumberTextbox15" runat="server" /></td>
                            <td>

                                <input type="text"  class="form-control form-control-sm" id="noteTextbox15" runat="server" /></td>
                        </tr>
                    </tbody>
                </table>
            </div>









            <%--SECTION 39 --%>
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
                    <input type="text" required="required" class="form-control" id="nameDopmTextbox" runat="server" />
                </div>
            </div>
            <div class="row mt-3">
                <div class="col-md-3 text-center">
                    <span>วันที่ทำ PM</span>
                </div>
                <div class="col-md-9">
                    <input type="text" required="required" class="form-control" id="dayDopmTextbox" runat="server" />
                </div>
            </div>


            <%--SECTION 40 --%>
            <div class="row mt-3">
                <div class="col-md-12 bg-success text-white text-center Myfont">
                    <h3>PICTURE CHECKLIST</h3>
                </div>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูปภาพรวมบริเวณ Site</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="steAreaRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 443).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="steAreaRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 443).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูปหน้าตู้ ก่อน-หลัง</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="beforeAfterRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 444).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="beforeAfterRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 444).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูปภายในตู้ ก่อน-หลัง</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="picIncontainRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 445).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="picIncontainRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 445).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูปขณะทำความสะอาดตู้ ก่อน-หลัง</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="beforeCleanRaio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 446).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="beforeCleanRaio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 446).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูปสถานะ Circuit Breaker (ON)</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="circuitBreakOnRaio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 447).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="circuitBreakOnRaio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 447).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูปการตรวจสอบ Ground และ Bar Ground</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="GroundAndBarGroundRaio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 448).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="GroundAndBarGroundRaio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 448).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />NOT PASS
                    </label>
                </div>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูปการตรวจสอบสถานะไฟฟ้ารั่วลง Ground (Lamp Test)</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="groundLampRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 449).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="groundLampRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 449).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูป PEA Meter</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="peaMeterRaio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 450).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="peaMeterRaio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 450).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูปการวัดแรงดัน AC และกระแส AC </label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="acAndACRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 451).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="acAndACRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 451).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูปหน้าจอ UPS แสดงค่าต่างๆ และ Serial NO.  </label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="monitorSerRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 452).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="monitorSerRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 452).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูป ONU/Modem พร้อม Serial NO. และ MAC </label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="ONUModemAndMacRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 453).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="ONUModemAndMacRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 453).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />NOT PASS
                    </label>
                </div>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูป Power Supply พร้อม Serial NO. </label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="psuAndSerialRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 454).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="psuAndSerialRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 454).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูป Switch 8 Port พร้อม Serial NO. และ MAC</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="switch8PortRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 455).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="switch8PortRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 455).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูป Outdoor AP 2.4 GHz พร้อม Serial NO. และ MAC</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="outDoorApRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 456).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="outDoorApRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 456).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูป Outdoor AP 5 GHz พร้อม Serial NO. และ MAC</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="outDoorAp5GhzRadioWithser" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 457).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="outDoorAp5GhzRadioWithser" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 457).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />NOT PASS
                    </label>
                </div>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูปการ Test Speed ONU (30/10 mbps) </label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="testSpeedOnuRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 458).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="testSpeedOnuRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 458).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูปการ Test Speed VSAT (30/5 mbps) *เฉพาะ SAT</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="testSpeedVsatRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 459).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="testSpeedVsatRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 459).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูป Cable Inlet ด้านในและด้านนอก</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="eieicableInletRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 460).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="eieicableInletRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 460).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูป Filter ก่อน-หลัง ทำความสะอาด</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="filterBeforeCleanRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 461).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="filterBeforeCleanRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 461).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />NOT PASS
                    </label>
                </div>
            </div>


            <%--SECTION 41--%>
            <div class="row mt-3">
                <div class="col-md-12 bg-primary text-white text-center Myfont">
                    <h3>VSAT PICTURE CHECKLIST</h3>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูปจุดติดตั้งจานดาวเทียม</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="inStallSatRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 462).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="inStallSatRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 462).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูปความสะอาดบริเวณจานดาวเทียม</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="cleanSatRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 463).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="cleanSatRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 463).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูป LNB พร้อม Part NO.</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="lnbWithpartRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 464).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="lnbWithpartRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 464).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูป BUC พร้อม Part NO.</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="bucWithpartRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 465).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="bucWithpartRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 465).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูปการเก็บสายและพันหัวที่ LNB/BUC</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="wireingLnbRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 466).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="wireingLnbRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 466).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูปแนว Line Of Sight (ดูการถูกบังของหน้าจานดาวเทียม)</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="lineOfsightRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 467).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" required="required" class="form-check-input" name="lineOfsightRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 467).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />NOT PASS
                    </label>
                </div>
            </div>


            <%--section 42--%>
            <div class="row mt-3">
                <div class="col-md-12 bg-primary text-white text-center Myfont">
                    <h3>SOLAR CELL PICTURE CHECKLIST</h3>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4" for="">รูปจุดติดตั้ง Solar Cell</label>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="solarCellRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 468).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="solarCellRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 468).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4" for="">รูปอุปกรณ์ภายในตู้ Solar Cell</label>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="toolsinSolarcellRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 469).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="toolsinSolarcellRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 469).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4" for="">รูปหน้าจอ Charger แสดงค่าต่างๆ</label>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="chargerRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 470).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="chargerRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 470).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4" for="">รูปหน้าจอ Inverter แสดงค่าต่างๆ</label>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="snowingInverterRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 471).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="snowingInverterRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 471).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />NOT PASS
                    </label>
                </div>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-4" for="">รูป Circuit Breaker ภายในตู้</label>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="cirBreakerRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 472).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="cirBreakerRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 472).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4" for="">รูป Terminal ต่อสายภายในตู้</label>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="termialInnerRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 473).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="termialInnerRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 473).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4" for="">รูปการวัดแรงดัน Battery ก้อนที่ 1</label>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="batteryVoltRadio1" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 474).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="batteryVoltRadio1" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 474).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4" for="">รูปการวัดแรงดัน Battery ก้อนที่ 2</label>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="batteryVoltRadio2" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 475).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="batteryVoltRadio2" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 475).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4" for="">รูปการวัดแรงดัน Battery ก้อนที่ 3</label>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="batteryVoltRadio3" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 476).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="batteryVoltRadio3" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 476).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4" for="">รูปการวัดแรงดัน Battery ก้อนที่ 4</label>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="batteryVoltRadio4" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 477).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="batteryVoltRadio4" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 477).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4" for="">รูปความสะอาดแผง PV</label>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="cleaninPVVRADIO" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 478).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="cleaninPVVRADIO" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 478).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />NOT PASS
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-4" for="">รูปภาพรวมดูสิ่งบดบังแสงอาทิตย์</label>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="sunnyRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 479).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" required="required" class="form-check-input" name="sunnyRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 479).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); }  %> />NOT PASS
                    </label>
                </div>
            </div>


            <div class="row mt-3">
                <div class="col-md-12  text-black text-center Myfont">
                    <h3>รูปภาพประกอบรายงาน</h3>
                </div>
            </div>
            <div class="row mt-3 ">
                <div class="col-sm-12">1.รูป PICTURE CHECKLIST </div>
                <asp:FileUpload ID="pictureChecklistImages" runat="server" data-thumbnail="user_img_2" accept="image/" onchange="previewImage(this)" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" Display="Dynamic" ControlToValidate="pictureChecklistImages" ErrorMessage="กรุณากรอกข้อมูล !" SetFocusOnError="true" ForeColor="#FF0000" Font-Size="12" Font-Bold="true">
                </asp:RequiredFieldValidator>

            </div>
            <div class="row ml-3 mt-3">
                <img id="user_img_2" src='<% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 480).Count() > 0) Response.Write(answers.Where(x => x.QuestionId == 480).FirstOrDefault().AnsDes); %>' class="placeholder2" />
            </div>

            <div class="row mt-3">
                <div class="col-sm-12">2.รูป VSAT PICTURE CHECKLIST</div>
                <asp:FileUpload ID="vsatpictureChecklistImages" runat="server" data-thumbnail="user_img_3" accept="image/" onchange="previewImage(this)" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" Display="Dynamic" ControlToValidate="vsatpictureChecklistImages" ErrorMessage="กรุณากรอกข้อมูล !" SetFocusOnError="true" ForeColor="#FF0000" Font-Size="12" Font-Bold="true">
                </asp:RequiredFieldValidator>
            </div>
            <div class="row ml-3 mt-3">
                <img id="user_img_3" src='<% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 481).Count() > 0) Response.Write(answers.Where(x => x.QuestionId == 481).FirstOrDefault().AnsDes); %>' class="placeholder2" />
            </div>

            <div class="row mt-3">
                <div class="col-sm-12">3.รูป SOLAR CELL PICTURE CHECKLIST</div>
                <asp:FileUpload ID="solarcellpictureChecklistImages" runat="server" data-thumbnail="user_img_4" accept="image/" onchange="previewImage(this)" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" Display="Dynamic" ControlToValidate="solarcellpictureChecklistImages" ErrorMessage="กรุณากรอกข้อมูล !" SetFocusOnError="true" ForeColor="#FF0000" Font-Size="12" Font-Bold="true">
                </asp:RequiredFieldValidator>
            </div>
            <div class="row ml-3 mt-3">
                <img id="user_img_4" src='<% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 482).Count() > 0) Response.Write(answers.Where(x => x.QuestionId == 482).FirstOrDefault().AnsDes); %>' class="placeholder2" />
            </div>


            <div class="row mt-5 justify-content-center">
                <div class="col-md-6">
                    <asp:Button ID="SubmitButton" runat="server" Text="บันทึก" CssClass="btn btn-primary btn-block" OnClick="SubmitButton_Click" OnClientClick="return signatureValidation();" />
                </div>
            </div>
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>





    <style type="text/css">
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
    </style>


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

    

   <%--//  NEW Signature  //--%> 
   <script>
       var signaturePad = new SignaturePad(document.getElementById('signature-pad'), {
           backgroundColor: 'rgba(255, 255, 255, 0)',
           penColor: 'rgb(0, 0, 0)'
       });
       // console.log(signaturePad);});
       var saveButton = document.getElementById('save');
       var cancelButton = document.getElementById('clear');

       saveButton.addEventListener('click', function (event) {
           var data = signaturePad.toDataURL('image/png')
           console.log("data 1 is =>", data);
           SignatureHiddenfieldExecutor.value = data;
           alert('Signature Hiddenfield Executor is =>' + SignatureHiddenfieldExecutor.value);
           // Send data to server instead...

       });

       cancelButton.addEventListener('click', function (event) {
           signaturePad.clear();
       });
   </script>


      <script>
          var signaturePad2 = new SignaturePad(document.getElementById('signature-pad2'), {
              backgroundColor: 'rgba(255, 255, 255, 0)',
              penColor: 'rgb(0, 0, 0)'
          });


          var saveButton2 = document.getElementById('save2');
          var cancelButton2 = document.getElementById('clear2');

          saveButton2.addEventListener('click', function (event) {
              var dataSignatureSupervisor = signaturePad2.toDataURL('image/png');
              console.log("data 2 is =>", dataSignatureSupervisor);
              SignatureHiddenfieldSupervisor.value = dataSignatureSupervisor;
              alert('Signature Hiddenfield Supervisor is =>' + SignatureHiddenfieldSupervisor.value);
          });

          cancelButton2.addEventListener('click', function (event) {
              signaturePad2.clear();
          });
      </script>
    <style type="text/css">
        .wrapper {
            position: relative;
            width: 400px;
            height: 200px;
            -moz-user-select: none;
            -webkit-user-select: none;
            -ms-user-select: none;
            user-select: none;
        }

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
    </style>
    <script>
        function signatureValidation()
        {
            //var imgNull = "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAZAAAADICAYAAADGFbfiAAAHFklEQVR4Xu3VsQ0AAAjDMPr/0/yQ2exdLKTsHAECBAgQCAILGxMCBAgQIHAC4gkIECBAIAkISGIzIkCAAAEB8QMECBAgkAQEJLEZESBAgICA+AECBAgQSAICktiMCBAgQEBA/AABAgQIJAEBSWxGBAgQICAgfoAAAQIEkoCAJDYjAgQIEBAQP0CAAAECSUBAEpsRAQIECAiIHyBAgACBJCAgic2IAAECBATEDxAgQIBAEhCQxGZEgAABAgLiBwgQIEAgCQhIYjMiQIAAAQHxAwQIECCQBAQksRkRIECAgID4AQIECBBIAgKS2IwIECBAQED8AAECBAgkAQFJbEYECBAgICB+gAABAgSSgIAkNiMCBAgQEBA/QIAAAQJJQEASmxEBAgQICIgfIECAAIEkICCJzYgAAQIEBMQPECBAgEASEJDEZkSAAAECAuIHCBAgQCAJCEhiMyJAgAABAfEDBAgQIJAEBCSxGREgQICAgPgBAgQIEEgCApLYjAgQIEBAQPwAAQIECCQBAUlsRgQIECAgIH6AAAECBJKAgCQ2IwIECBAQED9AgAABAklAQBKbEQECBAgIiB8gQIAAgSQgIInNiAABAgQExA8QIECAQBIQkMRmRIAAAQIC4gcIECBAIAkISGIzIkCAAAEB8QMECBAgkAQEJLEZESBAgICA+AECBAgQSAICktiMCBAgQEBA/AABAgQIJAEBSWxGBAgQICAgfoAAAQIEkoCAJDYjAgQIEBAQP0CAAAECSUBAEpsRAQIECAiIHyBAgACBJCAgic2IAAECBATEDxAgQIBAEhCQxGZEgAABAgLiBwgQIEAgCQhIYjMiQIAAAQHxAwQIECCQBAQksRkRIECAgID4AQIECBBIAgKS2IwIECBAQED8AAECBAgkAQFJbEYECBAgICB+gAABAgSSgIAkNiMCBAgQEBA/QIAAAQJJQEASmxEBAgQICIgfIECAAIEkICCJzYgAAQIEBMQPECBAgEASEJDEZkSAAAECAuIHCBAgQCAJCEhiMyJAgAABAfEDBAgQIJAEBCSxGREgQICAgPgBAgQIEEgCApLYjAgQIEBAQPwAAQIECCQBAUlsRgQIECAgIH6AAAECBJKAgCQ2IwIECBAQED9AgAABAklAQBKbEQECBAgIiB8gQIAAgSQgIInNiAABAgQExA8QIECAQBIQkMRmRIAAAQIC4gcIECBAIAkISGIzIkCAAAEB8QMECBAgkAQEJLEZESBAgICA+AECBAgQSAICktiMCBAgQEBA/AABAgQIJAEBSWxGBAgQICAgfoAAAQIEkoCAJDYjAgQIEBAQP0CAAAECSUBAEpsRAQIECAiIHyBAgACBJCAgic2IAAECBATEDxAgQIBAEhCQxGZEgAABAgLiBwgQIEAgCQhIYjMiQIAAAQHxAwQIECCQBAQksRkRIECAgID4AQIECBBIAgKS2IwIECBAQED8AAECBAgkAQFJbEYECBAgICB+gAABAgSSgIAkNiMCBAgQEBA/QIAAAQJJQEASmxEBAgQICIgfIECAAIEkICCJzYgAAQIEBMQPECBAgEASEJDEZkSAAAECAuIHCBAgQCAJCEhiMyJAgAABAfEDBAgQIJAEBCSxGREgQICAgPgBAgQIEEgCApLYjAgQIEBAQPwAAQIECCQBAUlsRgQIECAgIH6AAAECBJKAgCQ2IwIECBAQED9AgAABAklAQBKbEQECBAgIiB8gQIAAgSQgIInNiAABAgQExA8QIECAQBIQkMRmRIAAAQIC4gcIECBAIAkISGIzIkCAAAEB8QMECBAgkAQEJLEZESBAgICA+AECBAgQSAICktiMCBAgQEBA/AABAgQIJAEBSWxGBAgQICAgfoAAAQIEkoCAJDYjAgQIEBAQP0CAAAECSUBAEpsRAQIECAiIHyBAgACBJCAgic2IAAECBATEDxAgQIBAEhCQxGZEgAABAgLiBwgQIEAgCQhIYjMiQIAAAQHxAwQIECCQBAQksRkRIECAgID4AQIECBBIAgKS2IwIECBAQED8AAECBAgkAQFJbEYECBAgICB+gAABAgSSgIAkNiMCBAgQEBA/QIAAAQJJQEASmxEBAgQICIgfIECAAIEkICCJzYgAAQIEBMQPECBAgEASEJDEZkSAAAECAuIHCBAgQCAJCEhiMyJAgAABAfEDBAgQIJAEBCSxGREgQICAgPgBAgQIEEgCApLYjAgQIEBAQPwAAQIECCQBAUlsRgQIECAgIH6AAAECBJKAgCQ2IwIECBAQED9AgAABAklAQBKbEQECBAgIiB8gQIAAgSQgIInNiAABAgQExA8QIECAQBIQkMRmRIAAAQIC4gcIECBAIAkISGIzIkCAAAEB8QMECBAgkAQEJLEZESBAgICA+AECBAgQSAICktiMCBAgQOABB1wAyWjdfzMAAAAASUVORK5CYII="
            var data = signaturePad.toDataURL('image/png')
            console.log("data 1 is =>", data);
            SignatureHiddenfieldExecutor.value = data;
            alert('Signature Hiddenfield Executor is =>' + SignatureHiddenfieldExecutor.value);

            var dataSignatureSupervisor = signaturePad2.toDataURL('image/png');
            console.log("data 2 is =>", dataSignatureSupervisor);
            SignatureHiddenfieldSupervisor.value = dataSignatureSupervisor;

            alert('Signature Hiddenfield Supervisor is =>' + SignatureHiddenfieldSupervisor.value);

            if (SignatureHiddenfieldExecutor.value == SignatureHiddenfieldSupervisor.value) {
                alert('กรุณาเซ็นลายเซ็น');
                return false;
            }

           <%-- else ($('#<%= this.SignatureHiddenfieldExecutor.ClientID %>').val().length > 0 && $('#<%= this.SignatureHiddenfieldSupervisor.ClientID %>').val().length > 0) {
                return true;
            }--%>

             //if (SignatureHiddenfieldExecutor.value)
            //else {
            //    alert('กรุณาเซ็นลายเซ็น');
            //    return false;
            
        }
    </script>
</body>


<%--OLD RESOUCE--%>
<%-- rc="http://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>
<script src="http://ajax.googleapis.com/ajax/libs/jqueryui/1.12.1/jquery-ui.min.js"></script>
<script src="../sig/js/jquery.signature.js"></script>
<script>
    //-----------------  ลายเซ็น  //----------------------
    $(function () {
        $('#signatureExecutorTextbox').signature({ syncField: '#<%= this.signatureExecutorJSON.ClientID %>' });

            $('#clearButton1').click(function () {
                $('#signatureExecutorTextbox').signature('clear');
            });

            $('input[name="syncFormat"]').change(function () {
                var syncFormat = $('input[name="syncFormat"]:checked').val();
                $('#signatureExecutorTextbox').signature('option', 'syncFormat', syncFormat);
            });

            $('#svgStyles').change(function () {
                $('#signatureExecutorTextbox').signature('option', 'svgStyles', $(this).is(':checked'));
            });
            $('#redrawButton').click(function () {
                $('#redrawSignature1').signature('enable').
                    signature('draw', $('#<%= this.signatureExecutorJSON.ClientID %>').val()).
                    signature('disable');
            });

            $('#redrawSignature1').signature({ disabled: true });
        });
</script>
<script>
    $(function () {
        $('#signatureSupervisorTextbox').signature({ syncField: '#<%= this.signatureSupervisorJSON.ClientID %>' });

            $('#clear2Button').click(function () {
                $('#signatureSupervisorTextbox').signature('clear');
            });

            $('input[name="syncFormat"]').change(function () {
                var syncFormat = $('input[name="syncFormat"]:checked').val();
                $('#signatureSupervisorTextbox').signature('option', 'syncFormat', syncFormat);
            });

            $('#svgStyles').change(function () {
                $('#signatureSupervisorTextbox').signature('option', 'svgStyles', $(this).is(':checked'));
            });

            $('#redrawButton').click(function () {
                $('#redrawSignature').signature('enable').
                    signature('draw', $('#<%= this.signatureSupervisorJSON.ClientID %>').val()).
                    signature('disable');
            });

            $('#redrawSignature').signature({ disabled: true });
        });
</script>
<script>
    function signatureValidation() {
        if ($('#<%= this.signatureSupervisorJSON.ClientID %>').val().length > 0 && $('#<%= this.signatureExecutorJSON.ClientID %>').val().length > 0) {
            return true;
        } else {
            alert('กรุณาเซ็นลายเซ็น');
            return false;
        }
    }
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
</html>
