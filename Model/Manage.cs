using System;
using System.Collections.Generic;
using System.Text;

namespace Model //ÐÞ¸ÄÃû×Ö¿Õ¼ä
{
	public class Manage
	{
		private int id;
		public int Id
		{
			get { return id; }
			set { id = value; }
		}
	
		private string name;
		public string Name
		{
			get { return name; }
			set { name = value; }
		}
	
		private string password;
		public string Password
		{
			get { return password; }
			set { password = value; }
		}
	
		private int dianYingYuan_id;
		public int DianYingYuan_id
		{
			get { return dianYingYuan_id; }
			set { dianYingYuan_id = value; }
		}
	
		private bool limit;
		public bool Limit
		{
			get { return limit; }
			set { limit = value; }
		}
	}
}