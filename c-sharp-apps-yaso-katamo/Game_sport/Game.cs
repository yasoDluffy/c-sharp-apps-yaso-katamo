using c_sharp_apps_yaso_katamo.Team_sport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_yaso_katamo.Game_sport
{
    public class Game
    {
        private Team A;
        private Team B;
        private int sumOfGoalsTeam_A;
        private int sumOfGoalsTeam_B;
        private double currentMinuets;
        private bool GameOn;

        public Game(Team A, Team B ) 
        {
            this.A = A;
            this.B = B;
            this.sumOfGoalsTeam_A = 0;
            this.sumOfGoalsTeam_B = 0;
            this.currentMinuets = 0;
            this.GameOn = true;

        }

    }
}
