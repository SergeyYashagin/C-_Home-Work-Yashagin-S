/* Задача 53: Задайте двумерный массив. Напишите программу, 
которая поменяет местами первую и последнюю строку 
массива. */

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
int element = 0;
  
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            element = mass[0, j];
            mass[0, j] = mass[mass.GetLength(0)-1, j];
            mass[mass.GetLength(0)-1, j] = element;
            //Console.Write(mass[0, j] + " ");
            //Console.Write(mass[mass.GetLength(0)-1, j] + " ");
        }
        Console.WriteLine();
   
Print(mass); */

/* Задача 55: Задайте двумерный массив. Напишите программу, 
которая заменяет строки на столбцы. В случае, если это 
невозможно, программа должна вывести сообщение для 
пользователя. */

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

int element = 0;

if (mass.GetLength(0) == mass.GetLength(1))
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = i+1; j < mass.GetLength(1); j++)
        {
            element = mass[i, j];
            mass[i, j] = mass[j, i];
            mass[j, i] = element;
        }
        Console.WriteLine();
    }
}
else Console.Write("НЕТ");
Print(mass);  */

/* Задача 57: Составить частотный словарь элементов 
двумерного массива. Частотный словарь содержит 
информацию о том, сколько раз встречается элемент 
входных данных.
Набор данных Частотный массив
{ 1, 9, 9, 0, 2, 8, 0, 9 } 0 встречается 2 раза 
1 встречается 1 раз 
2 встречается 1 раз 
8 встречается 1 раз 
9 встречается 3 раза
1, 2, 3 
4, 6, 1 
2, 1, 6
1 встречается 3 раза 
2 встречается 2 раз 
3 встречается 1 раз 
4 встречается 1 раз 
6 встречается 2 раза */

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
int counterrr = 0;
Console.WriteLine("ВВеди число для поиска ");
int A = int.Parse(Console.ReadLine());
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        if (mass[i,j] == A)
        {
            counterrr++;
        }
    }
}
Console.WriteLine("Совпадений: " + counterrr);
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

int count = 0;
int a = 0;
int[] uniq = new int[mass.Length];
int k = 0;
bool finded = false;
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {


        finded = false;
        for (int l = 0; l < k; l++)
        {
            if (mass[i, j] == uniq[l])
                finded = true;
        }
        if (!finded)
        {
            uniq[k] = mass[i, j];
            k++;
        }
    }
}

for (int j = 0; j < k; j++)
{
    Console.Write(uniq[j] + " ");
}
Console.WriteLine();

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        if (mass[i, j] == a)
        {
            count++;
        };
    }
}

Console.WriteLine(count);
for (int z = 0; z < k; z++)
{
    count = 0;
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            if (mass[i, j] == uniq[z])
            {
                count++;
            };
        }
    }

    Console.WriteLine(uniq[z] + " встречается " + count);
}
 */


/* Задача 59: Задайтедвумерный массив из целых чисел. 
Напишите программу, которая удалит строку и столбец, на 
пересечении которых расположен наименьший элемент 
массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим 
следующий массив:
9 4 2
2 2 6
3 4 7 */

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

int min = mass[0,0];
int minx = 0;
int miny = 0;


for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        if ( mass[i, j] < min)
        {
        
        min = mass[i, j];
        minx = i;
        miny = j;
        }
    }
}

 for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
           if (i != minx && j != miny)
            Console.Write(mass[i, j] + " ");
        }
        if (i != minx)
        Console.WriteLine();
    }