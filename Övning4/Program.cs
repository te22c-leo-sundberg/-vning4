new Book("Potter", 67);

List<Rock> rocks = new List<Rock>();

bool success = false;
string input = "";
int rockAmount = 0;
float rockWeight = 0;

BlueCollar blue = new BlueCollar("Misty", 23);
WhiteCollar white = new WhiteCollar("Daniel", 45);
Worker work = new Worker("Jessica", 34);

blue.SetWage(5);
white.SetWage(20);
work.SetWage(12);
Console.WriteLine(blue.GetName());
Console.WriteLine(white.GetName());
Console.WriteLine(work.GetName());
Console.WriteLine(blue.GetAge());
Console.WriteLine(white.GetAge());
Console.WriteLine(work.GetAge());
Console.WriteLine(blue.GetWage());
Console.WriteLine(white.GetWage());
Console.WriteLine(work.GetWage());


Console.ReadLine();

void ConstructRocks()
{
    while (!success)
{
    Console.WriteLine("How many rocks would you like to make?");
    input = Console.ReadLine();
    success = int.TryParse(input, out rockAmount);
    if (rockAmount < 1)
    {
        success = false;
    }
}

success = false;

for (int i = 0; i < rockAmount; i++)
{
    while (!success)
    {
        Console.WriteLine("How much should your rock weigh?");
        input = Console.ReadLine();
        success = float.TryParse(input, out rockWeight);
        if (rockWeight <= 0)
        {
            success = false;
        }
        rocks.Add(new Rock(rockWeight));
    }
    success = false;
}
}