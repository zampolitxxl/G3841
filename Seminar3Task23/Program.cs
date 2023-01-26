// ФУНКЦИЯ считываем данные
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
//ФУНЦИЯ Выводим результат
void PrintData(string res)
{
Console.WriteLine(res);
}
//Функция делаем линию
string LineBuilder(int n, int p)
    {
        string s = "";
        for (int i = 1; i<=n; i++)
            {
            s+=Math.Pow(i, p).ToString() + "\t";
            }
        return s;
    }
// Ввод данных 
int num = ReadData("Введите N: ");

//Собираем первую строчку таблицы

string line1 = LineBuilder(num, 1);
 // Собирвем вторую строчку таблицы
string line2 = LineBuilder(num, 3);
//Вывод данных
PrintData(line1);
PrintData(line2);
