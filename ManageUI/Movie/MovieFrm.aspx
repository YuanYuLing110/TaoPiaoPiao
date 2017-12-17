<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MovieFrm.aspx.cs" Inherits="ManageUI.Movie.MovieFrm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script src="../resources/scripts/jquery-1.3.2.min.js"></script>
    <script >
        //document.getElementById("div1").style = "none";
        ////alert("hhh");
        //document.getElementById("div1")
        //$(document).ready(function(){
        //    //alert("cnxjc");
        //    $("#div1").css("display", "none");
        //})
        document.getElementById("<%= div1 %>")
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <div id="div1" style="width:100px;height:50px; background-color:brown; display:block" runat="server"></div>
    </div>
    </form>
</body>
</html>
