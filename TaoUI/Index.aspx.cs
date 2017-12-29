using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;


public partial class Default2 : System.Web.UI.Page
{
    static bool WeekTop = true;
    static DateTime dt;
    static bool pd = false;
    static bool cinemaTop = true;
    static List<Movie> listmovie;
    private int[] arrCurrentDays, arrPreDays, arrNextDays; //三个变量分别是当前月，前一月，和下一个月
    private int intCurrentMonth, intPreMonth, intNextMonth; //三个整型数组存放相对月份
    
    protected void Page_Load(object sender, EventArgs e)
    {
        List<Movie> movieListHotAll = BLL.MovieManage.searchHotMovieAll();
        hotNum.Text = movieListHotAll.Count.ToString();
        List<Movie> movieListHotWL = BLL.MovieManage.searchComing_soonMovieAll();
        wlNum.Text = movieListHotWL.Count.ToString();

        movie_post.Style.Add("display","none");
        List<Movie> movieListHot = BLL.MovieManage.searchHotMovie();

        //foreach (Movie m in movieListHot)
        //{
           
        //}

        for (int i = 0; i < movieListHot.Count-1; i++)
        {
            create_MovieHot(movieListHot[i]);
        }

        List<Movie> movieListPF = BLL.MovieManage.search_Movie_byCountFive();
        foreach (Movie m in movieListPF)
        {
            createWeeklist(m);
        }



        List<Movie> movieListSoon = BLL.MovieManage.searchComing_soonMovieFive();
        foreach (Movie m in movieListSoon)
            create_MovieSoon(m);
        List<DianYingYuan> dyyList = BLL.DianYingYuanManage.search_DianYingYuan_byGradeCityAll("德阳市");
        foreach (DianYingYuan dyy in dyyList)
            createCinemalist(dyy);
        if (!IsPostBack)
        {


        }
    }


    void create_MovieHot(Movie e)
    {
        //加入最外面的div
        HtmlGenericControl hgg_div = new HtmlGenericControl("div");
        hgg_div.Attributes.Add("class", "movie-card-wrap");


        //加入两个链接
        HtmlGenericControl a = new HtmlGenericControl("a");
        a.Attributes.Add("class", "movie-card");
        a.Attributes.Add("href", "showDetail.aspx?movieID=" + e.M_id);
        #region 照片
        HtmlGenericControl poster = new HtmlGenericControl("div");
        poster.Attributes.Add("class", "movie-card-poster");
        Image image = new Image();
        image.Width = 160;
        image.Height = 224;
        image.ImageUrl = "getpic1.aspx?id=" + e.M_id;
        poster.Controls.Add(image);
        a.Controls.Add(poster);
        #endregion

        #region 名字
        HtmlGenericControl name = new HtmlGenericControl("div");
        name.Attributes.Add("class", "movie-card-name");

        HtmlGenericControl span_name = new HtmlGenericControl("span");
        span_name.Attributes.Add("class", "bt-l");
        span_name.InnerText = e.M_name;
        name.Controls.Add(span_name);

        HtmlGenericControl span_grade = new HtmlGenericControl("span");
        span_grade.Attributes.Add("class", "bt-2");

        span_grade.InnerText = Math.Round(e.M_grade, 1).ToString();
        name.Controls.Add(span_grade);

        a.Controls.Add(name);
        #endregion
        #region 详情
        HtmlGenericControl info = new HtmlGenericControl("div");
        info.Attributes.Add("class", "movie-card-info");
        HtmlGenericControl mask = new HtmlGenericControl("div");
        mask.Attributes.Add("class", "movie-card-mask");
        info.Controls.Add(mask);

        HtmlGenericControl list = new HtmlGenericControl("div");
        list.Attributes.Add("class", "movie-card-list");
        HtmlGenericControl span_main1 = new HtmlGenericControl("span");
        span_main1.InnerText = "导演：" + e.M_direct;
        list.Controls.Add(span_main1);

        HtmlGenericControl span_main2 = new HtmlGenericControl("span");
        span_main2.InnerText = "主演：" + e.M_star;
        list.Controls.Add(span_main2);

        HtmlGenericControl span_main3 = new HtmlGenericControl("span");
        span_main3.InnerText = "类型：" + e.M_type;
        list.Controls.Add(span_main3);

        HtmlGenericControl span_main4 = new HtmlGenericControl("span");
        span_main4.InnerText = "地区：" + e.M_state;
        list.Controls.Add(span_main4);

        HtmlGenericControl span_main5 = new HtmlGenericControl("span");
        span_main5.InnerText = "语言：" + e.M_voice;
        list.Controls.Add(span_main5);

        HtmlGenericControl span_main6 = new HtmlGenericControl("span");
        span_main6.InnerText = "片长:" + e.M_minute + "分钟";
        list.Controls.Add(span_main6);

        info.Controls.Add(list);

        a.Controls.Add(info);
        #endregion
        hgg_div.Controls.Add(a);

        #region 选座购票
        HtmlGenericControl a_order = new HtmlGenericControl("a");
        a_order.Attributes.Add("class", "movie-card-buy");
        a_order.Attributes.Add("href", "showDetail.aspx?movieID=" + e.M_id);
        a_order.InnerText = "选座购票";
        hgg_div.Controls.Add(a_order);
        #endregion


        list_Hot.Controls.Add(hgg_div);
        list_Hot.Attributes.Add("class", "current");

    }


