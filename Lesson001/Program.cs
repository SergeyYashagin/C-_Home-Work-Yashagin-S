/* Задача 2: Напишите программу, которая на вход
принимает два числа и выдаёт, какое число большее, а
какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */

/* Console.WriteLine("Введите число А");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B");
int b = int.Parse(Console.ReadLine());
if (a > b)
{
    Console.Write("max");
    Console.WriteLine(a);
    Console.Write("min");
    Console.WriteLine(b);
}
else
{
    Console.Write("max");
    Console.WriteLine(b);
    Console.Write("min");
    Console.WriteLine(a);
} */
///////////////////////////////////////

/* Задача 4: Напишите программу, которая принимает на
вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */

/* Console.WriteLine("Введите число А");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число C");
int c = int.Parse(Console.ReadLine());

if(a>b & a>c)
{
    Console.WriteLine("max");
    Console.WriteLine(a);
}
else if(b>a & b>c)
{
    Console.WriteLine("max");
    Console.WriteLine(b);
}
else if(c>a & c>b)
{
    Console.WriteLine("max");
    Console.WriteLine(c);
} */

////////////////////////////////////

/* Задача 6: Напишите программу, которая на вход
принимает число и выдаёт, является ли число чётным
(делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет */

/* Console.WriteLine("Введите число А");
int a = int.Parse(Console.ReadLine());
int b=a%2;

if(b>0)
{
    Console.WriteLine("Не четное");
}
else
{
    Console.WriteLine("Четное");
} */

/////////////////////////////////

/* Задача 8: Напишите программу, которая на вход
принимает число (N), а на выходе показывает все чётные
числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8 */

Console.WriteLine("Введите число N");
int N = int.Parse(Console.ReadLine());
int A=2;

    while(A<=N)
    {
    Console.WriteLine(A);
    A+=2;
    }
