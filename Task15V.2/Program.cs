Console.WriteLine("Введите день недели (от 1 до 7)");

string[] array = {" ", "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Выходной", "Выходной"};
int n = array.Length;
int index = Convert.ToInt32(Console.ReadLine());

while (index < n && index > 0)
{
    Console.WriteLine(array[index]);
    break;
}
if (index <1 ^ index >7)
{
    Console.WriteLine("Нет такого дня недели");
}
