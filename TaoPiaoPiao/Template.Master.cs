using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TaoPiaoPiao.IpAddressSearchWebService;

namespace TaoPiaoPiao
{
    public partial class Template : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        public void getCity() {

            IpAddressSearchWebService.IpAddressSearchWebService ipCity = new IpAddressSearchWebService.IpAddressSearchWebService();
            string ip = "223.86.26.9";
            String[] citys = ipCity.getCountryCityByIp(ip);
            String[] str = citys[1].Split(' ');

        }
    }
}