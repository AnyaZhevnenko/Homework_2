// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// int number = ReadInt("Введите трехзначное число: ");
// int amount = number.ToString().Length;

// if (amount < 3 || amount > 3)
// {
//     Console.WriteLine("Вы ввели не трехзначное число");
// }
// else
// {
//     Console.WriteLine(InCenter(number));
// }
// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// // Функция вывода цифры стоящей в середине трехзначногно числа.
// int InCenter(int a)
// {
    
//     int result = ((a / 10) % 10);
//     return result;
// }

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// int Prompt(string msg)
// {

// System.Console.WriteLine($"{msg}");
// return Convert.ToInt32(Console.ReadLine());
// }
// int number = Prompt("Введите число");

// int fnumber(int number)
// {
// while (number > 999)
// {
// number /= 10;
// }
// return number % 10;
// }

// bool check(int number)
// {
// if (number < 100)
// return false;
// else return true;
// }

// if (check(number) != true)
// System.Console.WriteLine("Третьей цифры нет");
// else
// System.Console.WriteLine($"Третья цифра числа {number} является {fnumber(number)}");