/* Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9*/
Console.Clear();

double[,] ArrayGenerator(int m, int n)
{
    double[,] array = new double[m, n];

    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            array[i, j] = Math.Round((new Random().NextDouble() * 2 - 1) * 9, 1);

    return array;
}

void ArrayPrint(double[,] printArray)
{
    for (int k = 0; k < printArray.GetLength(0); k++)
    {
        for (int l = 0; l < printArray.GetLength(1); l++)
            Console.Write(printArray[k, l] + " ");

        Console.WriteLine();
    }
}

Console.Write("Enter the number of stroke: ");
bool sucsessStroke = int.TryParse(Console.ReadLine(), out int numberOfStroke);
Console.Write("Enter the number of columns: ");
bool sucsessColumn = int.TryParse(Console.ReadLine(), out int numberOfColumns);

if (sucsessColumn && sucsessStroke && numberOfStroke > 0 && numberOfColumns > 0)
{
    double[,] newArray = ArrayGenerator(numberOfStroke, numberOfColumns);
    ArrayPrint(newArray);
}
else Console.WriteLine("Enter correct number of stroke and columns!");
