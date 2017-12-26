<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
      <link href="CSS/index.less.css" rel="stylesheet" />
    <link href="CSS/calender.less.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <script>$(document).ready(function () {
    $(".tab-control-item").click( // When a top menu item is clicked...
        function () {

            $(this).parents('.tab-control').children().removeClass("current");
            //$(this).addClass("current").parent.siblings().children().removeClass("current");
            $(this).addClass("current");
            if ($("#fucture").hasClass("current")) {
                $("#ContentPlaceHolder1_list_Hot").css("display", "none");
                $("#ContentPlaceHolder1_list_future").css("display", "block");
            }
            if ($("#Hot").hasClass("current")) {
                $("#ContentPlaceHolder1_list_Hot").css("display", "block");
                $("#ContentPlaceHolder1_list_future").css("display", "none");
            }

        }
    );

});</script>
      <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
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
          #ContentPlaceHolder1_next {
              display:inline;
              float:left;
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
		<a class="tab-control-item current" href="#" id="Hot" style="display:block">正在热映(<asp:Label runat="server" ID="hotNum"></asp:Label>)</a>
		<a class="tab-control-item" href="#" id="fucture">即将上映(<asp:Label runat="server" ID="wlNum"></asp:Label>)</a>
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
		<div class="home-toplist-item" style="width:400px;margin-right:100px;">
			<div class="movie-weeklist" data-spm="t1">
    <h5><span>上周票房排行</span><a href="showList.htm-n_s=new.htm" tppabs="https://dianying.taobao.com/showList.htm?n_s=new" class="more">全部影片&nbsp;&gt;</a></h5>
    <ul class="weeklist M-weeklist" id="weeklist" runat="server">
				 
			
				    </ul>
</div>
		</div>
        <!-- 热门影院 -->
		<div class="home-toplist-item" style="width:400px">
			<div class="movie-cinemalist title-wrap" data-spm="t2">
    <h5><span>热门影院排行</span><a href="cinemaList.htm-&n_s=new.htm" tppabs="https://dianying.taobao.com/cinemaList.htm?&n_s=new" class="more">全部影院&nbsp;&gt;</a></h5>
	    <ul class="cinemalist M-cinemalist" id="cinemalist" runat="server">
		    </ul>
	</div>

		</div>


    </div>
</div>
<div class="center-wrap">

 <!--首页替换掉movie-guide -->
 <div class='movie-guide' data-spm="w6">
        <h3 class='movie-guide-info'>新片观影指南</h3>
    
 
     <asp:UpdatePanel ID="UpdatePanel1" runat="server">
         <ContentTemplate>
           
       
           <div class='movie-calender' style="opacity:1" >
             <asp:Calendar ID="Calendar1"    format="yyyy-mm-dd"   runat="server" OnDayRender="Calendar1_DayRender" onvisiblemonthchanged="Calendar1_VisibleMonthChanged" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="16px" ForeColor="Black" Height="300px" Width="400px" OnSelectionChanged="Calendar1_SelectionChanged"  >
         <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
         <NextPrevStyle VerticalAlign="Bottom" />
         <OtherMonthDayStyle CssClass="otherMonthDay" ForeColor="#808080" />
         <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
         <SelectorStyle BackColor="#CCCCCC" />
         <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
         <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
         <WeekendDayStyle BackColor="#FFFFCC" />
        </asp:Calendar>
        </div>

   
 
              <div class='movie-post M-post' id="movie_post" style="opacity:1" runat="server">

      
            <div class='movie-post-footer'>
              <%--  <em CssClass="prev M-post-prev" ></em>
                 <asp:Button runat="server" CssClass="prev M-post-prev" ID="prev" OnClick="prev_Click" Text="<" />--%>
                <span class='day-info M-post-day-info' runat="server" id="time_info"></span>
              <%--  <asp:Button runat="server" CssClass="next M-post-prev" ID="next" OnClick="prev_Click" Text=">" />    --%>       
            </div>
        </div>
           </ContentTemplate>
     </asp:UpdatePanel>      
   
    
    </div>

	
</div>
       
              
         
</asp:Content>

