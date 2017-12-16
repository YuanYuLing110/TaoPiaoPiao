using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ManageUI.DianYingTing
{
    public partial class MainFrm : System.Web.UI.Page
    {

        static SqlDataReader sr;

        //static DataTable dt;
  
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;
            if (Object.Equals(Session["name"], null))
            {//判断在Session["AdminName"]是否存在值
                Utility.JavaScript.AlertAndRedirect("请登录", "..//login.aspx", this);
            }
            else
            {

                string AdminName = Session["name"].ToString();
                lal_DianYingYuan.Text = BLL.Manage_Manager.Search_DianYingYuan_byManageName(AdminName);
                bind();

            }
          
        }

        public void bind()
        {
            string AdminName = Session["name"].ToString();
            sr = BLL.DianYingTingManage.search_DianYingTing_All(AdminName);
            DataTable dt = new DataTable();
            dt.Load(sr);
            gv.DataSource = dt;
            gv.DataBind();
        
        }
     

     

        protected void Unnamed_Click(object sender, ImageClickEventArgs e)
        {
          
            Utility.JavaScript.Alert("编辑", this);
        }

        protected void Unnamed_Click1(object sender, ImageClickEventArgs e)
        {
            Utility.JavaScript.Alert("删除", this);
        }

        protected void gv_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gv.PageIndex = e.NewPageIndex;
            bind();

        }

     
    }
}