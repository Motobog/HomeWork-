/*Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

1 7 -> такого числа в массиве нет*/

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

void ArrayPrint(int[,] printArray)
{
    for (int k = 0; k < printArray.GetLength(0); k++)
    {
        for (int l = 0; l < printArray.GetLength(1); l++)
            Console.Write(printArray[k, l] + " ");

        Console.WriteLine();
    }
}

string CheckContentsArray(int[,] checkArray, int strokeNum, int columnsNum)
{
    string result = string.Empty;
    if (strokeNum > checkArray.GetLength(0) && columnsNum > checkArray.GetLength(1))
        return result = "There is no data in the array with this address";
    else return result = "The value of the array at this address is " + checkArray[strokeNum - 1, columnsNum - 1];
}

Console.WriteLine("We came up with a two-dimensional array ranging from 3 to 10 rows and columns. Enter ");
Console.WriteLine("any natural row and column number and find out if there are values there or not.");
Console.Write("Enter the number of stroke: ");
bool sucsessStroke = int.TryParse(Console.ReadLine(), out int numberOfStroke);
Console.Write("Enter the number of columns: ");
bool sucsessColumn = int.TryParse(Console.ReadLine(), out int numberOfColumns);

if (sucsessColumn && sucsessStroke && numberOfStroke > 0 && numberOfColumns > 0)
{
    int[,] newArray = ArrayGenerator();
    Console.WriteLine(CheckContentsArray(newArray, numberOfStroke, numberOfColumns));
    ArrayPrint(newArray);
}
else Console.WriteLine("Enter correct number of stroke and columns!");
