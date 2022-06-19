//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 3, 5 -> 243 (3⁵) 2, 4 -> 16
int Expon(int basis, int degree)
{
    int res = 1;
    for (int i = 1; i <= degree; i++) res *= basis;
    return res;
}
Console.Clear();
Console.Write("Input integer base: ");
bool success = int.TryParse(Console.ReadLine(), out int bas);
if (success)
{
    Console.Write("Input natural degree: ");
    success = int.TryParse(Console.ReadLine(), out int deg);
    if (success == true && deg > 0)
    {
        int result = Expon(bas, deg);
        Console.WriteLine($"Base {bas} in {deg} degree = {result}");
    }
    else Console.WriteLine("Input correct natural degree!");
}
else Console.WriteLine("Input correct integer base!");