using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecommers.PL.customer
{
    public partial class index : System.Web.UI.Page
    {
        Ecommers.BL.Users supp = new BL.Users();
        Ecommers.BL.Categorycs cat = new BL.Categorycs();

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
                FillDropBox();
        }

        private void FillDropBox()
        {

            DropDownList1.DataSource = supp.supp();
            DropDownList1.DataValueField = "UserID";
            DropDownList1.DataTextField = "Fullname";
            DropDownList1.DataBind();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["IDSupp"] = DropDownList1.SelectedValue.ToString();
            Session["IDCat"] = DropDownList2.SelectedValue.ToString();
            Response.Redirect("~/customer/Product.aspx");
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList2.DataSource = cat.getData(int.Parse(DropDownList1.SelectedValue.ToString()));
            DropDownList2.DataValueField = "ID";
            DropDownList2.DataTextField = "Name";
            DropDownList2.DataBind();
        }
    }
}