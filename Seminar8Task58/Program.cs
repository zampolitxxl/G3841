
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


 //   Нахождение произведения 2 матриц

 int[,] MultiplyMatrix(int[,] A, int[,] B)
    {
        int rowA = A.GetLength(0);
        int colA = A.GetLength(1);
        int rowB = B.GetLength(0);
        int colB = B.GetLength(1);
        int temp = 0;
        int[,] multiMatrix = new int[rowA, colB];
        if (colA != rowB)
        {
            Console.WriteLine("Matrixes can't be multiplied!!");
        }
        else
        {
            
            for (int i = 0; i < rowA; i++)
            {
                for (int j = 0; j < colB; j++)
                {
                    temp = 0;
                    for (int k = 0; k < colA; k++)
                    {
                        temp += A[i, k] * B[k, j];
                    }
                    multiMatrix[i, j] = temp;
                }
            }

        }
            return multiMatrix;

    }

//Решение

int row=ReadData("Напишите количество строк");
int col=ReadData("Напишите количество столбцов");

//создаем массив 1 

int[,] arrayNew1 = Gen2DArr(row,col);
//создаем массив 12
int[,] arrayNew2 = Gen2DArr(row,col);

//печатаем массив 1
Print2DArray(arrayNew1);
Console.WriteLine(" ");
Print2DArray(arrayNew2);



//находим произведение 

int[,] powedMatrix = MultiplyMatrix(arrayNew1, arrayNew2);

//выводим произведение матриц на экран
Print2DArray(powedMatrix);
