using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TaoPiaoPiao
{
    public partial class LOGING : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
          
            UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;
            if (IsPostBack)
            {
               

               
            }
        }

        //protected void load_Click(object sender, EventArgs e)
        //{
        //    //Label1.Text = "请输入用户名";
        //    //if (userName.Text == "这里输入登录名")
        //    //    Label1.Text = "请输入用户名";
        //    //if (userName.Text != null && password.Text == null)
        //    //    Label1.Text = "请输入用户密码";
        //    //if (UsersServer.PanDuan_User(userName.Text, password.Text))
        //    //Response.Write("<script>alert('成功')</script>");
        //    if (RequiredFieldValidatorName.IsValid)
        //    {
        //        //Panel1.Visible = true;
        //        //RequiredFieldValidatorPwd.Display = ValidatorDisplay.None;
        //        Response.Write("<script>alert('成功')</script>");
        //    }
        //}

      

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Panel1.Visible = true;
            //Response.Write("<script>alert('成功')</script>");
            string name = userName.Text.Trim();
            string pwd = password.Text.Trim();
            
            if (UsersServer.PanDuan_User(name, pwd))
            {
                Session["id"] = UsersServer.ChaXunUserId(name); 
                //lab_msg.Text = "登录成功！";
                Response.Write("<script>alert('登录成功')</script>");
                Response.Redirect("~/zy.aspx");
                
            }
            else
                Response.Write("<script>alert('用户名或密码错误')</script>");
        }
    }
}