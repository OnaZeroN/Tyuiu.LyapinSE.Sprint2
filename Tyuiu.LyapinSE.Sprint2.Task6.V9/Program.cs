using Tyuiu.LyapinSE.Sprint2.Task6.V9.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #2 | Выполнил: Ляпин С. Е. | ИИПб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Получение результата из switch                                    *");
Console.WriteLine("* Задание #6                                                              *");
Console.WriteLine("* Вариант #9                                                              *");
Console.WriteLine("* Выполнил: Ляпин Степан Евгеньевич | ИИПб-25-1                           *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая использует оператор switch вычисляет        *");
Console.WriteLine("* требуемое значение и возвращает результат.                              *"); 
Console.WriteLine("* Дата некоторого дня характеризуется двумя натуральными числами:         *");
Console.WriteLine("* m (порядковый номер месяца) и n (число). По заданным n и m определить   *");
Console.WriteLine("* дату следующего дня (принять, что n и m не характеризуют 31 декабря).   *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Введите порядковый номер месяца: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine(ds.FindDateOfNextDay(n, m));

Console.ReadKey();