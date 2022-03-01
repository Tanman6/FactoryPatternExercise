using System;
namespace FactoryPatternExercise
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(string numberOfTires)
        {

            if (numberOfTires == "2"|| numberOfTires.ToLower() == "two")
            {
                return new Motorcycle();
            } else
            {
                return new Car();
            }
        }
    }
}
