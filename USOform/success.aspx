<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="success.aspx.cs" Inherits="USOform.success" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ทำรายการสำเร็จ</title>
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link href="../style/Mystyle.css" rel="stylesheet" />
     <%----------------//     BOOTSTRAP 4   //---------------------%> 
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
     <%----------------//     JQURRY 3  //---------------------%> 
    <script src="https://code.jquery.com/jquery-3.4.1.min.js" integrity="sha256-CSXorXvZcTkaix6Yvo6HppcZGetbYMGWSFlBw8HfCJo=" crossorigin="anonymous"></script>   
    <%----------------//     font style    //---------------------%>
    <link rel="preconnect" href="https://fonts.gstatic.com" />
    <link href="https://fonts.googleapis.com/css2?family=Sarabun:wght@100;300;400;500;600;700&display=swap" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <asp:Panel ID="pnFail" Visible="false" runat="server">
           <div class="container justify-content-center text-center">
                <div class="row justify-content-center text-center">
                    <div class="col-md-12 justify-content-center text-center">
                        <img src="../assets/errorImg.png" class="responsive"/>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-12 col-sm-12 justify-content-center text-center">
                        <button class="btn btn-lg  btn-danger fontBtn">กลับสู่หน้าหลัก</button>
                    </div>
                </div>
            </div>
        </asp:Panel>
        <asp:Panel ID="pnSuccess" Visible="false" runat="server">
            <div class="container justify-content-center text-center">
                <div class="row justify-content-center text-center">
                    <div class="col-md-12 justify-content-center text-center">
                        <img src="../assets/successImages.png" class="responsive"/>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-12 col-sm-12 justify-content-center text-center">                    
                        <asp:Button ID="goBacktoMain" runat="server" Text="กลับสู่หน้าหลัก" Cssclass="btn btn-lg  btn-success fontBtn" OnClick="btnGoMain_Click"/>
                    </div>
                </div>
            </div>
        </asp:Panel>
    </form> 

    <style type="text/css">
        .responsive {
            width: 467px;
            height: auto;
        }
        .fontBtn {
       font-family: 'Sarabun', sans-serif;
        }
    </style>
     <script src="../Scripts/bootstrap.min.js"></script>
    <script src="../Scripts/jquery-3.0.0.min.js"></script>
</body>
</html>
