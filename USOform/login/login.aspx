<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="USOform.login.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>USO LOGIN</title>
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <%--    <link href="~/style/Mystyle.css" rel="stylesheet" />--%>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous" />
    <script src="previewImg.js"></script>
    <script src="spinner.js"></script>
    <%--font style--%>
    <link rel="preconnect" href="https://fonts.gstatic.com" />
    <link href="https://fonts.googleapis.com/css2?family=Sarabun:wght@100;300;400;500;600;700&display=swap" rel="stylesheet" />
    <%--    date time picker JQURRY--%>
    <link rel="stylesheet" href="//code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css" />
    <link rel="stylesheet" href="/resources/demos/style.css" />
    <script src="https://code.jquery.com/jquery-1.12.4.js"></script>
    <script src="https://code.jquery.com/ui/1.12.1/jquery-ui.js"></script>
</head>
<body>
    <form id="form1" runat="server">
          <a class="navbar-brand" href="#">
              <img src="../assets/logo_3-03.png" style="width:276px;height:48px;"/>
        </a>
        <div class="container login-container">

         


            <div class="row justify-content-center">
                <div class="col-md-6 login-form-2">
                    <span>USO LOGIN</span>
                    <div class="mt-3">
                        <div class="form-group">
                            <input type="text" class="form-control" placeholder="ชื่อผู้ใช้ *" id="txtUsername" required="required" runat="server" />
                        </div>
                        <div class="form-group">
                            <input type="password" class="form-control" placeholder="รหัสผ่าน *" id="txtPassword" required="required" runat="server" />
                        </div>
                        <div class="form-group justify-content-center text-center  pt-4">
                            <asp:Button Text="เข้าสู่ระบบ" runat="server" CssClass="btn btn-primary btn-block" OnClick="btnLogins_Click" ID="btnLogin1" />
                        </div>

                    </div>
                </div>
            </div>
        </div>
    </form>

    <style type="text/css">
        body {
            font-family: 'Sarabun', sans-serif;
            background: rgb(90,161,205);
            background: linear-gradient(90deg, rgba(90,161,205,1) 0%, rgba(112,78,196,1) 73%);
        }

        .login-container {
            margin-top: 13%;
            margin-bottom: 15%;
        }

       
        .login-form-2 {
            padding: 4%;
            background: white;
            box-shadow: 0 5px 8px 0 rgba(0, 0, 0, 0.2), 0 9px 26px 0 rgba(0, 0, 0, 0.19);
        }

        .login-form-2 {
            text-align: center;
            color: black;
            font-size:25px;
        }

        .login-container form {
            padding: 10%;
        }

        .btnSubmit {
            width: 50%;
            border-radius: 1rem;
            padding: 1.5%;
            border: none;
            cursor: pointer;
        }

        .login-form-1 .btnSubmit {
            font-weight: 600;
            color: #fff;
            background-color: #0062cc;
        }

        .login-form-2 .btnSubmit {
            font-weight: 600;
            color: black;
            background-color: #fff;
        }

        .login-form-2 .ForgetPwd {
            color: #fff;
            font-weight: 600;
            text-decoration: none;
        }

        .login-form-1 .ForgetPwd {
            color: #0062cc;
            font-weight: 600;
            text-decoration: none;
        }

        h3 {
            color: black;
        }
    </style>

</body>
</html>
