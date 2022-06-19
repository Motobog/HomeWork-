//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 1, 2, 5, 7, 19, 3, 44, 3 -> [1, 2, 5, 7, 19, 3, 44, 3]
int[] GenArray()
{
    int[] array = new int[8];
    for (int i = 0; i < 8; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
    return array;
}
Console.Clear();
Console.WriteLine("Now the screen will display an array of 8 random integer numbers from 1 to 99");
int[] arr = GenArray();
Console.Write("[");
for (int j = 0; j < 7; j++) Console.Write(arr[j] + ", ");
Console.Write(arr[7] + "]");
Console.WriteLine();