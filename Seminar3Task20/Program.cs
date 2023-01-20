int ReadData(string msg)
{
    Console.WriteLine("Введите координаты X);
    return int.Parse(Console.ReadLine() ?? "0");
}
//Выводим результат
void PrintData(string msg, double res)
{
Console.WriteLine(msg + res);
}

//вычисляем расстояние между 2д точками пространства
double CalcLen(int x1, int x2, int y1, int y2)
{
     double res = 0;
     
     res = Math.Sqrt(Math.Pow(x1-x2,2) + Math.Pow(y1-y2,2));


     return res;
}
//вводим координаты точек
int coordX1 =  ReadData("Введите координату  x1");
int coordX2 =  ReadData("Введите координату  x2");
int coordY1 =  ReadData("Введите координату  y1");
int coordY2 =  ReadData("Введите координату  y2");

 //  вычисляем длину 

 double len = CalcLen(coordX1, coordX2, coordY1, coordY2);

//выдаем результат

PrintData("длина отрезка = ",  len);