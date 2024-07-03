using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_yaso_katamo.SportApp.generalPlayer
{
    public class genral_Player
    {
        protected int points;
        private string scoreName;
        private int assits;
        protected int fouls;
        protected bool outOfGame;

        public genral_Player(string scoreName)
        {
            this.points = 0;
            this.scoreName = scoreName;
            this.assits = 0;
            this.fouls = 0;
            this.outOfGame = false;
        }
        public virtual void ScoreField()
        {
            this.points++;
        }
        public virtual void AddFoul()
        {
            this.fouls++;
        }
        public virtual void DisplayScore()
        {
            Console.WriteLine($"you score! \n you have now: {this.points} points.  ");
        }



    }
}
