<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterPage.aspx.cs" Inherits="ManageUI.RegisterPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
      <link href="CSS/Tianjia.css"  rel="stylesheet" />
    <style>
            #main ul  li {
    list-style-type:none;
    line-height:35px;
    }
        #user {
            text-align:center;
        }
      #user  label {
            tab-size:24px;
        }
        .tb {
            width:150px;
            height:30px;
            line-height:36px;
            border-radius:3px;
        }

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
         
    <div>
         <div id="main">
   <h1>电影院选择</h1>
             <asp:UpdatePanel ID="UpdatePanel1" runat="server">
<ContentTemplate>
           <div class="clear"></div>
                <ul class="ul-first">
                <li class="wenben">所在的省份：</li>
                <li><asp:DropDownList ID="ddl_proice" AutoPostBack="True"  runat="server" OnSelectedIndexChanged="ddl_proice_SelectedIndexChanged"></asp:DropDownList></li>
            

            </ul>
         <div class="clear"></div>
                <ul class="ul-first">
                <li class="wenben">所在的城市：</li>
                <li><asp:DropDownList ID="ddl_city" runat="server" AutoPostBack="True"  OnSelectedIndexChanged="ddl_city_SelectedIndexChanged"></asp:DropDownList></li>

            </ul>
         <div class="clear"></div>
       
          <ul class="ul-first">
                <li class="wenben">所在的地区：</li>
                <li><asp:DropDownList ID="ddl_area" runat="server"  AutoPostBack="True" OnSelectedIndexChanged="ddl_area_SelectedIndexChanged" ></asp:DropDownList></li>
          
            </ul>
         <div class="clear"></div>
       <ul class="ul-first">
                <li class="wenben">所管理的电影院：</li>
              </ul>
                <li><asp:DropDownList ID="ddl_dyy" runat="server"  AutoPostBack="True" ></asp:DropDownList></li>
           </ContentTemplate>
        </asp:UpdatePanel>  
         
         <div class="clear"></div>
               <div id="user">
      <h1>用户注册</h1>
        <hr />
     <ul class="ul-first">

        <li  class="wenben">用户名：</li>
         <li><asp:TextBox runat="server"  ID="txt_name" CssClass="tb"/></li>
         <li><asp:RequiredFieldValidator  ControlToValidate="txt_name"   ErrorMessage="用户名不能为空" ForeColor="Red"  Display="Dynamic"  runat="server" CssClass="verify"></asp:RequiredFieldValidator>
 </li>
    </ul>
      <div class="clear"></div>
     <ul class="ul-first">
          <li  class="wenben">密码：</li>
         <li><asp:TextBox runat="server" TextMode="Password"  ID="txt_password" CssClass="tb"/></li>
         <li><asp:RequiredFieldValidator  ControlToValidate="txt_password"   ErrorMessage="密码不能为空" ForeColor="Red"  Display="Dynamic"  runat="server" CssClass="verify"></asp:RequiredFieldValidator>
</li>
         </ul>
           
   <div class="clear"></div>
     <ul class="ul-first">
          <li  class="wenben">确认密码：</li>
         <li> <asp:TextBox runat="server" TextMode="Password"  ID="txt_passwordAgain" CssClass="tb"/></li>
         <li>
<asp:RequiredFieldValidator  ControlToValidate="txt_passwordAgain"   ErrorMessage="用户名不能为空" ForeColor="Red"  Display="Dynamic"  runat="server" CssClass="verify"></asp:RequiredFieldValidator>
<asp:CompareValidator ControlToValidate  ="txt_passwordAgain" ControlToCompare="txt_password"  ErrorMessage="两次密码必须相同" ForeColor="Red"  Display="Dynamic"  runat="server" CssClass="verify"></asp:CompareValidator>


         </li>
         </ul>
          
        <div class="clear"></div>    <ul class="ul-first">

 <li  class="wenben">邮箱：</li>
<li><asp:TextBox runat="server" TextMode="Email"  ID="txt_email" CssClass="tb"/></li>
<li>  <asp:RequiredFieldValidator ControlToValidate="txt_email" ErrorMessage="Email不能为空" ForeColor="Red"  Display="Dynamic" runat="server"  CssClass="verify"></asp:RequiredFieldValidator>
         <asp:RegularExpressionValidator ID="re_Email" runat="server" ErrorMessage="电子邮箱格式不正确" ForeColor="Red" Display="Dynamic" ControlToValidate="txt_email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"  CssClass="verify"></asp:RegularExpressionValidator>
</li>
              </ul>   
   
<div class="clear"></div> 
    
         <ul class="ul-first">
            <li>
                <asp:Button runat="server" ID="btn_tianija" Text="注册" OnClick="btn_tianija_Click" CssClass="TJ" BorderStyle="None" /></li>
           <li><asp:Button runat="server" ID="btn_fanhui" Text="取消" OnClick="btn_fanhui_Click" CssClass="QX" BorderStyle="None" /></li>
   </ul>
       
   
            </div>
     
             </div>
      
    </div>
    </form>
</body>
</html>
