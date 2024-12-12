Console.WriteLine("What is your name?");
string name = Console.ReadLine()!;
Console.WriteLine("Hello " + name);
string botName = "Blob";
if (name == botName || name == "blob")
{
    Console.WriteLine("Woah! We have the same name!");
}
else
{
    Console.WriteLine("I am " + botName);
}

double x = 0.1f;
double y = 0.2f;
double sum = x + y;
if (sum == 0.3)
{
    Console.WriteLine("true!");
}
else
{
    Console.WriteLine("False.");
}
