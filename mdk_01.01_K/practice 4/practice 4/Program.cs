class Program {
    static void Main(string[] args)
    {
        long a = 0,b = 0,h = 0, n = 0;
        try
        {
            Console.WriteLine("вводите точки: ");
            a = long.Parse(Console.ReadLine());
            b = long.Parse(Console.ReadLine());

            Console.WriteLine("вводите шаг: ");
            h = long.Parse(Console.ReadLine());
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }

        if (h == 0) { throw new ArgumentException("шаг не может быть равен нулю"); }

        if(b<a && h > 0)
        {
            n = a;
            a = b;
            b = n;
        }

        while(!(a==b))
        {
            Console.Write(a + ": ");
            Console.WriteLine(Math.Tan(a/2)+2/Math.Cos(a));
            a += h;
        }
    }
}