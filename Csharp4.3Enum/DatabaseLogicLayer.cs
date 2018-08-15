using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp4._3Enum
{
    class DatabaseLogicLayer
    {//enumlar hata ayıklama da çok işe yarar burada işlemlerin sağlanıp sağlanmadığı hangi hatadab dolayı oluştuğu kontrol edilebilir.

        //ENumları kullanarak kod daha anlaşılarbilir bir hal alır.
        //Burada değerleri istediğimiz gibi girebiliriz .İstenilen olumlı veya olumsuz sonuçlara sayı atayıp anlaşılabilir olmasını sağlarız.
        public DatabaseKayitIslemleri Kaydet()
        {


            int sonuc = 1;
            return sonuc > 0 ? DatabaseKayitIslemleri.Basarili : DatabaseKayitIslemleri.Basarisiz;
        }

        public DatabaseKayitIslemleri Guncelle()
        {

            int sonuc = 0;
            return sonuc > 0 ? DatabaseKayitIslemleri.Basarili : DatabaseKayitIslemleri.Basarisiz;
        }

        public DatabaseKayitIslemleri Sil()
        {


            int sonuc = -1;

            return sonuc < 0 ? DatabaseKayitIslemleri.HataOlustu : DatabaseKayitIslemleri.Basarisiz;
        }

    }

    enum DatabaseKayitIslemleri
    {
        //istenilen değerleri buradan verebilirsin .BAsarili=1111;
        Basarili,Basarisiz,HataOlustu
    }
}
