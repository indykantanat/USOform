<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="testtable.aspx.cs" Inherits="USOform.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link href="~/style/Mystyle.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous" />
    <script src="previewImg.js"></script>
    <title>test table</title>
</head>
<body style="background-color: lightgrey">
    <div class="container bg-white">
        <div class="row mt-3">
            <div class="col-md-12 bg-primary text-white text-center Myfont">
                <h3>13.ปัญหาที่พบและการแก้ไข</h3>
            </div>
        </div>

        <%--        <div class="row mt-3">
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
        </div>--%>







<%--        <div class="divTable" style="width: 100%;">
            <div class="divTableBody">
                <div class="divTableRow">
                    <div class="divTableCell">ลำดับ</div>
                    <div class="divTableCell">ปัญหาที่พบ</div>
                    <div class="divTableCell">แนวทางการแก้ไข</div>
                </div>
                <div class="divTableRow">
                    <div class="divTableCell">&nbsp;1</div>
                    <div class="divTableCell">
                        <input type="text" class="form-control" id="" runat="server" />
                    </div>
                    <div class="divTableCell">
                        <input type="text" class="form-control" id="" runat="server" />
                    </div>
                </div>
                <div class="divTableRow">
                    <div class="divTableCell">&nbsp;2</div>
                    <div class="divTableCell">
                        <input type="text" class="form-control" id="" />
                    </div>
                    <div class="divTableCell">
                        <input type="text" class="form-control" id="" />
                    </div>
                </div>
                <div class="divTableRow">
                    <div class="divTableCell">&nbsp;3</div>
                    <div class="divTableCell">
                        <input type="text" class="form-control " id="" />
                    </div>
                    <div class="divTableCell">
                        <input type="text" class="form-control " id="" />
                    </div>
                </div>
                <div class="divTableRow">
                    <div class="divTableCell">&nbsp;4</div>
                    <div class="divTableCell">
                        <input type="text" class="form-control " id="" />
                    </div>
                    <div class="divTableCell">
                        <input type="text" class="form-control " id="" />
                    </div>
                </div>
                <div class="divTableRow">
                    <div class="divTableCell">&nbsp;5</div>
                    <div class="divTableCell">
                        <input type="text" class="form-control" id="" />
                    </div>
                    <div class="divTableCell">
                        <input type="text" class="form-control " id="" />
                    </div>
                </div>
                <div class="divTableRow">
                    <div class="divTableCell">&nbsp;6</div>
                    <div class="divTableCell">
                        <input type="text" class="form-control" id="" />
                    </div>
                    <div class="divTableCell">
                        <input type="text" class="form-control " id="" />
                    </div>
                </div>
                <div class="divTableRow">
                    <div class="divTableCell">&nbsp;7</div>
                    <div class="divTableCell">
                        <input type="text" class="form-control " id="" />
                    </div>
                    <div class="divTableCell">
                        <input type="text" class="form-control" id="" />
                    </div>
                </div>
                <div class="divTableRow">
                    <div class="divTableCell">&nbsp;8</div>
                    <div class="divTableCell">
                        <input type="text" class="form-control" id="" />
                    </div>
                    <div class="divTableCell">
                        <input type="text" class="form-control" id="" />
                    </div>
                </div>
                <div class="divTableRow">
                    <div class="divTableCell">&nbsp;9</div>
                    <div class="divTableCell">
                        <input type="text" class="form-control" id="" />
                    </div>
                    <div class="divTableCell">
                        <input type="text" class="form-control" id="" />
                    </div>
                </div>
                <div class="divTableRow">
                    <div class="divTableCell">&nbsp;10</div>
                    <div class="divTableCell">
                        <input type="text" class="form-control" id="" />
                    </div>
                    <div class="divTableCell">
                        <input type="text" class="form-control" id="" />
                    </div>
                </div>
                <div class="divTableRow">
                    <div class="divTableCell">&nbsp;11</div>
                    <div class="divTableCell">
                        <input type="text" class="form-control" id="" />
                    </div>
                    <div class="divTableCell">
                        <input type="text" class="form-control" id="" />
                    </div>
                </div>
                <div class="divTableRow">
                    <div class="divTableCell">&nbsp;12</div>
                    <div class="divTableCell">
                        <input type="text" class="form-control" id="" />
                    </div>
                    <div class="divTableCell">
                        <input type="text" class="form-control" id="" />
                    </div>
                </div>
                <div class="divTableRow">
                    <div class="divTableCell">&nbsp;13</div>
                    <div class="divTableCell">
                        <input type="text" class="form-control" id="" />
                    </div>
                    <div class="divTableCell">
                        <input type="text" class="form-control" id="" />
                    </div>
                </div>
                <div class="divTableRow">
                    <div class="divTableCell">&nbsp;14</div>
                    <div class="divTableCell">
                        <input type="text" class="form-control" id="" />
                    </div>
                    <div class="divTableCell">
                        <input type="text" class="form-control" id="" />
                    </div>
                </div>
                <div class="divTableRow">
                    <div class="divTableCell">&nbsp;15</div>
                    <div class="divTableCell">
                        <input type="text" class="form-control" id="" />
                    </div>
                    <div class="divTableCell">
                        <input type="text" class="form-control" id="" />
                    </div>
                </div>
            </div>
        </div>--%>
     
