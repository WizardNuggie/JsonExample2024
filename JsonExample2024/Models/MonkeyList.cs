using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace JsonExample2024.Models
{
    public class MonkeyList
    {
        public List<Monkey> Monkeys { get; set; }
        public MonkeyList()
        {
            Monkeys = new List<Monkey>();
            FillList();
        }
        public void FillList()
        {
            string text = File.ReadAllText(@"../../../monkeydata.json");
            Monkeys = JsonSerializer.Deserialize<List<Monkey>>(text);
        }
    }
}
