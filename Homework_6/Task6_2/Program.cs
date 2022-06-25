// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
int[] CopyArray(int[] array)
{
    int LengthArray = array.Length;
    int[] NewArray = new int[LengthArray];
    for (int i = 0; i < LengthArray; i++) NewArray[i] = array[i];
    return NewArray;
}
void PrintArray(int[] WelcomeArray)
{
    int count = WelcomeArray.Length - 1;
    Console.Write("[");
    for (int j = 0; j < count; j++) Console.Write($"{WelcomeArray[j]},");
    Console.WriteLine(WelcomeArray[count] + "]");
}
Console.Clear();
int[] BestArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
PrintArray(BestArray);
int[] CopyBestArray = CopyArray(BestArray);
PrintArray(CopyBestArray);

