class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите число для крутой формулы: ");
        double x = Convert.ToDouble(Console.ReadLine());

        if(x >3)
        {
            Console.WriteLine("Крутая формула = " + (x * -3 + 9));
        }
        else 
        {
            Console.WriteLine("Крутая формула = " + ((x*x*x)/((x*x)-8)) );
        }

        Console.WriteLine("Введите точку a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите точку b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите точку c: ");
        double c = Convert.ToDouble(Console.ReadLine());
        
        if ((Math.Abs(b - a)) < (Math.Abs(b - c)))
        {
            Console.WriteLine("Точка А ближе");
        }
        else
        {
            Console.WriteLine("Точка С ближе");
        }
    }  
}