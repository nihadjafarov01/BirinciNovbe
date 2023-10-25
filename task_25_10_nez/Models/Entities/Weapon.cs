using System.IO;

namespace Models.Entities;

public class Weapon
{
    private int _capacityOfMagazine;
    public Weapon(int _capacityOfMagazine, int _countOfBullet, float _timeOfMagazine, string _fireMode)
    {
        CapacityOfMagazine = _capacityOfMagazine;
        CountOfBullet = _countOfBullet;
        TimeOfMagazine = _timeOfMagazine;
        FireMode = _fireMode;
    }

    public int CapacityOfMagazine
    {
        get => _capacityOfMagazine;
        set { _capacityOfMagazine = value; }
    }

    public int CountOfBullet
    {
        get;
        set;
    }

    public float TimeOfMagazine
    {
        get ;
        set ;
    }

    public string FireMode
    {
        get;
        set;
    }

    public int Shoot() 
    {
        return CountOfBullet--;
    }

    public int Fire() 
    {
        float time = 0;
        float timePerBullet = TimeOfMagazine/CountOfBullet;   
        for (int i = CountOfBullet; i >0; i--)
        {
            if (FireMode == "avtomatik")
            {
                CountOfBullet--;
                time = TimeOfMagazine;
            }
            else if (FireMode == "tekli")
            {
                CountOfBullet--;
                time =+ timePerBullet;
                Console.WriteLine("1 gulle atildi");
                break;
            }

        }
        Console.WriteLine($"{time} saniyeye bitdi");
        return CountOfBullet;
    }

    public void GetNeededBulletCount()
    {
        Console.WriteLine($"Daragin tam dolmasi ucun lazim olan gulle sayi: {CapacityOfMagazine - CountOfBullet}"); 
    }

    public void Reload()
    {
        for (int i = CountOfBullet; i < CapacityOfMagazine; i++)
        {
            CountOfBullet++;
        }
        Console.WriteLine($"daraq yeniden doldu. Gulle sayi: {CountOfBullet}"); 
    }

    public string ChangeFireMode() 
    { 
        if ( FireMode == "tekli" )
        {
            FireMode = "avtomatik";
        }
        else if ( FireMode == "avtomatik")
        {
            FireMode = "tekli";
        }
        else
        {
            Console.WriteLine("atis modu yanlis daxil edilib!");
        }
        return FireMode;
    }

    public void GetFullInfo()
    {
        Console.WriteLine($"{CapacityOfMagazine} {CountOfBullet} {TimeOfMagazine} {FireMode}");
    }
}
