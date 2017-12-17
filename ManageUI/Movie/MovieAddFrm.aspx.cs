using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using System.Text;

namespace ManageUI.Movie
{
    public partial class MovieAddFrm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
             UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;
          
        }

        protected void btn_tianJia_Click(object sender, EventArgs e)
        {
            Model.Movie movie = new Model.Movie();
            string name = m_name.Text.Trim();
            string direct = m_direct.Text.Trim();
            string star =m_star.Text.Trim();
            string state = m_state.Text.Trim();
            string voice = ddl_voice.Text.ToString();
            string type = getType();
            double grade =Convert.ToSingle(m_grade.Text.Trim());
            string detail = txtarea.Value.ToString();
            string time = m_time.Value;
            int minute =int.Parse( m_minute.Text.Trim());
           // string
            //Utility.JavaScript.Alert(grade.ToString()+time, this);
            if (File1.HasFile)
            {
                int length = File1.PostedFile.ContentLength;

                Stream s = File1.PostedFile.InputStream;
                byte[] bts = new byte[length];
                s.Read(bts, 0, length);
                //string str = Encoding.Default.GetString(bts);
                //Utility.JavaScript.Alert(str,this);
                movie.M_name = name;
                movie.M_direct = direct;
                movie.M_star = star;
                movie.M_state = state;
                movie.M_voice = voice;
                movie.M_type = type;
                movie.M_grade = grade;
                movie.M_detail = detail;
                movie.M_time = time;
                movie.M_minute = minute;
                movie.M_image = bts;
                if (BLL.MovieManage.InsertMovie(movie))
                    Utility.JavaScript.Alert("添加成功",this);

            }

        }

       string getType() {
         
            string type = "";
            if (cb_aiQing.Checked)

                type = type + cb_aiQing.Text.ToString() + ',';
          
            if (cb_DongHua.Checked)
                type = type + cb_DongHua.Text.ToString() + ',';
            if (cb_jingSong.Checked)
                type = type + cb_jingSong.Text.ToString() + ',';
            if (cb_keHuan.Checked)
                type = type + cb_keHuan.Text.ToString() + ',';
            if (cb_Maoxian.Checked)
                type = type + cb_Maoxian.Text.ToString() + ',';
            if (cb_qiHuan.Checked)
                type = type + cb_qiHuan.Text.ToString() + ',';
            if (cb_xiju.Checked)
                type = type + cb_xiju.Text.ToString() + ',';
            if (cb_juQing.Checked)
                type = type + cb_juQing.Text.ToString();
            if (cb_dongZuo.Checked)
                type = type + cb_dongZuo.Text.ToString();
            if (cb_zhanZheng.Checked)
                type = type + cb_zhanZheng.Text.ToString();
           
            return type;
       }



    }
}