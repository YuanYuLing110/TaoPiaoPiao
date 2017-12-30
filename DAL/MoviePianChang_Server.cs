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
  public  class MoviePianChang_Server
    {
        /// <summary>
        ///根据电影院评分排序查出当地的电影院
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static List<MoviePianChang> search_pianChang_byMovieDate(int m_id,int y_id,DateTime dt)
        {
            List<MoviePianChang> list = new List<MoviePianChang>();
            SqlParameter[] p = {
             
                        new SqlParameter("@m_id",m_id),
                                                new SqlParameter("@y_id",y_id),
                                                                        new SqlParameter("@date",dt),
                    };
            SqlDataReader sdr = DBHelper.ExecuteReader("search_pianChang_byMovieDate", CommandType.StoredProcedure, p);
            if (sdr.HasRows)
            {
                while (sdr.Read())
                {
                    MoviePianChang mpc = new MoviePianChang();
                    mpc.P_id= int.Parse(sdr["p_id"].ToString());
                      mpc.M_minute= int.Parse(sdr["m_minute"].ToString());
                    mpc.M_name = sdr["m_name"].ToString();
                    mpc.M_voice = sdr["m_voice"].ToString();
                   mpc.T_name = sdr["t_name"].ToString();
                   mpc.P_time =Convert.ToDateTime( sdr["p_time"].ToString());
                   mpc.P_price = Convert.ToDouble(sdr["p_price"]);
                    list.Add(mpc);
                }
            }
            sdr.Close();
            return list;
        }
    }
}
