<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="USOform.PreventiveMaintenanceReportBB2._2_3._2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>PreventiveMaintenanceReportBB2.2,3.2</title>
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
    <div class="container bg-white Myfont"> 
         <div class="alert alert-success" role="alert" runat="server" id="SuccessPanel" visible="false">
                This is a success alert with <a href="#" class="alert-link">an example link</a>. Give it a click if you like.
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
                <input type="text" class="form-control" id="GroupNameTextBox" runat="server" />
            </div>
        </div>

        <div class="form-row mt-3">
            <label class="control-label col-sm-1" for="">ภาค :</label>
            <div class="col-sm-4">
                <input type="text" class="form-control"  id="AreaTextbox" runat="server" />
            </div>
        </div>

        <div class="form-row mt-3">
            <label class="control-label col-sm-1" for="">บริษัท :</label>
            <div class="col-sm-4">
                <input type="text" class="form-control" id="CompanyTextbox" runat="server"/>
            </div>
        </div>



        <div class="form-row mt-3">
            <label class="control-label col-sm-8" for="">ส่วนที่ 1 การจัดให้มีบริการอินเทอร์เน็ตความเร็วสูง (Broadband Internet Service) บริการประเภทที่ </label>
            <div class="form-check-inline">
                <label class="form-check-label" for="">
                    <input type="radio" class="form-check-input"  name="category" value="2.2"  <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 739).FirstOrDefault().AnsDes == "2.2") { Response.Write("checked"); } else { Response.Write(""); }  %> />2.2
                </label> 
            
            </div>
            <div class="form-check-inline">
                <label class="form-check-label" for="">
                    <input type="radio" class="form-check-input"  name="category" value="3.2"  <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 739).FirstOrDefault().AnsDes == "3.2") { Response.Write("checked"); } else { Response.Write(""); }  %> />3.2
                </label> 
            
            </div>
        </div>


        <div class="form-row mt-3">
            <label class="control-label col-sm-2" for="">รอบการบำรุงรักษา ครั้งที่ </label>
            <div class="col-sm-1">
                    <input type="text" class="form-control" id="maintenanceCountTextbox" runat="server" required="required" />
                </div>
                /
              <div class="col-sm-3">
                  <input type="text" class="form-control" placeholder="ปีพุทธศักราช" id="yearTextbox" runat="server" required="required" />
              </div>
        </div>

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

        <div class="form-row mt-3">
            <label class="control-label col-sm-2" for="">สถานที่ (Site code)</label>
            <div class="col-sm-4">
                <input type="text" class="form-control" id="siteCodeTextbox"  runat="server"  />
            </div>
        </div>


          <div class="row mt-3">
                <div class="col-sm-12 bg-primary text-white">Logo</div>

                <asp:FileUpload ID="pictureOrganize_" runat="server" data-thumbnail="user_img_logo" accept="image/*" onchange="previewImage(this)"  />

                <%--    OLD RESOUCE    <input type="file" name="image0" onchange="previewImage(this)" accept="image/*" data-thumbnail="user_img_0" />--%>
            </div>
            <%-- onchange="previewImage(this)"--%>
            <div class="row ml-3 mt-3">
                <img id="user_img_logo" src='<% if(answers.Count() > 0) Response.Write(answers.Where(x => x.QuestionId == 745).FirstOrDefault().AnsDes); %>' class="placeholder2" />
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
                <div class="col-sm-12 bg-primary text-white">ใส่ป้ายหน้าโรงเรียน</div>

                <asp:FileUpload ID="signboardschoolImage" runat="server" data-thumbnail="user_img_0" accept="image/*" onchange="previewImage(this)"  />

               
            </div>
            <%-- onchange="previewImage(this)"--%>
            <div class="row ml-3 mt-3">
                <img id="user_img_0" src='<% if(answers.Count() > 0) Response.Write(answers.Where(x => x.QuestionId == 757).FirstOrDefault().AnsDes); %>' class="placeholder2" />
            </div>


            <%-- QuestionId = 20, --%>
            <div class="row mt-3">
                <div class="col-sm-12 bg-primary text-white">ใส่รูปหน้าอาคารศูนย์ USO Net</div>
                <%--OLD RESOUCE <asp:FileUpload ID="Building2Image" runat="server" data-thumbnail="user_img_1" accept="image/*" onchange="previewImage(this)" />--%>
                <asp:FileUpload ID="usonetsignboardImage" runat="server" data-thumbnail="user_img_1" accept="image/*" onchange="previewImage(this)"  />
            </div>
            <div class="row ml-3 mt-3">
                <img id="user_img_1" src='<% if(answers.Count() > 0) Response.Write(answers.Where(x => x.QuestionId == 756).FirstOrDefault().AnsDes); %>' class="placeholder2" />
            </div>




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
                    <p style="clear: both;">
                        <div id="signatureExecutorTextbox"></div>
                        <input type="hidden" id="signatureExecutorJSON" class="ui-state-active" runat="server" />
                        <div id="redrawSignature1" hidden="hidden"></div>
                </div>
                 <div class="row">
               <%-- <img id="user_img_6" src='<% if (answers.Count() > 0) Response.Write(answers.Where(x => x.QuestionId == 758).FirstOrDefault().AnsDes); %>' class="placeholder2" />--%>
            </div>
                <div class="col-md-6 text-center">
                    <p style="clear: both;">
                        <div id="signatureSupervisorTextbox"  ></div>
                        <input type="hidden" id="signatureSupervisorJSON" class="ui-state-active" runat="server" />
                        <div id="redrawSignature1" hidden="hidden"></div>
                </div>
                 <div class="row">
              <%--  <img id="user_img_7" src='<% if (answers.Count() > 0) Response.Write(answers.Where(x => x.QuestionId == 759).FirstOrDefault().AnsDes); %>' class="placeholder2" />--%>
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


        <%---/////////////////////////////////     ////////////////////////////////////////--------%>
      

         <div class="row mt-3">
                <div class="col-md-12 bg-success text-white text-center Myfont">
                    <h3>1. รายละเอียดศูนย์</h3>
                </div>
            </div>
           
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
                            <input type="radio" class="form-check-input" name="typeofsignalRadio" value="OFC"  <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 768).FirstOrDefault().AnsDes == "OFC") { Response.Write("checked"); } else { Response.Write(""); }  %>/>OFC
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="typeofsignalRadio" value="Satellite"  <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 768).FirstOrDefault().AnsDes == "Satellite") { Response.Write("checked"); } else { Response.Write(""); }  %>/>Satellite
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
                        <h3>2.ระบบไฟฟ้า (หลัก)</h3>
                    </div>
                </div>
                <div class="form-row mt-3">
                    <%------  ------------------------------------------------------------------------------------------------------------%>
                    <label class="control-label col-sm-2">ระบบไฟฟ้า</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="elecRadio" value="PEA"  <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 770).FirstOrDefault().AnsDes == "PEA") { Response.Write("checked"); } else { Response.Write(""); }  %> />PEA
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="elecRadio" value="SolarCell"   <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 770).FirstOrDefault().AnsDes == "SolarCell") { Response.Write("checked"); } else { Response.Write(""); }  %>/>Solar Cell
                        </label>
                    </div>
                </div>



                <div class="form-row mt-3">
                    <%------, ---------------------------------------------------------------------------------------------------------%>
                    <label class="control-label col-sm-2">หม้อแปลงไฟฟ้า</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="transformerRadio" value="1Phase" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 771).FirstOrDefault().AnsDes == "1Phase") { Response.Write("checked"); } else { Response.Write(""); }  %> />1 Phase
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="transformerRadio" value="3Phase" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 771).FirstOrDefault().AnsDes == "3Phase") { Response.Write("checked"); } else { Response.Write(""); }  %> />3 Phase
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
                            <input type="radio" class="form-check-input" name="conditionRadio" value="ปกติ"  <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 777).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %>/>ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="conditionRadio" value="ชำรุด/ใช้งานไม่ได้"  <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 777).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); } %>/>ชำรุด/ใช้งานไม่ได้
                        </label>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <%------  ----------------------------------------------------------------------------------------------------------%>
                    <label class="control-label col-sm-2">สภาพ MDB/ Circuit Breaker</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="MDBCircuitBreakerRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 778).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %>/>ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="MDBCircuitBreakerRadio" value="ชำรุด/ใช้งานไม่ได้"<% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 778).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); } %>/>ชำรุด/ใช้งานไม่ได้
                        </label>
                    </div>
                </div>
                <%--////////////// -----------------------------  //////////////////--%>

            <%--////////////// ------------- -----------------  //////////////////--%>
                <div class="row mt-3">
                    <div class="col-md-12 bg-primary text-white text-center Myfont">
                        <h3>3.ระบบไฟ (สำรอง)</h3>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <%------  ----------------------------------------------------------------------------------------------------------%>
                    <label class="control-label col-sm-2">UPS ภายในตู้</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="inupsRadio" value="มี" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 779).FirstOrDefault().AnsDes == "มี") { Response.Write("checked"); } else { Response.Write(""); } %> />มี
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="inupsRadio" value="ไม่มี" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 779).FirstOrDefault().AnsDes == "ไม่มี") { Response.Write("checked"); } else { Response.Write(""); } %>/>ไม่มี
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

                <%------  --------------------------------------------------------------------------------------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-2">กระแส Load</label>
                    <div class="col-sm-8">
                        <input type="text" class="form-control" id="electricloadTextbox" runat="server" required="required" />
                    </div>
                    <label class="control-label col-sm-2">A.</label>
                </div>


                <%------  ---------------------------------------------------------------------------------------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-2">UPS MODE</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="upsModeRadio" value="LINE" required="required"<% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 782).FirstOrDefault().AnsDes == "LINE") { Response.Write("checked"); } else { Response.Write(""); } %> />LINE
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="upsModeRadio" value="BATT." required="required"<% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 782).FirstOrDefault().AnsDes == "BATT.") { Response.Write("checked"); } else { Response.Write(""); } %> />BATT.
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="upsModeRadio" value="BYPASS" required="required" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 782).FirstOrDefault().AnsDes == "BYPASS") { Response.Write("checked"); } else { Response.Write(""); } %>/>BYPASS
                        </label>
                    </div>
                </div>



                <%------  ---------------------------------------------------------------------------------------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-2">การทำงานของระบบไฟสำรอง</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="emergeneratorRadio" value="ปกติ"<% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 783).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %> />ปกติ
                        </label>
                    </div>

                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="emergeneratorRadio" value="ชำรุด/ใช้งานไม่ได้" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 783).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); } %>/>ชำรุด/ใช้งานไม่ได้
                        </label>
                    </div>
                </div>

                <%------  ----------------------------------------------------------------------------------------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-2">สภาพ Battery Bank</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="stateBatteryBankRadio" value="ปกติ"<% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 784).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %> />ปกติ
                        </label>
                    </div>

                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="stateBatteryBankRadio" value="ชำรุด/ใช้งานไม่ได้" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 784).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); } %>/>ชำรุด/ใช้งานไม่ได้
                        </label>
                    </div>
                </div>
                <%--////////////// ------------- -----------------  //////////////////--%>




        <%---/////////////////////////////////     S ////////////////////////////////////////--------%>
             <div class="row mt-3">
                    <div class="col-md-12 bg-primary text-white text-center Myfont">
                        <h3>4.รายละเอียดอุปกรณ์ Network ภายในศูนย์</h3>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <%------  --------------------------------------------------------------------------------------------------------%>
                    <label class="control-label col-sm-2">ONU/Modem Network</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="onuModemRadio" value="USO"<% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 785).FirstOrDefault().AnsDes == "USO") { Response.Write("checked"); } else { Response.Write(""); } %> />USO
                        </label>
                    </div>

                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="onuModemRadio" value="TRUE"<% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 785).FirstOrDefault().AnsDes == "TRUE") { Response.Write("checked"); } else { Response.Write(""); } %> />TRUE
                        </label>
                    </div>

                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="onuModemRadio" value="3BB"<% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 785).FirstOrDefault().AnsDes == "3BB") { Response.Write("checked"); } else { Response.Write(""); } %> />3BB
                        </label>
                    </div>

                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="onuModemRadio" value="Satellite" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 785).FirstOrDefault().AnsDes == "Satellite") { Response.Write("checked"); } else { Response.Write(""); } %>/>Satellite
                        </label>
                    </div>
                </div>


                <%------  --------------------------------------------------------------------------------------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-2">Switch 8 Port</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="switchportRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 786).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %>/>ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="switchportRadio" value="ชำรุด/ใช้งานไม่ได้" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 786).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); } %>/>ชำรุด/ใช้งานไม่ได้
                        </label>
                    </div>
                </div>


                <%------ , --------------------------------------------------------------------------------------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-2">Switch 48 Port</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="switch48portRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 787).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %> />ปกติ
                        </label>
                    </div>

                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="switch48portRadio" value="ชำรุด/ใช้งานไม่ได้"<% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 787).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); } %> />ชำรุด/ใช้งานไม่ได้
                        </label>
                    </div>
                </div>


                <%------ --------------------------------------------------------------------------------------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-2">Outdoor AP ตัวที่ 1</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="outdoorapRadio" value="ปกติ"<% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 788).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %> />ปกติ
                        </label>
                    </div>

                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="outdoorapRadio" value="ชำรุด/ใช้งานไม่ได้" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 788).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); } %>/>ชำรุด/ใช้งานไม่ได้
                        </label>
                    </div>
                </div>


                <%------ , -------------------------------------------------------------------------------------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-2">Outdoor AP ตัวที่ 2</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="outdoorap2Radio" value="ปกติ"<% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 789).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %> />ปกติ
                        </label>
                    </div>

                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="outdoorap2Radio" value="ชำรุด/ใช้งานไม่ได้"<% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 789).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); } %> />ชำรุด/ใช้งานไม่ได้
                        </label>
                    </div>
                </div>


                <%------  --------------------------------------------------------------------------------------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-2">Indoor AP ตัวที่ 1</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="indoorapRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 790).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %>/>ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="indoorapRadio" value="ชำรุด/ใช้งานไม่ได้" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 790).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); } %>/>ชำรุด/ใช้งานไม่ได้
                        </label>
                    </div>
                </div>


                <%------  -----------------------------------------------------------------------------------------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-2">Indoor AP ตัวที่ 2</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="indoorap2Radio" value="ปกติ"<% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 791).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %> />ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="indoorap2Radio" value="ชำรุด/ใช้งานไม่ได้" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 791).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); } %>/>ชำรุด/ใช้งานไม่ได้
                        </label>
                    </div>
                </div>

                <%------  ------------------------------------------------------------------------------------------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-2">การ Wiring สายไฟ</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="wiringelecRadio" value="เรียบร้อย"<% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 792).FirstOrDefault().AnsDes == "เรียบร้อย") { Response.Write("checked"); } else { Response.Write(""); } %> />เรียบร้อย
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="wiringelecRadio" value="ไม่เรียบร้อย"<% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 792).FirstOrDefault().AnsDes == "ไม่เรียบร้อย") { Response.Write("checked"); } else { Response.Write(""); } %> />ไม่เรียบร้อย
                        </label>
                    </div>
                </div>

                <%------  ------------------------------------------------------------------------------------------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-2">การ Wiring Patch cord และ สาย LAN</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="wiringpatchRadio" value="เรียบร้อย" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 793).FirstOrDefault().AnsDes == "เรียบร้อย") { Response.Write("checked"); } else { Response.Write(""); } %> />เรียบร้อย
                        </label>
                    </div>

                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="wiringpatchRadio" value="ไม่เรียบร้อย" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 793).FirstOrDefault().AnsDes == "ไม่เรียบร้อย") { Response.Write("checked"); } else { Response.Write(""); } %> />ไม่เรียบร้อย
                        </label>
                    </div>
                </div>
                <%--////////////// ------------- //////////////////--%>



          <%--////////////// ------------ -----------------  //////////////////--%>
                <div class="row mt-3">
                    <div class="col-md-12 bg-success text-white text-center Myfont">
                        <h3>5.ระบบ Ground</h3>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <%----------------------  ---------------------------%>
                    <label class="control-label col-sm-4">ความแข็งแรงจุดต่อ Ground Bar</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="groundbarRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 794).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %>/>ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="groundbarRadio" value="ชำรุด"<% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 794).FirstOrDefault().AnsDes == "ชำรุด") { Response.Write("checked"); } else { Response.Write(""); } %> />ชำรุด
                        </label>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <%----------------------  ---------------------------%>
                    <label class="control-label col-sm-4">ความแข็งแรงของน็อตขันหางปลาอุปกรณ์</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="notfishRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 795).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %>/>ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="notfishRadio" value="ชำรุด" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 795).FirstOrDefault().AnsDes == "ชำรุด") { Response.Write("checked"); } else { Response.Write(""); } %>/>ชำรุด
                        </label>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <%---------------------- , ---------------------------%>
                    <label class="control-label col-sm-4">สายกราวด์เรียบร้อย ปลอดภัย สมบูรณ์</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="safegroundRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 796).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %>/>ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="safegroundRadio" value="ชำรุด"<% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 796).FirstOrDefault().AnsDes == "ชำรุด") { Response.Write("checked"); } else { Response.Write(""); } %> />ชำรุด
                        </label>
                    </div>
                </div>



                <%----------------------  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">สถานะไฟฟ้ารั่วลง Ground</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="brokenElecRadio" value="ไม่พบไฟฟ้ารั่ว"<% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 797).FirstOrDefault().AnsDes == "ไม่พบไฟฟ้ารั่ว") { Response.Write("checked"); } else { Response.Write(""); } %> />ไม่พบไฟฟ้ารั่ว
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="brokenElecRadio" value="พบไฟฟ้ารั่ว"<% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 797).FirstOrDefault().AnsDes == "พบไฟฟ้ารั่ว") { Response.Write("checked"); } else { Response.Write(""); } %> />พบไฟฟ้ารั่ว
                        </label>
                    </div>
                </div>
                <%--////////////// ------------------------------  //////////////////--%>


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
                            <input type="radio" class="form-check-input" name="firesmokedDectorRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 798).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %>/>ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="firesmokedDectorRadio" value="ชำรุด/ใช้งานไม่ได้"<% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 798).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); } %> />ชำรุด/ใช้งานไม่ได้
                        </label>
                    </div>
                </div>


                <div class="form-row mt-3">
                    <%---------------------- QuestionId = 62 ---------------------------%>
                    <label class="control-label col-sm-4">Fire Alarm Manual Switch</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="firealarmManualswitchRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 799).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %>/>ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="firealarmManualswitchRadio" value="ชำรุด/ใช้งานไม่ได้"<% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 799).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); } %> />ชำรุด/ใช้งานไม่ได้
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
                            <input type="radio" class="form-check-input" name="emerLightRadio" value="ปกติ"<% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 802).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %> />ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="emerLightRadio" value="ชำรุด/ใช้งานไม่ได้"<% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 802).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); } %> />ชำรุด/ใช้งานไม่ได้
                        </label>
                    </div>
                </div>


                <%----------------------  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">ระบบ Monitor กล้องวงจรปิด</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="monitorCameraRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 803).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %>/>ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="monitorCameraRadio" value="ไม่สามารถ Monitor ได้" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 803).FirstOrDefault().AnsDes == "ไม่สามารถ Monitor ได้") { Response.Write("checked"); } else { Response.Write(""); } %>/>ไม่สามารถ Monitor ได้
                        </label>
                    </div>
                </div>



                <%----------------------  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">กล้องวงจรปิดห้องโถง</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="cameraHallRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 804).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %>/>ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="cameraHallRadio" value="ชำรุด" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 804).FirstOrDefault().AnsDes == "ชำรุด") { Response.Write("checked"); } else { Response.Write(""); } %>/>ชำรุด
                        </label>
                    </div>
                </div>


                <%----------------------  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">กล้องวงจรปิดห้องประชุม </label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="camerameetingRadio" value="ปกติ"<% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 805).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %> />ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="camerameetingRadio" value="ชำรุด"<% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 805).FirstOrDefault().AnsDes == "ชำรุด") { Response.Write("checked"); } else { Response.Write(""); } %> />ชำรุด
                        </label>
                    </div>
                </div>





                <%----------------------  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">กล้องวงจรปิดประตูทางเข้า</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="camerainRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 806).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %>/>ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="camerainRadio" value="ชำรุด"<% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 806).FirstOrDefault().AnsDes == "ชำรุด") { Response.Write("checked"); } else { Response.Write(""); } %> />ชำรุด
                        </label>
                    </div>
                </div>

          <%----------------------  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">กล้องวงจรปิดด้านหลัง</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="camerabackRadio" value="ปกติ"<% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 807).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %> />ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="camerabackRadio" value="ชำรุด"<% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 807).FirstOrDefault().AnsDes == "ชำรุด") { Response.Write("checked"); } else { Response.Write(""); } %> />ชำรุด
                        </label>
                    </div>
                </div>

          <%----------------------  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">กล้องวงจรปิดลานด้านหน้า</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="camerafont2Radio" value="ปกติ"<% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 808).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %> />ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="camerafont2Radio" value="ชำรุด" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 808).FirstOrDefault().AnsDes == "ชำรุด") { Response.Write("checked"); } else { Response.Write(""); } %>/>ชำรุด
                        </label>
                    </div>
                </div>

                <%--////////////// -------------END  SECTION ID 9 -----------------  //////////////////--%>




        <%--/////////////////////////  //////////////////////////////////////////////--%>
          <div class="row mt-3">
                    <div class="col-md-12 bg-primary text-white text-center Myfont">
                        <h3>7.ระบบสารสนเทศ</h3>
                    </div>
                </div>

                <%----------------------  ---------------------------%>
                <%----------------------  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">จอทีวีห้องประชุม</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="televisRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 809).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %>/>ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="televisRadio" value="ชำรุด/ใช้งานไม่ได้"<% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 809).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); } %> />ชำรุด/ใช้งานไม่ได้
                        </label>
                    </div>
                </div>


                <%----------------------  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">คอมพิวเตอร์เจ้าหน้าที่ศูนย์</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="computerAgentRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 810).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %>/>ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="computerAgentRadio" value="ชำรุด/ใช้งานไม่ได้"<% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 810).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); } %> />ชำรุด/ใช้งานไม่ได้
                        </label>
                    </div>
                </div>






                <%----------------------  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">Printer</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="printerRadio" value="ปกติ"<% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 811).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %> />ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="printerRadio" value="ชำรุด/ใช้งานไม่ได้" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 811).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); } %>/>ชำรุด/ใช้งานไม่ได้
                        </label>
                    </div>
                </div>



                <%----------------------  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">คอมพิวเตอร์ตัวที่ 1</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="Com1Radio" value="ปกติ"<% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 812).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %> />ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="Com1Radio" value="ชำรุด/ใช้งานไม่ได้"<% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 812).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); } %> />ชำรุด/ใช้งานไม่ได้
                        </label>
                    </div>
                </div>


                <%----------------------  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">คอมพิวเตอร์ตัวที่ 2</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="com2Radio" value="ปกติ"<% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 813).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %> />ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="com2Radio" value="ชำรุด/ใช้งานไม่ได้"<% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 813).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); } %> />ชำรุด/ใช้งานไม่ได้
                        </label>
                    </div>
                </div>



                <%---------------------- ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">คอมพิวเตอร์ตัวที่ 3</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="com3Radio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 814).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %>/>ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="com3Radio" value="ชำรุด/ใช้งานไม่ได้" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 814).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); } %>/>ชำรุด/ใช้งานไม่ได้
                        </label>
                    </div>
                </div>




                <%---------------------- ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">คอมพิวเตอร์ตัวที่ 4</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="com4Radio" value="ปกติ"<% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 815).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %> />ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="com4Radio" value="ชำรุด/ใช้งานไม่ได้" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 815).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); } %>/>ชำรุด/ใช้งานไม่ได้
                        </label>
                    </div>
                </div>



                <%---------------------- ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">คอมพิวเตอร์ตัวที่ 5</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="com5Radio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 816).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %>/>ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="com5Radio" value="ชำรุด/ใช้งานไม่ได้"<% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 816).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); } %> />ชำรุด/ใช้งานไม่ได้
                        </label>
                    </div>
                </div>




                <%----------------------  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">คอมพิวเตอร์ตัวที่ 6</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="com6Radio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 817).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %>/>ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="com6Radio" value="ชำรุด/ใช้งานไม่ได้"<% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 817).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); } %> />ชำรุด/ใช้งานไม่ได้
                        </label>
                    </div>
                </div>




                <%----------------------  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">คอมพิวเตอร์ตัวที่ 7</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="com7Radio" value="ปกติ"<% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 818).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %>/>ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="com7Radio" value="ชำรุด/ใช้งานไม่ได้" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 818).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); } %>/>ชำรุด/ใช้งานไม่ได้
                        </label>
                    </div>
                </div>





                <%---------------------- ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">คอมพิวเตอร์ตัวที่ 8</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="com8Radio" value="ปกติ"<% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 819).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %> />ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="com8Radio" value="ชำรุด/ใช้งานไม่ได้"<% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 819).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); } %> />ชำรุด/ใช้งานไม่ได้
                        </label>
                    </div>
                </div>



                <%----------------------  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">คอมพิวเตอร์ตัวที่ 9</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="com9Radio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 820).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %>/>ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="com9Radio" value="ชำรุด/ใช้งานไม่ได้" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 820).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); } %>/>ชำรุด/ใช้งานไม่ได้
                        </label>
                    </div>
                </div>



                <%----------------------  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">คอมพิวเตอร์ตัวที่ 10</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="com10Radio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 821).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %> />ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="com10Radio" value="ชำรุด/ใช้งานไม่ได้" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 821).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); } %> />ชำรุด/ใช้งานไม่ได้
                        </label>
                    </div>
                </div>

           <%----------------------  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">คอมพิวเตอร์ตัวที่ 11</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="com11Radio" value="ปกติ"<% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 822).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %> />ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="com11Radio" value="ชำรุด/ใช้งานไม่ได้"<% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 822).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); } %> />ชำรุด/ใช้งานไม่ได้
                        </label>
                    </div>
                </div>
                <%--////////////// ------------- -----------------  //////////////////--%>


        <%--////////////////////////  SECTION 8  //////////////////////////////////////////--%>
        <div class="row mt-3">
            <div class="col-md-12 bg-primary text-white text-center Myfont">
                <h5>8.ระบบเครื่องปรับอากาศและระบายอากาศ</h5>
            </div>
        </div>

        <div class="form-row mt-3">
            <label class="control-label  col-sm-4" for="">เครื่องปรับอากาศห้องโถง</label>
            <div class="form-check-inline">
                <label class="form-check-label" for="">
                    <input type="radio" class="form-check-input"  name="airhall" value="ปกติ"<% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 823).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %>>ปกติ 
                </label>
            </div>
            <div class="form-check-inline">
                <label class="form-check-label" for="">
                    <input type="radio" class="form-check-input"  name="airhall" value="ชำรุด/ใช้งานไม่ได้"<% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 823).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); } %>>ชำรุด/ใช้งานไม่ได้
                </label>
            </div>
        </div>

        <div class="form-row mt-3">
            <label class="control-label  col-sm-4" for="">เครื่องปรับอากาศห้องประชุม</label>
            <div class="form-check-inline">
                <label class="form-check-label" for="">
                    <input type="radio" class="form-check-input"  name="airmeeting" value="ปกติ"<% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 824).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %>>ปกติ 
                </label>
            </div>
            <div class="form-check-inline">
                <label class="form-check-label" for="">
                    <input type="radio" class="form-check-input"  name="airmeeting" value="ชำรุด/ใช้งานไม่ได้"<% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 824).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); } %>>ชำรุด/ใช้งานไม่ได้
                </label>
            </div>
        </div>

        <div class="form-row mt-3">
            <label class="control-label  col-sm-4" for="">เครื่องปรับอากาศห้อง Server</label>
            <div class="form-check-inline">
                <label class="form-check-label" for="">
                    <input type="radio" class="form-check-input"  name="airserver" value="ปกติ"<% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 825).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %>>ปกติ 
                </label>
            </div>
            <div class="form-check-inline">
                <label class="form-check-label" for="">
                    <input type="radio" class="form-check-input" name="airserver" value="ชำรุด/ใช้งานไม่ได้"<% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 825).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); } %>>ชำรุด/ใช้งานไม่ได้
                </label>
            </div>
        </div>

        <div class="form-row mt-3">
            <label class="control-label  col-sm-4" for="">พัดลมดูดอากาศห้องน้ำ</label>
            <div class="form-check-inline">
                <label class="form-check-label" for="">
                    <input type="radio" class="form-check-input"  name="airtoilet" value="ปกติ"<% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 826).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %>>ปกติ 
                </label>
            </div>
            <div class="form-check-inline">
                <label class="form-check-label" for="">
                    <input type="radio" class="form-check-input"  name="airtoilet" value="ชำรุด/ใช้งานไม่ได้"<% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 826).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); } %>>ชำรุด/ใช้งานไม่ได้
                </label>
            </div>
        </div>

        <div class="form-row mt-3">
            <label class="control-label  col-sm-4" for="">พัดลมดูดอากาศห้องปั๊มน้ำ</label>
            <div class="form-check-inline">
                <label class="form-check-label" for="">
                    <input type="radio" class="form-check-input"  name="airpump" value="ปกติ"<% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 827).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %>>ปกติ 
                </label>
            </div>
            <div class="form-check-inline">
                <label class="form-check-label" for="">
                    <input type="radio" class="form-check-input"  name="airpump" value="ชำรุด/ใช้งานไม่ได้"<% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 827).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); } %>>ชำรุด/ใช้งานไม่ได้
                </label>
            </div>
        </div>


        <%--///////////////////////////  SECTION 9 //////////////////////////////////////--%>
        <div class="row mt-3">
            <div class="col-md-12 bg-success text-white text-center Myfont">
                <h5>9.ระบบสุขาภิบาล</h5>
            </div>
        </div>


        <div class="form-row mt-3">
            <label class="control-label  col-sm-4" for="">มิเตอร์น้ำ</label>
            <div class="form-check-inline">
                <label class="form-check-label" for="">
                    <input type="radio" class="form-check-input"  name="meterwater" value="ปกติ"<% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 828).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %>>ปกติ       
                </label>
            </div>

            <div class="form-check-inline">
                <label class="form-check-label" for="">
                    <input type="radio" class="form-check-input"  name="meterwater" value="ชำรุด/ใช้งานไม่ได้"<% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 828).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); } %>>ชำรุด/ใช้งานไม่ได้
                </label>
            </div>
        </div>

        <div class="form-row mt-3">
            <label class="control-label  col-sm-4" for="">ปั๊มน้ำ</label>
            <div class="form-check-inline">
                <label class="form-check-label" for="">
                    <input type="radio" class="form-check-input"  name="pumpwater" value="ปกติ"<% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 829).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %>>ปกติ       
                </label>
            </div>

            <div class="form-check-inline">
                <label class="form-check-label" for="">
                    <input type="radio" class="form-check-input"  name="pumpwater" value="ชำรุด/ใช้งานไม่ได้"<% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 829).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); } %>>ชำรุด/ใช้งานไม่ได้
                </label>
            </div>
        </div>


        <div class="form-row mt-3">
            <label class="control-label  col-sm-4" for="">สายไฟและปลั๊กไฟภายห้องปั๊มน้ำr</label>
            <div class="form-check-inline">
                <label class="form-check-label" for="">
                    <input type="radio" class="form-check-input"  name="cableandplugpumpwater" value="ปกติเรียบร้อย" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 830).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %>>ปกติเรียบร้อย       
                </label>
            </div>

            <div class="form-check-inline">
                <label class="form-check-label" for="">
                    <input type="radio" class="form-check-input"  name="cableandplugpumpwater" value="ชำรุด/ไม่มีกล่องปิด"<% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 830).FirstOrDefault().AnsDes == "ชำรุด/ไม่มีกล่องปิด") { Response.Write("checked"); } else { Response.Write(""); } %>>ชำรุด/ไม่มีกล่องปิด
                </label>
            </div>
        </div>

        <div class="form-row mt-3">
            <label class="control-label  col-sm-4" for="">สุขภัณฑ์ภายในห้องน้ำ </label>
            <div class="form-check-inline">
                <label class="form-check-label" for="">
                    <input type="radio" class="form-check-input"  name="toiletitem" value="ปกติ"<% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 831).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %>>ปกติ       
                </label>
            </div>

            <div class="form-check-inline">
                <label class="form-check-label" for="">
                    <input type="radio" class="form-check-input" name="toiletitem" value="ชำรุด/ใช้งานไม่ได้"<% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 831).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); } %>>ชำรุด/ใช้งานไม่ได้
                </label>
            </div>
        </div>


        <%--/////////////////////  SECTION 10  /////////////////////////////////////////--%>
        <div class="row mt-3">
            <div class="col-md-12 bg-success text-white text-center Myfont">
                <h5>10.อาคาร</h5>
            </div>
        </div>

        <div class="form-row mt-3">
            <label class="control-label  col-sm-4" for="">ความสะอาดภายในอาคาร </label>
            <div class="form-check-inline">
                <label class="form-check-label" for="">
                    <input type="radio" class="form-check-input"  name="cleaningin" value="สะอาด" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 832).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %>>สะอาด      
                </label>
            </div>
            <div class="form-check-inline">
                <label class="form-check-label" for="">
                    <input type="radio" class="form-check-input"  name="cleaningin" value="ไม่สะอาด/ไม่เรียบร้อย" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 832).FirstOrDefault().AnsDes == "ไม่สะอาด/ไม่เรียบร้อย") { Response.Write("checked"); } else { Response.Write(""); } %>>ไม่สะอาด/ไม่เรียบร้อย
                </label>
            </div>
        </div>

        <div class="form-row mt-3">
            <label class="control-label  col-sm-4" for="">ความสะอาดรอบอาคารภายนอก </label>
            <div class="form-check-inline">
                <label class="form-check-label" for="">
                    <input type="radio" class="form-check-input" name="cleaningout" value="สะอาด" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 833).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %>>สะอาด      
                </label>
            </div>
            <div class="form-check-inline">
                <label class="form-check-label" for="">
                    <input type="radio" class="form-check-input"  name="cleaningout" value="ไม่สะอาด/ไม่เรียบร้อย" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 833).FirstOrDefault().AnsDes == "ไม่สะอาด/ไม่เรียบร้อย") { Response.Write("checked"); } else { Response.Write(""); } %>>ไม่สะอาด/ไม่เรียบร้อย
                </label>
            </div>
        </div>

        <div class="form-row mt-3">
            <label class="control-label  col-sm-4" for="">ความสะอาดรางระบายน้ำ </label>
            <div class="form-check-inline">
                <label class="form-check-label" for="">
                    <input type="radio" class="form-check-input"  name="cleaningDrain" value="สะอาด" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 834).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %>>สะอาด      
                </label>
            </div>
            <div class="form-check-inline">
                <label class="form-check-label" for="">
                    <input type="radio" class="form-check-input"  name="cleaningDrain" value="ไม่สะอาด/ไม่เรียบร้อย" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 834).FirstOrDefault().AnsDes == "ไม่สะอาด/ไม่เรียบร้อย") { Response.Write("checked"); } else { Response.Write(""); } %>>ไม่สะอาด/ไม่เรียบร้อย
                </label>
            </div>
        </div>

        <div class="form-row mt-3">
            <label class="control-label  col-sm-4" for="">ราวจับด้านหน้าอาคาร </label>
            <div class="form-check-inline">
                <label class="form-check-label" for="">
                    <input type="radio" class="form-check-input"  name="Handrail" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 835).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %>>ปกติ      
                </label>
            </div>
            <div class="form-check-inline">
                <label class="form-check-label" for="">
                    <input type="radio" class="form-check-input" name="Handrail" value="ชำรุด" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 835).FirstOrDefault().AnsDes == "ชำรุด") { Response.Write("checked"); } else { Response.Write(""); } %>>ชำรุด
                </label>
            </div>
        </div>


        <div class="form-row mt-3">
            <label class="control-label  col-sm-4" for="">ประตูหน้าอาคาร</label>
            <div class="form-check-inline">
                <label class="form-check-label" for="">
                    <input type="radio" class="form-check-input"  name="doorfont" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 836).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %>>ปกติ      
                </label>
            </div>
            <div class="form-check-inline">
                <label class="form-check-label" for="">
                    <input type="radio" class="form-check-input"  name="doorfont" value="ชำรุด" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 836).FirstOrDefault().AnsDes == "ชำรุด") { Response.Write("checked"); } else { Response.Write(""); } %>>ชำรุด
                </label>
            </div>
        </div>

        <div class="form-row mt-3">
            <label class="control-label  col-sm-4" for="">ประตูหน้าห้องประชุม</label>
            <div class="form-check-inline">
                <label class="form-check-label" for="">
                    <input type="radio" class="form-check-input"  name="doorfontmeeting" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 837).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %>>ปกติ      
                </label>
            </div>
            <div class="form-check-inline">
                <label class="form-check-label" for="">
                    <input type="radio" class="form-check-input"  name="doorfontmeeting" value="ชำรุด"<% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 837).FirstOrDefault().AnsDes == "ชำรุด") { Response.Write("checked"); } else { Response.Write(""); } %>>ชำรุด
                </label>
            </div>
        </div>

        <div class="form-row mt-3">
            <label class="control-label  col-sm-4" for="">ประตูห้องปั๊มน้ำ</label>
            <div class="form-check-inline">
                <label class="form-check-label" for="">
                    <input type="radio" class="form-check-input"  name="doorpump" value="ปกติ"<% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 838).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %>>ปกติ      
                </label>
            </div>
            <div class="form-check-inline">
                <label class="form-check-label" for="">
                    <input type="radio" class="form-check-input"  name="doorpump" value="ชำรุด"<% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 838).FirstOrDefault().AnsDes == "ชำรุด") { Response.Write("checked"); } else { Response.Write(""); } %>>ชำรุด
                </label>
            </div>
        </div>



        <%--//////////////////////////  SECTION 11 /////////////////////////////////////////////--%>
        <div class="row mt-3">
            <div class="col-md-12 bg-warning text-white text-center Myfont">
                <h5>11.อุปกรณ์ระบบ VSAT (เฉพาะศูนย์ที่เป็น VSAT)</h5>
            </div>
        </div>
  <%---------------------- ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">อุปกรณ์ LNB/BUC</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="toolslnbRadio" value="ปกติ"<% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 839).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %> />ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="toolslnbRadio" value="ชำรุด/ใช้งานไม่ได้" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 839).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); } %>/>ชำรุด/ใช้งานไม่ได้
                        </label>
                    </div>
                </div>


                <%----------------------  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">การเก็บสาย RG และการพันหัว</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="wiringrgRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 840).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %>/>ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="wiringrgRadio" value="ไม่เรียบร้อย/ไม่แน่น"<% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 840).FirstOrDefault().AnsDes == "ไม่เรียบร้อย/ไม่แน่น") { Response.Write("checked"); } else { Response.Write(""); } %> />ไม่เรียบร้อย/ไม่แน่น
                        </label>
                    </div>
                </div>



                <%----------------------   ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">ฐานและระดับของเสาจาน</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="baseOnRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 841).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %>/>ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="baseOnRadio" value="ไม่ได้ระดับ/เอียง"<% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 841).FirstOrDefault().AnsDes == "ไม่ได้ระดับ/เอียง") { Response.Write("checked"); } else { Response.Write(""); } %> />ไม่ได้ระดับ/เอียง
                        </label>
                    </div>
                </div>



                <%----------------------  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">แนว Line Of Sight</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="lineOfsightRadio" value="ปกติ"<% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 842).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %> />ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="lineOfsightRadio" value="โดนบัง"<% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 842).FirstOrDefault().AnsDes == "โดนบัง") { Response.Write("checked"); } else { Response.Write(""); } %> />โดนบัง
                        </label>
                    </div>
                </div>




                <%----------------------  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">ความสะอาดของหน้าจาน</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="cleaningDishRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 843).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %>/>ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="cleaningDishRadio" value="สกปรก" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 843).FirstOrDefault().AnsDes == "สกปรก") { Response.Write("checked"); } else { Response.Write(""); } %>/>สกปรก
                        </label>
                    </div>
                </div>




                <%----------------------   ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">LNB Band Switch</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="lnbbandswitchRadio" value="HIGHBAND"<% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 844).FirstOrDefault().AnsDes == "HIGHBAND") { Response.Write("checked"); } else { Response.Write(""); } %> />HIGH BAND
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="lnbbandswitchRadio" value="LOWBAND" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 844).FirstOrDefault().AnsDes == "LOWBAND") { Response.Write("checked"); } else { Response.Write(""); } %>/>LOW BAND
                        </label>
                    </div>
                </div>
                <%--////////////// ------------------------------  //////////////////--%>





        <%--////////////////////////    /////////////////////////////////--%>
        <div class="row mt-3">
            <div class="col-md-12 bg-primary text-white text-center Myfont">
                <h5>12.อุปกรณ์ระบบ Solar Cell (เฉพาะศูนย์ที่ใช้ Solar Cell)</h5>
            </div>
        </div>

     
                <%----------------------  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">ระบบ Solar Cell</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="solarcellSystemRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 845).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %> />ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="solarcellSystemRadio" value="ชำรุด/ใช้งานไม่ได้"<% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 845).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); } %> />ชำรุด/ใช้งานไม่ได้
                        </label>
                    </div>
                </div>


                <%---------------------- ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">แผง PV Panel</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="pvPanelRadio" value="ปกติ"<% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 846).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %> />ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="pvPanelRadio" value="ชำรุด/ใช้งานไม่ได้" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 846).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); } %>/>ชำรุด/ใช้งานไม่ได้
                        </label>
                    </div>
                </div>


                <%----------------------  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">อุปกรณ์ Charger</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="toolsCharger" value="ปกติ"<% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 847).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %> />ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="toolsCharger" value="ชำรุด/ใช้งานไม่ได้" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 847).FirstOrDefault().AnsDes == "ชำรุด/ใช้งานไม่ได้") { Response.Write("checked"); } else { Response.Write(""); } %>/>ชำรุด/ใช้งานไม่ได้
                        </label>
                    </div>
                </div>



                <%----------------------  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">ความสะอาดแผง PV</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="cleanIngpvRadio" value="ปกติ" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 848).FirstOrDefault().AnsDes == "ปกติ") { Response.Write("checked"); } else { Response.Write(""); } %>/>ปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="cleanIngpvRadio" value="สกปรก" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 848).FirstOrDefault().AnsDes == "สกปรก") { Response.Write("checked"); } else { Response.Write(""); } %>/>สกปรก
                        </label>
                    </div>
                </div>



                <%----------------------   ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">การติดตั้งแผง PV</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="installPvRadio" value="ที่โล่งรับแดดปกติ"<% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 849).FirstOrDefault().AnsDes == "โล่งรับแดดปกติ") { Response.Write("checked"); } else { Response.Write(""); } %> />ที่โล่งรับแดดปกติ
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="installPvRadio" value="มีอาคาร/ต้นไม้บัง" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 849).FirstOrDefault().AnsDes == "มีอาคาร/ต้นไม้บัง") { Response.Write("checked"); } else { Response.Write(""); } %>/>มีอาคาร/ต้นไม้บัง
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
                <%--////////////// --------------------------- -----------------------------  //////////////////--%>




        <%--///////////////////////////////   //////////////////////////////////--%>

        <div class="row mt-3">
            <div class="col-md-12 bg-primary text-white text-center Myfont">
                <h4>13. คุณภาพของสัญญาณ</h4>
            </div>
        </div>


            <%----------------------   ---------------------------%>
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


                <%----------------------   ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-2">Download (for LAN)</label>
                    <div class="col-sm-8">
                        <input type="text" class="form-control" id="dowlaodForlanTextbox" runat="server" required="required" />
                    </div>
                    <label class="control-label col-sm-2">Mb/s</label>
                </div>



                <%----------------------  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-2">Upload (for LAN)</label>
                    <div class="col-sm-8">
                        <input type="text" class="form-control" id="uploadForlandTextbox" runat="server" required="required" />
                    </div>
                    <label class="control-label col-sm-2">Mb/s</label>
                </div>



                <%----------------------   ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-2">Ping Test  (for LAN)</label>
                    <div class="col-sm-8">
                        <input type="text" class="form-control" id="pingtestForlanTextbox" runat="server" required="required" />
                    </div>
                    <label class="control-label col-sm-2">ms</label>
                </div>
                <%--////////////// --------------------- ---------------------------  //////////////////--%>


        <%--///////////////////////////////  SECTION 14  //////////////////////////////////--%>

        <div class="row mt-3">
            <div class="col-md-12 bg-warning text-white text-center Myfont">
                <h4>14.ปัญหาที่พบและการแก้ไข</h4>
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




        <%--/////////////////////////////////////////////////     ///////////////////////////////////--%>
        <div class="row mt-3">
            <div class="col-md-12 bg-primary text-white text-center Myfont">
                <h4>15.ข้อมูลรายการทรัพย์สิน</h4>
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




        <%--/////////////////////////////////////////////////     ///////////////////////////////////--%>
        <div class="row mt-3">
            <div class="col-md-12 bg-primary text-white text-center Myfont">
                <h3>16. รายละเอียดผู้ทำ PM</h3>
            </div>
        </div>

         <%----------------------  ---------------------------%>
                <div class="row mt-3">
                    <div class="col-md-3 text-center">
                        <span>ชื่อทีม</span>
                    </div>
                    <div class="col-md-9">
                        <input type="text" class="form-control" id="nameTeampmTextbox" runat="server" />
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
                <%--////////////// --------------------- END   ---------------------------  //////////////////--%



        <%--/////////////////////////////////////////////////     ///////////////////////////////////--%>
        <div class="row mt-3">
            <div class="col-md-12 bg-success text-white text-center Myfont">
                <h4>17. รายละเอียด เจ้าหน้าที่ประจำศูนย์</h4>
            </div>
        </div>

        <%---------------------- Q ---------------------------%>
                <div class="row mt-3">
                    <div class="col-md-3 text-center">
                        <span>ชื่อเจ้าหน้าที่ประจำศูนย์</span>
                    </div>
                    <div class="col-md-9">
                        <input type="text" class="form-control" id="nameAgentareaTextbox" runat="server" />
                    </div>
                </div>

                <%---------------------- Q  ---------------------------%>
                <div class="row mt-3">
                    <div class="col-md-3 text-center">
                        <span>เบอร์โทรติดต่อ</span>
                    </div>
                    <div class="col-md-9">
                        <input type="text" class="form-control" id="telephoneAgentTextbox" runat="server" />
                    </div>
                </div>
                <%--////////////// ---------------------  ---------------------------  //////////////////--%>



        <%--////////////////////////////////// SECTION PICTURE CHECKLIST    ///////////////////////////////////--%>
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
                            <input type="radio" class="form-check-input" name="billBoardSchoolRadio" value="PASS"  <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 955).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %>/>PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="billBoardSchoolRadio" value="NOTPASS"  <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 955).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %>/>NOT PASS
                        </label>
                    </div>
                </div>

                <%---------------------- QuestionId = 206  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูปภาพด้านหน้าศูนย์ (ถ่ายคู่กับ จนท.ประจำศูนย์)</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="pictureWithagentRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 956).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %>>PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="pictureWithagentRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 956).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %>>NOT PASS
                        </label>
                    </div>
                </div>

                <%---------------------- QuestionId = 207  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูปภาพด้านหลังศูนย์</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="pictureBehindHallRadio" value="PASS"  <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 957).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %>/>PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="pictureBehindHallRadio" value="NOTPASS"  <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 957).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %>/>NOT PASS
                        </label>
                    </div>
                </div>


                <%---------------------- QuestionId = 208  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูปภาพบริเวณห้องโถง</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="picInlobbyRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 958).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %> />PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="picInlobbyRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 958).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %> />NOT PASS
                        </label>
                    </div>
                </div>


                <%---------------------- QuestionId = 209  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูปภาพบริเวณห้องประชุม</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="picinMeetingroomRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 959).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %> />PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="picinMeetingroomRadio" value="NOTPASS"  <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 959).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %>/>NOT PASS
                        </label>
                    </div>
                </div>

                <%---------------------- QuestionId = 210  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูปภาพบริเวณห้อง Server</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="picInserverRadio" value="PASS"  <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 960).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %>/>PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="picInserverRadio" value="NOTPASS"  <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 960).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %>/>NOT PASS
                        </label>
                    </div>
                </div>

                <%---------------------- QuestionId = 211  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูปภาพบริเวณห้องน้ำ</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="picIntoiletRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 961).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %> >PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="picIntoiletRadio" value="NOTPASS"  <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 961).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %>>NOT PASS
                        </label>
                    </div>
                </div>
                <%---------------------- QuestionId = 212  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูปภาพบริเวณห้องปั๊มน้ำ</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="pictureInwaterpumpRadio" value="PASS"  <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 962).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %>/>PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="pictureInwaterpumpRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 962).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %> />NOT PASS
                        </label>
                    </div>
                </div>


                <%---------------------- QuestionId = 213  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูป PEA Meter</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="picpeaMeterRadio" value="PASS"  <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 963).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %>/>PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="picpeaMeterRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 963).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %> />NOT PASS
                        </label>
                    </div>
                </div>

                <%---------------------- QuestionId = 214  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูปการวัดแรงดัน AC และกระแส AC </label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="acPicRadio" value="PASS"  <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 964).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %>/>PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="acPicRadio" value="NOTPASS"  <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 964).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %>/>NOT PASS
                        </label>
                    </div>
                </div>

                <%---------------------- QuestionId = 215  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูปการวัดค่า Ground และ Bar Ground  </label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="recGroundBargroundRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 965).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %> />PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="recGroundBargroundRadio" value="NOTPASS"  <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 965).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %>/>NOT PASS
                        </label>
                    </div>
                </div>


                <%---------------------- QuestionId = 216  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูปการตรวจสอบสถานะไฟฟ้ารั่วลง Ground (Lamp Test) </label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="lightleakRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 966).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %> />PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="lightleakRadio" value="NOTPASS"  <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 966).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %>/>NOT PASS
                        </label>
                    </div>
                </div>

                <%---------------------- QuestionId = 217  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูป MDB  </label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="mdbPicRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 967).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %> />PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="mdbPicRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 967).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %> />NOT PASS
                        </label>
                    </div>
                </div>

                <%---------------------- QuestionId = 218  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูป Fire Alarm Control </label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="picFilealarmRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 968).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %> />PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="picFilealarmRadio" value="NOTPASS"  <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 968).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %>/>NOT PASS
                        </label>
                    </div>
                </div>

                <%---------------------- QuestionId = 219  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูปภาพรวมอุปกรณ์ทั้งหมดภายในตู้ Rack</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="alltoolsInrackRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 969).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %> />PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="alltoolsInrackRadio" value="NOTPASS"  <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 969).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %>/>NOT PASS
                        </label>
                    </div>
                </div>

                <%---------------------- QuestionId = 220  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูปหน้าจอ UPS แสดงค่าต่างๆ และ Serial NO.</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="upsAndserialRadio" value="PASS"  <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 970).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %>>PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="upsAndserialRadio" value="NOTPASS"  <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 970).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %>>NOT PASS
                        </label>
                    </div>
                </div>


                <%---------------------- QuestionId = 221  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูป ONU/Modem พร้อม Serial NO. และ MAC</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="picOnuRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 971).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %> >PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="picOnuRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 971).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %> >NOT PASS
                        </label>
                    </div>
                </div>

                <%---------------------- QuestionId = 222  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูป Power Supply พร้อม Serial NO.</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="picPsuRadio" value="PASS"  <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 972).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %>>PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="picPsuRadio" value="NOTPASS"  <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 972).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %>>NOT PASS
                        </label>
                    </div>
                </div>

                <%---------------------- QuestionId = 223  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูป Switch 8 Port พร้อม Serial NO. และ MAC  </label>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" name="picSwitchRadio" value="PASS"  <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 973).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %>/>PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="picSwitchRadio" value="NOTPASS"  <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 973).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %>/>NOT PASS
                        </label>
                    </div>
                </div>

                <%---------------------- QuestionId = 224  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4" for="">รูป Switch 48 Port พร้อม Serial NO. และ MAC </label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="picSwitch48Radio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 974).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %> />PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label" for="">
                            <input type="radio" class="form-check-input" name="picSwitch48Radio" value="NOTPASS"  <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 974).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %>/>NOT PASS
                        </label>
                    </div>
                </div>

                <%---------------------- QuestionId = 225  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูป Outdoor AP ทั้ง 2 จุด พร้อม Serial NO. และ MAC </label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="picOutdoorRadio" value="PASS"  <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 975).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %>>PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="picOutdoorRadio" value="NOTPASS"  <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 975).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %>>NOT PASS
                        </label>
                    </div>
                </div>

                <%---------------------- QuestionId = 226  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูป Indoor AP ทั้ง 2 จุด พร้อม Serial NO. และ MAC </label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="picIndoortwowayRadio" value="PASS"  <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 976).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %>>PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="picIndoortwowayRadio" value="NOTPASS"  <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 976).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %>>NOT PASS
                        </label>
                    </div>
                </div>

                <%---------------------- QuestionId = 227  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูปการ Test Speed จาก App Nperf โดยใช้ WIFI </label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="picspeedTestRadio" value="PASS"  <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 977).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %>>PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="picspeedTestRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 977).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %>>NOT PASS
                        </label>
                    </div>
                </div>


                <%---------------------- QuestionId = 228  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูปการ Test Speed จาก App Nperf โดยใช้ LAN </label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="picspeedTestwithLanRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 978).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %>>PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="picspeedTestwithLanRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 978).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %>>NOT PASS
                        </label>
                    </div>
                </div>


                <%---------------------- QuestionId = 229  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูป ก่อน-หลัง การทำความสะอาดรางระบายน้ำ </label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="picbeforeAftercanelRadio" value="PASS"  <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 979).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %>/>PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="picbeforeAftercanelRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 979).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %> />NOT PASS
                        </label>
                    </div>
                </div>

                <%---------------------- QuestionId = 230  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูปหน้าจอ Monitor กล้องวงจรปิดผ่านจอทีวีในห้องประชุม </label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="picMonitorRadio" value="PASS"  <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 980).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %>/>PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="picMonitorRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 980).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %> />NOT PASS
                        </label>
                    </div>
                </div>



                <%---------------------- QuestionId = 231  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูปภาพก่อน-หลัง การทำความสะอาดแอร์ห้องโถง </label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="beforeArterairCleanRadio" value="PASS"  <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 981).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %>>PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="beforeArterairCleanRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 981).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %>>NOT PASS
                        </label>
                    </div>
                </div>

                <%---------------------- QuestionId = 232  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูปภาพก่อน-หลัง การทำความสะอาดแอร์ห้องประชุม </label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="picairInmeetingRadio" value="PASS"  <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 982).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %>/>PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="picairInmeetingRadio" value="NOTPASS"  <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 982).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %>/>NOT PASS
                        </label>
                    </div>
                </div>

                <%---------------------- QuestionId = 233  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูปภาพก่อน-หลัง การทำความสะอาดแอร์ห้อง Server </label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="picAirserverRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 983).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %> />PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="picAirserverRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 983).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %> />NOT PASS
                        </label>
                    </div>
                </div>
                <%--////////////// --------------------- END   ---------------------------  //////////////////--%>




        <%--/////////////////////////////////   SECTION V-SAT   //////////////////////////////--%>
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
                            <input type="radio" class="form-check-input" name="inStallBaseRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 984).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %> />PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="inStallBaseRadio" value="NOTPASS"  <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 984).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %>/>NOT PASS
                        </label>
                    </div>
                </div>

                <%---------------------- QuestionId = 235  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูปความสะอาดบริเวณจานดาวเทียม</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="picCleansatelliteRadio" value="PASS"  <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 985).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %>/>PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="picCleansatelliteRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 985).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %> />NOT PASS
                        </label>
                    </div>
                </div>



                <%---------------------- QuestionId = 236  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูป LNB พร้อม Part NO.</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="picLnbRadio" value="PASS"  <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 986).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %>>PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="picLnbRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 986).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %> >NOT PASS
                        </label>
                    </div>
                </div>

                <%---------------------- QuestionId = 237  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูป BUC พร้อม Part NO.</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="picBUCRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 987).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %> />PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="picBUCRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 987).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %> />NOT PASS
                        </label>
                    </div>
                </div>

                <%---------------------- QuestionId = 238  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูปการเก็บสายและพันหัวที่ LNB/BUC</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="picWiringLnbRadio" value="PASS"  <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 988).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %>>PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="picWiringLnbRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 988).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %> >NOT PASS
                        </label>
                    </div>
                </div>

                <%---------------------- QuestionId = 239  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูปแนว Line Of Sight (ดูการถูกบังของหน้าจานดาวเทียม)</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="picLineofSightRadio" value="PASS"  <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 989).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %>/>PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="picLineofSightRadio" value="NOTPASS"  <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 989).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %>/>NOT PASS
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
                            <input type="radio" class="form-check-input" name="picBaseSolarcellRadio" value="PASS"  <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 990).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %>>PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="picBaseSolarcellRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 990).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %>>NOT PASS
                        </label>
                    </div>
                </div>

                 <%---------------------- QuestionId = 241  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูปอุปกรณ์ Solar Cell ภายในห้อง</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="solarcellToolsinroomRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 991).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %>/>PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input"  name="solarcellToolsinroomRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 991).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %>/>NOT PASS
                        </label>
                    </div>
                </div>



                 <%---------------------- QuestionId = 242  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูปหน้าจอ Charger แสดงค่าต่างๆ</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input"  name="screenChargerRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 992).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %> />PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="screenChargerRadio" value="NOTPASS"  <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 992).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %>/>NOT PASS
                        </label>
                    </div>
                </div>


                 <%---------------------- QuestionId = 243  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูปหน้าจอ Inverter แสดงค่าต่างๆ</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="screenInverterRadio" value="PASS"  <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 993).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %>/>PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="screenInverterRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 993).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %>/>NOT PASS
                        </label>
                    </div>
                </div>


                 <%---------------------- QuestionId = 244  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูป Circuit Breaker ภายในตู้</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input"  name="piccircuitBreakerRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 994).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %>/>PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="piccircuitBreakerRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 994).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %>/>NOT PASS
                        </label>
                    </div>
                </div>

                 <%---------------------- QuestionId = 245  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูป Terminal ต่อสายภายในตู้</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input"  name="picTerminalRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 995).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %>/>PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input"  name="picTerminalRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 995).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %>/>NOT PASS
                        </label>
                    </div>
                </div>




                 <%---------------------- QuestionId = 246  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูปความสะอาดแผง PV</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input"  name="picCleaningPvRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 996).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %>>PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input"  name="picCleaningPvRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 996).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %>>NOT PASS
                        </label>
                    </div>
                </div>




                     <%---------------------- QuestionId = 247  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูปภาพรวมดูสิ่งบดบังแสงอาทิตย์</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input"  name="picSunriseRadio" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 997).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %>>PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input"  name="picSunriseRadio" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 997).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %>>NOT PASS
                        </label>
                    </div>
                </div>
                 <%--////////////// --------------------- ---------------------------  //////////////////--%>




        <%--//////////////////////////   SECTION COMPUTER  ////////////////////////////////--%>
        <div class="row mt-3">
            <div class="col-md-12 bg-warning text-white text-center Myfont">
                <h4>COMPUTER PICTURE CHECKLIST</h4>
            </div>
        </div>

                  <%---------------------- QuestionId = 248  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูปคอมพิวเตอร์ตัวที่ 1 พร้อม Serial NO.(เครื่องผู้ดูแล)</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="piccomAgentRadio1" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 998).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %>/>PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input"  name="piccomAgentRadio1" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 998).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %>/>NOT PASS
                        </label>
                    </div>
                </div>


                  <%---------------------- QuestionId = 249  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูปคอมพิวเตอร์ตัวที่ 2 พร้อม Serial NO.</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="piccomAgentRadio2" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 999).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %>>PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input"  name="piccomAgentRadio2" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 999).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %>>NOT PASS
                        </label>
                    </div>
                </div>



                  <%---------------------- QuestionId = 250  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูปคอมพิวเตอร์ตัวที่ 3 พร้อม Serial NO.</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input"  name="piccomAgentRadio3" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1000).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %>/>PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="piccomAgentRadio3" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1000).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %>/>NOT PASS
                        </label>
                    </div>
                </div>





                 <%---------------------- QuestionId = 251  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูปคอมพิวเตอร์ตัวที่ 4 พร้อม Serial NO.</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input"  name="piccomAgentRadio4" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1001).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %>/>PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input"  name="piccomAgentRadio4" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1001).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %>/>NOT PASS
                        </label>
                    </div>
                </div>




                 <%---------------------- QuestionId = 252  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูปคอมพิวเตอร์ตัวที่ 5 พร้อม Serial NO.</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input"  name="piccomAgentRadio5" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1002).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %>/>PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input"  name="piccomAgentRadio5" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1002).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %>/>NOT PASS
                        </label>
                    </div>
                </div>



                <%---------------------- QuestionId = 253  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูปคอมพิวเตอร์ตัวที่ 6 พร้อม Serial NO.</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="piccomAgentRadio6" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1003).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %>/>PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input"  name="piccomAgentRadio6" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1003).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %>/>NOT PASS
                        </label>
                    </div>
                </div>


                 <%---------------------- QuestionId = 254  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูปคอมพิวเตอร์ตัวที่ 7 พร้อม Serial NO.</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input"  name="piccomAgentRadio7" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1004).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %>/>PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input"  name="piccomAgentRadio7" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1004).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %>/>NOT PASS
                        </label>
                    </div>
                </div>

                 <%---------------------- QuestionId = 255  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูปคอมพิวเตอร์ตัวที่ 8 พร้อม Serial NO.</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="piccomAgentRadio8" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1005).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %>>PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input"  name="piccomAgentRadio8" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1005).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %>>NOT PASS
                        </label>
                    </div>
                </div>



                 <%---------------------- QuestionId = 256  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูปคอมพิวเตอร์ตัวที่ 9 พร้อม Serial NO.</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="piccomAgentRadio9" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1006).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %>>PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input"  name="piccomAgentRadio9" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1006).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %>>NOT PASS
                        </label>
                    </div>
                </div>

                 <%---------------------- QuestionId = 257  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูปคอมพิวเตอร์ตัวที่ 10 พร้อม Serial NO.</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="piccomAgentRadio10" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1007).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %>/>PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="piccomAgentRadio10" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1007).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %>/>NOT PASS
                        </label>
                    </div>
                </div>
                 <%---------------------- QuestionId = 258  ---------------------------%>
                <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูปคอมพิวเตอร์ตัวที่ 11 พร้อม Serial NO.</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input"  name="piccomAgentRadio11" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1008).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %>/>PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" " name="piccomAgentRadio11" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1008).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %>/>NOT PASS
                        </label>
                    </div>
                </div>

         <div class="form-row mt-3">
                    <label class="control-label col-sm-4">รูปคอมพิวเตอร์ตัวที่ 12 พร้อม Serial NO.</label>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input"  name="piccomAgentRadio12" value="PASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1009).FirstOrDefault().AnsDes == "PASS") { Response.Write("checked"); } else { Response.Write(""); } %>/>PASS
                        </label>
                    </div>
                    <div class="form-check-inline">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" " name="piccomAgentRadio12" value="NOTPASS" <% if (answers.Count() > 0 && answers.Where(x => x.QuestionId == 1009).FirstOrDefault().AnsDes == "NOTPASS") { Response.Write("checked"); } else { Response.Write(""); } %>/>NOT PASS
                        </label>
                    </div>
                </div>
                  

        
        <%--////////////// --------------------- END  SECTION ID 23 ---------------------------  //////////////////--%>
        <br />

 
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
                    <img id="user_img_2" src='<% if(answers.Count() > 0) Response.Write(answers.Where(x => x.QuestionId == 1010).FirstOrDefault().AnsDes); %>' class="placeholder2" />
                </div>



                 <%---------------------- QuestionId = 260  ---------------------------%>
                <div class="row mt-3">
                    <div class="col-sm-12">2.รูป VSAT PICTURE CHECKLIST</div>
                       <asp:FileUpload ID="vsatpictureChecklistImages" runat="server" data-thumbnail="user_img_3" accept="image/" onchange="previewImage(this)"  />
