using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int sayi = 10; sayi <= 100; sayi++)
            {
                Console.WriteLine("Sayı değeri:" + sayi);
                if (sayi == 52)
                {
                    Console.WriteLine("İşlem tamam");
                    break;
                }

            }
            Console.ReadLine();
           
          


            
        }
        
    }
}
