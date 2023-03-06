// Напишите программу, которая выводит случайное число из отрезка [10, 99] 
// и показывает наибольшую цифру числа.

Random createNumber = new Random();
int number = createNumber.Next(10, 100);

int a = number / 10;
int b = number % 10;

if (a > b)
{
    Console.WriteLine("Первая цифра больше второй");
}
else if (b > a)
{
    Console.WriteLine("Вторя цифра больше первой");
}
else
    Console.WriteLine("Цифры равны");

// Console.WriteLine("Text example" + a);
// Console.WriteLine("Text {0} example {1}", a, b);
// Console.WriteLine($"Test example {a}");