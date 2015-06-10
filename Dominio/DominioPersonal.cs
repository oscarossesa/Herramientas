using Contratos.Dominio;
using Entidades;
using PersistenciaJson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class DominioPersonal : IDominioPersonal
    {
        PersistirPersonal _persistirPersonal;
        
        public DominioPersonal()
        {
            _persistirPersonal = new PersistirPersonal();
        }

        public List<Personal> GetPersonal()
        {
            //TODO: persistir el objeto Personal
            
            List<Personal> personas = new List<Personal>();
            personas = _persistirPersonal.GetPersonal();

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
            _persistirPersonal.AddPersonal(personal);

            return 1;
        }
    }
}