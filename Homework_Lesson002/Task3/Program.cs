// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

Random weekDay = new Random();
int number = weekDay.Next(1, 8);
Console.WriteLine(number);

if (number == 6 || number == 7)
{
    Console.WriteLine("Yes");
}
else Console.WriteLine("No");