<%--        <table  class="table table-responsive table-striped text-center" style="width: 100%;" border="0">
<tbody>
<tr>
<td style="width: auto;">&nbsp;ลำดับ</td>
<td style="width: auto;">&nbsp;รายการอุปกรณ์</td>
<td style="width: auto;">&nbsp;Serial Number</td>
<td style="width: auto;">&nbsp;Serial Number ใหม่</td>
<td style="width: auto;">&nbsp;หมายเหตุ</td>
</tr>
<tr>
<td style="width: 10%;">1</td>
<td style="width: 19%;"> <input type="text" class="form-control" /></td>
<td style="width: 19%;"><input type="text" class="form-control" /></td>
<td style="width: 18%;"><input type="text" class="form-control" /></td>
<td style="width: 27%;"><input type="text" class="form-control" /></td>
</tr>
<tr>
<td style="width: 10%;">2</td>
<td style="width: 19%;"> <input type="text" class="form-control" /></td>
<td style="width: 19%;"> <input type="text" class="form-control" /></td>
<td style="width: 18%;"> <input type="text" class="form-control" /></td>
<td style="width: 27%;"> <input type="text" class="form-control" /></td>
</tr>
<tr>
<td style="width: 10%;">3</td>
<td style="width: 19%;"><input type="text" class="form-control" /></td>
<td style="width: 19%;"><input type="text" class="form-control" /></td>
<td style="width: 18%;"><input type="text" class="form-control" /></td>
<td style="width: 27%;"><input type="text" class="form-control" /></td>
</tr>
<tr>
<td style="width: 10%;">4</td>
<td style="width: 19%;"><input type="text" class="form-control" /></td>
<td style="width: 19%;"><input type="text" class="form-control" /></td>
<td style="width: 18%;"><input type="text" class="form-control" /></td>
<td style="width: 27%;"><input type="text" class="form-control" /></td>
</tr>
<tr>
<td style="width: 10%;">&nbsp;</td>
<td style="width: 19%;">&nbsp;</td>
<td style="width: 19%;">&nbsp;</td>
<td style="width: 18%;">&nbsp;</td>
<td style="width: 27%;">&nbsp;</td>
</tr>
<tr>
<td style="width: 10%;">&nbsp;</td>
<td style="width: 19%;">&nbsp;</td>
<td style="width: 19%;">&nbsp;</td>
<td style="width: 18%;">&nbsp;</td>
<td style="width: 27%;">&nbsp;</td>
</tr>
<tr>
<td style="width: 10%;">&nbsp;</td>
<td style="width: 19%;">&nbsp;</td>
<td style="width: 19%;">&nbsp;</td>
<td style="width: 18%;">&nbsp;</td>
<td style="width: 27%;">&nbsp;</td>
</tr>
<tr>
<td style="width: 10%;">&nbsp;</td>
<td style="width: 19%;">&nbsp;</td>
<td style="width: 19%;">&nbsp;</td>
<td style="width: 18%;">&nbsp;</td>
<td style="width: 27%;">&nbsp;</td>
</tr>
<tr>
<td style="width: 10%;">&nbsp;</td>
<td style="width: 19%;">&nbsp;</td>
<td style="width: 19%;">&nbsp;</td>
<td style="width: 18%;">&nbsp;</td>
<td style="width: 27%;">&nbsp;</td>
</tr>
<tr>
<td style="width: 10%;">&nbsp;</td>
<td style="width: 19%;">&nbsp;</td>
<td style="width: 19%;">&nbsp;</td>
<td style="width: 18%;">&nbsp;</td>
<td style="width: 27%;">&nbsp;</td>
</tr>
<tr>
<td style="width: 10%;">&nbsp;</td>
<td style="width: 19%;">&nbsp;</td>
<td style="width: 19%;">&nbsp;</td>
<td style="width: 18%;">&nbsp;</td>
<td style="width: 27%;">&nbsp;</td>
</tr>
</tbody>
</table>--%>





