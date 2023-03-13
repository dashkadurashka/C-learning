// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
// 82 -> 10
// 9012 -> 12

int number = GetNumber();
Console.WriteLine(GetSum(number));

int GetNumber()
{
    Console.Write("Input number: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int GetSum(int number)
{
    char[] array = number.ToString().ToCharArray();
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        sum = sum + number % 10;
        number = number / 10;
    }
    return sum;
}