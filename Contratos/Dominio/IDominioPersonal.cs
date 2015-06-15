using Common.Entities;
using System.Collections.Generic;

namespace Contratos.Dominio
{
    public interface IDominioPersonal
    {
        List<Personal> GetPersonal();

        int AddPersonal(Personal personal);
    }
}