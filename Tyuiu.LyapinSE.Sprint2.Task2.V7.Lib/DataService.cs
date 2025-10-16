using System.Numerics;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.LyapinSE.Sprint2.Task2.V7.Lib
{
    public class DataService : ISprint2Task2V7
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            if ((y > 2 && y < 5) && ((x > 2 && x < 6) || (x > 8 && x < 13)))
            {
                return true;
            }
            if ((y == 5) && (x > 2 && x < 13))
            {
                return true;
            }
            if ((y > 5 && y < 8) && (x > 2 && x < 14))
            {
                return true;
            }
            if ((y == 8) && (x > 3 && x < 14))
            {
                return true;
            }
            if ((y > 8 && y < 11) && ((x > 3 && x < 6) && (x > 9 && x < 13)))
            {
                return true;
            }
            if ((y == 11) && ((x > 2 && x < 6) && (x > 9 && x < 13)))
            {
                return true;
            }
            if ((y == 12) && ((x > 3 && x < 7) && (x == 10)))
            {
                return true;
            }
            if ((y == 13) && (x > 3 && x < 7))
            {
                return true;
            }
            return false;
        }
    }
}
