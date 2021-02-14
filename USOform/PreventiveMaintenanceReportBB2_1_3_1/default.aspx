<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="USOform.PreventiveMaintenanceReportBB2._1_3._1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>รายงาน PM From BB Zone C+ บริการที่ 2.1,3.1</title>
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
    <link href="http://ajax.googleapis.com/ajax/libs/jqueryui/1.12.1/themes/south-street/jquery-ui.css" rel="stylesheet" />
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
            width: 348px;
            height: 200px;
        }

        table, tr, td {
            border: none;
        }
    </style>
    <!--[if IE]>
    <script src="excanvas.js"></script>
    <![endif]-->
    <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>
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
</head>

<body style="background-color: lightgray">
    <form id="form1" runat="server">
        <div class="container bg-white Myfont mt-3">
            <%-------------------------//    HEADER CONTENT    //------------------------------------------------%>
            <div class="row pt-5">
                <div class="col-4">
                    <asp:FileUpload ID="pictureOrganize_" runat="server" data-thumbnail="user_img_logo" accept="image/*" onchange="previewImage(this)" />
                    <div class="row ml-3 mt-3">
                        <img id="user_img_logo" src='<% if (answers.Count() > 0) Response.Write(answers.Where(x => x.QuestionId == 1023).FirstOrDefault().AnsDes); %>' class="imgLogoOganize  float-left" />
                    </div>
                </div>

                <div class="col-4  d-flex justify-content-center ">
                    <h5 class="headerText">Preventive Maintenance Site Report USO (Village’s WIFI)</h5>
                </div>
                <div class="col-4 ">
                    <img src="../assets/logo_uso.png" class="logoImg" />
                </div>
            </div>


            <div class="row mt-5">
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
                    <input type="text" class="form-control" id="GroupNameTextBox" runat="server" />
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-1" for="">ภาค :</label>
                <div class="col-sm-4">
                    <input type="text" class="form-control" id="AreaTextbox" runat="server" />
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-1" for="">บริษัท :</label>
                <div class="col-sm-4">
                    <input type="text" class="form-control" id="CompanyTextbox" runat="server" />
                </div>
            </div>




            <div class="form-row mt-3">
                <label class="control-label col-sm-8" for="">ส่วนที่ 1 การจัดให้มีบริการอินเทอร์เน็ตความเร็วสูง (Broadband Internet Service) บริการประเภทที่ </label>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" class="form-check-input" name="category" value="2.1" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1017).FirstOrDefault().AnsDes == "2.1") { Response.Write("checked"); } else { Response.Write(""); }  %> />2.1
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" class="form-check-input" name="category" value="3.1" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1017).FirstOrDefault().AnsDes == "3.1") { Response.Write("checked"); } else { Response.Write(""); }  %> />3.1
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-2" for="">รอบการบำรุงรักษา ครั้งที่ </label>
                <div class="col-sm-1">
                    <input type="text" class="form-control" id="maintenanceCountTextbox" runat="server" required="required" />
                </div>
                <span>/</span>
                <div class="col-sm-3">
                    <input type="text" class="form-control" placeholder="ปีพุทธศักราช" id="yearTextbox" runat="server" required="required" />
                </div>
            </div>

            <div class="row  text-left mt-3">
                <div class="col-md-4 form-inline">
                    <label>วัน เดือน ปี </label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <input class="form-control" type="text" id="startDatepicker" runat="server" required="required" />
                </div>
                <div class="col-md-6 form-inline">
                    <label>ถึง</label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                 <input class="form-control" type="text" id="endDatepicker" runat="server" required="required" />
                </div>

            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-2" for="">สถานที่ (Site code)</label>
                <div class="col-sm-4">
                    <input type="text" class="form-control" id="siteCodeTextbox" runat="server" />
                </div>
            </div>
            <%---------------------------------//   END HEADER CONTENT  //------------------------------------------%>


            <%--------------------------------form start-------------------------------------------------------------------%>
            <div class="row mt-3">
                <div class="col-md-12 bg-primary text-white text-center Myfont">
                    <h4>PREVENTIVE MAINTENANCE SITE REPORT (PM)</h4>
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


            <%-- QuestionId = 16,--%>
            <div class="form-row mt-3">
                <label class="control-label col-md-1">Sub-District </label>
                <div class="col">
                    <input type="text" class="form-control" id="subdistrictTextbox" runat="server" required="required" />
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-1">District :</label>
                <div class="col-sm-11">
                    <input type="text" class="form-control" id="districtTextbox" runat="server" required="required" />
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
                <div class="col-sm-12 bg-primary text-white">ใส่รูปหน้าตู้</div>
                <asp:FileUpload ID="signboardfontImage" runat="server" data-thumbnail="user_img_0" accept="image/*" onchange="previewImage(this)" />
            </div>

            <%-- onchange="previewImage(this)"--%>
            <div class="row ml-3 mt-3">
                <img id="user_img_0" src='<% if (answers.Count() > 0) Response.Write(answers.Where(x => x.QuestionId == 1033).FirstOrDefault().AnsDes); %>' class="placeholder2" />
            </div>





            <%--OLD RESOUCE--%>
            <%-- <div class="row mt-3">
                <div class="col-md-12 bg-warning text-white text-center Myfont">
                    <h4>Contractor</h4>
                </div>
            </div>

            <table style="width: 100%;" border="0" class="table-responsive-lg">
                <tbody>
                    <tr style="height: 21px;">
                        <td style="height: 21px; width: 10%;">&nbsp;</td>
                        <td style="height: 21px; width: 45%;">&nbsp; &nbsp; &nbsp; Executor</td>
                        <td style="height: 21px; width: 45%;">&nbsp; &nbsp; &nbsp; Supervisor</td>
                    </tr>
                    <tr style="height: 21px;">
                        <td style="height: 21px; width: 10%;">&nbsp;Signature</td>
                        <td style="height: 21px; width: 45%;">&nbsp;<div id="signatureExecutorTextbox"></div>
                            <input type="hidden" id="signatureExecutorJSON" class="ui-state-active" runat="server" />
                            <div id="redrawSignature1" hidden="hidden"></div>
                        </td>
                        <td style="height: 21px; width: 45%;">&nbsp;<div id="signatureSupervisorTextbox"></div>
                            <input type="hidden" id="signatureSupervisorJSON" class="ui-state-active" runat="server" />
                            <div id="redrawSignature1" hidden="hidden"></div>
                        </td>
                    </tr>
                    <tr style="height: 21px;">
                        <td style="height: 21px; width: 10%;">&nbsp;Name</td>
                        <td style="height: 21px; width: 45%;">&nbsp;  
                                <input type="text" class="form-control" id="nameExecutorTextbox" runat="server" required="required" /></td>
                        <td style="height: 21px; width: 45%;">&nbsp;  
                                <input type="text" class="form-control" id="nameSupervisorTextbox" runat="server" required="required" /></td>
                    </tr>
                    <tr style="height: 21px;">
                        <td style="height: 21px; width: 10%;">&nbsp;Date</td>
                        <td style="height: 21px; width: 45%;">&nbsp;
                                <input type="text" class="form-control" id="DateExecutorTextbox" runat="server" required="required" /></td>
                        <td style="height: 21px; width: 45%;">&nbsp; 
                                <input type="text" class="form-control" id="DateSupervisorTextbox" runat="server" required="required" /></td>
                    </tr>
                </tbody>
            </table>--%>

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
                            <div id="signatureExecutorTextbox"></div>
                            <div id="redrawSignature1" hidden="hidden"></div>
                            <input type="hidden" id="signatureExecutorJSON" class="ui-state-active" runat="server" />
                            <div class="form-group">
                                <label>Name</label>
                                <input type="text" class="form-control" id="nameExecutorTextbox" runat="server" required="required" />
                            </div>
                            <div class="form-group">
                                <label>Date</label>
                                <input type="text" class="form-control" id="DateExecutorTextbox" runat="server" required="required" />
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
                                <input type="text" class="form-control" id="nameSupervisorTextbox" runat="server" required="required" />
                            </div>
                            <div class="form-group">
                                <label>Date</label>
                                <input type="text" class="form-control" id="DateSupervisorTextbox" runat="server" required="required" />
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
                <label class="control-label col-sm-1">Cabinet ID</label>
                <div class="col-sm-11">
                    <%-- QuestionId = 28, --%>
                    <input type="text" class="form-control" id="cabinetIDTextboxSection4" runat="server" required="required" />
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
                        <input type="radio" class="form-check-input" name="typeofsignalRadio" value="OFC" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1044).FirstOrDefault().AnsDes == "OFC") { Response.Write("checked"); } else { Response.Write(""); }  %> />OFC
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="typeofsignalRadio" value="Satellite" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1044).FirstOrDefault().AnsDes == "Satellite") { Response.Write("checked"); } else { Response.Write(""); }  %> />Satellite
                    </label>
                </div>
            </div>

            <%-- QuestionId = 32, --%>
            <div class="form-row mt-3">
                <label class="control-label col-sm-2">OLT ID (USO Network) or ISP (Existing Network)</label>
                <div class="col-sm-10">
                    <input type="text" class="form-control" id="oltidTextbox" runat="server" required="required" />
                </div>
            </div>




            <%---/////////////////////////////////      ////////////////////////////////////////--------%>


            <div class="row mt-3">
                <div class="col-md-12 bg-primary text-white text-center Myfont">
                    <h4>2. ระบบไฟฟ้า (หลัก)</h4>
                </div>
            </div>

            <div class="form-row mt-3">
                <%------  ------------------------------------------------------------------------------------------------------------%>
                <label class="control-label col-sm-2">ระบบไฟฟ้า</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="elecRadio" value="PEA" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1046).FirstOrDefault().AnsDes == "PEA") { Response.Write("checked"); } else { Response.Write(""); }  %> />PEA
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="elecRadio" value="SolarCell" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1046).FirstOrDefault().AnsDes == "SolarCell") { Response.Write("checked"); } else { Response.Write(""); }  %> />Solar Cell
                    </label>
                </div>
            </div>


            <div class="form-row mt-3">
                <%------, ----------------------------------------------------------------------------------------------------------%>
                <label class="control-label col-sm-2">หมายเลขผู้ใช้ไฟ</label>
                <div class="col-sm-10">
                    <input type="text" class="form-control" id="numberuserTextbox" runat="server" required="required" />
                </div>
            </div>

            <div class="form-row mt-3">
                <%------  ----------------------------------------------------------------------------------------------------------%>
                <label class="control-label col-sm-2">หน่วยใช้ไฟ (kWh Meter)</label>
                <div class="col-sm-8">
                    <input type="text" class="form-control" id="kwhMeterTextbox" runat="server" required="required" />
                </div>
                <label class="control-label col-sm-2">kWh</label>
            </div>


            <div class="form-row mt-3">
                <%------ , ---------------------------------------------------------------------------------------------------------%>
                <label class="control-label col-sm-2">แรงดัน AC (kWh Meter)</label>
                <div class="col-sm-8">
                    <input type="text" class="form-control" id="acTextbox" runat="server" required="required" />
                </div>
                <label class="control-label col-sm-2">V.</label>
            </div>

            <div class="form-row mt-3">
                <%------  ----------------------------------------------------------------------------------------------------------%>
                <label class="control-label col-sm-2">กระแส Line AC (kWh Meter)</label>
                <div class="col-sm-8">
                    <input type="text" class="form-control" id="lineAcTextbox" runat="server" required="required" />
                </div>
                <label class="control-label col-sm-2">A.</label>
            </div>

            <div class="form-row mt-3">
                <%------  -----------------------------------------------------------------------------------------------------------%>
                <label class="control-label col-sm-2">กระแส Neutron AC (kWh Meter)</label>
                <div class="col-sm-8">
                    <input type="text" class="form-control" id="neutronacTextbox" runat="server" required="required" />
                </div>
                <label class="control-label col-sm-2">A.</label>
            </div>

            <div class="form-row mt-3">
                <%------  -----------------------------------------------------------------------------------------------------------%>
                <label class="control-label col-sm-2">สภาพ kWh Meter</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="conditionRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1052).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="conditionRadio" value="ชำรุด/ใช้งานไม่ได้" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1052).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); } %> />ชำรุด/ใช้งานไม่ได้
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <%------  ----------------------------------------------------------------------------------------------------------%>
                <label class="control-label col-sm-2">สภาพ Circuit Breaker</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="CircuitBreakerRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1053).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="CircuitBreakerRadio" value="ชำรุด/ใช้งานไม่ได้" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1053).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); } %> />ชำรุด/ใช้งานไม่ได้
                    </label>
                </div>
            </div>
            <%--////////////// -----------------------------  //////////////////--%>


            <div class="row mt-3">
                <div class="col-md-12 bg-primary text-white text-center Myfont">
                    <h4>3. ระบบไฟฟ้า (สำรอง)</h4>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-2" for="">UPS ภายในตู้</label>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" class="form-check-input" name="inupsRadio" value="มี" required="required" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1054).FirstOrDefault().AnsDes == "มี") { Response.Write("checked"); } else { Response.Write(""); } %> />มี
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" class="form-check-input" name="inupsRadio" value="ไม่มี" required="required" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1054).FirstOrDefault().AnsDes == "ไม่มี") { Response.Write("checked"); } else { Response.Write(""); } %> />ไม่มี
                    </label>
                </div>
            </div>


            <div class="form-row mt-3">
                <%------  ---------------------------------------------------------------------------------------------------------%>
                <label class="control-label col-sm-2">แรงดัน AC จาก UPS</label>
                <div class="col-sm-8">
                    <input type="text" class="form-control" id="acfromupsTextbox" runat="server" required="required" />
                </div>
                <label class="control-label col-sm-2">V.</label>
            </div>




            <div class="form-row mt-3">
                <label class="control-label col-sm-2" for="">ระดับกระแส Load </label>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" class="form-check-input" name="levelLoadRadio" value="1" required="required" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1056).FirstOrDefault().AnsDes == "1") { Response.Write("checked"); } else { Response.Write(""); } %>>1
                    </label>
                </div>

                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" class="form-check-input" name="levelLoadRadio" value="2" required="required" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1056).FirstOrDefault().AnsDes == "2") { Response.Write("checked"); } else { Response.Write(""); } %>>2
                    </label>
                </div>

                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" class="form-check-input" name="levelLoadRadio" value="3" required="required" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1056).FirstOrDefault().AnsDes == "3") { Response.Write("checked"); } else { Response.Write(""); } %>>3
                    </label>
                </div>

                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" class="form-check-input" name="levelLoadRadio" value="4" required="required" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1056).FirstOrDefault().AnsDes == "4") { Response.Write("checked"); } else { Response.Write(""); } %>>4
                    </label>

                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" name="levelLoadRadio" value="5" required="required" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1056).FirstOrDefault().AnsDes == "5") { Response.Write("checked"); } else { Response.Write(""); } %>>5
                        </label>
                    </div>
                </div>
                <label class="control-label col-sm-2" for="">(ขีดล่าง =1 , ขีดบน = 5)</label>

            </div>



            <div class="form-row mt-3">
                <label class="control-label col-sm-2" for="">ระดับความจุ Battery</label>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" class="form-check-input" name="levelBatteryRadio" value="1" required="required" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1056).FirstOrDefault().AnsDes == "1") { Response.Write("checked"); } else { Response.Write(""); } %>>1
                    </label>
                </div>

                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" class="form-check-input" name="levelBatteryRadio" value="2" required="required" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1056).FirstOrDefault().AnsDes == "2") { Response.Write("checked"); } else { Response.Write(""); } %>>2
                    </label>
                </div>

                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" class="form-check-input" name="levelBatteryRadio" value="3" required="required" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1056).FirstOrDefault().AnsDes == "3") { Response.Write("checked"); } else { Response.Write(""); } %>>3
                    </label>
                </div>

                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" class="form-check-input" name="levelBatteryRadio" value="4" required="required" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1056).FirstOrDefault().AnsDes == "4") { Response.Write("checked"); } else { Response.Write(""); } %>>4
                    </label>

                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" name="levelBatteryRadio" value="5" required="required" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1056).FirstOrDefault().AnsDes == "5") { Response.Write("checked"); } else { Response.Write(""); } %>>5
                        </label>
                    </div>
                </div>
                <label class="control-label col-sm-2" for="">(ขีดล่าง =1 , ขีดบน = 5)</label>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-2">UPS MODE</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="upsModeRadio" value="LINE" required="required" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1058).FirstOrDefault().AnsDes == "LINE") { Response.Write("checked"); } else { Response.Write(""); } %> />LINE
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="upsModeRadio" value="BATT." required="required" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1058).FirstOrDefault().AnsDes == "BATT.") { Response.Write("checked"); } else { Response.Write(""); } %> />BATT.
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="upsModeRadio" value="BYPASS" required="required" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1058).FirstOrDefault().AnsDes == "BYPASS") { Response.Write("checked"); } else { Response.Write(""); } %> />BYPASS
                    </label>
                </div>
            </div>
            <div class="form-row mt-3">
                <label class="control-label col-sm-2">การทำงานของระบบไฟสำรอง</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="emergeneratorRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1059).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %> />ปกติ
                    </label>
                </div>

                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="emergeneratorRadio" value="ชำรุด/ใช้งานไม่ได้" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1059).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); } %> />ชำรุด/ใช้งานไม่ได้
                    </label>
                </div>
            </div>

            <%------  ----------------------------------------------------------------------------------------------------------%>
            <div class="form-row mt-3">
                <label class="control-label col-sm-2">สภาพ Battery Bank</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="stateBatteryBankRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1060).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %> />ปกติ
                    </label>
                </div>

                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="stateBatteryBankRadio" value="ชำรุด/ใช้งานไม่ได้" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1060).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); } %> />ชำรุด/ใช้งานไม่ได้
                    </label>
                </div>
            </div>
            <%--////////////// ------------- -----------------  //////////////////--%>


            <div class="row mt-3">
                <div class="col-md-12 bg-primary text-white text-center Myfont">
                    <h4>4.รายละเอียดอุปกรณ์ Network ภายในตู้</h4>
                </div>
            </div>

            <div class="form-row mt-3">
                <%------  --------------------------------------------------------------------------------------------------------%>
                <label class="control-label col-sm-3">ONU/Modem Network</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="onuModemRadio" value="USO" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1061).FirstOrDefault().AnsDes == "USO") { Response.Write("checked"); } else { Response.Write(""); } %> />USO
                    </label>
                </div>

                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="onuModemRadio" value="TRUE" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1061).FirstOrDefault().AnsDes == "TRUE") { Response.Write("checked"); } else { Response.Write(""); } %> />TRUE
                    </label>
                </div>

                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="onuModemRadio" value="3BB" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1061).FirstOrDefault().AnsDes == "3BB") { Response.Write("checked"); } else { Response.Write(""); } %> />3BB
                    </label>
                </div>

                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="onuModemRadio" value="Satellite" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1061).FirstOrDefault().AnsDes == "Satellite") { Response.Write("checked"); } else { Response.Write(""); } %> />Satellite
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-3" for="">Power Supply (for Switch)</label>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" class="form-check-input" name="powersubRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1062).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" class="form-check-input" name="powersubRadio" value="ชำรุด/ใช้งานไม่ได้" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1062).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); } %> />ชำรุด/ใช้งานไม่ได้
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-3">Switch 8 Port</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="switchportRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1063).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="switchportRadio" value="ชำรุด/ใช้งานไม่ได้" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1063).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); } %> />ชำรุด/ใช้งานไม่ได้
                    </label>
                </div>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-3" for="">Outdoor AP 2.4 GHz</label>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" class="form-check-input" name="outdoorapRadio2_4" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1064).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" class="form-check-input" id="" name="outdoorapRadio2_4" value="ชำรุด/ใช้งานไม่ได้" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1064).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); } %> />ชำรุด/ใช้งานไม่ได้
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-3" for="">Outdoor AP 5 GHz</label>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" class="form-check-input" name="outdoorapRadio5" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1065).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" class="form-check-input" name="outdoorapRadio5" value="ชำรุด/ใช้งานไม่ได้" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1065).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); } %> />ชำรุด/ใช้งานไม่ได้
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-3" for="">ระบบระบายอากาศ (T-Power)</label>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" class="form-check-input" name="tpowerRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1066).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" class="form-check-input" name="tpowerRadio" value="ชำรุด/ใช้งานไม่ได้" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1066).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); } %> />ชำรุด/ใช้งานไม่ได้
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-3" for="">การ Wiring สายไฟและสาย Ground</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="wiringelecRadio" value="เรียบร้อย" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1067).FirstOrDefault().AnsDes == "เรียบร้อย") { Response.Write("checked"); } else { Response.Write(""); } %> />เรียบร้อย
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="wiringelecRadio" value="ไม่เรียบร้อย" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1067).FirstOrDefault().AnsDes == "ไม่เรียบร้อย") { Response.Write("checked"); } else { Response.Write(""); } %> />ไม่เรียบร้อย
                    </label>
                </div>
            </div>

            <%------  ------------------------------------------------------------------------------------------------------------%>
            <div class="form-row mt-3">
                <label class="control-label col-sm-3">การ Wiring Patch cord และ สาย LAN</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="wiringpatchRadio" value="เรียบร้อย" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1068).FirstOrDefault().AnsDes == "เรียบร้อย") { Response.Write("checked"); } else { Response.Write(""); } %> />เรียบร้อย
                    </label>
                </div>

                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="wiringpatchRadio" value="ไม่เรียบร้อย" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1068).FirstOrDefault().AnsDes == "ไม่เรียบร้อย") { Response.Write("checked"); } else { Response.Write(""); } %> />ไม่เรียบร้อย
                    </label>
                </div>
            </div>
            <%--////////////// ------------- //////////////////--%>

            <div class="row mt-3">
                <div class="col-md-12 bg-primary text-white text-center Myfont">
                    <h4>5.ระบบ Ground</h4>
                </div>
            </div>

            <div class="form-row mt-3">
                <%----------------------  ---------------------------%>
                <label class="control-label col-sm-4">ความแข็งแรงจุดต่อ Ground Bar</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="groundbarRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1069).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="groundbarRadio" value="ชำรุด" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1069).FirstOrDefault().AnsDes == "ชำรุด") { Response.Write("checked"); } else { Response.Write(""); } %> />ชำรุด
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <%----------------------  ---------------------------%>
                <label class="control-label col-sm-4">ความแข็งแรงของน็อตขันหางปลาอุปกรณ์</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="notfishRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1070).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="notfishRadio" value="ชำรุด" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1070).FirstOrDefault().AnsDes == "ชำรุด") { Response.Write("checked"); } else { Response.Write(""); } %> />ชำรุด
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <%---------------------- , ---------------------------%>
                <label class="control-label col-sm-4">สายกราวด์เรียบร้อย ปลอดภัย สมบูรณ์</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="safegroundRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1071).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="safegroundRadio" value="ชำรุด" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1071).FirstOrDefault().AnsDes == "ชำรุด") { Response.Write("checked"); } else { Response.Write(""); } %> />ชำรุด
                    </label>
                </div>
            </div>



            <%----------------------  ---------------------------%>
            <div class="form-row mt-3">
                <label class="control-label col-sm-4">สถานะไฟฟ้ารั่วลง Ground</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="brokenElecRadio" value="ไม่พบไฟฟ้ารั่ว" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1072).FirstOrDefault().AnsDes == "ไม่พบไฟฟ้ารั่ว") { Response.Write("checked"); } else { Response.Write(""); } %> />ไม่พบไฟฟ้ารั่ว
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="brokenElecRadio" value="พบไฟฟ้ารั่ว" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1072).FirstOrDefault().AnsDes == "พบไฟฟ้ารั่ว") { Response.Write("checked"); } else { Response.Write(""); } %> />พบไฟฟ้ารั่ว
                    </label>
                </div>
            </div>
            <%--////////////// ------------------------------  //////////////////--%>

            <div class="row mt-3">
                <div class="col-md-12 bg-success text-white text-center Myfont">
                    <h4>6.สภาพแวดล้อมและความสะอาดโดยรอบ</h4>
                </div>
            </div>




            <div class="form-row mt-3">
                <label class="control-label col-sm-3" for="">ป้ายและตัวเลขแสดงชื่อสถานี</label>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" class="form-check-input" name="nameStationRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1073).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %> />ปกติ     
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" class="form-check-input" name="nameStationRadio" value="ไม่ชัดเจน" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1073).FirstOrDefault().AnsDes == "ไม่ชัดเจน") { Response.Write("checked"); } else { Response.Write(""); } %> />ไม่ชัดเจน        
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-3" for="">การติดตั้งและการยึดตู้อุปกรณ์</label>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" class="form-check-input" name="installandboxRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1074).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %> />ปกติ     
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" class="form-check-input" name="installandboxRadio" value="ชำรุด" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1074).FirstOrDefault().AnsDes == "ชำรุด") { Response.Write("checked"); } else { Response.Write(""); } %> />ชำรุด        
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-3" for="">เสาไฟฟ้าที่ตั้งตั้งอุปกรณ์</label>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" class="form-check-input" name="postElectriInstallRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1075).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %> />ปกติ     
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" class="form-check-input" name="postElectriInstallRadio" value="ชำรุด/เอียง" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1075).FirstOrDefault().AnsDes == "ชำรุด/เอียง") { Response.Write("checked"); } else { Response.Write(""); } %> />ชำรุด/เอียง        
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-3" for="">แนวสายไฟฟ้าและสายเคเบิ้ลเข้าสถานี</label>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" class="form-check-input" name="cableInStationRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1076).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %> />ปกติ     
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" class="form-check-input" name="cableInStationRadio" value="ตกหย่อน/ไม่ได้ยึดโยง" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1076).FirstOrDefault().AnsDes == "ตกหย่อน/ไม่ได้ยึดโยง") { Response.Write("checked"); } else { Response.Write(""); } %> />ตกหย่อน/ไม่ได้ยึดโยง       
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-3" for="">ช่อง Cable Inlet  และความสะอาด</label>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" class="form-check-input" name="cleanCableRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1077).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %> />ปกติ     
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" class="form-check-input" name="cleanCableRadio" value="ไม่ได้อุดซิลีโคน" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1077).FirstOrDefault().AnsDes == "ไม่ได้อุดซิลีโคน") { Response.Write("checked"); } else { Response.Write(""); } %> />ไม่ได้อุดซิลีโคน       
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-3" for="">ช่อง Filter ความสะอาด (T-Power)</label>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" class="form-check-input" name="CleanfilterTpowerRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1078).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %> />ปกติ     
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" class="form-check-input" name="CleanfilterTpowerRadio" value="มีฝุ่น/สิ่งสกปรก" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1078).FirstOrDefault().AnsDes == "มีฝุ่น/สิ่งสกปรก") { Response.Write("checked"); } else { Response.Write(""); } %> />มีฝุ่น/สิ่งสกปรก      
                    </label>
                </div>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-3" for="">ประตูและยางขอบประตูของตู้อุปกรณ์</label>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" class="form-check-input" name="doorandboxRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1079).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %> />ปกติ     
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" class="form-check-input" name="doorandboxRadio" value="ชำรุด" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1079).FirstOrDefault().AnsDes == "ชำรุด") { Response.Write("checked"); } else { Response.Write(""); } %> />ชำรุด      
                    </label>
                </div>
            </div>


            <div class="row mt-3">
                <div class="col-md-12 bg-primary text-white text-center Myfont">
                    <h4>7.อุปกรณ์ระบบ VSAT (เฉพาะ Site ที่เป็น VSAT)</h4>
                </div>
            </div>

            <%---------------------- ---------------------------%>
            <div class="form-row mt-3">
                <label class="control-label col-sm-4">อุปกรณ์ LNB/BUC</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="toolslnbRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1080).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="toolslnbRadio" value="ชำรุด/ใช้งานไม่ได้" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1080).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); } %> />ชำรุด/ใช้งานไม่ได้
                    </label>
                </div>
            </div>


            <%----------------------  ---------------------------%>
            <div class="form-row mt-3">
                <label class="control-label col-sm-4">การเก็บสาย RG และการพันหัว</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="wiringrgRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1081).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="wiringrgRadio" value="ไม่เรียบร้อย/ไม่แน่น" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1081).FirstOrDefault().AnsDes == "ไม่เรียบร้อย/ไม่แน่น") { Response.Write("checked"); } else { Response.Write(""); } %> />ไม่เรียบร้อย/ไม่แน่น
                    </label>
                </div>
            </div>



            <%----------------------   ---------------------------%>
            <div class="form-row mt-3">
                <label class="control-label col-sm-4">ฐานและระดับของเสาจาน</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="baseOnRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1082).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="baseOnRadio" value="ไม่ได้ระดับ/เอียง" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1082).FirstOrDefault().AnsDes == "ไม่ได้ระดับ/เอีย") { Response.Write("checked"); } else { Response.Write(""); } %> />ไม่ได้ระดับ/เอียง
                    </label>
                </div>
            </div>



            <%----------------------  ---------------------------%>
            <div class="form-row mt-3">
                <label class="control-label col-sm-4">แนว Line Of Sight</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="lineOfsightRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1083).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="lineOfsightRadio" value="โดนบัง" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1083).FirstOrDefault().AnsDes == "โดนบัง") { Response.Write("checked"); } else { Response.Write(""); } %> />โดนบัง
                    </label>
                </div>
            </div>




            <%----------------------  ---------------------------%>
            <div class="form-row mt-3">
                <label class="control-label col-sm-4">ความสะอาดของหน้าจาน</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="cleaningDishRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1084).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="cleaningDishRadio" value="สกปรก" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1084).FirstOrDefault().AnsDes == "สกปรก") { Response.Write("checked"); } else { Response.Write(""); } %> />สกปรก
                    </label>
                </div>
            </div>




            <%----------------------   ---------------------------%>
            <div class="form-row mt-3">
                <label class="control-label col-sm-4">LNB Band Switch</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="lnbbandswitchRadio" value="HIGHBAND" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1085).FirstOrDefault().AnsDes == "HIGHBAND") { Response.Write("checked"); } else { Response.Write(""); } %> />HIGH BAND
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="lnbbandswitchRadio" value="LOWBAND" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1085).FirstOrDefault().AnsDes == "LOWBAND") { Response.Write("checked"); } else { Response.Write(""); } %> />LOW BAND
                    </label>
                </div>
            </div>
            <%--////////////// ------------------------------  //////////////////--%>

            <div class="row mt-3">
                <div class="col-md-12 bg-primary text-white text-center Myfont">
                    <h4>8.อุปกรณ์ระบบ Solar Cell (เฉพาะ Site ที่ใช้ Solar Cell)</h4>
                </div>
            </div>

            <%----------------------  ---------------------------%>
            <div class="form-row mt-3">
                <label class="control-label col-sm-4">ระบบ Solar Cell</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="solarcellSystemRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1086).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="solarcellSystemRadio" value="ชำรุด/ใช้งานไม่ได้" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1086).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); } %> />ชำรุด/ใช้งานไม่ได้
                    </label>
                </div>
            </div>


            <%---------------------- ---------------------------%>
            <div class="form-row mt-3">
                <label class="control-label col-sm-4">แผง PV Panel</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="pvPanelRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1087).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="pvPanelRadio" value="ชำรุด/ใช้งานไม่ได้" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1087).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); } %> />ชำรุด/ใช้งานไม่ได้
                    </label>
                </div>
            </div>


            <%----------------------  ---------------------------%>
            <div class="form-row mt-3">
                <label class="control-label col-sm-4">อุปกรณ์ Charger</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="toolsCharger" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1088).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="toolsCharger" value="ชำรุด/ใช้งานไม่ได้" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1088).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); } %> />ชำรุด/ใช้งานไม่ได้
                    </label>
                </div>
            </div>



            <%----------------------  ---------------------------%>
            <div class="form-row mt-3">
                <label class="control-label col-sm-4">ความสะอาดแผง PV</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="cleanIngpvRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1089).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %> />ปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="cleanIngpvRadio" value="สกปรก" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1089).FirstOrDefault().AnsDes == "สกปรก") { Response.Write("checked"); } else { Response.Write(""); } %> />สกปรก
                    </label>
                </div>
            </div>



            <%----------------------   ---------------------------%>
            <div class="form-row mt-3">
                <label class="control-label col-sm-4">การติดตั้งแผง PV</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="installPvRadio" value="ที่โล่งรับแดดปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1090).FirstOrDefault().AnsDes == "ที่โล่งรับแดดปกติ") { Response.Write("checked"); } else { Response.Write(""); } %> />ที่โล่งรับแดดปกติ
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="installPvRadio" value="มีอาคาร/ต้นไม้บัง" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1090).FirstOrDefault().AnsDes == "มีอาคาร/ต้นไม้บัง") { Response.Write("checked"); } else { Response.Write(""); } %> />มีอาคาร/ต้นไม้บัง
                    </label>
                </div>
            </div>



            <%----------------------  ---------------------------%>
            <div class="form-row mt-3">
                <label class="control-label col-sm-2">แรงดันไฟจาก Inverter</label>
                <div class="col-sm-8">
                    <input type="text" class="form-control" id="voltageInverterTextbox" runat="server" required="required" />
                </div>
                <label class="control-label col-sm-2">V.</label>
            </div>



            <%----------------------   ---------------------------%>
            <div class="form-row mt-3">
                <label class="control-label col-sm-2">กระแส Load</label>
                <div class="col-sm-8">
                    <input type="text" class="form-control" id="voltageLoadTextbox" runat="server" required="required" />
                </div>
                <label class="control-label col-sm-2">A.</label>
            </div>

            <div class="form-row mt-3">
                <label class="control-label col-sm-2" for="">แรงดัน Battery ก้อนที่ 1</label>
                <div class="col-sm-8">
                    <input type="text" class="form-control" id="powerBatterytext1" runat="server" />
                </div>
                <label class="control-label col-sm-2" for="">V.</label>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-2" for="">แรงดัน Battery ก้อนที่ 2</label>
                <div class="col-sm-8">
                    <input type="text" class="form-control" id="powerBatterytext2" runat="server" />
                </div>
                <label class="control-label col-sm-2" for="">V.</label>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-2" for="">แรงดัน Battery ก้อนที่ 3</label>
                <div class="col-sm-8">
                    <input type="text" class="form-control" id="powerBatterytext3" runat="server" />
                </div>
                <label class="control-label col-sm-2" for="">V.</label>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-2" for="">แรงดัน Battery ก้อนที่ 4</label>
                <div class="col-sm-8">
                    <input type="text" class="form-control" id="powerBatterytext4" runat="server" />
                </div>
                <label class="control-label col-sm-2" for="">V.</label>
            </div>

            <div class="row mt-3">
                <div class="col-md-12 bg-primary text-white text-center Myfont">
                    <h4>9.คุณภาพของสัญญาณ</h4>
                </div>
            </div>


            <div class="form-row mt-3">
                <label class="control-label col-sm-2">Download (for ONU/VSAT)</label>
                <div class="col-sm-8">
                    <input type="text" class="form-control" id="dowloadforOnuTextbox" runat="server" required="required" />
                </div>
                <label class="control-label col-sm-2">Mb/s</label>
            </div>

            <%----------------------   ---------------------------%>
            <div class="form-row mt-3">
                <label class="control-label col-sm-2">Upload (for ONU/VSAT)</label>
                <div class="col-sm-8">
                    <input type="text" class="form-control" id="uploadforOnuTextbox" runat="server" required="required" />
                </div>
                <label class="control-label col-sm-2">Mb/s</label>
            </div>



            <%----------------------   ---------------------------%>
            <div class="form-row mt-3">
                <label class="control-label col-sm-2">Ping Test (for ONU/VSAT)</label>
                <div class="col-sm-8">
                    <input type="text" class="form-control" id="pingTestTextbox" runat="server" required="required" />
                </div>
                <label class="control-label col-sm-2">ms</label>
            </div>



            <%----------------------   ---------------------------%>
            <div class="form-row mt-3">
                <label class="control-label col-sm-2">Download (for WIFI)</label>
                <div class="col-sm-8">
                    <input type="text" class="form-control" id="dowloadForwifiTextbox" runat="server" required="required" />
                </div>
                <label class="control-label col-sm-2">Mb/s</label>
            </div>

            <%----------------------   ---------------------------%>
            <div class="form-row mt-3">
                <label class="control-label col-sm-2">Upload (for WIFI)</label>
                <div class="col-sm-8">
                    <input type="text" class="form-control" id="uploadForwifiTextbox" runat="server" required="required" />
                </div>
                <label class="control-label col-sm-2">Mb/s</label>
            </div>


            <%----------------------   ---------------------------%>
            <div class="form-row mt-3">
                <label class="control-label col-sm-2">Ping Test (for WIFI)</label>
                <div class="col-sm-8">
                    <input type="text" class="form-control" id="pingtestForwifiTextbox" runat="server" required="required" />
                </div>
                <label class="control-label col-sm-2">ms</label>
            </div>


            <div class="row mt-3">
                <div class="col-md-12 bg-warning text-white text-center Myfont">
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
            <%--////////////// ---------------------  ---------------------------  //////////////////--%>


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
                    <h3>12. รายละเอียดผู้ทำ PM</h3>
                </div>
            </div>

            <%----------------------  ---------------------------%>
            <div class="row mt-3">
                <div class="col-md-3 text-center">
                    <span>ชื่อ</span>
                </div>
                <div class="col-md-9">
                    <input type="text" class="form-control" id="namepmTextbox" runat="server" />
                </div>

            </div>

            <%---------------------- QuestionId = ---------------------------%>
            <div class="row mt-3">
                <div class="col-md-3 text-center">
                    <span>วันที่ทำ PM</span>
                </div>
                <div class="col-md-9">
                    <input type="text" class="form-control" id="dayDopmTextbox" runat="server" />
                </div>
            </div>

            <div class="row mt-3">
                <div class="col-md-12 bg-success text-white text-center Myfont">
                    <h3>PICTURE CHECKLIST</h3>
                </div>
            </div>

            <%---------------------- QuestionId = 205  ---------------------------%>
            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูปภาพรวมบริเวณ Site</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="picallsiteRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1195).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="picallsiteRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1195).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %> />NOT PASS
                    </label>
                </div>
            </div>

            <%---------------------- QuestionId = 206  ---------------------------%>
            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูปหน้าตู้ ก่อน-หลัง</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="picturefontbackRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1196).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %>>PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="picturefontbackRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1196).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %>>NOT PASS
                    </label>
                </div>
            </div>

            <%---------------------- QuestionId = 207  ---------------------------%>
            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูปภายในตู้ ก่อน-หลัง</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="pictureinfontbackRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1197).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="pictureinfontbackRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1197).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %> />NOT PASS
                    </label>
                </div>
            </div>


            <%---------------------- QuestionId = 208  ---------------------------%>
            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูปขณะทำความสะอาดตู้ ก่อน-หลัง</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="picCleanboxRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1198).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="picCleanboxRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1198).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %> />NOT PASS
                    </label>
                </div>
            </div>


            <%---------------------- QuestionId = 209  ---------------------------%>
            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูปสถานะ Circuit Breaker (ON)</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="picCircuitOnRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1199).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="picCircuitOnRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1199).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %> />NOT PASS
                    </label>
                </div>
            </div>

            <%---------------------- QuestionId = 210  ---------------------------%>
            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูปการตรวจสอบงานติดตั้งระบบ Ground และ Bar Ground</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="picGroundandbarRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1200).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="picGroundandbarRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1200).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %> />NOT PASS
                    </label>
                </div>
            </div>

            <%---------------------- QuestionId = 211  ---------------------------%>
            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูปการตรวจสอบสถานะไฟฟ้ารั่วลง Ground (Lamp Test)</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="picElecGroundTestRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1201).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %>>PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="picElecGroundTestRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1201).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %>>NOT PASS
                    </label>
                </div>
            </div>


            <%---------------------- QuestionId = 213  ---------------------------%>
            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูป PEA Meter</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="picpeaMeterRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1202).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="picpeaMeterRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1202).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %> />NOT PASS
                    </label>
                </div>
            </div>

            <%---------------------- QuestionId = 214  ---------------------------%>
            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูปการวัดแรงดัน AC และกระแส AC </label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="acPicRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1203).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="acPicRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1203).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %> />NOT PASS
                    </label>
                </div>
            </div>

            <%---------------------- QuestionId = 215  ---------------------------%>
            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูปหน้าจอ UPS แสดงค่าต่างๆ และ Serial NO.   </label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="picUPSRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1204).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="picUPSRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1204).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %> />NOT PASS
                    </label>
                </div>
            </div>


            <%---------------------- QuestionId = 216  ---------------------------%>
            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูป ONU/Modem พร้อม Serial NO. และ MAC </label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="picONUModemRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1205).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="picONUModemRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1205).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %> />NOT PASS
                    </label>
                </div>
            </div>

            <%---------------------- QuestionId = 217  ---------------------------%>
            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูป Power Supply พร้อม Serial NO.</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="picpowersubRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1206).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="picpowersubRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1206).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %> />NOT PASS
                    </label>
                </div>
            </div>

            <%---------------------- QuestionId = 218  ---------------------------%>
            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูป Switch 8 Port พร้อม Serial NO. และ MAC </label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="picSwitch8portRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1207).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="picSwitch8portRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1207).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %> />NOT PASS
                    </label>
                </div>
            </div>

            <%---------------------- QuestionId = 219  ---------------------------%>
            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูป Outdoor AP 2.4 GHz พร้อม Serial NO. และ MAC</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="picOutdoor2_4Radio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1208).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="picOutdoor2_4Radio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1208).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %> />NOT PASS
                    </label>
                </div>
            </div>

            <%---------------------- QuestionId = 220  ---------------------------%>
            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูป Outdoor AP 5 GHz พร้อม Serial NO. และ MAC</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="picOutdoor5Radio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1209).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %>>PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="picOutdoor5Radio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1209).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %>>NOT PASS
                    </label>
                </div>
            </div>


            <%---------------------- QuestionId = 221  ---------------------------%>
            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูปการ Test Speed ONU (30/10 mbps)</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="picOnu3010Radio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1636).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %>>PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="picOnu3010Radio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1636).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %>>NOT PASS
                    </label>
                </div>
            </div>

            <%---------------------- QuestionId = 222  ---------------------------%>
            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูปการ Test Speed VSAT (30/5 mbps) *เฉพาะ SAT</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="pictestVSAT305Radio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1637).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %>>PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="pictestVSAT305Radio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1637).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %>>NOT PASS
                    </label>
                </div>
            </div>

            <%---------------------- QuestionId = 223  ---------------------------%>
            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูป Cable Inlet ด้านในและด้านนอก  </label>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" class="form-check-input" name="picCableinoutRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1638).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="picCableinoutRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1638).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %> />NOT PASS
                    </label>
                </div>
            </div>

            <%---------------------- QuestionId = 224  ---------------------------%>
            <div class="form-row mt-3">
                <label class="control-label col-sm-4" for="">รูป Filter ก่อน-หลัง ทำความสะอาด</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="picFillterRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1639).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label" for="">
                        <input type="radio" class="form-check-input" name="picFillterRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1639).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %> />NOT PASS
                    </label>
                </div>
            </div>

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
                        <input type="radio" class="form-check-input" name="inStallBaseRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1210).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="inStallBaseRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1210).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %> />NOT PASS
                    </label>
                </div>
            </div>

            <%---------------------- QuestionId = 235  ---------------------------%>
            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูปความสะอาดบริเวณจานดาวเทียม</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="picCleansatelliteRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1211).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="picCleansatelliteRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1211).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %> />NOT PASS
                    </label>
                </div>
            </div>



            <%---------------------- QuestionId = 236  ---------------------------%>
            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูป LNB พร้อม Part NO.</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="picLnbRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1212).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %>>PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="picLnbRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1212).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %>>NOT PASS
                    </label>
                </div>
            </div>

            <%---------------------- QuestionId = 237  ---------------------------%>
            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูป BUC พร้อม Part NO.</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="picBUCRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1213).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="picBUCRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1213).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %> />NOT PASS
                    </label>
                </div>
            </div>

            <%---------------------- QuestionId = 238  ---------------------------%>
            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูปการเก็บสายและพันหัวที่ LNB/BUC</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="picWiringLnbRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1214).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %>>PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="picWiringLnbRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1214).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %>>NOT PASS
                    </label>
                </div>
            </div>

            <%---------------------- QuestionId = 239  ---------------------------%>
            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูปแนว Line Of Sight (ดูการถูกบังของหน้าจานดาวเทียม)</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="picLineofSightRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1215).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="picLineofSightRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1215).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %> />NOT PASS
                    </label>
                </div>
            </div>



            <%--////////////// --------------------- END  SECTION ID 21 ---------------------------  //////////////////--%>


            <%--////////////////////////////////  SECTION SOLAR  ////////////////////////////--%>
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
                        <input type="radio" class="form-check-input" name="picBaseSolarcellRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1216).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %>>PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="picBaseSolarcellRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1216).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %>>NOT PASS
                    </label>
                </div>
            </div>

            <%---------------------- QuestionId = 241  ---------------------------%>
            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูปอุปกรณ์ Solar Cell ภายในห้อง</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="solarcellToolsinroomRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1217).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="solarcellToolsinroomRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1217).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %> />NOT PASS
                    </label>
                </div>
            </div>



            <%---------------------- QuestionId = 242  ---------------------------%>
            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูปหน้าจอ Charger แสดงค่าต่างๆ</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="screenChargerRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1218).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="screenChargerRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1218).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %> />NOT PASS
                    </label>
                </div>
            </div>


            <%---------------------- QuestionId = 243  ---------------------------%>
            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูปหน้าจอ Inverter แสดงค่าต่างๆ</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="screenInverterRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1219).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="screenInverterRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1219).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %> />NOT PASS
                    </label>
                </div>
            </div>


            <%---------------------- QuestionId = 244  ---------------------------%>
            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูป Circuit Breaker ภายในตู้</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="piccircuitBreakerRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1220).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="piccircuitBreakerRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1220).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %> />NOT PASS
                    </label>
                </div>
            </div>

            <%---------------------- QuestionId = 245  ---------------------------%>
            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูป Terminal ต่อสายภายในตู้</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="picTerminalRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1221).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="picTerminalRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1221).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %> />NOT PASS
                    </label>
                </div>
            </div>

            <%---------------------- QuestionId =   ---------------------------%>
            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รรูปการวัดแรงดัน Battery ก้อนที่ 1</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="picbattery1sRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1222).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="picbattery1sRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1222).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %> />NOT PASS
                    </label>
                </div>
            </div>

            <%---------------------- QuestionId =  ---------------------------%>
            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูปการวัดแรงดัน Battery ก้อนที่ 2</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="picbattery2sRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1223).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="picbattery2sRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1223).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %> />NOT PASS
                    </label>
                </div>
            </div>

            <%---------------------- QuestionId =   ---------------------------%>
            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูปการวัดแรงดัน Battery ก้อนที่ 3</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="picbattery3sRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1224).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="picbattery3sRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1224).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %> />NOT PASS
                    </label>
                </div>
            </div>

            <%---------------------- QuestionId =   ---------------------------%>
            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูปการวัดแรงดัน Battery ก้อนที่ 4</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="picbattery4sRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1225).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %> />PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="picbattery4sRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1225).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %> />NOT PASS
                    </label>
                </div>
            </div>





            <%---------------------- QuestionId = 246  ---------------------------%>
            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูปความสะอาดแผง PV</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="picCleaningPvRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1226).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %>>PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="picCleaningPvRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1226).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %>>NOT PASS
                    </label>
                </div>
            </div>




            <%---------------------- QuestionId = 247  ---------------------------%>
            <div class="form-row mt-3">
                <label class="control-label col-sm-4">รูปภาพรวมดูสิ่งบดบังแสงอาทิตย์</label>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="picSunriseRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1227).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %>>PASS
                    </label>
                </div>
                <div class="form-check-inline">
                    <label class="form-check-label">
                        <input type="radio" class="form-check-input" name="picSunriseRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1227).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %>>NOT PASS
                    </label>
                </div>
            </div>
            <%--////////////// --------------------- ---------------------------  //////////////////--%>


            <div class="row mt-3 ">
                <div class="col-sm-12">1.รูป PICTURE CHECKLIST </div>
                <asp:FileUpload ID="pictureChecklistImages" runat="server" data-thumbnail="user_img_2" accept="image/" onchange="previewImage(this)" />

            </div>
            <div class="row ml-3 mt-3">
                <img id="user_img_2" src='<% if (answers.Count() > 0) Response.Write(answers.Where(x => x.QuestionId == 1228).FirstOrDefault().AnsDes); %>' class="placeholder2" />
            </div>



            <%---------------------- QuestionId = 260  ---------------------------%>
            <div class="row mt-3">
                <div class="col-sm-12">2.รูป VSAT PICTURE CHECKLIST</div>
                <asp:FileUpload ID="vsatpictureChecklistImages" runat="server" data-thumbnail="user_img_3" accept="image/" onchange="previewImage(this)" />
                <%--                    <input type="file" name="image3" onchange="previewImage(this)" accept="image/*" data-thumbnail="user_img_3" />--%>
            </div>
            <div class="row ml-3 mt-3">
                <img id="user_img_3" src='<% if (answers.Count() > 0) Response.Write(answers.Where(x => x.QuestionId == 1229).FirstOrDefault().AnsDes); %>' class="placeholder2" />
            </div>


            <%---------------------- QuestionId = 261  ---------------------------%>
            <div class="row mt-3">
                <div class="col-sm-12">3.รูป SOLAR CELL PICTURE CHECKLIST</div>
                <asp:FileUpload ID="solarcellpictureChecklistImages" runat="server" data-thumbnail="user_img_4" accept="image/" onchange="previewImage(this)" />
                <%--                    <input type="file" name="image4" onchange="previewImage(this)" accept="image/*" data-thumbnail="user_img_4" />--%>
            </div>
            <div class="row ml-3 mt-3">
                <img id="user_img_4" src='<% if (answers.Count() > 0) Response.Write(answers.Where(x => x.QuestionId == 1230).FirstOrDefault().AnsDes); %>' class="placeholder2" />
            </div>
            <br />
            <br />

            <div class="row text-center ">
                <div class="col">
                    <asp:Button ID="SubmitButton" runat="server" Text="บันทึก" CssClass="btn btn-primary btn-lg  " OnClick="SubmitButton_Click" />
                </div>
            </div>

            <div class="row mt-5">
            </div>
        </div>
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
</body>

</html>
