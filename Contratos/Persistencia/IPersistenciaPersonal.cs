using Common.Entities;
using System.Collections.Generic;

namespace Contratos.Persistencia
{
    public interface IPersistenciaPersonal
    {
        List<Personal> GetPersonal();

        int AddPersonal(Personal personal);
    }
}