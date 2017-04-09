using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Ecommers.DL
{
    public class Product : Ecommers.Entity.Aggration
    {
        public int Add(Ecommers.Entity.Product product)
        {
            int result = 0;
            string sql = "insert into Product (ProductID,ProductName,ProductPrice,ProductQuantity,ProductPicture,IsAvilable,CategoryID,SupplerID) values (@ProductID,@ProductName,@ProductPrice,@ProductQuantity,@ProductPicture,@IsAvilable,@CategoryID,@SupplerID)";
           
            SqlCommand cmd = new SqlCommand(sql, DBC.conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@ProductID", product.ProductID);
            cmd.Parameters.AddWithValue("@ProductName", product.ProductName);
            cmd.Parameters.AddWithValue("@ProductPrice", product.ProductPrice);
            cmd.Parameters.AddWithValue("@ProductQuantity", product.ProductQuantity);
            cmd.Parameters.AddWithValue("@ProductPicture", product.ProductPicture);
            cmd.Parameters.AddWithValue("@IsAvilable", product.IsAvilable);
            cmd.Parameters.AddWithValue("@CategoryID", product.CategoryID);
            cmd.Parameters.AddWithValue("@SupplerID", product.SupplerID);
            DBC.conn.Open();
            result = cmd.ExecuteNonQuery();
            DBC.conn.Close();
            return result;

        }

        public int Edit(Ecommers.Entity.Product product)
        {
            int result = 0; 
            string sql = "update Product set ProductName=@ProductName,ProductPrice=@ProductPrice,ProductQuantity=@ProductQuantity,CategoryID=@CategoryID where ProductID=@ProductID and SupplerID=@SupplerID ";
            SqlCommand cmd = new SqlCommand(sql, DBC.conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@ProductID", product.ProductID);
            cmd.Parameters.AddWithValue("@ProductName", product.ProductName);
            cmd.Parameters.AddWithValue("@ProductPrice", product.ProductPrice);
            cmd.Parameters.AddWithValue("@ProductQuantity", product.ProductQuantity);
           // cmd.Parameters.AddWithValue("@ProductPicture", product.ProductPicture);
            cmd.Parameters.AddWithValue("@CategoryID", product.CategoryID);
            cmd.Parameters.AddWithValue("@SupplerID", product.SupplerID);
            DBC.conn.Open();
            result = cmd.ExecuteNonQuery();
            DBC.conn.Close();
            return result;

        }

        public int Rmove(Ecommers.Entity.Product product)
        {
            int result = 0;
            string sql = "delete from Product where ProductID=@ProductID and SupplerID=@SupplerID";
            SqlCommand cmd = new SqlCommand(sql, DBC.conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@ProductID", product.ProductID);
            cmd.Parameters.AddWithValue("@SupplerID", product.SupplerID);

            DBC.conn.Open();
            result = cmd.ExecuteNonQuery();
            DBC.conn.Close();
            return result;

        }

        public DataTable getData()
        {
            DataTable table = new DataTable();
            string sql = "select * from Porduct";
           
            SqlCommand cmd = new SqlCommand(sql, DBC.conn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            return table;
        
        }


        public DataTable getData(string name)
        {
            DataTable table = new DataTable();
            string sql = "select * from Porduct where  ProductName = @ProductName";
            SqlCommand cmd = new SqlCommand(sql, DBC.conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@ProductName", name);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            return table;

        }


        


        public DataTable getData(int IDSupp)
        {
            DataTable table = new DataTable();
            string sql = "select * from Product where SupplerID=@SupplerID";
            SqlCommand cmd = new SqlCommand(sql, DBC.conn);
            cmd.Parameters.AddWithValue("@SupplerID", IDSupp);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            return table;
        }


        public int MaxValue(int IDSupp)
        {
            int max = 1;
            try
            {
                string sql = "select max(ProductID + 1) from Product where SupplerID=@SupplerID";
                SqlCommand cmd = new SqlCommand(sql, DBC.conn);
                cmd.Parameters.AddWithValue("@SupplerID", IDSupp);
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
        public int MaxVulae(string Query = "")
        {
            int result = 0;
            string sql = "select max(ProductID) from Product ";
            if (Query.Length > 0)
            {
                sql =  sql + " where " + Query;
            }
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;

            DBC.conn.Open();
            result = int.Parse(cmd.ExecuteScalar().ToString());
            DBC.conn.Close();
            return result;


   
        }

        public int MinVulae(string Query = "")
        {

            int result = 0;
            string sql = "select min(ProductID) from Product ";
            if (Query.Length > 0)
            {
                sql = sql + " where " + Query;
            }
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;

            DBC.conn.Open();
            result = int.Parse(cmd.ExecuteScalar().ToString());
            DBC.conn.Close();
            return result;

        }

        public int SumVulae(string Query = "")
        {
            int result = 0;
            string sql = "select sum(ProductID) from Product ";
            if (Query.Length > 0)
            {
                sql = sql + " where " + Query;
            }
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;

            DBC.conn.Open();
            result = int.Parse(cmd.ExecuteScalar().ToString());
            DBC.conn.Close();
            return result;

        }

        public int AVGVulae(string Query = "")
        {
            int result = 0;
            string sql = "select avg(ProductID) from Product ";
            if (Query.Length > 0)
            {
                sql = sql + " where " + Query;
            }
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;

            DBC.conn.Open();
            result = int.Parse(cmd.ExecuteScalar().ToString());
            DBC.conn.Close();
            return result;

        }

        public int CountVulae(string Query = "")
        {
            int result = 0;
            string sql = "select count(ProductID) from Product ";
            if (Query.Length > 0)
            {
                sql = sql + " where " + Query;
            }
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;

            DBC.conn.Open();
            result = int.Parse(cmd.ExecuteScalar().ToString());
            DBC.conn.Close();
            return result;

        }
    }
}
