// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int a = GetNumber();
int b = GetNumber();
Console.WriteLine($"Число {a} в степени {b} - {GetProduct(a, b)}");

int GetNumber()
{
    Console.Write("Input number: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}


int GetProduct(int a, int b)
{
    int power = 1;
    for (int i = 0; i < b; i++)
    {
        power = power * a;
    }
    return power;
}