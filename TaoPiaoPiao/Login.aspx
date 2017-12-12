<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TaoPiaoPiao.LOGING" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>首页</title>
    <link href="CSS/login.css" rel="stylesheet" /> 
</head>
<body style="background-image:url(image/05.jpg)" >
   
    <div id="main" style="margin:auto;margin-top:200px;z-index:1;background-color:rgba(252, 245, 235,0.5);background-size:cover;-moz-background-size:cover;">
     <form id="form1"  method="post" runat="server"  >
          <header style="text-align:center">
              <h1>百词斩登录界面</h1>
               <hr style="color:white;"/>
          </header>
       <%--  <asp:Panel ID="Panel1" runat="server" CssClass="pnl" BorderStyle="Groove" Visible="False" >
             <img src="image/icon.png" style="margin-top:10px;margin-left:20px" />
             <asp:RequiredFieldValidator ControlToValidate="userName" ID="RequiredFieldValidatorName" ErrorMessage="用户名不能为空" ForeColor="Red"  Display="Dynamic" runat="server" CssClass="verify"  ></asp:RequiredFieldValidator>
             <asp:RequiredFieldValidator ControlToValidate="password" ID="RequiredFieldValidatorPwd" ErrorMessage="密码不能为空" ForeColor="Red"  Display="Dynamic" runat="server" CssClass="verify" ></asp:RequiredFieldValidator>
             <%--<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>--%>
         <%--</asp:Panel>--%>
          <div  style="z-index:1" >
                   
              <asp:TextBox ID="userName" runat="server" placeholder="这里输入登录名" CssClass="layui-input" ></asp:TextBox>
              <br />
               <asp:RequiredFieldValidator ControlToValidate="userName" ID="RequiredFieldValidatorName" ErrorMessage="用户名不能为空" ForeColor="Red"  Display="Dynamic" runat="server" CssClass="verify"  ></asp:RequiredFieldValidator>
                  </div>
                  <div  style="z-index:1">
                    
                      <asp:TextBox ID="password" placeholder="这里输入密码" CssClass="layui-input" runat="server" TextMode="Password" ></asp:TextBox>
                         <br /> <asp:RequiredFieldValidator ControlToValidate="password" ID="RequiredFieldValidatorPwd" ErrorMessage="密码不能为空" ForeColor="Red"  Display="Dynamic" runat="server" CssClass="verify" ></asp:RequiredFieldValidator>
                  </div>
        <%--  <asp:Button ID="btn" runat="server"  Text="登录" Width="300px" Height="40px" CssClass="btn"  OnClick="btn_Click"/>--%>
        <%-- <input type="button" onclick="load_Click"/>--%>

         <asp:Button ID="Button1" runat="server"  Text="登录" Width="300px" Height="40px" CssClass="btn" OnClick="Button1_Click" />

          <div class="login-ZuCe">
                      <ul >
                          <li style="float:left;margin-right:100px;margin-left:100px"> <a href="#" style="color:rgb(190, 244, 246)"><b>忘记密码</b></a></li>

                          <li style="float:left">
                              <a href="#" style="color:rgb(190, 244, 246)"><b>注册</b></a>
                          </li>
</ul>
                  </div>

          <footer style="margin-top:100px;text-align:center;font-family:'Bauhaus 93'">
              <p>版权所有　ＬＧ　</p>
          </footer>
         </form>
       
    </div>
  
     
</body>
</html>
