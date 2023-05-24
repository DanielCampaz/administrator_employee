using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionDeEmpleados.Models
{
    public class Employee
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Position { get; set; }
        public Int64 Salary { get; set; }
        public bool Active { get; set; }
        public string Password { get; set; }
        public bool Admin { get; set; }
        public Int64 CC { get; set; }
        public Int64 NRegistre { get; set; }
        public Int64 Phone { get; set; }

    }
}
