<%@ Page Language="C#" AutoEventWireup="true" enableEventValidation="false" CodeBehind="ManageFrm.aspx.cs" Inherits="ManageUI.SuperManage.ManageFrm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="../resources/css/ManageFrm.css" rel="stylesheet" />
    <style>

        .gv_future {
            text-align:center;
                
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
          <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
      <div id="main-content">
         
   
    <h2>Welcome</h2>
    <h1>普通管理员管理</h1>
   
    
    <div class="clear"></div>
  
    <div class="content-box">
        <div class="clear"></div>
       
    
            
      <div class="content-box-header">
     
       
        <div class="clear"></div>
      </div>
      <!-- End .content-box-header -->
        <asp:GridView ID="gv_future" CssClass="gv_future"   AutoPostBack="True"    runat="server" AutoGenerateColumns="False" AllowPaging="True" PageSize="5" OnPageIndexChanging="gv_future_PageIndexChanging" CellPadding="4" ForeColor="#333333" GridLines="None" >

            <AlternatingRowStyle BackColor="White" />

            <Columns>
                   <asp:TemplateField HeaderText="电影院名称用户名"  ItemStyle-Width="15%">
                   <ItemTemplate>
                        <asp:Label runat="server" Text='<%#Eval("name") %>'></asp:Label>
                   </ItemTemplate>

<ItemStyle Width="15%"></ItemStyle>
               </asp:TemplateField>
                <asp:TemplateField HeaderText="Email" ItemStyle-Width="15%">
                   <ItemTemplate>
                        <asp:Label runat="server" Text='<%#Eval("email") %>'></asp:Label>
                   </ItemTemplate>

<ItemStyle Width="15%"></ItemStyle>
               </asp:TemplateField>
                <asp:TemplateField HeaderText="所管理的电影院" ItemStyle-Width="10%">
                   <ItemTemplate>
                        <asp:Label runat="server" Text='<%#Eval("y_Name") %>'></asp:Label>
                   </ItemTemplate>

<ItemStyle Width="10%"></ItemStyle>
               </asp:TemplateField>
                <asp:TemplateField HeaderText="操作" ItemStyle-Width="10%">
                   <ItemTemplate>
                     <asp:Button runat="server" ID="btn_tongYi" Text="同意" OnClick="btn_tongYi_Click" CommandArgument='<%#Eval("id") %>'  />
                       <asp:Button runat="server" ID="btn_buTongYo" Text="不同意" OnClick="btn_buTongYo_Click" CommandArgument='<%#Eval("id") %>'  />
                   </ItemTemplate>

<ItemStyle Width="10%"></ItemStyle>
               </asp:TemplateField>
              
                
            </Columns>

                  <PagerTemplate>
                                    当前第:
                                     <%--//((GridView)Container.NamingContainer)就是为了得到当前的控件--%>
                                    <asp:Label ID="LabelCurrentPage" runat="server" Text="<%# ((GridView)Container.NamingContainer).PageIndex + 1 %>"></asp:Label>
                                    页/共:
                                    <%--//得到分页页面的总数--%>
                                    <asp:Label ID="LabelPageCount" runat="server" Text="<%# ((GridView)Container.NamingContainer).PageCount %>"></asp:Label>
                                    页
                                    <%--//如果该分页是首分页，那么该连接就不会显示了.同时对应了自带识别的命令参数CommandArgument--%>
                                    <asp:LinkButton ID="LinkButtonFirstPage" runat="server" CommandArgument="First" CommandName="Page"
                                        Visible='<%#((GridView)Container.NamingContainer).PageIndex != 0 %>'>首页</asp:LinkButton>
                                    <asp:LinkButton ID="LinkButtonPreviousPage" runat="server" CommandArgument="Prev"
                                        CommandName="Page" Visible='<%# ((GridView)Container.NamingContainer).PageIndex != 0 %>'>上一页</asp:LinkButton>
                                    <%--//如果该分页是尾页，那么该连接就不会显示了--%>
                                    <asp:LinkButton ID="LinkButtonNextPage" runat="server" CommandArgument="Next" CommandName="Page"
                                        Visible='<%# ((GridView)Container.NamingContainer).PageIndex != ((GridView)Container.NamingContainer).PageCount - 1 %>'>下一页</asp:LinkButton>
                                    <asp:LinkButton ID="LinkButtonLastPage" runat="server" CommandArgument="Last" CommandName="Page"
                                        Visible='<%# ((GridView)Container.NamingContainer).PageIndex != ((GridView)Container.NamingContainer).PageCount - 1 %>'>尾页</asp:LinkButton>
                                    转到第
                                    <asp:TextBox ID="txtNewPageIndex" runat="server" Width="20px" Text='<%# ((GridView)Container.Parent.Parent).PageIndex + 1 %>' />页
                                    <%--//这里将CommandArgument即使点击该按钮e.newIndex 值为3 --%>
                                    <asp:LinkButton ID="btnGo" runat="server" CausesValidation="False" CommandArgument="-2"
                                        CommandName="Page" Text="GO"  />
                                </PagerTemplate>
            <EditRowStyle BackColor="#7C6F57" />
            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#E3EAEB" />
            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F8FAFA" />
            <SortedAscendingHeaderStyle BackColor="#246B61" />
            <SortedDescendingCellStyle BackColor="#D4DFE1" />
            <SortedDescendingHeaderStyle BackColor="#15524A" />
        </asp:GridView>
   
   
            
            </div>
              </div>
    </form>
</body>
</html>
