Console.WriteLine("Здраствуйте, напишите число !");
string imputnumber = Console.ReadLine();
if(imputnumber!=null)
{
    int numberA = int.Parse(imputnumber);
    int numberB = 1;
    int lastDigit = numberB % 2;

    string lineNumbers = string.Empty;
    
    while(numberB  < numberA)
    {
     lastDigit = numberB % 2;
    
// проверяем остаток есть ли

        if(lastDigit!= 0 )

        {
        // число Б не четное поэтому добавляем к нему единицу и ничего не делаем
        lineNumbers = lineNumbers;
        }

        else

        {
        // число Б  четное поэтому добавляем его в строку, и добавлем к нему единицу и ничего не делаем
        lineNumbers = lineNumbers + numberB + ",";
        }
    numberB = numberB + 1;
    }
    Console.WriteLine(lineNumbers);

}



