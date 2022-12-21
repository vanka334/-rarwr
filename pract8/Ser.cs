using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace pract8
{
    internal class Ser
    {
        public static void Serelization(List<Tablica> list)
        {
           
            
            string json = JsonConvert.SerializeObject(list);
            File.WriteAllText("C:\\Users\\Vanya\\OneDrive\\Рабочий стол\\skoka.json", json);
        }
        public static void Deserialize()
        {
            string text = File.ReadAllText("C:\\Users\\Vanya\\OneDrive\\Рабочий стол\\skoka.json"); 
            Program.list = JsonConvert.DeserializeObject<List<Tablica>>(text);
        }

    }
}
