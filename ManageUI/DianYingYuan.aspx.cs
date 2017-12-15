using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ManageUI
{
    public partial class ManageFrm : System.Web.UI.Page
    {
        SqlDataReader sr;
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;
            sr = BLL.DianYingYuanManage.search_DianYingYuan_All();
            bind();
            if (IsPostBack)
            {

               

            }
          
          //  gv.DataSource = BLL.DianYingYuanManage.search_DianYingYuan_All();
          //gv.DataBind();
        }

        protected void lnkbtnFrist_Click(object sender, EventArgs e)
        {
            this.gv.PageIndex = 0;
            bind();
        }

        protected void lnkbtnPre_Click(object sender, EventArgs e)
        {
            if (this.gv.PageIndex > 0)
            {
                this.gv.PageIndex = this.gv.PageIndex - 1;
                bind();
            }
        }

        protected void lnkbtnNext_Click(object sender, EventArgs e)
        {
            if (this.gv.PageIndex < this.gv.PageCount)
            {
                this.gv.PageIndex = this.gv.PageIndex + 1;
                bind();
            }
        }

        protected void lnkbtnLast_Click(object sender, EventArgs e)
        {
            this.gv.PageIndex = this.gv.PageCount;
            bind();
        }

        protected void ddlCurrentPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.gv.PageIndex = this.ddlCurrentPage.SelectedIndex;
            bind();
        }

        public void bind()
        {
            //SqlDataReader sr = BLL.DianYingYuanManage.search_DianYingYuan_All();
            DataTable dt = new DataTable();
            sr = BLL.DianYingYuanManage.search_DianYingYuan_All();
            dt.Load(sr);
            gv.DataSource = dt;
            //gv.DataKeyNames = new string[] { "学号" };
            gv.DataBind();
            this.ddlCurrentPage.Items.Clear();
            for (int i = 1; i <= this.gv.PageCount; i++)
            {
                this.ddlCurrentPage.Items.Add(i.ToString());
            }
            this.ddlCurrentPage.SelectedIndex = this.gv.PageIndex;
        }

        protected void gv_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gv.PageIndex = e.NewPageIndex;
            bind();

        }

        protected void btn_chaxun_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void btn_all_Click(object sender, EventArgs e)
        {
            BLL.DianYingYuanManage.search_DianYingYuan_All();
        }

        protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            //Utility.JavaScript.Alert("修改", this);
            //ImageButton ib = (ImageButton)e.CommandSource;
            //if(ib.ID=="xiuGai")
            //    Utility.JavaScript.Alert("修改", this);
            //if (e.CommandName=="xiuGai")
            //{
            //    Utility.JavaScript.Alert("修改",this);
            //}
            //else if (e.CommandName == "delete")
            //{
            //    int id = (int)e.CommandArgument;
            //    Utility.JavaScript.Alert(id.ToString(), this);
            //    //BLL.DianYingYuanManage.deleteDianYingYuan(id);
            //}
        }

        protected void Unnamed_Click(object sender, ImageClickEventArgs e)
        {
            Utility.JavaScript.Alert("修改", this);
        }

        protected void Unnamed_Click1(object sender, ImageClickEventArgs e)
        {
            ImageButton ib = (ImageButton)sender;
            int i = int.Parse(ib.CommandArgument);
            //int id = (int)e.
            Utility.JavaScript.Alert("删除" + i, this);
            //BLL.DianYingYuanManage.deleteDianYingYuan(id);
        }

        protected void gv_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ImageButton ib = (ImageButton)sender;
            //int i = int.Parse(ib.CommandArgument);
            //Utility.JavaScript.Alert("删除" + i, this);

          
        }

    }
}