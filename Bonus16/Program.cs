using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus16
{
    class Program
    {
        static void Main(string[] args)
        {
            CarApp startApp = new CarApp();

            Console.WriteLine("How many cars do you want to create?");
            startApp.CreateObjectAndPrint(Console.ReadLine());

            Console.ReadLine();

        }
    }
}
