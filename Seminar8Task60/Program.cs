// создали генератор уникальных двузначных чисел, который возвращает int число
  int GenerateUniqueNumber()
{
  //создали ХэшНет последовательнось чисел
 HashSet<int> numbers = new HashSet<int>();
// создали генератор уникальных чисел R
 Random r = new Random();

//создаем бесконечный цикл
    while (true)
    {
    //создается уникальное число в рандомизаторе
        var n = r.Next(10, 100);
        //если в Хэшнет последовательности отсутствует данное число 
        if (!numbers.Contains(n))
        {
         //добавляем в хэшнет массив данное число
            numbers.Add(n);
            //возвращаем как ИНТ данное число 
            return n;
        }
        
    }
}




//ФУНКЦИЯ считываем данные
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
//Метод генерации  3д массива уникальных чисел
int [,,] Gen3DArr(int row, int col, int fird)
{

int i = 0;
int j=0;
int k =0;
int [,,] arr = new int [row , col, fird];
    while (i< row)
    {
        j=0;
        
        while ( j < col)
        {
        k=0;
            
                while(k<fird)
                {
                 arr[i,j,k]= GenerateUniqueNumber();
                 k++;
                } 
         
        j++;
        }
                  
        i++;
    }
return arr;
}


//Метод   печати 3 д массива 
 void Print3DArray (int[,,] array2d)
 {
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
            {
                for(int k =0; k<array2d.GetLength(2);k++)
        
                {
                Console.Write(array2d[i,j,k]+"("+i+","+j+","+k+")");

                }
             Console.WriteLine(" ");

            }
    }
 
 }


 
 
int row=ReadData("Напишите количество строк");
int col=ReadData("Напишите количество столбцов");
int fird=ReadData("Напишите количество 3 стороны");

//создаем массив 1 

int[,,] arrayNew1 = Gen3DArr(row,col,fird);


//печатаем массив 1
Print3DArray(arrayNew1);
Console.WriteLine(" ");




