using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Araba
    {
        public int hiz;
        public string model;

        public int hizlandir(int a)
        {
            hiz = hiz + a;
            return hiz;
           

        }
        public int yavaşlat(int b)
        {
            hiz = hiz - b;
            return hiz;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Araba benimarabam = new Araba();
            benimarabam.hiz = 0;
            benimarabam.model = "BMW";
            benimarabam.hizlandir(30);
            benimarabam.hizlandir(15);

            int yenihiz = 0;
            yenihiz = benimarabam.hizlandir(10);
            Console.WriteLine("Hızınız:" + yenihiz);
            Console.WriteLine("Arabanın modeli:" + benimarabam.model);

            if (yenihiz > 50)
            {
                
                yenihiz = benimarabam.yavaşlat(10);
                Console.WriteLine("Hızınız 10km düşürüldü\nYeni hızınız:" + yenihiz);
            }

            
        }
    }
}
