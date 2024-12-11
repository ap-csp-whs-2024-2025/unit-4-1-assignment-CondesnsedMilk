Console.WriteLine("What is your name?");
string name = Console.ReadLine()!;
Console.WriteLine("Hello " + name);
string botName = "Blob";
if (name == botName)
{
    Console.WriteLine("Woah! We have the same name!");
}
else
{
    Console.WriteLine("I am " + botName);
}