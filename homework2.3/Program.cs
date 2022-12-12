// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 
// 6 -> да
// 7 -> да
// 1 -> нет


Console.WriteLine("Введите любое число, желательно от 1 до 7");
// int a = int.Parse(Console.ReadLine());

bool isParsed = int.TryParse(Console.ReadLine(), out int number);

if (!isParsed)
{
    Console.WriteLine("То, что Вы ввели не есть целое число, запустите снова!");
    return;
}

if (number < 1 | number > 7){
    Console.WriteLine("Введите число от 1 до 7");
    return;
}

if (number == 1){
    Console.WriteLine("1 - это понедельник, это не выходной!");
}
if (number == 2){
    Console.WriteLine("2 - это вторник - это не выходной!");
}
if (number == 3){
    Console.WriteLine("3 - среда, это не выходной!");
}
if (number == 4){
    Console.WriteLine("4 - четверг, это не выходной!");
}
if (number == 5){
    Console.WriteLine("5 - пятница, это не выходной! но уже очень близко!");
}
if (number == 6){
    Console.WriteLine("6 - суббота! Ура, Выходные начались!");
}
if (number == 7){
    Console.WriteLine("7 - воскресенье! Это Выходной!");
}
