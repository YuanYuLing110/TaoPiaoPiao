﻿using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class Manage_Manager
    {
          /// <summary>
        ///添加电影院
        /// </summary>
        /// <param name="ddy"></param>
        /// <returns></returns>
       public static bool addManage(Manage ddy)
       {
           return DAL.ManageServer.addManage(ddy);
       }

        /// <summary>
        /// 判断管理员是否存在
        /// </summary>
        /// <param name="UserName"></param>
        /// <param name="UserPwd"></param>
        /// <returns></returns>
       public static bool PanDuan_manageExit(string UserName)
       {
           return DAL.ManageServer.PanDuan_manageExit(UserName);
       }

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

        /// 对字符串进行MD5变换
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public static string MD5(string password)
        {
            return DAL.ManageServer.MD5(password);
        }

        /// <summary>
        /// 发送邮件
        /// </summary>
        /// <param name="mailTo">要发送的邮箱</param>
        /// <param name="mailSubject">邮箱主题</param>
        /// <param name="mailContent">邮箱内容</param>
        /// <returns>返回发送邮箱的结果</returns>
        public static bool SendEmail(string mailTo)
        {
            return DAL.ManageServer.SendEmail(mailTo);
        }

        /// <summary>
      /// 查询未通过的用户
      /// </summary>
      /// <returns></returns>
        public static SqlDataReader search_future_sr()
        {
            return DAL.ManageServer.search_future_sr();
        }

        /// <summary>
      ///同意加入
      /// </summary>
      /// <param name="ddy"></param>
      /// <returns></returns>
        public static bool tongYiManage(int id)
        {
          return  DAL.ManageServer.tongYiManage(id);
        }
    }
}
