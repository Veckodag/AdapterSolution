using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CheeseCakes;

namespace LoggerDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type your favorite cheesecake and hit enter");
            string name = Console.ReadLine();
            Console.WriteLine("What is the cakes flavor?");
            string flavor = Console.ReadLine();
            ILogger logger = new CheeseCakeAdapter(new Cheesecake(name, flavor));
            FavoriteCake(logger, "My favorite cake is ");
            Console.ReadLine();
        }

        private static void FavoriteCake(ILogger logger, string p)
        {
            logger.Log(p);
        }
    }
}
