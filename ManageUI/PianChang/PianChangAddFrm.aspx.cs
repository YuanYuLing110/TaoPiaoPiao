using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ManageUI.PianChang
{
    public partial class PianChangAddFrm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            for (int i = 0; i <= 23; i++)
            {
                lb_hour.Items.Add(i.ToString());
            }
            for (int i = 0; i <= 59; i++)
            {
                lb_mimutes.Items.Add(i.ToString());
            }
        }
    }
}