Console.Write("Введите первое число: ");
int firstNum = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondNum = int.Parse(Console.ReadLine());
int max = firstNum;
int min = secondNum;

if( firstNum > secondNum )
{
    max = firstNum;
    min = secondNum;
    Console.Write("max = ");
    Console.WriteLine(max);
    Console.Write("min = ");
    Console.WriteLine(min);
}
if( secondNum > firstNum)
{
    max = secondNum;
    min = firstNum;
    Console.Write("max = ");
    Console.WriteLine(max);
    Console.Write("min = ");
    Console.WriteLine(min);
}
if(firstNum == secondNum)
{
    Console.WriteLine("The numbers are equal");
}
