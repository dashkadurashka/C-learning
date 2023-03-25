double Factorial (int num)
{
    if(num == 1) return 1; // !1 = 1; !0 = 1
    else return num * Factorial(num - 1); 
}

Console.WriteLine(Factorial(20));

for(int i = 1; i < 50; i++)
{ 
    Console.WriteLine(Factorial(i));
}