using System;
using System.Collections.Generic;
using System.Text;

namespace Model //ÐÞ¸ÄÃû×Ö¿Õ¼ä
{
	public class Site
	{
		private int s_id;
		public int S_id
		{
			get { return s_id; }
			set { s_id = value; }
		}
	
		private int p_id;
		public int P_id
		{
			get { return p_id; }
			set { p_id = value; }
		}
	
		private string s_name;
		public string S_name
		{
			get { return s_name; }
			set { s_name = value; }
		}
	
		private bool s_choice;
		public bool S_choice
		{
			get { return s_choice; }
			set { s_choice = value; }
		}
	}
}