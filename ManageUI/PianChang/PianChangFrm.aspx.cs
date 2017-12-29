using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ManageUI.PianChang
{
    public partial class PianChangFrm : System.Web.UI.Page
    {
        static SqlDataReader sr;

        DataTable dt;
        int y_id;
        protected void Page_Load(object sender, EventArgs e)
        {

            Session["name"] = "yyl02";
            UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;

            string name = Session["name"].ToString();
            y_id = BLL.DianYingYuanManage.search_DianYingYuanId_byM_name(name);
            if(!IsPostBack)
            {
                if (Object.Equals(Session["name"], null))
                {//判断在Session["AdminName"]是否存在值
                    Utility.JavaScript.AlertAndRedirect("请登录", "..//login.aspx", this);
                }
                else
                {
                  


                    if (!IsPostBack)
                    {
                        //sr = BLL.MovieManage.search_NewMovie_byDate_sr("2017/12/18");
                        sr = BLL.PianChangManage.search_pianChang_All_sr(y_id);
                        dt = new DataTable();
                        dt.Load(sr);
                        Application["dt"] = dt;
                        InitGridView();
                        //ddl_movie.Items.Clear();
                        List<Model.Movie> comingList = BLL.MovieManage.searchHotMovieAll();
                        //ddl_Coming.
                        for (int i = 0; i < comingList.Count; i++)
                        {
                            string m_name = comingList[i].M_name.ToString();
                            int m_id = comingList[i].M_id;
                            ListItem li = new ListItem();
                            li.Text = m_name;
                            li.Value = m_id.ToString();
                            ddl_movie.Items.Add(li);
                            //ddl_Coming.Items.Add();

                        }

                        //ddl_dyt.Items.Clear();
                        List<Model.DianYingTing> dytList = BLL.DianYingTingManage.search_DianYingTing(name);

                        for (int i = 0; i < dytList.Count; i++)
                        {
                            string t_name = dytList[i].T_name.ToString();
                            int t_id = dytList[i].T_id;
                            ListItem li = new ListItem();
                            li.Text = t_name;
                            li.Value = t_id.ToString();
                            ddl_dyt.Items.Add(li);
                            //ddl_Coming.Items.Add();

                        }
            }
            //Session["name"] = "yyl01";
             

                 
                 
              }
            }
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
            dt = (DataTable)Application["dt"];
            gv.DataSource = dt;

            gv.DataBind();

        }

        protected void btn_movie_Click(object sender, EventArgs e)
        {
            //ddl_movie.Items.Clear();
            //ddl_dyt.Items.Clear();
            int m_id = int.Parse(ddl_movie.SelectedValue.ToString());

            //Utility.JavaScript.Alert(m_id + ":" + y_id, this);
            sr = BLL.PianChangManage.search_pianChang_byMovie_sr(m_id,y_id);
            dt = new DataTable();
            dt.Load(sr);
            Application["dt"] = dt;
            InitGridView();
        }

        protected void btn_dyt_Click(object sender, EventArgs e)
        {
            //ddl_movie.Items.Clear();
            //ddl_dyt.Items.Clear();
            int t_id = int.Parse(ddl_dyt.SelectedValue.ToString());
           
            //Utility.JavaScript.Alert(t_id.ToString(),this);
            sr = BLL.PianChangManage.search_pianChang_byDianYingTing_sr(t_id,y_id);
            dt=new DataTable();
            dt.Load(sr);
            Application["dt"] = dt;
            InitGridView();
        }
    }
}