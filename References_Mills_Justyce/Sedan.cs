using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace References_Mills_Justyce
{
    class Sedan : IAutomobile // implements the IAutomobile interface
    {
        public double Speed { get; private set; } //add a private setter to the Speed property

        public int Wheels { get; }

        public string LicensePlate { get; }

        public Sedan(double speed) //Creates a constructor for the class that takes a double parameter called speed.
        {
            Speed = speed;
            Wheels = 4;
            LicensePlate = "GTG-007";
        }

        public void Stringify()
        {
            Console.WriteLine($"The Sedan is traveling at a speed of {Speed} on {Wheels} wheels, with a License Plate of {LicensePlate}.");
        }
        public void IncreaseSpeed() //method that increase the speed of the Sedan by 5 when called
        {
            Speed += 5;
        }
        public void DecreaseSpeed() //methods that decrease the speed of the Sedan by 5 when called
        {
            Speed -= 5;
        }
    }
}
