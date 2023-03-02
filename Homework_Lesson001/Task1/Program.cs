// Напишите программу, которая на вход принимает два числа и выдаёт, \какое число большее, а какое меньшее.
Console.Write("Enter first number: ");
double a = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter second number: ");
double b = Convert.ToDouble(Console.ReadLine());

if (a > b)
{
    Console.Write("max = ");
    Console.WriteLine(a);
}

else
{
    Console.Write("max = ");
    Console.WriteLine(b);
}



