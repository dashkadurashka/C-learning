//  Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number < 1000)
{
    int secondNumber = number % 100 / 10;
    Console.WriteLine($"Second number {secondNumber}");

}
else
{
    Console.WriteLine("Incorrect number");
}
