namespace References_Adkisson_Damien
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Creates Sedan
            Sedan myFirstSedan = new Sedan(0);
            IAutomobile myAutomobile = myFirstSedan;

            //creates otherSedans
            Sedan myOtherSedan = new Sedan(0);

            //increases speed and checks if Sedan is equal to automobile
            myFirstSedan.Increasespeed();
            Console.WriteLine(myFirstSedan.Speed);
            Console.WriteLine(myAutomobile.Speed);
            Console.WriteLine(myFirstSedan.Equals(myAutomobile));

            //increases speed of the other sedan and checks if Sedan is equal to otherSedan
            myOtherSedan.Increasespeed();
            Console.WriteLine(myFirstSedan.Speed);
            Console.WriteLine(myOtherSedan.Speed);
            Console.WriteLine(myFirstSedan.Equals(myOtherSedan));

            //creates truck and sets params
            Truck myTruck = new Truck(50, 500, "MyTruck");

            // Calls stringify method and describes automobiles.
            myFirstSedan.stringify();
            myAutomobile.stringify();
            myOtherSedan.stringify();
            myTruck.stringify();
        }
    }
}