using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace AnbardariFinal
{
    internal class ProductRepository : IProductRepository
    {
        private string connectionString = "Data Source=.;Initial Catalog=InventoryManagement;Integrated Security=true";
        public bool Delete(int codeProduct)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                string query = "Delete from tblProduct where codeProduct = @codeProduct";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@codeProduct", codeProduct);
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

        public bool Insert(int codeProduct, string ProductName, string ProductGroupName, int ProductSerials, string Unit, string Note)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                string query = "Insert into tblProduct (codeProduct , ProductName , ProductGroupName , ProductSerials , Unit , Note) values (@codeProduct , @ProductName , @ProductGroupName, @ProductSerials , @Unit , @Note)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@codeProduct", codeProduct);
                cmd.Parameters.AddWithValue("@ProductName", ProductName);
                cmd.Parameters.AddWithValue("@ProductGroupName", ProductGroupName);
                cmd.Parameters.AddWithValue("@ProductSerials", ProductSerials);
                cmd.Parameters.AddWithValue("@Unit", Unit);
                cmd.Parameters.AddWithValue("@Note", Note);
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

        public DataTable SearchByCode(int codeProduct)
        {
            string query = "Select * From tblProduct where Code like @parameter";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.SelectCommand.Parameters.AddWithValue("@parameter", "%" + codeProduct + "%");
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }

        public DataTable SearchByName(string parameter)
        {
            string query = "Select * From tblProduct where ProductName like @parameter or ProductGroupName like @parameter";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.SelectCommand.Parameters.AddWithValue("@parameter", "%" + parameter + "%");
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }

        public DataTable SelectAll()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "Select * from tblProduct";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }

        public DataTable ReadData(int codeProduct)
        {
            string query = "Select * from tblProduct where codeProduct= " + codeProduct;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }

        public bool Update(int codeProduct, string ProductName, string ProductGroupName, int ProductSerials, string Unit, string Note)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                string query = "Update tblProduct set codeProduct = @codeProduct , ProductName = @ProductName , ProductGroupName = @ProductGroupName , ProductSerials = @ProductSerials , Unit = @Unit , Note = @Note)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Code", codeProduct);
                cmd.Parameters.AddWithValue("@ProductName", ProductName);
                cmd.Parameters.AddWithValue("@ProductGroupName", ProductGroupName);
                cmd.Parameters.AddWithValue("@ProductSeials", ProductSerials);
                cmd.Parameters.AddWithValue("@Unit", Unit);
                cmd.Parameters.AddWithValue("@Note", Note);
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
