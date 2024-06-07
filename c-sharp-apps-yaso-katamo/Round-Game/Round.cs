using c_sharp_apps_yaso_katamo.Game_sport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_yaso_katamo.Round_Game
{
    public class Round
    {
        Game[] roundGames;
        public Round(int numGame)
        {
            this.roundGames = new Game[numGame];
        }
    }
}
