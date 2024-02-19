using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace AnbardariFinal
{
    internal interface IExportAndImportRepository
    {
        DataTable SelectAll();
        DataTable SearchStore(int CodeStore);
        DataTable SearchProduct(int CodeProduct);
        bool Insert(int CodeProduct, string ProductName, int ProductSerials, int CodeStore, string StoreName, int Number, string Person, string Persontype, string Date, string Note);

    }
}
