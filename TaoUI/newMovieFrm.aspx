<%@ Page Language="C#" AutoEventWireup="true" CodeFile="newMovieFrm.aspx.cs" Inherits="newMovieFrm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:Button runat="server" ID="btn" Text="查询" OnClick="btn_Click" />
                <asp:TextBox ID="txt" runat="server"></asp:TextBox>
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>
    </form>
</body>
</html>
