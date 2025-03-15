using ChainOfResponsability.Models;

namespace ChainOfResponsability.WithPattern;

public class Bucks70Points : ICalculatePoints
{
    private ICalculatePoints _next;
    public int CalculateOrderPoints(Order order)
    {
        if (order.Value >= 70)
        {
            return Convert.ToInt32(order.Value / 5);
        }

        return _next.CalculateOrderPoints(order);
    }

    public void SetNext(ICalculatePoints calculatePoints)
    {
        _next = calculatePoints;
    }
}
