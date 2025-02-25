using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracYonetimSistemi
{
    public class Truck:Vehicle,ISurulebilen
    {
        public short YukKapasitesi {  get; set; }
        public Truck(string marka,string model,short yil,string yakit,short yukkapasitesi)
        :base(marka,model,yil,yakit)
        { 
            YukKapasitesi = yukkapasitesi;
        }
        public override string GetInfo()
        {
             return $" Marka:{Marka}\n Model:{Model}\n Yıl:{Yil}\n" +
                $" Yakıt:{Yakit}\n Yük Kapasitesi:{YukKapasitesi} Ton ";
        }
        public string SurulebilenYer()
        {
            return $"{Model} karada sürülür";
        }
    }
}
