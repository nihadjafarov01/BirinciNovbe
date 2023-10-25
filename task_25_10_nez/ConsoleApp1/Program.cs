using Models.Entities;

namespace ConsoleApp1;

internal class Program
{
    static void Main(string[] args)
    {
        Weapon silah = new Weapon(28,15,10,"tekli");

        int key = -1;
        Console.Write("CapacityOfMagazine: ");
        int capacityOfMagazine = Convert.ToInt32(Console.ReadLine());
        silah.CapacityOfMagazine = capacityOfMagazine;

        Console.Write("CountOfBullet: ");
        int countOfBullet = Convert.ToInt32(Console.ReadLine());
        silah.CountOfBullet = countOfBullet;

        Console.Write("TimeOfMagazine: ");
        float timeOfMagazine = Convert.ToInt32(Console.ReadLine());
        silah.TimeOfMagazine = timeOfMagazine;

        Console.Write("FireMode: ");
        string fireMode = Console.ReadLine();
        silah.FireMode = fireMode;

        Console.WriteLine
    (
    "0 - Informasiya almaq ucun\n" +
    "1 - Shoot metodu ucun\n" +
    "2 - Fire metodu ucun\n" +
    "3 - GetNeededBulletCount metodu ucun\n" +
    "4 - Reload metodu ucun\n" +
    "5 - ChangeFireMode metodu ucun metodu ucun\n" +
    "6 - Proqrami dayandirmaq ucun\n" +
    "7 - Yeni silah yaratmaq ucun\n"
    );

        do
        {
            key = Convert.ToInt32(Console.ReadLine());
            if (key == 0) // Informasiya almaq ucun
            {
                silah.GetFullInfo();
            }
            if (key == 1) // Shoot metodu ucun
            {
                silah.Shoot();
            }
            if (key == 2) // Fire metodu ucun
            {
                silah.Fire();
            }
            if (key == 3) // GetNeededBulletCount metodu ucun
            {
                silah.GetNeededBulletCount();
            }
            if (key == 4) // Reload metodu ucun
            {
                silah.Reload();
            }
            if (key == 5) // ChangeFireMode metodu ucun
            {
                silah.ChangeFireMode();
            }
            if (key == 7)
            {
                Console.Write("CapacityOfMagazine: ");
                capacityOfMagazine = Convert.ToInt32(Console.ReadLine());
                silah.CapacityOfMagazine = capacityOfMagazine;

                Console.Write("CountOfBullet: ");
                countOfBullet = Convert.ToInt32(Console.ReadLine());
                silah.CountOfBullet = countOfBullet;

                Console.Write("TimeOfMagazine: ");
                timeOfMagazine = Convert.ToInt32(Console.ReadLine());
                silah.TimeOfMagazine = timeOfMagazine;

                Console.Write("FireMode: ");
                fireMode = Console.ReadLine();
                silah.FireMode = fireMode;
            }
        }

        while (key != 6 && key <= 7 && key >= -1);
        {

        }
    }
}
