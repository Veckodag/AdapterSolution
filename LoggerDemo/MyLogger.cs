using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerDemo
{
    public class MyLogger : ILogger
    {
        public void Log(string s)
        {
            Console.WriteLine(s);
        }
    }
}
