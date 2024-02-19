using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AnbardariFinal
{
    internal class PersonRepository : IPersonRepository
    {
        private string connectionString = "Data Source=.;Initial Catalog=InventoryManagement;Integrated Security=true";

        public bool Delete(string CodePerson)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                string query = "Delete from tblpersons where CodePerson = @CodePerson";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@CodePerson", CodePerson);
                connection.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public bool Insert(string CodePerson, string Name, string Type, string Phone, string Mobile, string Password, string Address)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                string query = "Insert into tblpersons (CodePerson , Name , Type , Phone , Mobile , Password , Address) values (@CodePerson , @Name , @Type, @Phone , @Mobile , @Password , @Address)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@CodePerson", CodePerson);
                cmd.Parameters.AddWithValue("@name", Name);
                cmd.Parameters.AddWithValue("@Type", Type);
                cmd.Parameters.AddWithValue("@Phone", Phone);
                cmd.Parameters.AddWithValue("@Mobile", Mobile);
                cmd.Parameters.AddWithValue("@Password", Password);
                cmd.Parameters.AddWithValue("@Address", Address);
                connection.Open();
                cmd.ExecuteNonQuery();
                return true;

            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public DataTable Login(string Username, string Password)
        {
            string query = "select * from tblpersons where Username = @Username and Password = @Password";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@Username", Username);
            cmd.Parameters.AddWithValue("@Password", Password);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
            connection .Open ();
            int i = cmd.ExecuteNonQuery();
            connection.Close ();
            
        }

        public DataTable ReadData(string CodePerson)
        {
            string query = "Select * from tblpersons where CodePerson= " + CodePerson;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }

        public DataTable SearchByCode(string CodePerson)
        {
            string query = "Select * From tblpersons where Name like @CodePerson";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.SelectCommand.Parameters.AddWithValue("@Code", "%" + CodePerson + "%");
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }

        public DataTable SearchByName(string parameter)
        {
            string query = "Select * From tblpersons where Name like @parameter or Family like @parameter";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.SelectCommand.Parameters.AddWithValue("@parameter", "%" + parameter + "%");
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }

        public DataTable SelectAll()
        {
            string query = "Select * from tblpersons";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }

        public bool Update(string CodePerson, string Name, string Type, string Phone, string Mobile, string Password, string Address)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                string query = "Update tblpersons set CodePerson = @CodePerson , Name = @Name , Type = @Type , Phone = @Phone , Mobile = @Mobile , Password = @Password , Address = @Address";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@CodePerson", CodePerson);
                cmd.Parameters.AddWithValue("@name", Name);
                cmd.Parameters.AddWithValue("@Type", Type);
                cmd.Parameters.AddWithValue("@Phone", Phone);
                cmd.Parameters.AddWithValue("@Mobile", Mobile);
                cmd.Parameters.AddWithValue("@Password", Password);
                cmd.Parameters.AddWithValue("@Address", Address);
                connection.Open();
                cmd.ExecuteNonQuery();
                return true;

            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
