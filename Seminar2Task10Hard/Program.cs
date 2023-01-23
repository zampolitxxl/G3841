Console.WriteLine("Введите трехзначное число");

char[] numbers = Console.ReadLine().ToCharArray();

if(numbers.Length == 3)
{
    Console.WriteLine(numbers[1]);
}
else
{
    Console.WriteLine("вы ввели не трехзначное число, попробуйте снова");

}