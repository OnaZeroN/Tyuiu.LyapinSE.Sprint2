using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.LyapinSE.Sprint2.Task7.V14.Lib
{
    public class DataService : ISprint2Task7V14
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool isInCircle = (x * x + y * y) <= 1;
            bool isInSector = y <= -x && y >= x;
            return isInCircle && isInSector;
        }
    }
}
