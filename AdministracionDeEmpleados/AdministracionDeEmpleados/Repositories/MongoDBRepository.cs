using AdministracionDeEmpleados.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionDeEmpleados.Repositories
{
    public class MongoDBRepository
    {
        public MongoClient client;

        public IMongoDatabase db;


        public MongoDBRepository(string password)
        {
            client = new MongoClient($"mongodb+srv://DanielAdminEm:{password}@adminemple-db.bjn5rph.mongodb.net/?retryWrites=true&w=majority");

            db = client.GetDatabase("AdEmpDb");
        }
    }
}
