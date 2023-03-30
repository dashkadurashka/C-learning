// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int sum = 0;
int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}


int SumAllNumbers(int m, int n )
{
   
    if (m > n) return sum;
    Console.Write(m + " ");
    sum += m;
    return SumAllNumbers((m + 1), n);
}

void PrintSum(int sum)
{
    Console.WriteLine(sum);
}

int m = Prompt("M: ");
int n = Prompt("N: ");

SumAllNumbers(m, n);
Console.WriteLine();
PrintSum(sum);