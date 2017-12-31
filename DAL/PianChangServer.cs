using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
 public   class PianChangServer
    {

        /// <summary>
        /// 添加片场
        /// </summary>
        /// <param name="pc"></param>
        /// <returns></returns>

        public static bool Insert_DianYingTing(PianChang pc)
        {

            SqlParameter[] p = {
                new SqlParameter("@t_id",pc.T_id),
                  new SqlParameter("@m_id",pc.M_id),
                    new SqlParameter("@p_time",pc.P_time),
                       new SqlParameter("@p_price",pc.P_price)
                    };
            int i = DBHelper.ExecuteNonQuery("InsertPianChang", CommandType.StoredProcedure, p);
            return i > 0;
        }

     /// <summary>
     /// 根据电影查询安排的片场
     /// </summary>
     /// <param name="m_id"></param>
     /// <param name="y_id"></param>
     /// <returns></returns>
        public static SqlDataReader search_pianChang_byMovie_sr(int m_id, int y_id)
        {

            SqlParameter[] p = {
             
                        new SqlParameter("@m_id",m_id),
                         new SqlParameter("@y_id",y_id)
                    };
            SqlDataReader sdr = DBHelper.ExecuteReader("search_pianChang_byMovie", CommandType.StoredProcedure, p);
            return sdr;
        }

        /// <summary>
        /// 根据电影厅查询安排的片场
        /// </summary>
        /// <param name="m_id"></param>
        /// <param name="y_id"></param>
        /// <returns></returns>
        public static SqlDataReader search_pianChang_byDianYingTing_sr(int t_id, int y_id)
        {

            SqlParameter[] p = {
             
                        new SqlParameter("@t_id",t_id),
                         new SqlParameter("@y_id",y_id)
                    };
            SqlDataReader sdr = DBHelper.ExecuteReader("search_pianChang_byDianYingTing", CommandType.StoredProcedure, p);
            return sdr;
        }

      /// <summary>
        /// 根据电影厅查询安排的片场
        /// </summary>
        /// <param name="m_id"></param>
        /// <param name="y_id"></param>
        /// <returns></returns>
        public static SqlDataReader search_pianChang_All_sr( int y_id)
        {
            SqlParameter[] p = {
             
                   
                         new SqlParameter("@y_id",y_id)
                    };
            SqlDataReader sdr = DBHelper.ExecuteReader("search_pianChang_All", CommandType.StoredProcedure, p);
            return sdr;
        
        }

        public static PianChang search_pianChang_byP_id(int p_id)
        {
            string str = "select * from PianChang where p_id=@id";
            SqlParameter[] p = {
             
                   
                         new SqlParameter("@id",p_id)
                    };
            SqlDataReader sr = DBHelper.ExecuteReader(str,CommandType.Text,p);
            PianChang pc = new PianChang();
            if (sr.Read())
            {
                pc.P_price =Convert.ToDouble( sr["p_price"]);
                pc.P_time =Convert.ToDateTime( sr["p_time"]);
             
            }
            sr.Close();
            return pc;

        }

        /// <summary>
        ///根据片场id查询电影
        /// </summary>
        public static Movie search_Movie_byP_id(int p_id)
        {

            string str = " select * from Movie where m_id=(select m_id from PianChang where p_id=@id)";
            SqlParameter[] p = {
             
                        new SqlParameter("@id",p_id)
                    };
            SqlDataReader sdr = DBHelper.ExecuteReader(str, CommandType.Text, p);
            Movie movie = new Movie();

            if (sdr.Read())
            {


                movie.M_id = int.Parse(sdr["m_id"].ToString());
                movie.M_name = sdr["m_Name"].ToString();
                movie.M_image = (byte[])sdr["m_image"];
                movie.M_direct = sdr["m_direct"].ToString();
                movie.M_star = sdr["m_star"].ToString();
                movie.M_type = sdr["m_type"].ToString();
                movie.M_state = sdr["m_state"].ToString();
                movie.M_voice = sdr["m_voice"].ToString();
                movie.M_state = sdr["m_state"].ToString();
                movie.M_voice = sdr["m_voice"].ToString();
                movie.M_time = sdr["m_time"].ToString();
                movie.M_grade = Convert.ToSingle(sdr["m_grade"]);
                movie.M_detail = sdr["m_detail"].ToString();
                movie.M_count = int.Parse(sdr["m_count"].ToString());
                movie.M_minute = int.Parse(sdr["m_minute"].ToString());

            }
            sdr.Close();
            return movie;
        }

        public static DianYingTing search_DianYingTing_byP_id(int p_id)
        {

            string str = " select * from DianYingTing where t_id=(select t_id from PianChang where p_id=@id)";
            SqlParameter[] p = {
             
                   
                         new SqlParameter("@id",p_id)
                    };
            SqlDataReader sr = DBHelper.ExecuteReader(str, CommandType.Text, p);
            DianYingTing dyt = new DianYingTing();
            if (sr.Read())
            {
                dyt.T_name = sr["t_name"].ToString();
                dyt.T_line = Convert.ToInt32(sr["t_line"]);
                dyt.T_row = Convert.ToInt32(sr["t_row"]);
                dyt.T_count = Convert.ToInt32(sr["t_count"]);
            }
            sr.Close();
            return dyt;
        
        }

        public static string search_DianYingYuanName_byP_id(int p_id)
        {
            string str = " select y_Name from DianYingYuan where y_id=(select y_id from DianYingTing where t_id=(select t_id from PianChang where p_id=@id))";
            SqlParameter[] p = {
             
                   
                         new SqlParameter("@id",p_id)
                    };
            object obj = DBHelper.ExecuteScalar(str,CommandType.Text,p);
            return obj.ToString();
        }
    }
}
