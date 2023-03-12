// Метод 1 - Ничего не принимает и ничего не возвращает

void Method1()
{
    Console.WriteLine("Dasha Domanskaya");
}

//Method1();


// Метод 2 - Принимает аргументы. но ничего не возвращает

void Method2(string msg)
{
    Console.WriteLine(msg);
}

// Method2(msg: "Dashka Durashka");

void Method2_1(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
// Method2_1("Text", 4);
// Method2_1(msg: "Dasha", count: 5);

// Метод 3 - ничего не принимает, но возвращает

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
// Console.WriteLine(year);

// Метод 4 - что-то принимает и что-то возвращает

// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty; 
//     while (i < count)
//     {
//         result += text;
//         i++;
//     }
//     return result;
// }

// string res = Method4(10, "Dasha");
// Console.WriteLine(res);

string Method4(int count, string text)
{
    string result = String.Empty; 
    for(int i = 0; i< count; i++)
    {
        result += text;
    }
    return result;
}

// string res = Method4(10, "Dasha");
// Console.WriteLine(res);

for(int i = 2; i <= 10; i++)
{
    for(int j = 1; j <=10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i * j}");
    }
    Console.WriteLine();
}
