<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="dashboard.aspx.cs" Inherits="USOform.WebForm2" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link href="~/style/Mystyle.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous" />
    <script src="previewImg.js"></script>
    <%---------------------------------//  font style  //------------------------------------%>
    <link rel="preconnect" href="https://fonts.gstatic.com" />
    <link href="https://fonts.googleapis.com/css2?family=Prompt:wght@200;300;400;500&display=swap" rel="stylesheet" />
    <%---------------------------------// bootstrap 4  //------------------------------------%>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/jquery-3.0.0.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/popper.min.js"></script>

    <title>USO FORMs DASHBOARD </title>
</head>

<body>
    <form id="form1" runat="server">
        <div class="container bg-white  mt-5">
            <table id="example" class="table table-striped table-responsive" style="width: 100%">
                <thead>
                    <tr>
                        <th style="width: 8%">จุดที่
                        </th>
                        <th style="text-align: center;">SR
                        </th>
                        <th style="text-align: center;">Name
                        </th>
                        <th>Village
                        </th>
                        <th style="width: 12%">SubDistrict
                        </th>
                        <th>District
                        </th>
                        <th>Province
                        </th>
                        <th>Type
                        </th>
                        <th>Create/Edit
                        </th>
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
                                    <%# Eval("Type") %>
                                </td>
                                <td>
                                    <asp:HyperLink ID="HyperLink1" runat="server">Edit</asp:HyperLink>
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
    </style>

</body>
</html>
