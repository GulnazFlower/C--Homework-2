// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
if (number < 100) Console.WriteLine($"{number} -> третьей цифры нет");
if (number >= 100 & number < 1000)
{
    int thirdDigit = number % 10;
    Console.WriteLine($"{number} -> {thirdDigit}");
}
if (number >= 1000)
{
    int neededNumber = number;
    while (neededNumber >= 1000) 
    {
        neededNumber = neededNumber / 10;
    }
    int thirdDigit = neededNumber % 10;
    Console.WriteLine($"{number} -> {thirdDigit}");
}    