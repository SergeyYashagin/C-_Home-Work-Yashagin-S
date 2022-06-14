/* Задача 19: Напишите программу, которая принимает на
вход пятизначное число и проверяет, является ли оно
палиндромом.
14212 -> нет
23432 -> да
12821 -> да */

/* Console.WriteLine("Введите пятизначное число");
int N = int.Parse(Console.ReadLine());
int a1 = N % 10;             //последняя 
int a2 = (N % 100) / 10;      //предпоследняя
int b1 = (N / 1000) % 10;      //вторая
int b2 = N / 10000;             //первая

if (N < 9999 || N > 100000)
{
    Console.WriteLine("Не пятизначное число");
}
else if (a1 == b2 && a2 == b1)
{
    Console.WriteLine("Число полиндром");
}
else
{
    Console.WriteLine("Число не полиндром");
} */

///////////////////////////////////

/* Задача 21: Напишите программу, которая принимает на
вход координаты двух точек и находит расстояние между
ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

/* Console.WriteLine("Введите X1");
int X1=int.Parse(Console.ReadLine());

Console.WriteLine("Введите Y1");
int Y1=int.Parse(Console.ReadLine());

Console.WriteLine("Введите Z1");
int Z1=int.Parse(Console.ReadLine());

Console.WriteLine("Введите X2");
int X2=int.Parse(Console.ReadLine());

Console.WriteLine("Введите Y2");
int Y2=int.Parse(Console.ReadLine());

Console.WriteLine("Введите Z2");
int Z2=int.Parse(Console.ReadLine());

double dist=Math.Sqrt(Math.Pow(X1-X2,2)+Math.Pow(Y1-Y2,2)+Math.Pow(Z1-Z2,2));
Console.WriteLine(Math.Round(dist,2)); */

////////////////////////////

/* Задача 23: Напишите программу, которая принимает на
вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

/* Console.WriteLine("Введите N");
int N=int.Parse(Console.ReadLine());


for (int Count = 1; Count <= N ; Count++)
{
    Console.Write(Math.Pow(Count,3) + " ");
} */