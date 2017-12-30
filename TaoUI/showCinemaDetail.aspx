<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="showCinemaDetail.aspx.cs" Inherits="showCinemaDetail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="CSS/---pages-cinema_detail-index.less.css,-mods-list-filter.less.css,-mods-list-hall.less.css,-mods-list-cinematop.less.css,pages-movie_detail-comment.less.css,mods-list-title.less.css" rel="stylesheet" />
<style>
    .movie-info ul li {
        float:none;
    }
     
</style>
       
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <script>$(document).ready(function () {
    $('.nav').children().removeClass("current");
    $('#cinema').addClass("current");

});</script>
  <%--  <img src="image/TB1IKI_FVXXXXcWXFXXHhe5QXXX-1400-390.jpg" />--%>
      <div class='infomation-wrapper' style="background-image:url('image/TB1IKI_FVXXXXcWXFXXHhe5QXXX-1400-390.jpg')" data-spm="w1">
   		<div class='center-wrap'>
   			<h4 class='title'><asp:Label runat="server" ID="Y_name" ></asp:Label>
                   <small class='score' id="score" runat="server"> </small>
   			</h4>
   			<div class='info'>
				
   				<a data-type='image' class='float-layer-hook float-layer-wrapper' >
					<img data-src="ef3c981f-9b5e-4aa7-a67a-8083850379d8.jpg" tppabs="http://bdworkflow.oss-cn-hangzhou.aliyuncs.com/ef3c981f-9b5e-4aa7-a67a-8083850379d8.jpg">
				</a>
   				<ul class='info-list'>
					<li>
                   <asp:Label ID="y_address" runat="server"></asp:Label>  <a class='pos-hook' data-href="#J-map">[地图]</a></li>			
                       		<li> <asp:Label ID="y_phone" runat="server"></asp:Label></li>
                      
				</ul>
   			</div>
		</div>
	</div>
	<!-- tab -->
	<div class='center-wrap tab-wrapper'>
		<ul class='tab-list M-tabs'>
			<li id="seat" class='current J_seat'>

				<a href="#seat" data-href="javascript:if(confirm('https://dianying.taobao.com/seat  \n\n���ļ��޷��� Teleport Ultra ����, ��Ϊ ������������ļ�δ�ҵ���  \n\n�����ڷ������ϴ���?'))window.location='https://dianying.taobao.com/seat'" tppabs="https://dianying.taobao.com/seat">选座购票</a>
            </li>
          <%--  <li id="coupon" class="J_coupon">
                <a href="#coupon" data-href="javascript:if(confirm('https://dianying.taobao.com/coupon  \n\n���ļ��޷��� Teleport Ultra ����, ��Ϊ ������������ļ�δ�ҵ���  \n\n�����ڷ������ϴ���?'))window.location='https://dianying.taobao.com/coupon'" tppabs="https://dianying.taobao.com/coupon">团购</a>
            </li>
            <li id="detail" class="J_detail">
                <a href="#detail" data-href="javascript:if(confirm('https://dianying.taobao.com/detail  \n\n���ļ��޷��� Teleport Ultra ����, ��Ϊ ������������ļ�δ�ҵ���  \n\n�����ڷ������ϴ���?'))window.location='https://dianying.taobao.com/detail'" tppabs="https://dianying.taobao.com/detail" class='M-detail-panel'>影院信息</a>
            </li>--%>

		</ul>
	</div>

	
</div>
<div class="center-wrap M-seat" data-spm="w2">
	<div class="schedule-wrap J_scheduleWrap schedule-loaded" data-param="showId=&amp;cinemaId=36361&amp;ts=1514596713250&amp;n_s=new" data-ajax="/cinemaDetailSchedule.htm" data-type="cinema_detail">

	<div class="center-wrap w-seat-wrapper">
		<div class="filter-wrap">
			<ul class="filter-select">
								<li>
					<label>选择影片</label>
					<div class="select-tags" id="select_tags" runat="server">
												
											</div>
				</li>
				<li>
					<label>选择时间</label>
					<div class="select-tags" id="select_time" runat="server">
