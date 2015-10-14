using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocketLogger
{
    public class RocketLogger
    {
        public void WriteToConsole(string message)
        {
            Console.WriteLine("Wroom " + message);
        }
    }
}
