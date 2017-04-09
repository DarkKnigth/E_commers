using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecommers.PL.customer
{
    public partial class CustomerSite : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["id"] != null && Session["type"].ToString() == "3")
            {
                lblcustomer.Text ="Welcome " + Session["name"].ToString();
            }
            else
                Response.Redirect(@"~\visitor\Signin.aspx");

            lbltime.Text = DateTime.Now.ToString();
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect(@"~\visitor\Signin.aspx");
        }
    }
}