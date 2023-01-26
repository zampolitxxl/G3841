// вводим ФУНЦИЮ считывания данных int и возврата их в чар
char[] ReadData(string msg)
{
    Console.WriteLine(msg);
    char[] digit = Console.ReadLine().ToCharArray();
    return digit;
}
// вводим ФУНКЦИЮ проверки что число НЕ является  НЕ 5-значным
void LengthCheck(char[] digit,int lenght)
    {
        if (digit.Length!= lenght)
        {
        PrintData("Введено не верное число, пожалуйста попробуйте снова");
        }
    }
//вводим ФУНКЦИЮ выведения  сообщения и результата
void PrintData(string msg)
{
Console.WriteLine(msg);
}
// вводим ФУНКЦИЮ проверки на палиндром 5 значного числа

void Palindrom5check(char[] digit)
    {
    if(digit[0]==digit[4]&& digit[1]==digit[3] )
        {
        PrintData("Число является палиндромом");
        }
    else
        {
        PrintData("Число НЕ является палиндромом");
        }

    }
//просим ввести число
char[] chekDigit = ReadData("Введите 5 значное число");
//проверяем полученный char на длинну 5
LengthCheck(chekDigit, 5);
//проверяем является число палиндромом или нет
Palindrom5check(chekDigit);