    void create_MovieSoon(Movie e)
    {
        //加入最外面的div
        HtmlGenericControl hgg_div = new HtmlGenericControl("div");
        hgg_div.Attributes.Add("class", "movie-card-wrap");


        //加入两个链接
        HtmlGenericControl a = new HtmlGenericControl("a");
        a.Attributes.Add("class", "movie-card");
        a.Attributes.Add("href", "showDetail.aspx?movieID=" + e.M_id);
        #region 照片
        HtmlGenericControl poster = new HtmlGenericControl("div");
        poster.Attributes.Add("class", "movie-card-poster");
        Image image = new Image();
        image.Width = 160;
        image.Height = 224;
        image.ImageUrl = "getpic1.aspx?id=" + e.M_id;
        poster.Controls.Add(image);
        a.Controls.Add(poster);
        #endregion

        #region 名字
        HtmlGenericControl name = new HtmlGenericControl("div");
        name.Attributes.Add("class", "movie-card-name");

        HtmlGenericControl span_name = new HtmlGenericControl("span");
        span_name.Attributes.Add("class", "bt-l");
        span_name.InnerText = e.M_name;
        name.Controls.Add(span_name);

        HtmlGenericControl span_grade = new HtmlGenericControl("span");
        span_grade.Attributes.Add("class", "bt-2");

        span_grade.InnerText = Math.Round(e.M_grade, 1).ToString();
        name.Controls.Add(span_grade);

        a.Controls.Add(name);
        #endregion
        #region 详情
        HtmlGenericControl info = new HtmlGenericControl("div");
        info.Attributes.Add("class", "movie-card-info");
        HtmlGenericControl mask = new HtmlGenericControl("div");
        mask.Attributes.Add("class", "movie-card-mask");
        info.Controls.Add(mask);

        HtmlGenericControl list = new HtmlGenericControl("div");
        list.Attributes.Add("class", "movie-card-list");
        HtmlGenericControl span_main1 = new HtmlGenericControl("span");
        span_main1.InnerText = "导演：" + e.M_direct;
        list.Controls.Add(span_main1);

        HtmlGenericControl span_main2 = new HtmlGenericControl("span");
        span_main2.InnerText = "主演：" + e.M_star;
        list.Controls.Add(span_main2);

        HtmlGenericControl span_main3 = new HtmlGenericControl("span");
        span_main3.InnerText = "类型：" + e.M_type;
        list.Controls.Add(span_main3);

        HtmlGenericControl span_main4 = new HtmlGenericControl("span");
        span_main4.InnerText = "地区：" + e.M_state;
        list.Controls.Add(span_main4);

        HtmlGenericControl span_main5 = new HtmlGenericControl("span");
        span_main5.InnerText = "语言：" + e.M_voice;
        list.Controls.Add(span_main5);

        HtmlGenericControl span_main6 = new HtmlGenericControl("span");
        span_main6.InnerText = "片长:" + e.M_minute + "分钟";
        list.Controls.Add(span_main6);

        info.Controls.Add(list);

        a.Controls.Add(info);
        #endregion
        hgg_div.Controls.Add(a);

        #region 选座购票
        HtmlGenericControl a_order = new HtmlGenericControl("a");
        a_order.Attributes.Add("class", "movie-card-soon");
        a_order.Attributes.Add("href", "showDetail.aspx?movieID=" + e.M_id);
        DateTime dt = Convert.ToDateTime(e.M_time);

        a_order.InnerText = dt.ToShortDateString().ToString();
        hgg_div.Controls.Add(a_order);
        #endregion

        list_future.Controls.Add(hgg_div);

    }


