using ChainOfResponsability.Models;

namespace ChainOfResponsability.WithPattern;

public class PointsCalculatorWithPattern
{
    public int CalculateOrderPoints(Order order, int day) 
    {
        var _70Bucks = new Bucks70Points();
        var _40Bucks = new Bucks40Points();
        var _20Bucks = new Bucks20Points();
        var _noPoints = new NoPoints();

        _70Bucks.SetNext(_40Bucks);
        _40Bucks.SetNext(_20Bucks);
        _20Bucks.SetNext(_noPoints);

        if (day >=16 &&  day <= 31)
        {
            return _70Bucks.CalculateOrderPoints(order) * 2;
        }

        return _70Bucks.CalculateOrderPoints(order);
    }
}
