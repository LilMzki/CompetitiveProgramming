using System;
class Program
{
    static int N;
    static int X;
    static int Y;
    static int Z;
    static int A;
    static int B;
    static int C;
    static void Main()
    {
        FetchInputs();

        List<int> totalPrices = new List<int>();

        int iMax = 0;
        while (iMax * X < N) { iMax++; }
        int jMax = 0;
        while (jMax * Y < N) { jMax++; }
        int kMax = 0;
        while (kMax * Z < N) { kMax++; }

        for (int i = 0; i <= iMax; i++)
        {
            for (int j = 0; j <= jMax; j++)
            {
                for (int k = 0; k <= kMax; k++)
                {
                    if (i + X + j * Y + k * Z >= N)
                    {
                        int totalPrice = i * A + j * B + k * C;
                        totalPrices.Add(totalPrice);
                    }
                }
            }
        }

        Console.WriteLine(totalPrices.Min());

    }

    static void FetchInputs()
    {
        N = int.Parse(Console.ReadLine());
        string[] inputs = Console.ReadLine().Split(' ');
        X = int.Parse(inputs[0]);
        A = int.Parse(inputs[1]);
        inputs = Console.ReadLine().Split(' ');
        Y = int.Parse(inputs[0]);
        B = int.Parse(inputs[1]);
        inputs = Console.ReadLine().Split(' ');
        Z = int.Parse(inputs[0]);
        C = int.Parse(inputs[1]);
    }


}