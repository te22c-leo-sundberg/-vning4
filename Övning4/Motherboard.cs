class Motherboard : Hardware
{
    private bool wifi;
    public void SetWiFi(bool wf)
    {
        wifi = wf;
    }
    public bool GetWiFi()
    {
        return wifi;
    }

    public Motherboard(string n, int p, bool wf) : base(n, p)
    {
        name = n;
        price = p;
        wifi = wf;
    }
    public override void Print()
    {
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Price: {price}$");
        Console.WriteLine($"Wifi: {wifi}");
    }
}