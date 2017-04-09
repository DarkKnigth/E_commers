using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecommers.PL.suppliers
{
    public partial class Category : System.Web.UI.Page
    {
        Ecommers.BL.Categorycs BL = new Ecommers.BL.Categorycs();
        Ecommers.Entity.Category entity = new Ecommers.Entity.Category();


        protected void Page_Load(object sender, EventArgs e)
        {
            GetID();
        }

        private void GetID()
        {
            string id = BL.MaxValue(int.Parse(Session["id"].ToString())).ToString();
            TextBox1.Text = id;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                entity.CategoryID = int.Parse(TextBox1.Text);
                entity.SupplierID = int.Parse(Session["id"].ToString());
                entity.CategoryName = TextBox2.Text;

                if (BL.Add(entity) > 0)
                {
                    lblMsg.Text = "Data Was Saved Successfully ...!";
                    TextBox2.Text = "";
                    TextBox2.Focus();
                }
                else
                    lblMsg.Text = "Data Was not Saved Successfully ...!";
            }
            catch(Exception ex)
            {
                lblMsg.Text = ex.Message;
            }
            finally
            {
                GetID();
            }

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                entity.CategoryID = int.Parse(TextBox3.Text);
                entity.SupplierID = int.Parse(Session["id"].ToString());
                entity.CategoryName = TextBox4.Text;

                if (BL.Edit(entity) > 0)
                {
                    lblMsg0.Text = "Data Was Updated Successfully ...!";
                    TextBox4.Text = "";
                    Button3.Enabled = false;
                    Button5.Enabled = false;
                    TextBox4.Focus();
                }
                else
                    lblMsg0.Text = "Data Was not Updated Successfully ...!";
            }
            catch (Exception ex)
            {
                lblMsg0.Text = ex.Message;
            }
            finally
            {
                fillGrid();
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 1;
            fillGrid();
        }

        private void fillGrid()
        {
            GridView1.DataSource = BL.getData(int.Parse(Session["id"].ToString()));
            GridView1.DataBind();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 0;
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBox3.Text = GridView1.SelectedRow.Cells[1].Text;
            TextBox4.Text = GridView1.SelectedRow.Cells[2].Text;
            Button3.Enabled = true;
            Button5.Enabled = true;
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            try
            {
                entity.CategoryID = int.Parse(TextBox3.Text);
                entity.SupplierID = int.Parse(Session["id"].ToString());
                entity.CategoryName = TextBox4.Text;

                if (BL.Remove(entity) > 0)
                {
                    lblMsg0.Text = "Data Was Deleted Successfully ...!";
                    TextBox4.Text = "";
                    Button3.Enabled = false;
                    Button5.Enabled = false;
                    TextBox4.Focus();
                }
                else
                    lblMsg0.Text = "Data Was not Deleted Successfully ...!";
            }
            catch (Exception ex)
            {
                lblMsg0.Text = ex.Message;
            }
            finally
            {
                fillGrid();
            }
        }
    }
}