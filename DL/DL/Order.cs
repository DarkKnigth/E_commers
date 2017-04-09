using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Ecommers.DL
{
     public class Order
    {
        public int Add(Ecommers.Entity.Order Order)
        {
            int result = 0;
            string sql = "insert into [Order] ( OrderTotal ,SupplierID,CustomerID) values ( @OrderTotal ,@SupplierID,@CustomerID);";
            SqlCommand cmd = new SqlCommand(sql, DBC.conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@SupplierID", Order.SupplierID);
            cmd.Parameters.AddWithValue("@CustomerID", Order.CustomerID);
            cmd.Parameters.AddWithValue("@OrderTotal", Order.OrderTotal);
            DBC.conn.Open();
            result = cmd.ExecuteNonQuery();
            DBC.conn.Close();
            return result;
        
        }

        public int Edit(Ecommers.Entity.Order Order)
        {
            int result = 0;
            string sql = "update Order set SupplierID=@SupplierID,CustomerID=@CustomerID where OrderID=@OrderID ";
            SqlCommand cmd = new SqlCommand(sql, DBC.conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@OrderID", Order.OrderID);
            cmd.Parameters.AddWithValue("@SupplierID", Order.SupplierID);
            cmd.Parameters.AddWithValue("@CustomerID", Order.CustomerID);
            DBC.conn.Open();
            result = cmd.ExecuteNonQuery();
            DBC.conn.Close();
            return result;

        }

        public int Remove(Ecommers.Entity.Order Order)
        {
            int result = 0;
            string sql = "delete from Order  where  OrderID=@OrderID ";
            SqlCommand cmd = new SqlCommand(sql, DBC.conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@OrderID", Order.OrderID);
            DBC.conn.Open();
            result = cmd.ExecuteNonQuery();
            DBC.conn.Close();
            return result;

        }

        public DataTable getData()
        {
            DataTable table = new DataTable();
            string sql = "select * from Order";
            SqlCommand cmd = new SqlCommand(sql, DBC.conn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter adpter = new SqlDataAdapter();
            adpter.SelectCommand = cmd;
            adpter.Fill(table);
            return table;
        }

        public DataTable getData(int orderId)
        {
            DataTable table = new DataTable();
            string sql = "select * from Order where OrderID=@OrderID";
            SqlCommand cmd = new SqlCommand(sql, DBC.conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@OrderID", orderId);
            SqlDataAdapter adpter = new SqlDataAdapter();
            adpter.SelectCommand = cmd;
            adpter.Fill(table);
            return table;
        }


        public DataTable getData2(int IDSupp)
        {
            DataTable table = new DataTable();
            string sql = "select * from [Order] where SupplierID=@SupplierID";
            SqlCommand cmd = new SqlCommand(sql, DBC.conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@SupplierID", IDSupp);
            SqlDataAdapter adpter = new SqlDataAdapter();
            adpter.SelectCommand = cmd;
            adpter.Fill(table);
            return table;
        }

        public int updatetotle(int ID,double totle)
        {
            int result = 0;
            string sql = "update [Order] set OrderTotal=@OrderTotal where SupplierID=@SupplierID";
            SqlCommand cmd = new SqlCommand(sql, DBC.conn);
            cmd.Parameters.AddWithValue("@SupplierID", ID);
            cmd.Parameters.AddWithValue("@OrderTotal", totle);
            DBC.conn.Open();
            result = cmd.ExecuteNonQuery();
            DBC.conn.Close();
            return result;

        }










    }
}
