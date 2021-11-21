using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using Soru.Enums;

namespace Soru.Entity.Classlar
{
    public abstract class Cephane
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public MenzilTipi MenzilTipi{ get; set; }
        public double Agirlik { get; set; }

        protected void Oldur()
        {
            using (SoundPlayer player = new SoundPlayer(Environment.CurrentDirectory + @"\..\..\Sesler\death.wav"))
            {
                player.PlaySync();
            }
        }
        
        protected void Yarala()
        {
            using (SoundPlayer player = new SoundPlayer(Environment.CurrentDirectory + @"\..\..\Sesler\scream.wav"))
            {
                player.PlaySync();
            }
        }
        protected void SilahKusan()
        {
            using (SoundPlayer player = new SoundPlayer(Environment.CurrentDirectory + @"\..\..\Sesler\silah1.wav"))
            {
                player.PlaySync();
            }
        }
    }
}
