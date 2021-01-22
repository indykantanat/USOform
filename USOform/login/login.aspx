<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="USOform.login.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>USO'net LOGIN</title>
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

        <%--        <div class="container" style="background-color: #f1f1f1">
            <label><b>Username</b></label>
            <input type="text" placeholder="Enter Username" id="txtUsername" required="required" runat="server" />

            <label><b>Password</b></label>
            <input type="password" placeholder="Enter Password" id="txtPassword" required="required" runat="server" />

            <asp:Button Text="เข้า" runat="server" CssClass="btn btn-success" OnClick="btnLogins_Click" ID="btnLogin1" />
            <label>
            </label>



            <button type="button" class="cancelbtn">Cancel</button>
            <span class="psw">Forgot <a href="frmResetPassword.aspx">password?</a></span>
        </div>--%>


        <div class="container login-container">
            <div class="row justify-content-center">
                <div class="col-md-6 login-form-2">
                    <h3>เข้าสู่ระบบ</h3>
                    <div class="mt-4">
                        <div class="form-group">
                            <input type="text" class="form-control" placeholder="ชื่อผู้ใช้ *" id="txtUsername" required="required" runat="server" />
                        </div>
                        <div class="form-group">
                            <input type="password" class="form-control" placeholder="รหัสผ่าน" id="txtPassword" required="required" runat="server" />
                        </div>
                        <div class="form-group">
                            <asp:Button Text="เข้าสู่ระบบ" runat="server" CssClass="btn btn-light" OnClick="btnLogins_Click" ID="btnLogin1" />
                        </div>
                        <div class="form-group">
                            <a href="#" class="ForgetPwd">สมัคร ?</a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>

    <style type="text/css">
        body {
            font-family: 'Sarabun', sans-serif;
            background:#FBFBFB;
        }

        .login-container {
            margin-top: 13%;
            margin-bottom: 15%;
        }

        .login-form-1 {
            padding: 5%;
            box-shadow: 0 5px 8px 0 rgba(0, 0, 0, 0.2), 0 9px 26px 0 rgba(0, 0, 0, 0.19);
        }

            .login-form-1 h3 {
                text-align: center;
                color: #333;
            }

        .login-form-2 {
            padding: 5%;
            background: #0062cc;
            box-shadow: 0 5px 8px 0 rgba(0, 0, 0, 0.2), 0 9px 26px 0 rgba(0, 0, 0, 0.19);
        }

            .login-form-2 h3 {
                text-align: center;
                color: #fff;
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
            color: #0062cc;
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
    </style>

</body>
</html>
