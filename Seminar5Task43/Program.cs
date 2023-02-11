// ФУНКЦИЯ считываем данные
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
//Функция вывода данных стринг + ИНТ
void PrintData(string words, string info)
{
Console.Write(words);
Console.WriteLine(info);
}

//Метод поиска координат точки пересечения двух прямых

string Intersection(double b1, double k1, double b2, double k2)
{
    
    double interPointX = (b2-b1)/(k1-k2);
    double interPointY = k1*interPointX+b1;
    

    string Y=Convert.ToString(interPointY);
    string X=Convert.ToString(interPointX);
    string IntersectionPoint = "("+X+","+Y+")";
    

    return IntersectionPoint;
}


//Решение


//Просим ввести поочередно координаты точек
int b1 = ReadData("Введит координаты точки b1");
int k1 = ReadData("Введит координаты точки k1");
int b2 = ReadData("Введит координаты точки b2");
int k2 = ReadData("Введит координаты точки k2");



//Вычисляем точку перечения по методу
//проверка на параллельность
    if(k1==k2)
    {
    Console.WriteLine("Прямые не пересекаются");
    }
    else
    {
    string intPointRes = Intersection(b1, k1, b2, k2);
    //Выводим ответ на экран
    PrintData("Точка пересечения двух прямых имеет координаты: ", intPointRes);
    }
