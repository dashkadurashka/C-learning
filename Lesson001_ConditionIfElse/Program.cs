Console.Write("Enter username: ");
string username = Console.ReadLine();

if(username.ToLower() == "masha")
{
    Console.WriteLine("We are glad to see you, Masha!");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}