double Length(double xA, double yA, double zA, double xB, double yB, double zB)
{
return Math.Round(Math.Sqrt(Math.Pow(xA-xB,2)+Math.Pow(yA-yB,2)+Math.Pow(zA-zB,2)),2);
}
Console.WriteLine("Input coordinates point A.");
Console.Write("xA: ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("yA: ");
double yA = Convert.ToDouble(Console.ReadLine());
Console.Write("zA: ");
double zA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input coordinates point B.");
Console.Write("xB: ");
double xB = Convert.ToDouble(Console.ReadLine());
Console.Write("yB: ");
double yB = Convert.ToDouble(Console.ReadLine());
Console.Write("zB: ");
double zB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Distance between points is {Length(xA, yA, zA, xB, yB, zB)}");