using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_yaso_katamo.TransportationApp
{



    public class MonitorTransportation
    {
        public void Test1()
        {
            // TODO:

            // some tests:
            PublicVehicle p1 = new PublicVehicle(); // מהירות מקסימלית תוגדר ל-0
            Bus bus = new Bus(1, 2033355, 110, 50, 3); // int line, int id, int maxSpeed, int seats, int doors
            PassengersAirplain passengersAirplain1 = new PassengersAirplain(605, 987653, 4, 10, 60, 6); // int line, int id, int enginesNum, int wingLength, int rows, int columns

            Crone crone1 = new Crone(20, 5);
            PassengersTrain passengersTrain1 = new PassengersTrain(65, 9998774, 250, crone1, 5);
            bool allPassed = true;

            // test max speed
            if (p1.MaxSpeed != 0)
            {
                Console.WriteLine("Test 1 Error - Max Speed should be {0} but actual is {1}", 0, p1.MaxSpeed);
                allPassed = false;
            }
            else
            {
                Console.WriteLine("Test 1 Passed ");
            }

            if (bus.MaxSpeed != 110)
            {
                Console.WriteLine("Test 2 Error - Max Speed should be {0} but actual is {1}", 110, bus.MaxSpeed);
                allPassed = false;
            }
            else
            {
                Console.WriteLine("Test 2 Passed ");
            }

            bus.MaxSpeed = 200;

            if (bus.MaxSpeed != 110)
            {
                Console.WriteLine("Test 3 Error - Max Speed should be {0} but actual is {1}", 110, bus.MaxSpeed);
                allPassed = false;
            }
            else
            {
                Console.WriteLine("Test 3 Passed ");
            }

            // test upload some passenger and the currentPassengers after
            passengersAirplain1.CurrentPassengers = 300;
            passengersAirplain1.UploadPassengers(100);

            if (passengersAirplain1.CurrentPassengers == 353 && passengersAirplain1.RejectedPassengers == 47)
            {
                Console.WriteLine("Test 4 Passed ");
            }
            else
            {
                Console.WriteLine("Test 4 Error - CurrentPassengers should be {0} but actual is {1} \n" +
                    "And rejected should be {2} but actual is {3} ", 353, passengersAirplain1.CurrentPassengers,
                    47, passengersAirplain1.RejectedPassengers);
                allPassed = false;
            }

            bus.UploadPassengers(40);
            bus.UploadPassengers(20);

            if (bus.CurrentPassengers == 55 && bus.RejectedPassengers == 5)
            {
                Console.WriteLine("Test 5 Passed ");
            }
            else
            {
                Console.WriteLine("Test 5 Error - CurrentPassengers should be {0} but actual is {1} \n" +
                    "And rejected should be {2} but actual is {3} ", 55, bus.CurrentPassengers,
                    5, bus.RejectedPassengers);
                allPassed = false;
            }

            if (passengersTrain1.Id == 9998774)
            {
                Console.WriteLine("Test 6 Passed ");
            }
            else
            {
                Console.WriteLine("Test 6 Error - id  should be {0} but actual is {1} ",
                    9998774, passengersTrain1.Id);
                allPassed = false;
            }

            passengersTrain1.UploadPassengers(300);
            passengersTrain1.UploadPassengers(134);

            if (passengersTrain1.CurrentPassengers == 434 && passengersTrain1.RejectedPassengers == 0)
            {
                Console.WriteLine("Test 7 Passed ");
            }
            else
            {
                Console.WriteLine("Test 7 Error - CurrentPassengers should be {0} but actual is {1} \n" +
                    "And rejected should be {2} but actual is {3} ", 434, passengersTrain1.CurrentPassengers,
                    0, passengersTrain1.RejectedPassengers);
                allPassed = false;
            }

            passengersTrain1.UploadPassengers(405);

            if (passengersTrain1.CurrentPassengers == 700 && passengersTrain1.RejectedPassengers == 139
                && !passengersTrain1.HasRoom)
            {
                Console.WriteLine("Test 8 Passed ");
            }
            else
            {
                Console.WriteLine("Test 8 Error - CurrentPassengers should be {0} but actual is {1} \n" +
                    "And rejected should be {2} but actual is {3} and HasRoom should be False, but actual is {4}", 700, passengersTrain1.CurrentPassengers,
                    139, passengersTrain1.RejectedPassengers, passengersTrain1.HasRoom);
                allPassed = false;
            }

            // Check that each crone is a different object
            if (ReferenceEquals(passengersTrain1.Crones[0], passengersTrain1.Crones[1]))
            {
                Console.WriteLine("Test 9 Error - each crone of the train should be different instance. ");
                allPassed = false;
            }
            else
            {
                Console.WriteLine("Test 9 Passed");
            }

            Console.WriteLine("\n*********************************\n");

            if (allPassed)
            {
                Console.WriteLine("All TEST PASSED - WELL DONE!! \n" +
                    "Yet it's not saying that everything work well. You should test yourself a little bit, also.");
            }
            else
            {
                Console.WriteLine("YOU HAVE FAILURES AT THE TESTS :( - SEE ABOVE");
            }
            Console.WriteLine("\n*********************************\n");
        }


    }
}