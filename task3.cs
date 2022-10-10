public class Task3_Interfaces
{
    public Task3_Interfaces()
    {
        Console.WriteLine("\nPlease enter an amount of gasoline to refuel");
        Car car = new Car(0);
 
        int gasoline = int.Parse(Console.ReadLine());
        Console.WriteLine("\n==== Output =====");
        if (car.Refuel(gasoline))
        {
            car.Drive();
        }
    }

    public interface IVehiculo
    {
        void Drive();
        bool Refuel(int amount);
    }

    public class Car : IVehiculo {
        public int Gasoline;
 
        public Car(int gasoline)
        {
            Gasoline = gasoline;
        }
 
        public void Drive()
        {
            if (Gasoline > 0)
            {
                Console.WriteLine("The car is Driving");
            }
            else
            {
                Console.WriteLine("Not fuel");
            }
        }
 
        public bool Refuel(int amount)
        {
            Gasoline += amount;
            return true;
        }
   }
}