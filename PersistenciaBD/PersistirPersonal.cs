//using Entidades;
//using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
//using Contratos.Persistencia;

namespace PersistenciaBD
{
    public class PersistirPersonal
    {
        //const string path = "Environment. Server.MapPath(~/personal.json);";

        //public List<Personal> GetPersonal()
        //{
        //    List<Personal> personas = new List<Personal>();

        //    using (StreamReader r = new StreamReader(path))
        //    {
        //        string json = r.ReadToEnd();
        //        personas = JsonConvert.DeserializeObject<List<Personal>>(json);
        //    }

        //    return personas;
        //}

        //public bool AddPersonal(Personal personal)
        //{
        //    //TODO: persistir obejeto de tipo Personal

        //    PersistirJson(personal);
        //    //PersistirBD(personal);

        //    return true;
        //}

        //public void PersistirJson(Personal personal)
        //{
        //    string newJson = string.Empty;
            

        //    using (StreamReader r = new StreamReader(path)) {
        //        string json = r.ReadToEnd();
        //        List<Personal> personas = JsonConvert.DeserializeObject<List<Personal>>(json);
        //        personas.Add(personal);
        //        newJson = JsonConvert.SerializeObject(personas);                
        //    }

        //    File.WriteAllText(path, newJson);
        //}
    }
}