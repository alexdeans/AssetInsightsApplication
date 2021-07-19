using AssetInsightsApplication.Context;
using AssetInsightsApplication.IService;
using AssetInsightsApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssetInsightsApplication.Service
{
    public class EmployeeService : IEmployeeService
    {
        private readonly DatabaseContext _context;
        public EmployeeService(DatabaseContext context)
        {
            _context = context;
        }
        public string Delete(int employeeId)
        {
            var employee = _context.Employee.FirstOrDefault(x => x.EmployeeId == employeeId);
            if (employee != null)
            {
                _context.Employee.Remove(employee);
                _context.SaveChanges();
            }
            return "Deleted";
        }

        public Employee GetById(int employeeId)
        {
            return _context.Employee.SingleOrDefault(x=>x.EmployeeId == employeeId);
        }

        public List<Employee> GetEmployee()
        {
            return _context.Employee.ToList();
        }

        public void Save(Employee oEmployee)
        {
            _context.Employee.Add(oEmployee);
            _context.SaveChanges(); 
        }

        public void Update(Employee oEmployee)
        {
            _context.Employee.Update(oEmployee);
            _context.SaveChanges();
        }
    }
}
