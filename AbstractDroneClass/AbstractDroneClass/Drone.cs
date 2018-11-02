using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDroneClass
{
    abstract class Drone
    {
        private int TotalFlyTime { get; }//i dont understand why i need these
        private int TotalDistance { get; }//its a abstract class i cant call new Drone()

        public Drone(int fly, int dist)
        {
            TotalDistance = dist;
            TotalFlyTime = fly;
        }

        public virtual double FlightSpeed()
        {
            return TotalDistance / TotalFlyTime;
        }
    }
}
