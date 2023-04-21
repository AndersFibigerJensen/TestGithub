using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGithub
{
    public class Chicken
    {
        public int NrOfEggs { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Chicken(int nrOfEggs, string name, int age)
        {
            NrOfEggs = nrOfEggs;
            Name = name;
            Age = age;
        }
    }
}
