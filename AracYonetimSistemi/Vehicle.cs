using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AracYonetimSistemi
{
    public abstract class Vehicle
    {
        public string Marka {  get; set; }
        public string Model {  get; set; }
        public short Yil {  get; set; }
        public string Yakit {  get; set; }

        public Vehicle(string marka, string model, short yil, string yakit)
        {
            Marka = marka;
            Model = model;
            Yil = yil;
            Yakit = yakit;
        }

        public abstract string GetInfo();
    }
}
