using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;

namespace ManageUI.DianYingTing
{
    public partial class DianYingTingTianJiaFrm : System.Web.UI.Page
    {
        static int y_id;
        protected void Page_Load(object sender, EventArgs e)
        {
            //Session["name"] = "yyl01";
            UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;
            if (Object.Equals(Session["name"], null))
            {//判断在Session["AdminName"]是否存在值
                Utility.JavaScript.AlertAndRedirect("请登录", "..//login.aspx", this);
            }
            else
            {

                string AdminName = Session["name"].ToString();

                y_id = BLL.DianYingYuanManage.search_DianYingYuanId_byM_name(AdminName);
            }
        }

        protected void btn_tianija_Click(object sender, EventArgs e)
        {
            String name = DYT_name.Text.Trim();
            int row =int.Parse( DYT_row.Text.Trim());
            int line =int.Parse( DYT_line.Text.Trim());
            int sum = row * line;
            Model.DianYingTing dyt = new Model.DianYingTing();
            dyt.T_name = name;
            dyt.T_count = sum;
            dyt.T_row = row;
            dyt.T_line = line;
            dyt.Y_id = y_id;

            if (BLL.DianYingTingManage.PanDuan_DianYingTingExist(name, y_id))
            {
                if (BLL.DianYingTingManage.Insert_DianYingTing(dyt))
                    Utility.JavaScript.Alert("添加成功",this);
                else
                    Utility.JavaScript.Alert("添加失败", this);

            }
        }

        protected void btn_fanhui_Click(object sender, EventArgs e)
        {

        }
    }
}