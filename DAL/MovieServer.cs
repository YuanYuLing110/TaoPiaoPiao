﻿using System;
using Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
  public  class MovieServer
    {
        /// <summary>
        ///添加电影
        /// </summary>
        /// <param name="ddy"></param>
        /// <returns></returns>
        public static bool InsertMovie(Movie movie)
        {
            SqlParameter[] p = {
                new SqlParameter("@m_name",movie.M_name),
                  new SqlParameter("@m_image",movie.M_image),
                    new SqlParameter("@m_direct",movie.M_direct),
                      new SqlParameter("@m_star",movie.M_star),
                        new SqlParameter("@m_type	",movie.M_type),
                           new SqlParameter("@m_state ",movie.M_state),
                        new SqlParameter("@m_voice",movie.M_voice),
                        new SqlParameter("@m_time	  ",movie.M_time),
                        new SqlParameter("@m_grade",movie.M_grade),
                            new SqlParameter("@m_detail",movie.M_detail)
                     
                    };
            int i = DBHelper.ExecuteNonQuery("InsertMovie", CommandType.StoredProcedure, p);
            return i > 0;
        }

        /// <summary>
        ///根据票房查询前一周前五的电影
        /// </summary>
        public static List<Movie> search_Movie_byCountFive()
        {
            List<Movie> list = new List<Movie>();

            SqlDataReader sdr = DBHelper.ExecuteReader("search_Movie_byCountFive", CommandType.StoredProcedure, null);
            if (sdr.HasRows)
            {
                while (sdr.Read())
                {
                    Movie movie = new Movie();
                    movie.M_id = int.Parse(sdr["m_id"].ToString());
                    movie.M_name = sdr["m_Name"].ToString();
                    movie.M_image = (byte[])sdr["m_image"];
                    movie.M_direct = sdr["m_direct"].ToString();
                    movie.M_star = sdr["m_star"].ToString();
                    movie.M_type = sdr["m_type"].ToString();
                    movie.M_state = sdr["m_state"].ToString();
                    movie.M_voice = sdr["m_voice"].ToString();
                    movie.M_state = sdr["m_state"].ToString();
                    movie.M_voice = sdr["m_voice"].ToString();
                    movie.M_time = sdr["m_time"].ToString();
                    movie.M_grade = Convert.ToSingle(sdr["m_grade"]);
                    movie.M_detail = sdr["m_detail"].ToString();
                    movie.M_count = int.Parse(sdr["m_count"].ToString());
                    list.Add(movie);
                }
            }
            sdr.Close();
            return list;
        }

        /// <summary>
        ///根据id查询电影
        /// </summary>
        public static Movie search_Movie_byId(int id)
        {

            SqlParameter[] p = {
             
                        new SqlParameter("@id",id)
                    };
            SqlDataReader sdr = DBHelper.ExecuteReader("search_Movie_byId", CommandType.StoredProcedure, p);

            Movie movie = new Movie();
            movie.M_id = int.Parse(sdr["m_id"].ToString());
            movie.M_name = sdr["m_Name"].ToString();
            movie.M_image = (byte[])sdr["m_image"];
            movie.M_direct = sdr["m_direct"].ToString();
            movie.M_star = sdr["m_star"].ToString();
            movie.M_type = sdr["m_type"].ToString();
            movie.M_state = sdr["m_state"].ToString();
            movie.M_voice = sdr["m_voice"].ToString();
            movie.M_state = sdr["m_state"].ToString();
            movie.M_voice = sdr["m_voice"].ToString();
            movie.M_time = sdr["m_time"].ToString();
            movie.M_grade = Convert.ToSingle(sdr["m_grade"]);
            movie.M_detail = sdr["m_detail"].ToString();
            movie.M_count = int.Parse(sdr["m_count"].ToString());

            sdr.Close();
            return movie;
        }

        /// <summary>
        ///查询指定时间上映的电影
        /// </summary>
        public static List<Movie> search_NewMovie_byDate(DateTime dt)
        {

            SqlParameter[] p = {
             
                        new SqlParameter("@date",dt)
                    };
            List<Movie> list = new List<Movie>();
            SqlDataReader sdr = DBHelper.ExecuteReader("search_NewMovie_byDate", CommandType.StoredProcedure, p);
            if (sdr.HasRows)
            {
                while (sdr.Read())
                {
                    Movie movie = new Movie();
                    movie.M_id = int.Parse(sdr["m_id"].ToString());
                    movie.M_name = sdr["m_Name"].ToString();
                    movie.M_image = (byte[])sdr["m_image"];
                    movie.M_direct = sdr["m_direct"].ToString();
                    movie.M_star = sdr["m_star"].ToString();
                    movie.M_type = sdr["m_type"].ToString();
                    movie.M_state = sdr["m_state"].ToString();
                    movie.M_voice = sdr["m_voice"].ToString();
                    movie.M_state = sdr["m_state"].ToString();
                    movie.M_voice = sdr["m_voice"].ToString();
                    movie.M_time = sdr["m_time"].ToString();
                    movie.M_grade = Convert.ToSingle(sdr["m_grade"]);
                    movie.M_detail = sdr["m_detail"].ToString();
                    movie.M_count = int.Parse(sdr["m_count"].ToString());
                    movie.M_count = int.Parse(sdr["m_count"].ToString());
                    list.Add(movie);
                }
            }
            sdr.Close();
            return list;
        }

        /// <summary>
        ///查询所以即将上映的电影
        /// </summary>
        public static List<Movie> searchComing_soonMovieAll()
        {
            List<Movie> list = new List<Movie>();

            SqlDataReader sdr = DBHelper.ExecuteReader("searchComing_soonMovieAll", CommandType.StoredProcedure, null);
            if (sdr.HasRows)
            {
                while (sdr.Read())
                {
                    Movie movie = new Movie();
                    movie.M_id = int.Parse(sdr["m_id"].ToString());
                    movie.M_name = sdr["m_Name"].ToString();
                    movie.M_image = (byte[])sdr["m_image"];
                    movie.M_direct = sdr["m_direct"].ToString();
                    movie.M_star = sdr["m_star"].ToString();
                    movie.M_type = sdr["m_type"].ToString();
                    movie.M_state = sdr["m_state"].ToString();
                    movie.M_voice = sdr["m_voice"].ToString();
                    movie.M_state = sdr["m_state"].ToString();
                    movie.M_voice = sdr["m_voice"].ToString();
                    movie.M_time = sdr["m_time"].ToString();
                    movie.M_grade = Convert.ToSingle(sdr["m_grade"]);
                    movie.M_detail = sdr["m_detail"].ToString();
                    movie.M_count = int.Parse(sdr["m_count"].ToString());
                    list.Add(movie);
                }
            }
            sdr.Close();
            return list;
        }

        /// <summary>
        ///查询所以最近即将上映的电影
        /// </summary>
        public static List<Movie> searchComing_soonMovieFive()
        {
            List<Movie> list = new List<Movie>();

            SqlDataReader sdr = DBHelper.ExecuteReader("searchComing_soonMovieFive", CommandType.StoredProcedure, null);
            if (sdr.HasRows)
            {
                while (sdr.Read())
                {
                    Movie movie = new Movie();
                    movie.M_id = int.Parse(sdr["m_id"].ToString());
                    movie.M_name = sdr["m_Name"].ToString();
                    movie.M_image = (byte[])sdr["m_image"];
                    movie.M_direct = sdr["m_direct"].ToString();
                    movie.M_star = sdr["m_star"].ToString();
                    movie.M_type = sdr["m_type"].ToString();
                    movie.M_state = sdr["m_state"].ToString();
                    movie.M_voice = sdr["m_voice"].ToString();
                    movie.M_state = sdr["m_state"].ToString();
                    movie.M_voice = sdr["m_voice"].ToString();
                    movie.M_time = sdr["m_time"].ToString();
                    movie.M_grade = Convert.ToSingle(sdr["m_grade"]);
                    movie.M_detail = sdr["m_detail"].ToString();
                    movie.M_count = int.Parse(sdr["m_count"].ToString());
                    list.Add(movie);
                }
            }
            sdr.Close();
            return list;
        }


        /// <summary>
        ///搜索前五热门电影
        /// </summary>
        public static List<Movie> searchHotMovie()
        {
            List<Movie> list = new List<Movie>();

            SqlDataReader sdr = DBHelper.ExecuteReader("searchHotMovie", CommandType.StoredProcedure, null);
            if (sdr.HasRows)
            {
                while (sdr.Read())
                {
                    Movie movie = new Movie();
                    movie.M_id = int.Parse(sdr["m_id"].ToString());
                    movie.M_name = sdr["m_Name"].ToString();
                    movie.M_image = (byte[])sdr["m_image"];
                    movie.M_direct = sdr["m_direct"].ToString();
                    movie.M_star = sdr["m_star"].ToString();
                    movie.M_type = sdr["m_type"].ToString();
                    movie.M_state = sdr["m_state"].ToString();
                    movie.M_voice = sdr["m_voice"].ToString();
                    movie.M_state = sdr["m_state"].ToString();
                    movie.M_voice = sdr["m_voice"].ToString();
                    movie.M_time = sdr["m_time"].ToString();
                    movie.M_grade = Convert.ToSingle(sdr["m_grade"]);
                    movie.M_detail = sdr["m_detail"].ToString();
                    movie.M_count = int.Parse(sdr["m_count"].ToString());
                    list.Add(movie);
                }
            }
            sdr.Close();
            return list;
        }


        /// <summary>
        ///搜索所以热门电影
        /// </summary>
        public static List<Movie> searchHotMovieAll()
        {
            List<Movie> list = new List<Movie>();

            SqlDataReader sdr = DBHelper.ExecuteReader("searchHotMovieAll", CommandType.StoredProcedure, null);
            if (sdr.HasRows)
            {
                while (sdr.Read())
                {
                    Movie movie = new Movie();
                    movie.M_id = int.Parse(sdr["m_id"].ToString());
                    movie.M_name = sdr["m_Name"].ToString();
                    movie.M_image = (byte[])sdr["m_image"];
                    movie.M_direct = sdr["m_direct"].ToString();
                    movie.M_star = sdr["m_star"].ToString();
                    movie.M_type = sdr["m_type"].ToString();
                    movie.M_state = sdr["m_state"].ToString();
                    movie.M_voice = sdr["m_voice"].ToString();
                    movie.M_state = sdr["m_state"].ToString();
                    movie.M_voice = sdr["m_voice"].ToString();
                    movie.M_time = sdr["m_time"].ToString();
                    movie.M_grade = Convert.ToSingle(sdr["m_grade"]);
                    movie.M_detail = sdr["m_detail"].ToString();
                    movie.M_count = int.Parse(sdr["m_count"].ToString());
                    list.Add(movie);
                }
            }
            sdr.Close();
            return list;
        }


      

    }
}