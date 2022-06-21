/* Задайте массив из 12 элементов, заполненный
случайными числами из промежутка [-9, 9]. Найдите сумму
отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
положительных чисел равна 29, сумма отрицательных равна
-20. */

/* void Print(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

int[] mass = new int[12];
for (int i = 0; i < mass.Length; i++)
{
    mass[i] = new Random().Next(-9, 10);
}
Print(mass);

int sumNeg = 0;
int sumPos = 0;
for (int i = 0; i < mass.Length; i++)
{
    if (mass[i] > 0)
    {
        sumPos += mass[i];
    }
    else
    {
        sumNeg += mass[i];
    }
}
Console.WriteLine(sumPos);
Console.WriteLine(sumNeg); */

/* Решение в группах задач:
Задача 32: Напишите программу замена элементов 
массива: положительные элементы замените на 
соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]  */

/* void Print(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

int[] mass = new int[12];
for (int i = 0; i < mass.Length; i++)
{
    mass[i] = new Random().Next(-9, 10);
}
Print(mass);

int[] mass1=mass;

for (int i = 0; i < mass1.Length; i++)
{
   Console.Write((mass[i]=mass[i]*-1) + " ");
} */

/* Задача 33: Задайте массив. Напишите программу, которая 
определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да */

/* void Print(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

int[] mass = new int[12];
for (int i = 0; i < mass.Length; i++)
{
    mass[i] = new Random().Next(-9, 10);
}
Print(mass);

Console.WriteLine("Введите число");
int a=int.Parse(Console.ReadLine());
bool b=("Совпадение не найдено");
for (int i = 0; i < mass.Length; i++)
{
    if(a==mass[i])
    {
        Console.WriteLine("Совпадение найдено");
        break;
    }   

} */
/* void print (int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

int[] mass = new int[10];
for (int i = 0; i < mass.Length; i++)
{
    mass[i] = new Random().Next(0, 10);
}
print(mass);

int find = 4;
int index = 0;

while (index < mass.Length)
{
    if (mass[index] == find)
    {
        Console.WriteLine("Элемент найден: " + mass[index]);
        break;
    }
    else if (index == mass.Length -1)
    {
        Console.WriteLine("Элемент не найден");
    }
    index++;
}
 */

/*  Задача 35: Задайте одномерный массив из 123 случайных чисел. 
Найдите количество элементов массива, значения которых лежат в 
отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 
123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5 */

/* void Print(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

int[] mass = new int[123];
for (int i = 0; i < mass.Length; i++)
{
    mass[i] = new Random().Next(0, 200);
}
Print(mass);

int count=0;

for (int i = 0; i < mass.Length; i++)
{
   if(mass[i]>10 & mass[i]<99)
   {
    count++;
   } 

}
Console.WriteLine(count); */

/* Задача 37: Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний 
и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21 */

void Print(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

int a = new Random().Next(2, 10);
int[] mass = new int[a];
for (int i = 0; i < mass.Length; i++)
{
    mass[i] = new Random().Next(0, 10);
}
Print(mass);

int b = 0;
int[] newmass;
if (mass.Length % 2 == 0)// чет 
{
    b = mass.Length / 2;
    newmass = new int[b];

    for (int i = 0; i < b; i++)
    {
        newmass[i] = mass[i] * mass[mass.Length - 1 - i];
    }
}
else
{
    b = mass.Length / 2;
    newmass = new int[b + 1];

    for (int i = 0; i < b; i++)
    {
        newmass[i] = mass[i] * mass[mass.Length - i - 1];
    }
    newmass[newmass.Length - 1] = mass[b];
}
Print(newmass);

/////////////////////

void Print(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

int[] mass = new int[5];

for (int i = 0; i < mass.Length; i++)
{
    mass[i] = new Random().Next(-9, 10);
}
Print(mass);

int pr = 1;
int j = 0;
int[] arr = new int[(mass.Length + 1) / 2];
arr[arr.Length - 1] = mass[mass.Length / 2];
while (j < mass.Length / 2)
{
    arr[j] = mass[j] * mass[mass.Length - j - 1];
    j++;
}

Print(arr);


