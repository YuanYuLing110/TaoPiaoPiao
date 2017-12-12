using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DBHelper
    {
        /// <summary>
        /// 创建连接对象
        /// </summary>
        /// <returns>连接对象</returns>
        //public static SqlConnection CreateConn()
        //{
        //    string connStr = ConfigurationManager.ConnectionStrings["sql2005"].ConnectionString;
        //    SqlConnection conn = new SqlConnection(connStr);
        //    return conn;
        //}
   static  string connStr = ConfigurationManager.ConnectionStrings["sql2005"].ConnectionString;
        /// <summary>
        /// 增、删、改操作
        /// </summary>
        /// <param name="sqlText">sql语句</param>
        /// <returns>受影响的行数</returns>
        public static int ExecuteNonQuery(string sqlText, CommandType type, SqlParameter[] pars)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
              
                try
                    {
                        conn.Open();
                SqlCommand cmd = new SqlCommand(sqlText, conn);
                cmd.CommandType = type;

                if (pars != null)
                {
                    cmd.Parameters.AddRange(pars);
                }
                int count = cmd.ExecuteNonQuery();
                
                return count;
                    }
                 catch(SystemException ex)
                {
                    conn.Close();
                    throw ex;
                 }
            }
        }
        /// <summary>
        /// 单值查询
        /// </summary>
        /// <param name="sqlText">sql语句</param>
        /// <returns>单个值</returns>
        public static object ExecuteScalar(string sqlText, CommandType type,SqlParameter[] pars)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
               
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sqlText, conn);
                    cmd.CommandType = type;
                    if (pars != null)
                    {
                        cmd.Parameters.AddRange(pars);
                    }
                    object obj = cmd.ExecuteScalar();
                    conn.Close();
                    return obj;
                }
                catch (SystemException ex)
                {
                    conn.Close();
                    throw ex;
                }
            }
        }
        /// <summary>
        /// 多值查询:查询一行数据
        /// </summary>
        /// <param name="sqlText"></param>
        /// <returns></returns>
        public static SqlDataReader ExecuteReader(string sqlText, CommandType type, SqlParameter[] pars)
        {
            SqlConnection conn = new SqlConnection(connStr);
           
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlText, conn);
                cmd.CommandType = type;
                //判断pars是否为空
                if (pars != null)
                {
                    cmd.Parameters.AddRange(pars);
                }
                SqlDataReader sdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                return sdr;
            }
            catch (SystemException ex)
            {
                conn.Close();
                throw ex;
            }
        }
    }
}
