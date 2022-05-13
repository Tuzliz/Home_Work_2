// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


int number = new Random().Next(100,1000);
string strr = number.ToString();

if (number > 100 && number < 1000)
{
    Console.WriteLine($"{number} -> {strr[2]}");
}
    

else if (number < 100)
    Console.WriteLine("третьей цифры нет");
