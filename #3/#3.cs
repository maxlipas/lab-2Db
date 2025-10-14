//Лабораторная работа #2. Разветвляющиеся алгоритмы
//Оператор выбора
//Средний уровень Вариант #14
try
{
    Console.Write("введите x: ");
    double x = double.Parse(Console.ReadLine());
    double a = 0.5;
    double b = 4.5;
    double z = Math.Pow(Math.E, a * x);
    if (x <= 5 * a) Console.WriteLine($"y={2.5 * Math.Pow(b, 2) + a * x - 4.5 * Math.Cos(x * z)}");
    else a = 0.5;
    b = 3.7;
    z = Math.Pow(Math.E, 2 * a * x);
    if (x > b) Console.WriteLine($"y={Math.Pow(a * a - 5.4 * x, 3) + Math.Log10(x * z)}");
    else a = 0.5;
    b = 2.7;
    z = Math.Pow(Math.E, 2.5 * a * x);
    if (x > 5 * a && x <= b) Console.WriteLine($"y={Math.Sqrt(6.5 * (b * b) + (a - Math.Pow(x, 3) * z))}");
}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}