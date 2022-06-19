using System;

namespace proje_3
{
    class Program
    {
        static bool Pawn(int beg0, int beg1, int fin0, int fin1, int[,] color, char[,] board)
        {
            bool validity = false;
            if (color[beg1, beg0] == 1)//red
            {
                if (beg1 == 1)
                {
                    if ((fin0 == beg0 && fin1 == beg1 + 2 && board[beg1 + 1, beg0] == '.' && board[beg1 + 2, beg0] == '.') ||
                        (fin0 == beg0 && fin1 == beg1 + 1 && board[beg1 + 1, beg0] == '.') ||
                        (fin0 == beg0 + 1 && fin1 == beg1 + 1 && color[beg1 + 1, beg0 + 1] != color[beg1, beg0] && board[beg1 + 1, beg0 + 1] != '.') ||
                        (fin0 == beg0 - 1 && fin1 == beg1 + 1 && color[beg1 + 1, beg0 - 1] != color[beg1, beg0] && board[beg1 + 1, beg0 - 1] != '.'))
                    {
                        validity = true;
                    }
                    else
                    {
                        Console.SetCursorPosition(50, 5);
                        Console.WriteLine("Invalid move");
                    }
                }
                else
                {
                    if ((fin0 == beg0 && fin1 == beg1 + 1 && board[beg1 + 1, beg0] == '.') ||
                        (fin0 == beg0 + 1 && fin1 == beg1 + 1 && color[beg1 + 1, beg0 + 1] != color[beg1, beg0] && board[beg1 + 1, beg0 + 1] != '.') ||
                        (fin0 == beg0 - 1 && fin1 == beg1 + 1 && color[beg1 + 1, beg0 - 1] != color[beg1, beg0] && board[beg1 + 1, beg0 - 1] != '.'))
                    {
                        validity = true;
                    }
                    else
                    {
                        Console.SetCursorPosition(50, 5);
                        Console.WriteLine("Invalid move");
                    }
                }
            }
            else//blue
            {
                if (beg1 == 6)
                {
                    if ((fin0 == beg0 && fin1 == beg1 - 2 && board[beg1 - 1, beg0] == '.' && board[beg1 - 2, beg0] == '.') ||
                        (fin0 == beg0 && fin1 == beg1 - 1 && board[beg1 - 1, beg0] == '.') ||
                        (fin0 == beg0 + 1 && fin1 == beg1 - 1 && color[beg1 - 1, beg0 + 1] != color[beg1, beg0] && board[beg1 - 1, beg0 + 1] != '.') ||
                        (fin0 == beg0 - 1 && fin1 == beg1 - 1 && color[beg1 - 1, beg0 - 1] != color[beg1, beg0] && board[beg1 - 1, beg0 - 1] != '.'))
                    {
                        validity = true;
                    }
                    else
                    {
                        Console.SetCursorPosition(50, 5);
                        Console.WriteLine("Invalid move");
                    }
                }
                else
                {
                    if ((fin0 == beg0 && fin1 == beg1 - 1 && board[beg1 - 1, beg0] == '.') ||
                        (fin0 == beg0 + 1 && fin1 == beg1 - 1 && color[beg1 - 1, beg0 + 1] != color[beg1, beg0] && board[beg1 - 1, beg0 + 1] != '.') ||
                        (fin0 == beg0 - 1 && fin1 == beg1 - 1 && color[beg1 - 1, beg0 - 1] != color[beg1, beg0] && board[beg1 - 1, beg0 - 1] != '.'))
                    {
                        validity = true;
                    }
                    else
                    {
                        Console.SetCursorPosition(50, 5);
                        Console.WriteLine("Invalid move");
                    }
                }
            }
            return validity;
        }
        static bool King(int beg0, int beg1, int fin0, int fin1, int[,] color, char[,] board)
        {
            bool validity = false;
            if ((fin0 == beg0 + 1 && fin1 == beg1 + 1 && (color[beg1 + 1, beg0 + 1] != color[beg1, beg0] || board[beg1 + 1, beg0 + 1] == '.')) ||
                (fin0 == beg0 - 1 && fin1 == beg1 + 1 && (color[beg1 + 1, beg0 - 1] != color[beg1, beg0] || board[beg1 + 1, beg0 - 1] == '.')) ||
                (fin0 == beg0 + 1 && fin1 == beg1 - 1 && (color[beg1 - 1, beg0 + 1] != color[beg1, beg0] || board[beg1 - 1, beg0 + 1] == '.')) ||
                (fin0 == beg0 - 1 && fin1 == beg1 - 1 && (color[beg1 - 1, beg0 - 1] != color[beg1, beg0] || board[beg1 - 1, beg0 - 1] == '.')) ||
                (fin0 == beg0 && fin1 == beg1 + 1 && (color[beg1 + 1, beg0] != color[beg1, beg0] || board[beg1 + 1, beg0] == '.')) ||
                (fin0 == beg0 && fin1 == beg1 - 1 && (color[beg1 - 1, beg0] != color[beg1, beg0] || board[beg1 - 1, beg0] == '.')) ||
                (fin0 == beg0 + 1 && fin1 == beg1 && (color[beg1, beg0 + 1] != color[beg1, beg0] || board[beg1, beg0 + 1] == '.')) ||
                (fin0 == beg0 - 1 && fin1 == beg1 && (color[beg1, beg0 - 1] != color[beg1, beg0] || board[beg1, beg0 - 1] == '.')))
            {
                validity = true;
            }
            else
            {
                Console.SetCursorPosition(50, 5);
                Console.WriteLine("Invalid move");
            }
            return validity;
        }

