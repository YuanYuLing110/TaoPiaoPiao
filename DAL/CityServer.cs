using System;
using System.Xml;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;

namespace DAL
{
   
 public   class CityServer
    {

        public static XmlDocument Provincedoc;
        public static XmlDocument Citydoc;
        public static XmlDocument Districtdoc;

        public static XmlElement ProvincerootElem;
        public static XmlElement CityrootElem;
        public static XmlElement DistrictrootElem;

        public static XmlNodeList ProvinceNodes;
        public static XmlNodeList CityNodes;
        public static XmlNodeList DistrictNodes;

       public static  string ProvinceID;
       
  public static string CityID;

     /// <summary>
     /// 获取所有省份
     /// </summary>
     /// <returns></returns>
       public static List<string> getProvice()
     {
         List<string> pro = new List<string>();
         //string ss = System.IO.Directory.GetCurrentDirectory();
         string xmlPath = System.Web.HttpRuntime.AppDomainAppPath + "\\XML\\Provinces.xml";
         Provincedoc = new XmlDocument();
         //string st = @"../XML/Provinces.xml";
       //  string path = Path.GetFullPath(st);
         Provincedoc.Load(xmlPath);    //加载Xml文件    
         ProvincerootElem = Provincedoc.DocumentElement;   //获取根节点    
         ProvinceNodes = ProvincerootElem.GetElementsByTagName("Province"); //获取Provinces子节点集合  
         foreach (XmlNode Provincenode in ProvinceNodes)  
          {  
              string strProvinceName = ((XmlElement)Provincenode).GetAttribute("ProvinceName");   //获取name属性值    
              string strProvinceID = ((XmlElement)Provincenode).GetAttribute("ID");
              pro.Add(strProvinceName);
              //comboBox_sheng.Items.Add(strProvinceName);  
          }
         return pro;
     
     }

       public static XmlNodeList setProvinceNodes()
       {
           string xmlPath = System.Web.HttpRuntime.AppDomainAppPath + "\\XML\\Provinces.xml";
           Provincedoc = new XmlDocument();
           //string st = @"../XML/Provinces.xml";
           //  string path = Path.GetFullPath(st);
           Provincedoc.Load(xmlPath);    //加载Xml文件    
           ProvincerootElem = Provincedoc.DocumentElement;   //获取根节点    
           ProvinceNodes = ProvincerootElem.GetElementsByTagName("Province"); //获取Provinces子节点集合  

           return ProvinceNodes;
       }
     /// <summary>
     /// 根据省份获取市
     /// </summary>
     /// <param name="proviceName"></param>
     /// <returns></returns>
       public static List<string> getCity(string proviceName)
       {
           //setProvinceNodes();
           string xmlPath = System.Web.HttpRuntime.AppDomainAppPath + "\\XML\\Cities.xml";
           List<string> pro = new List<string>();
              Citydoc = new XmlDocument();
              Citydoc.Load(xmlPath);    //加载Xml文件    
           CityrootElem = Citydoc.DocumentElement;   //获取根节点    
           CityNodes = CityrootElem.GetElementsByTagName("City"); //获取Cities子节点集合   

          foreach (XmlNode Provincenode in ProvinceNodes)  
          {  
              if (((XmlElement)Provincenode).GetAttribute("ProvinceName").Equals(proviceName))  
              {  
                  ProvinceID = ((XmlElement)Provincenode).GetAttribute("ID");  
                  break;  
              }  
          }  
          foreach (XmlNode Citynode in CityNodes)  
          {  
              if (((XmlElement)Citynode).GetAttribute("PID").Equals(ProvinceID))  
              {  
                  string strCityName = ((XmlElement)Citynode).GetAttribute("CityName");
                  pro.Add(strCityName);
              }  
          }

          return pro;
       }


       public static List<string> getDistricts(string cityName)
       {
           string xmlPath = System.Web.HttpRuntime.AppDomainAppPath + "\\XML\\Districts.xml";
           List<string> pro = new List<string>();
           Districtdoc = new XmlDocument();
           Districtdoc.Load(xmlPath);    //加载Xml文件    
           DistrictrootElem = Districtdoc.DocumentElement;   //获取根节点    
           DistrictNodes = DistrictrootElem.GetElementsByTagName("District"); //获取Cities子节点集合 

               
             foreach (XmlNode Citynode in CityNodes)  
       {
           if (((XmlElement)Citynode).GetAttribute("CityName").Equals(cityName) && ((XmlElement)Citynode).GetAttribute("PID").Equals(ProvinceID))  
           {  
               CityID = ((XmlElement)Citynode).GetAttribute("ID");  
               break;  
            }  
        }  
        foreach (XmlNode Districtnode in DistrictNodes)  
        {  
            if (((XmlElement)Districtnode).GetAttribute("CID").Equals(CityID))  
            {  
                string strDistrictName = ((XmlElement)Districtnode).GetAttribute("DistrictName");   //获取name属性值    
                pro.Add(strDistrictName);  
            }  
        }

        return pro;

       }
 
 }
}
