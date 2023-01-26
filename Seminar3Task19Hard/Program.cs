// создаем словарь новый
var palindromDic = new Dictionary<int, int>();
//просим ввести число, парсим его в ИНТ
int imputNumber =ReadData("введите 5 значное число для проверки на палиндром");

//Методы
//создаем метод заполнения словаря
void DicPaliWrite(int stringsNumber, int firstPalindrom, int firstKey)
{
//вводим переменную -необходимое количество ключей
int quantaty = stringsNumber;
//вводим переменную - с какого номера начинается первый ключ
//вводим переменную значение палиндрома первого
int paliDigit = firstPalindrom;

// добавляем элемент: ключ - номер по порядку от 1 до 90, значение - палиндром
//начинаем цикл добавления списка в словарь 

int x = firstKey;
while (x< quantaty)
{
//добавляем 1 значение в словарь с иксом и палиндромом
    palindromDic.Add(x, paliDigit);
    //увеличиваем 2 переменные 
    //делаем проверку на каждое 10 значение ключа, тк в этом случаем мы увеличиваем переменную на 11 место 110
    if((x+10)%10!=0)
    {
        paliDigit = paliDigit + 110;
        x = x+1;

    }
    else
    //тут выходит ключ кратный 10. тогда прибаляем 11 вместо 110
    {
     paliDigit = paliDigit + 11;
     x = x+1;
    }
}
}

// вводим ФУНЦИЮ считывания данных в формате int 
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int digit = int.Parse(Console.ReadLine()??"0");
    return digit;
}
// вводим ФУНКЦИЮ проверки что число НЕ является  НЕ 5-значным
void LengthCheck(int digitCheck, int lenght)
    {
        int digitCount = (int)Math.Log10(digitCheck) + 1;
        if (digitCount!= lenght)
        {
        PrintData("Введено не верное число, пожалуйста попробуйте снова");
        }
    }
//вводим ФУНКЦИЮ выведения  сообщения и результата
void PrintData(string msg)
{
Console.WriteLine(msg);
}
//вводим Метод убирания 3 цифры

int DeleteThirdNumber(int digit5)
{
int digit01=digit5/1000;
int digit34=digit5%100;

string stringNumber01=digit01.ToString();
string stringNumber34=digit34.ToString();
string number0134=stringNumber01+stringNumber34;
int finishNumber=int.Parse(number0134);
return finishNumber;
}

//вводим функцию проверки числа на палиндром с помощью Dictionary
void Palindromcheck(int finishdigit)
    {
    var valueExists = palindromDic.ContainsValue(finishdigit);
 
    Console.WriteLine(valueExists);       
    }


//Вычисление

//вызываем метод заполнения словаря и вводим туда переменные
DicPaliWrite(90,1001,1);

//проверяем число на количество знаков

LengthCheck(imputNumber, 5);

//удаляем третью цифру

DeleteThirdNumber(imputNumber);

//проверяем является число палиндромом

Palindromcheck(DeleteThirdNumber(imputNumber));

