Console.Write("Enter first number: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Enter second number: ");
int b = int.Parse(Console.ReadLine());
Console.Write("Enter third number: ");
int c = int.Parse(Console.ReadLine());
int max = a;

if (a < b)
{
    max = b;
}
if (a < c)
{
    max = c;    
}

Console.Write("max = ");
Console.WriteLine(max);
