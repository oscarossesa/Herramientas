using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Persistencia;

namespace Dominio
{
    public class DominioPersonal
    {
        public List<Personal> GetPersonal(string path)
        {
            //TODO: persistir el objeto Personal 
            PersistirPersonal pPersonal = new PersistirPersonal();
            List<Personal> personas = new List<Personal>();
            personas = pPersonal.GetPersonal(path);

            return personas;
        }

        public bool AgregarPersonal(Personal personal, string path)
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
            PersistirPersonal pPersonal = new PersistirPersonal();
            pPersonal.AddPersonal(personal, path);


            return true;
        }
    }
}
