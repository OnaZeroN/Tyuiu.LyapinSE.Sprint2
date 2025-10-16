using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.LyapinSE.Sprint2.Task0.V2.Lib
{
    public class DataService : ISprint2Task0V2
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] result = new bool[6];
            result[0] = x == y + 1;   
            result[1] = x != y - 1;   
            result[2] = x < y - 1;    
            result[3] = x > y - 1;    
            result[4] = x <= y - 2;   
            result[5] = x >= y - 1;   
            return result;
        }
    }
}
