using Tyuiu.LyapinSE.Sprint2.Task0.V2.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #2 | Выполнил: Ляпин С. Е. | ИИПб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Операции сравнения                                                *");
Console.WriteLine("* Задание #0                                                              *");
Console.WriteLine("* Вариант #2                                                              *");
Console.WriteLine("* Выполнил: Ляпин Степан Евгеньевич | ИИПб-25-1                           *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу из операций сравнений                                *");
Console.WriteLine("* (==, !=, <, >, <=, >=, последовательность операций не должна нарушаться)*");
Console.WriteLine("* и арифметических выражений, которая вернет логическую последовательность*");
Console.WriteLine("* (массив): (False, True, False, True, False, True), при x = 123, y = 123 *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* x = 123, y = 123                                                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

int x = 123;
int y = 123;

bool[] res = ds.GetCompareOperations(x, y);

for (int i = 0; i < res.Length; i++)
{
    Console.WriteLine($"Результат {i + 1}: {res[i]}");
}

Console.ReadLine();