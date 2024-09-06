using System;
class Program
{
    static void Main()
    {
        string[] inputs = Console.ReadLine().Split(' ');
        int n = int.Parse(inputs[0]);
        int h = int.Parse(inputs[1]);
        int w = int.Parse(inputs[2]);

        Grid _grid = new Grid { square_state = new int[h, w] };

        GameManager gameManager = new GameManager { grid = _grid, H = h, W = w };

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                inputs = Console.ReadLine().Split(' ');
                int _x = int.Parse(inputs[0]);
                int _y = int.Parse(inputs[1]);
                int _size = int.Parse(inputs[2]);

                gameManager.PaintGrid(_x, _y, _size, j + 1);
            }
        }

        int p1Count = 0;
        int p2Count = 0;
        int p3Count = 0;

        foreach (var item in gameManager.grid.square_state)
        {
            switch (item)
            {
                case 1: p1Count++; break;
                case 2: p2Count++; break;
                case 3: p3Count++; break;
            }
        }

        Console.WriteLine($"{p1Count} {p2Count} {p3Count}");
    }
}


public class Grid
{
    public int[,] square_state;
}

public class GameManager
{
    public Grid grid;
    public int H;
    public int W;
    public void PaintGrid(int x, int y, int size, int player_index)
    {
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                if (y + j < W && x + i < H)
                {
                    grid.square_state[x + i, y + j] =
                            GetPaintedSquareState(grid, x + i, y + j, player_index);
                }
            }
        }
    }

    int GetPaintedSquareState(Grid grid, int x, int y, int player_index)
    {
        int[] p_indexes = { 1, 2, 3 };
        if (grid.square_state[x, y] == 0 || grid.square_state[x, y] == player_index)
        {
            return player_index;
        }
        else
        {
            return 6 - player_index - grid.square_state[x, y];
        }

    }

}
