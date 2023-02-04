// ФУНКЦИЯ считываем данные
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
//ФУНЦИЯ Выводим результат
void PrintArr(int[] arr)
{
Console.Write("[");
for(int i = 0; i<arr.Length-1; i++)
    {
    Console.Write(arr[i]+", ");
    }
    Console.WriteLine(arr[arr.Length-1]+ "]");
}
//Функция генерирования Массива
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
//просим ввести длинну массива и диапозон данных в массиве
int arrLen=ReadData("Введите длинну массива");
//просим ввести нижнюю границу  массива
int arrDown=ReadData("Введите нижнюю границу массива");
//просим ввести верхнюю границу  массива
int arrUP=ReadData("Введите верхнюю границу массива");

//генерируем массив
int[]arr = GenArr(arrLen, arrDown, arrUP);
//Выводим массив на экран
PrintArr(arr);