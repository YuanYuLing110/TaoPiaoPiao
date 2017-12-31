<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="seatOrder.aspx.cs" Inherits="seatOrder" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="CSS/seatOrder.css" rel="stylesheet" />

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  <%--  <script src="JS/MyJuery.js"></script>--%>
  <style>
      ul li {
          float:none;
      }
  </style>
      <script>$(document).ready(function () {
    $('.nav').children().removeClass("current");
    $('#cinema').addClass("current");

    
    var n = 0;
    $(".seat-cell").click(function () {
        //alert("aaaaaa");
        if ($(this).hasClass("seat-checked"))
        {
          
            $(this).removeClass("seat-checked");
            var s_id = $(this).attr("data-seatid");
            var dj = $(".jiaQian").text();
            //$("'#" + s_id + "'").remove();
            $("#"+s_id).remove();
            n--;
            $("#count").text(n);
            $("#num").text(n);

            $(".J_price").text(dj * n);
        }         
        else
        {
            if (n < 4) {
                $(this).addClass("seat-checked");
                var tst = $(this).attr("data-name");
                var s_id = $(this).attr("data-seatid");
                var dj = $(".jiaQian").text();
                
                //alert(dj);
                var txt2 = $("<a class='seatNum' id=" + s_id + "></a>").text(tst);
                $(".J_pewGroup").append(txt2);
                n++;
                $("#count").text(n);
                $("#num").text(n);

                $(".J_price").text(dj*n);
            }
            else
                alert("一个用户最多买四个座位");
        }
        if (n == 0)
        {
            $(".No_set").css("display", "block");
            $(".J_seatNum_tips").css("display", "block");
            $(".J_seatNum_text").css("display", "none");

        }           
        else
        {
            $(".No_set").css("display", "none");
            $(".J_seatNum_tips").css("display", "none");
            $(".J_seatNum_text").css("display", "block");
        }
           
    })
});</script>
    <div class="center-wrap">
    <div class="seat-step">
        <ul>
            <li class="down"><s></s>1.选择影片，场次</li>
            <li class="current">2.选座，填手机号</li>
            <li class="future">3.确认订单，支付</li>
            <li class="future">4.支付成功，影院取票观影</li>
        </ul>
    </div>
</div>
    <div class="center-wrap seat-wrap">
    <div class="seat-left">
        <div class="clearfix">
            <div class="J_coulmn" id="coulmn" runat="server">
                <ul>
                   <%-- <label style="top: 0px; line-height: 32.53px; position: absolute;">1</label>
                    <label style="top: 33px; line-height: 32.53px; position: absolute;">2</label>
                    <label style="top: 65px; line-height: 32.53px; position: absolute;">3</label>
                    <label style="top: 98px; line-height: 32.53px; position: absolute;">4</label>
                    <label style="top: 130px; line-height: 32.53px; position: absolute;">5</label>
                    <label style="top: 163px; line-height: 32.53px; position: absolute;">6</label>
                    <label style="top: 195px; line-height: 32.53px; position: absolute;">7</label>
                    <label style="top: 228px; line-height: 32.53px; position: absolute;">8</label>--%>

                </ul></div>
            <div class="seatContainer" style="height: 465.86px;">
                <div class="seatTitle">
                    <h2>
                   <%--  广汉天智国际影城 5号激光厅 银幕--%>
                        <asp:Label ID="p_name" Font-Size="22px" runat="server"></asp:Label>
                    </h2>
                    <s></s>
                </div>
                <div class="seatChoose J_Boundry">
                    <div class="seat_zuo J_seat_zuo" id="seat" runat="server">
                    <%--     <div class="unregular-seat seat-cell " style="width: 46px; height: 33px; margin-top: 0px; margin-left: 0px;" data-name="1排1座" data-flag="0" data-seatid="4827"></div> 
                        <div class="unregular-seat seat-cell " style="width: 46px; height: 33px; margin-top: 0px; margin-left: 46px;" data-name="1排2座" data-flag="0" data-seatid="4828"></div> 
                        <div class="unregular-seat seat-cell " style="width: 46px; height: 33px; margin-top: 0px; margin-left: 91px;" data-name="1排3座" data-flag="0" data-seatid="4829"></div>
              --%> </div>
            </div>
        </div>
        <div class="seatChooseInfor">
            <ul class="clearfix">
                <li><span class="hasSeat"></span>可选座位</li>
                <li><span class="sellSeat"></span>已选座位</li>
                <li><span class="checkSeat"></span>不可选座位</li>
                <li><span class="loveSeat"></span>情侣座</li>
            </ul>
																				            <p> 本影厅共有座位97个，当前已售<span class="J_sell">0</span>个</p>
			        </div>
        

    </div>
   
</div>
         <div class="seat-right">
        <div class="seatMovie clearfix">
            <div class="picBox">
                <a href="https://www.taopiaopiao.com/showDetail.htm?showId=211693&amp;n_s=new">
					<img src="https://img.alicdn.com/bao/uploaded/i3/TB12V0Iiv6H8KJjSspmXXb2WXXa_.jpg_120x120.jpg"></a>
            </div>
            <ul>
                <li><h3 id="m_name" runat="server"> </h3></li>
                <li id="m_voice" runat="server"> </li>      
                      
                <li id="m_time" runat="server"></li>            </ul>
        </div>
        <div class="seatContent">
            <ul>
                <li>
                    <label>影院：</label>
                    <strong id="yY_name" runat="server"></strong>
                </li>
                <li>
                    <label>影厅：</label>
                    <strong id="yT_name" runat="server"></strong>
                </li>
                <li>
                    <label>场次：</label>
                  <%--  <a class="changPlace J_show" href="javascript:"><s></s>更换场次</a>--%>
                    <em id="p_time" runat="server"></em>
                </li>
                <li class="line">
                    <label>座位:</label>
                    <span class="No_set">还未选择座位</span>
                    <div class="J_pewGroup"></div>
                     <p class="J_seatNum_tips">点击<em>左侧座位图</em>选择座位，再次点击取消</p>
                    <p class="J_seatNum_text" style="display: none;">已选择<em id="count"></em>个座位，再次点击座位可以取消</p>
                </li>
				<li>
                    <label>原价：</label>
                    <span class="J_originPrice originPrice" data-originprice="2800">¥<asp:Label ID="jiaGe" CssClass="jiaQian" runat="server"  ></asp:Label> x <i id="num"></i></span>
                    <span class="offer J_originOffer"></span>
                </li> 
								
				                <li class="total">
                    <label>总计:</label>
                    <div>
                        ¥
                        <span class="J_price" data-price="2800">
						
						</span>
                    </div>
                </li>
            </ul>
        </div>
        <div class="seatForm">
            <input class="J_scheduleId" id="scheduleId" type="hidden" value="479109857"/>
							<input class="J_seatNum" id="maxCanBuy" type="hidden" value="4"/>
						            <input class="J_seatNum" id="seatInfo" type="hidden">
            <input name="_tb_token_" type="hidden" value="cb533ad56735"/>
            <ul>
            <li>
                    <asp:Button CssClass="sub J_bt"  runat="server" Text="确认信息，下单" />
                </li>
            </ul>
        </div>
        
    </div>
        </div>
   
</asp:Content>

