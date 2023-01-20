int qNum = ReadData("Введите номер четверти);
 PrintQuterAnswer(int num);



//метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine("Введите координаты X");
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintQuterAnswer(int num)

{
    if (num==1) Console.WriteLine("X > 0, Y > 0");
    if (num==2) Console.WriteLine("X > 0, Y < 0");
    if (num==3) Console.WriteLine("X < 0, Y < 0");
    if (num==4) Console.WriteLine("X < 0, Y > 0");

}