using AdministracionDeEmpleados.Models;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionDeEmpleados.Repositories
{
    public interface IEmployeeCollection
    {
        void InsertEmployee(Employee employee);
        void UpdateEmployee(Employee employee);
        void DeleteEmployee(string id);
        List<Employee> GetEmployeeAll();
        List<Employee> GetEmployeeById(string id);
        List<Employee> GetEmployeeByEmail(string email);

    }
}
