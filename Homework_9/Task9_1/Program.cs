/*Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/
int SumNaturalNumbers(int min, int max)
{
    if(max>min) return max + SumNaturalNumbers(min,max-1);
    else return min;

}

Console.Clear();

Console.Write("enter the first natural number of the range: ");
bool sucsessStartInterval = int.TryParse(Console.ReadLine(), out int startInterval);
Console.Write("Enter the second natural number greater than the first: ");
bool sucsessEndInerval = int.TryParse(Console.ReadLine(), out int endInterval);
if (sucsessStartInterval && sucsessEndInerval && startInterval > 0 && endInterval > startInterval)
    Console.WriteLine(SumNaturalNumbers(startInterval, endInterval));
else Console.WriteLine("Input correct numbers");