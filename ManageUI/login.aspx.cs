using System;
using DAL;
using Utility;
using ManageUI;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ManageUI
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;
            if (IsPostBack)
            {



            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string name = username.Text.Trim();
            string pwd = password.Text.Trim();
            string pass = BLL.Manage_Manager.MD5(pwd);


            if (BLL.Manage_Manager.PanDuan_SuperManage(name, pass))
            {
                Session["name"] = name;
                Session["limit"] = "super";
                    Response.Redirect("~/Index.aspx");
            }
            else if (BLL.Manage_Manager.PanDuan_CommonManage(name, pwd))
            {
                Session["name"] = name;
                Session["limit"] = "commit";
                Response.Redirect("~/Index.aspx");
            }
            else
            {
                JavaScript.Alert("请输入正确的用户名或密码",this);
            }
        }
    }
}