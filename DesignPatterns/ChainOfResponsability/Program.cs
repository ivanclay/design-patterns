using ChainOfResponsability;

int[] days = { 15, 16};
decimal[] values = { 20, 100 };

Console.WriteLine("Results No Patterns");
Console.WriteLine("-------------------");
for (int i = 0; i < days.Length; i++)
{
    Execute.ExecuteNoPattern(values[i], days[i]);
}
Console.WriteLine("===========================");

Console.WriteLine("Results with Patterns");
Console.WriteLine("---------------------");
for (int i = 0; i < days.Length; i++)
{
    Execute.ExecuteWithPattern(values[i], days[i]);
}
Console.WriteLine("===========================");
