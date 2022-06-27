//Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

void CheckDay(int day)
{
     if (day >5 && day <7)
     {
        Console.WriteLine("Это выходной день");
     }
     else if (day == 1)
     {
        Console.WriteLine("Понедельник");
     }
     else if (day == 2)
     {
        Console.WriteLine("Вторник");
     }else if (day == 1)
     {
        Console.WriteLine("Понедельник");
     }else if (day == 3)
     {
        Console.WriteLine("Среда");
     }else if (day == 4)
     {
        Console.WriteLine("Четверг");
     }
     else if (day == 5)
     {
        Console.WriteLine("Пятница");
     }
     else
     {
        Console.WriteLine("НЕТ такого дня недели!");
     }
}
Console.WriteLine("Введите номер дня недели");
int number = Convert.ToInt32(Console.ReadLine());
CheckDay(number);

