<%@ Page Language="C#" AutoEventWireup="true" enableEventValidation="false" CodeBehind="MainFrm.aspx.cs" Inherits="ManageUI.DianYingTing.MainFrm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
   
   <style>

       li {
list-style-type:none;
       }
       .gv {
           text-align:center;
       }

   </style>
</head>
<body>
    <form id="form1" runat="server">
        
   
      <div id="main-content">
         
   
    <h2>Welcome</h2>
    <h1><asp:Label runat="server" ID="lal_DianYingYuan" ></asp:Label></h1>
  
    <div class="clear"></div>
  
    <div class="content-box">
        <div class="clear"></div>
       
  
            
      <div class="content-box-header">
        <h2>电影厅表</h2>
        <ul class="content-box-tabs">
          <li><a href="#tab1" class="default-tab">Table</a></li>
          <!-- href must be unique and match the id of target div -->
         
        </ul>
        <div class="clear"></div>
      </div>
      <!-- End .content-box-header -->

   
       <asp:GridView ID="gv" CssClass="gv" Width="1000px" AutoPostBack="True"   runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateColumns="False" AllowPaging="True" PageSize="5"  OnPageIndexChanging="gv_PageIndexChanging"   >

           <AlternatingRowStyle BackColor="White" />

           <Columns>
               <asp:TemplateField HeaderText="电影厅名"  ItemStyle-Width="15%">
                   <ItemTemplate>
                        <asp:Label runat="server" Text='<%#Eval("t_name") %>'></asp:Label>
                   </ItemTemplate>

<ItemStyle Width="15%"></ItemStyle>
               </asp:TemplateField>
                <asp:TemplateField HeaderText="容纳人数" ItemStyle-Width="15%">
                   <ItemTemplate>
                        <asp:Label runat="server" Text='<%#Eval("t_count") %>'></asp:Label>
                   </ItemTemplate>

<ItemStyle Width="15%"></ItemStyle>
               </asp:TemplateField>
                <asp:TemplateField HeaderText="排数" ItemStyle-Width="10%">
                   <ItemTemplate>
                        <asp:Label runat="server" Text='<%#Eval("t_row") %>'></asp:Label>
                   </ItemTemplate>

<ItemStyle Width="10%"></ItemStyle>
               </asp:TemplateField>
                <asp:TemplateField HeaderText=" 列数" ItemStyle-Width="10%">
                   <ItemTemplate>
                        <asp:Label runat="server" Text='<%#Eval("t_line") %>'></asp:Label>
                   </ItemTemplate>

<ItemStyle Width="10%"></ItemStyle>
               </asp:TemplateField>
                               <asp:TemplateField HeaderText="操作">
                   <ItemTemplate>
                      <asp:ImageButton runat="server" CommandName="xiuGai" ImageUrl="~/resources/images/icons/pencil.png" CommandArgument='<%#Eval("t_id") %>' OnClick="Unnamed_Click"/>

               <asp:ImageButton runat="server" CommandName="xiuGai" ImageUrl="~/resources/images/icons/cross.png" CommandArgument='<%#Eval("t_id") %>' OnClick="Unnamed_Click1"/>
                   </ItemTemplate>
               </asp:TemplateField>

             
           </Columns>
          
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
     
      <%--   <asp:LinkButton ID="lnkbtnFrist" runat="server" OnClick="lnkbtnFrist_Click">首页</asp:LinkButton> 
        <asp:LinkButton ID="lnkbtnPre" runat="server" OnClick="lnkbtnPre_Click">上一页</asp:LinkButton> 
        <asp:Label ID="lblCurrentPage" runat="server"></asp:Label> 
        <asp:LinkButton ID="lnkbtnNext" runat="server" OnClick="lnkbtnNext_Click">下一页</asp:LinkButton> 
        <asp:LinkButton ID="lnkbtnLast" runat="server" OnClick="lnkbtnLast_Click" >尾页</asp:LinkButton> 
跳转到第<asp:DropDownList ID="ddlCurrentPage" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlCurrentPage_SelectedIndexChanged"> 
        </asp:DropDownList>页--%>
            
            </div>
              </div>
    </form>
</body>
</html>
