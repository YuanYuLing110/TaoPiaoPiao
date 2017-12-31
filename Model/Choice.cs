using System;
using System.Collections.Generic;
using System.Text;

namespace Model //ĞŞ¸ÄÃû×Ö¿Õ¼ä
{
	public class Choice
	{
		private int c_id;
		public int C_id
		{
			get { return c_id; }
			set { c_id = value; }
		}
	
		private int p_id;
		public int P_id
		{
			get { return p_id; }
			set { p_id = value; }
		}
	
		private int u_id;
		public int U_id
		{
			get { return u_id; }
			set { u_id = value; }
		}
	
		private string c_orderNum;
		public string C_orderNum
		{
			get { return c_orderNum; }
			set { c_orderNum = value; }
		}
	
		private string c_name;
		public string C_name
		{
			get { return c_name; }
			set { c_name = value; }
		}
	
		private DateTime c_time;
		public DateTime C_time
		{
			get { return c_time; }
			set { c_time = value; }
		}
	
		private double c_grade;
		public double C_grade
		{
			get { return c_grade; }
			set { c_grade = value; }
		}
	}
}