using System;
using Model;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ManageUI
{
    public partial class ManagerTianjiaFrm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;
            List<string> proList = DAL.CityServer.getProvice();
            foreach (string st in proList)
            {
                ddl_proice.Items.Add(st);
               
            }
       
            if (IsPostBack)
            {



            }
        }

        protected void btn_tianija_Click(object sender, EventArgs e)
        {
            
            string name = DYY_name.Text.Trim();
            string dz = DYY_address.Text.Trim();
            string phone = DYY_phone.Text.Trim();
            string pro = ddl_proice.Text.Trim();
            string city = ddl_city.SelectedItem.ToString();
            string area = ddl_area.SelectedItem.ToString();
            DianYingYuan ddy = new DianYingYuan();
            ddy.Y_Name = name;
            ddy.Y_address = dz;
            ddy.Y_phone = phone;
            ddy.Y_provice = pro;
            ddy.Y_city = city;
            ddy.Y_area = area;
            if (BLL.DianYingYuanManage.PanDuan_DianYingYianExist(name))
            {

                BLL.DianYingYuanManage.addTianYingYuan(ddy);
                Utility.JavaScript.Alert("添加成功", this); 
            }
            else
                Utility.JavaScript.Alert("电影院名已经存在",this); 
        }

        protected void btn_fanhui_Click(object sender, EventArgs e)
        {

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

   
    }
}