using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp4._0_Nesnedp
{
    class Program
    {

        //private: Bulunduğu class içerisinde kullanılır dış dünya tarafından kullanılamaz.
        //Başında erişim belirleyicisi olmayan het tanım private olarak kullanılır.
        //public:Tanımlandığı class içerisindede kullanılır dış dünyada da kullanılır.

        //Internal :class ın üzerinde tanımlanır.
        //Bulunduğu Namespace içerisinde erişilebilir.Farklı namespacelerden erişilemez.
        //Protected olarak belirtilen Erişim belirleyicisi bulunduğu class içerisinde ve kendisinden kalıtılan classlar içerisinde kullanılır.
        
        static void Main(string[] args)
        {
            Musteri M1=new Musteri();


            M1.MusteriId = 1;
            M1.MusteriAdi = "onur";


          


        }


    }

    class Musteri
    {
        //Yapıcı metot içerisinde class new lendiği zaaman istenilen ilk değerlerin ilk işlemlerin yapılmasını sağlar.
        //New işlemi başlarken yapıcı metot çalıştırılıe sonra new tamamlanır. 
        public Musteri()
        {


        }

        public int MusteriId { get; set; }
        public string MusteriAdi { get; set; }

      


    }
    //Kapsülleme işlemi 
    class Ogrenci
    {
        //Kapsülleme işlmeinde tanımlamalara direk erişim yapılmamakla birlikte bir filtreden geçirilerek işlemler yapılır.
        //Bunun için erişilemeyen tanımlamalara yapıcı metot üzerinden erişilileblir ancak bunlar kapsülleme değildir kapsülleme için gerekli işlemler burada yapılablir.
        public Ogrenci(string _ogrenciAdi,string _ogrenciSoyad,int _numara)
        {
            this.Numara = _numara;
            this.OgrenciAdi = _ogrenciAdi;
            this.OgrenciSoyad = _ogrenciSoyad;


        }


        private string OgrenciAdi { get; set; }
        private string  OgrenciSoyad { get; set; }
        private int  Numara { get; set; }
    }


}
