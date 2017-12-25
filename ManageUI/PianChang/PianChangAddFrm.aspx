<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PianChangAddFrm.aspx.cs" Inherits="ManageUI.PianChang.PianChangAddFrm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
   
    <link href="../CSS/PianChangAdd.css" rel="stylesheet" />

    <link rel="stylesheet" type="text/css" href="../assets/css/bootstrap.min.css"/>
<link rel="stylesheet" type="text/css" href="../dist/bootstrap-clockpicker.min.css"/>
<link rel="stylesheet" type="text/css" href="../assets/css/github.min.css"/>
    
    <style type="text/css">


</style>

     <link href="../CSS/kalendae.css" rel="stylesheet" />
    <script src="../JS/kalendae.standalone.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div class="main">
      <label>电影厅：</label>
    <asp:DropDownList runat="server" ID="ddl_pianChang" CssClass="ddl"></asp:DropDownList><br /><br />

         <label>电影：</label>
    <asp:DropDownList runat="server" ID="ddl_Coming" CssClass="ddl" ></asp:DropDownList>  <br />
         
        <label>设置日期：</label>
         <input type="text" id="m_time" class="auto-kal txt" data-kal="direction: 'future'" runat="server" /><br /><br />
        <div  style="clear: both;"></div>
        
        <label>设置时间：</label>
   <div class="input-group clockpicker">
			<input type="text" class="form-control" value="09:30" id="txt_hour" runat="server"/>
			<span class="input-group-addon">
				<span class="glyphicon glyphicon-time"></span>
			</span>

        <hr />
    </div>        <label>价格</label>
        <asp:TextBox runat="server" ID="tb_price"></asp:TextBox><br />
        <asp:Button runat="server" ID="btn_Add" Text="添加" CssClass="add" OnClick="btn_Add_Click" />
     
        </div>
        <script type="text/javascript" src="../assets/js/jquery.min.js"></script>
<script type="text/javascript" src="../assets/js/bootstrap.min.js"></script>
<script type="text/javascript" src="../dist/bootstrap-clockpicker.min.js"></script>
<script type="text/javascript">
$('.clockpicker').clockpicker()
	.find('input').change(function(){
		console.log(this.value);
	});
var input = $('#single-input').clockpicker({
	placement: 'bottom',
	align: 'left',
	autoclose: true,
	'default': 'now'
});

// Manually toggle to the minutes view
$('#check-minutes').click(function(e){
	// Have to stop propagation here
	e.stopPropagation();
	input.clockpicker('show')
			.clockpicker('toggleView', 'minutes');
});
if (/mobile/i.test(navigator.userAgent)) {
	$('input').prop('readOnly', true);
}
</script>
<script type="text/javascript" src="../assets/js/highlight.min.js"></script>
<script type="text/javascript">
hljs.configure({tabReplace: '    '});
hljs.initHighlightingOnLoad();
</script>
    </form>
  
</body>
</html>
