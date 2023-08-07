// Type 1

void Method1()
{
    Console.WriteLine("Author name");
}
Method1();

// Type 2

void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Text");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21("Text", 4);
Method21(count: 2, msg: "New Text");

// Type 3

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);

// Type 3

string Method4(int count, string c)
{
    int i = 0;
    string result = String.Empty;

    while (i < count)
    {
        result = result + c;
        i++;
    }
    return result;
}

string res = Method4(10, "HA");
Console.WriteLine(res);

// For 

string Method5(int count2, string c2)
{
    string result2 = String.Empty;
    for(int i2 = 0; i2 < count2; i2++)
    {
        result2 = result2 + c2;
    }
    return result2;
}

string res2 = Method5(5, "Ho");
Console.WriteLine(res2);

for (int i = 2; i <= 10; i++)
{
    for (int j = 2;j<= 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i*j}");
    }
    Console.WriteLine();
}