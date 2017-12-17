<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MovieAddFrm.aspx.cs" Inherits="ManageUI.Movie.MovieAddFrm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="../CSS/kalendae.css" rel="stylesheet" />
    <link href="../CSS/MovieAddFrm.css" rel="stylesheet" />
    <script src="../resources/scripts/jquery-1.3.2.min.js"></script>
    <script>
        function PreviewImg(imgFile) {
            //alert(imgFile.value);
            var ext = imgFile.value.toLowerCase().substring(imgFile.value.length - 3, imgFile.value.length);
            if (ext == "jpg" || ext == "png" || ext == "gif" || ext == "bmp") {
              
            
                var str = imgFile.value;
               
                var str1 = str.replace(/\\/g, '/');
            
                $("#newPreview").css("background-image", "url(" + str1 + ")");
               
            }
        }
    
        $(document).ready(function () {
          
        })
    </script>

    <script src="../JS/kalendae.standalone.js"></script>
  <%--  <style>
        #newPreview {FILTER: progid:DXImageTransform.Microsoft.AlphaImageLoader(sizingMethod=scale)}  
    </style>--%>
</head>
<body>
    <form id="form1" runat="server">
        <div id="zuo" class="cl">
            <table>
                <tr>
                    <td>
                        <label>电影名：</label></td>
                    <td>
                        <asp:TextBox runat="server" ID="m_name" CssClass="txt"></asp:TextBox></td>
                </tr>
                <tr>

                    <td>
                        <label>导演:</label>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="m_direct" CssClass="txt"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        <label>主演：</label></td>
                    <td>
                        <asp:TextBox runat="server" ID="m_star" CssClass="txt"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        <label>类型：</label></td>
                    <td>
                        <asp:TextBox runat="server" ID="m_type" CssClass="txt"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        <label>语言：</label></td>
                    <td>
                        <asp:TextBox runat="server" ID="m_voice" CssClass="txt"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        <label>放映时间:</label></td>
                    <td>
                        <input type="text" id="m_time" class="auto-kal txt" data-kal="direction: 'future'" /></td>
                </tr>
                <tr>
                    <td>
                        <label>专业评分：</label></td>
                    <td>
                        <asp:TextBox runat="server" ID="m_grade"></asp:TextBox></td>
                </tr>


            </table>


        </div>
        <div id="you" class="cl">

            <label>详情：</label>
            <br />
            <textarea style="width: 300px; height: 100px;"></textarea>
            <br />
            <label>添加电影宣传图片：</label>
            <br />
            <asp:FileUpload ID="File1" runat="server" onchange="PreviewImg(this)" />

            <%--     <button type="button" onclick="document.getElementById('FileUpload').click();">选择图片</button>  --%>
            <br />
            <%--<asp:Image runat="server" Width="200px" ID="Image1" />--%>
            <img id="img1" width="200" src="E:/毕业设计/TaoPiaoPiao4/ManageUI/image/9f9fd69dd18c06cb8041935eebf1b3b5.jpg" />
        </div>
        <div style="clear: both;"></div>
        <%--<div id="newPreview"></div>--%>
        <%--<input type="file" onchange="PreviewImg(this)" id="upimg" runat="server"  />--%>

        <asp:Button runat="server" ID="btn_tianJia" Text="添加" CssClass="btn" />
        <asp:Button runat="server" ID="btn_cancel" Text="取消" CssClass="btn" />
    </form>
   
<div id="newPreview" style="width:200px;height:200px; "></div>  

  <%--  <img src="../image/bg.jpg" />--%>
 <%--   <img src="C:/Users/YuanYuLing/Pictures/TB1Q4NNKXXXXXXeXpXXdtacIVXX-125-173_jpeg_q90.jpg" />
     <img src="C:/Users/YuanYuLing/Pictures/img/img1.jpg" />--%>
   <%-- <div style="width:200px; height:200px;background-image:url('C:/Users/YuanYuLing/Pictures/TB1Q4NNKXXXXXXeXpXXdtacIVXX-125-173_jpeg_q90.jpg')" ></div>--%>
    <%--  <img src="E:/游戏/04.jpg" />
      <img src="E:/游戏/img7.jpg" />--%>
    <%-- <img src="../image/bg.jpg" />--%>
    <%--  <img src="E:/毕业设计/TaoPiaoPiao4/ManageUI/image/login-bg-8.jpg" />--%>
    <%--  <img src="../image/9f9fd69dd18c06cb8041935eebf1b3b5.jpg" />--%>
</body>
</html>
