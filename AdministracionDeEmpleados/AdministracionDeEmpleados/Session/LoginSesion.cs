using AdministracionDeEmpleados.Models;
using AdministracionDeEmpleados.Repositories;
using AdministracionDeEmpleados.Resource;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionDeEmpleados.Session
{
    public class LoginSesion
    {
        private static IEmployeeCollection dbEmployee = new EmployeeCollection();

        public LoginSesion() { }

        public returnboolstring ConfirmLogin(string email, string password)
        {
            List<Employee> employeeAdmin = dbEmployee.GetEmployeeByEmail(email);

            if (employeeAdmin.Count == 0) { return new returnboolstring() { isonot = false, message = "Employee does not exist", employee = employeeAdmin[0] }; }
            if (employeeAdmin[0].Admin == false) { return new returnboolstring() { isonot = false, message = "Employee does not Administrative", employee = employeeAdmin[0] }; }
            if (employeeAdmin[0].Password == password) 
            { 
                return new returnboolstring() { isonot = true, message = "Employee does not Access", employee = employeeAdmin[0] };
            }
            else
            {
                return new returnboolstring() { isonot = false, message = "Incorrect Password", employee = employeeAdmin[0] };
            }
        }

        public void CloseSession()
        {
            XmlManipulation xml = new XmlManipulation();

            xml.DeleteLoginXml();

        }

    }

    public class returnboolstring
    {
        public string message;
        public bool isonot;
        public Employee employee;
    }
}
