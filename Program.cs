using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Pizda
{
    class Program
    {
        private const ConsoleColor red = ConsoleColor.Red;

        static void Main(string[] args)
        {
            Console.WriteLine("Ку епта, че за имя у тебя?");
            string yourName = Console.ReadLine();
            Console.WriteLine($"У {yourName} мать в канаве");
            Console.ReadLine();

        }
    }
}
