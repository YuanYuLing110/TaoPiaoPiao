using System;
using Model;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
  public  class ManageServer
    {

        /// <summary>
        /// 判断用户是否为超级管理员
        /// </summary>
        /// <param name="UserName"></param>
        /// <param name="UserPwd"></param>
        /// <returns></returns>
        public static bool PanDuan_SuperManage(string UserName, string UserPwd)
        {
           
            string sql = "select count(*) from Manage where name=@UserName and password=@UserPwd and limit=1";
            SqlParameter[] p = {
                new SqlParameter("@UserPwd",UserPwd),
                new SqlParameter("@UserName",UserName)
                    };
            object i = DBHelper.ExecuteScalar(sql, CommandType.Text, p);
            return (int)i > 0;
          
        }

        /// <summary>
        /// 只根据用户名判断用户是否为超级管理员
        /// </summary>
        /// <param name="UserName"></param>
   
        /// <returns></returns>
        public static bool PanDuan_SuperManageByName(string UserName)
        {

            string sql = "select count(*) from Manage where name=@UserName  and limit=1";
            SqlParameter[] p = {
              
                new SqlParameter("@UserName",UserName)
                    };
            object i = DBHelper.ExecuteScalar(sql, CommandType.Text, p);
            return (int)i > 0;

        }
        /// <summary>
        /// 判断用户是否为超级管理员
        /// </summary>
        /// <param name="UserName"></param>
        /// <param name="UserPwd"></param>
        /// <returns></returns>
        public static bool PanDuan_CommonManage(string UserName, string UserPwd)
        {

            string sql = "select count(*) from Manage where name=@UserName and password=@UserPwd";
            SqlParameter[] p = {
                new SqlParameter("@UserPwd",UserPwd),
                new SqlParameter("@UserName",UserName)
                    };
            object i = DBHelper.ExecuteScalar(sql, CommandType.Text, p);
            return (int)i > 0;

        }

        /// 查询所有用户
        /// </summary>
        /// <returns></returns>
        public static List<Manage> ChaXunAll()
        {
            List<Manage> a = new List<Manage>();
            //string sqlTest = "select * from Manage";
            //SqlDataReader sdr = DBHelper.ExecuteReader(sqlTest, CommandType.Text, null);
            //if (sdr.HasRows)
            //{
            //    while (sdr.Read())
            //    {
            //        Manage pro = new Manage();
            //        //pro.L_NAME = int.Parse(sdr["id"].ToString());
            //        pro.U_NAME = sdr["U_NAME"].ToString();
            //        pro.U_PSSWORD = sdr["U_PSSWORD"].ToString();
            //        //pro.Name = sdr["UserCompellation"].ToString();
            //        a.Add(pro);
            //    }
            //}
            //sdr.Close();
            return a;
        }

        /// <summary>
        /// 删除用户2
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool DeleteUserProc(string UserName)
        {
            SqlParameter[] p = {
                new SqlParameter("@UserName",UserName)
                    };
            int i = DBHelper.ExecuteNonQuery("DeleteUser", CommandType.StoredProcedure, p);
            return i > 0;
        }

        /// <summary>
        /// 修改用户密码
        /// </summary>
        public static bool ChangeUserPwd(string UserName, string UserPwd)
        {
            string sql = "update Manage set UserPwd=@UserPwd where UserName=@UserName";
            SqlParameter[] p = {
                new SqlParameter("@UserPwd",UserPwd),
                new SqlParameter("@UserName",UserName)
                    };
            int i = DBHelper.ExecuteNonQuery(sql, CommandType.Text, p);
            return i > 0;
        }

        /// <summary>
        /// 根据管理员id判断管理的哪一个影院
        /// </summary>
        /// <param name="ManageID"></param>
        /// <returns></returns>
        public static String Search_DianYingYuan_byManageName(string ManageName)
        {
            try
            {

                string sqlTest =
                    @"select y_name from DianYingYuan join Manage on DianYingYuan.y_id=Manage.DianYingYuan_id where Manage.name=@name";
                SqlParameter[] par =
               {
                   new SqlParameter ("@name",ManageName)
               };



                Object obj = DBHelper.ExecuteScalar(sqlTest, CommandType.Text, par);
                return Convert.ToString(obj);
            }
            catch (Exception)
            {
                return null;
            }

        }


        /// <summary>
        /// 添加新的用户
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        //public static bool insertUser(Manage u)
        //{
        //    string sql = "insert into Manage values(@name,@pwd,@email,@time)";
        //    SqlParameter[] p ={
        //              new SqlParameter("@name",u.U_NAME), 
        //              new SqlParameter("@pwd",u.U_PSSWORD),
        //              new SqlParameter("@email",u.U_EMAIL),
        //              new SqlParameter("@time",u.U_REGISTERTIME)
        //                     };
        //    int i = DBHelper.ExecuteNonQuery(sql, CommandType.Text, p);
        //    return i > 0;
        //}
    }
}
