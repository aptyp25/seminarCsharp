// Напишите программу, которая принимает на вход число и проверяет, 
// кратно ли оно одновременно 7 и 23. 14 -> нет 46 -> нет 161 -> да

Console.WriteLine("Введите первое число, отличное от нуля");
// int a = int.Parse(Console.ReadLine());

bool isParsed = int.TryParse(Console.ReadLine(), out int a);

if (!isParsed)
{
    Console.WriteLine("То, что Вы ввели не есть целое число, запустите снова!");
    return;
}

if (a % 7 == 0 & a%23 ==0)
{
    Console.WriteLine("Это число кратно одновременно 7ми и 23м");
}
else
{
    Console.WriteLine("Это число не кратно одновременно 7 и 23");
}

