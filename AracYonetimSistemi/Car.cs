using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracYonetimSistemi
{
    public class Car:Vehicle,ISurulebilen
    {
        public short YolcuKapasitesi {  get; set; }
        public bool TurboControl {  get; set; }

        public Car(string marka, string model, short yil, string yakit, short yolcukapasitesi, bool turboControl)
        : base(marka, model, yil, yakit)
        {
            YolcuKapasitesi = yolcukapasitesi;
            TurboControl = turboControl;
        }

        public override string GetInfo()
        {
            return $" Marka:{Marka}\n Model:{Model}\n Yıl:{Yil}\n" +
                $" Yakıt:{Yakit}\n Yolcu Kapasitesi:{YolcuKapasitesi} Kisi";//turbocontolü sonradan çağırıcam
        }
        public string SurulebilenYer()
        {
            return $"{Model} karada sürülür";
        }
    }
}
