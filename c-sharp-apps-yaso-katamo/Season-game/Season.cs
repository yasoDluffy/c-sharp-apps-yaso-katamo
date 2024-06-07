using c_sharp_apps_yaso_katamo.Round_Game;
using c_sharp_apps_yaso_katamo.Team_sport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_yaso_katamo.Season_game
{
    public class Season
    {
        private int year;
        private string typeSport;
        private string typeLiga;
        private int rounds_amount;
        private Round next_round;
        private Team[] teams;
        private int numTeams;
        private bool active;
        public void DisplayTable()
        {
            for(int i=0; i<numTeams; i++)
            {
                Console.WriteLine(teams[i].GetName() + " " + teams[i].GetPoints());
            }
        }

    }
}
