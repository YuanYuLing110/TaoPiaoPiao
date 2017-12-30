<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="showCinemaDetail.aspx.cs" Inherits="showCinemaDetail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="CSS/---pages-cinema_detail-index.less.css,-mods-list-filter.less.css,-mods-list-hall.less.css,-mods-list-cinematop.less.css,pages-movie_detail-comment.less.css,mods-list-title.less.css" rel="stylesheet" />
<style>
    .movie-info ul li {
        float:none;
    }
     
</style>
<script type="text/javascript" src="qrcode.js" tppabs="https://g.alicdn.com/mtb/lib-qrcode/1.0.0/qrcode.js"></script>
<script>
function alertCode(cinemaId,movieId){
	KISSY.use(["event","node","jbc/jupopup"],function(S,Event,Node,Box){
//var jumpUrl = "http://d.alipay.com/movie/jump.htm?target=showtimeList&cinemaId=4497&providerCode=tbmovie&movieId=16730var jumpUrl ="http://d.alipay.com/movie/jump.htm?appId=20000131&target=showtimeList&cinemaId="+cinemaId+"&providerCode=tbmovie&movieId="+movieId+"";
var options = {
render : "canvas",
width : 160,
height : 160,
typeNumber : -1,
correctLevel : lib.QRErrorCorrectLevel.H,
background : "#ffffff",
foreground : "#000000"
}
var qrcode = new lib.QRCode(options.typeNumber, options.correctLevel);
qrcode.addData(jumpUrl);
qrcode.make();

// create canvas element
var canvas = document.createElement('canvas');
canvas.width = options.width;
canvas.height = options.height;
var ctx = canvas.getContext('2d');

// compute tileW/tileH based on options.width/options.height
var tileW = options.width / qrcode.getModuleCount();
var tileH = options.height / qrcode.getModuleCount();

// draw in the canvas
for( var row = 0; row < qrcode.getModuleCount(); row++ ){
for( var col = 0; col < qrcode.getModuleCount(); col++ ){
ctx.fillStyle = qrcode.isDark(row, col) ? options.foreground : options.background;
var w = (Math.ceil((col+1)*tileW) - Math.floor(col*tileW));
var h = (Math.ceil((row+1)*tileW) - Math.floor(row*tileW));
ctx.fillRect(Math.round(col*tileW),Math.round(row*tileH), w, h); 
} 
}
S.all('.ju-popup-wrapper').remove(); 
new Box({
autoShow: true,
title: '提示',
top:20,
width:600,
content: "<h5 class='wanda-h5'>由于万达影院购票流程已修改，请用支付宝钱包扫描下面的二维码继续购票</h5><div id='output' class='output-code'></div>",
buttons:[{
style: 'btn',
text: '确定',
func: function() {
this.hide();
}
}]
});
document.querySelector("#output").appendChild(canvas);

})
}
</script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  <%--  <img src="image/TB1IKI_FVXXXXcWXFXXHhe5QXXX-1400-390.jpg" />--%>
      <div class='infomation-wrapper' style="background-image:url('image/TB1IKI_FVXXXXcWXFXXHhe5QXXX-1400-390.jpg')" data-spm="w1">
   		<div class='center-wrap'>
   			<h4 class='title'>中影星美国际影城-韩森寨店<!--small class='mark'>关注：22093</small--><small class='score'> 8.0 </small><small class="others"><!--a class="J_gocomment" href="#comment">[评价]</a--><!--a href="#">[纠错信息]</a--></small></h4>
   			<div class='info'>
				<div class='right-event'>
					<!--div class='panel'>
						<div class='panel-message'>
							1、周二、周三全天半价； 
							2、每天12:00前半价； 
							3、学生凭全日制大学本
							3、学生凭全日制大学本3、学生凭全日制大学本3、学生凭全日制大学本3、学生凭全日制大学本3、学生凭全日制大学本3、学生凭全日制大学本3、学生凭全日制大学本3、学生凭全日制大学本
						</div>
						<div class='panel-title'><a class='pos-hook' data-href='.special-detail-hook'>详情&nbsp;&gt;</a></div>
					</div-->
					<div id='J-sm-map' class="sm-map">
						<div class='sm-map-info'><a class='more pos-hook' data-href="#J-map">大图查看</a></div>
					</div>
				</div>
   				<a data-type='image' class='float-layer-hook float-layer-wrapper' >
					<img data-src="ef3c981f-9b5e-4aa7-a67a-8083850379d8.jpg" tppabs="http://bdworkflow.oss-cn-hangzhou.aliyuncs.com/ef3c981f-9b5e-4aa7-a67a-8083850379d8.jpg">
				</a>
   				<ul class='info-list'>
					<li>详细地址：新城区幸福路与韩森路十字东南角福邸铭门10号楼4层<a class='pos-hook' data-href="#J-map">[地图]</a></li>					<li>联系电话：029-82219801,602</li>															<li>更多信息：
						<!--a class='pos-hook' data-href=".cinema-server-hook">影院服务</a-->
						<a class='pos-hook' data-href="javascript:if(confirm('https://dianying.taobao.com/.traffic-server-hook  \n\n���ļ��޷��� Teleport Ultra ����, ��Ϊ ������������ļ�δ�ҵ���  \n\n�����ڷ������ϴ���?'))window.location='https://dianying.taobao.com/.traffic-server-hook'" tppabs="https://dianying.taobao.com/.traffic-server-hook">交通信息</a> 
												<!--a class='pos-hook' data-href=".machine-server-hook">取票机位置</a-->
					</li>
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
            <li id="coupon" class="J_coupon">
                <a href="#coupon" data-href="javascript:if(confirm('https://dianying.taobao.com/coupon  \n\n���ļ��޷��� Teleport Ultra ����, ��Ϊ ������������ļ�δ�ҵ���  \n\n�����ڷ������ϴ���?'))window.location='https://dianying.taobao.com/coupon'" tppabs="https://dianying.taobao.com/coupon">团购</a>
            </li>
            <li id="detail" class="J_detail">
                <a href="#detail" data-href="javascript:if(confirm('https://dianying.taobao.com/detail  \n\n���ļ��޷��� Teleport Ultra ����, ��Ϊ ������������ļ�δ�ҵ���  \n\n�����ڷ������ϴ���?'))window.location='https://dianying.taobao.com/detail'" tppabs="https://dianying.taobao.com/detail" class='M-detail-panel'>影院信息</a>
            </li>

		</ul>
	</div>
	<!-- cinema-detail -->
	<div class='center-wrap cinema-detail-wrapper M-detail' data-spm="w4">
		<div class='cinema-detail-item'>
			<div class="title-wrap" > <h3 class="special-detail-hook">影院介绍</h3></div> 
						<ul>
				<li><span>详细地址： </span>新城区幸福路与韩森路十字东南角福邸铭门10号楼4层 [<a data-href="#J-map" class='pos-hook'>地图</a>]</li>
				<li><span>联系电话： </span>029-82219801,602</li>												<!--li><span>营业时间： </span></li-->
			</ul>
			
		</div>
		
		<!--div class='cinema-detail-item'>
			<h3>优惠公告</h3>
			<p>暂无公告</p>
		</div-->
		
		<!--div class='cinema-detail-item'>
			<h3 class='cinema-server-hook'>影院服务</h3>
			<p>暂无影院服务</p>
		</div-->
		
		<div class='cinema-detail-item'>
			<h3 class='traffic-server-hook'>交通信息</h3>
			<ul>
								<!--li><span>停车信息：</span> 暂无停车信息</li-->
				<li><span>地图：</span><!--a href="#">[放大查看]</a--></li>
			</ul>
			<div id='J-map' ></div>
			<div class='search-map'>
            	<form action="http://www.amap.com/" class='M-form-search' data-city='杭州' target="_blank" accept-charset="utf-8">	
					<input name='_tb_token_' type='hidden' value='356eb70e1377'>
            		<div class='search-map-tab'>
            			<div class='active M-search-item'>驾车</div>
            			<div class='M-search-item'>公交</div>
            		</div>
            		<div class='input-wrapper'>
            			<span>起</span><input class='M-start-search' type='text' placeholder='请输入起点'>
            			<br/>
            			<span>终</span><input class='M-end-search' type='text' placeholder='请输入终点'>
            		</div>
            		<a href='#' class='search-submit-button M-submit-search'>提交查询</a>
            	</form>
            </div>
		</div>
		
				
		<!--div class='cinema-detail-item'>
			<h3 class='machine-server-hook'>取票机位置</h3>
			<p>暂无取票机位置</p>
		</div-->
	</div>
	<!-- coupon -->
	<div class='center-wrap coupon-wrapper M-coupon' data-spm="w3">
		<div class='coupon-message'>
			<ul>
				<li>团购券购买说明：</li>
                <li>1、成功购买团购券后，将收到带有验证码的短信，凭验证码至影院柜台进行兑换。</li>
                <li>2、请注意团购券有效期、节假日使用规则、3D/IMAX使用规则等说明。</li>
                <li>3、团购券售后条例以具体店铺和宝贝详情描述为准。</li>
			</ul>
		</div>	
			<table class="hall-table">
			<thead>
				<tr>
				    <th class="hall-name">优惠券</th>
				    <!--th class="hall-type">适用类型</th>
				    <th class="hall-time">适用时间</th-->
				    <th class="hall-flow">有效期</th>
				    <th class="hall-price">现价/面值（元）</th>
				    <th class="hall-hasbuy">已售</th>
				    <!--th class="hall-agent">代理商</th-->
				    <!--th class="hall-count">购买张数</th-->
				    <th class="hall-buy">购买</th>
				</tr>
			</thead>
			<tbody>
									<td colspan="8"><div class="error-wrap">囧 ~没有找到你需要的团购券，你可以换个影院试试</div><td>
							</tbody>	
		</table>
	</div>
