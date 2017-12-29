using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using System.Web.UI.HtmlControls;

public partial class showDetail : System.Web.UI.Page
{
  static  int movieid;
  static string cinemaArea;
  static string cityName;
  static string provinceName;
  static bool evenExit = false;
  static string name_area;
  static string name_dyy;
  static bool first = true;
    protected void Page_Load(object sender, EventArgs e)
    {
        //movieid =int.Parse( Request.QueryString["movieID"].ToString());

        movieid = 48;
        Movie movie = BLL.MovieManage.search_Movie_byId(movieid);
        title.InnerText = movie.M_name;
        score.InnerText = movie.M_grade.ToString();
        Image image = new Image();
        image.Width = 200;
        image.Height = 300;
        image.ImageUrl = "getpic1.aspx?id=" + movie.M_id;
        div_img.Controls.Add(image);
        direct.InnerText = "导演：" + movie.M_direct;
        star.InnerText = "主演：" + movie.M_star;
        type.InnerText = "类型：" + movie.M_type;
        state.InnerText = "制片国家/地区：" + movie.M_state;
        voice.InnerText = "语言：" + movie.M_voice;
        minute.InnerText = "片长：" + movie.M_minute + "分钟";
        detail.InnerText = "剧情介绍：" + movie.M_detail;
        Session["province"] = "四川省";
        Session["city"] = "德阳市";
        DateTime now=DateTime.Now;
        DateTime after;
        DateTime dt =Convert.ToDateTime( movie.M_time);
        int num = now.Day - dt.Day;

        for (int i = 0; i < num; i++)
        {
            after = now.AddDays(i);
        }
           

            cityName = Session["city"].ToString();
      
        provinceName = Session["province"].ToString();
        DAL.CityServer.getProvice();
        DAL.CityServer.getCity(provinceName);
        List<string> listArea = DAL.CityServer.getDistricts(cityName);
        HtmlGenericControl a = new HtmlGenericControl("a");

      

            createArea("全部区域", "全部区域");
            foreach (string st in listArea)
                createArea(st, "全部区域");

            List<DianYingYuan> listDYY = BLL.DianYingYuanManage.search_DianYingYuan_byGradeCityAll(cityName); 
            foreach (DianYingYuan dyy in listDYY)
                createDianYingYuan(dyy.Y_Name, listDYY[0].Y_Name);
       
    }

    void createArea(string area,string xz)
    {
        //HtmlGenericControl a = new HtmlGenericControl("a");
        //a.InnerText = area;
        //select_tags.Controls.Add(a);
        Button btn = new Button();
        btn.Command+=btn_Command;
        btn.Text = area;
        //btn.BackColor = Transparent;
        if (area.Equals(xz))
            btn.CssClass = "current2";
        else
        btn.CssClass = "btnBefore";
       
        btn.BorderColor = System.Drawing.Color.Transparent;
        btn.BorderStyle = System.Web.UI.WebControls.BorderStyle.None;
        select_tags.Controls.Add(btn);
    }

    private void btn_Command(object sender, CommandEventArgs e)
    {
        Button btn2 = (Button)sender;
        name_area = btn2.Text.ToString();
        //throw new NotImplementedException();
        //int count = select_tags.Controls.Count;
        select_tags.Controls.Clear();
        select_dyy.Controls.Clear();

        List<string> listArea = DAL.CityServer.getDistricts(cityName);
        createArea("全部区域", name_area);
        foreach (string str in listArea)
            createArea(str, name_area);

        List<DianYingYuan> listDYY = BLL.DianYingYuanManage.search_DianYingYuan_byGradeAreaAll(name_area);
        foreach(DianYingYuan dyy in listDYY)
        createDianYingYuan(dyy.Y_Name,listDYY[0].Y_Name);
        //btn.CssClass = "current2";
        ////btn.CssClass = "btnBefore";
        //btn.ID = "cur";
        //Utility.JavaScript.Alert("aaaaaa",this);
    }

    private void btn_Command2(object sender, CommandEventArgs e)
    {
        Button btn2 = (Button)sender;
        name_dyy = btn2.Text.ToString();
        select_dyy.Controls.Clear();
        List<DianYingYuan> listDYY = BLL.DianYingYuanManage.search_DianYingYuan_byGradeAreaAll(name_area);
        foreach (DianYingYuan dyy in listDYY)
            createDianYingYuan(dyy.Y_Name, name_dyy);
        //Button btn2 = (Button)sender;
        //string st = btn2.Text.ToString();
        ////throw new NotImplementedException();
        ////int count = select_tags.Controls.Count;
        //select_tags.Controls.Clear();
        //List<string> listArea = DAL.CityServer.getDistricts(cityName);
        //createArea("全部区域", st);
        //foreach (string str in listArea)
        //    createArea(str, st);

        //List<DianYingYuan> listDYY = BLL.DianYingYuanManage.search_DianYingYuan_byGradeAreaAll(st);
        //createDianYingYuan(listDYY);
        //btn.CssClass = "current2";
        ////btn.CssClass = "btnBefore";
        //btn.ID = "cur";
        //Utility.JavaScript.Alert("aaaaaa",this);
    }

    void createDianYingYuan(string area, string xz)
    {
        //HtmlGenericControl a = new HtmlGenericControl("a");
        //a.InnerText = area;
        //select_tags.Controls.Add(a);
        Button btn = new Button();
        btn.Command += btn_Command2;
        btn.Text = area;
        //btn.BackColor = Transparent;
        if (area.Equals(xz))
            btn.CssClass = "current2";
        else
            btn.CssClass = "btnBefore2";

        btn.BorderColor = System.Drawing.Color.Transparent;
        btn.BorderStyle = System.Web.UI.WebControls.BorderStyle.None;
        select_dyy.Controls.Add(btn);
    }

    void createDays(DateTime dt,string date) 
    { 

           Button btn = new Button();
        btn.Command+=btn_Command;
        string time= dt.Month+"月"+dt.Day+'日';
        btn.Text =time;
        //btn.BackColor = Transparent;
        if (time.Equals(date))
            btn.CssClass = "current2";
        else
        btn.CssClass = "btnBefore";
       
        btn.BorderColor = System.Drawing.Color.Transparent;
        btn.BorderStyle = System.Web.UI.WebControls.BorderStyle.None;
        select_time.Controls.Add(btn);
    
    }
}