using System;
using System.Collections.Generic;
using System.Text;

namespace Model //ÐÞ¸ÄÃû×Ö¿Õ¼ä
{
	public class Users
	{
		private int u_ID;
		public int U_ID
		{
			get { return u_ID; }
			set { u_ID = value; }
		}
	
		private string u_NAME;
		public string U_NAME
		{
			get { return u_NAME; }
			set { u_NAME = value; }
		}
	
		private string u_PSSWORD;
		public string U_PSSWORD
		{
			get { return u_PSSWORD; }
			set { u_PSSWORD = value; }
		}
	
		private string u_EMAIL;
		public string U_EMAIL
		{
			get { return u_EMAIL; }
			set { u_EMAIL = value; }
		}
	
		private DateTime u_REGISTERTIME;
		public DateTime U_REGISTERTIME
		{
			get { return u_REGISTERTIME; }
			set { u_REGISTERTIME = value; }
		}
	}
}