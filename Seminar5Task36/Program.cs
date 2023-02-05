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
//ФУНЦИЯ Выводим массиы
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
//Функция суммирования НЕчетных позиций

int Sumposition(int[] arr)
{
    int res = 0;
    for (int i = 1; i < arr.Length; i=i+2)
        {
        res = arr[i]+res;
        }
    return res;
}
//Решение задачи:
//создаем массив
int[] array  = GenArr(10, -100, 100);

//выводим массив для проверки 
PrintArr(array);
// суммируем элементы, стоящие на четных позициях
int sumPos= Sumposition(array);
//выводим результат
PrintData(sumPos);