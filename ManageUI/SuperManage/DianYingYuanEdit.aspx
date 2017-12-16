<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DianYingYuanEdit.aspx.cs" Inherits="ManageUI.DianYingYuanEdit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
       <link href="../CSS/Tianjia.css" rel="stylesheet" />
    <style>
            #main ul  li {
    list-style-type:none;
    line-height:35px;
    }
    </style>
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
                <li class="wenben">所在的省份：</li>
                <li><asp:DropDownList ID="ddl_proice" AutoPostBack="true" runat="server" OnSelectedIndexChanged="ddl_proice_SelectedIndexChanged"></asp:DropDownList></li>
            

            </ul>
         <div class="clear"></div>
                <ul class="ul-first">
                <li class="wenben">所在的城市：</li>
                <li><asp:DropDownList ID="ddl_city" AutoPostBack="true" runat="server" OnSelectedIndexChanged="ddl_city_SelectedIndexChanged"></asp:DropDownList></li>

            </ul>
         <div class="clear"></div>
       
          <ul class="ul-first">
                <li class="wenben">所在的地区：</li>
                <li><asp:DropDownList ID="ddl_area" runat="server" ></asp:DropDownList></li>
          
            </ul>
         <div class="clear"></div>
        <ul class="ul-first">
            <li>
                <asp:Button runat="server" ID="btn_tianija" Text="修改" OnClick="btn_tianija_Click" CssClass="TJ" BorderStyle="None" /></li>
           <li><asp:Button runat="server" ID="btn_fanhui" Text="返回" OnClick="btn_fanhui_Click" CssClass="QX" BorderStyle="None" /></li>
   </ul>
             </div>
    </form>
</body>
</html>
