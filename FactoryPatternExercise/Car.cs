using System;
namespace FactoryPatternExercise
{
    public class Car : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("You are driving a Car");
        }
        public Car()
        {
        }
    }
}
