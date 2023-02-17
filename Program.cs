//Задача 4: Напишите программу, которая принимает на вход три числа 
//и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.WriteLine("Введите число a");
int a=int.Parse(Console.ReadLine()!);
Console.WriteLine ("Введите число b");
int b=int.Parse(Console.ReadLine()!);
Console.WriteLine ("Введите число c");
int c=int.Parse(Console.ReadLine()!);
if (a>b && a>c) Console.WriteLine($"Максимальное число a={a}");
else if (b>a && b>c) Console.WriteLine($"Максимальное число b={b}");
else if (c>a && c>b) Console.WriteLine($"Максимальное число c={c}");
else if (a==b && a==c && b==c) Console.WriteLine("Введенные чифры равны");

