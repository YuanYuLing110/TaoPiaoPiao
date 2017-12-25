using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
  public  class DianYingTingManage
    {
        /// <summary>
        /// 根据电影院查询电影厅
        /// </summary>
        /// <param name="m_name"></param>
        /// <returns></returns>
        public static SqlDataReader search_DianYingTing_All(string m_name)
        {
            return DAL.DianYingTingServer.search_DianYingTing_All(m_name);
        }

        /// <summary>
        /// 判断电影院是否为存在
        /// </summary>    
        /// <returns></returns>
        public static bool PanDuan_DianYingTingExist(String t_name, int y_id)
        {
            return DAL.DianYingTingServer.PanDuan_DianYingTingExist(t_name,y_id);
        }

      
    /// <summary>
    /// 添加电影厅
    /// </summary>
    /// <param name="dyt"></param>
    /// <returns></returns>

        public static bool Insert_DianYingTing(DianYingTing dyt)
        {
            return DAL.DianYingTingServer.Insert_DianYingTing(dyt);
        
        }

       /// <summary>
        /// 根据电影院管理者查询电影厅
        /// </summary>
        /// <param name="m_name"></param>
        /// <returns></returns>
        public static List<DianYingTing> search_DianYingTing(string m_name)
        {
            return DAL.DianYingTingServer.search_DianYingTing(m_name);
        }
    }
}
