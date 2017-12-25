using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.SqlClient;

namespace BLL
{
  public  class PianChangManage
    {

        /// <summary>
        /// 添加片场
        /// </summary>
        /// <param name="pc"></param>
        /// <returns></returns>

      public static bool Insert_DianYingTing(PianChang pc)
      {
          return DAL.PianChangServer.Insert_DianYingTing(pc);
      }

       /// <summary>
     /// 根据电影查询安排的片场
     /// </summary>
     /// <param name="m_id"></param>
     /// <param name="y_id"></param>
     /// <returns></returns>
      public static SqlDataReader search_pianChang_byMovie_sr(int m_id, int y_id) 
  {
      return DAL.PianChangServer.search_pianChang_byMovie_sr(m_id,y_id);
      }

   /// <summary>
        /// 根据电影厅查询安排的片场
        /// </summary>
        /// <param name="m_id"></param>
        /// <param name="y_id"></param>
        /// <returns></returns>
      public static SqlDataReader search_pianChang_byDianYingTing_sr(int t_id, int y_id)
      {
          return DAL.PianChangServer.search_pianChang_byDianYingTing_sr(t_id,y_id);
      }

       /// <summary>
        /// 查询未来安排的所有片场
        /// </summary>
        /// <param name="m_id"></param>
        /// <param name="y_id"></param>
        /// <returns></returns>
      public static SqlDataReader search_pianChang_All_sr( int y_id)
      {
          return DAL.PianChangServer.search_pianChang_All_sr(y_id);
      }
    }
}
