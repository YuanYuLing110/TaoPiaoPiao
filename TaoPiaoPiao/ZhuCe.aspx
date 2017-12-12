<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ZhuCe.aspx.cs" Inherits="TaoPiaoPiao.ZhuCe" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>

  
    <title>注册</title>
  
    <link href="CSS/ZhuCe.css" rel="stylesheet" />
   <%-- <script src="JS/ZhuCe.js"></script>--%>
</head>
<body >
   
    <div id="main" style="margin:auto;z-index:1; top: -15px; left: 6px;">
     <form id="form1"  method="post" runat="server"  >
         
          <header style="text-align:center">
              <h1>百词斩注册界面</h1>
               <hr style="color:white;"/>
          </header>
          <div  style="z-index:1" >
                 <%--<label style="margin-left:60px;position:absolute;z-index:4;margin-top:40px;color:red">请点击按钮选择图片</label>
             
                  <asp:FileUpload ID="FileUpload1" runat="server" style="margin-left:60px;position:absolute;z-index:5;margin-top:80px;" /> --%>
             <%-- <asp:ImageButton ImageUrl="image/defaultImage.gif"  runat="server" ID="picture" OnClick="picture_Click" CssClass="picture" CausesValidation="false" />--%>
              <img src="image/defaultImage.gif" class="picture" />
                                     <asp:TextBox ID="userName" runat="server" placeholder="这里输入登录名" CssClass="layui-input" MaxLength="20" ></asp:TextBox>
              <br />
              <label style="width:100px" ></label>
              <asp:RequiredFieldValidator ControlToValidate="userName" ErrorMessage="用户名不能为空" ForeColor="Red"  Display="Dynamic" runat="server" CssClass="verify" ></asp:RequiredFieldValidator>
                  </div>
                  <div  style="z-index:1">
                    
                      <asp:TextBox ID="password" placeholder="这里输入密码" CssClass="layui-input" runat="server" TextMode="Password" ></asp:TextBox>
                      <br />  <asp:RequiredFieldValidator ControlToValidate="password" ErrorMessage="密码不能为空" ForeColor="Red"  Display="Dynamic" runat="server" CssClass="verify" ></asp:RequiredFieldValidator>
                  </div>
          <div  style="z-index:1">
                    
                      <asp:TextBox ID="again_password" placeholder="这里再次确认输入密码" CssClass="layui-input" runat="server" TextMode="Password" ></asp:TextBox>
               <br /> <asp:RequiredFieldValidator ControlToValidate="again_password" ErrorMessage="再次输入密码不能为空" ForeColor="Red"  Display="Dynamic" runat="server"  CssClass="verify" ></asp:RequiredFieldValidator>
              <asp:CompareValidator ID="ComPare" ErrorMessage="必须入上一次的密码相同" ForeColor="Red" runat="server" ControlToValidate="again_password"  ControlToCompare="password"  ></asp:CompareValidator>
                 <asp:TextBox ID="txt_email" placeholder="这里Email" CssClass="layui-input" runat="server" ></asp:TextBox>
                <br /> <asp:RequiredFieldValidator ControlToValidate="txt_email" ErrorMessage="Email不能为空" ForeColor="Red"  Display="Dynamic" runat="server"  CssClass="verify"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="re_Email" runat="server" ErrorMessage="电子邮箱格式不正确" ForeColor="Red" Display="Dynamic" ControlToValidate="txt_email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"  CssClass="verify"></asp:RegularExpressionValidator>

          </div>
          <asp:Button ID="load" runat="server"  Text="注册" Width="300px" Height="40px" CssClass="btn" OnClick="load_Click"  />
      <%--   <input type="button" onclick="ShowSecond()" />--%>
      
              <footer> 
              <p style="text-align:center;margin-top:40px">版权所有　ＬＧ　</p>
          </footer>
         </form>
       
    </div>
  
     
</body>
</html>
