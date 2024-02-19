using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace AnbardariFinal
{
    internal interface IStockRepository
    {
        bool Insert(int CodeCompany, string CompanyName, string OwnerName, string Phone, string Fax, string Address);
        bool Update(int CodeCompany, string CompanyName, string OwnerName, string Phone, string Fax, string Address);

    }
}
