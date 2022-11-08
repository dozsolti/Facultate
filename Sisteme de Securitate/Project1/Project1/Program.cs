using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(PasswordGenerator.Generate());
            Console.WriteLine(PasswordGenerator.Generate(Level.STRONG));
            Console.WriteLine(PasswordGenerator.Generate(Level.STRONG));
            Console.WriteLine(PasswordGenerator.Generate(Level.WEAK));
            Console.WriteLine(PasswordGenerator.Generate(Level.WEAK));
            Console.WriteLine(PasswordGenerator.Generate());

            Console.ReadKey();
        }
    }
}
