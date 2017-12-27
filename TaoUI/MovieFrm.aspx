<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="MovieFrm.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="CSS/---pages-movie-index.less.css,mods-card-moviecard.less.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <script>$(document).ready(function () {
    $('.nav').children().removeClass("current");
    $('#movie').addClass("current");

    $(".tab-control-item").click( // When a top menu item is clicked...
     function () {

         $(this).parents('.tab-control').children().removeClass("current");
         //$(this).addClass("current").parent.siblings().children().removeClass("current");
         $(this).addClass("current");
         if ($("#fucture").hasClass("current")) {
             $("#ContentPlaceHolder1_list_hot").css("display", "none");
             $("#ContentPlaceHolder1_list_future").css("display", "block");
         }
         if ($("#Hot").hasClass("current")) {
             $("#ContentPlaceHolder1_list_hot").css("display", "block");
             $("#ContentPlaceHolder1_list_future").css("display", "none");
         }

     }
 );
});</script>

    
<div class="center-wrap movie-path" data-spm="w1">
	<div class="path"><a href="index.htm-n_s=new.htm" tppabs="https://dianying.taobao.com/index.htm?n_s=new">首页</a> > <a href="showList.htm-n_s=new.htm" tppabs="https://dianying.taobao.com/showList.htm?n_s=new">影片</a> > 西安</div>
	<div class="steps"><span>3步轻松购票:1.选座购票/买券</span><i></i><span>2.收电子码</span><i></i><span>3.影院取票</span></div>
</div>
<div class="center-wrap">
	<div class="left-wrap" data-spm="w2">
			<div class="tab-control tab-movie-tit">
				<a class="tab-control-item" href="#" id="Hot"> 正在热映 </a>
				<a class="tab-control-item" href="#" id="fucture">即将上映</a>
		        <!--a class="more" href="#">查看全部&nbsp;&gt;</a-->
			</div>
			<div class="tab-content " >
				<!-- 正在热映 -->
             
                <div class="tab-movie-list " id="list_hot" runat="server" style="display:block">

                </div>
       <!-- 即将热映 -->
        		<div class="tab-movie-list" id="list_future" runat="server" >
                          
        		</div>
        		


			</div>
	</div>
	<div class="right-wrap" data-spm="w3">
		<!-- 常去的影院 -->
        <div class="movie-freqlist">
    <h5><span> 热门影院 </span><a href="cinemaList.htm-n_s=new.htm" tppabs="https://dianying.taobao.com/cinemaList.htm?n_s=new" class="more">查看全部影院&nbsp;&gt;</a></h5>
    <ul class="freqlist M-freqlist">
		        <li class="current">
            <span class="name" id="name1" runat="server"></span>
                        <span class="address" id="address1" runat="server"></span>
            <span class="buynow"><a href="cinemaDetail.htm-cinemaId=31104&n_s=new.htm" tppabs="https://dianying.taobao.com/cinemaDetail.htm?cinemaId=31104&n_s=new">选座购票</a></span>
        </li>
                <li class="current">
            <span class="name" id="name2" runat="server"></span>
                        <span class="address" id="address2" runat="server"></span>
            <span class="buynow"><a href="cinemaDetail.htm-cinemaId=24066&n_s=new.htm" tppabs="https://dianying.taobao.com/cinemaDetail.htm?cinemaId=24066&n_s=new">选座购票</a></span>
        </li>
            </ul>
</div>
        
	</div>
</div>
</asp:Content>

