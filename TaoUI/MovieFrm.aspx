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

                       <div class="movie-card-wrap">
    			    			<a href="showDetail.htm-showId=214258&n_s=new&source=current.htm" tppabs="https://dianying.taobao.com/showDetail.htm?showId=214258&n_s=new&source=current" class="movie-card">
                    <div class="movie-card-tag"><i class="t-202"></i></div>
                    <div class="movie-card-poster">
						                        <img width="160" height="224" data-src="TB1xsowaG_85uJjSZFlXXXemXXa_.jpg_160x240.jpg" tppabs="https://img.alicdn.com/bao/uploaded/i2/TB1xsowaG_85uJjSZFlXXXemXXa_.jpg_160x240.jpg" src="TB1xsowaG_85uJjSZFlXXXemXXa_.jpg_160x240.jpg" tppabs="https://img.alicdn.com/bao/uploaded/i2/TB1xsowaG_85uJjSZFlXXXemXXa_.jpg_160x240.jpg">
                    </div>
                    <div class="movie-card-name">
                        <span class="bt-l">寻梦环游记</span>
                        <span class="bt-r">9.5</span>
                    </div>
                    <div class="movie-card-info">
                        <div class="movie-card-mask"></div>
                        <div class="movie-card-list">
                            <span>导演：李&middot;昂克里奇</span>
                            <span>主演：本杰明&middot;布拉特,盖尔&middot;加西亚&middot;贝纳尔,芮妮&middot;维克托</span>
                            <span>类型：动画,冒险,动作</span>
                            <span>地区：美国</span>
                            <span>语言：英语</span>
                            <span>片长：105分钟</span>                        </div>
                    </div>
                </a>
                <a href="showDetail.htm-showId=214258&n_s=new.htm" tppabs="https://dianying.taobao.com/showDetail.htm?showId=214258&n_s=new" class="movie-card-buy">选座购票</a>
    		</div>
                </div>
       <!-- 即将热映 -->
        		<div class="tab-movie-list" id="list_future" runat="server" >
                           <div class="movie-card-wrap">
                    			<a href="showDetail.htm-showId=217762&n_s=new&source=soon.htm" tppabs="https://dianying.taobao.com/showDetail.htm?showId=217762&n_s=new&source=soon" class="movie-card">
                    <div class="movie-card-tag"><i class="t-"></i></div>
                    <div class="movie-card-poster">
						                        <img width="160" height="224"src="TB1SCZMfTnI8KJjy0FfXXcdoVXa_.jpg_160x240.jpg" tppabs="https://img.alicdn.com/bao/uploaded/i2/TB1SCZMfTnI8KJjy0FfXXcdoVXa_.jpg_160x240.jpg">
                    </div>
                    <div class="movie-card-name">
                        <span class="bt-l">假如王子睡着了</span>
                        <span class="bt-r"></span>
                    </div>
                    <div class="movie-card-info">
                        <div class="movie-card-mask"></div>
                        <div class="movie-card-list">
                            <span>导演：王郢</span>
                            <span>主演：陈柏霖,林允,张云龙</span>
                            <span>类型：爱情,喜剧</span>
                            <span>地区：中国大陆</span>
                            <span>语言：汉语普通话</span>
                            <span>片长：101</span>
                        </div>
                    </div>
                </a>
    			<a href="showDetail.htm-showId=217762&n_s=new&source=soon.htm" tppabs="https://dianying.taobao.com/showDetail.htm?showId=217762&n_s=new&source=soon" class="movie-card-soon">上映时间2017-12-08</a> 
    	 </div>
        		</div>
        		


			</div>
	</div>
	<div class="right-wrap" data-spm="w3">
		<!-- 常去的影院 -->
        <div class="movie-freqlist">
    <h5><span> 热门影院 </span><a href="cinemaList.htm-n_s=new.htm" tppabs="https://dianying.taobao.com/cinemaList.htm?n_s=new" class="more">查看全部影院&nbsp;&gt;</a></h5>
    <ul class="freqlist M-freqlist">
		        <li class="current">
            <span class="name">时代华纳国际影城（洪庆店）</span>
                        <span class="address">灞桥区洪庆街北段800号</span>
            <span class="buynow"><a href="cinemaDetail.htm-cinemaId=31104&n_s=new.htm" tppabs="https://dianying.taobao.com/cinemaDetail.htm?cinemaId=31104&n_s=new">选座购票</a></span>
        </li>
                <li class="current">
            <span class="name">金逸影城（光美西安澳堡店）</span>
                        <span class="address">长安区西长安街555号，澳堡时代广场6F</span>
            <span class="buynow"><a href="cinemaDetail.htm-cinemaId=24066&n_s=new.htm" tppabs="https://dianying.taobao.com/cinemaDetail.htm?cinemaId=24066&n_s=new">选座购票</a></span>
        </li>
            </ul>
</div>
        
	</div>
</div>
</asp:Content>

