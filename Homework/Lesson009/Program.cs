/* Задача 64: Задайте значения M и N. Напишите программу, которая выведет все
натуральные числа в промежутке от M до N.
M = 1; N = 5. -> "1, 2, 3, 4, 5"
M = 4; N = 8. -> "4, 5, 6, 7, 8"
M = 8; N = 4. -> "8, 7, 6, 5, 4" */

/* int Rec(int m, int n)
{
    if (n < m)
    {
        Console.Write(m + " ");
        return
        Rec((m - 1), n);
    }

    else if (n > m)
    {
        Console.Write(m + " ");
        return
        Rec((m + 1), n);
    }
    else if (n == m)
    {
        Console.Write(n);
        return n;
    }
    return n;

}
int N = 1, M = 6;
Rec(M, N); */


/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

/* int Rec(int m, int n)
{
    if (n == m)
    {
        return n;
    }
    return m + Rec(m + 1, n);
}
int N = 6, M = 4;
Console.Write(Rec(M, N)); */


/* Задача 68: Напишите программу вычисления функции Аккермана с помощью
рекурсии. Даны два неотрицательных числа m и n.
m = 3, n = 2 -> A(m,n) = 29 */
int Rec(int m, int n)
{
    if (m==0)
    {
        
        return n+1;
    }
    else if(n==0 && m>0)
    {
        
        return Rec(m-1,1);
    }
    else if(n>0 && m>0)
    {
        
        return Rec(m-1, Rec(m,n-1));
    }
    else
    return -1;
}
int N = 5, M = 3;
Console.Write(Rec(M, N));