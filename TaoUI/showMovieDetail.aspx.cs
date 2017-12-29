using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using System.Web.UI.HtmlControls;

public partial class showMovieDetail : System.Web.UI.Page
{
    static int movieid;
    static string cinemaArea;
    static string cityName;
    static string provinceName;
    static DianYingYuan dyy_current;
    static string dyyName;
    static bool evenExit = false;
    static string name_area;
    static string name_dyy;
    static bool first = true;
    protected void Page_Load(object sender, EventArgs e)
    {
        movieid = 44;
        //movieid =int.Parse( Request.QueryString["movieID"].ToString());
        #region 添加电影
     
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
                dyyName = listDYY[0].Y_Name;
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
                dyyName = listDYY[0].Y_Name;
                foreach (DianYingYuan dyy in listDYY)
                    createDianYingYuan(dyy.Y_Name, dyyName);
            }


            else
            {
                dyyName = Request.QueryString["dyyName"];
                foreach (DianYingYuan dyy in listDYY)
                    createDianYingYuan(dyy.Y_Name, dyyName);
            }
        }
        #endregion

        #region  添加时间
        DateTime now = DateTime.Now;
        DateTime after;
        DateTime dt = Convert.ToDateTime(movie.M_time);

        DateTime d3 = Convert.ToDateTime(string.Format("{0}-{1}-{2}", now.Year, now.Month, now.Day));

        DateTime d4 = Convert.ToDateTime(string.Format("{0}-{1}-{2}", dt.Year, dt.Month, dt.Day));

        int days = (d4 - d3).Days;
        if (Request.QueryString["date"] == null)
        {
            if (days <= 0)
            {
                for (int i = 0; i < 5 + days; i++)
                {
                    after = now.AddDays(i);
                    createDays(after, i, now);

                }
            }

            if (days > 0)
            {
                for (int i = 1; i < 5 - days; i++)
                {
                    after = now.AddDays(i);
                    createDays(after, i, now.AddDays(1));

                }

            }
        }
        else
        {
            DateTime bjDate = Convert.ToDateTime(Request.QueryString["date"]);
            if (days <= 0)
            {
                for (int i = 0; i < 5 + days; i++)
                {
                    after = now.AddDays(i);
                    createDays(after, i, bjDate);

                }
            }

            if (days > 0)
            {
                for (int i = 1; i < 5 - days; i++)
                {
                    after = now.AddDays(i);
                    createDays(after, i, bjDate);

                }

            }

        }

        #endregion

        dyy_current = BLL.DianYingYuanManage.search_DianYingYuan_name(dyyName);
        y_name.Text = dyy_current.Y_Name;
        y_address.Text = dyy_current.Y_address;
        y_num.Text = dyy_current.Y_phone;

    }

    void createArea(string area, string str)
    {
        HtmlGenericControl a = new HtmlGenericControl("a");
        a.InnerText = area;
        if (area.Equals(str))
            a.Attributes.Add("class", "current");
        a.Attributes.Add("href", "showMovieDetail.aspx?cinemaArea=" + area);

        select_tags.Controls.Add(a);

    }

   

    void createDianYingYuan(string area, string xz)
    {
        HtmlGenericControl a = new HtmlGenericControl("a");
        a.InnerText = area;
        if (area.Equals(xz))
            a.Attributes.Add("class", "current");
        a.Attributes.Add("href", "showMovieDetail.aspx?cinemaArea=" + cinemaArea + "&dyyName=" + area);
        select_dyy.Controls.Add(a);
    }

    void createDays(DateTime dt,int n,DateTime bj)
    {
        string[] Day = new string[] { "星期日", "星期一", "星期二", "星期三", "星期四", "星期五", "星期六" };
        string week = Day[Convert.ToInt32(dt.DayOfWeek.ToString("d"))].ToString();
        //Utility.JavaScript.Alert(dt.Date.ToShortDateString(),this);

        HtmlGenericControl a = new HtmlGenericControl("a");
        a.Attributes.Add("href", "showMovieDetail.aspx?cinemaArea=" + cinemaArea + "&dyyName=" + dyyName + "&date=" + dt.Date.ToShortDateString());
           string time="" ;
           if (n == 0)
           {
               time = dt.Month + "月" + dt.Day + '日' + "(今天)";
           }
           else
               time = dt.Month + "月" + dt.Day+"("+week+")";
    
        a.InnerText =time;

        if ((dt.Date.ToShortDateString()).Equals(bj.Date.ToShortDateString()))
        {
            a.Attributes.Add("class", "current");
        }

        select_time.Controls.Add(a);

    }
}