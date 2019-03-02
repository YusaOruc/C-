using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_100_arasındaki_sayıları_toplama
{
    class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0;
            int i = 0;
            while (i <= 100)
            {
                toplam = toplam + i;
                i = i + 1;
            }
            Console.WriteLine(toplam);
        }
    }
}
