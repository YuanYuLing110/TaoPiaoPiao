using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;

namespace ManageUI
{
    public partial class RegisterPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;
            jiaZai();
        }
        public void jiaZai()
        {
             Session["name"] = "yyl01";
             if (Object.Equals(Session["name"], null))
             {//判断在Session["AdminName"]是否存在值
                 Utility.JavaScript.AlertAndRedirect("请登录", "..//login.aspx", this);
             }
             else
             {
               

                 string name = Session["name"].ToString();
                int  y_id = BLL.DianYingYuanManage.search_DianYingYuanId_byM_name(name);
                 //int y_id = 11;
                 //Utility.JavaScript.Alert(y_id.ToString(), this);
                 //DianYingYuan dyy = BLL.DianYingYuanManage.search_DianYingYuan_idl(y_id);


                 List<string> proList = DAL.CityServer.getProvice();
                 foreach (string st in proList)
                 {
                     ddl_proice.Items.Add(st);

                 }
               



              


               

                 


             }
        }
        protected void ddl_proice_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ProvinceName = ddl_proice.SelectedItem.ToString();
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
            string ProvinceName = ddl_city.SelectedItem.ToString();
            List<string> cityList = DAL.CityServer.getDistricts(ProvinceName);


            ddl_area.Items.Clear();

            foreach (string st in cityList)
            {
                //dd .Items.Add(st);
                ddl_area.Items.Add(st);
            }
        }

        protected void ddl_area_SelectedIndexChanged(object sender, EventArgs e)
        {
            string AreaName = ddl_area.SelectedItem.ToString();
            ddl_dyy.Items.Clear();
            List<DianYingYuan> dyyList = BLL.DianYingYuanManage.search_DianYingYuan_byGradeAreaAll(AreaName);
            foreach (DianYingYuan st in dyyList)
            {
                ListItem li = new ListItem();
                li.Text = st.Y_Name;
                li.Value = st.Y_id.ToString();
                //dd .Items.Add(st);
                ddl_dyy.Items.Add(li);
            }
        }

        protected void btn_tianija_Click(object sender, EventArgs e)
        {
            string name = txt_name.Text.Trim();
            string pwd = txt_password.Text.Trim();
            string password = BLL.Manage_Manager.MD5(pwd);

            Model.Manage manage = new Manage();
            manage.Name = name;
            manage.Password = password;
            manage.Email = txt_email.Text.Trim();
            manage.DianYingYuan_id = int.Parse(ddl_dyy.SelectedValue);
            manage.Limit = null;
            if (BLL.Manage_Manager.PanDuan_manageExit(name))
            {
                if (BLL.Manage_Manager.addManage(manage))
                    Utility.JavaScript.Alert("注册成功，通过审核将发送至你的邮箱",this);
                Response.Redirect("~/login.aspx");
                

            }
            else
                Utility.JavaScript.Alert("该用户以存在", this);

        }

        protected void btn_fanhui_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/login.aspx");
        }
    }
}