using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    internal class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeeContext _context;
        public EmployeeRepository(EmployeeContext context)
        {
            _context = context;
        }
        public IEnumerable<Employees> All()
        {
            return _context.Employees;
        }
        public Employees Insert(Employees employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
            return employee;
        }

        public bool Remove(int id)
        {
            var employee = _context.Employees.FirstOrDefault(_ => _.EmployeeId == id);
            if (employee==null)
            {
                return false;
            }
            _context.Employees.Remove(employee);
            _context.SaveChanges();
            return true;
        }
        public Employees Single(int id)
        {
            return _context.Employees.FirstOrDefault(_ => _.EmployeeId == id);
        }
        public Employees Update(Employees employee)
        {
            if (_context.Employees.Any(_=>_.EmployeeId==employee.EmployeeId))
            {
                _context.Employees.Update(employee);
                _context.SaveChanges();
                return employee;
            }
            return null;
        }
    }
}