        static bool Queen(int beg0, int beg1, int fin0, int fin1, int[,] color, char[,] board)
        {
            bool validity = false;
            if (Bishop(beg0, beg1, fin0, fin1, color, board) == true || Rook(beg0, beg1, fin0, fin1, color, board) == true)
            {
                validity = true;
            }
            else
            {
                Console.SetCursorPosition(50, 5);
                Console.WriteLine("Invalid move");
            }
            return validity;
        }
        static bool Bishop(int beg0, int beg1, int fin0, int fin1, int[,] color, char[,] board)
        {
            bool validity = false;
            if ((fin0 == beg0 + 1 && fin1 == beg1 + 1 && (color[beg1 + 1, beg0 + 1] != color[beg1, beg0] || board[beg1 + 1, beg0 + 1] == '.')) ||
                (fin0 == beg0 + 2 && fin1 == beg1 + 2 && board[beg1 + 1, beg0 + 1] == '.' && (color[beg1 + 2, beg0 + 2] != color[beg1, beg0] || board[beg1 + 2, beg0 + 2] == '.')) ||
                (fin0 == beg0 + 3 && fin1 == beg1 + 3 && board[beg1 + 1, beg0 + 1] == '.' && board[beg1 + 2, beg0 + 2] == '.' && (color[beg1 + 3, beg0 + 3] != color[beg1, beg0] || board[beg1 + 3, beg0 + 3] == '.')) ||
                (fin0 == beg0 + 4 && fin1 == beg1 + 4 && board[beg1 + 1, beg0 + 1] == '.' && board[beg1 + 2, beg0 + 2] == '.' && board[beg1 + 3, beg0 + 3] == '.' && (color[beg1 + 4, beg0 + 4] != color[beg1, beg0] || board[beg1 + 4, beg0 + 4] == '.')) ||
                (fin0 == beg0 + 5 && fin1 == beg1 + 5 && board[beg1 + 1, beg0 + 1] == '.' && board[beg1 + 2, beg0 + 2] == '.' && board[beg1 + 3, beg0 + 3] == '.' && board[beg1 + 4, beg0 + 4] == '.' && (color[beg1 + 5, beg0 + 5] != color[beg1, beg0] || board[beg1 + 5, beg0 + 5] == '.')) ||
                (fin0 == beg0 + 6 && fin1 == beg1 + 6 && board[beg1 + 1, beg0 + 1] == '.' && board[beg1 + 2, beg0 + 2] == '.' && board[beg1 + 3, beg0 + 3] == '.' && board[beg1 + 4, beg0 + 4] == '.' && board[beg1 + 5, beg0 + 5] == '.' && (color[beg1 + 6, beg0 + 6] != color[beg1, beg0] || board[beg1 + 6, beg0 + 6] == '.')) ||
                (fin0 == beg0 + 7 && fin1 == beg1 + 7 && board[beg1 + 1, beg0 + 1] == '.' && board[beg1 + 2, beg0 + 2] == '.' && board[beg1 + 3, beg0 + 3] == '.' && board[beg1 + 4, beg0 + 4] == '.' && board[beg1 + 5, beg0 + 5] == '.' && board[beg1 + 6, beg0 + 6] == '.' && (color[beg1 + 7, beg0 + 7] != color[beg1, beg0] || board[beg1 + 7, beg0 + 7] == '.')) ||
                (fin0 == beg0 - 1 && fin1 == beg1 + 1 && (color[beg1 + 1, beg0 - 1] != color[beg1, beg0] || board[beg1 + 1, beg0 - 1] == '.')) ||
                (fin0 == beg0 - 2 && fin1 == beg1 + 2 && board[beg1 + 1, beg0 - 1] == '.' && (color[beg1 + 2, beg0 - 2] != color[beg1, beg0] || board[beg1 + 2, beg0 - 2] == '.')) ||
                (fin0 == beg0 - 3 && fin1 == beg1 + 3 && board[beg1 + 1, beg0 - 1] == '.' && board[beg1 + 2, beg0 - 2] == '.' && (color[beg1 + 3, beg0 - 3] != color[beg1, beg0] || board[beg1 + 3, beg0 - 3] == '.')) ||
                (fin0 == beg0 - 4 && fin1 == beg1 + 4 && board[beg1 + 1, beg0 - 1] == '.' && board[beg1 + 2, beg0 - 2] == '.' && board[beg1 + 3, beg0 - 3] == '.' && (color[beg1 + 4, beg0 - 4] != color[beg1, beg0] || board[beg1 + 4, beg0 - 4] == '.')) ||
                (fin0 == beg0 - 5 && fin1 == beg1 + 5 && board[beg1 + 1, beg0 - 1] == '.' && board[beg1 + 2, beg0 - 2] == '.' && board[beg1 + 3, beg0 - 3] == '.' && board[beg1 + 4, beg0 - 4] == '.' && (color[beg1 + 5, beg0 - 5] != color[beg1, beg0] || board[beg1 + 5, beg0 - 5] == '.')) ||
                (fin0 == beg0 - 6 && fin1 == beg1 + 6 && board[beg1 + 1, beg0 - 1] == '.' && board[beg1 + 2, beg0 - 2] == '.' && board[beg1 + 3, beg0 - 3] == '.' && board[beg1 + 4, beg0 - 4] == '.' && board[beg1 + 5, beg0 - 5] == '.' && (color[beg1 + 6, beg0 - 6] != color[beg1, beg0] || board[beg1 + 6, beg0 - 6] == '.')) ||
                (fin0 == beg0 - 7 && fin1 == beg1 + 7 && board[beg1 + 1, beg0 - 1] == '.' && board[beg1 + 2, beg0 - 2] == '.' && board[beg1 + 3, beg0 - 3] == '.' && board[beg1 + 4, beg0 - 4] == '.' && board[beg1 + 5, beg0 - 5] == '.' && board[beg1 + 6, beg0 - 6] == '.' && (color[beg1 + 7, beg0 - 7] != color[beg1, beg0] || board[beg1 + 7, beg0 - 7] == '.')) ||
                (fin0 == beg0 + 1 && fin1 == beg1 - 1 && (color[beg1 - 1, beg0 + 1] != color[beg1, beg0] || board[beg1 - 1, beg0 + 1] == '.')) ||
                (fin0 == beg0 + 2 && fin1 == beg1 - 2 && board[beg1 - 1, beg0 + 1] == '.' && (color[beg1 - 2, beg0 + 2] != color[beg1, beg0] || board[beg1 - 2, beg0 + 2] == '.')) ||
                (fin0 == beg0 + 3 && fin1 == beg1 - 3 && board[beg1 - 1, beg0 + 1] == '.' && board[beg1 - 2, beg0 + 2] == '.' && (color[beg1 - 3, beg0 + 3] != color[beg1, beg0] || board[beg1 - 3, beg0 + 3] == '.')) ||
                (fin0 == beg0 + 4 && fin1 == beg1 - 4 && board[beg1 - 1, beg0 + 1] == '.' && board[beg1 - 2, beg0 + 2] == '.' && board[beg1 - 3, beg0 + 3] == '.' && (color[beg1 - 4, beg0 + 4] != color[beg1, beg0] || board[beg1 - 4, beg0 + 4] == '.')) ||
                (fin0 == beg0 + 5 && fin1 == beg1 - 5 && board[beg1 - 1, beg0 + 1] == '.' && board[beg1 - 2, beg0 + 2] == '.' && board[beg1 - 3, beg0 + 3] == '.' && board[beg1 - 4, beg0 + 4] == '.' && (color[beg1 - 5, beg0 + 5] != color[beg1, beg0] || board[beg1 - 5, beg0 + 5] == '.')) ||
                (fin0 == beg0 + 6 && fin1 == beg1 - 6 && board[beg1 - 1, beg0 + 1] == '.' && board[beg1 - 2, beg0 + 2] == '.' && board[beg1 - 3, beg0 + 3] == '.' && board[beg1 - 4, beg0 + 4] == '.' && board[beg1 - 5, beg0 + 5] == '.' && (color[beg1 - 6, beg0 + 6] != color[beg1, beg0] || board[beg1 - 6, beg0 + 6] == '.')) ||
                (fin0 == beg0 + 7 && fin1 == beg1 - 7 && board[beg1 - 1, beg0 + 1] == '.' && board[beg1 - 2, beg0 + 2] == '.' && board[beg1 - 3, beg0 + 3] == '.' && board[beg1 - 4, beg0 + 4] == '.' && board[beg1 - 5, beg0 + 5] == '.' && board[beg1 - 6, beg0 + 6] == '.' && (color[beg1 - 7, beg0 + 7] != color[beg1, beg0] || board[beg1 - 7, beg0 + 7] == '.')) ||
                (fin0 == beg0 - 1 && fin1 == beg1 - 1 && (color[beg1 - 1, beg0 - 1] != color[beg1, beg0] || board[beg1 - 1, beg0 - 1] == '.')) ||
                (fin0 == beg0 - 2 && fin1 == beg1 - 2 && board[beg1 - 1, beg0 - 1] == '.' && (color[beg1 - 2, beg0 - 2] != color[beg1, beg0] || board[beg1 - 2, beg0 - 2] == '.')) ||
                (fin0 == beg0 - 3 && fin1 == beg1 - 3 && board[beg1 - 1, beg0 - 1] == '.' && board[beg1 - 2, beg0 - 2] == '.' && (color[beg1 - 3, beg0 - 3] != color[beg1, beg0] || board[beg1 - 3, beg0 - 3] == '.')) ||
                (fin0 == beg0 - 4 && fin1 == beg1 - 4 && board[beg1 - 1, beg0 - 1] == '.' && board[beg1 - 2, beg0 - 2] == '.' && board[beg1 - 3, beg0 - 3] == '.' && (color[beg1 - 4, beg0 - 4] != color[beg1, beg0] || board[beg1 - 4, beg0 - 4] == '.')) ||
                (fin0 == beg0 - 5 && fin1 == beg1 - 5 && board[beg1 - 1, beg0 - 1] == '.' && board[beg1 - 2, beg0 - 2] == '.' && board[beg1 - 3, beg0 - 3] == '.' && board[beg1 - 4, beg0 - 4] == '.' && (color[beg1 - 5, beg0 - 5] != color[beg1, beg0] || board[beg1 - 5, beg0 - 5] == '.')) ||
                (fin0 == beg0 - 6 && fin1 == beg1 - 6 && board[beg1 - 1, beg0 - 1] == '.' && board[beg1 - 2, beg0 - 2] == '.' && board[beg1 - 3, beg0 - 3] == '.' && board[beg1 - 4, beg0 - 4] == '.' && board[beg1 - 5, beg0 - 5] == '.' && (color[beg1 - 6, beg0 - 6] != color[beg1, beg0] || board[beg1 - 6, beg0 - 6] == '.')) ||
                (fin0 == beg0 - 7 && fin1 == beg1 - 7 && board[beg1 - 1, beg0 - 1] == '.' && board[beg1 - 2, beg0 - 2] == '.' && board[beg1 - 3, beg0 - 3] == '.' && board[beg1 - 4, beg0 - 4] == '.' && board[beg1 - 5, beg0 - 5] == '.' && board[beg1 - 6, beg0 - 6] == '.' && (color[beg1 - 7, beg0 - 7] != color[beg1, beg0] || board[beg1 - 7, beg0 - 7] == '.')))
            {
                validity = true;
            }
            else
            {
                Console.SetCursorPosition(50, 5);
                Console.WriteLine("Invalid move");
            }
            return validity;
        }

