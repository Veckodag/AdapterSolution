using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheeseCakes
{
    public class Cheesecake
    {
        public Cheesecake()
        {
            
        }
        public Cheesecake(string name, string flavor)
        {
            Name = name;
            Flavor = flavor;
        }
        public string Name { get; set; }
        public string Flavor { get; set; }

    }
}
