using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracYonetimSistemi
{
    public class VehicleManager
    {
        private List<Vehicle> vehicles; 
        private Dictionary<Vehicle, string> vehicleStatus; // Araçların durumlarını tutar

        public VehicleManager()
        {
            vehicles = new List<Vehicle>();
            vehicleStatus = new Dictionary<Vehicle, string>();
        }

        // Araç ekleme metodu
        public void AddVehicle(Vehicle vehicle)
        {
            vehicles.Add(vehicle);
            vehicleStatus[vehicle] = "Satılık";

        }

        // Araç durumu güncelleme metodu
        public string UpdateVehicleStatus(Vehicle vehicle, string status)
        {
            if (vehicles.Contains(vehicle))
            {
               return vehicleStatus[vehicle] = status;
                
            }
            else
            {
               return"Araç bulunamadı.";
            }
        }

        // Araçları listeleme metodu
        public List<Vehicle> ListVehicles()
        {
            return vehicles;
        }

        //update Vehicle
        public bool UpdateVehicle(Vehicle oldVehicle, Vehicle updatedVehicle)
        {
            int index = vehicles.IndexOf(oldVehicle);
            if (index >= 0)
            {
                // Eski aracın durum bilgisini sakla
                string oldStatus = vehicleStatus.ContainsKey(oldVehicle) ? vehicleStatus[oldVehicle] : "Bilinmiyor";

                // Eski aracı listeden kaldır ve yeni aracı ekle
                vehicles[index] = updatedVehicle;

                // Durum bilgisini güncellenmiş araçla eşleştir
                vehicleStatus.Remove(oldVehicle); // Eski referansı kaldır
                vehicleStatus[updatedVehicle] = oldStatus; // Yeni araçla eşleştir

                return true; // Güncelleme başarılı
            }
            return false; // Güncelleme başarısız
        }

        public string GetVehicleStatus(Vehicle vehicle)
        {
            if (vehicleStatus.ContainsKey(vehicle))
            {
                return vehicleStatus[vehicle];
            }
            return "Durum bilinmiyor"; // Eğer araç durum bilgisi yoksa
        }

    }

}

