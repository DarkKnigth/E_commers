using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecommers.PL.customer
{
    public partial class Bscket : System.Web.UI.Page
    {
        public int i;
        public DataTable tables = new DataTable();
        Ecommers.BL.Order orderBl = new BL.Order();
        Ecommers.Entity.Order order = new Entity.Order();
      
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                tables = (DataTable)Session["table"];
                GridView1.DataSource = tables;
               GridView1.DataBind();
                GetTotle();
            }
        }

        private void GetTotle()
        {
            double sum=0;
            for (int i = 0; i < GridView1.Rows.Count; i++)
            {
                sum += Convert.ToDouble(GridView1.Rows[i].Cells[5].Text);
            }
            lblbtotle.Text = sum.ToString();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            tables = (DataTable)Session["table"];

            try
            {
                int index = e.RowIndex;
                DataRow dr = tables.Rows[index];
                dr.Delete();
            }
            catch (Exception ex)
            { }
            finally
            {
                GridView1.DataSource = tables;
                GridView1.DataBind();
            }

        }

        protected void OrderSave_Click(object sender, EventArgs e)
        {
            DataTable table = orderBl.getData2(int.Parse(Session["IDSupp"].ToString()));
            if (table.Rows.Count > 0)
            {
                double x = double.Parse(table.Rows[0]["OrderTotal"].ToString());
                x += double.Parse(lblbtotle.Text);
                orderBl.update(int.Parse(Session["IDSupp"].ToString()), x);
            }

            else{
                order.SupplierID = int.Parse(Session["IDSupp"].ToString());
                order.CustomerID = int.Parse(Session["id"].ToString());
                order.OrderTotal = double.Parse(lblbtotle.Text);
                orderBl.Add(order);
            }

            
         
            
        }

       
    }
    }
