<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="USOform.testsig._default" %>


<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Signature Pad - HTML5 - jQuery Mobile</title>
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous" />
    <link rel="stylesheet" href="http://code.jquery.com/mobile/1.3.2/jquery.mobile-1.3.2.min.css" />
    <script src="https://code.jquery.com/jquery-1.9.1.min.js"></script>
    <%-- <script src="https://code.jquery.com/mobile/1.3.2/jquery.mobile-1.3.2.min.js"></script>--%>
    <style>
        #div_signcontract {
            width
        }
    </style>

</head>
<body>
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
                    <div data-role="page">
                        <!-- /header -->
                        <div id="page" data-role="content">
                          <div class="row">
                                <canvas id="canvas" style="width: 100px !important;">Canvas is not supported</canvas>
                                <div>
                                    <input id="btnSubmitSign" type="button" data-inline="true" data-mini="true" data-theme="b" value="Submit Sign" onclick="fun_submit()" />
                                    <input id="btnClearSign" type="button" data-inline="true" data-mini="true" data-theme="b" value="Clear" onclick="init_Sign_Canvas()" />
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="form-group">
                        <label>Name</label>
                        <input type="text" required="required" class="form-control" id="nameExecutorTextbox" runat="server" />
                    </div>
                    <div class="form-group">
                        <label>Date</label>
                        <input type="text" required="required" class="form-control" id="DateExecutorTextbox" runat="server" />
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
                    <div data-role="page">
                        <div data-role="header">
                        </div>
                        <!-- /header -->
                        <div id="page2" data-role="content">
                            <div class="row">
                                <canvas id="canvas2">Canvas is not supported</canvas>
                                <div>
                                    <input id="btnSubmitSign2" type="button" data-inline="true" data-mini="true" data-theme="b" value="Submit Sign" onclick="fun_submit2()" />
                                    <input id="btnClearSign2" type="button" data-inline="true" data-mini="true" data-theme="b" value="Clear" onclick="init_Sign_Canvas2()" />
                                </div>

                            </div>
                        </div>
                    </div>
                    <div class="form-group">
                        <label>Name</label>
                        <input type="text" required="required" class="form-control" id="nameSupervisorTextbox" runat="server" />
                    </div>
                    <div class="form-group">
                        <label>Date</label>
                        <input type="text" required="required" class="form-control" id="DateSupervisorTextbox" runat="server" />
                    </div>
                </div>
            </div>
        </div>
    </div>





    <script type="text/javascript">
        var isSign = false;
        var leftMButtonDown = false;

        jQuery(function () {
            //Initialize sign pad
            init_Sign_Canvas2();
        });

        function fun_submit2() {
            if (isSign) {
                var canvas = $("#canvas2").get(0);
                var imgData = canvas.toDataURL();
                var imageData = "S";
                var hid = "hidden";
                jQuery('#page2').find('p').remove();
                jQuery('#page2').find('img').remove();
                //jQuery('#page').append(jQuery('<p>Your Sign:</p>'));
                jQuery('#page2').append($('<img/>').attr('src', imgData).attr('id', imageData).attr('hidden', hid));

                closePopUp2();
            } else {
                alert('Please sign');
            }
        }

        function closePopUp2() {
            jQuery('#divPopUpSignContract').popup('close');
            jQuery('#divPopUpSignContract').popup('close');
        }

        function init_Sign_Canvas2() {
            isSign = false;
            leftMButtonDown = false;

            //Set Canvas width
            var sizedWindowWidth = $(window).width();
            if (sizedWindowWidth > 700)
                sizedWindowWidth = $(window).width() / 2;
            else if (sizedWindowWidth > 400)
                sizedWindowWidth = sizedWindowWidth - 100;
            else
                sizedWindowWidth = sizedWindowWidth - 50;

            $("#canvas2").width(500);
            $("#canvas2").height(200);
            $("#canvas2").css("border", "1px solid #000");

            var canvas = $("#canvas2").get(0);

            canvasContext2 = canvas.getContext('2d');

            if (canvasContext2) {
                canvasContext2.canvas.width = 500;
                canvasContext2.canvas.height = 200;

                canvasContext2.fillStyle = "#fff";
                canvasContext2.fillRect(0, 0, sizedWindowWidth, 200);

                canvasContext2.moveTo(50, 150);
                canvasContext2.lineTo(sizedWindowWidth - 50, 150);
                canvasContext2.stroke();

                canvasContext2.fillStyle = "#000";
                canvasContext2.font = "20px Arial";
                canvasContext2.fillText("x", 10, 155);
            }
            // Bind Mouse events
            $(canvas).on('mousedown', function (e) {
                if (e.which === 1) {
                    leftMButtonDown2 = true;
                    canvasContext2.fillStyle = "#000";
                    var x = e.pageX - $(e.target).offset().left;
                    var y = e.pageY - $(e.target).offset().top;
                    canvasContext2.moveTo(x, y);
                }
                e.preventDefault();
                return false;
            });

            $(canvas).on('mouseup', function (e) {
                if (leftMButtonDown2 && e.which === 1) {
                    leftMButtonDown2 = false;
                    isSign = true;
                }
                e.preventDefault();
                return false;
            });

            // draw a line from the last point to this one
            $(canvas).on('mousemove', function (e) {
                if (leftMButtonDown2 == true) {
                    canvasContext2.fillStyle = "#000";
                    var x = e.pageX - $(e.target).offset().left;
                    var y = e.pageY - $(e.target).offset().top;
                    canvasContext2.lineTo(x, y);
                    canvasContext2.stroke();
                }
                e.preventDefault();
                return false;
            });

            //bind touch events
            $(canvas).on('touchstart', function (e) {
                leftMButtonDown2 = true;
                canvasContext2.fillStyle = "#000";
                var t = e.originalEvent.touches[0];
                var x = t.pageX - $(e.target).offset().left;
                var y = t.pageY - $(e.target).offset().top;
                canvasContext2.moveTo(x, y);

                e.preventDefault();
                return false;
            });

            $(canvas).on('touchmove', function (e) {
                canvasContext.fillStyle = "#000";
                var t = e.originalEvent.touches[0];
                var x = t.pageX - $(e.target).offset().left;
                var y = t.pageY - $(e.target).offset().top;
                canvasContext2.lineTo(x, y);
                canvasContext2.stroke();

                e.preventDefault();
                return false;
            });

            $(canvas).on('touchend', function (e) {
                if (leftMButtonDown) {
                    leftMButtonDown = false;
                    isSign = true;
                }

            });
        }
    </script>

    <script type="text/javascript">
        var isSign = false;
        var leftMButtonDown = false;

        jQuery(function () {
            //Initialize sign pad
            init_Sign_Canvas();
        });

        function fun_submit() {
            if (isSign) {
                var canvas = $("#canvas").get(0);
                var imgData = canvas.toDataURL();
                var imageData = "Ss";
                var hid = "hidden";
                jQuery('#page').find('p').remove();
                jQuery('#page').find('img').remove();
                //jQuery('#page').append(jQuery('<p>Your Sign:</p>'));
                jQuery('#page').append($('<img/>').attr('src', imgData).attr('id', imageData).attr('hidden', hid));

                closePopUp();
            } else {
                alert('Please sign');
            }
        }

        function closePopUp() {
            jQuery('#divPopUpSignContract').popup('close');
            jQuery('#divPopUpSignContract').popup('close');
        }

        function init_Sign_Canvas() {
            isSign = false;
            leftMButtonDown = false;

            //Set Canvas width
            var sizedWindowWidth = $(window).width();
            if (sizedWindowWidth > 700)
                sizedWindowWidth = $(window).width() / 2;
            else if (sizedWindowWidth > 400)
                sizedWindowWidth = sizedWindowWidth - 100;
            else
                sizedWindowWidth = sizedWindowWidth - 50;

            $("#canvas").width(500);
            $("#canvas").height(200);
            $("#canvas").css("border", "1px solid #000");

            var canvas = $("#canvas").get(0);

            canvasContext = canvas.getContext('2d');

            if (canvasContext) {
                canvasContext.canvas.width = 500;
                canvasContext.canvas.height = 200;

                canvasContext.fillStyle = "#fff";
                canvasContext.fillRect(0, 0, sizedWindowWidth, 200);

                canvasContext.moveTo(50, 150);
                canvasContext.lineTo(sizedWindowWidth - 50, 150);
                canvasContext.stroke();

                canvasContext.fillStyle = "#000";
                canvasContext.font = "20px Arial";
                canvasContext.fillText("x", 40, 155);
            }
            // Bind Mouse events
            $(canvas).on('mousedown', function (e) {
                if (e.which === 1) {
                    leftMButtonDown = true;
                    canvasContext.fillStyle = "#000";
                    var x = e.pageX - $(e.target).offset().left;
                    var y = e.pageY - $(e.target).offset().top;
                    canvasContext.moveTo(x, y);
                }
                e.preventDefault();
                return false;
            });

            $(canvas).on('mouseup', function (e) {
                if (leftMButtonDown && e.which === 1) {
                    leftMButtonDown = false;
                    isSign = true;
                }
                e.preventDefault();
                return false;
            });

            // draw a line from the last point to this one
            $(canvas).on('mousemove', function (e) {
                if (leftMButtonDown == true) {
                    canvasContext.fillStyle = "#000";
                    var x = e.pageX - $(e.target).offset().left;
                    var y = e.pageY - $(e.target).offset().top;
                    canvasContext.lineTo(x, y);
                    canvasContext.stroke();
                }
                e.preventDefault();
                return false;
            });

            //bind touch events
            $(canvas).on('touchstart', function (e) {
                leftMButtonDown = true;
                canvasContext.fillStyle = "#000";
                var t = e.originalEvent.touches[0];
                var x = t.pageX - $(e.target).offset().left;
                var y = t.pageY - $(e.target).offset().top;
                canvasContext.moveTo(x, y);

                e.preventDefault();
                return false;
            });

            $(canvas).on('touchmove', function (e) {
                canvasContext.fillStyle = "#000";
                var t = e.originalEvent.touches[0];
                var x = t.pageX - $(e.target).offset().left;
                var y = t.pageY - $(e.target).offset().top;
                canvasContext.lineTo(x, y);
                canvasContext.stroke();

                e.preventDefault();
                return false;
            });

            $(canvas).on('touchend', function (e) {
                if (leftMButtonDown) {
                    leftMButtonDown = false;
                    isSign = true;
                }

            });
        }
    </script>


</body>
</html>

