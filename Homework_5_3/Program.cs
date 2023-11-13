class program
{
   

    static void Output(int[,] mas) {
        int N = mas.GetLength(0);
        int M = mas.GetLength(1);
        int s = 0;
        int[] temp = new int[M];
        for (int i = 0; i < M; i++)
        {
            temp[i] = mas[N-1,i];
        }
        /*foreach (var item in temp)
        {
            Console.Write(item);
        }*/

            for (int i = N-1; i >= 0; i--)
        {
            for (int j = 0; j < M; j++)
            {
                if (i == 0)
                {
                    mas[i, j] = temp[j];
                }
                else
                { 
                    mas[i, j] = mas[i-1, j];
                }
            }
        }
        foreach (int k in mas)
        {
            Console.Write(k);
            s++;
            if (s == M)
            {
                Console.WriteLine();
                s = 0;
            }
        }
    } 
         

    static void Main(string[] args)
    {
        Console.WriteLine("Input number of rows");
        int N = int.Parse(Console.ReadLine());
        Console.WriteLine("Input number of columns");
        int M = int.Parse(Console.ReadLine());
        int[,] mas = new int[N,M];
        Console.WriteLine("Fill the array");
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < M; j++) { 
                mas[i,j] = int.Parse(Console.ReadLine());
            }
        }
        Output(mas);
        Console.ReadKey();
    }
    
}