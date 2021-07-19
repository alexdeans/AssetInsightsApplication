using AssetInsightsApplication.IService;
using AssetInsightsApplication.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssetInsightsApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        IEmployeeService _employeeService = null;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        // GET: api/<EmployeeController>
        [HttpGet]
        public IEnumerable<Employee> GetEmployee()
        {
            return _employeeService.GetEmployee();

        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}", Name = "Get")]
        public Employee Get(int id)
        {
            return _employeeService.GetById(id);
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public void SaveOrUpdate([FromForm] Employee employee)
        {
            if (employee.EmployeeId == 0) _employeeService.Save(employee);
            else _employeeService.Update(employee);
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return _employeeService.Delete(id);
        }
    }
}
