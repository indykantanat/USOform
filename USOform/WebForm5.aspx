<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm5.aspx.cs" Inherits="USOform.WebForm5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>รายงาน PM From BB Zone C+ บริการ USO Wrap</title>
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link href="~/style/Mystyle.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous" />
    <script src="previewImg.js"></script>
    <%--test brach preview UOSwrap --%>
    <script src="spinner.js"></script>
    <%--font style--%>
    <link rel="preconnect" href="https://fonts.gstatic.com" />
    <link href="https://fonts.googleapis.com/css2?family=Sarabun:wght@100;300;400;500;600;700&display=swap" rel="stylesheet" />
    <%--    date time picker JQURRY--%>
    <link rel="stylesheet" href="//code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css" />
    <link rel="stylesheet" href="/resources/demos/style.css">
    <script src="https://code.jquery.com/jquery-1.12.4.js"></script>
    <script src="https://code.jquery.com/ui/1.12.1/jquery-ui.js"></script>

    <%--sweert alert--%>
    <script src="https://cdn.jsdelivr.net/npm/sweetalert2@10"></script>
    <script src="sweetalert2.all.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/sweetalert2@10.13.1/dist/sweetalert2.all.min.js"></script>


     <script src="sweetalert2.min.js"></script>
    <link rel="stylesheet" href="sweetalert2.min.css">
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
             <div class="row">
                    <div class="col-md-12 justify-content-center ">                     
                       <asp:Button text="FUCKING TEST !! " class="btn btn-primary btn-block" ID="success" OnClick="Button1_Click" runat="server"/>
                    </div>
                   
                </div>
        </div>
        
    </form>


     <script type="text/javascript">
         function successalert1() {
             swal({
                 title: 'สำเร็จ',  //สิ่งที่เปลี่ยนได้ คือหัว
                 text: 'ได้ทำการดึงข้อมูลสำเร็จ',  // ข้อความที่แสดง
                 type: 'success', // อันนี้คือประเภทว่าจะให้เป็นแบบไหน
                 timer: 2000  // หน่วงเวลา 
             }).then(
                 function () { },
                 // handling the promise rejection
                 function (dismiss) {
                     if (dismiss === 'timer') {
                         console.log('I was closed by the timer')
                     }
                 }
             )
         }
     </script>

   

    <style type="text/css">
       
    </style>
</body>
</html>
