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
	
		private int u_id;
		public int U_id
		{
			get { return u_id; }
			set { u_id = value; }
		}
	
		private int s_id;
		public int S_id
		{
			get { return s_id; }
			set { s_id = value; }
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