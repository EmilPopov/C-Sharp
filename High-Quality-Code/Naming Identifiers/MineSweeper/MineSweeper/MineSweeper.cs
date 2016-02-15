namespace MineSweeper
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class MineSweeper
    {    
        public static void Main()
        {
            const int EMPTY_FIELDS = 35;

            string command = string.Empty;
            char[,] playingField = CreatePlayingField();
            char[,] mines = PutMines();
            int counter = 0;
            bool isActiveMine = false;
            List<UserInfo> highscores = new List<UserInfo>(6);
            int row = 0;
            int col = 0;
            bool isNewGame = true;
            bool wonTheGame = false;

            do
            {
                if (isNewGame)
                {
                    Console.WriteLine("Let's play 'Minesweepers'. Try stepping only on the mine-free fields. " +
                   "Commands: 'top'=> shows the highscores  'restart' => starts a new game, 'exit'=> quits the game!");
                    PrintPlayfield(playingField);
                    isNewGame = false;
                }

                Console.Write("Enter Row and Column(row col) : ");
                command = Console.ReadLine().Trim();
                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) &&
                    int.TryParse(command[2].ToString(), out col) &&
                        row <= playingField.GetLength(0) && col <= playingField.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        PrintHighscores(highscores);
                        break;
                    case "restart":
                        playingField = CreatePlayingField();
                        mines = PutMines();
                        PrintPlayfield(playingField);
                        isActiveMine = false;
                        isNewGame = false;
                        break;
                    case "exit":
                        Console.WriteLine("Bye !!!");
                        break;
                    case "turn":
                        if (mines[row, col] != '*')
                        {
                            if (mines[row, col] == '-')
                            {
                                ShowFieldValue(playingField, mines, row, col);
                                counter++;
                            }

                            if (EMPTY_FIELDS == counter)
                            {
                                wonTheGame = true;
                            }
                            else
                            {
                                PrintPlayfield(playingField);
                            }
                        }
                        else
                        {
                            isActiveMine = true;
                        }

                        break;
                    default:
                        Console.WriteLine("\nInvalid Command\n");
                        break;
                }

                if (isActiveMine)
                {
                    PrintPlayfield(mines);
                    Console.Write("\nGame Over => Points {0} Enter your nickname: ", counter);
                    string userNickname = Console.ReadLine();
                    UserInfo userPoint = new UserInfo(userNickname, counter);
                    if (highscores.Count < 5)
                    {
                        highscores.Add(userPoint);
                    }
                    else
                    {
                        for (int i = 0; i < highscores.Count; i++)
                        {
                            if (highscores[i].Points < userPoint.Points)
                            {
                                highscores.Insert(i, userPoint);
                                highscores.RemoveAt(highscores.Count - 1);
                                break;
                            }
                        }
                    }

                    highscores.Sort((UserInfo r1, UserInfo r2) => r2.Points.CompareTo(r1.Points));
                    highscores.Sort((UserInfo r1, UserInfo r2) => r2.Points.CompareTo(r1.Points));
                    PrintHighscores(highscores);
                    playingField = CreatePlayingField();
                    mines = PutMines();
                    counter = 0;
                    isActiveMine = false;
                    isNewGame = true;
                }

                if (wonTheGame)
                {
                    Console.WriteLine("\n WINNER !!!.");
                    PrintPlayfield(mines);
                    Console.WriteLine(" Enter your nickname: ");
                    string userNickname = Console.ReadLine();
                    UserInfo userUserInfo = new UserInfo(userNickname, counter);
                    highscores.Add(userUserInfo);
                    PrintHighscores(highscores);
                    playingField = CreatePlayingField();
                    mines = PutMines();
                    counter = 0;
                    wonTheGame = false;
                    isNewGame = true;
                }
            }
            while (command != "exit");
            Console.WriteLine("Press any key to exit.");
            Console.WriteLine();
            Console.Read();
        }

        private static void PrintHighscores(List<UserInfo> points)
        {
            Console.WriteLine("\nPoints : ");
            if (points.Count > 0)
            {
                for (int i = 0; i < points.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} ", i + 1, points[i].Name, points[i].Points);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Empty Point List!\n");
            }
        }

        private static void ShowFieldValue(char[,] playingField, char[,] mines, int row, int col)
        {
            char minesCount = CounterMines(mines, row, col);
            mines[row, col] = minesCount;
            playingField[row, col] = minesCount;
        }

        private static void PrintPlayfield(char[,] playingField)
        {
            int rows = playingField.GetLength(0);
            int cols = playingField.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int i = 0; i < rows; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(string.Format("{0} ", playingField[i, j]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] CreatePlayingField()
        {
            int rows = 5;
            int cols = 10;
            char[,] playingField = new char[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    playingField[i, j] = '?';
                }
            }

            return playingField;
        }

        private static char[,] PutMines()
        {
            int rows = 5;
            int cols = 10;
            char[,] playingField = new char[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    playingField[i, j] = '-';
                }
            }

            List<int> mines = new List<int>();
            while (mines.Count < 15)
            {
                Random random = new Random();
                int rndNum = random.Next(50);
                if (!mines.Contains(rndNum))
                {
                    mines.Add(rndNum);
                }
            }

            foreach (int mine in mines)
            {
                int col = mine / cols;
                int row = mine % cols;
                if (row == 0 && mine != 0)
                {
                    col--;
                    row = cols;
                }
                else
                {
                    row++;
                }

                playingField[col, row - 1] = '*';
            }

            return playingField;
        }




        private static void CalculateFieldValues(char[,] playingField)
        {
            int col = playingField.GetLength(0);
            int row = playingField.GetLength(1);

            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    if (playingField[i, j] != '*')
                    {
                        char minesCount = CounterMines(playingField, i, j);
                        playingField[i, j] = minesCount;
                    }
                }
            }
        }

        private static char CounterMines(char[,] playfield, int row, int col)
        {
            int counter = 0;
            int rows = playfield.GetLength(0);
            int cols = playfield.GetLength(1);

            if (row - 1 >= 0)
            {
                if (playfield[row - 1, col] == '*')
                {
                    counter++;
                }
            }

            if (row + 1 < rows)
            {
                if (playfield[row + 1, col] == '*')
                {
                    counter++;
                }
            }

            if (col - 1 >= 0)
            {
                if (playfield[row, col - 1] == '*')
                {
                    counter++;
                }
            }

            if (col + 1 < cols)
            {
                if (playfield[row, col + 1] == '*')
                {
                    counter++;
                }
            }

            if ((row - 1 >= 0) && (col - 1 >= 0))
            {
                if (playfield[row - 1, col - 1] == '*')
                {
                    counter++;
                }
            }

            if ((row - 1 >= 0) && (col + 1 < cols))
            {
                if (playfield[row - 1, col + 1] == '*')
                {
                    counter++;
                }
            }

            if ((row + 1 < rows) && (col - 1 >= 0))
            {
                if (playfield[row + 1, col - 1] == '*')
                {
                    counter++;
                }
            }

            if ((row + 1 < rows) && (col + 1 < cols))
            {
                if (playfield[row + 1, col + 1] == '*')
                {
                    counter++;
                }
            }

            return char.Parse(counter.ToString());
        }
    }
}