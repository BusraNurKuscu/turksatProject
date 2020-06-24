using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace turksatdeneme_6
{
   public class Telemetri
    {
        private static LiteDatabase db = new LiteDatabase(@"database.db");

        //Litedb ile database de tutulacak verileri bu envertere ekliyoruz.
        public int Paket_No { get; set; }
        public DateTime Gonderme_Zamani { get; set; }
        public float Basinc { get; set; }
        public float Yukseklik{ get; set; }
        public float Inis_Hizi { get; set; }
        public float Sicaklik { get; set; }
        public float Pil_Gerilimi { get; set; }
        public float RPM { get; set; }
        public float GPS_Long { get; set; }
        public float GPS_Lot { get; set; }
        public float Pitch { get; set; }
        public float Roll { get; set; }
        public float Yaw { get; set; }
        public float Donus_Sayisi { get; set; }
        public int Takim_No { get; set; }


        public static void Add(Telemetri telemetri)//ekle fonksiyonu oluşturarak datalarımızı value olarak ekliyoruz.
        {
           
            var telemetries = db.GetCollection<Telemetri>();
            telemetries.Insert(telemetri);
        }

        public static List<Telemetri> GetAll()//tümünüü listele fonksiyonu oluşturarak verilerin hepsini okuyop listeliyoruz.
        {
            return db.GetCollection<Telemetri>().FindAll().OrderByDescending(t=>t.Gonderme_Zamani).ToList();
         }

        internal static void Add(string port)
        {
            throw new NotImplementedException();
        }
    }
}
