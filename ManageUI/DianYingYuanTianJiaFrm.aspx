<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DianYingYuanTianjiaFrm.aspx.cs" Inherits="ManageUI.ManagerTianjiaFrm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="CSS/Tianjia.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div id="main">
   <h1>电影院添加界面</h1>
            <ul class="ul-first">
                <li class="wenben">电影院名：</li>
                <li>
<asp:TextBox ID="DYY_name" runat="server" CssClass="TextBox" ></asp:TextBox>
                </li>
                <li>
                    <asp:RequiredFieldValidator  ControlToValidate="DYY_name"  ErrorMessage="电影院名不能为空" ForeColor="Red"  Display="Dynamic"  runat="server" CssClass="verify"></asp:RequiredFieldValidator>

                </li>
            </ul>
    <div class="clear"></div>
            <ul class="ul-first">
                <li class="wenben">电影院地址：</li>
                <li><asp:TextBox ID="DYY_address" runat="server" CssClass="TextBox"></asp:TextBox></li>
                <li><asp:RequiredFieldValidator  ControlToValidate="DYY_address"  ErrorMessage="电影院地址不能为空" ForeColor="Red"  Display="Dynamic"  runat="server" CssClass="verify"></asp:RequiredFieldValidator>
</li>
            </ul>

        <div class="clear"></div>
       
               <ul class="ul-first">
                <li class="wenben">联系电话：</li>
                <li><asp:TextBox ID="DYY_phone" runat="server" CssClass="TextBox"></asp:TextBox></li>
                <li><asp:RequiredFieldValidator  ControlToValidate="DYY_phone"  ErrorMessage="联系电话不能为空" ForeColor="Red"  Display="Dynamic"  runat="server" CssClass="verify"></asp:RequiredFieldValidator>
</li>
            </ul>
         <div class="clear"></div>
                <ul class="ul-first">
                <li class="wenben">所在的城市：</li>
                <li><asp:TextBox ID="DYY_city" runat="server" CssClass="TextBox"></asp:TextBox></li>
                <li><asp:RequiredFieldValidator  ControlToValidate="DYY_city"  ErrorMessage="所在的城市不能为空" ForeColor="Red"  Display="Dynamic"  runat="server" CssClass="verify"></asp:RequiredFieldValidator>
</li>
            </ul>
         <div class="clear"></div>
       
        <asp:Button runat="server" ID="btn_tianija" Text="添加" OnClick="btn_tianija_Click" CssClass="TJ" BorderStyle="None" />
    </div>
    </form>
</body>
</html>
