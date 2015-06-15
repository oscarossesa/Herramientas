using Common.Entities;
using Repository;
using Services.Contracts;
using System;
using System.Collections.Generic;

namespace Services.Implementations
{
    public class PersonalService : IPersonalRepository
    {
        private PersonalRepository _personalRepository;

        public PersonalService()
        {
            _personalRepository = new PersonalRepository();
        }

        public List<Personal> GetPersonal()
        {
            //TODO: persistir el objeto Personal

            List<Personal> personas = new List<Personal>();
            personas = _personalRepository.GetPersonal();

            return personas;
        }

        public int AddPersonal(Personal personal)
        {
            //TODO: implementar logica de dominio para agregar a una persona de tipo Personal

            if (String.IsNullOrEmpty(personal.Nombre))
            {
                throw new ArgumentException("Nombre es nulo o vacío.");
            }

            if (!(Convert.ToInt32(personal.Anexo) > 0))
            {
                throw new ArgumentException("Anexo debe ser mayor que 0.");
            }

            //TODO: persistir el objeto Personal
            _personalRepository.AddPersonal(personal);

            return 1;
        }
    }
}