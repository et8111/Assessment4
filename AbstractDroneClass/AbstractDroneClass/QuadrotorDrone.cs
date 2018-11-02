using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDroneClass
{
    class QuadrotorDrone : Drone
    {
        private int TotalDistance1 { get; }
        private int TotalFlyTime1 { get; }

        public QuadrotorDrone(int fly, int dist): base(fly, dist)
        {
            TotalDistance1 = dist;
            TotalFlyTime1 = fly;
        }
        public override double FlightSpeed()
        {
            return TotalDistance1 / TotalFlyTime1;
        }
    }
}
