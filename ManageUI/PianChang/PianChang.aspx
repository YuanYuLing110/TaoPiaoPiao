﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PianChang.aspx.cs" Inherits="ManageUI.PianChang" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
      
       <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
      <div id="main-content">
         
   
    <h2>Welcome</h2>
    <h1>电影院片场管理</h1>
    
    
    <div class="clear"></div>
  
    <div class="content-box">
        <div class="clear"></div>
       
    <ul class="shortcut-buttons-set" >
         <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
    <li><asp:DropDownList ID="ddl_Sheng" runat="server" AutoPostBack="True"  OnSelectedIndexChanged="ddl_Sheng_SelectedIndexChanged" ></asp:DropDownList>&nbsp; &nbsp; 省&nbsp; &nbsp;</li>
    <li><asp:DropDownList ID="ddl_city" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddl_city_SelectedIndexChanged"></asp:DropDownList> &nbsp; &nbsp;   市&nbsp; &nbsp;</li>
    <li><asp:DropDownList ID="ddl_area" runat="server" ></asp:DropDownList>&nbsp; &nbsp;</li>
                
                </ContentTemplate>
            </asp:UpdatePanel>
    <li><asp:ImageButton ID="btn_chaxun" runat="server"   ImageUrl="~/image/zoom.png" OnClick="btn_chaxun_Click" /></li>
   
</ul>
            
      <div class="content-box-header">
        <h3>电影院表</h3>
        <ul class="content-box-tabs">
          <li><a href="#tab1" class="default-tab">Table</a></li>
          <!-- href must be unique and match the id of target div -->
         
        </ul>
        <div class="clear"></div>
      </div>
      <!-- End .content-box-header -->

   
       <asp:GridView ID="gv" CssClass="gv" Width="1000px" AutoPostBack="True"   runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateColumns="False" AllowPaging="True" PageSize="5" OnRowCommand="gv_RowCommand"   >

           <AlternatingRowStyle BackColor="White" />

           <Columns>
               <asp:TemplateField HeaderText="电影院名称"  ItemStyle-Width="15%">
                   <ItemTemplate>
                        <asp:Label runat="server" Text='<%#Eval("y_Name") %>'></asp:Label>
                   </ItemTemplate>

<ItemStyle Width="15%"></ItemStyle>
               </asp:TemplateField>
                <asp:TemplateField HeaderText="电影院地址" ItemStyle-Width="15%">
                   <ItemTemplate>
                        <asp:Label runat="server" Text='<%#Eval("y_address") %>'></asp:Label>
                   </ItemTemplate>

<ItemStyle Width="15%"></ItemStyle>
               </asp:TemplateField>
                <asp:TemplateField HeaderText="电影院所在的城市" ItemStyle-Width="10%">
                   <ItemTemplate>
                        <asp:Label runat="server" Text='<%#Eval("y_city") %>'></asp:Label>
                   </ItemTemplate>

<ItemStyle Width="10%"></ItemStyle>
               </asp:TemplateField>
                <asp:TemplateField HeaderText=" 电影院所在的地区" ItemStyle-Width="10%">
                   <ItemTemplate>
                        <asp:Label runat="server" Text='<%#Eval("y_area") %>'></asp:Label>
                   </ItemTemplate>

<ItemStyle Width="10%"></ItemStyle>
               </asp:TemplateField>
                <asp:TemplateField HeaderText="联系电话" ItemStyle-Width="15%">
                   <ItemTemplate>
                        <asp:Label runat="server" Text='<%#Eval("y_phone") %>'></asp:Label>
                   </ItemTemplate>

<ItemStyle Width="15%"></ItemStyle>
               </asp:TemplateField>
                 <asp:TemplateField HeaderText="电影院评分" ItemStyle-Width="10%">
                   <ItemTemplate>
                        <asp:Label runat="server" Text='<%#Eval("y_grade") %>'></asp:Label>
                   </ItemTemplate>

<ItemStyle Width="10%"></ItemStyle>
               </asp:TemplateField>
                 <asp:TemplateField HeaderText="操作">
                   <ItemTemplate>
                      <asp:ImageButton runat="server" CommandName="xiuGai" ImageUrl="~/resources/images/icons/pencil.png" CommandArgument='<%#Eval("y_id") %>' OnClick="Unnamed_Click"/>

               <asp:ImageButton runat="server" CommandName="xiuGai" ImageUrl="~/resources/images/icons/cross.png" CommandArgument='<%#Eval("y_id") %>' OnClick="Unnamed_Click1"/>
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
     
        
            
            </div>
              </div>
    </form>
</body>
</html>
