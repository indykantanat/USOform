﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="USOform.PreventiveMaintenanceReportBBUSOWrap.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>รายงาน PM From BB Zone C+ บริการ USO Wrap</title>

    <link href="~/style/Mystyle.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous" />

    <%--font style--%>
    <link rel="preconnect" href="https://fonts.gstatic.com" />
    <link href="https://fonts.googleapis.com/css2?family=Sarabun:wght@100;300;400;500;600;700&display=swap" rel="stylesheet" />
</head>
<body style="background-color:lightgrey;">

    <form id="form1" runat="server">
        <div class="container bg-white">

            <div class="row">
                <div class="col-md-12 text-center">
                    <div>
                        <h3>รายงานผลการตรวจสอบ และบำรุงรักษา
                        <br />
                            ชุดอุปกรณ์ Broadband Internet Service
                        <br />
                            (Preventive Maintenance (PM) Report)     </h3>
                    </div>
                </div>
            </div>
            <div class="row mt-5">
                <div class="col-md-12 text-center">
                    <div>
                        <h3>โครงการจัดให้มีสัญญาณโทรศัพท์เคลื่อนที่และบริการอินเทอร์เน็ต
                        <br />
                            ความเร็วสูงในพื้นที่ชายขอบ (Zone C+)  </h3>
                    </div>
                </div>
            </div>

            <%--input group--%>
            <div class="row pt-5">
                <div class="col-md-3">
                    <div class="block  float-right">
                        <label>กลุ่ม</label>
                        <input type="text" class="form-control-sm" />
                    </div>
                </div>
                <div class="col-md-3">
                    <div class="block">
                        <label>ภาค</label>
                        <input type="text" />
                    </div>
                </div>
                <div class="col-md-6">
                    <div class="block">
                        <label>บริษัท</label>
                        <input type="text" class="form-control-sm" size="50" />
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-md-12 text-center pt-lg-5">
                    <h4>ส่วนที่ 1 การจัดให้มีบริการอินเทอร์เน็ตความเร็วสูง 
                    </h4>
                </div>
                <div class="col-md-12 text-center">
                    <h5>(Broadband Internet Service) บริการ USO Wrap
                <div class="form-check-inline">
                    <label class="form-check-label" for="radio1">
                        <input type="radio" class="form-check-input" id="radio1" name="optradio" value="option1" checked>2.1
                    </label>
                </div>
                        <div class="form-check-inline">
                            <label class="form-check-label" for="radio2">
                                <input type="radio" class="form-check-input" id="radio2" name="optradio" value="option2">2.2
                            </label>
                        </div>
                        <div class="form-check-inline">
                            <label class="form-check-label" for="radio3">
                                <input type="radio" class="form-check-input" id="radio3" name="optradio" value="option3">3
                            </label>
                        </div>
                    </h5>
                </div>
            </div>
            <div class="row">
                <div class="col-md-12 text-center pt-lg-3">
                    <label>
                        <h4>รอบการบำรุงรักษา ครั้งที่</h4>
                    </label>
                    <input type="text" class="" size="2" />
                    <label>/</label>
                    <input type="text" class="" size="2" />
                </div>
            </div>

            <div class="row  text-center">
                <div class="col-md-12">
                    <div>
                        <label>
                            <h4>วัน เดือน ปี</h4>
                        </label>
                        <input data-date-format="dd/mm/yyyy" id="startDate">

                        <label>
                            <h4>ถึง</h4>
                        </label>
                        <input data-date-format="dd/mm/yyyy" id="startDate2">
                    </div>
                </div>
            </div>
            <div class="row text-center">
                <div class="col-md-12">
                    <label>
                        <h4>สถานที่ (Site code)</h4>
                    </label>
                    <input type="text" class="" size="10" />
                </div>
            </div>

            <div class="container">
                <div class="row ">
                    <div class="col-md-12 bg-primary text-white text-center">
                        <h3>PREVENTIVE MAINTENANCE SITE REPORT (PM)</h3>
                    </div>
                </div>

                <form class="mt-5">
                    <div class="form-row">
                        <label class="control-label col-sm-1" for="">Cabinet ID :</label>
                        <div class="col-sm-11">
                            <input type="email" class="form-control" id="" name="">
                        </div>
                    </div>

                    <div class="form-row mt-3">
                        <label class="control-label col-sm-1" for="">Site Code :</label>
                        <div class="col-sm-11">
                            <input class="form-control" id="" name="">
                        </div>
                    </div>

                    <div class="form-row mt-3">
                        <label class="control-label col-sm-1" for="">Village ID :</label>
                        <div class="col-sm-11">
                            <input class="form-control" id="" name="">
                        </div>
                    </div>

                    <div class="form-row mt-3">
                        <label class="control-label col-sm-1" for="">Village :</label>
                        <div class="col-sm-11">
                            <input class="form-control" id="" name="">
                        </div>
                    </div>

                    <div class="form-row mt-3">
                        <label class="control-label col-sm-1" for="">School’s name :</label>
                        <div class="col-sm-11">
                            <input class="form-control" id="" name="">
                        </div>
                    </div>


                    <div class="form-row mt-3">
                        <label class="control-label col-sm-1" for="">Sub-District:</label>
                        <div class="col-sm-11">
                            <input class="form-control" id="" name="">
                        </div>
                    </div>

                    <div class="form-row mt-3">
                        <label class="control-label col-sm-1" for="">Province :</label>
                        <div class="col-sm-11">
                            <input class="form-control" id="" name="">
                        </div>
                    </div>


                    <div class="form-row mt-3">
                        <label class="control-label col-sm-1" for="">Type :</label>
                        <div class="col-sm-11">
                            <input class="form-control" id="" name="">
                        </div>
                    </div>


                    <div class="form-row mt-3">
                        <label class="control-label col-sm-1" for="">PM Date : </label>
                        <div class="col-sm-11">
                            <input class="form-control" id="" name="">
                        </div>
                    </div>

                    <div class="row mt-md-3">
                        <div class="form-group">
                            <label for="exampleFormControlFile1">ใส่ป้ายหน้าโรงเรียน</label>
                            <input type="file" class="form-control-file" id="exampleFormControlFile1">
                        </div>
                    </div>

                    <div class="row mt-md-3">
                        <div class="form-group">
                            <label for="exampleFormControlFile1">ใส่รูปหน้าอาคารศูนย์ USO Net</label>
                            <input type="file" class="form-control-file" id="exampleFormControlFile1">
                        </div>
                    </div>

                    <div class="row ">
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
                            <input type="text" class="form-control" id="" name="">
                        </div>
                        <div class="col-md-6 text-center">
                            <input type="text" class="form-control" id="" name="">
                        </div>
                    </div>

                    <div class="row mt-3">
                        <div class="col-md-1 text-center">
                            <span>Name</span>
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
                            <span>Date</span>
                        </div>
                        <div class="col-md-5 text-center">
                            <input type="text" class="form-control" id="" name="">
                        </div>
                        <div class="col-md-6 text-center">
                            <input type="text" class="form-control" id="" name="">
                        </div>
                    </div>

                </form>
            </div>
            <br />

            <%--is here--%>

            <%-- ข้อ1--%>
            <div class="container Myfont">
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

                    <%-- ข้อ2--%>
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

                    <div class="form-row mt-3">
                        <label class="control-label col-sm-2" for="">UPS MODE</label>
                        <div class="form-check-inline">
                            <label class="form-check-label" for="">
                                <input type="radio" class="form-check-input" id="" name="" value="">LINE
                            </label>
                        </div>
                        <div class="form-check-inline">
                            <label class="form-check-label" for="">
                                <input type="radio" class="form-check-input" id="" name="" value="">BATT.
                            </label>
                        </div>
                        <div class="form-check-inline">
                            <label class="form-check-label" for="">
                                <input type="radio" class="form-check-input" id="" name="" value="">BYPASS
                            </label>
                        </div>
                    </div>

                    <%--                            <div class="form-row mt-3">
                                <label class="control-label col-sm-2" for="">UPS ภายในตู้</label>
                                <div class="form-check-inline">
                                    <label class="form-check-label" for="">
                                        <input type="radio" class="form-check-input" id="" name="" value="">1
                                    </label>
                                </div>

                                <div class="form-check-inline">
                                    <label class="form-check-label" for="">
                                        <input type="radio" class="form-check-input" id="" name="" value="">2
                                    </label>
                                </div>

                                <div class="form-check-inline">
                                    <label class="form-check-label" for="">
                                        <input type="radio" class="form-check-input" id="" name="" value="">3
                                    </label>
                                </div>

                                <div class="form-check-inline">
                                    <label class="form-check-label" for="">
                                        <input type="radio" class="form-check-input" id="" name="" value="">4
                                    </label>

                                    <div class="form-check-inline">
                                        <label class="form-check-label" for="">
                                            <input type="radio" class="form-check-input" id="" name="" value="">5
                                        </label>
                                    </div>
                                </div>
                                <label class="control-label col-sm-2" for="">(ขีดล่าง =1 , ขีดบน = 5)</label>

                            </div>



                            <div class="form-row mt-3">
                                <label class="control-label col-sm-2" for="">ระดับความจุ Battery</label>
                                <div class="form-check-inline">
                                    <label class="form-check-label" for="">
                                        <input type="radio" class="form-check-input" id="" name="" value="">1
                                    </label>
                                </div>

                                <div class="form-check-inline">
                                    <label class="form-check-label" for="">
                                        <input type="radio" class="form-check-input" id="" name="" value="">2
                                    </label>
                                </div>

                                <div class="form-check-inline">
                                    <label class="form-check-label" for="">
                                        <input type="radio" class="form-check-input" id="" name="" value="">3
                                    </label>
                                </div>

                                <div class="form-check-inline">
                                    <label class="form-check-label" for="">
                                        <input type="radio" class="form-check-input" id="" name="" value="">4
                                    </label>

                                    <div class="form-check-inline">
                                        <label class="form-check-label" for="">
                                            <input type="radio" class="form-check-input" id="" name="" value="">5
                                        </label>
                                    </div>
                                </div>
                                <label class="control-label col-sm-2" for="">(ขีดล่าง =1 , ขีดบน = 5)</label>
                            </div>--%>



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


                    <%-- <div class="form-row mt-3 ">
                                <label class="control-label col-sm-2" for="">FEMTO</label>
                                <div class="form-check-inline col-4 ">
                                    <label class="form-check-label" for="">
                                        <input type="radio" class="form-check-input" id="" name="" value="">3G
                                    </label>
                                    <label class="form-check-label" for="">
                                        <input type="radio" class="form-check-input" id="" name="" value="">4G
                                    </label>
                                </div>
                                <div class="form-check-inline">
                                    <label class="form-check-label" for="">
                                        <input type="radio" class="form-check-input" id="" name="" value="">ปกติ
                                    </label>
                                    <label class="form-check-label" for="">
                                        <input type="radio" class="form-check-input" id="" name="" value="">ชำรุด/ใช้งานไม่ได้
                                    </label>
                                </div>
                            </div>

                            <div class="form-row mt-3 ">
                                <label class="control-label " for="">การระบายอากาศ (T-Power)</label>
                                <div class="form-check-inline">
                                    <label class="form-check-label" for="">
                                        <input type="radio" class="form-check-input" id="" name="" value="">ปกติ                
                                    </label>
                                    <label class="form-check-label" for="">
                                        <input type="radio" class="form-check-input" id="" name="" value="">ชำรุด/ใช้งานไม่ได้
                                    </label>
                                </div>

                            </div>

                            <div class="form-row mt-3 ">
                                <label class="control-label " for="">การ Wiring สายไฟและสาย Ground</label>
                                <div class="form-check-inline">
                                    <label class="form-check-label" for="">
                                        <input type="radio" class="form-check-input" id="" name="" value="">เรียบร้อย                          
                                    </label>
                                    <label class="form-check-label" for="">
                                        <input type="radio" class="form-check-input" id="" name="" value="">ไม่เรียบร้อย
                                    </label>
                                </div>
                            </div>
                            <div class="form-row mt-3 ">
                                <label class="control-label " for="">การ Wiring Patch cord และ สาย LAN</label>
                                <div class="form-check-inline">
                                    <label class="form-check-label" for="">
                                        <input type="radio" class="form-check-input" id="" name="" value="">เรียบร้อย                          
                                    </label>
                                    <label class="form-check-label" for="">
                                        <input type="radio" class="form-check-input" id="" name="" value="">ไม่เรียบร้อย
                                    </label>
                                </div>--%>
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


            <%-- <div class="form-row mt-3">
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
                            </div>--%>

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

            <%--  <div class="form-row mt-3">
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
                                <label class="control-label col-sm-4" for="">ความสะอาดแผง PV </label>
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
                                <label class="control-label col-sm-4" for="">การติดตั้งแผง PV </label>
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

                            <div class="form-row mt-3">
                                <label class="control-label col-sm-2" for="">แรงดัน Battery ก้อนที่ 1</label>
                                <div class="col-sm-8">
                                    <input type="email" class="form-control" id="" name="">
                                </div>
                                <label class="control-label col-sm-2" for="">V.</label>
                            </div>
                            <div class="form-row mt-3">
                                <label class="control-label col-sm-2" for="">แรงดัน Battery ก้อนที่ 2</label>
                                <div class="col-sm-8">
                                    <input type="email" class="form-control" id="" name="">
                                </div>
                                <label class="control-label col-sm-2" for="">V.</label>
                            </div>
                            <div class="form-row mt-3">
                                <label class="control-label col-sm-2" for="">แรงดัน Battery ก้อนที่ 3</label>
                                <div class="col-sm-8">
                                    <input type="email" class="form-control" id="" name="">
                                </div>
                                <label class="control-label col-sm-2" for="">V.</label>
                            </div>

                            <div class="form-row mt-3">
                                <label class="control-label col-sm-2" for="">แรงดัน Battery ก้อนที่ 4</label>
                                <div class="col-sm-8">
                                    <input type="email" class="form-control" id="" name="">
                                </div>
                                <label class="control-label col-sm-2" for="">V.</label>
                            </div>--%>

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


            <%--                            <div class="form-row mt-3">
                                <label class="control-label col-sm-2" for="">Cell ID/Bsrid (for Femto)</label>
                                <div class="col-sm-8">
                                    <input type="email" class="form-control" id="" name="">
                                </div>
                            </div>


                            <div class="form-row mt-3">
                                <label class="control-label col-sm-2" for="">Network strength (>= -77.5 dBm) Section 1</label>
                                <div class="col-sm-8">
                                    <input type="email" class="form-control" id="" name="">
                                </div>
                                <label class="control-label col-sm-2" for="">dBm</label>
                            </div>

                            <div class="form-row mt-3">
                                <label class="control-label col-sm-2" for="">Network strength (>= -77.5 dBm) Section 2</label>
                                <div class="col-sm-8">
                                    <input type="email" class="form-control" id="" name="">
                                </div>
                                <label class="control-label col-sm-2" for="">dBm</label>
                            </div>--%>


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


            <%--  <div class="form-row mt-3">
                                <label class="control-label col-sm-2" for="">Network strength (>= -77.5 dBm) Section 3</label>
                                <div class="col-sm-8">
                                    <input type="email" class="form-control" id="" name="">
                                </div>
                                <label class="control-label col-sm-2" for="">dBm</label>
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
                                <label class="control-label col-sm-2" for="">Download (for Mobile)</label>
                                <div class="col-sm-8">
                                    <input type="email" class="form-control" id="" name="">
                                </div>
                                <label class="control-label col-sm-2" for="">Mb/s</label>
                            </div>


                            <div class="form-row mt-3">
                                <label class="control-label col-sm-2" for="">Upload (for Mobile)</label>
                                <div class="col-sm-8">
                                    <input type="email" class="form-control" id="" name="">
                                </div>
                                <label class="control-label col-sm-2" for="">Mb/s</label>
                            </div>

                            <div class="form-row mt-3">
                                <label class="control-label col-sm-2" for="">Ping Test (for Mobile)</label>
                                <div class="col-sm-8">
                                    <input type="email" class="form-control" id="" name="">
                                </div>
                                <label class="control-label col-sm-2" for="">Ms</label>
                            </div>--%>


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
            </div>
    </form>
    </div>
                    <br>
    <br>
    <br>
    <br>
    <br>
    <br>
    <br>
    <br>
    <br>
    <br>
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
