// Задача №55
/* Задайте двумерный массив. Напишите программу,
которая заменяет строки на столбцы. В случае,
если это невозможно, программа должна вывести
сообщение для пользователя. */

//ФУНКЦИЯ считываем данные
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
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

// сортировка 1 мерного  массива
void SortArr(int[]arr)
{
 
int temp=0;
for (int i = 0; i < arr.Length - 1; i++)
{
    for (int j = i + 1; j < arr.Length; j++)
    {
        if (arr[j] > arr[i])
        {
            temp = arr[j];
            arr[j] = arr[i];
            arr[i] = temp;
        }
    }
}
}

 // Сортировка 2 мерного массива по строкам

 void SortArray(int[,] array2d)
{  
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        int[] bufarr = new int[array2d.GetLength(1)];
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            bufarr[j]=array2d[i,j];
        }
        SortArr(bufarr);
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            array2d[i,j]=bufarr[j];
        }

    }
 }

//Решение

int row=ReadData("Напишите количество строк");
int col=ReadData("Напишите количество столбцов");

//создаем массив

int[,] arrayNew = Gen2DArr(row,col);
//печатаем массив
Print2DArray(arrayNew);
Console.WriteLine(" ");

//сортируем масси

SortArray(arrayNew);

Print2DArray(arrayNew);

