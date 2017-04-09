using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Ecommers.DL
{
    public class Categorycs
    {

        public int Add(Ecommers.Entity.Category cat)
        {
            int result = 0;
            string sql = "insert into Category (CategoryID , CategoryName , SupplierID ) values (@CategoryID , @CategoryName , @SupplierID )"; 
            SqlCommand cmd = new SqlCommand(sql, DBC.conn);
            cmd.Parameters.AddWithValue("@CategoryID", cat.CategoryID);
            cmd.Parameters.AddWithValue("@CategoryName", cat.CategoryName);
            cmd.Parameters.AddWithValue("@SupplierID", cat.SupplierID);
            DBC.conn.Open();
            result = cmd.ExecuteNonQuery();
            DBC.conn.Close();
            return result;
        
        }

        public int Edit(Ecommers.Entity.Category cat)
        {
            int result = 0;
            string sql = "update Category set CategoryName=@CategoryName  where CategoryID=@CategoryID and SupplierID=@SupplierID";
            SqlCommand cmd = new SqlCommand(sql, DBC.conn);
            cmd.Parameters.AddWithValue("@CategoryID", cat.CategoryID);
            cmd.Parameters.AddWithValue("@CategoryName", cat.CategoryName);
            cmd.Parameters.AddWithValue("@SupplierID", cat.SupplierID);
            DBC.conn.Open();
            result = cmd.ExecuteNonQuery();
            DBC.conn.Close();
            return result;

        }

        public int Rmove(Ecommers.Entity.Category cat)
        {
            int result = 0;
            string sql = "delete from  Category where  CategoryID=@CategoryID and SupplierID=@SupplierID";
            SqlCommand cmd = new SqlCommand(sql, DBC.conn);
            cmd.Parameters.AddWithValue("@CategoryID", cat.CategoryID);
            cmd.Parameters.AddWithValue("@SupplierID", cat.SupplierID);
            DBC.conn.Open();
            result = cmd.ExecuteNonQuery();
            DBC.conn.Close();
            return result;

        }

        /*public DataTable getData(int IDSupp)
        {
            DataTable table = new DataTable();
            string sql = "select * from Category where SupplierID=@SupplierID";
            SqlCommand cmd = new SqlCommand(sql, DBC.conn);
            cmd.Parameters.AddWithValue("@SupplierID", IDSupp);

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            return table;
        }*/

        public DataTable getData(int IDSupp)
        {
            DataTable table = new DataTable();
            string sql = "select CategoryId as ID,CategoryName as Name from Category where SupplierID=@SupplierID";
            SqlCommand cmd = new SqlCommand(sql, DBC.conn);
            cmd.Parameters.AddWithValue("@SupplierID", IDSupp);

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            return table;
        }

        public DataTable getData(int IDcat,int IDSupp)
        {
            DataTable table = new DataTable();
            string sql = "select * from Category where CategoryID=@CategoryID and SupplierID=@SupplierID";
            SqlCommand cmd = new SqlCommand(sql, DBC.conn);
            cmd.Parameters.AddWithValue("@CategoryID", IDcat);
            cmd.Parameters.AddWithValue("@SupplierID", IDSupp);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            return table;
        }

        public DataTable getData(string name, int IDSupp)
        {
            DataTable table = new DataTable();
            string sql = "select * from Category where CategoryName=@CategoryName and SupplierID=@SupplierID";
            SqlCommand cmd = new SqlCommand(sql, DBC.conn);
            cmd.Parameters.AddWithValue("@CategoryName", name);
            cmd.Parameters.AddWithValue("@SupplierID", IDSupp);
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
                string sql = "select max(CategoryID + 1) from Category where SupplierID=@SupplierID";
                SqlCommand cmd = new SqlCommand(sql, DBC.conn);
                cmd.Parameters.AddWithValue("@SupplierID", IDSupp);
                DBC.conn.Open();
                max = int.Parse(cmd.ExecuteScalar().ToString());
                DBC.conn.Close();
            }
            catch(Exception ex)
            {
                max = 1;
            }
            finally
            {
                DBC.conn.Close();
            }

            return max;
        }
    }
}
