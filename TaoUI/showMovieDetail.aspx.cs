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
    static DateTime bjDate;
    static string dyyName;
    static string name_area;

    static string name_dyy;
    static bool pdEven = false;
    protected void Page_Load(object sender, EventArgs e)
    {
        movieid = 21;
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

            if(listDYY.Count>0)
            {
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
                bjDate = now;
                for (int i = 0; i < 5 + days; i++)
                {
                    after = now.AddDays(i);
                    createDays(after, i, bjDate);

                }
            }

            if (days > 0)
            {
                bjDate = dt.AddDays(0);
                for (int i = 1; i <= 5 - days; i++)
                {
                    after = dt.AddDays(i-1);
                    createDays(after, i, bjDate);

                }

            }
        }
        else
        {
            bjDate = Convert.ToDateTime(Request.QueryString["date"]);
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
                for (int i = 1; i <= 5 - days; i++)
                {
                    after = dt.AddDays(i-1);
                    createDays(after, i, bjDate);

                }

            }

        }

        #endregion

        dyy_current = BLL.DianYingYuanManage.search_DianYingYuan_name(dyyName);
        y_name.Text = dyy_current.Y_Name;
        y_address.Text = dyy_current.Y_address;
        y_num.Text = dyy_current.Y_phone;

        List<MoviePianChang> listMPC = DAL.MoviePianChang_Server.search_pianChang_byMovieDate(movieid, dyy_current.Y_id, bjDate);
        foreach (MoviePianChang mpc in listMPC)
            createMoviePianChang(mpc);

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

    void createMoviePianChang(MoviePianChang mpc)
    {

        HtmlGenericControl tr = new HtmlGenericControl("tr");
        if (pdEven)
        {
            tr.Attributes.Add("class", "even");
            pdEven = false;
        }
        else
            pdEven = true;
        HtmlGenericControl td_time = new HtmlGenericControl("td");
        td_time.Attributes.Add("class", "hall-time");

                     HtmlGenericControl bold = new HtmlGenericControl("em");
                     bold.Attributes.Add("class", "bold");
                     bold.InnerText = mpc.P_time.Hour + ":" + mpc.P_time.Minute;
                     td_time.Controls.Add(bold);
                     DateTime dt = mpc.P_time.AddMinutes(mpc.M_minute);
                     Label lb = new Label();
                     lb.Text = "预计"+dt.Hour+":"+dt.Minute+"散场";
                    td_time.Controls.Add(lb);
        tr.Controls.Add(td_time);

        HtmlGenericControl td_name = new HtmlGenericControl("td");
        td_name.Attributes.Add("class", "hall-name");
        td_name.InnerText = mpc.T_name;
        tr.Controls.Add(td_name);

        HtmlGenericControl td_type = new HtmlGenericControl("td");
        td_type.Attributes.Add("class", "hall-type");
        td_type.InnerText = mpc.M_voice;
        tr.Controls.Add(td_type);

     

        HtmlGenericControl td_price = new HtmlGenericControl("td");
        td_price.Attributes.Add("class", "hall-price");
        td_price.Attributes.Add("data-partcode", "dingxinnew");
                   HtmlGenericControl em = new HtmlGenericControl("em");
                   em.Attributes.Add("class", "now");
                   string str1 = String.Format("{0:F}", mpc.P_price);//默认为保留两位
                   em.InnerText = str1;
                   td_price.Controls.Add(em);
         tr.Controls.Add(td_price);


        HtmlGenericControl td_seat = new HtmlGenericControl("td");
        td_seat.Attributes.Add("class", "hall-seat");
                    
        tr.Controls.Add(td_seat);
                    HtmlGenericControl a = new HtmlGenericControl("a");
                    a.Attributes.Add("class", "seat-btn");
                    a.InnerText = "选座购票";
                    td_seat.Controls.Add(a);
        t_body.Controls.Add(tr); 
    }
}