// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях. [3, 7, 23, 12] -> 19 [-4, -6, 89, 6] -> 0
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
int SumOddPosition(int[] array)
{
int sum=0;
for(int i =1;i<array.Length;i+=2) sum+=array[i];
return sum;
}
Console.Clear();
int minNum=-99, maxNum=99;
Console.Write("Input array length: ");
bool success = int.TryParse(Console.ReadLine(), out int lengthArray);
if(success&&lengthArray>0)
{
    int[]newArray=GenArray(minNum,maxNum,lengthArray);
    Console.WriteLine($"In array sum number at odd position is {SumOddPosition(newArray)}");
}
else Console.WriteLine("Array length must be natura numbers. Try again!");