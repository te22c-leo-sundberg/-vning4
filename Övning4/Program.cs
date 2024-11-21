using System.Runtime.InteropServices;

List<Hardware> hardware = new List<Hardware>();

bool success = false;
string input = "";
string name;
int result = 0;
int result2 = 0;
int result3 = 0;
int result4 = 0;
bool boolResult = true;

while(!success)
{
    Console.WriteLine("What part would you like to create between [1] Processor, [2] Motherboard, [3] Harddrive");
    input = Console.ReadLine();
    success = int.TryParse(input, out result);
    if (result < 1 || result > 3)
    {
        success = false;
    }
}
if (result == 1)
{
    CreateProcessor(hardware);
}
else if (result == 2)
{
    CreateMotherboard(hardware);
}
else if (result == 3)
{
    CreateHarddrive(hardware);
}

Console.ReadLine();

void CreateProcessor(List<Hardware> hardware)
{
    name = GetName();
    Console.WriteLine("What should the price be?");
    GetResult(result);
    Console.WriteLine("What should the clock speed be?");
    GetResult(result2);
    Console.WriteLine("How many cores should the processor have?");
    GetResult(result3);
    Console.WriteLine("How many threads should the processor have?");
    GetResult(result4);

    hardware.Add(new Processor(name, result, result2, result3, result4));

    Console.WriteLine("Created a Processor with the following modifications:");
    hardware.Last().Print();
}
void CreateMotherboard(List<Hardware> hardware)
{
    name = GetName();
    Console.WriteLine("What should the price be?");
    GetResult(result);
    Console.WriteLine("Do you want WiFi for your motherboard?");
    boolResult = GetBoolResult();
    
    hardware.Add(new Motherboard(name, result, boolResult));

    Console.WriteLine("Created a Motherboard with the following modifications:");
    hardware.Last().Print();
}
void CreateHarddrive(List<Hardware> hardware)
{
    name = GetName();
    Console.WriteLine("What should the price be?");
    GetResult(result);
    Console.WriteLine("How many Rotations per Minute should your harddrive be capable of?");
    GetResult(result2);
    Console.WriteLine("How many Gigabytes of storage do you want?");
    GetResult(result3);

    hardware.Add(new Harddrive(name, result, result2, result3));

    hardware.Last().Print();
}
static string GetName()
{
    string input;
    Console.WriteLine("What do you want to name the hardware?");
    input = Console.ReadLine();
    return input;
}
static void GetResult(int r)
{
    bool success = false;
    string input = "";
    while (!success)
    {
        input = Console.ReadLine();
        success = int.TryParse(input, out r);
        if (r < 0)
        {
            success = false;
        }
    }
}
static bool GetBoolResult()
{
    bool success = false;
    string input = "";
    while (!success)
    {
        Console.WriteLine("[Yes] or [No]?");
        input = Console.ReadLine().ToUpper();
        if (input == "YES")
        {
            return true;
        }
        else if (input == "NO")
        {
            return false;
        }
    }

    return false;
}



// new Book("Potter", 67);

// List<Rock> rocks = new List<Rock>();

// bool success = false;
// string input = "";
// int rockAmount = 0;
// float rockWeight = 0;

// BlueCollar blue = new BlueCollar("Misty", 23);
// WhiteCollar white = new WhiteCollar("Daniel", 45);
// Worker work = new Worker("Jessica", 34);

// blue.SetWage(5);
// white.SetWage(20);
// work.SetWage(12);
// Console.WriteLine(blue.GetName());
// Console.WriteLine(white.GetName());
// Console.WriteLine(work.GetName());
// Console.WriteLine(blue.GetAge());
// Console.WriteLine(white.GetAge());
// Console.WriteLine(work.GetAge());
// Console.WriteLine(blue.GetWage());
// Console.WriteLine(white.GetWage());
// Console.WriteLine(work.GetWage());


// Console.ReadLine();

// void ConstructRocks()
// {
//     while (!success)
// {
//     Console.WriteLine("How many rocks would you like to make?");
//     input = Console.ReadLine();
//     success = int.TryParse(input, out rockAmount);
//     if (rockAmount < 1)
//     {
//         success = false;
//     }
// }

// success = false;

// for (int i = 0; i < rockAmount; i++)
// {
//     while (!success)
//     {
//         Console.WriteLine("How much should your rock weigh?");
//         input = Console.ReadLine();
//         success = float.TryParse(input, out rockWeight);
//         if (rockWeight <= 0)
//         {
//             success = false;
//         }
//         rocks.Add(new Rock(rockWeight));
//     }
//     success = false;
// }
// }