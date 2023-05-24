using AdministracionDeEmpleados.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionDeEmpleados.Repositories
{
    public interface INRegistroCollection
    {
        void InsertNRegistre(NRegistro registro);
        void UpdateNRegistre(NRegistro registro);
        void DeleteNRegistre(string id);
        List<NRegistro> GetNRegistreAll();
        List<NRegistro> GetNRegistreById(string id);
    }
}
