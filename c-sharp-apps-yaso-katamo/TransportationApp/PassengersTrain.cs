using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_yaso_katamo.TransportationApp
{
    public class PassengersTrain : PublicVehicle
    {
        private Crone[] crones;
        private int cronesAmount;

        public PassengersTrain() { }

        public PassengersTrain(int line, int id, int maxSpeed, Crone crone, int cronesAmount)
            : base(line, id, maxSpeed, crone.GetSeats() * cronesAmount + crone.GetExtras() * cronesAmount)
        {
            this.cronesAmount = cronesAmount;
            crones = new Crone[cronesAmount];
            for (int i = 0; i < cronesAmount; i++)
            {
                crones[i] = new Crone(crone);
            }
        }

        public Crone[] Crones => crones;

        public override int MaxSpeed
        {
            get => base.MaxSpeed;
            set
            {
                if (value <= 300) base.MaxSpeed = value;
            }
        }

        public override void UploadPassengers(int numberOfPassengers)
        {
            if (CalculateHasRoom())
            {
                if (numberOfPassengers <= Seats - CurrentPassengers)
                {
                    CurrentPassengers += numberOfPassengers;
                }
                else
                {
                    RejectedPassengers += numberOfPassengers - (Seats - CurrentPassengers);
                    CurrentPassengers = Seats;
                    HasRoom = false;
                }
            }
            else
            {
                RejectedPassengers += numberOfPassengers;
            }
        }

        public override string ToString()
        {
            return $"PassengersTrain: Line: {Line}, Id: {Id}, MaxSpeed: {MaxSpeed}, Seats: {Seats}, CronesAmount: {cronesAmount}";
        }
    }
}
