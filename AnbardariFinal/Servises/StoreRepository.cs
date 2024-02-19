using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AnbardariFinal
{
    internal class StoreRepository : IStoreRepository
    {
        private string connectionString = "Data Source=.;Initial Catalog=InventoryManagement;Integrated Security=true";

        public bool Delete(int CodeStore)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                string query = "Delete from tblStore where CodeStore = @CodeStore";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@CodeStore", CodeStore);
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

        public bool Insert(int CodeStore, string StoreName, string StorePhone, string StoreAddress)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                string query = "Insert into tblStore (CodeStore , StoreName , StorePhone , StoreAddres) values (@CodeStore , @StoreName , @StorePhone, @StoreAddress)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@CodeStore", CodeStore);
                cmd.Parameters.AddWithValue("@StoreName", StoreName);
                cmd.Parameters.AddWithValue("@StorePhone", StorePhone);
                cmd.Parameters.AddWithValue("@StoreAddress", StoreAddress);
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

        public DataTable SearchByName(string parameter)
        {
            string query = "Select * From tblStore where ProductName like @parameter";
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
            string query = "Select * from tblStore";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }

        public DataTable SelectRow(int CodeStore)
        {
            string query = "Select * From tblStore where CodeStore=" + CodeStore;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }

        public bool Update(int CodeStore, string StoreName, string StorePhone, string StoreAddress)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                string query = "Update tblStore set CodeStore = @CodeStore , StoreName = @StoreName , StorePhone = @StorePhone , StoreAddress = @StoreAddress)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@CodeStore", CodeStore);
                cmd.Parameters.AddWithValue("@StoreName", StoreName);
                cmd.Parameters.AddWithValue("@StorePhone", StorePhone);
                cmd.Parameters.AddWithValue("@StoreAddress", StoreAddress);
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
