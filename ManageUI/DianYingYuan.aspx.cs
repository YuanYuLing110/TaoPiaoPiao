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
      static  SqlDataReader sr;
   
       DataTable dt;
  
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;
            sr = BLL.DianYingYuanManage.search_DianYingYuan_All();
          
            //sr = BLL.DianYingYuanManage.search_DianYingYuan_byGradeCityAll_sr("成都市");
            dt = new DataTable();
            dt.Load(sr);
            Application["dt"] = dt;
            bind();
         List<string> proList=   DAL.CityServer.getProvice();
            foreach (string st in proList)
            {
              ddl_Sheng.Items.Add(st);
            }
       
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
            //this.gv.PageIndex = int.Parse(this.ddlCurrentPage.SelectedItem.ToString()) - 1;
            //Utility.JavaScript.Alert(this.ddlCurrentPage.SelectedIndex.ToString(),this);
            //bind();
        }

        public void bind()
        {
            //sr = BLL.DianYingYuanManage.search_DianYingYuan_byGradeCityAll_sr("成都市");
            //dt = new DataTable();
            //dt.Load(sr);
            dt = (DataTable)Application["dt"];
            gv.DataSource = dt;
        
            gv.DataBind();
            this.ddlCurrentPage.Items.Clear();
            for (int i = 1; i <= this.gv.PageCount; i++)
            {
                this.ddlCurrentPage.Items.Add(i.ToString());
            }
            ddlCurrentPage.SelectedIndex = this.gv.PageIndex;
        }

        protected void gv_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            //gv.PageIndex = e.NewPageIndex;
            //bind();

        }

        protected void btn_chaxun_Click(object sender, ImageClickEventArgs e)
        {
            string city = ddl_city.SelectedItem.ToString();
            string area = ddl_area.SelectedItem.ToString();
            if (area.Equals("全部"))
            {
                sr = BLL.DianYingYuanManage.search_DianYingYuan_byGradeCityAll_sr(city);
                dt = new DataTable();
               dt.Load(sr);
               Application["dt"] = dt;
               this.gv.PageIndex = 0;
               bind();
               


            }
            else
            {
                sr = BLL.DianYingYuanManage.search_DianYingYuan_byGradeAreaAll_sr(area);
                dt = new DataTable();
                dt.Load(sr);
                Application["dt"] = dt;
               this.gv.PageIndex = 0;
                bind();
               

            }
           
            //BLL.DianYingYuanManage.
            //Utility.JavaScript.Alert(city + ":" + area, this);
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
            //Utility.JavaScript.Alert("修改", this);
            ImageButton ib = (ImageButton)sender;
            int i = int.Parse(ib.CommandArgument);
            Response.Redirect("DianYingYuanEdit.aspx?Y_id="+i);
        }

        protected void Unnamed_Click1(object sender, ImageClickEventArgs e)
        {
            ImageButton ib = (ImageButton)sender;
            int id = int.Parse(ib.CommandArgument);
            //int id = (int)e.
            //Utility.JavaScript.Alert("删除" + i, this);
            BLL.DianYingYuanManage.deleteDianYingYuan(id);
        }


        protected void ddl_Sheng_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Utility.JavaScript.Alert("nj", this);
            string ProvinceName = ddl_Sheng.SelectedItem.ToString();
            List<string> cityList = DAL.CityServer.getCity(ProvinceName);
          
            ddl_city.Items.Clear();
            ddl_area.Items.Clear();

            foreach (string st in cityList)
            {
                ddl_city.Items.Add(st);
            }
       
        }

        protected void ddl_city_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Utility.JavaScript.Alert("nj", this);
            string ProvinceName = ddl_city.SelectedItem.ToString();
            List<string> cityList = DAL.CityServer.getDistricts(ProvinceName);

            
            ddl_area.Items.Clear();
            ddl_area.Items.Add("全部");
            foreach (string st in cityList)
            {
                //dd .Items.Add(st);
                ddl_area.Items.Add(st);
            }

        }

      

    }
}