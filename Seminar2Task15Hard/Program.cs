Console.WriteLine("Введите номер дня недели");

// вводим день 
int day = int.Parse(Console.ReadLine() ?? "0");

// создали словарь
var daysOfWeek = new Dictionary<int, string>() 
{
    [1] = "Это не выходной день",
    [2] = "Это не выходной день",
    [3] = "Это не выходной день",
    [4] = "Это не выходной день",
    [5] = "Это не выходной день",
    [6] = "Выходной день!",
    [7] = "Выходной день!",

};
// получаем элемент по ключу day
string answer = daysOfWeek[day];  // answer
Console.WriteLine(answer);  // выводим



