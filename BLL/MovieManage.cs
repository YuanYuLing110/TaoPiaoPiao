﻿using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class MovieManage
    {

        /// <summary>
        ///添加电影
        /// </summary>
        /// <param name="ddy"></param>
        /// <returns></returns>
       public static bool InsertMovie(Movie movie)
       {
           return DAL.MovieServer.InsertMovie(movie);
       }

        /// <summary>
    

         /// <summary>
        ///根据票房查询前一周前五的电影
        /// </summary>
       public static List<Movie> search_Movie_byCountFive()
       {
           return DAL.MovieServer.search_Movie_byCountFive();
       }


       /// <summary>
       ///根据id查询电影
       /// </summary>
       public static Movie search_Movie_byId(int id) {
           return DAL.MovieServer.search_Movie_byId(id);
       }

        /// <summary>
        ///查询指定时间上映的电影
        /// </summary>
       public static List<Movie> search_NewMovie_byDate(DateTime dt)
       {
           return DAL.MovieServer.search_NewMovie_byDate(dt);
       }


        /// <summary>
        ///查询所以即将上映的电影
        /// </summary>
       public static List<Movie> searchComing_soonMovieAll()
       {
           return DAL.MovieServer.searchComing_soonMovieAll();
       }

       /// <summary>
        ///查询所以最近即将上映的电影
        /// </summary>
       public static List<Movie> searchComing_soonMovieFive()
       {
           return DAL.MovieServer.searchComing_soonMovieFive();
       }

       /// <summary>
        ///搜索前五热门电影
        /// </summary>
       public static List<Movie> searchHotMovie()
       {
           return DAL.MovieServer.searchHotMovie();
       }

        /// <summary>
        ///搜索所以热门电影
        /// </summary>
       public static List<Movie> searchHotMovieAll()
       {
           return DAL.MovieServer.searchHotMovieAll();
       }
    }
}