using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL
{
public    class DianYingTingServer
    {
      
        /// <summary>
        /// 根据电影院查询电影厅
        /// </summary>
        /// <param name="m_name"></param>
        /// <returns></returns>
        public static SqlDataReader search_DianYingTing_All(string m_name)
        {
            string sql = "select * from DianYingTing  where y_id=(select y_id  from Manage where name=@name)";
            SqlParameter[] sp ={
                      new SqlParameter("@name",m_name)         
                               };
            SqlDataReader sdr = DBHelper.ExecuteReader(sql, CommandType.Text, sp);

            return sdr;
        }


        /// <summary>
        /// 判断电影院是否为存在
        /// </summary>    
        /// <returns></returns>
        public static bool PanDuan_DianYingTingExist(String t_name,int y_id)
        {

            string sql = "select Count(*) from DianYingTing where t_name=@Tname and y_id=@Yid";
            SqlParameter[] p = {
             
                new SqlParameter("@Tname",t_name),
                new SqlParameter("@Yid",y_id)
                    };
            object i = DBHelper.ExecuteScalar(sql, CommandType.Text, p);
            if ((int)i > 0)
                return false;
            else
                return true;
        }

    /// <summary>
    /// 添加电影厅
    /// </summary>
    /// <param name="dyt"></param>
    /// <returns></returns>

        public static bool Insert_DianYingTing(DianYingTing dyt)
        {

            SqlParameter[] p = {
                new SqlParameter("@y_id",dyt.Y_id),
                  new SqlParameter("@t_name",dyt.T_name),
                    new SqlParameter("@t_count",dyt.T_count),
                       new SqlParameter("@t_row",dyt.T_row),
                      new SqlParameter("@t_line ",dyt.T_line)
                    };
            int i = DBHelper.ExecuteNonQuery("InsertDianYingTing", CommandType.StoredProcedure, p);
            return i > 0;
        }
    }
}
