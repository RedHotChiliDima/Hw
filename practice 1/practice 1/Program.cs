   class Program
    {
        static void Main(string[] args)
        {

        Console.WriteLine("Введите x");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите y");
        double y = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("крутая формула = " + ( Math.Pow(1+1/x*x,x)-12*x*x*y));

        Console.WriteLine("Введите длину окружности");
        double length = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Площадь круга = " +((length * length) / 12.56)); //12.56 это число Пи умноженное на 4
    }
    }
