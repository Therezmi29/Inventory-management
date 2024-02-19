using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AnbardariFinal
{
    internal class AddProductToStoreRepository : IAddProductToStoreRepository
    {
        private string connectionString = "Data Source=.;Initial Catalog=InventoryManagement;Integrated Security=true";
        public bool Insert(int Code, int CodeStore, string StoreName, int CodeProduct, string ProductName, int ProductSerials, string ProductPlace, int FirstBalance, int CurrentBalance)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                string query = "Insert into tblProductStore (Code , CodeStore ,  StoreName,  CodeProduct,  ProductName,  ProductSerials,  ProductPlace, FirstBalance, CurrentBalance) values (@Code, @CodeStore, @StoreName, @CodeProduct , @ProductName, @ProductSerials, @ProductPlace, @FirstBalance, @CurrentBalance)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Code", Code);
                cmd.Parameters.AddWithValue("@CodeStore", CodeStore);
                cmd.Parameters.AddWithValue("@StoreName", StoreName);
                cmd.Parameters.AddWithValue("@CodeProduct", CodeProduct);
                cmd.Parameters.AddWithValue("@ProductName", ProductName);
                cmd.Parameters.AddWithValue("@ProductSerials", ProductSerials);
                cmd.Parameters.AddWithValue("@ProductPlace", ProductPlace);
                cmd.Parameters.AddWithValue("@FirstBalance", FirstBalance);
                cmd.Parameters.AddWithValue("@CurrentBalance", FirstBalance);
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

        public DataTable Search_Code(int Code)
        {
            string query = "Select * From tblProductStore where Code=" + Code;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }

        public DataTable Search_Product(int CodeProduct)
        {
            string query = "Select * from tblProduct where codeProduct= " + CodeProduct;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }

        public DataTable Search_Store(int CodeStore)
        {
            string query = "Select * From tblStore where CodeStore=" + CodeStore;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }

        public DataTable SelectAll()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "Select * from tblProductStore";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }

    }
}
