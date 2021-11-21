using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using Soru.Enums;
using Soru.Interfaces;


namespace Soru.Entity.Classlar.Silahlar
{
    public class Tufek : AtesliSilahlar, IYakinlastirma
    {
        private TufekTipi TufekTipi { get; set; }
        public string Yakinlastir { get { return "Yakınlaştırıldı!"; } }
        public string Uzaklastir { get { return "Uzaklaştırıldı!"; } }
        public Tufek(string marka, string model, MenzilTipi menzilTipi, double agirlik, double kalibre, TufekTipi tufekTipi)
        {
            Marka = marka;
            Model = model;
            MenzilTipi = menzilTipi;
            Agirlik = agirlik;
            Kalibre = kalibre;
            TufekTipi = tufekTipi;
            SilahKusan();

            if (TufekTipi == TufekTipi.Pompalı)
            {
                MermiTipi = MermiTipi.Sacma;
                Kapasite = MermiKapasitesi.dort;
                MermiSayisi = (int)Kapasite;
            }
            else if(TufekTipi == TufekTipi.Taramalı)
            {
                MermiTipi = MermiTipi.Cekirdekli;
                Kapasite = MermiKapasitesi.elli;
                MermiSayisi = (int)Kapasite;
            }
        }
        public override void AtesEt()
        {
            if (MermiVarMi() && TufekTipi == TufekTipi.Pompalı)
            {
                using (SoundPlayer player = new SoundPlayer(Environment.CurrentDirectory + @"\..\..\Sesler\Pompali.wav"))
                {
                    player.PlaySync();
                }
            }
            else if (MermiVarMi() && TufekTipi == TufekTipi.Taramalı)
            {
                using (SoundPlayer player = new SoundPlayer(Environment.CurrentDirectory + @"\..\..\Sesler\Taramali.wav"))
                {
                    player.PlaySync();
                }
            }
            base.AtesEt();
        }
        public override void SarjorDoldur()
        {
            if (TufekTipi == TufekTipi.Pompalı && MermiSayisi != (int)Kapasite)
            {
                while (MermiSayisi < (int)Kapasite)
                {
                    MermiSayisi++;
                    using (SoundPlayer player = new SoundPlayer(Environment.CurrentDirectory + @"\..\..\Sesler\PompaliSarjor.wav"))
                    {
                        player.PlaySync();
                    }
                }
            }
            else
            {
                base.SarjorDoldur();
                using (SoundPlayer player = new SoundPlayer(Environment.CurrentDirectory + @"\..\..\Sesler\Taramali2.wav"))
                {
                    player.PlaySync();
                }
            }
        }
    }
}
