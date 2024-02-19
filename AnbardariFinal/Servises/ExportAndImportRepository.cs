using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AnbardariFinal
{
    internal class ExportAndImportRepository : IExportAndImportRepository
    {
        private string connectionString = "Data Source=.;Initial Catalog=InventoryManagement;Integrated Security=true";
        public bool Insert(int CodeProduct, string ProductName, int ProductSerials, int CodeStore, string StoreName, int Number, string Person, string Persontype, string Date, string Note)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                string query = "Insert into tblExportImport (CodeProduct, ProductName, ProductSerials, CodeStore, StoreName, Number, Person, Persontype, Date, Note) values (@CodeProduct, @ProductName, @ProductSerials, @CodeStore, @StoreName, @Number, @Person, @Persontype, @Date, @Note)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@CodeProduct", CodeProduct);
                cmd.Parameters.AddWithValue("@ProductName", ProductName);
                cmd.Parameters.AddWithValue("@ProductSerials", ProductSerials);
                cmd.Parameters.AddWithValue("@CodeStore", CodeStore);
                cmd.Parameters.AddWithValue("@StoreName", StoreName);
                cmd.Parameters.AddWithValue("@Number", Number);
                cmd.Parameters.AddWithValue("@Person", Person);
                cmd.Parameters.AddWithValue("@Persontype", Persontype);
                cmd.Parameters.AddWithValue("@Date", Date);
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

        public DataTable SearchProduct(int CodeProduct)
        {
            string query = "Select * from tblProduct where codeProduct= " + CodeProduct;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;

        }

        public DataTable SearchStore(int CodeStore)
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
            string query = "Select * from tblExportImport";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;

        }
    }
}
