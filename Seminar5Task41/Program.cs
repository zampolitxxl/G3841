// ФУНКЦИЯ считываем данные стринг
string ReadDataString(string msg)
{
    Console.WriteLine(msg);
    return Console.ReadLine() ?? "0";
}
//ФУНЦИЯ Выводим результат
void PrintData(string words, int info)
{
Console.Write(words);
Console.WriteLine(info);
}


//Создаем метод куда вставлчем стринг и возвращаем инт кол-во полож. чисел

int PosiNumCount(string text)
{
 
string[] words = text.Split(new char[] { ',' });

//узнаем длину разбитого после СПЛИТ "массива"
int len = words.Length;
//создадим переменную подсчета положительных цифр
int posiDigits=0;
 //запустим цикл
 for( int i = 0; i<len; i++)
    
    {int intWords = int.Parse(words[i]);//каждый раз конвертируем элемент ЧАР в ИНТ

        if(intWords>0)
        {
        posiDigits=1+posiDigits;
        }
    
    } 
    return posiDigits;
}

//Выводим Рид Дата
string textInput = ReadDataString("Введите пожалуйста числа для посчета");
// запускаем методподсчета положительных
int pos = PosiNumCount(textInput);
//выводим рез-т
PrintData("ответ:  ", pos);

