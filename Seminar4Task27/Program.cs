// ФУНКЦИЯ считываем данные
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
//ФУНЦИЯ Выводим результат
void PrintData(int res)
{
Console.WriteLine(res);
}
//вводим фунцию суммирования чисел
int SumDigit(int num)
{
    int res =0;
    while (num>0)
    {
        res=num%10+res;
        num=num/10;

    }
    return res;
}
//Программа: вводим число
int res= ReadData("Введите число");

int resulOfSum=SumDigit(res);
PrintData(resulOfSum);
