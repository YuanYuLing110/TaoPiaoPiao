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

    <style>
     
        #remember-password {
            width:150px;
        }

      /*#remember-password  #zhuce {

           color:blue;
        }*/
        a :hover {
            color:red
        }
        a:link {
          color:#2e377e
        }
        a:active {
            color:red
        }
        a {
            color:#2e377e
        }
    </style>
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
          <a href="RegisterPage.aspx" id="zhuce" >注册</a>
               &nbsp;  &nbsp;  &nbsp; &nbsp;
        <input type="checkbox" id="mima" />
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
