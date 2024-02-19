using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace AnbardariFinal
{
    internal interface IPersonRepository
    {
        DataTable SelectAll();
        DataTable ReadData(string CodePerson);
        DataTable SearchByName(string parameter);
        DataTable SearchByCode(string CodePerson);
        DataTable Login(string Username, string Password);
        bool Insert(string CodePerson, string Name, string Type, string Phone, string Mobile, string Password, string Address);
        bool Update(string CodePerson, string Name, string Type, string Phone, string Mobile, string Password, string Address);
        bool Delete(string CodePerson);
    }
}
