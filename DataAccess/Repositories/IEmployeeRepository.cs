using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface IEmployeeRepository
    {
        Employees Insert(Employees employee);
        IEnumerable<Employees> All();
        Employees Single(int id);
        Employees Update(Employees employee);
        bool Remove(int id);
    }
}
