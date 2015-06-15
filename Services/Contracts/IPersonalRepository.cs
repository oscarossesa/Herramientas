using Common.Entities;
using System.Collections.Generic;

namespace Services.Contracts
{
    public interface IPersonalRepository
    {
        List<Personal> GetPersonal();

        int AddPersonal(Personal personal);
    }
}