using System;
using System.Collections.Generic;
using System.Text;

namespace Model //ĞŞ¸ÄÃû×Ö¿Õ¼ä
{
	public class Movie
	{
		private int m_id;
		public int M_id
		{
			get { return m_id; }
			set { m_id = value; }
		}
	
		private string m_name;
		public string M_name
		{
			get { return m_name; }
			set { m_name = value; }
		}
	
		private byte[] m_image;
		public byte[] M_image
		{
			get { return m_image; }
			set { m_image = value; }
		}
	
		private string m_direct;
		public string M_direct
		{
			get { return m_direct; }
			set { m_direct = value; }
		}
	
		private string m_star;
		public string M_star
		{
			get { return m_star; }
			set { m_star = value; }
		}
	
		private string m_type;
		public string M_type
		{
			get { return m_type; }
			set { m_type = value; }
		}
	
		private string m_state;
		public string M_state
		{
			get { return m_state; }
			set { m_state = value; }
		}
	
		private string m_voice;
		public string M_voice
		{
			get { return m_voice; }
			set { m_voice = value; }
		}
	
		private string m_time;
		public string M_time
		{
			get { return m_time; }
			set { m_time = value; }
		}
	
		private double m_grade;
		public double M_grade
		{
			get { return m_grade; }
			set { m_grade = value; }
		}
	
		private string m_detail;
		public string M_detail
		{
			get { return m_detail; }
			set { m_detail = value; }
		}
	
		private long m_count;
		public long M_count
		{
			get { return m_count; }
			set { m_count = value; }
		}

        private int m_minute;
        public int M_minute
        {
            get { return m_minute; }
            set { m_minute = value; }
        }
	}
}