<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PianChangAddFrm.aspx.cs" Inherits="ManageUI.PianChang.PianChangAddFrm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="../CSS/kalendae.css" rel="stylesheet" />
    <script src="../JS/kalendae.standalone.js"></script>
    <link href="../CSS/PianChangAdd.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="main">
      <label>电影厅：</label>
    <asp:DropDownList runat="server" ID="ddl_pianChang" CssClass="ddl"></asp:DropDownList><br /><br />

         <label>已经上映的电影：</label>
    <asp:DropDownList runat="server" ID="DropDownList1" CssClass="ddl"></asp:DropDownList><label>或</label>  <br />
          <label>即将上映的电影：</label>
    <asp:DropDownList runat="server" ID="DropDownList2" CssClass="ddl"></asp:DropDownList>
        <br /><br />
        <label>设置日期：</label>
         <input type="text" id="m_time" class="auto-kal txt" data-kal="direction: 'future'" runat="server" /><br /><br />
        <label>设置时间：</label>
          <asp:ListBox ID="lb_hour" CssClass="lb" runat="server"></asp:ListBox><label>:</label><asp:ListBox ID="lb_mimutes" CssClass="lb"  runat="server"></asp:ListBox><br /><br />
        <label>价格</label>
        <asp:TextBox runat="server" ID="tb_price"></asp:TextBox>
    </div>
    </form>
  
</body>
</html>