        static bool Rook(int beg0, int beg1, int fin0, int fin1, int[,] color, char[,] board)
        {
            bool validity = false;
            if ((fin0 == beg0 && fin1 == beg1 + 1 && (color[beg1 + 1, beg0] != color[beg1, beg0] || board[beg1 + 1, beg0] == '.')) ||
                (fin0 == beg0 && fin1 == beg1 + 2 && board[beg1 + 1, beg0] == '.' && (color[beg1 + 2, beg0] != color[beg1, beg0] || board[beg1 + 2, beg0] == '.')) ||
                (fin0 == beg0 && fin1 == beg1 + 3 && board[beg1 + 1, beg0] == '.' && board[beg1 + 2, beg0] == '.' && (color[beg1 + 3, beg0] != color[beg1, beg0] || board[beg1 + 3, beg0] == '.')) ||
                (fin0 == beg0 && fin1 == beg1 + 4 && board[beg1 + 1, beg0] == '.' && board[beg1 + 2, beg0] == '.' && board[beg1 + 3, beg0] == '.' && (color[beg1 + 4, beg0] != color[beg1, beg0] || board[beg1 + 4, beg0] == '.')) ||
                (fin0 == beg0 && fin1 == beg1 + 5 && board[beg1 + 1, beg0] == '.' && board[beg1 + 2, beg0] == '.' && board[beg1 + 3, beg0] == '.' && board[beg1 + 4, beg0] == '.' && (color[beg1 + 5, beg0] != color[beg1, beg0] || board[beg1 + 5, beg0] == '.')) ||
                (fin0 == beg0 && fin1 == beg1 + 6 && board[beg1 + 1, beg0] == '.' && board[beg1 + 2, beg0] == '.' && board[beg1 + 3, beg0] == '.' && board[beg1 + 4, beg0] == '.' && board[beg1 + 5, beg0] == '.' && (color[beg1 + 6, beg0] != color[beg1, beg0] || board[beg1 + 6, beg0] == '.')) ||
                (fin0 == beg0 && fin1 == beg1 + 7 && board[beg1 + 1, beg0] == '.' && board[beg1 + 2, beg0] == '.' && board[beg1 + 3, beg0] == '.' && board[beg1 + 4, beg0] == '.' && board[beg1 + 5, beg0] == '.' && board[beg1 + 6, beg0] == '.' && (color[beg1 + 7, beg0] != color[beg1, beg0] || board[beg1 + 7, beg0] == '.')) ||
                (fin0 == beg0 - 1 && fin1 == beg1 && (color[beg1, beg0 - 1] != color[beg1, beg0] || board[beg1, beg0 - 1] == '.')) ||
                (fin0 == beg0 - 2 && fin1 == beg1 && board[beg1, beg0 - 1] == '.' && (color[beg1, beg0 - 2] != color[beg1, beg0] || board[beg1, beg0 - 2] == '.')) ||
                (fin0 == beg0 - 3 && fin1 == beg1 && board[beg1, beg0 - 1] == '.' && board[beg1, beg0 - 2] == '.' && (color[beg1, beg0 - 3] != color[beg1, beg0] || board[beg1, beg0 - 3] == '.')) ||
                (fin0 == beg0 - 4 && fin1 == beg1 && board[beg1, beg0 - 1] == '.' && board[beg1, beg0 - 2] == '.' && board[beg1, beg0 - 3] == '.' && (color[beg1, beg0 - 4] != color[beg1, beg0] || board[beg1, beg0 - 4] == '.')) ||
                (fin0 == beg0 - 5 && fin1 == beg1 && board[beg1, beg0 - 1] == '.' && board[beg1, beg0 - 2] == '.' && board[beg1, beg0 - 3] == '.' && board[beg1, beg0 - 4] == '.' && (color[beg1, beg0 - 5] != color[beg1, beg0] || board[beg1, beg0 - 5] == '.')) ||
                (fin0 == beg0 - 6 && fin1 == beg1 && board[beg1, beg0 - 1] == '.' && board[beg1, beg0 - 2] == '.' && board[beg1, beg0 - 3] == '.' && board[beg1, beg0 - 4] == '.' && board[beg1, beg0 - 5] == '.' && (color[beg1, beg0 - 6] != color[beg1, beg0] || board[beg1, beg0 - 6] == '.')) ||
                (fin0 == beg0 - 7 && fin1 == beg1 && board[beg1, beg0 - 1] == '.' && board[beg1, beg0 - 2] == '.' && board[beg1, beg0 - 3] == '.' && board[beg1, beg0 - 4] == '.' && board[beg1, beg0 - 5] == '.' && board[beg1, beg0 - 6] == '.' && (color[beg1, beg0 - 7] != color[beg1, beg0] || board[beg1, beg0 - 7] == '.')) ||
                (fin0 == beg0 + 1 && fin1 == beg1 && (color[beg1, beg0 + 1] != color[beg1, beg0] || board[beg1, beg0 + 1] == '.')) ||
                (fin0 == beg0 + 2 && fin1 == beg1 && board[beg1, beg0 + 1] == '.' && (color[beg1, beg0 + 2] != color[beg1, beg0] || board[beg1, beg0 + 2] == '.')) ||
                (fin0 == beg0 + 3 && fin1 == beg1 && board[beg1, beg0 + 1] == '.' && board[beg1, beg0 + 2] == '.' && (color[beg1, beg0 + 3] != color[beg1, beg0] || board[beg1, beg0 + 3] == '.')) ||
                (fin0 == beg0 + 4 && fin1 == beg1 && board[beg1, beg0 + 1] == '.' && board[beg1, beg0 + 2] == '.' && board[beg1, beg0 + 3] == '.' && (color[beg1, beg0 + 4] != color[beg1, beg0] || board[beg1, beg0 + 4] == '.')) ||
                (fin0 == beg0 + 5 && fin1 == beg1 && board[beg1, beg0 + 1] == '.' && board[beg1, beg0 + 2] == '.' && board[beg1, beg0 + 3] == '.' && board[beg1, beg0 + 4] == '.' && (color[beg1, beg0 + 5] != color[beg1, beg0] || board[beg1, beg0 + 5] == '.')) ||
                (fin0 == beg0 + 6 && fin1 == beg1 && board[beg1, beg0 + 1] == '.' && board[beg1, beg0 + 2] == '.' && board[beg1, beg0 + 3] == '.' && board[beg1, beg0 + 4] == '.' && board[beg1, beg0 + 5] == '.' && (color[beg1, beg0 + 6] != color[beg1, beg0] || board[beg1, beg0 + 6] == '.')) ||
                (fin0 == beg0 + 7 && fin1 == beg1 && board[beg1, beg0 + 1] == '.' && board[beg1, beg0 + 2] == '.' && board[beg1, beg0 + 3] == '.' && board[beg1, beg0 + 4] == '.' && board[beg1, beg0 + 5] == '.' && board[beg1, beg0 + 6] == '.' && (color[beg1, beg0 + 7] != color[beg1, beg0] || board[beg1, beg0 + 7] == '.')) ||
                (fin0 == beg0 && fin1 == beg1 - 1 && (color[beg1 - 1, beg0] != color[beg1, beg0] || board[beg1 - 1, beg0] == '.')) ||
                (fin0 == beg0 && fin1 == beg1 - 2 && board[beg1 - 1, beg0] == '.' && (color[beg1 - 2, beg0] != color[beg1, beg0] || board[beg1 - 2, beg0] == '.')) ||
                (fin0 == beg0 && fin1 == beg1 - 3 && board[beg1 - 1, beg0] == '.' && board[beg1 - 2, beg0] == '.' && (color[beg1 - 3, beg0] != color[beg1, beg0] || board[beg1 - 3, beg0] == '.')) ||
                (fin0 == beg0 && fin1 == beg1 - 4 && board[beg1 - 1, beg0] == '.' && board[beg1 - 2, beg0] == '.' && board[beg1 - 3, beg0] == '.' && (color[beg1 - 4, beg0] != color[beg1, beg0] || board[beg1 - 4, beg0] == '.')) ||
                (fin0 == beg0 && fin1 == beg1 - 5 && board[beg1 - 1, beg0] == '.' && board[beg1 - 2, beg0] == '.' && board[beg1 - 3, beg0] == '.' && board[beg1 - 4, beg0] == '.' && (color[beg1 - 5, beg0] != color[beg1, beg0] || board[beg1 - 5, beg0] == '.')) ||
                (fin0 == beg0 && fin1 == beg1 - 6 && board[beg1 - 1, beg0] == '.' && board[beg1 - 2, beg0] == '.' && board[beg1 - 3, beg0] == '.' && board[beg1 - 4, beg0] == '.' && board[beg1 - 5, beg0] == '.' && (color[beg1 - 6, beg0] != color[beg1, beg0] || board[beg1 - 6, beg0] == '.')) ||
                (fin0 == beg0 && fin1 == beg1 - 7 && board[beg1 - 1, beg0] == '.' && board[beg1 - 2, beg0] == '.' && board[beg1 - 3, beg0] == '.' && board[beg1 - 4, beg0] == '.' && board[beg1 - 5, beg0] == '.' && board[beg1 - 6, beg0] == '.' && (color[beg1 - 7, beg0] != color[beg1, beg0] || board[beg1 - 7, beg0] == '.')))
            {
                validity = true;
            }
            else
            {
                Console.SetCursorPosition(50, 5);
                Console.WriteLine("Invalid move");
            }
            return validity;
        }

