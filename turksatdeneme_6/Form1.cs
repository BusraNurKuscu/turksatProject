using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Windows.Forms;
using System.IO.Ports;
using System.Diagnostics;
using System.Threading;
using System.IO;

namespace turksatdeneme_6
{
    public partial class Form1 : Form
    {
        public bool IsClosed { get; private set; }
        private FilterInfoCollection webcam; //webcam isminde tanımladığımız değişken bilgisayara kaç kamera bağlıysa onları tutan bir dizi.
        private VideoCaptureDevice cam; //cam ise bizim kullanacağımız aygıt.

        //public object RowIndex { get; private set; }

        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            //com3 usb bağlıntısını kontrol ediyoruz ve bağlantının açılıp açılmadığını denetliyoruz
           
        }

        void Cam_NewFrame(object sender, NewFrameEventArgs eventArgs)
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

            //serial port verilerini dinliyoruz
           Thread Hilo = new Thread(ListenSerial);
            Hilo.Start();
            webcam = new
            FilterInfoCollection(FilterCategory.VideoInputDevice); //webcam dizisine mevcut kameraları dolduruyoruz.
            foreach (FilterInfo item in webcam)
            {
                comboBox1.Items.Add(item.Name); //kameraları combobox a dolduruyoruz.
            }
            comboBox1.SelectedIndex = 0;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ListenSerial()
        {


            while (!IsClosed)
            {
                try
                {
                    //xbee den dataları okuyoruz
                    string TelemetriPaketi = Port.ReadLine();

                    dataGridView1.Invoke(new MethodInvoker(
                        delegate
                        { dataGridView1.DataSource = TelemetriPaketi; }));

                }
                catch { }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            cam = new
            VideoCaptureDevice(webcam[comboBox1.SelectedIndex].MonikerString); //başlaya basıldığıdnda yukarda tanımladığımız cam değişkenine comboboxta seçilmş olan kamerayı atıyoruz.
            cam.NewFrame += new NewFrameEventHandler(Cam_NewFrame);
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

        private void tmrRefresh_Tick(object sender, EventArgs e)// timer ile gelen verileri saniyede bir yenilemeyi sağlayan fonksiyonumuz.
        {
            //4      Port.Open();
            //serialPort1.Write(dataGridView1.Rows[0].Cells[1].Value.ToString());
            string Sicaklik = Port.ReadExisting();
            dataGridView1.DataSource = Telemetri.GetAll();
                 if (Sicaklik != null && Sicaklik != "" && Sicaklik[0] != '.')
            Telemetri.Add(new Telemetri
            {

                Basinc = 2000,
                Donus_Sayisi = 315,
                Roll = 365,
                GPS_Long = 234,
                Gonderme_Zamani = DateTime.Now,
                Takim_No = 55502,
                GPS_Lot = 3654,
                Inis_Hizi = 3657,
                Paket_No = 5372,
                Pil_Gerilimi = 457,
                Pitch = 357,
                RPM = 34,
                Yaw = 12456,
                Yukseklik = 1456,
              //  Sicaklik = (SerialPort.GetPortNames())
            });
           
        }
        private void Sayfa2_Click(object sender, EventArgs e)
            {

            }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //form kapandığında veri akışını kapatıoruz.

            IsClosed = true;
            if (Port.IsOpen)
            Port.Close();
        }

      /* private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
           
        }*/

        private void Sayfa1_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_DataSourceChanged(object sender, EventArgs e)
        {
            txtBsn.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
            txtDns.Text = dataGridView1.Rows[0].Cells[13].Value.ToString();
            txtGnd.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
            txtGPSlg.Text = dataGridView1.Rows[0].Cells[8].Value.ToString();
            txtGPSlt.Text = dataGridView1.Rows[0].Cells[9].Value.ToString();
            txtPil.Text = dataGridView1.Rows[0].Cells[6].Value.ToString();
            txtPitch.Text = dataGridView1.Rows[0].Cells[10].Value.ToString();
            txtPkt.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
            txtRoll.Text = dataGridView1.Rows[0].Cells[11].Value.ToString();
            txtRPM.Text = dataGridView1.Rows[0].Cells[7].Value.ToString();
            txtSck.Text = dataGridView1.Rows[0].Cells[5].Value.ToString();
            txtTkm.Text = dataGridView1.Rows[0].Cells[14].Value.ToString();
            txtYaw.Text = dataGridView1.Rows[0].Cells[12].Value.ToString();
            txtHiz.Text = dataGridView1.Rows[0].Cells[4].Value.ToString();
            txtYks.Text = dataGridView1.Rows[0].Cells[3].Value.ToString();

            this.chtBsn.Series["Basınç"].Points.AddXY(dataGridView1.Rows[0].Cells[1].Value.ToString(),
                Convert.ToInt32(dataGridView1.Rows[1].Cells[2].Value.ToString()));
            this.chtDns.Series["Dönüş Sayısı"].Points.AddXY(dataGridView1.Rows[0].Cells[1].Value.ToString(),
                Convert.ToInt32(dataGridView1.Rows[1].Cells[13].Value.ToString()));
            this.chtGPSLg.Series["GPS Long"].Points.AddXY(dataGridView1.Rows[0].Cells[1].Value.ToString(),
                Convert.ToInt32(dataGridView1.Rows[1].Cells[8].Value.ToString()));
            this.chtGPSLt.Series["GPS Lot"].Points.AddXY(dataGridView1.Rows[0].Cells[1].Value.ToString(),
                Convert.ToInt32(dataGridView1.Rows[1].Cells[9].Value.ToString()));
            this.chtHiz.Series["İniş Hızı"].Points.AddXY(dataGridView1.Rows[0].Cells[1].Value.ToString(),
                Convert.ToInt32(dataGridView1.Rows[1].Cells[4].Value.ToString()));
            this.chtPil.Series["Pil Gerilimi"].Points.AddXY(dataGridView1.Rows[0].Cells[1].Value.ToString(), 
                Convert.ToInt32(dataGridView1.Rows[1].Cells[6].Value.ToString()));
            this.chtPtc.Series["Pitch"].Points.AddXY(dataGridView1.Rows[0].Cells[1].Value.ToString(),
                Convert.ToInt32(dataGridView1.Rows[1].Cells[10].Value.ToString()));
            this.chtRoll.Series["Roll"].Points.AddXY(dataGridView1.Rows[0].Cells[1].Value.ToString(),
                Convert.ToInt32(dataGridView1.Rows[1].Cells[11].Value.ToString()));
            this.chtRPM.Series["RPM"].Points.AddXY(dataGridView1.Rows[0].Cells[1].Value.ToString(),
                Convert.ToInt32(dataGridView1.Rows[1].Cells[7].Value.ToString()));
            this.chtSck.Series["Sıcaklık"].Points.AddXY(dataGridView1.Rows[0].Cells[1].Value.ToString(),
                Convert.ToInt32(dataGridView1.Rows[1].Cells[5].Value.ToString()));
            this.chtYaw.Series["Yaw"].Points.AddXY(dataGridView1.Rows[0].Cells[1].Value.ToString(),
                Convert.ToInt32(dataGridView1.Rows[1].Cells[12].Value.ToString()));
            this.chtYks.Series["Yükseklik"].Points.AddXY(dataGridView1.Rows[0].Cells[1].Value.ToString(),
                Convert.ToInt32(dataGridView1.Rows[1].Cells[3].Value.ToString()));
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            System.IO.Ports.SerialPort Port;

            Port
                 = new System.IO.Ports.SerialPort
                 {
                     PortName = "COM3",
                     BaudRate = 9600,
                     ReadTimeout = 400
                 };
            try
            {
                Port.Open();
            }
            catch { }
        }
    }

      
    
}
