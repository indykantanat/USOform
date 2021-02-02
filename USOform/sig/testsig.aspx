<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="testsig.aspx.cs" Inherits="USOform.sig.testsig" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <%--Important must have for signature !--%>
     <meta http-equiv="Content-Type" content="text/html;charset=utf-8" />
    <%-------%>
    <meta http-equiv="Content-Security-Policy" content="upgrade-insecure-requests"> 
    <title>jQuery UI Signature Basics</title>
    <link href="http://ajax.googleapis.com/ajax/libs/jqueryui/1.12.1/themes/south-street/jquery-ui.css" rel="stylesheet">
    <link href="css/jquery.signature.css" rel="stylesheet">
    <style>
        .kbw-signature {
            width: 400px;
            height: 200px;
        }
    </style>
    <!--[if IE]>
    <script src="excanvas.js"></script>
    <![endif]-->
    <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>
    <script src="http://ajax.googleapis.com/ajax/libs/jqueryui/1.12.1/jquery-ui.min.js"></script>
    <script src="js/jquery.signature.js"></script>
    <script>
        $(function () {


            $('#captureSignature').signature({ syncField: '#signatureJSON' });

            $('#clear2Button').click(function () {
                $('#captureSignature').signature('clear');
            });

            $('input[name="syncFormat"]').change(function () {
                var syncFormat = $('input[name="syncFormat"]:checked').val();
                $('#captureSignature').signature('option', 'syncFormat', syncFormat);
            });

            $('#svgStyles').change(function () {
                $('#captureSignature').signature('option', 'svgStyles', $(this).is(':checked'));
            });



            $('#redrawButton').click(function () {
                $('#redrawSignature').signature('enable').
                    signature('draw', $('#signatureJSON').val()).
                    signature('disable');
            });

            $('#redrawSignature').signature({ disabled: true });
        });
    </script>
    
</head>
<body>
    <form id="form1" runat="server">
         <h1>Signature</h1>

    <p><span class="demoLabel">Capture signature:</span></p>
    <div id="captureSignature"></div>
    <p style="clear: both;">
        <span class="demoLabel">&nbsp;</span>
        <button type="button" id="clear2Button">Clear</button>





    <p>
        <span class="demoLabel">Signature Output:</span>
        <textarea id="signatureJSON" rows="5" cols="50" readonly class="ui-state-active"></textarea>
    </p>
    <p>
        <span class="demoLabel">&nbsp;</span>
        <button type="button" id="redrawButton">Re-draw</button>
    </p>
    <p><span class="demoLabel">Re-draw signature:</span></p>
    <div id="redrawSignature"></div>

    </dl>
    </form>
   
   
</body>
</html>



