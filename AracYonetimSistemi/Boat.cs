using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracYonetimSistemi
{
    public class Boat:Vehicle,ISurulebilen
    {
        public string KulanimAmaci {  get; set; }
        public short Uzunluk {  get; set; }

        public Boat(string marka, string model, short yil, string yakit,string kulanimamaci,short uzunluk)
            :base(marka,model,yil,yakit)
        {
            KulanimAmaci = kulanimamaci;
            Uzunluk = uzunluk;
        }
        public override string GetInfo()
        {
            return $" Marka:{Marka}\n Model:{Model}\n Yıl:{Yil}\n" +
              $" Yakıt:{Yakit}\n Kulanım Amacı:{KulanimAmaci}\n Uzunluk:{Uzunluk} Metre";
        }
        public string SurulebilenYer()
        {
            return $"{Marka} Denizde sürülür";
        }
    }
}