<%--        <div class="divTable" style="width: 100%; border: 0px solid #000;">
<div class="divTableBody">
<div class="divTableRow">
<div class="divTableCell">&nbsp;ลำดับ</div>
<div class="divTableCell">&nbsp;รายการอุปกรณ์</div>
<div class="divTableCell">&nbsp;Serial Number</div>
<div class="divTableCell">&nbsp;Serial Number</div>
<div class="divTableCell">หมายเหกตุ&nbsp;</div>
</div>
<div class="divTableRow">
<div class="divTableCell">1</div>
<div class="divTableCell"><input type="text" class="form-control" /></div>
<div class="divTableCell"><input type="text" class="form-control" /></div>
<div class="divTableCell"><input type="text" class="form-control" /></div>
<div class="divTableCell"><input type="text" class="form-control" /></div>
</div>
<div class="divTableRow">
<div class="divTableCell">2</div>
<div class="divTableCell"><input type="text" class="form-control" /></div>
<div class="divTableCell"><input type="text" class="form-control" /></div>
<div class="divTableCell"><input type="text" class="form-control" /></div>
<div class="divTableCell"><input type="text" class="form-control" /></div>
</div>
<div class="divTableRow">
<div class="divTableCell">&nbsp;</div>
<div class="divTableCell">&nbsp;</div>
<div class="divTableCell">&nbsp;</div>
<div class="divTableCell">&nbsp;</div>
<div class="divTableCell">&nbsp;</div>
</div>
<div class="divTableRow">
<div class="divTableCell">&nbsp;</div>
<div class="divTableCell">&nbsp;</div>
<div class="divTableCell">&nbsp;</div>
<div class="divTableCell">&nbsp;</div>
<div class="divTableCell">&nbsp;</div>
</div>
<div class="divTableRow">
<div class="divTableCell">&nbsp;</div>
<div class="divTableCell">&nbsp;</div>
<div class="divTableCell">&nbsp;</div>
<div class="divTableCell">&nbsp;</div>
<div class="divTableCell">&nbsp;</div>
</div>
<div class="divTableRow">
<div class="divTableCell">&nbsp;</div>
<div class="divTableCell">&nbsp;</div>
<div class="divTableCell">&nbsp;</div>
<div class="divTableCell">&nbsp;</div>
<div class="divTableCell">&nbsp;</div>
</div>
<div class="divTableRow">
<div class="divTableCell">&nbsp;</div>
<div class="divTableCell">&nbsp;</div>
<div class="divTableCell">&nbsp;</div>
<div class="divTableCell">&nbsp;</div>
<div class="divTableCell">&nbsp;</div>
</div>
<div class="divTableRow">
<div class="divTableCell">&nbsp;</div>
<div class="divTableCell">&nbsp;</div>
<div class="divTableCell">&nbsp;</div>
<div class="divTableCell">&nbsp;</div>
<div class="divTableCell">&nbsp;</div>
</div>
<div class="divTableRow">
<div class="divTableCell">&nbsp;</div>
<div class="divTableCell">&nbsp;</div>
<div class="divTableCell">&nbsp;</div>
<div class="divTableCell">&nbsp;</div>
<div class="divTableCell">&nbsp;</div>
</div>
<div class="divTableRow">
<div class="divTableCell">&nbsp;</div>
<div class="divTableCell">&nbsp;</div>
<div class="divTableCell">&nbsp;</div>
<div class="divTableCell">&nbsp;</div>
<div class="divTableCell">&nbsp;</div>
</div>
<div class="divTableRow">
<div class="divTableCell">&nbsp;</div>
<div class="divTableCell">&nbsp;</div>
<div class="divTableCell">&nbsp;</div>
<div class="divTableCell">&nbsp;</div>
<div class="divTableCell">&nbsp;</div>
</div>
</div>
</div>--%>
<!-- DivTable.com -->
<!-- DivTable.com -->




        <div class="table-responsive-sm text-center">
              <table  class="table table-sm table-hover" style="width: 100%;" border="0">
