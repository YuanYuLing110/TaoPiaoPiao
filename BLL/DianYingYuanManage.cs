﻿using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
  public  class DianYingYuanManage
    {

       /// <summary>
        ///添加电影院
        /// </summary>
        /// <param name="ddy"></param>
        /// <returns></returns>
      public static bool addTianYingYuan(DianYingYuan ddy) {
          return DAL.DianYingYuanServer.addTianYingYuan(ddy);
      }

      ///删除电影院，指定id
      /// </summary>
      /// <param name="ddy"></param>
      /// <returns></returns>
      public static bool deleteDianYingYuan(int id)
       {
           return DAL.DianYingYuanServer.deleteDianYingYuan(id);
       }
       /// <summary>
        ///根据电影院评分排序查出当地的电影院
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
      public static SqlDataReader search_DianYingYuan_byGradeAreaAll_sr(string area)
      {
          return DAL.DianYingYuanServer.search_DianYingYuan_byGradeAreaAll_sr(area);
      }

      /// <summary>
     /// 查询所有电影院
     /// </summary>
     /// <returns></returns>
      public static SqlDataReader search_DianYingYuan_All()
      {
          return DAL.DianYingYuanServer.search_DianYingYuan_All();
      }

      /// <summary>
      ///根据电影院评分排序查出当地的电影院
      /// </summary>
      /// <param name="id"></param>
      /// <returns></returns>
      public static List<DianYingYuan> search_DianYingYuan_byGradeAreaAll(string area)
      {
          return DAL.DianYingYuanServer.search_DianYingYuan_byGradeAreaAll(area);
      }

      /// <summary>
      ///根据电影院评分排序查出当地的电影院
      /// </summary>
      /// <param name="id"></param>
      /// <returns></returns>
      public static SqlDataReader search_DianYingYuan_byGradeCityAll_sr(string area)
      {
          return DAL.DianYingYuanServer.search_DianYingYuan_byGradeCityAll_sr(area);
      }
      /// <summary>
        ///根据电影院评分排序查出所在城市的电影院
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
      public static List<DianYingYuan> search_DianYingYuan_byGradeCityAll(string city)
      {
          return DAL.DianYingYuanServer.search_DianYingYuan_byGradeCityAll(city);
      }

       /// <summary>
        ///根据电影院评分排序查出所在城市的电影院前五
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
      public static List<DianYingYuan> search_DianYingYuan_byGradeCityFive(string city)
      {
          return DAL.DianYingYuanServer.search_DianYingYuan_byGradeCityFive(city);
      }

       /// <summary>
        ///修改电影院
        /// </summary>
        /// <param name="ddy"></param>
        /// <returns></returns>
      public static bool alterDianYingYuan(DianYingYuan ddy) {
          return DAL.DianYingYuanServer.alterDianYingYuan(ddy);
      }

       /// <summary>
        /// 判断电影院是否为存在
        /// </summary>    
        /// <returns></returns>
      public static bool PanDuan_DianYingYianExist(String name)
      {
          return DAL.DianYingYuanServer.PanDuan_DianYingYianExist(name);
      }

        /// <summary>
        /// 根据城市查询电影院总数
        /// </summary>    
        /// <returns></returns>
      public static int search_DianYingYuanCount_byCity(int city)
      {
          return DAL.DianYingYuanServer.search_DianYingYuanCount_byCity(city);
      }

      /// <summary>
        /// 根据区域查询电影院总数
        /// </summary>    
        /// <returns></returns>
      public static int search_DianYingYuanCount_byArea(int area)
      {
          return DAL.DianYingYuanServer.search_DianYingYuanCount_byArea(area);
      }
    }
}