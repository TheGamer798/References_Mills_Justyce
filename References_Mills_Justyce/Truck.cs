using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace References_Mills_Justyce
{
    class Truck : IAutomobile
    {
        public double Speed { get; private set; }

        public int Wheels { get; }

        public string LicensePlate { get; }
        public double Weight { get; }
        public Truck(double speedParam, double weightParam, string lisecnseNum)
        {
            Speed = speedParam;
            Weight = weightParam;
            LicensePlate = lisecnseNum;
            if (Weight < 400)
            {
                Wheels = 8;
            }
            else
            {
                Wheels = 12;
            }
        }

        public void Stringify()
        {
            Console.WriteLine($"The truck is traveling at a speed of {Speed} on {Wheels} wheels, with a license plate of {LicensePlate}.");
        }
        public void IncreaseSpeed()
        {
            Speed += 5;
        }
        public void DecreaseSpeed()
        {
            Speed -= 5;
        }
    }
}
