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
  static string dyyName;
  static bool evenExit = false;
  static string name_area;
  static string name_dyy;
  static bool first = true;
    protected void Page_Load(object sender, EventArgs e)
    {
        //movieid =int.Parse( Request.QueryString["movieID"].ToString());
        #region 添加电影
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
        #endregion

        DateTime now=DateTime.Now;
        DateTime after;
        DateTime dt =Convert.ToDateTime( movie.M_time);
        int num = now.Day - dt.Day;

        for (int i = 0; i < num; i++)
        {
            after = now.AddDays(i);
            
        }

        #region 选择区域或电影院
        cityName = Session["city"].ToString();
      
        provinceName = Session["province"].ToString();
        DAL.CityServer.getProvice();
        DAL.CityServer.getCity(provinceName);
        List<string> listArea = DAL.CityServer.getDistricts(cityName);
        if (Request.QueryString["cinemaArea"] == null || (Request.QueryString["cinemaArea"]).Equals("全部区域"))
        {
            cinemaArea = "全部区域";
            createArea("全部区域", cinemaArea);
            foreach (string st in listArea)
                createArea(st, cinemaArea);



            List<DianYingYuan> listDYY = BLL.DianYingYuanManage.search_DianYingYuan_byGradeCityAll(cityName);
            if (Request.QueryString["dyyName"] == null)
            {
                foreach (DianYingYuan dyy in listDYY)
                    createDianYingYuan(dyy.Y_Name, listDYY[0].Y_Name);
            }
               

            else
            {
                dyyName = Request.QueryString["dyyName"];
                foreach (DianYingYuan dyy in listDYY)
                    createDianYingYuan(dyy.Y_Name, dyyName);
            }
        }
        else
        {
            cinemaArea = Request.QueryString["cinemaArea"];
            createArea("全部区域", cinemaArea);
            foreach (string st in listArea)
                createArea(st, cinemaArea);



            List<DianYingYuan> listDYY = BLL.DianYingYuanManage.search_DianYingYuan_byGradeAreaAll(cinemaArea);          

            if (Request.QueryString["dyyName"] == null)
            {
                foreach (DianYingYuan dyy in listDYY)
                    createDianYingYuan(dyy.Y_Name, listDYY[0].Y_Name);
            }


            else
            {
                dyyName = Request.QueryString["dyyName"];
                foreach (DianYingYuan dyy in listDYY)
                    createDianYingYuan(dyy.Y_Name, dyyName);
            }
        }
        #endregion
    }

    void createArea(string area,string str)
    {
        HtmlGenericControl a = new HtmlGenericControl("a");
        a.InnerText = area;
        if(area.Equals(str))
        a.Attributes.Add("class", "current");
        a.Attributes.Add("href", "showDetail .aspx?cinemaArea="+area);

        select_tags.Controls.Add(a);
      
    }

    private void btn_Command(object sender, CommandEventArgs e)
    {
       // Button btn2=(Button)select_tags.FindControl("dq");
       // Button tj = new Button();    
       // tj.Command += btn_Command;
       // tj.Text = btn2.Text;
       // tj.CssClass = "btnBefore";
       //int m= select_tags.Controls.IndexOf(btn2);
       ////
       //select_tags.Controls.RemoveAt(m);
       //select_tags.Controls.AddAt(m, tj);
       // Button btn = (Button)sender;

       // Button tj2 = new Button();
       // tj2.Command += btn_Command;
       // tj2.Text = btn.Text;
       // tj2.CssClass = "current2";
       // //select_tags.Controls.RemoveAt(1);
        Button btn = (Button)sender;
        btn.CssClass = "current2";
       // tj2.ID = "dq";
       // int n = select_tags.Controls.IndexOf(btn);
       // select_tags.Controls.RemoveAt(n);
       // select_tags.Controls.AddAt(n, tj);
    }

    private void btn_Command2(object sender, CommandEventArgs e)
    {
       
    }

    void createDianYingYuan(string area, string xz)
    {
        HtmlGenericControl a = new HtmlGenericControl("a");
        a.InnerText = area;
        if (area.Equals(xz))
            a.Attributes.Add("class", "current");
        a.Attributes.Add("href", "showDetail .aspx?cinemaArea=" + cinemaArea + "&dyyName=" + area);
        select_dyy.Controls.Add(a);
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