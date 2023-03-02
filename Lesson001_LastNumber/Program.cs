// Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает последнюю цифру этого числа.

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(number % 10);
