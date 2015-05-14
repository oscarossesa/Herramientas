using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.IO;
using Newtonsoft.Json;

namespace Persistencia
{
    public class PersistirPersonal
    {
        public bool AgregarPersonal(Personal personal, string path)
        {
            //TODO: persistir obejeto de tipo Personal

            LoadJson2(path);

            return true;
        }

        public void LoadJson1()
        {

            //var path = Server.MapPath("~/Content/treatments.json");
            using (StreamReader r = new StreamReader("path"))
            {
                string json = r.ReadToEnd();
                List<Item> items = JsonConvert.DeserializeObject<List<Item>>(json);
            }
        }

        public void LoadJson2(string path)
        {
            string json = System.IO.File.ReadAllText(path);
            dynamic jsonObj = JsonConvert.DeserializeObject(json);
            jsonObj["Personal"][0]["Nombre"] = "Oscar Osses Arriaza";
            string output = JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
            System.IO.File.WriteAllText(path, output);
        }
    }

    public class Item
    {
        public int millis;
        public string stamp;
        public DateTime datetime;
        public string light;
        public float temp;
        public float vcc;
    }
}
