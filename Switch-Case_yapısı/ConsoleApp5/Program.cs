using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1,2 ve 3 numaralardan birini seçiniz:");

            string x = Console.ReadLine();
            switch (x)
            {
                case "1":
                    Console.WriteLine("500.000");
                    break;
                case "2":
                    Console.WriteLine("100.000");
                    break;
                case "3":
                    Console.WriteLine("5.000");
                    break;
                default:
                    Console.WriteLine("ggg");
                    break;
            }

        }

    }
}
