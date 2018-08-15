using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Csharp4._3Enum
{
    class Program
    {
        static void Main(string[] args)
        {

            DatabaseLogicLayer Dll=new DatabaseLogicLayer();


        DatabaseKayitIslemleri gelenDeger=Dll.Kaydet();

            switch (gelenDeger)
            {
                case DatabaseKayitIslemleri.Basarili:
                    break;
                case DatabaseKayitIslemleri.Basarisiz:
                    break;
                case DatabaseKayitIslemleri.HataOlustu:
                    break;
                default:
                    break;
            }
        }
    }
}
