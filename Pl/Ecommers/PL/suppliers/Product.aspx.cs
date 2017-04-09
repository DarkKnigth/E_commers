using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace Ecommers.PL.suppliers
{
    public partial class Product : System.Web.UI.Page
    {
        
        Ecommers.BL.Product BLProduct = new BL.Product();
        Ecommers.BL.Categorycs BLCategorycs = new BL.Categorycs();
        Ecommers.Entity.Product Entity = new Ecommers.Entity.Product();
        protected void Page_Load(object sender, EventArgs e)
        {
            FillDrop();
            GetID();
        }

        private void GetID()
        {
            string id = BLProduct.MaxValue(int.Parse(Session["id"].ToString())).ToString();
            txtid.Text = id;
        }




        private void FillDrop()
        {
            DropCatName.DataSource = BLCategorycs.getData(int.Parse(Session["id"].ToString()));
            DropCatName.DataValueField = "ID";
            DropCatName.DataTextField = "Name";
            DropCatName.DataBind();


            DropCatName0.DataSource = BLCategorycs.getData(int.Parse(Session["id"].ToString()));
            DropCatName0.DataValueField = "ID";
            DropCatName0.DataTextField = "Name";
            DropCatName0.DataBind();
        }

        protected void Save_Click(object sender, EventArgs e)
        {
            try
            {
                string path_db="";
                string path_server = Request.PhysicalApplicationPath + "ProductImages/";

                if (!Directory.Exists(path_server))
                    Directory.CreateDirectory(path_server);

                string [] arr = {".png",".gif",".jpg",".bmp"};


                if(fU.HasFile)
                {
                    path_db = "~/ProductImages/" + fU.FileName;

                    string type = Path.GetExtension(fU.FileName);

                    if (!arr.Contains(type))
                    {
                        lblMessage.Text = "File not allow Extension";
                        return;
                    }

                    fU.SaveAs(path_server + fU.FileName);

                }
                else
                    path_db= "~/ProductImages/nologo.png";


                Entity = new Ecommers.Entity.Product(int.Parse(txtid.Text), txtname.Text, decimal.Parse(txtprice.Text),  int.Parse(txtQuity.Text),path_db, CheckBox1.Checked , int.Parse(DropCatName.SelectedItem.Value), int.Parse(Session["id"].ToString()));
                if (BLProduct.Add(Entity) > 0)
                {
                    lblMessage.Text = "Data Was Saved....";
                }
                else
                    lblMessage.Text = "Data Wasnot Saved ....";
            }
            catch (Exception ex) { }
            finally
            {
                FillGrid();
                GetID();
            }
        }

        protected void Show_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 1;
            FillGrid();
            btnEdit.Enabled = false;
            btnRemove.Enabled = false;
            
        }

        private void FillGrid()
        {
            GridView2.DataSource = BLProduct.getData(int.Parse(Session["id"].ToString()));
            GridView2.DataBind();

       
            DataList1.DataBind();
        }

       

        protected void Button4_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 0;
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBox3.Text = GridView2.SelectedRow.Cells[1].Text;
            TextBox4.Text = GridView2.SelectedRow.Cells[2].Text;
            TextBox5.Text = GridView2.SelectedRow.Cells[3].Text;
            TextBox6.Text = GridView2.SelectedRow.Cells[4].Text;
            btnEdit.Enabled = true;
            btnRemove.Enabled = true;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                Entity.ProductID = int.Parse(TextBox3.Text);
                Entity.ProductName = TextBox4.Text;
                Entity.ProductPrice = decimal.Parse(TextBox5.Text);
                Entity.ProductQuantity = int.Parse(TextBox6.Text);
                Entity.IsAvilable = bool.Parse(DropDownList1.SelectedValue);
                //Entity.CategoryID = int.Parse(TextBox9.Text);
                //TextBox10.Text = int.Parse(Session["id"].ToString()).ToString();
                Entity.SupplerID= int.Parse(Session["id"].ToString());



                if (BLProduct.Edit(Entity) > 0)
                {
                    lblMsg1.Text = "update Dan";
                    TextBox3.Text = "";
                    TextBox4.Text = "";
                    TextBox5.Text = "";
                    TextBox6.Text = "";
                    //TextBox9.Text = "";
                    //TextBox10.Text = "";
                    //TextBox7.Text = "";
                    TextBox3.Focus();
                }
                else
                {
                    lblMsg1.Text = "update not Dan";
                }

            }
            catch (Exception ex) { }
            finally {
                FillGrid();
                GetID();
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {

            try
            {
                Entity.ProductID = int.Parse(TextBox3.Text);
                Entity.ProductName = TextBox4.Text;
                Entity.ProductPrice = decimal.Parse(TextBox5.Text);
                Entity.ProductQuantity = int.Parse(TextBox6.Text);
                Entity.IsAvilable = bool.Parse(DropDownList1.SelectedValue);
                //Entity.CategoryID = int.Parse(TextBox9.Text);
                //TextBox10.Text = int.Parse(Session["id"].ToString()).ToString();
                Entity.SupplerID = int.Parse(Session["id"].ToString());



                if (BLProduct.Remove(Entity) > 0)
                {
                    lblMsg1.Text = "Remove Dan";
                    TextBox3.Text = "";
                    TextBox4.Text = "";
                    TextBox5.Text = "";
                    TextBox6.Text = "";
                    //TextBox9.Text = "";
                    //TextBox10.Text = "";
                    //TextBox7.Text = "";
                    TextBox3.Focus();
                }
                else
                {
                    lblMsg1.Text = "Remove not Dan";
                }

            }
            catch (Exception ex) { }
            finally
            {
                FillGrid();
                GetID();
            }

        }
    }
}