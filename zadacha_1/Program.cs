// Напишите программу, которая принимает на вход трёхзначное число и на 
// выходе показывает вторую цифру этого числа. 
// Не использовать строки для расчета.

// Ввод данных:
Console.Write("Введите трехзначное число:   ");
int number = Convert.ToInt32(Console.ReadLine());
//проверка на трехзначность
if (number < 99 || number > 1000)
{
    Console.WriteLine("Это число не трехзначное");
}
else
{
    int secondRank = number / 10 % 10;     // вторая цифра
    System.Console.WriteLine($"Вторая цифра числа {number} равна {secondRank}");
}



