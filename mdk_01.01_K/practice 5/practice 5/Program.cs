class program
{
    static void Main(string[] args)
    {
        int max = 0;
        Random rand = new Random();
        int[] arr = new int[10];

        for(int i = 0;i <10;i++)
        {
            arr[i] = rand.Next(0, 25);
        }

        foreach(int i in arr)
        {
            if (i > max) { max = i; }
        }

        Console.WriteLine();

        foreach (int i in arr)
        {
            Console.WriteLine("Максимальное число и разность: "+(max)+" "+(max - i));
        }

        Console.WriteLine("Введите размер квадратной матрицы: ");

        int n = Convert.ToInt16(Console.ReadLine());
        int[,] arr2 = new int[n,n];

        for(int i = 0; i < n;i++)
        { 
            for(int j = 0; j < n;j++)
            {
                if (i == j)
                {
                    Console.Write(((i+1)*(i+2))+" ");
                }
                else
                {
                    Console.Write("0 ");
                }
            }
            Console.WriteLine("");
        }
    }
}