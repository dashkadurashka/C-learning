// Напишите программу, которая принимает на вход координаты точки (X и Y),
//причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

int [] points = new int [2];
for(int i = 0; i < points.Length; i ++)
{
    while(true)
    {
        Console.Write("Input number: ");
        points[i] = Convert.ToInt32(Console.ReadLine());
        if(points[i] != 0)
            break;
        else
            Console.WriteLine("Incorrect input");
    } 
}

if(points[0] > 0 && points[1] > 0)
{
    Console.WriteLine("Первая четверть");
}
else if(points[0] < 0 && points[1] > 0)
{
    Console.WriteLine("Вторая четверть");
}
else if(points[0] < 0 && points[1] < 0)
{
    Console.WriteLine("Третья четверть");
}
else
{
    Console.WriteLine("Четвертая четверть");
}