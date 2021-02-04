<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="dashboard.aspx.cs" Inherits="USOform.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link href="~/style/Mystyle.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous" />
    <script src="previewImg.js"></script>

    <%--font style--%>
    <link rel="preconnect" href="https://fonts.gstatic.com" />
    <link href="https://fonts.googleapis.com/css2?family=Sarabun:wght@100;300;400;500;600;700&display=swap" rel="stylesheet" />




    <link href=" https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/4.5.2/css/bootstrap.css" rel="stylesheet" />
    <link href="https://cdn.datatables.net/1.10.23/css/dataTables.bootstrap4.min.css" rel="stylesheet" />



    <%--    date time picker JQURRY--%>
    <link rel="stylesheet" href="//code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css" />
    <link rel="stylesheet" href="/resources/demos/style.css">
    <title>DASHBOARD</title>
</head>

<body>
 <form id="form1" runat="server">
        <div class="container">

            <br />

            <br />

            <table id="example" class="table table-striped table-bordered" style="width: 100%">
                <thead>
                    <tr>

                        <th>จุดที่
                        </th>
                        <th>SR
                        </th>
                        <th>Name
                        </th>
                        <th>Village
                        </th>
                        <th>Sub District
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

                                <td><%# Eval("id") %></td>

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







    <script src="https://code.jquery.com/jquery-3.5.1.js"></script>
    <script src="https://cdn.datatables.net/1.10.23/js/jquery.dataTables.min.js"></script>
    <script src=" https://cdn.datatables.net/1.10.23/js/dataTables.bootstrap4.min.js"></script>
    <script src=" https://cdn.datatables.net/responsive/2.2.6/js/dataTables.responsive.min.js"></script>
    <script src="https://code.jquery.com/ui/1.12.1/jquery-ui.js"></script>







    <%--/////////////////    script START !!   /////////////////////////////--%>



    <script>

        $(document).ready(function () {
            $('#example').DataTable();
        });
    </script>


</body>


</html>
