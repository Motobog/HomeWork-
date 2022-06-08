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
}
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
//Task3
int num;
Console.Write("Input nature number: ");
num = Convert.ToInt32(Console.ReadLine());
if(num%2==0)
{
Console.WriteLine("Number is even");
}
else
{
Console.WriteLine("Number is odd");
}*/
//Task4
int num, counter = 2;
Console.Write("Input any nature number: ");
num = Convert.ToInt32(Console.ReadLine());
if (num < 2)
{
    Console.WriteLine("There is no nature number divisible by 2 between 0 and " + num);
}
else
{
    while(counter<=num)
    {
      Console.Write(counter +" ");
      counter+=2;
    }
}
Console.WriteLine();