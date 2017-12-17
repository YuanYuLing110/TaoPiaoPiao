<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DianYingTingTianJiaFrm.aspx.cs" Inherits="ManageUI.DianYingTing.DianYingTingTianJiaFrm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="../CSS/Tianjia.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
       <div id="main">
   <h1>电影厅添加界面</h1>
            <ul class="ul-first">
                <li class="wenben">电影院名：</li>
                <li>
<asp:TextBox ID="DYT_name" runat="server" CssClass="TextBox" ></asp:TextBox>
                </li>
                <li>
                    <asp:RequiredFieldValidator  ControlToValidate="DYT_name"  ErrorMessage="电影厅名不能为空" ForeColor="Red"  Display="Dynamic"  runat="server" CssClass="verify"></asp:RequiredFieldValidator>

                </li>
            </ul>


        <div class="clear"></div>
       
               <ul class="ul-first">
                <li class="wenben">排数：</li>
                <li><asp:TextBox ID="DYT_row" runat="server" CssClass="TextBox"></asp:TextBox></li>
                <li><asp:RequiredFieldValidator  ControlToValidate="DYT_row"  ErrorMessage="电影院排不能为空" ForeColor="Red"  Display="Dynamic"  runat="server" CssClass="verify"></asp:RequiredFieldValidator>
                      <asp:RangeValidator ControlToValidate="DYT_row" ErrorMessage="输入必须是数字且范围为1~100" ForeColor="Red"  Display="Dynamic"  runat="server" CssClass="verify" MaximumValue="50" MinimumValue="0" Type="Integer"></asp:RangeValidator>
</li>
            </ul>
           <div class="clear"></div>
         <ul class="ul-first">
                <li class="wenben">列数：</li>
                <li><asp:TextBox ID="DYT_line" runat="server" CssClass="TextBox"></asp:TextBox></li>
                <li><asp:RequiredFieldValidator  ControlToValidate="DYT_line"  ErrorMessage="电影厅列数不能为空" ForeColor="Red"  Display="Dynamic"  runat="server" CssClass="verify"></asp:RequiredFieldValidator>
                    <asp:RangeValidator ControlToValidate="DYT_line" ErrorMessage="输入必须是数字且范围为1~100" ForeColor="Red"  Display="Dynamic"  runat="server" CssClass="verify" MaximumValue="50" MinimumValue="0" Type="Integer"></asp:RangeValidator>
</li>
            </ul>
        <div class="clear"></div>
                <asp:Button runat="server" ID="btn_tianija" Text="添加" OnClick="btn_tianija_Click" CssClass="TJ" BorderStyle="None" />
         <asp:Button runat="server" ID="btn_fanhui" Text="返回" OnClick="btn_fanhui_Click" CssClass="QX" BorderStyle="None" />

             </div>
    </form>
</body>
</html>
