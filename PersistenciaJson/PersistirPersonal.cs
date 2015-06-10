using Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using Contratos.Persistencia;

namespace PersistenciaJson
{
    public class PersistirPersonal : IPersistenciaPersonal
    {
        //string fileName = "personal.json";

        public List<Personal> GetPersonal()
        {
            List<Personal> personas = new List<Personal>();

            using (StreamReader r = new StreamReader(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "personal.json")))
            {
                string json = r.ReadToEnd();
                personas = JsonConvert.DeserializeObject<List<Personal>>(json);
            }

            return personas;
        }

        public int AddPersonal(Personal personal)
        {
            //TODO: persistir obejeto de tipo Personal

            PersistirJson(personal);
            //PersistirBD(personal);

            return 1;
        }

        public void PersistirJson(Personal personal)
        {
            string newJson = string.Empty;
            string path = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "personal.json");

            using (StreamReader r = new StreamReader(path))
            {
                string json = r.ReadToEnd();
                List<Personal> personas = JsonConvert.DeserializeObject<List<Personal>>(json);
                personas.Add(personal);
                newJson = JsonConvert.SerializeObject(personas);                
            }

            File.WriteAllText(path, newJson);
        }


       
    }
}