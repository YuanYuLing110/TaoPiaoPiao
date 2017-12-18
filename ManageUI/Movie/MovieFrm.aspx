<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MovieFrm.aspx.cs" Inherits="ManageUI.Movie.MovieFrm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
   
    <link href="../CSS/kalendae.css" rel="stylesheet" />
    <script src="../JS/kalendae.standalone.js"></script>
    <link href="../CSS/MovieCss.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div id="header">
            <h1>电影管理界面</h1>
日期：
<input type="text" class="auto-kal" id="data" runat="server"/>
            <asp:Button runat="server" Text="查询" ID="tbn_dateSearch" OnClick="tbn_dateSearch_Click" />
        </div>
        <div>
  
       <asp:GridView ID="gv" Width="1000px" CssClass="gv" AutoPostBack="True"   runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateColumns="False" AllowPaging="True" PageSize="5"  OnPageIndexChanging="gv_PageIndexChanging"  >

           <AlternatingRowStyle BackColor="White" />

           <Columns>
               <asp:TemplateField HeaderText="电影名称"  ItemStyle-Width="150px">
                   <ItemTemplate>
                        <asp:Label runat="server" Text='<%#Eval("m_name") %>'></asp:Label>
                   </ItemTemplate>

<ItemStyle Width="15%"></ItemStyle>
               </asp:TemplateField>
                <asp:TemplateField HeaderText="导演" ItemStyle-Width="100px">
                   <ItemTemplate>
                        <asp:Label runat="server" Text='<%#Eval("m_direct") %>'></asp:Label>
                   </ItemTemplate>

<ItemStyle Width="15%"></ItemStyle>
               </asp:TemplateField>
                <asp:TemplateField HeaderText="主演" ItemStyle-Width="300px">
                   <ItemTemplate>
                        <asp:Label runat="server" Text='<%#Eval("m_star") %>'></asp:Label>
                   </ItemTemplate>

<ItemStyle Width="10%"></ItemStyle>
               </asp:TemplateField>
                <asp:TemplateField HeaderText=" 类型" ItemStyle-Width="100px">
                   <ItemTemplate>
                        <asp:Label runat="server" Text='<%#Eval("m_type") %>'></asp:Label>
                   </ItemTemplate>

<ItemStyle Width="10%"></ItemStyle>
               </asp:TemplateField>
                <asp:TemplateField HeaderText=" 制片国家" ItemStyle-Width="100px">
                   <ItemTemplate>
                        <asp:Label runat="server" Text='<%#Eval("m_state") %>'></asp:Label>
                   </ItemTemplate>

<ItemStyle Width="10%"></ItemStyle>
               </asp:TemplateField>

                <asp:TemplateField HeaderText=" 上映时间" ItemStyle-Width="100px">
                   <ItemTemplate>
                        <asp:Label runat="server" Text='<%#Eval("m_time") %>'></asp:Label>
                   </ItemTemplate>

<ItemStyle Width="10%"></ItemStyle>
               </asp:TemplateField>

                <asp:TemplateField HeaderText="评分" ItemStyle-Width="50px">
                   <ItemTemplate>
                        <asp:Label runat="server" Text='<%#Eval("m_grade").ToString().Length>10?Eval("m_grade").ToString().Substring(0,3):Eval("m_grade") %>'></asp:Label>
                   </ItemTemplate>

<ItemStyle Width="10%"></ItemStyle>
               </asp:TemplateField>



            
                               <asp:TemplateField HeaderText="操作">
                   <ItemTemplate>
                      <asp:ImageButton runat="server" CommandName="xiuGai" ImageUrl="~/resources/images/icons/pencil.png" CommandArgument='<%#Eval("m_id") %>' OnClick="Unnamed_Click"/>

               <asp:ImageButton runat="server" CommandName="xiuGai" ImageUrl="~/resources/images/icons/cross.png" CommandArgument='<%#Eval("m_id") %>' OnClick="Unnamed_Click1"/>
                   </ItemTemplate>
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
           <PagerStyle BackColor="#996633" ForeColor="Black" HorizontalAlign="Center" CssClass="pager" />
           <RowStyle BackColor="#E3EAEB" />
           <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
           <SortedAscendingCellStyle BackColor="#F8FAFA" />
           <SortedAscendingHeaderStyle BackColor="#246B61" />
           <SortedDescendingCellStyle BackColor="#D4DFE1" />
           <SortedDescendingHeaderStyle BackColor="#15524A" />
           
       </asp:GridView>
    </div>
    </form>
</body>
</html>
