
//Функция генерирования 1 мерного Массива Вещественными числами
double[] GenDoubleArr(int num)
{
Random rnd = new Random();
double[] arr = new double [num];
for (int i = 0; i < arr.Length; i++)
{
     arr[i]= rnd.NextDouble()*100;
}
return arr;
}
//ФУНЦИЯ Выводим массиы
void PrintDoubleArr(double[] arr)
{
Console.Write("[");
for(int i = 0; i<arr.Length-1; i++)
    {
    Console.Write(arr[i]+", ");
    }
    Console.WriteLine(arr[arr.Length-1]+ "]");
}

//Функция поиска максимума и минимума и вывода разницы

double MinMax(double[]arr)
{
    double max=double.MinValue;
    double min =double.MaxValue;
    for(int i = 0; i<arr.Length; i++)
        {
        if(arr[i]>max)
        {
        max=arr[i];
        }
        if(arr[i]<min)
        {
        min=arr[i];
        }
        }
    double miniMax = max - min;
    return miniMax;
}
//сделать
//Функция поиска минимума
//сделать

//ФУНЦИЯ Выводим вещественное  число
void PrintData(double res)
{
Console.WriteLine(res);
}

//Решение
//Генерируем вещественный массив
double[] arrayDouble = GenDoubleArr(10);
//Выводим вещественный массив
PrintDoubleArr(arrayDouble);
//Находим разницу минимального и максимального
double resultMinMax = MinMax(arrayDouble);
//Выводим результат
PrintData (resultMinMax);