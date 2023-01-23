int day = int.Parse(Console.ReadLine() ?? "0");
if (day > 7 || day < 1)
{
    Console.WriteLine("Это не день недели");

}
else
{
    if (day > 5)
    {
        Console.WriteLine("Это выходной день");

    }
    else
    {

        Console.WriteLine("Это  будний день");


    }
}

