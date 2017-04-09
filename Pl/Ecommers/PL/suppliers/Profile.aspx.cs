using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecommers.PL.suppliers
{
    public partial class Profile : System.Web.UI.Page
    {
        Ecommers.Entity.Users users = new Entity.Users();
        Ecommers.BL.Users Blusers = new BL.Users();
        protected void Page_Load(object sender, EventArgs e)
        {
      

        }

        protected void Save_Click(object sender, EventArgs e)
        {

            users.Fullname = txtfull.Text;
            users.Username = txtuser.Text;
            users.Password = txtpass.Text;
            users.Phone = txtphone.Text;
            users.UserID = int.Parse(Session["id"].ToString());
            users.Address = txtaddres.Text;
            users.Email = txtEmail.Text;

            if (Blusers.Edit2(users) > 0)
            {
                Label1.Text = "Data Was Saved";
            }
            else
                Label1.Text = "Data Was not Saved";


        }
    }
}