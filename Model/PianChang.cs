using System;
using System.Collections.Generic;
using System.Text;

namespace Model //ÐÞ¸ÄÃû×Ö¿Õ¼ä
{
	public class PianChang
	{
		private int p_id;
		public int P_id
		{
			get { return p_id; }
			set { p_id = value; }
		}
	
		private int t_id;
		public int T_id
		{
			get { return t_id; }
			set { t_id = value; }
		}
	
		private int m_id;
		public int M_id
		{
			get { return m_id; }
			set { m_id = value; }
		}
	
		private DateTime p_time;
		public DateTime P_time
		{
			get { return p_time; }
			set { p_time = value; }
		}
	
		private double p_price;
		public double P_price
		{
			get { return p_price; }
			set { p_price = value; }
		}
	}
}