class Worker
{
    protected string name;
    public string GetName()
    {
        return name;
        // Console.WriteLine($"Their name is {name}");
    }
    protected int age;
    public int GetAge()
    {
        return age;
        // Console.WriteLine($"{name} is {age} years old.");
    }
    protected int wage;
    public int GetWage()
    {
        return wage;
        // Console.WriteLine($"{name} gets payed {wage}.");
    }
    public void SetWage(int n)
    {
        wage = n;
        // Console.WriteLine($"{name}'s wage is now {wage} dollars per hour.");
    }
    public Worker(string n, int a)
    {
        name = n;
        age = a;
    }
}