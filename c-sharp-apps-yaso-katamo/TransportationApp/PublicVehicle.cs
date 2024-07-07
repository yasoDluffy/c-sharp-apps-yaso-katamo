using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_yaso_katamo.TransportationApp
{
    public class PublicVehicle
    {
        // תכונות
        private int line;
        private int id;
        protected int maxSpeed;
        private int currentPassengers;
        private int seats;
        private bool hasRoom;
        private int rejectedPassengers;

        public PublicVehicle() { }

        public PublicVehicle(int line, int id)
        {
            this.line = line;
            this.id = id;
        }

        public PublicVehicle(int line, int id, int maxSpeed, int seats)
        {
            this.line = line;
            this.id = id;
            MaxSpeed = maxSpeed;
            this.seats = seats;
        }

        public int Line { get => line; set => line = value; }
        public int Id { get => id; set => id = value; }
        public virtual int MaxSpeed
        {
            get => maxSpeed;
            set
            {
                if (value <= 40) maxSpeed = value;
            }
        }
        public int CurrentPassengers { get => currentPassengers; set => currentPassengers = value; }
        public int Seats { get => seats; set => seats = value; }
        public bool HasRoom { get => hasRoom; set => hasRoom = value; }
        public int RejectedPassengers { get => rejectedPassengers; set => rejectedPassengers = value; }

        public virtual void UploadPassengers(int numberOfPassengers)
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

        protected bool CalculateHasRoom()
        {
            return CurrentPassengers < Seats;
        }

        public override string ToString()
        {
            return $"PublicVehicle: Line: {line}, Id: {id}, MaxSpeed: {maxSpeed}, Seats: {seats}";
        }
    }
}
