// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и
/* возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

// ФУНКЦИЯ считываем данные
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
        for (int j = 0; j < array2d.GetLength(0); j++)
        {
            Console.Write(array2d[i,j]+" ");

        }
        Console.WriteLine(" ");
    }
 
 }

//Метод поиска данных в 2 Д массиве по индексу
void seearch2d(int[,] arrayUP, int row, int col)
{
    if(row<=arrayUP.GetLength(0) && col<=arrayUP.GetLength(0))
    {
    Console.WriteLine(arrayUP[row-1, col-1]);
    }
    else
    {
    Console.WriteLine("Элемента с заданным индексом нет");
    }
 }


//Решение 
//Вводим парамептры массива 2 д
int row = ReadData("Введите строку");
int col = ReadData("Введите столбец");

// Генерируем новый массив

int[,] arrIJ = Gen2DArr(10, 10);
// выводим массив на экран
Print2DArray(arrIJ);
Console.WriteLine(" ");

//Ищем позицию
seearch2d(arrIJ, row, col);
//Выводим информацию




