using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_yaso_katamo
{
    public class Owner
    {
        private string firstName;
        private string lastName;
        private double balance;
        private double overdraft;
        private double MAX_OVERDRAFT;


        public Owner(string firstName, string lastName)
        {
            this.firstName = firstName; 
            this.lastName = lastName; 
        }


    }

}
