using AdministracionDeEmpleados.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionDeEmpleados.Repositories
{
    public class NRegistroCollection : INRegistroCollection
    {
        internal MongoDBRepository _repository = new MongoDBRepository("efDLK9varPMUXjZA");

        private IMongoCollection<NRegistro> Collection;

        public NRegistroCollection()
        {
            Collection = _repository.db.GetCollection<NRegistro>("NRegistro");
        }

        public void DeleteNRegistre(string id)
        {
            ObjectId ID = new ObjectId(id);
            Collection.DeleteOne(d => d.Id == ID);
        }

        public List<NRegistro> GetNRegistreAll()
        {
            List<NRegistro> nregistro = Collection.Find(d => true).ToList();

            return nregistro;
        }

        public List<NRegistro> GetNRegistreById(string id)
        {
            ObjectId ID = new ObjectId(id);
            var nregistroFil = Collection.Find(d => d.Id == ID).ToList();

            return nregistroFil;
        }

        public void InsertNRegistre(NRegistro registro)
        {
            Collection.InsertOne(registro);
        }

        public void UpdateNRegistre(NRegistro registro)
        {
            Collection.ReplaceOne(d => d.Id == registro.Id, registro);
        }
    }
}
