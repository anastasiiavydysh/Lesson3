Console.Write("Write radius -> ");
double radius = Convert.ToInt32(Console.ReadLine());
Console.Write("Write height -> ");
double height = Convert.ToInt32(Console.ReadLine());

if(radius > 0 && height > 0)
{
    double v =Math.PI*Math.Pow(radius, 2)*height;
    double s = 2*Math.PI * radius * (radius + height);
    Console.WriteLine("V = " + v + ", S = " + s + ". Press any key.");
}
else
{
    Console.WriteLine("Radius and height cannot be < or = 0. Press any key.");
}

Console.ReadKey();