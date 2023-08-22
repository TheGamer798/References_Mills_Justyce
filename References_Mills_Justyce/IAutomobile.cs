using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace References_Mills_Justyce
{
    interface IAutomobile //Creates an interface called IAutomobile
    {
        public double Speed { get; } //Adds a double property called Speed with an automatic getter
        public int Wheels { get; } //Adds a int property called Wheels with an automatic getter
        public string LicensePlate { get; } //Adds a string property called LicensePlate with an automatic getter
        public void Stringify(); //defines a void method called Stringify()
    }
}
