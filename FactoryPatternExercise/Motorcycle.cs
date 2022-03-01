using System;
namespace FactoryPatternExercise
{
    public class Motorcycle :IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("You are driving a motorcycle");
        }
        public Motorcycle()
        {
        }
    }
}
