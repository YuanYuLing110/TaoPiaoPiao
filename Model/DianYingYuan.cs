using System;
using System.Collections.Generic;
using System.Text;

namespace Model //ÐÞ¸ÄÃû×Ö¿Õ¼ä
{
	public class DianYingYuan
	{
		private int y_id;
		public int Y_id
		{
			get { return y_id; }
			set { y_id = value; }
		}
	
		private string y_Name;
		public string Y_Name
		{
			get { return y_Name; }
			set { y_Name = value; }
		}
	
		private string y_address;
		public string Y_address
		{
			get { return y_address; }
			set { y_address = value; }
		}
	
		private string y_phone;
		public string Y_phone
		{
			get { return y_phone; }
			set { y_phone = value; }
		}

        private string y_provice;
        public string Y_provice
        {
            get { return y_provice; }
            set { y_provice = value; }
        }
	
		private string y_city;
		public string Y_city
		{
			get { return y_city; }
			set { y_city = value; }
		}
	
		private string y_area;
		public string Y_area
		{
			get { return y_area; }
			set { y_area = value; }
		}
	
		private double y_grade;
		public double Y_grade
		{
			get { return y_grade; }
			set { y_grade = value; }
		}
	}
}