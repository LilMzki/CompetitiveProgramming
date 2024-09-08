using System;

//N行K列の行列に対して、その転置行列を求める

class Program
{
    static void Main()
    {
        string[] inputs = Console.ReadLine().Split(' ');
        int N = int.Parse(inputs[0]);
        int K = int.Parse(inputs[1]);

        int[,] numbers = new int[N, K];

        for (int i = 0; i < N; i++)
        {
            inputs = Console.ReadLine().Split(' ');
            for (int j = 0; j < K; j++)
            {
                numbers[i, j] = int.Parse(inputs[j]);
            }
        }

        for (int i = 0; i < K; i++)
        {
            for (int j = 0; j < N; j++)
            {
                if (j == N - 1) Console.Write($"{numbers[j, i]}\n");
                else Console.Write($"{numbers[j, i]} ");
            }
        }
    }
}