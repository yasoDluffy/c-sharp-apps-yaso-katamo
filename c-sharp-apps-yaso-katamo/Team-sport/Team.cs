using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_yaso_katamo.Team_sport
{
    public class Team
    {
        private string name;
        private string city;
        private string curentLiga;
        private int allGamesPlay;
        private int gamesPlayed;//משחקים ששוחקו
        private int wins;
        private int losses;
        private int Tie;//תיקו
        private int points;
        private int goalsFor;//לטובת הקבוצה
        private int goalAgainst;//נגד הקבוצה
        private int goalDiffrential;

        public Team(string name, string city, string curretLiga)
        {
            this.name = name;
            this.city = city;
            this.curentLiga = curretLiga;
            this.allGamesPlay = 0;
            this.gamesPlayed = 0;
            this.wins = 0;
            this.losses = 0;
            this.goalsFor = 0;
            this.goalAgainst = 0;
            this.goalDiffrential = 0;
            this.goalAgainst = 0;
            this.goalDiffrential = 0;
        }

        public string GetName()
        {
            return name;
        }
        public int GetPoints()
        {
            return points;
        }










    }
}
