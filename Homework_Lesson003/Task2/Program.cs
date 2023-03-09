// Напишите программу, которая принимает на вход координаты трех точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double [] firstPoint = new double[3];
double [] secondPoint = new double[3];

for (int i = 0; i < firstPoint.Length; i++)
{
    Console.Write("Input first point: ");
    firstPoint[i] = Convert.ToInt32(Console.ReadLine());
}

for (int i = 0; i < secondPoint.Length; i++)
{
    Console.Write("Input second point: ");
    secondPoint[i] = Convert.ToInt32(Console.ReadLine());
}

double result = 0;
for (int i = 0; i < secondPoint.Length; i++)
{
    result = result + Math.Pow(secondPoint[i] - firstPoint[i], 2);
}

double finishResult = Math.Sqrt(result);
Console.WriteLine(finishResult);