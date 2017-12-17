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
         
            var ext = imgFile.value.toLowerCase().substring(imgFile.value.length - 3, imgFile.value.length);
            if (ext == "jpg" || ext == "png" || ext == "gif" || ext == "bmp") {
              
            
                var str = imgFile.value;
               
                var str1 = str.replace(/\\/g, '/');
            
                $("#newPreview").css("background-image", "url(" + str1 + ")");
               
            }
        }
    
    
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
                    <td>
<asp:RequiredFieldValidator  ControlToValidate="m_name"  ErrorMessage="电影名不能为空" ForeColor="Red"  Display="Dynamic"  runat="server" CssClass="verify"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>

                    <td>
                        <label>导演:</label>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="m_direct" CssClass="txt"></asp:TextBox></td>
                    <td>
  <asp:RequiredFieldValidator  ControlToValidate="m_direct"  ErrorMessage="导演名不能为空" ForeColor="Red"  Display="Dynamic"  runat="server" CssClass="verify"></asp:RequiredFieldValidator>                      
                    </td>
                </tr>
                <tr>
                    <td>
                        <label>主演：</label></td>
                    <td>
                        <asp:TextBox runat="server" ID="m_star" CssClass="txt"></asp:TextBox></td>
                    <td>
  <asp:RequiredFieldValidator  ControlToValidate="m_star"  ErrorMessage="导演名不能为空" ForeColor="Red"  Display="Dynamic"  runat="server" CssClass="verify"></asp:RequiredFieldValidator>                      

                    </td>
                </tr>
                <tr>
                    <td>
                        <label>类型：</label></td>
                    <td id="tb_Type">
                        <asp:CheckBox ID="cb_DongHua" runat="server" Text="动画" />
                         <asp:CheckBox ID="cb_Maoxian" runat="server" Text="冒险" />
                         <asp:CheckBox ID="cb_xiju" runat="server" Text="喜剧" />
                         <asp:CheckBox ID="cb_aiQing" runat="server" Text="爱情" />
                        <asp:CheckBox ID="cb_juQing" runat="server" Text="剧情" />
                        <br />
                            <asp:CheckBox ID="cb_zhanZheng" runat="server" Text="战争" />   
                         <asp:CheckBox ID="cb_keHuan" runat="server" Text="科幻" />
                           <asp:CheckBox ID="cb_qiHuan" runat="server" Text="奇幻" />
                           <asp:CheckBox ID="cb_jingSong" runat="server" Text="惊悚" />
                        <asp:CheckBox runat="server" ID="cb_dongZuo" Text="动作" />
 
                        <%--<asp:TextBox runat="server" ID="m_type" CssClass="txt"></asp:TextBox></td>--%>
                   
 <%-- <asp:RequiredFieldValidator  ControlToValidate="m_type"  ErrorMessage="导演名不能为空" ForeColor="Red"  Display="Dynamic"  runat="server" CssClass="verify"></asp:RequiredFieldValidator>                      --%>

                    </td>
                </tr>
                   <tr>
                    <td>
                        <label>地区：</label></td>
                    <td>
                               <asp:TextBox runat="server" ID="m_state"></asp:TextBox>
  <asp:RequiredFieldValidator  ControlToValidate="m_state"  ErrorMessage="地区不能为空" ForeColor="Red"  Display="Dynamic"  runat="server" CssClass="verify"></asp:RequiredFieldValidator>     
                
                   
                    </td>
                </tr>
                <tr>
                    <td>
                        <label>语言：</label></td>
                    <td>
                       
                        <asp:DropDownList runat="server" ID="ddl_voice">
                             <asp:ListItem>国语</asp:ListItem>    
                            <asp:ListItem>英语</asp:ListItem>
                                             
                        </asp:DropDownList>
                    </td>
                </tr>

                <tr>
                    <td>
                        <label>放映时间:</label></td>
                    <td>
                        <input type="text" id="m_time" class="auto-kal txt" data-kal="direction: 'future'" runat="server" /></td>
                    <td>
  <asp:RequiredFieldValidator  ControlToValidate="m_time"  ErrorMessage="必须选择上映时间" ForeColor="Red"  Display="Dynamic"  runat="server" CssClass="verify"></asp:RequiredFieldValidator>                      
</td>
                </tr>
                   <tr>
                    <td>
                        <label>片长：</label></td>
                    <td>
                        <asp:TextBox runat="server" ID="m_minute"></asp:TextBox>  </td>
                        <td>
  <asp:RequiredFieldValidator  ControlToValidate="m_minute"  ErrorMessage="片长不能为空" ForeColor="Red"  Display="Dynamic"  runat="server" CssClass="verify"></asp:RequiredFieldValidator>     
<%-- <asp:RangeValidator ControlToValidate="m_minute" ErrorMessage="输入必须是整数" ForeColor="Red"  Display="Dynamic"  runat="server" CssClass="verify"   Type="Integer"></asp:RangeValidator>--%>
                            </td>            

                  
                </tr>
                <tr>
                    <td>
                        <label>专业评分：</label></td>
                    <td>
                        <asp:TextBox runat="server" ID="m_grade"></asp:TextBox>
  <asp:RequiredFieldValidator  ControlToValidate="m_grade"  ErrorMessage="评分不能为空" ForeColor="Red"  Display="Dynamic"  runat="server" CssClass="verify"></asp:RequiredFieldValidator>     
 <asp:RangeValidator ControlToValidate="m_grade" ErrorMessage="输入必须是数字且范围为1~10" ForeColor="Red"  Display="Dynamic"  runat="server" CssClass="verify" MaximumValue="10" MinimumValue="0" Type="Double"></asp:RangeValidator>
                                        

                    </td>
                </tr>


            </table>


        </div>
        <div id="you" class="cl">

            <label>详情：</label>
            <br />
            <textarea id="txtarea" style="width: 300px; height: 100px;" runat="server"></textarea>
            <br />
            <label>添加电影宣传图片：</label>
            <br />
            <asp:FileUpload ID="File1" runat="server" onchange="PreviewImg(this)" />
            <div id="newPreview" style="width:200px;height:300px; "></div>  
            <%--     <button type="button" onclick="document.getElementById('FileUpload').click();">选择图片</button>  --%>
            <br />
          
        </div>
        <div style="clear: both;"></div>
     
        <asp:Button runat="server" ID="btn_tianJia" Text="添加" CssClass="btn" OnClick="btn_tianJia_Click" />
        <asp:Button runat="server" ID="btn_cancel" Text="取消" CssClass="btn" />
    </form>
   


 
</body>
</html>
