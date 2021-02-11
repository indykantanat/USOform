<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="dashboard.aspx.cs" Inherits="USOform.WebForm2" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link href="~/style/Mystyle.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous" /> 
    <%---------------------------------//  font style  //------------------------------------%>
    <link rel="preconnect" href="https://fonts.gstatic.com" />
    <link href="https://fonts.googleapis.com/css2?family=Prompt:wght@200;300;400;500&display=swap" rel="stylesheet" />
    <%---------------------------------// bootstrap 4  //------------------------------------%>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/jquery-3.0.0.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
  

    <title>USO FORM DASHBOARD </title>
</head>

<body>
    <form id="form1" runat="server">
        <div class="container-fluid bg-white     p-5">
            <div class="loading" align="center">
                Loading. Please wait.<br />
                <br />
                <img src="../assets/loader2.gif" alt="loading..." />
            </div>
            <table id="example" class="table table-striped table-responsive" style="width: 100%">
                <thead>                 
                    <tr>
                        <td>จุดที่</td>
                        <td>SR
                        </td>
                        <td>Name                                               
                        </td>
                        <td>CabinetId                                                
                        </td>
                        <td>SiteCode                                              
                        </td>
                        <td>VillageId                                               
                        </td>
                        <td>Village
                        </td>
                        <td>SubDistrict
                        </td>
                        <td>District
                        </td>
                        <td>Province
                        </td>
                        <td>Contract
                        </td>
                        <td>Type
                        </td>
                        <td>TypeofSignal
                        </td>
                        <td>Create/Edit
                                    
                        </td>
                    </tr>
                </thead>
                <tbody>
                    <asp:Repeater runat="server" ID="SiteRepeater" OnItemDataBound="SiteRepeater_ItemDataBound">
                        <ItemTemplate>
                            <tr>
                                <td style="text-align: center;"><%# Eval("id") %></td>
                                <td><%# Eval("Name") %>
                                </td>
                                <td><%# Eval("Head.Name") %>                                                
                                </td>
                                <td><%# Eval("CabinetId") %>                                                
                                </td>
                                <td><%# Eval("SiteCode") %>                                                
                                </td>
                                <td><%# Eval("VillageId") %>                                                
                                </td>
                                <td>
                                    <%# Eval("Village") %>
                                </td>
                                <td>
                                    <%# Eval("SubDistrict") %>
                                </td>
                                <td>
                                    <%# Eval("District") %>
                                </td>
                                <td>
                                    <%# Eval("Province") %>
                                </td>
                                <td>
                                    <%# Eval("Contract") %>
                                </td>
                                <td>
                                    <%# Eval("Type") %>
                                </td>
                                <td>
                                    <%# Eval("TypeofSignal") %>
                                </td>
                                <td>
                                    <asp:HyperLink ID="HyperLink1" runat="server">Edit</asp:HyperLink>
                                    <asp:HyperLink ID="HyperLink2" runat="server">Preview</asp:HyperLink>

                                </td>
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                </tbody>
            </table>

            <br />
            <br />
        </div>
    </form>

    <%------------------------------//  BOOTSTRAP 4 DATA TABLE  //-------------------------------------%>
    <script src="https://code.jquery.com/jquery-3.5.1.js"></script>
    <script src="https://cdn.datatables.net/1.10.23/js/jquery.dataTables.min.js"></script>
    <script src=" https://cdn.datatables.net/1.10.23/js/dataTables.bootstrap4.min.js"></script>
    <script src=" https://cdn.datatables.net/responsive/2.2.6/js/dataTables.responsive.min.js"></script>
    <script src="https://code.jquery.com/ui/1.12.1/jquery-ui.js"></script>

    <script>

        $(document).ready(function () {
            $('#example').DataTable();
        });
    </script>


    <%------------------------------//  LOADING SCREEN //-------------------------------------%>
<%--    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>--%>
    <script type="text/javascript">
        function ShowProgress() {
            setTimeout(function () {
                var modal = $('<div />');
                modal.addClass("modal");
                $('body').append(modal);
                var loading = $(".loading");
                loading.show();
                var top = Math.max($(window).height() / 2 - loading[0].offsetHeight / 2, 0);
                var left = Math.max($(window).width() / 2 - loading[0].offsetWidth / 2, 0);
                loading.css({ top: top, left: left });
            }, 200);
        }
        $('form1').live("submit", function () {
            ShowProgress();
        });
    </script>
    <style type="text/css">
        body {
            background-color: #f3f6fb;
            font-family: 'Prompt', sans-serif;
        }

        thead {
            background-color: #007cc2;
            color: white;
            font-weight: 200;
        }

        table {
            border-collapse: collapse;
            border-radius: 1.3em;
            overflow: hidden;
        }

        th, td {
            padding: 1em;
            border-bottom: 2px solid white;
            font-weight: 400;
        }

        .modal {
            position: fixed;
            top: 0;
            left: 0;
            background-color: black;
            z-index: 99;
            opacity: 0.8;
            filter: alpha(opacity=80);
            -moz-opacity: 0.8;
            min-height: 100%;
            width: 100%;
        }

        .loading {
            font-family: Arial;
            font-size: 10pt;
            border: 5px solid #67CFF5;
            width: 200px;
            height: 100px;
            display: none;
            position: fixed;
            background-color: red;
            z-index: 999;
        }
    </style>

</body>
</html>
