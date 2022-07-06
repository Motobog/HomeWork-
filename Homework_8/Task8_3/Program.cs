/*Заполните спирально массив 4 на 4.

Например, на выходе получается вот такой массив:

1 2 3 4

12 13 14 5

11 16 15 6

10 9 8 7*/
int[,] GenerateElementsOfArray(int[,] array)
{
    int countTurns = array.GetLength(0);
    int count = 1, xCoordinates = 0, yCoordinates = 0, rotationFactor = 1;

    for (int i = 0; i < countTurns; i++)
    {
        xCoordinates = i;
        array[0, xCoordinates] = count++;
    }

    countTurns--;
    while (countTurns > 0)
    {
        for (int j = 1; j <= countTurns; j++)
        {
            array[yCoordinates + j * rotationFactor, xCoordinates] = count++;
            array[yCoordinates + countTurns * rotationFactor, xCoordinates - j * rotationFactor] = count + countTurns - 1;
        }
        count += countTurns;
        xCoordinates -= countTurns * rotationFactor;
        yCoordinates += countTurns * rotationFactor;
        countTurns--;
        rotationFactor *= -1;
    }
    return array;
}
void ShowArray(int[,] arrayForShow)
{
    for (int k = 0; k < arrayForShow.GetLength(0); k++)
    {
        for (int l = 0; l < arrayForShow.GetLength(1); l++)
        {
            Console.SetCursorPosition(l * 4, k);
            Console.Write(arrayForShow[k, l]);
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
Console.Clear();
int[,] myArray = new int[4, 4];
myArray = GenerateElementsOfArray(myArray);
ShowArray(myArray);