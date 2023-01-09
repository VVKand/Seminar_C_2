// Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("Введите цифру дня недели");
int N = Convert.ToInt32(Console.ReadLine());
if (N > 0 && N < 8)
    if (N == 6 || N == 7) Console.WriteLine("Выходной");
    else 
        Console.WriteLine("Рабочий");
else
Console.WriteLine("нет такого дня недели");