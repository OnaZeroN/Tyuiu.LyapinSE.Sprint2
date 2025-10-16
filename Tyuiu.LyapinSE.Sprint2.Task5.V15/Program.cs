using Tyuiu.LyapinSE.Sprint2.Task5.V15.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #2 | Выполнил: Ляпин С. Е. | ИИПб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Оператор switch                                                   *");
Console.WriteLine("* Задание #5                                                              *");
Console.WriteLine("* Вариант #15                                                             *");
Console.WriteLine("* Выполнил: Ляпин Степан Евгеньевич | ИИПб-25-1                           *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая использует оператор switch вычисляет        *");
Console.WriteLine("* требуемое значение и возвращает результат.                              *");
Console.WriteLine("* Дано целое число k (1 <= k <= 365). Определить, каким днем недели       *");
Console.WriteLine("* (понедельником, вторником, …, субботой или воскресеньем) является k-й   *");
Console.WriteLine("* день не високосного года, в котором 1 января понедельник.               *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Введите значение переменной K: ");
int k = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine(ds.FindDayName(k));

Console.ReadKey();