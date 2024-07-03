using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_yaso_katamo.SportApp.generalPlayer
{
    public class soccer_Player : genral_Player
    {
        private bool redCard;
        private int penalyais;//עונשים
        private int dribblingRate;

        public soccer_Player(string scoreName) : base("goal")
        {

            this.redCard = false;
            this.penalyais = 0;
            this.dribblingRate = 0;
        }
        public void setRedCard()
        {
            redCard = true;
        }


    }
}
