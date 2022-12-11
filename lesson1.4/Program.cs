// Напишите программу, которая на вход принимает одно число (N), 
// а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 2 -> " -2, -1, 0, 1, 2"

int number = int.Parse(Console.ReadLine());

int c;
int b;

if (number > 0){
b = - number;
c = number;
}
else{
    b=number;
    c=-number;
}
while (b <=c){
    Console.WriteLine(b);
    b++;
}
