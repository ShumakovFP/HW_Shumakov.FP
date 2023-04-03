// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введи цифру, обозначающую день недели: ");
int numDay = int.Parse(Console.ReadLine());

void CheckingDay (int numDay)
{
  if (numDay == 6 || numDay == 7) {
  Console.WriteLine("Этот день выходной");
  }
  else if (numDay < 1 || numDay > 7) {
    Console.WriteLine("Это вообще не день недели");
  }
  else Console.WriteLine("Этот день не выходной");
}

CheckingDay(numDay);
