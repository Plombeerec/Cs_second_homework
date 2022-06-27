//Напишите программу, 
//которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

void CheckThird (int n)
{
    if (n/100 == 0)
    {
        Console.WriteLine("Третей цифры в числе нет");
    }
    else
    {
        int result = n/100 ;
        Console.WriteLine("Second number is " + result);
    }
    
}
Console.WriteLine("Enter number");
int number = Convert.ToInt32(Console.ReadLine());
CheckThird(number);