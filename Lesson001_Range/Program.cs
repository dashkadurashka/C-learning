// Напишите программу, которая на вход принимает одно число (N), 
//а на выходе показывает все целые числа в промежутке от -N до N.

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

int i = - number;

while(i <= number)
{
    Console.Write(i);
    Console.Write(",");
    i++;
}