<%--                    <input type="file" name="image3" onchange="previewImage(this)" accept="image/*" data-thumbnail="user_img_3" />--%>
                </div>
                <div class="row ml-3 mt-3">
                    <img id="user_img_3" src='<% if(answers.Count() > 0) Response.Write(answers.Where(x => x.QuestionId == 1011).FirstOrDefault().AnsDes); %>'class="placeholder2" />
                </div>


                 <%---------------------- QuestionId = 261  ---------------------------%>
                <div class="row mt-3">
                    <div class="col-sm-12">3.รูป SOLAR CELL PICTURE CHECKLIST</div>
                       <asp:FileUpload ID="solarcellpictureChecklistImages" runat="server" data-thumbnail="user_img_4" accept="image/" onchange="previewImage(this)"  />
<%--                    <input type="file" name="image4" onchange="previewImage(this)" accept="image/*" data-thumbnail="user_img_4" />--%>
                </div>
                <div class="row ml-3 mt-3">
                    <img id="user_img_4" src='<% if(answers.Count() > 0) Response.Write(answers.Where(x => x.QuestionId == 1012).FirstOrDefault().AnsDes); %>' class="placeholder2" />
                </div>



                 <%---------------------- QuestionId = 262  ---------------------------%>
                <div class="row mt-3">
                    <div class="col-sm-12">4.COMPUTER PICTURE CHECKLIST</div>
                       <asp:FileUpload ID="compictureChecklistImages" runat="server" data-thumbnail="user_img_5" accept="image/" onchange="previewImage(this)"  />
<%--                    <input type="file" name="image5" onchange="previewImage(this)" accept="image/*" data-thumbnail="user_img_5" />--%>
                </div>
                <div class="row ml-3 mt-3">
                    <img id="user_img_5" src='<% if(answers.Count() > 0) Response.Write(answers.Where(x => x.QuestionId == 1013).FirstOrDefault().AnsDes); %>' class="placeholder2" />
                </div>
                 <%--////////////// --------------------- END  SECTION ID 24 ---------------------------  //////////////////--%>

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
        <br />
        <br />
        <br />
        <br />
    </div>

     <%--/////////////////    script START !!   /////////////////////////////--%>
</form>
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

</body>


</html>
