//  Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
int count = 0;

int Prompt(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

Console.WriteLine("Input 666 for exit");
void GetCountOfNumber()
{
    while(true)
    {
        int number = Prompt("Input number: ");
        if(number == 666) break;
        else
            if(number > 0) count += 1;
    }
}

void PrintResult (int count)
{
    Console.WriteLine($"Чисел больше нуля - {count}");
}

GetCountOfNumber();
PrintResult(count);