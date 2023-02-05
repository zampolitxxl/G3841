//Функция генерирования 1 мерного Массива
int[] GenArr(int num, int begin, int end)
{
Random rnd = new Random();
int[] arr = new int [num];
for (int i = 0; i < arr.Length; i++)
{
    arr[i]= rnd.Next(begin, end);
}
return arr;
}
//ФУНЦИЯ Выводим массив
void PrintArr(int[] arr)
{
Console.Write("[");
for(int i = 0; i<arr.Length-1; i++)
    {
    Console.Write(arr[i]+", ");
    }
    Console.WriteLine(arr[arr.Length-1]+ "]");
}
//ФУНЦИЯ Выводим число
void PrintData(int res)
{
Console.WriteLine(res);
}
// ФУНКЦИЯ считываем данные
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
//Функция тест
bool Test(int n)
{
int ostatok=n%2;
return(ostatok==0);
}
//Функция CountElement
int CountElement(int[]arr)
{
    int res = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(Test(arr[i]))
        {
            res++;
        }
        
    }
    return res;
} 

///решение преподавателя
/*  int CountElem(int[] arr)
{
    int res = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (Test(arr[i]))
        {
            res++;
        }
    }
    return res;
}

bool Test(int n)
{
    return (n>10&&n<99);
}   */






// Решение задачи

//генерируем массив
int[] newMassive = GenArr(10, 0, 1000);
//Выводим массив на экран
PrintArr(newMassive);
//Считаем элементы от 10 до 99 в массиве
int countin = CountElement(newMassive);
//Пишем количество элементов от 10 до 99 в массиве
PrintData(countin );