using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_40_arasında_5e_bölünen
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 40; i++)
            {
                int bölüm = i % 5;
                if (bölüm == 0)
                {
                    Console.WriteLine(i + " 5'e bölünür");
                }
                else
                {
                    Console.WriteLine(i + " 5'e bölünmez");
                }
                
            }
        }
    }
}
