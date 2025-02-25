using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracYonetimSistemi
{
    public partial class AnaSayfa : Form
    {
        private VehicleManager vehicleManager;

        public AnaSayfa()
        {
            vehicleManager = new VehicleManager();
            InitializeComponent();
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {

            Car car1 = new Car("BMW", "M1", 2018, "Benzin", 12, false);
            Car car2 = new Car("BMW", "M3", 2020, "Benzin", 12, true);
            Truck truck1 = new Truck("Audi", "5R", 2019, "Benzin", 45);
            Boat boat1 = new Boat("Yamaha", "WaveRunner", 2021, "Benzin", "Eğlence", 3); 
            Airplane air1 = new Airplane("Boeing", "747", 2018, "Jet", 416, 4);

            // Araçları yönetime ekle
            vehicleManager.AddVehicle(car1);
            vehicleManager.AddVehicle(truck1);
            vehicleManager.AddVehicle(boat1);
            vehicleManager.AddVehicle(air1);
            vehicleManager.AddVehicle(car2);

            // Araçları TreeView içinde listele
            ListVehiclesToTreeView(treeView1);
        }
        private void ListVehiclesToTreeView(TreeView treeView)
        {
            // TreeView içeriğini temizle
            treeView.Nodes.Clear();

            // Türlere göre ana düğümleri oluştur
            TreeNode carsNode = new TreeNode("Cars");
            TreeNode trucksNode = new TreeNode("Trucks");
            TreeNode boatsNode = new TreeNode("Boats");
            TreeNode airplanesNode = new TreeNode("Airplanes");

            // Araçları türlerine göre uygun düğümlere ekle
            foreach (var vehicle in vehicleManager.ListVehicles())
            {
                string vehicleInfo = vehicle.GetInfo();
                // Araç durumu, VehicleManager'dan alınacak
                string Durum = vehicleManager.GetVehicleStatus(vehicle);
                if (vehicle is Car car)
                {
                    // Car için alt düğüm oluştur
                    string turboStatus = car.TurboControl ? "Turbo: Var" : "Turbo: Yok";
                    string details = $"{vehicleInfo}, {turboStatus},Arac Durumu:{Durum}";
                    carsNode.Nodes.Add(details);
                }
                else if (vehicle is Truck)
                {
                    string details = $"{vehicleInfo},Arac Durumu:{Durum}";
                    trucksNode.Nodes.Add(details);
                }
                else if (vehicle is Boat)
                {
                    // Boat için alt düğüm oluştur
                    string details = $"{vehicleInfo},Arac Durumu:{Durum}";
                    boatsNode.Nodes.Add(details);
                }
                else if (vehicle is Airplane)
                {
                    // Airplane için alt düğüm oluştur
                    string details = $"{vehicleInfo},Arac Durumu:{Durum}";
                    airplanesNode.Nodes.Add(details);
                }
            }

            // Ana düğümleri TreeView'e ekle
            if (carsNode.Nodes.Count > 0) treeView.Nodes.Add(carsNode);
            if (trucksNode.Nodes.Count > 0) treeView.Nodes.Add(trucksNode);
            if (boatsNode.Nodes.Count > 0) treeView.Nodes.Add(boatsNode);
            if (airplanesNode.Nodes.Count > 0) treeView.Nodes.Add(airplanesNode);

            // TreeView'i genişlet
            treeView.ExpandAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }
        private void FilterVehiclesInTreeView(string secim)
        {
            // TreeView'i temizle
            treeView1.Nodes.Clear();

            // Eğer boş bir seçim varsa, tüm araçları göster
            if (string.IsNullOrWhiteSpace(secim))
            {
                ListVehiclesToTreeView(treeView1); // Mevcut tüm araçları gösteren metodu çağır
                return;
            }

            // Seçime göre araçları filtrele
            var filteredVehicles = vehicleManager.ListVehicles()
                .Where(vehicle =>
                    (secim == "Car" && vehicle is Car) ||
                    (secim == "Truck" && vehicle is Truck) ||
                    (secim == "Boat" && vehicle is Boat) ||
                    (secim == "Airplane" && vehicle is Airplane))
                .ToList();

            // Ana düğümü oluştur
            TreeNode filteredNode = new TreeNode($"{secim}s");

            foreach (var vehicle in filteredVehicles)
            {
                string vehicleInfo = $"Marka:{vehicle.Marka} Model:{vehicle.Model} - Yıl:{vehicle.Yil} Yakıt:{vehicle.Yakit}";
                string Durum = vehicleManager.UpdateVehicleStatus(vehicle, "Satılık");
                if (vehicle is Car car)
                {
                    string turboStatus = car.TurboControl ? "Turbo: Var" : "Turbo: Yok";
                    string details = $"{vehicleInfo} {turboStatus},Arac Durumu:{Durum}";
                    filteredNode.Nodes.Add(details);
                }
                else if (vehicle is Truck)
                {
                    string details = $"{vehicleInfo},Arac Durumu:{Durum}";
                    filteredNode.Nodes.Add(details);
                }
                else if (vehicle is Boat boat)
                {
                    string details = $"{vehicleInfo},Arac Durumu:{Durum}";
                    filteredNode.Nodes.Add(details);
                }
                else if (vehicle is Airplane airplane)
                {
                    string details = $"{vehicleInfo},Arac Durumu:{Durum}";
                    filteredNode.Nodes.Add(details);
                }
            }

            // Filtrelenen araç düğümünü TreeView'e ekle
            if (filteredNode.Nodes.Count > 0)
            {
                treeView1.Nodes.Add(filteredNode);
            }

            // Tüm düğümleri genişlet
            treeView1.ExpandAll();
        }

        private void comboBoxAracFiltreleme_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secim=comboBoxAracFiltreleme.Text;
            FilterVehiclesInTreeView(secim);
        }
    }
}
