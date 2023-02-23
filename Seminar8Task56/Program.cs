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


 //   Нахождение суммы наибольшей строки 2 мерного массива п

 int MinSumString(int[,] array2d)
{  
    int min = int.MaxValue;
    int bufSum = 0;
    for (int i = 0; i < array2d.GetLength(0); i++)
    {   bufSum=0;
        for (int j = 0; j < array2d.GetLength(1); j++)
        {   
            bufSum=array2d[i,j]+bufSum;
        }

        if(bufSum<min)
            {
            min=bufSum;
            }
           
    }
    return min;
}

//Решение

int row=ReadData("Напишите количество строк");
int col=ReadData("Напишите количество столбцов");

//создаем массив

int[,] arrayNew = Gen2DArr(row,col);
//печатаем массив
Print2DArray(arrayNew);
Console.WriteLine(" ");

//находим сумму минимальную строки массива


int sumOfMin=MinSumString(arrayNew);

Console.WriteLine(sumOfMin);
