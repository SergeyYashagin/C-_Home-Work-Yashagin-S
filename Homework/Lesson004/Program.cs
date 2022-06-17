/* Задача 25: Напишите цикл, который принимает на вход 
два числа (A и B) и возводит число A в натуральную 
степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

/* Console.WriteLine("Введите А");
int a=int.Parse(Console.ReadLine());
Console.WriteLine("Введите Б");
int b=int.Parse(Console.ReadLine());
int deg=1;

for(int i=1; i<=b; i++)
{
    deg=deg*a;
}
Console.WriteLine(deg); */

///////////////////////////////////

/* Задача 27: Напишите программу, которая принимает на 
вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

/* Console.WriteLine("Введите число");
int num=int.Parse(Console.ReadLine());
int sum=0;

while (num>0)
{
    sum=sum+num%10;
    num=num/10;
}
Console.WriteLine(sum); */

/////////////////////////////////

/* Задача 29: Напишите программу, которая задаёт массив 
из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] 
6, 1, 33 -> [6, 1, 33] */

/* int[] array=new int[8];
int i=0;

while (i < array.Length)
{
    array [i] =new Random().Next(0, 100);
    i++;
}
for (i=0; i < array.Length; i++)
{
    Console.Write(array[i]+" ");
} */