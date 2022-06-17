/* Задача 26: Напишите программу, которая принимает 
на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5 */

/* Console.WriteLine("Введите N");
int N=int.Parse(Console.ReadLine());

for (int count = 0;  0<N; count++)
{
    N=N/10;
} 
Console.WriteLine (N); */

///////////

/* Задача 28: Напишите программу, которая 
принимает на вход число N и выдаёт 
произведение чисел от 1 до N.
4 -> 24 
5 -> 120 */

/* Console.WriteLine("Введите N");
int N=int.Parse(Console.ReadLine());

int mult=1;
for(int i=1; i<=N; i++)
{
    mult*=i;
}
Console.WriteLine(mult); */

/* Задача 30: Напишите программу, которая 
выводит массив из 8 элементов, заполненный 
нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0] */

void PrintArray(int[] col)
{
    for (int i = 0; i < mass.Length; i++)
    {
         Console.Write(mass[i] + " ");
    }
    Console.WriteLine();
}

PrintArray(mass);

