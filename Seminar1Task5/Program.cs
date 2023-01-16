Console.WriteLine("Здраствуйте, напишите число !");
string imputnumber = Console.ReadLine();
if(imputnumber!=null)
{
    int numberA = int.Parse(imputnumber);
    int numberB = numberA*(-1);

    string lineNumbers = string.Empty;
    
    while(numberB  < numberA)
    {
    lineNumbers = lineNumbers + numberB + ",";
    numberB = numberB + 1;

    
    }

    Console.WriteLine(lineNumbers);

}  