</div>
<div class="center-wrap M-seat" data-spm="w2">
	<div class="schedule-wrap J_scheduleWrap schedule-loaded" data-param="showId=&amp;cinemaId=36361&amp;ts=1514596713250&amp;n_s=new" data-ajax="/cinemaDetailSchedule.htm" data-type="cinema_detail">

	<div class="center-wrap w-seat-wrapper">
		<div class="filter-wrap">
			<ul class="filter-select">
								<li>
					<label>选择影片</label>
					<div class="select-tags">
													<a class="current" href="javascript:;" data-param="cinemaId=36361&amp;activityId=&amp;fCode=&amp;showId=212819&amp;showDate=2017-12-30&amp;ts=1514596717134&amp;n_s=new">妖铃铃</a>
													<a href="javascript:;" data-param="cinemaId=36361&amp;activityId=&amp;fCode=&amp;showId=208737&amp;showDate=2017-12-30&amp;ts=1514596717134&amp;n_s=new">二代妖精之今生有幸</a>
													<a href="javascript:;" data-param="cinemaId=36361&amp;activityId=&amp;fCode=&amp;showId=226839&amp;showDate=2017-12-30&amp;ts=1514596717134&amp;n_s=new">解忧杂货店</a>
													<a href="javascript:;" data-param="cinemaId=36361&amp;activityId=&amp;fCode=&amp;showId=211693&amp;showDate=2017-12-30&amp;ts=1514596717134&amp;n_s=new">芳华</a>
													<a href="javascript:;" data-param="cinemaId=36361&amp;activityId=&amp;fCode=&amp;showId=178733&amp;showDate=2017-12-30&amp;ts=1514596717134&amp;n_s=new">星球大战：最后的绝地武士</a>
													<a href="javascript:;" data-param="cinemaId=36361&amp;activityId=&amp;fCode=&amp;showId=154601&amp;showDate=2017-12-30&amp;ts=1514596717134&amp;n_s=new">妖猫传</a>
													<a href="javascript:;" data-param="cinemaId=36361&amp;activityId=&amp;fCode=&amp;showId=190166&amp;showDate=2017-12-30&amp;ts=1514596717134&amp;n_s=new">前任3：再见前任</a>
													<a href="javascript:;" data-param="cinemaId=36361&amp;activityId=&amp;fCode=&amp;showId=199566&amp;showDate=2017-12-30&amp;ts=1514596717134&amp;n_s=new">机器之血</a>
													<a href="javascript:;" data-param="cinemaId=36361&amp;activityId=&amp;fCode=&amp;showId=233001&amp;showDate=2017-12-30&amp;ts=1514596717134&amp;n_s=new">小猫巴克里</a>
											</div>
				</li>
				<li>
					<label>选择时间</label>
					<div class="select-tags">
													<a class="current" href="javascript:;" data-param="cinemaId=36361&amp;activityId=&amp;fCode=&amp;showId=212819&amp;showDate=2017-12-30&amp;ts=1514596717134&amp;n_s=new">12月30日（今天）</a>
													<a href="javascript:;" data-param="cinemaId=36361&amp;activityId=&amp;fCode=&amp;showId=212819&amp;showDate=2017-12-31&amp;ts=1514596717134&amp;n_s=new">12月31日（周日）</a>
													<a href="javascript:;" data-param="cinemaId=36361&amp;activityId=&amp;fCode=&amp;showId=212819&amp;showDate=2018-01-01&amp;ts=1514596717134&amp;n_s=new">1月1日（周一）</a>
													<a href="javascript:;" data-param="cinemaId=36361&amp;activityId=&amp;fCode=&amp;showId=212819&amp;showDate=2018-01-02&amp;ts=1514596717134&amp;n_s=new">1月2日（周二）</a>
											</div>
				</li>
							</ul>
		</div>
	<!-- movie bar -->
		 	<div class="movie-wrapper M-movie">
			<img width="120" height="160" class="movie-post" src="https://img.alicdn.com/bao/uploaded/i4/TB1_xJQf8DH8KJjy1zeXXXjepXa_.jpg_160x160.jpg">
			<div class="movie-info-wrap">
				<h4 class="info-title">
					<a class="movie-name" href="https://www.taopiaopiao.com/showDetail.htm?showId=212819&amp;n_s=new">妖铃铃<small class="score">7.6</small></a><!--small class='mark'>关注度：40000000</small--></h4>
					<div class="right-info">
						<a class="detail" href="https://www.taopiaopiao.com/showDetail.htm?showId=212819&amp;n_s=new">查看影片详情&nbsp;&gt;</a>
					</div>
                <div style="  clear: both;"></div>
				<div class="movie-info">
					<ul>
												<li>导演：吴君如</li>						<li>主演：吴君如,沈腾,岳云鹏,张译,papi,吴镇宇,方中信,焦俊艳</li>						<li>类型：喜剧</li>						<li>制片国家/地区：中国香港,中国大陆</li>						<li>语言：汉语普通话</li>					</ul>
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
				    <th class="hall-flow">座位情况</th>
				    <th class="hall-price">现价/影院价（元）</th>
				    <th class="hall-buy">选座购票</th>
				</tr>
			</thead>
			<tbody>
				
									
				  <tr>
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
				</tr>
									
				  <tr class="even">
					<td class="hall-time">
						<em class="bold">10:20</em>
						 预计11:48散场 					</td>
					<td class="hall-type">
						国语 2D
					</td>
					<td class="hall-name">
						7号厅
					</td>
										
					<td class="hall-flow">
						<div class="flowing-wrap flowing-loose">
							<label> 宽松  </label>
							<span class="flowing-vol"><i style="width: 0%;"></i></span>
							<span class="flowing-view J_flowingView" data-scheduleid="478641146">
								    								<i class="icon-zoom"></i>
    								<div class="view-wrap" style="display: none;">
    									<div class="view-box">加载中...</div>
    								</div>
															</span>
						</div>
					</td>
										<td class="hall-price" data-partcode="wandanew">
						<em class="now">33.00</em>
						<del class="old">35.00</del>
											</td>
					<td class="hall-seat">
													<a class="seat-btn" href="https://www.taopiaopiao.com/wandaPhoneOrder.htm?scheduleId=478641146&amp;shextid=C987201712300070430&amp;partnermaxcanbuy=4&amp;cinemaId=36361&amp;n_s=new">选座购票</a>
											</td>
				</tr>
									
				  <tr>
					<td class="hall-time">
						<em class="bold">10:50</em>
						 预计12:18散场 					</td>
					<td class="hall-type">
						国语 2D
					</td>
					<td class="hall-name">
						6号厅
					</td>
										
					<td class="hall-flow">
						<div class="flowing-wrap flowing-loose">
							<label> 宽松  </label>
							<span class="flowing-vol"><i style="width: 0%;"></i></span>
							<span class="flowing-view J_flowingView" data-scheduleid="477952766">
								    								<i class="icon-zoom"></i>
    								<div class="view-wrap" style="display: none;">
    									<div class="view-box">加载中...</div>
    								</div>
															</span>
						</div>
					</td>
										<td class="hall-price" data-partcode="wandanew">
						<em class="now">33.00</em>
						<del class="old">35.00</del>
											</td>
					<td class="hall-seat">
													<a class="seat-btn" href="https://www.taopiaopiao.com/wandaPhoneOrder.htm?scheduleId=477952766&amp;shextid=C987201712300060220&amp;partnermaxcanbuy=4&amp;cinemaId=36361&amp;n_s=new">选座购票</a>
											</td>
				</tr>
									
				  <tr class="even">
					<td class="hall-time">
						<em class="bold">12:40</em>
						 预计14:08散场 					</td>
					<td class="hall-type">
						国语 2D
					</td>
					<td class="hall-name">
						6号厅
					</td>
										
					<td class="hall-flow">
						<div class="flowing-wrap flowing-loose">
							<label> 宽松  </label>
							<span class="flowing-vol"><i style="width: 0%;"></i></span>
							<span class="flowing-view J_flowingView" data-scheduleid="477952751">
								    								<i class="icon-zoom"></i>
    								<div class="view-wrap" style="display: none;">
    									<div class="view-box">加载中...</div>
    								</div>
															</span>
						</div>
					</td>
										<td class="hall-price" data-partcode="wandanew">
						<em class="now">33.00</em>
						<del class="old">70.00</del>
											</td>
					<td class="hall-seat">
													<a class="seat-btn" href="https://www.taopiaopiao.com/wandaPhoneOrder.htm?scheduleId=477952751&amp;shextid=C987201712300060240&amp;partnermaxcanbuy=4&amp;cinemaId=36361&amp;n_s=new">选座购票</a>
											</td>
				</tr>
									
				  <tr>
					<td class="hall-time">
						<em class="bold">14:00</em>
						 预计15:28散场 					</td>
					<td class="hall-type">
						国语 2D
					</td>
					<td class="hall-name">
						1号厅
					</td>
										
					<td class="hall-flow">
						<div class="flowing-wrap flowing-loose">
							<label> 宽松  </label>
							<span class="flowing-vol"><i style="width: 0%;"></i></span>
							<span class="flowing-view J_flowingView" data-scheduleid="478641057">
								    								<i class="icon-zoom"></i>
    								<div class="view-wrap" style="display: none;">
    									<div class="view-box">加载中...</div>
    								</div>
															</span>
						</div>
					</td>
										<td class="hall-price" data-partcode="wandanew">
						<em class="now">38.00</em>
						<del class="old">70.00</del>
											</td>
					<td class="hall-seat">
													<a class="seat-btn" href="https://www.taopiaopiao.com/wandaPhoneOrder.htm?scheduleId=478641057&amp;shextid=C987201712300010520&amp;partnermaxcanbuy=4&amp;cinemaId=36361&amp;n_s=new">选座购票</a>
											</td>
				</tr>
									
				  <tr class="even">
					<td class="hall-time">
						<em class="bold">14:20</em>
						 预计15:48散场 					</td>
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
							<span class="flowing-view J_flowingView" data-scheduleid="478641121">
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
													<a class="seat-btn" href="https://www.taopiaopiao.com/wandaPhoneOrder.htm?scheduleId=478641121&amp;shextid=C987201712300150780&amp;partnermaxcanbuy=4&amp;cinemaId=36361&amp;n_s=new">选座购票</a>
											</td>
				</tr>
									
				  <tr>
					<td class="hall-time">
						<em class="bold">14:30</em>
						 预计15:58散场 					</td>
					<td class="hall-type">
						国语 2D
					</td>
					<td class="hall-name">
						6号厅
					</td>
										
					<td class="hall-flow">
						<div class="flowing-wrap flowing-loose">
							<label> 宽松  </label>
							<span class="flowing-vol"><i style="width: 0%;"></i></span>
							<span class="flowing-view J_flowingView" data-scheduleid="477952807">
								    								<i class="icon-zoom"></i>
    								<div class="view-wrap" style="display: none;">
    									<div class="view-box">加载中...</div>
    								</div>
															</span>
						</div>
					</td>
										<td class="hall-price" data-partcode="wandanew">
						<em class="now">38.00</em>
						<del class="old">70.00</del>
											</td>
					<td class="hall-seat">
													<a class="seat-btn" href="https://www.taopiaopiao.com/wandaPhoneOrder.htm?scheduleId=477952807&amp;shextid=C987201712300060260&amp;partnermaxcanbuy=4&amp;cinemaId=36361&amp;n_s=new">选座购票</a>
											</td>
				</tr>
									
				  <tr class="even">
					<td class="hall-time">
						<em class="bold">15:45</em>
						 预计17:13散场 					</td>
					<td class="hall-type">
						国语 2D
					</td>
					<td class="hall-name">
						1号厅
					</td>
										
					<td class="hall-flow">
						<div class="flowing-wrap flowing-loose">
							<label> 宽松  </label>
							<span class="flowing-vol"><i style="width: 0%;"></i></span>
							<span class="flowing-view J_flowingView" data-scheduleid="478641097">
								    								<i class="icon-zoom"></i>
    								<div class="view-wrap" style="display: none;">
    									<div class="view-box">加载中...</div>
    								</div>
															</span>
						</div>
					</td>
										<td class="hall-price" data-partcode="wandanew">
						<em class="now">38.00</em>
						<del class="old">70.00</del>
											</td>
					<td class="hall-seat">
													<a class="seat-btn" href="https://www.taopiaopiao.com/wandaPhoneOrder.htm?scheduleId=478641097&amp;shextid=C987201712300010560&amp;partnermaxcanbuy=4&amp;cinemaId=36361&amp;n_s=new">选座购票</a>
											</td>
				</tr>
									
				  <tr>
					<td class="hall-time">
						<em class="bold">16:20</em>
						 预计17:48散场 					</td>
					<td class="hall-type">
						国语 2D
					</td>
					<td class="hall-name">
						6号厅
					</td>
										
					<td class="hall-flow">
						<div class="flowing-wrap flowing-loose">
							<label> 宽松  </label>
							<span class="flowing-vol"><i style="width: 0%;"></i></span>
							<span class="flowing-view J_flowingView" data-scheduleid="477952789">
								    								<i class="icon-zoom"></i>
    								<div class="view-wrap" style="display: none;">
    									<div class="view-box">加载中...</div>
    								</div>
															</span>
						</div>
					</td>
										<td class="hall-price" data-partcode="wandanew">
						<em class="now">38.00</em>
						<del class="old">70.00</del>
											</td>
					<td class="hall-seat">
													<a class="seat-btn" href="https://www.taopiaopiao.com/wandaPhoneOrder.htm?scheduleId=477952789&amp;shextid=C987201712300060280&amp;partnermaxcanbuy=4&amp;cinemaId=36361&amp;n_s=new">选座购票</a>
											</td>
				</tr>
									
				  <tr class="even">
					<td class="hall-time">
						<em class="bold">17:30</em>
						 预计18:58散场 					</td>
					<td class="hall-type">
						国语 2D
					</td>
					<td class="hall-name">
						1号厅
					</td>
										
					<td class="hall-flow">
						<div class="flowing-wrap flowing-loose">
							<label> 宽松  </label>
							<span class="flowing-vol"><i style="width: 0%;"></i></span>
							<span class="flowing-view J_flowingView" data-scheduleid="478641037">
								    								<i class="icon-zoom"></i>
    								<div class="view-wrap" style="display: none;">
    									<div class="view-box">加载中...</div>
    								</div>
															</span>
						</div>
					</td>
										<td class="hall-price" data-partcode="wandanew">
						<em class="now">33.00</em>
						<del class="old">70.00</del>
											</td>
					<td class="hall-seat">
													<a class="seat-btn" href="https://www.taopiaopiao.com/wandaPhoneOrder.htm?scheduleId=478641037&amp;shextid=C987201712300010620&amp;partnermaxcanbuy=4&amp;cinemaId=36361&amp;n_s=new">选座购票</a>
											</td>
				</tr>
									
				  <tr>
					<td class="hall-time">
						<em class="bold">18:15</em>
						 预计19:43散场 					</td>
					<td class="hall-type">
						国语 2D
					</td>
					<td class="hall-name">
						6号厅
					</td>
										
					<td class="hall-flow">
						<div class="flowing-wrap flowing-loose">
							<label> 宽松  </label>
							<span class="flowing-vol"><i style="width: 0%;"></i></span>
							<span class="flowing-view J_flowingView" data-scheduleid="477952732">
								    								<i class="icon-zoom"></i>
    								<div class="view-wrap" style="display: none;">
    									<div class="view-box">加载中...</div>
    								</div>
															</span>
						</div>
					</td>
										<td class="hall-price" data-partcode="wandanew">
						<em class="now">33.00</em>
						<del class="old">70.00</del>
											</td>
					<td class="hall-seat">
													<a class="seat-btn" href="https://www.taopiaopiao.com/wandaPhoneOrder.htm?scheduleId=477952732&amp;shextid=C987201712300060300&amp;partnermaxcanbuy=4&amp;cinemaId=36361&amp;n_s=new">选座购票</a>
											</td>
				</tr>
									
				  <tr class="even">
					<td class="hall-time">
						<em class="bold">19:20</em>
						 预计20:48散场 					</td>
					<td class="hall-type">
						国语 2D
					</td>
					<td class="hall-name">
						1号厅
					</td>
										
					<td class="hall-flow">
						<div class="flowing-wrap flowing-loose">
							<label> 宽松  </label>
							<span class="flowing-vol"><i style="width: 0%;"></i></span>
							<span class="flowing-view J_flowingView" data-scheduleid="478641076">
								    								<i class="icon-zoom"></i>
    								<div class="view-wrap" style="display: none;">
    									<div class="view-box">加载中...</div>
    								</div>
															</span>
						</div>
					</td>
										<td class="hall-price" data-partcode="wandanew">
						<em class="now">38.00</em>
						<del class="old">70.00</del>
											</td>
					<td class="hall-seat">
													<a class="seat-btn" href="https://www.taopiaopiao.com/wandaPhoneOrder.htm?scheduleId=478641076&amp;shextid=C987201712300010660&amp;partnermaxcanbuy=4&amp;cinemaId=36361&amp;n_s=new">选座购票</a>
											</td>
				</tr>
									
				  <tr>
					<td class="hall-time">
						<em class="bold">20:00</em>
						 预计21:28散场 					</td>
					<td class="hall-type">
						国语 2D
					</td>
					<td class="hall-name">
						6号厅
					</td>
										
					<td class="hall-flow">
						<div class="flowing-wrap flowing-loose">
							<label> 宽松  </label>
							<span class="flowing-vol"><i style="width: 0%;"></i></span>
							<span class="flowing-view J_flowingView" data-scheduleid="477952775">
								    								<i class="icon-zoom"></i>
    								<div class="view-wrap" style="display: none;">
    									<div class="view-box">加载中...</div>
    								</div>
															</span>
						</div>
					</td>
										<td class="hall-price" data-partcode="wandanew">
						<em class="now">38.00</em>
						<del class="old">70.00</del>
											</td>
					<td class="hall-seat">
													<a class="seat-btn" href="https://www.taopiaopiao.com/wandaPhoneOrder.htm?scheduleId=477952775&amp;shextid=C987201712300060330&amp;partnermaxcanbuy=4&amp;cinemaId=36361&amp;n_s=new">选座购票</a>
											</td>
				</tr>
									
				  <tr class="even">
					<td class="hall-time">
						<em class="bold">21:30</em>
						 预计22:58散场 					</td>
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
							<span class="flowing-view J_flowingView" data-scheduleid="478641033">
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
													<a class="seat-btn" href="https://www.taopiaopiao.com/wandaPhoneOrder.htm?scheduleId=478641033&amp;shextid=C987201712300150800&amp;partnermaxcanbuy=4&amp;cinemaId=36361&amp;n_s=new">选座购票</a>
											</td>
				</tr>
									
				  <tr>
					<td class="hall-time">
						<em class="bold">21:35</em>
						 预计23:03散场 					</td>
					<td class="hall-type">
						国语 2D
					</td>
					<td class="hall-name">
						10号厅
					</td>
										
					<td class="hall-flow">
						<div class="flowing-wrap flowing-loose">
							<label> 宽松  </label>
							<span class="flowing-vol"><i style="width: 0%;"></i></span>
							<span class="flowing-view J_flowingView" data-scheduleid="477952828">
								    								<i class="icon-zoom"></i>
    								<div class="view-wrap" style="display: none;">
    									<div class="view-box">加载中...</div>
    								</div>
															</span>
						</div>
					</td>
										<td class="hall-price" data-partcode="wandanew">
						<em class="now">33.00</em>
						<del class="old">70.00</del>
											</td>
					<td class="hall-seat">
													<a class="seat-btn" href="https://www.taopiaopiao.com/wandaPhoneOrder.htm?scheduleId=477952828&amp;shextid=C987201712300100350&amp;partnermaxcanbuy=4&amp;cinemaId=36361&amp;n_s=new">选座购票</a>
											</td>
				</tr>
									
				  <tr class="even">
					<td class="hall-time">
						<em class="bold">22:05</em>
						 预计23:33散场 					</td>
					<td class="hall-type">
						国语 2D
					</td>
					<td class="hall-name">
						6号厅
					</td>
										
					<td class="hall-flow">
						<div class="flowing-wrap flowing-loose">
							<label> 宽松  </label>
							<span class="flowing-vol"><i style="width: 0%;"></i></span>
							<span class="flowing-view J_flowingView" data-scheduleid="477952750">
								    								<i class="icon-zoom"></i>
    								<div class="view-wrap" style="display: none;">
    									<div class="view-box">加载中...</div>
    								</div>
															</span>
						</div>
					</td>
										<td class="hall-price" data-partcode="wandanew">
						<em class="now">33.00</em>
						<del class="old">70.00</del>
											</td>
					<td class="hall-seat">
													<a class="seat-btn" href="https://www.taopiaopiao.com/wandaPhoneOrder.htm?scheduleId=477952750&amp;shextid=C987201712300060360&amp;partnermaxcanbuy=4&amp;cinemaId=36361&amp;n_s=new">选座购票</a>
											</td>
				</tr>
									
				  <tr>
					<td class="hall-time">
						<em class="bold">23:20</em>
						 预计次日00:48散场 					</td>
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
							<span class="flowing-view J_flowingView" data-scheduleid="477952734">
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
													<a class="seat-btn" href="https://www.taopiaopiao.com/wandaPhoneOrder.htm?scheduleId=477952734&amp;shextid=C987201712300150390&amp;partnermaxcanbuy=4&amp;cinemaId=36361&amp;n_s=new">选座购票</a>
											</td>
				</tr>
									
				  <tr class="even">
					<td class="hall-time">
						<em class="bold">23:50</em>
						 预计次日01:18散场 					</td>
					<td class="hall-type">
						国语 2D
					</td>
					<td class="hall-name">
						6号厅
					</td>
										
					<td class="hall-flow">
						<div class="flowing-wrap flowing-loose">
							<label> 宽松  </label>
							<span class="flowing-vol"><i style="width: 0%;"></i></span>
							<span class="flowing-view J_flowingView" data-scheduleid="477952810">
								    								<i class="icon-zoom"></i>
    								<div class="view-wrap" style="display: none;">
    									<div class="view-box">加载中...</div>
    								</div>
															</span>
						</div>
					</td>
										<td class="hall-price" data-partcode="wandanew">
						<em class="now">33.00</em>
						<del class="old">70.00</del>
											</td>
					<td class="hall-seat">
													<a class="seat-btn" href="https://www.taopiaopiao.com/wandaPhoneOrder.htm?scheduleId=477952810&amp;shextid=C987201712300060380&amp;partnermaxcanbuy=4&amp;cinemaId=36361&amp;n_s=new">选座购票</a>
											</td>
				</tr>
							</tbody>	
		</table>
			</div>
