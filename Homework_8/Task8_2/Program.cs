/*Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

int[,] ArrayGenerator(int Rows, int Column)
{
    int[,] array = new int[Rows, Column];

    for (int i = 0; i < Rows; i++)
        for (int j = 0; j < Column; j++)
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

int SmollestSumOfElementsOfRow(int[,] array)
{
    int numberRowsWithSmallestSum = 0;
    int[] sumOfElementsOfRow = new int[array.GetLength(0)];
    
    for (int i = 0; i < array.GetLength(0); i++)
            for (int j = 0; j < array.GetLength(1); j++)
                sumOfElementsOfRow[i] += array[i, j];

    int smollestSum = sumOfElementsOfRow[0];
    for (int i = 1; i < array.GetLength(0); i++)
        if (sumOfElementsOfRow[i] < smollestSum)
        {
            smollestSum=sumOfElementsOfRow[i];
            numberRowsWithSmallestSum=i;
        }



            return numberRowsWithSmallestSum;
}

Console.Clear();

Console.Write("Set the number of lines in a rectangular two-dimensional array: ");
bool sucsessRows = int.TryParse(Console.ReadLine(), out int numberOfRows);

if (sucsessRows && numberOfRows > 0)
{
    int[,] myArray = ArrayGenerator(numberOfRows, numberOfRows);
    ShowArray(myArray);
    Console.WriteLine("Row number with the smallest sum of elements is: " + SmollestSumOfElementsOfRow(myArray));
    Console.WriteLine();
}
else Console.WriteLine("Enter correct number of stroke and columns!");
