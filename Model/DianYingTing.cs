using System;
using System.Collections.Generic;
using System.Text;

namespace Model //ĞŞ¸ÄÃû×Ö¿Õ¼ä
{
	public class DianYingTing
	{
		private int t_id;
		public int T_id
		{
			get { return t_id; }
			set { t_id = value; }
		}
	
		private int y_id;
		public int Y_id
		{
			get { return y_id; }
			set { y_id = value; }
		}
	
		private string t_name;
		public string T_name
		{
			get { return t_name; }
			set { t_name = value; }
		}
	
		private int t_count;
		public int T_count
		{
			get { return t_count; }
			set { t_count = value; }
		}
	
		private int t_row;
		public int T_row
		{
			get { return t_row; }
			set { t_row = value; }
		}
	
		private int t_line;
		public int T_line
		{
			get { return t_line; }
			set { t_line = value; }
		}
	}
}