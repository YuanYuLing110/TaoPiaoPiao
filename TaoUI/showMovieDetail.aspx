<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="showMovieDetail.aspx.cs" Inherits="showMovieDetail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
      <link href="CSS/--pages-movie_detail-index.less.css,mods-list-title.less.css,mods-list-filter.less.css,mods-list-hall.less.css,mods-list-custtop.less.css,pages-movie_detail-comment.less.css" rel="stylesheet" />
  
   <style>

       .btnBefore {
           width:50px;
           height:25px;
           margin-left:22px;
           margin-top:2px;
           color:#4f4f4f;
           background-color:rgba(0, 0, 0, 0.00);
       }

        .btnBefore2 {
         
           height:25px;
           margin-left:22px;
           margin-top:2px;
           color:#4f4f4f;
           background-color:rgba(0, 0, 0, 0.00);
       }
           .btnBefore:hover {
               background-color:#f42429;
               color:#fff;
             
           }
         
       .current2 {
             background-color:#f42429;
               color:#fff;
                margin-left:24px;
           margin-top:2px;
       }

   </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <script>
         $(document).ready(function () {
             $('.nav').children().removeClass("current");
             $('#movie').addClass("current");
             //$('.btnBefore').click(function () {
             //    alert("aaaaaa");
             //    $(this).addClass("current2");
             //})
         });</script> 
    <link rel="stylesheet" href="https://g.alicdn.com/life/pc-movie/1.0.34/??pages/movie_detail/index.less.css,mods/list/title.less.css,mods/list/filter.less.css,mods/list/hall.less.css,mods/list/custtop.less.css,pages/movie_detail/comment.less.css">
<div class="detail-wrap J_detailWrap" data-spm="w1">
	<div class="detail-bg J_detailBg" data-bg="https://img.alicdn.com/bao/uploaded/i2/TB1u78.iv6H8KJjy0FjXXaXepXa_.jpg_60x60.jpg"></div>


	<div class="detail-cont">
		<div class="center-wrap">
			<h3 class="cont-title" runat="server" id="title">  <em class="score" runat="server" id="score"></em></h3>
			<div class="cont-pic" id="div_img" runat="server">
				<%--<img with="230" heigh="300" src="#" alt="">--%>
              <%--  <asp:Image ID="img1" runat="server"with="230" heigh="300" />--%>
			</div>
			<ul class="cont-info">
								<li id="direct" runat="server"></li>
                				<li id="star" runat="server"></li>	
                			<li id="type" runat="server"></li>		
                		<li id="state" runat="server"></li>		
                		<li id="voice" runat="server"></li>		
                		<li runat="server" id="minute"></li>		
                		<li runat="server" id="detail"></li>			</ul>
			<div class="cont-time" id="time" runat="server"></div>
			<div class="cont-view">
									<a href="javascript:;" data-showId="154601" data-type='image' class="float-layer-hook"><img src="https://img.alicdn.com/bao/uploaded/i3/TB1W1qNLpXXXXX4aXXXXXXXXXXX_.jpg_160x160.jpg" alt=""><span>20</span></a>
													<a href="javascript:;" data-showId="154601" data-type='video' class="float-layer-hook"><img src="http://img02.taobaocdn.com/bao/uploaded/TB1_Yaoiv6H8KJjSspmXXb2WXXa.jpg_100x100.jpg"  width="160" height="110" alt=""><s></s><span>10</span></a>
							</div>
           <%-- class="J_shrink shrink"--%>
		</div>			
	</div>
</div>

<div class="title-wrap">
	<div class="center-wrap">
		<h3>选座购票</h3>
	</div>
</div>
   <%-- <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>--%>
   
            <div class="schedule-wrap J_scheduleWrap schedule-loaded" data-spm="w2" data-spm-max-idx="37" data-param="showId=211693&amp;ts=1514367621331&amp;n_s=new" data-ajax="/showDetailSchedule.htm">
<!-- Filter -->
	<div class="filter-wrap">
		<div class="center-wrap">
			<ul class="filter-select">
				<li>
					
                <%--     <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
        <ContentTemplate>--%>
            <label>选择区域</label>
					<div class="select-tags" id="select_tags" runat="server">
					
                        					</div>
    
				</li>
				<li>
					
   <%-- <asp:UpdatePanel ID="UpdatePanel2" runat="server" UpdateMode="Conditional">--%>
      <%--  <Triggers>        
        <asp:PostBackTrigger ControlID="select_tags" />
    </Triggers>--%>

       <%-- <ContentTemplate>--%>
            <label>选择影城</label>
					<div class="select-tags" id="select_dyy" runat="server">	</div>

