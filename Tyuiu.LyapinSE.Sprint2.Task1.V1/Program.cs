using Tyuiu.LyapinSE.Sprint2.Task1.V1.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #2 | Выполнил: Ляпин С. Е. | ИИПб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Логические операции                                               *");
Console.WriteLine("* Задание #1                                                              *");
Console.WriteLine("* Вариант #1                                                              *");
Console.WriteLine("* Выполнил: Ляпин Степан Евгеньевич | ИИПб-25-1                           *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу из операций сравнений                                *");
Console.WriteLine("* (==, !=, <, >, <=, >=, последовательность можно чередовать, но          *");
Console.WriteLine("* использовать один раз в выражении) и логических операций                *");
Console.WriteLine("*  (|, &, ||, &&, !, ^, последовательность операций не должна нарушаться) *");
Console.WriteLine("* а также арифметических выражений, которая вернет логическую             *");
Console.WriteLine("* последовательность(массив): (True, False, True, False, True, False)     *");
Console.WriteLine("* при a = 119, b = 196, c = 134, d = 327                                  *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* a = 119, b = 196, c = 134, d = 327                                      *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

int a = 119;
int b = 196;
int c = 134;
int d = 327;

bool[] res = ds.GetLogicOperations(a, b, c, d);

for (int i = 0; i < res.Length; i++)
{
    Console.WriteLine($"Результат {i + 1}: {res[i]}");
}

Console.ReadLine();