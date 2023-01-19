Console.WriteLine("Введите трехзначное число");

int num = int.Parse(Console.ReadLine()??"0");
if (num<100 || num > 999)
{
    Console.WriteLine("Вы ввели не трехзначное число, пожалуйста попробуйте снова");
}
else
{
    int res =num/ 10;

    res = res % 10 ;

    Console.WriteLine(res);
}
