using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp4._2Statik
{
    class Program
    {
        static void Main(string[] args)
        {

            Personel p1=new Personel();


            p1.Isim = "john";
            p1.Soyisim = "doe";


            //burada nesne oluşturmadan erişebildik .çünkü değişken statiktir.
            Personel.FirmaAdi = "oss";


            Console.ReadLine();
        }
    }
    //Statik sınıflar örnekleenmez yani EmailGonder E1=new EmailGonder(); işlemini statik sınıf ile yapamayız.
    //Nokta operatörü ile ulaşabiliriz.
    static class EmailGonder
    {



    }
    class Personel
    {
        public Personel()
        {
            Console.WriteLine("Yapıcı metot çalıştı.");
        }
        //erişim belirleyicisine ihtiyaç yoktur. çünkü statik olduğunda kendisi içerde çalışır.
        static Personel()
        {
            Console.WriteLine("Statik yapıcı metot çalıştı.");

        }

        public string Isim { get; set; }
        public string Soyisim { get; set; }

        //değişken statik olduğunda örneklemeden erişilebilir.Yani nesne olulşturmamıza gerek yoktur.
        public static string FirmaAdi { get; set; }
            


        
    }
}
