/* Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

В итоге получается вот такой массив:

1 2 4 7
2 3 5 9
2 4 4 8*/

int[,] ArrayGenerator(int lines, int rows)
{
    int[,] array = new int[lines, rows];

    for (int i = 0; i < lines; i++)
        for (int j = 0; j < rows; j++)
            array[i, j] = new Random().Next(1, 10);

    return array;
}

void ShowArray(int[,] arrayForShow)
{
    for (int k = 0; k < arrayForShow.GetLength(0); k++)
    {
        for (int l = 0; l < arrayForShow.GetLength(1); l++)
            Console.Write(arrayForShow[k, l] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] SortValuesInLines(int[,] array)
{
    int temp = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int lustNumber = array.GetLength(1); lustNumber > 1; lustNumber--)
            for (int j = 1; j < lustNumber; j++)
                if (array[i, j - 1] > array[i, j])
                {
                    temp = array[i, j];
                    array[i, j] = array[i, j - 1];
                    array[i, j - 1] = temp;
                }

    return array;
}

Console.Clear();

Console.Write("Enter the number of lines: ");
bool sucsessLine = int.TryParse(Console.ReadLine(), out int numberOfLine);
Console.Write("Enter the number of rows: ");
bool sucsessRows = int.TryParse(Console.ReadLine(), out int numberOfRows);

if (sucsessRows && sucsessLine && numberOfLine > 0 && numberOfRows > 0)
{
    int[,] myArray = ArrayGenerator(numberOfLine, numberOfRows);
    ShowArray(myArray);
    int[,] sortArray = SortValuesInLines(myArray);
    ShowArray(sortArray);
}
else Console.WriteLine("Enter correct number of stroke and columns!");
