/*Напишите программу, которая будет принимать на вход число и возвращать кол-во его цифр.

453 -> 3

45 -> 2*/

int SumOfDifits(int num)

{
    if (num > 0) return 1 + SumOfDifits(num / 10);
    else return 0;
}

Console.Clear();

Console.Write("Enter natural number: ");
bool sucsessnumber = int.TryParse(Console.ReadLine(), out int number);

if (sucsessnumber && number > 0)
    Console.WriteLine("Sum of digits is: " + SumOfDifits(number));
else Console.WriteLine("Input correct numbers");
