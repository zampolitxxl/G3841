int ReadData(string msg)
{
    Console.WriteLine("Введите  N);
    return int.Parse(Console.ReadLine() ?? "0");
}
//Выводим результат
void PrintData(string msg, double res)
{
Console.WriteLine(msg + res);
}

string LineBuilder(int n, int p)
{
string s = "";
for (int i = 1; i<=n, i++)
{
 s+=Math.Pow(i, p).ToString() + "\t";
}
return s;

// Ввод данных 
int num = PrintData("Введите N: ");

//Собираем первую строчку талицы

string line1 = LineBuilder(num, 1);
 // Собирвем вторуб строчку таблицы
string line2 = LineBuilder(num, 2);
//Вывод данных
PrintData(line1, line2);