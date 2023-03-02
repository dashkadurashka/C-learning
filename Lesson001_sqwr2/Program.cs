// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
Console.Write("Enter first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter first number: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number2 * number2 == number1)
{
    Console.WriteLine("Yes");
}

else
{
    Console.WriteLine("No");
}
