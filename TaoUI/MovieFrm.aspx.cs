using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using System.Web.UI.HtmlControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Session["city"] = "德阳市";
        string cityName = Session["city"].ToString();
        List<Movie> listMovie = BLL.MovieManage.searchHotMovieAll();
        foreach (Movie movie in listMovie)
            create_MovieHot(movie);

        List<Movie> listWL = BLL.MovieManage.searchComing_soonMovieAll();
        foreach (Movie mo in listWL)
            create_MovieSoon(mo);
        List<DianYingYuan> dyyList = BLL.DianYingYuanManage.search_DianYingYuan_byGradeCityAll(cityName);
        name1.InnerText = dyyList[0].Y_Name;
        name2.InnerText = dyyList[1].Y_Name;
        address1.InnerText = dyyList[0].Y_address;
        address2.InnerText = dyyList[1].Y_address;
    }
    void create_MovieHot(Movie e)
    {
        //加入最外面的div
        HtmlGenericControl hgg_div = new HtmlGenericControl("div");
        hgg_div.Attributes.Add("class", "movie-card-wrap");


        //加入两个链接
        HtmlGenericControl a = new HtmlGenericControl("a");
        a.Attributes.Add("class", "movie-card");
        a.Attributes.Add("href", "showDetail.aspx?movieID="+e.M_id);
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


        list_hot.Controls.Add(hgg_div);
        //list_Hot.Attributes.Add("class", "current");

    }

    void create_MovieSoon(Movie e)
    {
        //加入最外面的div
        HtmlGenericControl hgg_div = new HtmlGenericControl("div");
        hgg_div.Attributes.Add("class", "movie-card-wrap");


        //加入两个链接
        HtmlGenericControl a = new HtmlGenericControl("a");
        a.Attributes.Add("class", "movie-card");
        a.Attributes.Add("href", "showDetail.aspx?movieID="+e.M_id);
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

        a_order.InnerText = "上映时间："+dt.ToShortDateString().ToString();
        hgg_div.Controls.Add(a_order);
        #endregion

        list_future.Controls.Add(hgg_div);

    }
}