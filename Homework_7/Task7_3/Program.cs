/*Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/
Console.Clear();

int[,] ArrayGenerator()
{
    int m = new Random().Next(3, 11);
    int n = new Random().Next(3, 11);
    int[,] array = new int[m, n];

    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            array[i, j] = new Random().Next(1, 10);

    return array;
}

void AverageOfArrayColumnsPrint(int[,] printArray)
{
    double average;
    int numberOfRows = printArray.GetLength(0);
    int numberOfColumns = printArray.GetLength(1);

    Console.SetCursorPosition(numberOfColumns * 3 - 6, numberOfRows + 3);
    Console.WriteLine("Average");
    
    for (int k = 0; k < numberOfColumns; k++)
    {
        average = 0;
        for (int l = 0; l < numberOfRows; l++)
        {
            average += printArray[l, k];
            Console.SetCursorPosition(k * 6, l + 3);
            Console.Write(printArray[l, k]);
        }
        Console.SetCursorPosition(k * 6, numberOfRows + 4);
        Console.WriteLine(Math.Round(average / numberOfRows, 1));
    }
    Console.WriteLine();
}

Console.WriteLine("We came up with a two-dimensional array from 3 to 10 rows and columns and ");
Console.WriteLine("calculated the arithmetic mean for each columns");

int[,] newArray = ArrayGenerator();
AverageOfArrayColumnsPrint(newArray);

