using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
            #endregion

            var vehicles = new List<IVehicle>();
          

            Car car1 = new Car() { Motor = "6 cylinder", Wheels = "Four wheels", Windows = "Five windows, one windshield", Radio = "Radio is CD compatible", Name = "Honda", Slogan = "The Power of Dreams", Hatchback = "No hatchback", InteriorSize = "Interior is roomy" };
            Truck truck1 = new Truck() { Motor = "8 cylinder", Wheels = "Six wheels", Windows = "Three windows, one windshield", Radio = "Radio is hooked to the antena", Name = "Toyota", Slogan = "Lets Go Places", Dually = "This truck is a dually", TrunkTopper = "No trunk topper" };
            SUV suv1 = new SUV() { Motor = "6 cylinder", Wheels = "Four wheels", Windows = "Seven windows, one windshield", Radio = "Radio has Sirius XM!", Name = "Hyundai", Slogan = "New Thinking, New Possibilities", ThirdRow = "This SUV has three rows", SoccerMomCar = "This SUV is VERY much a soccer mom car" };
            vehicles.Add(car1);
            vehicles.Add(truck1);
            vehicles.Add(suv1);

            foreach (var cars in vehicles)
            {
                Console.WriteLine($"{cars.Motor} {cars.Wheels} {cars.Windows} {cars.Radio}");

            }

        }
    }
}
