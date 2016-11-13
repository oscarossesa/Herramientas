using Repository;
using System.Collections.Generic;
using Utils;
using Common.Entities;
using System.Linq;

namespace Services.Implementations
{
    public class DiccionarioSerivice
    {
        private DiccionarioRepository diccionarioDatosRepository;

        public DiccionarioSerivice()
            : this(new DiccionarioRepository())
        {
        }

        public DiccionarioSerivice(DiccionarioRepository diccionarioDatosRepository)
        {
            this.diccionarioDatosRepository = diccionarioDatosRepository;
        }

        //public IList<Diccionario> GetTablas()
        //{
        //    IList<Diccionario> diccionario = diccionarioDatosRepository.GetTablas();

        //    //diccionarioDatosRepository.GetTablas().OrderBy(x => x.Tabla).OrderByDescending(;

        //    return diccionario;


        //}
    }
}