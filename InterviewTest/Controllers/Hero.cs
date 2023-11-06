using InterviewTest.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewTest.Controllers
{
    public class Hero : IHero
    {
        public string name { get; set; }
        public string power { get; set; }
        public List<KeyValuePair<string, int>> stats {get;set;}
        public void evolve(int statIncrease = 5)
        {
            List<KeyValuePair<string, int>> updatedStats = new List<KeyValuePair<string, int>>();
            foreach (var stat in stats)
            {
                int originalValue = stat.Value;
                int increaseValue = originalValue / 2 * statIncrease;
                updatedStats.Add(new KeyValuePair<string, int>(stat.Key, originalValue + increaseValue));
            }
            stats = updatedStats;
        }
    }
}
