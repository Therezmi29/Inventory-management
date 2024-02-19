using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AnbardariFinal
{
    internal class StockRepository : IStockRepository
    {
        private string connectionString = "Data Source=.;Initial Catalog=InventoryManagement;Integrated Security=true";
        public bool Insert(int CodeCompany, string CompanyName, string OwnerName, string Phone, string Fax, string Address)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {

                string query = "Insert into tblCompanyInfo (CodeCompany , CompanyName , OwnerName , Phone , Fax , Address) values (@CodeCompany , @CompanyName , @OwnerName, @Phone , @Fax , @Address)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@CodeCompany",CodeCompany);
                cmd.Parameters.AddWithValue("@CompanyName", CompanyName);
                cmd.Parameters.AddWithValue("@OwnerName", OwnerName);
                cmd.Parameters.AddWithValue("@Phone", Phone);
                cmd.Parameters.AddWithValue("@Fax", Fax);
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


        public bool Update(int CodeCompany, string CompanyName, string OwnerName, string Phone, string Fax, string Address)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                string query = "Update tblCompanyInfo set CodeCompany = @CodeCompany , CompanyName = @CompanyName , OwnerName = @OwnerName , Phone = @Phone , Fax = @Fax , Address = @Address";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@CodeCompany", CodeCompany);
                cmd.Parameters.AddWithValue("@CompanyName", CompanyName);
                cmd.Parameters.AddWithValue("@OwnerName", OwnerName);
                cmd.Parameters.AddWithValue("@Phone", Phone);
                cmd.Parameters.AddWithValue("@Fax", Fax);
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
