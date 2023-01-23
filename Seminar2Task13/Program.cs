char[] digit = Console.ReadLine().ToCharArray();

if (digit.Length > 2)
{
    Console.WriteLine("Введено верное число");
    Console.WriteLine(digit[2]);

}
else
{
    Console.WriteLine("Третей цифры нет");

}
