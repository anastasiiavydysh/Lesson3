const double pi = 3.1416f;

Console.Write("Enter radius -> ");
double r = Convert.ToSingle(Console.ReadLine());

if (r > 0)
{
    double square = (double)pi * Math.Pow(r, 2);
    Console.WriteLine("Square = " + square +". Press any key.");   
}
else
{
    Console.WriteLine("Radius cannot be < or = 0. Press any key.");    
}

Console.ReadKey();