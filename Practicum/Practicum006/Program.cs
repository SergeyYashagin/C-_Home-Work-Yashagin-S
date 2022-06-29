/* Задача 39: Напишите программу, которая перевернёт 
одномерный массив (последний элемент будет на первом 
месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6] */

/* void Print(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

int[] mass = new int[6];
for (int i = 0; i < mass.Length; i++)
{
    mass[i] = new Random().Next(0, 10);
}
Print(mass);

int save;
for (int i = 0; i < mass.Length / 2; i++)
{ */
    /*     save = mass[i];
        mass[i] = mass[mass.Length - 1 - i];
        mass[mass.Length - 1 - i] = save; */ ///// заменено кортежем строка снизу
/*     (mass[i], mass[mass.Length - 1 - i]) = (mass[mass.Length - 1 - i], mass[i]);
}

Print(mass); */

///////////////////////////////////////////
/* Задача 40: Напишите программу, которая принимает на вход три 
числа и проверяет, может ли существовать треугольник с сторонами 
такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника 
меньше суммы двух других сторон.
 */
/* Console.WriteLine("Введите N1");
int N1=int.Parse(Console.ReadLine());

Console.WriteLine("Введите N2");
int N2=int.Parse(Console.ReadLine());

Console.WriteLine("Введите N3");
int N3=int.Parse(Console.ReadLine());

if(N1+N2>N3 && N2+N3>N1 && N3+N1>N2)
{
    Console.Write("Треугольник может существовать");
}
else
{
    Console.Write("Треугольник не может существовать");
}
 */

/* Задача 42: Напишите программу, которая будет преобразовывать 
десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10 */

/* Console.WriteLine("Введите число 1");

int N = int.Parse(Console.ReadLine());

string res = String.Empty;

while(N>0)
{
    Console.Write(N%2);
    res = N%2 + res;
    N= N/2;
    
}
Console.WriteLine();
Console.WriteLine(res);
 */

/* Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());

int save = a;
int count = 0;
while (a > 0)
{
    a = a / 2;
    count++;
}

void Print(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

int[] mass = new int[count];

for (int i = 0; i < mass.Length; i++)
{
    mass[i] = save % 2;
    save = save / 2;
}
Print(mass);
Console.WriteLine();

int s;
for (int i = 0; i < mass.Length/2; i++)
{
    s = mass[i];
    mass[i] = mass[mass.Length - 1 - i];
    mass[mass.Length - 1 - i] = s;
}

Print(mass);
 */
/////////////////////////////////////////
    
/*   Задача 44: Не используя рекурсию, выведите первые N чисел 
Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8 */

/* Console.WriteLine("введи число ");
int a = int.Parse(Console.ReadLine());

int a1 = 0;
int a2 = 1;
int i = 0;
int sum = 0;

if (a < 2)
{
    Console.Write(a1 + " ");
}
else Console.WriteLine(a1 + " " + a2 + " ");
while (i < a - 2)
{
    sum = a1 + a2;
    a1 = a2;
    a2 = sum;
    Console.WriteLine(sum + " ");
    i++;
} */


/////////////////////////////////////////////
/* Задача 45: Напишите программу, которая будет создавать 
копию заданного массива с помощью поэлементного 
копирования.  */

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
    mass[i] = new Random().Next(0, 10);
}
Print(mass);

int[] newmass = new int[5];

for (int i = 0; i < mass.Length; i++)
{
    newmass[i] = mass[i];
}
Print(newmass);

int[] newnewmass = mass; // - неправильно, это ссылка на массив mass, а не копия
Print(newnewmass);

mass[3] = 10;
newnewmass[0] = 0;
Print(mass);
Print(newmass);
Print(newnewmass);
