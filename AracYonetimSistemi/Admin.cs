using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace AracYonetimSistemi
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private VehicleManager vehicleManager = new VehicleManager();
        
        private void Admin_Load(object sender, EventArgs e)
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

            ListVehiclesToTreeView(treeView1);
        }
        private void ListVehiclesToTreeView(TreeView treeView)
        {
            // TreeView'i temizle
            treeView.Nodes.Clear();

            // Ana düğümleri oluştur
            TreeNode carsNode = new TreeNode("Cars");
            TreeNode trucksNode = new TreeNode("Trucks");
            TreeNode boatsNode = new TreeNode("Boats");
            TreeNode airplanesNode = new TreeNode("Airplanes");

            
            // Araçları türlerine göre uygun düğümlere ekle
            foreach (var vehicle in vehicleManager.ListVehicles())
            {
                string vehicleInfo = vehicle.GetInfo();

                // Araç durumunu VehicleManager'dan al
                string aracDurumu = vehicleManager.GetVehicleStatus(vehicle);

                if (vehicle is Car car)
                {
                    string turboStatus = car.TurboControl ? "Turbo: Var" : "Turbo: Yok";
                    string details = $"{vehicleInfo}, {turboStatus},Durum:{aracDurumu}";
                    carsNode.Nodes.Add(details);
                }

                else if (vehicle is Truck)
                {
                    string details = $"{vehicleInfo},Durum:{aracDurumu}";
                    trucksNode.Nodes.Add(details);
                }
                else if (vehicle is Boat)
                {
                    // Boat için alt düğüm oluştur
                    string details = $"{vehicleInfo},Durum:{aracDurumu}";
                    boatsNode.Nodes.Add(details);
                }
                else if (vehicle is Airplane)
                {
                    // Airplane için alt düğüm oluştur
                    string details = $"{vehicleInfo},Durum:{aracDurumu}";
                    airplanesNode.Nodes.Add(details);
                }
            }

            // Ana düğümleri TreeView'e ekle
            if (carsNode.Nodes.Count > 0) treeView.Nodes.Add(carsNode);
            if (trucksNode.Nodes.Count > 0) treeView.Nodes.Add(trucksNode);
            if (boatsNode.Nodes.Count > 0) treeView.Nodes.Add(boatsNode);
            if (airplanesNode.Nodes.Count > 0) treeView.Nodes.Add(airplanesNode);

            // Tüm düğümleri açık hale getir
            treeView.ExpandAll();
        }


        private void buttonEkle_Click(object sender, EventArgs e)
        {
            string secim = comboBoxAracTürü.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(secim))
            {
                MessageBox.Show("Lütfen bir araç türü seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Ortak bilgiler
                string marka = textBoxMarka.Text;
                string model = textBoxModel.Text;
                short yil = short.Parse(textBoxYil.Text);
                string yakit = textBoxYakit.Text;
                string aracdurumu=textBoxAracDurumu.Text;


                switch (secim)
                {
                    case "Car":
                        {
                            short yolcuKapasitesi = short.Parse(panel1.Controls["textBoxYolcuKapasite"].Text);
                            bool turboVarMi = ((CheckBox)panel1.Controls["chkTurboControl"]).Checked;
                            
                            Car yeniArac = new Car(marka, model, yil, yakit, yolcuKapasitesi, turboVarMi);
                            vehicleManager.AddVehicle(yeniArac);
                            vehicleManager.UpdateVehicleStatus(yeniArac, aracdurumu);
                            ListVehiclesToTreeView(treeView1);
                            MessageBox.Show($"Marka:{yeniArac.Marka} Model:{yeniArac.Model} {yeniArac.SurulebilenYer()}  Başarıyla Eklendi.");
                            textboxtemizle();
                            break;
                        }

                    case "Truck":
                        {
                            short yukKapasitesi = short.Parse(panel1.Controls["textBoxYukKapasitesi"].Text);

                            Truck yeniArac = new Truck(marka, model, yil, yakit, yukKapasitesi);
                            vehicleManager.AddVehicle(yeniArac);
                            vehicleManager.UpdateVehicleStatus(yeniArac, aracdurumu);
                            ListVehiclesToTreeView(treeView1);
                            MessageBox.Show($"Marka:{yeniArac.Marka} Model:{yeniArac.Model} {yeniArac.SurulebilenYer()}  Başarıyla Eklendi.");
                            textboxtemizle();
                            break;
                        }

                    case "Boat":
                        {
                            string kullanimAmaci = panel1.Controls["textBoxKulanimAmaci"].Text;
                            short uzunluk = short.Parse(panel1.Controls["textBoxUzunluk"].Text);

                            Boat yeniArac = new Boat(marka, model, yil, yakit, kullanimAmaci, uzunluk);
                            vehicleManager.AddVehicle(yeniArac);
                            vehicleManager.UpdateVehicleStatus(yeniArac, aracdurumu);
                            ListVehiclesToTreeView(treeView1);
                            MessageBox.Show($"Marka:{yeniArac.Marka} Model:{yeniArac.Model} {yeniArac.SurulebilenYer()}  Başarıyla Eklendi.");
                            textboxtemizle();
                            break;
                        }

                    case "Airplane":
                        {
                            short yolcuKapasitesi = short.Parse(panel1.Controls["textBoxYolcuKapasite"].Text);
                            short motorSayisi = short.Parse(panel1.Controls["textBoxMotorSayisi"].Text);

                            Airplane yeniArac = new Airplane(marka, model, yil, yakit, yolcuKapasitesi, motorSayisi);
                            vehicleManager.AddVehicle(yeniArac);
                            vehicleManager.UpdateVehicleStatus(yeniArac, aracdurumu);
                            ListVehiclesToTreeView(treeView1);
                            MessageBox.Show($"Marka:{yeniArac.Marka} Model:{yeniArac.Model} {yeniArac.SurulebilenYer()}  Başarıyla Eklendi.");
                            textboxtemizle();
                            break;
                        }

                    default:
                        MessageBox.Show("Bilinmeyen araç türü!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Geçersiz değer girdiniz: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textboxtemizle()
        {
            textBoxMarka.Text = textBoxModel.Text = textBoxYil.Text = textBoxYakit.Text =textBoxAracDurumu.Text=comboBoxAracTürü.Text="";
            foreach (Control ctrl in panel1.Controls)
            {
                if (ctrl is TextBox textBox)
                    textBox.Text = "";
                else if (ctrl is CheckBox checkBox)
                    checkBox.Checked = false;
            }
            comboBoxAracTürü.Focus();
        }

        private void comboBoxAracTürü_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            string secim = comboBoxAracTürü.SelectedItem.ToString();
            if (!string.IsNullOrEmpty(secim)) {
                if (secim == "Car")
                {
                    AddTextBoxToPanel("Yolcu Kapasite","textBoxYolcuKapasite", 30);
                    AddCheckBoxToPanel("Turbo Kontrol", "chkTurboControl", 80);
                }
                else if(secim == "Truck")
                {
                    AddTextBoxToPanel("Yük Kapasitesi", "textBoxYukKapasitesi", 30);
                }
                else if(secim == "Boat")
                {
                    AddTextBoxToPanel("Kulanim Amaci", "textBoxKulanimAmaci", 30);
                    AddTextBoxToPanel("Uzunluk", "textBoxUzunluk", 80);
                }
                else if(secim == "Airplane")
                {
                    AddTextBoxToPanel("Yolcu Kapasite", "textBoxYolcuKapasite", 30);
                    AddTextBoxToPanel("Motor Sayısı", "textBoxMotorSayisi", 80);
                }
            }


        }
        //Panele TextBox Ekleme
        private void AddTextBoxToPanel(string labelText, string textBoxName, int yPosition)
        {
            // Label oluştur
            Label label = new Label
            {
                Text = labelText,
                Location = new Point(10, yPosition),
                AutoSize = true,
                BackColor= Color.White,
                ForeColor= Color.Blue,
            };

            // TextBox oluştur
            TextBox textBox = new TextBox
            {
                Name = textBoxName,
                Location = new Point(90, yPosition),
                Width = 150,
                BackColor = Color.White,
                ForeColor = Color.Black,
               
                
            };

            // Panel'e ekle
            panel1.Controls.Add(label);
            panel1.Controls.Add(textBox);
        }

        //Panele CheckBox Ekleme
        private void AddCheckBoxToPanel(string labelText, string checkBoxName, int yPosition)
        {
            CheckBox checkBox = new CheckBox
            {
                Text = labelText,
                Name = checkBoxName,
                Location = new Point(10, yPosition),
                BackColor = Color.AliceBlue,
                AutoCheck = true,
            };
            panel1.Controls.Add(checkBox);
        }

        private void comboBoxAracFiltreleme_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secim=comboBoxAracFiltreleme.Text;
            FilterVehiclesInTreeView(secim);
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
                string aracDurumu = vehicleManager.GetVehicleStatus(vehicle);
                if (vehicle is Car car)
                {
                    string turboStatus = car.TurboControl ? "Turbo: Var" : "Turbo: Yok";
                    string details = $"{vehicleInfo} {turboStatus},Durum:{aracDurumu}";
                    filteredNode.Nodes.Add(details);
                }
                else if (vehicle is Truck )
                {
                    string details = $"{vehicleInfo},Durum:{aracDurumu}";
                    filteredNode.Nodes.Add(details);
                }
                else if (vehicle is Boat boat)
                {
                    string details = $"{vehicleInfo},Durum:{aracDurumu}";
                    filteredNode.Nodes.Add(details);
                }
                else if (vehicle is Airplane airplane)
                {
                    string details = $"{vehicleInfo},Durum:{aracDurumu}";
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

        private void buttonGüncelle_Click(object sender, EventArgs e)
        {
           if (treeView1.SelectedNode != null)
                {
                    string selectedVehicle = treeView1.SelectedNode.Text;

                    // Seçilen aracın detaylarını al
                    Vehicle vehicleToUpdate = vehicleManager.ListVehicles()
                        .FirstOrDefault(v => selectedVehicle.Contains(v.Marka) && selectedVehicle.Contains(v.Model));

                    if (vehicleToUpdate != null)
                    {
                        // Güncelleme formundan gelen değerler
                        string yeniMarka = textBoxMarka.Text;
                        string yeniModel = textBoxModel.Text;
                        short yeniYil = short.Parse(textBoxYil.Text);
                        string yeniYakit = textBoxYakit.Text;
                        string aracdurumu=textBoxAracDurumu.Text;

                        // Araç türüne göre güncellenmiş nesne oluştur
                        Vehicle updatedVehicle = null;

                        if (vehicleToUpdate is Car car)
                        {
                            bool yeniTurbo = ((CheckBox)panel1.Controls["chkTurboControl"]).Checked;
                            short yeniYolcuKapasite = short.Parse(panel1.Controls["textBoxYolcuKapasite"].Text);

                            updatedVehicle = new Car(yeniMarka, yeniModel, yeniYil, yeniYakit, yeniYolcuKapasite, yeniTurbo);
                            vehicleManager.UpdateVehicleStatus(car, aracdurumu);
                        }
                        else if (vehicleToUpdate is Truck truck)
                        {
                            short yeniYukKapasite = short.Parse(panel1.Controls["textBoxYukKapasitesi"].Text);
                            updatedVehicle = new Truck(yeniMarka, yeniModel, yeniYil, yeniYakit, yeniYukKapasite);
                            vehicleManager.UpdateVehicleStatus(truck, aracdurumu);
                    }
                        else if (vehicleToUpdate is Boat boat)
                        {
                            string yeniKullanimAmaci = panel1.Controls["textBoxKulanimAmaci"].Text;
                            short yeniUzunluk = short.Parse(panel1.Controls["textBoxUzunluk"].Text);
                            updatedVehicle = new Boat(yeniMarka, yeniModel, yeniYil, yeniYakit, yeniKullanimAmaci, yeniUzunluk);
                            vehicleManager.UpdateVehicleStatus(boat, aracdurumu);
                    }
                        else if (vehicleToUpdate is Airplane airplane)
                        {
                            short yeniYolcuKapasite = short.Parse(panel1.Controls["textBoxYolcuKapasite"].Text);
                            short yeniMotorSayisi = short.Parse(panel1.Controls["textBoxMotorSayisi"].Text);
                            updatedVehicle = new Airplane(yeniMarka, yeniModel, yeniYil, yeniYakit, yeniYolcuKapasite, yeniMotorSayisi);
                            vehicleManager.UpdateVehicleStatus(airplane, aracdurumu);
                    }

                        // Güncelleme işlemi
                        if (updatedVehicle != null && vehicleManager.UpdateVehicle(vehicleToUpdate, updatedVehicle))
                        {
                            MessageBox.Show("Araç bilgileri güncellendi.");
                            ListVehiclesToTreeView(treeView1);
                            textboxtemizle();
                        }
                        else
                        {
                            MessageBox.Show("Araç güncellenemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            textboxtemizle();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen bir araç seçin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textboxtemizle();
                }
        }
    }
}
