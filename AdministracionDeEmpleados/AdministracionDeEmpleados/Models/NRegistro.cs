using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionDeEmpleados.Models
{
    public class NRegistro
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public Int64 count { get; set; }
    }
}