    void createWeeklist(Movie e)
    {

        HtmlGenericControl li = new HtmlGenericControl("li");
        li.Attributes.Add("class", "lili");
        if (WeekTop)
        {
            li.Attributes.Add("class", "current");
            WeekTop = false;
        }
        HtmlGenericControl i = new HtmlGenericControl("i");
        //i.Attributes.Add("class", "i-1");
        li.Controls.Add(i);
        HtmlGenericControl span = new HtmlGenericControl("span");
        span.Attributes.Add("class", "poster");

        HtmlGenericControl a = new HtmlGenericControl("a");
        a.Attributes.Add("href", "showDetail.aspx?movieID=" + e.M_id);
        Image image = new Image();
        image.Width = 80;
        image.Height = 90;
        image.Style.Add("margin-right", "10px");
        image.ImageUrl = "getpic1.aspx?id=" + e.M_id;

        a.Controls.Add(image);
        span.Controls.Add(a);

        li.Controls.Add(span);

        HtmlGenericControl a2 = new HtmlGenericControl("a");
        a2.Attributes.Add("href", "showDetail.aspx?movieID=" + e.M_id);
        a2.Attributes.Add("class", "name");
        a2.InnerText = e.M_name;
        li.Controls.Add(a2);

        HtmlGenericControl span2 = new HtmlGenericControl("span");
        span2.Attributes.Add("class", "rating");
        span2.InnerText = Math.Round(e.M_grade, 1).ToString();
        li.Controls.Add(span2);

        HtmlGenericControl span3 = new HtmlGenericControl("span");
        span3.Attributes.Add("class", "buynow");
        HtmlGenericControl a3 = new HtmlGenericControl("a");
        a3.Attributes.Add("href", "showDetail.aspx?movieID=" + e.M_id);
        a3.Attributes.Add("class", "buy");
        a3.InnerText = "选座购票";

        span3.Controls.Add(a3);
        li.Controls.Add(span3);

        weeklist.Controls.Add(li);


    }

    void createCinemalist(DianYingYuan dyy)
    {

        HtmlGenericControl li = new HtmlGenericControl("li");
        li.Attributes.Add("class", "lili2");
        if (cinemaTop)
        {
            li.Attributes.Add("class", "current");
            cinemaTop = false;
        }
        HtmlGenericControl i = new HtmlGenericControl("i");
        //i.Attributes.Add("class", "i-1");
        li.Controls.Add(i);



        HtmlGenericControl a = new HtmlGenericControl("a");
        a.Attributes.Add("class", "name");
        a.InnerText = dyy.Y_Name;
        li.Controls.Add(a);



        HtmlGenericControl span2 = new HtmlGenericControl("span");
        span2.Attributes.Add("class", "address");
        span2.InnerText = dyy.Y_address;
        li.Controls.Add(span2);

        HtmlGenericControl span3 = new HtmlGenericControl("span");
        span3.Attributes.Add("class", "buynow");
        HtmlGenericControl a3 = new HtmlGenericControl("a");
        a3.Attributes.Add("class", "seat");
        a3.InnerText = "选座";

        span3.Controls.Add(a3);
        li.Controls.Add(span3);


        cinemalist.Controls.Add(li);


    }
   
    protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
    {

        arrCurrentDays = null;
        CalendarDay d = ((DayRenderEventArgs)e).Day;
        TableCell c = ((DayRenderEventArgs)e).Cell;
        string ss = "";

        if (pd)
        {

            if ((dt.Year == d.Date.Year) && (dt.Month == d.Date.Month))
            {

                arrCurrentDays = DAL.MovieServer.getArrayDay(DateTime.Now);


            }

            else
            {
                arrCurrentDays = null;
                //Utility.JavaScript.Alert(dt.Date.ToString(), this);

                arrCurrentDays = DAL.MovieServer.getArrayDayNext(dt);
            }

        }
        else
        {
            arrCurrentDays = DAL.MovieServer.getArrayDay(DateTime.Now);
        }

        int j = 0;
        int n;

        int[] arrCurrent = arrCurrentDays;

        while (!arrCurrentDays[j].Equals(0))
        {

            n = arrCurrentDays[j];


            if (d.Date.Day == n)
            {
                ss = ss + n;
                //Utility.JavaScript.Alert(n.ToString(), this);
                e.Cell.ForeColor = System.Drawing.Color.Red;
                e.Day.IsSelectable = true;
                break;
                //TableCell tc = new TableCell();
                //Utility.JavaScript.Alert(n.ToString(), this);
                // c.Controls.Clear();
                // LinkButton lb = new LinkButton();
                // lb.Attributes.Add("class", "tc");
                // lb.Command += new CommandEventHandler(this.lv_Click);
                // //lb.Click += new System.EventHandler(lv_Click);
                //lb.Text = arrCurrentDays[j].ToString();

                //c.Controls.Add(lb);
            }
            else
            {
                e.Cell.ForeColor = System.Drawing.Color.Gray;
                e.Day.IsSelectable = false;

            }
            j++;
        }
    }
    protected void Calendar1_VisibleMonthChanged(object sender, MonthChangedEventArgs e)
    {
        pd = true;
        dt = e.NewDate;
    }
    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        movie_post.Style.Add("display", "block");
        DateTime dt = Calendar1.SelectedDate;

