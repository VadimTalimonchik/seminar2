// Напишите программу, которая принимает на вход 
// два числа и проверяет, является ли одно число 
// квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

// Вариант 1
// Console.WriteLine("Введите первое число: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите второе число: ");
// int b = int.Parse(Console.ReadLine()!);

// if(a * a == b || b * b == a)
// {
//     Console.WriteLine("Одно из чисел ЯВЛЯЕТСЯ квадратом для другого");
// }
// else
// {
//     Console.WriteLine("Одно из чисел НЕ ЯВЛЯЕТСЯ квадратом для другого");
// }

// Вариант 2
Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);

if(a * a == b)
{
    Console.WriteLine($"Число {b} является квадратом числа {a}");
}
else if(b * b == a)
{
    Console.WriteLine($"Число {a} является квадратом числа {b}");
}
else
{
    Console.WriteLine("Ни одно из чисел не является квадратом для другого");
}