using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
public partial class ReciteWord_image_Default : System.Web.UI.Page
{
   
    protected void Page_Load(object sender, EventArgs e)
    {
     Response.Expires=0;
     Response.Buffer=true;
     Response.Clear();
     //int cd_id = Convert.ToInt32(Request.Params["cd_id"]);
     int id = Convert.ToInt32(Request.QueryString["id"]);
        //Request.QueryString["pname"].ToString()
     //int cd_id = 2;
       GetPic(id);
    }
public void GetPic(int id)
{
    string str = ConfigurationManager.ConnectionStrings["sql2005"].ToString();
    SqlConnection conn = new SqlConnection(str);
    conn.Open();
    string sql = "select m_image from Movie WHERE m_id=@id";
    SqlCommand cmd = new SqlCommand(sql, conn);
    cmd.Parameters.AddWithValue("@id", id);
    SqlDataReader dr1 = cmd.ExecuteReader();
    dr1.Read();
    if (dr1.HasRows)
    {
        byte[] photo1 = null;
        if (dr1[0] != null)
            photo1 = (byte[])dr1[0];
        Response.ContentType = "image/jpeg";
        Response.BinaryWrite(photo1);
        Response.End();
    }
    dr1.Close();
    conn.Close();
}
}