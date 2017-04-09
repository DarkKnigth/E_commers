using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecommers.PL.customer
{
    public partial class Order : System.Web.UI.Page
    {
        Ecommers.BL.Ditales BLDIT = new BL.Ditales();
        int SuppID;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

     

        private void ShowGrid()
        {
        

            GridView2.DataSource = BLDIT.getData2(SuppID, int.Parse(Session["id"].ToString()));
            GridView2.DataBind();
        }

     

        protected void GridView3_SelectedIndexChanged(object sender, EventArgs e)
        {
            SuppID = int.Parse(GridView3.SelectedRow.Cells[4].Text);

            ShowGrid();

        }
    }
}