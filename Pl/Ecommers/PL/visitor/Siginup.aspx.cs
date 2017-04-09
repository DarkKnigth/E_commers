using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecommers.PL.visitor
{
    public partial class Siginup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSignup_Click(object sender, EventArgs e)
        {
            try
            {
                Ecommers.Entity.Users entity = new Ecommers.Entity.Users(txtFull.Text, txtuser.Text,txtpass.Text, txtPhone.Text, txtAddress.Text, false, txtEmial.Text, ddlGender.SelectedValue, int.Parse(ddlType.SelectedValue.ToString()), DateTime.Now);
                if (new Ecommers.BL.Users().Add(entity) > 0)
                {
                    //lblMess.Text = "Data Was Saved Successfully ..!";
                    //Response.Write("<script> alert('Data Was Saved Successfully'); window.location='SignIn.aspx'</script>");
                    //Response.Redirect("SignIn.aspx?un=" + System.Web.HttpUtility.UrlEncode(txtuser.Text) + "&pass=" + System.Web.HttpUtility.UrlEncode(txtpass.Text));
                    Session["un"] = txtuser.Text;
                    Session["pass"] = txtpass.Text;
                    Response.Redirect("SignIn.aspx");
                }
                else
                    lblMess.Text = "Data Was Not Saved Successfully..!";
                

            }
            catch (Exception ex)
            {
                lblMess.Text = ex.Message;
            }
        }
    }
}