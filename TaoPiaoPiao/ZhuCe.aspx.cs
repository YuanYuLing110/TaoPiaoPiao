using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using BLL;
using Model;
using System.Web.UI.WebControls;
//using BaiCiZhan_Model;

namespace TaoPiaoPiao
{
    public partial class ZhuCe : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;
           
        }

        protected void load_Click(object sender, EventArgs e)
        {
            #region 间隔几秒跳转，没有成功
            //load.Attributes.Add("onclick", "ShowSecond()");
            ////Response.Redirect("~/Login.html");
            // string st="<meta http-equiv="+"'Refresh'"+" content="+"'3;URL=Login.aspx'"+" />";
            // Response.Write("<script>alert('"+st+" ')</script>");
            // //Response.Write(st);
            //Response.Write("<script>alert('注册成功 ')</script>");
            //DateTime starttime;
            //starttime = DateTime.Now;

            //while ((DateDiff(starttime, DateTime.Now) >= 10))
            //{
            //    //'显示读秒效果，并且提示10秒钟后页面自动跳转到abcde.asp

            //}

            //Response.Redirect("~/Login.aspx");
            #endregion

            #region
            if (Page.IsValid)
            {
                Users user = new Users();
                user.U_NAME = userName.Text.Trim();

                user.U_PSSWORD = password.Text.Trim();
                user.U_EMAIL = txt_email.Text.Trim();
                user.U_REGISTERTIME = DateTime.Now;
                //Response.Write("<script>alert('" + user.U_NAME + '\\' + user.U_EMAIL + '\\' + user.U_PSSWORD +'\\' +user.U_REGISTERTIME + "')</script>");
                //response.write("<script>alert('"  + user.u_pssword + "')</script>");

                if (UserManager.insertUser(user))
                {
                    Response.Write("<script>alert('注册成功 ')</script>");

                    Response.Redirect("~/Login.aspx");
                    //Response.Write("<script >setTimeout(href='~/Login.html',3000)</script>");
                    //Response.Write("<meta http-equiv=refresh content=3 url='~/Login.html'>");
                }

                else
                    Response.Write("<script>alert('注册失败')</script>");
            }
            #endregion
        }

        private int DateDiff(DateTime DateTime1, DateTime DateTime2)
 {
            int  dateDiff ;
 TimeSpan ts1 = new TimeSpan(DateTime1.Ticks);
 TimeSpan ts2 = new TimeSpan(DateTime2.Ticks);
 TimeSpan ts = ts1.Subtract(ts2).Duration();
 dateDiff =ts.Seconds;
 return dateDiff;
 } 

    }
}