using System;
using Model;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace DAL
{
  public  class ManageServer
    {

        /// <summary>
        ///添加管理员
        /// </summary>
        /// <param name="ddy"></param>
        /// <returns></returns>
      public static bool addManage(Manage ddy)
        {
            SqlParameter[] p = {
                new SqlParameter("@name",ddy.Name),
                  new SqlParameter("@password",ddy.Password),
                    new SqlParameter("@email",ddy.Email),
                    new SqlParameter("@DianYingYuan_id",ddy.DianYingYuan_id)
                   
                    
                    };
            int i = DBHelper.ExecuteNonQuery("InsertManage", CommandType.StoredProcedure, p);
            return i > 0;
        }

      /// <summary>
      ///同意加入
      /// </summary>
      /// <param name="ddy"></param>
      /// <returns></returns>
      public static bool tongYiManage(int id)
      {
          string sql = "update Manage set limit='common' where id=@id";

          SqlParameter[] p = {
               
                    new SqlParameter("@id",id)
                   
                    
                    };
          int i = DBHelper.ExecuteNonQuery(sql, CommandType.Text, p);
          return i > 0;
      }

      public static string getEmail(int id)
      {
          string sql = "select email  from Manage where id=@id";

          SqlParameter[] p = {
               
                    new SqlParameter("@id",id)
                   
                    
                    };
          String obj = (String)DBHelper.ExecuteScalar(sql, CommandType.Text, p);

          return obj;
      }
      /// <summary>
      /// 查询未通过的用户
      /// </summary>
      /// <returns></returns>
      public static SqlDataReader search_future_sr()
      {
          string sql = "select id,name,email,y_Name from Manage join DianYingYuan on Manage.DianYingYuan_id=DianYingYuan.y_id where  limit is null";

          SqlDataReader sr = DBHelper.ExecuteReader(sql,CommandType.Text,null);
          return sr;

      }

    

         /// <summary>
        /// 判断管理员是否存在
        /// </summary>
        /// <param name="UserName"></param>
        /// <param name="UserPwd"></param>
        /// <returns></returns>
        public static bool PanDuan_manageExit(string UserName)
        {
            string sql = "select count(*) from Manage where name=@UserName ";
            SqlParameter[] p = {
               
                new SqlParameter("@UserName",UserName)
                    };
            object i = DBHelper.ExecuteScalar(sql, CommandType.Text, p);
            if ((int)i > 0)
                return false;
            else
                return true;
        
        }


        /// <summary>
        /// 判断用户是否为超级管理员
        /// </summary>
        /// <param name="UserName"></param>
        /// <param name="UserPwd"></param>
        /// <returns></returns>
        public static bool PanDuan_SuperManage(string UserName, string UserPwd)
        {

            string sql = "select count(*) from Manage where name=@UserName and password=@UserPwd and limit='super'";
            SqlParameter[] p = {
                new SqlParameter("@UserPwd",UserPwd),
                new SqlParameter("@UserName",UserName)
                    };
            object i = DBHelper.ExecuteScalar(sql, CommandType.Text, p);
            return (int)i > 0;
          
        }



        /// 对字符串进行MD5变换
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public static string MD5(string password)
        {
            string s = System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(password, "MD5");
            return s;
        }



        /// <summary>
        /// 只根据用户名判断用户是否为超级管理员
        /// </summary>
        /// <param name="UserName"></param>
   
        /// <returns></returns>
        public static bool PanDuan_SuperManageByName(string UserName)
        {

            string sql = "select count(*) from Manage where name=@UserName  and limit='super'";
            SqlParameter[] p = {
              
                new SqlParameter("@UserName",UserName)
                    };
            object i = DBHelper.ExecuteScalar(sql, CommandType.Text, p);
            return (int)i > 0;

        }



        /// <summary>
        /// 判断用户是否为普通管理员
        /// </summary>
        /// <param name="UserName"></param>
        /// <param name="UserPwd"></param>
        /// <returns></returns>
        public static bool PanDuan_CommonManage(string UserName, string UserPwd)
        {

            string sql = "select count(*) from Manage where name=@UserName and password=@UserPwd and limit='common'";
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
        /// 发送邮件
        /// </summary>
        /// <param name="mailTo">要发送的邮箱</param>
        /// <param name="mailSubject">邮箱主题</param>
        /// <param name="mailContent">邮箱内容</param>
        /// <returns>返回发送邮箱的结果</returns>
        public static bool SendEmail(string mailTo)
        {
            // 设置发送方的邮件信息,例如使用网易的smtp
            string smtpServer = "smtp.126.com"; //SMTP服务器
            string mailFrom = "YuanYuLing110@126.com"; //登陆用户名
            string userPassword = "yyl961214";//登陆密码

            // 邮件服务设置
            SmtpClient smtpClient = new SmtpClient();
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;//指定电子邮件发送方式
            smtpClient.Host = smtpServer; //指定SMTP服务器
            smtpClient.Credentials = new System.Net.NetworkCredential(mailFrom, userPassword);//用户名和密码


            string mailSubject = "淘票票后台管理员注册成功通知！";

            string mailContent = "尊敬的用户你好欢迎加入<淘票票后台管理系统>,淘票票拥有大量的电影资源，祝使用愉快!";

            // 发送邮件设置        
            MailMessage mailMessage = new MailMessage(mailFrom, mailTo); // 发送人和收件人
            mailMessage.Subject = mailSubject;//主题
            mailMessage.Body = mailContent;//内容
            mailMessage.BodyEncoding = Encoding.UTF8;//正文编码
            mailMessage.IsBodyHtml = true;//设置为HTML格式
            mailMessage.Priority = MailPriority.Low;//优先级

            try
            {
                smtpClient.Send(mailMessage); // 发送邮件
                return true;
            }
            catch (SmtpException ex)
            {
                throw ex;
                //return false;
            }
        }

     
    }
}
