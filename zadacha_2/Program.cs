// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Ввод данных:
Console.Write("Введите число:   ");
int number = Convert.ToInt32(Console.ReadLine());


if (number < 99) // Проверка наличия третьей цифры:
{
    Console.Write("В этом числе третьей цифры нет");
}
else
{
    // Преобразование числа в массив цифр:
    List<int> digits = new List<int>();
    while (number > 0)
    {
        int digit; //вводим дополнительную переменную
        number = Math.DivRem(number, 10, out digit); //Функция возвращает остаток частного т.е. выделяем последнюю цифру числа.
        digits.Add(digit); //остаток digit добавляем в массив digits. Массив digits - зеркальный.
    }
    digits.Reverse(); // Переворачиваем массив digits 

    //Выделение третьей цифры:
    Console.Write($"Третья цифра {digits[2]}");
    }
