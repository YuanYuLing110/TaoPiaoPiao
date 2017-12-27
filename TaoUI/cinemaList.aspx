<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="cinemaList.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="CSS/--pages-cinema_list-index.less.css,mods-path-path.less.css,mods-list-title.less.css,mods-list-filter.less.css,mods-list-sort.less.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
       <script>$(document).ready(function () {
    $('.nav').children().removeClass("current");
    $('#cinema').addClass("current");

    $("#ContentPlaceHolder1_detail li").hover(
         function () {
             //alert("vjhvbjhgbvhg");
             $(this).parent().children().removeClass("current");
             $(this).addClass("current");
         })

});</script>
    <style>
        a:hover {
            cursor:pointer;
        }
    </style>
    <div class="center-wrap movie-path" data-spm="w1">
		<div class="path"><a href="-n_s=new.htm" tppabs="https://dianying.taobao.com/?n_s=new">首页</a> > <a href="cinemaList.aspx?cinemaArea=" tppabs="https://dianying.taobao.com/cinemaList.htm?n_s=new">影院</a> > <asp:Label ID="city" runat="server"></asp:Label></div>
		<div class="steps"><span>3步轻松购票:1.选座购票/买券</span><i></i><span>2.收电子码</span><i></i><span>3.影院取票</span></div>
	</div>
		
	<div class="cinema-wrap center-wrap">
		<div class="filter-wrap" data-spm="w2">
			<ul class="filter-select">
				<li>
					<label>选择区域</label>
					<div class="select-tags" runat="server" id="select_tags">
			
                        					</div>					
				</li>
				
				<li>
					<label>搜索</label>
					<div class="search-wrap J_searchWrap">
							<input placeholder="请输入影院名称/关键字" class="search-input" type="text" value=""><a href="javascript:;" data-search="regionName=&cinemaName={s}&n_s=new" data-target="https://dianying.taobao.com/cinemaList.htm" class="search-btn"><i class="icon-search"></i>查询</a>
					</div>
				</li>
			</ul>
			<div class='list-sort M-sort'>
				排序：<a  class='active'  href="cinemaList.htm-regionName=&sortType=0&cinemaName=&activityId=&fCode=&n_s=new.htm" tppabs="https://dianying.taobao.com/cinemaList.htm?regionName=&sortType=0&cinemaName=&activityId=&fCode=&n_s=new">综合</a>
				<a  href="cinemaList.htm-regionName=&sortType=4&cinemaName=&activityId=&fCode=&n_s=new.htm" tppabs="https://dianying.taobao.com/cinemaList.htm?regionName=&sortType=4&cinemaName=&activityId=&fCode=&n_s=new">评分 <i class='toggle-down'></i> </a> 
				当前条件下共有<span class='count' id="count" runat="server"></span>家影院 
			</div>
						<ul class="sortbar-detail J_cinemaList" id="detail" runat="server" >
    			    	
                      
				    				
			    		
							</ul>
					
					   <div class="sortbar-more J_cinemaMore" data-ajax="https://dianying.taobao.com/ajaxCinemaList.htm" data-param="page=1&regionName=&cinemaName=&pageSize=10&pageLength=9&sortType=0&n_s=new">
                <%--<div>
                   <a href="javascript:;">点击显示更多</a>
                </div>--%>
            </div>
						
		</div>

	<%--	<div class="Coupon-list" data-spm="w3">
			<div class="list-hd ">
				<h4>热销团购券</h4>
				<a href="itemList.htm-n_s=new}.htm" tppabs="https://dianying.taobao.com/itemList.htm?n_s=new}">查看全部&nbsp;&gt;</a>
			</div>
			
							<div class="error-wrap"><div class="title">暂无团购信息</div>你可以查看 <a href="cinemaList.htm-n_s=new.htm" tppabs="https://dianying.taobao.com/cinemaList.htm?n_s=new">全部影院</a>或者<a href="showList.htm-n_s=new.htm" tppabs="https://dianying.taobao.com/showList.htm?n_s=new">全部影片</a></div>
						
		</div>--%>
		<div class="cinema-sortbar">
		</div>
	</div>
</asp:Content>

