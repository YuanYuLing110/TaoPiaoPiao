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

    }
}
