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
    static string cinemaArea;
   static string cityName;
   static string provinceName;
   static bool evenExit = false;
   static bool first = true;
    protected void Page_Load(object sender, EventArgs e)
    {
        Session["province"] = "四川省";
        Session["city"] = "德阳市";
      
        cityName = Session["city"].ToString();
        city.Text = cityName;
        provinceName = Session["province"].ToString();
        DAL.CityServer.getProvice();
        DAL.CityServer.getCity(provinceName);
        List<string> listArea = DAL.CityServer.getDistricts(cityName);

        if (Request.QueryString["cinemaArea"] == null)
        {
            HtmlGenericControl a = new HtmlGenericControl("a");
            a.InnerText = "全部区域";
            a.Attributes.Add("class", "current");
            a.Attributes.Add("href", "cinemaList.aspx?");
            select_tags.Controls.Add(a);
            cinemaArea = null;
            List<DianYingYuan> listDyy = BLL.DianYingYuanManage.search_DianYingYuan_byGradeCityAll(cityName);
            //Utility.JavaScript.Alert(listDyy.Count.ToString(),this);
            foreach (DianYingYuan dyy in listDyy)
                createCinemalist(dyy);
            count.InnerText = listDyy.Count.ToString();
        }
        else
        {
            HtmlGenericControl a = new HtmlGenericControl("a");
            a.InnerText = "全部区域";         
            a.Attributes.Add("href", "cinemaList.aspx?");
            select_tags.Controls.Add(a);
            cinemaArea = (Request.QueryString["cinemaArea"]).ToString();
            List<DianYingYuan> listDyy = BLL.DianYingYuanManage.search_DianYingYuan_byGradeAreaAll(cinemaArea);
            foreach (DianYingYuan dyy in listDyy)
                createCinemalist(dyy);
            count.InnerText = listDyy.Count.ToString();
        }
     
        //string ss = "";
        foreach (string st in listArea)
            create(st);
        //Utility.JavaScript.Alert(ss,this);
    }

    void create(string area)
    {
        HtmlGenericControl a = new HtmlGenericControl("a");
        a.InnerText = area;
     if(cinemaArea!=null)
     {
         if (cinemaArea.Equals(area))
         {
             a.Attributes.Add("class", "current");
         }
     }
     a.Attributes.Add("href", "cinemaList.aspx?cinemaArea="+area);
        select_tags.Controls.Add(a);
    }

  

    void createCinemalist(DianYingYuan dyy)
    {
        //Utility.JavaScript.Alert(dyy.Y_Name,this);
        HtmlGenericControl li = new HtmlGenericControl("li");     
            if (first)
            {
                li.Attributes.Add("class", "current");
                first = false;
            }
                        if (evenExit)
                        {
                            li.Attributes.Add("class", "even");
                            evenExit = false;
                        }
                        else
                        {
                            evenExit = true;
                        }

         HtmlGenericControl div_right = new HtmlGenericControl("div");
         div_right.Attributes.Add("class", "detail-right");
                  HtmlGenericControl div_score = new HtmlGenericControl("div");
                  div_score.Attributes.Add("class", "right-score");
                  div_score.InnerHtml = "评分：<strong>"+dyy.Y_grade+"</strong>";
                  div_right.Controls.Add(div_score);

                  HtmlGenericControl div_fav = new HtmlGenericControl("div");
                  div_fav.Attributes.Add("class", "right-fav");
                  div_right.Controls.Add(div_fav);

                  HtmlGenericControl div_buy = new HtmlGenericControl("div");
                  div_buy.Attributes.Add("class", "right-buy");
                                 HtmlGenericControl a= new HtmlGenericControl("a");
                                 a.InnerText = "选座";
                                 div_buy.Controls.Add(a);   
                  div_right.Controls.Add(div_buy);
         li.Controls.Add(div_right);

        HtmlGenericControl a2 = new HtmlGenericControl("a");
        a2.Attributes.Add("class", "detail-left pictures");
                 Image img = new Image();
                 img.ImageUrl = "image/taobao-movie1.png";
                 img.AlternateText = dyy.Y_Name;
                 a2.Controls.Add(img);
         li.Controls.Add(a2);

         HtmlGenericControl div_middle = new HtmlGenericControl("div");
         div_middle.Attributes.Add("class", "detail-middle");

                      HtmlGenericControl div_hd = new HtmlGenericControl("div");
                      div_hd.Attributes.Add("class", "middle-hd");
                            HtmlGenericControl h4 = new HtmlGenericControl("h4");
                                   HtmlGenericControl a3 = new HtmlGenericControl("a");
                                   a3.InnerText = dyy.Y_Name;
                                   h4.Controls.Add(a3);
                            div_hd.Controls.Add(h4);
                      div_middle.Controls.Add(div_hd);

                      HtmlGenericControl div_p = new HtmlGenericControl("div");
                      div_p.Attributes.Add("class", "middle-p");
                                 HtmlGenericControl div_p_list = new HtmlGenericControl("div");
                                 div_p_list.Attributes.Add("class", "middle-p-list");
                                            HtmlGenericControl i = new HtmlGenericControl("i");
                                            i.InnerText = "地址：";
                                            div_p_list.Controls.Add(i);
                                  HtmlGenericControl span = new HtmlGenericControl("span");
                                  span.Attributes.Add("class", "limit-address");
                                  span.InnerText = dyy.Y_address;
                                  div_p_list.Controls.Add(span);
                                  HtmlGenericControl a4 = new HtmlGenericControl("a");
                                  a4.Attributes.Add("class", "J_miniMap");
                                  a4.InnerText = "[地图]";
                                  div_p_list.Controls.Add(a4);
                      div_p.Controls.Add(div_p_list);
                     

                      HtmlGenericControl div_p2 = new HtmlGenericControl("div");
                      div_p2.Attributes.Add("class", "middle-p-list");
                      div_p2.InnerHtml = "<i>电话：</i>"+dyy.Y_phone;
                      div_p.Controls.Add(div_p2);

                      HtmlGenericControl div_p3 = new HtmlGenericControl("div");
                      div_p3.Attributes.Add("class", "middle-p-list");
                              HtmlGenericControl i2 = new HtmlGenericControl("i");
                              i2.InnerText = "更多：";
                              div_p3.Controls.Add(i2);
                              HtmlGenericControl a6 = new HtmlGenericControl("a");
                              a6.Attributes.Add("class", " middle-more");
       
                              a6.InnerText = "影院服务";
                              div_p3.Controls.Add(a6);
                              HtmlGenericControl a7 = new HtmlGenericControl("a");
                              a7.Attributes.Add("class", " middle-more");
                              a7.InnerText = "交通信息";
                              div_p3.Controls.Add(a7);

                      div_p.Controls.Add(div_p3);
               div_middle.Controls.Add(div_p);
         li.Controls.Add(div_middle);
        detail.Controls.Add(li);


    }
}