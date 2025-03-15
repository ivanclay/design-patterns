using ChainOfResponsability.Models;

namespace ChainOfResponsability.NoPattern;

public class PointsCalculator
{
    private int _points;
    public int CalculateOrderPoints(Order order, int day) 
    {
        if (order.Value >= 70)
        {
            _points = Convert.ToInt32(order.Value / 5);
        }
        else if (order.Value >= 40)
        {
            _points = Convert.ToInt32(order.Value / 7);
        }
        else if (order.Value >= 20)
        {
            _points = Convert.ToInt32(order.Value / 10);
        }
        else
        {
            return 0;
        }

        if(day >=16 &&  day <= 31)
        {
            return _points * 2;
        }

        return _points;
    }
}
