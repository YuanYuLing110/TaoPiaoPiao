<%@ Page Title="" Language="C#" MasterPageFile="~/Template.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="TaoPiaoPiao.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="CSS/index.less.css" rel="stylesheet" />
  <%--  <script src="JS/jquery-2.2.0.js"></script>
    <script src="JS/MyJuery.js"></script>--%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%-- <asp:ScriptManager runat="server"></asp:ScriptManager>--%>
    
     <script type="text/javascript">
        
       
    </script>
    <style type="text/css">
        .otherMonthDay {
           visibility:hidden
        }

        .tc {
            color:red;
        }
        .mxz {
            color:Gray;
        }

        #head {
            height:200px;
            width:100%;
           
            font-family:YouYuan;
            position:absolute;
            top:200px;
            left:350px;
            color:#adb9ba;
            font-size:50px;
            z-index:1;
        }
        .banner-wrap { position: relative; display: inline-block; height: 400px; width: 100%; background: #333; overflow: hidden; }
        .banner-scrollable { position: absolute; bottom: 10px; left: 50%; display: none; }
        .banner-scrollable li { float: left; list-style-type: none; }
        .banner-scrollable li a { display: inline-block; width: 10px; height: 10px; background: #FFF; color: #FFF; margin-left: 8px; overflow: hidden; }
        .banner-scrollable li.current a { display: inline-block; width: 10px; height: 10px; background: #fff; color: #fff; margin-left: 8px; overflow: hidden; }
        .banner-item { height: 360px; width: 100%; }
        .banner-item a { display: block; height: 360px; width: 100%; background-position: center center; background-repeat: no-repeat; text-align: center; }
        .bannerControl { position: absolute; top: 120px; width: 48px; height: 68px; background: url("TB1CjQ_FVXXXXbgXXXXc98EUXXX-48-200.png")/*tpa=https://gw.alicdn.com/tps/i2/TB1CjQ_FVXXXXbgXXXXc98EUXXX-48-200.png*/ no-repeat; display: none; }
        .M-BannerLeft { left: 15%; }
        .M-BannerRight { right: 15%; background-position: 0px -132px; }
    </style>
      <div id="head">
        <label>淘你所想，看你想看</label>
    </div>
    <div id="M-banner" class="banner-wrap">
     
        <iframe width="100%" height="100%" src="index.html" ></iframe>
    </div>
  
    
<div class="center-wrap" data-spm="w2">
	<div class="tab-control tab-movie-tit">
		<a class="tab-control-item current" href="#" id="Hot" style="display:block">正在热映(48)</a>
		<a class="tab-control-item" href="#" id="fucture">即将上映(432)</a>
        <a class="more" href="showList.htm-n_s=new.htm" tppabs="https://dianying.taobao.com/showList.htm?n_s=new">查看全部&nbsp;&gt;</a>
	</div>
	<div class="tab-content "  >
		<!-- 正在热映 -->
		<div class="tab-movie-list " id="list_Hot" runat="server"  >
	    	    	
			</div>

		<!-- 即将热映 -->
		<div class="tab-movie-list" id="list_future" runat="server">
	    	        
    	 	</div>

	</div>
</div>
<div class="process-wrap"></div>
<div class="center-wrap">
    <div class="home-toplist">
		<!-- 上周票房排行 -->
		<div class="home-toplist-item">
			<div class="movie-weeklist" data-spm="t1">
    <h5><span>上周票房排行</span><a href="showList.htm-n_s=new.htm" tppabs="https://dianying.taobao.com/showList.htm?n_s=new" class="more">全部影片&nbsp;&gt;</a></h5>
    <ul class="weeklist M-weeklist" id="weeklist" runat="server">
				 
			
				    </ul>
</div>
		</div>
        <!-- 热门影院 -->
		<div class="home-toplist-item">
			<div class="movie-cinemalist title-wrap" data-spm="t2">
    <h5><span>热门影院排行</span><a href="cinemaList.htm-&n_s=new.htm" tppabs="https://dianying.taobao.com/cinemaList.htm?&n_s=new" class="more">全部影院&nbsp;&gt;</a></h5>
	    <ul class="cinemalist M-cinemalist" id="cinemalist" runat="server">
		    </ul>
	</div>

		</div>

		<!-- 热销团购 -->
		<div class="home-toplist-item">
			<div class="movie-custlist title-wrap" data-spm="t3">
   <div>
    <iframe frameborder="no" border="0" marginwidth="0" marginheight="0" width="300" height="431" src="embed-player-pc.html-type=selection&id=113117941&auto=0&res=300x400&theme=light" tppabs="https://h.xiami.com/embed-player-pc.html?type=selection&id=113117941&auto=0&res=300x400&theme=light">
    </iframe>
  </div>
</div>

		</div>
    </div>
</div>
<div class="center-wrap">

 <!--首页替换掉movie-guide -->
 <div class='movie-guide' data-spm="w6">
        <h3 class='movie-guide-info'>新片观影指南</h3>
    <%--    <div class='movie-calender'>
            <div class='movie-calender-header'>
                <div class='movie-calender-month'>
                    <em class='movie-ctrl-prev M-head-prev'>&#60;</em>
                    <span class='movie-ctrl-show M-head-show'></span>
                    <em class='movie-ctrl-next M-head-next'>&#62;</em>
                </div>
                <ul class='movie-calender-week'>
					<li>周日</li>
                    <li>周一</li>
                    <li>周二</li>
                    <li>周三</li>
                    <li>周四</li>
                    <li>周五</li>
                    <li>周六</li>
                </ul>
            </div>
            <ul class='movie-calender-main M-calender-main'>
            </ul>
        </div>--%>
   <%--  <asp:UpdatePanel runat="server">
         <ContentTemplate>--%>
     <asp:Calendar ID="Calendar1"    format="yyyy-mm-dd"   runat="server" OnDayRender="Calendar1_DayRender" onvisiblemonthchanged="Calendar1_VisibleMonthChanged" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="16px" ForeColor="Black" Height="300px" Width="400px" >
         <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
         <NextPrevStyle VerticalAlign="Bottom" />
         <OtherMonthDayStyle CssClass="otherMonthDay" ForeColor="#808080" />
         <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
         <SelectorStyle BackColor="#CCCCCC" />
         <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
         <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
         <WeekendDayStyle BackColor="#FFFFCC" />
        </asp:Calendar>
          <%--   </ContentTemplate>
</asp:UpdatePanel>--%>
        <div class='movie-post M-post'>

            <div class='movie-post-main'>
                 <a target="_blank" href="#">
                     <img class='movie-post-img M-post-img' src="">
                    <div class='movie-post-mask'></div>
                    <ul class='movie-post-mask-list M-post-mask-list'>
                    </ul>
                    <h3 class='movie-post-mask-info M-post-mask-info'>
                        <span class='movie-name '></span>
                        <span class='movie-rank'>&#9733;&#9733;&#9733;&#9733;&#9733;<i class='M-post-rank'>&#9733;&#9733;&#9733;&#9733;&#9733;</i></span>
                    </h3>
                </a>
            </div>
            <div class='movie-post-footer'>
                <em class='prev M-post-prev'>&#60;</em>
                <span class='day-info M-post-day-info'></span>
                <em class='next M-post-next'>&#62;</em>
            </div>
        </div>
    </div>

	<!-- 热门预告片 -->
	<div class='movie-recent' data-spm="w7">
    <h3 class='movie-guide-info'>热门预告片</h3>
	    <ul class='movie-recent-ul'>
					    			<li class='movie-recent-item'>
    				<a href="showDetail.htm-showId=214258&n_s=new.htm" tppabs="https://dianying.taobao.com/showDetail.htm?showId=214258&n_s=new">
    					<img width="140" height="80" class='movie-recent-item-post' src="TB14gTFeRDH8KJjSspnXXbNAVXa_.jpg_200x200.jpg" tppabs="https://img.alicdn.com/bao/uploaded/i4/TB14gTFeRDH8KJjSspnXXbNAVXa_.jpg_200x200.jpg">
    						<img class='movie-video-icon' src="T1IKtlFfpgXXbKu7Ha-22-22.png" tppabs="https://img.alicdn.com/tps/i2/T1IKtlFfpgXXbKu7Ha-22-22.png"><p>寻梦环游记</p>
    				</a>
    			</li>
												    			<li class='movie-recent-item'>
    				<a href="showDetail.htm-showId=230528&n_s=new.htm" tppabs="https://dianying.taobao.com/showDetail.htm?showId=230528&n_s=new">
    					<img width="140" height="80" class='movie-recent-item-post' src="taobao-movie1.svg" tppabs="http://g.alicdn.com/alipay-movie-client/movie-cdn/svgfiles/taobao-movie1.svg">
    						<img class='movie-video-icon' src="T1IKtlFfpgXXbKu7Ha-22-22.png" tppabs="https://img.alicdn.com/tps/i2/T1IKtlFfpgXXbKu7Ha-22-22.png"><p>烟花</p>
    				</a>
    			</li>
												    			<li class='movie-recent-item'>
    				<a href="showDetail.htm-showId=168600&n_s=new.htm" tppabs="https://dianying.taobao.com/showDetail.htm?showId=168600&n_s=new">
    					<img width="140" height="80" class='movie-recent-item-post' src="TB1kLvedlTH8KJjy0FiXXcRsXXa_.jpg_200x200.jpg" tppabs="https://img.alicdn.com/bao/uploaded/i2/TB1kLvedlTH8KJjy0FiXXcRsXXa_.jpg_200x200.jpg">
    						<img class='movie-video-icon' src="T1IKtlFfpgXXbKu7Ha-22-22.png" tppabs="https://img.alicdn.com/tps/i2/T1IKtlFfpgXXbKu7Ha-22-22.png"><p>正义联盟</p>
    				</a>
    			</li>
												    			<li class='movie-recent-item'>
    				<a href="showDetail.htm-showId=225197&n_s=new.htm" tppabs="https://dianying.taobao.com/showDetail.htm?showId=225197&n_s=new">
    					<img width="140" height="80" class='movie-recent-item-post' src="taobao-movie1.svg" tppabs="http://g.alicdn.com/alipay-movie-client/movie-cdn/svgfiles/taobao-movie1.svg">
    						<img class='movie-video-icon' src="T1IKtlFfpgXXbKu7Ha-22-22.png" tppabs="https://img.alicdn.com/tps/i2/T1IKtlFfpgXXbKu7Ha-22-22.png"><p>至暗时刻</p>
    				</a>
    			</li>
												    			<li class='movie-recent-item'>
    				<a href="showDetail.htm-showId=216311&n_s=new.htm" tppabs="https://dianying.taobao.com/showDetail.htm?showId=216311&n_s=new">
    					<img width="140" height="80" class='movie-recent-item-post' src="taobao-movie1.svg" tppabs="http://g.alicdn.com/alipay-movie-client/movie-cdn/svgfiles/taobao-movie1.svg">
    						<img class='movie-video-icon' src="T1IKtlFfpgXXbKu7Ha-22-22.png" tppabs="https://img.alicdn.com/tps/i2/T1IKtlFfpgXXbKu7Ha-22-22.png"><p>鲨海</p>
    				</a>
    			</li>
									    </ul>
	</div>
</div>
	        
	


</asp:Content>
