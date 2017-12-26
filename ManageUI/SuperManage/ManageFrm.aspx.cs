using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ManageUI.SuperManage
{
    public partial class ManageFrm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;
            SqlDataReader sr = BLL.Manage_Manager.search_future_sr();
            DataTable dt = new DataTable();
            dt.Load(sr);
            gv_future.DataSource =dt;
            gv_future.DataBind();
 ;
        }

        protected void gv_future_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            // 得到该控件
            GridView theGrid = sender as GridView;
            int newPageIndex = 0;
            if (e.NewPageIndex == -3)
            {
                //点击了Go按钮
                TextBox txtNewPageIndex = null;

                //GridView较DataGrid提供了更多的API，获取分页块可以使用BottomPagerRow 或者TopPagerRow，当然还增加了HeaderRow和FooterRow
                GridViewRow pagerRow = theGrid.BottomPagerRow;

                if (pagerRow != null)
                {
                    //得到text控件
                    txtNewPageIndex = pagerRow.FindControl("txtNewPageIndex") as TextBox;
                }
                if (txtNewPageIndex != null)
                {
                    //得到索引
                    newPageIndex = int.Parse(txtNewPageIndex.Text) - 1;
                }
            }
            else
            {
                //点击了其他的按钮
                newPageIndex = e.NewPageIndex;
            }
            //防止新索引溢出
            newPageIndex = newPageIndex < 0 ? 0 : newPageIndex;
            newPageIndex = newPageIndex >= theGrid.PageCount ? theGrid.PageCount - 1 : newPageIndex;

            //得到新的值
            theGrid.PageIndex = newPageIndex;

            //重新绑定
            SqlDataReader sr = BLL.Manage_Manager.search_future_sr();
            DataTable dt = new DataTable();
            dt.Load(sr);
            gv_future.DataSource = dt;
            gv_future.DataBind();
        }

        protected void btn_tongYi_Click(object sender, EventArgs e)
        {
            Button ib = (Button)sender;
            int id = int.Parse(ib.CommandArgument);
            string email = DAL.ManageServer.getEmail(id);
            //int id = int.Parse();
            if (BLL.Manage_Manager.tongYiManage(id))
            {
                if (BLL.Manage_Manager.SendEmail(email))
                    Utility.JavaScript.Alert("已同意",this);
                

            }
        }

        protected void btn_buTongYo_Click(object sender, EventArgs e)
        {

        }
    }
}