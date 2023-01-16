Console.WriteLine("Здраствуйте, напишите число !");
string imputnumber = Console.ReadLine();
if(imputnumber!=null)
{
    int numberA = int.Parse(imputnumber);
    int lastDigit = numberA % 2;
    
// проверяем остаток есть ли

    if(lastDigit!= 0 )

    {
    Console.WriteLine(" Число явялется  нечетным");
    }

    else

    {
    Console.WriteLine("Число является  четным");
    }
    
}  
