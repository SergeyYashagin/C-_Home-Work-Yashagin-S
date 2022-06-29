/* Задача 41: Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3 */

/* Console.WriteLine("Введите числа");
string M = Console.ReadLine();

string[] nums = M.Split(' ');

double count1 = 0;

for (double i = 0; i < nums.Length; i++)
{
    double num = double.Parse(nums[i]);
    if (num > 0)
    {
        count1++;
    }
}
Console.Write(count1); */


/* Задача 43. Напишите программу, которая найдёт точку
пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, 
y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

Console.WriteLine("Введите b1");
double b1=double.Parse(Console.ReadLine());

Console.WriteLine("Введите k1");
double k1=double.Parse(Console.ReadLine());

Console.WriteLine("Введите b2");
double b2=double.Parse(Console.ReadLine());

Console.WriteLine("Введите k2");
double k2=double.Parse(Console.ReadLine());

double x=1;
double y=1;

Console.WriteLine("x=" + (x=(b2-b1)/(k1-k2)));
Console.Write("y=" + (y=k1*(b2-b1)/(k1-k2)+b1));
