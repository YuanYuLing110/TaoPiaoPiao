using System;
using System.Collections.Generic;
using System.Linq;
using Model;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ManageUI
{
    public partial class DianYingYuanEdit : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;

            jiaZai();
            //BLL.DianYingYuanManage.
        }

        public void jiaZai()
        {
            int y_id = int.Parse(Request.QueryString["Y_id"]);
            //int y_id = 11;
            //Utility.JavaScript.Alert(y_id.ToString(), this);
            DianYingYuan dyy = BLL.DianYingYuanManage.search_DianYingYuan_idl(y_id);
            DYY_name.Text= dyy.Y_Name;
            DYY_address.Text = dyy.Y_address;
            DYY_phone.Text = dyy.Y_phone;
          
            List<string> proList = DAL.CityServer.getProvice();
            foreach (string st in proList)
            {
                ddl_proice.Items.Add(st);

            }
            ddl_proice.Text = dyy.Y_provice;



            List<string> cityList = DAL.CityServer.getCity(dyy.Y_provice);


            foreach (string st in cityList)
            {
                ddl_city.Items.Add(st);
            }
            ddl_city.Text = dyy.Y_city;


            List<string> districtsList = DAL.CityServer.getDistricts(dyy.Y_city);

            foreach (string st in districtsList)
            {
                //dd .Items.Add(st);
                ddl_area.Items.Add(st);
            }

            ddl_area.Text = dyy.Y_area;
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

        protected void btn_tianija_Click(object sender, EventArgs e)
        {
            string name = DYY_name.Text.Trim();
            string dz = DYY_address.Text.Trim();
            string phone = DYY_phone.Text.Trim();
            string pro = ddl_proice.SelectedItem.ToString();
            string city = ddl_city.SelectedItem.ToString();
            string area = ddl_area.SelectedItem.ToString();
            DianYingYuan ddy = new DianYingYuan();
            ddy.Y_Name = name;
            ddy.Y_address = dz;
            ddy.Y_phone = phone;
            ddy.Y_provice = pro;
            ddy.Y_city = city;
            ddy.Y_area = area;
            BLL.DianYingYuanManage.alterDianYingYuan(ddy);
            Response.Redirect("DianYingYuan.aspx");
        }

        protected void btn_fanhui_Click(object sender, EventArgs e)
        {
            Response.Redirect("DianYingYuan.aspx");
        }
    }
}