using Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Persistencia
{
    public class PersistirPersonal
    {
        public List<Personal> GetPersonal(string path)
        {
            List<Personal> personas = new List<Personal>();

            using (StreamReader r = new StreamReader(path))
            {
                string json = r.ReadToEnd();
                personas = JsonConvert.DeserializeObject<List<Personal>>(json);
            }

            return personas;
        }

        public bool AddPersonal(Personal personal, string path)
        {
            //TODO: persistir obejeto de tipo Personal

            PersistirJson(personal, path);

            return true;
        }

        public void PersistirJson(Personal personal, string path)
        {
            string newJson = string.Empty;

            using (StreamReader r = new StreamReader(path)) {
                string json = r.ReadToEnd();
                List<Personal> personas = JsonConvert.DeserializeObject<List<Personal>>(json);
                personas.Add(personal);
                newJson = JsonConvert.SerializeObject(personas);                
            }

            File.WriteAllText(path, newJson);
        }
    }
}