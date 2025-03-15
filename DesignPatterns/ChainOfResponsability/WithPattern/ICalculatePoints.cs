using ChainOfResponsability.Models;

namespace ChainOfResponsability.WithPattern;

public interface ICalculatePoints
{
    public int CalculateOrderPoints(Order order);
    public void SetNext(ICalculatePoints calculatePoints);
}