<tbody>
<tr>
<td>ลำดับ</td>
<td>รายการอุปกรณ์</td>
<td>Serial Number</td>
<td>Serial Number (ใหม่)</td>
<td>หมายเหตุ</td>
</tr>
<tr>
<td>1</td>
<td><input type="text" class="form-control form-control-sm" /></td>
<td><input type="text" class="form-control form-control-sm" /></td>
<td><input type="text" class="form-control form-control-sm" /></td>
<td><input type="text" class="form-control form-control-sm" /></td>
</tr>
<tr>
<td>2</td>
<td><input type="text" class="form-control form-control-sm" /></td>
<td><input type="text" class="form-control form-control-sm" /></td>
<td><input type="text" class="form-control form-control-sm" /></td>
<td><input type="text" class="form-control form-control-sm" /></td>
</tr>
<tr>
<td>3</td>
<td><input type="text" class="form-control form-control-sm" /></td>
<td><input type="text" class="form-control form-control-sm" /></td>
<td><input type="text" class="form-control form-control-sm" /></td>
<td><input type="text" class="form-control form-control-sm" /></td>
</tr>
<tr>
<td>4</td>
<td><input type="text" class="form-control form-control-sm" /></td>
<td><input type="text" class="form-control form-control-sm" /></td>
<td><input type="text" class="form-control form-control-sm" /></td>
<td><input type="text" class="form-control form-control-sm" /></td>
</tr>
<tr>
<td>5</td>
<td><input type="text" class="form-control form-control-sm" /></td>
<td><input type="text" class="form-control form-control-sm" /></td>
<td><input type="text" class="form-control form-control-sm" /></td>
<td><input type="text" class="form-control form-control-sm" /></td>
</tr>
<tr>
<td>6</td>
<td><input type="text" class="form-control form-control-sm" /></td>
<td><input type="text" class="form-control form-control-sm" /></td>
<td><input type="text" class="form-control form-control-sm" /></td>
<td><input type="text" class="form-control form-control-sm" /></td>
</tr>
<tr>
<td>7</td>
<td><input type="text" class="form-control form-control-sm" /></td>
<td><input type="text" class="form-control form-control-sm" /></td>
<td><input type="text" class="form-control form-control-sm" /></td>
<td><input type="text" class="form-control form-control-sm" /></td>
</tr>
<tr>
<td>8</td>
<td><input type="text" class="form-control form-control-sm" /></td>
<td><input type="text" class="form-control form-control-sm" /></td>
<td><input type="text" class="form-control form-control-sm" /></td>
<td><input type="text" class="form-control form-control-sm" /></td>
</tr>
<tr>
<td>9</td>
<td><input type="text" class="form-control form-control-sm" /></td>
<td><input type="text" class="form-control form-control-sm" /></td>
<td><input type="text" class="form-control form-control-sm" /></td>
<td><input type="text" class="form-control form-control-sm" /></td>
</tr>
<tr>
<td>10</td>
<td><input type="text" class="form-control form-control-sm" /></td>
<td><input type="text" class="form-control form-control-sm" /></td>
<td><input type="text" class="form-control form-control-sm" /></td>
<td><input type="text" class="form-control form-control-sm" /></td>
</tr>
<tr>
<td>11</td>
<td><input type="text" class="form-control form-control-sm" /></td>
<td><input type="text" class="form-control form-control-sm" /></td>
<td><input type="text" class="form-control form-control-sm" /></td>
<td><input type="text" class="form-control form-control-sm" /></td>
</tr>
    <tr>
<td>12</td>
<td><input type="text" class="form-control form-control-sm" /></td>
<td><input type="text" class="form-control form-control-sm" /></td>
<td><input type="text" class="form-control form-control-sm" /></td>
<td><input type="text" class="form-control form-control-sm" /></td>
</tr>
    <tr>
<td>13</td>
<td><input type="text" class="form-control form-control-sm" /></td>
<td><input type="text" class="form-control form-control-sm" /></td>
<td><input type="text" class="form-control form-control-sm" /></td>
<td><input type="text" class="form-control form-control-sm" /></td>
</tr>
    <tr>
<td>14</td>
<td><input type="text" class="form-control form-control-sm" /></td>
<td><input type="text" class="form-control form-control-sm" /></td>
<td><input type="text" class="form-control form-control-sm" /></td>
<td><input type="text" class="form-control form-control-sm" /></td>
</tr>
    <tr>
<td>15</td>
<td><input type="text" class="form-control form-control-sm" /></td>
<td><input type="text" class="form-control form-control-sm" /></td>
<td><input type="text" class="form-control form-control-sm" /></td>
<td><input type="text" class="form-control form-control-sm" /></td>
</tr>
</tbody>
</table>
           
        </div>
       <br />
<!-- DivTable.com -->
    </div>







    <style type="text/css">
        /* DivTable.com */
        .divTable {
            display: table;
            width: 100%;
        }

        .divTableRow {
            display: table-row;
        }

        .divTableHeading {
            background-color: #EEE;
            display: table-header-group;
        }

        .divTableCell, .divTableHead {
            border: 0px solid #999999;
            display: table-cell;
            padding: 3px 10px;
            text-align: center;
        }

        .divTableHeading {
            background-color: #EEE;
            display: table-header-group;
            font-weight: bold;
        }

        .divTableFoot {
            background-color: #EEE;
            display: table-footer-group;
            font-weight: bold;
        }

        .divTableBody {
            display: table-row-group;
        }
    </style>



</body>


</html>
