using ChainOfResponsability.Models;
using ChainOfResponsability.NoPattern;
using ChainOfResponsability.WithPattern;

namespace ChainOfResponsability;

public class Execute
{
    public static void ExecuteNoPattern(decimal value, int day)
    {
        var order = new Order();
        var calculatePoints = new PointsCalculator();

        order.Value = value;
        var points = calculatePoints.CalculateOrderPoints(order, day);
        Console.WriteLine($"Day {day}: {points} pontos");
    }

    public static void ExecuteWithPattern(decimal value, int day)
    {
        var order = new Order();
        var calculatePoints = new PointsCalculatorWithPattern();

        order.Value = value;
        var points = calculatePoints.CalculateOrderPoints(order, day);
        Console.WriteLine($"Day {day}: {points} pontos");
    }
}
