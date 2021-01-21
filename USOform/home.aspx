<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="USOform.WebForm4" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>mainmenu</title>
    <link href="~/style/Mystyle.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous" />
    <%--font style--%>
    <link rel="preconnect" href="https://fonts.gstatic.com" />
    <link href="https://fonts.googleapis.com/css2?family=Sarabun:wght@100;300;400;500;600;700&display=swap" rel="stylesheet" />
</head>
<body ">
    <form id="form1" runat="server">
       <div class="container" style="background-color:aquamarine">
           <div class="row pt-5">
                <div class="col-4">
                    <asp:FileUpload ID="logoPicture2" runat="server" data-thumbnail="user_img_2" accept="image/" onchange="previewImage(this)" required="required" />
                </div>
                <div class="col-4  d-flex justify-content-center ">
                    <h5 class="headerText">Preventive Maintenance Site Report USO (PHO’s WIFI)</h5>
                </div>
                <div class="col-4 ">
                    <img src="/assets/logo_uso.png" class="logoImg" />
                </div>
            </div>
       
       </div>
    </form>
</body>
</html>
