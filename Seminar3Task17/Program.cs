// See https://aka.ms/new-console-template for more information
int coordX = ReadData("Введите координаты X");
int coordY = ReadData("Введите координаты Y");
PrintQuterTeast();



//метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine("Введите координаты X");
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintQuterTeast()

{
    if (coordX > 0 && coordY > 0) Console.WriteLine("Точка четверти 1");
    if (coordX > 0 && coordY < 0) Console.WriteLine("Точка четверти 2");
    if (coordX < 0 && coordY < 0) Console.WriteLine("Точка четверти 3");
    if (coordX < 0 && coordY > 0) Console.WriteLine("Точка четверти 4");

