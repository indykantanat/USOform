<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="USOform.PreventiveMaintenanceReportBB1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>รายงาน PM From BB Zone C+ บริการที่ 1</title>
    <link href="~/style/Mystyle.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous">

    <%--font style--%>
    <link rel="preconnect" href="https://fonts.gstatic.com" />
    <link href="https://fonts.googleapis.com/css2?family=Sarabun:wght@100;300;400;500;600;700&display=swap" rel="stylesheet" />
</head>
<body style="background-color: lightgray">
    <div class="container bg-white Myfont mt-3">
        <div class="row">
            <div class="col-md-12 text-center">
                <div>
                    <h1>รายงานผลการตรวจสอบ และบำรุงรักษา
                        <br>
                        ชุดอุปกรณ์ Broadband Internet Service
                        <br>
                        (Preventive Maintenance (PM) Report)    </h1>
                </div>
            </div>
        </div>
        <div class="row mt-5">
            <div class="col-md-12 text-center">
                <div>
                    <h4>โครงการจัดให้มีสัญญาณโทรศัพท์เคลื่อนที่และบริการอินเทอร์เน็ต
                        <br>
                        ความเร็วสูงในพื้นที่ชายขอบ (Zone C+)  </h4>
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
                <h4>(Broadband Internet Service) บริการประเภทที่ 1
                
              

                </h4>
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


        <div class="row ">
            <div class="col-md-12 bg-primary text-white text-center Myfont">
                <h4>PREVENTIVE MAINTENANCE SITE REPORT (PM)</h4>
            </div>
        </div>

        <div class="form-row mt-3">
            <label class="control-label col-sm-1" for="">Cabinet ID :</label>
            <div class="col-sm-11">
                <input type="email" class="form-control" id="" name="">
            </div>
        </div>

        <div class="form-row mt-3">
            <label class="control-label col-sm-1" for="">Site Code :</label>
            <div class="col-sm-11">
                <input type="email" class="form-control" id="" name="">
            </div>
        </div>

        <div class="form-row mt-3">
            <label class="control-label col-sm-1" for="">Village ID :</label>
            <div class="col-sm-11">
                <input type="email" class="form-control" id="" name="">
            </div>
        </div>

        <div class="form-row mt-3">
            <label class="control-label col-sm-1" for="">Village :</label>
            <div class="col-sm-11">
                <input type="email" class="form-control" id="" name="">
            </div>
        </div>

        <div class="form-row mt-3">
            <label class="control-label col-sm-1" for="">Sub-District :</label>
            <div class="col-sm-11">
                <input type="email" class="form-control" id="" name="">
            </div>
        </div>

        <div class="form-row mt-3">
            <label class="control-label col-sm-1" for="">District :</label>
            <div class="col-sm-11">
                <input type="email" class="form-control" id="" name="">
            </div>
        </div>

        <div class="form-row mt-3">
            <label class="control-label col-sm-1" for="">Province :</label>
            <div class="col-sm-11">
                <input type="email" class="form-control" id="" name="">
            </div>
        </div>

        <div class="form-row mt-3">
            <label class="control-label col-sm-1" for="">Type :</label>
            <div class="col-sm-11">
                <input type="email" class="form-control" id="" name="">
            </div>
        </div>

        <div class="form-row mt-3">
            <label class="control-label col-sm-1" for="">PM Date :</label>
            <div class="col-sm-11">
                <input type="email" class="form-control" id="" name="">
            </div>
        </div>




        <div class="form-row mt-3">
            <div class="form-group">
                <label for="">ใส่รูปหน้าตู้</label>
                <input type="file" class="form-control-file" id="">
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


        <div class="row mt-3">
            <div class="col-md-12 bg-primary text-white text-center Myfont">
                <h4>1. รายละเอียดสถานี</h4>
            </div>
        </div>


        <div class="form-row mt-3">
            <label class="control-label col-sm-1" for="">Cabinet ID :</label>
            <div class="col-sm-11">
                <input type="email" class="form-control" id="" name="">
            </div>
        </div>


        <div class="form-row mt-3">
            <label class="control-label col-sm-1" for="">Site code :</label>
            <div class="col-sm-11">
                <input type="email" class="form-control" id="" name="">
            </div>
        </div>

        <div class="form-row mt-3">
            <label class="control-label col-sm-1" for="">Village ID :</label>
            <div class="col-sm-11">
                <input type="email" class="form-control" id="" name="">
            </div>
        </div>

        <div class="form-row mt-3">
            <label class="control-label col-sm-2" for="">LAT & LONG :</label>
            <div class="col-sm-10">
                <input type="email" class="form-control" id="" name="">
            </div>
        </div>



        <div class="row mt-3">
            <div class="col-md-12 bg-primary text-white text-center Myfont">
                <h4>2. ระบบไฟฟ้า (หลัก)</h4>
            </div>
        </div>

        <div class="form-row mt-3">
            <label class="control-label col-sm-2" for="">หมายเลขผู้ใช้ไฟ</label>
            <div class="col-sm-8">
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
                    <input type="radio" class="form-check-input" id="" name="" value="" />ปกติ
                </label>
            </div>
            <div class="form-check-inline">
                <label class="form-check-label" for="">
                    <input type="radio" class="form-check-input" id="" name="" value="">ชำรุด/ใช้งานไม่ได้
                </label>
            </div>
        </div>

        <div class="form-row mt-3">
            <label class="control-label col-sm-2" for="">สภาพ Circuit Breaker</label>
            <div class="form-check-inline">
                <label class="form-check-label" for="">
                    <input type="radio" class="form-check-input" id="" name="" value="" />ปกติ
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
                <h4>3. ระบบ Rectifier</h4>
            </div>
        </div>

        <div class="form-row mt-3">
            <label class="control-label col-sm-2" for="">แรงดัน DC</label>
            <div class="col-sm-8">
                <input type="email" class="form-control" id="" name="">
            </div>
            <label class="control-label col-sm-2" for="">V.</label>
        </div>

        <div class="form-row mt-3">
            <label class="control-label col-sm-2" for="">กระแส Load DC</label>
            <div class="col-sm-8">
                <input type="email" class="form-control" id="" name="">
            </div>
            <label class="control-label col-sm-2" for="">A.</label>
        </div>

        <div class="form-row mt-3">
            <label class="control-label col-sm-2" for="">จำนวน Rectifier Module</label>
            <div class="col-sm-8">
                <input type="email" class="form-control" id="" name="">
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
                <input type="email" class="form-control" id="" name="">
            </div>
            <label class="control-label col-sm-2" for="">V.</label>
        </div>

        <div class="form-row mt-3">
            <label class="control-label col-sm-2" for="">Battery Temperature</label>
            <div class="col-sm-8">
                <input type="email" class="form-control" id="" name="">
            </div>
            <label class="control-label col-sm-2" for="">°C</label>
        </div>

        <div class="form-row mt-3">
            <label class="control-label col-sm-2" for="">Battery Voltage ก้อนที่ 1</label>
            <div class="col-sm-8">
                <input type="email" class="form-control" id="" name="">
            </div>
            <label class="control-label col-sm-2" for="">V.</label>
        </div>

        <div class="form-row mt-3">
            <label class="control-label col-sm-2" for="">Battery Voltage ก้อนที่ 2</label>
            <div class="col-sm-8">
                <input type="email" class="form-control" id="" name="">
            </div>
            <label class="control-label col-sm-2" for="">V.</label>
        </div>

        <div class="form-row mt-3">
            <label class="control-label col-sm-2" for="">Battery Voltage ก้อนที่ 3</label>
            <div class="col-sm-8">
                <input type="email" class="form-control" id="" name="">
            </div>
            <label class="control-label col-sm-2" for="">V.</label>
        </div>

        <div class="form-row mt-3">
            <label class="control-label col-sm-2" for="">Battery Voltage ก้อนที่ 4</label>
            <div class="col-sm-8">
                <input type="email" class="form-control" id="" name="">
            </div>
            <label class="control-label col-sm-2" for="">V.</label>
        </div>

        <div class="form-row mt-3">
            <label class="control-label col-sm-2" for="">Battery Capacity </label>
            <div class="col-sm-8">
                <input type="email" class="form-control" id="" name="">
            </div>
            <label class="control-label col-sm-2" for="">Ah.</label>
        </div>




        <div class="row mt-3">
            <div class="col-md-12 bg-primary text-white text-center Myfont">
                <h4>5.ระบบ Alarm</h4>
            </div>
        </div>

        <div class="form-row mt-3">
            <label class="control-label col-sm-2" for="">Door Alarm</label>
            <div class="form-check-inline">
                <label class="form-check-label" for="">
                    <input type="radio" class="form-check-input" id="" name="" value="">ปกติ 
                </label>
            </div>

            <div class="form-check-inline">
                <label class="form-check-label" for="">
                    <input type="radio" class="form-check-input" id="" name="" value="">ไม่ส่ง Alarm
                </label>
            </div>
        </div>

        <div class="form-row mt-3">
            <label class="control-label col-sm-2" for="">Main Power Failure Alarm</label>
            <div class="form-check-inline">
                <label class="form-check-label" for="">
                    <input type="radio" class="form-check-input" id="" name="" value="">ปกติ 
                </label>
            </div>
            <div class="form-check-inline">
                <label class="form-check-label" for="">
                    <input type="radio" class="form-check-input" id="" name="" value="" />ไม่ส่ง Alarm
                </label>
            </div>
        </div>


        <div class="form-row mt-3">
            <label class="control-label col-sm-2" for="">Rectifier 1 Comm. Fail Alarm</label>
            <div class="form-check-inline">
                <label class="form-check-label" for="">
                    <input type="radio" class="form-check-input" id="" name="" value="" />ปกติ 
                </label>
            </div>

            <div class="form-check-inline">
                <label class="form-check-label" for="">
                    <input type="radio" class="form-check-input" id="" name="" value="" />ไม่ส่ง Alarm
                </label>
            </div>
        </div>

        <div class="form-row mt-3">
            <label class="control-label col-sm-2" for="">Rectifier 2 Comm. Fail Alarm</label>
            <div class="form-check-inline">
                <label class="form-check-label" for="">
                    <input type="radio" class="form-check-input" id="" name="" value="" />ปกติ 
                </label>
            </div>

            <div class="form-check-inline">
                <label class="form-check-label" for="">
                    <input type="radio" class="form-check-input" id="" name="" value="">ไม่ส่ง Alarm
                </label>
            </div>
        </div>





        <div class="row mt-3">
            <div class="col-md-12 bg-primary text-white text-center Myfont">
                <h4>6.ระบบ Ground</h4>
            </div>
        </div>

        <div class="form-row mt-3">
            <label class="control-label col-sm-3" for="">ความแข็งแรงจุดต่อ Ground Bar</label>
            <div class="form-check-inline">
                <label class="form-check-label" for="">
                    <input type="radio" class="form-check-input" id="" name="" value="" />ปกติ
                </label>
            </div>
            <div class="form-check-inline">
                <label class="form-check-label" for="">
                    <input type="radio" class="form-check-input" id="" name="" value="" />ชำรุด
                </label>
            </div>
        </div>

        <div class="form-row mt-3">
            <label class="control-label col-sm-3" for="">ความแข็งแรงของน็อตขันหางปลาอุปกรณ์</label>
            <div class="form-check-inline">
                <label class="form-check-label" for="">
                    <input type="radio" class="form-check-input" id="" name="" value="" />ปกติ
                </label>
            </div>
            <div class="form-check-inline">
                <label class="form-check-label" for="">
                    <input type="radio" class="form-check-input" id="" name="" value="" />ชำรุด
                </label>
            </div>
        </div>

        <div class="form-row mt-3">
            <label class="control-label col-sm-3" for="">สายกราวด์เรียบร้อย ปลอดภัย สมบูรณ์</label>
            <div class="form-check-inline">
                <label class="form-check-label" for="">
                    <input type="radio" class="form-check-input" id="" name="" value="" />ปกติ
                </label>
            </div>
            <div class="form-check-inline">
                <label class="form-check-label" for="">
                    <input type="radio" class="form-check-input" id="" name="" value="" />ชำรุด
                </label>
            </div>
        </div>

        <div class="form-row mt-3">
            <label class="control-label col-sm-3" for="">สถานะไฟฟ้ารั่วลง Ground</label>
            <div class="form-check-inline">
                <label class="form-check-label" for="">
                    <input type="radio" class="form-check-input" id="" name="" value="" />ไม่พบไฟฟ้ารั่ว     
                </label>
            </div>
            <div class="form-check-inline">
                <label class="form-check-label" for="">
                    <input type="radio" class="form-check-input" id="" name="" value="" />พบไฟฟ้ารั่ว        
                </label>
            </div>
        </div>

        <div class="row mt-3">
            <div class="col-md-12 bg-success text-white text-center Myfont">
                <h4>7.สภาพแวดล้อมและความสะอาดโดยรอบ</h4>
            </div>
        </div>


        <div class="form-row mt-3">
            <label class="control-label col-sm-3" for="">ป้ายและตัวเลขแสดงชื่อสถานี</label>
            <div class="form-check-inline">
                <label class="form-check-label" for="">
                    <input type="radio" class="form-check-input" id="" name="" value="" />ปกติ     
                </label>
            </div>
            <div class="form-check-inline">
                <label class="form-check-label" for="">
                    <input type="radio" class="form-check-input" id="" name="" value="" />ไม่ชัดเจน        
                </label>
            </div>
        </div>

        <div class="form-row mt-3">
            <label class="control-label col-sm-3" for="">การติดตั้งและการยึดตู้อุปกรณ์</label>
            <div class="form-check-inline">
                <label class="form-check-label" for="">
                    <input type="radio" class="form-check-input" id="" name="" value="" />ปกติ     
                </label>
            </div>
            <div class="form-check-inline">
                <label class="form-check-label" for="">
                    <input type="radio" class="form-check-input" id="" name="" value="" />ชำรุด        
                </label>
            </div>
        </div>

        <div class="form-row mt-3">
            <label class="control-label col-sm-3" for="">เสาไฟฟ้าที่ตั้งตั้งอุปกรณ์</label>
            <div class="form-check-inline">
                <label class="form-check-label" for="">
                    <input type="radio" class="form-check-input" id="" name="" value="" />ปกติ     
                </label>
            </div>
            <div class="form-check-inline">
                <label class="form-check-label" for="">
                    <input type="radio" class="form-check-input" id="" name="" value="" />ชำรุด/เอียง        
                </label>
            </div>
        </div>

        <div class="form-row mt-3">
            <label class="control-label col-sm-3" for="">แนวสายไฟฟ้าและสายเคเบิ้ลเข้าสถานี</label>
            <div class="form-check-inline">
                <label class="form-check-label" for="">
                    <input type="radio" class="form-check-input" id="" name="" value="" />ปกติ     
                </label>
            </div>
            <div class="form-check-inline">
                <label class="form-check-label" for="">
                    <input type="radio" class="form-check-input" id="" name="" value="" />ตกหย่อน/ไม่ได้ยึดโยง       
                </label>
            </div>
        </div>

        <div class="form-row mt-3">
            <label class="control-label col-sm-3" for="">ช่อง Cable Inlet  และความสะอาด</label>
            <div class="form-check-inline">
                <label class="form-check-label" for="">
                    <input type="radio" class="form-check-input" id="" name="" value="" />ปกติ     
                </label>
            </div>
            <div class="form-check-inline">
                <label class="form-check-label" for="">
                    <input type="radio" class="form-check-input" id="" name="" value="" />ไม่ได้อุดซิลีโคน       
                </label>
            </div>
        </div>

        <div class="form-row mt-3">
            <label class="control-label col-sm-3" for="">ความสะอาดภายในตู้</label>
            <div class="form-check-inline">
                <label class="form-check-label" for="">
                    <input type="radio" class="form-check-input" id="" name="" value="" />ปกติ     
                </label>
            </div>
            <div class="form-check-inline">
                <label class="form-check-label" for="">
                    <input type="radio" class="form-check-input" id="" name="" value="" />มีฝุ่น/สิ่งสกปรก      
                </label>
            </div>
        </div>

        <div class="form-row mt-3">
            <label class="control-label col-sm-3" for="">ประตูและยางขอบประตูของตู้อุปกรณ์</label>
            <div class="form-check-inline">
                <label class="form-check-label" for="">
                    <input type="radio" class="form-check-input" id="" name="" value="" />ปกติ     
                </label>
            </div>
            <div class="form-check-inline">
                <label class="form-check-label" for="">
                    <input type="radio" class="form-check-input" id="" name="" value="" />ชำรุด      
                </label>
            </div>
        </div>




        <div class="row mt-3">
            <div class="col-md-12 bg-warning text-white text-center Myfont">
                <h3>8. ปัญหาที่พบและการแก้ไข</h3>
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
                <h3>9.ข้อมูลรายการทรัพย์สิน</h3>
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
                <h3>10. รายละเอียดผู้ทำ PM</h3>
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
            <div class="col-md-12 bg-success text-white text-center Myfont">
                <h3>PICTURE CHECKLIST</h3>
            </div>
        </div>




        <div class="form-row mt-3">
            <label class="control-label col-sm-4" for="">รูปหน้าตู้ ก่อน-หลัง</label>
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
            <label class="control-label col-sm-4" for="">รูปภายในตู้ ก่อน-หลัง</label>
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
            <label class="control-label col-sm-4" for="">รูปขณะทำความสะอาดตู้ ก่อน-หลัง</label>
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
            <label class="control-label col-sm-4" for="">รูปสถานะ Circuit Breaker (ON)</label>
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
            <label class="control-label col-sm-4" for="">รูปการจับยึด Bar Ground และการต่อ Ground</label>
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
            <label class="control-label col-sm-4" for="">รูปการตรวจสอบสถานะไฟฟ้ารั่วลง Ground (Lamp Test)</label>
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
            <label class="control-label col-sm-4" for="">รูปแรงดัน DC และกระแส DC </label>
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
            <label class="control-label col-sm-4" for="">รูปการวัดแรงดัน Battery รวม </label>
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
            <label class="control-label col-sm-4" for="">รูปการวัดแรงดัน Battery ก้อนที่ 1 และ Serial NO.  </label>
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
            <label class="control-label col-sm-4" for="">รูปการวัดแรงดัน Battery ก้อนที่ 2 และ Serial NO. </label>
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
            <label class="control-label col-sm-4" for="">รูปการวัดแรงดัน Battery ก้อนที่ 3 และ Serial NO.</label>
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
            <label class="control-label col-sm-4" for="">รูปการวัดแรงดัน Battery ก้อนที่ 4 และ Serial NO. </label>
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
            <label class="control-label col-sm-4" for="">รูปการ Test Door Alarm </label>
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
            <label class="control-label col-sm-4" for="">รูปการ Test Rectifier 1 Comm. Fail  Alarm </label>
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
        2.2
        <div class="form-row mt-3">
            <label class="control-label col-sm-4" for="">รูปการ Test Rectifier 2 Comm. Fail  Alarm </label>
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
            <label class="control-label col-sm-4" for="">รูป Rectifier Module และ Serial NO.</label>
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
            <label class="control-label col-sm-4" for="">รูป Cable Inlet ด้านในและด้านนอก </label>
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
            <label class="control-label col-sm-4" for="">รูป ODF โดยรวม </label>
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
            <label class="control-label col-sm-4" for="">รูปอุปกรณ์ OLT โดยรวม</label>
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
            <label class="control-label col-sm-4" for="">รูป Control Rectifier แสดงแรงดันและกระแส Load </label>
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
            <br />
            <br />
            <br />
        </div>









    </div>
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
