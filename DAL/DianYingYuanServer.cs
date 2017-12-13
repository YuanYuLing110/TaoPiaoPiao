using System;
using System.Collections.Generic;
using Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
 public   class DianYingYuanServer
    {

        /// <summary>
        ///添加电影院
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool addTianYingYuan(DianYingYuan ddy)
        {
            SqlParameter[] p = {
                new SqlParameter("@@y_Name",ddy.Y_Name),
                  new SqlParameter("@y_address",ddy.Y_address),
                    new SqlParameter("@y_phone",ddy.Y_phone),
                      new SqlParameter("@y_city	 ",ddy.Y_city),
                        new SqlParameter("@y_area",ddy.Y_area)
                    };
            int i = DBHelper.ExecuteNonQuery("InsertDianYingYuan", CommandType.StoredProcedure, p);
            return i > 0;
        }

    }
}
