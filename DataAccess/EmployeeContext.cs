using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions options)
           : base(options)
        {

        }
        public DbSet<Employees> Employees { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employees>().HasData(new Employees
            {
                EmployeeId = 1,
                FirstName = "Laura",
                LastName = "Callahan",
                Address = "908 W. Capital Way"
            }, new Employees
            {
                EmployeeId = 2,
                FirstName = "Margaret",
                LastName = "Peacock",
                Address = "14 Garrett Hill"
            });
        }
    }
}
