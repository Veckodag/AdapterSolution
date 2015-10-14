using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CheeseCakes;

namespace LoggerDemo
{
    public class CheeseCakeAdapter : ILogger
    {
        Cheesecake myCake = new Cheesecake();
        public CheeseCakeAdapter(Cheesecake cake)
        {
            myCake.Name = cake.Name;
            myCake.Flavor = cake.Flavor;
        }

        public void Log(string message)
        {
            Console.WriteLine(message + $"{myCake.Name} cheesecake with the flavor {myCake.Flavor}");
        }
    }
}
