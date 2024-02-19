using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace AnbardariFinal
{
    internal interface IAddProductToStoreRepository
    {
        DataTable SelectAll();
        DataTable Search_Code(int Code);
        DataTable Search_Product(int CodeProduct);
        DataTable Search_Store(int CodeStore);
        bool Insert(int Code, int CodeStore, string StoreName, int CodeProduct, string ProductName, int ProductSerials, string ProductPlace, int FirstBalance, int CurrentBalance);

    }
}
