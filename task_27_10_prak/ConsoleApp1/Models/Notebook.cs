namespace ConsoleApp1.Models;

internal class Notebook:Product
{
    string _model;
    string _storage;
    public string Brand{ get; set; }
    public string Model 
    {
        get => _model;
        set {
            if (value.Length >= 3 && value.Length <=30) 
            {
                _model = value;
            }
            else
            {
                Console.WriteLine("Duzgun eded daxil edin!");
            }
           }
    }
    public byte RAM { get; set; }
    public string Storage
    {
        get => _model;
        set
        {
            if (value.Length >= 3 && value.Length <= 30)
            {
                _model = value;
            }
            else
            {
                Console.WriteLine("Duzgun eded daxil edin!");
            }
        }
    }

    public Notebook(int count, int price, string model) : base(count, price)
    {
        Model = model;
    }
}