</div></div>
</div>
</div>	
</div>
<script type="text/javascript" src="maps-v=1.3&key=bb9d2509c1e13664de59b79e1ecf61ee" tppabs="https://webapi.amap.com/maps?v=1.3&key=bb9d2509c1e13664de59b79e1ecf61ee"></script>
<!-- <script src='https://webapi.amap.com/maps/main?v=1.3&key=bb9d2509c1e13664de59b79e1ecf61ee'></script> -->
<script language="javascript">
    //自定义定位标记
    var longitude = 109.017048;// 设置经度
    var latitude = 34.258364;//设置纬度
    //初始化地图对象，加载地图
    function mapInit() {
        var mapObj = new AMap.Map("J-map", {
            center: new AMap.LngLat(longitude, latitude),//位置信息
            level: 13
        });
        var sMap = new AMap.Map('J-sm-map', {
            center: new AMap.LngLat(longitude, latitude),//位置信息
            level: 13
        })
        var customMarker = new AMap.Marker({
            icon: new AMap.Icon({  //复杂图标
                size: new AMap.Size(28, 37),//图标大小
                image: "https://webapi.amap.com/images/custom_a_j.png", //大图地址
                imageOffset: new AMap.Pixel(-28, 0)//相对于大图的取图位置
            }),
            position: new AMap.LngLat(longitude, latitude) // 位置信息
        });
        var customMarker2 = new AMap.Marker({
            icon: new AMap.Icon({  //复杂图标
                size: new AMap.Size(28, 37),//图标大小
                image: "https://webapi.amap.com/images/custom_a_j.png", //大图地址
                imageOffset: new AMap.Pixel(-28, 0)//相对于大图的取图位置
            }),
            position: new AMap.LngLat(longitude, latitude) // 位置信息
        });
        customMarker.setMap(mapObj);
        customMarker2.setMap(sMap);
    }
    mapInit();
</script>

<script>
    KISSY.use("pcm/pages/cinema_detail/index", function (S, Index) {
        new Index();
    })
</script>
</asp:Content>

