System.Random numsintezator = new System.Random();
int num = numsintezator.Next(100,1000);
Console.WriteLine(num);
int digit1 = num/100;
int digit2 = num%10;
Console.WriteLine(digit1 + "" + digit2);

