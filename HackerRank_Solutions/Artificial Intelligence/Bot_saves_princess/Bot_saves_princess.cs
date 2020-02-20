using System;
using System.Collections.Generic;
using System.IO;
class Solution {

 static void displayPathtoPrincess(int n, String[] grid)
        {
            Dictionary<int, int> PrincessPosition = new Dictionary<int, int>();
            Dictionary<int, int> BotPosition = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                string Line = grid[i];
                if (Line.Substring(0, 1) == "p")
                {
                    PrincessPosition.Add(i, 0);
                }
                else if (Line.Substring(n - 1, 1) == "p")
                {
                    PrincessPosition.Add(i, n - 1);
                }
            }

            int TempVar = ((n - 1) / 2) + 1;
            BotPosition.Add(TempVar - 1, TempVar - 1);

            DoMoveTowardsPrincess(PrincessPosition, BotPosition);

        }

        private static void DoMoveTowardsPrincess(Dictionary<int, int> PrincessPosition, Dictionary<int, int> BotPosition)
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

                if (PrincessRow < BotRow)
                {
                    Console.WriteLine("UP");
                    BotPosition.Clear();
                    BotPosition.Add(BotRow - 1, BotColumn);
                }
                else if (PrincessRow > BotRow)
                {
                    Console.WriteLine("DOWN");
                    BotPosition.Clear();
                    BotPosition.Add(BotRow + 1, BotColumn);
                }
                else if (PrincessRow == BotRow)
                {
                    if (PrincessColumn > BotColumn)
                    {
                        Console.WriteLine("RIGHT");
                        BotPosition.Clear();
                        BotPosition.Add(BotRow, BotColumn + 1);
                    }
                    else if (PrincessColumn < BotColumn)
                    {
                        Console.WriteLine("LEFT");
                        BotPosition.Clear();
                        BotPosition.Add(BotRow, BotColumn - 1);
                    }
                    else if (PrincessColumn == BotColumn)
                    {
                        //Console.WriteLine("LEFT");
                        CanDoRecursive = false;
                    }
                }



            } while (CanDoRecursive);
        }

static void Main(String[] args) {
        int m;

        m = int.Parse(Console.ReadLine());

        String[] grid  = new String[m];
        for(int i=0; i < m; i++) {
            grid[i] = Console.ReadLine(); 
        }

        displayPathtoPrincess(m,grid);
     }
}