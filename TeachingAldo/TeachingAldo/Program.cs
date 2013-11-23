using System;

namespace TeachingAldo
{
    using System.Security.Cryptography.X509Certificates;

    public class Program
    {
        static void Main()
        {
            int milesToChurch = 13;

            Car bmw = new Car();

            bmw.Drive(milesToChurch);
            Console.WriteLine(String.Format("Odometer Before shady mechanic: {0}", bmw.odometer));

            ShadyMechanic bob = new ShadyMechanic();
            bob.rollBackOdometer(bmw);

            Console.WriteLine(String.Format("Odometer After shady mechanic: {0}", bmw.odometer));
            


            Console.ReadKey();

        }
    }

    public class Car
    {
        public string make { get; set; }
        public string model { get; set; }
        public int year { get; set; }
        public bool hasABS { get; set; }
        public bool hasPowerWindows { get; set; }
        public int odometer { get; set; }

        public Car()
        {
            make = "BMW";
            model = "M3";
            year = 2014;
            hasABS = true;
            hasPowerWindows = false;
            odometer = 0;
        }

        public void Drive(int tripDistance)
        {
            odometer += tripDistance;
        }
    }

    public class ShadyMechanic
    {
        public Car rollBackOdometer(Car car)
        {
            car.odometer = 0;

            return car;
        }
    }
}
