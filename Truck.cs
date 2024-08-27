using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace References_Adkisson_Damien
{
    //class inherits from IAutomobile
    class Truck : IAutomobile
    {
        public double Speed { get; private set; }

        public int Wheels { get; private set; }

        public string LincensePlate { get; private set; }

        //new weight param for the truck only
        public double weight { get; }
        public object Licenseplate { get; }
        public object? LicenseNum { get; }


        //sets up params for truck and a bool to set the amount of wheels based on the weight
        public Truck(double speedparam, double weightparam, string v)
        {
            Speed = speedparam;
            weight = weightparam;
            Licenseplate = LicenseNum;

            if (weight < 400)
            {
                Wheels = 8;
            }
            else
            {
                Wheels = 12;
            }
        }


        //prints stats about truck
        public void stringify()
        {
            Console.WriteLine($"The Truck is traveling at a speed of {Speed} on {Wheels} wheels, with a License Plate # of {Licenseplate}!");
        }

        //method to increase speed by 5

        public void IncreaseSpeed()
        {
            Speed += 5;
        }

        //method to decrease speed by 5
        public void DecreaseSpeed()
        {
            Speed -= 5;
        }
    }
}
