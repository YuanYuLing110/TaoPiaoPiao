using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;

namespace ManageUI.PianChang
{
    public partial class PianChangAddFrm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;
            Session["name"] = "yyl01";
            if (Object.Equals(Session["name"], null))
            {//判断在Session["AdminName"]是否存在值
                Utility.JavaScript.AlertAndRedirect("请登录", "..//login.aspx", this);
            }
            else
            {

                string AdminName = Session["name"].ToString();

              //int  y_id = BLL.DianYingYuanManage.search_DianYingYuanId_byM_name(AdminName);


                ddl_Coming.Items.Clear();
                List<Model.Movie> comingList = BLL.MovieManage.searchHotMovieAll();
                //ddl_Coming.
                for (int i = 0; i < comingList.Count; i++)
                {
                    string m_name = comingList[i].M_name.ToString();
                    int m_id = comingList[i].M_id;
                    ListItem li = new ListItem();
                    li.Text = m_name;
                    li.Value = m_id.ToString();
                    ddl_Coming.Items.Add(li);
                    //ddl_Coming.Items.Add();

                }

                ddl_pianChang.Items.Clear();
                List<Model.DianYingTing> dytList = BLL.DianYingTingManage.search_DianYingTing(AdminName);

                for (int i = 0; i < dytList.Count; i++)
                {
                    string t_name = dytList[i].T_name.ToString();
                    int t_id =  dytList[i].T_id;
                    ListItem li = new ListItem();
                    li.Text = t_name;
                    li.Value = t_id.ToString();
                    ddl_pianChang.Items.Add(li);
                    //ddl_Coming.Items.Add();

                }
            }
           

            //for(int i=0;i<)

            //ddl_Coming
        }

        protected void btn_Add_Click(object sender, EventArgs e)
        {
            int t_id =int.Parse( ddl_pianChang.SelectedValue);
            int m_id = int.Parse(ddl_Coming.SelectedValue);
            string time = "";
            string day = m_time.Value.ToString();
           
             
            string hour = txt_hour.Value.ToString();
            
            time = day +" "+ hour;
            DateTime dt = Convert.ToDateTime(time);
            int money =int.Parse( tb_price.Text.ToString());
            Model.PianChang pc = new Model.PianChang();
            pc.T_id = t_id;
            pc.M_id = m_id;
            pc.P_time = dt;
            pc.P_price = money;
            if (BLL.PianChangManage.Insert_DianYingTing(pc))
                Utility.JavaScript.Alert("添加成功",this);
            //Utility.JavaScript.Alert(time,this);
        }

     
        
    }
}