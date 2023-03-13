// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int nums = GetNumber(); 
Console.WriteLine($"Sum is {Sum(nums)}");

int GetNumber()
{
    Console.Write("Input number: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int Sum(int a)
{
    int result = 0;
    for(int i = 1; i <= a; i++)
    {
        result += i;
    }
    return result;
}

