System.Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
{
    if (number1 > number3)
    {
        System.Console.WriteLine("MAX"+number1);
    }
    else 
    {
       System.Console.WriteLine("MAX"+number3); 
    }
}
else 
{
    if (number2 > number3)
    {
        System.Console.WriteLine("MAX"+number2);
    }
    else 
    {
       System.Console.WriteLine("MAX"+number3); 
    }
}
