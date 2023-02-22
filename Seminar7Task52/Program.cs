// ФУНКЦИЯ считываем данные
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
//ФУНЦИЯ Выводим число
void PrintData(int res)
{
Console.WriteLine(res);
}
//Метод генерации 2 д массива
int [,] Gen2DArr(int row, int col)
{

System.Random numberSyntezator = new System.Random();
int i = 0;
int j=0;
int [,] arr = new int [row , col];
    while (i < row)
    {
        j=0;
        while ( j < col)
        {
            arr[i,j]= numberSyntezator.Next(0,10);
            j++;
        }
        i++;
    }
return arr;
}


//Метод   печати 2 д массива 
 void Print2DArray (int[,] array2d)
 {
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            Console.Write(array2d[i,j]+" ");

        }
        Console.WriteLine(" ");
    }
 
 }

 //метод поиска  Среднеарифметического столбцов

double[] Average (int[,] array2d)
    {
    double[] averageArr= new double [array2d.GetLength(0)];
    double sumOfCol=0;
    for (int j = 0; j < array2d.GetLength(1); j++)
    {
        sumOfCol=0;
        for (int i = 0; i < array2d.GetLength(0); i++)
        {
         sumOfCol= array2d[i,j]+sumOfCol;

        }
        averageArr[j]=sumOfCol/array2d.GetLength(1);   
    }
    return averageArr;
}
//Печать одномерного вещественного массива
void PrintDoubleArr(double[] arr)
{
Console.Write("[");
for(int i = 0; i<arr.Length-1; i++)
    {
    Console.Write(arr[i]+", ");
    }
    Console.WriteLine(arr[arr.Length-1]+ "]");
}

//1) просим ввести столбцы строки
int row = ReadData("Напишите количество строк");
int col = ReadData("Напишите количество столбцов");

// Генерируем новый массив

int[,] arrIJ = Gen2DArr(row, col);
// выводим массив на экран

Print2DArray(arrIJ);
Console.WriteLine(" ");
//Считаем сумму элементов по диагонали
double[] averaging = Average(arrIJ);
//Выводим результат 

PrintDoubleArr(averaging);