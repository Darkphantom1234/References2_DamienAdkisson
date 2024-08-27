using System;
using System.Collections.Generic;
using System.Text;

namespace References_Adkisson_Damien
{
    class Sedan : IAutomobile
    {

        //private sets for wheels,speed, etc
        public double Speed { get; private set; }

        public int Wheels { get; private set; }

        public string LincensePlate { get; private set; }
        public object LicensePlate { get; private set; }

        //constructor sets information about sedan
        public Sedan(double Speed)
        {
            Wheels = 4;
            Speed = Speed;
            LincensePlate = "GCTC-06";
        }

        //prints sedans stats
        public void stringify()
        {
            Console.WriteLine($"The Sedan is taveling at a speed of {Speed} on {Wheels} wheels, with a License Plate # of {LicensePlate}.");
        }

        //method to increase speed by 5
        public void Increasespeed()
        {
            Speed += 5;
        }

        //method to decrease speed by 5
        public void Decreasespeed()
        {
            Speed -= 5;
        }
    }
}
