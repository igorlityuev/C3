using System.Numerics;
using System.Security.Cryptography;
using System.Security.Principal;



internal class Program
{

    private static void Main(string[] args)
    {
        //3.1
        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine(i + i * 3);
        }
        //3.2
        for (int i = 100; i < 1000; i++)
        {
            if (i % 15 == 0)
            {
                Console.WriteLine(i);
            }
        }
        //3.3

        int a = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i < 100; i++)
        {
            if (a % i == 0)
            {
                Console.WriteLine(i);
            }
        }
        //3.4
        int sum = 0;
        for (int i = 10; i <= 99; i++)
        {
            sum += i;

        }
        Console.WriteLine(sum);


        ////3.5
        int n = Convert.ToInt32(Console.ReadLine());
        int h = 1;
        string input = Console.ReadLine();

        List<long> list1 = input.Split(' ').Select(long.Parse).ToList();


        list1.Sort();
        for (int i = 0; i < n; i++)
        {
            if (h == list1[i])
            {
                h = (int)list1[i];
                Console.WriteLine(h);
            }
            else
            {
                Console.WriteLine(h);
                break;

            }
        }



        //3.6
        List<ulong> list = new List<ulong> { 0, 1 };
        for (int i = 0; i <= 100; i++)
        {
            list.Add(list[i] + list[i + 1]);

        }
        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine(list[i]);

        }


        //3.1 a
        int a5 = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; a5 > i; i++)
        {
            Console.Write("*-|");
        }


        //3.2 a 
        int a6 = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i < a6; i++)
        {
            if (i % 2 == 0)
            {
                for (int j = 0; j < i; j++)
                {

                    Console.Write("*");
                }
                Console.Write("--");

            }
            else
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");

                }
                Console.Write("||");
            }

        }
        //3.3 a

        int a7 = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < a7; i++)
        {
            if (i % 2 == 0)
            {
                for (int j = 0; j < i; j++)
                {

                    Console.Write("-");
                }
                Console.Write("*");

            }
            else
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("|");

                }
                Console.Write("*");
            }

        }

        //3.4 a

        int nene = Convert.ToInt32(Console.ReadLine());
        int mid = nene / 2;

        for (int i = 0; i < nene; i++)
        {
            for (int j = 0; j < Math.Abs(mid - i); j++)
                Console.Write(" ");
            Console.Write("*");

            if ((nene - 2 * Math.Abs(mid - i)) > 1)
            {
                for (int j = 0; j < (nene - 2 * Math.Abs(mid - i)) - 2; j++)
                    Console.Write(" ");
                Console.Write("*");
            }

            Console.WriteLine();
        }

        //3.5 a

        int a9 = Convert.ToInt32(Console.ReadLine());
        int midd = (a9 / 2);
        for (int i = 0; i < a9; i++)
        {
            for (int j = 0; j < a9; j++)
            {
                if (j == midd)
                {

                    Console.Write("*");
                }
                else if (i == midd)
                {
                    Console.Write("-");

                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
        //3.6 a
        int a10 = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < a10; i++)
        {
            for (int j = 0; j < a10; j++)
            {
                if (j == (a10 - 1 - i))
                {

                    Console.Write("?");
                }
                else if (j == i)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }


        //3.7 a



        int a11 = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= a11; i++)
        {
            for (int j = 1; j <= a11; j++)
            {
                if (i == 1 || i == a11 || j == 1 || j == a11 || (i == (a11 / 2 + 1) && j == (a11 / 2 + 1)))
                {

                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }

        //3.1 b 
        for (int i = 0; i < 30; i++)
        {
            Console.Write(i + " ");

        }

        //3.2 b
        for (int i = 0; i < 1000; i++)
        {
            if (Math.Pow(i, 2) % 2 != 0)
            {

                Console.Write(Math.Pow(i, 2) + " ");
            }

        }


        //3.3 b
        for (int i = 1000; i < 10000; i++)
        {
            if (i % 379 == 0)
            {

                Console.Write(i);
            }

        }
        //3.4 b
        for (int i = 100; i < 1000; i++)
        {
            if (i % 5 == 0 || i % 6 == 0 || i % 11 == 0)
            {

                Console.Write(i);
            }

        }


        //3.5 b
        int suma = 0;
        for (int i = 0; i < Convert.ToInt32(Console.ReadLine()); i++)
        {
            int b = Convert.ToInt32((Console.ReadLine()));
            suma += b;
        }
        Console.WriteLine(suma);


        //3.6 b 
        int suma1 = 0;
        for (int i = 0; i < Convert.ToInt32(Console.ReadLine()); i++)
        {
            int b = Convert.ToInt32((Console.ReadLine()));
            suma1 += i * 2;

        }
        Console.WriteLine(suma1);

        //3.7 b
        int suma2 = 0;
        for (int i = 11; i < Convert.ToInt32(Console.ReadLine()); i++)
        {
            if (i % 2 == 1)
            {
                suma2 += i;
            }

        }
        Console.WriteLine(suma2);


        //3.8 b

        for (double i = 1; i <= 1000; i++)
        {
            if (i % 10 == Math.Sqrt(i))
            {
                Console.WriteLine(i);
            }
        }

    }
}
