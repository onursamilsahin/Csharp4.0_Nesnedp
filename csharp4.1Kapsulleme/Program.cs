using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp4._1Kapsulleme
{
    class Program
    {
        static void Main(string[] args)
        {

            Musteri M1=new Musteri();

            M1._isim = "john";
            M1._soyisim = "doe";
            M1._musteriNumarasi = 1;
            M1._tcKimlikNo = "111111111111";



        }
    }

    class Musteri
    {


        private int MusteriNo;
        private string Isim;
        private string Soyisim;
        private string TcKimlikNo;

        private Guid MusteriId;
        // kapsülleme
        //set ile data yı değişkene atama yaparım. get ile veriyi çekerim.
        //set this.tanımlama=value
        //public tip tanım {get;} yaparak sadece dışarı data yı verebilirim .
        //public tip tanım {set;} yaparak ta dışarda data alabilirim.

            //Yapıcı metot
        public Musteri()
        {
            MusteriId = Guid.NewGuid();
        }
        public Guid _musteriId
        {
            get { return this.MusteriId;  }
        }

        public int _musteriNumarasi
        {

            get { return MusteriNo; }
            set { this.MusteriNo = value;}
        }


        public string _isim
        {

            get { return Isim;}
            set { this.Isim = value; }
        }

        public string _soyisim
        {

            get { return Soyisim; }
            set { this.Soyisim = value; }

        }

        public string _tcKimlikNo
        {
            get { return "++"+TcKimlikNo.Substring(2); }
            set
            {
                if (value.Length==12)
                {
                    this.TcKimlikNo = value;
                }
                else
                {
                    this.TcKimlikNo = string.Empty;
                }
                
            }

        }



    }
}
