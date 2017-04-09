using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Web.UI.WebControls;

namespace Ecommers.PL.customer
{
    public partial class Product : System.Web.UI.Page
    {
        Ecommers.Entity.Ditales Dit = new Entity.Ditales();
        Ecommers.BL.Ditales BLdit = new BL.Ditales();
        protected void Page_Load(object sender, EventArgs e)
        {

           
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataList1.DataBind();
        }

        protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (e.CommandName == "btn_Add")
            {
                Label LBLid = (Label)e.Item.FindControl("ProductIDLabel");
                TextBox LBLQrt = (TextBox)e.Item.FindControl("TextBox1");
                Label lblname = (Label)e.Item.FindControl("ProductNameLabel");
                Label lblPrice = (Label)e.Item.FindControl("ProductPriceLabel");

                Dit.CustomerID = int.Parse(Session["id"].ToString());
                Dit.SupplierID = int.Parse(Session["IDSupp"].ToString());
                Dit.ProductQunity = int.Parse(LBLQrt.Text);
                Dit.ProductPrice = decimal.Parse(lblPrice.Text);
                Dit.ProductID = int.Parse(LBLid.Text);
                BLdit.Add(Dit);
                //Response.Write(LBLid.Text + LBLQrt.Text);


                if (Session["table"] != null)
                {
                    DataTable mytable = (DataTable)Session["table"];
                    DataRow row = mytable.NewRow();
                    mytable.PrimaryKey = new DataColumn[] { mytable.Columns["Name"] };

                    DataRow DR = mytable.Rows.Find(lblname.Text);
                    if (DR == null)
                    {
                        row["IDPro"] = int.Parse(LBLid.Text);
                        row["Name"] = lblname.Text;
                        row["QRT"] = int.Parse(LBLQrt.Text);
                        row["Price"] = double.Parse(lblPrice.Text);
                        double sal = int.Parse(LBLQrt.Text) * double.Parse(lblPrice.Text);
                        row["Total"] = sal;


                        mytable.Rows.Add(row);
                    }

                    else
                    {
                        for (int i = 0; i < mytable.Rows.Count; i++)
                        {
                            if (lblname.Text == mytable.Rows[i]["Name"].ToString())
                                mytable.Rows[i]["QRT"] = int.Parse(LBLQrt.Text) + int.Parse(mytable.Rows[i]["QRT"].ToString());
                                row["Total"] = int.Parse(LBLQrt.Text) * int.Parse(lblPrice.Text);
                        }
                    }
                }




                else
                {

                    DataTable mytable = table();
                    DataRow row = mytable.NewRow();
                    row["IDPro"] = int.Parse(LBLid.Text);
                    row["Name"] = lblname.Text;
                    row["QRT"] = int.Parse(LBLQrt.Text);
                    row["Price"] = double.Parse(lblPrice.Text);
                    double sal= int.Parse(LBLQrt.Text) * double.Parse(lblPrice.Text);
                    row["Total"] = sal;


                    mytable.Rows.Add(row);

                    Session["table"] = mytable;
                }

            }
        }

        public DataTable table()
        {
            DataTable dt = new DataTable();
            dt.Columns.AddRange(
                new DataColumn[5] {
                    new DataColumn("IDPro", typeof(int)),
                          new DataColumn("Name",typeof(string)),
                            new DataColumn("QRT", typeof(int)),
                             new DataColumn("Price", typeof(double)),
                              new DataColumn("Total", typeof(double)),


            });

            return dt;
        }
    }
}