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
            Console.WriteLine();
            for (int i = 0; i < teams.Length; i++)
            {
                Console.WriteLine($"{i+1} {teams[i].GetName()} {teams[i].GetPoints()}");
            }
            Console.WriteLine();
        }

        public Season(int year, string typeSport, string typeLiga, Team[] teams)
        {
            this.year = year;
            this.typeSport = typeSport;
            this.typeLiga = typeLiga;
            this.teams = teams;


        }

    }
}
