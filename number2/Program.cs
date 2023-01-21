//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a > 99 && a < 99999)
{
    int result =  a % 10 ;
    Console.WriteLine("Третья цифра числа: " + result );
}
else
{
    Console.WriteLine("Третье число отсутствует");
}