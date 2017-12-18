using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ManageUI.Movie
{
    public partial class MovieFrm : System.Web.UI.Page
    {
        static SqlDataReader sr;

        DataTable dt;
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;
            sr = BLL.MovieManage.searchMovieAll_sr();
            //sr = BLL.MovieManage.search_NewMovie_byDate_sr("2017/12/18");
           
            dt = new DataTable();
            dt.Load(sr);
            Application["dt"] = dt;
            InitGridView();
        }

        protected void gv_PageIndexChanging(object sender, GridViewPageEventArgs e)
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
            InitGridView();
          


        }

        void InitGridView()
        {
            //dt = (DataTable)Application["dt"];
            gv.DataSource = dt;

            gv.DataBind();
        
        }

        protected void Unnamed_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void Unnamed_Click1(object sender, ImageClickEventArgs e)
        {

        }

        protected void tbn_dateSearch_Click(object sender, EventArgs e)
        {
            //Utility.JavaScript.Alert("sac",this);
            string str = data.Value.Trim();
            //string str1 = str.Replace('/','-');
            sr = BLL.MovieManage.search_NewMovie_byDate_sr(str);
            dt = new DataTable();
            dt.Load(sr);
            InitGridView();
            //Application["dt"] = dt;
            //InitGridView();
        }
    }
}