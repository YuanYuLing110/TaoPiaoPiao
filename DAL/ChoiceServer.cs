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
  public  class ChoiceServer
    {
        /// <summary>
        /// 添加片场
        /// </summary>
        /// <param name="pc"></param>
        /// <returns></returns>

        public static bool Insert_DianYingTing(Choice cho)
        {

            SqlParameter[] p = {
                new SqlParameter("@p_id",cho.P_id),
                  new SqlParameter("@u_id",cho.U_id),
                    new SqlParameter("@c_name",cho.C_name)
                    };
            int i = DBHelper.ExecuteNonQuery("insertChoice ", CommandType.StoredProcedure, p);
            return i > 0;
        }
    }
}
