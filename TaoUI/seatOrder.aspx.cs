using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using Model;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

public partial class seatOrder : System.Web.UI.Page
{
    static int p_id;
    static int count = 1;
    static int s_width;
    static int s_heigh;
    protected void Page_Load(object sender, EventArgs e)
    {
        p_id = 1032;
        String Y_name = DAL.PianChangServer.search_DianYingYuanName_byP_id(p_id);
        DianYingTing dyt = DAL.PianChangServer.search_DianYingTing_byP_id(p_id);
        Movie movie = DAL.PianChangServer.search_Movie_byP_id(p_id);
        PianChang pc = DAL.PianChangServer.search_pianChang_byP_id(p_id);
        s_width =Convert.ToInt32( Math.Floor((double)(600/(dyt.T_line))));
        //s_heigh = Convert.ToInt32(Math.Floor((double)(600 / (dyt.T_line))));
        p_name.Text = Y_name + "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" + dyt.T_name;
        m_name.InnerText = movie.M_name;
        m_time.InnerText = "片长：" + movie.M_minute+"分钟";
        m_voice.InnerText = "版本：" + movie.M_voice;

        yY_name.InnerText = Y_name;
        yT_name.InnerText = dyt.T_name;
        jiaGe.Text = pc.P_price.ToString();

        string[] Day = new string[] { "星期日", "星期一", "星期二", "星期三", "星期四", "星期五", "星期六" };
        string week = Day[Convert.ToInt32(pc.P_time.DayOfWeek.ToString("d"))].ToString();
        p_time.InnerText = pc.P_time.Date.ToShortDateString()+ "(" + week + ")" + pc.P_time.Hour + ":" + pc.P_time.Minute;

        for (int n = 1; n <= dyt.T_row; n++)
        {
            createCoulmn(n);
        }

        for (int n = 1; n <= dyt.T_row; n++)
            for (int m = 1; m <= dyt.T_line; m++)
            {
                createSeat(n, m);
            }
    }

    void createCoulmn(int n)
    {
        HtmlGenericControl label = new HtmlGenericControl("label");
        label.Style.Add("top",(33*(n-1)).ToString()+"px");
        label.Style.Add("line-height", "32.53px");
        label.Style.Add("position", "absolute");
        label.InnerText = n.ToString();
        coulmn.Controls.Add(label);
    }

    void createSeat(int n, int m)
    {
        string num="";
        HtmlGenericControl div = new HtmlGenericControl("div");
        div.Attributes.Add("class", "unregular-seat seat-cell");
        div.Attributes.Add("data-name",n+"排"+m+"列");
        div.Attributes.Add("data-flag","0");
        if (count < 9)
            num = p_id.ToString() + "0" + count;
        else
            num = p_id.ToString() + count;
        div.Attributes.Add("data-seatid",num);
        div.Style.Add("width", s_width+"px");
        div.Style.Add("height", "33px");
        div.Style.Add("margin-top", (33*(n - 1)).ToString() + "px");
        div.Style.Add("margin-left",(s_width*(m-1)).ToString()+"px");
        seat.Controls.Add(div);
    }
}