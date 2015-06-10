using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contratos.Persistencia
{
    public interface IPersistenciaPersonal
    {
        List<Personal> GetPersonal();
        int AddPersonal(Personal personal);
    }
}
