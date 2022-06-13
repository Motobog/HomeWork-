//Task1
/*void IntSec()
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
IntSec();*/
//Task2_Method1
void ThreeDigFromLeft()
{
    int num, count, degree;//degree = 3 Количество разрядов для числа variable, если число положительное и состоит из 3 знаков 
    Console.Write("Method 1. Input thee or more digit number: ");
    string? variable = Console.ReadLine();
    int variablelength = variable!.Length;//Считается кол-во знаков в числе с учетом "-"
    if (variablelength < 4)//Проверка на количество знаков
    {
        num = Math.Abs(Convert.ToInt32(variable));//считается модуль числа
        if (num < 100) Console.WriteLine("In number less than three digits!");//числа от -99 до 99 будут отсеяны
        else Console.WriteLine($"Third number from the left is {num % 10}");//Для чисел от 100 до 999 будет посчитан 3 справа знак   
    }
    else//Подсчёт для чисел, где больше 3 разрядов
    {
        variable = variable.Remove(4, variablelength - 4);//Отсекаются все знаки кроме первых 4
        num = Math.Abs(Convert.ToInt32(variable));//Считается модуль числа
        degree = Convert.ToString(num).Length;//вычисляется кол-во разрядов
        count = Convert.ToInt32(Math.Pow(10, degree - 3));//Двойная точность будет переведена в целое число
        Console.WriteLine($"Third number from the left is {num / count % 10}");
    }
}
ThreeDigFromLeft();
//Task2_Method2
void ThreeDigFromTheLeft()
{
    Console.Write("Method 2. Input thee or more digit number: ");
    string? numstring = Console.ReadLine();
    double num = Math.Abs(Convert.ToDouble(numstring));//Строка переводится в число
    int numlength = numstring.Length;//Вычисляется разрядность числа
    if (numstring.Substring(0, 1) == "-") numlength--;//убирается "-" из подсчета кол-ва разрядов
    if (num < 100) Console.WriteLine("In number less than three digits!");//проверка на трехразрядность
    else Console.WriteLine($"Third number from the left is {Math.Truncate(num / Math.Pow(10, numlength - 3)) % 10}");//Вывод результата
}
ThreeDigFromTheLeft();
//Task3_Method3
void ThreeDigitFromLeft()
{
    int dig = 2;//По умолчанию считаем. что число положительное и нам нужен 3 знак слева
    Console.Write("Method 3. Input thee or more digit number: ");
    string? numstring = Console.ReadLine();
    double num = Convert.ToDouble(numstring);//Переводим строку в число
    if (num < 0) dig = 3;//Если число отрицательное, то нужен 4 знак слева
    if (num < 100 && num > -100) Console.WriteLine("In number less than three digits!");//Проверка на 3 значность
    else Console.WriteLine($"Third number from the left is {numstring.Substring(dig, 1)}");//Вывод нужного знака слева
}
ThreeDigitFromLeft();
//Task3_Method4
void ThreeDigitFromTheLeft()
{
    Console.Write("Method 4. Input thee or more digit number: ");
    double num = Math.Abs(Convert.ToDouble(Console.ReadLine()));//Получаем модуль введенного числа
    if (num < 100) Console.WriteLine("In number less than three digits!");//Проверка на 3 значность
    while (num > 999) num /= 10; //Приводим число к 3 значному виду
    Console.WriteLine($"Third number from the left is {Math.Truncate(num) % 10}");
}
ThreeDigitFromTheLeft();
