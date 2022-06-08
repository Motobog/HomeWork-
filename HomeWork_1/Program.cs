//Task1
double num1,num2;
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
}