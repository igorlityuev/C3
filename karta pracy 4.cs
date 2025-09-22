using System;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    //4.1 + 4.2
    public static int Sum(int x, int len)
    {
        int sum = 0;

        for (int i = 1; i <= len; i++)
        {

            sum += x % (10 * i);
        }


        return sum;
    }
    private static void Main(string[] args)
    {
        string e = Console.ReadLine();
        int len = e.Length;
        int x = Convert.ToInt32(e);
        Console.WriteLine(Sum(x, len));
    }



    //4.3+4.1

    public static int Sil(int t)
    {
        int sum = 1;
        for (int i = 1; t >= i; i++)
        {
            sum *= i;
        }
        return sum;
    }


    private static void Main(string[] args)
    {
        Console.WriteLine(Sil(Convert.ToInt32(Console.ReadLine())));
    }

    //4.1+4.4

    public static int Fibo(int n)
    {
        if (n <= 1)
        {

            return 1;
        }
        else
        {
            return (Fibo(n - 1) + Fibo(n - 2));
        }
    }

    private static void Main(string[] args)
    {
        Console.WriteLine(Fibo(Convert.ToInt32(Console.ReadLine())));
    }


    //4.6 + 4.1 

    public static int Pow(int x)
    {
        int sum = x;
        for (int i = 1; i < x; i++)
        {
            sum *= x;
        }
        return sum;
    }
    private static void Main(string[] args)
    {
        Console.WriteLine(Pow(Convert.ToInt32(Console.ReadLine())));
    }



}
