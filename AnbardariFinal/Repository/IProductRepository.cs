using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace AnbardariFinal
{
    internal interface IProductRepository
    {
        DataTable SelectAll();
        DataTable ReadData(int codeProduct);
        DataTable SearchByCode(int codeProduct);
        DataTable SearchByName(string parameter);
        bool Insert(int codeProduct, string ProductName, string ProductGroupName, int ProductSerials, string Unit, string Note);
        bool Update(int codeProduct, string ProductName, string ProductGroupName, int ProductSerials, string Unit, string Note);
        bool Delete(int codeProduct);
    }
}
