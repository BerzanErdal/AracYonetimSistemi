using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracYonetimSistemi
{
    public class Airplane:Vehicle,ISurulebilen
    {
        public short YolcuKapasitesi {  get; set; }
        public short MotorSayisi {  get; set; }
        public Airplane(string marka, string model, short yil, string yakit,short yolcukapasitesi,short motorsayisi)
        : base(marka, model, yil, yakit) 
        { 
            YolcuKapasitesi = yolcukapasitesi;
            MotorSayisi = motorsayisi;
        }
        public override string GetInfo()
        {
            return $" Marka:{Marka}\n Model:{Model}\n Yıl:{Yil}\n" +
                $" Yakıt:{Yakit}\n Yolcu Kapasitesi:{YolcuKapasitesi} Kisi\n" +
                $" Motor Sayısı:{MotorSayisi} Adet";
        }

        public string SurulebilenYer()
        {
            return $"{Marka} havada sürülür";
        }
    }
}
