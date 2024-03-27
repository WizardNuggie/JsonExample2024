using JsonExample2024.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace JsonExample2024.Service
{
    public class Service
    {
        private MonkeyList monkeys;
        public List<Monkey> Monkeys { get => monkeys.Monkeys; }
        public Service()
        {
            monkeys = new();
        }
        public void PrintMonkeys()
        {
            foreach (Monkey m in  Monkeys)
            {
                Console.WriteLine(m.ToString());
                Console.WriteLine("-------------------------------");
            }
        }
        public void JsonMonkey(Monkey m)
        {
            DeSerialize(Serialize(m));
            PrintMonkeys();
        }
        private string Serialize(Monkey m)
        {
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true,
                IgnoreReadOnlyProperties = true,
                IncludeFields = true,
            };
            string json = JsonSerializer.Serialize(m, options);
            return json;
        }
        private void DeSerialize(string json)
        {
            Monkey m = JsonSerializer.Deserialize<Monkey>(json);
            monkeys.Monkeys.Add(m);
        }
    }
}
