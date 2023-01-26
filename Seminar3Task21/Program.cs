// вводим фунцию считывания данных
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
//вводим функцию выведения  сообщения и результата
void PrintData(string msg, double res)
{
Console.WriteLine(msg + res);
}

//вводим фуyкцию вычисления расстояние между 3д точками пространства
double CalcLen(int x1, int x2, int y1, int y2, int z1, int z2)
{
     double res = 0;
     //квадратный корень из суммы квадратов разницы между x1, x2 и y1, y2
     res = Math.Sqrt(Math.Pow(x1-x2,2) + Math.Pow(y1-y2,2) + Math.Pow(z1-z2,2));


     return res;
}
//вводим координаты точек
int coordX1 =  ReadData("Введите координату  x1");
int coordX2 =  ReadData("Введите координату  x2");
int coordY1 =  ReadData("Введите координату  y1");
int coordY2 =  ReadData("Введите координату  y2");
int coordZ1 =  ReadData("Введите координату  z1");
int coordZ2 =  ReadData("Введите координату  z2");

 //  вычисляем длину с использованием метода

 double len = CalcLen(coordX1, coordX2, coordY1, coordY2, coordZ1, coordZ2);

//выдаем результат

PrintData("длина отрезка = ",  len);