        static bool Knight(int beg0, int beg1, int fin0, int fin1, int[,] color, char[,] board)
        {
            bool validity = false;

            if ((fin0 == beg0 + 1 && fin1 == beg1 + 2 && color[beg1 + 2, beg0 + 1] != color[beg1, beg0]) ||
                (fin0 == beg0 + 1 && fin1 == beg1 - 2 && color[beg1 - 2, beg0 + 1] != color[beg1, beg0]) ||
                (fin0 == beg0 + 2 && fin1 == beg1 + 1 && color[beg1 + 1, beg0 + 2] != color[beg1, beg0]) ||
                (fin0 == beg0 + 2 && fin1 == beg1 - 1 && color[beg1 - 1, beg0 + 2] != color[beg1, beg0]) ||
                (fin0 == beg0 - 1 && fin1 == beg1 + 2 && color[beg1 + 2, beg0 - 1] != color[beg1, beg0]) ||
                (fin0 == beg0 - 1 && fin1 == beg1 - 2 && color[beg1 - 2, beg0 - 1] != color[beg1, beg0]) ||
                (fin0 == beg0 - 2 && fin1 == beg1 + 1 && color[beg1 + 1, beg0 - 2] != color[beg1, beg0]) ||
                (fin0 == beg0 - 2 && fin1 == beg1 - 1 && color[beg1 - 1, beg0 - 2] != color[beg1, beg0]))
            {
                validity = true;
            }
            else
            {
                Console.SetCursorPosition(50, 5);
                Console.WriteLine("Invalid move");
            }
            return validity;
        }


        static int Converter(char x)
        {
            int x1 = 0;
            if (x == 'a')
                x1 = 0;
            else if (x == 'b')
                x1 = 1;
            else if (x == 'c')
                x1 = 2;
            else if (x == 'd')
                x1 = 3;
            else if (x == 'e')
                x1 = 4;
            else if (x == 'f')
                x1 = 5;
            else if (x == 'g')
                x1 = 6;
            else if (x == 'h')
                x1 = 7;
            return x1;
        }

