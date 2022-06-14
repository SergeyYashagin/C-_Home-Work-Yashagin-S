/* Console.WriteLine("Введите X");
int X=int.Parse(Console.ReadLine());

Console.WriteLine("Введите Y");
int Y=int.Parse(Console.ReadLine());

if (X>0 && Y>0)
{
    Console.WriteLine("Первая Плоскость");
}
else if(X<0 && Y>0)
{

    Console.WriteLine("Вторая Плоскость");
}
else if(X<0 && Y<0)
{

    Console.WriteLine("Третья Плоскость");
}
else if(X>0 && Y<0)
{

    Console.WriteLine("Четвертая Плоскость");
}
else
{
    Console.WriteLine("Не принадлежит плоскости");
} */
//////////////

/* Задача 18: Напишите программу, которая по 
заданному номеру четверти, показывает диапазон 
возможных координат точек в этой четверти (x и y). */

/* Console.WriteLine("Введите номер четверти");
int A = int.Parse(Console.ReadLine());

if (A == 1)
{
    Console.WriteLine("X от 1 до бесконечности, Y от 1 до бесконечности ");
}
else if (A == 2)
{

    Console.WriteLine("X от -1 до бесконечности, Y от 1 до бесконечности");
}
else if (A == 3)
{

    Console.WriteLine("X от -1 до бесконечности, Y от -1 до бесконечности");
}
else if (A == 4)
{

    Console.WriteLine("X от 1 до бесконечности, Y от -1 до бесконечности");
}
else
{
    Console.WriteLine("Не существует");
} */
////////////////////////////

/* Задача 21: Напишите программу, которая 
принимает на вход координаты двух точек и 
находит расстояние между ними в 2D 
пространстве.
A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21 */

/* Console.WriteLine("Введите A1");
int A1=int.Parse(Console.ReadLine());

Console.WriteLine("Введите B1");
int B1=int.Parse(Console.ReadLine());

Console.WriteLine("Введите A2");
int A2=int.Parse(Console.ReadLine());

Console.WriteLine("Введите B2");
int B2=int.Parse(Console.ReadLine());

int dist=Math.Sqrt((Math.Pow(A2-A1),2)+Math.Pow((B2-B1),2));
Console.WriteLine(dist); */
////////////////////

/* Задача 22: Напишите программу, которая 
принимает на вход число (N) и выдаёт таблицу 
квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1,4 */

Console.WriteLine("Введите N");
int A1=int.Parse(Console.ReadLine());

