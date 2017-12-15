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
            if (IsPostBack)
            {



            }
        }

        protected void btn_tianija_Click(object sender, EventArgs e)
        {
            string name = DYY_name.Text.Trim();
            string dz = DYY_address.Text.Trim();
            string phone = DYY_phone.Text.Trim();
            string city = DYY_city.Text.Trim();
            string area = DYY_Aream.Text.Trim();
            DianYingYuan ddy = new DianYingYuan();
            ddy.Y_Name = name;
            ddy.Y_address = dz;
            ddy.Y_phone = phone;
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
    }
}