void Cubed(int num)
{
    int count = 1;
    while (count <= num)
    {
        Console.Write($"{Math.Pow(count, 3)}, ");
        count++;
    }
    Console.WriteLine();
}
Console.Write("Input number greater than one: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 2) Console.WriteLine("Input correct Number!");
else Cubed(number);
