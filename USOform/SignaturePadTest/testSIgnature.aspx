<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="testSIgnature.aspx.cs" Inherits="USOform.SignaturePadTest.testSIgnature" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>test signature pad</title>
    <%--//  SIGNATURE PAD  //--%>
    <script src="https://cdn.jsdelivr.net/npm/signature_pad@2.3.2/dist/signature_pad.min.js"></script>
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link href="../style/Mystyle.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous" />
</head>
<body>
    <form id="form1" runat="server">      
        <div class="container">
            <div class="row mt-3">
                <div class="col-md-12 bg-warning text-white text-center Myfont">
                    <h4>Contractor</h4>
                </div>
            </div>
            <div class="row mt-2">
                <div class="col-lg-6">
                    <div class="card">
                        <div class="card-header">
                            Executor
                        </div>
                        <div class="card-body">                        
                          <%--  <img src="../assets/whiteBackground.png" width="400" height="200" />--%>
                            <%--<img src="https://preview.ibb.co/jnW4Qz/Grumpy_Cat_920x584.jpg" width="400" height="200" />--%>
                            <canvas id="signature-pad" class="signature-pad" width="400" height="200"></canvas>
                             <asp:HiddenField ID="SignatureHiddenfieldExecutor" runat="server" />
                              <div>
                                   <button  type="button" id="save">save</button>
                                 <button type="button" id="clear">Clear</button>
                                </div>
                             <div class="form-group">
                                <label>Name</label>
                                <input type="text"  class="form-control" id="Text1" runat="server" />
                            </div>
                            <div class="form-group">
                                <label>Date</label>
                                <input type="text"  class="form-control" id="Text2" runat="server" />
                            </div>
                        </div>
                    </div>
                </div>

                <div class="col-lg-6">
                    <div class="card">
                        <div class="card-header">
                            Supervisor
                        </div>
                        <div class="card-body">                         
                           <%-- <img src="../assets/whiteBackground.png" width="400" height="200" />--%>
                            <%--<img src="https://preview.ibb.co/jnW4Qz/Grumpy_Cat_920x584.jpg" width="400" height="200" />--%>
                            <canvas id="signature-pad2" class="signature-pad2" width="400" height="200"></canvas>
                             <asp:HiddenField ID="SignatureHiddenfieldSupervisor" runat="server" />
                        
                          
                            <div>                            
                                <button type="button" id="save2">Save</button>
                                 <button type="button" id="clear2">Clear</button>
                                </div>
                               
                            <div class="form-group">
                                <label>Name</label>
                                <input type="text"  class="form-control" id="nameSupervisorTextbox" runat="server" />
                            </div>
                            <div class="form-group">
                                <label>Date</label>
                                <input type="text"  class="form-control" id="DateSupervisorTextbox" runat="server" />
                            </div>                                       
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>






    <script>
        var signaturePad = new SignaturePad(document.getElementById('signature-pad'), {
            backgroundColor: 'rgba(255, 255, 255, 0)',
            penColor: 'rgb(0, 0, 0)'       
        });
        // console.log(signaturePad);});
        var saveButton = document.getElementById('save');
        var cancelButton = document.getElementById('clear');

        saveButton.addEventListener('click', function (event) {
            var data = signaturePad.toDataURL('image/png')    
            console.log("data 1 is =>", data);
            SignatureHiddenfieldExecutor.value = data;
            alert('Signature Hiddenfield Executor is =>' + SignatureHiddenfieldExecutor.value);
            // Send data to server instead...
         
        });

        cancelButton.addEventListener('click', function (event) {
            signaturePad.clear();
        });
    </script>


      <script>
          var signaturePad2 = new SignaturePad(document.getElementById('signature-pad2'), {
              backgroundColor: 'rgba(255, 255, 255, 0)',
              penColor: 'rgb(0, 0, 0)'
          });
      

          var saveButton2 = document.getElementById('save2');
          var cancelButton2 = document.getElementById('clear2');

          saveButton2.addEventListener('click', function (event) {
              var dataSignatureSupervisor = signaturePad2.toDataURL('image/png');
              console.log("data 2 is =>", dataSignatureSupervisor);
              SignatureHiddenfieldSupervisor.value = dataSignatureSupervisor;
              alert('Signature Hiddenfield Supervisor is =>' + SignatureHiddenfieldSupervisor.value);
          });

          cancelButton2.addEventListener('click', function (event) {
              signaturePad2.clear();
          });
      </script>
    <style type="text/css">
        .wrapper {
            position: relative;
            width: 400px;
            height: 200px;
            -moz-user-select: none;
            -webkit-user-select: none;
            -ms-user-select: none;
            user-select: none;
        }

        img {
            position: relative;
            left: 0;
            top: 0;
        }

        .signature-pad {
            position: relative;
            /*  left: 0;
            top: 0;*/
            width: 400px;
            height: 200px;
            border: solid;
            border-width: 1px;
        }

        
        .signature-pad2 {
            position: relative;
            /*  left: 0;
            top: 0;*/
            width: 400px;
            height: 200px;
            border: solid;
            border-width: 1px;
        }
    </style>

</body>
</html>
