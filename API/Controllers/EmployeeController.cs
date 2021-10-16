using DataAccess;
using DataAccess.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [ApiController]
    [Route("Employees")]
    public class EmployeeController:ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        [HttpGet]
        public IEnumerable<Employees> Get()
        {
            return _employeeRepository.All();
        }
        [HttpGet("{id}")]
        public Employees Get(int id)
        {
            return _employeeRepository.Single(id);
        }
        [HttpPost]
        public Employees Post(Employees employee)
        {
           return _employeeRepository.Insert(employee);
        }
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            return _employeeRepository.Remove(id);
        }
        [HttpPut]
        public Employees Put(Employees employee)
        {
            return _employeeRepository.Update(employee);
        }

    }
}
