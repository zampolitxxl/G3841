Console.WriteLine("Введите первое число");
string? inputNum1 = Console.ReadLine();
Console.WriteLine("Введите второе число");
string? inputNum2 = Console.ReadLine();
if(inputNum1!=null && inputNum2!=null)
{ 
    int num1 = int.Parse(inputNum1);
    int num2 = int.Parse(inputNum2);

    if(num1>num2)
    {
    Console.WriteLine("Первое число больше второго");

    }
    else
    {
    Console.WriteLine("Второе число больше первого");
    }
}
