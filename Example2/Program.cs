Console.Write("Введите первое число: ");
int firstNum = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondNum = int.Parse(Console.ReadLine());
int max = firstNum;

if( firstNum > secondNum )
{
    max = firstNum;
}
else
{
    max = secondNum;
}

Console.Write("max = ");
Console.WriteLine(max);