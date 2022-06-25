//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. 0, 7, 8, -2, -2 -> 2
int MaxValue(int num)
{
    int count = 0;
    for (int i = 1; i <= num; i++)
    {
        Console.Write($"Enter {i} nature number: ");
        bool succeses = int.TryParse(Console.ReadLine(), out int result);
        if (succeses)
        {
            if (succeses && result > 0) count++;
        }
        else
        {
            i--;
            Console.WriteLine("Enter a valid value!");
        }
    }
    return count;
}
int res = 0;
Console.Write("Enter the number of integers to enter (number must be natural): ");
bool success = int.TryParse(Console.ReadLine(), out int number);
if (success && number > 0) res = MaxValue(number);
else Console.Write($"Enter correct number!");
Console.WriteLine($"Number of positive numbers is {res}");
