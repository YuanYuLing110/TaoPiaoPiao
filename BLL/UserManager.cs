using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace BLL
{
  public   class UserManager
    {
         /// <summary>
        /// 判断用户是否存在
        /// </summary>
        /// <param name="UserName"></param>
        /// <param name="UserPwd"></param>
        /// <returns></returns>
        public static bool PanDuan_User(string UserName, string UserPwd)
        {

            return UsersServer.PanDuan_User(UserName,UserPwd);  
        }

         /// <summary>
        /// 查询所有用户
        /// </summary>
        /// <returns></returns>
        public static List<Users> ChaXunAll()
        {
            return UsersServer.ChaXunAll();
        }

        
        /// <summary>
        /// 修改用户密码
        /// </summary>
        public static bool ChangeUserPwd(string UserName, string UserPwd)
        {
            return UsersServer.ChangeUserPwd(UserName,UserPwd);
        }
           /// <summary>
     /// 添加新的用户
     /// </summary>
     /// <param name="u"></param>
     /// <returns></returns>
        public static bool insertUser(Users u)
        {
            return UsersServer.insertUser(u);
        }
    }
}
