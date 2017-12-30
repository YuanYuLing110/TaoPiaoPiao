using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
  public  class MoviePianChang
    {
        private int p_id;
        public int P_id
        {
            get { return p_id; }
            set { p_id = value; }
        }

        private string t_name;
        public string T_name
        {
            get { return t_name; }
            set { t_name = value; }
        }

        private string m_name;
        public string M_name
        {
            get { return m_name; }
            set { m_name = value; }
        }
        private int m_minute;
        public int M_minute
        {
            get { return m_minute; }
            set { m_minute = value; }
        }
        private string m_voice;
        public string M_voice
        {
            get { return m_voice; }
            set { m_voice = value; }
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
