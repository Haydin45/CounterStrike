using Soru.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Soru.Entity.Classlar.Silahlar
{
    class Tabanca : AtesliSilahlar
    {
        public Tabanca(string marka, string model, MenzilTipi menzilTipi, double agirlik, double kalibre)
        {
            Marka = marka;
            Model = model;
            MenzilTipi = menzilTipi;
            Agirlik = agirlik;
            Kalibre = kalibre;
            MermiTipi = MermiTipi.Cekirdekli;
            Kapasite = MermiKapasitesi.onbes;
            MermiSayisi = (int)Kapasite;
            SilahKusan();
        }

        public override void SarjorDoldur()
        {
            base.SarjorDoldur();
        }

        public override void AtesEt()
        {
            using (SoundPlayer player = new SoundPlayer(Environment.CurrentDirectory + @"\..\..\Sesler\Tabanca.wav"))
            {
                player.PlaySync();
            }
            base.AtesEt();
        }
    }
}
