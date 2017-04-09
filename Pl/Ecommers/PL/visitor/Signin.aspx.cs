using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace Ecommers.PL.visitor

{
    public partial class Signin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

                //if(Request.QueryString["un"] != null && Request.QueryString["pass"] != null)
                if(Session["un"] != null && Session["pass"] != null)
                {
                    /*txtun.Text = Request.QueryString["un"];
                    txtpass.Text = Request.QueryString["pass"];*/
                    txtun.Text = Session["un"].ToString();
                    txtpass.Text = Session["pass"].ToString();
                    checkUser();
                }
                else
                    GetCookies();
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            checkUser();    
        }

        private void checkUser()
        {
            Ecommers.BL.Users user = new BL.Users();
            DataTable table = user.CheckUser(txtun.Text, txtpass.Text);
            try
            {
                if (table.Rows.Count > 0)
                {
                    bool Isblock = bool.Parse(table.Rows[0]["Isblocked"].ToString());
                    if (!Isblock)
                    {
                        Session["id"] = table.Rows[0]["UserID"].ToString();
                        Session["name"] = table.Rows[0]["Fullname"].ToString();
                        Session["type"] = table.Rows[0]["type"].ToString();
                        if (chkrem.Checked)
                        {
                            HttpCookie un = new HttpCookie("un");
                            un.Expires = DateTime.Now.AddYears(1);
                            un.Value = txtun.Text;
                            Response.Cookies.Add(un);
                            HttpCookie pass = new HttpCookie("pass");
                            pass.Expires = DateTime.Now.AddYears(1);
                            pass.Value = txtpass.Text;
                            Response.Cookies.Add(pass);
                        }
                        else
                        {
                            HttpCookie un = new HttpCookie("un");
                            un.Expires = DateTime.Now.AddYears(-1);
                            Response.Cookies.Add(un);
                            HttpCookie pass = new HttpCookie("pass");
                            pass.Expires = DateTime.Now.AddYears(-1);
                            Response.Cookies.Add(pass);
                        }

                        Session["un"] = null;
                        Session["pass"] = null;

                        if (int.Parse(table.Rows[0]["type"].ToString()) == 1)
                            Response.Redirect(@"~\admin\index.aspx");
                        else if (table.Rows[0]["type"].ToString() == "2")
                            Response.Redirect(@"~\suppliers\index.aspx");
                        else if (table.Rows[0]["type"].ToString() == "3")
                            Response.Redirect(@"~\customer\index.aspx");
                    }
                    else
                        lblMsg.Text = "this User Is Block Form Admin";
                }

                else
                {
                    lblMsg.Text = "NotFound";
                    txtun.Focus();
                }
            }
            catch (Exception ex)
            {
                lblMsg.Text = ex.Message;
            }
        }

        public void GetCookies()
        {
            if (Request.Cookies["un"] != null && Request.Cookies["pass"] != null)
            {
                if (!Request.Cookies["un"].ToString().Equals("") && !Request.Cookies["pass"].ToString().Equals(""))
                {
                    txtun.Text = Server.HtmlEncode(Request.Cookies["un"].Value).ToString();
                    txtpass.Attributes.Add("value", Server.HtmlEncode(Request.Cookies["pass"].Value));
                    chkrem.Checked = true;
                }
            }
       
        }

      

   

        
    }
}