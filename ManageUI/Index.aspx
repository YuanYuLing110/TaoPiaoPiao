<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="ManageUI.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
 
<link rel="stylesheet" href="resources/css/reset.css" type="text/css" media="screen" />
<!-- Main Stylesheet -->
<link rel="stylesheet" href="resources/css/style.css" type="text/css" media="screen" />
<!-- Invalid Stylesheet. This makes stuff look pretty. Remove it if you want the CSS completely valid -->
<link rel="stylesheet" href="resources/css/invalid.css" type="text/css" media="screen" />
<!--                       Javascripts                       -->
<!-- jQuery -->
<script type="text/javascript" src="resources/scripts/jquery-1.3.2.min.js"></script>
<!-- jQuery Configuration -->
<script type="text/javascript" src="resources/scripts/simpla.jquery.configuration.js"></script>
<!-- Facebox jQuery Plugin -->
<%--<script type="text/javascript" src="resources/scripts/facebox.js"></script>
<!-- jQuery WYSIWYG Plugin -->
<script type="text/javascript" src="resources/scripts/jquery.wysiwyg.js"></script>
<!-- jQuery Datepicker Plugin -->
<script type="text/javascript" src="resources/scripts/jquery.datePicker.js"></script>
<script type="text/javascript" src="resources/scripts/jquery.date.js"></script>--%>

  <%--  <script src="resources/scripts/myJS.js"></script>--%>
</head>
<body>
    <form id="form1" runat="server">
    <div id="body-wrapper">
  <!-- Wrapper for the radial gradient background -->
  <div id="sidebar" runat="server">
    <div id="sidebar-wrapper" >
      <!-- Sidebar with logo and menu -->
      <h1 id="sidebar-title"><a href="#">淘票票后台管理系统</a></h1>
      <!-- Logo (221px wide) -->
      <a href="#"><img id="logo" src="resources/images/logo.png" width="200px" alt="Simpla Admin logo" /></a>
      <!-- Sidebar Profile links -->
      
      <div id="profile-links"> 你好,   <asp:LinkButton runat="server" ID="name" OnClick="name_Click"></asp:LinkButton>,<asp:Label runat="server" ID="manage"></asp:Label>  管理者<br />
        <br />
        <a href="#" title="View the Site">编辑</a> | <a href="#" title="Sign Out">退出</a> </div>
      <ul id="main-nav">
        <!-- Accordion Menu -->
        <li> <a href="main.htm"  target="main" class="SY current main-item " >
       
          首页</a> 
           
        </li>
        <li runat="server" id="Li_Manage"> <a href="#" class=" nav-top-item main-item ">
          电影院管理 </a>
          <ul>
            <li><a href="SuperManage/DianYingYuan.aspx" target="main" id="aaa1" class="current lili">编辑</a></li>
   
          </ul>
        </li>
        <li runat="server" id="li_DianYingTing"> <a  class="nav-top-item main-item" >电影厅管理</a>
          <ul>
            <li><a href="#" class="lili">新建电影厅</a></li>
            <li><a href="DianYingTing/DianYingTingFrm.aspx" target="main" class="lili">管理电影厅</a></li>
          </ul>
        </li>
        <li runat="server" id="li_Movie"> <a href="#" class="nav-top-item main-item"> 电影管理 </a>
          <ul>
            <li><a href="#" class="lili">上传电影</a></li>
            <li><a href="#" class="lili">管理电影</a></li>
           
          </ul>
        </li>
        <li runat="server" id="li_pianChang"> <a href="#" class="nav-top-item main-item"> 电影片场 </a>
          <ul>
            <li><a href="#" class="lili">创建片场</a></li>
            <li><a href="#" class="lili">管理片场</a></li>
          
          </ul>
        </li>
      
            <li runat="server" id="Li_Manager"> 
                <a href="#" class="nav-top-item main-item"> 电影院管理员管理 </a>
          <ul>
            <li><a href="#" class="lili">添加管理员</a></li>
            <li><a href="#" class="lili">编辑管理员</a></li>
          
          </ul>
        </li>
             <li runat="server" id="Li1"> 
                <a href="#" class="nav-top-item main-item"> 个人主页 </a>
         
        </li>
      </ul>
    
    </div>
  </div>
  <!-- End #sidebar -->
       <iframe  name="main" runat="server" class="iframe1" src="main.htm" id="iframe" style="width:100%;height:630px;background-color:gray;margin-left:250px;   overflow-x:hidden"></iframe>

  <!-- End #main-content -->
</div>
    </form>
</body>
</html>
