using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.LyapinSE.Sprint2.Task5.V15.Lib;

public class DataService : ISprint2Task5V15
{
    public string FindDayName(int k)
    {
        int dayNumber = (k - 1) % 7;

        string dayName;

        switch (dayNumber)
        {
            case 0:
                dayName = "Понедельник";
                break;
            case 1:
                dayName = "Вторник";
                break;
            case 2:
                dayName = "Среда";
                break;
            case 3:
                dayName = "Четверг";
                break;
            case 4:
                dayName = "Пятница";
                break;
            case 5:
                dayName = "Суббота";
                break;
            case 6:
                dayName = "Воскресенье";
                break;
            default:
                dayName = "Ошибка";
                break;
        }

        return dayName;
    }
}
