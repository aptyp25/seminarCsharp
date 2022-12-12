// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет. Не использовать string[]
// 
// 645 -> 5
// 
// 78 -> третьей цифры нет
// 
// 32679 -> 6

Console.WriteLine("Введите любое число");
// int a = int.Parse(Console.ReadLine());

bool isParsed = int.TryParse(Console.ReadLine(), out int number);

if (!isParsed)
{
    Console.WriteLine("То, что Вы ввели не есть целое число, запустите снова!");
    return;
}

if (number < 100 & number > -100){
    Console.WriteLine("Введите число минимум трехзначное");
    return;
}

int firstNumber = number / 10;

int secondNumber = firstNumber / 10;

int result = secondNumber % 10;

// int result = (number / 100) % 10;

Console.WriteLine(result);
