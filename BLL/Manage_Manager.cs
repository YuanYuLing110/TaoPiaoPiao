using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class Manage_Manager
    {

        /// <summary>
        /// 判断用户是否为超级管理员
        /// </summary>
        /// <param name="UserName"></param>
        /// <param name="UserPwd"></param>
        /// <returns></returns>
        public static bool PanDuan_SuperManage(string UserName, string UserPwd)
        {


            return DAL.ManageServer.PanDuan_SuperManage(UserName, UserPwd);

        }
        /// <summary>
        /// 只根据用户名判断用户是否为超级管理员
        /// </summary>
        /// <param name="UserName"></param>

        /// <returns></returns>
        public static bool PanDuan_SuperManageByName(string UserName)
        {


            return DAL.ManageServer.PanDuan_SuperManageByName(UserName);

        }
        /// <summary>
        /// 判断用户是否为超级管理员
        /// </summary>
        /// <param name="UserName"></param>
        /// <param name="UserPwd"></param>
        /// <returns></returns>
        public static bool PanDuan_CommonManage(string UserName, string UserPwd)
        {


            return DAL.ManageServer.PanDuan_CommonManage(UserName, UserPwd);

        }

          /// <summary>
        /// 根据管理员id判断管理的哪一个影院
        /// </summary>
        /// <param name="ManageID"></param>
        /// <returns></returns>
        public static String Search_DianYingYuan_byManageName(string ManageName)
        {
            return DAL.ManageServer.Search_DianYingYuan_byManageName(ManageName);
        }
    }
}
