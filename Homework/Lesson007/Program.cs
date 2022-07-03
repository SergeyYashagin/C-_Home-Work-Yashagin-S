/* Задача 47: Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
 */

/*  void Print(double[,] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            Console.Write(mass[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
int m = 3, n = 4;
double[,] mass = new double[m, n];
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = new Random().Next(-10, 10) + Math.Round(new Random().NextDouble(), 2);
    }
}

Print(mass); */

/* Задача 50: Напишите программу, которая на вход 
принимает позиции элемента в двумерном массиве, и 
возвращает значение этого элемента или же указание, 
что такого элемента нет
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

/* void Print(int[,] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            Console.Write(mass[i, j] + "\t");
        }
        Console.WriteLine();
    }

}

Console.WriteLine("Введите индекс строки массива");
int MassivLine = int.Parse(Console.ReadLine());

Console.WriteLine("Введите индекс столбца массива");
int MassivColumn = int.Parse(Console.ReadLine());

int m = 3, n = 4;
int[,] mass = new int[m, n];

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = new Random().Next(0, 10);



    }
}

if (MassivLine >= m && MassivColumn >= n)
{
    Console.WriteLine("Такого элемента нет");
}
else
{
    Console.WriteLine("Значение элемента: " + mass[MassivLine, MassivColumn]);
}

Print(mass); */


/* Задача 52: Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом 
столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого 
столбца: 4,6; 5,6; 3,6; 3.
 */

void Print(int[,] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            Console.Write(mass[i, j] + " ");
        }
        Console.WriteLine();
    }

}
int m = 5, n = 4;
int[,] mass = new int[m, n];
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = new Random().Next(0, 10);
    }
}

Print(mass);

double sum = 0;
double middle = 0;

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        sum += mass[j, i];
    }
    
    middle = sum / m;
    sum=0;
    Console.WriteLine("Среднее: " + Math.Round(middle, 2));
}





