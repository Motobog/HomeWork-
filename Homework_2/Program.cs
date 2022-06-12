//Task1
void IntSec()
{
    Console.Write("Input three digit number: ");
    int num=Convert.ToInt32(Console.ReadLine());
    if ((num<1000 && num>99) || (num<-99 && num>-1000))
    {
        int res=Math.Abs(num)/10%10;
        Console.WriteLine($"Two digital is {res}");
    }
    else
    {
        Console.WriteLine("Input Correct number!");
    }
}
IntSec();