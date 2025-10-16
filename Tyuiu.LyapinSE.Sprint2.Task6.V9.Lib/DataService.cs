using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.LyapinSE.Sprint2.Task6.V9.Lib
{
    public class DataService : ISprint2Task6V9
    {
        public string FindDateOfNextDay(int m, int n)
        {
            int daysInMonth;

            switch (m)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    daysInMonth = 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    daysInMonth = 30;
                    break;
                case 2:
                    daysInMonth = 28;
                    break;
                default:
                    throw new ArgumentException("Некорректный номер месяца");
            }

            int nextDay, nextMonth;

            if (n < daysInMonth)
            {
                nextDay = n + 1;
                nextMonth = m;
            }
            else
            {
                nextDay = 1;
                nextMonth = m + 1;
            }

            return $"{nextDay}.{nextMonth}";
        }
    }
}
