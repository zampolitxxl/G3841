char[]digit = Console.ReadLine().ToCharArray();

if (digit.Length>3)
{
    Console.WriteLine ("Введено верное число");
}
else
{
        Console.WriteLine ("Третей цифры нет");

}
Console.WriteLine ( digit[2]);
