using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using Soru.Enums;

namespace Soru.Entity.Classlar
{
    public abstract class AtesliSilahlar : Cephane
    {
        Random rnd = new Random();
        protected MermiTipi MermiTipi { get; set; }
        protected MermiKapasitesi Kapasite { get; set; }
        public double Kalibre { get; set; }

        private int anlikMermiSayisi;
        public int MermiSayisi
        {
            get { return anlikMermiSayisi; }
            set { anlikMermiSayisi = value; }
        }

        private int _oldurmeOlasiligi;
        private string OldurmeOlasiligi()
        {
            _oldurmeOlasiligi = rnd.Next(1, 7);

            if (_oldurmeOlasiligi == 1)
            {
                base.Oldur();
                return "Rakip öldü.";
            }
            else
            {
                base.Yarala();
                return "Rakip yaralandı.";
            }
        }
        
        protected bool MermiVarMi()
        {
            if (MermiSayisi != 0)
                return true;
            else
                return false;
        }
        public virtual void AtesEt()
        {
            if (MermiVarMi())
            {
                Console.WriteLine(OldurmeOlasiligi());
                MermiSayisi--;
            }
            else
            {
                using (SoundPlayer player = new SoundPlayer(Environment.CurrentDirectory + @"\..\..\Sesler\GumEmpty.wav"))
                {
                    player.PlaySync();
                }
            }
        }
        public virtual void SarjorDoldur()
        {
            if (MermiSayisi < (int)Kapasite)
            {
                MermiSayisi = (int)Kapasite;
                using (SoundPlayer player = new SoundPlayer(Environment.CurrentDirectory + @"\..\..\Sesler\Silah2.wav"))
                {
                    player.PlaySync();
                }
            }
            else
                Console.WriteLine("Şarjör zaten dolu.");
        }
    }
}
