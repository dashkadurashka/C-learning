// Задача 26: Напишите программу, которая принимает на вход число 
//и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5
// Задача 28: Напишите программу, которая принимает на вход число N 
// и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int GetNumber()
{
    Console.Write("Input number: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int GetLengthArray(int number)
{
    char[] array = number.ToString().ToCharArray();
    int length = array.Length;
    return length;
}

int GetProductToNumber(int number)
{
    int product = 1;
    for (int i = 1; i <= number; i++)
    {
        product *= i;

    }
    return product;
}


// int nums = GetNumber();
// Console.WriteLine($"Количество цифр в числе - {GetLengthArray(nums)}");

int number = GetNumber();
Console.WriteLine($"Произведение чисел от 1 до {number} - {GetProductToNumber(number)}");
