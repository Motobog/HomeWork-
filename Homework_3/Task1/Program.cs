string PalCheck(int num)
{
    int[] digit = new int[5];
    for (int i = 0; i <= 4; i++)
    {
        digit[i] = num % 10;
        num /= 10;
    }
    if (digit[0] == digit[4] && digit[1] == digit[3]) return "Polindrom";
    else return "Not Polindrom";
}

Console.Write("Input 5 digigtal number: ");
int number = Convert.ToInt32(Console.ReadLine());
if ( number > 99999 || number < -99999 || number > -10000 && number < 10000) Console.WriteLine("Input correct number!");
else Console.WriteLine(PalCheck(number));