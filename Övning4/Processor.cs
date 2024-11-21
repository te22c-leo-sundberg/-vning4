class Processor : Hardware
{
    private int clockSpeed;
    public void SetClockSpeed(int clockS)
    {
        clockSpeed = clockS;
    }
    public int GetClockSpeed()
    {
        return clockSpeed;
    }

    private int cores;
    public void SetCores(int c)
    {
        cores = c;
    }
    public int GetCores()
    {
        return cores;
    }

    private int threads;
    public void SetThreads(int t)
    {
        threads = t;
    }
    public int GetThreads()
    {
        return threads;
    }

    public Processor(string n, int p, int clockS, int c, int t) : base(n, p)
    {
        name = n;
        price = p;
        clockSpeed = clockS;
        cores = c;
        threads = t;
    }

    public override void Print()
    {
    Console.WriteLine($"Name: {name}");
    Console.WriteLine($"Price: {price}$");
    Console.WriteLine($"Clock Speed: {clockSpeed}Hz$");
    Console.WriteLine($"Cores: {cores}");
    Console.WriteLine($"Threads: {threads}");
        
    }
}