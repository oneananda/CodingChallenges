using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotSavePrin2
{
    class Bot_Saved_Princess2
    {
        static void nextMove(int n, int r, int c, String[] grid)
        {
            Dictionary<int, int> PrincessPosition = new Dictionary<int, int>();
            Dictionary<int, int> BotPosition = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                string Line = grid[i];

                char[] charArr = Line.ToCharArray();

                int ColCount = 0;
                foreach (char singleChar in charArr)
                {
                    if (singleChar == 'p')
                    {
                        PrincessPosition.Add(i, ColCount);
                    }
                    ColCount++;
                }
            }
            BotPosition.Add(r, c);

            PrintBotNextMove(PrincessPosition, BotPosition);

        }

        private static void PrintBotNextMove(Dictionary<int, int> PrincessPosition, Dictionary<int, int> BotPosition)
        {
            bool CanDoRecursive = true;
            do
            {
                int PrincessRow = -1;
                int PrincessColumn = -1;

                int BotRow = -1;
                int BotColumn = -1;

                foreach (KeyValuePair<int, int> SinglePrincessPosition in PrincessPosition)
                {
                    PrincessRow = SinglePrincessPosition.Key;
                    PrincessColumn = SinglePrincessPosition.Value;
                }

                foreach (KeyValuePair<int, int> SingleBotPosition in BotPosition)
                {
                    BotRow = SingleBotPosition.Key;
                    BotColumn = SingleBotPosition.Value;
                }

                if (PrincessRow == BotRow)
                {
                    int DistanceBetweenPrinceAndBot = PrincessColumn - BotColumn;
                    if (DistanceBetweenPrinceAndBot < 0) DistanceBetweenPrinceAndBot = DistanceBetweenPrinceAndBot * -1;
                    if (DistanceBetweenPrinceAndBot == 1)
                    {
                        CanDoRecursive = false;
                    }
                }

                if (PrincessColumn == BotColumn)
                {
                    int DistanceBetweenPrinceAndBot = PrincessRow - BotRow;
                    if (DistanceBetweenPrinceAndBot < 0) DistanceBetweenPrinceAndBot = DistanceBetweenPrinceAndBot * -1;
                    if (DistanceBetweenPrinceAndBot == 1)
                    {
                        CanDoRecursive = false;
                    }
                }

                if (PrincessColumn == BotColumn && PrincessRow == BotRow)
                {
                    CanDoRecursive = false;
                }
                else if (CanDoRecursive)
                {
                    CanDoRecursive = true;

                    if (PrincessRow > BotRow)
                    {
                        Console.WriteLine("DOWN");
                        BotPosition.Clear();
                        BotPosition.Add(BotRow + 1, BotColumn);
                    }
                    else if (PrincessRow < BotRow)
                    {
                        Console.WriteLine("UP");
                        BotPosition.Clear();
                        BotPosition.Add(BotRow - 1, BotColumn);
                    }
                    else if (PrincessRow == BotRow)
                    {
                        if (PrincessColumn < BotColumn)
                        {
                            Console.WriteLine("LEFT");
                            BotPosition.Clear();
                            BotPosition.Add(BotRow, BotColumn - 1);
                        }
                        else
                        {
                            Console.WriteLine("RIGHT");
                            BotPosition.Clear();
                            BotPosition.Add(BotRow, BotColumn + 1);
                        }
                    }

                }
            } while (CanDoRecursive);

        }

        static void Main(String[] args)
        {
            int n;

            n = int.Parse(Console.ReadLine());
            String pos;
            pos = Console.ReadLine();
            String[] position = pos.Split(' ');
            int[] int_pos = new int[2];
            int_pos[0] = Convert.ToInt32(position[0]);
            int_pos[1] = Convert.ToInt32(position[1]);
            String[] grid = new String[n];
            for (int i = 0; i < n; i++)
            {
                grid[i] = Console.ReadLine();
            }

            nextMove(n, int_pos[0], int_pos[1], grid);
            Console.ReadLine();
        }
    }
}
