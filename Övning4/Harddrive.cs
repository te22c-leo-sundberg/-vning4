class Harddrive : Hardware
{
    private int rotationsPerMinute;
    public void SetRPM(int rpm)
    {
        rotationsPerMinute = rpm;
    }
    public int GetRPM()
    {
        return rotationsPerMinute;
    }
    
    private int storage;
    public void SetStorage(int s)
    {
        storage = s;
    }
    public int GetStorage()
    {
        return storage;
    }

    public Harddrive(string n, int p, int rpm, int s) : base(n, p)
    {
        name = n;
        price = p;
        rotationsPerMinute = rpm;
        storage = s;
    }
    public override void Print()
    {
        Console.WriteLine($"Name: {name}");
    Console.WriteLine($"Price: {price}$");
    Console.WriteLine($"Rotations per Minute: {rotationsPerMinute}");
    Console.WriteLine($"Storage: {storage}GB");
    }
}