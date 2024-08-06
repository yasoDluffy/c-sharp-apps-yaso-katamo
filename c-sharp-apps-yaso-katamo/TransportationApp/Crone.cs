using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_yaso_katamo.TransportationApp
{
    public class Crone
    {
        // תכונות
        private int rows;
        private int columns;

        public Crone(int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;
        }

        public Crone(Crone crone)
        {
            this.rows = crone.rows;
            this.columns = crone.columns;
        }

        public int Rows
        {
            get => rows;
            set => rows = value;
        }

        public int Columns
        {
            get => columns;
            set => columns = value;
        }

        public int GetSeats()
        {
            return rows * columns;
        }

        public int GetExtras()
        {
            return rows * 2;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Crone other = (Crone)obj;
            return rows == other.rows && columns == other.columns;
        }

        public override int GetHashCode()
        {
            int hash = 17;
            hash = hash * 31 + rows.GetHashCode();
            hash = hash * 31 + columns.GetHashCode();
            return hash;
        }
    } 
}
