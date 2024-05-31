using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using c_sharp_apps_yaso_katamo.BankApp;
using c_sharp_apps_yaso_katamo.SportApp;
using c_sharp_apps_yaso_katamo.DraftApp;
using c_sharp_apps_yaso_katamo.TransportationApp;
namespace c_sharp_apps_yaso_katamo.shared
{
    internal class ProcessManager
    {
        public static void RunMainProcess()
        {
            bool finish = false;
            Console.WriteLine("App Menu");
            Console.WriteLine("========");
            Console.WriteLine("1. Bank App");
            Console.WriteLine("2. Sport App");
            Console.WriteLine("3. Transportation App");
            Console.WriteLine("4. Draft App");
            Console.WriteLine("Exit");
            Console.WriteLine("========");
            while (!finish)
            {
               

                Console.Write("Enter Choise: ");
                int choise = int.Parse(Console.ReadLine());
                switch(choise)
                {
                    case 1:
                        BankAppMain.MainEntry();
                        break;
                    case 2:
                        SportAppMain.MainEntry();
                        break;
                    case 3:
                        TransportationAppMain.MainEntry();
                        break;
                    case 4:
                        DraftAppMain.MainEntry();
                        break;
                    case 5:
                        finish = true;
                        break;








                }


            }
        }
    }
}
