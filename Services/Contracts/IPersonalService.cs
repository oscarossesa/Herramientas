using Common.Entities;
using System.Collections.Generic;

namespace Services.Contracts
{
    public interface IPersonalService
    {
        List<Personal> GetPersonal();

        int AddPersonal(Personal personal);
    }
}