        static void Main(string[] args)
        {
            int cursorx = 10, cursory = 4;
            int counterBlueKing = 0;
            int counterRedKing = 0;
            ConsoleKeyInfo cki;
            char[,] board = new char[8, 8];
            int lastMoveX = 0;
            char lastStone = '.';
            int[,] color = new int[8, 8];
            char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h' };
            string secilen_tas;
            string koyulacak_yer;
            char holder = '.';
            int colorHolder = 0;
            bool yazdırma = false;
            for (int i = 1; i <= 18; i++)
            {
                for (int j = 1; j <= 18; j++)
                {
                    if ((i - 1) % 16 == 0 && 2 < j && j < 18)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow
                            ;
                        Console.SetCursorPosition(4 + (j * 2), 2 + i);
                        Console.WriteLine('-');
                    }
                    if ((i - 1) % 16 == 0 && (j - 2) % 16 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.SetCursorPosition(4 + (j * 2), 2 + i);
                        Console.WriteLine('+');
                    }
                    if (1 < i && i < 17 && (j - 2) % 16 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.SetCursorPosition(4 + (j * 2), 2 + i);
                        Console.WriteLine('|');
                    }
                    if (i == 1 && 1 < j && j < 17 && j % 2 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.SetCursorPosition(6 + i, 2 + j);
                        Console.WriteLine((18 - j) / 2);
                    }
                    if (2 < i && i < 18 && (i - 1) % 2 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.SetCursorPosition(4 + (i * 2), 20);
                        Console.WriteLine(letters[(i - 3) / 2]);
                    }
                }
            }
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    board[i, j] = '.';
                    if (i < 2)
                        color[i, j] = 1;
                    else if (5 < i)
                        color[i, j] = 2;
                    else
                        color[i, j] = 0;
                }
            }

            int position_x = 0;
            int position_y = 0;
            int position_x1 = 0;
            int position_y1 = 0;
            char red_P = 'P';
            char red_R = 'R';
            char red_N = 'N';
            char red_B = 'B';
            char red_Q = 'Q';
            char red_K = 'K';
            char blue_P = 'P';
            char blue_R = 'R';
            char blue_N = 'N';
            char blue_B = 'B';
            char blue_Q = 'Q';
            char blue_K = 'K';
            for (int i = 0; i < 8; i++)
            {
                board[1, i] = red_P;
                board[6, i] = blue_P;
            }
            board[0, 0] = red_R;
            board[0, 1] = red_N;
            board[0, 2] = red_B;
            board[0, 3] = red_Q;
            board[0, 4] = red_K;
            board[0, 5] = red_B;
            board[0, 6] = red_N;
            board[0, 7] = red_R;
            board[7, 0] = blue_R;
            board[7, 1] = blue_N;
            board[7, 2] = blue_B;
            board[7, 3] = blue_Q;
            board[7, 4] = blue_K;
            board[7, 5] = blue_B;
            board[7, 6] = blue_N;
            board[7, 7] = blue_R;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (color[j, i] == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                    }
                    else if (color[j, i] == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                    }
                    else
                        Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(10 + (i * 4), 4 + (j * 2));
                    Console.WriteLine(board[j, i]);
                }
            }
            Console.SetCursorPosition(5, 22);
            Console.WriteLine("Please choose a mode   ");
            Console.WriteLine("If you want to move with string press 1");
            Console.WriteLine("If you want to play with cursor press 2");
            Console.SetCursorPosition(40, 24);
            int istek = Convert.ToInt32(Console.ReadLine());
            int countx = 0;
            int county = 0;
            int count2 = 0;
            int counter = 0;

            if (istek == 1)
            {
                while (true)
                {
                    yazdırma = false;
                    Console.CursorVisible = false;
                    if (Console.KeyAvailable)
                    {       // true: there is a key in keyboard buffer
                        cki = Console.ReadKey(true);       // true: do not write character 


                        if (cki.Key == ConsoleKey.Enter)
                        {
                            counter++;
                            Console.SetCursorPosition(50, 5);
                            Console.WriteLine("              ");
                            Console.SetCursorPosition(50, 0);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("taş seçiniz: ");
                            secilen_tas = Console.ReadLine();
                            Console.SetCursorPosition(50, 1);
                            Console.Write("gidilecek konumu seçiniz: ");
                            koyulacak_yer = Console.ReadLine();
                            int ct = 56 - Convert.ToInt32(secilen_tas[1]);
                            int ct2 = 56 - Convert.ToInt32(koyulacak_yer[1]);
                            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            if (board[ct, Converter(secilen_tas[0])] == 'K' && ((count2 % 2 == 0 && color[ct, Converter(secilen_tas[0])] == 1) || (count2 % 2 == 1 && color[ct, Converter(secilen_tas[0])] == 2))) // MOVEMENT FOR KING
                            {
                                if (counterBlueKing == 0 && color[ct, Converter(secilen_tas[0])] == 2 && ct == 7 && Converter(secilen_tas[0]) == 4 && ct2 == 7 && Converter(koyulacak_yer[0]) == 5 && board[7, 5] == '.' && board[7, 6] == '.' && board[7, 7] == blue_R)
                                {
                                    Console.SetCursorPosition(70 + countx, 5 + county);
                                    Console.WriteLine("O-O");
                                    board[7, 4] = blue_R;
                                    color[7, 4] = 2;
                                    board[7, 7] = '.';
                                    color[7, 7] = 0;
                                    board[7, 5] = blue_K;
                                    color[7, 5] = 2;
                                    yazdırma = true;
                                    count2++;
                                }
                                else if (counterBlueKing == 0 && color[ct, Converter(secilen_tas[0])] == 2 && ct == 7 && Converter(secilen_tas[0]) == 4 && ct2 == 7 && Converter(koyulacak_yer[0]) == 2 && board[7, 1] == '.' && board[7, 2] == '.' && board[7, 3] == '.' && board[7, 0] == blue_R)
                                {
                                    Console.SetCursorPosition(70 + countx, 5 + county);
                                    Console.WriteLine("O-O-O"); // long castling for blue side
                                    board[7, 0] = '.';
                                    color[7, 0] = 0;
                                    board[7, 1] = '.';
                                    color[7, 1] = 0;
                                    board[7, 2] = blue_K;
                                    color[7, 2] = 2;
                                    board[7, 3] = blue_R;
                                    color[7, 3] = 2;
                                    board[7, 4] = '.';
                                    color[7, 4] = 0;
                                    yazdırma = true;
                                    count2++;
                                }
                                else if (counterRedKing == 0 && color[ct, Converter(secilen_tas[0])] == 1 && ct == 0 && Converter(secilen_tas[0]) == 4 && ct2 == 0 && Converter(koyulacak_yer[0]) == 5 && board[0, 5] == '.' && board[0, 6] == '.' && board[0, 7] == red_R)
                                {
                                    Console.SetCursorPosition(70 + countx, 5 + county);
                                    Console.WriteLine("O-O");
                                    board[0, 4] = red_R;
                                    color[0, 4] = 1;
                                    board[0, 7] = '.';
                                    color[0, 7] = 0;
                                    board[0, 5] = red_K;
                                    color[0, 5] = 1;
                                    yazdırma = true;
                                    count2++;
                                }
                                else if (counterRedKing == 0 && color[ct, Converter(secilen_tas[0])] == 1 && ct == 0 && Converter(secilen_tas[0]) == 4 && ct2 == 0 && Converter(koyulacak_yer[0]) == 2 && board[0, 1] == '.' && board[0, 2] == '.' && board[0, 3] == '.' && board[0, 0] == red_R)
                                {
                                    Console.SetCursorPosition(70 + countx, 5 + county);
                                    Console.WriteLine("O-O-O");
                                    board[0, 0] = '.';
                                    color[0, 0] = 0;
                                    board[0, 1] = '.';
                                    color[0, 1] = 0;
                                    board[0, 2] = red_K;
                                    color[0, 2] = 1;
                                    board[0, 3] = red_R;
                                    color[0, 3] = 1;
                                    board[0, 4] = '.';
                                    color[0, 4] = 0;
                                    yazdırma = true;
                                    count2++;
                                }

                                else if (King(Converter(secilen_tas[0]), ct, Converter(koyulacak_yer[0]), ct2, color, board) == true) // if it is not castling controlling king
                                {
                                    if (color[ct, Converter(secilen_tas[0])] == 1)
                                    {
                                        counterRedKing++;
                                    }
                                    else
                                    {
                                        counterBlueKing++;
                                    }
                                    if (board[ct2, Converter(koyulacak_yer[0])]!='.')
                                    {
                                        Console.SetCursorPosition(70 + countx, 5 + county);
                                        Console.WriteLine((county + 1) + "." + "K" +"x"+ koyulacak_yer);
                                    }
                                    else
                                    {
                                        Console.SetCursorPosition(70 + countx, 5 + county);
                                        Console.WriteLine((county + 1) + "." + "K" + koyulacak_yer);

                                    }
                                    holder = board[ct, Converter(secilen_tas[0])];
                                    colorHolder = color[ct, Converter(secilen_tas[0])];
                                    board[ct, Converter(secilen_tas[0])] = '.';
                                    color[ct, Converter(secilen_tas[0])] = 0;


                                    board[ct2, Converter(koyulacak_yer[0])] = holder;
                                    color[ct2, Converter(koyulacak_yer[0])] = colorHolder;
                                    yazdırma = true;
                                    count2++;
                                }

                            }
                            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            if (board[ct, Converter(secilen_tas[0])] == 'R' && ((count2 % 2 == 0 && color[ct, Converter(secilen_tas[0])] == 1) || (count2 % 2 == 1 && color[ct, Converter(secilen_tas[0])] == 2))) // MOVEMENT FOR ROCK
                            {
                                if (Rook(Converter(secilen_tas[0]), ct, Converter(koyulacak_yer[0]), ct2, color, board) == true)
                                {
                                    if (board[ct2, Converter(koyulacak_yer[0])] != '.')
                                    {
                                        Console.SetCursorPosition(70 + countx, 5 + county);
                                        Console.WriteLine((county + 1) + "." + "R" + "x" + koyulacak_yer);
                                    }
                                    else
                                    {
                                        Console.SetCursorPosition(70 + countx, 5 + county);
                                        Console.WriteLine((county + 1) + "." + "R" + koyulacak_yer);
                                    }
                                    holder = board[ct, Converter(secilen_tas[0])];
                                    colorHolder = color[ct, Converter(secilen_tas[0])];
                                    board[ct, Converter(secilen_tas[0])] = '.';
                                    color[ct, Converter(secilen_tas[0])] = 0;


                                    board[ct2, Converter(koyulacak_yer[0])] = holder;
                                    color[ct2, Converter(koyulacak_yer[0])] = colorHolder;
                                    yazdırma = true;
                                    count2++;
                                }
                            }
                            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            if (board[ct, Converter(secilen_tas[0])] == 'Q' && ((count2 % 2 == 0 && color[ct, Converter(secilen_tas[0])] == 1) || (count2 % 2 == 1 && color[ct, Converter(secilen_tas[0])] == 2))) // MOVEMENT FOR QUEEN
                            {
                                if (Queen(Converter(secilen_tas[0]), ct, Converter(koyulacak_yer[0]), ct2, color, board) == true)
                                {
                                    if (board[ct2, Converter(koyulacak_yer[0])] != '.')
                                    {
                                        Console.SetCursorPosition(70 + countx, 5 + county);
                                        Console.WriteLine((county + 1) + "." + "Q" + "x" + koyulacak_yer);
                                    }
                                    else
                                    {
                                        Console.SetCursorPosition(70 + countx, 5 + county);
                                        Console.WriteLine((county + 1) + "." + "Q" + koyulacak_yer);
                                    }
                                    holder = board[ct, Converter(secilen_tas[0])];
                                    colorHolder = color[ct, Converter(secilen_tas[0])];
                                    board[ct, Converter(secilen_tas[0])] = '.';
                                    color[ct, Converter(secilen_tas[0])] = 0;


                                    board[ct2, Converter(koyulacak_yer[0])] = holder;
                                    color[ct2, Converter(koyulacak_yer[0])] = colorHolder;
                                    yazdırma = true;
                                    count2++;
                                }
                            }
                            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            if (board[ct, Converter(secilen_tas[0])] == 'B' && ((count2 % 2 == 0 && color[ct, Converter(secilen_tas[0])] == 1) || (count2 % 2 == 1 && color[ct, Converter(secilen_tas[0])] == 2))) // MOVEMENT FOR BISHOP
                            {
                                if (Bishop(Converter(secilen_tas[0]), ct, Converter(koyulacak_yer[0]), ct2, color, board) == true)
                                {
                                    if (board[ct2, Converter(koyulacak_yer[0])] != '.')
                                    {
                                        Console.SetCursorPosition(70 + countx, 5 + county);
                                        Console.WriteLine((county + 1) + "." + "B" + "x" + koyulacak_yer);
                                    }
                                    else
                                    {
                                        Console.SetCursorPosition(70 + countx, 5 + county);
                                        Console.WriteLine((county + 1) + "." + "B" + koyulacak_yer);
                                    }
                                    holder = board[ct, Converter(secilen_tas[0])];
                                    colorHolder = color[ct, Converter(secilen_tas[0])];
                                    board[ct, Converter(secilen_tas[0])] = '.';
                                    color[ct, Converter(secilen_tas[0])] = 0;


                                    board[ct2, Converter(koyulacak_yer[0])] = holder;
                                    color[ct2, Converter(koyulacak_yer[0])] = colorHolder;
                                    yazdırma = true;
                                    count2++;
                                }
                            }
                            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            if (board[ct, Converter(secilen_tas[0])] == 'N' && ((count2 % 2 == 0 && color[ct, Converter(secilen_tas[0])] == 1) || (count2 % 2 == 1 && color[ct, Converter(secilen_tas[0])] == 2))) // MOVEMENT FOR KNIGHT
                            {
                                if (Knight(Converter(secilen_tas[0]), ct, Converter(koyulacak_yer[0]), ct2, color, board) == true)
                                {
                                    if (board[ct2, Converter(koyulacak_yer[0])] != '.')
                                    {
                                        Console.SetCursorPosition(70 + countx, 5 + county);
                                        Console.WriteLine((county + 1) + "." + "N" + "x" + koyulacak_yer);
                                    }
                                    else
                                    {
                                        Console.SetCursorPosition(70 + countx, 5 + county);
                                        Console.WriteLine((county + 1) + "." + "N" + koyulacak_yer);
                                    }
                                    holder = board[ct, Converter(secilen_tas[0])];
                                    colorHolder = color[ct, Converter(secilen_tas[0])];
                                    board[ct, Converter(secilen_tas[0])] = '.';
                                    color[ct, Converter(secilen_tas[0])] = 0;


                                    board[ct2, Converter(koyulacak_yer[0])] = holder;
                                    color[ct2, Converter(koyulacak_yer[0])] = colorHolder;
                                    yazdırma = true;
                                    count2++;
                                }
                            }
                            if (board[ct, Converter(secilen_tas[0])] == 'P' && ((count2 % 2 == 0 && color[ct, Converter(secilen_tas[0])] == 1) || (count2 % 2 == 1 && color[ct, Converter(secilen_tas[0])] == 2)))     // MOVEMENT FOR PAWN
                            {
                                if (Pawn(Converter(secilen_tas[0]), ct, Converter(koyulacak_yer[0]), ct2, color, board) == true)
                                {
                                    if ((color[ct, Converter(secilen_tas[0])] == 1) && (ct == 3) && (ct2 == 4)) // for red pawn en passant
                                    {
                                        if ((board[ct2, Converter(koyulacak_yer[0]) + 1] == blue_P)/* && lastStone == blue_P && lastMoveX == Converter(koyulacak_yer[0]) + 1*/)
                                        {
                                            Console.SetCursorPosition(70 + countx, 5 + county);
                                            Console.WriteLine((county + 1) + "." +"e.p."+ koyulacak_yer);                                                      // yukarıdaki yorumlar son hamleyi kontrol etmek icin ama calısmadı 
                                            board[ct2, Converter(koyulacak_yer[0]) + 1] = '.';
                                            color[ct2, Converter(koyulacak_yer[0]) + 1] = 0;
                                            holder = board[ct, Converter(secilen_tas[0])];
                                            colorHolder = color[ct, Converter(secilen_tas[0])];
                                            board[ct, Converter(secilen_tas[0])] = '.';
                                            color[ct, Converter(secilen_tas[0])] = 0;

                                            board[ct2, Converter(koyulacak_yer[0])] = holder;
                                            color[ct2, Converter(koyulacak_yer[0])] = colorHolder;
                                        }
                                        else if (board[ct2, Converter(koyulacak_yer[0]) - 1] == blue_P /*&& lastStone == blue_P && lastMoveX == Converter(koyulacak_yer[0]) - 1*/)
                                        {                                                 // yukarıdaki yorumlar son hamleyi kontrol etmek icin ama calısmadı 
                                            Console.SetCursorPosition(70 + countx, 5 + county);
                                            Console.WriteLine((county + 1) + "." + "e.p." + koyulacak_yer);
                                            board[ct2, Converter(koyulacak_yer[0]) - 1] = '.';
                                            color[ct2, Converter(koyulacak_yer[0]) - 1] = 0;
                                            holder = board[ct, Converter(secilen_tas[0])];
                                            colorHolder = color[ct, Converter(secilen_tas[0])];
                                            board[ct, Converter(secilen_tas[0])] = '.';
                                            color[ct, Converter(secilen_tas[0])] = 0;

                                            board[ct2, Converter(koyulacak_yer[0])] = holder;
                                            color[ct2, Converter(koyulacak_yer[0])] = colorHolder;
                                        }


                                        else          // normal stuff but this one stands if code enters en passant situation but it is not
                                        {
                                            if (board[ct2, Converter(koyulacak_yer[0])] != '.')
                                            {
                                                Console.SetCursorPosition(70 + countx, 5 + county);
                                                Console.WriteLine((county + 1) + "." + secilen_tas + "x" + koyulacak_yer);
                                            }
                                            else
                                            {
                                                Console.SetCursorPosition(70 + countx, 5 + county);
                                                Console.WriteLine((county + 1) + "." + koyulacak_yer);
                                            }
                                            holder = board[ct, Converter(secilen_tas[0])];
                                            colorHolder = color[ct, Converter(secilen_tas[0])];
                                            board[ct, Converter(secilen_tas[0])] = '.';
                                            color[ct, Converter(secilen_tas[0])] = 0;

                                            board[ct2, Converter(koyulacak_yer[0])] = holder;
                                            color[ct2, Converter(koyulacak_yer[0])] = colorHolder;
                                        }
                                    }
                                    else if ((color[ct, Converter(secilen_tas[0])] == 2) && (ct == 4) && (ct2 == 3)) // for blue pawn en passant
                                    {
                                        if ((board[ct2, Converter(koyulacak_yer[0]) + 1] == red_P)/* && lastStone == blue_P && lastMoveX == Converter(koyulacak_yer[0]) + 1*/)
                                        {                                                        // yukarıdaki yorumlar son hamleyi kontrol etmek icin ama calısmadı 
                                            Console.SetCursorPosition(70 + countx, 5 + county);
                                            Console.WriteLine((county + 1) + "." + "e.p." + koyulacak_yer);
                                            board[ct2, Converter(koyulacak_yer[0]) + 1] = '.';
                                            color[ct2, Converter(koyulacak_yer[0]) + 1] = 0;
                                            holder = board[ct, Converter(secilen_tas[0])];
                                            colorHolder = color[ct, Converter(secilen_tas[0])];
                                            board[ct, Converter(secilen_tas[0])] = '.';
                                            color[ct, Converter(secilen_tas[0])] = 0;

                                            board[ct2, Converter(koyulacak_yer[0])] = holder;
                                            color[ct2, Converter(koyulacak_yer[0])] = colorHolder;
                                        }
                                        else if (board[ct2, Converter(koyulacak_yer[0]) - 1] == red_P /*&& lastStone == blue_P && lastMoveX == Converter(koyulacak_yer[0]) - 1*/)
                                        {                                                 // yukarıdaki yorumlar son hamleyi kontrol etmek icin ama calısmadı 
                                            Console.SetCursorPosition(70 + countx, 5 + county);
                                            Console.WriteLine((county + 1) + "." + "e.p." + koyulacak_yer);
                                            board[ct2, Converter(koyulacak_yer[0]) - 1] = '.';
                                            color[ct2, Converter(koyulacak_yer[0]) - 1] = 0;
                                            holder = board[ct, Converter(secilen_tas[0])];
                                            colorHolder = color[ct, Converter(secilen_tas[0])];
                                            board[ct, Converter(secilen_tas[0])] = '.';
                                            color[ct, Converter(secilen_tas[0])] = 0;

                                            board[ct2, Converter(koyulacak_yer[0])] = holder;
                                            color[ct2, Converter(koyulacak_yer[0])] = colorHolder;
                                        }


                                        else          // normal stuff but this one stands if code enters en passant situation but it is not
                                        {
                                            if (board[ct2, Converter(koyulacak_yer[0])] != '.')
                                            {
                                                Console.SetCursorPosition(70 + countx, 5 + county);
                                                Console.WriteLine((county + 1) + "." + secilen_tas + "x" + koyulacak_yer);
                                            }
                                            else
                                            {
                                                Console.SetCursorPosition(70 + countx, 5 + county);
                                                Console.WriteLine((county + 1) + "." + koyulacak_yer);
                                            }
                                            holder = board[ct, Converter(secilen_tas[0])];
                                            colorHolder = color[ct, Converter(secilen_tas[0])];
                                            board[ct, Converter(secilen_tas[0])] = '.';
                                            color[ct, Converter(secilen_tas[0])] = 0;

                                            board[ct2, Converter(koyulacak_yer[0])] = holder;
                                            color[ct2, Converter(koyulacak_yer[0])] = colorHolder;
                                        }
                                    }

                                    else if ((ct2 == 7) && (color[ct, Converter(secilen_tas[0])] == 1))// promotion for red
                                    {
                                        Console.SetCursorPosition(70 + countx, 5 + county);
                                        Console.WriteLine((county + 1) + "."  + koyulacak_yer+"Q");
                                        board[ct2, Converter(koyulacak_yer[0])] = red_Q;
                                        color[ct2, Converter(koyulacak_yer[0])] = 1;
                                        board[ct, Converter(secilen_tas[0])] = '.';
                                        color[ct, Converter(secilen_tas[0])] = 0;
                                    }


                                    else if ((ct2 == 0) && color[ct, Converter(secilen_tas[0])] == 2)// promotion for blue
                                    {
                                        Console.SetCursorPosition(70 + countx, 5 + county);
                                        Console.WriteLine((county + 1) + "." + koyulacak_yer + "Q");
                                        board[ct2, Converter(koyulacak_yer[0])] = 'Q';
                                        color[ct2, Converter(koyulacak_yer[0])] = 2;
                                        board[ct, Converter(secilen_tas[0])] = '.';
                                        color[ct, Converter(secilen_tas[0])] = 0;

                                    }
                                    else
                                    {
                                        if (board[ct2, Converter(koyulacak_yer[0])] != '.')
                                        {
                                            Console.SetCursorPosition(70 + countx, 5 + county);
                                            Console.WriteLine((county + 1)+"." + secilen_tas+   "x" + koyulacak_yer);
                                        }
                                        else
                                        {
                                            Console.SetCursorPosition(70 + countx, 5 + county);
                                            Console.WriteLine((county + 1) + "." + koyulacak_yer);
                                        }
                                        holder = board[ct, Converter(secilen_tas[0])];
                                        colorHolder = color[ct, Converter(secilen_tas[0])];
                                        board[ct, Converter(secilen_tas[0])] = '.';
                                        color[ct, Converter(secilen_tas[0])] = 0;

                                        board[ct2, Converter(koyulacak_yer[0])] = holder;
                                        color[ct2, Converter(koyulacak_yer[0])] = colorHolder;

                                    }

                                    count2++;
                                    yazdırma = true;
                                }

                            }
                            lastStone = board[ct, Converter(secilen_tas[0])];
                            lastMoveX = Converter(koyulacak_yer[0]);
                        }

                    }
                    for (int i = 0; i < 8; i++)
                    {
                        for (int j = 0; j < 8; j++)
                        {
                            if (color[j, i] == 1)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                            }
                            else if (color[j, i] == 2)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                            }
                            else
                                Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(10 + (i * 4), 4 + (j * 2));
                            Console.WriteLine(board[j, i]);
                        }
                    }

                    Console.SetCursorPosition(50, 0);
                    Console.WriteLine("                                     ");
                    Console.SetCursorPosition(50, 1);
                    Console.WriteLine("                                     ");
                    if (count2 % 2 == 0 && yazdırma == true)
                    {
                        countx = 0;
                        county++;
                    }
                    else if (count2 % 2 == 1 && yazdırma == true)
                    {
                        countx += 10;
                    }
                }

            }
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            else
            {
                bool tus_enter = true;

                while (true)
                {
                    yazdırma = false;
                    for (int i = 0; i < 8; i++)
                    {
                        for (int j = 0; j < 8; j++)
                        {
                            if (color[j, i] == 1)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                            }
                            else if (color[j, i] == 2)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                            }
                            else
                                Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(10 + (i * 4), 4 + (j * 2));
                            Console.WriteLine(board[j, i]);
                        }
                    }
                    Console.SetCursorPosition(cursorx, cursory);
                    while (true)
                    {
                        if (Console.KeyAvailable)
                        {
                            cki = Console.ReadKey(true);

                            if ((cki.Key == ConsoleKey.RightArrow || cki.Key == ConsoleKey.D) && cursorx < 36)
                            {
                                cursorx += 4;

                                Console.SetCursorPosition(cursorx, cursory);
                            }
                            if ((cki.Key == ConsoleKey.LeftArrow || cki.Key == ConsoleKey.A) && cursorx > 10)
                            {
                                cursorx -= 4;

                                Console.SetCursorPosition(cursorx, cursory);
                            }
                            if ((cki.Key == ConsoleKey.UpArrow || cki.Key == ConsoleKey.W) && cursory > 4)
                            {
                                cursory -= 2;

                                Console.SetCursorPosition(cursorx, cursory);
                            }
                            if ((cki.Key == ConsoleKey.DownArrow || cki.Key == ConsoleKey.S) && cursory < 17)
                            {
                                cursory += 2;

                                Console.SetCursorPosition(cursorx, cursory);
                            }
                            if (cki.Key == ConsoleKey.Enter && tus_enter == true)
                            {
                                position_x = (cursorx - 10) / 4;
                                position_y = (cursory - 4) / 2;
                                tus_enter = false;
                                break;
                            }

                            if (cki.Key == ConsoleKey.Enter && tus_enter == false)
                            {
                                position_x1 = (cursorx - 10) / 4;
                                position_y1 = (cursory - 4) / 2;

                                if (board[position_y, position_x] == 'K' && ((count2 % 2 == 0 && color[position_y, position_x] == 1) || (count2 % 2 == 1 && color[position_y, position_x] == 2))) // control for king
                                {
                                    if (counterBlueKing == 0 && color[position_y, position_x] == 2 && position_y == 7 && position_x == 4 && position_y1 == 7 && position_x1 == 5 && board[7, 5] == '.' && board[7, 6] == '.' && board[7, 7] == blue_R)
                                    {
                                        Console.SetCursorPosition(60, 5); // blue side short castling
                                        Console.WriteLine("O-O");
                                        board[7, 4] = blue_R;
                                        color[7, 4] = 2;
                                        board[7, 7] = '.';
                                        color[7, 7] = 0;
                                        board[7, 5] = blue_K;
                                        color[7, 5] = 2;
                                        yazdırma = true;
                                        count2++;
                                    }
                                    else if (counterBlueKing == 0 && color[position_y, position_x] == 2 && position_y == 7 && position_x == 4 && position_y1 == 7 && position_x1 == 2 && board[7, 1] == '.' && board[7, 2] == '.' && board[7, 3] == '.' && board[7, 0] == blue_R)
                                    {
                                        Console.SetCursorPosition(60, 5);// blue side long castling
                                        Console.WriteLine("O-O-O");
                                        board[7, 0] = '.';
                                        color[7, 0] = 0;
                                        board[7, 1] = '.';
                                        color[7, 1] = 0;
                                        board[7, 2] = blue_K;
                                        color[7, 2] = 2;
                                        board[7, 3] = blue_R;
                                        color[7, 3] = 2;
                                        board[7, 4] = '.';
                                        color[7, 4] = 0;
                                        yazdırma = true;
                                        count2++;
                                    }
                                    else if (counterRedKing == 0 && color[position_y, position_x] == 1 && position_y == 0 && position_x == 4 && position_y1 == 0 && position_x1 == 5 && board[0, 5] == '.' && board[0, 6] == '.' && board[0, 7] == red_R)
                                    {
                                        Console.SetCursorPosition(60, 5);// red side short castling
                                        Console.WriteLine("O-O");
                                        board[0, 4] = red_R;
                                        color[0, 4] = 1;
                                        board[0, 7] = '.';
                                        color[0, 7] = 0;
                                        board[0, 5] = red_K;
                                        color[0, 5] = 1;
                                        yazdırma = true;
                                        count2++;
                                    }
                                    else if (counterRedKing == 0 && color[position_y, position_x] == 1 && position_y == 0 && position_x == 4 && position_y1 == 0 && position_x1 == 2 && board[0, 1] == '.' && board[0, 2] == '.' && board[0, 3] == '.' && board[0, 0] == red_R)
                                    {
                                        Console.SetCursorPosition(60, 5);// red side long castling
                                        Console.WriteLine("O-O-O");
                                        board[0, 0] = '.';
                                        color[0, 0] = 0;
                                        board[0, 1] = '.';
                                        color[0, 1] = 0;
                                        board[0, 2] = red_K;
                                        color[0, 2] = 1;
                                        board[0, 3] = red_R;
                                        color[0, 3] = 1;
                                        board[0, 4] = '.';
                                        color[0, 4] = 0;
                                        yazdırma = true;
                                        count2++;
                                    }


                                    else if (King(position_x, position_y, position_x1, position_y1, color, board) == true)
                                    {
                                        if (color[position_y, position_x] == 1)
                                        {
                                            counterRedKing++;
                                        }
                                        else
                                        {
                                            counterBlueKing++;
                                        }
                                        holder = board[position_y, position_x];
                                        colorHolder = color[position_y, position_x];
                                        board[position_y, position_x] = '.';
                                        color[position_y, position_x] = 0;


                                        board[position_y1, position_x1] = holder;
                                        color[position_y1, position_x1] = colorHolder;
                                        Console.SetCursorPosition(50, 5);
                                        Console.WriteLine("                                     ");
                                        yazdırma = true;
                                        count2++;
                                    }
                                }
                                ///////////////////////////////////////////////////////////////////////////////////////////
                                if (board[position_y, position_x] == 'Q' && ((count2 % 2 == 0 && color[position_y, position_x] == 1) || (count2 % 2 == 1 && color[position_y, position_x] == 2))) // control for queen
                                {
                                    if (Queen(position_x, position_y, position_x1, position_y1, color, board) == true)
                                    {
                                        holder = board[position_y, position_x];
                                        colorHolder = color[position_y, position_x];
                                        board[position_y, position_x] = '.';
                                        color[position_y, position_x] = 0;


                                        board[position_y1, position_x1] = holder;
                                        color[position_y1, position_x1] = colorHolder;
                                        Console.SetCursorPosition(50, 5);
                                        Console.WriteLine("                                     ");
                                        yazdırma = true;
                                        count2++;
                                    }
                                }
                                ///////////////////////////////////////////////////////////////////////////////////////////
                                if (board[position_y, position_x] == 'B' && ((count2 % 2 == 0 && color[position_y, position_x] == 1) || (count2 % 2 == 1 && color[position_y, position_x] == 2))) // control for bishop
                                {
                                    if (Bishop(position_x, position_y, position_x1, position_y1, color, board) == true)
                                    {
                                        holder = board[position_y, position_x];
                                        colorHolder = color[position_y, position_x];
                                        board[position_y, position_x] = '.';
                                        color[position_y, position_x] = 0;


                                        board[position_y1, position_x1] = holder;
                                        color[position_y1, position_x1] = colorHolder;
                                        Console.SetCursorPosition(50, 5);
                                        Console.WriteLine("                                     ");
                                        yazdırma = true;
                                        count2++;
                                    }
                                }
                                ///////////////////////////////////////////////////////////////////////////////////////////
                                if (board[position_y, position_x] == 'R' && ((count2 % 2 == 0 && color[position_y, position_x] == 1) || (count2 % 2 == 1 && color[position_y, position_x] == 2))) // control for rock
                                {
                                    if (Rook(position_x, position_y, position_x1, position_y1, color, board) == true)
                                    {
                                        holder = board[position_y, position_x];
                                        colorHolder = color[position_y, position_x];
                                        board[position_y, position_x] = '.';
                                        color[position_y, position_x] = 0;


                                        board[position_y1, position_x1] = holder;
                                        color[position_y1, position_x1] = colorHolder;
                                        Console.SetCursorPosition(50, 5);
                                        Console.WriteLine("                                     ");
                                        yazdırma = true;
                                        count2++;
                                    }
                                }
                                ///////////////////////////////////////////////////////////////////////////////////////////////
                                if (board[position_y, position_x] == 'P' && ((count2 % 2 == 0 && color[position_y, position_x] == 1) || (count2 % 2 == 1 && color[position_y, position_x] == 2))) // control for pawn
                                {
                                    if (Pawn(position_x, position_y, position_x1, position_y1, color, board) == true)
                                    {
                                        if ((color[position_y, position_x] == 1) && (position_y == 3) && (position_y1 == 4)) // en passant for red side
                                        {
                                            if ((board[position_y1, position_x1 + 1] == blue_P)) // en passant if enemy pawn is in the right side
                                            {
                                                board[position_y1, position_x1 + 1] = '.';
                                                color[position_y1, position_x1 + 1] = 0;
                                                holder = board[position_y, position_x];
                                                colorHolder = color[position_y, position_x];
                                                board[position_y, position_x] = '.';
                                                color[position_y, position_x] = 0;

                                                board[position_y1, position_x1] = holder;
                                                color[position_y1, position_x1] = colorHolder;
                                            }
                                            else if (board[position_y1, position_x1 - 1] == blue_P) // en passant if enemy pawn is in the left side
                                            {
                                                board[position_y1, position_x1 - 1] = '.';
                                                color[position_y1, position_x1 - 1] = 0;
                                                holder = board[position_y, position_x];
                                                colorHolder = color[position_y, position_x];
                                                board[position_y, position_x] = '.';
                                                color[position_y, position_x] = 0;

                                                board[position_y1, position_x1] = holder;
                                                color[position_y1, position_x1] = colorHolder;
                                            }
                                            else if ((color[position_y, position_x] == 2) && (position_y == 4) && (position_y1 == 3)) // en passant for blue side
                                            {
                                                if ((board[position_y1, position_x1 + 1] == red_P)) // en passant if enemy pawn is in the right side
                                                {
                                                    board[position_y1, position_x1 + 1] = '.';
                                                    color[position_y1, position_x1 + 1] = 0;
                                                    holder = board[position_y, position_x];
                                                    colorHolder = color[position_y, position_x];
                                                    board[position_y, position_x] = '.';
                                                    color[position_y, position_x] = 0;

                                                    board[position_y1, position_x1] = holder;
                                                    color[position_y1, position_x1] = colorHolder;
                                                }
                                                else if (board[position_y1, position_x1 - 1] == red_P) // en passant if enemy pawn is in the left side
                                                {
                                                    board[position_y1, position_x1 - 1] = '.';
                                                    color[position_y1, position_x1 - 1] = 0;
                                                    holder = board[position_y, position_x];
                                                    colorHolder = color[position_y, position_x];
                                                    board[position_y, position_x] = '.';
                                                    color[position_y, position_x] = 0;

                                                    board[position_y1, position_x1] = holder;
                                                    color[position_y1, position_x1] = colorHolder;
                                                }


                                                else
                                                {


                                                    holder = board[position_y, position_x];
                                                    colorHolder = color[position_y, position_x];
                                                    board[position_y, position_x] = '.';
                                                    color[position_y, position_x] = 0;

                                                    board[position_y1, position_x1] = holder;
                                                    color[position_y1, position_x1] = colorHolder;
                                                }
                                            }
                                            else if ((position_y1 == 7) && (color[position_y, position_x] == 1))
                                            {
                                                board[position_y1, position_x1] = 'Q';
                                                color[position_y1, position_x1] = colorHolder;
                                                board[position_y, position_x] = '.';
                                                color[position_y, position_x] = 0;
                                            }


                                            else if ((position_y1 == 0) && color[position_y, position_x] == 2)
                                            {
                                                board[position_y1, position_x1] = 'Q';
                                                color[position_y1, position_x1] = colorHolder;
                                                board[position_y, position_x] = '.';
                                                color[position_y, position_x] = 0;

                                            }
                                            else
                                            {

                                                holder = board[position_y, position_x];
                                                colorHolder = color[position_y, position_x];
                                                board[position_y, position_x] = '.';
                                                color[position_y, position_x] = 0;

                                                board[position_y1, position_x1] = holder;
                                                color[position_y1, position_x1] = colorHolder;

                                            }

                                            Console.SetCursorPosition(50, 5);
                                            Console.WriteLine("                                     ");
                                            yazdırma = true;
                                            count2++;
                                        }
                                    }
                                    ///////////////////////////////////////////////////////////////////////////////////////////////////
                                    if (board[position_y, position_x] == 'N' && ((count2 % 2 == 0 && color[position_y, position_x] == 1) || (count2 % 2 == 1 && color[position_y, position_x] == 2))) // control for knight
                                    {
                                        if (Knight(position_x, position_y, position_x1, position_y1, color, board) == true)
                                        {
                                            holder = board[position_y, position_x];
                                            colorHolder = color[position_y, position_x];
                                            board[position_y, position_x] = '.';
                                            color[position_y, position_x] = 0;


                                            board[position_y1, position_x1] = holder;
                                            color[position_y1, position_x1] = colorHolder;
                                            Console.SetCursorPosition(50, 5);
                                            Console.WriteLine("                                     ");
                                            yazdırma = true;
                                            count2++;
                                        }
                                    }
                                    tus_enter = true;
                                    break;
                                }

                            }
                        }

                    }

                }

            }
        }
    }
}
