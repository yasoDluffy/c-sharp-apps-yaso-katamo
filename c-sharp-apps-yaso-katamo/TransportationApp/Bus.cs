using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_yaso_katamo.TransportationApp
{
    public class Bus : PublicVehicle
    {
        // תכונות
        private readonly int doors;

        public Bus() { }

        public Bus(int line, int id, int maxSpeed, int seats, int doors)
            : base(line, id, maxSpeed, seats)
        {
            this.doors = doors;
        }

        public int Doors => doors;

        public override int MaxSpeed
        {
            get => base.MaxSpeed;
            set
            {
                if (value <= 120) base.MaxSpeed = value;
            }
        }

        public override void UploadPassengers(int numberOfPassengers)
        {
            int maxPassengers = Seats + (int)Math.Ceiling(Seats * 0.1);
            if (CalculateHasRoom())
            {
                if (numberOfPassengers <= maxPassengers - CurrentPassengers)
                {
                    CurrentPassengers += numberOfPassengers;
                }
                else
                {
                    RejectedPassengers += numberOfPassengers - (maxPassengers - CurrentPassengers);
                    CurrentPassengers = maxPassengers;
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
            return $"Bus: Line: {Line}, Id: {Id}, MaxSpeed: {MaxSpeed}, Seats: {Seats}, Doors: {doors}";
        }
    }
}
