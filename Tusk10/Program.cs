// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.WriteLine("Введите трёхзначное число");
int number = int.Parse(Console.ReadLine());

if (number / 100 == 0 || number > 999)
{
    Console.WriteLine("Обманывать плохо!");
}
else
{
    int result = number % 100;
    Console.Write(result / 10);
}

