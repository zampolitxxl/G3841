Console.WriteLine("Введите номер, вам отобразится день недели");
string? imputline = Console.ReadLine();
//вариант 1

if(imputline!=null)
    {
    string[] dayofWeek = new string[7];
    dayofWeek[0] = "Понедельник";
    dayofWeek[1] = "Вторник";
    dayofWeek[2] = "Среда";
    dayofWeek[3] = "Четверг";
    dayofWeek[4] = "Пятница";
    dayofWeek[5] = "Суббота";
    dayofWeek[6] = "Воскресенье";

    int imputnumber = int.Parse(imputline);

    string outDayofWeek = dayofWeek[imputnumber-1];

    Console.WriteLine(outDayofWeek);
    }