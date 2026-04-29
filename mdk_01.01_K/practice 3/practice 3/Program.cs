using System;

class Program
{
    static void Main(string[] args)
    {
        int first = 1;
        int second = 1;

        int c = 0;
        Console.WriteLine("Кол-во шагов Фибоначи:");
        int v = Convert.ToInt16(Console.ReadLine()) -2;

        for (int i = 0; i <= v; i++)
        {
            c = first + second;
            first = second;
            second = c;
            
            Console.WriteLine(c);
        }
    }
}