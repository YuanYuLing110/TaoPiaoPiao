<%@ Page Language="C#" EnableEventValidation="false"  AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="ManageUI.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>

    <link rel="stylesheet" href="resources/css/reset.css" type="text/css" media="screen" />
<!-- Main Stylesheet -->
<link rel="stylesheet" href="resources/css/style.css" type="text/css" media="screen" />
<!-- Invalid Stylesheet. This makes stuff look pretty. Remove it if you want the CSS completely valid -->
<link rel="stylesheet" href="resources/css/invalid.css" type="text/css" media="screen" />
<!--                       Javascripts                       -->
<!-- jQuery -->
<%--<script type="text/javascript" src="resources/scripts/jquery-1.3.2.min.js"></script>
<!-- jQuery Configuration -->
<script type="text/javascript" src="resources/scripts/simpla.jquery.configuration.js"></script>
<!-- Facebox jQuery Plugin -->
<script type="text/javascript" src="resources/scripts/facebox.js"></script>
<!-- jQuery WYSIWYG Plugin -->
<script type="text/javascript" src="resources/scripts/jquery.wysiwyg.js"></script>--%>
</head>
<body id="login">
    <form id="form1" runat="server">
   <div id="login-wrapper" class="png_bg">
  <div id="login-top">
    <h1>淘票票后台管理系统登陆</h1>
    <!-- Logo (221px width) -->
    <a href="#"><img id="logo" src="image/TB163BlJVXXXXXMXFXXXXXXXXXX-366-119.png" width="300px" alt="Simpla Admin logo" /></a> </div>
  <!-- End #logn-top -->
  <div id="login-content">
    <%--<form action="index.html">--%>
     <%-- <div class="notification information png_bg">
        <div> Just click "Sign In". No password needed. </div>
      </div>--%>
      <p>
        <label>用户名</label>
      <%--  <input class="text-input" type="text" />--%>
          <asp:TextBox ID="username" CssClass="text-input" runat="server"></asp:TextBox>
      </p>
      <div class="clear"></div>
      <p>
        <label>密码</label>
     <%--   <input class="text-input" type="password" />--%>
             <asp:TextBox ID="password" CssClass="text-input" runat="server" TextMode="Password" ></asp:TextBox>
      </p>
      <div class="clear"></div>
      <p id="remember-password">
        <input type="checkbox" />
       记住密码 </p>
      <div class="clear"></div>
      <p>
       <%-- <input class="button" type="submit" value="Sign In" />--%>
          <asp:Button ID="btnLogin" runat="server" Text="登陆" CssClass="button" OnClick="btnLogin_Click" />
      </p>
 <%--   </form>--%>
  </div>
  <!-- End #login-content -->
</div>
    </form>
</body>
</html>