<%--													<a class="current" href="javascript:;" data-param="cinemaId=36361&amp;activityId=&amp;fCode=&amp;showId=212819&amp;showDate=2017-12-30&amp;ts=1514596717134&amp;n_s=new">12月30日（今天）</a>
													<a href="javascript:;" data-param="cinemaId=36361&amp;activityId=&amp;fCode=&amp;showId=212819&amp;showDate=2017-12-31&amp;ts=1514596717134&amp;n_s=new">12月31日（周日）</a>
													<a href="javascript:;" data-param="cinemaId=36361&amp;activityId=&amp;fCode=&amp;showId=212819&amp;showDate=2018-01-01&amp;ts=1514596717134&amp;n_s=new">1月1日（周一）</a>
													<a href="javascript:;" data-param="cinemaId=36361&amp;activityId=&amp;fCode=&amp;showId=212819&amp;showDate=2018-01-02&amp;ts=1514596717134&amp;n_s=new">1月2日（周二）</a>
	--%>										</div>
				</li>
							</ul>
		</div>
	<!-- movie bar -->
		 	<div class="movie-wrapper M-movie">
<%--			<img width="120" height="160" class="movie-post" src="https://img.alicdn.com/bao/uploaded/i4/TB1_xJQf8DH8KJjy1zeXXXjepXa_.jpg_160x160.jpg">--%>
                 <asp:Image ID="m_img" Width="120" Height="160" CssClass="movie-post" runat="server" />
			<div class="movie-info-wrap">
				<h4 class="info-title">
					<a class="movie-name" >
                     <asp:Label runat="server" ID="movie_name"></asp:Label>
                        <small class="score" id="m_score" runat="server"></small></a>

				</h4>
					<div class="right-info">
                        <asp:HyperLink  ID="m_hl" runat="server" CssClass="detail">查看影片详情&nbsp;&gt;</asp:HyperLink>
<%--						<a class="detail" href="https://www.taopiaopiao.com/showDetail.htm?showId=212819&amp;n_s=new">查看影片详情&nbsp;&gt;</a>--%>
					</div>
             
				<div class="movie-info">
					<ul>
						<li id="m_direct" runat="server"></li>	
                        
                        <li id="m_star" runat="server"></li>
                        
                        <li id="m_type" runat="server"></li>	
                        
                        <li id="m_state" runat="server"></li>	
                       
                        <li id="m_voice" runat="server"></li>	

					</ul>
				</div>
			</div>
		</div>
			<!-- Hall Tabel-->
		<div class="center-wrap">
				<table class="hall-table">
			<thead>
				<tr>
				    <th class="hall-time">放映时间</th>
				    <th class="hall-type">语言版本</th>
				    <th class="hall-name">放映厅</th>
				
				    <th class="hall-price">现价/影院价（元）</th>
				    <th class="hall-buy">选座购票</th>
				</tr>
			</thead>
			<tbody id="t_body" runat="server">
				
									
				<%--  <tr>
					<td class="hall-time">
						<em class="bold">10:15</em>
						 预计11:43散场 					</td>
					<td class="hall-type">
						国语 2D
					</td>
					<td class="hall-name">
						VIP厅(所有儿童需购票)
					</td>
										
					<td class="hall-flow">
						<div class="flowing-wrap flowing-loose">
							<label> 宽松  </label>
							<span class="flowing-vol"><i style="width: 0%;"></i></span>
							<span class="flowing-view J_flowingView" data-scheduleid="477952847">
								    								<i class="icon-zoom"></i>
    								<div class="view-wrap" style="display: none;">
    									<div class="view-box">加载中...</div>
    								</div>
															</span>
						</div>
					</td>
										<td class="hall-price" data-partcode="wandanew">
						<em class="now">73.00</em>
						<del class="old">73.00</del>
											</td>
					<td class="hall-seat">
													<a class="seat-btn" href="https://www.taopiaopiao.com/wandaPhoneOrder.htm?scheduleId=477952847&amp;shextid=C987201712300150230&amp;partnermaxcanbuy=4&amp;cinemaId=36361&amp;n_s=new">选座购票</a>
											</td>
				</tr>--%>
									
				 
							</tbody>	
		</table>
			</div>
</div></div>
</div>

</asp:Content>

