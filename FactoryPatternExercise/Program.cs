using System;

namespace FactoryPatternExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many tires are on your vehicle?");
            string numberOfTires = Console.ReadLine();

            IVehicle vehicle = VehicleFactory.GetVehicle(numberOfTires);
            vehicle.Drive();
        }
    }
}
