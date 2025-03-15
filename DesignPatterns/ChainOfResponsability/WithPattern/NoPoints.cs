using ChainOfResponsability.Models;

namespace ChainOfResponsability.WithPattern;

public class NoPoints : ICalculatePoints
{
    private ICalculatePoints _next;
    public int CalculateOrderPoints(Order order)
    {
        return 0;
    }

    public void SetNext(ICalculatePoints calculatePoints)
    {

    }
}
