Console.Write("Enter number: ");
int N = int.Parse(Console.ReadLine());

if (N > 0)
{
    for (int i = 2; i <= N; i += 2)
    {
        Console.WriteLine(i);
    }
    
}
else
{
    Console.WriteLine("Invaild value");
}