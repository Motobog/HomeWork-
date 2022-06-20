//Задайте массив вещественных(дробных, см. Random().NextDouble()) чисел. Найдите разницу между максимальным и минимальным элементов массива. [3 7 22 2 78] -> 76
double[] GenArray(double min, double max, int count)
{
    double[] array = new double[count];
    for (int i = 0; i < count; i++)
    {
        array[i] = Math.Round((new Random().NextDouble()*(max-min)+min),3);
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
    return array;
}
double MaxDigital(double[]array)
{
    double maxNumber=array[0];
    for(int k=1;k<array.Length;k++) if (array[k]>maxNumber) maxNumber=array[k];
    return maxNumber;
}
double MinDigital(double[]array)
{
    double minNumber=array[0];
    for(int j=1;j<array.Length;j++) if (array[j]<minNumber) minNumber=array[j];
    return minNumber;
}
Console.Clear();
double minNum=2, maxNum=99;
Console.Write("Input array length: ");
bool success = int.TryParse(Console.ReadLine(), out int lengthArray);
if(success&&lengthArray>0)
{
    double[]newArray=GenArray(minNum,maxNum,lengthArray);
    Console.WriteLine($"In array maximum number minus minimum number is {MaxDigital(newArray)-MinDigital(newArray)}");
}
else Console.WriteLine("Array length must be natura numbers. Try again!");