using System.Runtime.ExceptionServices;

namespace ClassTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            //("mercedes", "amg", "white", 2000, 4, "sedan")
            //car1.Brand = "mercedes";
            //car1.Model = "amg";
            //car1.Colour = "white";
            //car1.ProducedYear = 2000;
            //car1.DoorCount = 4;
            //car1.Type = "sedan";


            //Plane plane1 = new Plane("f18","e/c","white", 1980 , 2, false );
            Console.WriteLine(car1.GetMaximumSpeed());
            //Console.WriteLine(plane1.GetMaximumSpeed());
            //Vehicle[] array = new Vehicle[] {car1,plane1 };

            //foreach (var item in array)
            //{
            //    Console.WriteLine(item.ProducedYear);
            //}
        }
    }
}