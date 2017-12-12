<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="ManageUI.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <!--                       CSS                       -->
<!-- Reset Stylesheet -->
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
<script type="text/javascript" src="resources/scripts/facebox.js"></script>
<!-- jQuery WYSIWYG Plugin -->
<script type="text/javascript" src="resources/scripts/jquery.wysiwyg.js"></script>
<!-- jQuery Datepicker Plugin -->
<script type="text/javascript" src="resources/scripts/jquery.datePicker.js"></script>
<script type="text/javascript" src="resources/scripts/jquery.date.js"></script>
    <script type="text/javascript"  "><!-- 

window.onload=function() 
{ 
parent.document.all("iframe1").style.height = document.body.scrollHeight; 
parent.document.all("iframe1").style.width = document.body.scrollWidth; 
} 
// --></script>
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
        <li> <a href="main.htm" class="nav-top-item current" target="main">
       
          首页</a> </li>
        <li> <a href="#" class="nav-top-item ">
          电影院管理 </a>
          <ul>
            <li><a href="ManageFrm.aspx" target="main">编辑</a></li>
   
          </ul>
        </li>
        <li> <a href="#" class="nav-top-item">电影厅管理</a>
          <ul>
            <li><a href="#">新建电影厅</a></li>
            <li><a href="#">管理电影厅</a></li>
          </ul>
        </li>
        <li> <a href="#" class="nav-top-item"> 电影管理 </a>
          <ul>
            <li><a href="#">上传电影</a></li>
            <li><a href="#">管理电影</a></li>
           
          </ul>
        </li>
        <li> <a href="#" class="nav-top-item"> 电影片场 </a>
          <ul>
            <li><a href="#">创建片场</a></li>
            <li><a href="#">管理片场</a></li>
          
          </ul>
        </li>
      
      </ul>
     <%-- <!-- End #main-nav -->
      <div id="messages" style="display: none">
        <!-- Messages are shown when a link with these attributes are clicked: href="#messages" rel="modal"  -->
        <h3>3 Messages</h3>
        <p> <strong>17th May 2009</strong> by Admin<br />
          Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus magna. Cras in mi at felis aliquet congue. <small><a href="#" class="remove-link" title="Remove message">Remove</a></small> </p>
        <p> <strong>2nd May 2009</strong> by Jane Doe<br />
          Ut a est eget ligula molestie gravida. Curabitur massa. Donec eleifend, libero at sagittis mollis, tellus est malesuada tellus, at luctus turpis elit sit amet quam. Vivamus pretium ornare est. <small><a href="#" class="remove-link" title="Remove message">Remove</a></small> </p>
        <p> <strong>25th April 2009</strong> by Admin<br />
          Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus magna. Cras in mi at felis aliquet congue. <small><a href="#" class="remove-link" title="Remove message">Remove</a></small> </p>
        <form action="#" method="post">
          <h4>New Message</h4>
          <fieldset>
          <textarea class="textarea" name="textfield" cols="79" rows="5"></textarea>
          </fieldset>
          <fieldset>
          <select name="dropdown" class="small-input">
            <option value="option1">Send to...</option>
            <option value="option2">Everyone</option>
            <option value="option3">Admin</option>
            <option value="option4">Jane Doe</option>
          </select>
          <input class="button" type="submit" value="Send" />
          </fieldset>
        </form>
      </div>
      <!-- End #messages -->--%>
    </div>
  </div>
  <!-- End #sidebar -->
       <iframe  name="main" runat="server" class="iframe1" src="main.htm" id="iframe" style="width:100%;height:630px;background-color:gray;margin-left:250px"></iframe>

  <!-- End #main-content -->
</div>
    </form>
</body>
</html>
