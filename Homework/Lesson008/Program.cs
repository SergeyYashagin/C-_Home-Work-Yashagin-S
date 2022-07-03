/* Задача 54: Задайте двумерный массив. Напишите программу, которая
упорядочит по убыванию элементы каждой строки двумерного массива.
 */
/* void Print(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }

}
int m = 4, n = 4;
int[,] mass = new int[m, n];
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = new Random().Next(0, 10);
    }
}
Print(mass);
Console.WriteLine();

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
            for (int a = 0; a < mass.GetLength(1); a++)
            {
                if (mass[i,j] > mass[i, a])
                {
                    int temp;
                    temp = mass[i, j];
                    mass[i, j] = mass[i, a];
                    mass[i, a] = temp;
                }
            }
        }
     }

Print(mass); */

/* Задача 56: Задайте прямоугольный двумерный массив. Напишите
программу, которая будет находить строку с наименьшей суммой элементов.
 */

void Print(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }

}

int m = 3, n = 4;
int[,] mass = new int[m, n];
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = new Random().Next(0, 10);
    }
}

Print(mass);
Console.WriteLine();

int indexSum = 0;
int minSum = 9999999;

for (int i = 0; i < mass.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        sum = sum + mass[i, j];
    }
    if (sum <= minSum)
    {
        minSum = sum;
        indexSum=i+1;
    }
     
     Console.WriteLine( $"Строка: {i+1} Сумма: {sum}");
}
Console.Write("Строка с минимальной суммой: " +(indexSum));



/* Задача 58: Задайте две матрицы. Напишите программу, которая будет
находить произведение двух матриц.
 */


/* Задача 60: Сформируйте трёхмерный массив из неповторяющихся
двузначных чисел. Напишите программу, которая будет построчно выводить
массив, добавляя индексы каждого элемента. */


/* Задача 62: Заполните спирально массив 4 на 4. */