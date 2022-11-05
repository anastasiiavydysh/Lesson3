int num1, num2, num3;

Console.Write("Write first integer number -> ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Write second integer number -> ");
num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Write third integer number -> ");
num3 = Convert.ToInt32(Console.ReadLine());

if (num1 != 0 || num2 != 0 || num3 != 0)
{
    float avg = (float)(num1 + num2 + num3) / 3;
    Console.WriteLine("Average = " + avg + ". Press any button.");
}
else
{
    Console.WriteLine("Please write another numbers. Press any button.");
}

Console.ReadKey();