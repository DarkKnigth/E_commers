using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Ecommers.DL
{
    public class Ditales
    {
        public int Add(Ecommers.Entity.Ditales Ditales)
        {
            int result = 0;
            string sql = "insert into Ditales (ProductID,ProductPrice,ProductQuantity,SupplierID,CustomerID) values (@ProductID,@ProductPrice,@ProductQunity,@SupplierID,@CustomerID)";
            SqlCommand cmd = new SqlCommand(sql,DBC.conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@ProductID",Ditales.ProductID);
            cmd.Parameters.AddWithValue("@ProductPrice", Ditales.ProductPrice);
            cmd.Parameters.AddWithValue("@ProductQunity", Ditales.ProductQunity);
            cmd.Parameters.AddWithValue("@SupplierID", Ditales.SupplierID);
            cmd.Parameters.AddWithValue("@CustomerID", Ditales.CustomerID);
            DBC.conn.Open();
            result = cmd.ExecuteNonQuery();
            DBC.conn.Close();
            return result;

        }

        public int Edit(Ecommers.Entity.Ditales Ditales)
        {
            int result = 0;
            string sql = "update Ditales set  ProductQunity=@ProductQunity,ProductPrice=@ProductPrice where OrderID=@OrderID  ";
            SqlCommand cmd = new SqlCommand(sql, DBC.conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@OrderID", Ditales.OrderID);
            DBC.conn.Open();
            result = cmd.ExecuteNonQuery();
            DBC.conn.Close();
            return result;

        }

        public int Remove(Ecommers.Entity.Ditales Ditales)
        {
            int result = 0;
            string sql = "delete * form  Ditales where  OrderID=@OrderID";
            SqlCommand cmd = new SqlCommand(sql, DBC.conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@OrderID", Ditales.OrderID);
            DBC.conn.Open();
            result = cmd.ExecuteNonQuery();
            DBC.conn.Close();
            return result;

        }

        public DataTable getData()
        {
            DataTable table = new DataTable();
            string sql = "select * from  Ditales ";
            SqlCommand cmd = new SqlCommand(sql, DBC.conn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter adpater = new SqlDataAdapter();
            adpater.SelectCommand = cmd;
            adpater.Fill(table);
            return table;

        }

        public DataTable getData(int orderID)
        {
            DataTable table = new DataTable();
            string sql = "select * from  Ditales where OrderID= @OrderID ";
            SqlCommand cmd = new SqlCommand(sql, DBC.conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@OrderID", orderID);
            SqlDataAdapter adpater = new SqlDataAdapter();
            adpater.SelectCommand = cmd;
            adpater.Fill(table);
            return table;

        }
        public int MaxValue(int IDCus)
        {
            int max = 1;
            try
            {
                string sql = "select max(OrderID+ 1) from Order where CustomerID=@CustomerID ";
                SqlCommand cmd = new SqlCommand(sql, DBC.conn);
                cmd.Parameters.AddWithValue("@CustomerID", IDCus);
                DBC.conn.Open();
                max = int.Parse(cmd.ExecuteScalar().ToString());
                DBC.conn.Close();
            }
            catch (Exception ex)
            {
                max = 1;
            }
            finally
            {
                DBC.conn.Close();
            }

            return max;
        }


        public DataTable getData2(int ID,int Cus)
        {
            DataTable table = new DataTable();
            string sql = "SELECT  Product.ProductName, Users.Fullname ,Ditales.ProductPrice, Ditales.ProductQuantity, Ditales.ProductTotal, Users.UserID FROM Ditales INNER JOIN  Product ON Ditales.ProductID = Product.ProductID CROSS JOIN  Users WHERE (Users.UserID = @SupplierID)";
            SqlCommand cmd = new SqlCommand(sql, DBC.conn);
            cmd.Parameters.AddWithValue("@SupplierID", ID);
            cmd.Parameters.AddWithValue("@CustomerID", Cus);
            SqlDataAdapter adpater = new SqlDataAdapter();
            adpater.SelectCommand = cmd;
            adpater.Fill(table);
            return table;
        }




    }
}
