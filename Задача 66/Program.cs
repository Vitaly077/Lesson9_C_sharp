/*Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите M: ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Введите N: ");
        int n = int.Parse(Console.ReadLine());

        int sum = 0;
        for (int i = m; i <= n; i++)
        {
            sum += i;
        }

        Console.WriteLine("Сумма натуральных элементов от {0} до {1} равна {2}", m, n, sum);
    }
}
