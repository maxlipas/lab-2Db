//Лабораторная работа #2. Разветвляющиеся алгоритмы
//Условные операторы
//высокий уровень Вариант #14
try
{
    Console.Write("введите средний балл по диплому: ");
    double a=double.Parse(Console.ReadLine());
    Console.Write("введите стаж работы: ");
    double b=double.Parse(Console.ReadLine());
    if (b == 0) if (a * 1 >= 45) Console.WriteLine("прошел");
    else Console.WriteLine("не прошел");
    else if (b <=2 && b>=0) if (a * 13 >= 45) Console.WriteLine("прошел");
    else Console.WriteLine("не прошел");
    else if (b>=2 && b <= 5) if (a * 16 >= 45) Console.WriteLine("прошел");
    else Console.WriteLine("не прошел");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}