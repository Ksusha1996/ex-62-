//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] spiralArray = CreateSpiralArray(4);

        PrintArray(spiralArray);

        Console.ReadLine();
    }

    static int[,] CreateSpiralArray(int size)
    {
        int[,] array = new int[size, size];

        int value = 1;
        int row = 0;
        int column = 0;
        int rowIncrement = 0;
        int columnIncrement = 1;
        int limit = size * size;

        while (value <= limit)
        {
            array[row, column] = value;

            if (row + rowIncrement < 0 || row + rowIncrement >= size || column + columnIncrement < 0 || column + columnIncrement >= size || array[row + rowIncrement, column + columnIncrement] != 0)
            {
                int temp = rowIncrement;
                rowIncrement = columnIncrement;
                columnIncrement = -temp;
            }

            row += rowIncrement;
            column += columnIncrement;
            value++;
        }

        return array;
    }

    static void PrintArray(int[,] array)
    {
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(array[i, j].ToString("D2") + " ");
            }
            Console.WriteLine();
        }
    }
}
