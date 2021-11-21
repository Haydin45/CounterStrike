using Soru.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Soru.Entity.Classlar.Silahlar
{
    public class Bicak : Cephane
    {
        private int kesmeSayisi = 0;
        public Bicak(string marka, string model, MenzilTipi menzilTipi, double agirlik)
        {
            Marka = marka;
            Model = model;
            MenzilTipi = menzilTipi;
            Agirlik = agirlik;
            SilahKusan();
        }
        public string Kes()
        {
            using (SoundPlayer player = new SoundPlayer(Environment.CurrentDirectory + @"\..\..\Sesler\StabKnife.wav"))
            {
                player.PlaySync();
            }
            if (kesmeSayisi == 4) //Burası 5 olsaydı 6. kesmede öldürecektik. O yüzden 4 yaptım. Veya kesme sayısının artış isteğini else dışına taşıyarak kesme sayısını 5'ten başlatabiliriz
            {
                Oldur();
                kesmeSayisi = 0;
                return "Düşman öldü";
            }
            else
            {
                kesmeSayisi++;
                Yarala();
                return "Düşman yaşıyor";
            }
        }
        public string Bileyle
        {
            get
            {
                using (SoundPlayer player = new SoundPlayer(Environment.CurrentDirectory + @"\..\..\Sesler\SharpenKnife.wav"))
                {
                    player.PlaySync();
                }
                return "Bıçak bileylendi";
            }
        }

    }
}
