﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ManageUI
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Object.Equals(Session["name"], null))
            //{//判断在Session["AdminName"]是否存在值
            //    Utility.JavaScript.AlertAndRedirect("请登录","Index.aspx",this);
            //}
            //else
            //{//要是存在则记录下这个人的用户名
            //    string AdminName = Session["name"].ToString();
            //    name.Text = AdminName;
            //    if (Object.Equals(Session["limit"], "super"))
            //    {
            //        manage.Text = "超级";
            //    }
            //    else
            //    {
            //        manage.Text = BLL.Manage_Manager.Search_DianYingYuan_byManageName(AdminName);
            //    }
            //}


        }

        protected void name_Click(object sender, EventArgs e)
        {

        }

        protected void Manage_Click(object sender, EventArgs e)
        {
            iframe.Attributes["src"] = "DianYingYuanTianJiaFrm.aspx";
            
        }
    }
}