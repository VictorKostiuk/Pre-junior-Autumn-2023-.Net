using System;

namespace ClassLibrary1
{
    class Car
    {
        private string name;
        private int maxSpeed;

        public Car(string name, int maxSpeed)
        {
            this.name = name;
            this.maxSpeed = maxSpeed;
        }

        public string GetName()
        {
            return name;
        }

        public int GetMaxSpeed()
        {
            return maxSpeed;
        }
    }

    public class Class1
    {
        public static void Main()
        {
            Car car1 = new Car("BMW", 350);
            Car car2 = new Car("Supra", 450);
            Console.WriteLine(car1.GetMaxSpeed() > car2.GetMaxSpeed() ? car1.GetName() : car2.GetName());
        }
    }
}