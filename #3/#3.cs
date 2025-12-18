//Лабораторная работа #2. Разветвляющиеся алгоритмы
//Оператор выбора
//Средний уровень Вариант #14
try
{
    Console.Write("Введите x: ");
    double x = double.Parse(Console.ReadLine());
    double y = 0;
    double a, b, z;
    int condition=0;
    if (x <= 5 * 0.5)
    {
        condition = 1;
    }
    else if (x > 3.7) 
    {
        condition = 2;
    }
    else if(5*0.5<x||x<=2.7)
    {
        condition = 3;
    }
    switch (condition)
    {
        case 1:
            a = 0.5;
            b = 4.5;
            z = Math.Pow(Math.E, a * x);
            y = 2.5 * Math.Pow(b, 2) + a * x - 4.5 * Math.Cos(x * z);
            Console.WriteLine($"y = {y}");
            break;

        case 2: 
            a = 0.5;
            b = 3.7;
            z = Math.Pow(Math.E, 2 * a * x);
            y = Math.Pow(a * a - 5.4 * x, 3) + Math.Log10(x * z);
            Console.WriteLine($"y = {y}");
            break;

        case 3: 
            a = 0.5;
            b = 2.7;
            z = Math.Pow(Math.E, 2.5 * a * x);
            y = Math.Sqrt(6.5 * Math.Pow(b, 2) + (a - Math.Pow(x, 3) * z));
            Console.WriteLine($"y = {y}");
            break;
    }
}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}