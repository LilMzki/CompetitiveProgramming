using System;
using System.Linq;

class Program
{
    //三次元の立体のデータが入力され、それの正面から見た図を出力する問題 

    static void Main()
    {
        int[] inputs = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

        int X = inputs[0];
        int Y = inputs[1];
        int Z = inputs[2];

        char[,,] printDatas = new char[Z, X, Y];

        for (int i = 0; i < Z; i++)
        {
            for (int j = 0; j < X; j++)
            {
                string input = Console.ReadLine();
                var datas = input.ToCharArray();
                for (int k = 0; k < Y; k++)
                {
                    printDatas[i, j, k] = datas[k];
                }

                if (j == X - 1)
                {
                    Console.ReadLine();
                }
            }
        }

        char[,] frontData = new char[Z, Y];

        for (int i = 0; i < Z; i++)
        {
            for (int j = 0; j < Y; j++)
            {
                for (int k = 0; k < X; k++)
                {
                    if (printDatas[i, k, j] == '#')
                    {
                        frontData[i, j] = '#';
                        break;
                    }
                    else
                    {
                        frontData[i, j] = '.';
                    }
                }
            }
        }

        for (int i = 0; i < Z; i++)
        {
            for (int j = 0; j < Y; j++)
            {
                Console.Write(frontData[i, j]);
            }
        }
    }
}