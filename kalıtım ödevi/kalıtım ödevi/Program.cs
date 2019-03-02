using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalıtım_ödevi
{
    class BABA
    {
        public string ad;
        public string soyad;
        public string meslek;
        public int yaş;
        public int dogumyili;
        public void yazdır()
        {
            Console.WriteLine("--------------BABA--------------" + "\nAD:" + ad + "\nSOYAD:" + soyad + "\nMESLEK:" + meslek + "\nYAŞ:"+yaş + "\nDUGUMYILI:" + dogumyili);
        }
    }
    class ANNE : BABA
    {
        public string ad2;
        public string soyad2;
        public string meslek2;
        public int yaş2;
        public int dogumyili2;
        public void yazdır2()
        {
            Console.WriteLine("--------------ANNE--------------" + "\nAD:" + ad2 + "\nSOYAD:" + soyad2 + "\nMESLEK:" + meslek2 + "\nYAŞ:"+yaş2 + "\nDUGUMYILI:" + dogumyili2);
        }

    }
    class KARDEŞLER : ANNE
    {
        public string ad3;
        public string soyad3;
        public string meslek3;
        public int yaş3;
        public int dogumyili3;
        public void yazdır3()
        {
            Console.WriteLine("--------------KARDEŞ--------------" + "\nAD:" + ad3 + "\nSOYAD:" + soyad3 + "\nMESLEK:" + meslek3 + "\nYAŞ:"+yaş3 + "\nDUGUMYILI:" + dogumyili3);
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            BABA baba = new BABA();
            baba.ad = "öMER";
            baba.soyad = "Oruç";
            baba.meslek = "Serbest meslek";
            baba.yaş = 47;
            baba.dogumyili = 1971;
            baba.yazdır();
            ANNE anne = new ANNE();
            anne.ad2 = "Neslihan";
            anne.soyad2 = "Oruç";
            anne.meslek2 = "Öğretmen";
            anne.yaş2 = 42;
            anne.dogumyili2 = 1976;
            anne.yazdır2();
            KARDEŞLER kardeşler = new KARDEŞLER();
            kardeşler.ad3 = "Ahmet";
            kardeşler.soyad3 = "Oruç";
            kardeşler.meslek3 = "Öğrenci";
            kardeşler.yaş3 = 15;
            kardeşler.dogumyili3 = 2003;
            kardeşler.yazdır3();
        }
    }
}
