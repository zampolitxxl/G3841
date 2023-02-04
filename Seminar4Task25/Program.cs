// ФУНКЦИЯ считываем данные
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
//ФУНЦИЯ Выводим результат
void PrintData(int res)
{
Console.WriteLine(res);
}
//Функция выводит число а в степени Б
int stepenAB (int numA, int numB)
{
    int summa=1;
    for(int i =1; i <=numB;i++)

    {
        summa=summa*numA;
    }


    return summa;
}

//Прсим вести число 

int numberA=ReadData("Ввведите число");
int numberB=ReadData("Ввведите степень, в которую нужно возвести число");

//Считаем сумму от 1 до А

int result=stepenAB(numberA, numberB);

//выводим результат 

PrintData(result);


