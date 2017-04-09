using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Ecommers.DL
{
    public class User 
    {

        public int Add(Ecommers.Entity.Users user)
        {
            int result = 0;
            string sql = "insert into Users (Fullname,Username,Password,Phone,Address,Email,Gender,type,CreatedTime) values (@Fullname,@Username,@Password,@Phone,@Address,@Email,@Gender,@type,@CreatedTime) ";
            SqlCommand cmd = new SqlCommand(sql, DBC.conn);
            cmd.Parameters.AddWithValue("@Fullname",user.Fullname);
            cmd.Parameters.AddWithValue("@Username", user.Username);
            cmd.Parameters.AddWithValue("@Password", user.Password);
            cmd.Parameters.AddWithValue("@Phone", user.Phone);
            cmd.Parameters.AddWithValue("@Address", user.Address);
            cmd.Parameters.AddWithValue("@Email", user.Email);
            cmd.Parameters.AddWithValue("@Gender", user.Gender);
            cmd.Parameters.AddWithValue("@type", user.Type);
            cmd.Parameters.AddWithValue("@CreatedTime", user.CreatedTime);
            
            DBC.conn.Open();
            result = cmd.ExecuteNonQuery();
            DBC.conn.Close();
            return result;
             
        }

    
        public int Edit(Ecommers.Entity.Users user)
        {
            int result = 0;
            string sql = "update Users set Fullname=@Fullname, Username=@Username,Password=@Password,Phone=@Phone,Address=@Address,Email=@Email,Gender=@Gender where UserID=@UserID";
            SqlCommand cmd = new SqlCommand(sql, DBC.conn);
            cmd.Parameters.AddWithValue("@Fullname", user.Fullname);
            cmd.Parameters.AddWithValue("@Username", user.Username);
            cmd.Parameters.AddWithValue("@Password", user.Password);
            cmd.Parameters.AddWithValue("@Phone", user.Phone);
            cmd.Parameters.AddWithValue("@Address", user.Address);
            cmd.Parameters.AddWithValue("@Email", user.Email);
            cmd.Parameters.AddWithValue("@Gender", user.Gender);
            
            cmd.Parameters.AddWithValue("@UserID", user.UserID);

            DBC.conn.Open();
            result = cmd.ExecuteNonQuery();
            DBC.conn.Close();
            return result;

        }

        public int Remove(Ecommers.Entity.Users user)
        {
            int result = 0;
            string sql = "delete from Users where UserID=@UserID";
            SqlCommand cmd = new SqlCommand(sql, DBC.conn);
            cmd.Parameters.AddWithValue("@UserID", user.UserID);

            DBC.conn.Open();
            result = cmd.ExecuteNonQuery();
            DBC.conn.Close();
            return result;

        }

        public DataTable getData()
        {
            DataTable table = new DataTable();
            string sql = "select * from Users";
            SqlCommand cmd = new SqlCommand(sql, DBC.conn);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            return table;

        }

        public DataTable getData(string name)
        {
            DataTable table = new DataTable();
            string sql = "select * from Users where Fullname like %@name%";
            SqlCommand cmd = new SqlCommand(sql, DBC.conn);
            cmd.Parameters.AddWithValue("@name", name);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            return table;

        }

        public DataTable getData(int ID)
        {
            DataTable table = new DataTable();
            string sql = "select * from Users where UserID = @UserID";
            SqlCommand cmd = new SqlCommand(sql, DBC.conn);
            cmd.Parameters.AddWithValue("@UserID", ID);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            return table;

        }

        public DataTable CheckUser(string name, string Password)
            
        {
            DataTable table=new DataTable();
            string sql = "select *from Users where Username=@Username and Password=@Password";
            SqlCommand cmd = new SqlCommand(sql, DBC.conn);
            cmd.Parameters.AddWithValue("@Username", name);
            cmd.Parameters.AddWithValue("@Password", Password);
            SqlDataAdapter adpater = new SqlDataAdapter();
            adpater.SelectCommand = cmd;
            adpater.Fill(table);
            return table;
        }

        public int MaxValue(string Query = "")
        {
            int result = 0;

            string sql = "select max(UserID) from Users";
                if (Query.Length > 0)
            {
                sql = sql + " where " + Query;
            }

            SqlCommand cmd = new SqlCommand(sql, DBC.conn);
            cmd.CommandType = CommandType.Text;
            DBC.conn.Open();
            result = int.Parse(cmd.ExecuteScalar().ToString());
            DBC.conn.Close();

            return result;
       }

        public int MinValue(string Query = "")
        {

            int result = 0;

            string sql = "select min(UserID) from Users";
                if (Query.Length > 0)
            {
                sql = sql + " where " + Query;
            }

            SqlCommand cmd = new SqlCommand(sql, DBC.conn);
            cmd.CommandType = CommandType.Text;
            DBC.conn.Open();
            result = int.Parse(cmd.ExecuteScalar().ToString());
            DBC.conn.Close();

            return result;
        }

        public int SumValue(string Query = "")
        {
            int result = 0;

            string sql = "select sum(UserID) from Users";
                if (Query.Length > 0)
            {
                sql = sql + " where " + Query;
            }

            SqlCommand cmd = new SqlCommand(sql, DBC.conn);
            cmd.CommandType = CommandType.Text;
            DBC.conn.Open();
            result = int.Parse(cmd.ExecuteScalar().ToString());
            DBC.conn.Close();

            return result;

        }

        public int AVGValue(string Query = "")
        {
            int result = 0;

            string sql = "select avg(UserID) from Users";
                if (Query.Length > 0)
            {
                sql = sql + " where " + Query;
            }

            SqlCommand cmd = new SqlCommand(sql, DBC.conn);
            cmd.CommandType = CommandType.Text;
            DBC.conn.Open();
            result = int.Parse(cmd.ExecuteScalar().ToString());
            DBC.conn.Close();

            return result;

        }

        public int CountValue(string Query = "")

        {
            int result = 0;

            string sql = "select count(UserID) from Users";
                if (Query.Length > 0)
            {
                sql = sql + " where " + Query;
            }

            SqlCommand cmd = new SqlCommand(sql, DBC.conn);
            cmd.CommandType = CommandType.Text;
            DBC.conn.Open();
            result = int.Parse(cmd.ExecuteScalar().ToString());
            DBC.conn.Close();

            return result;

        }


        public int Edit2(Ecommers.Entity.Users user)
        {
            int result = 0;
            string sql = "update Users set Fullname=@Fullname, Username=@Username,Password=@Password,Phone=@Phone,Address=@Address,Email=@Email where UserID=@UserID";
            SqlCommand cmd = new SqlCommand(sql, DBC.conn);
            cmd.Parameters.AddWithValue("@Fullname", user.Fullname);
            cmd.Parameters.AddWithValue("@Username", user.Username);
            cmd.Parameters.AddWithValue("@Password", user.Password);
            cmd.Parameters.AddWithValue("@Phone", user.Phone);
            cmd.Parameters.AddWithValue("@Address", user.Address);
            cmd.Parameters.AddWithValue("@Email", user.Email);
            cmd.Parameters.AddWithValue("@UserID", user.UserID);

            DBC.conn.Open();
            result = cmd.ExecuteNonQuery();
            DBC.conn.Close();
            return result;

        }

        public DataTable Supp( )

        {
       
            DataTable table = new DataTable();
            string sql = "select UserID,Fullname from Users where Type=@Type";
            SqlCommand cmd = new SqlCommand(sql, DBC.conn);
            cmd.Parameters.AddWithValue("@type", 2);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            return table;
        }
   
    }
}
