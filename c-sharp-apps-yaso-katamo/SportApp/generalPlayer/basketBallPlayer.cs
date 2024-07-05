using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_yaso_katamo.SportApp.generalPlayer
{
    public class  basketBallPlayer : genral_Player
    {
        private int Dunks;
        private int threeShots;
        private int rebounds;

        public basketBallPlayer(string scoreName) : base("basket")
        {
            this.Dunks = 0;
            this.threeShots = 0;
            this.rebounds = 0;
        }
        
        public override void  AddFoul()
        {
            this.fouls++;
            if(this.fouls == 5)
            {
                this.outOfGame= true;
                Console.WriteLine("you out of the game");
            }
        }
        public override void ScoreField()
        {
            this.points += 2;
            DisplayScore();
        }
        public void Score3()
        {
            this.threeShots += 3;
        }

    }
}
