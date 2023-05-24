using AdministracionDeEmpleados.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AdministracionDeEmpleados.Repositories
{
    public class EmployeeCollection : IEmployeeCollection
    {
        internal MongoDBRepository _repository = new MongoDBRepository("efDLK9varPMUXjZA");
        
        private IMongoCollection<Employee> Collection;


        public EmployeeCollection() 
        {
            Collection = _repository.db.GetCollection<Employee>("Employees");
        }

        public void DeleteEmployee(string id)
        {
            ObjectId ID = new ObjectId(id);
            Collection.DeleteOne(d => d.Id == ID);
        }

        public List<Employee> GetEmployeeAll()
        {
            List<Employee> employees = Collection.Find(d => true).ToList();

            return employees;
        }

        public List<Employee> GetEmployeeByEmail(string email)
        {
            List<Employee> employees = Collection.Find(d => d.Email == email).ToList();

            return employees;
        }

        public List<Employee> GetEmployeeByCC(Int64 cedula)
        {
            List<Employee> employees = Collection.Find(d => d.CC == cedula).ToList();

            return employees;
        }

        public  List<Employee> GetEmployeeById(string id)
        {
            ObjectId ID = new ObjectId(id);
            /*var employeFil = await employeeDB.FindAsync(
                    new BsonDocument { { "_id", id } }
                ).Result.FirstAsync();*/

            var employeFil = Collection.Find(d => d.Id == ID).ToList();
            


            return employeFil;
        }

        public void InsertEmployee(Employee employee)
        {
            Collection.InsertOne(employee);
        }

        public void UpdateEmployee(Employee employee)
        {
            Collection.ReplaceOne(d => d.Id == employee.Id, employee );
        }
    }
}
