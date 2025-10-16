using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.LyapinSE.Sprint2.Task7.V14.Lib
{
    public class DataService : ISprint2Task7V14
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool isInCircle = (Math.Pow(x, 2) + Math.Pow(y, 2)) <= 1;
            bool isInShaded = !((x < 0 && y < -x) || (y < 0 && x < 0));

            return isInCircle && isInShaded;
        }
    }
}
