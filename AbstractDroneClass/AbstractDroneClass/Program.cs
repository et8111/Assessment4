using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDroneClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Drone d = new QuadrotorDrone(5, 15);
            Console.WriteLine(d.FlightSpeed());
        }
    }
}
//S-drone is a blueprint
//O-Quatrotor does one thing(implement a diffrent type of drone)
//L-Quatrotor can run if drone is removed
//I-already mentioned
//D-literally abstract