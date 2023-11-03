using ConsoleApp1.Models;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task1
            //Vehicle car = new Car();
            //Vehicle bus = new Bus();
            //car.Drive();
            //bus.Drive();
            //if (car is  Car)
            //{
            //    ((Car)car).CarProperty = 10;
            //}
            //if (bus is Bus)
            //{
            //    ((Bus)bus).BusProperty = 20;
            //}

            //Car car1 = car as Car;
            //if (car1 != null)
            //{
            //    car1.Drive();
            //}
            //else
            //{
            //    Console.WriteLine("as islederek, Car deyil");
            //}
            #endregion

            #region task2
            Car car1 = new Car();
            Car car2 = new Car();
            car1.Price = 50;
            car2.Price = 100;
            Console.WriteLine(car1 == car2);
            #endregion
        }
    }
}
