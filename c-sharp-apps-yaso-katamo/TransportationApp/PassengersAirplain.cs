using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_yaso_katamo.TransportationApp
{
    public class PassengersAirplain : PublicVehicle
    {
        // תכונות
        private int enginesNum;
        private int wingLength;
        private int rows;
        private int columns;

        public PassengersAirplain()
        {
           this.MaxSpeed = 0; // הגדרת ברירת מחדל למהירות מקסימלית
        }

        public PassengersAirplain(int line, int id, int enginesNum, int wingLength, int rows, int columns)
            : base(line, id, 0, rows * columns - 7)
        {
            this.enginesNum = enginesNum;
            this.wingLength = wingLength;
            this.rows = rows;
            this.columns = columns;
        }

        public int EnginesNum { get => enginesNum; set => enginesNum = value; }
        public int WingLength { get => wingLength; set => wingLength = value; }
        public int Rows { get => rows; set => rows = value; }
        public int Columns { get => columns; set => columns = value; }

        public override int MaxSpeed
        {
            get => base.MaxSpeed;
            set
            {
                if (value <= 1000) base.MaxSpeed = value;
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
            return $"PassengersAirplane: Line: {Line}, Id: {Id}, MaxSpeed: {MaxSpeed}, Seats: {Seats}, EnginesNum: {enginesNum}, WingLength: {wingLength}";
        }
    }
}
