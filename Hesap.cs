using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankamatikProje
{
   public  class Hesap
    {
        //Constracter
        public Hesap()
        {
            Bakiye = 100;
        }
        //Encapsulation
        private int _bakiye;
        public  int Bakiye
        {
            get
            {
                return _bakiye;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Bakiye Sıfır Olamaz");
                }
                _bakiye = value;
            }
        }

        public  void ParaCek()
        {
            Bakiye = Bakiye - 10; //parayı hesaptan düştük
        }
        public  void ParaYatir()
        {
            Bakiye = Bakiye + 10; //para
        }
    }
}
