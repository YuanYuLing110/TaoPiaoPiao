//using RepastHelper;
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
 public    class UsersServer
    {
        /// <summary>
        /// 判断用户是否存在
        /// </summary>
        /// <param name="UserName"></param>
        /// <param name="UserPwd"></param>
        /// <returns></returns>
        public static bool PanDuan_User(string UserName, string UserPwd)
        {
            bool pd = false;
            List<Users> u = UsersServer.ChaXunAll();
            for (int i = 0; i < u.Count; i++)
            {
                if (UserName == u[i].U_NAME)
                {
                    if (UserPwd == u[i].U_PSSWORD)
                    {
                        pd = true;
                        break;
                    }
                }
            }
            return pd;
        }


        public static int ChaXunUserId(string UserName)
        {
            string sqlTest = "select U_ID from Users where U_NAME=@name";
            SqlParameter[] sp =
            {
            new SqlParameter("@name",UserName)
            };
            object o=DBHelper.ExecuteScalar(sqlTest,CommandType.Text,sp);
        return (int)o;
        }

        /// <summary>
        /// 查询所有用户
        /// </summary>
        /// <returns></returns>
        public static List<Users> ChaXunAll()
        {
            List<Users> a = new List<Users>();
            string sqlTest = "select * from Users";
            SqlDataReader sdr = DBHelper.ExecuteReader(sqlTest, CommandType.Text, null);
            if (sdr.HasRows)
            {
                while (sdr.Read())
                {
                    Users pro = new Users();
                    //pro.L_NAME = int.Parse(sdr["id"].ToString());
                    pro.U_NAME = sdr["U_NAME"].ToString();
                    pro.U_PSSWORD = sdr["U_PSSWORD"].ToString();
                    //pro.Name = sdr["UserCompellation"].ToString();
                    a.Add(pro);
                }
            }
            sdr.Close();
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
            string sql = "update Users set UserPwd=@UserPwd where UserName=@UserName";
            SqlParameter[] p = {
                new SqlParameter("@UserPwd",UserPwd),
                new SqlParameter("@UserName",UserName)
                    };
            int i = DBHelper.ExecuteNonQuery(sql, CommandType.Text, p);
            return i > 0;
        }

     /// <summary>
     /// 添加新的用户
     /// </summary>
     /// <param name="u"></param>
     /// <returns></returns>
        public static bool insertUser(Users u)
        {
            string sql = "insert into Users values(@name,@pwd,@email,@time)";
            SqlParameter[] p ={
                      new SqlParameter("@name",u.U_NAME), 
                      new SqlParameter("@pwd",u.U_PSSWORD),
                      new SqlParameter("@email",u.U_EMAIL),
                      new SqlParameter("@time",u.U_REGISTERTIME)
                             };
          int i = DBHelper.ExecuteNonQuery(sql, CommandType.Text, p);
            return i > 0;
        }


        /// <summary>
        /// 加密
        /// </summary>
        /// <param name="st">要加密的数据</param>
        /// <returns></returns>
        public static string Jiami(string st)
        {
            string result = "";
            if (st == null || st == "")
            {
                result = "";
            }
            else
            {
                result = Convert.ToBase64String(System.Text.Encoding.Default.GetBytes("" + st + "")).Replace("+", "%2B");
            }
            return result;
        }


        /// <summary>
        /// 解密
        /// </summary>
        /// <param name="st">要解密的字符串</param>
        /// <returns></returns>

        public static string jiemi(string st)
        {
            string result = "";
            if (st == null || st == "")
            {
                result = "";
            }
            else
            {
                try
                {
                    result = System.Text.Encoding.Default.GetString(Convert.FromBase64String(st.Replace("%2B", "+")));
                }
                catch (FormatException ex)
                {
                    result = "0";
                    throw (ex);
                }
            }
            return result;
        }

        //public static bool InsertUser(User u)
        //{ 
           
        //}
    }
}
