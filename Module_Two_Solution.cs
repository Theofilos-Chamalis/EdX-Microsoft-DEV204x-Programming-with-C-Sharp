using System;

namespace ConsoleApplication2
{
    class Module_Two_Solution
    {
        static void Main(string[] args)
        {
            string[,] chessMatrix = new string[8, 8];

            //Initialize the Matrix with ""
            for (int i = 0; i < chessMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < chessMatrix.GetLength(1); j++)
                {
                    chessMatrix[i, j] = "";
                }
            }

            //Initialize the two upper left squares on the chess grid
            chessMatrix[0, 0] = "X";
            chessMatrix[0, 1] = "O";

            //Fill the matrix with the appropriate values
            for (int i = 0; i < chessMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < chessMatrix.GetLength(1); j++)
                {
                    if (i == 0 && j != 0 && j != 1)
                    {
                        chessMatrix[i, j] = chessMatrix[i, j - 2];
                    }
                    if (i > 0 && j < chessMatrix.GetLength(1) - 1)
                    {
                        chessMatrix[i, j] = chessMatrix[i - 1, j + 1];
                    }
                    else if (i > 0 && j == chessMatrix.GetLength(1) - 1)
                    {
                        chessMatrix[i, j] = chessMatrix[i - 1, j - 1];
                    }
                }
            }

            //Print the matrix
            for (int i = 0; i < chessMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < chessMatrix.GetLength(1); j++)
                {
                    if (j < chessMatrix.GetLength(1) - 1)
                        Console.Write(chessMatrix[i, j]);
                    else
                        Console.WriteLine(chessMatrix[i, j]);
                }
            }
            
        }
    }
}