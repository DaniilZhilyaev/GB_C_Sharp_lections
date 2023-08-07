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

//=====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.
// Ясна ли задача?

string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             012345
// s[3] = r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'С', 'с');
Console.WriteLine(newText);
Console.WriteLine();

// Sort arr from min to max

int [] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] <  array[minPosition]) minPosition = j;

        }

        int temporary = array[i];
        array[i] =  array[minPosition];
        array[minPosition] = temporary;
 
    }
}

PrintArray(arr);

SelectionSort(arr);
PrintArray(arr);