<%--			             </ContentTemplate>
    </asp:UpdatePanel>	--%>
                    	</li>	
                	<li>
					<label>选择时间</label>
					<div class="select-tags" id="select_time" runat="server">
											
                        					</div>
				</li>
       <%--                         </ContentTemplate>
    </asp:UpdatePanel>		--%>          								
							                        				
				
			
			</ul>
		</div>
	</div>
	<!-- Cinema bar -->
	<div class="center-wrap cinemabar-wrap">
		<h4 ><asp:label ID="y_name" runat="server"></asp:label></h4>
	<asp:Label ID="y_address" runat="server"></asp:Label>	
        <%-- <a href="/cinemaDetail.htm?cinemaId=46017&amp;n_s=new#detail">[地图]</a>  --%>
       <asp:HyperLink ID="hl"  runat="server">[地图]</asp:HyperLink>
        <asp:Label ID="y_num" runat="server"></asp:Label>
        <asp:HyperLink ID="y_detail" runat="server">查看影院详情&nbsp;&gt;</asp:HyperLink>
			<%--	<a class="more" href="/cinemaDetail.htm?cinemaId=46017&amp;n_s=new"></a>--%>
			</div>

	<!-- Hall Tabel -->
	<div class="center-wrap">
				<table class="hall-table">
			<thead>
				<tr>
				    <th class="hall-time">放映时间</th>
				    <th class="hall-type">语言版本</th>
				    <th class="hall-name">放映厅</th>
				    <th class="hall-flow">座位情况</th>
				    <th class="hall-price">现价/影院价（元）</th>
				    <th class="hall-buy">选座购票</th>
				</tr>
			</thead>
			<tbody>
				
									
				  <tr>
					<td class="hall-time">
						<em class="bold">18:00</em>
						 预计20:16散场 					</td>
					<td class="hall-type">
						国语 2D
					</td>
					<td class="hall-name">
						2号激光厅
					</td>
										
					<td class="hall-flow">
						<div class="flowing-wrap flowing-loose">
							<label> 宽松  </label>
							<span class="flowing-vol"><i style="width: 0%;"></i></span>
							<span class="flowing-view J_flowingView" data-scheduleid="477479593">
								    								<i class="icon-zoom"></i>
    								<div class="view-wrap" style="display: none;">
    									<div class="view-box">加载中...</div>
    								</div>
															</span>
						</div>
					</td>
										<td class="hall-price" data-partcode="dingxinnew">
						<em class="now">28.00</em>
						<del class="old">60.00</del>
											</td>
					<td class="hall-seat">
													<a class="seat-btn" href="https://www.taopiaopiao.com/seatOrder.htm?scheduleId=477479593&amp;n_s=new">选座购票</a>
											</td>
				</tr>
									
				  <tr class="even">
					<td class="hall-time">
						<em class="bold">18:50</em>
						 预计21:06散场 					</td>
					<td class="hall-type">
						国语 2D
					</td>
					<td class="hall-name">
						4号激光厅
					</td>
										
					<td class="hall-flow">
						<div class="flowing-wrap flowing-loose">
							<label> 宽松  </label>
							<span class="flowing-vol"><i style="width: 0%;"></i></span>
							<span class="flowing-view J_flowingView" data-scheduleid="477479592">
								    								<i class="icon-zoom"></i>
    								<div class="view-wrap" style="display: none;">
    									<div class="view-box">加载中...</div>
    								</div>
															</span>
						</div>
					</td>
										<td class="hall-price" data-partcode="dingxinnew">
						<em class="now">28.00</em>
						<del class="old">60.00</del>
											</td>
					<td class="hall-seat">
													<a class="seat-btn" href="https://www.taopiaopiao.com/seatOrder.htm?scheduleId=477479592&amp;n_s=new">选座购票</a>
											</td>
				</tr>
									
				  <tr>
					<td class="hall-time">
						<em class="bold">20:30</em>
						 预计22:46散场 					</td>
					<td class="hall-type">
						国语 2D
					</td>
					<td class="hall-name">
						2号激光厅
					</td>
										
					<td class="hall-flow">
						<div class="flowing-wrap flowing-loose">
							<label> 宽松  </label>
							<span class="flowing-vol"><i style="width: 0%;"></i></span>
							<span class="flowing-view J_flowingView" data-scheduleid="477479591">
								    								<i class="icon-zoom"></i>
    								<div class="view-wrap" style="display: none;">
    									<div class="view-box">加载中...</div>
    								</div>
															</span>
						</div>
					</td>
										<td class="hall-price" data-partcode="dingxinnew">
						<em class="now">28.00</em>
						<del class="old">60.00</del>
											</td>
					<td class="hall-seat">
													<a class="seat-btn" href="https://www.taopiaopiao.com/seatOrder.htm?scheduleId=477479591&amp;n_s=new">选座购票</a>
											</td>
				</tr>
							</tbody>	
		</table>
			</div>

</div>
      
<%--<div class="schedule-wrap J_scheduleWrap schedule-loading" data-spm="w2" data-ajax="/showDetailSchedule.htm" data-param="showId=154601&ts=1514365236987&n_s=new" ></div>--%>
	





  
</asp:Content>

