using AssetInsightsApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssetInsightsApplication.IService
{
    public interface IEmployeeService
    {
        List<Employee> GetEmployee();
        Employee GetById(int employeeId);
        void Save(Employee oEmployee);
        void Update(Employee oEmployee);
        string Delete(int employeeId);
    }
}
