Console.WriteLine("Введите первое число");
string? inputNum1 = Console.ReadLine();
Console.WriteLine("Введите второе число");
string? inputNum2 = Console.ReadLine();
Console.WriteLine("Введите третье число");
string? inputNum3 = Console.ReadLine();

if(inputNum1!=null && inputNum2!=null && inputNum3!=null)
{ 
    int num1 = int.Parse(inputNum1);
    int num2 = int.Parse(inputNum2);
    int num3 = int.Parse(inputNum3);

    //вводим пока  переменную Максимум приравниваем ее к 1 переменной
    int max = num1;

// проверяем 2 переменную на максимум
    if(num2>max)
    {
    max=num2;
    }
    else
    {
    max = max;
    }
// проверяем 3 переменную на максимум
    if(num3>max)
    {
    max=num3;
    }
    else
    {
    max = max;
    }
//выводим переменную максимум на экран
     Console.WriteLine("Максимумальне значение у числа:" + max);

}
