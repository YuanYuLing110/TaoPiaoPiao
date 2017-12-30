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
        /// <param name="ddy"></param>
        /// <returns></returns>
        public static bool addTianYingYuan(DianYingYuan ddy)
        {
            SqlParameter[] p = {
                new SqlParameter("@y_Name",ddy.Y_Name),
                  new SqlParameter("@y_address",ddy.Y_address),
                    new SqlParameter("@y_phone",ddy.Y_phone),
                       new SqlParameter("@y_provice ",ddy.Y_provice),
                      new SqlParameter("@y_city",ddy.Y_city),
                        new SqlParameter("@y_area",ddy.Y_area)
                    };
            int i = DBHelper.ExecuteNonQuery("InsertDianYingYuan", CommandType.StoredProcedure, p);
            return i > 0;
        }

        /// <summary>
        ///删除电影院，指定id
        /// </summary>
        /// <param name="ddy"></param>
        /// <returns></returns>
        public static bool deleteDianYingYuan(int id)
        {
            string sql = "delete DianYingYuan where y_id=@id";
            SqlParameter[] p = {
             
                new SqlParameter("@id",id)
                    };
            int i = DBHelper.ExecuteNonQuery(sql, CommandType.Text, p);
            return i > 0;
        }

     /// <summary>
     /// 查询所有电影院
     /// </summary>
     /// <returns></returns>
        public static SqlDataReader search_DianYingYuan_All()
        {
            string sql = "select * from DianYingYuan ";
            SqlDataReader sdr = DBHelper.ExecuteReader(sql, CommandType.Text, null);

            return sdr;
        }


        /// <summary>
        ///根据电影院评分排序查出当地的电影院
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static List<DianYingYuan> search_DianYingYuan_byGradeAreaAll(string area)
        {
            List<DianYingYuan> list = new List<DianYingYuan>();
            SqlParameter[] p = {
             
                        new SqlParameter("@area",area)
                    };
            SqlDataReader sdr = DBHelper.ExecuteReader("search_DianYingYuan_byGradeAreaAll", CommandType.StoredProcedure, p);
           if (sdr.HasRows)
           {
               while (sdr.Read())
               {
                   DianYingYuan dyy = new DianYingYuan();
                   dyy.Y_id = int.Parse(sdr["y_id"].ToString());
                   dyy.Y_Name = sdr["y_Name"].ToString();
                   dyy.Y_address = sdr["y_address"].ToString();
                   dyy.Y_phone = sdr["y_phone"].ToString();
                   dyy.Y_provice = sdr["y_provice"].ToString();
                   dyy.Y_city = sdr["y_city"].ToString();
                   dyy.Y_area = sdr["y_area"].ToString();
                  list.Add(dyy);
               }
           }
           sdr.Close();
           return list;
        }

        /// <summary>
        ///根据电影院id查询电影详情
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static DianYingYuan search_DianYingYuan_idl(int id)
        {
            //List<DianYingYuan> list = new List<DianYingYuan>();
            string str = "select * from DianYingYuan where y_id=@id";
            SqlParameter[] p = {
             
                        new SqlParameter("@id",id)
                    };
            DianYingYuan dyy = new DianYingYuan();
            SqlDataReader sdr = DBHelper.ExecuteReader(str, CommandType.Text, p);
            while (sdr.Read())
            {
                
                dyy.Y_id = int.Parse(sdr["y_id"].ToString());
                dyy.Y_grade = int.Parse(sdr["y_grade"].ToString());
                dyy.Y_Name = sdr["y_Name"].ToString();
                dyy.Y_address = sdr["y_address"].ToString();
                dyy.Y_phone = sdr["y_phone"].ToString();
                dyy.Y_provice = sdr["y_provice"].ToString();
                dyy.Y_city = sdr["y_city"].ToString();
                dyy.Y_area = sdr["y_area"].ToString();
              
            }
            sdr.Close();
            return dyy;
        }

        /// <summary>
        ///根据电影院名查询电影详情
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static DianYingYuan search_DianYingYuan_name(string name)
        {
            //List<DianYingYuan> list = new List<DianYingYuan>();
            string str = "select * from DianYingYuan where y_Name=@name";
            SqlParameter[] p = {
             
                        new SqlParameter("@name",name)
                    };
            DianYingYuan dyy = new DianYingYuan();
            SqlDataReader sdr = DBHelper.ExecuteReader(str, CommandType.Text, p);
            while (sdr.Read())
            {

                dyy.Y_id = int.Parse(sdr["y_id"].ToString());
                dyy.Y_Name = sdr["y_Name"].ToString();
                dyy.Y_address = sdr["y_address"].ToString();
                dyy.Y_phone = sdr["y_phone"].ToString();
                dyy.Y_provice = sdr["y_provice"].ToString();
                dyy.Y_city = sdr["y_city"].ToString();
                dyy.Y_area = sdr["y_area"].ToString();

            }
            sdr.Close();
            return dyy;
        }


        /// <summary>
        ///根据电影院评分排序查出当地的电影院
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static SqlDataReader search_DianYingYuan_byGradeAreaAll_sr(string area)
        {
            List<DianYingYuan> list = new List<DianYingYuan>();
            SqlParameter[] p = {
             
                        new SqlParameter("@area",area)
                    };
            SqlDataReader sdr = DBHelper.ExecuteReader("search_DianYingYuan_byGradeAreaAll", CommandType.StoredProcedure, p);
           
            return sdr;
        }


        /// <summary>
        ///根据电影院评分排序查出所在城市的电影院
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static List<DianYingYuan> search_DianYingYuan_byGradeCityAll(string city)
        {
            List<DianYingYuan> list = new List<DianYingYuan>();
            SqlParameter[] p = {
             
                        new SqlParameter("@city",city)
                    };
            SqlDataReader sdr = DBHelper.ExecuteReader("search_DianYingYuan_byGradeCityAll", CommandType.StoredProcedure, p);
            if (sdr.HasRows)
            {
                while (sdr.Read())
                {
                    DianYingYuan dyy = new DianYingYuan();
                    dyy.Y_id = int.Parse(sdr["y_id"].ToString());
                    dyy.Y_Name = sdr["y_Name"].ToString();
                    dyy.Y_address = sdr["y_address"].ToString();
                    dyy.Y_phone = sdr["y_phone"].ToString();
                    dyy.Y_provice = sdr["y_provice"].ToString();
                    dyy.Y_grade = Convert.ToDouble(sdr["y_grade"].ToString());
                    dyy.Y_city = sdr["y_city"].ToString();
                    dyy.Y_area = sdr["y_area"].ToString();
                    list.Add(dyy);
                }
            }
            sdr.Close();
            return list;
        }

     /// <summary>
        ///根据电影院评分排序查出所在城市的电影院
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static SqlDataReader search_DianYingYuan_byGradeCityAll_sr(string city)
        {
           
            SqlParameter[] p = {
             
                        new SqlParameter("@city",city)
                    };
            SqlDataReader sdr = DBHelper.ExecuteReader("search_DianYingYuan_byGradeCityAll", CommandType.StoredProcedure, p);
          
            return sdr;
        }

        /// <summary>
        ///根据电影院评分排序查出所在城市的电影院前五
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static List<DianYingYuan> search_DianYingYuan_byGradeCityFive(string city)
        {
            List<DianYingYuan> list = new List<DianYingYuan>();
            SqlParameter[] p = {
             
                        new SqlParameter("@city",city)
                    };
            SqlDataReader sdr = DBHelper.ExecuteReader("search_DianYingYuan_byGradeCityFive", CommandType.StoredProcedure, p);
            if (sdr.HasRows)
            {
                while (sdr.Read())
                {
                    DianYingYuan dyy = new DianYingYuan();
                    dyy.Y_id = int.Parse(sdr["y_id"].ToString());
                    dyy.Y_Name = sdr["y_Name"].ToString();
                    dyy.Y_address = sdr["y_address"].ToString();
                    dyy.Y_phone = sdr["y_phone"].ToString();
                    dyy.Y_provice = sdr["y_provice"].ToString();
                    dyy.Y_city = sdr["y_city"].ToString();
                    dyy.Y_area = sdr["y_area"].ToString();
                    list.Add(dyy);
                }
            }
            sdr.Close();
            return list;
        }

      

        /// <summary>
        ///修改电影院
        /// </summary>
        /// <param name="ddy"></param>
        /// <returns></returns>
        public static bool alterDianYingYuan(DianYingYuan ddy)
        {
            SqlParameter[] p = {
                   new SqlParameter("@id",ddy.Y_id),
                new SqlParameter("@y_Name",ddy.Y_Name),
                  new SqlParameter("@y_address",ddy.Y_address),
                    new SqlParameter("@y_phone",ddy.Y_phone),
                       new SqlParameter("@y_provice ",ddy.Y_provice),
                      new SqlParameter("@y_city",ddy.Y_city),
                        new SqlParameter("@y_area",ddy.Y_area)
                    };
            int i = DBHelper.ExecuteNonQuery("alterDianYingYuan", CommandType.StoredProcedure, p);
            return i > 0;
        }

        /// <summary>
        /// 判断电影院是否为存在
        /// </summary>    
        /// <returns></returns>
        public static bool PanDuan_DianYingYianExist(String name)
        {

            string sql = "select Count(*) from DianYingYuan where y_Name=@name";
            SqlParameter[] p = {
             
                new SqlParameter("@name",name)
                    };
            object i = DBHelper.ExecuteScalar(sql, CommandType.Text, p);
            if ((int)i > 0)
                return false;
            else
                return true;
        }

        /// <summary>
        /// 根据城市查询电影院总数
        /// </summary>    
        /// <returns></returns>
        public static int search_DianYingYuanCount_byCity(int city)
        {


            SqlParameter[] p = {
             
                new SqlParameter("@city",city)
                    };
            object i = DBHelper.ExecuteScalar("search_DianYingYuanCount_byCity", CommandType.StoredProcedure, p);
            return (int)i;

        }

        /// <summary>
        /// 根据区域查询电影院总数
        /// </summary>    
        /// <returns></returns>
        public static int search_DianYingYuanCount_byArea(int area)
        {


            SqlParameter[] p = {
             
                new SqlParameter("@area",area)
                    };
            object i = DBHelper.ExecuteScalar("search_DianYingYuanCount_byArea", CommandType.StoredProcedure, p);
            return (int)i;

        }

     /// <summary>
     /// 根据管理员姓名搜索电影院id
     /// </summary>
     /// <param name="st"></param>
     /// <returns></returns>

     public static int search_DianYingYuanId_byM_name(string st)
     {
         string str = "select DianYingYuan_id from Manage  where name=@name";
      SqlParameter[] p = {
             
                new SqlParameter("@name",st)
                    };
            object i = DBHelper.ExecuteScalar(str, CommandType.Text, p);
            return (int)i;
     }
    }
}
