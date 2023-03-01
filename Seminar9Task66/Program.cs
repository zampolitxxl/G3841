

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Печать результата
void PrintResult(int prefix)
{
    Console.WriteLine(prefix);
}

// 1 2 3 4 5 ..... n
// n = 5

// num = 5   5_4_3_2_1_""
// num = 4     4_3_2_1_""
// num = 3       3_2_1_""
// num = 2         2_1_""
// num = 1           1_""
// num = 0            ""
//

int  RecSumMN(int m, int n)
{
    if (m >= n)
    {
        return n;
    }
    else
    {
        return m + RecSumMN(m+1, n);
    }
}

int m = ReadData("Введите число M: ");
int n = ReadData("Введите число N: ");
int res = RecSumMN(m,n);
PrintResult(res);