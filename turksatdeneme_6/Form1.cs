using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Windows.Forms;
using System.Diagnostics;

namespace turksatdeneme_6
{
    public partial class Form1 : Form
    {
        private FilterInfoCollection webcam; //webcam isminde tanımladığımız değişken bilgisayara kaç kamera bağlıysa onları tutan bir dizi.
        private VideoCaptureDevice cam; //cam ise bizim kullanacağımız aygıt.

        public Form1()
        {
            InitializeComponent();
        }

        void cam_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bmp = (Bitmap)eventArgs.Frame.Clone(); //kısaca bu eventta kameradan alınan görüntüyü picturebox a atıyoruz.
            pcbVideo.Image = bmp;
        }
        private void Cek_Click(object sender, EventArgs e)
        {
            SaveFileDialog swf = new SaveFileDialog();
            swf.Filter = "(*.jpg)|*.jpg|Bitma*p(*.bmp)|*.bmp";
            DialogResult dialog = swf.ShowDialog();  //resmi çekiyoruz ve aşağıda da kaydediyoruz.

            if (dialog == DialogResult.OK)
            {
                pcbVideo.Image.Save(swf.FileName);
            }

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

            webcam = new 
            FilterInfoCollection(FilterCategory.VideoInputDevice); //webcam dizisine mevcut kameraları dolduruyoruz.
            foreach (FilterInfo item in webcam)
            {
                comboBox1.Items.Add(item.Name); //kameraları combobox a dolduruyoruz.
            }
            comboBox1.SelectedIndex = 0;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = Telemetri.GetAll();


        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            cam = new
            VideoCaptureDevice(webcam[comboBox1.SelectedIndex].MonikerString); //başlaya basıldığıdnda yukarda tanımladığımız cam değişkenine comboboxta seçilmş olan kamerayı atıyoruz.
            cam.NewFrame += new NewFrameEventHandler(cam_NewFrame);
            cam.Start(); //kamerayı başlatıyoruz.
        }

        private void btnStop_Click(object sender, EventArgs e)
        {

            if (cam.IsRunning)
            {
                cam.Stop(); // kamerayı durduruyoruz.
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void tmrRefresh_Tick(object sender, EventArgs e)
        {
          //  Telemetri.Add(new Telemetri {Basinc=12, Donus_Sayisi=315 ,Roll=365, GPS_Long=234, Gonderme_Zamani= DateTime.Now
            //, GPS_Lot= 3654, Inis_Hizi=3657, Paket_No=5372, Pil_Gerilimi=457, Pitch=357, RPM=34, Sicaklik=537, Yaw=12456, Yukseklik=1456});
        }

        private void Sayfa2_Click(object sender, EventArgs e)
        {

        }
    }
}
