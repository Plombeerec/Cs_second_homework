//Напишите программу, которая принимает на 
//вход трёхзначное число и на выходе показывает вторую цифру этого числа.

void FindSecondNumber(int n1)
{
    int result = (n1 - (n1/100)*100)/10;
    Console.WriteLine("Second number is " + result);

}

Console.WriteLine("Enter number");
int number = Convert.ToInt32(Console.ReadLine());
FindSecondNumber(number);