        listmovie = BLL.MovieManage.search_NewMovie_byDate(dt.ToString());
        //Utility.JavaScript.Alert(listmovie.Count.ToString(), this);
        HtmlGenericControl hgg_div = new HtmlGenericControl("div");
        hgg_div.Attributes.Add("class", "movie-post-main");

        HtmlGenericControl a = new HtmlGenericControl("a");
        a.Attributes.Add("target", "_blank");
        a.Attributes.Add("href", "showDetail.aspx?movieID=" + listmovie[0].M_id);
        Image img = new Image();
        img.ImageUrl = "getpic1.aspx?id=" + listmovie[0].M_id;
        img.Attributes.Add("class", "movie-post-img");
        img.Attributes.Add("class", "M-post-img");
       a.Controls.Add(img);

        HtmlGenericControl mask = new HtmlGenericControl("div");
        mask.Attributes.Add("class", "movie-post-mask");
        a.Controls.Add(mask);

        HtmlGenericControl ul = new HtmlGenericControl("ul");
        //ul.Attributes.Add("class", "movie-post-mask-list");
        ul.Attributes.Add("class", "movie-post-mask-list M-post-mask-list");

        HtmlGenericControl li1 = new HtmlGenericControl("li");

        HtmlGenericControl em1 = new HtmlGenericControl("em");
        em1.InnerText = "导演：";
        HtmlGenericControl span1 = new HtmlGenericControl("span");
        span1.InnerText = listmovie[0].M_direct;
        li1.Controls.Add(em1);
        li1.Controls.Add(span1);

        ul.Controls.Add(li1);


        HtmlGenericControl li2 = new HtmlGenericControl("li");

        HtmlGenericControl em2 = new HtmlGenericControl("em");
        em2.InnerText = "主演：";
        HtmlGenericControl span2 = new HtmlGenericControl("span");
        span2.InnerText = listmovie[0].M_star;
        li2.Controls.Add(em2);
        li2.Controls.Add(span2);

        ul.Controls.Add(li2);


        HtmlGenericControl li3 = new HtmlGenericControl("li");

        HtmlGenericControl em3 = new HtmlGenericControl("em");
        em3.InnerText = "类型：";
        HtmlGenericControl span3 = new HtmlGenericControl("span");
        span3.InnerText = listmovie[0].M_type;
        li3.Controls.Add(em3);
        li3.Controls.Add(span3);

        ul.Controls.Add(li3);

        HtmlGenericControl li4 = new HtmlGenericControl("li");

        HtmlGenericControl em4 = new HtmlGenericControl("em");
        em4.InnerText = "地区：";
        HtmlGenericControl span4 = new HtmlGenericControl("span");
        span4.InnerText = listmovie[0].M_state;
        li4.Controls.Add(em4);
        li4.Controls.Add(span4);

        ul.Controls.Add(li4);


        HtmlGenericControl li6 = new HtmlGenericControl("li");

        HtmlGenericControl em6 = new HtmlGenericControl("em");
        em6.InnerText = "语言：";
        HtmlGenericControl span6 = new HtmlGenericControl("span");
        span6.InnerText = listmovie[0].M_voice;
        li6.Controls.Add(em6);
        li6.Controls.Add(span6);

        ul.Controls.Add(li6);

        HtmlGenericControl li5 = new HtmlGenericControl("li");

        HtmlGenericControl em5 = new HtmlGenericControl("em");
        em5.InnerText = "片长：";
        HtmlGenericControl span5 = new HtmlGenericControl("span");
        span5.InnerText = listmovie[0].M_minute + "分钟";
        li5.Controls.Add(em5);
        li5.Controls.Add(span5);

        ul.Controls.Add(li5);
       a.Controls.Add(ul);

        HtmlGenericControl h3 = new HtmlGenericControl("h3");
        //h3.Attributes.Add("class", "movie-post-mask-info");
        h3.Attributes.Add("class", "movie-post-mask-info M-post-mask-info");

        HtmlGenericControl span_name = new HtmlGenericControl("span");
        span_name.Attributes.Add("class", "movie-name");
        span_name.InnerText = listmovie[0].M_name;

        h3.Controls.Add(span_name);

        a.Controls.Add(h3);
        hgg_div.Controls.Add(a);
      
        movie_post.Controls.AddAt(0,hgg_div);
        time_info.InnerText = dt.Date.ToShortDateString() + "上映" + listmovie.Count + "部";
    }
    protected void btn_cx_Click(object sender, EventArgs e)
    {
      
    }
    protected void prev_Click(object sender, EventArgs e)
    {
        movie_post.Style.Add("display", "block");
        time_info.InnerText = dt.Date.ToString() + "上映" + 1+ "部";
        //Utility.JavaScript.Alert("fffffffffff",this);
    }
}