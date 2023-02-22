//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.


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
//Метод генерации 2 д массива вещественными числами
double [,] Gen2DDoubleArr(int row, int col)
{

System.Random numberSyntezator = new System.Random();
int i = 0;
int j=0;
double [,] arr = new double [row , col];
    while (i < row)
    {
        j=0;
        while ( j < col)
        {
            arr[i,j]= numberSyntezator.Next(0, 100)+numberSyntezator.NextDouble();
            j++;
        }
        i++;
    }
return arr;
}


//Метод   печати 2 д массива C DT
 void Print2DArray (double[,] array2d)
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



//1) просим ввести столбцы строки
int row = ReadData("Напишите количество строк");
int col = ReadData("Напишите количество столбцов");

// Генерируем новый массив

double[,] arrIJ = Gen2DDoubleArr(row, col);
// выводим массив на экран

Print2DArray(arrIJ);
