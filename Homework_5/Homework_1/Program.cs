// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве. [345, 897, 568, 234] -> 2
int[] GenArray(int min, int max, int count)
{
    int[] array = new int[count];
    for (int i = 0; i < count; i++)
    {
        array[i] = new Random().Next(min, max + 1);
        Console.Write(array[i] + " ");
    }
    
    Console.WriteLine();
    return array;
}
int PositiveNumberCounter(int[] array)
{
int count=0;
for(int i =0;i<array.Length;i++)if (array[i]%2==1) count++;
return count;
}
Console.Clear();
int minNum=100, maxNum=999;
Console.Write("Input array length: ");
bool success = int.TryParse(Console.ReadLine(), out int lengthArray);
if(success&&lengthArray>0)
{
    int[]newArray=GenArray(minNum,maxNum,lengthArray);
    Console.WriteLine($"In array {PositiveNumberCounter(newArray)} odd numbers!");
}
else Console.WriteLine("Array length must be natura numbers. Try again!");
