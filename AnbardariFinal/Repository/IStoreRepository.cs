using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AnbardariFinal
{
    internal interface IStoreRepository
    {
        DataTable SelectAll();
        DataTable SelectRow(int CodeStore);
        DataTable SearchByName(string parameter);
        bool Insert(int CodeStore, string StoreName, string StorePhone, string StoreAddress);
        bool Update(int CodeStore, string StoreName, string StorePhone, string StoreAddress);
        bool Delete(int CodeStore);
    }
}
