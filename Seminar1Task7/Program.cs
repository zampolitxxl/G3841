Console.WriteLine("Здраствуйте, напишите число !");
string imputnumber = Console.ReadLine();
if(imputnumber!=null)
{
    int numberA = int.Parse(imputnumber);
    int lastDigit = numberA % 10;

    Console.WriteLine(lastDigit);
 
}  
