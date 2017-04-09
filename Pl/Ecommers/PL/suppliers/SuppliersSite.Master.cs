using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecommers.PL.suppliers
{
    public partial class SuppliersSite : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["id"] != null && Session["type"].ToString() == "2")
            {
             lblSupp.Text = "Welcome " + Session["name"];
            }
            else
                Response.Redirect(@"~\visitor\Signin.aspx");


            lblTime.Text = DateTime.Now.ToString();
        }

        protected void bntLogout3_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect(@"~\visitor\Signin.aspx");
        }
    }
}