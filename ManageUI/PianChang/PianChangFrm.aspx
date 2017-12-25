<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PianChangFrm.aspx.cs" Inherits="ManageUI.PianChang.PianChangFrm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
   
    <title></title>
    <style  type="text/css">
        .pc {
            width:300px;
        }
        label {
             font-size:24px;

        }
        .ddl {
            width:150px;
             font-size:16px;
             height:24px;
             border-radius:3px;
        }

    </style>
</head>
<body>
    <form id="form1" runat="server">
      <div id="main-content">
         
   
    <h2>Welcome</h2>
   
   <label>根据电影查询:&nbsp;</label>
   <asp:DropDownList ID="ddl_movie" runat="server"  CssClass="ddl"></asp:DropDownList>
      <asp:Button ID="btn_movie" Text="查询"  runat="server" CssClass="btn" OnClick="btn_movie_Click"/>    
          <br />
   <label>根据电影厅查询:</label>
   <asp:DropDownList ID="ddl_dyt" runat="server"  CssClass="ddl"></asp:DropDownList>
    <asp:Button ID="btn_dyt" Text="查询"  runat="server" CssClass="btn" OnClick="btn_dyt_Click" />  <br />
    <div class="clear"></div>
  
    <div class="content-box">
        <div class="clear"></div>
       
  
            
      <div class="content-box-header">
        <h2>片场表</h2>
        <ul class="content-box-tabs">
          <li><a href="#tab1" class="default-tab">Table</a></li>
          <!-- href must be unique and match the id of target div -->
        

        </ul>
        <div class="clear"></div>
      </div>
      <!-- End .content-box-header -->

   
       <asp:GridView ID="gv" CssClass="gv" Width="1000px" AutoPostBack="True"   runat="server"  ForeColor="#333333"  AutoGenerateColumns="False" AllowPaging="True" PageSize="5"  OnPageIndexChanging="gv_PageIndexChanging" CellPadding="4" GridLines="None"   >

           <AlternatingRowStyle BackColor="White" />

           <Columns>
               <asp:TemplateField HeaderText="电影厅名" HeaderStyle-Width="150"  ItemStyle-Width="150">
                   <ItemTemplate>
                        <asp:Label runat="server" Text='<%#Eval("t_name") %>'></asp:Label>
                   </ItemTemplate>



<HeaderStyle Width="150px"></HeaderStyle>



<ItemStyle Width="15%"></ItemStyle>
               </asp:TemplateField>
                <asp:TemplateField HeaderText="电影名" HeaderStyle-CssClass="pc">
                   <ItemTemplate>
                        <asp:Label runat="server" Text='<%#Eval("m_name") %>'></asp:Label>
                   </ItemTemplate>



<HeaderStyle CssClass="pc"></HeaderStyle>



<ItemStyle Width="15%"></ItemStyle>
               </asp:TemplateField>
                <asp:TemplateField HeaderText="放映时间" HeaderStyle-CssClass="pc">
                   <ItemTemplate>
                        <asp:Label runat="server" Text='<%#Eval("p_time") %>'></asp:Label>
                   </ItemTemplate>



<HeaderStyle CssClass="pc"></HeaderStyle>



<ItemStyle Width="10%"></ItemStyle>
               </asp:TemplateField>
                <asp:TemplateField HeaderText="票价" HeaderStyle-Width="100" ItemStyle-Width="100">
                   <ItemTemplate>
                        <asp:Label runat="server" Text='<%#Eval("p_price") %>'></asp:Label>
                   </ItemTemplate>



<HeaderStyle Width="100px"></HeaderStyle>



<ItemStyle Width="10%"></ItemStyle>
               </asp:TemplateField>
                               <asp:TemplateField HeaderText="操作" >
                   <ItemTemplate>
                      <asp:ImageButton runat="server" CommandName="xiuGai" ImageUrl="~/resources/images/icons/pencil.png" CommandArgument='<%#Eval("p_id") %>' />

               <asp:ImageButton runat="server" CommandName="xiuGai" ImageUrl="~/resources/images/icons/cross.png" CommandArgument='<%#Eval("p_id") %>' />
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
           <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" CssClass="pager" />
           <RowStyle BackColor="#E3EAEB" HorizontalAlign="Center" />
           <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
           <SortedAscendingCellStyle BackColor="#F8FAFA" />
           <SortedAscendingHeaderStyle BackColor="#246B61" />
           <SortedDescendingCellStyle BackColor="#D4DFE1" />
           <SortedDescendingHeaderStyle BackColor="#15524A" />
           
       </asp:GridView>
     
         <%--<asp:LinkButton ID="lnkbtnFrist" runat="server" OnClick="lnkbtnFrist_Click">首页</asp:LinkButton> 
        <asp:LinkButton ID="lnkbtnPre" runat="server" OnClick="lnkbtnPre_Click">上一页</asp:LinkButton> 
        <asp:Label ID="lblCurrentPage" runat="server"></asp:Label> 
        <asp:LinkButton ID="lnkbtnNext" runat="server" OnClick="lnkbtnNext_Click">下一页</asp:LinkButton> 
        <asp:LinkButton ID="lnkbtnLast" runat="server" OnClick="lnkbtnLast_Click" >尾页</asp:LinkButton> 
跳转到第<asp:DropDownList ID="ddlCurrentPage" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlCurrentPage_SelectedIndexChanged"> 
        </asp:DropDownList>页
            
            --%></div>
              </div>
    </form>
</body>
</html>
