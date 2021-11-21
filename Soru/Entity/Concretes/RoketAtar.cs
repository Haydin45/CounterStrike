using Soru.Enums;
using Soru.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Soru.Entity.Classlar.Silahlar
{
    public class RoketAtar : AtesliSilahlar, IYakinlastirma
    {
        public RoketAtar(string marka, string model, MenzilTipi menzilTipi, double agirlik, double kalibre)
        {
            Marka = marka;
            Model = model;
            MenzilTipi = menzilTipi;
            Agirlik = agirlik;
            Kalibre = kalibre;
            MermiTipi = MermiTipi.Roket;
            Kapasite = MermiKapasitesi.bir;
            MermiSayisi = (int)Kapasite;
            SilahKusan();
        }

        public string Yakinlastir { get { return "Yakınlaştırıldı!"; } }

        public string Uzaklastir { get { return "Uzaklaştırıldı!"; } }

        public override void AtesEt()
        {
            using (SoundPlayer player = new SoundPlayer(Environment.CurrentDirectory + @"\..\..\Sesler\TopAtis.wav"))
            {
                player.PlaySync();
            }
            base.AtesEt();
        }

        public override void SarjorDoldur()
        {
            base.SarjorDoldur();
        }
    }
}
