//Task1
/*double num1,num2;
Console.Write("Input first number: ");
num1=Convert.ToDouble(Console.ReadLine());
Console.Write("Input second number: ");
num2=Convert.ToDouble(Console.ReadLine());
if (num1>=num2)
{
    Console.WriteLine("Max is: " + num1);
}
else
{
   Console.WriteLine("Max is: " + num2); 
}*/
//Task2
double num1, num2, num3, max;
Console.Write("Input first number: ");
num1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input second number: ");
num2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input third number: ");
num3 = Convert.ToDouble(Console.ReadLine());
max = num1;
if (num2 > max) max = num2;
if (num3 > max) max = num3;
Console.WriteLine("Max is: " + max);